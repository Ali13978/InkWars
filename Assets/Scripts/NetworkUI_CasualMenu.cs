using UnityEngine;
public class NetworkUI_CasualMenu : NetworkUIMenu
{
    // Fields
    public UnityEngine.UI.Button FindMatchButton;
    private GradientInformation m_FindingMatchGradient;
    private bool m_RankedMenu;
    private bool m_IsSearchingForOpponent;
    private string m_FindingMatchText;
    private float m_TypewriterDelay;
    private UnityEngine.Material m_GradientMaterial;
    
    // Properties
    public bool IsSearchingForOpponent { get; set; }
    public bool IsRanked { get; }
    
    // Methods
    private void Awake()
    {
        var val_3;
        ButtonClickedEvent val_1 = this.FindMatchButton.onClick;
        val_3 = null;
        val_3 = null;
        if((NetworkUI_CasualMenu.<>c.<>9__7_0) == null)
        {
            goto label_4;
        }
        
        label_9:
        val_1.AddListener(call:  NetworkUI_CasualMenu.<>c.<>9__7_0);
        return;
        label_4:
        NetworkUI_CasualMenu.<>c.<>9__7_0 = new UnityEngine.Events.UnityAction(object:  NetworkUI_CasualMenu.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NetworkUI_CasualMenu.<>c::<Awake>b__7_0());
        if(val_1 != null)
        {
            goto label_9;
        }
        
        goto label_9;
    }
    private void OnEnable()
    {
        null = null;
        InkWars.Model.MVCNetworkManager.OnMatchButtonInteractableChange.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void NetworkUI_CasualMenu::OnNetworkProcessInteractableChanged(bool enable)));
    }
    private void OnDisable()
    {
        null = null;
        InkWars.Model.MVCNetworkManager.OnMatchButtonInteractableChange.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void NetworkUI_CasualMenu::OnNetworkProcessInteractableChanged(bool enable)));
    }
    private void OnNetworkProcessInteractableChanged(bool enable)
    {
        enable = enable;
        this.FindMatchButton.interactable = enable;
    }
    private void LateUpdate()
    {
        if(this.m_IsSearchingForOpponent == false)
        {
                return;
        }
        
        this.ChangeColors();
    }
    public void FindMatch(TMPro.TextMeshProUGUI _text)
    {
        object val_3;
        if(this.m_RankedMenu != false)
        {
                val_3 = "Finding RANKED match";
        }
        else
        {
                val_3 = "Finding CASUAL match";
        }
        
        UnityEngine.Debug.Log(message:  val_3);
        this.m_IsSearchingForOpponent = true;
        _text.text = "Searching for opponent";
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.AnimateFindingMatchText(_text:  _text));
    }
    private System.Collections.IEnumerator AnimateFindingMatchText(TMPro.TextMeshProUGUI _text)
    {
        NetworkUI_CasualMenu.<AnimateFindingMatchText>d__13 val_1 = new NetworkUI_CasualMenu.<AnimateFindingMatchText>d__13();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[32] = this;
        }
        
        ._text = _text;
        return (System.Collections.IEnumerator)val_1;
    }
    public void ChangeColors()
    {
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 + val_1;
        UnityEngine.Color val_3 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = "<color=#1FC641>", g = (string**)(1152921526036483424)("VIP_EXPIRE_CHECKER").__il2cppRuntimeField_14, b = "NetworkDataCollection/VIPCollection", a = (string**)(1152921526036483424)("VIP_EXPIRE_CHECKER").__il2cppRuntimeField_1C}, b:  new UnityEngine.Color() {r = this.m_FindingMatchGradient.TopColor, g = V13.16B, b = V14.16B, a = V15.16B}, t:  UnityEngine.Mathf.PingPong(t:  val_1, length:  1f));
        float val_4 = UnityEngine.Time.time;
        val_4 = val_4 + val_4;
        UnityEngine.Color val_6 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.m_FindingMatchGradient.BottomColor, g = V13.16B, b = V15.16B, a = V14.16B}, b:  new UnityEngine.Color() {r = this.m_FindingMatchGradient.BottomColor, g = (string**)(1152921526036483424)("VIP_EXPIRE_CHECKER").__il2cppRuntimeField_14, b = (string**)(1152921526036483424)("VIP_EXPIRE_CHECKER").__il2cppRuntimeField_1C, a = "NetworkDataCollection/VIPCollection"}, t:  UnityEngine.Mathf.PingPong(t:  val_4, length:  1f));
        this.m_GradientMaterial.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
        this.m_GradientMaterial.SetColor(name:  "_Color2", value:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a});
    }
    public void StopChangingColors()
    {
        this.m_IsSearchingForOpponent = false;
        this.ApplyGradientToMaterial(_material:  this.m_GradientMaterial);
    }
    public bool get_IsSearchingForOpponent()
    {
        return (bool)this.m_IsSearchingForOpponent;
    }
    public void set_IsSearchingForOpponent(bool value)
    {
        this.m_IsSearchingForOpponent = value;
    }
    public bool get_IsRanked()
    {
        return (bool)this.m_RankedMenu;
    }
    protected override void OnShow()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(DataStructs.UserDataDictionary.GameSave.PVPTutorialPlayed != false)
        {
                return;
        }
        
        InstructionCanvas.Instance.Show();
        val_4 = null;
        val_4 = null;
        DataStructs.UserDataDictionary.GameSave.PVPTutorialPlayed = true;
    }
    public void ShowBattleEnhancerPanel()
    {
        BattleEnhancerInventory.Show();
    }
    public NetworkUI_CasualMenu()
    {
        this.m_TypewriterDelay = 1f;
        this.m_FindingMatchText = "Searching for opponent";
        this = new UnityEngine.MonoBehaviour();
    }

}
