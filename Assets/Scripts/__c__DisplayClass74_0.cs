using UnityEngine;
private sealed class NFClientUser.<>c__DisplayClass74_0
{
    // Fields
    public UnityEngine.Events.UnityAction<NFClientUser.NFResponseRoom> callback;
    
    // Methods
    public NFClientUser.<>c__DisplayClass74_0()
    {
    
    }
    internal void <RoomStatus>b__0(IResponse response)
    {
        NFResponseRoom val_1 = HttpNetworkingExecutor.HttpResponseToCustomResponse<NFResponseRoom>(response:  response);
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
