using UnityEngine;
[Serializable]
public class Controller_Network_NF.Msg_Float : Controller_Network_NF.NFIRequest
{
    // Fields
    public float value;
    
    // Methods
    public Controller_Network_NF.Msg_Float(int id, float value)
    {
        val_1 = new System.Object();
        mem[1152921529302661264] = id;
        this.value = value;
    }

}
