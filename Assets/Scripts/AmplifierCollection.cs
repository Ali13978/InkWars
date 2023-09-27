using UnityEngine;
public class AmplifierCollection : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<AmplifierCollection.AmplifierTypeData> typeDataList;
    public System.Collections.Generic.List<AmplifierCollection.AmplifierPriceData> priceDataList;
    private static AmplifierCollection _inst;
    
    // Properties
    private static AmplifierCollection instance { get; }
    
    // Methods
    private static AmplifierCollection get_instance()
    {
        var val_3;
        AmplifierCollection val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = AmplifierCollection._inst;
        if(0 == val_4)
        {
                val_5 = null;
            val_4 = UnityEngine.Resources.Load<AmplifierCollection>(path:  "NetworkDataCollection/AmplifierCollection");
            val_5 = null;
            AmplifierCollection._inst = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (AmplifierCollection)AmplifierCollection._inst;
    }
    public static string GetName(InkWars.Model.BPAmplifierType type)
    {
        object val_7;
        System.Collections.Generic.List<AmplifierTypeData> val_8;
        string val_9;
        AmplifierCollection.<>c__DisplayClass7_0 val_1 = new AmplifierCollection.<>c__DisplayClass7_0();
        val_7 = val_1;
        .type = type;
        AmplifierCollection val_2 = AmplifierCollection.instance;
        val_8 = val_2.typeDataList;
        if((val_8.Find(match:  new System.Predicate<AmplifierTypeData>(object:  val_1, method:  System.Boolean AmplifierCollection.<>c__DisplayClass7_0::<GetName>b__0(AmplifierCollection.AmplifierTypeData x)))) != null)
        {
                val_9 = val_4.name;
            return (string)val_9;
        }
        
        val_8 = .type.ToString();
        .type.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  public AmplifierTypeData System.Collections.Generic.List<AmplifierTypeData>::Find(System.Predicate<T> match), drivenProperties:  public System.Void System.Predicate<AmplifierTypeData>::.ctor(object object, IntPtr method));
        mem[1152921528629555840] = null;
        val_7 = "Cannot find AmplifierTypeData with type " + val_8;
        UnityEngine.Debug.LogError(message:  val_7);
        val_9 = "";
        return (string)val_9;
    }
    public static UnityEngine.Sprite GetIcon(InkWars.Model.BPAmplifierType type)
    {
        object val_7;
        System.Collections.Generic.List<AmplifierTypeData> val_8;
        UnityEngine.Sprite val_9;
        AmplifierCollection.<>c__DisplayClass8_0 val_1 = new AmplifierCollection.<>c__DisplayClass8_0();
        val_7 = val_1;
        .type = type;
        AmplifierCollection val_2 = AmplifierCollection.instance;
        val_8 = val_2.typeDataList;
        if((val_8.Find(match:  new System.Predicate<AmplifierTypeData>(object:  val_1, method:  System.Boolean AmplifierCollection.<>c__DisplayClass8_0::<GetIcon>b__0(AmplifierCollection.AmplifierTypeData x)))) != null)
        {
                val_9 = val_4.icon;
            return (UnityEngine.Sprite)val_9;
        }
        
        val_8 = .type.ToString();
        .type.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  public AmplifierTypeData System.Collections.Generic.List<AmplifierTypeData>::Find(System.Predicate<T> match), drivenProperties:  public System.Void System.Predicate<AmplifierTypeData>::.ctor(object object, IntPtr method));
        mem[1152921528629746688] = null;
        val_7 = "Cannot find AmplifierTypeData with type " + val_8;
        UnityEngine.Debug.LogError(message:  val_7);
        val_9 = 0;
        return (UnityEngine.Sprite)val_9;
    }
    public static string GetDesc(InkWars.Model.BPAmplifierType type)
    {
        object val_7;
        System.Collections.Generic.List<AmplifierTypeData> val_8;
        string val_9;
        AmplifierCollection.<>c__DisplayClass9_0 val_1 = new AmplifierCollection.<>c__DisplayClass9_0();
        val_7 = val_1;
        .type = type;
        AmplifierCollection val_2 = AmplifierCollection.instance;
        val_8 = val_2.typeDataList;
        if((val_8.Find(match:  new System.Predicate<AmplifierTypeData>(object:  val_1, method:  System.Boolean AmplifierCollection.<>c__DisplayClass9_0::<GetDesc>b__0(AmplifierCollection.AmplifierTypeData x)))) != null)
        {
                val_9 = val_4.desc;
            return (string)val_9;
        }
        
        val_8 = .type.ToString();
        .type.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  public AmplifierTypeData System.Collections.Generic.List<AmplifierTypeData>::Find(System.Predicate<T> match), drivenProperties:  public System.Void System.Predicate<AmplifierTypeData>::.ctor(object object, IntPtr method));
        mem[1152921528629937536] = null;
        val_7 = "Cannot find AmplifierTypeData with type " + val_8;
        UnityEngine.Debug.LogError(message:  val_7);
        val_9 = "";
        return (string)val_9;
    }
    public static AmplifierCollection.AmplifierPriceData GetPriceData(InkWars.Model.BPAmplifierType type, int percentage)
    {
        var val_12;
        int val_13;
        UnityEngine.RectTransform val_14;
        var val_15;
        AmplifierCollection.<>c__DisplayClass10_0 val_1 = new AmplifierCollection.<>c__DisplayClass10_0();
        if(val_1 != null)
        {
                val_12 = val_1;
            .type = type;
        }
        else
        {
                val_12 = 16;
            mem[16] = type;
        }
        
        val_13 = val_1;
        .percentage = percentage;
        AmplifierCollection val_2 = AmplifierCollection.instance;
        val_14 = public AmplifierPriceData System.Collections.Generic.List<AmplifierPriceData>::Find(System.Predicate<T> match);
        val_15 = val_2.priceDataList.Find(match:  new System.Predicate<AmplifierPriceData>(object:  val_1, method:  System.Boolean AmplifierCollection.<>c__DisplayClass10_0::<GetPriceData>b__0(AmplifierCollection.AmplifierPriceData x)));
        if(val_15 != null)
        {
                return (AmplifierPriceData)val_15;
        }
        
        string[] val_5 = new string[5];
        if("Cannot find amplifier price with " == null)
        {
                val_14 = 0;
        }
        
        if(val_5.Length == 0)
        {
                val_14 = 0;
        }
        
        val_5[0] = "Cannot find amplifier price with ";
        mem[16].Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_14, drivenProperties:  public System.Void System.Predicate<AmplifierPriceData>::.ctor(object object, IntPtr method));
        mem[16] = null;
        val_5[1] = mem[16].ToString();
        val_5[2] = " ";
        val_5[3] = .percentage.ToString();
        val_5[4] = "%";
        UnityEngine.Debug.LogError(message:  +val_5);
        AmplifierCollection.AmplifierPriceData val_9 = null;
        val_15 = val_9;
        val_9 = new AmplifierCollection.AmplifierPriceData();
        .amplifierType = mem[16];
        val_13 = .percentage;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_13);
        .percent = val_10;
        mem[1152921528630179836] = val_10.fakeValue;
        mem[1152921528630179840] = val_10.inited;
        .currency = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_11 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  99999);
        .price = val_11;
        mem[1152921528630179852] = val_11.fakeValue;
        mem[1152921528630179856] = val_11.inited;
        return (AmplifierPriceData)val_15;
    }
    public AmplifierCollection()
    {
        this.typeDataList = new System.Collections.Generic.List<AmplifierTypeData>();
        this.priceDataList = new System.Collections.Generic.List<AmplifierPriceData>();
    }
    private static AmplifierCollection()
    {
    
    }

}
