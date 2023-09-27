using UnityEngine;
public class shopScreen : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject storePanel;
    public static int currentShopScreen;
    public UnityEngine.Sprite activeButtonSprite;
    public UnityEngine.Sprite inactiveButtonSprite;
    public UnityEngine.UI.Image[] buttons;
    public UnityEngine.GameObject[] activeBacks;
    private int previousScreen;
    
    // Methods
    private void Start()
    {
        var val_4;
        var val_6;
        MMOCClientUser val_1 = MMOCUser.current;
        val_4 = null;
        val_4 = null;
        if((shopScreen.<>c.<>9__7_0) == null)
        {
            goto label_3;
        }
        
        label_19:
        val_1.GetUserProfile(onGetUserProfileDone:  shopScreen.<>c.<>9__7_0);
        GGPPurchasingManager.instance.InitializePurchasing();
        val_6 = null;
        val_6 = null;
        this.previousScreen = shopScreen.currentShopScreen;
        this.buttons[shopScreen.currentShopScreen].sprite = this.activeButtonSprite;
        this.activeBacks[shopScreen.currentShopScreen].SetActive(value:  true);
        return;
        label_3:
        shopScreen.<>c.<>9__7_0 = new UnityEngine.Events.UnityAction<MMOCUserProfile>(object:  shopScreen.<>c.__il2cppRuntimeField_static_fields, method:  System.Void shopScreen.<>c::<Start>b__7_0(MMOCClientUser.MMOCUserProfile res));
        if(val_1 != null)
        {
            goto label_19;
        }
        
        goto label_19;
    }
    public void backtoTitle()
    {
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu_Title_Screen");
    }
    public void vip()
    {
        var val_1;
        GameAudio.PlayButtonSound();
        val_1 = null;
        val_1 = null;
        shopScreen.currentShopScreen = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_VIP");
    }
    public void backgroundBuy()
    {
        null = null;
        shopScreen.currentShopScreen = 2;
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Shop_Backgrounds");
    }
    public void GoToBEPA()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        shopScreen.currentShopScreen = 5;
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_4 = null;
        val_4 = null;
        BEPACanvasController.PreviousScene = val_1.m_Handle.name;
        BEPACanvasController.GotoBattleAmplifierCanvas = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_GetBEPA");
    }
    public void powerUps()
    {
        null = null;
        shopScreen.currentShopScreen = 3;
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_PowerUps");
    }
    public void Characters()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        shopScreen.currentShopScreen = 0;
        GameAudio.PlayButtonSound();
        val_2 = null;
        val_2 = null;
        sceneCharacters.DirectCharacterLink = 42;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_Characters");
    }
    public void GetPearl()
    {
        null = null;
        shopScreen.currentShopScreen = 4;
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_GetPearl");
    }
    public void onPurchaseButtonClick(int index)
    {
        GameAudio.PlayButtonSound();
        GGPPurchasingManager.instance.BuyProductID(skuIndex:  index);
    }
    public void restorePurchaseButtonClicked()
    {
        GameAudio.PlayButtonSound();
        GGPPurchasingManager.instance.RestorePurchases();
    }
    public shopScreen()
    {
        this.previousScreen = 1;
    }
    private static shopScreen()
    {
        shopScreen.currentShopScreen = 1;
    }

}
