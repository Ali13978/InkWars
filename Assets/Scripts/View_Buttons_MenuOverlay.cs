using UnityEngine;
public class View_Buttons_MenuOverlay : MonoBehaviour
{
    // Methods
    public void Button_MainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu_Title_Screen");
    }
    public void Button_Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "MVC_GameScene");
    }
    public void Button_CharacterSelect()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "CharacterSelect");
    }
    public View_Buttons_MenuOverlay()
    {
    
    }

}
