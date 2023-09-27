using UnityEngine;
public class AdvTutorialButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button btn;
    private UnityEngine.Animator btnAnimator;
    
    // Methods
    private void Awake()
    {
        this.btn = this.GetComponent<UnityEngine.UI.Button>();
        this.btnAnimator = this.GetComponent<UnityEngine.Animator>();
        this.btn.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AdvTutorialButton::OnClick()));
    }
    private void OnClick()
    {
        var val_3;
        DeviceBasedData.playerAtLeftForQuickPlay = false;
        val_3 = null;
        val_3 = null;
        DataStructs.UserDataDictionary.Settings.FlipNegateX = 1;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        TutorialDataManager.LoadTutorial(advanced:  true, nextScene:  val_1.m_Handle.name, showLoadingScreen:  true, preload:  false);
    }
    private void OnEnable()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        this.btnAnimator.enabled = (~DataStructs.UserDataDictionary.GameSave.AdvancedTutorialPlayed) & 1;
        val_5 = null;
        val_5 = null;
        InkWars.Model.MVCNetworkManager.OnMatchButtonInteractableChange.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void AdvTutorialButton::OnNetworkProcessInteractableChanged(bool enable)));
    }
    private void OnDisable()
    {
        null = null;
        InkWars.Model.MVCNetworkManager.OnMatchButtonInteractableChange.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void AdvTutorialButton::OnNetworkProcessInteractableChanged(bool enable)));
    }
    private void OnNetworkProcessInteractableChanged(bool enable)
    {
        enable = enable;
        this.btn.interactable = enable;
    }
    public AdvTutorialButton()
    {
    
    }

}
