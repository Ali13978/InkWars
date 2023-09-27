using UnityEngine;
private sealed class CharAnimationController_Physical.<DelaySettingRecieveDamageAnimEnded>d__39 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float imageDuration;
    public CharAnimationController_Physical <>4__this;
    private float <time>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharAnimationController_Physical.<DelaySettingRecieveDamageAnimEnded>d__39(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_2;
        int val_3;
        if((this.<>1__state) == 1)
        {
            goto label_0;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        val_2 = this.imageDuration * 0.8f;
        goto label_2;
        label_0:
        this.<>1__state = 0;
        val_2 = (this.<time>5__2) - UnityEngine.Time.deltaTime;
        label_2:
        this.<time>5__2 = val_2;
        if(val_2 > 0f)
        {
            goto label_3;
        }
        
        val_3 = 0;
        this.<>4__this.receiveDamageAnimEnded = true;
        return (bool)val_3;
        label_1:
        val_3 = 0;
        return (bool)val_3;
        label_3:
        val_3 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_3;
        return (bool)val_3;
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
