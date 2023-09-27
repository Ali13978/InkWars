using UnityEngine;
private sealed class LineControllerP2.<GapTranslationLowerPart>d__101 : IEnumerator<object>, IEnumerator, IDisposable
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
    private float <startTime>5__7;
    private int <i>5__8;
    private float <deltaTime>5__9;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerP2.<GapTranslationLowerPart>d__101(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_41;
        int val_42;
        int val_43;
        int val_44;
        int val_45;
        var val_48;
        int val_50;
        if((this.<>1__state) > 3)
        {
            goto label_1;
        }
        
        var val_40 = 40840520 + (this.<>1__state) << 2;
        val_40 = val_40 + 40840520;
        goto (40840520 + (this.<>1__state) << 2 + 40840520);
        label_82:
        if((this.<start>5__6) < 2)
        {
            goto label_4;
        }
        
        val_43 = this.<i>5__8;
        goto label_93;
        label_4:
        val_43 = this;
        val_44 = ;
        System.Int32[] val_4 =  + ((this.mid) << 2);
        mem2[0] = this.<i>5__8;
        int val_41 = this.<k>5__5;
        val_41 = val_41 - 1;
        this.<k>5__5 = val_41;
        goto label_93;
        label_1:
        val_45 = 0;
        return (bool)val_45;
        label_94:
        if(this.ringBalls[53308392] != 0)
        {
                int val_59 = this.<gapCounter>5__2;
            val_59 = val_59 + 1;
            this.<gapCounter>5__2 = val_59;
        }
        
        val_44 = mem[(this.<start>5__6 + 1)];
        val_44 = val_43;
        if(this.ringBalls[val_44] == 0)
        {
            goto label_72;
        }
        
        val_44 = mem[(this.<start>5__6 + 1)];
        val_44 = val_43;
        if((System.String.op_Inequality(a:  this.ringBalls[val_44].gameObject.tag, b:  "SPD")) == false)
        {
            goto label_72;
        }
        
        val_44 = mem[(this.<start>5__6 + 1)];
        val_44 = val_43;
        if((System.String.op_Inequality(a:  this.ringBalls[val_44].gameObject.tag, b:  "SPD1")) == false)
        {
            goto label_72;
        }
        
        val_44 = mem[(this.<start>5__6 + 1)];
        val_44 = val_43;
        if((System.String.op_Inequality(a:  this.ringBalls[val_44].gameObject.tag, b:  "SPD2")) == false)
        {
            goto label_72;
        }
        
        var val_64 = val_43;
        label_81:
        int val_34 = val_64 + 1;
        label_74:
        if((val_34 - 2) < (this.mid - 1))
        {
            goto label_82;
        }
        
        val_34 = val_34 - 1;
        if(val_43 == this.mid)
        {
            goto label_74;
        }
        
        val_64 = val_34 - 1;
        val_48 = (long)val_64;
        if(this.ringBalls[val_48] == 0)
        {
                if((val_43 == this.mid) || (this.mid != val_34))
        {
            goto label_81;
        }
        
        }
        
        if(val_43 == val_34)
        {
            goto label_82;
        }
        
        if((this.<start>5__6) == 1)
        {
                this.<start>5__6 = val_34;
        }
        
        val_44 = (long)val_34;
        this.ringBalls[val_44] = this.ringBalls[(long)val_43].gameObject;
        val_43 = mem[(this.<start>5__6 + 1)];
        val_43 = val_43;
        val_45 = 1;
        this.ringBalls[val_43] = 0;
        this.<>2__current = 0;
        this.<>1__state = val_45;
        return (bool)val_45;
        label_72:
        if((this.<start>5__6) == 2)
        {
                this.<start>5__6 = 0;
        }
        
        label_93:
        val_41 = this.<length>5__3;
        val_42 = val_43 + 1;
        mem2[0] = val_42;
        if(val_42 <= val_41)
        {
            goto label_94;
        }
        
        val_50 = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        this.<>1__state = val_50;
        val_45 = 1;
        return (bool)val_45;
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
