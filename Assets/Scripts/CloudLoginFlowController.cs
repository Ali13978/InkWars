using UnityEngine;
public class CloudLoginFlowController : MonoBehaviour
{
    // Fields
    private TitleButtonAnimationController titleButtonAnimController;
    private UserPanelInTitle userPanelInTitle;
    
    // Properties
    private float animDuration { get; }
    
    // Methods
    private float get_animDuration()
    {
        null = null;
        return (float)(mainTitle.ShowModeSelectImmediately == false) ? 0.5f : 0.01f;
    }
    private void OnEnable()
    {
        this.InitAnimation();
    }
    private void InitAnimation()
    {
        var val_5;
        this.SetText(info:  0);
        if(LoadingScreenController.isShowing != false)
        {
                val_5 = null;
            val_5 = null;
            LoadingScreenController.OnFlyOutDone.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CloudLoginFlowController::OnLoadingScreenFlyOut()));
            return;
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.DelayStartAnimation());
    }
    private System.Collections.IEnumerator DelayStartAnimation()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new CloudLoginFlowController.<DelayStartAnimation>d__6();
    }
    private void OnLoadingScreenFlyOut()
    {
        null = null;
        LoadingScreenController.OnFlyOutDone.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CloudLoginFlowController::OnLoadingScreenFlyOut()));
        this.StartGameTitleFlow();
    }
    private void StartGameTitleFlow()
    {
        UnityEngine.GameObject val_1 = this.titleButtonAnimController.gameObject;
        val_1.SetActive(value:  true);
        this.titleButtonAnimController.Enter(duration:  val_1.animDuration, onDone:  0);
        this.userPanelInTitle.gameObject.SetActive(value:  false);
        this.userPanelInTitle.gameObject.SetActive(value:  true);
    }
    private void SetText(string info)
    {
        if((System.String.IsNullOrEmpty(value:  info)) != false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  info);
    }
    public CloudLoginFlowController()
    {
    
    }

}
