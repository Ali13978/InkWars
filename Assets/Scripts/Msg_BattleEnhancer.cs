using UnityEngine;
[Serializable]
public class Controller_Network_NF.Msg_BattleEnhancer : Controller_Network_NF.NFIRequest
{
    // Fields
    public float timeStamp;
    public InkWars.Model.BattleEnhancerType type;
    public InkWars.Model.BattleEnhancerState state;
    public int level;
    
    // Methods
    public Controller_Network_NF.Msg_BattleEnhancer(float timeStamp, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)
    {
        val_1 = new System.Object();
        this.timeStamp = timeStamp;
        this.type = type;
        this.state = state;
        mem[1152921529303764752] = 212;
        this.level = level;
    }

}
