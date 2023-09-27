using UnityEngine;
public class LobbyBackButton : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject toBeDisabled;
    
    // Methods
    private void OnEnable()
    {
        this.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LobbyBackButton::GoBack()));
    }
    private void OnDisable()
    {
        this.GetComponent<UnityEngine.UI.Button>().onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LobbyBackButton::GoBack()));
    }
    private void GoBack()
    {
        this.toBeDisabled.gameObject.SetActive(value:  false);
        ActiveCanvasController.Instance.ShowLobby();
    }
    public LobbyBackButton()
    {
    
    }

}
