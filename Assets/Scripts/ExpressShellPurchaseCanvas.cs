using UnityEngine;
public class ExpressShellPurchaseCanvas : MonoBehaviour
{
    // Fields
    private ExpressShellPurchaseCanvas.OnShellsUpdatedDelegate OnShellsUpdated;
    private static ExpressShellPurchaseCanvas m_Instance;
    private AdPlayerWithDelegate m_AdPlayer;
    private UnityEngine.UI.Text m_ShellsText;
    
    // Properties
    public static ExpressShellPurchaseCanvas Instance { get; }
    public static bool Exists { get; }
    
    // Methods
    public void add_OnShellsUpdated(ExpressShellPurchaseCanvas.OnShellsUpdatedDelegate value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.OnShellsUpdated, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.OnShellsUpdated != 1152921529018281368);
    
    }
    public void remove_OnShellsUpdated(ExpressShellPurchaseCanvas.OnShellsUpdatedDelegate value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.OnShellsUpdated, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.OnShellsUpdated != 1152921529018417944);
    
    }
    public static ExpressShellPurchaseCanvas get_Instance()
    {
        ExpressShellPurchaseCanvas val_5 = ExpressShellPurchaseCanvas.m_Instance;
        if(0 != val_5)
        {
                return (ExpressShellPurchaseCanvas)ExpressShellPurchaseCanvas.m_Instance;
        }
        
        ExpressShellPurchaseCanvas.m_Instance = UnityEngine.Object.Instantiate<ExpressShellPurchaseCanvas>(original:  UnityEngine.Resources.Load<ExpressShellPurchaseCanvas>(path:  "DynamicUI/Express Purchase - Shells"));
        val_5 = ExpressShellPurchaseCanvas.m_Instance.gameObject;
        val_5.SetActive(value:  false);
        return (ExpressShellPurchaseCanvas)ExpressShellPurchaseCanvas.m_Instance;
    }
    private void OnEnable()
    {
        var val_2;
        mem[1152921529018723248] = this;
        mem[1152921529018723256] = System.Void ExpressShellPurchaseCanvas::ShellsUpdated(int _shells);
        mem[1152921529018723232] = System.Void ExpressShellPurchaseCanvas::ShellsUpdated(int _shells);
        this.add_OnShellsUpdated(value:  new ExpressShellPurchaseCanvas.OnShellsUpdatedDelegate());
        val_2 = null;
        val_2 = null;
        GGPPurchasingManager.OnPurchaseSuccess.AddListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void ExpressShellPurchaseCanvas::OnPurchaseDone(IAPItemIds _ID)));
    }
    private void OnDisable()
    {
        var val_3;
        this.remove_OnShellsUpdated(value:  this.OnShellsUpdated);
        if(GGPPurchasingManager.instance == null)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        GGPPurchasingManager.OnPurchaseSuccess.RemoveListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void ExpressShellPurchaseCanvas::OnPurchaseDone(IAPItemIds _ID)));
    }
    public static bool IsNoShellAndShowExpressPurchase()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.Shells;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})) > 0)
        {
                val_4 = 0;
            return (bool)val_4;
        }
        
        ExpressShellPurchaseCanvas.Show();
        val_4 = 1;
        return (bool)val_4;
    }
    public static void Show()
    {
        var val_11;
        UnityEngine.Object val_12;
        ExpressShellPurchaseCanvas val_1 = ExpressShellPurchaseCanvas.Instance;
        val_11 = null;
        val_11 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Items.Shells;
        string val_3 = val_2.currentCryptoKey.ToString();
        ExpressShellPurchaseCanvas.Instance.gameObject.SetActive(value:  true);
        val_12 = ExpressShellPurchaseCanvas.Instance.transform.GetChild(index:  0);
        if(0 == val_12)
        {
                return;
        }
        
        val_12 = val_12.gameObject;
        val_12.SetActive(value:  true);
    }
    public void PlayAd()
    {
        this.m_AdPlayer.Setup(_onPlayDoneAction:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ExpressShellPurchaseCanvas::Reward()), _onPlayFailAction:  0, _isAdPlayingReturnWithOnPlayFail:  false);
        this.m_AdPlayer.PlayAd();
    }
    private void Reward()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.Shells;
        int val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
        val_2 = val_2 + 1;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_2);
        DataStructs.UserDataDictionary.Items.Shells = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = DataStructs.UserDataDictionary.Items.Shells;
        ExpressShellPurchaseCanvas.UpdateShells(_shells:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited}));
    }
    private void ShellsUpdated(int _shells)
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public static bool get_Exists()
    {
        return UnityEngine.Object.op_Inequality(x:  0, y:  ExpressShellPurchaseCanvas.m_Instance);
    }
    public static void UpdateShells(int _shells)
    {
        if(null == 0)
        {
                return;
        }
        
        Invoke(_shells:  _shells);
    }
    private void OnPurchaseDone(IAPItemIds _ID)
    {
        var val_4;
        if((_ID & 4294967292) != 36)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Items.Shells;
        ExpressShellPurchaseCanvas.UpdateShells(_shells:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited}));
    }
    public ExpressShellPurchaseCanvas()
    {
    
    }

}
