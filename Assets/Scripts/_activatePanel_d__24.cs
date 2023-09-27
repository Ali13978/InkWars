using UnityEngine;
private sealed class StoryPanelScript.<activatePanel>d__24 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public StoryPanelScript <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public StoryPanelScript.<activatePanel>d__24(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        StoryPanelScript val_13;
        int val_14;
        var val_15;
        UnityEngine.GameObject val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        val_13 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_32;
        }
        
        this.<>1__state = 0;
        val_14 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = val_14;
        return (bool)val_14;
        label_1:
        this.<>1__state = 0;
        val_13 = this.<>4__this;
        val_15 = null;
        val_15 = null;
        if((System.String.op_Equality(a:  StoryPanelScript.keyForStory, b:  "Tako_Start")) == false)
        {
            goto label_6;
        }
        
        this.<>4__this.takoStart.SetActive(value:  true);
        val_16 = this.<>4__this.takoStart;
        goto label_75;
        label_6:
        val_17 = null;
        val_17 = null;
        val_18 = null;
        if((System.String.op_Equality(a:  StoryPanelScript.keyForStory, b:  "Tako_End")) == false)
        {
            goto label_12;
        }
        
        val_19 = null;
        StoryPanelScript.Tako_End = true;
        this.<>4__this.takoEnding.SetActive(value:  true);
        val_16 = this.<>4__this.takoEnding;
        goto label_75;
        label_12:
        val_20 = null;
        val_21 = null;
        if((System.String.op_Equality(a:  StoryPanelScript.keyForStory, b:  "Tako_P1")) == false)
        {
            goto label_20;
        }
        
        val_22 = null;
        StoryPanelScript.Tako_P1 = true;
        this.<>4__this.takoP1.SetActive(value:  true);
        val_16 = this.<>4__this.takoP1;
        label_75:
        UnityEngine.Coroutine val_6 = val_13.StartCoroutine(routine:  this.<>4__this.takoP1.AnimatePanels(tempPanel:  val_16));
        label_32:
        val_14 = 0;
        return (bool)val_14;
        label_20:
        val_23 = null;
        val_24 = null;
        if((System.String.op_Equality(a:  StoryPanelScript.keyForStory, b:  "Tako_P2")) == false)
        {
            goto label_27;
        }
        
        val_25 = null;
        StoryPanelScript.Tako_P2 = true;
        if((this.<>4__this.takoP2) != null)
        {
            goto label_45;
        }
        
        label_46:
        label_45:
        this.<>4__this.takoP2.SetActive(value:  true);
        goto label_32;
        label_27:
        val_26 = null;
        val_27 = null;
        if((System.String.op_Equality(a:  StoryPanelScript.keyForStory, b:  "Tako_PB")) == false)
        {
            goto label_35;
        }
        
        val_28 = null;
        StoryPanelScript.Tako_PB = true;
        this.<>4__this.takoPB.SetActive(value:  true);
        goto label_75;
        label_35:
        val_29 = null;
        if((System.String.op_Equality(a:  StoryPanelScript.keyForStory, b:  "Ika_Start")) == false)
        {
            goto label_43;
        }
        
        if((this.<>4__this.ikaStart) != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_43:
        val_30 = null;
        val_30 = null;
        val_31 = null;
        if((System.String.op_Equality(a:  StoryPanelScript.keyForStory, b:  "Ika_End")) == false)
        {
            goto label_49;
        }
        
        val_32 = null;
        StoryPanelScript.Ika_End = true;
        this.<>4__this.ikaEnding.SetActive(value:  true);
        goto label_75;
        label_49:
        val_33 = null;
        val_34 = null;
        if((System.String.op_Equality(a:  StoryPanelScript.keyForStory, b:  "Ika_P1")) == false)
        {
            goto label_57;
        }
        
        val_35 = null;
        StoryPanelScript.Ika_P1 = true;
        this.<>4__this.ikaP1.SetActive(value:  true);
        goto label_75;
        label_57:
        val_36 = null;
        val_37 = null;
        if((System.String.op_Equality(a:  StoryPanelScript.keyForStory, b:  "Ika_P2")) == false)
        {
            goto label_65;
        }
        
        val_38 = null;
        StoryPanelScript.Ika_P2 = true;
        this.<>4__this.ikaP2.SetActive(value:  true);
        goto label_75;
        label_65:
        val_39 = null;
        StoryPanelScript.Ika_PB = true;
        this.<>4__this.ikaPB.SetActive(value:  true);
        goto label_75;
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
