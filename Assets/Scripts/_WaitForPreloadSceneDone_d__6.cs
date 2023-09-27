using UnityEngine;
private sealed class AsyncSceneLoader.<WaitForPreloadSceneDone>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action onDone;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AsyncSceneLoader.<WaitForPreloadSceneDone>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_2;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        }
        
        this.<>1__state = 0;
        if(AsyncSceneLoader.preloadOperator != null)
        {
                if(AsyncSceneLoader.preloadOperator.isDone == false)
        {
            goto label_4;
        }
        
        }
        
        val_2 = this.onDone;
        if(val_2 == null)
        {
                return (bool)val_2;
        }
        
        val_2.Invoke();
        label_2:
        val_2 = 0;
        return (bool)val_2;
        label_4:
        val_2 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_2;
        return (bool)val_2;
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
