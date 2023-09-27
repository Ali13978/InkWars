using UnityEngine;
public class NetworkUICharacterInformationPanel : MonoBehaviour
{
    // Fields
    public static NetworkUICharacterInformationPanel m_Instance;
    private UnityEngine.CanvasGroup m_Transparency;
    private TMPro.TextMeshProUGUI m_UserID;
    private UnityEngine.UI.Image m_Avatar;
    private UnityEngine.UI.Image m_Flag;
    private UnityEngine.UI.Image m_Rank;
    private CustomTitle title;
    private TMPro.TextMeshProUGUI m_Shells;
    private TMPro.TextMeshProUGUI m_PlayerPoints;
    private TMPro.TextMeshProUGUI m_BattlePoints;
    private TMPro.TextMeshProUGUI m_Wins;
    private TMPro.TextMeshProUGUI m_Loses;
    private TMPro.TextMeshProUGUI m_Draws;
    private TMPro.TextMeshProUGUI m_Region;
    private UnityEngine.RectTransform m_MainPanel;
    private UnityEngine.RectTransform m_RankPanel;
    private UnityEngine.RectTransform m_ShellsPanel;
    private UnityEngine.RectTransform m_PlayerPointsPanel;
    private UnityEngine.RectTransform m_BattlePointsPanel;
    private UnityEngine.RectTransform m_WLDRPanel;
    private bool m_DisplayWLDR;
    private bool m_DisplayRank;
    private bool m_DisplayShells;
    private bool m_DisplayPP;
    private bool m_DisplayBP;
    
    // Methods
    public void Show()
    {
        this.m_Transparency.alpha = 1f;
        this.Setup();
        object[] val_1 = new object[1];
        UnityEngine.Vector3 val_2 = this.m_MainPanel.localScale;
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(val_2 != 0)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_2 == 0)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = val_2;
        UnityEngine.Debug.LogFormat(format:  "SHOW - MAIN PANEL LOCAL SCALE: {0}", args:  val_1);
    }
    public void Hide()
    {
        this.m_Transparency.alpha = 0f;
        object[] val_1 = new object[1];
        UnityEngine.Vector3 val_2 = this.m_MainPanel.localScale;
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(val_2 != 0)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_2 == 0)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = val_2;
        UnityEngine.Debug.LogFormat(format:  "SHOW - MAIN PANEL LOCAL SCALE: {0}", args:  val_1);
    }
    private void OnEnable()
    {
        var val_5;
        NetworkUICharacterInformationPanel.m_Instance = this;
        ExpressShellPurchaseCanvas.Instance.add_OnShellsUpdated(value:  new ExpressShellPurchaseCanvas.OnShellsUpdatedDelegate(object:  this, method:  public System.Void NetworkUICharacterInformationPanel::ShellsUpdated(int _shells)));
        val_5 = null;
        val_5 = null;
        this.m_UserID.text = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  DataStructs.UserDataDictionary.Settings.UserName);
        this.Setup();
    }
    private void OnDisable()
    {
        if(ExpressShellPurchaseCanvas.Exists == false)
        {
                return;
        }
        
        ExpressShellPurchaseCanvas.Instance.remove_OnShellsUpdated(value:  new ExpressShellPurchaseCanvas.OnShellsUpdatedDelegate(object:  this, method:  public System.Void NetworkUICharacterInformationPanel::ShellsUpdated(int _shells)));
    }
    private UnityEngine.Vector3 Display(bool _shouldDisplay)
    {
        if(_shouldDisplay == false)
        {
                return UnityEngine.Vector3.zero;
        }
        
        return UnityEngine.Vector3.one;
    }
    public static void UpdateVisualFields()
    {
        if(0 == NetworkUICharacterInformationPanel.m_Instance)
        {
                return;
        }
        
        NetworkUICharacterInformationPanel.m_Instance.Setup();
    }
    public void Setup()
    {
        var val_37;
        UnityEngine.Sprite val_38;
        var val_39;
        float val_40;
        float val_41;
        float val_42;
        float val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        val_37 = null;
        val_37 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedTitle;
        this.title.Setup(title:  TitleCollection.GetTitleFromIntId(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})));
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = DataStructs.UserDataDictionary.Settings.SelectedAvatar;
        val_38 = AvatarCollection.GetAvatarSpriteFromIntId(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited}));
        this.m_Avatar.sprite = val_38;
        if((UnityEngine.Object.op_Implicit(exists:  this.m_WLDRPanel)) != false)
        {
                val_39 = null;
            val_39 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_8 = DataStructs.UserDataDictionary.Stats.NetworkWins;
            this.m_Wins.text = "W: "("W: ") + val_8.currentCryptoKey.ToString();
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_11 = DataStructs.UserDataDictionary.Stats.NetworkLoses;
            this.m_Loses.text = "L: "("L: ") + val_11.currentCryptoKey.ToString();
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_14 = DataStructs.UserDataDictionary.Stats.NetworkDraws;
            val_38 = "D: "("D: ") + val_14.currentCryptoKey.ToString();
            this.m_Draws.text = val_38;
            UnityEngine.Vector3 val_17 = this.m_Draws.Display(_shouldDisplay:  this.m_DisplayWLDR);
            val_40 = val_17.x;
            val_41 = val_40;
            val_42 = val_17.y;
            val_43 = val_17.z;
            this.m_WLDRPanel.localScale = new UnityEngine.Vector3() {x = val_41, y = val_42, z = val_43};
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.m_RankPanel)) != false)
        {
                val_44 = null;
            val_44 = null;
            this.m_Rank.sprite = RankingCollection.GetRankSprite(rank:  DataStructs.UserDataDictionary.Stats.CurrentCharacterRank);
            val_38 = NetworkUtils.GetCountry(_flag:  DataStructs.UserDataDictionary.Settings.UserFlag);
            this.m_Flag.sprite = val_38;
            UnityEngine.Vector3 val_23 = this.m_Flag.Display(_shouldDisplay:  this.m_DisplayRank);
            val_40 = val_23.x;
            val_41 = val_40;
            val_42 = val_23.y;
            val_43 = val_23.z;
            this.m_RankPanel.localScale = new UnityEngine.Vector3() {x = val_41, y = val_42, z = val_43};
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.m_ShellsPanel)) != false)
        {
                val_45 = null;
            val_45 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_25 = DataStructs.UserDataDictionary.Items.Shells;
            val_38 = PlayerPrefsManager.GetShellString(shells:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_25.currentCryptoKey, hiddenValue = val_25.hiddenValue, fakeValue = val_25.fakeValue, inited = val_25.inited}));
            this.m_Shells.text = val_38;
            UnityEngine.Vector3 val_28 = this.m_Shells.Display(_shouldDisplay:  this.m_DisplayShells);
            val_40 = val_28.x;
            val_41 = val_40;
            val_42 = val_28.y;
            val_43 = val_28.z;
            this.m_ShellsPanel.localScale = new UnityEngine.Vector3() {x = val_41, y = val_42, z = val_43};
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.m_PlayerPointsPanel)) != false)
        {
                val_46 = null;
            val_46 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_30 = DataStructs.UserDataDictionary.Stats.PlayerPoints;
            val_38 = val_30.currentCryptoKey.ToString();
            this.m_PlayerPoints.text = val_38;
            UnityEngine.Vector3 val_32 = this.m_PlayerPoints.Display(_shouldDisplay:  this.m_DisplayPP);
            val_40 = val_32.x;
            val_41 = val_40;
            val_42 = val_32.y;
            val_43 = val_32.z;
            this.m_PlayerPointsPanel.localScale = new UnityEngine.Vector3() {x = val_41, y = val_42, z = val_43};
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.m_BattlePointsPanel)) == false)
        {
                return;
        }
        
        val_47 = null;
        val_47 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_34 = DataStructs.UserDataDictionary.Stats.CurrentCharacterBP;
        val_38 = val_34.currentCryptoKey.ToString();
        this.m_BattlePoints.text = val_38;
        UnityEngine.Vector3 val_36 = this.m_BattlePoints.Display(_shouldDisplay:  this.m_DisplayBP);
        val_40 = val_36.x;
        this.m_BattlePointsPanel.localScale = new UnityEngine.Vector3() {x = val_40, y = val_36.y, z = val_36.z};
    }
    public void ShellsUpdated(int _shells)
    {
        this.m_Shells.text = _shells.ToString();
    }
    public static void UpdatePP(int _val)
    {
        NetworkUICharacterInformationPanel val_3 = NetworkUICharacterInformationPanel.m_Instance;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = mem[NetworkUICharacterInformationPanel.m_Instance + 80];
        val_3 = NetworkUICharacterInformationPanel.m_Instance.m_PlayerPoints;
        text = _val.ToString();
    }
    public NetworkUICharacterInformationPanel()
    {
    
    }

}
