using UnityEngine;
public class BubblesCollection : ScriptableObject
{
    // Fields
    private static int m_id;
    private static BubblesCollection _inst;
    public System.Collections.Generic.List<BubblesCollection.BubblesData> list;
    private System.Collections.Generic.Dictionary<InkWars.Model.CustomizationTier, string> imageType;
    
    // Properties
    public static BubblesCollection instance { get; }
    
    // Methods
    public static BubblesCollection get_instance()
    {
        var val_3;
        BubblesCollection val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = BubblesCollection._inst;
        if(0 == val_4)
        {
                val_5 = null;
            val_4 = UnityEngine.Resources.Load<BubblesCollection>(path:  "NetworkDataCollection/BubblesCollection");
            val_5 = null;
            BubblesCollection._inst = val_4;
        }
        else
        {
                val_5 = null;
        }
        
        val_5 = null;
        return (BubblesCollection)BubblesCollection._inst;
    }
    public System.Collections.Generic.List<BubblesCollection.BubblesData> GetBubblsByTier(InkWars.Model.CustomizationTier tier)
    {
        var val_6;
        System.Collections.Generic.List<BubblesData> val_1 = new System.Collections.Generic.List<BubblesData>();
        val_6 = null;
        val_6 = null;
        if((BubblesCollection.<>c.<>9__7_0) == null)
        {
            goto label_3;
        }
        
        label_14:
        int val_2 = this.list.RemoveAll(match:  BubblesCollection.<>c.<>9__7_0);
        List.Enumerator<T> val_3 = this.list.GetEnumerator();
        label_10:
        if(((-2060907368) & 1) == 0)
        {
            goto label_6;
        }
        
        if(val_4._impl != tier)
        {
            goto label_10;
        }
        
        val_1.Add(item:  0.InitialType);
        goto label_10;
        label_3:
        BubblesCollection.<>c.<>9__7_0 = new System.Predicate<BubblesData>(object:  BubblesCollection.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BubblesCollection.<>c::<GetBubblsByTier>b__7_0(BubblesCollection.BubblesData x));
        if(this.list != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_6:
        0.Add(driver:  public System.Void List.Enumerator<BubblesData>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<BubblesData>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
        return val_1;
    }
    public BubblesCollection.BubblesData getBubblesByFamily(InkWars.Model.BubbleFamily family, bool returnNullForInvalidIds = False)
    {
        var val_7;
        var val_8;
        var val_10;
        val_7 = family;
        BubblesCollection.BubblesData val_1 = new BubblesCollection.BubblesData();
        if(val_1 != null)
        {
                .family = 0;
            .tier = ;
            .battleEnhancerOffer = 3;
        }
        else
        {
                mem[16] = 1;
            .level = 1;
            .family = 0;
            mem[24] = 0;
            .price = 9999;
            mem[32] = 1;
            .offerCount = 3;
        }
        
        .currency = 1;
        val_8 = null;
        val_8 = null;
        if((BubblesCollection.<>c.<>9__8_0) == null)
        {
            goto label_5;
        }
        
        label_15:
        int val_2 = this.list.RemoveAll(match:  BubblesCollection.<>c.<>9__8_0);
        List.Enumerator<T> val_3 = this.list.GetEnumerator();
        label_10:
        if(((-2060745192) & 1) == 0)
        {
            goto label_8;
        }
        
        val_10 = 0.InitialType;
        if((-2060745192) != val_7)
        {
            goto label_10;
        }
        
        0.Add(driver:  public System.Void List.Enumerator<BubblesData>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<BubblesData>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
        return (BubblesData)(returnNullForInvalidIds != true) ? 0 : (val_1);
        label_5:
        BubblesCollection.<>c.<>9__8_0 = new System.Predicate<BubblesData>(object:  BubblesCollection.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BubblesCollection.<>c::<getBubblesByFamily>b__8_0(BubblesCollection.BubblesData x));
        if(this.list != null)
        {
            goto label_15;
        }
        
        goto label_15;
        label_8:
        0.Add(driver:  public System.Void List.Enumerator<BubblesData>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<BubblesData>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
        return (BubblesData)(returnNullForInvalidIds != true) ? 0 : (val_1);
    }
    public UnityEngine.Sprite GetBubbleSpriteByFamilyAndType(InkWars.Model.BubbleFamily family, InkWars.Model.BubbleTypes type)
    {
        return this.GetBubbleSpriteByData(data:  this.getBubblesByFamily(family:  family, returnNullForInvalidIds:  false), type:  type);
    }
    public UnityEngine.Sprite GetBubbleSpriteByData(BubblesCollection.BubblesData data, InkWars.Model.BubbleTypes type)
    {
        var val_11;
        System.String[] val_12;
        UnityEngine.RectTransform val_14;
        UnityEngine.RectTransform val_15;
        UnityEngine.RectTransform val_16;
        val_11 = this;
        if(type > 6)
        {
                val_12 = type;
            type.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  type, drivenProperties:  null);
            string val_2 = "Bubbles/Special/Bubble Special - "("Bubbles/Special/Bubble Special - ") + type.ToString();
            return (UnityEngine.Sprite)UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  +val_3);
        }
        
        string[] val_3 = new string[8];
        val_12 = val_3;
        if(("Bubbles/") == null)
        {
                val_14 = 0;
        }
        
        if(val_3.Length == 0)
        {
                val_14 = 0;
        }
        
        val_12[0] = "Bubbles/";
        data.tier.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_14, drivenProperties:  null);
        mem2[0] = null;
        val_12[1] = data.tier.ToString();
        val_12[2] = "/";
        val_15 = public System.String System.Collections.Generic.Dictionary<InkWars.Model.CustomizationTier, System.String>::get_Item(InkWars.Model.CustomizationTier key);
        string val_5 = this.imageType.Item[data.tier];
        if((val_5 != null) && (val_5 == null))
        {
                val_15 = 0;
        }
        
        if(val_3.Length <= 3)
        {
                val_15 = 0;
        }
        
        val_12[3] = val_5;
        if(" " == null)
        {
                val_15 = 0;
        }
        
        if(val_3.Length <= 4)
        {
                val_15 = 0;
        }
        
        val_12[4] = " ";
        data.family.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_15, drivenProperties:  null);
        mem2[0] = null;
        val_16 = 32;
        string val_7 = data.family.ToString().Replace(oldChar:  '_', newChar:  ' ');
        if((val_7 != null) && (val_7 == null))
        {
                val_16 = 0;
        }
        
        if(val_3.Length <= 5)
        {
                val_16 = 0;
        }
        
        val_12[5] = val_7;
        if(" " == null)
        {
                val_16 = 0;
        }
        
        if(val_3.Length <= 6)
        {
                val_16 = 0;
        }
        
        val_12[6] = " ";
        val_11 = null;
        null.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_16, drivenProperties:  0);
        val_12[7] = null.ToString();
        return (UnityEngine.Sprite)UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  +val_3);
    }
    public BubblesCollection()
    {
        this.list = new System.Collections.Generic.List<BubblesData>();
        System.Collections.Generic.Dictionary<InkWars.Model.CustomizationTier, System.String> val_2 = new System.Collections.Generic.Dictionary<InkWars.Model.CustomizationTier, System.String>();
        if(val_2 != null)
        {
                val_2.Add(key:  1, value:  "Bubble Type 1 -");
        }
        else
        {
                val_2.Add(key:  1, value:  "Bubble Type 1 -");
        }
        
        val_2.Add(key:  2, value:  "Bubble Type 2 -");
        if(val_2 != null)
        {
                val_2.Add(key:  3, value:  "Bubble Type 3 -");
        }
        else
        {
                val_2.Add(key:  3, value:  "Bubble Type 3 -");
        }
        
        val_2.Add(key:  4, value:  "Bubble Type 4 -");
        if(val_2 != null)
        {
                val_2.Add(key:  5, value:  "Bubble Type 5 -");
        }
        else
        {
                val_2.Add(key:  5, value:  "Bubble Type 5 -");
        }
        
        val_2.Add(key:  6, value:  "Bubble Type 6 -");
        this.imageType = val_2;
    }
    private static BubblesCollection()
    {
    
    }

}
