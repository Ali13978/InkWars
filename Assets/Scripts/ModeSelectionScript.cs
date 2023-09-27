using UnityEngine;
public class ModeSelectionScript : MonoBehaviour
{
    // Methods
    public void loadLevelMap(UnityEngine.GameObject buttonName)
    {
        GameMode val_5;
        var val_6;
        string val_1 = buttonName.name;
        if((System.String.op_Equality(a:  val_1, b:  "Button_PuzzleLevel")) == false)
        {
            goto label_2;
        }
        
        val_5 = 3;
        goto label_13;
        label_2:
        if((System.String.op_Equality(a:  val_1, b:  "Button_vsCpuLevel")) == false)
        {
            goto label_6;
        }
        
        val_6 = null;
        goto label_9;
        label_6:
        if((System.String.op_Equality(a:  val_1, b:  "Button_vsCpuSpecial")) == false)
        {
            goto label_10;
        }
        
        val_5 = 4;
        goto label_13;
        label_10:
        val_6 = null;
        label_9:
        val_5 = 1;
        label_13:
        Character_GlobalInfo.gameMode = val_5;
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "PlayScene");
    }
    public ModeSelectionScript()
    {
    
    }

}
