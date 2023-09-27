using UnityEngine;
private sealed class MMOCClientUser.<>c__DisplayClass63_0
{
    // Fields
    public MMOCClientUser <>4__this;
    public UnityEngine.Events.UnityAction<MMOCClientUser.MMOCUserProfile> onGetUserProfileDone;
    public UnityEngine.Events.UnityAction<bool, string> <>9__1;
    public UnityEngine.Events.UnityAction<bool, string> <>9__3;
    
    // Methods
    public MMOCClientUser.<>c__DisplayClass63_0()
    {
    
    }
    internal void <GetUserProfile>b__0(BestHTTP.HTTPRequest originalRequest, BestHTTP.HTTPResponse response)
    {
        UnityEngine.Events.UnityAction<MMOCUserProfile> val_20;
        System.Object[] val_21;
        val_20 = this;
        if((response != null) && (response.StatusCode == 200))
        {
                Newtonsoft.Json.JsonConverter[] val_3 = new Newtonsoft.Json.JsonConverter[1];
            new DecimalConverter() = new DecimalConverter();
            val_3[0] = new DecimalConverter();
            MMOCUserProfile val_5 = Newtonsoft.Json.JsonConvert.DeserializeObject<MMOCUserProfile>(value:  response.DataAsText, converters:  val_3);
            NFUser val_6 = NFUser.current;
            val_6.loginUserInfo.account = val_5.username;
            NFUser val_7 = NFUser.current;
            val_7.loginUserInfo.password = "ImGGPUser";
            NFUser val_8 = NFUser.current;
            val_8.loginUserInfo.isGGPAccount = true;
            mem[this.<>4__this].userProfile = val_5;
            object[] val_9 = new object[2];
            val_21 = val_9;
            val_21[0] = val_5.displayname;
            val_21[1] = val_5.gems;
            UnityEngine.Debug.LogFormat(format:  "MMOC User Profile: {0}, {1} gems", args:  val_9);
            if(this.onGetUserProfileDone == null)
        {
                return;
        }
        
            NFUser val_10 = NFUser.current;
            val_10.loginUserInfo.account = val_5.username;
            NFUser val_11 = NFUser.current;
            val_11.loginUserInfo.password = "ImGGPUser";
            NFUser val_12 = NFUser.current;
            val_21 = val_12.loginUserInfo;
            val_21.isGGPAccount = true;
            val_20 = this.onGetUserProfileDone;
            val_20.Invoke(arg0:  val_5);
            return;
        }
        
        if((this.<>9__1) == null)
        {
            goto label_39;
        }
        
        label_42:
        this.<>4__this.RefreshToken(onDone:  this.<>9__1);
        return;
        label_39:
        this.<>9__1 = new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  this, method:  System.Void MMOCClientUser.<>c__DisplayClass63_0::<GetUserProfile>b__1(bool succes, string info));
        if((this.<>4__this) != null)
        {
            goto label_42;
        }
        
        goto label_42;
    }
    internal void <GetUserProfile>b__1(bool succes, string info)
    {
        .info = info;
        if(succes != false)
        {
                this.<>4__this.GetUserProfile(onGetUserProfileDone:  this.onGetUserProfileDone);
            return;
        }
        
        ConnectionTester.TestConnection(callback:  new System.Action<System.Boolean, System.String>(object:  new MMOCClientUser.<>c__DisplayClass63_1(), method:  System.Void MMOCClientUser.<>c__DisplayClass63_1::<GetUserProfile>b__2(bool has, string msg)));
        this.onGetUserProfileDone.Invoke(arg0:  0);
    }
    internal void <GetUserProfile>b__3(bool succes, string info)
    {
        .info = info;
        if(succes != false)
        {
                this.<>4__this.GetUserProfile(onGetUserProfileDone:  this.onGetUserProfileDone);
            return;
        }
        
        ConnectionTester.TestConnection(callback:  new System.Action<System.Boolean, System.String>(object:  new MMOCClientUser.<>c__DisplayClass63_2(), method:  System.Void MMOCClientUser.<>c__DisplayClass63_2::<GetUserProfile>b__4(bool has, string msg)));
        this.onGetUserProfileDone.Invoke(arg0:  0);
    }

}
