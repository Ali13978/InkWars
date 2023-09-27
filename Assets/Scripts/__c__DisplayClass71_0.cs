using UnityEngine;
private sealed class NFClientUser.<>c__DisplayClass71_0
{
    // Fields
    public NFClientUser <>4__this;
    public UnityEngine.Events.UnityAction<IResponse> callback;
    
    // Methods
    public NFClientUser.<>c__DisplayClass71_0()
    {
    
    }
    internal void <LeaveRoom>b__0(IResponse response)
    {
        IResponse val_1 = HttpNetworkingExecutor.HttpResponseToCustomResponse<IResponse>(response:  response);
        if(val_1 != null)
        {
                if(val_1.IsSuccess != false)
        {
                this.<>4__this.<currentRoom>k__BackingField = 0;
        }
        
        }
        
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke(arg0:  val_1);
    }

}
