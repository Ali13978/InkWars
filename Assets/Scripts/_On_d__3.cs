using UnityEngine;
private sealed class Stream.<On>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Collections.Generic.Dictionary<string, string> APIParams;
    public Twitter.Stream <>4__this;
    public Twitter.TwitterStreamCallback callback;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Stream.<On>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        var val_16;
        int val_17;
        var val_18;
        val_16 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_16;
        }
        
        this.<>1__state = 0;
        UnityEngine.WWWForm val_2 = new UnityEngine.WWWForm();
        Dictionary.Enumerator<TKey, TValue> val_3 = this.APIParams.GetEnumerator();
        label_6:
        if(((-1203677168) & 1) == 0)
        {
            goto label_4;
        }
        
        UnityEngine.Playables.PlayableHandle val_7 = val_6.GetHandle();
        val_2.AddField(fieldName:  val_7.m_Handle.ToInt64(), value:  val_7.m_Handle);
        goto label_6;
        label_1:
        val_17 = 0;
        goto label_7;
        label_4:
        val_6.Add(driver:  public System.Void Dictionary.Enumerator<System.String, System.String>::Dispose(), rectTransform:  null, drivenProperties:  null);
        if((this.<>4__this) != null)
        {
            goto label_8;
        }
        
        goto label_15;
        label_8:
        UnityEngine.Networking.UnityWebRequest val_9 = UnityEngine.Networking.UnityWebRequest.Post(uri:  this.<>4__this.REQUEST_URL, formData:  val_2);
        var val_10 = (this.<>4__this + 16) + 8;
        mem2[0] = val_9;
        if(val_9 != null)
        {
            goto label_19;
        }
        
        label_20:
        label_19:
        val_9.SetRequestHeader(name:  "ContentType", value:  "application/x-www-form-urlencoded");
        if((this.<>4__this) == null)
        {
            goto label_17;
        }
        
        val_18 = mem[(this.<>4__this + 16 + 8)];
        val_18 = val_10;
        goto label_18;
        label_15:
        mem[24] = UnityEngine.Networking.UnityWebRequest.Post(uri:  11993091, formData:  val_2);
        if(mem[24] != 0)
        {
            goto label_19;
        }
        
        goto label_20;
        label_17:
        val_18 = mem[(this.<>4__this + 16 + 8)];
        val_18 = val_10;
        label_18:
        val_18.SetRequestHeader(name:  "Authorization", value:  Twitter.Oauth.GenerateHeaderWithAccessToken(parameters:  Twitter.Helper.ConvertToSortedDictionary(APIParams:  this.APIParams), requestMethod:  "POST", requestURL:  this.<>4__this + 16));
        .callback = this.callback;
        val_10.downloadHandler = new Twitter.StreamingDownloadHandler();
        this.<>2__current = val_10.Send();
        val_17 = 1;
        val_16 = 1;
        label_7:
        this.<>1__state = val_17;
        return (bool)val_16;
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
