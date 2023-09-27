using UnityEngine;
private sealed class InteractiveTutorialManager.<PostAttackSequence>d__87 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool isCPU;
    public InteractiveTutorialManager <>4__this;
    private CharAnimationController <thisAnim>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InteractiveTutorialManager.<PostAttackSequence>d__87(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool);
        }
        
        var val_8 = 40823980;
        val_8 = (40823980 + (this.<>1__state) << 2) + val_8;
        goto (40823980 + (this.<>1__state) << 2 + 40823980);
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
