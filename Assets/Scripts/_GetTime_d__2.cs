using UnityEngine;
private sealed class OnlineTimeGetter.<GetTime>d__2 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public IOnlineTimeParser[] parserList;
    public UnityEngine.Events.UnityAction<string> callback;
    private int <expiredParserCount>5__2;
    private IOnlineTimeParser[] <>7__wrap2;
    private int <>7__wrap3;
    private IOnlineTimeParser <parser>5__5;
    private UnityEngine.WWW <request>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public OnlineTimeGetter.<GetTime>d__2(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Events.UnityAction<System.String> val_15;
        IOnlineTimeParser[] val_16;
        var val_17;
        string val_18;
        int val_20;
        var val_21;
        int val_22;
        var val_23;
        var val_24;
        string val_25;
        var val_26;
        val_15 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>7__wrap3 = 0;
        val_16 = this.parserList;
        val_17 = 0;
        this.<>1__state = 0;
        mem[1152921528212084528] = 0;
        mem[1152921528212084536] = val_16;
        if(val_16 != null)
        {
            goto label_4;
        }
        
        goto label_4;
        label_1:
        val_18 = val_15;
        this.<>1__state = 0;
        if((this.<request>5__6) != null)
        {
            goto label_42;
        }
        
        label_43:
        label_42:
        if((this.<request>5__6.isDone) == false)
        {
            goto label_6;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.<request>5__6.error)) == false)
        {
            goto label_8;
        }
        
        val_18 = this.<request>5__6.text;
        var val_15 = 0;
        val_15 = val_15 + 1;
        goto label_14;
        label_6:
        val_20 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_20;
        return (bool)val_20;
        label_14:
        string val_7 = this.<parser>5__5.GetTimeStringFromWWWText(wwwText:  val_18);
        val_21 = val_7;
        if((System.String.IsNullOrEmpty(value:  val_7)) == false)
        {
            goto label_16;
        }
        
        val_22 = this.<expiredParserCount>5__2;
        this.<parser>5__5 = 0;
        this.<request>5__6 = 0;
        goto label_17;
        label_16:
        val_15 = this.callback;
        if(val_15 != null)
        {
            goto label_34;
        }
        
        goto label_19;
        label_29:
        var val_9 = X22 + (-9223372036720164864);
        mem2[0] = (X22 + -9223372036720164864) + 32;
        if(((X22 + -9223372036720164864) + 32) == 0)
        {
            goto label_22;
        }
        
        var val_18 = (X22 + -9223372036720164864) + 32;
        if(((X22 + -9223372036720164864) + 32 + 286) == 0)
        {
            goto label_26;
        }
        
        var val_16 = (X22 + -9223372036720164864) + 32 + 176;
        var val_17 = 0;
        val_16 = val_16 + 8;
        label_25:
        if((((X22 + -9223372036720164864) + 32 + 176 + 8) + -8) == null)
        {
            goto label_24;
        }
        
        val_17 = val_17 + 1;
        val_16 = val_16 + 16;
        if(val_17 < ((X22 + -9223372036720164864) + 32 + 286))
        {
            goto label_25;
        }
        
        goto label_26;
        label_24:
        val_18 = val_18 + ((((X22 + -9223372036720164864) + 32 + 176 + 8)) << 4);
        val_23 = val_18 + 296;
        label_26:
        if((System.String.IsNullOrEmpty(value:  (X22 + -9223372036720164864) + 32.GetUrl())) == false)
        {
            goto label_27;
        }
        
        label_22:
        label_17:
        mem2[0] = 1152921508778894369;
        label_8:
        val_17 = 1152921508778894370;
        mem2[0] = val_17;
        val_16 = this.callback + 64 + -8;
        label_4:
        if(val_17 < (this.callback + 64 + -8 + 24))
        {
            goto label_29;
        }
        
        mem2[0] = 0;
        System.DateTime val_12 = System.DateTime.UtcNow;
        val_21;
        if(val_15 != null)
        {
            goto label_34;
        }
        
        label_19:
        label_34:
        val_24 = 1152921526004021600;
        val_25 = val_21;
        val_15.Invoke(arg0:  null);
        label_2:
        val_20 = 0;
        return (bool)val_20;
        label_27:
        var val_21 = (X22 + -9223372036720164864) + 32;
        if(((X22 + -9223372036720164864) + 32 + 286) == 0)
        {
            goto label_41;
        }
        
        var val_19 = (X22 + -9223372036720164864) + 32 + 176;
        var val_20 = 0;
        val_19 = val_19 + 8;
        label_40:
        if((((X22 + -9223372036720164864) + 32 + 176 + 8) + -8) == null)
        {
            goto label_39;
        }
        
        val_20 = val_20 + 1;
        val_19 = val_19 + 16;
        if(val_20 < ((X22 + -9223372036720164864) + 32 + 286))
        {
            goto label_40;
        }
        
        goto label_41;
        label_39:
        val_21 = val_21 + ((((X22 + -9223372036720164864) + 32 + 176 + 8)) << 4);
        val_26 = val_21 + 296;
        label_41:
        UnityEngine.WWW val_14 = new UnityEngine.WWW(url:  (X22 + -9223372036720164864) + 32.GetUrl());
        mem2[0] = val_14;
        if(val_14 != null)
        {
            goto label_42;
        }
        
        goto label_43;
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
