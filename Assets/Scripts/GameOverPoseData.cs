using UnityEngine;
[Serializable]
public class GameOverPoseData
{
    // Fields
    public UnityEngine.Sprite winPose;
    public UnityEngine.Sprite losePose;
    public UnityEngine.Sprite drawPose;
    public string winQuote20Balls;
    public string winQuote19Balls;
    public string winQuote5Balls;
    public string winQuoteSameCharacter;
    
    // Methods
    public UnityEngine.Sprite GetPose(GameResult result, bool isLocalPlayer)
    {
        UnityEngine.Sprite val_1;
        if(result == 2)
        {
            goto label_2;
        }
        
        if(result == 1)
        {
            goto label_1;
        }
        
        if(result != 0)
        {
            goto label_2;
        }
        
        if(isLocalPlayer == false)
        {
            goto label_3;
        }
        
        label_6:
        val_1 = this.winPose;
        return (UnityEngine.Sprite)mem[this.losePose];
        label_2:
        val_1 = this.drawPose;
        return (UnityEngine.Sprite)mem[this.losePose];
        label_1:
        if(isLocalPlayer == false)
        {
            goto label_6;
        }
        
        label_3:
        val_1 = this.losePose;
        return (UnityEngine.Sprite)mem[this.losePose];
    }
    public string GetQuoteByBallRemain(int remainBallCount)
    {
        string val_1;
        if(remainBallCount >= 20)
        {
                val_1 = this.winQuote20Balls;
            return (string)mem[this.winQuote5Balls];
        }
        
        if(remainBallCount >= 6)
        {
                val_1 = this.winQuote19Balls;
            return (string)mem[this.winQuote5Balls];
        }
        
        val_1 = this.winQuote5Balls;
        return (string)mem[this.winQuote5Balls];
    }
    public GameOverPoseData()
    {
    
    }

}
