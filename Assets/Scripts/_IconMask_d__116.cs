using UnityEngine;
private sealed class LineControllerP2.<IconMask>d__116 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineControllerP2 <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerP2.<IconMask>d__116(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_11;
        int val_12;
        val_11 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>4__this.iconPlayerActive.GetComponent<UnityEngine.UI.Outline>().enabled = false;
        this.<>4__this.isWaiting = true;
        this.<>4__this.specialBallButton.interactable = false;
        this.<>4__this.iconMaskTime = 0f;
        goto label_7;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_8;
        }
        
        label_7:
        float val_11 = this.<>4__this.characterReloadVariable;
        val_11 = val_11 + 1f;
        var val_2 = ((this.<>4__this.winSequenceFlag) == true) ? 1 : 0;
        if((this.<>4__this.iconMaskTime) <= val_11)
        {
            goto label_9;
        }
        
        label_25:
        if((val_2 != 0) && ((this.<>4__this.looseSequenceFlag) != false))
        {
                this.<>4__this.specialBallButton.interactable = true;
            this.<>4__this.specialBallButtonArrow.interactable = true;
        }
        
        this.<>4__this.isWaiting = false;
        val_11 = this.<>4__this.iconPlayerActive.GetComponent<UnityEngine.UI.Outline>();
        val_11.enabled = true;
        label_2:
        val_12 = 0;
        return (bool)val_12;
        label_9:
        label_26:
        if((val_2 & 1) == 0)
        {
                this.<>4__this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = 1f;
        }
        
        this.<>4__this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = this.<>4__this.iconMaskTime;
        if((this.<>4__this.stunSequenceFlag) != true)
        {
                float val_12 = this.<>4__this.iconMaskTime;
            val_12 = val_12 + (this.<>4__this.characterReloadVariable);
            mem2[0] = val_12;
        }
        
        val_12 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.04f);
        this.<>1__state = val_12;
        return (bool)val_12;
        label_8:
        var val_10 = (240 != 0) ? 1 : 0;
        if((2.228065E-43f) > ((5.605194E-45f) + 1f))
        {
            goto label_25;
        }
        
        goto label_26;
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
