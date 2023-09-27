using UnityEngine;
private sealed class NFClientUser.<>c__DisplayClass70_0
{
    // Fields
    public NFClientUser <>4__this;
    public UnityEngine.Events.UnityAction<NFClientUser.NFResponsCreateRoom> callback;
    
    // Methods
    public NFClientUser.<>c__DisplayClass70_0()
    {
    
    }
    internal void <CreateRoom>b__0(IResponse response)
    {
        string val_3;
        var val_4;
        NFResponsCreateRoom val_1 = HttpNetworkingExecutor.HttpResponseToCustomResponse<NFResponsCreateRoom>(response:  response);
        if(val_1 != null)
        {
                if(val_1.IsSuccess != false)
        {
                this.<>4__this.<currentRoom>k__BackingField = val_1;
            val_3 = val_1.matchID;
            val_4 = null;
            val_4 = null;
            MatchID.matchID = val_3;
        }
        
        }
        
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke(arg0:  val_1);
    }

}
