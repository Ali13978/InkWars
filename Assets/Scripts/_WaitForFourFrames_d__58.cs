using UnityEngine;
private sealed class playSceneCanvas.<WaitForFourFrames>d__58 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string levelName;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public playSceneCanvas.<WaitForFourFrames>d__58(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_5;
        int val_6;
        val_5 = this;
        if((this.<>1__state) <= 4)
        {
                var val_5 = 40844176 + (this.<>1__state) << 2;
            val_5 = val_5 + 40844176;
        }
        else
        {
                val_6 = 0;
            return (bool)val_6;
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
