using UnityEngine;
public class FacebookPage : MonoBehaviour
{
    // Fields
    private string facebookPageLink;
    private string facebookPageID;
    private UnityEngine.UI.Button facebookButton;
    private bool leftApp;
    
    // Methods
    private void OnEnable()
    {
        this.facebookButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void FacebookPage::OnClickButton()));
    }
    private void OnDisable()
    {
        this.facebookButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void FacebookPage::OnClickButton()));
    }
    private System.Collections.IEnumerator OpenFacebookPage()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new FacebookPage.<OpenFacebookPage>d__5();
    }
    private void OnApplicationPause()
    {
        this.leftApp = true;
    }
    private void OnClickButton()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "OpenFacebookPage");
    }
    public FacebookPage()
    {
    
    }

}
