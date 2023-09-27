using UnityEngine;
private sealed class StageItem.<LoadTextureAsync>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string resourcePath;
    public StageItem <>4__this;
    private UnityEngine.ResourceRequest <loader>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public StageItem.<LoadTextureAsync>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_8;
        int val_9;
        val_8 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_14;
        }
        
        this.<>1__state = 0;
        UnityEngine.ResourceRequest val_1 = UnityEngine.Resources.LoadAsync<UnityEngine.Sprite>(path:  this.resourcePath);
        this.<loader>5__2 = val_1;
        if(val_1 != null)
        {
            goto label_17;
        }
        
        label_18:
        label_17:
        if(val_1.isDone == false)
        {
            goto label_4;
        }
        
        val_8 = mem[this.<loader>5__2].asset;
        if((val_8 != null) && (null != null))
        {
                val_8 = 0;
        }
        
        if(0 != (this.<>4__this.stageImage))
        {
                if(0 != val_8)
        {
                this.<>4__this.stageImage.sprite = val_8;
        }
        
        }
        
        label_14:
        val_9 = 0;
        return (bool)val_9;
        label_4:
        val_9 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_9;
        return (bool)val_9;
        label_1:
        this.<>1__state = 0;
        if((this.<loader>5__2) != null)
        {
            goto label_17;
        }
        
        goto label_18;
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
