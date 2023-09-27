using UnityEngine;
public class GameResultInfo
{
    // Fields
    private GameResult <result>k__BackingField;
    private GameResultInfo.PlayerResultData <player1Data>k__BackingField;
    private GameResultInfo.PlayerResultData <player2Data>k__BackingField;
    
    // Properties
    public GameResult result { get; set; }
    public GameResultInfo.PlayerResultData player1Data { get; set; }
    public GameResultInfo.PlayerResultData player2Data { get; set; }
    
    // Methods
    public GameResult get_result()
    {
        return (GameResult)this.<result>k__BackingField;
    }
    protected void set_result(GameResult value)
    {
        this.<result>k__BackingField = value;
    }
    public GameResultInfo.PlayerResultData get_player1Data()
    {
        return (PlayerResultData)this.<player1Data>k__BackingField;
    }
    protected void set_player1Data(GameResultInfo.PlayerResultData value)
    {
        this.<player1Data>k__BackingField = value;
    }
    public GameResultInfo.PlayerResultData get_player2Data()
    {
        return (PlayerResultData)this.<player2Data>k__BackingField;
    }
    protected void set_player2Data(GameResultInfo.PlayerResultData value)
    {
        this.<player2Data>k__BackingField = value;
    }
    public GameResultInfo()
    {
        this.<player1Data>k__BackingField = new GameResultInfo.PlayerResultData();
        this.<player2Data>k__BackingField = new GameResultInfo.PlayerResultData();
    }
    public void OnGameResult(GameResult aNewResult)
    {
        var val_8;
        this.<result>k__BackingField = aNewResult;
        val_8 = null;
        val_8 = null;
        this.<player1Data>k__BackingField.remainBallCount = GameInfo.inGame.GetPlayerBallCount(pid:  0);
        this.<player2Data>k__BackingField.remainBallCount = GameInfo.inGame.GetPlayerBallCount(pid:  1);
        string[] val_3 = new string[5];
        string val_4 = aNewResult.ToString();
        aNewResult.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
        if(val_3 == null)
        {
            goto label_9;
        }
        
        if(val_4 != null)
        {
            goto label_10;
        }
        
        goto label_13;
        label_9:
        if(val_4 == null)
        {
            goto label_13;
        }
        
        label_10:
        label_13:
        val_3[0] = val_4;
        val_3[1] = " ";
        val_3[2] = this.<player1Data>k__BackingField.remainBallCount.ToString();
        val_3[3] = " , ";
        val_3[4] = this.<player2Data>k__BackingField.remainBallCount.ToString();
        UnityEngine.Debug.Log(message:  +val_3);
    }

}
