using UnityEngine;
private sealed class LineControllerAI.<GapTranslationLowerPart>d__66 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int mid;
    public UnityEngine.GameObject[] ringBalls;
    public int negateX;
    public float radius;
    public float upperAngle;
    public float angleDiff;
    private int <gapCounter>5__2;
    private int <length>5__3;
    private int[] <pos>5__4;
    private int <k>5__5;
    private int <start>5__6;
    private int <i>5__7;
    private float <deltaTime>5__8;
    private float <startTime>5__9;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerAI.<GapTranslationLowerPart>d__66(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_31;
        int val_32;
        int val_33;
        var val_36;
        int val_37;
        var val_38;
        int val_40;
        if((this.<>1__state) > 3)
        {
            goto label_5;
        }
        
        var val_30 = 40840344 + (this.<>1__state) << 2;
        val_30 = val_30 + 40840344;
        goto (40840344 + (this.<>1__state) << 2 + 40840344);
        label_5:
        val_36 = 0;
        return (bool)val_36;
        label_63:
        val_37 = 1152921504858337280;
        if(this.ringBalls[53308392] == 0)
        {
            goto label_48;
        }
        
        int val_47 = this.<gapCounter>5__2;
        val_47 = val_47 + 1;
        this.<gapCounter>5__2 = val_47;
        var val_48 = val_33;
        label_57:
        int val_23 = val_48 + 1;
        label_50:
        if((val_23 - 2) < (this.mid - 1))
        {
            goto label_49;
        }
        
        val_23 = val_23 - 1;
        if(val_33 == this.mid)
        {
            goto label_50;
        }
        
        val_48 = val_23 - 1;
        val_38 = (long)val_48;
        if(this.ringBalls[val_38] == 0)
        {
                if((val_33 == this.mid) || (this.mid != val_23))
        {
            goto label_57;
        }
        
        }
        
        if(val_33 != val_23)
        {
            goto label_58;
        }
        
        label_49:
        if((this.<start>5__6) >= 2)
        {
                val_33 = this.<i>5__7;
        }
        else
        {
                val_33 = this;
            val_37 = this.<k>5__5;
            System.Int32[] val_27 =  + (((this.<k>5__5 - 1)) << 2);
            mem2[0] = this.<i>5__7;
            int val_50 = this.<k>5__5;
            val_50 = val_50 - 1;
            this.<k>5__5 = val_50;
        }
        
        label_65:
        val_31 = this.<length>5__3;
        val_32 =  + 1;
        this.<i>5__7 = val_32;
        if(val_32 <= val_31)
        {
            goto label_63;
        }
        
        val_40 = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.01f);
        this.<>1__state = val_40;
        val_36 = 1;
        return (bool)val_36;
        label_48:
        if((this.<start>5__6) != 2)
        {
            goto label_65;
        }
        
        this.<start>5__6 = 0;
        goto label_65;
        label_58:
        if((this.<start>5__6) == 1)
        {
                this.<start>5__6 = val_23;
        }
        
        this.ringBalls[(long)val_23] = this.ringBalls[(long)val_33].gameObject;
        this.ringBalls[val_33] = 0;
        this.<>2__current = 0;
        this.<>1__state = 1;
        return (bool)val_36;
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
