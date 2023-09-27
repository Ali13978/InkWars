using UnityEngine;
public class noADS : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject buyButton;
    public UnityEngine.GameObject gotIt;
    
    // Methods
    private void Start()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = DataStructs.UserDataDictionary.Items.NoAds;
        val_1.fakeValue = val_1.fakeValue & 4294967295;
        val_1.fakeValue = (~(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, fakeValueChanged = val_1.fakeValue, inited = val_1.fakeValue}))) & 1;
        this.buyButton.SetActive(value:  val_1.fakeValue);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = DataStructs.UserDataDictionary.Items.NoAds;
        val_3.fakeValue = val_3.fakeValue & 4294967295;
        val_3.fakeValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        this.gotIt.SetActive(value:  val_3.fakeValue);
    }
    public void onPurchaseButtonClick(int index)
    {
        this.InvokeRepeating(methodName:  "CheckForBought", time:  0.1f, repeatRate:  0.1f);
        GGPPurchasingManager.instance.BuyProductID(skuIndex:  index);
    }
    private void CheckForBought()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = DataStructs.UserDataDictionary.Items.NoAds;
        val_1.fakeValue = val_1.fakeValue & 4294967295;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, fakeValueChanged = val_1.fakeValue, inited = val_1.fakeValue})) == false)
        {
                return;
        }
        
        this.buyButton.SetActive(value:  false);
        this.gotIt.SetActive(value:  true);
        this.CancelInvoke(methodName:  "CheckForBought");
    }
    public void backtoShop()
    {
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Shop_Scene");
    }
    public noADS()
    {
    
    }

}
