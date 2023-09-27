using UnityEngine;
private sealed class ConnectionTestExecuter.<checkInternetConnection>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string[] urlList;
    public System.Action<bool, string> action;
    private int <count>5__2;
    private string[] <>7__wrap2;
    private int <>7__wrap3;
    private string <url>5__5;
    private UnityEngine.WWW <www>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ConnectionTestExecuter.<checkInternetConnection>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_12;
        System.String[] val_13;
        System.String[] val_14;
        int val_15;
        int val_16;
        System.Action<System.Boolean, System.String> val_17;
        var val_18;
        string val_19;
        var val_20;
        val_12 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_22;
        }
        
        val_13 = this.urlList;
        this.<>1__state = 0;
        if((val_13 == null) || (this.urlList.Length == 0))
        {
            goto label_4;
        }
        
        val_14 = val_12;
        this.<>7__wrap2 = val_13;
        val_15 = 1152921526437911464;
        val_16 = 0;
        mem[1152921526437911456] = 0;
        mem[1152921526437911472] = 0;
        if(val_13 != null)
        {
            goto label_20;
        }
        
        goto label_6;
        label_1:
        this.<>1__state = 0;
        if((System.String.IsNullOrEmpty(value:  this.<www>5__6.error)) == false)
        {
            goto label_8;
        }
        
        val_17 = this.action;
        if(val_17 == null)
        {
                return (bool)val_17;
        }
        
        val_18 = 1;
        val_19 = 0;
        val_20 = public System.Void System.Action<System.Boolean, System.String>::Invoke(System.Boolean arg1, System.String arg2);
        goto label_10;
        label_4:
        val_17 = this.action;
        if(val_17 == null)
        {
                return (bool)val_17;
        }
        
        val_19 = "No url to test.";
        val_20 = public System.Void System.Action<System.Boolean, System.String>::Invoke(System.Boolean arg1, System.String arg2);
        goto label_12;
        label_8:
        UnityEngine.Debug.Log(message:  "Cannot connect " + this.<url>5__5(this.<url>5__5) + ": "(": ") + this.<www>5__6.error(this.<www>5__6.error));
        val_15 = this.<>7__wrap3;
        val_14 = this.<>7__wrap2;
        this.<url>5__5 = 0;
        this.<www>5__6 = 0;
        goto label_36;
        label_21:
        var val_5 = (mem[this.<>7__wrap2]) + ((this.<>7__wrap3) << 3);
        this.<url>5__5 = (mem[this.<>7__wrap2] + (this.<>7__wrap3) << 3) + 32;
        if((System.String.IsNullOrEmpty(value:  (mem[this.<>7__wrap2] + (this.<>7__wrap3) << 3) + 32)) == false)
        {
            goto label_19;
        }
        
        label_36:
        val_16 = val_15 + 1;
        mem2[0] = val_16;
        val_13 = mem[this.<>7__wrap2];
        if(val_13 != 0)
        {
            goto label_20;
        }
        
        label_6:
        label_20:
        if(val_16 < (mem[this.<>7__wrap2] + 24))
        {
            goto label_21;
        }
        
        mem2[0] = 0;
        if(this.action == null)
        {
            goto label_22;
        }
        
        val_16 = 1152921504621490176;
        val_12 = this.<count>5__2;
        val_19 = System.String.Format(format:  "{0} of {1} tested. No connection.", arg0:  this.<count>5__2, arg1:  this.urlList.Length);
        val_20 = public System.Void System.Action<System.Boolean, System.String>::Invoke(System.Boolean arg1, System.String arg2);
        label_12:
        val_18 = 0;
        label_10:
        this.action.Invoke(arg1:  false, arg2:  val_19);
        label_22:
        val_17 = 0;
        return (bool)val_17;
        label_19:
        this.<www>5__6 = 0;
        new UnityEngine.WWW() = new UnityEngine.WWW(url:  this.<url>5__5);
        this.<www>5__6 = new UnityEngine.WWW();
        UnityEngine.Debug.Log(message:  "Test " + this.<url>5__5(this.<url>5__5));
        int val_11 = this.<count>5__2;
        this.<>1__state = 1;
        val_11 = val_11 + 1;
        this.<>2__current = this.<www>5__6;
        this.<count>5__2 = val_11;
        return (bool)val_17;
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
