using UnityEngine;
public class LevelSelectionSuponicMode : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Toggle m_levelButton;
    private UnityEngine.UI.ToggleGroup m_toggleGroupl;
    private int m_levelCount;
    private UnityEngine.Canvas m_parentCanvas;
    private UnityEngine.UI.Button m_shiftRight;
    private UnityEngine.UI.Button m_shiftLeft;
    private UnityEngine.Sprite m_inactiveImage;
    private UnityEngine.Sprite m_lockedImage;
    private TMPro.TextMeshProUGUI m_wager;
    private TMPro.TextMeshProUGUI m_price;
    private bool withArrows;
    private bool isExpressWager;
    private System.Collections.Generic.List<LevelButtonStruct> m_levelButtons;
    private System.Collections.Generic.List<UnityEngine.Vector3> m_lerpPoints;
    private PublicWagerData m_wagerData;
    private float m_gap;
    private UnityEngine.UI.Toggle lastSelectedToggle;
    
    // Methods
    private void GenerateLerpPoints()
    {
        float val_14;
        float val_15;
        float val_16;
        UnityEngine.Vector3 val_2 = this.m_shiftRight.transform.position;
        float val_15 = val_2.x;
        UnityEngine.Vector3 val_4 = this.m_shiftLeft.transform.position;
        val_15 = val_15 - val_4.x;
        float val_16 = 11f;
        val_14 = 6f;
        val_16 = val_15 / ((this.withArrows == true) ? (val_14) : (val_16));
        val_15 = System.Math.Abs(val_16);
        this.m_gap = val_15;
        this.m_lerpPoints = new System.Collections.Generic.List<UnityEngine.Vector3>();
        UnityEngine.Vector3 val_8 = this.m_shiftLeft.transform.position;
        val_16 = val_8.x;
        if(this.withArrows != false)
        {
                val_14 = -5f;
            val_15 = this.m_gap * val_14;
            val_16 = val_16 + val_15;
        }
        
        var val_18 = 0;
        do
        {
            UnityEngine.Vector3 val_11 = this.m_shiftRight.transform.position;
            UnityEngine.Vector3 val_14 = this.m_shiftRight.transform.position;
            float val_17 = (float)val_18 + 1;
            val_17 = this.m_gap * val_17;
            val_17 = val_16 + val_17;
            this.m_lerpPoints.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_18 = val_18 + 1;
        }
        while(val_18 < ((this.withArrows == true) ? 15 : 10));
    
    }
    private void OnEnable()
    {
        null = null;
        DataStructs.UserDataDictionary.OnCurrencyChanged.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LevelSelectionSuponicMode::RefreshToggleLockStatus()));
    }
    private void OnDisable()
    {
        null = null;
        DataStructs.UserDataDictionary.OnCurrencyChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LevelSelectionSuponicMode::RefreshToggleLockStatus()));
    }
    private void Start()
    {
        this.GenerateLerpPoints();
        this.m_wagerData = new PublicWagerData();
        this.m_levelButtons = new System.Collections.Generic.List<LevelButtonStruct>();
        if(this.m_levelCount >= 1)
        {
                do
        {
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            UnityEngine.UI.Toggle val_4 = UnityEngine.Object.Instantiate<UnityEngine.UI.Toggle>(original:  this.m_levelButton, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
            val_4.transform.SetParent(p:  this.m_parentCanvas.transform);
            UnityEngine.Vector3 val_9 = this.m_parentCanvas.transform.localPosition;
            val_4.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            val_4.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            TMPro.TextMeshProUGUI val_11 = val_4.GetComponentInChildren<TMPro.TextMeshProUGUI>();
            if(val_11 != 0)
        {
                val_11.SetText(text:  0 + 1.ToString());
        }
        
            UnityEngine.Vector3 val_18 = this.m_lerpPoints.Item[(this.withArrows == true) ? (0 + 5) : 0];
            val_4.transform.position = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            val_4.gameObject.SetActive(value:  true);
            int val_20 = 0 + 1;
            WagerData val_21 = PublicWagerData.GetDataByLevel(level:  val_20);
            if(val_21 != null)
        {
                val_21.m_button = val_4;
        }
        
            UnityEngine.UI.ToggleGroup val_22 = this.m_toggleGroupl.GetComponent<UnityEngine.UI.ToggleGroup>();
            if(val_4 != null)
        {
                val_4.group = val_22;
        }
        else
        {
                val_4.group = val_22;
        }
        
            val_4.isOn = false;
            this.SetupToggleLockStyle(toggle:  val_4, wagerdata:  val_21);
            if(0 == 0)
        {
                val_4.isOn = true;
            this.lastSelectedToggle = val_4;
        }
        
            this.OnClickLevelButton(data:  val_21);
        }
        while(val_20 < this.m_levelCount);
        
        }
        
        this.RefreshToggleLockStatus();
    }
    private void RefreshToggleLockStatus()
    {
        if(this.m_levelCount < 1)
        {
                return;
        }
        
        do
        {
            this.SetupToggleLockStyle(toggle:  val_1.m_button, wagerdata:  PublicWagerData.GetDataByLevel(level:  1));
        }
        while(1 < this.m_levelCount);
    
    }
    private void SetupToggleLockStyle(UnityEngine.UI.Toggle toggle, WagerData wagerdata)
    {
        UnityEngine.Events.UnityAction val_10;
        LevelSelectionSuponicMode.<>c__DisplayClass22_0 val_1 = new LevelSelectionSuponicMode.<>c__DisplayClass22_0();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .<>4__this = this;
        .wagerdata = wagerdata;
        if(wagerdata != null)
        {
            goto label_19;
        }
        
        label_20:
        label_19:
        UnityEngine.UI.Button val_2 = toggle.GetComponentInChildren<UnityEngine.UI.Button>(includeInactive:  true);
        val_2.gameObject.SetActive(value:  true);
        if(wagerdata.m_Level < 2)
        {
            goto label_7;
        }
        
        toggle.transition = 0;
        val_2.onClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_6 = null;
        val_10 = val_6;
        val_6 = new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void LevelSelectionSuponicMode.<>c__DisplayClass22_0::<SetupToggleLockStyle>b__0());
        val_2.onClick.AddListener(call:  val_6);
        if(toggle != null)
        {
            goto label_17;
        }
        
        goto label_13;
        label_7:
        toggle.transition = 1;
        toggle.onValueChanged.RemoveAllListeners();
        UnityEngine.Events.UnityAction<System.Boolean> val_7 = null;
        val_10 = val_7;
        val_7 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  val_1, method:  System.Void LevelSelectionSuponicMode.<>c__DisplayClass22_0::<SetupToggleLockStyle>b__1(bool isOn));
        toggle.onValueChanged.AddListener(call:  val_7);
        if(toggle != null)
        {
            goto label_17;
        }
        
        label_13:
        label_17:
        toggle.GetComponentInChildren<UnityEngine.UI.Image>().sprite = (wagerdata.m_Level > 1) ? this.m_lockedImage : this.m_inactiveImage;
        return;
        label_1:
        mem[16] = this;
        mem[24] = wagerdata;
        if(mem[24] != 0)
        {
            goto label_19;
        }
        
        goto label_20;
    }
    private void OnLockedWagerButtonClick(WagerData wagerdata)
    {
        DialogPanel val_2 = DialogManager.Show(title:  "", message:  LanguageManager.GetText(key:  "LK.ggp.LevelLockMsg"), cancelButtonTitle:  0, onCancelCallback:  0);
    }
    private void OnNoEnoughCurrencyWagerButtonClick(WagerData wagerdata)
    {
        LevelSelectionSuponicMode.<>c__DisplayClass24_0 val_1 = new LevelSelectionSuponicMode.<>c__DisplayClass24_0();
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
        DialogPanel val_17 = DialogManager.ShowConfirmDialog(title:  val_4, message:  System.String.Format(format:  LanguageManager.GetTextFormat(key:  "LK.wager.error1", list:  val_9), args:  System.Array.Empty<System.Object>()), confirmButtonTitle:  LanguageManager.GetText(key:  "LK.wager.get")(LanguageManager.GetText(key:  "LK.wager.get")) + " " + val_3, cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close"), onConfirmCallback:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void LevelSelectionSuponicMode.<>c__DisplayClass24_0::<OnNoEnoughCurrencyWagerButtonClick>b__0()), onCancelCallback:  0);
    }
    private void RefreshSelectedToggle()
    {
        UnityEngine.UI.Toggle val_4;
        if(this.m_levelCount < 1)
        {
                return;
        }
        
        do
        {
            val_4 = PublicWagerData.GetDataByLevel(level:  1);
            if((val_4 != null) && (0 != val_1.m_button))
        {
                if(val_1.m_button != this.lastSelectedToggle)
        {
                val_4 = val_1.m_button;
            val_4.isOn = false;
        }
        
        }
        
        }
        while(1 < this.m_levelCount);
    
    }
    private void OnClickLevelButton(WagerData data)
    {
        string val_6;
        UnityEngine.UI.Toggle val_7;
        val_6 = data;
        val_7 = data.m_button;
        if(val_7.isOn == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "select wager level " + data.m_Level.ToString());
        PublicWagerData.selectedWagerLevel = data.m_Level;
        val_7 = this.m_price;
        this.lastSelectedToggle = data.m_button;
        val_7.SetText(text:  data.m_price.ToString());
        val_6 = data.m_wager.ToString();
        this.m_wager.SetText(text:  val_6);
    }
    public LevelSelectionSuponicMode()
    {
        this.m_levelCount = 5;
        this.withArrows = true;
    }

}
