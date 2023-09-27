using UnityEngine;
private sealed class Reporter.<readInfo>d__188 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Reporter <>4__this;
    private UnityEngine.Networking.UnityWebRequest <www>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Reporter.<readInfo>d__188(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_16;
        string val_17;
        int val_18;
        string val_19;
        val_16 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_17 = "build_info";
        if((IndexOf(value:  "://")) == 1)
        {
            goto label_4;
        }
        
        label_19:
        if((Contains(value:  "://")) != true)
        {
                val_17 = "file://"("file://") + val_17;
        }
        
        UnityEngine.Networking.UnityWebRequest val_4 = UnityEngine.Networking.UnityWebRequest.Get(uri:  val_17);
        this.<www>5__2 = val_4;
        this.<>2__current = val_4.SendWebRequest();
        val_18 = 1;
        this.<>1__state = val_18;
        return (bool)val_18;
        label_1:
        this.<>1__state = 0;
        bool val_7 = System.String.IsNullOrEmpty(value:  this.<www>5__2.error);
        if((this.<www>5__2) == null)
        {
            goto label_10;
        }
        
        if(val_7 == false)
        {
            goto label_11;
        }
        
        label_20:
        val_16 = this.<www>5__2.downloadHandler.text;
        val_18 = 0;
        this.<>4__this.buildDate = val_16;
        return (bool)val_18;
        label_4:
        string val_10 = UnityEngine.Application.streamingAssetsPath;
        val_19 = val_10;
        if((System.String.op_Equality(a:  val_10, b:  "")) != false)
        {
                val_19 = UnityEngine.Application.dataPath + "/StreamingAssets/"("/StreamingAssets/");
        }
        
        if((System.IO.Path.Combine(path1:  val_19, path2:  val_17)) != null)
        {
            goto label_19;
        }
        
        goto label_19;
        label_10:
        if(val_7 == true)
        {
            goto label_20;
        }
        
        label_11:
        val_16 = this.<www>5__2.error;
        UnityEngine.Debug.LogError(message:  val_16);
        label_2:
        val_18 = 0;
        return (bool)val_18;
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
