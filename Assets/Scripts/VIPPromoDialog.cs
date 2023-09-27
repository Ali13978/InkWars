using UnityEngine;
public class VIPPromoDialog : DynamicUISingleton<VIPPromoDialog>
{
    // Fields
    private TMPro.TextMeshProUGUI titleTxt;
    private VIPPromoGroup currVip;
    private VIPPromoGroup promoVip;
    
    // Methods
    protected override void OnShow()
    {
        this.OnShow();
        this.Setup();
    }
    private void Setup()
    {
        var val_37;
        var val_39;
        var val_40;
        var val_41;
        object val_42;
        TMPro.TextMeshProUGUI val_43;
        string val_44;
        var val_45;
        var val_46;
        val_37 = null;
        val_37 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.VipLevel;
        this.currVip.Setup(vipLevel:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited}), titleKey:  "LK.VIP.PROMO.RENEW", showBonus:  false, showMedalEffect:  false);
        this.promoVip.gameObject.SetActive(value:  VIP.canUpgrade);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = DataStructs.UserDataDictionary.Items.VipLevel;
        int val_8 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited})) + 1;
        this.promoVip.Setup(vipLevel:  val_8, titleKey:  "LK.VIP.PROMO.UPGRADE_TO", showBonus:  VIP.ShouldShowUpgradeBonus(targetLevel:  val_8), showMedalEffect:  true);
        UnityEngine.Color val_11 = UnityEngine.Color.white;
        if(VIP.isVipActived == false)
        {
            goto label_14;
        }
        
        val_39 = null;
        if(VIP.VipDaysLeft < 1)
        {
            goto label_17;
        }
        
        object[] val_14 = new object[2];
        val_40 = null;
        val_40 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_15 = DataStructs.UserDataDictionary.Items.VipLevel;
        string val_17 = VIP.GetTitleString(vipLevel:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_15.currentCryptoKey, hiddenValue = val_15.hiddenValue, fakeValue = val_15.fakeValue, inited = val_15.inited}));
        if(val_14 == null)
        {
                val_41 = 0;
        }
        
        if(val_17 != null)
        {
                val_41 = val_17;
        }
        
        val_14[0] = val_17;
        val_42 = VIP.VipDaysLeft;
        val_14[1] = val_42;
        val_43 = LanguageManager.GetTextFormat(key:  "LK.VIP.PROMO.TITLE.NOTICE", list:  val_14);
        val_44 = val_43;
        goto label_33;
        label_14:
        val_43 = this.titleTxt;
        object[] val_20 = new object[1];
        val_45 = null;
        val_45 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_21 = DataStructs.UserDataDictionary.Items.VipLevel;
        val_42 = VIP.GetTitleString(vipLevel:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_21.currentCryptoKey, hiddenValue = val_21.hiddenValue, fakeValue = val_21.fakeValue, inited = val_21.inited}));
        val_20[0] = val_42;
        val_44 = LanguageManager.GetTextFormat(key:  "LK.VIP.PROMO.TITLE.EXPIRED", list:  val_20);
        label_33:
        val_43.text = val_44;
        return;
        label_17:
        object[] val_25 = new object[4];
        val_46 = null;
        val_46 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_26 = DataStructs.UserDataDictionary.Items.VipLevel;
        val_25[0] = VIP.GetTitleString(vipLevel:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_26.currentCryptoKey, hiddenValue = val_26.hiddenValue, fakeValue = val_26.fakeValue, inited = val_26.inited}));
        System.TimeSpan val_29 = VIP.timeLeft;
        val_25[1] = val_29._ticks.Hours;
        System.TimeSpan val_31 = VIP.timeLeft;
        val_25[2] = val_31._ticks.Minutes;
        System.TimeSpan val_33 = VIP.timeLeft;
        val_25[3] = val_33._ticks.Seconds;
        this.titleTxt.text = LanguageManager.GetTextFormat(key:  "LK.VIP.PROMO.TITLE.NOTICE.0DAY", list:  val_25);
        UnityEngine.Color val_36 = UnityEngine.Color.red;
        if(this.titleTxt != null)
        {
                return;
        }
    
    }
    public VIPPromoDialog()
    {
    
    }

}
