using UnityEngine;
private sealed class DemoManager.<RestartStage>d__54 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DemoManager.<RestartStage>d__54(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        int val_7;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        InteractiveTutorialManager val_1 = InteractiveTutorialManager.Instance;
        val_1.iconCPUActive.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        InteractiveTutorialManager val_3 = InteractiveTutorialManager.Instance;
        val_3.iconPlayerActive.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        InstanceAnimator.Instance.Start();
        goto label_12;
        label_1:
        this.<>1__state = 0;
        label_12:
        val_6 = null;
        val_6 = null;
        if(InstanceAnimator.areBallsInstantiated == false)
        {
            goto label_15;
        }
        
        label_2:
        val_7 = 0;
        return (bool)val_7;
        label_15:
        val_7 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_7;
        return (bool)val_7;
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
