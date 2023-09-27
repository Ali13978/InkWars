using UnityEngine;
public class VIPPanel : MonoBehaviour
{
    // Fields
    private bool <isVip>k__BackingField;
    private int <vipLevel>k__BackingField;
    private VIPMedal medalCtrl;
    private VIPItemGroup itemGroupCtrl;
    private VIPPromoTxt promoCtrl;
    private ShopBuyButton buyButton;
    private TMPro.TextMeshProUGUI purchasedInfoTxt;
    private UnityEngine.UI.Image purchasedEffect;
    public VIPPanelGroup parent;
    
    // Properties
    public bool isVip { get; set; }
    public int vipLevel { get; set; }
    public bool isPurchased { get; }
    
    // Methods
    public bool get_isVip()
    {
        return (bool)this.<isVip>k__BackingField;
    }
    protected void set_isVip(bool value)
    {
        this.<isVip>k__BackingField = value;
    }
    public int get_vipLevel()
    {
        return (int)this.<vipLevel>k__BackingField;
    }
    protected void set_vipLevel(int value)
    {
        this.<vipLevel>k__BackingField = value;
    }
    public bool get_isPurchased()
    {
        var val_2;
        if((this.<isVip>k__BackingField) != false)
        {
                return VIP.CheckIsPurchased(targetLevel:  this.<vipLevel>k__BackingField);
        }
        
        val_2 = null;
        val_2 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = DataStructs.UserDataDictionary.Items.StarterBundle;
        val_1.fakeValue = val_1.fakeValue & 4294967295;
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, fakeValueChanged = val_1.fakeValue, inited = val_1.fakeValue});
    }
    public void SetVip(int level, bool popular)
    {
        this.<isVip>k__BackingField = true;
        int val_1 = UnityEngine.Mathf.Clamp(value:  level, min:  1, max:  4);
        this.<vipLevel>k__BackingField = val_1;
        this.medalCtrl.SetVIPMedal(level:  val_1, popular:  false);
        this.itemGroupCtrl.SetVIPItems(level:  this.<vipLevel>k__BackingField, spaceForEmptyItems:  true);
        this.SetupVIPPurchase();
    }
    public void SetupVIPPurchase()
    {
        var val_27;
        string val_30;
        var val_31;
        string val_32;
        var val_33;
        this.buyButton.gameObject.SetActive(value:  (~this.isPurchased) & 1);
        val_27 = null;
        bool val_4 = VIP.ShouldShowUpgradePrice(targetLevel:  VIP>>0&0xFFFFFFFF);
        if((VIP.ShouldShowUpgradeBonus(targetLevel:  this.<vipLevel>k__BackingField)) != false)
        {
                string val_6 = LanguageManager.GetText(key:  "LK.VIP.PROMO.UPGRADE");
        }
        else
        {
                object[] val_7 = new object[1];
            val_7[0] = VIP.BasicDays;
        }
        
        val_30 = LanguageManager.GetTextFormat(key:  "LK.VIP.PROMO.NOT_PURCHASED", list:  val_7);
        val_31 = null;
        if(VIP.isInVipEndPromo == false)
        {
            goto label_15;
        }
        
        val_32 = "LK.VIP.PROMO.VIP_END_PROMO";
        goto label_16;
        label_15:
        val_33 = null;
        if(VIP.isInVipStartPromo == false)
        {
            goto label_19;
        }
        
        val_32 = "LK.VIP.PROMO.VIP_START_PROMO";
        label_16:
        val_30 = LanguageManager.GetText(key:  val_32);
        label_19:
        this.promoCtrl.SetPromoTxt(promoInfo:  val_30);
        this.promoCtrl.EnablePromoBonus(enabled:  VIP.ShouldShowUpgradeBonus(targetLevel:  this.<vipLevel>k__BackingField));
        object[] val_15 = new object[1];
        int val_16 = VIP.GetVipUpgradeBonusDays(targetLevel:  this.<vipLevel>k__BackingField);
        if(val_15 == null)
        {
            goto label_24;
        }
        
        if(val_16 != 0)
        {
            goto label_25;
        }
        
        goto label_28;
        label_24:
        if(val_16 == 0)
        {
            goto label_28;
        }
        
        label_25:
        label_28:
        val_15[0] = val_16;
        this.promoCtrl.SetPromoBonus(bonusInfo:  LanguageManager.GetTextFormat(key:  "LK.VIP.PROMO.FREE_DAY_BONUS", list:  val_15));
        this.promoCtrl.gameObject.SetActive(value:  (~this.isPurchased) & 1);
        this.purchasedInfoTxt.gameObject.SetActive(value:  this.isPurchased);
        object[] val_24 = new object[2];
        val_24[0] = "<br>";
        val_24[1] = VIP.GetLocalExpireDateString();
        this.purchasedInfoTxt.text = LanguageManager.GetTextFormat(key:  "LK.VIP.PURCHASED_INFO", list:  val_24);
        this.StartPurchasedEffect();
        this.SetupVIPBuyButton();
    }
    private void SetupVIPBuyButton()
    {
        this.buyButton.itemId = VIP.GetIAPItemIdByVIPLevel(vipLevel:  this.<vipLevel>k__BackingField);
        this.buyButton.ResetButton();
        this.buyButton.OnPurcahseSuccessEvent.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void VIPPanel::<SetupVIPBuyButton>b__19_0()));
    }
    public void SetBundle()
    {
        this.<isVip>k__BackingField = false;
        this.<vipLevel>k__BackingField = 0;
        this.medalCtrl.SetBundleMedal();
        this.itemGroupCtrl.SetBundleItems();
        this.buyButton.itemId = 29;
        this.buyButton.ResetButton();
        this.buyButton.OnPurcahseSuccessEvent.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this.parent, method:  public System.Void VIPPanelGroup::Refresh()));
        this.SetupBundlePurchase();
    }
    private void SetupBundlePurchase()
    {
        this.buyButton.gameObject.SetActive(value:  (~this.isPurchased) & 1);
        this.promoCtrl.gameObject.SetActive(value:  this.isPurchased);
        this.promoCtrl.EnablePromoBonus(enabled:  false);
        this.promoCtrl.SetPromoTxt(promoInfo:  LanguageManager.GetText(key:  "LK.VIP.PROMO.BUNDLE_PROMO"));
        this.purchasedInfoTxt.gameObject.SetActive(value:  this.isPurchased);
        this.purchasedInfoTxt.text = LanguageManager.GetText(key:  "LK.VIP.BUNDLE_PURCHASED_INFO");
        this.StartPurchasedEffect();
    }
    private void StartPurchasedEffect()
    {
        this.purchasedEffect.gameObject.SetActive(value:  this.isPurchased);
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.purchasedEffect.rectTransform, endValue:  1.02f, duration:  1f), ease:  1), loops:  0, loopType:  1);
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.purchasedEffect, endValue:  0.85f, duration:  0.01f);
        DG.Tweening.Sequence val_9 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_9, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.purchasedEffect, endValue:  1f, duration:  0.5f), ease:  30));
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_9, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.purchasedEffect, endValue:  0.85f, duration:  0.5f), ease:  27));
        DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_9, t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.purchasedEffect, endValue:  0.9f, duration:  0.5f), ease:  22), loops:  6, loopType:  1));
        object val_20 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  val_9, loops:  0, loopType:  0);
        float val_22 = (float)this.<vipLevel>k__BackingField;
        val_22 = val_22 * 0.5f;
        DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  val_9, delay:  val_22);
    }
    public VIPPanel()
    {
    
    }
    private void <SetupVIPBuyButton>b__19_0()
    {
        this.parent.Setup();
        VIPUnlockDialog.Show(vipLevel:  this.<vipLevel>k__BackingField);
    }

}
