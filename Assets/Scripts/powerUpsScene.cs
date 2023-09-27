using UnityEngine;
public class powerUpsScene : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject stunYellow;
    public UnityEngine.GameObject ironYellow;
    public UnityEngine.GameObject blackYellow;
    public UnityEngine.GameObject ques1Yellow;
    public UnityEngine.GameObject ques2Yellow;
    public UnityEngine.GameObject stunLarge;
    public UnityEngine.GameObject question1;
    public UnityEngine.GameObject question2;
    public UnityEngine.UI.Text pearlCount;
    public UnityEngine.GameObject panelConfirm;
    public UnityEngine.GameObject panelNotEnoughPearls;
    public UnityEngine.UI.Text panelConfirmText;
    private int price;
    private int quantity;
    private PowerUpIds selectedPowerUpType;
    public UnityEngine.Sprite[] powerImage;
    public string[] infoString;
    public TMPro.TextMeshProUGUI infoText;
    public UnityEngine.UI.Text panelConfirmMainText;
    public UnityEngine.GameObject instructionPanel;
    public TMPro.TextMeshProUGUI powerNameText;
    public UnityEngine.GameObject mainPanel;
    public UnityEngine.UI.Text stunnerCountText;
    public UnityEngine.UI.Text ironCounterText;
    public UnityEngine.UI.Text eraserCounterText;
    private bool muteFirstButtonSoundForInit;
    
    // Methods
    private void Start()
    {
        this.panelNotEnoughPearls.SetActive(value:  false);
        this.price = 500;
        this.quantity = 5;
        this.selectedPowerUpType = 1;
        this.powerNameText.text = LanguageManager.GetText(key:  "LK.Shop.PowerUps.Stunner");
        this.infoText.text = LanguageManager.GetText(key:  "LK.Shop.PowerUps.Stunner.Info");
        this.panelConfirm.SetActive(value:  false);
        this.stunYellow.SetActive(value:  true);
        this.ironYellow.SetActive(value:  false);
        this.blackYellow.SetActive(value:  false);
        this.ques1Yellow.SetActive(value:  false);
        this.ques2Yellow.SetActive(value:  false);
        this.question1.SetActive(value:  false);
        this.question2.SetActive(value:  false);
        this.SetPowerCount();
        this.onclickStun(powerPanel:  this.mainPanel);
    }
    private void Update()
    {
        string val_2 = PlayerPrefsManager.Pearls.ToString();
        if(this.pearlCount != null)
        {
                return;
        }
    
    }
    private void SetPowerCount()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.StunnerBall;
        string val_2 = val_1.currentCryptoKey.ToString();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Items.IronBall;
        string val_4 = val_3.currentCryptoKey.ToString();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Items.ColorEraserBall;
        string val_6 = val_5.currentCryptoKey.ToString();
        if(this.eraserCounterText != null)
        {
                return;
        }
    
    }
    public void InfoClick()
    {
        GameAudio.PlayButtonSound();
        this.instructionPanel.SetActive(value:  true);
    }
    public void InfoCrossClick()
    {
        GameAudio.PlayButtonSound();
        this.instructionPanel.SetActive(value:  false);
    }
    public void backtoshop()
    {
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Shop_Scene");
    }
    public void confirmClickedYes()
    {
        var val_14;
        int val_15;
        var val_16;
        var val_17;
        var val_18;
        GameAudio.PlayButtonSound();
        if(PlayerPrefsManager.Pearls >= this.price)
        {
            goto label_3;
        }
        
        this.panelNotEnoughPearls.SetActive(value:  true);
        goto label_5;
        label_3:
        val_14 = null;
        val_14 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Stats.ItemsBougth;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited});
        val_15 = val_3.currentCryptoKey;
        DataStructs.UserDataDictionary.Stats.ItemsBougth = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_15, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
        GameAudio.PlayPurchaseSound();
        int val_4 = PlayerPrefsManager.Pearls;
        val_4 = val_4 - this.price;
        PlayerPrefsManager.Pearls = val_4;
        if(this.selectedPowerUpType == 3)
        {
            goto label_14;
        }
        
        if(this.selectedPowerUpType == 2)
        {
            goto label_15;
        }
        
        if(this.selectedPowerUpType != 1)
        {
            goto label_30;
        }
        
        val_16 = null;
        val_16 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Items.StunnerBall;
        int val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited});
        val_6 = this.quantity + val_6;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_6);
        val_15 = val_7.currentCryptoKey;
        DataStructs.UserDataDictionary.Items.StunnerBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_15, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue, inited = val_7.inited};
        goto label_30;
        label_14:
        val_17 = null;
        val_17 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_8 = DataStructs.UserDataDictionary.Items.ColorEraserBall;
        int val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_8.currentCryptoKey, hiddenValue = val_8.hiddenValue, fakeValue = val_8.fakeValue, inited = val_8.inited});
        val_9 = this.quantity + val_9;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_9);
        val_15 = val_10.currentCryptoKey;
        DataStructs.UserDataDictionary.Items.ColorEraserBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_15, hiddenValue = val_10.hiddenValue, fakeValue = val_10.fakeValue, inited = val_10.inited};
        goto label_30;
        label_15:
        val_18 = null;
        val_18 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_11 = DataStructs.UserDataDictionary.Items.IronBall;
        int val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_11.currentCryptoKey, hiddenValue = val_11.hiddenValue, fakeValue = val_11.fakeValue, inited = val_11.inited});
        val_12 = this.quantity + val_12;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_13 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_12);
        val_15 = val_13.currentCryptoKey;
        DataStructs.UserDataDictionary.Items.IronBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_15, hiddenValue = val_13.hiddenValue, fakeValue = val_13.fakeValue, inited = val_13.inited};
        label_30:
        this.SetPowerCount();
        label_5:
        this.panelConfirm.SetActive(value:  false);
    }
    public void pearlGetMoreClick()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        UnityEngine.PlayerPrefs.SetString(key:  "LastLevel", value:  val_1.m_Handle.name);
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_GetPearl");
    }
    public void pearlOkClick()
    {
        this.panelNotEnoughPearls.SetActive(value:  false);
    }
    public void confirmClickedNo()
    {
        GameAudio.PlayButtonSound();
        this.panelConfirm.SetActive(value:  false);
    }
    public void onclickStun(UnityEngine.GameObject powerPanel)
    {
        var val_98;
        var val_92;
        var val_97;
        var val_100;
        var val_102;
        var val_105;
        var val_109;
        var val_113;
        var val_114;
        var val_116;
        this.powerNameText.text = LanguageManager.GetText(key:  "LK.Shop.PowerUps.Stunner");
        this.infoText.text = LanguageManager.GetText(key:  "LK.Shop.PowerUps.Stunner.Info");
        if(this.muteFirstButtonSoundForInit != false)
        {
                this.muteFirstButtonSoundForInit = false;
        }
        else
        {
                GameAudio.PlayButtonSound();
        }
        
        this.selectedPowerUpType = 1;
        System.Collections.IEnumerator val_4 = powerPanel.transform.GetEnumerator();
        val_92 = 1152921504621170688;
        label_302:
        label_301:
        if(val_4 != null)
        {
            goto label_234;
        }
        
        label_235:
        label_234:
        var val_102 = 0;
        val_102 = val_102 + 1;
        if(val_4.MoveNext() == false)
        {
            goto label_15;
        }
        
        var val_103 = 0;
        val_103 = val_103 + 1;
        object val_8 = val_4.Current;
        if((System.String.op_Equality(a:  0.name, b:  "Info")) == false)
        {
            goto label_24;
        }
        
        string val_104 = this.infoString[0];
        if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_301;
        }
        
        goto label_301;
        label_24:
        if((System.String.op_Equality(a:  0.name, b:  "Button1")) == false)
        {
            goto label_97;
        }
        
        System.Collections.IEnumerator val_17 = 0.transform.GetEnumerator();
        goto label_61;
        label_68:
        var val_105 = 0;
        val_105 = val_105 + 1;
        object val_19 = val_17.Current;
        if((System.String.op_Equality(a:  0.name, b:  "image")) == false)
        {
            goto label_44;
        }
        
        0.GetComponent<UnityEngine.UI.Image>().sprite = UnityEngine.Object.Instantiate<UnityEngine.Sprite>(original:  this.powerImage[0]);
        goto label_61;
        label_44:
        if((System.String.op_Equality(a:  0.name, b:  "value")) == false)
        {
            goto label_53;
        }
        
        if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_61;
        }
        
        goto label_61;
        label_53:
        if((System.String.op_Equality(a:  0.name, b:  "count")) != false)
        {
                if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_61;
        }
        
        }
        
        label_61:
        var val_107 = 0;
        val_107 = val_107 + 1;
        if(val_17.MoveNext() == true)
        {
            goto label_68;
        }
        
        val_97 = 0;
        val_100 = 1152921504621170688;
        if(val_17 != null)
        {
                var val_108 = 0;
            val_108 = val_108 + 1;
            val_17.Dispose();
        }
        
        val_102 = 1;
        if(val_102 == 1)
        {
            goto label_96;
        }
        
        if(973 != 973)
        {
            goto label_97;
        }
        
        goto label_166;
        label_96:
        label_97:
        if((System.String.op_Equality(a:  0.name, b:  "Button2")) == false)
        {
            goto label_165;
        }
        
        System.Collections.IEnumerator val_38 = 0.transform.GetEnumerator();
        goto label_129;
        label_136:
        var val_109 = 0;
        val_109 = val_109 + 1;
        object val_40 = val_38.Current;
        if((System.String.op_Equality(a:  0.name, b:  "image")) == false)
        {
            goto label_112;
        }
        
        0.GetComponent<UnityEngine.UI.Image>().sprite = UnityEngine.Object.Instantiate<UnityEngine.Sprite>(original:  this.powerImage[0]);
        goto label_129;
        label_112:
        if((System.String.op_Equality(a:  0.name, b:  "value")) == false)
        {
            goto label_121;
        }
        
        if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_129;
        }
        
        goto label_129;
        label_121:
        if((System.String.op_Equality(a:  0.name, b:  "count")) != false)
        {
                if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_129;
        }
        
        }
        
        label_129:
        var val_111 = 0;
        val_111 = val_111 + 1;
        if(val_38.MoveNext() == true)
        {
            goto label_136;
        }
        
        val_105 = 0;
        val_100 = 1152921504621170688;
        if(val_38 != null)
        {
                var val_112 = 0;
            val_112 = val_112 + 1;
            val_38.Dispose();
        }
        
        val_102 = 1;
        if(val_102 == 1)
        {
            goto label_164;
        }
        
        if(973 != 973)
        {
            goto label_165;
        }
        
        goto label_166;
        label_164:
        label_165:
        if((System.String.op_Equality(a:  0.name, b:  "Button3")) == false)
        {
            goto label_233;
        }
        
        System.Collections.IEnumerator val_59 = 0.transform.GetEnumerator();
        goto label_197;
        label_204:
        var val_113 = 0;
        val_113 = val_113 + 1;
        object val_61 = val_59.Current;
        if((System.String.op_Equality(a:  0.name, b:  "image")) == false)
        {
            goto label_180;
        }
        
        0.GetComponent<UnityEngine.UI.Image>().sprite = UnityEngine.Object.Instantiate<UnityEngine.Sprite>(original:  this.powerImage[0]);
        goto label_197;
        label_180:
        if((System.String.op_Equality(a:  0.name, b:  "value")) == false)
        {
            goto label_189;
        }
        
        if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_197;
        }
        
        goto label_197;
        label_189:
        if((System.String.op_Equality(a:  0.name, b:  "count")) != false)
        {
                if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_197;
        }
        
        }
        
        label_197:
        var val_115 = 0;
        val_115 = val_115 + 1;
        if(val_59.MoveNext() == true)
        {
            goto label_204;
        }
        
        val_109 = 0;
        val_100 = 1152921504621170688;
        if(val_59 != null)
        {
                var val_116 = 0;
            val_116 = val_116 + 1;
            val_59.Dispose();
        }
        
        val_102 = 1;
        if(val_102 == 1)
        {
            goto label_232;
        }
        
        if(973 != 973)
        {
            goto label_233;
        }
        
        label_166:
        var val_117 = 0;
        val_117 = val_117 ^ 0;
        val_102 = val_102 + val_117;
        if(val_4 != null)
        {
            goto label_234;
        }
        
        goto label_235;
        label_232:
        label_233:
        if((System.String.op_Equality(a:  0.name, b:  "Button4")) == false)
        {
            goto label_301;
        }
        
        System.Collections.IEnumerator val_80 = 0.transform.GetEnumerator();
        goto label_266;
        label_273:
        var val_118 = 0;
        val_118 = val_118 + 1;
        object val_82 = val_80.Current;
        if((System.String.op_Equality(a:  0.name, b:  "image")) == false)
        {
            goto label_249;
        }
        
        0.GetComponent<UnityEngine.UI.Image>().sprite = UnityEngine.Object.Instantiate<UnityEngine.Sprite>(original:  this.powerImage[0]);
        goto label_266;
        label_249:
        if((System.String.op_Equality(a:  0.name, b:  "value")) == false)
        {
            goto label_258;
        }
        
        if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_266;
        }
        
        goto label_266;
        label_258:
        if((System.String.op_Equality(a:  0.name, b:  "count")) != false)
        {
                if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_266;
        }
        
        }
        
        label_266:
        var val_120 = 0;
        val_120 = val_120 + 1;
        if(val_80.MoveNext() == true)
        {
            goto label_273;
        }
        
        val_113 = 0;
        val_114 = 1;
        if(val_80 != null)
        {
                var val_121 = 0;
            val_121 = val_121 + 1;
            val_80.Dispose();
        }
        
        if( == 1)
        {
            goto label_301;
        }
        
        var val_99 = (val_98 == 973) ? 1 : 0;
        val_99 = (( >= 0) ? 1 : 0) & val_99;
        val_99 =  - val_99;
        goto label_302;
        label_15:
        var val_122 = 0;
        val_116 = 0;
        val_122 = val_122 + 1;
        mem2[0] = 1006;
        if(val_4 != null)
        {
                var val_123 = 0;
            val_123 = val_123 + 1;
            val_4.Dispose();
        }
        
        this.ques2Yellow.SetActive(value:  false);
        this.ques1Yellow.SetActive(value:  false);
        this.blackYellow.SetActive(value:  false);
        this.ironYellow.SetActive(value:  false);
        this.stunYellow.SetActive(value:  true);
        this.stunLarge.SetActive(value:  true);
        this.question1.SetActive(value:  false);
        this.question2.SetActive(value:  false);
    }
    public void onclickIron(UnityEngine.GameObject powerPanel)
    {
        var val_98;
        var val_92;
        var val_97;
        var val_100;
        var val_102;
        var val_105;
        var val_109;
        var val_113;
        var val_114;
        var val_116;
        this.powerNameText.text = LanguageManager.GetText(key:  "LK.Shop.PowerUps.Cannon");
        this.infoText.text = LanguageManager.GetText(key:  "LK.Shop.PowerUps.Cannon.Info");
        GameAudio.PlayButtonSound();
        this.selectedPowerUpType = 2;
        System.Collections.IEnumerator val_4 = powerPanel.transform.GetEnumerator();
        val_92 = 1152921504621170688;
        label_300:
        label_299:
        if(val_4 != null)
        {
            goto label_232;
        }
        
        label_233:
        label_232:
        var val_102 = 0;
        val_102 = val_102 + 1;
        if(val_4.MoveNext() == false)
        {
            goto label_13;
        }
        
        var val_103 = 0;
        val_103 = val_103 + 1;
        object val_8 = val_4.Current;
        if((System.String.op_Equality(a:  0.name, b:  "Info")) == false)
        {
            goto label_22;
        }
        
        string val_104 = this.infoString[1];
        if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_299;
        }
        
        goto label_299;
        label_22:
        if((System.String.op_Equality(a:  0.name, b:  "Button1")) == false)
        {
            goto label_95;
        }
        
        System.Collections.IEnumerator val_17 = 0.transform.GetEnumerator();
        goto label_59;
        label_66:
        var val_105 = 0;
        val_105 = val_105 + 1;
        object val_19 = val_17.Current;
        if((System.String.op_Equality(a:  0.name, b:  "image")) == false)
        {
            goto label_42;
        }
        
        0.GetComponent<UnityEngine.UI.Image>().sprite = UnityEngine.Object.Instantiate<UnityEngine.Sprite>(original:  this.powerImage[1]);
        goto label_59;
        label_42:
        if((System.String.op_Equality(a:  0.name, b:  "value")) == false)
        {
            goto label_51;
        }
        
        if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_59;
        }
        
        goto label_59;
        label_51:
        if((System.String.op_Equality(a:  0.name, b:  "count")) != false)
        {
                if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_59;
        }
        
        }
        
        label_59:
        var val_107 = 0;
        val_107 = val_107 + 1;
        if(val_17.MoveNext() == true)
        {
            goto label_66;
        }
        
        val_97 = 0;
        val_100 = 1152921504621170688;
        if(val_17 != null)
        {
                var val_108 = 0;
            val_108 = val_108 + 1;
            val_17.Dispose();
        }
        
        val_102 = 1;
        if(val_102 == 1)
        {
            goto label_94;
        }
        
        if(956 != 956)
        {
            goto label_95;
        }
        
        goto label_164;
        label_94:
        label_95:
        if((System.String.op_Equality(a:  0.name, b:  "Button2")) == false)
        {
            goto label_163;
        }
        
        System.Collections.IEnumerator val_38 = 0.transform.GetEnumerator();
        goto label_127;
        label_134:
        var val_109 = 0;
        val_109 = val_109 + 1;
        object val_40 = val_38.Current;
        if((System.String.op_Equality(a:  0.name, b:  "image")) == false)
        {
            goto label_110;
        }
        
        0.GetComponent<UnityEngine.UI.Image>().sprite = UnityEngine.Object.Instantiate<UnityEngine.Sprite>(original:  this.powerImage[1]);
        goto label_127;
        label_110:
        if((System.String.op_Equality(a:  0.name, b:  "value")) == false)
        {
            goto label_119;
        }
        
        if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_127;
        }
        
        goto label_127;
        label_119:
        if((System.String.op_Equality(a:  0.name, b:  "count")) != false)
        {
                if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_127;
        }
        
        }
        
        label_127:
        var val_111 = 0;
        val_111 = val_111 + 1;
        if(val_38.MoveNext() == true)
        {
            goto label_134;
        }
        
        val_105 = 0;
        val_100 = 1152921504621170688;
        if(val_38 != null)
        {
                var val_112 = 0;
            val_112 = val_112 + 1;
            val_38.Dispose();
        }
        
        val_102 = 1;
        if(val_102 == 1)
        {
            goto label_162;
        }
        
        if(956 != 956)
        {
            goto label_163;
        }
        
        goto label_164;
        label_162:
        label_163:
        if((System.String.op_Equality(a:  0.name, b:  "Button3")) == false)
        {
            goto label_231;
        }
        
        System.Collections.IEnumerator val_59 = 0.transform.GetEnumerator();
        goto label_195;
        label_202:
        var val_113 = 0;
        val_113 = val_113 + 1;
        object val_61 = val_59.Current;
        if((System.String.op_Equality(a:  0.name, b:  "image")) == false)
        {
            goto label_178;
        }
        
        0.GetComponent<UnityEngine.UI.Image>().sprite = UnityEngine.Object.Instantiate<UnityEngine.Sprite>(original:  this.powerImage[1]);
        goto label_195;
        label_178:
        if((System.String.op_Equality(a:  0.name, b:  "value")) == false)
        {
            goto label_187;
        }
        
        if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_195;
        }
        
        goto label_195;
        label_187:
        if((System.String.op_Equality(a:  0.name, b:  "count")) != false)
        {
                if((0.GetComponent<UnityEngine.GUILayer>()) != null)
        {
            goto label_195;
        }
        
        }
        
        label_195:
        var val_115 = 0;
        val_115 = val_115 + 1;
        if(val_59.MoveNext() == true)
        {
            goto label_202;
        }
        
        val_109 = 0;
        val_100 = 1152921504621170688;
        if(val_59 != null)
        {
                var val_116 = 0;
            val_116 = val_116 + 1;
            val_59.Dispose();
        }
        
        val_102 = 1;
        if(val_102 == 1)
        {
            goto label_230;
        }
        
        if(956 != 956)
        {
            goto label_231;
        }
        
        label_164:
        var val_117 = 0;
        val_117 = val_117 ^ 0;
        val_102 = val_102 + val_117;
        if(val_4 != null)
        {
            goto label_232;
        }
        
        goto label_233;
        label_230:
        label_231:
        if((System.String.op_Equality(a:  0.name, b:  "Button4")) == false)
        {
            goto label_299;
        }
        
        System.Collections.IEnumerator val_80 = 0.transform.GetEnumerator();
        goto label_264;
        label_271:
        var val_118 = 0;
        val_118 = val_118 + 1;
        object val_82 = val_80.Current;
        if((System.String.op_Equality(a:  0.name, b:  "image")) == false)
        {
            goto label_247;
        }
        
        0.GetComponent<UnityEngine.UI.Image>().sprite = UnityEngine.Object.Instantiate<UnityEngine.Sprite>(original:  this.powerImage[1]);
        goto label_264;
        label_247:
        if((System.String.op_Equality(a:  0.name, b:  "value")) == false)
        {
            goto label_256;
        }
        
        if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_264;
        }
        
        goto label_264;
        label_256:
        if((System.String.op_Equality(a:  0.name, b:  "count")) != false)
        {
                if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_264;
        }
        
        }
        
        label_264:
        var val_120 = 0;
        val_120 = val_120 + 1;
        if(val_80.MoveNext() == true)
        {
            goto label_271;
        }
        
        val_113 = 0;
        val_114 = 1;
        if(val_80 != null)
        {
                var val_121 = 0;
            val_121 = val_121 + 1;
            val_80.Dispose();
        }
        
        if( == 1)
        {
            goto label_299;
        }
        
        var val_99 = (val_98 == 956) ? 1 : 0;
        val_99 = (( >= 0) ? 1 : 0) & val_99;
        val_99 =  - val_99;
        goto label_300;
        label_13:
        var val_122 = 0;
        val_116 = 0;
        val_122 = val_122 + 1;
        mem2[0] = 989;
        if(val_4 != null)
        {
                var val_123 = 0;
            val_123 = val_123 + 1;
            val_4.Dispose();
        }
        
        this.ques2Yellow.SetActive(value:  false);
        this.ques1Yellow.SetActive(value:  false);
        this.blackYellow.SetActive(value:  false);
        this.ironYellow.SetActive(value:  true);
        this.stunYellow.SetActive(value:  false);
        this.stunLarge.SetActive(value:  true);
        this.question1.SetActive(value:  false);
        this.question2.SetActive(value:  false);
    }
    public void onclickBlackHole(UnityEngine.GameObject powerPanel)
    {
        var val_98;
        var val_92;
        var val_97;
        var val_100;
        var val_102;
        var val_105;
        var val_109;
        var val_113;
        var val_114;
        var val_116;
        this.powerNameText.text = LanguageManager.GetText(key:  "LK.Shop.PowerUps.Eraser");
        this.infoText.text = LanguageManager.GetText(key:  "LK.Shop.PowerUps.Eraser.Info");
        GameAudio.PlayButtonSound();
        this.selectedPowerUpType = 3;
        System.Collections.IEnumerator val_4 = powerPanel.transform.GetEnumerator();
        val_92 = 1152921504621170688;
        label_300:
        label_299:
        if(val_4 != null)
        {
            goto label_232;
        }
        
        label_233:
        label_232:
        var val_102 = 0;
        val_102 = val_102 + 1;
        if(val_4.MoveNext() == false)
        {
            goto label_13;
        }
        
        var val_103 = 0;
        val_103 = val_103 + 1;
        object val_8 = val_4.Current;
        if((System.String.op_Equality(a:  0.name, b:  "Info")) == false)
        {
            goto label_22;
        }
        
        string val_104 = this.infoString[2];
        if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_299;
        }
        
        goto label_299;
        label_22:
        if((System.String.op_Equality(a:  0.name, b:  "Button1")) == false)
        {
            goto label_95;
        }
        
        System.Collections.IEnumerator val_17 = 0.transform.GetEnumerator();
        goto label_59;
        label_66:
        var val_105 = 0;
        val_105 = val_105 + 1;
        object val_19 = val_17.Current;
        if((System.String.op_Equality(a:  0.name, b:  "image")) == false)
        {
            goto label_42;
        }
        
        0.GetComponent<UnityEngine.UI.Image>().sprite = UnityEngine.Object.Instantiate<UnityEngine.Sprite>(original:  this.powerImage[2]);
        goto label_59;
        label_42:
        if((System.String.op_Equality(a:  0.name, b:  "value")) == false)
        {
            goto label_51;
        }
        
        if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_59;
        }
        
        goto label_59;
        label_51:
        if((System.String.op_Equality(a:  0.name, b:  0)) != false)
        {
                if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_59;
        }
        
        }
        
        label_59:
        var val_107 = 0;
        val_107 = val_107 + 1;
        if(val_17.MoveNext() == true)
        {
            goto label_66;
        }
        
        val_97 = 0;
        val_100 = 1152921504621170688;
        if(val_17 != null)
        {
                var val_108 = 0;
            val_108 = val_108 + 1;
            val_17.Dispose();
        }
        
        val_102 = 1;
        if(val_102 == 1)
        {
            goto label_94;
        }
        
        if(956 != 956)
        {
            goto label_95;
        }
        
        goto label_164;
        label_94:
        label_95:
        if((System.String.op_Equality(a:  0.name, b:  "Button2")) == false)
        {
            goto label_163;
        }
        
        System.Collections.IEnumerator val_38 = 0.transform.GetEnumerator();
        goto label_127;
        label_134:
        var val_109 = 0;
        val_109 = val_109 + 1;
        object val_40 = val_38.Current;
        if((System.String.op_Equality(a:  0.name, b:  "image")) == false)
        {
            goto label_110;
        }
        
        0.GetComponent<UnityEngine.UI.Image>().sprite = UnityEngine.Object.Instantiate<UnityEngine.Sprite>(original:  this.powerImage[2]);
        goto label_127;
        label_110:
        if((System.String.op_Equality(a:  0.name, b:  "value")) == false)
        {
            goto label_119;
        }
        
        if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_127;
        }
        
        goto label_127;
        label_119:
        if((System.String.op_Equality(a:  0.name, b:  "count")) != false)
        {
                if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_127;
        }
        
        }
        
        label_127:
        var val_111 = 0;
        val_111 = val_111 + 1;
        if(val_38.MoveNext() == true)
        {
            goto label_134;
        }
        
        val_105 = 0;
        val_100 = 1152921504621170688;
        if(val_38 != null)
        {
                var val_112 = 0;
            val_112 = val_112 + 1;
            val_38.Dispose();
        }
        
        val_102 = 1;
        if(val_102 == 1)
        {
            goto label_162;
        }
        
        if(956 != 956)
        {
            goto label_163;
        }
        
        goto label_164;
        label_162:
        label_163:
        if((System.String.op_Equality(a:  0.name, b:  "Button3")) == false)
        {
            goto label_231;
        }
        
        System.Collections.IEnumerator val_59 = 0.transform.GetEnumerator();
        goto label_195;
        label_202:
        var val_113 = 0;
        val_113 = val_113 + 1;
        object val_61 = val_59.Current;
        if((System.String.op_Equality(a:  0.name, b:  "image")) == false)
        {
            goto label_178;
        }
        
        0.GetComponent<UnityEngine.UI.Image>().sprite = UnityEngine.Object.Instantiate<UnityEngine.Sprite>(original:  this.powerImage[2]);
        goto label_195;
        label_178:
        if((System.String.op_Equality(a:  0.name, b:  "value")) == false)
        {
            goto label_187;
        }
        
        if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_195;
        }
        
        goto label_195;
        label_187:
        if((System.String.op_Equality(a:  0.name, b:  "count")) != false)
        {
                if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_195;
        }
        
        }
        
        label_195:
        var val_115 = 0;
        val_115 = val_115 + 1;
        if(val_59.MoveNext() == true)
        {
            goto label_202;
        }
        
        val_109 = 0;
        val_100 = 1152921504621170688;
        if(val_59 != null)
        {
                var val_116 = 0;
            val_116 = val_116 + 1;
            val_59.Dispose();
        }
        
        val_102 = 1;
        if(val_102 == 1)
        {
            goto label_230;
        }
        
        if(956 != 956)
        {
            goto label_231;
        }
        
        label_164:
        var val_117 = 0;
        val_117 = val_117 ^ 0;
        val_102 = val_102 + val_117;
        if(val_4 != null)
        {
            goto label_232;
        }
        
        goto label_233;
        label_230:
        label_231:
        if((System.String.op_Equality(a:  0.name, b:  "Button4")) == false)
        {
            goto label_299;
        }
        
        System.Collections.IEnumerator val_80 = 0.transform.GetEnumerator();
        goto label_264;
        label_271:
        var val_118 = 0;
        val_118 = val_118 + 1;
        object val_82 = val_80.Current;
        if((System.String.op_Equality(a:  0.name, b:  "image")) == false)
        {
            goto label_247;
        }
        
        0.GetComponent<UnityEngine.UI.Image>().sprite = UnityEngine.Object.Instantiate<UnityEngine.Sprite>(original:  this.powerImage[2]);
        goto label_264;
        label_247:
        if((System.String.op_Equality(a:  0.name, b:  "value")) == false)
        {
            goto label_256;
        }
        
        if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_264;
        }
        
        goto label_264;
        label_256:
        if((System.String.op_Equality(a:  0.name, b:  "count")) != false)
        {
                if((0.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_264;
        }
        
        }
        
        label_264:
        var val_120 = 0;
        val_120 = val_120 + 1;
        if(val_80.MoveNext() == true)
        {
            goto label_271;
        }
        
        val_113 = 0;
        val_114 = 1;
        if(val_80 != null)
        {
                var val_121 = 0;
            val_121 = val_121 + 1;
            val_80.Dispose();
        }
        
        if( == 1)
        {
            goto label_299;
        }
        
        var val_99 = (val_98 == 956) ? 1 : 0;
        val_99 = (( >= 0) ? 1 : 0) & val_99;
        val_99 =  - val_99;
        goto label_300;
        label_13:
        var val_122 = 0;
        val_116 = 0;
        val_122 = val_122 + 1;
        mem2[0] = 989;
        if(val_4 != null)
        {
                var val_123 = 0;
            val_123 = val_123 + 1;
            val_4.Dispose();
        }
        
        this.ques2Yellow.SetActive(value:  false);
        this.ques1Yellow.SetActive(value:  false);
        this.blackYellow.SetActive(value:  true);
        this.ironYellow.SetActive(value:  false);
        this.stunYellow.SetActive(value:  false);
        this.stunLarge.SetActive(value:  true);
        this.question1.SetActive(value:  false);
        this.question2.SetActive(value:  false);
    }
    public void onQuestion1()
    {
        GameAudio.PlayButtonSound();
        this.ques2Yellow.SetActive(value:  false);
        this.ques1Yellow.SetActive(value:  true);
        this.blackYellow.SetActive(value:  false);
        this.ironYellow.SetActive(value:  false);
        this.stunYellow.SetActive(value:  false);
        this.stunLarge.SetActive(value:  false);
        this.question1.SetActive(value:  true);
        this.question2.SetActive(value:  false);
    }
    public void onQuestion2()
    {
        GameAudio.PlayButtonSound();
        this.ques2Yellow.SetActive(value:  true);
        this.ques1Yellow.SetActive(value:  false);
        this.blackYellow.SetActive(value:  false);
        this.blackYellow.SetActive(value:  false);
        this.stunYellow.SetActive(value:  false);
        this.stunLarge.SetActive(value:  false);
        this.question1.SetActive(value:  false);
        this.question2.SetActive(value:  true);
    }
    public void buttonInapp()
    {
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        UnityEngine.PlayerPrefs.SetString(key:  "LastLevel", value:  val_1.m_Handle.name);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_GetPearl");
    }
    public void Button1(UnityEngine.GameObject button)
    {
        powerUpsScene.<>c__DisplayClass42_0 val_24;
        var val_25;
        int val_26;
        var val_29;
        powerUpsScene.<>c__DisplayClass42_0 val_1 = null;
        val_24 = val_1;
        val_1 = new powerUpsScene.<>c__DisplayClass42_0();
        .<>4__this = this;
        GameAudio.PlayButtonSound();
        System.Collections.IEnumerator val_3 = button.transform.GetEnumerator();
        val_25 = "value";
        val_26 = this.quantity;
        goto label_22;
        label_29:
        var val_26 = 0;
        val_26 = val_26 + 1;
        object val_5 = val_3.Current;
        if((System.String.op_Equality(a:  0.name, b:  "value")) != false)
        {
                mem2[0] = System.Int32.Parse(s:  0.GetComponent<UnityEngine.UI.Text>());
            val_25 = val_25;
            val_26 = val_26;
            val_24 = val_24;
        }
        
        if((System.String.op_Equality(a:  0.name, b:  "count")) != false)
        {
                mem2[0] = System.Int32.Parse(s:  0.GetComponent<UnityEngine.UI.Text>());
        }
        
        label_22:
        var val_27 = 0;
        val_27 = val_27 + 1;
        if(val_3.MoveNext() == true)
        {
            goto label_29;
        }
        
        val_29 = 0;
        if(val_3 != null)
        {
                var val_28 = 0;
            val_28 = val_28 + 1;
            val_3.Dispose();
        }
        
        object[] val_20 = new object[2];
        val_20[0] = val_26.ToString();
        val_20[1] = this.price.ToString();
        .dialog = 0;
        .dialog = PurchaseAndEquipDialog.Show(msg:  LanguageManager.GetTextFormat(key:  "LK.Shop.Powerups.PurchaseMsg", list:  val_20), title:  LanguageManager.GetText(key:  "LK.Shop.Powerups.PurchaseTitle"), currency:  0, price:  this.price, purchaseDoneAction:  new System.Action(object:  val_1, method:  System.Void powerUpsScene.<>c__DisplayClass42_0::<Button1>b__0()));
    }
    public powerUpsScene()
    {
        this.muteFirstButtonSoundForInit = true;
    }

}
