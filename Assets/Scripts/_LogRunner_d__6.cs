using UnityEngine;
private sealed class ConsoleOutput.<LogRunner>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public FirebaseExamples.ConsoleOutput <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ConsoleOutput.<LogRunner>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        string val_2 = 0;
        if((this.<>1__state) <= 1)
        {
                this.<>1__state = 0;
            if((this.<>4__this.myLogQueue.Count) != 0)
        {
                if((this.<>4__this.myLogQueue.TryDequeue(result: out  val_2)) != false)
        {
                this.<>4__this.log(s:  val_2);
        }
        
        }
        
            val_5 = 1;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.05f);
            this.<>1__state = val_5;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
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
