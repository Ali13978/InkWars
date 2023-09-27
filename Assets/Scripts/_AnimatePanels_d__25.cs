using UnityEngine;
private sealed class StoryPanelScript.<AnimatePanels>d__25 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.GameObject tempPanel;
    private System.Collections.IEnumerator <>7__wrap1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public StoryPanelScript.<AnimatePanels>d__25(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 2)
        {
                if((this.<>1__state) != 3)
        {
                return;
        }
        
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        var val_14;
        System.Collections.IEnumerator val_15;
        int val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 2)
        {
            goto label_24;
        }
        
        val_14 = this;
        val_15 = this.<>7__wrap1;
        goto label_4;
        label_2:
        this.<>1__state = 0;
        val_15 = this.tempPanel.transform.GetEnumerator();
        val_14 = this;
        this.<>7__wrap1 = val_15;
        label_4:
        this.<>1__state = -3;
        var val_15 = 0;
        val_15 = val_15 + 1;
        goto label_11;
        label_1:
        this.<>1__state = 0;
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        val_17 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds();
        this.<>1__state = val_17;
        return (bool)val_17;
        label_11:
        if(val_15.MoveNext() == false)
        {
            goto label_13;
        }
        
        var val_19 = mem[val_2];
        if((mem[val_2] + 286) == 0)
        {
            goto label_18;
        }
        
        var val_16 = mem[val_2] + 176;
        var val_17 = 0;
        val_16 = val_16 + 8;
        label_17:
        if(((mem[val_2] + 176 + 8) + -8) == null)
        {
            goto label_16;
        }
        
        val_17 = val_17 + 1;
        val_16 = val_16 + 16;
        if(val_17 < (mem[val_2] + 286))
        {
            goto label_17;
        }
        
        goto label_18;
        label_13:
        this.<>m__Finally1();
        this.<>7__wrap1 = 0;
        val_19 = null;
        val_19 = null;
        if((System.String.op_Equality(a:  StoryPanelScript.keyForStory, b:  "Ika_End")) == true)
        {
            goto label_21;
        }
        
        val_20 = null;
        val_20 = null;
        if((System.String.op_Equality(a:  StoryPanelScript.keyForStory, b:  "Tako_End")) == false)
        {
            goto label_24;
        }
        
        label_21:
        val_14 = "";
        Credits.nextScene = "";
        val_21 = null;
        val_21 = null;
        Character_GlobalInfo.hackCreditsStartMusic = false;
        Credits.nextScene = "";
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Credits");
        label_24:
        val_17 = 0;
        return (bool)val_17;
        label_16:
        var val_18 = val_16;
        val_18 = val_18 + 1;
        val_19 = val_19 + val_18;
        val_18 = val_19 + 296;
        label_18:
        val_22 = this.<>7__wrap1.Current;
        val_14 = 1152921504865153024;
        if(val_22 != null)
        {
                val_22 = 0;
        }
        
        val_22.gameObject.SetActive(value:  true);
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  2.5f);
        this.<>2__current = new UnityEngine.WaitForSeconds();
        this.<>1__state = 2;
        val_17 = 1;
        return (bool)val_17;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        if((this.<>7__wrap1) == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.<>7__wrap1.Dispose();
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
