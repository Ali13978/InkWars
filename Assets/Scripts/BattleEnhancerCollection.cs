using UnityEngine;
public class BattleEnhancerCollection : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<BattleEnhancerCollection.BattleEnhancerAssets> items;
    public UnityEngine.Sprite blockIcon;
    public System.Collections.Generic.List<BattleEnhancerCollection.BattleEnhancerButtonBG> buttonBGList;
    public System.Collections.Generic.List<BattleEnhancerCollection.BattleEnhancerChatBubbleBG> bubbleBGList;
    public System.Collections.Generic.List<BattleEnhancerCollection.BattleEnhancerSFX> sfxList;
    public System.Collections.Generic.List<BattleEnhancerCollection.BattleEnhancerPriceData> priceList;
    private static BattleEnhancerCollection _inst;
    
    // Properties
    private static BattleEnhancerCollection instance { get; }
    
    // Methods
    private static BattleEnhancerCollection get_instance()
    {
        var val_3;
        BattleEnhancerCollection val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = BattleEnhancerCollection._inst;
        if(0 == val_4)
        {
                val_5 = null;
            val_4 = UnityEngine.Resources.Load<BattleEnhancerCollection>(path:  "NetworkDataCollection/BattleEnhancerCollection");
            val_5 = null;
            BattleEnhancerCollection._inst = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (BattleEnhancerCollection)BattleEnhancerCollection._inst;
    }
    public static BattleEnhancerCollection.BattleEnhancerAssets Get(InkWars.Model.BattleEnhancerType type)
    {
        object val_7;
        System.Collections.Generic.List<BattleEnhancerAssets> val_8;
        var val_9;
        BattleEnhancerCollection.<>c__DisplayClass14_0 val_1 = new BattleEnhancerCollection.<>c__DisplayClass14_0();
        val_7 = val_1;
        .type = type;
        BattleEnhancerCollection val_2 = BattleEnhancerCollection.instance;
        val_8 = val_2.items;
        if((val_8.Find(match:  new System.Predicate<BattleEnhancerAssets>(object:  val_1, method:  System.Boolean BattleEnhancerCollection.<>c__DisplayClass14_0::<Get>b__0(BattleEnhancerCollection.BattleEnhancerAssets x)))) != null)
        {
                return (BattleEnhancerAssets)val_9;
        }
        
        val_8 = .type.ToString();
        .type.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  public BattleEnhancerAssets System.Collections.Generic.List<BattleEnhancerAssets>::Find(System.Predicate<T> match), drivenProperties:  public System.Void System.Predicate<BattleEnhancerAssets>::.ctor(object object, IntPtr method));
        mem[1152921528863179936] = null;
        val_7 = "Cannot find BattleEnhancer with type " + val_8;
        UnityEngine.Debug.LogError(message:  val_7);
        val_9 = 0;
        return (BattleEnhancerAssets)val_9;
    }
    public static string GetName(InkWars.Model.BattleEnhancerType type)
    {
        object val_9;
        System.Collections.Generic.List<BattleEnhancerAssets> val_10;
        var val_11;
        BattleEnhancerCollection.<>c__DisplayClass15_0 val_1 = new BattleEnhancerCollection.<>c__DisplayClass15_0();
        val_9 = val_1;
        .type = type;
        BattleEnhancerCollection val_2 = BattleEnhancerCollection.instance;
        val_10 = val_2.items;
        if((val_10.Find(match:  new System.Predicate<BattleEnhancerAssets>(object:  val_1, method:  System.Boolean BattleEnhancerCollection.<>c__DisplayClass15_0::<GetName>b__0(BattleEnhancerCollection.BattleEnhancerAssets x)))) != null)
        {
                string val_6 = LanguageManager.GetText(key:  "Lk.BattleEnhancer." + val_4.type);
            return (string)val_11;
        }
        
        val_10 = .type.ToString();
        .type.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  public BattleEnhancerAssets System.Collections.Generic.List<BattleEnhancerAssets>::Find(System.Predicate<T> match), drivenProperties:  public System.Void System.Predicate<BattleEnhancerAssets>::.ctor(object object, IntPtr method));
        mem[1152921528863383184] = null;
        val_9 = "Cannot find BattleEnhancer with type " + val_10;
        UnityEngine.Debug.LogError(message:  val_9);
        val_11 = "";
        return (string)val_11;
    }
    public static string GetDesc(InkWars.Model.BattleEnhancerType type)
    {
        object val_9;
        System.Collections.Generic.List<BattleEnhancerAssets> val_10;
        var val_11;
        BattleEnhancerCollection.<>c__DisplayClass16_0 val_1 = new BattleEnhancerCollection.<>c__DisplayClass16_0();
        val_9 = val_1;
        .type = type;
        BattleEnhancerCollection val_2 = BattleEnhancerCollection.instance;
        val_10 = val_2.items;
        if((val_10.Find(match:  new System.Predicate<BattleEnhancerAssets>(object:  val_1, method:  System.Boolean BattleEnhancerCollection.<>c__DisplayClass16_0::<GetDesc>b__0(BattleEnhancerCollection.BattleEnhancerAssets x)))) != null)
        {
                string val_6 = LanguageManager.GetText(key:  "Lk.BattleEnhancer." + val_4.type + ".dec");
            return (string)val_11;
        }
        
        val_10 = .type.ToString();
        .type.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  public BattleEnhancerAssets System.Collections.Generic.List<BattleEnhancerAssets>::Find(System.Predicate<T> match), drivenProperties:  public System.Void System.Predicate<BattleEnhancerAssets>::.ctor(object object, IntPtr method));
        mem[1152921528863602784] = null;
        val_9 = "Cannot find BattleEnhancer with type " + val_10;
        UnityEngine.Debug.LogError(message:  val_9);
        val_11 = "";
        return (string)val_11;
    }
    public static UnityEngine.Sprite GetBlockIcon()
    {
        if(BattleEnhancerCollection.instance != null)
        {
                return (UnityEngine.Sprite)val_1.blockIcon;
        }
        
        return (UnityEngine.Sprite)val_1.blockIcon;
    }
    public static UnityEngine.Sprite GetIcon(InkWars.Model.BattleEnhancerType type, bool isOpponent = False)
    {
        object val_7;
        object val_8;
        UnityEngine.Sprite val_9;
        BattleEnhancerCollection.<>c__DisplayClass18_0 val_1 = null;
        val_7 = val_1;
        val_1 = new BattleEnhancerCollection.<>c__DisplayClass18_0();
        val_8 = val_7;
        .type = type;
        BattleEnhancerCollection val_2 = BattleEnhancerCollection.instance;
        if((val_2.items.Find(match:  new System.Predicate<BattleEnhancerAssets>(object:  val_1, method:  System.Boolean BattleEnhancerCollection.<>c__DisplayClass18_0::<GetIcon>b__0(BattleEnhancerCollection.BattleEnhancerAssets x)))) == null)
        {
            goto label_6;
        }
        
        if(isOpponent == false)
        {
            goto label_7;
        }
        
        val_9 = val_4.opponentIcon;
        return val_9;
        label_6:
        val_7 = .type.ToString();
        .type.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  public BattleEnhancerAssets System.Collections.Generic.List<BattleEnhancerAssets>::Find(System.Predicate<T> match), drivenProperties:  public System.Void System.Predicate<BattleEnhancerAssets>::.ctor(object object, IntPtr method));
        mem[1152921528863942496] = null;
        val_8 = "Cannot find BattleEnhancer with type " + val_7;
        UnityEngine.Debug.LogError(message:  val_8);
        val_9 = 0;
        return val_9;
        label_7:
        val_9 = val_4.icon;
        return val_9;
    }
    public static UnityEngine.Sprite GetButtonBG(InkWars.Model.BattleEnhancerState state)
    {
        object val_7;
        System.Collections.Generic.List<BattleEnhancerButtonBG> val_8;
        UnityEngine.Sprite val_9;
        BattleEnhancerCollection.<>c__DisplayClass19_0 val_1 = new BattleEnhancerCollection.<>c__DisplayClass19_0();
        val_7 = val_1;
        .state = state;
        BattleEnhancerCollection val_2 = BattleEnhancerCollection.instance;
        val_8 = val_2.buttonBGList;
        if((val_8.Find(match:  new System.Predicate<BattleEnhancerButtonBG>(object:  val_1, method:  System.Boolean BattleEnhancerCollection.<>c__DisplayClass19_0::<GetButtonBG>b__0(BattleEnhancerCollection.BattleEnhancerButtonBG x)))) != null)
        {
                val_9 = val_4.buttonBG;
            return (UnityEngine.Sprite)val_9;
        }
        
        val_8 = .state.ToString();
        .state.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  public BattleEnhancerButtonBG System.Collections.Generic.List<BattleEnhancerButtonBG>::Find(System.Predicate<T> match), drivenProperties:  public System.Void System.Predicate<BattleEnhancerButtonBG>::.ctor(object object, IntPtr method));
        mem[1152921528864143760] = null;
        val_7 = "Cannot find battle enhancer button bg by state: "("Cannot find battle enhancer button bg by state: ") + val_8;
        UnityEngine.Debug.LogError(message:  val_7);
        val_9 = 0;
        return (UnityEngine.Sprite)val_9;
    }
    public static UnityEngine.Sprite GetChatBubbleBG(InkWars.Model.BattleEnhancerType enhancerType)
    {
        object val_7;
        System.Collections.Generic.List<BattleEnhancerChatBubbleBG> val_8;
        UnityEngine.Sprite val_9;
        BattleEnhancerCollection.<>c__DisplayClass20_0 val_1 = new BattleEnhancerCollection.<>c__DisplayClass20_0();
        val_7 = val_1;
        .enhancerType = enhancerType;
        BattleEnhancerCollection val_2 = BattleEnhancerCollection.instance;
        val_8 = val_2.bubbleBGList;
        if((val_8.Find(match:  new System.Predicate<BattleEnhancerChatBubbleBG>(object:  val_1, method:  System.Boolean BattleEnhancerCollection.<>c__DisplayClass20_0::<GetChatBubbleBG>b__0(BattleEnhancerCollection.BattleEnhancerChatBubbleBG x)))) != null)
        {
                val_9 = val_4.bubbleBG;
            return (UnityEngine.Sprite)val_9;
        }
        
        val_8 = .enhancerType.ToString();
        .enhancerType.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  public BattleEnhancerChatBubbleBG System.Collections.Generic.List<BattleEnhancerChatBubbleBG>::Find(System.Predicate<T> match), drivenProperties:  public System.Void System.Predicate<BattleEnhancerChatBubbleBG>::.ctor(object object, IntPtr method));
        mem[1152921528864340944] = null;
        val_7 = "Cannot find battle enhancer bubble bg by enhancerType: "("Cannot find battle enhancer bubble bg by enhancerType: ") + val_8;
        UnityEngine.Debug.LogError(message:  val_7);
        val_9 = 0;
        return (UnityEngine.Sprite)val_9;
    }
    public static UnityEngine.AudioClip GetSFX(InkWars.Model.BattleEnhancerState state)
    {
        object val_7;
        System.Collections.Generic.List<BattleEnhancerSFX> val_8;
        UnityEngine.AudioClip val_9;
        BattleEnhancerCollection.<>c__DisplayClass21_0 val_1 = new BattleEnhancerCollection.<>c__DisplayClass21_0();
        val_7 = val_1;
        .state = state;
        BattleEnhancerCollection val_2 = BattleEnhancerCollection.instance;
        val_8 = val_2.sfxList;
        if((val_8.Find(match:  new System.Predicate<BattleEnhancerSFX>(object:  val_1, method:  System.Boolean BattleEnhancerCollection.<>c__DisplayClass21_0::<GetSFX>b__0(BattleEnhancerCollection.BattleEnhancerSFX x)))) != null)
        {
                val_9 = val_4.sfx;
            return (UnityEngine.AudioClip)val_9;
        }
        
        val_8 = .state.ToString();
        .state.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  public BattleEnhancerSFX System.Collections.Generic.List<BattleEnhancerSFX>::Find(System.Predicate<T> match), drivenProperties:  public System.Void System.Predicate<BattleEnhancerSFX>::.ctor(object object, IntPtr method));
        mem[1152921528864538096] = null;
        val_7 = "Cannot find battle enhancer sfx by state: "("Cannot find battle enhancer sfx by state: ") + val_8;
        UnityEngine.Debug.LogError(message:  val_7);
        val_9 = 0;
        return (UnityEngine.AudioClip)val_9;
    }
    public static bool GetIsDebuffType(InkWars.Model.BattleEnhancerType type)
    {
        object val_8;
        System.Collections.Generic.List<BattleEnhancerAssets> val_9;
        var val_10;
        BattleEnhancerCollection.<>c__DisplayClass22_0 val_1 = new BattleEnhancerCollection.<>c__DisplayClass22_0();
        val_8 = val_1;
        .type = type;
        BattleEnhancerCollection val_2 = BattleEnhancerCollection.instance;
        val_9 = val_2.items;
        if((val_9.Find(match:  new System.Predicate<BattleEnhancerAssets>(object:  val_1, method:  System.Boolean BattleEnhancerCollection.<>c__DisplayClass22_0::<GetIsDebuffType>b__0(BattleEnhancerCollection.BattleEnhancerAssets x)))) != null)
        {
                var val_5 = (val_4.isDebuffType == true) ? 1 : 0;
            return (bool)val_10;
        }
        
        val_9 = .type.ToString();
        .type.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  public BattleEnhancerAssets System.Collections.Generic.List<BattleEnhancerAssets>::Find(System.Predicate<T> match), drivenProperties:  public System.Void System.Predicate<BattleEnhancerAssets>::.ctor(object object, IntPtr method));
        mem[1152921528864729088] = null;
        val_8 = "Cannot find battle enhancer by type: "("Cannot find battle enhancer by type: ") + val_9;
        UnityEngine.Debug.LogError(message:  val_8);
        val_10 = 0;
        return (bool)val_10;
    }
    public static BattleEnhancerCollection.BattleEnhancerPriceData GetPriceData(InkWars.Model.BattleEnhancerType type, int aNewLevel, int count)
    {
        InkWars.Model.BattleEnhancerType val_8;
        var val_9;
        var val_10;
        int val_11;
        BattleEnhancerCollection.<>c__DisplayClass23_0 val_1 = new BattleEnhancerCollection.<>c__DisplayClass23_0();
        if(val_1 != null)
        {
                val_8 = val_1;
            .type = type;
            val_9 = 1152921528864909696;
            mem[1152921528864909700] = aNewLevel;
        }
        else
        {
                val_8 = 16;
            mem[16] = type;
            val_9 = val_1;
            .aNewLevel = aNewLevel;
        }
        
        .count = count;
        BattleEnhancerCollection val_2 = BattleEnhancerCollection.instance;
        val_10 = val_2.priceList.Find(match:  new System.Predicate<BattleEnhancerPriceData>(object:  val_1, method:  System.Boolean BattleEnhancerCollection.<>c__DisplayClass23_0::<GetPriceData>b__0(BattleEnhancerCollection.BattleEnhancerPriceData x)));
        if(val_10 != null)
        {
                return (BattleEnhancerPriceData)val_10;
        }
        
        BattleEnhancerCollection.BattleEnhancerPriceData val_5 = null;
        val_10 = val_5;
        val_5 = new BattleEnhancerCollection.BattleEnhancerPriceData();
        if(val_10 != null)
        {
                .enhancerType = val_8;
            val_11 = .aNewLevel;
        }
        else
        {
                mem[16] = val_8;
            val_11 = .aNewLevel;
        }
        
        .level = val_11;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  99999);
        .price = val_6;
        mem[1152921528864930212] = val_6.fakeValue;
        mem[1152921528864930216] = val_6.inited;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  1);
        .count = val_7;
        mem[1152921528864930192] = val_7.fakeValue;
        mem[1152921528864930196] = val_7.inited;
        .currency = 0;
        return (BattleEnhancerPriceData)val_10;
    }
    public static System.Collections.Generic.List<BattleEnhancerCollection.BattleEnhancerPriceData> GetAllPriceDataByType(InkWars.Model.BattleEnhancerType type)
    {
        var val_6;
        .type = type;
        BattleEnhancerCollection val_2 = BattleEnhancerCollection.instance;
        val_6 = val_2.priceList.FindAll(match:  new System.Predicate<BattleEnhancerPriceData>(object:  new BattleEnhancerCollection.<>c__DisplayClass24_0(), method:  System.Boolean BattleEnhancerCollection.<>c__DisplayClass24_0::<GetAllPriceDataByType>b__0(BattleEnhancerCollection.BattleEnhancerPriceData x)));
        if(val_6 != null)
        {
                return (System.Collections.Generic.List<BattleEnhancerPriceData>)val_6;
        }
        
        System.Collections.Generic.List<BattleEnhancerPriceData> val_5 = null;
        val_6 = val_5;
        val_5 = new System.Collections.Generic.List<BattleEnhancerPriceData>();
        return (System.Collections.Generic.List<BattleEnhancerPriceData>)val_6;
    }
    public BattleEnhancerCollection()
    {
        this.items = new System.Collections.Generic.List<BattleEnhancerAssets>();
        this.buttonBGList = new System.Collections.Generic.List<BattleEnhancerButtonBG>();
        this.bubbleBGList = new System.Collections.Generic.List<BattleEnhancerChatBubbleBG>();
        this.sfxList = new System.Collections.Generic.List<BattleEnhancerSFX>();
        this.priceList = new System.Collections.Generic.List<BattleEnhancerPriceData>();
    }
    private static BattleEnhancerCollection()
    {
    
    }

}
