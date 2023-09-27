using UnityEngine;
public class ExpressPearlBuyButton : ShopBuyButton
{
    // Fields
    public UnityEngine.UI.Text pearlText;
    
    // Methods
    protected override void OnPurchaseSuccess(IAPItemIds id)
    {
        this.UpdateText();
    }
    private void UpdateText()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.Pearls;
        string val_2 = val_1.currentCryptoKey.ToString();
        GameAudio.PlayPurchaseSound();
    }
    public ExpressPearlBuyButton()
    {
    
    }

}
