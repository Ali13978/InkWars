using UnityEngine;
public class ShareScreenButton : MonoBehaviour
{
    // Fields
    public bool disableAfterShare;
    
    // Properties
    public static int SHARE_UNLOCK_COUNT { get; }
    
    // Methods
    public static int get_SHARE_UNLOCK_COUNT()
    {
        return 20;
    }
    private void Start()
    {
    
    }
    private void OnEnable()
    {
        AppAdvisory.SharingSystem.VSSHARE.add_OnNativeShareWindowOpened(value:  new VSSHARE.OnNativeShareWindowOpenedHandler(object:  this, method:  System.Void ShareScreenButton::OnShareWindowOpened()));
    }
    private void OnDisable()
    {
        AppAdvisory.SharingSystem.VSSHARE.remove_OnNativeShareWindowOpened(value:  new VSSHARE.OnNativeShareWindowOpenedHandler(object:  this, method:  System.Void ShareScreenButton::OnShareWindowOpened()));
    }
    private void OnShareWindowOpened()
    {
        var val_16;
        int val_17;
        DataStructs.Items val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        this.gameObject.SetActive(value:  (this.disableAfterShare == false) ? 1 : 0);
        val_16 = null;
        val_16 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Stats.ShareScreenCount;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited});
        val_17 = val_4.fakeValue;
        DataStructs.UserDataDictionary.Stats.ShareScreenCount = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_17, inited = val_4.inited};
        val_18 = DataStructs.UserDataDictionary.Items;
        if((val_18.IsCharacterLocked(id:  25)) == false)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = DataStructs.UserDataDictionary.Stats.ShareScreenCount;
        val_18 = val_6.currentCryptoKey;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_18, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited})) < 20)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        DataStructs.UserDataDictionary.Items.SetCharacterUnlock(id:  25, unlocked:  true, displayAvatarUnlockPopup:  true);
        val_21 = null;
        val_21 = null;
        val_17 = 1152921504858337280;
        if(0 != LineController.instance)
        {
                val_22 = null;
            val_22 = null;
            if(0 != LineController.instance.characterUnlockPanel)
        {
                val_23 = null;
            val_23 = null;
            LineController.instance.characterUnlockPanel.SetActive(value:  true);
            LineController.instance.SetupCharacterUnlockPanel(cid:  25, showPanel:  true);
            UnityEngine.AudioSource val_13 = GameAudio.sound.PlayOneShot(clip:  LineController.instance.characterUnlockedClip, volume:  1f);
        }
        
        }
        
        val_24 = null;
        val_24 = null;
        val_18 = WinScreenParticleManager.instance;
        if(0 == val_18)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        val_18 = WinScreenParticleManager.instance;
        if(null == null)
        {
                return;
        }
        
        val_26 = null;
        val_26 = null;
        val_18 = WinScreenParticleManager.instance;
        val_27 = 0;
    }
    public void ShareScreen()
    {
        AppAdvisory.SharingSystem.VSSHARE.DOTakeScreenShot();
    }
    public ShareScreenButton()
    {
        this.disableAfterShare = true;
    }

}
