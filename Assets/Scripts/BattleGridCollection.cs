using UnityEngine;
public class BattleGridCollection : ScriptableObject
{
    // Fields
    private static BattleGridCollection _inst;
    public System.Collections.Generic.List<BattleGridCollection.BGData> list;
    
    // Properties
    public static BattleGridCollection instance { get; }
    
    // Methods
    public static BattleGridCollection get_instance()
    {
        var val_3;
        BattleGridCollection val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = BattleGridCollection._inst;
        if(0 == val_4)
        {
                val_5 = null;
            val_4 = UnityEngine.Resources.Load<BattleGridCollection>(path:  "NetworkDataCollection/BattleGridCollection");
            val_5 = null;
            BattleGridCollection._inst = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (BattleGridCollection)BattleGridCollection._inst;
    }
    public System.Collections.Generic.List<BattleGridCollection.BGData> GetBattleGridsByTier(InkWars.Model.CustomizationTier type)
    {
        var val_6;
        System.Collections.Generic.List<BGData> val_1 = new System.Collections.Generic.List<BGData>();
        val_6 = null;
        val_6 = null;
        if((BattleGridCollection.<>c.<>9__5_0) == null)
        {
            goto label_3;
        }
        
        label_14:
        int val_2 = this.list.RemoveAll(match:  BattleGridCollection.<>c.<>9__5_0);
        List.Enumerator<T> val_3 = this.list.GetEnumerator();
        label_10:
        if(((-2062825544) & 1) == 0)
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
        BattleGridCollection.<>c.<>9__5_0 = new System.Predicate<BGData>(object:  BattleGridCollection.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattleGridCollection.<>c::<GetBattleGridsByTier>b__5_0(BattleGridCollection.BGData x));
        if(this.list != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_6:
        0.Add(driver:  public System.Void List.Enumerator<BGData>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<BGData>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
        return val_1;
    }
    public BattleGridCollection.BGData GetBattleGridByID(int _id, bool returnNullForInvalidIds = False)
    {
        InkWars.Model.BattleEnhancerType val_4;
        var val_5;
        BattleGridCollection.BGData val_1 = null;
        val_4 = 2;
        .battleEnhancerOffer = val_4;
        .offerCount = 5;
        .currency = 1;
        val_1 = new BattleGridCollection.BGData();
        if(val_1 != null)
        {
                .type = 4294967297;
            .image = "Battlegrid Type 1 - Default Blue";
            .price = ;
            .id = ;
            .battleEnhancerOffer = 21474836482;
        }
        else
        {
                mem[16] = 1;
            .level = 1;
            mem[24] = "Battlegrid Type 1 - Default Blue";
            .id = 0;
            mem[32] = 9999;
            .battleEnhancerOffer = val_4;
            .offerCount = 5;
        }
        
        .currency = 1;
        if((_id & 2147483648) == 0)
        {
                val_4 = this.list;
            if(val_4.Count > _id)
        {
                val_5 = this.list.Item[_id];
            return (BGData)val_5;
        }
        
        }
        
        if(returnNullForInvalidIds == false)
        {
                return (BGData)val_5;
        }
        
        val_5 = 0;
        return (BGData)val_5;
    }
    public int GetRandomBattleGridID()
    {
        var val_4 = null;
        if((BattleGridCollection.<>c.<>9__7_0) == null)
        {
            goto label_3;
        }
        
        label_9:
        int val_1 = this.list.RemoveAll(match:  BattleGridCollection.<>c.<>9__7_0);
        return UnityEngine.Random.Range(min:  0, max:  this.list.Count);
        label_3:
        BattleGridCollection.<>c.<>9__7_0 = new System.Predicate<BGData>(object:  BattleGridCollection.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattleGridCollection.<>c::<GetRandomBattleGridID>b__7_0(BattleGridCollection.BGData x));
        if(this.list != null)
        {
            goto label_9;
        }
        
        goto label_9;
    }
    public UnityEngine.Sprite GetBattleGridSpriteByID(int id)
    {
        BGData val_1 = this.GetBattleGridByID(_id:  id, returnNullForInvalidIds:  false);
        return val_1.GetBattleGridSpriteByData(data:  val_1);
    }
    public UnityEngine.Sprite GetBattleGridSpriteByData(BattleGridCollection.BGData data)
    {
        data.type.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        data.type = null;
        return UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "BattleGrid/"("BattleGrid/") + data.type.ToString() + "/"("/") + data.image);
    }
    public UnityEngine.Sprite GetBattleGridTileSpriteByID(int id)
    {
        BGData val_1 = this.GetBattleGridByID(_id:  id, returnNullForInvalidIds:  false);
        return val_1.GetBattleGridTileSpriteByData(data:  val_1);
    }
    public UnityEngine.Sprite GetBattleGridTileSpriteByData(BattleGridCollection.BGData data)
    {
        return UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "BattleGrid/Thumbnails/"("BattleGrid/Thumbnails/") + data.image + " CROPPED");
    }
    public BattleGridCollection()
    {
        this.list = new System.Collections.Generic.List<BGData>();
    }
    private static BattleGridCollection()
    {
    
    }

}
