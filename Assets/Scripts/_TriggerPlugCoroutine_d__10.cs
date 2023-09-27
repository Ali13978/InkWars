using UnityEngine;
private sealed class View_Whirlpool.<TriggerPlugCoroutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View_Whirlpool <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public View_Whirlpool.<TriggerPlugCoroutine>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        int val_9;
        val_8 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_3;
        }
        
        this.<>4__this.RingEmpty = true;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        View_Core val_1 = View_Core.Instance;
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_1.Template_Plug, parent:  this.<>4__this.transform);
        val_3.GetComponent<UnityEngine.SpriteRenderer>().sortingOrder = 3;
        val_8 = val_3.transform;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        val_8.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        label_2:
        val_9 = 0;
        return (bool)val_9;
        label_3:
        mem[40] = 1;
        label_4:
        this.<>4__this.SpriteImage.sprite = 0;
        val_9 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        this.<>1__state = val_9;
        return (bool)val_9;
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
