using UnityEngine;
public class PostMatchRematchPanel : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject acceptInvitationPanel;
    private UnityEngine.GameObject declinePanel;
    private UnityEngine.GameObject waitingPanel;
    private UnityEngine.GameObject returningToLobbyPanel;
    private UnityEngine.GameObject wagerSelectionPanel;
    private UnityEngine.UI.Text m_returningtoLobbyText;
    private UnityEngine.UI.Button accept;
    private UnityEngine.UI.Button cancel;
    private RematchProgressBar acceptInvProBar;
    private UnityEngine.UI.Text InvOpponnentUserName;
    private UnityEngine.UI.Text WaitingOpponnentUserName;
    private UnityEngine.UI.Text declineInvUserName;
    private UnityEngine.UI.Button backButton;
    private UnityEngine.UI.Button wagerSelectionOkButton;
    private RematchProgressBar wagerSelectionProBar;
    private PostMatchRematchPanel.RematchStates _rematchState;
    
    // Properties
    public PostMatchRematchPanel.RematchStates RematchState { get; set; }
    
    // Methods
    public PostMatchRematchPanel.RematchStates get_RematchState()
    {
        return (RematchStates)this._rematchState;
    }
    public void set_RematchState(PostMatchRematchPanel.RematchStates value)
    {
        bool val_12;
        this.acceptInvitationPanel.gameObject.SetActive(value:  false);
        this.declinePanel.gameObject.SetActive(value:  false);
        this.wagerSelectionPanel.gameObject.SetActive(value:  false);
        this.waitingPanel.gameObject.SetActive(value:  false);
        this.returningToLobbyPanel.gameObject.SetActive(value:  false);
        val_12 = true;
        this.acceptInvProBar.stop = val_12;
        this.wagerSelectionProBar.stop = val_12;
        if(value <= 4)
        {
                var val_12 = 40824432 + (value) << 2;
            val_12 = val_12 + 40824432;
        }
        else
        {
                this._rematchState = value;
        }
    
    }
    private void Update()
    {
        var val_1;
        var val_3;
        val_1 = null;
        val_1 = null;
        if(InkWars.Model.MVC_Multiplayer_Manager_Base.OtherPlayerHasClickedNo == false)
        {
            goto label_3;
        }
        
        if(this._rematchState != 3)
        {
                return;
        }
        
        label_15:
        this.RematchState = 1;
        return;
        label_3:
        val_1 = null;
        if(InkWars.Model.MVC_Multiplayer_Manager_Base.OtherPlayerHasClickedYes == false)
        {
                return;
        }
        
        if(InkWars.Model.MVC_Multiplayer_Manager_Base.HasClickedYes == false)
        {
                return;
        }
        
        if(this._rematchState != 3)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(PostMatchCanvas.IsPublicMatch == false)
        {
            goto label_14;
        }
        
        goto label_15;
        label_14:
        this.StartRematch();
    }
    private void StartRematch()
    {
        this.gameObject.SetActive(value:  false);
        InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.State = 1;
    }
    public void GotoLobby()
    {
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void PostMatchRematchPanel::OnBackToLobbyReloadScene(UnityEngine.SceneManagement.Scene sceneLoaded, UnityEngine.SceneManagement.LoadSceneMode loadMode)));
        if(InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch != false)
        {
                UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            AsyncSceneLoader.Load(sceneName:  val_3.m_Handle.name, minimumDelayInSeconds:  0f, showLoadingScreen:  false, autoHideLoadingScreen:  true);
        }
        else
        {
                InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.ShutdownNetwork(forceAutoStart:  false, couldBeRageQuit:  false, reloadScene:  true, delay:  0f, notifyUser:  true);
        }
        
        this.returningToLobbyPanel.gameObject.SetActive(value:  true);
        this.m_returningtoLobbyText.gameObject.SetActive(value:  true);
        this.gameObject.SetActive(value:  false);
    }
    private void OnBackToLobbyReloadScene(UnityEngine.SceneManagement.Scene sceneLoaded, UnityEngine.SceneManagement.LoadSceneMode loadMode)
    {
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void PostMatchRematchPanel::OnBackToLobbyReloadScene(UnityEngine.SceneManagement.Scene sceneLoaded, UnityEngine.SceneManagement.LoadSceneMode loadMode)));
        PostMatchCanvas.Hide();
    }
    public void OnClickedWagerSelected()
    {
        this.wagerSelectionProBar.stop = true;
        this.StartRematch();
    }
    private void OnEnable()
    {
        object[] val_1 = new object[3];
        val_1[0] = "<color=#f39232FF>";
        NetworkUserInfo val_2 = CloudOpponent.current;
        val_1[1] = val_2.userName;
        val_1[2] = "</color>";
        string val_3 = LanguageManager.GetTextFormat(key:  "LK.Rematch.Invitation", list:  val_1);
        object[] val_4 = new object[3];
        val_4[0] = "<color=#f39232FF>";
        NetworkUserInfo val_5 = CloudOpponent.current;
        val_4[1] = val_5.userName;
        val_4[2] = "</color>";
        string val_6 = LanguageManager.GetTextFormat(key:  "LK.Rematch.Waiting", list:  val_4);
        NetworkUserInfo val_7 = CloudOpponent.current;
        string val_10 = System.String.Format(format:  "<color=#f39232FF>{0}</color>\r\n{1}", arg0:  val_7.userName, arg1:  LanguageManager.GetTextFormat(key:  "LK.Rematch.Decline", list:  System.Array.Empty<System.Object>()));
        this.accept.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PostMatchRematchPanel::AcceptInvitation()));
        this.cancel.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PostMatchRematchPanel::DeclineInvitation()));
        this.backButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void PostMatchRematchPanel::GotoLobby()));
        this.wagerSelectionOkButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void PostMatchRematchPanel::OnClickedWagerSelected()));
        this.RematchState = 0;
    }
    private void OnDisable()
    {
        this.accept.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PostMatchRematchPanel::AcceptInvitation()));
        this.cancel.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PostMatchRematchPanel::DeclineInvitation()));
        this.backButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void PostMatchRematchPanel::GotoLobby()));
        this.wagerSelectionOkButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void PostMatchRematchPanel::OnClickedWagerSelected()));
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void PostMatchRematchPanel::OnBackToLobbyReloadScene(UnityEngine.SceneManagement.Scene sceneLoaded, UnityEngine.SceneManagement.LoadSceneMode loadMode)));
    }
    private void AcceptInvitation()
    {
        var val_2;
        InkWars.Model.Model_Events.Instance.SendNetworkMessage(message:  12);
        val_2 = null;
        val_2 = null;
        InkWars.Model.MVC_Multiplayer_Manager_Base.HasClickedYes = true;
        this.RematchState = 3;
    }
    private void DeclineInvitation()
    {
        InkWars.Model.Model_Events.Instance.SendNetworkMessage(message:  13);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.GotoLobbyWait());
    }
    private System.Collections.IEnumerator GotoLobbyWait()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new PostMatchRematchPanel.<GotoLobbyWait>d__29();
    }
    public PostMatchRematchPanel()
    {
    
    }
    private void <set_RematchState>b__18_0()
    {
        InkWars.Model.Model_Events.Instance.SendNetworkMessage(message:  13);
        this.GotoLobby();
    }

}
