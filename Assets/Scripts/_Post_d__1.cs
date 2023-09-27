using UnityEngine;
private sealed class Client.<Post>d__1 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string APIPath;
    public System.Collections.Generic.Dictionary<string, string> APIParams;
    public Twitter.TwitterCallback callback;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Client.<Post>d__1(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_12;
        var val_33;
        int val_34;
        UnityEngine.WWWForm val_35;
        System.Collections.Generic.Dictionary<System.String, System.String> val_36;
        var val_37;
        var val_38;
        val_33 = 0;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        val_34 = 0;
        goto label_59;
        label_1:
        if((this.<>1__state) != 0)
        {
                return (bool)val_33;
        }
        
        this.<>1__state = 0;
        System.Collections.Generic.List<System.String> val_2 = new System.Collections.Generic.List<System.String>();
        if(val_2 != null)
        {
                val_2.Add(item:  "media/upload");
        }
        else
        {
                val_2.Add(item:  "media/upload");
        }
        
        val_2.Add(item:  "account/update_profile_image");
        if(val_2 != null)
        {
                val_2.Add(item:  "account/update_profile_banner");
        }
        else
        {
                val_2.Add(item:  "account/update_profile_banner");
        }
        
        val_2.Add(item:  "account/update_profile_background_image");
        string val_5 = ((this.APIPath.Contains(value:  "media/")) != true) ? "https://upload.twitter.com/1.1/" : "https://api.twitter.com/1.1/"(((this.APIPath.Contains(value:  "media/")) != true) ? "https://upload.twitter.com/1.1/" : "https://api.twitter.com/1.1/") + this.APIPath + ".json";
        UnityEngine.WWWForm val_6 = null;
        val_35 = val_6;
        val_6 = new UnityEngine.WWWForm();
        System.Collections.Generic.SortedDictionary<System.String, System.String> val_7 = new System.Collections.Generic.SortedDictionary<System.String, System.String>();
        val_36 = this.APIParams;
        if((val_2.IndexOf(item:  this.APIPath)) == 1)
        {
            goto label_10;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_9 = val_36.GetEnumerator();
        val_37 = 1152921524788523968;
        val_38 = 1152921511506689568;
        label_30:
        if(((-1206492272) & 1) == 0)
        {
            goto label_12;
        }
        
        UnityEngine.Playables.PlayableHandle val_13 = val_12.GetHandle();
        if((val_13.m_Handle.ToInt64().Contains(value:  "media")) == false)
        {
            goto label_14;
        }
        
        val_6.AddBinaryData(fieldName:  "media", contents:  System.Convert.FromBase64String(s:  val_13.m_Handle), fileName:  "", mimeType:  "");
        goto label_30;
        label_14:
        if((System.String.op_Equality(a:  val_13.m_Handle.ToInt64(), b:  "image")) == false)
        {
            goto label_19;
        }
        
        val_6.AddBinaryData(fieldName:  "image", contents:  System.Convert.FromBase64String(s:  val_13.m_Handle), fileName:  "", mimeType:  "");
        goto label_30;
        label_19:
        if((System.String.op_Equality(a:  val_13.m_Handle.ToInt64(), b:  "banner")) == false)
        {
            goto label_24;
        }
        
        val_6.AddBinaryData(fieldName:  "banner", contents:  System.Convert.FromBase64String(s:  val_13.m_Handle), fileName:  "", mimeType:  "");
        goto label_30;
        label_24:
        val_6.AddField(fieldName:  val_13.m_Handle.ToInt64(), value:  val_13.m_Handle);
        goto label_30;
        label_10:
        System.Collections.Generic.SortedDictionary<System.String, System.String> val_24 = Twitter.Helper.ConvertToSortedDictionary(APIParams:  val_36);
        val_36 = this.APIParams;
        Dictionary.Enumerator<TKey, TValue> val_25 = val_36.GetEnumerator();
        val_37 = 1152921524788523968;
        val_38 = 1152921511506689568;
        label_34:
        if(((-1206492272) & 1) == 0)
        {
            goto label_32;
        }
        
        UnityEngine.Playables.PlayableHandle val_26 = val_12.GetHandle();
        val_6.AddField(fieldName:  val_26.m_Handle.ToInt64(), value:  val_26.m_Handle);
        goto label_34;
        label_12:
        val_12.Add(driver:  public System.Void Dictionary.Enumerator<System.String, System.String>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<System.String>::IndexOf(System.String item), drivenProperties:  0);
        goto label_61;
        label_32:
        val_12.Add(driver:  public System.Void Dictionary.Enumerator<System.String, System.String>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<System.String>::IndexOf(System.String item), drivenProperties:  0);
        val_35 = UnityEngine.Networking.UnityWebRequest.Post(uri:  val_5, formData:  val_6);
        val_35.SetRequestHeader(name:  "ContentType", value:  "application/x-www-form-urlencoded");
        this.<>2__current = Twitter.Client.SendRequest(request:  val_35, parameters:  val_24, method:  "POST", requestURL:  val_5, callback:  this.callback);
        val_33 = 1;
        val_34 = 2;
        goto label_59;
        label_61:
        this.<>2__current = Twitter.Client.SendRequest(request:  UnityEngine.Networking.UnityWebRequest.Post(uri:  val_5, formData:  val_6), parameters:  val_24, method:  "POST", requestURL:  val_5, callback:  this.callback);
        val_34 = 1;
        val_33 = 1;
        label_59:
        this.<>1__state = val_34;
        return (bool)val_33;
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
