using UnityEngine;
public class CustomItemVIPBuyButton : MonoBehaviour
{
    // Fields
    private ShopBuyButton buyButton;
    private UnityEngine.UI.Image vipIconImg;
    private UnityEngine.RectTransform priceRT;
    private UnityEngine.Vector2 savedPriceOffsetMin;
    private UnityEngine.Vector2 savedPriceOffsetMax;
    private float maxPriceFontSize;
    
    // Methods
    private void Awake()
    {
        if(0 == this.priceRT)
        {
                return;
        }
        
        UnityEngine.Vector2 val_2 = this.priceRT.offsetMin;
        this.savedPriceOffsetMin = val_2;
        mem[1152921528202504116] = val_2.y;
        UnityEngine.Vector2 val_3 = this.priceRT.offsetMax;
        this.savedPriceOffsetMax = val_3;
        mem[1152921528202504124] = val_3.y;
        TMPro.TextMeshProUGUI val_4 = this.priceRT.GetComponent<TMPro.TextMeshProUGUI>();
        if(0 == val_4)
        {
                return;
        }
        
        this.maxPriceFontSize = val_4.fontSizeMax;
    }
    public void SetupVIPPurchase(int level)
    {
        int val_7;
        var val_8;
        ShopBuyButton val_9;
        val_7 = level;
        CustomItemVIPBuyButton.<>c__DisplayClass7_0 val_1 = new CustomItemVIPBuyButton.<>c__DisplayClass7_0();
        if(val_1 != null)
        {
                .level = val_7;
            val_8 = this;
            val_9 = this.buyButton;
        }
        else
        {
                mem[16] = val_7;
            val_8 = this;
            val_9 = this.buyButton;
            val_7 = mem[16];
        }
        
        this.buyButton.itemId = VIP.GetIAPItemIdByVIPLevel(vipLevel:  val_7);
        val_9.ResetButton();
        this.buyButton.OnPurcahseSuccessEvent.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void CustomItemVIPBuyButton.<>c__DisplayClass7_0::<SetupVIPPurchase>b__0()));
        if(0 == this.priceRT)
        {
                return;
        }
        
        this.priceRT.offsetMin = new UnityEngine.Vector2() {x = this.savedPriceOffsetMin, y = V9.16B};
        this.priceRT.offsetMax = new UnityEngine.Vector2() {x = this.savedPriceOffsetMax, y = V9.16B};
        TMPro.TextMeshProUGUI val_5 = this.priceRT.GetComponent<TMPro.TextMeshProUGUI>();
        if(0 == val_5)
        {
                return;
        }
        
        val_5.fontSizeMax = this.maxPriceFontSize;
    }
    public void SetupLongIcon(int iconLevel)
    {
        this.vipIconImg.sprite = VIPCollection.GetLongIconSpriteFromLevel(level:  iconLevel);
        if(0 != this.vipIconImg.sprite)
        {
                UnityEngine.Color val_4 = UnityEngine.Color.white;
        }
        else
        {
                UnityEngine.Color val_5 = UnityEngine.Color.clear;
        }
        
        this.vipIconImg.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
    }
    public void SetupSquaredIcon(int iconLevel)
    {
        this.vipIconImg.sprite = VIPCollection.GetSquareIconSpriteFromLevel(level:  iconLevel);
        if(0 != this.vipIconImg.sprite)
        {
                UnityEngine.Color val_4 = UnityEngine.Color.white;
        }
        else
        {
                UnityEngine.Color val_5 = UnityEngine.Color.clear;
        }
        
        this.vipIconImg.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
    }
    public void SetButtonEnable(bool enable)
    {
        this.buyButton.gameObject.SetActive(value:  enable);
    }
    public CustomItemVIPBuyButton()
    {
        this.maxPriceFontSize = 32f;
    }

}
