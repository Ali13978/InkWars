using UnityEngine;
[Serializable]
public class Controller_Network_NF.Msg_Bool : Controller_Network_NF.NFIRequest
{
    // Fields
    public bool value;
    
    // Methods
    public Controller_Network_NF.Msg_Bool(int id, bool value)
    {
        val_1 = new System.Object();
        mem[1152921529302437264] = id;
        this.value = value;
    }

}
