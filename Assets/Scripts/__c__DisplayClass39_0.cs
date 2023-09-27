using UnityEngine;
private sealed class NFClientUser.<>c__DisplayClass39_0
{
    // Fields
    public UnityEngine.Events.UnityAction<IResponse> callback;
    
    // Methods
    public NFClientUser.<>c__DisplayClass39_0()
    {
    
    }
    internal void <SaveRankData>b__0(IResponse response)
    {
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke(arg0:  HttpNetworkingExecutor.HttpResponseToCustomResponse<IResponse>(response:  response));
    }

}
