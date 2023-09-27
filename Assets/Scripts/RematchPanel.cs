using UnityEngine;
public class RematchPanel : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Image Image;
    public bool ForceNoShells;
    public InkWars.Model.Controller_Network_Message DebugReceiveMessage;
    public System.Collections.Generic.List<UnityEngine.UI.Text> OtherPlayerName;
    public InkWars.Model.Controller_Network_Message LastMessage;
    public System.Collections.Generic.List<UnityEngine.GameObject> State_WaitingForResponse;
    public System.Collections.Generic.List<UnityEngine.GameObject> State_AskedForRematch_CharacterSelect;
    public System.Collections.Generic.List<UnityEngine.GameObject> State_AskedForRematch_SameCharacters;
    public System.Collections.Generic.List<UnityEngine.GameObject> State_YouNeedToTopUp;
    public System.Collections.Generic.List<UnityEngine.GameObject> State_TheyNeedToTopUp;
    public System.Collections.Generic.List<UnityEngine.GameObject> State_YouHaveToppedUp;
    public System.Collections.Generic.List<UnityEngine.GameObject> State_TheyHaveToppedUp;
    private System.Collections.Generic.List<UnityEngine.GameObject> CleanUpObjects;
    private static RematchPanel _instance;
    
    // Properties
    public static RematchPanel Instance { get; }
    public bool HasShells { get; }
    
    // Methods
    public static RematchPanel get_Instance()
    {
        if(RematchPanel._instance != 0)
        {
                return (RematchPanel)RematchPanel._instance;
        }
        
        RematchPanel._instance = UnityEngine.Object.FindObjectOfType<RematchPanel>();
        return (RematchPanel)RematchPanel._instance;
    }
    public bool get_HasShells()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.Shells;
        return (bool)((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})) > 0) ? 1 : 0;
    }
    private void Awake()
    {
        List.Enumerator<T> val_1 = this.OtherPlayerName.GetEnumerator();
        label_5:
        if(((-1370643976) & 1) == 0)
        {
            goto label_2;
        }
        
        NetworkUserInfo val_3 = CloudOpponent.current;
        if(0.InitialType != null)
        {
            goto label_5;
        }
        
        goto label_5;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Text>::Dispose(), rectTransform:  null, drivenProperties:  null);
        this.AddCleanupObjects(state:  this.State_WaitingForResponse);
        this.AddCleanupObjects(state:  this.State_AskedForRematch_CharacterSelect);
        this.AddCleanupObjects(state:  this.State_AskedForRematch_SameCharacters);
        this.AddCleanupObjects(state:  this.State_YouNeedToTopUp);
        this.AddCleanupObjects(state:  this.State_TheyNeedToTopUp);
        this.AddCleanupObjects(state:  this.State_YouHaveToppedUp);
        this.AddCleanupObjects(state:  this.State_TheyHaveToppedUp);
        this.CleanUp();
    }
    private void SetAllActive(System.Collections.Generic.List<UnityEngine.GameObject> objects)
    {
        this.Image.enabled = true;
        List.Enumerator<T> val_1 = objects.GetEnumerator();
        label_5:
        if(((-1370474616) & 1) == 0)
        {
            goto label_3;
        }
        
        0.InitialType.SetActive(value:  true);
        goto label_5;
        label_3:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.GameObject>::Dispose(), rectTransform:  0, drivenProperties:  null);
    }
    private void CleanUp()
    {
        System.Collections.Generic.List<UnityEngine.GameObject> val_3;
        this.Image.enabled = false;
        val_3 = this.CleanUpObjects;
        List.Enumerator<T> val_1 = val_3.GetEnumerator();
        label_5:
        if(((-1370338040) & 1) == 0)
        {
            goto label_3;
        }
        
        0.InitialType.SetActive(value:  false);
        goto label_5;
        label_3:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.GameObject>::Dispose(), rectTransform:  0, drivenProperties:  null);
    }
    private void AddCleanupObjects(System.Collections.Generic.List<UnityEngine.GameObject> state)
    {
        var val_4 = this;
        List.Enumerator<T> val_1 = state.GetEnumerator();
        label_6:
        if(((-1370196376) & 1) == 0)
        {
            goto label_2;
        }
        
        System.Type val_2 = 0.InitialType;
        if((this.CleanUpObjects.Contains(item:  val_2)) == true)
        {
            goto label_6;
        }
        
        this.CleanUpObjects.Add(item:  val_2);
        goto label_6;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.GameObject>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    private void OnEnable()
    {
        InkWars.Model.Model_Events.Instance.add_OnMessageReceived(value:  new Model_Events.ControllerNetworkMessageDelegate(object:  this, method:  System.Void RematchPanel::OnMessageReceived(InkWars.Model.Controller_Network_Message message)));
    }
    private void OnDisable()
    {
        if(InkWars.Model.Model_Events.Instance == 0)
        {
                return;
        }
        
        InkWars.Model.Model_Events.Instance.remove_OnMessageReceived(value:  new Model_Events.ControllerNetworkMessageDelegate(object:  this, method:  System.Void RematchPanel::OnMessageReceived(InkWars.Model.Controller_Network_Message message)));
    }
    public void SendNetworkMessage(InkWars.Model.Controller_Network_Message message, bool showWaitingMessage)
    {
        if(showWaitingMessage != false)
        {
                this.CleanUp();
            this.SetAllActive(objects:  this.State_WaitingForResponse);
        }
        
        if((message | 2) == 3)
        {
                InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.OnLocalPlayerLocked();
        }
        
        InkWars.Model.Model_Events.Instance.SendNetworkMessage(message:  message);
    }
    private void OnMessageReceived(InkWars.Model.Controller_Network_Message message)
    {
        if(InkWars.Model.MVC_Multiplayer_Manager_Base.Instance == 0)
        {
                return;
        }
        
        this.CleanUp();
        if((message - 1) <= 7)
        {
                var val_9 = 40824648 + ((message - 1)) << 2;
            val_9 = val_9 + 40824648;
        }
        else
        {
                this.LastMessage = message;
        }
    
    }
    public void SyncState()
    {
        InkWars.Model.Controller_Network_NF.Instance.SetMultiplayerState(state:  InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.State);
    }
    public void ButtonYes()
    {
        InkWars.Model.Controller_Network_Message val_3;
        var val_4;
        if(ExpressShellPurchaseCanvas.IsNoShellAndShowExpressPurchase() != false)
        {
                return;
        }
        
        this.CleanUp();
        if(this.HasShells == false)
        {
            goto label_1;
        }
        
        if(this.LastMessage == 1)
        {
            goto label_2;
        }
        
        if(this.LastMessage != 2)
        {
                return;
        }
        
        val_3 = 4;
        goto label_4;
        label_1:
        this.SetAllActive(objects:  this.State_YouNeedToTopUp);
        val_3 = 7;
        val_4 = 0;
        goto label_5;
        label_2:
        val_3 = 3;
        label_4:
        val_4 = 1;
        label_5:
        this.SendNetworkMessage(message:  val_3, showWaitingMessage:  true);
    }
    public void ButtonNo()
    {
        var val_1;
        this.CleanUp();
        if(this.LastMessage != 1)
        {
                if(this.LastMessage != 2)
        {
                return;
        }
        
            val_1 = 6;
        }
        else
        {
                val_1 = 5;
        }
        
        this.SendNetworkMessage(message:  5, showWaitingMessage:  false);
    }
    public void TopUpShells()
    {
        this.ForceNoShells = false;
        this.CleanUp();
        this.SetAllActive(objects:  this.State_YouHaveToppedUp);
        this.SendNetworkMessage(message:  8, showWaitingMessage:  false);
    }
    public RematchPanel()
    {
        this.CleanUpObjects = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
