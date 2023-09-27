using UnityEngine;
private sealed class LoadingAvatarSizeFitter.<AdjustSize>d__1 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LoadingAvatarSizeFitter <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LoadingAvatarSizeFitter.<AdjustSize>d__1(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        int val_7;
        float val_10;
        val_6 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_7 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_7;
        return (bool)val_7;
        label_1:
        this.<>1__state = 0;
        val_6 = this.<>4__this.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Rect val_3 = val_6.rect;
        if(val_6 != null)
        {
                UnityEngine.Vector2 val_4 = val_6.sizeDelta;
            val_10 = val_4.y;
        }
        else
        {
                UnityEngine.Vector2 val_5 = val_6.sizeDelta;
            val_10 = val_5.y;
        }
        
        val_6.sizeDelta = new UnityEngine.Vector2() {x = val_3.m_XMin, y = val_10};
        label_2:
        val_7 = 0;
        return (bool)val_7;
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
