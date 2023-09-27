using UnityEngine;
public class NetworkUISidebar : NetworkUIMenu
{
    // Fields
    private NetworkUIController m_NetworkUIController;
    private UnityEngine.UI.VerticalLayoutGroup m_VerticalLayoutGroup;
    private UnityEngine.UI.Image m_SelectedMenuHoverImage;
    private float m_HoverOffsetPosition;
    private bool m_RotateClockwise;
    private DG.Tweening.Tween HoverFade;
    private DG.Tweening.Tween HoverRotate;
    private UnityEngine.RectTransform m_MenuPanel;
    private UnityEngine.RectTransform m_CasualMenuButton;
    private UnityEngine.RectTransform m_RankedMenuButton;
    private UnityEngine.RectTransform m_LeaderboardsMenuButton;
    private UnityEngine.RectTransform m_CustomizationMenuButton;
    private UnityEngine.RectTransform m_StatsModeButton;
    private UnityEngine.UI.Button m_BackButton;
    private NetworkUIController.MenuType m_LastMenu;
    private NetworkUIController.MenuType m_CurrentMenu;
    private string m_ExitScene;
    private UnityEngine.GameObject ExpressPurchase_Shells;
    
    // Methods
    private void Awake()
    {
        this.m_VerticalLayoutGroup.enabled = false;
        this.m_SelectedMenuHoverImage.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        if(0 != this.m_NetworkUIController)
        {
                return;
        }
        
        this.m_NetworkUIController = this.GetComponentInParent<NetworkUIController>();
    }
    private void OnEnable()
    {
        var val_4;
        this.m_BackButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void NetworkUISidebar::BackToTitle()));
        val_4 = null;
        val_4 = null;
        InkWars.Model.MVCNetworkManager.OnMatchButtonInteractableChange.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void NetworkUISidebar::OnNetworkProcessInteractableChanged(bool enable)));
    }
    private void OnDisable()
    {
        var val_4;
        this.m_BackButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void NetworkUISidebar::BackToTitle()));
        val_4 = null;
        val_4 = null;
        InkWars.Model.MVCNetworkManager.OnMatchButtonInteractableChange.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void NetworkUISidebar::OnNetworkProcessInteractableChanged(bool enable)));
    }
    private void OnNetworkProcessInteractableChanged(bool enable)
    {
        this.m_RankedMenuButton.GetComponent<UnityEngine.UI.Button>().interactable = enable;
        this.m_LeaderboardsMenuButton.GetComponent<UnityEngine.UI.Button>().interactable = enable;
        this.m_CustomizationMenuButton.GetComponent<UnityEngine.UI.Button>().interactable = enable;
        bool val_8 = enable;
        this.m_StatsModeButton.GetComponent<UnityEngine.UI.Button>().interactable = val_8;
        if(val_8 == true)
        {
                return;
        }
        
        if(this.m_CurrentMenu == 4)
        {
                return;
        }
        
        this.SelectMenu(_iMenu:  4);
    }
    private void Start()
    {
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_SelectedMenuHoverImage.rectTransform, endValue:  0.475f, duration:  0.35f), loops:  0, loopType:  1);
        DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_RankedMenuButton, endValue:  1.2f, duration:  0.3f), loops:  0, loopType:  1);
    }
    public void BackToTitle()
    {
        InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.BackToLobby();
        GameAudio.PlayButtonSound();
        InkWars.Model.MVC_Multiplayer_Manager_Base val_2 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
        val_2.ConnectionStatus = 0;
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "Menu_Title_Screen", minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
    }
    private void SetHover(UnityEngine.Vector2 _position)
    {
        this.m_SelectedMenuHoverImage.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        DG.Tweening.Tween val_1 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tween>(t:  this.HoverRotate, loops:  0);
        DG.Tweening.TweenExtensions.Complete(t:  this.HoverRotate);
        DG.Tweening.TweenExtensions.Kill(t:  this.HoverRotate, complete:  false);
        DG.Tweening.Tween val_2 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tween>(t:  this.HoverFade, loops:  0);
        DG.Tweening.TweenExtensions.Complete(t:  this.HoverFade);
        DG.Tweening.TweenExtensions.Kill(t:  this.HoverFade, complete:  false);
        UnityEngine.Rect val_4 = this.m_MenuPanel.rect;
        float val_14 = this.m_HoverOffsetPosition;
        val_4.m_XMin = _position.y + val_4.m_XMin;
        val_14 = val_4.m_XMin + val_14;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  _position.x, y:  val_14);
        this.m_SelectedMenuHoverImage.rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        this.HoverFade = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_SelectedMenuHoverImage, endValue:  1f, duration:  0.25f);
        if(this.m_RotateClockwise != false)
        {
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.back;
        }
        else
        {
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.forward;
        }
        
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  360f);
        this.HoverRotate = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this.m_SelectedMenuHoverImage.rectTransform, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  4f, mode:  1), ease:  1), loops:  0, loopType:  2);
    }
    public void SelectMenu(int _iMenu)
    {
        NetworkUIController.MenuType val_12;
        if(_iMenu == 0)
        {
                UnityEngine.Debug.Log(message:  "Go back to previous scene");
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  this.m_ExitScene);
        }
        
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        if((_iMenu - 2) <= 6)
        {
                var val_12 = 40824312 + ((_iMenu - 2)) << 2;
            val_12 = 2;
            val_12 = val_12 + 40824312;
        }
        else
        {
                UnityEngine.Vector2 val_5 = this.m_CasualMenuButton.anchoredPosition;
            val_12 = 3;
            if(_iMenu < 3)
        {
            
        }
        else
        {
                this.SetHover(_position:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        }
        
            UnityEngine.Debug.Log(message:  ">> SELECTED MENU: "(">> SELECTED MENU: ") +);
            if(_iMenu != 2)
        {
                GameAudio.PlayButtonSound();
        }
        
            this.m_NetworkUIController.ShowMenu(_menuType:  null);
            this.m_CurrentMenu = ;
        }
    
    }
    private void OnValidate()
    {
        if(this.m_HoverOffsetPosition >= 0)
        {
                return;
        }
        
        this.m_HoverOffsetPosition = 0f;
    }
    public NetworkUISidebar()
    {
        this.m_HoverOffsetPosition = 1f;
        this.m_RotateClockwise = true;
        this.m_ExitScene = "Menu_Title_Screen";
        this = new UnityEngine.MonoBehaviour();
    }

}
