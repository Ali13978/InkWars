using UnityEngine;
private sealed class InteractiveTutorialManager.<MakeBallNull>d__86 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool isCPU;
    public InteractiveTutorialManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InteractiveTutorialManager.<MakeBallNull>d__86(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        InteractiveTutorialManager val_7;
        int val_8;
        if((this.<>1__state) <= 4)
        {
                var val_7 = 40823960 + (this.<>1__state) << 2;
            val_7 = this.<>4__this;
            val_7 = val_7 + 40823960;
        }
        else
        {
                val_8 = 0;
            return (bool);
        }
    
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
