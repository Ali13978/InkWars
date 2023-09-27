using UnityEngine;
private sealed class InteractiveTutorialManager.<ActivateCollider>d__85 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool isCPU;
    public InteractiveTutorialManager <>4__this;
    private UnityEngine.Rigidbody2D <ball>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InteractiveTutorialManager.<ActivateCollider>d__85(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        UnityEngine.Rigidbody2D val_6;
        int val_7;
        object val_8;
        val_5 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_4;
        }
        
        if(this.isCPU == false)
        {
            goto label_5;
        }
        
        label_14:
        UnityEngine.Rigidbody2D val_1 = this.<>4__this.cpuBall;
        goto label_6;
        label_1:
        val_7 = 0;
        goto label_7;
        label_2:
        this.<>1__state = 0;
        if((this.<ball>5__2) != 0)
        {
                this.<ball>5__2.GetComponent<UnityEngine.CircleCollider2D>().enabled = true;
        }
        
        val_8 = 0;
        val_7 = 2;
        goto label_13;
        label_4:
        if(this.isCPU == true)
        {
            goto label_14;
        }
        
        label_5:
        val_6 = this.<>4__this.playerBall;
        label_6:
        this.<ball>5__2 = val_6;
        UnityEngine.WaitForSeconds val_4 = null;
        val_8 = val_4;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  0.18f);
        val_7 = 1;
        label_13:
        val_5 = 1;
        this.<>2__current = val_8;
        label_7:
        this.<>1__state = val_7;
        return (bool)val_5;
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
