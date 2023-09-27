using UnityEngine;
public static class VIP
{
    // Fields
    private const string SHOULD_SHOW_VIP_EXIPIRED_NOTICE_KEY = "ShouldShowVIPExpiredNotice";
    public static bool couldShowVIPFinishNotice;
    private const string VIP_EXPIRE_CHECKER_KEY = "VIP_EXPIRE_CHECKER";
    
    // Properties
    public static int BasicDays { get; }
    public static int EndPromoDays { get; }
    public static int StartPromoDays { get; }
    public static int startPromoFreeDays { get; }
    public static int endPromoFreeDays { get; }
    public static int normalPromoFreeDays { get; }
    public static bool isVipActived { get; }
    public static int maxVipLevel { get; }
    public static bool canUpgrade { get; }
    public static int VipDaysLeft { get; }
    public static System.TimeSpan timeLeft { get; }
    public static string VipExpireTimeHHmm { get; }
    public static int VipDaysStart { get; }
    public static bool isInVipStartPromo { get; }
    public static bool isInVipEndPromo { get; }
    public static bool shouldShowVIPExpiredNotice { get; set; }
    public static bool isValidLevel { get; }
    
    // Methods
    public static int get_BasicDays()
    {
        if(VIPCollection.GetPromoData() != null)
        {
                return (int)val_1.normalDurationInDays;
        }
        
        return (int)val_1.normalDurationInDays;
    }
    public static int get_EndPromoDays()
    {
        if(VIPCollection.GetPromoData() != null)
        {
                return (int)val_1.eventDaysBeforeVIPFinish;
        }
        
        return (int)val_1.eventDaysBeforeVIPFinish;
    }
    public static int get_StartPromoDays()
    {
        if(VIPCollection.GetPromoData() != null)
        {
                return (int)val_1.eventDaysAfterVIPStart;
        }
        
        return (int)val_1.eventDaysAfterVIPStart;
    }
    public static int get_startPromoFreeDays()
    {
        if(VIPCollection.GetPromoData() != null)
        {
                return (int)val_1.freeDaysForAfterVIPStartPromo;
        }
        
        return (int)val_1.freeDaysForAfterVIPStartPromo;
    }
    public static int get_endPromoFreeDays()
    {
        if(VIPCollection.GetPromoData() != null)
        {
                return (int)val_1.freeDaysForBeforeVIPEndPromo;
        }
        
        return (int)val_1.freeDaysForBeforeVIPEndPromo;
    }
    public static int get_normalPromoFreeDays()
    {
        if(VIPCollection.GetPromoData() != null)
        {
                return (int)val_1.freeDaysForNormal;
        }
        
        return (int)val_1.freeDaysForNormal;
    }
    private static System.DateTime GetVIPUTCNow(bool defaultMinValue = True)
    {
        var val_1;
        var val_2;
        ulong val_3;
        var val_4;
        val_1 = null;
        if(defaultMinValue != false)
        {
                val_2 = null;
            val_3 = 1152921504618086416;
            return NFServerTime.GetUTC(defaultValue:  new System.DateTime() {dateData = val_3});
        }
        
        val_4 = null;
        val_3 = 1152921504618086424;
        return NFServerTime.GetUTC(defaultValue:  new System.DateTime() {dateData = val_3});
    }
    public static bool get_isVipActived()
    {
        var val_8;
        ulong val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_8 = null;
        val_8 = null;
        System.DateTime val_1 = DataStructs.UserDataDictionary.Items.VipExpireTimeUTC;
        val_9 = val_1.dateData;
        val_10 = null;
        val_10 = null;
        if(((System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_9}, t2:  new System.DateTime() {dateData = System.DateTime.MinValue})) & 2147483648) != 0)
        {
            goto label_12;
        }
        
        if(NFServerTime.isServerTimeActive == false)
        {
            goto label_9;
        }
        
        val_9 = 1152921505101680640;
        val_11 = null;
        if(VIP.isValidLevel == false)
        {
            goto label_12;
        }
        
        System.DateTime val_5 = VIP.GetVIPUTCNow(defaultMinValue:  true);
        val_12 = null;
        val_9 = val_5.dateData;
        val_12 = null;
        System.DateTime val_6 = DataStructs.UserDataDictionary.Items.VipExpireTimeUTC;
        val_13 = (System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_9}, t2:  new System.DateTime() {dateData = val_6.dateData})) >> 31;
        return (bool)val_13;
        label_9:
        UnityEngine.Debug.LogError(message:  "Returning VIP Disabled because server time is not active");
        label_12:
        val_13 = 0;
        return (bool)val_13;
    }
    public static int get_maxVipLevel()
    {
        return 4;
    }
    public static bool get_canUpgrade()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.VipLevel;
        return (bool)((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})) < 4) ? 1 : 0;
    }
    public static int get_VipDaysLeft()
    {
        int val_9;
        var val_10;
        var val_11;
        var val_12;
        val_10 = null;
        if(VIP.isVipActived != false)
        {
                val_11 = null;
            val_11 = null;
            System.DateTime val_2 = DataStructs.UserDataDictionary.Items.VipExpireTimeUTC;
            System.DateTime val_3 = val_2.dateData.ToLocalTime();
            System.DateTime val_4 = VIP.GetVIPUTCNow(defaultMinValue:  false);
            System.DateTime val_5 = val_4.dateData.ToLocalTime();
            System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_3.dateData}, d2:  new System.DateTime() {dateData = val_5.dateData});
            val_9 = val_6._ticks.Days;
            val_12 = 0;
            int val_8 = UnityEngine.Mathf.Max(a:  0, b:  val_9);
            return (int)val_12;
        }
        
        val_12 = 0;
        return (int)val_12;
    }
    public static System.TimeSpan get_timeLeft()
    {
        ulong val_7;
        var val_8;
        var val_9;
        var val_10;
        val_8 = null;
        if(VIP.isVipActived != false)
        {
                val_9 = null;
            val_9 = null;
            System.DateTime val_2 = DataStructs.UserDataDictionary.Items.VipExpireTimeUTC;
            System.DateTime val_3 = val_2.dateData.ToLocalTime();
            val_7 = val_3.dateData;
            System.DateTime val_4 = VIP.GetVIPUTCNow(defaultMinValue:  false);
            System.DateTime val_5 = val_4.dateData.ToLocalTime();
            System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_7}, d2:  new System.DateTime() {dateData = val_5.dateData});
            return (System.TimeSpan)val_10;
        }
        
        val_10 = 0;
        return (System.TimeSpan)val_10;
    }
    public static string get_VipExpireTimeHHmm()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = null;
        if(VIP.isVipActived != false)
        {
                val_5 = null;
            val_5 = null;
            System.DateTime val_2 = DataStructs.UserDataDictionary.Items.VipExpireTimeUTC;
            System.DateTime val_3 = val_2.dateData.ToLocalTime();
            return (string)val_6;
        }
        
        val_6 = "";
        return (string)val_6;
    }
    public static int get_VipDaysStart()
    {
        int val_9;
        var val_10;
        var val_11;
        var val_12;
        val_9 = 1152921505101680640;
        val_10 = null;
        if(VIP.isVipActived != false)
        {
                System.DateTime val_2 = VIP.GetVIPUTCNow(defaultMinValue:  true);
            System.DateTime val_3 = val_2.dateData.ToLocalTime();
            val_11 = null;
            val_11 = null;
            System.DateTime val_4 = DataStructs.UserDataDictionary.Items.VipStartTimeUTC;
            System.DateTime val_5 = val_4.dateData.ToLocalTime();
            System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_3.dateData}, d2:  new System.DateTime() {dateData = val_5.dateData});
            val_9 = val_6._ticks.Days;
            val_12 = 0;
            int val_8 = UnityEngine.Mathf.Max(a:  0, b:  val_9);
            return (int)val_12;
        }
        
        val_12 = 0;
        return (int)val_12;
    }
    public static bool get_isInVipStartPromo()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = null;
        if(VIP.isVipActived == false)
        {
            goto label_3;
        }
        
        val_7 = null;
        if(VIP.isInVipEndPromo == false)
        {
            goto label_6;
        }
        
        label_3:
        val_8 = 0;
        return (bool)(VIP.VipDaysStart <= VIP.StartPromoDays) ? 1 : 0;
        label_6:
        val_9 = null;
        return (bool)(VIP.VipDaysStart <= VIP.StartPromoDays) ? 1 : 0;
    }
    public static bool get_isInVipEndPromo()
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = null;
        if(VIP.isVipActived != false)
        {
                val_6 = null;
            var val_4 = (VIP.VipDaysLeft <= VIP.EndPromoDays) ? 1 : 0;
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    public static int GetVipUpgradeBonusDays(int targetLevel)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_13;
        val_8 = targetLevel;
        val_9 = null;
        if(VIP.isVipActived == false)
        {
            goto label_9;
        }
        
        val_10 = null;
        val_10 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Items.VipLevel;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited})) >= val_8)
        {
            goto label_9;
        }
        
        val_11 = null;
        if(VIP.isInVipEndPromo == false)
        {
            goto label_12;
        }
        
        val_8 = VIP.VipDaysLeft;
        val_13 = VIP.endPromoFreeDays + val_8;
        return (int)val_13;
        label_9:
        val_13 = 0;
        return (int)val_13;
        label_12:
        if(VIP.isInVipStartPromo == false)
        {
                return VIP.normalPromoFreeDays;
        }
        
        return VIP.startPromoFreeDays;
    }
    public static bool get_shouldShowVIPExpiredNotice()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = DataStructs.UserDataDictionary.GameSave.GetGameSaveFlags(key:  "ShouldShowVIPExpiredNotice", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
        val_3.fakeValue = val_3.fakeValue & 4294967295;
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
    }
    public static void set_shouldShowVIPExpiredNotice(bool value)
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
        DataStructs.UserDataDictionary.GameSave.SetGameSaveFlags(key:  "ShouldShowVIPExpiredNotice", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
    }
    public static bool CheckIsPurchased(int targetLevel)
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = null;
        if(VIP.isVipActived != false)
        {
                val_6 = null;
            val_6 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Items.VipLevel;
            var val_4 = ((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited})) >= targetLevel) ? 1 : 0;
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    public static bool ShouldShowUpgradePrice(int targetLevel)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        if(VIP.isVipActived != false)
        {
                val_4 = null;
            val_5 = (~VIP.isInVipEndPromo) & 1;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    public static bool ShouldShowUpgradeBonus(int targetLevel)
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_6 = null;
        if(VIP.isVipActived == false)
        {
            goto label_15;
        }
        
        val_7 = null;
        if(VIP.isVipActived == false)
        {
            goto label_15;
        }
        
        val_8 = null;
        if(VIP.isInVipEndPromo == true)
        {
            goto label_9;
        }
        
        val_9 = null;
        if(VIP.isInVipStartPromo == false)
        {
            goto label_15;
        }
        
        label_9:
        if((VIP.GetVipUpgradeBonusDays(targetLevel:  targetLevel)) > 0)
        {
                val_10 = 1;
            return (bool)val_10;
        }
        
        label_15:
        val_10 = 0;
        return (bool)val_10;
    }
    public static bool IsBattleGridUnlockedByVip(int gridId)
    {
        var val_4;
        var val_5;
        val_4 = null;
        if(VIP.isVipActived == false)
        {
                return false;
        }
        
        val_5 = null;
        val_5 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Items.VipLevel;
        return VIP.CheckBattleGridCouldBeUnlockedByVip(gridId:  gridId, vipLevel:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited}));
    }
    public static bool CheckBattleGridCouldBeUnlockedByVip(int gridId, int vipLevel)
    {
        var val_5;
        if((BattleGridCollection.instance.GetBattleGridByID(_id:  gridId, returnNullForInvalidIds:  true)) == null)
        {
                return (bool)val_5;
        }
        
        if((VIPCollection.GetVipDataFromLevel(level:  vipLevel)) == null)
        {
                return (bool)val_5;
        }
        
        if(val_3.unlockCustomizableItems != false)
        {
                var val_4 = (val_2.type <= val_3.maxUnlockedItemTier) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    public static bool IsSwitcherUnlockedByVip(int switcherId)
    {
        var val_4;
        var val_5;
        val_4 = null;
        if(VIP.isVipActived == false)
        {
                return false;
        }
        
        val_5 = null;
        val_5 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Items.VipLevel;
        return VIP.CheckSwitcherCouldBeUnlockedByVip(switcherId:  switcherId, vipLevel:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited}));
    }
    public static bool CheckSwitcherCouldBeUnlockedByVip(int switcherId, int vipLevel)
    {
        var val_5;
        if((SwitcherCollection.instance.GetSwitcherByID(_id:  switcherId, returnNullForInvalidIds:  true)) == null)
        {
                return (bool)val_5;
        }
        
        if((VIPCollection.GetVipDataFromLevel(level:  vipLevel)) == null)
        {
                return (bool)val_5;
        }
        
        if(val_3.unlockCustomizableItems != false)
        {
                var val_4 = (val_2.type <= val_3.maxUnlockedItemTier) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    public static bool IsBubbleSetUnlockedByVip(InkWars.Model.BubbleFamily bubbleId)
    {
        var val_4;
        var val_5;
        val_4 = null;
        if(VIP.isVipActived == false)
        {
                return false;
        }
        
        val_5 = null;
        val_5 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Items.VipLevel;
        return VIP.CheckBubbleSetCouldBeUnlockedByVip(bubbleId:  bubbleId, vipLevel:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited}));
    }
    public static bool CheckBubbleSetCouldBeUnlockedByVip(InkWars.Model.BubbleFamily bubbleId, int vipLevel)
    {
        var val_5;
        if((BubblesCollection.instance.getBubblesByFamily(family:  bubbleId, returnNullForInvalidIds:  true)) == null)
        {
                return (bool)val_5;
        }
        
        if((VIPCollection.GetVipDataFromLevel(level:  vipLevel)) == null)
        {
                return (bool)val_5;
        }
        
        if(val_3.unlockCustomizableItems != false)
        {
                var val_4 = (val_2.tier <= val_3.maxUnlockedItemTier) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    public static bool IsCharacterUnlockedByVip(CharacterNameID cid)
    {
        var val_4;
        var val_5;
        val_4 = null;
        if(cid == 42)
        {
                return false;
        }
        
        if(VIP.isVipActived == false)
        {
                return false;
        }
        
        val_5 = null;
        val_5 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Items.VipLevel;
        return VIP.CheckCharacterCouldBeUnlockedByVip(cid:  cid, vipLevel:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited}), includeDefault:  false);
    }
    public static bool CheckCharacterCouldBeUnlockedByVip(CharacterNameID cid, int vipLevel, bool includeDefault = False)
    {
        bool val_7;
        if(0 == (CharacterDataManager.Get(id:  cid)))
        {
                return false;
        }
        
        if((CharacterHelper.IsHidden(cid:  cid)) != false)
        {
                return false;
        }
        
        var val_4 = (val_1.unlockType != 1) ? 1 : 0;
        if(val_1.unlockType == 0)
        {
                return false;
        }
        
        val_4 = val_4 | includeDefault;
        if(val_4 == false)
        {
                return false;
        }
        
        if((VIPCollection.GetVipDataFromLevel(level:  vipLevel)) == null)
        {
                return false;
        }
        
        if(val_1.realPersonCharacter != false)
        {
                val_7 = val_5.unlockCelebs;
        }
        else
        {
                val_7 = val_5.unlockCharacters;
        }
        
        var val_6 = (val_7 == true) ? 1 : 0;
        return false;
    }
    public static IAPItemIds GetIAPItemIdByVIPLevel(int vipLevel)
    {
        int val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_9 = vipLevel;
        IAPItemIds val_6 = 0;
        val_10 = null;
        if((VIP.ShouldShowUpgradePrice(targetLevel:  VIP>>0&0xFFFFFFFF)) == false)
        {
            goto label_3;
        }
        
        val_11 = null;
        val_11 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Items.VipLevel;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited})) >= val_9)
        {
            goto label_9;
        }
        
        val_12 = null;
        val_12 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = DataStructs.UserDataDictionary.Items.VipLevel;
        val_9 = System.String.Format(format:  "VIP_{0}_TO_{1}", arg0:  val_4, arg1:  val_9);
        bool val_7 = System.Enum.TryParse<IAPItemIds>(value:  val_9, result: out  val_6);
        val_13 = val_6;
        return (IAPItemIds)val_13;
        label_3:
        IAPItemIds val_8 = VIP.GetFullPriceIapIdByVIPLevel(vipLevel:  val_9);
        return (IAPItemIds)val_13;
        label_9:
        val_13 = 0;
        return (IAPItemIds)val_13;
    }
    public static IAPItemIds GetFullPriceIapIdByVIPLevel(int vipLevel)
    {
        IAPItemIds val_2 = 0;
        bool val_3 = System.Enum.TryParse<IAPItemIds>(value:  System.String.Format(format:  "VIP_{0}", arg0:  vipLevel), result: out  val_2);
        return val_2;
    }
    public static int GetVipLevelFromIAPIds(IAPItemIds id)
    {
        if((id - 159) > 9)
        {
                return 0;
        }
        
        return (int)40825632 + ((id - 159)) << 2;
    }
    public static void BuyVIPFull(IAPItemIds vipIAPIds)
    {
        var val_5;
        var val_6;
        if((vipIAPIds - 159) <= 9)
        {
                val_5 = mem[40825632 + ((vipIAPIds - 159)) << 2];
            val_5 = 40825632 + ((vipIAPIds - 159)) << 2;
        }
        else
        {
                val_5 = 0;
        }
        
        val_6 = null;
        val_6 = null;
        DataStructs.UserDataDictionary.Items.PurchaseVip(level:  0, durationInDays:  (VIP.GetVipUpgradeBonusDays(targetLevel:  0)) + VIP.BasicDays);
    }
    public static void BuyVIPUpgrade(IAPItemIds vipIAPIds)
    {
        var val_3;
        var val_4;
        if((vipIAPIds - 159) <= 9)
        {
                val_3 = mem[40825632 + ((vipIAPIds - 159)) << 2];
            val_3 = 40825632 + ((vipIAPIds - 159)) << 2;
        }
        else
        {
                val_3 = 0;
        }
        
        val_4 = null;
        val_4 = null;
        DataStructs.UserDataDictionary.Items.PurchaseVip(level:  0, durationInDays:  VIP.GetVipUpgradeBonusDays(targetLevel:  0));
    }
    public static string GetLocalExpireDateString()
    {
        null = null;
        System.DateTime val_1 = DataStructs.UserDataDictionary.Items.VipExpireTimeUTC;
        System.DateTime val_2 = val_1.dateData.ToLocalTime();
        return -1960139992;
    }
    public static int GetUnlockedCharacterCountByLevel(int targetLevel, bool isCeleb, bool includeDefaults = False)
    {
        var val_13;
        var val_15;
        var val_17;
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        val_13 = 0;
        goto label_16;
        label_25:
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_15 = null;
        val_3.Current.Add(driver:  public System.Object System.Collections.IEnumerator::get_Current(), rectTransform:  includeDefaults, drivenProperties:  null);
        if((VIP.CheckCharacterCouldBeUnlockedByVip(cid:  1152921504628039680, vipLevel:  targetLevel, includeDefault:  includeDefaults)) != false)
        {
                val_15 = CharacterDataManager.Get(id:  1152921504628039680);
            var val_9 = (val_8.realPersonCharacter == true) ? 1 : 0;
            val_9 = val_9 ^ isCeleb;
            val_9 = val_9 ^ 1;
            val_9 = ((null != 42) ? 1 : 0) & val_9;
            val_13 = val_13 + val_9;
        }
        
        label_16:
        var val_16 = 0;
        val_16 = val_16 + 1;
        if(val_3.MoveNext() == true)
        {
            goto label_25;
        }
        
        val_17 = 0;
        if(val_3 != null)
        {
                var val_17 = 0;
            val_17 = val_17 + 1;
            val_3.Dispose();
        }
        
        if( == false)
        {
                return (int)val_13;
        }
        
        return (int)val_13;
    }
    public static int GetUnlockedItemCountByLevel(int targetLevel, bool includeDefaults = False)
    {
        var val_7 = 0;
        InkWars.Model.BubbleFamily val_8 = 0;
        do
        {
            val_7 = val_7 + (VIP.CheckBattleGridCouldBeUnlockedByVip(gridId:  0, vipLevel:  targetLevel));
            val_7 = val_7 + (VIP.CheckSwitcherCouldBeUnlockedByVip(switcherId:  0, vipLevel:  targetLevel));
            bool val_5 = VIP.CheckBubbleSetCouldBeUnlockedByVip(bubbleId:  val_8, vipLevel:  targetLevel);
            bool val_6 = val_5;
            val_8 = val_8 + 1;
            val_7 = val_7 + val_6;
        }
        while(val_8 != 100);
        
        val_6 = val_7 - 5;
        val_5 = (includeDefaults != true) ? (val_7) : (val_6);
        return (int)val_5;
    }
    public static string GetTitleString(int vipLevel)
    {
        return (string)LanguageManager.GetText(key:  "LK.VIP.TITLE." + vipLevel.ToString());
    }
    public static void ApplyFreeVIPForNewUser()
    {
        var val_9;
        string val_10;
        byte val_11;
        var val_12;
        var val_13;
        val_9 = null;
        val_10 = "FreeVIPForNewUser";
        val_9 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
        val_11 = val_1.currentCryptoKey;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = DataStructs.UserDataDictionary.GameSave.GetGameSaveFlags(key:  val_10, defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_11, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
        val_3.fakeValue = val_3.fakeValue & 4294967295;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue})) == true)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        VIPPromo val_5 = VIPCollection.GetPromoData();
        VIPPromo val_6 = VIPCollection.GetPromoData();
        DataStructs.UserDataDictionary.Items.PurchaseVip(level:  val_5.levelForNewUserGiftVIP, durationInDays:  val_6.freeDaysForNewUserGiftVIP);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
        val_11 = val_7.currentCryptoKey;
        DataStructs.UserDataDictionary.GameSave.SetGameSaveFlags(key:  val_10, aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_11, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue & 4294967295, fakeValueChanged = val_7.fakeValue & 4294967295, inited = val_7.fakeValue & 4294967295});
        DynamicUISingleton<VIPBonusPanel>.Show();
        val_10 = 1152921505101680640;
        val_13 = null;
        val_13 = null;
        VIP.VIP_EXPIRE_CHECKER_KEY = 0;
    }
    public static bool get_isValidLevel()
    {
        var val_6;
        int val_7;
        var val_8;
        var val_9;
        val_6 = null;
        val_6 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.VipLevel;
        val_7 = val_1.currentCryptoKey;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})) >= 1)
        {
                val_8 = null;
            val_8 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Items.VipLevel;
            val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited});
            var val_5 = (val_7 < 5) ? 1 : 0;
            return (bool)val_9;
        }
        
        val_9 = 0;
        return (bool)val_9;
    }
    public static void Init()
    {
        var val_3 = null;
        VIP.VIP_EXPIRE_CHECKER_KEY = VIP.isVipActived;
    }
    public static void DeInit()
    {
        null = null;
        VIP.VIP_EXPIRE_CHECKER_KEY = 0;
        MainThreadDispatcher.StopRepeat(key:  "VIP_EXPIRE_CHECKER");
    }
    public static void NoticeVIPExpire()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        val_1.AddRange(collection:  new int[6] {0, 1, 2, 3, 5, 7});
        val_11 = null;
        if(VIP.isVipActived == false)
        {
            goto label_14;
        }
        
        val_12 = null;
        if(VIP.isValidLevel == false)
        {
            goto label_14;
        }
        
        val_13 = null;
        val_13 = null;
        if((VIP.VIP_EXPIRE_CHECKER_KEY == null) || ((val_1.Contains(item:  VIP.VipDaysLeft)) == false))
        {
            goto label_14;
        }
        
        DynamicUISingleton<VIPPromoDialog>.Show();
        val_14 = null;
        val_14 = null;
        VIP.VIP_EXPIRE_CHECKER_KEY = 0;
        goto label_25;
        label_14:
        val_15 = null;
        if(VIP.shouldShowVIPExpiredNotice != false)
        {
                val_16 = null;
            if(VIP.isVipActived != true)
        {
                VIP.NoticeVIPAlreadyExpired();
        }
        
        }
        
        label_25:
        MainThreadDispatcher.Init();
        MainThreadDispatcher.StopRepeat(key:  "VIP_EXPIRE_CHECKER");
        val_17 = null;
        if(VIP.isVipActived == false)
        {
                return;
        }
        
        MainThreadDispatcher.InvokeRepeat(key:  "VIP_EXPIRE_CHECKER", action:  new System.Action(object:  0, method:  public static System.Void VIP::RunTimeNoticeVIPExpire()), interval:  0f, delay:  1f);
    }
    private static void NoticeVIPAlreadyExpired()
    {
        var val_4;
        var val_5;
        val_4 = null;
        if(VIP.shouldShowVIPExpiredNotice == false)
        {
                return;
        }
        
        val_5 = null;
        if(VIP.isVipActived == true)
        {
                return;
        }
        
        if(NFServerTime.isServerTimeActive == false)
        {
                return;
        }
        
        DynamicUISingleton<VIPPromoDialog>.Show();
        VIP.shouldShowVIPExpiredNotice = false;
        MainThreadDispatcher.StopRepeat(key:  "VIP_EXPIRE_CHECKER");
        VIP.ResetCustomItemsToDefault();
    }
    private static void ResetCustomItemsToDefault()
    {
        null = null;
        DataStructs.UserDataDictionary.Items.TrySetToDefaultBattleBubble();
        DataStructs.UserDataDictionary.Items.TrySetToDefaultBattleGrid();
        DataStructs.UserDataDictionary.Items.TrySetToDefaultSwitcher();
    }
    public static void RunTimeNoticeVIPExpire()
    {
        UnityEngine.Object val_12;
        if(NFServerTime.isServerTimeActive == false)
        {
                return;
        }
        
        val_12 = 1152921504864088064;
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_2.m_Handle.name, b:  "MVC_GameScene")) == true)
        {
                return;
        }
        
        UnityEngine.SceneManagement.Scene val_5 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_5.m_Handle.name, b:  "NetworkLobbyNew")) != false)
        {
                val_12 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            if(0 == val_12)
        {
                return;
        }
        
            val_12 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            if(val_12.State != 0)
        {
                return;
        }
        
        }
        
        VIP.NoticeVIPAlreadyExpired();
    }
    private static VIP()
    {
        VIP.VIP_EXPIRE_CHECKER_KEY = 1;
    }

}
