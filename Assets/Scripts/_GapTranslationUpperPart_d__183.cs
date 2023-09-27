using UnityEngine;
private sealed class LineController.<GapTranslationUpperPart>d__183 : IEnumerator<object>, IEnumerator, IDisposable
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
    private int[] <pos>5__2;
    private int <k>5__3;
    private int <start>5__4;
    private int <gapCounter>5__5;
    private int <i>5__6;
    private float <deltaTime>5__7;
    private float <startTime>5__8;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineController.<GapTranslationUpperPart>d__183(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_48;
        int val_49;
        var val_52;
        if((this.<>1__state) > 3)
        {
            goto label_9;
        }
        
        var val_46 = 40844380 + (this.<>1__state) << 2;
        val_46 = val_46 + 40844380;
        goto (40844380 + (this.<>1__state) << 2 + 40844380);
        label_94:
        val_48 = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        goto label_3;
        label_81:
        if((this.<start>5__4) < 2)
        {
            goto label_4;
        }
        
        val_49 = this.<i>5__6;
        goto label_92;
        label_4:
        val_49 = this;
        System.Int32[] val_4 =  + ((this.mid) << 2);
        mem2[0] = this.<i>5__6;
        int val_47 = this.<k>5__3;
        val_47 = val_47 - 1;
        this.<k>5__3 = val_47;
        goto label_92;
        label_9:
        val_52 = 0;
        return (bool)val_52;
        label_3:
        this.<>1__state = ;
        val_52 = 1;
        return (bool)val_52;
        label_93:
        if(this.ringBalls[(long)this.mid] != 0)
        {
                int val_60 = this.<gapCounter>5__5;
            val_60 = val_60 + 1;
            this.<gapCounter>5__5 = val_60;
        }
        
        if(this.ringBalls[] == 0)
        {
            goto label_71;
        }
        
        if((System.String.op_Inequality(a:  this.ringBalls[].gameObject.tag, b:  "SPD")) == false)
        {
            goto label_71;
        }
        
        if((System.String.op_Inequality(a:  this.ringBalls[].gameObject.tag, b:  "SPD1")) == false)
        {
            goto label_71;
        }
        
        if((System.String.op_Inequality(a:  this.ringBalls[].gameObject.tag, b:  "SPD2")) == false)
        {
            goto label_71;
        }
        
        var val_65 = ;
        label_80:
        int val_40 = val_65 - 1;
        label_73:
        if((val_40 + 2) > (this.mid + 1))
        {
            goto label_81;
        }
        
        val_40 = val_40 + 1;
        if( == this.mid)
        {
            goto label_73;
        }
        
        val_65 = val_40 + 1;
        if(this.ringBalls[(long)val_65] == 0)
        {
                if(( == this.mid) || (this.mid != val_40))
        {
            goto label_80;
        }
        
        }
        
        if( == val_40)
        {
            goto label_81;
        }
        
        if((this.<start>5__4) == 1)
        {
                this.<start>5__4 = val_40;
        }
        
        this.ringBalls[(long)val_40] = this.ringBalls[(long)].gameObject;
        this.ringBalls[] = 0;
        this.<>2__current = 0;
        this.<>1__state = 1;
        return (bool)val_52;
        label_71:
        if((this.<start>5__4) == 2)
        {
                this.<start>5__4 = 0;
        }
        
        label_92:
        int val_45 =  - 1;
        mem2[0] = val_45;
        if((val_45 & 2147483648) == 0)
        {
            goto label_93;
        }
        
        goto label_94;
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
