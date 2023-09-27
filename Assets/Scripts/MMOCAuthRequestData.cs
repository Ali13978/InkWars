using UnityEngine;
[Serializable]
public class MMOCClientUser.MMOCAuthRequestData
{
    // Fields
    public string grant_type;
    public string code;
    public string client_id;
    public string redirect_uri;
    
    // Methods
    public MMOCClientUser.MMOCAuthRequestData()
    {
    
    }

}
