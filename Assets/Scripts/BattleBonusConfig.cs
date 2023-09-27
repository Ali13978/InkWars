using UnityEngine;
public static class BattleBonusConfig
{
    // Fields
    public const string GRID_TYPE_KEY = "GRID";
    public const string SWITCHER_TYPE_KEY = "SWITCHER";
    public const string BUBBLE_TYPE_KEY = "BUBBLE";
    public const string REMOTE_CONFIG_KEY = "data.BattleBonusConfig";
    private static BattleBonusConfigData config;
    
    // Methods
    public static void InitConfigFromJson(string json)
    {
        var val_2 = null;
        BattleBonusConfig.config = UnityEngine.JsonUtility.FromJson<BattleBonusConfigData>(json:  json);
    }
    public static void FetchBonus(UnityEngine.Events.UnityAction OnDone)
    {
        .OnDone = OnDone;
        AzureRemoteConfig.FetchRemote(callback:  new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  new BattleBonusConfig.<>c__DisplayClass6_0(), method:  System.Void BattleBonusConfig.<>c__DisplayClass6_0::<FetchBonus>b__0(bool success, string errorInfo)));
    }
    public static int GetTotlaBonusValue(BattleBonusType type)
    {
        var val_7;
        System.Predicate<T> val_8;
        var val_9;
        .type = type;
        val_7 = null;
        val_7 = null;
        System.Predicate<BattleBonusData> val_2 = null;
        val_8 = val_2;
        val_2 = new System.Predicate<BattleBonusData>(object:  new BattleBonusConfig.<>c__DisplayClass7_0(), method:  System.Boolean BattleBonusConfig.<>c__DisplayClass7_0::<GetTotlaBonusValue>b__0(BattleBonusData x));
        val_9 = FindAll(match:  val_2);
        if(val_9 == null)
        {
                return (int)val_9;
        }
        
        if(val_9.Count == 0)
        {
            goto label_7;
        }
        
        List.Enumerator<T> val_5 = val_9.GetEnumerator();
        val_8 = 1152921528926328912;
        val_9 = 0;
        goto label_8;
        label_10:
        System.Type val_6 = 0.InitialType;
        label_8:
        if(((-1450298648) & 1) != 0)
        {
            goto label_10;
        }
        
        0.Add(driver:  public System.Void List.Enumerator<BattleBonusData>::Dispose(), rectTransform:  public System.Collections.Generic.List<T> System.Collections.Generic.List<BattleBonusData>::FindAll(System.Predicate<T> match), drivenProperties:  public System.Void System.Predicate<BattleBonusData>::.ctor(object object, IntPtr method));
        return (int)val_9;
        label_7:
        val_9 = 0;
        return (int)val_9;
    }
    public static int GetItemBonusValue(string item, int id)
    {
        var val_4;
        int val_5;
        BattleBonusConfig.<>c__DisplayClass8_0 val_1 = new BattleBonusConfig.<>c__DisplayClass8_0();
        if(val_1 != null)
        {
                .item = item;
        }
        else
        {
                mem[16] = item;
        }
        
        .id = id;
        val_4 = null;
        val_4 = null;
        if((Find(match:  new System.Predicate<BattleBonusData>(object:  val_1, method:  System.Boolean BattleBonusConfig.<>c__DisplayClass8_0::<GetItemBonusValue>b__0(BattleBonusData x)))) == null)
        {
                return val_5;
        }
        
        val_5 = val_3.value;
        return val_5;
    }
    public static BattleBonusType GetItemBonusType(string item, int id)
    {
        object val_6;
        var val_7;
        var val_8;
        BattleBonusConfig.<>c__DisplayClass9_0 val_1 = null;
        val_6 = val_1;
        val_1 = new BattleBonusConfig.<>c__DisplayClass9_0();
        if(val_6 != null)
        {
                .item = item;
        }
        else
        {
                mem[16] = item;
        }
        
        .id = id;
        val_7 = null;
        val_7 = null;
        val_8 = 999;
        BattleBonusType val_4 = 999;
        if((Find(match:  new System.Predicate<BattleBonusData>(object:  val_1, method:  System.Boolean BattleBonusConfig.<>c__DisplayClass9_0::<GetItemBonusType>b__0(BattleBonusData x)))) == null)
        {
                return (BattleBonusType)val_8;
        }
        
        val_6 = val_3.bonus;
        bool val_5 = System.Enum.TryParse<BattleBonusType>(value:  val_6, result: out  val_4);
        val_8 = val_4;
        return (BattleBonusType)val_8;
    }
    public static int GetBonusValueForLocalPlayer(BattleBonusType type)
    {
        var val_7;
        var val_20;
        System.Predicate<T> val_21;
        UnityEngine.DrivenTransformProperties val_22;
        UnityEngine.RectTransform val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        .type = type;
        val_20 = null;
        val_20 = null;
        System.Predicate<BattleBonusData> val_2 = null;
        val_21 = val_2;
        val_22 = public System.Void System.Predicate<BattleBonusData>::.ctor(object object, IntPtr method);
        val_2 = new System.Predicate<BattleBonusData>(object:  new BattleBonusConfig.<>c__DisplayClass10_0(), method:  System.Boolean BattleBonusConfig.<>c__DisplayClass10_0::<GetBonusValueForLocalPlayer>b__0(BattleBonusData x));
        val_23 = public System.Collections.Generic.List<T> System.Collections.Generic.List<BattleBonusData>::FindAll(System.Predicate<T> match);
        val_24 = FindAll(match:  val_2);
        if(val_24 == null)
        {
                return (int)val_24;
        }
        
        if(val_24.Count == 0)
        {
            goto label_7;
        }
        
        List.Enumerator<T> val_5 = val_24.GetEnumerator();
        val_24 = 0;
        goto label_26;
        label_27:
        val_21 = val_8._impl;
        if((System.String.op_Equality(a:  val_21, b:  "SWITCHER")) == false)
        {
            goto label_10;
        }
        
        val_25 = null;
        val_25 = null;
        val_21 = DataStructs.UserDataDictionary.Items;
        val_23 = 1;
        val_26 = val_21;
        val_22 = 0;
        bool val_10 = val_26.GetSwitcherUnlocked(id:  W22, includeVipUnlock:  true);
        goto label_19;
        label_10:
        if((System.String.op_Equality(a:  val_21, b:  "GRID")) == false)
        {
            goto label_15;
        }
        
        val_27 = null;
        val_27 = null;
        val_21 = DataStructs.UserDataDictionary.Items;
        val_23 = 1;
        val_26 = val_21;
        val_22 = 0;
        bool val_12 = val_26.GetBattleGridUnlocked(id:  W22, includeVipUnlock:  true);
        goto label_19;
        label_15:
        val_23 = 0;
        if((System.String.op_Equality(a:  val_21, b:  "BUBBLE")) == false)
        {
            goto label_26;
        }
        
        bool val_17 = System.Enum.TryParse<InkWars.Model.BubbleFamily>(value:  val_7.InitialType + 24.ToString(), result: out  37);
        val_28 = null;
        val_28 = null;
        val_21 = DataStructs.UserDataDictionary.Items;
        val_23 = 1;
        val_26 = val_21;
        val_22 = 0;
        label_19:
        if((val_26.GetBubbleUnlocked(id:  37, includeVipUnlock:  true)) != false)
        {
                val_24 = 1152921505151524864;
        }
        
        label_26:
        if(((-1449829584) & 1) != 0)
        {
            goto label_27;
        }
        
        val_7.Add(driver:  public System.Void List.Enumerator<BattleBonusData>::Dispose(), rectTransform:  val_23, drivenProperties:  val_22);
        return (int)val_24;
        label_7:
        val_24 = 0;
        return (int)val_24;
    }
    public static string GetTypeString(BattleBonusType type)
    {
        var val_7;
        type.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        string val_3 = LanguageManager.GetText(key:  "LK.BATTLE_BONUS." + type.ToString() + ".DESC");
        val_7 = val_3;
        if((System.String.IsNullOrWhiteSpace(value:  val_3)) != true)
        {
                if((val_7.Contains(value:  "LK.BATTLE_BONUS.")) == false)
        {
                return (string)val_7;
        }
        
        }
        
        val_7 = LanguageManager.GetText(key:  "LK.NA");
        return (string)val_7;
    }
    public static string GetFormatValueString(BattleBonusType type, int value)
    {
        if(type > 17)
        {
                return LanguageManager.GetText(key:  "LK.NA");
        }
        
        var val_2 = 40829736 + (type) << 2;
        val_2 = val_2 + 40829736;
        goto (40829736 + (type) << 2 + 40829736);
    }
    private static BattleBonusConfigData CreateDefault()
    {
        BattleBonusData val_2 = new BattleBonusData();
        .item = "GRID";
        .id = 18;
        BattleBonusData val_3 = val_2.SetBonus(aNewBonus:  6);
        .value = 2;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_2);
        BattleBonusData val_4 = new BattleBonusData();
        .item = "GRID";
        .id = 19;
        BattleBonusData val_5 = val_4.SetBonus(aNewBonus:  7);
        .value = 2;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_4);
        BattleBonusData val_6 = new BattleBonusData();
        .item = "GRID";
        .id = 20;
        BattleBonusData val_7 = val_6.SetBonus(aNewBonus:  8);
        .value = 1;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_6);
        BattleBonusData val_8 = new BattleBonusData();
        .item = "GRID";
        .id = 21;
        BattleBonusData val_9 = val_8.SetBonus(aNewBonus:  9);
        .value = 1;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_8);
        BattleBonusData val_10 = new BattleBonusData();
        .item = "GRID";
        .id = 22;
        BattleBonusData val_11 = val_10.SetBonus(aNewBonus:  10);
        .value = 1;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_10);
        BattleBonusData val_12 = new BattleBonusData();
        .item = "GRID";
        .id = 23;
        BattleBonusData val_13 = val_12.SetBonus(aNewBonus:  11);
        .value = 1;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_12);
        BattleBonusData val_14 = new BattleBonusData();
        .item = "GRID";
        .id = 3;
        BattleBonusData val_15 = val_14.SetBonus(aNewBonus:  6);
        .value = 4;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_14);
        BattleBonusData val_16 = new BattleBonusData();
        .item = "GRID";
        .id = 4;
        BattleBonusData val_17 = val_16.SetBonus(aNewBonus:  7);
        .value = 4;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_16);
        BattleBonusData val_18 = new BattleBonusData();
        .item = "GRID";
        .id = 5;
        BattleBonusData val_19 = val_18.SetBonus(aNewBonus:  8);
        .value = 2;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_18);
        BattleBonusData val_20 = new BattleBonusData();
        .item = "GRID";
        .id = 24;
        BattleBonusData val_21 = val_20.SetBonus(aNewBonus:  9);
        .value = 2;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_20);
        BattleBonusData val_22 = new BattleBonusData();
        .item = "GRID";
        .id = 25;
        BattleBonusData val_23 = val_22.SetBonus(aNewBonus:  10);
        .value = 2;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_22);
        BattleBonusData val_24 = new BattleBonusData();
        .item = "GRID";
        .id = 26;
        BattleBonusData val_25 = val_24.SetBonus(aNewBonus:  11);
        .value = 2;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_24);
        BattleBonusData val_26 = new BattleBonusData();
        .item = "GRID";
        .id = 6;
        BattleBonusData val_27 = val_26.SetBonus(aNewBonus:  6);
        .value = 6;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_26);
        BattleBonusData val_28 = new BattleBonusData();
        .item = "GRID";
        .id = 7;
        BattleBonusData val_29 = val_28.SetBonus(aNewBonus:  7);
        .value = 6;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_28);
        BattleBonusData val_30 = new BattleBonusData();
        .item = "GRID";
        .id = 8;
        BattleBonusData val_31 = val_30.SetBonus(aNewBonus:  8);
        .value = 3;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_30);
        BattleBonusData val_32 = new BattleBonusData();
        .item = "GRID";
        .id = 27;
        BattleBonusData val_33 = val_32.SetBonus(aNewBonus:  9);
        .value = 3;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_32);
        BattleBonusData val_34 = new BattleBonusData();
        .item = "GRID";
        .id = 28;
        BattleBonusData val_35 = val_34.SetBonus(aNewBonus:  10);
        .value = 3;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_34);
        BattleBonusData val_36 = new BattleBonusData();
        .item = "GRID";
        .id = 29;
        BattleBonusData val_37 = val_36.SetBonus(aNewBonus:  11);
        .value = 3;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_36);
        BattleBonusData val_38 = new BattleBonusData();
        .item = "GRID";
        .id = 9;
        BattleBonusData val_39 = val_38.SetBonus(aNewBonus:  6);
        .value = 8;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_38);
        BattleBonusData val_40 = new BattleBonusData();
        .item = "GRID";
        .id = 10;
        BattleBonusData val_41 = val_40.SetBonus(aNewBonus:  7);
        .value = 8;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_40);
        BattleBonusData val_42 = new BattleBonusData();
        .item = "GRID";
        .id = 11;
        BattleBonusData val_43 = val_42.SetBonus(aNewBonus:  8);
        .value = 4;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_42);
        BattleBonusData val_44 = new BattleBonusData();
        .item = "GRID";
        .id = 30;
        BattleBonusData val_45 = val_44.SetBonus(aNewBonus:  9);
        .value = 4;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_44);
        BattleBonusData val_46 = new BattleBonusData();
        .item = "GRID";
        .id = 31;
        BattleBonusData val_47 = val_46.SetBonus(aNewBonus:  10);
        .value = 4;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_46);
        BattleBonusData val_48 = new BattleBonusData();
        .item = "GRID";
        .id = 32;
        BattleBonusData val_49 = val_48.SetBonus(aNewBonus:  11);
        .value = 4;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_48);
        BattleBonusData val_50 = new BattleBonusData();
        .item = "GRID";
        .id = 12;
        BattleBonusData val_51 = val_50.SetBonus(aNewBonus:  6);
        .value = 10;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_50);
        BattleBonusData val_52 = new BattleBonusData();
        .item = "GRID";
        .id = 13;
        BattleBonusData val_53 = val_52.SetBonus(aNewBonus:  7);
        .value = 10;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_52);
        BattleBonusData val_54 = new BattleBonusData();
        .item = "GRID";
        .id = 14;
        BattleBonusData val_55 = val_54.SetBonus(aNewBonus:  8);
        .value = 5;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_54);
        BattleBonusData val_56 = new BattleBonusData();
        .item = "GRID";
        .id = 33;
        BattleBonusData val_57 = val_56.SetBonus(aNewBonus:  9);
        .value = 5;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_56);
        BattleBonusData val_58 = new BattleBonusData();
        .item = "GRID";
        .id = 34;
        BattleBonusData val_59 = val_58.SetBonus(aNewBonus:  10);
        .value = 5;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_58);
        BattleBonusData val_60 = new BattleBonusData();
        .item = "GRID";
        .id = 35;
        BattleBonusData val_61 = val_60.SetBonus(aNewBonus:  11);
        .value = 5;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_60);
        BattleBonusData val_62 = new BattleBonusData();
        .item = "GRID";
        .id = 15;
        BattleBonusData val_63 = val_62.SetBonus(aNewBonus:  6);
        .value = 12;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_62);
        BattleBonusData val_64 = new BattleBonusData();
        .item = "GRID";
        .id = 16;
        BattleBonusData val_65 = val_64.SetBonus(aNewBonus:  7);
        .value = 12;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_64);
        BattleBonusData val_66 = new BattleBonusData();
        .item = "GRID";
        .id = 17;
        BattleBonusData val_67 = val_66.SetBonus(aNewBonus:  8);
        .value = 6;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_66);
        BattleBonusData val_68 = new BattleBonusData();
        .item = "GRID";
        .id = 36;
        BattleBonusData val_69 = val_68.SetBonus(aNewBonus:  9);
        .value = 6;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_68);
        BattleBonusData val_70 = new BattleBonusData();
        .item = "GRID";
        .id = 37;
        BattleBonusData val_71 = val_70.SetBonus(aNewBonus:  10);
        .value = 6;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_70);
        BattleBonusData val_72 = new BattleBonusData();
        .item = "GRID";
        .id = 38;
        BattleBonusData val_73 = val_72.SetBonus(aNewBonus:  11);
        .value = 6;
        (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_72);
        int val_110 = 6;
        int val_111 = 1;
        do
        {
            BattleBonusData val_75 = new BattleBonusData();
            .item = "SWITCHER";
            .id = val_110 - 5;
            BattleBonusData val_76 = val_75.SetBonus(aNewBonus:  0);
            .value = val_111;
            (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_75);
            BattleBonusData val_78 = new BattleBonusData();
            .item = "SWITCHER";
            .id = val_110 - 4;
            BattleBonusData val_79 = val_78.SetBonus(aNewBonus:  1);
            .value = val_111;
            (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_78);
            BattleBonusData val_81 = new BattleBonusData();
            .item = "SWITCHER";
            .id = val_110 - 3;
            BattleBonusData val_82 = val_81.SetBonus(aNewBonus:  2);
            .value = 100;
            (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_81);
            BattleBonusData val_84 = new BattleBonusData();
            .item = "SWITCHER";
            .id = val_110 - 2;
            BattleBonusData val_85 = val_84.SetBonus(aNewBonus:  3);
            .value = 100;
            (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_84);
            BattleBonusData val_87 = new BattleBonusData();
            .item = "SWITCHER";
            .id = val_110 - 1;
            BattleBonusData val_88 = val_87.SetBonus(aNewBonus:  4);
            .value = val_111;
            (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_87);
            BattleBonusData val_89 = new BattleBonusData();
            .item = "SWITCHER";
            .id = val_110;
            BattleBonusData val_90 = val_89.SetBonus(aNewBonus:  5);
            .value = val_111;
            (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_89);
            val_110 = val_110 + 6;
            var val_91 = 100 + 100;
            val_111 = val_111 + 1;
        }
        while(val_110 != 42);
        
        int val_112 = 6;
        int val_113 = 3;
        do
        {
            BattleBonusData val_93 = new BattleBonusData();
            .item = "BUBBLE";
            .id = val_112 - 5;
            BattleBonusData val_94 = val_93.SetBonus(aNewBonus:  12);
            .value = val_113;
            (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_93);
            BattleBonusData val_96 = new BattleBonusData();
            .item = "BUBBLE";
            .id = val_112 - 4;
            BattleBonusData val_97 = val_96.SetBonus(aNewBonus:  13);
            .value = val_113;
            (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_96);
            BattleBonusData val_99 = new BattleBonusData();
            .item = "BUBBLE";
            .id = val_112 - 3;
            BattleBonusData val_100 = val_99.SetBonus(aNewBonus:  14);
            .value = val_113;
            (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_99);
            BattleBonusData val_102 = new BattleBonusData();
            .item = "BUBBLE";
            .id = val_112 - 2;
            BattleBonusData val_103 = val_102.SetBonus(aNewBonus:  15);
            .value = val_113;
            (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_102);
            BattleBonusData val_105 = new BattleBonusData();
            .item = "BUBBLE";
            .id = val_112 - 1;
            BattleBonusData val_106 = val_105.SetBonus(aNewBonus:  16);
            .value = 1;
            var val_107 = 0 + 1;
            (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_105);
            BattleBonusData val_108 = new BattleBonusData();
            .item = "BUBBLE";
            .id = val_112;
            BattleBonusData val_109 = val_108.SetBonus(aNewBonus:  17);
            .value = 1;
            (BattleBonusConfigData)[1152921528927858112].data.Add(item:  val_108);
            val_112 = val_112 + 6;
            val_113 = val_113 + 3;
        }
        while(val_112 != 42);
        
        return (BattleBonusConfigData)new BattleBonusConfigData();
    }
    private static BattleBonusConfig()
    {
        BattleBonusConfig.config = BattleBonusConfig.CreateDefault();
    }

}
