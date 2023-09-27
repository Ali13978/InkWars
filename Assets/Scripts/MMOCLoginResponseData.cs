using UnityEngine;
[Serializable]
public class MMOCClientUser.MMOCLoginResponseData : IResponse
{
    // Fields
    public string scope;
    public string token_type;
    public string access_token;
    public int expires_in;
    public string refresh_token;
    public string id_token;
    
    // Methods
    public MMOCClientUser.MMOCLoginResponseData()
    {
    
    }

}
