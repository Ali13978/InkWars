using UnityEngine;
public class MusicShopBuyButton : ShopBuyButton
{
    // Fields
    public UnityEngine.UI.Image gotImage;
    
    // Methods
    private void Start()
    {
        var val_4;
        var val_5;
        if(==0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = null;
        val_5 = null;
        int val_3 = GameInfo.music.GetUniqueIdFromIapItemId(iapId:  static_value_03330000);
        val_3 = DataStructs.UserDataDictionary.Items.IsMusicUnlocked(id:  val_3);
        this.SetButtonUnlocked(isUnlocked:  val_3);
    }
    protected override void OnPurchaseSuccess(IAPItemIds id)
    {
        this.SetButtonUnlocked(isUnlocked:  true);
    }
    private void SetButtonUnlocked(bool isUnlocked)
    {
        this.gameObject.SetActive(value:  (~isUnlocked) & 1);
        if(0 == this.gotImage)
        {
                return;
        }
        
        this.gotImage.gameObject.SetActive(value:  isUnlocked);
    }
    public MusicShopBuyButton()
    {
    
    }

}
