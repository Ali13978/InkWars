using UnityEngine;
[Serializable]
public class IResponse
{
    // Fields
    public string msg;
    public long statusCode;
    
    // Properties
    public bool IsSuccess { get; }
    
    // Methods
    public IResponse()
    {
        this.msg = "";
    }
    public IResponse(long statusCode, string msg)
    {
        this.msg = "";
        val_1 = new System.Object();
        this.msg = val_1;
        this.statusCode = statusCode;
    }
    public bool get_IsSuccess()
    {
        return (bool)(this.statusCode == 200) ? 1 : 0;
    }
    public string ToJson()
    {
        return UnityEngine.JsonUtility.ToJson(obj:  this);
    }

}
