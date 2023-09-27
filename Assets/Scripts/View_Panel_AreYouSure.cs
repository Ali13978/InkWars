using UnityEngine;
public class View_Panel_AreYouSure : MonoBehaviour
{
    // Fields
    public TMPro.TextMeshProUGUI Text_Heading;
    public string String_Restart;
    public string String_CharacterSelect;
    public string String_PreviousMenu;
    private AreYouSureType Type;
    
    // Methods
    public void OpenPanel(AreYouSureType type)
    {
        this.Type = type;
        if(type == 2)
        {
            goto label_0;
        }
        
        if(type == 1)
        {
            goto label_1;
        }
        
        if(type != 0)
        {
                return;
        }
        
        if(this.Text_Heading != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        this.Text_Heading.text = this.String_Restart;
        return;
        label_0:
        if(this.Text_Heading != null)
        {
            goto label_6;
        }
        
        goto label_7;
        label_1:
        if(this.Text_Heading != null)
        {
            goto label_6;
        }
        
        goto label_7;
    }
    public void Button_Yes()
    {
        var val_2;
        var val_3;
        string val_4;
        var val_5;
        val_2 = this;
        GameAudio.PlayButtonSound();
        if(this.Type == 2)
        {
            goto label_3;
        }
        
        if(this.Type == 1)
        {
            goto label_4;
        }
        
        if(this.Type != 0)
        {
                return;
        }
        
        val_2 = 1152921505064992768;
        val_3 = null;
        val_3 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
                return;
        }
        
        val_4 = "MVC_GameScene";
        goto label_25;
        label_3:
        val_2 = 1152921505064992768;
        val_5 = null;
        val_5 = null;
        if((Character_GlobalInfo.gameMode - 1) >= 4)
        {
            goto label_14;
        }
        
        val_4 = "Scene_CharacterSelection_Adventure";
        goto label_25;
        label_4:
        val_4 = "CharacterSelect";
        goto label_25;
        label_14:
        if((Character_GlobalInfo.gameMode != 5) && (Character_GlobalInfo.gameMode == 8))
        {
                val_4 = "QuickPlay";
        }
        else
        {
                val_4 = "Menu_Title_Screen";
        }
        
        label_25:
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  val_4);
    }
    public View_Panel_AreYouSure()
    {
    
    }

}
