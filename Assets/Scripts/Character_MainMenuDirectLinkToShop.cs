using UnityEngine;
public class Character_MainMenuDirectLinkToShop : MonoBehaviour
{
    // Fields
    public CharacterNameID charNameID;
    
    // Methods
    private void Start()
    {
        this.gameObject.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void Character_MainMenuDirectLinkToShop::GoToShop()));
    }
    public void GoToShop()
    {
        var val_1;
        GameAudio.PlayButtonSound();
        val_1 = null;
        val_1 = null;
        sceneCharacters.DirectCharacterLink = 42;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_Characters");
    }
    public Character_MainMenuDirectLinkToShop()
    {
    
    }

}
