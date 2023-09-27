using UnityEngine;
[Serializable]
public class Controller_Network_NF.Msg_PlayerData : Controller_Network_NF.NFIRequest
{
    // Fields
    public NetworkUserInfo data;
    public bool updateDataOnly;
    
    // Methods
    public Controller_Network_NF.Msg_PlayerData(NetworkUserInfo Data, bool onlyUpdateData = False)
    {
        val_1 = new System.Object();
        this.data = Data;
        mem[1152921529302777360] = 201;
        this.updateDataOnly = onlyUpdateData;
    }

}
