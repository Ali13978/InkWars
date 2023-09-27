using UnityEngine;
public class VIPCollection : ScriptableObject
{
    // Fields
    private System.Collections.Generic.List<VIPIconData> iconList;
    private System.Collections.Generic.List<VIPData> vipList;
    private VIPPromo promo;
    private static VIPCollection _inst;
    
    // Properties
    private static VIPCollection instance { get; }
    
    // Methods
    private static VIPCollection get_instance()
    {
        var val_3;
        VIPCollection val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = VIPCollection._inst;
        if(0 == val_4)
        {
                val_5 = null;
            val_4 = UnityEngine.Resources.Load<VIPCollection>(path:  "NetworkDataCollection/VIPCollection");
            val_5 = null;
            VIPCollection._inst = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (VIPCollection)VIPCollection._inst;
    }
    public static UnityEngine.Sprite GetMedalSpriteFromName(string name)
    {
        UnityEngine.Sprite val_5;
        .name = name;
        VIPCollection val_2 = VIPCollection.instance;
        if((val_2.iconList.Find(match:  new System.Predicate<VIPIconData>(object:  new VIPCollection.<>c__DisplayClass6_0(), method:  System.Boolean VIPCollection.<>c__DisplayClass6_0::<GetMedalSpriteFromName>b__0(VIPIconData x)))) == null)
        {
                return val_5;
        }
        
        val_5 = val_4.medal;
        return val_5;
    }
    public static UnityEngine.Sprite GetLongIconSpriteFromLevel(int level)
    {
        System.Predicate<T> val_6;
        UnityEngine.Sprite val_7;
        VIPCollection.<>c__DisplayClass7_0 val_1 = new VIPCollection.<>c__DisplayClass7_0();
        val_6 = 1152921505140285440;
        VIPData val_2 = VIPCollection.GetVipDataFromLevel(level:  level);
        if(val_1 == null)
        {
            goto label_3;
        }
        
        .data = val_2;
        if(val_2 == null)
        {
            goto label_4;
        }
        
        label_11:
        VIPCollection val_3 = VIPCollection.instance;
        System.Predicate<VIPIconData> val_4 = null;
        val_6 = val_4;
        val_4 = new System.Predicate<VIPIconData>(object:  val_1, method:  System.Boolean VIPCollection.<>c__DisplayClass7_0::<GetLongIconSpriteFromLevel>b__0(VIPIconData x));
        if((val_3.iconList.Find(match:  val_4)) == null)
        {
                return (UnityEngine.Sprite)val_7;
        }
        
        val_7 = val_5.longIcon;
        return (UnityEngine.Sprite)val_7;
        label_3:
        mem[16] = val_2;
        if(mem[16] != 0)
        {
            goto label_11;
        }
        
        label_4:
        val_7 = 0;
        return (UnityEngine.Sprite)val_7;
    }
    public static UnityEngine.Sprite GetSquareIconSpriteFromLevel(int level)
    {
        System.Predicate<T> val_6;
        UnityEngine.Sprite val_7;
        VIPCollection.<>c__DisplayClass8_0 val_1 = new VIPCollection.<>c__DisplayClass8_0();
        val_6 = 1152921505140285440;
        VIPData val_2 = VIPCollection.GetVipDataFromLevel(level:  level);
        if(val_1 == null)
        {
            goto label_3;
        }
        
        .data = val_2;
        if(val_2 == null)
        {
            goto label_4;
        }
        
        label_11:
        VIPCollection val_3 = VIPCollection.instance;
        System.Predicate<VIPIconData> val_4 = null;
        val_6 = val_4;
        val_4 = new System.Predicate<VIPIconData>(object:  val_1, method:  System.Boolean VIPCollection.<>c__DisplayClass8_0::<GetSquareIconSpriteFromLevel>b__0(VIPIconData x));
        if((val_3.iconList.Find(match:  val_4)) == null)
        {
                return (UnityEngine.Sprite)val_7;
        }
        
        val_7 = val_5.squareIcon;
        return (UnityEngine.Sprite)val_7;
        label_3:
        mem[16] = val_2;
        if(mem[16] != 0)
        {
            goto label_11;
        }
        
        label_4:
        val_7 = 0;
        return (UnityEngine.Sprite)val_7;
    }
    public static VIPData GetVipDataFromLevel(int level)
    {
        .level = level;
        VIPCollection val_2 = VIPCollection.instance;
        if(val_2.vipList != null)
        {
                return val_2.vipList.Find(match:  new System.Predicate<VIPData>(object:  new VIPCollection.<>c__DisplayClass9_0(), method:  System.Boolean VIPCollection.<>c__DisplayClass9_0::<GetVipDataFromLevel>b__0(VIPData x)));
        }
        
        return val_2.vipList.Find(match:  new System.Predicate<VIPData>(object:  new VIPCollection.<>c__DisplayClass9_0(), method:  System.Boolean VIPCollection.<>c__DisplayClass9_0::<GetVipDataFromLevel>b__0(VIPData x)));
    }
    public static VIPData GetBundleData()
    {
        var val_3;
        VIPCollection val_1 = VIPCollection.instance;
        val_3 = null;
        val_3 = null;
        if((VIPCollection.<>c.<>9__10_0) != null)
        {
                if(val_1.vipList == null)
        {
                return val_1.vipList.Find(match:  VIPCollection.<>c.<>9__10_0);
        }
        
            return val_1.vipList.Find(match:  VIPCollection.<>c.<>9__10_0);
        }
        
        VIPCollection.<>c.<>9__10_0 = new System.Predicate<VIPData>(object:  VIPCollection.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean VIPCollection.<>c::<GetBundleData>b__10_0(VIPData x));
        if(val_1.vipList != null)
        {
                return val_1.vipList.Find(match:  VIPCollection.<>c.<>9__10_0);
        }
        
        return val_1.vipList.Find(match:  VIPCollection.<>c.<>9__10_0);
    }
    public static void SetupVIPFromRemoteConfig()
    {
        VIPCollection.SetupVIPDataFromJson(json:  AzureRemoteConfig.GetString(key:  "data.VIPData", defaultValue:  ""));
        VIPCollection.SetupVIPPromoFromJson(json:  AzureRemoteConfig.GetString(key:  "data.VIPPromo", defaultValue:  ""));
    }
    private static void SetupVIPPromoFromJson(string json)
    {
        VIPCollection val_1 = VIPCollection.instance;
        val_1.promo = UnityEngine.JsonUtility.FromJson<VIPPromo>(json:  json);
    }
    public static void SetupVIPDataFromJson(string json)
    {
        VIPDataWrapper val_1 = UnityEngine.JsonUtility.FromJson<VIPDataWrapper>(json:  json);
        VIPCollection val_2 = VIPCollection.instance;
        val_2.vipList = val_1.data;
    }
    public static VIPPromo GetPromoData()
    {
        if(VIPCollection.instance != null)
        {
                return (VIPPromo)val_1.promo;
        }
        
        return (VIPPromo)val_1.promo;
    }
    public static bool IsPopular(int level)
    {
        int val_4 = level;
        if((VIPCollection.GetVipDataFromLevel(level:  val_4 = level)) == null)
        {
                return (bool)(val_2.isPopular == true) ? 1 : 0;
        }
        
        val_4 = VIPCollection.GetVipDataFromLevel(level:  val_4);
        return (bool)(val_2.isPopular == true) ? 1 : 0;
    }
    public VIPCollection()
    {
        this.iconList = new System.Collections.Generic.List<VIPIconData>();
        this.vipList = new System.Collections.Generic.List<VIPData>();
        VIPPromo val_3 = null;
        .freeDaysForNormal = 5;
        .normalDurationInDays = ;
        .eventDaysBeforeVIPFinish = ;
        .eventDaysAfterVIPStart = 12884901891;
        .freeDaysForAfterVIPStartPromo = 3;
        .freeDaysForNewUserGiftVIP = 3;
        .levelForNewUserGiftVIP = 2;
        val_3 = new VIPPromo();
        this.promo = val_3;
    }
    private static VIPCollection()
    {
    
    }

}
