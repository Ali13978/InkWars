using UnityEngine;
[Serializable]
public class Controller_Network_NF.Msg_Int : Controller_Network_NF.NFIRequest
{
    // Fields
    public int value;
    
    // Methods
    public Controller_Network_NF.Msg_Int(int id, int value)
    {
        val_1 = new System.Object();
        mem[1152921529302549264] = id;
        this.value = value;
    }

}
