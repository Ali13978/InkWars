using UnityEngine;
[Serializable]
public class Controller_Network_NF.Msg_RevengeSuper : Controller_Network_NF.NFIRequest
{
    // Fields
    public InkWars.Model.BubbleTypes bubbleType;
    public InkWars.Model.RevengeSuperEventState state;
    
    // Methods
    public Controller_Network_NF.Msg_RevengeSuper(InkWars.Model.BubbleTypes bubbleType, InkWars.Model.RevengeSuperEventState state)
    {
        val_1 = new System.Object();
        mem[1152921529303636368] = 211;
        this.bubbleType = bubbleType;
        this.state = state;
    }

}
