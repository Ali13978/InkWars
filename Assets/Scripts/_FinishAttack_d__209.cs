using UnityEngine;
private sealed class LineController.<FinishAttack>d__209 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineController <>4__this;
    private float <postAttackDuration>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineController.<FinishAttack>d__209(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        int val_7;
        float val_8;
        object val_9;
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
        if((this.<>4__this.modeName) == 3)
        {
            goto label_5;
        }
        
        this.<postAttackDuration>5__2 = this.<>4__this.animController.GetAnimationDuration(anim:  11);
        goto label_10;
        label_1:
        val_7 = 0;
        goto label_8;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this.stunSequenceFlag) != true)
        {
                val_8 = this.<>4__this.reloadTime;
            float val_2 = UnityEngine.Time.deltaTime;
            val_2 = val_8 - val_2;
            this.<>4__this.reloadTime = val_2;
        }
        
        label_10:
        float val_5 = this.<>4__this.reloadTime;
        val_5 = val_5 - (this.<postAttackDuration>5__2);
        if(val_5 > 0f)
        {
            goto label_11;
        }
        
        if((this.<>4__this.stuntime) <= 0f)
        {
                this.<>4__this.CancelInvoke(methodName:  "ShakeSequenceAnimationPlayer");
        }
        
        this.<>4__this.animController.pause = false;
        label_5:
        val_8 = this.<>4__this.originalPos;
        this.<>4__this.playerChar.transform.position = new UnityEngine.Vector3() {x = val_8, y = V9.16B, z = V10.16B};
        this.<>4__this.animController.PlayAnimation(newAnimName:  11, forceOverride:  true);
        this.<>4__this.shakeAmount = 0.1f;
        UnityEngine.WaitForSeconds val_4 = null;
        val_9 = val_4;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  0.8f);
        val_7 = 2;
        goto label_17;
        label_11:
        val_9 = 0;
        val_7 = 1;
        label_17:
        val_5 = 1;
        this.<>2__current = val_9;
        label_8:
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
