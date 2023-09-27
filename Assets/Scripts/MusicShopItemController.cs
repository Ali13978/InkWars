using UnityEngine;
public class MusicShopItemController : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Text musicTitleText;
    public TMPro.TextMeshProUGUI musicSubTitleText;
    public MusicShopBuyButton buyButton;
    public PearlBuyButton pearlBuyButton;
    public UnityEngine.UI.Image gotImage;
    private int musicId;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Time.timeScale = 1f;
    }
    public void SetupMusic(MusicData data)
    {
        TMPro.TextMeshProUGUI val_17;
        string val_18;
        var val_19;
        if(data == null)
        {
                return;
        }
        
        if(0 != this.musicTitleText)
        {
                string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  X22);
        }
        
        val_17 = this.musicSubTitleText;
        if(0 != val_17)
        {
                string val_4 = data.subTitle.Replace(oldValue:  "Theme of ", newValue:  "");
            val_17 = this.musicSubTitleText;
            val_18 = 0;
            if((System.String.IsNullOrEmpty(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  data.subTitle))) != true)
        {
                object[] val_7 = new object[1];
            val_7[0] = val_4;
            val_18 = LanguageManager.GetTextFormat(key:  "LK.Shop.BGM.Music.TheamOf", list:  val_7);
        }
        
            val_17.text = val_18;
        }
        
        this.musicId = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4, hiddenValue = val_4, fakeValue = val_17, inited = val_17});
        val_19 = null;
        val_19 = null;
        int val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 544673792, hiddenValue = 268435456, fakeValue = val_17, inited = val_17});
        if((DataStructs.UserDataDictionary.Items.IsMusicUnlocked(id:  val_10)) == false)
        {
            goto label_26;
        }
        
        if(this.gotImage != null)
        {
            goto label_42;
        }
        
        label_43:
        label_42:
        this.gotImage.gameObject.SetActive(value:  true);
        return;
        label_26:
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = DataStructs.UserDataDictionary.Items, hiddenValue = DataStructs.UserDataDictionary.Items, fakeValue = val_10, inited = val_10})) <= 0)
        {
            goto label_31;
        }
        
        this.pearlBuyButton.Setup(aNewItemName:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_10), aNewItem:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = X24, hiddenValue = X24, fakeValue = 1152921505062117376, inited = false}), aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 1152921505062117376, fakeValue = X24, inited = X24}, aNewCurrency:  data);
        if(this.pearlBuyButton != null)
        {
            goto label_42;
        }
        
        goto label_43;
        label_31:
        mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = DataStructs.UserDataDictionary.Items, hiddenValue = DataStructs.UserDataDictionary.Items, fakeValue = data, inited = data});
        if(this.buyButton != null)
        {
            goto label_42;
        }
        
        goto label_43;
    }
    public void OnTestPlayMusicClick()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        ShopBackground.customSoundTrackPlayed = true;
        val_5 = null;
        val_5 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
        DataStructs.UserDataDictionary.Settings.MusicEnabled = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295};
        val_6 = null;
        val_6 = null;
        GameAudio.SwitchMusic(clip:  GameInfo.music.LoadResourceById(uniqueId:  this.musicId), customLoopStartTime:  0f, customLoopEndTime:  0f, forcePlay:  false);
    }
    public MusicShopItemController()
    {
    
    }

}
