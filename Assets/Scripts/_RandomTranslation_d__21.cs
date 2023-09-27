using UnityEngine;
private sealed class InkingSequenceBubbleAnim.<RandomTranslation>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public InkingSequenceBubbleAnim <>4__this;
    private UnityEngine.Vector3 <startPos>5__2;
    private float <flagX>5__3;
    private float <flagY>5__4;
    private float <negateX>5__5;
    private float <startTime>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InkingSequenceBubbleAnim.<RandomTranslation>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_25;
        if((this.<>1__state) <= 3)
        {
                var val_24 = 40830788 + (this.<>1__state) << 2;
            val_24 = val_24 + 40830788;
        }
        else
        {
                val_25 = 0;
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
