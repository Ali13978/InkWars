using UnityEngine;
public class View_Panel_Pause : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject Panel_Pause;
    public UnityEngine.GameObject Panel_AreYouSure;
    public UnityEngine.GameObject BG_Fade;
    public UnityEngine.GameObject MusselCount;
    public UnityEngine.GameObject PearlCount;
    public UnityEngine.UI.Image button_Pause;
    public UnityEngine.UI.Image button_Play;
    public UnityEngine.UI.Image button_Restart;
    public UnityEngine.UI.Image button_PreviousMenu;
    public UnityEngine.UI.Image button_Music;
    public UnityEngine.UI.Image button_SoundFX;
    public UnityEngine.UI.Button button_CharacterSelect;
    public UnityEngine.UI.Button button_TutorialTip;
    public TMPro.TextMeshProUGUI text_MusselCount;
    public TMPro.TextMeshProUGUI text_MusselTimeTilReplenishment;
    public TMPro.TextMeshProUGUI text_PearlCount;
    public UnityEngine.Sprite sprite_Music_On;
    public UnityEngine.Sprite sprite_Music_Off;
    public UnityEngine.Sprite sprite_SoundFX_On;
    public UnityEngine.Sprite sprite_SoundFX_Off;
    
    // Methods
    private void Awake()
    {
        var val_6;
        var val_7;
        var val_8;
        this.button_CharacterSelect.gameObject.SetActive(value:  false);
        this.button_TutorialTip.gameObject.SetActive(value:  false);
        val_6 = null;
        val_6 = null;
        if(Character_GlobalInfo.gameMode > 10)
        {
                return;
        }
        
        var val_6 = 1;
        val_6 = val_6 << Character_GlobalInfo.gameMode;
        if((val_6 & 30) != 0)
        {
            goto label_8;
        }
        
        val_6 = val_6 & 1089;
        if(val_6 == 0)
        {
            goto label_9;
        }
        
        val_7 = this.button_Pause.gameObject;
        val_8 = 0;
        goto label_12;
        label_8:
        if(this.button_TutorialTip != null)
        {
            goto label_16;
        }
        
        label_17:
        label_16:
        val_7 = this.button_TutorialTip.gameObject;
        val_8 = 1;
        label_12:
        val_7.SetActive(value:  true);
        return;
        label_9:
        if(Character_GlobalInfo.gameMode != 5)
        {
                return;
        }
        
        if(this.button_CharacterSelect != null)
        {
            goto label_16;
        }
        
        goto label_17;
    }
    private void Update()
    {
        var val_8;
        InkWars.Model.Model_Manager val_1 = InkWars.Model.Model_Manager.Instance;
        if(val_1.Model.InkEmUp_CurrentPhase != 0)
        {
                this.button_Pause.gameObject.SetActive(value:  false);
        }
        
        val_8 = null;
        val_8 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Items.Mussels;
        this.text_MusselCount.text = val_3.currentCryptoKey.ToString();
        this.text_MusselTimeTilReplenishment.text = MVC_MusselTracker.GetTimeTilNextMussel();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = DataStructs.UserDataDictionary.Items.Pearls;
        this.text_PearlCount.text = val_6.currentCryptoKey.ToString();
    }
    public void Button_Pause()
    {
        GameAudio.PlayButtonSound();
        this.Panel_Pause.SetActive(value:  true);
        this.BG_Fade.SetActive(value:  true);
        if(Character_GlobalInfo.IsAdventureMode() != false)
        {
                this.MusselCount.SetActive(value:  true);
        }
        
        InkWars.Model.Model_Manager.Instance.enabled = false;
    }
    public void Button_Play()
    {
        GameAudio.PlayButtonSound();
        InkWars.Model.Model_Manager.Instance.enabled = true;
        this.BG_Fade.SetActive(value:  false);
        this.MusselCount.SetActive(value:  false);
        this.PearlCount.SetActive(value:  false);
        this.Panel_Pause.SetActive(value:  false);
    }
    public void Button_Restart()
    {
        var val_6;
        System.Action val_8;
        GameAudio.PlayButtonSound();
        if(MVC_MusselTracker.GetMusselCount() >= 1)
        {
                val_6 = null;
            val_6 = null;
            val_8 = View_Panel_Pause.<>c.<>9__24_0;
            if(val_8 == null)
        {
                System.Action val_4 = null;
            val_8 = val_4;
            val_4 = new System.Action(object:  View_Panel_Pause.<>c.__il2cppRuntimeField_static_fields, method:  System.Void View_Panel_Pause.<>c::<Button_Restart>b__24_0());
            View_Panel_Pause.<>c.<>9__24_0 = val_8;
        }
        
            YesNoDialog val_5 = YesNoDialog.Show(title:  LanguageManager.GetText(key:  "LK.Pause.Restart"), msg:  LanguageManager.GetText(key:  "LK.AreYouSure"), yesAction:  val_4, noAction:  0);
            return;
        }
        
        DynamicUISingleton<ExpressMusselPurchaseCanvas>.Show();
    }
    public void Button_CharacterSelect()
    {
        var val_6;
        System.Action val_8;
        GameAudio.PlayButtonSound();
        if(MVC_MusselTracker.GetMusselCount() < 2)
        {
                DynamicUISingleton<ExpressMusselPurchaseCanvas>.Show();
            return;
        }
        
        val_6 = null;
        val_6 = null;
        val_8 = View_Panel_Pause.<>c.<>9__25_0;
        if(val_8 == null)
        {
                System.Action val_4 = null;
            val_8 = val_4;
            val_4 = new System.Action(object:  View_Panel_Pause.<>c.__il2cppRuntimeField_static_fields, method:  System.Void View_Panel_Pause.<>c::<Button_CharacterSelect>b__25_0());
            View_Panel_Pause.<>c.<>9__25_0 = val_8;
        }
        
        YesNoDialog val_5 = YesNoDialog.Show(title:  LanguageManager.GetText(key:  "LK.ReturnMsgCharacterSelect"), msg:  LanguageManager.GetText(key:  "LK.AreYouSure"), yesAction:  val_4, noAction:  0);
    }
    public void Button_TutorialTip()
    {
        GameAudio.PlayButtonSound();
    }
    public void Button_Music()
    {
        var val_8;
        GameAudio.PlayButtonSound();
        val_8 = null;
        val_8 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = DataStructs.UserDataDictionary.Settings.MusicEnabled;
        val_1.fakeValue = val_1.fakeValue & 4294967295;
        bool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, fakeValueChanged = val_1.fakeValue, inited = val_1.fakeValue});
        val_2 = (~val_2) & 1;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  val_2);
        DataStructs.UserDataDictionary.Settings.MusicEnabled = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue & 4294967295, fakeValueChanged = val_3.fakeValue & 4294967295, inited = val_3.fakeValue & 4294967295};
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_5 = DataStructs.UserDataDictionary.Settings.MusicEnabled;
        val_5.fakeValue = val_5.fakeValue & 4294967295;
        this.button_Music.sprite = ((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, fakeValueChanged = val_5.fakeValue, inited = val_5.fakeValue})) != true) ? this.sprite_Music_On : this.sprite_Music_Off;
    }
    public void Button_PreviousMenu()
    {
        string val_6;
        var val_7;
        var val_8;
        System.Action val_10;
        GameAudio.PlayButtonSound();
        val_6 = LanguageManager.GetText(key:  "LK.ReturnMsgMenu");
        val_7 = null;
        val_7 = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
                val_6 = LanguageManager.GetText(key:  "LK.ReturnMsgTitleScreen");
        }
        
        val_8 = null;
        val_8 = null;
        val_10 = View_Panel_Pause.<>c.<>9__28_0;
        if(val_10 == null)
        {
                System.Action val_4 = null;
            val_10 = val_4;
            val_4 = new System.Action(object:  View_Panel_Pause.<>c.__il2cppRuntimeField_static_fields, method:  System.Void View_Panel_Pause.<>c::<Button_PreviousMenu>b__28_0());
            View_Panel_Pause.<>c.<>9__28_0 = val_10;
        }
        
        YesNoDialog val_5 = YesNoDialog.Show(title:  val_6, msg:  LanguageManager.GetText(key:  "LK.AreYouSure"), yesAction:  val_4, noAction:  0);
    }
    public void Button_SoundFX()
    {
        var val_8;
        GameAudio.PlayButtonSound();
        val_8 = null;
        val_8 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = DataStructs.UserDataDictionary.Settings.SoundEnabled;
        val_1.fakeValue = val_1.fakeValue & 4294967295;
        bool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, fakeValueChanged = val_1.fakeValue, inited = val_1.fakeValue});
        val_2 = (~val_2) & 1;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  val_2);
        DataStructs.UserDataDictionary.Settings.SoundEnabled = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue & 4294967295, fakeValueChanged = val_3.fakeValue & 4294967295, inited = val_3.fakeValue & 4294967295};
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_5 = DataStructs.UserDataDictionary.Settings.SoundEnabled;
        val_5.fakeValue = val_5.fakeValue & 4294967295;
        this.button_SoundFX.sprite = ((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, fakeValueChanged = val_5.fakeValue, inited = val_5.fakeValue})) != true) ? this.sprite_SoundFX_On : this.sprite_SoundFX_Off;
    }
    public void ClosePanel(UnityEngine.GameObject panel)
    {
        panel.SetActive(value:  false);
    }
    public View_Panel_Pause()
    {
    
    }

}
