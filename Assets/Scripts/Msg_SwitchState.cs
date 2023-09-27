using UnityEngine;
[Serializable]
public class Controller_Network_NF.Msg_SwitchState : Controller_Network_NF.NFIRequest
{
    // Fields
    public InkWars.Model.BubbleTypes loadedBubble;
    public InkWars.Model.BubbleTypes spareBubble;
    public float revengeSuperLevel;
    
    // Methods
    public Controller_Network_NF.Msg_SwitchState(int msg_id, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, float revengeSuperLevel = 0)
    {
        val_1 = new System.Object();
        mem[1152921529303021840] = msg_id;
        this.loadedBubble = loadedBubble;
        this.spareBubble = spareBubble;
        this.revengeSuperLevel = revengeSuperLevel;
    }

}
