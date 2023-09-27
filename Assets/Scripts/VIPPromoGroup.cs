using UnityEngine;
public class VIPPromoGroup : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI titleTxt;
    private UnityEngine.GameObject bonusObject;
    private TMPro.TextMeshProUGUI bonusTxt;
    private ShopBuyButton buyButton;
    private VIPMedal medalCtrl;
    private UnityEngine.GameObject medalEffectObject;
    
    // Methods
    public void Setup(int vipLevel, string titleKey, bool showBonus, bool showMedalEffect)
    {
        this.SetupBuyButton(vipLevel:  vipLevel);
        object[] val_1 = new object[1];
        string val_2 = VIP.GetTitleString(vipLevel:  vipLevel);
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(val_2 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_2 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = val_2;
        this.titleTxt.text = LanguageManager.GetTextFormat(key:  titleKey, list:  val_1);
        bool val_4 = VIPCollection.IsPopular(level:  vipLevel);
        this.medalCtrl.SetVIPMedal(level:  vipLevel, popular:  false);
        this.medalCtrl.SetLocalPosY(y:  0f);
        this.EnableBonus(enableBonus:  showBonus, vipLevel:  vipLevel);
        if(0 == this.medalEffectObject)
        {
                return;
        }
        
        this.medalEffectObject.gameObject.SetActive(value:  showMedalEffect);
    }
    private void SetupBuyButton(int vipLevel)
    {
        int val_6;
        ShopBuyButton val_7;
        val_6 = vipLevel;
        VIPPromoGroup.<>c__DisplayClass7_0 val_1 = new VIPPromoGroup.<>c__DisplayClass7_0();
        if(val_1 != null)
        {
                .vipLevel = val_6;
            val_7 = this.buyButton;
        }
        else
        {
                mem[16] = val_6;
            val_7 = this.buyButton;
            val_6 = mem[16];
        }
        
        this.buyButton.itemId = VIP.GetFullPriceIapIdByVIPLevel(vipLevel:  val_6);
        val_7.ResetButton();
        this.buyButton.OnPurcahseSuccessEvent.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void VIPPromoGroup.<>c__DisplayClass7_0::<SetupBuyButton>b__0()));
        val_7.GetComponentInChildren<TMPro.TextMeshProUGUI>().fontSize = 30f;
        val_7.GetComponentInChildren<TMPro.TextMeshProUGUI>().fontSizeMax = 30f;
    }
    private void EnableBonus(bool enableBonus, int vipLevel)
    {
        int val_4;
        bool val_5;
        val_4 = vipLevel;
        val_5 = enableBonus;
        enableBonus = val_5;
        this.bonusObject.SetActive(value:  enableBonus);
        if(val_5 == false)
        {
                return;
        }
        
        val_5 = this.bonusTxt;
        object[] val_1 = new object[1];
        val_4 = VIP.GetVipUpgradeBonusDays(targetLevel:  val_4);
        val_1[0] = val_4;
        val_5.text = LanguageManager.GetTextFormat(key:  "LK.VIP.PROMO.FREE_DAY_BONUS", list:  val_1);
    }
    public VIPPromoGroup()
    {
    
    }

}
