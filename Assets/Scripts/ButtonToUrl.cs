using UnityEngine;
public class ButtonToUrl : MonoBehaviour
{
    // Fields
    public string url;
    
    // Methods
    private void OnEnable()
    {
        this.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ButtonToUrl::OpenUrl()));
    }
    private void OnDisable()
    {
        this.GetComponent<UnityEngine.UI.Button>().onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ButtonToUrl::OpenUrl()));
    }
    private void OpenUrl()
    {
        GameAudio.PlayButtonSound();
        UnityEngine.Application.OpenURL(url:  this.url);
    }
    public ButtonToUrl()
    {
    
    }

}
