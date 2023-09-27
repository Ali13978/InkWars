using UnityEngine;
private sealed class DemoManager.<AdvancedTutorial>d__55 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DemoManager <>4__this;
    private float <countDownTimer>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DemoManager.<AdvancedTutorial>d__55(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_96;
        int val_97;
        var val_108;
        if((this.<>1__state) > 52)
        {
            goto label_1;
        }
        
        var val_94 = 40827056 + (this.<>1__state) << 2;
        val_94 = val_94 + 40827056;
        goto (40827056 + (this.<>1__state) << 2 + 40827056);
        InteractiveTutorialManager.Instance.SetPlayers(stage:  3, subStage:  0);
        if(null <= 20)
        {
                UnityEngine.Coroutine val_40 = StartCoroutine(routine:  RestartStage());
        }
        
        SetAdvancedTutorialStage(index:  21);
        UnityEngine.WaitForSeconds val_41 = new UnityEngine.WaitForSeconds(seconds:  3f);
        this.<>2__current = val_41;
        val_97 = 26;
        goto label_331;
        if(0 >= 23)
        {
            goto label_134;
        }
        
        val_41.SetAdvancedTutorialStage(index:  22);
        UnityEngine.WaitForSeconds val_42 = new UnityEngine.WaitForSeconds(seconds:  4f);
        this.<>2__current = val_42;
        val_97 = 27;
        goto label_331;
        label_134:
        if(0 >= 24)
        {
            goto label_135;
        }
        
        mem[1152921526100706129] = 0;
        val_108 = null;
        val_108 = null;
        DemoManager.touchBoolForDemo = true;
        EnableBallChange(enable:  true);
        val_42.SetAdvancedTutorialStage(index:  23);
        SetActive(value:  true);
        if(0 == 0)
        {
            goto label_142;
        }
        
        val_42.SetLeftText(text:  "1.8 SEC");
        if(0 == 0)
        {
            goto label_145;
        }
        
        UnityEngine.WaitForSeconds val_43 = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>2__current = val_43;
        val_97 = 30;
        goto label_331;
        label_135:
        val_43.SetAdvancedTutorialStage(index:  24);
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  3f);
        val_97 = 31;
        goto label_331;
        label_1:
        val_96 = 0;
        return (bool)val_96;
        label_145:
        this.<>2__current = 0;
        val_97 = 29;
        goto label_331;
        label_142:
        this.<>2__current = 0;
        val_97 = 28;
        label_331:
        this.<>1__state = ;
        val_96 = 1;
        return (bool)val_96;
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
