using UnityEngine;
private sealed class NFClientUser.<>c__DisplayClass73_0
{
    // Fields
    public UnityEngine.Events.UnityAction<NFClientUser.NFResponseRoom> callback;
    
    // Methods
    public NFClientUser.<>c__DisplayClass73_0()
    {
    
    }
    internal void <JoinRoom>b__0(IResponse response)
    {
        object val_1 = HttpNetworkingExecutor.HttpResponseToCustomResponse<System.Object>(response:  response);
        if(val_1 != null)
        {
                bool val_2 = val_1.IsSuccess;
        }
        
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke(arg0:  val_1);
    }

}
