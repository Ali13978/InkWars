using UnityEngine;
private class MMOCClientUser.MMOCLoginListener : MonoBehaviour
{
    // Fields
    private static MMOCClientUser.MMOCLoginListener _listener;
    private UnityEngine.Events.UnityAction<bool, string> OnLogin;
    private int retryCount;
    private string lastURL;
    
    // Properties
    public static MMOCClientUser.MMOCLoginListener instance { get; }
    
    // Methods
    public static MMOCClientUser.MMOCLoginListener get_instance()
    {
        var val_4;
        MMOCClientUser.MMOCLoginListener val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = MMOCClientUser.MMOCLoginListener._listener;
        if(0 == val_5)
        {
                UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "MMOC Login Listener");
            UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
            val_6 = null;
            val_5 = val_2.AddComponent<MMOCLoginListener>();
            val_6 = null;
            MMOCClientUser.MMOCLoginListener._listener = val_5;
        }
        
        val_7 = null;
        val_7 = null;
        return (MMOCLoginListener)MMOCClientUser.MMOCLoginListener._listener;
    }
    public void ListenToLoginCallback(UnityEngine.Events.UnityAction<bool, string> OnLoginCallback)
    {
        this.OnLogin = OnLoginCallback;
    }
    private void Start()
    {
        ImaginationOverflow.UniversalDeepLinking.DeepLinkManager.Instance.add_LinkActivated(value:  new ImaginationOverflow.UniversalDeepLinking.LinkActivationHandler(object:  this, method:  System.Void MMOCClientUser.MMOCLoginListener::Instance_LinkActivated(ImaginationOverflow.UniversalDeepLinking.LinkActivation s)));
    }
    private void Instance_LinkActivated(ImaginationOverflow.UniversalDeepLinking.LinkActivation s)
    {
        object val_9;
        string val_1 = s.Uri;
        if((System.String.IsNullOrWhiteSpace(value:  val_1)) == false)
        {
            goto label_2;
        }
        
        val_9 = "Url is empty or null";
        goto label_11;
        label_2:
        if((val_1.Contains(value:  "/MMOC/Auth")) == false)
        {
            goto label_7;
        }
        
        if((System.String.op_Equality(a:  this.lastURL, b:  val_1)) == false)
        {
            goto label_8;
        }
        
        val_9 = "Url is already used";
        goto label_11;
        label_7:
        val_9 = "Url is not for MMOC Login";
        label_11:
        UnityEngine.Debug.Log(message:  val_9);
        return;
        label_8:
        this.lastURL = val_1;
        bool val_5 = val_1.Contains(value:  "code=");
        object[] val_7 = new object[2];
        val_7[0] = val_5;
        val_7[1] = val_1;
        UnityEngine.Debug.LogFormat(format:  "{0} {1}", args:  val_7);
        this.OnLogin.Invoke(arg0:  val_5, arg1:  val_1);
    }
    public MMOCClientUser.MMOCLoginListener()
    {
    
    }
    private static MMOCClientUser.MMOCLoginListener()
    {
    
    }

}
