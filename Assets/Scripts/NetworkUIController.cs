using UnityEngine;
public class NetworkUIController : MonoBehaviour
{
    // Fields
    private static NetworkUIController _instance;
    private NetworkUI_MainMenu m_MainMenu;
    private NetworkUI_CasualMenu m_RankedMenu;
    private NetworkUI_StageSelectMenu m_StageSelectSubMenu;
    private NetworkUI_CustomizationMenu m_CustomizationMenu;
    private NetworkUI_StatsMenu m_StatsMenu;
    private UnityEngine.UI.Image m_TransitionImage;
    private System.Collections.Generic.List<NetworkUIMenu> m_MenuList;
    private DG.Tweening.Sequence m_Sequence;
    private NetworkUICharacterInformationPanel m_CharacterInformationPanel;
    private NetworkUISidebar m_Sidebar;
    private UnityEngine.Material m_GradientMaterial;
    private TMPro.TextMeshProUGUI m_MenuDescriptionText;
    private bool canRefreshDescText;
    private static bool m_FirstTimeOpeningNetworkMode;
    private UnityEngine.GameObject m_SidebarRankedButton;
    
    // Properties
    public static NetworkUIController Instance { get; }
    
    // Methods
    public static NetworkUIController get_Instance()
    {
        var val_3;
        NetworkUIController val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = NetworkUIController._instance;
        if(val_4 == 0)
        {
                val_5 = null;
            val_4 = UnityEngine.Object.FindObjectOfType<NetworkUIController>();
            val_5 = null;
            NetworkUIController._instance = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (NetworkUIController)NetworkUIController._instance;
    }
    private void OnEnable()
    {
        var val_2;
        this.canRefreshDescText = true;
        val_2 = null;
        val_2 = null;
        InkWars.Model.MVCNetworkManager.OnMatchButtonInteractableChange.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void NetworkUIController::OnNetworkProcessing(bool enabled)));
    }
    private void OnDisable()
    {
        null = null;
        InkWars.Model.MVCNetworkManager.OnMatchButtonInteractableChange.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void NetworkUIController::OnNetworkProcessing(bool enabled)));
    }
    private void OnNetworkProcessing(bool enabled)
    {
        bool val_1;
        if(enabled != false)
        {
                val_1 = this.canRefreshDescText;
        }
        else
        {
                val_1 = false;
        }
        
        this.canRefreshDescText = val_1;
    }
    private void Start()
    {
        var val_13;
        var val_14;
        var val_15;
        val_13 = this;
        this.PopulateList();
        InkWars.Model.MVC_Multiplayer_Manager_Base val_1 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
        if(val_1.ConnectionStatus == 4)
        {
                val_14 = 4;
        }
        else
        {
                val_14 = 2;
        }
        
        this.m_Sidebar.SelectMenu(_iMenu:  2);
        this.m_CharacterInformationPanel.Show();
        InkWars.Model.MVC_Multiplayer_Manager_Base val_2 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
        val_2.ConnectionStatus = 0;
        val_15 = null;
        val_15 = null;
        if(NetworkUIController.m_FirstTimeOpeningNetworkMode == false)
        {
                return;
        }
        
        StationaryPulseUIElement val_3 = this.m_SidebarRankedButton.AddComponent<StationaryPulseUIElement>();
        StationaryPulseUIElement val_4 = this.m_SidebarRankedButton.GetComponent<StationaryPulseUIElement>();
        Variables val_5 = val_4.Options;
        val_5.Interactable = true;
        Variables val_6 = val_4.Options;
        val_6.BlockRaycasts = true;
        Variables val_7 = val_4.Options;
        val_7.ScaleMultiplier = 1.25f;
        Variables val_8 = val_4.Options;
        val_8.AnimateFromStart = true;
        Variables val_9 = val_4.Options;
        val_9.Looping = true;
        Variables val_10 = val_4.Options;
        val_10.LoopType = 1;
        Variables val_11 = val_4.Options;
        val_11.Ease = 32;
        val_13 = val_4.Options;
        val_12.LoopDuration = 0.5f;
    }
    public void PopulateList()
    {
        this.m_MenuList.Clear();
        this.m_MenuList.Add(item:  this.m_MainMenu);
        this.m_MenuList.Add(item:  this.m_RankedMenu);
        this.m_MenuList.Add(item:  this.m_StageSelectSubMenu);
        this.m_MenuList.Add(item:  this.m_CustomizationMenu);
        this.m_MenuList.Add(item:  this.m_StatsMenu);
    }
    public static void SelectMenu(NetworkUIController.MenuType _menuType)
    {
        if(0 == NetworkUIController.Instance)
        {
                return;
        }
        
        NetworkUIController val_3 = NetworkUIController.Instance;
        val_3.m_Sidebar.SelectMenu(_iMenu:  _menuType);
    }
    public void ShowMenu(NetworkUIController.MenuType _menuType)
    {
        var val_9;
        var val_10;
        NetworkUIController.<>c__DisplayClass25_0 val_1 = new NetworkUIController.<>c__DisplayClass25_0();
        if(val_1 != null)
        {
                ._menuType = _menuType;
        }
        else
        {
                mem[16] = _menuType;
        }
        
        .<>4__this = this;
        val_9 = null;
        val_9 = null;
        if(NetworkUIController.m_FirstTimeOpeningNetworkMode != false)
        {
                StationaryPulseUIElement val_2 = this.m_SidebarRankedButton.GetComponent<StationaryPulseUIElement>();
            if(0 != val_2)
        {
                val_2.StopAnimation();
            UnityEngine.Object.Destroy(obj:  val_2);
        }
        
            val_10 = null;
            val_10 = null;
            NetworkUIController.m_FirstTimeOpeningNetworkMode = false;
        }
        
        this.ResetTransition();
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.m_Sequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_TransitionImage, endValue:  1f, duration:  0.05f), ease:  6));
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.m_Sequence, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void NetworkUIController.<>c__DisplayClass25_0::<ShowMenu>b__0()));
    }
    private void ResetTransition()
    {
        UnityEngine.Color val_1 = this.m_TransitionImage.color;
        this.m_TransitionImage.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = 0f};
        if(this.m_Sequence != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.m_Sequence, complete:  false);
        }
        
        this.m_Sequence = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), isIndependentUpdate:  true);
    }
    private void OnValidate()
    {
        this.PopulateList();
    }
    public NetworkUIController()
    {
        this.m_MenuList = new System.Collections.Generic.List<NetworkUIMenu>();
        this.canRefreshDescText = true;
    }
    private static NetworkUIController()
    {
        NetworkUIController.m_FirstTimeOpeningNetworkMode = true;
    }

}
