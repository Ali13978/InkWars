using UnityEngine;
private sealed class DataFetchCtrl.<FakeLoadProcess>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DataFetchCtrl <>4__this;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DataFetchCtrl.<FakeLoadProcess>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        int val_4;
        val_3 = this.<>1__state;
        if(val_3 == 1)
        {
            goto label_1;
        }
        
        if(val_3 != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<i>5__2 = 0;
        if((this.<>4__this) != null)
        {
            goto label_7;
        }
        
        label_8:
        val_3 = 0;
        label_7:
        float val_3 = 0.1f;
        val_3 = 0f * val_3;
        this.<>4__this.OnDataDownloadStep(process:  val_3, exc:  0);
        val_4 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        this.<>1__state = val_4;
        return (bool)val_4;
        label_1:
        this.<>1__state = 0;
        int val_2 = (this.<i>5__2) + 1;
        this.<i>5__2 = val_2;
        if(val_2 < 11)
        {
            goto label_5;
        }
        
        this.<>4__this.OnAllDataDownloaded();
        label_2:
        val_4 = 0;
        return (bool)val_4;
        label_5:
        if((this.<>4__this) != null)
        {
            goto label_7;
        }
        
        goto label_8;
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
