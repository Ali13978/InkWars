using UnityEngine;
public class PublicWagerData
{
    // Fields
    private static int <selectedWagerLevel>k__BackingField;
    private static System.Collections.Generic.List<WagerData> m_wagerDataList;
    private static decimal <lastWager>k__BackingField;
    private static decimal <lastPrize>k__BackingField;
    
    // Properties
    public static int selectedWagerLevel { get; set; }
    public static decimal lastWager { get; set; }
    public static decimal lastPrize { get; set; }
    
    // Methods
    public static int get_selectedWagerLevel()
    {
        return (int)PublicWagerData.<selectedWagerLevel>k__BackingField;
    }
    public static void set_selectedWagerLevel(int value)
    {
        PublicWagerData.<selectedWagerLevel>k__BackingField = value;
    }
    public static decimal get_lastWager()
    {
        return new System.Decimal() {flags = PublicWagerData.<lastWager>k__BackingField, hi = PublicWagerData.<lastWager>k__BackingField, lo = PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_18>>0&0xFFFFFFFF, mid = PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_18>>32&0x0};
    }
    private static void set_lastWager(decimal value)
    {
        PublicWagerData.<lastWager>k__BackingField = value.flags;
        PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_14 = value.hi;
        PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_18 = value.lo;
        PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_1C = value.mid;
    }
    public static decimal get_lastPrize()
    {
        return new System.Decimal() {flags = PublicWagerData.<lastPrize>k__BackingField, hi = PublicWagerData.<lastPrize>k__BackingField, lo = PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_28>>0&0xFFFFFFFF, mid = PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_28>>32&0x0};
    }
    private static void set_lastPrize(decimal value)
    {
        PublicWagerData.<lastPrize>k__BackingField = value.flags;
        PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_24 = value.hi;
        PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_28 = value.lo;
        PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_2C = value.mid;
    }
    public static WagerData GetSelectedWagerData()
    {
        if(PublicWagerData.m_wagerDataList == null)
        {
                PublicWagerData.InitPearShellCurrencyMode();
        }
        
        WagerData val_1 = PublicWagerData.GetDataByLevel(level:  PublicWagerData.<selectedWagerLevel>k__BackingField);
        if(val_1 != null)
        {
                return val_1;
        }
        
        object[] val_2 = new object[1];
        1152921505121169408 = PublicWagerData.<selectedWagerLevel>k__BackingField;
        val_2[0] = 1152921505121169408;
        UnityEngine.Debug.LogErrorFormat(format:  "Cannot get selected wager data by id {0}", args:  val_2);
        return val_1;
    }
    public int GetWagerCount()
    {
        if(PublicWagerData.m_wagerDataList == null)
        {
                return (int)PublicWagerData.m_wagerDataList;
        }
        
        return PublicWagerData.m_wagerDataList.Count;
    }
    public static void RemoveWagerFromLocalUser()
    {
        System.Object[] val_20;
        object val_21;
        var val_22;
        object val_23;
        var val_24;
        int val_25;
        var val_26;
        var val_27;
        val_20 = 1152921505064992768;
        val_21 = PublicWagerData.GetSelectedWagerData();
        val_22 = null;
        val_22 = null;
        val_23 = "Character_GlobalInfo.isCryptoMMOCMode : "("Character_GlobalInfo.isCryptoMMOCMode : ") + ToString();
        UnityEngine.Debug.Log(message:  val_23);
        if(Character_GlobalInfo.isCryptoMMOCMode == false)
        {
            goto label_5;
        }
        
        if(val_21 != null)
        {
            goto label_6;
        }
        
        return;
        label_5:
        val_23 = 1152921505119145984;
        val_24 = null;
        val_24 = null;
        if(val_21 == null)
        {
                return;
        }
        
        if(PostMatchCanvas.IsPublicMatch == false)
        {
                return;
        }
        
        label_6:
        float val_8 = UnityEngine.Mathf.Max(a:  0f, b:  1f - (PlayerBuff.GetLocalPlayerBuff().GetBuffValuePercent01(aNewType:  13)));
        val_8 = (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_1.m_wager, hi = val_1.m_wager, lo = 1152921505119145984})) * val_8;
        int val_9 = UnityEngine.Mathf.RoundToInt(f:  val_8);
        decimal val_10 = System.Decimal.op_Implicit(value:  val_9);
        PublicWagerData.<lastWager>k__BackingField = val_10.flags;
        PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_14 = val_10.hi;
        PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_18 = val_10.lo;
        PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_1C = val_10.mid;
        if(val_1.m_currency == 2)
        {
            goto label_20;
        }
        
        if(val_1.m_currency == 1)
        {
            goto label_21;
        }
        
        if(val_1.m_currency != 0)
        {
            goto label_30;
        }
        
        val_26 = null;
        val_26 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_11 = DataStructs.UserDataDictionary.Items.Pearls;
        int val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_11.currentCryptoKey, hiddenValue = val_11.hiddenValue, fakeValue = val_11.fakeValue, inited = val_11.inited});
        val_12 = val_12 - val_9;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_13 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_12);
        val_25 = val_13.fakeValue;
        DataStructs.UserDataDictionary.Items.Pearls = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_13.currentCryptoKey, hiddenValue = val_13.hiddenValue, fakeValue = val_25, inited = val_13.inited};
        goto label_30;
        label_20:
        PublicWagerData.<lastWager>k__BackingField = val_1.m_wager;
        PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_18 = ???;
        goto label_30;
        label_21:
        val_27 = null;
        val_27 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_14 = DataStructs.UserDataDictionary.Items.Shells;
        int val_15 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_14.currentCryptoKey, hiddenValue = val_14.hiddenValue, fakeValue = val_14.fakeValue, inited = val_14.inited});
        val_15 = val_15 - val_9;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_16 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_15);
        val_25 = val_16.fakeValue;
        DataStructs.UserDataDictionary.Items.Shells = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_16.currentCryptoKey, hiddenValue = val_16.hiddenValue, fakeValue = val_25, inited = val_16.inited};
        label_30:
        object[] val_17 = new object[4];
        val_20 = val_17;
        val_20[0] = "Remove wager: ";
        val_20[1] = val_9;
        val_20[2] = " ";
        CurrencyData val_18 = CurrencyCollection.Get(cur:  val_1.m_currency);
        val_20[3] = val_18.pluralName;
        val_21 = +val_17;
        UnityEngine.Debug.Log(message:  val_21);
    }
    public static void ProtectWagerWhenLose()
    {
        var val_15;
        var val_16;
        if(PublicWagerData.GetSelectedWagerData() == null)
        {
                return;
        }
        
        float val_4 = UnityEngine.Random.value;
        if((PlayerBuff.GetLocalPlayerBuff().GetBuffValuePercent01(aNewType:  15)) < 0)
        {
                return;
        }
        
        if(val_1.m_currency != 1)
        {
                if(val_1.m_currency != 0)
        {
                return;
        }
        
            val_15 = null;
            val_15 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Items.Pearls;
            decimal val_7 = PublicWagerData.lastWager;
            int val_8 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_7.lo, mid = val_7.mid});
            val_8 = val_8 + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited}));
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_8);
            DataStructs.UserDataDictionary.Items.Pearls = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_9.currentCryptoKey, hiddenValue = val_9.hiddenValue, fakeValue = val_9.fakeValue, inited = val_9.inited};
            return;
        }
        
        val_16 = null;
        val_16 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_10 = DataStructs.UserDataDictionary.Items.Shells;
        decimal val_12 = PublicWagerData.lastWager;
        int val_13 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid});
        val_13 = val_13 + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_10.currentCryptoKey, hiddenValue = val_10.hiddenValue, fakeValue = val_10.fakeValue, inited = val_10.inited}));
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_14 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_13);
        DataStructs.UserDataDictionary.Items.Shells = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_14.currentCryptoKey, hiddenValue = val_14.hiddenValue, fakeValue = val_14.fakeValue, inited = val_14.inited};
    }
    public static void AddWinPriceToLocalUser()
    {
        object val_22;
        int val_24;
        int val_25;
        decimal val_26;
        var val_27;
        var val_28;
        var val_29;
        val_22 = PublicWagerData.GetSelectedWagerData();
        if(val_22 == null)
        {
                return;
        }
        
        decimal val_4 = System.Decimal.op_Explicit(value:  PlayerBuff.GetLocalPlayerBuff().GetBuffValuePercent01(aNewType:  12));
        decimal val_5 = System.Decimal.op_Addition(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid});
        decimal val_6 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_1.m_price, hi = val_1.m_price, lo = X21, mid = X21}, d2:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid});
        val_24 = val_6.flags;
        val_25 = val_6.lo;
        if((PlayerBuff.GetLocalPlayerBuff().GetBuffValuePercent01(aNewType:  14)) >= UnityEngine.Random.value)
        {
                decimal val_10 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_24, hi = val_6.hi, lo = val_25, mid = val_6.mid}, d2:  new System.Decimal());
            val_24 = val_10.flags;
            val_25 = val_10.lo;
        }
        
        val_26 = null;
        PublicWagerData.<lastPrize>k__BackingField = val_24;
        PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_24 = val_10.hi;
        PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_28 = val_25;
        PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_2C = val_10.mid;
        if(val_1.m_currency == 2)
        {
            goto label_12;
        }
        
        if(val_1.m_currency == 1)
        {
            goto label_13;
        }
        
        if(val_1.m_currency != 0)
        {
            goto label_24;
        }
        
        val_27 = null;
        val_27 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_11 = DataStructs.UserDataDictionary.Items.Pearls;
        val_28 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_11.currentCryptoKey, hiddenValue = val_11.hiddenValue, fakeValue = val_11.fakeValue, inited = val_11.inited});
        int val_13 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_24, hi = val_10.hi, lo = val_25, mid = val_10.mid});
        val_13 = val_13 + val_28;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_14 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_13);
        DataStructs.UserDataDictionary.Items.Pearls = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_14.currentCryptoKey, hiddenValue = val_14.hiddenValue, fakeValue = val_14.fakeValue, inited = val_14.inited};
        goto label_24;
        label_12:
        val_26 = val_1.m_price;
        PublicWagerData.<lastPrize>k__BackingField = val_26;
        PublicWagerData.<selectedWagerLevel>k__BackingField.__il2cppRuntimeField_28 = ???;
        goto label_24;
        label_13:
        val_29 = null;
        val_29 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_15 = DataStructs.UserDataDictionary.Items.Shells;
        val_28 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_15.currentCryptoKey, hiddenValue = val_15.hiddenValue, fakeValue = val_15.fakeValue, inited = val_15.inited});
        int val_17 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_24, hi = val_10.hi, lo = val_25, mid = val_10.mid});
        val_17 = val_17 + val_28;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_18 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_17);
        DataStructs.UserDataDictionary.Items.Shells = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_18.currentCryptoKey, hiddenValue = val_18.hiddenValue, fakeValue = val_18.fakeValue, inited = val_18.inited};
        label_24:
        object[] val_19 = new object[4];
        val_19[0] = "Add win price: ";
        val_19[1] = val_1.m_price;
        val_19[2] = " ";
        CurrencyData val_20 = CurrencyCollection.Get(cur:  val_1.m_currency);
        val_19[3] = val_20.pluralName;
        val_22 = +val_19;
        UnityEngine.Debug.Log(message:  val_22);
    }
    private static void InitCryptoCurrencyMode()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        System.Collections.Generic.List<WagerData> val_1 = new System.Collections.Generic.List<WagerData>();
        PublicWagerData.m_wagerDataList = val_1;
        WagerData val_2 = new WagerData();
        if(val_2 != null)
        {
                .m_button = 0;
        }
        else
        {
                mem[16] = 0;
        }
        
        .m_Level = 1;
        val_7 = 0;
        if(val_2 == null)
        {
                val_7 = 1;
        }
        
        .m_wager = 0m;
        mem[1152921528706321992] = 0;
        .m_minWins = 0;
        .m_currency = 2;
        .m_price = 0m;
        mem[1152921528706322008] = 0;
        val_1.Add(item:  val_2);
        WagerData val_3 = new WagerData();
        if(val_3 != null)
        {
                .m_button = 0;
        }
        else
        {
                mem[16] = 0;
        }
        
        .m_Level = 2;
        if(val_3 != null)
        {
                val_8 = 0;
        }
        else
        {
                val_8 = 1;
        }
        
        .m_wager = 0m;
        mem[1152921528706326088] = 0;
        .m_minWins = 0;
        .m_currency = 2;
        .m_price = 0m;
        mem[1152921528706326104] = 0;
        val_1.Add(item:  val_3);
        WagerData val_4 = new WagerData();
        if(val_4 != null)
        {
                .m_button = 0;
        }
        else
        {
                mem[16] = 0;
        }
        
        .m_Level = 3;
        if(val_4 != null)
        {
                val_9 = 0;
        }
        else
        {
                val_9 = 1;
        }
        
        .m_wager = 0m;
        mem[1152921528706330184] = 0;
        .m_minWins = 0;
        .m_currency = 2;
        .m_price = 0m;
        mem[1152921528706330200] = 0;
        val_1.Add(item:  val_4);
        WagerData val_5 = new WagerData();
        if(val_5 != null)
        {
                .m_button = 0;
        }
        else
        {
                mem[16] = 0;
        }
        
        .m_Level = 4;
        if(val_5 != null)
        {
                val_10 = 0;
        }
        else
        {
                val_10 = 1;
        }
        
        .m_wager = 0m;
        mem[1152921528706334280] = 0;
        .m_minWins = 0;
        .m_currency = 2;
        .m_price = 0m;
        mem[1152921528706334296] = 0;
        val_1.Add(item:  val_5);
        WagerData val_6 = new WagerData();
        if(val_6 != null)
        {
                .m_button = 0;
        }
        else
        {
                mem[16] = 0;
        }
        
        .m_Level = 5;
        if(val_6 != null)
        {
                val_11 = 0;
        }
        else
        {
                val_11 = 1;
        }
        
        .m_wager = 0m;
        mem[1152921528706338376] = 0;
        .m_minWins = 0;
        .m_currency = 2;
        .m_price = 0m;
        mem[1152921528706338392] = 0;
        val_1.Add(item:  val_6);
    }
    private static void InitPearShellCurrencyMode()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        System.Collections.Generic.List<WagerData> val_1 = new System.Collections.Generic.List<WagerData>();
        PublicWagerData.m_wagerDataList = val_1;
        WagerData val_2 = new WagerData();
        if(val_2 != null)
        {
                .m_button = 0;
            .m_Level = 1;
            .m_wager = 0m;
            mem[1152921528706503624] = 0;
        }
        else
        {
                mem[16] = 0;
            mem[24] = 1;
            mem[40] = 0;
            mem[32] = 0;
        }
        
        .m_minWins = 0;
        val_12 = 0;
        if(val_2 == null)
        {
                val_12 = 1;
        }
        
        .m_price = 0m;
        mem[1152921528706503640] = 0;
        .m_currency = 0;
        val_1.Add(item:  val_2);
        WagerData val_3 = new WagerData();
        if(val_3 != null)
        {
                .m_button = 0;
        }
        else
        {
                mem[16] = 0;
        }
        
        .m_Level = 2;
        if(val_3 != null)
        {
                val_13 = 0;
        }
        else
        {
                val_13 = 1;
        }
        
        .m_wager = 0m;
        mem[1152921528706507720] = 0;
        .m_minWins = 10;
        .m_currency = 0;
        .m_price = 0m;
        mem[1152921528706507736] = 0;
        val_1.Add(item:  val_3);
        WagerData val_4 = new WagerData();
        if(val_4 != null)
        {
                .m_button = 0;
        }
        else
        {
                mem[16] = 0;
        }
        
        .m_Level = 3;
        if(val_4 != null)
        {
                val_14 = 0;
        }
        else
        {
                val_14 = 1;
        }
        
        .m_wager = 0m;
        mem[1152921528706511816] = 0;
        .m_minWins = 20;
        .m_currency = 0;
        .m_price = 0m;
        mem[1152921528706511832] = 0;
        val_1.Add(item:  val_4);
        WagerData val_5 = new WagerData();
        if(val_5 != null)
        {
                .m_button = 0;
        }
        else
        {
                mem[16] = 0;
        }
        
        .m_Level = 4;
        if(val_5 != null)
        {
                val_15 = 0;
        }
        else
        {
                val_15 = 1;
        }
        
        .m_wager = 0m;
        mem[1152921528706515912] = 0;
        .m_minWins = 40;
        .m_currency = 0;
        .m_price = 0m;
        mem[1152921528706515928] = 0;
        val_1.Add(item:  val_5);
        WagerData val_6 = new WagerData();
        if(val_6 != null)
        {
                .m_button = 0;
        }
        else
        {
                mem[16] = 0;
        }
        
        .m_Level = 5;
        if(val_6 != null)
        {
                val_16 = 0;
        }
        else
        {
                val_16 = 1;
        }
        
        .m_wager = 0m;
        mem[1152921528706520008] = 0;
        .m_minWins = 60;
        .m_currency = 0;
        .m_price = 0m;
        mem[1152921528706520024] = 0;
        val_1.Add(item:  val_6);
        WagerData val_7 = new WagerData();
        if(val_7 != null)
        {
                .m_button = 0;
        }
        else
        {
                mem[16] = 0;
        }
        
        .m_Level = 6;
        if(val_7 != null)
        {
                val_17 = 0;
        }
        else
        {
                val_17 = 1;
        }
        
        .m_wager = 0m;
        mem[1152921528706524104] = 0;
        .m_minWins = 80;
        .m_currency = 1;
        .m_price = 0m;
        mem[1152921528706524120] = 0;
        val_1.Add(item:  val_7);
        WagerData val_8 = new WagerData();
        if(val_8 != null)
        {
                .m_button = 0;
        }
        else
        {
                mem[16] = 0;
        }
        
        .m_Level = 7;
        if(val_8 != null)
        {
                val_18 = 0;
        }
        else
        {
                val_18 = 1;
        }
        
        .m_wager = 0m;
        mem[1152921528706528200] = 0;
        .m_minWins = 100;
        .m_currency = 1;
        .m_price = 0m;
        mem[1152921528706528216] = 0;
        val_1.Add(item:  val_8);
        WagerData val_9 = new WagerData();
        if(val_9 != null)
        {
                .m_button = 0;
        }
        else
        {
                mem[16] = 0;
        }
        
        .m_Level = 8;
        if(val_9 != null)
        {
                val_19 = 0;
        }
        else
        {
                val_19 = 1;
        }
        
        .m_wager = 0m;
        mem[1152921528706532296] = 0;
        .m_minWins = 150;
        .m_currency = 1;
        .m_price = 0m;
        mem[1152921528706532312] = 0;
        val_1.Add(item:  val_9);
        WagerData val_10 = new WagerData();
        if(val_10 != null)
        {
                .m_button = 0;
        }
        else
        {
                mem[16] = 0;
        }
        
        .m_Level = 9;
        if(val_10 != null)
        {
                val_20 = 0;
        }
        else
        {
                val_20 = 1;
        }
        
        .m_wager = 0m;
        mem[1152921528706536392] = 0;
        .m_minWins = 200;
        .m_currency = 1;
        .m_price = 0m;
        mem[1152921528706536408] = 0;
        val_1.Add(item:  val_10);
        WagerData val_11 = new WagerData();
        if(val_11 != null)
        {
                .m_button = 0;
        }
        else
        {
                mem[16] = 0;
        }
        
        .m_Level = 10;
        if(val_11 != null)
        {
                val_21 = 0;
        }
        else
        {
                val_21 = 1;
        }
        
        .m_wager = 0m;
        mem[1152921528706540488] = 0;
        .m_minWins = 300;
        .m_currency = 1;
        .m_price = 0m;
        mem[1152921528706540504] = 0;
        val_1.Add(item:  val_11);
    }
    public PublicWagerData()
    {
        ActiveCanvasController val_1 = ActiveCanvasController.Instance;
        if(val_1.isCryptoPublicLobby != false)
        {
                PublicWagerData.InitCryptoCurrencyMode();
            return;
        }
        
        PublicWagerData.InitPearShellCurrencyMode();
    }
    public static WagerData GetDataByLevel(int level)
    {
        var val_5;
        if(PublicWagerData.m_wagerDataList == null)
        {
                PublicWagerData.InitPearShellCurrencyMode();
        }
        
        List.Enumerator<T> val_1 = 0.GetEnumerator();
        val_5 = 0;
        goto label_3;
        label_5:
        label_3:
        if(((-1669904792) & 1) != 0)
        {
            goto label_5;
        }
        
        0.Add(driver:  public System.Void List.Enumerator<WagerData>::Dispose(), rectTransform:  null, drivenProperties:  null);
        if((((-1669904792) == level) ? 0.InitialType : (val_5)) != 0)
        {
                return (WagerData)val_5;
        }
        
        val_5 = PublicWagerData.m_wagerDataList.Item[0];
        return (WagerData)val_5;
    }

}
