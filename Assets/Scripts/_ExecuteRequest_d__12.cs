using UnityEngine;
private sealed class HttpNetworkingExecutor.<ExecuteRequest>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.Networking.UnityWebRequest www;
    public UnityEngine.Events.UnityAction<IResponse> callback;
    public System.Threading.Tasks.TaskCompletionSource<IResponse> task;
    private IResponse <response>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HttpNetworkingExecutor.<ExecuteRequest>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 3)
        {
                return;
        }
        
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        UnityEngine.Networking.UnityWebRequest val_15;
        var val_16;
        System.Action<System.Boolean, System.String> val_18;
        int val_19;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 1)
        {
            goto label_2;
        }
        
        this.<>1__state = -3;
        if(this.www.isNetworkError == false)
        {
            goto label_4;
        }
        
        new IResponse() = new IResponse(statusCode:  this.www.responseCode, msg:  this.www.error);
        this.<response>5__2 = new IResponse();
        val_15 = this.www;
        UnityEngine.Debug.LogError(message:  System.String.Format(format:  "{0} {1}", arg0:  this.www.error, arg1:  val_15.uri));
        val_16 = null;
        val_16 = null;
        val_18 = HttpNetworkingExecutor.<>c.<>9__12_0;
        if(val_18 == null)
        {
                val_18 = null;
            val_18 = new System.Action<System.Boolean, System.String>(object:  HttpNetworkingExecutor.<>c.__il2cppRuntimeField_static_fields, method:  System.Void HttpNetworkingExecutor.<>c::<ExecuteRequest>b__12_0(bool has, string msg));
            HttpNetworkingExecutor.<>c.<>9__12_0 = val_18;
        }
        
        ConnectionTester.TestConnection(callback:  null);
        goto label_18;
        label_1:
        this.<>1__state = 0;
        val_15 = new IResponse();
        val_15 = new IResponse();
        this.<response>5__2 = val_15;
        this.<>1__state = -3;
        this.<>2__current = this.www.SendWebRequest();
        val_19 = 1;
        this.<>1__state = val_19;
        return (bool)val_19;
        label_4:
        UnityEngine.Networking.DownloadHandler val_12 = this.www.downloadHandler;
        if(val_12 != null)
        {
                val_15 = val_12.text;
        }
        else
        {
                val_15 = 0;
        }
        
        new IResponse() = new IResponse(statusCode:  this.www.responseCode, msg:  val_15);
        this.<response>5__2 = new IResponse();
        label_18:
        this.<>m__Finally1();
        label_2:
        val_19 = 0;
        return (bool)val_19;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        if(this.callback != null)
        {
                this.callback.Invoke(arg0:  this.<response>5__2);
        }
        
        if(this.task == null)
        {
                return;
        }
        
        this.task.SetResult(result:  this.<response>5__2);
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
