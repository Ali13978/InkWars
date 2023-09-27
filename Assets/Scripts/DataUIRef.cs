using UnityEngine;
[Serializable]
public class GameOverPanel.DataUIRef
{
    // Fields
    public UnityEngine.UI.Text winnerTitle;
    public UnityEngine.UI.Text scoreText;
    public UnityEngine.UI.Image leftCharacterImage;
    public UnityEngine.UI.Image rightCharacterImage;
    public UnityEngine.UI.Text quoteText;
    public UserBattleDataPanel leftDataPanel;
    public UserBattleDataPanel rightDataPanel;
    public View_PVPGameOverQuote quoteData;
    public UnityEngine.GameObject musselBox;
    public ShareScreenButton shareButton;
    public UnityEngine.UI.Text extraScoreText;
    
    // Methods
    public GameOverPanel.DataUIRef()
    {
    
    }

}
