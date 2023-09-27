using UnityEngine;
private sealed class AsyncSceneLoader.<LoadScene>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string sceneName;
    public bool showLoadingScreen;
    public float minimumDelayInSeconds;
    public bool autoHideLoadingScreen;
    private float <loadingScreenAnimDuration>5__2;
    private UnityEngine.AsyncOperation <sceneLoadingOperation>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AsyncSceneLoader.<LoadScene>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_12;
        int val_14;
        val_12 = this;
        if((this.<>1__state) <= 5)
        {
                var val_12 = 40829628 + (this.<>1__state) << 2;
            val_12 = val_12 + 40829628;
        }
        else
        {
                val_14 = 0;
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
