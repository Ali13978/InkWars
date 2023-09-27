using UnityEngine;
private sealed class DataFetchCtrl.<DataFetchTimeoutMonitor>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int timeOutTime;
    public DataFetchCtrl <>4__this;
    private int <sec>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DataFetchCtrl.<DataFetchTimeoutMonitor>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_11;
        DataFetchCtrl val_12;
        int val_13;
        val_11 = this.<>1__state;
        val_12 = this.<>4__this;
        if(val_11 == 1)
        {
            goto label_1;
        }
        
        if(val_11 != 0)
        {
            goto label_2;
        }
        
        this.<sec>5__2 = 0;
        this.<>1__state = 0;
        goto label_3;
        label_1:
        val_11 = (this.<sec>5__2) + 4;
        this.<>1__state = 0;
        this.<sec>5__2 = val_11;
        label_3:
        if(val_11 < this.timeOutTime)
        {
                UnityEngine.Debug.Log(message:  "#Monitoring loading time " + this.<sec>5__2.ToString()(this.<sec>5__2.ToString()));
            UnityEngine.WaitForSeconds val_3 = null;
            val_12 = val_3;
            val_3 = new UnityEngine.WaitForSeconds(seconds:  4f);
            val_13 = 1;
            this.<>2__current = val_12;
            this.<>1__state = val_13;
            return (bool)val_13;
        }
        
        UnityEngine.Debug.Log(message:  "#Monitoring loading time stopped");
        DialogPanel val_10 = DialogManager.ShowConfirmDialog(title:  LanguageManager.GetText(key:  "LK.FetchData.Error"), message:  LanguageManager.GetText(key:  "LK.FetchData.StuckError"), confirmButtonTitle:  LanguageManager.GetText(key:  "LK.FetchData.Retry"), cancelButtonTitle:  LanguageManager.GetText(key:  "LK.FetchData.KeepWaiting"), onConfirmCallback:  new UnityEngine.Events.UnityAction(object:  val_12, method:  System.Void DataFetchCtrl::MoveToBack()), onCancelCallback:  new UnityEngine.Events.UnityAction(object:  val_12, method:  System.Void DataFetchCtrl::<DataFetchTimeoutMonitor>b__15_0()));
        label_2:
        val_13 = 0;
        return (bool)val_13;
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
