using UnityEngine;
public class NFUser.UserInfo
{
    // Fields
    public const string ACCOUNT_TYPE_EMAIL = "Email";
    public const string ACCOUNT_TYPE_FACEBOOK = "Facebook";
    public const string ACCOUNT_TYPE_GGP = "GGP";
    public string _account;
    public string _password;
    public string _accountType;
    public string _userJWT;
    public string _ggpJWT;
    public string _ggpJwtType;
    public string _refreshCode;
    
    // Properties
    public string account { get; set; }
    public string password { get; set; }
    public string accountType { get; set; }
    public string userJWT { get; set; }
    public string refreshCode { get; set; }
    public string ggpJWT { get; set; }
    public string ggpJwtType { get; set; }
    public bool isFacebookAccount { get; set; }
    public bool isGGPAccount { get; set; }
    public bool isEmailAccount { get; set; }
    
    // Methods
    public string get_account()
    {
        string val_3 = this._account;
        if(val_3 != null)
        {
                return val_3;
        }
        
        bool val_2 = NFUser.current.TryLoadFromDevice();
        val_3 = this._account;
        return val_3;
    }
    public void set_account(string value)
    {
        this._account = value;
        this.Save();
    }
    public string get_password()
    {
        string val_3 = this._password;
        if(val_3 != null)
        {
                return val_3;
        }
        
        bool val_2 = NFUser.current.TryLoadFromDevice();
        val_3 = this._password;
        return val_3;
    }
    public void set_password(string value)
    {
        this._password = value;
        this.Save();
    }
    public string get_accountType()
    {
        string val_3 = this._accountType;
        if(val_3 != null)
        {
                return val_3;
        }
        
        bool val_2 = NFUser.current.TryLoadFromDevice();
        val_3 = this._accountType;
        return val_3;
    }
    public void set_accountType(string value)
    {
        this._accountType = value;
        this.Save();
    }
    public string get_userJWT()
    {
        string val_3 = this._userJWT;
        if(val_3 != null)
        {
                return val_3;
        }
        
        bool val_2 = NFUser.current.TryLoadFromDevice();
        val_3 = this._userJWT;
        return val_3;
    }
    public void set_userJWT(string value)
    {
        this._userJWT = value;
        this.Save();
    }
    public string get_refreshCode()
    {
        string val_3 = this._refreshCode;
        if(val_3 != null)
        {
                return val_3;
        }
        
        bool val_2 = NFUser.current.TryLoadFromDevice();
        val_3 = this._refreshCode;
        return val_3;
    }
    public void set_refreshCode(string value)
    {
        this._refreshCode = value;
        this.Save();
    }
    public string get_ggpJWT()
    {
        string val_3 = this._ggpJWT;
        if(val_3 != null)
        {
                return val_3;
        }
        
        bool val_2 = NFUser.current.TryLoadFromDevice();
        val_3 = this._ggpJWT;
        return val_3;
    }
    public void set_ggpJWT(string value)
    {
        this._ggpJWT = value;
        this.Save();
    }
    public string get_ggpJwtType()
    {
        string val_3 = this._ggpJwtType;
        if(val_3 != null)
        {
                return val_3;
        }
        
        bool val_2 = NFUser.current.TryLoadFromDevice();
        val_3 = this._ggpJwtType;
        return val_3;
    }
    public void set_ggpJwtType(string value)
    {
        this._ggpJwtType = value;
        this.Save();
    }
    private void Save()
    {
        GameServerInfo val_2 = NFUser.current.Server;
        NFUser.SaveToDevice(userName:  this._account, aNewPassword:  this._password, jwt:  this._userJWT, ggpJwt:  this._ggpJWT, ggpJwtType:  this._ggpJwtType, refreshCode:  this._refreshCode, aNewServerId:  val_2.id);
    }
    public bool get_isFacebookAccount()
    {
        return System.String.op_Equality(a:  "Facebook", b:  this.accountType);
    }
    public void set_isFacebookAccount(bool value)
    {
        this._accountType = (value != true) ? "Facebook" : 0;
        this.Save();
    }
    public bool get_isGGPAccount()
    {
        return System.String.op_Equality(a:  "GGP", b:  this.accountType);
    }
    public void set_isGGPAccount(bool value)
    {
        this._accountType = (value != true) ? "GGP" : 0;
        this.Save();
    }
    public bool get_isEmailAccount()
    {
        return System.String.op_Equality(a:  "Email", b:  this.accountType);
    }
    public void set_isEmailAccount(bool value)
    {
        this._accountType = (value != true) ? "Email" : 0;
        this.Save();
    }
    public void Clear()
    {
        this._account = 0;
        this.Save();
        this._password = 0;
        this.Save();
        this._accountType = 0;
        this.Save();
        this._userJWT = 0;
        this.Save();
        this._ggpJWT = 0;
        this.Save();
        this._refreshCode = 0;
        this.Save();
    }
    public NFUser.UserInfo()
    {
    
    }

}
