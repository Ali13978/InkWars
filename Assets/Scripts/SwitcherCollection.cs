using UnityEngine;
public class SwitcherCollection : ScriptableObject
{
    // Fields
    private static SwitcherCollection _inst;
    public System.Collections.Generic.List<SwitcherCollection.SwitcherData> list;
    
    // Properties
    public static SwitcherCollection instance { get; }
    
    // Methods
    public static SwitcherCollection get_instance()
    {
        var val_3;
        SwitcherCollection val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = SwitcherCollection._inst;
        if(0 == val_4)
        {
                val_5 = null;
            val_4 = UnityEngine.Resources.Load<SwitcherCollection>(path:  "NetworkDataCollection/SwitcherCollection");
            val_5 = null;
            SwitcherCollection._inst = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (SwitcherCollection)SwitcherCollection._inst;
    }
    public System.Collections.Generic.List<SwitcherCollection.SwitcherData> GetSwitchersByTier(InkWars.Model.CustomizationTier type)
    {
        var val_6;
        System.Collections.Generic.List<SwitcherData> val_1 = new System.Collections.Generic.List<SwitcherData>();
        val_6 = null;
        val_6 = null;
        if((SwitcherCollection.<>c.<>9__5_0) == null)
        {
            goto label_3;
        }
        
        label_14:
        int val_2 = this.list.RemoveAll(match:  SwitcherCollection.<>c.<>9__5_0);
        List.Enumerator<T> val_3 = this.list.GetEnumerator();
        label_10:
        if(((-2055916152) & 1) == 0)
        {
            goto label_6;
        }
        
        if(val_4._impl != type)
        {
            goto label_10;
        }
        
        val_1.Add(item:  0.InitialType);
        goto label_10;
        label_3:
        SwitcherCollection.<>c.<>9__5_0 = new System.Predicate<SwitcherData>(object:  SwitcherCollection.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SwitcherCollection.<>c::<GetSwitchersByTier>b__5_0(SwitcherCollection.SwitcherData x));
        if(this.list != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_6:
        0.Add(driver:  public System.Void List.Enumerator<SwitcherData>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<SwitcherData>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
        return val_1;
    }
    public SwitcherCollection.SwitcherData GetSwitcherByID(int _id, bool returnNullForInvalidIds = False)
    {
        var val_4;
        SwitcherCollection.SwitcherData val_1 = null;
        .battleEnhancerOffer = 1;
        .offerCount = 3;
        .currency = 1;
        val_1 = new SwitcherCollection.SwitcherData();
        if(val_1 != null)
        {
                .type = 4294967297;
            .image = "Switcher Default";
            .id = ;
            .price = ;
            .battleEnhancerOffer = 12884901889;
        }
        else
        {
                mem[16] = 1;
            .level = 1;
            mem[24] = "Switcher Default";
            mem[32] = 0;
            .price = 9999;
            .battleEnhancerOffer = 1;
            .offerCount = 3;
        }
        
        .currency = 1;
        if((_id & 2147483648) == 0)
        {
                if(this.list.Count > _id)
        {
                val_4 = this.list.Item[_id];
            return (SwitcherData)val_4;
        }
        
        }
        
        if(returnNullForInvalidIds == false)
        {
                return (SwitcherData)val_4;
        }
        
        val_4 = 0;
        return (SwitcherData)val_4;
    }
    public UnityEngine.Sprite GetSwitcherSpriteByID(int id, int charATKLv = 1)
    {
        SwitcherData val_1 = this.GetSwitcherByID(_id:  id, returnNullForInvalidIds:  false);
        return val_1.GetSwitcherSpriteByData(data:  val_1, charATKLv:  charATKLv);
    }
    public int GetRandomSwitcherID()
    {
        var val_4 = null;
        if((SwitcherCollection.<>c.<>9__8_0) == null)
        {
            goto label_3;
        }
        
        label_9:
        int val_1 = this.list.RemoveAll(match:  SwitcherCollection.<>c.<>9__8_0);
        return UnityEngine.Random.Range(min:  0, max:  this.list.Count);
        label_3:
        SwitcherCollection.<>c.<>9__8_0 = new System.Predicate<SwitcherData>(object:  SwitcherCollection.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SwitcherCollection.<>c::<GetRandomSwitcherID>b__8_0(SwitcherCollection.SwitcherData x));
        if(this.list != null)
        {
            goto label_9;
        }
        
        goto label_9;
    }
    public UnityEngine.Sprite GetSwitcherSpriteByData(SwitcherCollection.SwitcherData data, int charATKLv = 1)
    {
        string val_7;
        string val_8;
        if(data != null)
        {
                val_7 = data;
            val_8 = data.image;
        }
        else
        {
                val_7 = 24;
            val_8 = 10260432;
        }
        
        if(data.id == 0)
        {
                string val_2 = UnityEngine.Mathf.Clamp(value:  charATKLv, min:  1, max:  4).ToString();
            val_8 = val_7 + " Lv" + val_2;
        }
        
        data.type.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_2, drivenProperties:  0);
        mem2[0] = null;
        return (UnityEngine.Sprite)UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "Switcher/"("Switcher/") + data.type.ToString() + "/"("/") + val_8);
    }
    public SwitcherCollection()
    {
        this.list = new System.Collections.Generic.List<SwitcherData>();
    }
    private static SwitcherCollection()
    {
    
    }

}
