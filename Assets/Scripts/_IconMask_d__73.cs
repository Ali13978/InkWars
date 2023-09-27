using UnityEngine;
private sealed class LineControllerAI.<IconMask>d__73 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineControllerAI <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerAI.<IconMask>d__73(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        int val_10;
        float val_11;
        object val_12;
        val_9 = 0;
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
                return (bool)val_9;
        }
        
        this.<>1__state = 0;
        this.<>4__this.iconCPUActive.GetComponent<UnityEngine.UI.Outline>().enabled = false;
        this.<>4__this.isWaiting = true;
        this.<>4__this.iconMaskTime = 0f;
        goto label_7;
        label_1:
        val_10 = 0;
        goto label_8;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_9;
        }
        
        label_7:
        float val_9 = this.<>4__this.characterReloadVariable;
        val_9 = val_9 + 1f;
        if((this.<>4__this + 176 + 156) <= val_9)
        {
            goto label_10;
        }
        
        this.<>4__this.isWaiting = false;
        goto label_11;
        label_10:
        float val_2 = (this.<>4__this + 176) + 156;
        label_17:
        val_11 = mem[(this.<>4__this + 176 + 156)];
        val_11 = val_2;
        this.<>4__this.iconCPUActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = val_11;
        if((this.<>4__this.stunSequenceFlag) != true)
        {
                float val_10 = val_2;
            val_10 = val_10 + (this.<>4__this + 176);
            mem2[0] = val_10;
        }
        
        UnityEngine.WaitForSeconds val_5 = null;
        val_12 = val_5;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  0.04f);
        val_10 = 1;
        goto label_16;
        label_9:
        val_11 = 0f;
        if(val_11 <= ((2.802597E-45f) + 1f))
        {
            goto label_17;
        }
        
        mem[152] = 0;
        label_11:
        this.<>4__this.iconCPUActive.GetComponent<UnityEngine.UI.Outline>().enabled = true;
        UnityEngine.WaitForSeconds val_8 = null;
        val_12 = val_8;
        val_8 = new UnityEngine.WaitForSeconds(seconds:  0f);
        val_10 = 2;
        label_16:
        val_9 = 1;
        this.<>2__current = val_12;
        label_8:
        this.<>1__state = val_10;
        return (bool)val_9;
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
