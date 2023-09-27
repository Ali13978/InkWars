using UnityEngine;
public class NetworkLobbyCloseButton : MonoBehaviour
{
    // Fields
    public bool shutDownNetowrk;
    public bool reloadScene;
    public bool disableWhenClick;
    private UnityEngine.UI.Button btn;
    
    // Methods
    private void Awake()
    {
        this.btn = this.GetComponent<UnityEngine.UI.Button>();
    }
    private void OnEnable()
    {
        this.btn.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkLobbyCloseButton::OnClick()));
    }
    private void OnDisable()
    {
        UnityEngine.Events.UnityAction val_2 = 1152921504859136000;
        val_2 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkLobbyCloseButton::OnClick());
        this.btn.onClick.RemoveListener(call:  val_2);
    }
    private void OnClick()
    {
        if(this.disableWhenClick != false)
        {
                this.btn.interactable = false;
        }
        
        if(this.shutDownNetowrk == false)
        {
                return;
        }
        
        InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.ShutdownNetwork(forceAutoStart:  false, couldBeRageQuit:  false, reloadScene:  (this.reloadScene == true) ? 1 : 0, delay:  0f, notifyUser:  true);
        NFUser.current.clientUser.LeaveRoom(callback:  0);
    }
    public NetworkLobbyCloseButton()
    {
        this.shutDownNetowrk = true;
        this.reloadScene = true;
        this.disableWhenClick = true;
    }

}
