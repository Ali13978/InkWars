using UnityEngine;
public class HttpNetworkingExecutor : MonoBehaviour
{
    // Fields
    public const string MasterServer = "https://snation1.inkwarsesport.com/";
    public static readonly string VERSION;
    public static readonly string RemoteConfigUri;
    private static HttpNetworkingExecutor _instance;
    
    // Properties
    public static string HOST { get; }
    public static HttpNetworkingExecutor Instance { get; }
    
    // Methods
    public static string get_HOST()
    {
        GameServerInfo val_2 = NFUser.current.Server;
        if(val_2.IP == null)
        {
                return "https://snation1.inkwarsesport.com/";
        }
        
        GameServerInfo val_4 = NFUser.current.Server;
        if(NFUser.current.Server != null)
        {
                return val_4.protocol + "://"("://") + val_6.IP;
        }
        
        return val_4.protocol + "://"("://") + val_6.IP;
    }
    public static HttpNetworkingExecutor get_Instance()
    {
        var val_4;
        HttpNetworkingExecutor val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        val_5 = HttpNetworkingExecutor._instance;
        if(0 != val_5)
        {
                val_6 = null;
            val_6 = null;
            return (HttpNetworkingExecutor)HttpNetworkingExecutor._instance;
        }
        
        val_6 = null;
        val_5 = new UnityEngine.GameObject(name:  "HttpNetworkingExecutor").AddComponent<HttpNetworkingExecutor>();
        val_6 = null;
        HttpNetworkingExecutor._instance = val_5;
        return (HttpNetworkingExecutor)HttpNetworkingExecutor._instance;
    }
    private void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    public void Get(string apiUrl, NFClientUser authUser, UnityEngine.Events.UnityAction<IResponse> callback, bool buildUrl = True)
    {
        System.String[] val_8;
        string val_9;
        string val_10;
        val_8 = buildUrl;
        val_9 = authUser;
        val_10 = apiUrl;
        if(val_8 != false)
        {
                string[] val_1 = new string[5];
            val_8 = val_1;
            val_8[0] = HttpNetworkingExecutor.HOST;
            val_8[1] = "/";
            val_8[2] = HttpNetworkingExecutor.VERSION;
            val_8[3] = "/";
            val_8[4] = val_10;
            val_10 = +val_1;
        }
        
        UnityEngine.Networking.UnityWebRequest val_4 = UnityEngine.Networking.UnityWebRequest.Get(uri:  val_10);
        if(val_9 != null)
        {
                val_9 = val_9.JWT_TOKEN;
            val_4.SetRequestHeader(name:  "jwt", value:  val_9);
        }
        
        UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  val_4.ExecuteRequest(www:  val_4, callback:  callback, task:  0));
    }
    public void Post(string apiUrl, NFClientUser authUser, object data, UnityEngine.Events.UnityAction<IResponse> callback, bool buildUrl = True)
    {
        string val_12;
        string val_13;
        string val_14;
        var val_15;
        val_13 = authUser;
        val_14 = apiUrl;
        if(buildUrl == true)
        {
            goto label_1;
        }
        
        if(data == null)
        {
            goto label_2;
        }
        
        label_25:
        val_15 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  data);
        goto label_5;
        label_1:
        string[] val_2 = new string[5];
        val_2[0] = HttpNetworkingExecutor.HOST;
        val_2[1] = "/";
        val_2[2] = HttpNetworkingExecutor.VERSION;
        val_12 = "/";
        val_2[3] = val_12;
        val_2[4] = val_14;
        val_14 = +val_2;
        if(data != null)
        {
            goto label_25;
        }
        
        label_2:
        val_15 = "{}";
        label_5:
        UnityEngine.Networking.UnityWebRequest val_5 = new UnityEngine.Networking.UnityWebRequest(url:  val_14, method:  "POST");
        val_5.uploadHandler = new UnityEngine.Networking.UploadHandlerRaw(data:  System.Text.Encoding.UTF8);
        UnityEngine.Networking.DownloadHandlerBuffer val_8 = new UnityEngine.Networking.DownloadHandlerBuffer();
        if(val_5 != null)
        {
                val_5.downloadHandler = val_8;
        }
        else
        {
                val_5.downloadHandler = val_8;
        }
        
        val_5.SetRequestHeader(name:  "Content-Type", value:  "application/json");
        if(val_13 != null)
        {
                val_13 = val_13.JWT_TOKEN;
            val_5.SetRequestHeader(name:  "jwt", value:  val_13);
        }
        
        UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  val_5.ExecuteRequest(www:  val_5, callback:  callback, task:  0));
    }
    public System.Threading.Tasks.Task<IResponse> ExecuteAsyncRequest(UnityEngine.Networking.UnityWebRequest www)
    {
        System.Threading.Tasks.TaskCompletionSource<IResponse> val_1 = new System.Threading.Tasks.TaskCompletionSource<IResponse>();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  val_1.ExecuteRequest(www:  www, callback:  0, task:  val_1));
        if(val_1 != null)
        {
                return val_1.Task;
        }
        
        return val_1.Task;
    }
    public System.Collections.IEnumerator ExecuteRequest(UnityEngine.Networking.UnityWebRequest www, UnityEngine.Events.UnityAction<IResponse> callback, System.Threading.Tasks.TaskCompletionSource<IResponse> task)
    {
        HttpNetworkingExecutor.<ExecuteRequest>d__12 val_1 = new HttpNetworkingExecutor.<ExecuteRequest>d__12();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .www = www;
            .callback = callback;
        }
        else
        {
                mem[32] = www;
            mem[40] = callback;
        }
        
        .task = task;
        return (System.Collections.IEnumerator)val_1;
    }
    public static T HttpResponseToCustomResponse<T>(IResponse response)
    {
        var val_5;
        string val_6;
        var val_7;
        val_5 = __RuntimeMethodHiddenParam + 48;
        if(val_5 != 0)
        {
                val_6 = val_5;
            mem2[0] = "Unknown Error";
        }
        else
        {
                val_6 = 16;
            mem[16] = "Unknown Error";
        }
        
        mem2[0] = 404;
        if(response == null)
        {
            goto label_3;
        }
        
        mem2[0] = response.statusCode;
        if((response + 24) != 200)
        {
            goto label_4;
        }
        
        val_6 = response.msg;
        UnityEngine.Debug.Log(message:  val_6);
        if((System.String.IsNullOrWhiteSpace(value:  response.msg)) != true)
        {
                val_5 = response.msg;
            if(response.msg == null)
        {
            goto label_13;
        }
        
        }
        
        label_26:
        mem2[0] = response + 24;
        return (IResponse)val_5;
        label_3:
        mem[16] = "No Http Response";
        mem2[0] = 404;
        UnityEngine.Debug.LogError(message:  "Http Response Error: No Http Response.");
        return (IResponse)val_5;
        label_4:
        mem[16] = "Error Code " + response + 24.ToString()(response + 24.ToString()) + " " + response.msg;
        return (IResponse)val_5;
        label_13:
        val_7 = response.msg;
        if((__RuntimeMethodHiddenParam + 48 + 16) != 1)
        {
            goto label_14;
        }
        
        if((null & 1) == 0)
        {
            goto label_15;
        }
        
        object[] val_4 = new object[2];
        val_4[0] = 1152921504623673344;
        val_4[1] = response.msg;
        UnityEngine.Debug.LogErrorFormat(format:  "Parse response data to JSON fail: {0}. Source: {1}", args:  val_4);
        goto label_26;
        label_15:
        mem[8] = null;
        val_7 = 8;
        label_14:
    }
    public static T BestHttpResponseToCustomResponse<T>(BestHTTP.HTTPResponse response)
    {
        string val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_15 = __RuntimeMethodHiddenParam;
        val_16 = __RuntimeMethodHiddenParam + 48;
        if(val_16 != 0)
        {
                val_17 = val_16;
            mem2[0] = "Unknown Error";
        }
        else
        {
                val_17 = 16;
            mem[16] = "Unknown Error";
        }
        
        mem2[0] = 404;
        if(response == null)
        {
            goto label_3;
        }
        
        mem2[0] = (long)response.StatusCode;
        if(response.StatusCode != 200)
        {
            goto label_4;
        }
        
        UnityEngine.Debug.Log(message:  response.DataAsText);
        if((System.String.IsNullOrWhiteSpace(value:  response.DataAsText)) == false)
        {
            goto label_7;
        }
        
        label_29:
        val_18 = response;
        int val_6 = val_18.StatusCode;
        goto label_8;
        label_3:
        mem[16] = "No Http Response";
        mem2[0] = 404;
        UnityEngine.Debug.LogError(message:  "Http Response Error: No Http Response.");
        return (JoinedPoolData)val_16;
        label_4:
        val_15 = response.StatusCode.ToString();
        mem[16] = "Error Code " + val_15 + " " + response.DataAsText;
        return (JoinedPoolData)val_16;
        label_7:
        val_15 = response.DataAsText;
        val_18 = response;
        if(val_15 == null)
        {
            goto label_16;
        }
        
        val_16 = val_15;
        label_8:
        mem2[0] = (long)val_18.StatusCode;
        return (JoinedPoolData)val_16;
        label_16:
        val_19 = 0;
        if(0 != 1)
        {
            goto label_17;
        }
        
        if((null & 1) == 0)
        {
            goto label_18;
        }
        
        object[] val_13 = new object[2];
        val_13[0] = 1179403647;
        val_13[1] = response.DataAsText;
        UnityEngine.Debug.LogErrorFormat(format:  "Parse response data to JSON fail: {0}. Source: {1}", args:  val_13);
        goto label_29;
        label_18:
        mem[8] = 1179403647;
        val_19 = 8;
        label_17:
    }
    public HttpNetworkingExecutor()
    {
    
    }
    private static HttpNetworkingExecutor()
    {
        HttpNetworkingExecutor.VERSION = "v1";
        HttpNetworkingExecutor.RemoteConfigUri = "https://snation1.inkwarsesport.com//"("https://snation1.inkwarsesport.com//") + HttpNetworkingExecutor.VERSION + "/config?region=ASIA"("/config?region=ASIA");
    }

}
