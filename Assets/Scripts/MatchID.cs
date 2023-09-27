using UnityEngine;
public class MatchID : MonoBehaviour
{
    // Fields
    public TMPro.TextMeshProUGUI label;
    public static string matchID;
    
    // Methods
    private void Start()
    {
        null = null;
        this.label.text = "Match ID<br>"("Match ID<br>") + MatchID.matchID;
        this.CheckMode();
    }
    private void OnEnable()
    {
        null = null;
        this.label.text = "Match ID<br>"("Match ID<br>") + MatchID.matchID;
        this.CheckMode();
    }
    private void CheckMode()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if((Character_GlobalInfo.gameMode == 5) || (Character_GlobalInfo.IsAdventureMode() == true))
        {
            goto label_6;
        }
        
        val_5 = null;
        val_5 = null;
        if(Character_GlobalInfo.gameMode != 8)
        {
            goto label_9;
        }
        
        label_6:
        label_14:
        this.label.gameObject.SetActive(value:  false);
        return;
        label_9:
        if(this.label.gameObject != null)
        {
            goto label_14;
        }
        
        goto label_14;
    }
    public MatchID()
    {
    
    }
    private static MatchID()
    {
        MatchID.matchID = "";
    }

}
