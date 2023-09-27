using UnityEngine;
[Serializable]
public class Controller_Network_NF.Msg_PlayerState : Controller_Network_NF.NFIRequest
{
    // Fields
    public InkWars.Model.PlayerState data;
    
    // Methods
    public Controller_Network_NF.Msg_PlayerState(InkWars.Model.PlayerState Data)
    {
        val_1 = new System.Object();
        mem[1152921529302897552] = 203;
        this.data = Data;
    }

}
