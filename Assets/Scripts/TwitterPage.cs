using UnityEngine;
public class TwitterPage : MonoBehaviour
{
    // Fields
    private string userName;
    private UnityEngine.UI.Button twitterButton;
    private bool leftApp;
    
    // Methods
    private void OnEnable()
    {
        this.twitterButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void TwitterPage::OnClickButton()));
    }
    private void OnDisable()
    {
        this.twitterButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void TwitterPage::OnClickButton()));
    }
    private System.Collections.IEnumerator OpenTwitter()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new TwitterPage.<OpenTwitter>d__4();
    }
    private void OnApplicationPause()
    {
        this.leftApp = true;
    }
    private void OnClickButton()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "OpenTwitter");
    }
    public TwitterPage()
    {
    
    }

}
