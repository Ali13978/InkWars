using UnityEngine;
public class OfflineTitleScreenBar : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject internetAvailableIndicator;
    private UnityEngine.GameObject internetNotAvailableIndicator;
    private UnityEngine.UI.Button loginButton;
    private float interval;
    private string url;
    
    // Methods
    private void OnEnable()
    {
        this.loginButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void OfflineTitleScreenBar::OnClickLogin()));
    }
    private void OnDiable()
    {
        this.loginButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void OfflineTitleScreenBar::OnClickLogin()));
    }
    private void OnClickLogin()
    {
        var val_2;
        UnityEngine.Events.UnityAction val_4;
        val_2 = null;
        val_2 = null;
        val_4 = OfflineTitleScreenBar.<>c.<>9__6_0;
        if(val_4 == null)
        {
                UnityEngine.Events.UnityAction val_1 = null;
            val_4 = val_1;
            val_1 = new UnityEngine.Events.UnityAction(object:  OfflineTitleScreenBar.<>c.__il2cppRuntimeField_static_fields, method:  System.Void OfflineTitleScreenBar.<>c::<OnClickLogin>b__6_0());
            OfflineTitleScreenBar.<>c.<>9__6_0 = val_4;
        }
        
        GameVersionCheck.CheckGameVersion(OnDone:  val_1, showLoadingWhenProc:  false);
    }
    public string GetHtmlFromUri(string resource)
    {
        string val_12;
        var val_13;
        System.IO.StreamReader val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        bool val_19;
        var val_21;
        var val_22;
        val_12 = mem[static_value_032D1378 + 184];
        val_12 = static_value_032D1378 + 184;
        System.Net.WebRequest val_1 = System.Net.WebRequest.Create(requestUriString:  resource);
        val_13 = 0;
        if((0 > 298) || (0 < 200))
        {
            goto label_41;
        }
        
        val_14 = new System.IO.StreamReader();
        val_14 = new System.IO.StreamReader(stream:  0);
        char[] val_6 = new char[80];
        if(val_6.Length >= 1)
        {
                do
        {
            long val_12 = 0;
            string val_7 = val_12 + val_6[0];
            val_12 = val_12 + 1;
        }
        while(val_12 < val_6.Length);
        
        }
        else
        {
                val_15 = val_12;
        }
        
        val_16 = 0;
        val_17 = 0;
        val_12 = val_15;
        if(val_14 != null)
        {
            goto label_18;
        }
        
        goto label_35;
        label_29:
        val_18 = val_6;
        val_19 = X0;
        goto label_55;
        label_18:
        var val_13 = 0;
        val_13 = val_13 + 1;
        new System.IO.StreamReader().Dispose();
        label_35:
        if( == 1)
        {
            goto label_41;
        }
        
        var val_9 = (155 == 155) ? 1 : 0;
        val_9 = (( >= 0) ? 1 : 0) & val_9;
        val_9 =  - val_9;
        val_9 = val_9 + 1;
        val_21 = (long)val_9;
        goto label_42;
        label_41:
        val_21 = 0;
        label_42:
        if((1 & 1) != 0)
        {
                return val_12;
        }
        
        val_14 = 0;
        var val_16 = 1179403647;
        if(mem[282584257676957] == 0)
        {
            goto label_47;
        }
        
        var val_14 = mem[282584257676847];
        var val_15 = 0;
        val_14 = val_14 + 8;
        label_46:
        if(((mem[282584257676847] + 8) + -8) == null)
        {
            goto label_45;
        }
        
        val_15 = val_15 + 1;
        val_14 = val_14 + 16;
        if(val_15 < mem[282584257676957])
        {
            goto label_46;
        }
        
        goto label_47;
        label_45:
        val_16 = val_16 + (((mem[282584257676847] + 8)) << 4);
        val_22 = val_16 + 296;
        label_47:
        0.Dispose();
        if(val_14 == 0)
        {
                return val_12;
        }
        
        return val_12;
        label_55:
        if(val_18 != 2)
        {
            goto label_29;
        }
        
        if((null & 1) != 0)
        {
                return val_12;
        }
        
        mem[8] = val_19;
        goto label_29;
    }
    private System.Collections.IEnumerator checkInternetConnection(System.Action<bool> action)
    {
        OfflineTitleScreenBar.<checkInternetConnection>d__9 val_1 = new OfflineTitleScreenBar.<checkInternetConnection>d__9();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .action = action;
        return (System.Collections.IEnumerator)val_1;
    }
    private void FetchRemote(System.Action<bool> action)
    {
        .action = action;
        AzureRemoteConfig.FetchRemote(callback:  new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  new OfflineTitleScreenBar.<>c__DisplayClass10_0(), method:  System.Void OfflineTitleScreenBar.<>c__DisplayClass10_0::<FetchRemote>b__0(bool success, string info)));
    }
    private void Start()
    {
        MainThreadDispatcher.Init();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.checkInternetConnection(action:  new System.Action<System.Boolean>(object:  this, method:  System.Void OfflineTitleScreenBar::<Start>b__11_0(bool isConnected))));
    }
    public OfflineTitleScreenBar()
    {
        this.interval = 3f;
        this.url = "I used a google docs page with one character here";
    }
    private void <Start>b__11_0(bool isConnected)
    {
        var val_6;
        var val_7;
        UnityEngine.GameObject val_1 = this.internetAvailableIndicator.gameObject;
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(isConnected == false)
        {
            goto label_2;
        }
        
        label_8:
        val_1.SetActive(value:  true);
        this.internetNotAvailableIndicator.gameObject.SetActive(value:  false);
        val_6 = this.loginButton.gameObject;
        val_7 = 1;
        goto label_7;
        label_1:
        if(isConnected == true)
        {
            goto label_8;
        }
        
        label_2:
        val_1.SetActive(value:  false);
        this.internetNotAvailableIndicator.gameObject.SetActive(value:  true);
        val_6 = this.loginButton.gameObject;
        val_7 = 0;
        label_7:
        val_6.SetActive(value:  false);
    }

}
