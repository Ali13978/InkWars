using UnityEngine;
private sealed class LineControllerAI.<GapTranslationUpperPart>d__65 : IEnumerator<object>, IEnumerator, IDisposable
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
    private int[] <pos>5__3;
    private int <k>5__4;
    private int <start>5__5;
    private int <i>5__6;
    private float <deltaTime>5__7;
    private float <startTime>5__8;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerAI.<GapTranslationUpperPart>d__65(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_38;
        var val_41;
        int val_46;
        if((this.<>1__state) > 3)
        {
            goto label_5;
        }
        
        var val_36 = 40840360 + (this.<>1__state) << 2;
        val_36 = val_36 + 40840360;
        goto (40840360 + (this.<>1__state) << 2 + 40840360);
        label_65:
        val_38 = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.01f);
        goto label_3;
        label_5:
        val_41 = 0;
        return (bool)val_41;
        label_3:
        this.<>1__state = ;
        val_41 = 1;
        return (bool)val_41;
        label_64:
        if(this.ringBalls[(long)this.mid] == 0)
        {
            goto label_47;
        }
        
        int val_49 = this.<gapCounter>5__2;
        val_49 = val_49 + 1;
        this.<gapCounter>5__2 = val_49;
        var val_50 = ;
        label_56:
        int val_29 = val_50 - 1;
        label_49:
        if((val_29 + 2) > (this.mid + 1))
        {
            goto label_48;
        }
        
        val_29 = val_29 + 1;
        if( == this.mid)
        {
            goto label_49;
        }
        
        val_50 = val_29 + 1;
        if(this.ringBalls[(long)val_50] == 0)
        {
                if(( == this.mid) || (this.mid != val_29))
        {
            goto label_56;
        }
        
        }
        
        if( != val_29)
        {
            goto label_57;
        }
        
        label_48:
        if((this.<start>5__5) < 2)
        {
            goto label_58;
        }
        
        val_46 = this.<i>5__6;
        goto label_63;
        label_58:
        val_46 = this;
        System.Int32[] val_33 =  + (((this.<k>5__4 - 1)) << 2);
        mem2[0] = this.<i>5__6;
        int val_52 = this.<k>5__4;
        val_52 = val_52 - 1;
        this.<k>5__4 = val_52;
        goto label_63;
        label_47:
        if((this.<start>5__5) == 2)
        {
                this.<start>5__5 = 0;
        }
        
        label_63:
        int val_34 =  - 1;
        mem2[0] = val_34;
        if((val_34 & 2147483648) == 0)
        {
            goto label_64;
        }
        
        goto label_65;
        label_57:
        if((this.<start>5__5) == 1)
        {
                this.<start>5__5 = val_29;
        }
        
        this.ringBalls[(long)val_29] = this.ringBalls[(long)].gameObject;
        this.ringBalls[] = 0;
        this.<>2__current = 0;
        this.<>1__state = 1;
        return (bool)val_41;
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
