using UnityEngine;
public class OpenLinkBehaviour : MonoBehaviour
{
    // Fields
    public string Url;
    
    // Methods
    private void Start()
    {
        this.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void OpenLinkBehaviour::Open()));
    }
    public void Open()
    {
        UnityEngine.Application.OpenURL(url:  this.Url);
    }
    public OpenLinkBehaviour()
    {
    
    }

}
