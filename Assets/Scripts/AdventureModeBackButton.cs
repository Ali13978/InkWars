using UnityEngine;
public class AdventureModeBackButton : MonoBehaviour
{
    // Methods
    public void BackButton()
    {
        var val_2;
        var val_3;
        string val_4;
        var val_5;
        val_2 = null;
        val_2 = null;
        UnityEngine.Object.Destroy(obj:  MainTitleBackMusicHandler.instance.gameObject);
        GameAudio.PlayButtonSound();
        val_3 = null;
        val_3 = null;
        if(Character_GlobalInfo.isOfflineMode != false)
        {
                val_4 = "OfflineTitleScreen";
        }
        else
        {
                val_5 = null;
            val_5 = null;
            mainTitle.ShowModeSelectImmediately = false;
            val_4 = "Menu_Title_Screen";
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  val_4);
    }
    public AdventureModeBackButton()
    {
    
    }

}
