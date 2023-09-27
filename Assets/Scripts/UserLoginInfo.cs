using UnityEngine;
[Serializable]
public class NFUser.UserLoginInfo
{
    // Fields
    public string name;
    public string password;
    public string serverId;
    public string ggpRefreshCode;
    public string userJWT;
    public string ggpJWT;
    public string ggpJwtType;
    
    // Methods
    public void Clear()
    {
        this.ggpJwtType = 0;
        this.serverId = 0;
        this.userJWT = 0;
        this.name = 0;
    }
    public NFUser.UserLoginInfo()
    {
    
    }

}
