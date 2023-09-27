using UnityEngine;
private sealed class InteractiveTutorialManager.<IconMask>d__91 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public InteractiveTutorialManager <>4__this;
    private float <characterReloadVariable>5__2;
    private float <startTime>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InteractiveTutorialManager.<IconMask>d__91(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_11;
        var val_12;
        float val_13;
        int val_14;
        val_11 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<characterReloadVariable>5__2 = 0.02352941f;
        this.<>1__state = 0;
        this.<>4__this.iconPlayerActive.GetComponent<UnityEngine.UI.Outline>().enabled = false;
        DemoManager val_2 = DemoManager.Instance;
        if(val_2.IsAdvancedTutorialMode != false)
        {
                this.<>4__this.iconCPUActive.GetComponent<UnityEngine.UI.Outline>().enabled = false;
        }
        
        val_12 = val_11;
        this.<>4__this.Player_Left.isReloading = true;
        this.<startTime>5__3 = 0f;
        float val_11 = this.<characterReloadVariable>5__2;
        val_11 = val_11 + 1f;
        if(val_11 < 0f)
        {
            goto label_13;
        }
        
        label_24:
        val_13 = this.<startTime>5__3;
        this.<>4__this.iconPlayerActive.GetComponent<UnityEngine.UI.Image>().fillAmount = val_13;
        DemoManager val_5 = DemoManager.Instance;
        if(val_5.IsAdvancedTutorialMode != false)
        {
                val_13 = this.<startTime>5__3;
            this.<>4__this.iconCPUActive.GetComponent<UnityEngine.UI.Image>().fillAmount = val_13;
        }
        
        float val_12 = this.<startTime>5__3;
        val_12 = val_12 + (this.<characterReloadVariable>5__2);
        mem[1152921526146219580] = val_12;
        val_14 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.04f);
        this.<>1__state = val_14;
        return (bool)val_14;
        label_1:
        val_12 = val_11;
        val_13 = this.<startTime>5__3;
        this.<>1__state = 0;
        if(val_13 <= ((this.<characterReloadVariable>5__2) + 1f))
        {
            goto label_24;
        }
        
        label_13:
        this.<>4__this.Player_Left.isReloading = false;
        this.<>4__this.iconPlayerActive.GetComponent<UnityEngine.UI.Outline>().enabled = true;
        val_11 = this.<>4__this.iconCPUActive.GetComponent<UnityEngine.UI.Outline>();
        val_11.enabled = true;
        label_2:
        val_14 = 0;
        return (bool)val_14;
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
