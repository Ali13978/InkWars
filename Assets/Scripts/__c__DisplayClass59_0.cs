using UnityEngine;
private sealed class MMOCClientUser.<>c__DisplayClass59_0
{
    // Fields
    public MMOCClientUser <>4__this;
    public UnityEngine.Events.UnityAction<MMOCClientUser.JoinedPoolData> onJoinPoolDone;
    
    // Methods
    public MMOCClientUser.<>c__DisplayClass59_0()
    {
    
    }
    internal void <JoinPool>b__0(BestHTTP.HTTPRequest originalRequest, BestHTTP.HTTPResponse response)
    {
        JoinedPoolData val_4;
        MMOCClientUser.JoinedPoolData val_1 = null;
        val_4 = val_1;
        val_1 = new MMOCClientUser.JoinedPoolData();
        this.<>4__this.poolData = val_4;
        if(response.StatusCode == 200)
        {
                this.<>4__this.<originGemsBeforeJoinPool>k__BackingField = this.<>4__this._profile.gems;
            mem2[0] = ???;
            val_4 = this.<>4__this;
            this.<>4__this.poolData = HttpNetworkingExecutor.BestHttpResponseToCustomResponse<JoinedPoolData>(response:  response);
        }
        
        if(this.onJoinPoolDone == null)
        {
                return;
        }
        
        this.onJoinPoolDone.Invoke(arg0:  this.<>4__this.poolData);
    }

}
