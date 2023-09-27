using UnityEngine;
[Serializable]
public class Controller_Network_NF.Msg_SyncData : Controller_Network_NF.NFIRequest
{
    // Fields
    public float gameTime;
    public InkWars.Model.GameResult result;
    public InkWars.Model.BubbleTypes[] innerRing1;
    public InkWars.Model.BubbleTypes[] middleRing1;
    public InkWars.Model.BubbleTypes[] outerRing1;
    public bool isReady;
    
    // Methods
    public Controller_Network_NF.Msg_SyncData(int id, float gameTime, InkWars.Model.GameResult result, InkWars.Model.BubbleTypes[] innerRing1, InkWars.Model.BubbleTypes[] middleRing1, InkWars.Model.BubbleTypes[] outerRing1, bool isReady)
    {
        val_1 = new System.Object();
        mem[1152921529303401488] = id;
        this.gameTime = gameTime;
        this.result = result;
        this.innerRing1 = innerRing1;
        this.middleRing1 = middleRing1;
        this.outerRing1 = outerRing1;
        this.isReady = isReady;
    }

}
