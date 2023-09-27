using UnityEngine;
private sealed class SwipeSceneSelect.<AnimationAtStart>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SwipeSceneSelect <>4__this;
    private float <rollTime>5__2;
    private float <fraction>5__3;
    private int <i>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SwipeSceneSelect.<AnimationAtStart>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        object val_8;
        int val_9;
        var val_10;
        int val_11;
        val_7 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool)val_7;
        }
        
        var val_7 = 40838828;
        val_7 = (40838828 + (this.<>1__state) << 2) + val_7;
        goto (40838828 + (this.<>1__state) << 2 + 40838828);
        label_16:
        this.<rollTime>5__2 = ;
        this.<fraction>5__3 = (this.<fraction>5__3) + 0.01f;
        do
        {
            UnityEngine.GameObject.FindWithTag(tag:  "ikaLeftRight").GetComponent<SelectStageController>().StartRoll(rollTime:  this.<rollTime>5__2);
            if((this.<>4__this) != null)
        {
                val_10 = this.<>4__this;
            val_11 = (this.<>4__this.nameCounter) + 1;
            mem2[0] = val_11;
        }
        else
        {
                val_10 = 60;
            mem[60] = 1769501;
            val_11 = mem[60];
        }
        
            if(val_11 >= 12)
        {
                mem[60] = 0;
        }
        
            UnityEngine.WaitForSeconds val_6 = null;
            val_8 = val_6;
            val_6 = new UnityEngine.WaitForSeconds(seconds:  this.<rollTime>5__2);
            val_9 = 2;
            val_7 = 1;
            this.<>2__current = val_8;
            this.<>1__state = val_9;
            return (bool)val_7;
        }
        while( < 8);
        
        float val_10 = this.<rollTime>5__2;
        val_10 = val_10 + (this.<fraction>5__3);
        goto label_16;
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
