using UnityEngine;
[Serializable]
public class Controller_Network_NF.Msg_Shoot : Controller_Network_NF.NFIRequest
{
    // Fields
    public float gameTime;
    public InkWars.Model.AimTarget aimTarget;
    public InkWars.Model.BubbleTypes shotBubble;
    public InkWars.Model.BubbleTypes loadedBubble;
    public InkWars.Model.BubbleTypes spareBubble;
    
    // Methods
    public Controller_Network_NF.Msg_Shoot(float gameTime, InkWars.Model.AimTarget aimTarget, InkWars.Model.BubbleTypes shotBubble, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)
    {
        val_1 = new System.Object();
        this.gameTime = gameTime;
        this.aimTarget = aimTarget;
        this.shotBubble = shotBubble;
        mem[1152921529303158416] = 206;
        this.loadedBubble = loadedBubble;
        this.spareBubble = spareBubble;
    }

}
