using UnityEngine;
public class scenePlayerChange : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject phoneCanvas;
    public UnityEngine.GameObject tabCanvas;
    
    // Methods
    private void Awake()
    {
        UnityEngine.GameObject val_3;
        if(UnityEngine.Camera.main.aspect >= 1.6f)
        {
            goto label_1;
        }
        
        this.tabCanvas.SetActive(value:  true);
        val_3 = this.phoneCanvas;
        if(val_3 != null)
        {
            goto label_6;
        }
        
        goto label_4;
        label_1:
        this.phoneCanvas.SetActive(value:  true);
        val_3 = this.tabCanvas;
        if(val_3 != null)
        {
            goto label_6;
        }
        
        label_4:
        label_6:
        val_3.SetActive(value:  false);
    }
    public void backButton()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        UnityEngine.Object.Destroy(obj:  MainTitleBackMusicHandler.instance.gameObject);
        GameAudio.PlayButtonSound();
        val_3 = null;
        val_3 = null;
        mainTitle.ShowModeSelectImmediately = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu_Title_Screen");
    }
    public void buttonIka()
    {
        GameAudio.PlayButtonSound();
        Character_GlobalInfo.SetMainPlayer(nameID:  7);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_CharacterSelection_Adventure");
    }
    public void buttonTako()
    {
        GameAudio.PlayButtonSound();
        Character_GlobalInfo.SetMainPlayer(nameID:  20);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_CharacterSelection_Adventure");
    }
    public scenePlayerChange()
    {
    
    }

}
