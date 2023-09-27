using UnityEngine;
private sealed class DataFetchCtrl.<LoadNextAsync>d__17 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DataFetchCtrl <>4__this;
    private UnityEngine.AsyncOperation <task>5__2;
    private float <originProc>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DataFetchCtrl.<LoadNextAsync>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        DataFetchCtrl val_6;
        UnityEngine.AsyncOperation val_7;
        int val_8;
        val_6 = this.<>4__this;
        if((this.<>1__state) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.loadingBar.animatedPercentage) < 0)
        {
            goto label_4;
        }
        
        CryptoCurrency.ListenToUserCurrencyChangeEvent();
        val_7 = this;
        this.<task>5__2 = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  "Menu_Title_Screen");
        this.<originProc>5__3 = this.<>4__this.loadingBar.percent;
        goto label_10;
        label_1:
        if((this.<>1__state) != 2)
        {
            goto label_11;
        }
        
        val_7 = this.<task>5__2;
        this.<>1__state = 0;
        label_10:
        if((mem[this.<task>5__2].isDone) == false)
        {
            goto label_13;
        }
        
        label_11:
        val_8 = 0;
        return (bool)val_8;
        label_4:
        val_8 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_8;
        return (bool)val_8;
        label_13:
        val_6 = this.<>4__this.loadingBar;
        float val_6 = 10f;
        val_6 = (this.<task>5__2.progress) * val_6;
        float val_7 = (float)UnityEngine.Mathf.RoundToInt(f:  val_6);
        val_7 = (this.<originProc>5__3) + val_7;
        val_8 = 1;
        this.<>4__this.loadingBar.percent = val_7;
        this.<>2__current = 0;
        this.<>1__state = 2;
        return (bool)val_8;
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
