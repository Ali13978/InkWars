using UnityEngine;
public class InternetGameVersionCheckButton : MonoBehaviour
{
    // Fields
    public mainTitle mainTitleScript;
    public UnityEngine.UI.Button targetButton;
    
    // Methods
    private void OnEnable()
    {
        if(0 == this.targetButton)
        {
                return;
        }
        
        this.targetButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void InternetGameVersionCheckButton::OnClick()));
    }
    private void OnDisable()
    {
        if(0 == this.targetButton)
        {
                return;
        }
        
        this.targetButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void InternetGameVersionCheckButton::OnClick()));
    }
    private void OnClick()
    {
        GameVersionCheck.CheckGameVersion(OnDone:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void InternetGameVersionCheckButton::OnVersionCorrect()), showLoadingWhenProc:  true);
    }
    private void OnVersionCorrect()
    {
        if(0 == this.mainTitleScript)
        {
                return;
        }
        
        this.mainTitleScript.RankingVsClicked();
    }
    public InternetGameVersionCheckButton()
    {
    
    }

}
