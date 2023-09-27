using UnityEngine;
public class LevelSelection : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Toggle m_levelButton;
    private UnityEngine.UI.Button m_shiftRight;
    private UnityEngine.UI.Button m_shiftLeft;
    private UnityEngine.UI.Button m_pearlButton;
    private UnityEngine.UI.Button m_ShellButton;
    private UnityEngine.UI.Image m_wagerPearl;
    private UnityEngine.UI.Image m_wagerShell;
    private UnityEngine.UI.Image m_pricePearl;
    private UnityEngine.UI.Image m_priceShell;
    private UnityEngine.Sprite m_lockedImage;
    private UnityEngine.Sprite m_inactiveImage;
    private TMPro.TextMeshProUGUI m_wager;
    private TMPro.TextMeshProUGUI m_price;
    private UnityEngine.UI.ScrollRect scrollView;
    private int _scrollId;
    private bool withArrows;
    private bool isExpressWager;
    private System.Collections.Generic.List<LevelButtonStruct> m_levelButtons;
    private PublicWagerData m_wagerData;
    private UnityEngine.UI.Toggle lastSelectedToggle;
    
    // Properties
    private int scrollIndex { get; set; }
    
    // Methods
    private int get_scrollIndex()
    {
        return (int)this._scrollId;
    }
    private void set_scrollIndex(int value)
    {
        var val_4;
        if(this.m_wagerData != null)
        {
                val_4 = this.m_wagerData.GetWagerCount() - 1;
        }
        else
        {
                val_4 = 0;
        }
        
        this._scrollId = UnityEngine.Mathf.Clamp(value:  value, min:  0, max:  0);
        this.RefreshToggleScrollView();
    }
    private void OnEnable()
    {
        var val_6;
        this.m_shiftRight.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LevelSelection::OnLevelShiftRightClick()));
        this.m_shiftLeft.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LevelSelection::OnLevelShiftLeftClick()));
        val_6 = null;
        val_6 = null;
        DataStructs.UserDataDictionary.OnCurrencyChanged.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LevelSelection::RefreshToggleLockStatus()));
    }
    private void OnDisable()
    {
        var val_6;
        this.m_shiftRight.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LevelSelection::OnLevelShiftRightClick()));
        this.m_shiftLeft.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LevelSelection::OnLevelShiftLeftClick()));
        val_6 = null;
        val_6 = null;
        DataStructs.UserDataDictionary.OnCurrencyChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LevelSelection::RefreshToggleLockStatus()));
    }
    private void Start()
    {
        var val_18;
        this.m_wagerData = new PublicWagerData();
        this.m_levelButtons = new System.Collections.Generic.List<LevelButtonStruct>();
        val_18 = 1;
        goto label_1;
        label_26:
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        UnityEngine.UI.Toggle val_4 = UnityEngine.Object.Instantiate<UnityEngine.UI.Toggle>(original:  this.m_levelButton, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        val_4.transform.SetParent(p:  this.m_levelButton.transform.parent);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        val_4.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        val_4.gameObject.SetActive(value:  false);
        TMPro.TextMeshProUGUI val_11 = val_4.GetComponentInChildren<TMPro.TextMeshProUGUI>();
        if(val_11 != 0)
        {
                val_11.SetText(text:  val_18.ToString());
        }
        
        val_4.gameObject.SetActive(value:  true);
        int val_15 = W24 + 1;
        WagerData val_16 = PublicWagerData.GetDataByLevel(level:  val_15);
        if(val_16 != null)
        {
                val_16.m_button = val_4;
        }
        
        val_4.isOn = false;
        this.SetupToggleLockStyle(toggle:  val_4, wagerdata:  val_16);
        if(val_15 == 1)
        {
                val_4.isOn = true;
            this.lastSelectedToggle = val_4;
        }
        
        val_18 = 2;
        label_1:
        if((val_18 - 1) < this.m_wagerData.GetWagerCount())
        {
            goto label_26;
        }
        
        this.CheckForNewLevelUnlocks();
        this.scrollIndex = 0;
    }
    private void CheckForNewLevelUnlocks()
    {
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        int val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        val_18 = null;
        val_18 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Stats.PublicMatch_CurrentLevel;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})) == 0)
        {
                val_19 = null;
            val_19 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  1);
            DataStructs.UserDataDictionary.Stats.PublicMatch_CurrentLevel = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
        }
        
        val_20 = 0;
        val_21 = 0;
        val_22 = 0;
        goto label_19;
        label_26:
        val_20 = 1;
        val_23 = null;
        val_23 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Stats.TotalPVPWins;
        val_24 = val_5.fakeValue;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_24, inited = val_5.inited})) >= val_4.m_minWins)
        {
                val_25 = null;
            val_25 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = DataStructs.UserDataDictionary.Stats.PublicMatch_CurrentLevel;
            val_24 = val_7.fakeValue;
            int val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_24, inited = val_7.inited});
            val_22 = val_22 | ((val_4.m_Level > val_8) ? 1 : 0);
        }
        
        label_19:
        if(val_20 < this.m_wagerData.GetWagerCount())
        {
            goto label_26;
        }
        
        val_26 = 1;
        goto label_27;
        label_41:
        WagerData val_12 = PublicWagerData.GetDataByLevel(level:  1);
        val_27 = null;
        val_27 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_13 = DataStructs.UserDataDictionary.Stats.TotalPVPWins;
        val_24 = val_13.fakeValue;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_13.currentCryptoKey, hiddenValue = val_13.hiddenValue, fakeValue = val_24, inited = val_13.inited})) >= val_12.m_minWins)
        {
                val_28 = null;
            val_28 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_15 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_12.m_Level);
            val_24 = val_15.fakeValue;
            DataStructs.UserDataDictionary.Stats.PublicMatch_CurrentLevel = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_15.currentCryptoKey, hiddenValue = val_15.hiddenValue, fakeValue = val_24, inited = val_15.inited};
        }
        
        val_26 = 2;
        label_27:
        if((val_26 - 1) < this.m_wagerData.GetWagerCount())
        {
            goto label_41;
        }
        
        if(((val_4.m_Level > val_8) ? PublicWagerData.GetDataByLevel(level:  1) : (val_21)) == 0)
        {
                return;
        }
        
        if((val_22 ^ 1 & 1) != 0)
        {
                return;
        }
        
        WagerLevelUnlockedPopup.Show(unlockedLevel:  val_4.m_Level > val_8 ? val_4 : val_21 + 24, wagerCount:  new System.Decimal() {flags = val_4.m_Level > val_8 ? val_4 : val_21 + 32, hi = val_4.m_Level > val_8 ? val_4 : val_21 + 32, lo = val_4.m_Level > val_8 ? val_4 : val_21 + 32 + 8, mid = val_4.m_Level > val_8 ? val_4 : val_21 + 32 + 8}, prizeCount:  new System.Decimal() {flags = val_4.m_Level > val_8 ? val_4 : val_21 + 48, hi = val_4.m_Level > val_8 ? val_4 : val_21 + 48, lo = val_4.m_Level > val_8 ? val_4 : val_21 + 48 + 8, mid = val_4.m_Level > val_8 ? val_4 : val_21 + 48 + 8});
    }
    private void RefreshToggleLockStatus()
    {
        var val_6;
        var val_7;
        int val_8;
        var val_9;
        val_6 = 1;
        goto label_1;
        label_15:
        val_7 = null;
        val_7 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Stats.TotalPVPWins;
        val_8 = val_2.fakeValue;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_8, inited = val_2.inited})) >= val_1.m_minWins)
        {
                val_9 = null;
            val_9 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_1.m_Level);
            val_8 = val_4.currentCryptoKey;
            DataStructs.UserDataDictionary.Stats.PublicMatch_CurrentLevel = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_8, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited};
        }
        
        this.SetupToggleLockStyle(toggle:  val_1.m_button, wagerdata:  PublicWagerData.GetDataByLevel(level:  1));
        val_6 = 2;
        label_1:
        if((val_6 - 1) < this.m_wagerData.GetWagerCount())
        {
            goto label_15;
        }
    
    }
    private void SetupToggleLockStyle(UnityEngine.UI.Toggle toggle, WagerData wagerdata)
    {
        var val_20;
        WagerData val_21;
        var val_23;
        IntPtr val_25;
        LevelSelection.<>c__DisplayClass28_0 val_1 = new LevelSelection.<>c__DisplayClass28_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .wagerdata = wagerdata;
        val_20 = null;
        val_20 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Stats.TotalPVPWins;
        int val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited});
        val_21 = (LevelSelection.<>c__DisplayClass28_0)[1152921528708084384].wagerdata;
        if(val_21 != null)
        {
                var val_4 = (val_3 < ((LevelSelection.<>c__DisplayClass28_0)[1152921528708084384].wagerdata.m_minWins)) ? 1 : 0;
        }
        else
        {
                val_21 = (LevelSelection.<>c__DisplayClass28_0)[1152921528708084384].wagerdata;
            var val_5 = (val_3 < ((LevelSelection.<>c__DisplayClass28_0)[1152921528708084384].wagerdata.m_minWins)) ? 1 : 0;
        }
        
        bool val_6 = val_21.HasUserGotEnoughCurrency();
        UnityEngine.UI.Button val_7 = toggle.GetComponentInChildren<UnityEngine.UI.Button>(includeInactive:  true);
        val_7.gameObject.SetActive(value:  val_5 | val_6 ^ 1);
        if(val_5 == 0)
        {
            goto label_14;
        }
        
        toggle.transition = 0;
        val_7.onClick.RemoveAllListeners();
        val_23 = val_7.onClick;
        val_25 = 1152921528707988448;
        goto label_19;
        label_14:
        if(val_6 == false)
        {
            goto label_20;
        }
        
        if(toggle == null)
        {
            goto label_21;
        }
        
        toggle.transition = 1;
        goto label_22;
        label_20:
        val_7.onClick.RemoveAllListeners();
        val_23 = val_7.onClick;
        UnityEngine.Events.UnityAction val_16 = null;
        val_25 = 1152921528708001760;
        label_19:
        val_16 = new UnityEngine.Events.UnityAction(object:  val_1, method:  val_25);
        val_23.AddListener(call:  val_16);
        if(toggle != null)
        {
            goto label_31;
        }
        
        label_32:
        label_31:
        toggle.GetComponentInChildren<UnityEngine.UI.Image>().sprite = (val_5 != 0) ? this.m_lockedImage : this.m_inactiveImage;
        return;
        label_21:
        0.transition = 1;
        label_22:
        toggle.onValueChanged.RemoveAllListeners();
        toggle.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  val_1, method:  System.Void LevelSelection.<>c__DisplayClass28_0::<SetupToggleLockStyle>b__2(bool isOn)));
        if(toggle != null)
        {
            goto label_31;
        }
        
        goto label_32;
    }
    private void OnLockedWagerButtonClick(WagerData wagerdata)
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Stats.TotalPVPWins;
        string val_3 = System.String.Format(format:  "Win {0} times in network PVP.\r\nYour process: {1}/{2}", arg0:  wagerdata.m_minWins, arg1:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited}), arg2:  wagerdata.m_minWins);
        object[] val_4 = new object[1];
        if(val_4 == null)
        {
            goto label_9;
        }
        
        if(wagerdata.m_minWins != 0)
        {
            goto label_10;
        }
        
        goto label_13;
        label_9:
        if(wagerdata.m_minWins == 0)
        {
            goto label_13;
        }
        
        label_10:
        label_13:
        val_4[0] = wagerdata.m_minWins;
        DialogPanel val_7 = DialogManager.Show(title:  LanguageManager.GetText(key:  "LK.Lobby.WagerLockMsgTitle"), message:  LanguageManager.GetTextFormat(key:  "LK.Lobby.WagerLockMsg", list:  val_4), cancelButtonTitle:  "Close", onCancelCallback:  0);
    }
    private void OnNoEnoughCurrencyWagerButtonClick(WagerData wagerdata)
    {
        LevelSelection.<>c__DisplayClass30_0 val_1 = new LevelSelection.<>c__DisplayClass30_0();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .wagerdata = wagerdata;
        if(wagerdata != null)
        {
            goto label_11;
        }
        
        label_12:
        label_11:
        string val_3 = CurrencyCollection.Get(cur:  wagerdata.m_currency).TitleCasePluralName;
        string val_4 = LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Title");
        if(this.isExpressWager == false)
        {
            goto label_6;
        }
        
        object[] val_5 = new object[1];
        val_5[0] = val_3;
        DialogPanel val_8 = DialogManager.Show(title:  val_4, message:  LanguageManager.GetTextFormat(key:  "LK.wager.error2", list:  val_5), cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close"), onCancelCallback:  0);
        return;
        label_1:
        mem[16] = wagerdata;
        if(mem[16] != 0)
        {
            goto label_11;
        }
        
        goto label_12;
        label_6:
        object[] val_9 = new object[2];
        val_9[0] = wagerdata.m_wager;
        val_9[1] = val_3;
        DialogPanel val_17 = DialogManager.ShowConfirmDialog(title:  val_4, message:  System.String.Format(format:  LanguageManager.GetTextFormat(key:  "LK.wager.error1", list:  val_9), args:  System.Array.Empty<System.Object>()), confirmButtonTitle:  LanguageManager.GetText(key:  "LK.wager.get")(LanguageManager.GetText(key:  "LK.wager.get")) + " " + val_3, cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close"), onConfirmCallback:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void LevelSelection.<>c__DisplayClass30_0::<OnNoEnoughCurrencyWagerButtonClick>b__0()), onCancelCallback:  0);
    }
    private void RefreshToggleScrollView()
    {
        if(0 == this.scrollView)
        {
                return;
        }
        
        float val_12 = 1f;
        val_12 = val_12 / ((float)this.m_wagerData.GetWagerCount() - 5);
        val_12 = val_12 * (float)this._scrollId;
        this.scrollView.horizontalNormalizedPosition = val_12;
        this.scrollView.horizontalNormalizedPosition = UnityEngine.Mathf.Clamp01(value:  this.scrollView.horizontalNormalizedPosition);
        this.m_shiftLeft.gameObject.SetActive(value:  (this.scrollView.horizontalNormalizedPosition > 0.001f) ? 1 : 0);
        this.m_shiftRight.gameObject.SetActive(value:  (this.scrollView.horizontalNormalizedPosition < 0) ? 1 : 0);
    }
    private void OnLevelShiftRightClick()
    {
        this.scrollIndex = this._scrollId + 5;
    }
    private void OnLevelShiftLeftClick()
    {
        this.scrollIndex = this._scrollId - 5;
    }
    private void OnClickLevelButton(WagerData data)
    {
        var val_22;
        UnityEngine.UI.Toggle val_23;
        var val_24;
        val_22 = this;
        val_23 = data.m_button;
        if(val_23.isOn == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "select wager level " + data.m_Level.ToString());
        PublicWagerData.selectedWagerLevel = data.m_Level;
        this.lastSelectedToggle = data.m_button;
        this.m_price.SetText(text:  data.m_price.ToString());
        this.m_wager.SetText(text:  data.m_wager.ToString());
        val_23 = 1152921504858337280;
        if(data.m_currency != 0)
        {
                if(0 != this.m_pearlButton)
        {
                if(0 != this.m_ShellButton)
        {
                this.m_pearlButton.gameObject.SetActive(value:  false);
            this.m_ShellButton.gameObject.SetActive(value:  true);
        }
        
        }
        
            this.m_wagerPearl.gameObject.SetActive(value:  false);
            this.m_pricePearl.gameObject.SetActive(value:  false);
            this.m_wagerShell.gameObject.SetActive(value:  true);
            val_22 = this.m_priceShell.gameObject;
            val_24 = 1;
        }
        else
        {
                if(0 != this.m_pearlButton)
        {
                if(0 != this.m_ShellButton)
        {
                this.m_pearlButton.gameObject.SetActive(value:  true);
            this.m_ShellButton.gameObject.SetActive(value:  false);
        }
        
        }
        
            this.m_wagerPearl.gameObject.SetActive(value:  true);
            this.m_pricePearl.gameObject.SetActive(value:  true);
            this.m_wagerShell.gameObject.SetActive(value:  false);
            val_22 = this.m_priceShell.gameObject;
            val_24 = 0;
        }
        
        val_22.SetActive(value:  false);
    }
    public LevelSelection()
    {
        this.withArrows = true;
    }

}
