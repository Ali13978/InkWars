using UnityEngine;
private sealed class NFClientUser.<>c__DisplayClass34_0
{
    // Fields
    public NFClientUser <>4__this;
    public UnityEngine.Events.UnityAction<NFClientUser.RefreshDataResponse> callback;
    
    // Methods
    public NFClientUser.<>c__DisplayClass34_0()
    {
    
    }
    internal void <IWRefresh>b__0(IResponse response)
    {
        UserInfo val_5;
        RefreshDataResponse val_1 = HttpNetworkingExecutor.HttpResponseToCustomResponse<RefreshDataResponse>(response:  response);
        if(val_1.IsSuccess == false)
        {
            goto label_4;
        }
        
        if(val_1 == null)
        {
            goto label_5;
        }
        
        if((this.<>4__this) != null)
        {
            goto label_18;
        }
        
        label_19:
        label_18:
        this.<>4__this.<JWT_TOKEN>k__BackingField = val_1.jwt;
        NFUser val_3 = NFUser.current;
        val_3.loginUserInfo._account = this.<>4__this.<User>k__BackingField;
        val_3.loginUserInfo.Save();
        NFUser val_4 = NFUser.current;
        val_5 = val_4.loginUserInfo;
        val_4.loginUserInfo._userJWT = this.<>4__this.<JWT_TOKEN>k__BackingField;
        val_5.Save();
        IWServerDB_Cache.EnableSaveRoutine(enable:  true);
        label_4:
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke(arg0:  val_1);
        return;
        label_5:
        if((this.<>4__this) != null)
        {
            goto label_18;
        }
        
        goto label_19;
    }

}
