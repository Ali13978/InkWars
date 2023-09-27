using UnityEngine;
public class ShopBackground : MonoBehaviour
{
    // Fields
    public static bool customSoundTrackPlayed;
    public StageSelectionController backgroundsPanel;
    public UnityEngine.GameObject musicPanel;
    public UnityEngine.GameObject backgroundButtonBack;
    public UnityEngine.GameObject musicButtonBack;
    public UnityEngine.GameObject ggpButton;
    private UnityEngine.Vector3 leftPostion;
    private UnityEngine.Vector3 middlePostion;
    private UnityEngine.Vector3 rightPostion;
    private bool currentUserMusicSetting;
    
    // Methods
    private void Start()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = DataStructs.UserDataDictionary.Settings.MusicEnabled;
        val_1.fakeValue = val_1.fakeValue & 4294967295;
        this.currentUserMusicSetting = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, fakeValueChanged = val_1.fakeValue, inited = val_1.fakeValue});
        val_5 = null;
        val_5 = null;
        ShopBackground.customSoundTrackPlayed = false;
        this.backgroundButtonBack.SetActive(value:  true);
        this.musicButtonBack.SetActive(value:  false);
        this.backgroundsPanel.SetActive(active:  true);
        this.musicPanel.SetActive(value:  false);
        this.ggpButton.SetActive(value:  false);
    }
    public void BackgroundButtonClick()
    {
        GameAudio.PlayButtonSound();
        this.backgroundButtonBack.SetActive(value:  true);
        this.musicButtonBack.SetActive(value:  false);
        this.backgroundsPanel.SetActive(active:  true);
        this.musicPanel.SetActive(value:  false);
        this.ggpButton.SetActive(value:  false);
    }
    public void MusicButtonClick()
    {
        GameAudio.PlayButtonSound();
        this.backgroundButtonBack.SetActive(value:  false);
        this.musicButtonBack.SetActive(value:  true);
        this.backgroundsPanel.SetActive(active:  false);
        this.musicPanel.SetActive(value:  true);
        this.ggpButton.SetActive(value:  true);
    }
    public void PurchaseMusicClicked()
    {
        GameAudio.PlayButtonSound();
    }
    public void BackButtonClicked()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  (this.currentUserMusicSetting == true) ? 1 : 0);
        DataStructs.UserDataDictionary.Settings.MusicEnabled = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295};
        GameAudio.PlayButtonSound();
        val_5 = null;
        val_5 = null;
        if(ShopBackground.customSoundTrackPlayed != false)
        {
                MainTitleBackMusicHandler.Play();
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Shop_Scene");
    }
    public ShopBackground()
    {
    
    }
    private static ShopBackground()
    {
    
    }

}
