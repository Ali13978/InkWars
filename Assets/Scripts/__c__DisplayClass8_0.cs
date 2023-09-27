using UnityEngine;
private sealed class UserDataDictionary.<>c__DisplayClass8_0
{
    // Fields
    public System.Action onAllDone;
    public System.Action<float, System.Exception> onProcess;
    public System.Action<string> onFailed;
    
    // Methods
    public UserDataDictionary.<>c__DisplayClass8_0()
    {
    
    }
    internal void <DownloadData>b__0(NFJson_Database.IDatabaseResponse result)
    {
        UnityEngine.Debug.Log(message:  "Download complete callback executed..");
        if(result.success != false)
        {
                UnityEngine.Debug.Log(message:  "NFJsonDataLoad Success");
            this.onAllDone.Invoke();
            IWServerDB_Cache.EnableAddToCache(enable:  true);
            IWServerDB_Cache.EnableSaveRoutine(enable:  true);
            return;
        }
        
        DialogPanel val_2 = DialogManager.Show(title:  "User Data Error", message:  System.String.Format(format:  "Load Failed: Data:{0}", arg0:  result.message), cancelButtonTitle:  0, onCancelCallback:  0);
        UnityEngine.Debug.LogError(message:  System.String.Format(format:  "Load Failed: Data:{0}", arg0:  result.message));
        this.onProcess.Invoke(arg1:  0.1f, arg2:  new System.Exception(message:  System.String.Format(format:  "Load Failed: Data:{0}", arg0:  result.message)));
        this.onFailed.Invoke(obj:  System.String.Format(format:  "Load Failed: Data:{0}", arg0:  result.message));
    }

}
