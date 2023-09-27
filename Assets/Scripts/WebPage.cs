using UnityEngine;
public class WebPage : MonoBehaviour
{
    // Fields
    private string webPage;
    private UnityEngine.UI.Button webPageButton;
    private bool leftApp;
    
    // Methods
    private void OnEnable()
    {
        this.webPageButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void WebPage::OnClickButton()));
    }
    private void OnDisable()
    {
        this.webPageButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void WebPage::OnClickButton()));
    }
    private System.Collections.IEnumerator OpenWebPage()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new WebPage.<OpenWebPage>d__4();
    }
    private void OnApplicationPause()
    {
        this.leftApp = true;
    }
    private void OnClickButton()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "OpenWebPage");
    }
    public WebPage()
    {
    
    }

}
