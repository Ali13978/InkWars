using UnityEngine;
private sealed class LineControllerP2.<startDefenceSequence>d__110 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineControllerP2 <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerP2.<startDefenceSequence>d__110(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        BattleVSGates val_11;
        var val_14;
        val_11 = this;
        if((this.<>1__state) <= 4)
        {
                var val_11 = 40840624 + (this.<>1__state) << 2;
            val_11 = val_11 + 40840624;
        }
        else
        {
                val_14 = 0;
            return (bool)val_14;
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
