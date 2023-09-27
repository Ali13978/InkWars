using UnityEngine;
private sealed class NFClientUser.<>c__DisplayClass29_0
{
    // Fields
    public NFClientUser <>4__this;
    public string username;
    public UnityEngine.Events.UnityAction<NFClientUser.LoginDataResponse> callback;
    
    // Methods
    public NFClientUser.<>c__DisplayClass29_0()
    {
    
    }
    internal void <GGPLogin>b__0(IResponse response)
    {
        UserInfo val_5;
        LoginDataResponse val_1 = HttpNetworkingExecutor.HttpResponseToCustomResponse<LoginDataResponse>(response:  response);
        if(val_1 != null)
        {
                if(val_1.IsSuccess != false)
        {
                this.<>4__this.<User>k__BackingField = this.username;
            this.<>4__this.<JWT_TOKEN>k__BackingField = val_1.jwt;
            NFUser val_3 = NFUser.current;
            val_3.loginUserInfo._account = this.<>4__this.<User>k__BackingField;
            val_3.loginUserInfo.Save();
            NFUser val_4 = NFUser.current;
            val_5 = val_4.loginUserInfo;
            val_4.loginUserInfo._userJWT = this.<>4__this.<JWT_TOKEN>k__BackingField;
            val_5.Save();
            IWServerDB_Cache.EnableSaveRoutine(enable:  true);
        }
        
        }
        
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke(arg0:  val_1);
    }

}
