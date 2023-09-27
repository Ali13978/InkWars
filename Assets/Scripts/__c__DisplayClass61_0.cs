using UnityEngine;
private sealed class MMOCClientUser.<>c__DisplayClass61_0
{
    // Fields
    public UnityEngine.Events.UnityAction<MMOCClientUser.JoinedPoolData> onAddGemsDone;
    
    // Methods
    public MMOCClientUser.<>c__DisplayClass61_0()
    {
    
    }
    internal void <AddGems>b__0(BestHTTP.HTTPRequest originalRequest, BestHTTP.HTTPResponse response)
    {
        if(this.onAddGemsDone == null)
        {
                return;
        }
        
        this.onAddGemsDone.Invoke(arg0:  HttpNetworkingExecutor.BestHttpResponseToCustomResponse<JoinedPoolData>(response:  response));
    }

}
