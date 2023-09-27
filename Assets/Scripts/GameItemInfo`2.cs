using UnityEngine;
public abstract class GameItemInfo<DataType, AssetType>
{
    // Fields
    private GameItemInfo.GameItemCollection<DataType, AssetType> _data;
    
    // Properties
    protected abstract string resourcePath { get; }
    protected GameItemInfo.GameItemCollection<DataType, AssetType> data { get; }
    
    // Methods
    protected abstract string get_resourcePath(); // 0
    protected GameItemInfo.GameItemCollection<DataType, AssetType> get_data()
    {
        if(this != null)
        {
                return (GameItemInfo.GameItemCollection<DataType, AssetType>)val_1;
        }
        
        string val_1 = CMS.IO.ReadOnlyDataFile.Load(path:  this, type:  1);
        mem[1152921528391702464] = val_1;
        return (GameItemInfo.GameItemCollection<DataType, AssetType>)val_1;
    }
    public System.Collections.Generic.List<int> GetAllDefaultItemIntBasedIds()
    {
        var val_2;
        var val_3;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        val_10 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 24 + 294];
        val_10 = __RuntimeMethodHiddenParam + 24 + 192 + 24 + 294;
        if((val_10 & 1) == 0)
        {
                val_10 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 24 + 294];
            val_10 = __RuntimeMethodHiddenParam + 24 + 192 + 24 + 294;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 24 + 184 + 8) == 0)
        {
            goto label_9;
        }
        
        label_27:
        if(this == null)
        {
                return val_1;
        }
        
        label_17:
        if(((-1984836096) & 1) == 0)
        {
            goto label_12;
        }
        
        val_1.Add(item:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = __RuntimeMethodHiddenParam + 24 + 192 + 24 + 184 + 8, hiddenValue = __RuntimeMethodHiddenParam + 24 + 192 + 24 + 184 + 8, fakeValue = val_3.InitialType, inited = val_3.InitialType}));
        goto label_17;
        label_9:
        val_11 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 24 + 294];
        val_11 = __RuntimeMethodHiddenParam + 24 + 192 + 24 + 294;
        if((val_11 & 1) == 0)
        {
                val_11 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 24 + 294];
            val_11 = __RuntimeMethodHiddenParam + 24 + 192 + 24 + 294;
        }
        
        val_12 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_12 = __RuntimeMethodHiddenParam + 24 + 192;
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 24 + 294) & 1) == 0)
        {
                val_12 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_12 = __RuntimeMethodHiddenParam + 24 + 192;
        }
        
        mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 40;
        if(this != null)
        {
            goto label_27;
        }
        
        goto label_27;
        label_12:
        val_9 = 0;
        val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 96;
        val_2 = val_3;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 96 + 286) == 0)
        {
            goto label_37;
        }
        
        var val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 96 + 176;
        var val_8 = 0;
        val_7 = val_7 + 8;
        label_36:
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 96 + 176 + 8) + -8) == null)
        {
            goto label_35;
        }
        
        val_8 = val_8 + 1;
        val_7 = val_7 + 16;
        if(val_8 < (__RuntimeMethodHiddenParam + 24 + 192 + 96 + 286))
        {
            goto label_36;
        }
        
        goto label_37;
        label_35:
        val_13 = ((__RuntimeMethodHiddenParam + 24 + 192 + 96) + (((__RuntimeMethodHiddenParam + 24 + 192 + 96 + 176 + 8)) << 4)) + 296;
        label_37:
        val_3.Dispose();
        if( == 0)
        {
                return val_1;
        }
        
        return val_1;
    }
    public IAPItemIds GetIAPItemIds(int uniqueId)
    {
        mem2[0] = uniqueId;
        if(this == null)
        {
                return (IAPItemIds)this;
        }
        
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = __RuntimeMethodHiddenParam, hiddenValue = __RuntimeMethodHiddenParam, fakeValue = __RuntimeMethodHiddenParam + 24 + 192 + 104, inited = __RuntimeMethodHiddenParam + 24 + 192 + 104});
    }
    public int GetRandomDefaultIds()
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 24 + 294];
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 24 + 294;
        if((val_2 & 1) == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 24 + 294];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 24 + 294;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 24 + 184 + 16) == 0)
        {
            goto label_9;
        }
        
        label_26:
        System.Random val_1 = new System.Random();
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = -1984587696, hiddenValue = 268435461, fakeValue = -1984587696, inited = true});
        label_9:
        val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 24 + 294];
        val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 24 + 294;
        if((val_3 & 1) == 0)
        {
                val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 24 + 294];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 24 + 294;
        }
        
        val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_4 = __RuntimeMethodHiddenParam + 24 + 192;
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 24 + 294) & 1) == 0)
        {
                val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_4 = __RuntimeMethodHiddenParam + 24 + 192;
        }
        
        mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 40;
        if(this != null)
        {
            goto label_26;
        }
        
        goto label_26;
    }
    public bool IsDefaultId(int id)
    {
        mem2[0] = id;
        if(this == null)
        {
                return (bool)this;
        }
        
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = __RuntimeMethodHiddenParam + 24 + 192 + 160, hiddenValue = __RuntimeMethodHiddenParam + 24 + 192 + 160, fakeValue = __RuntimeMethodHiddenParam, fakeValueChanged = __RuntimeMethodHiddenParam, inited = __RuntimeMethodHiddenParam});
    }
    public int GetUniqueIdFromIapItemId(IAPItemIds iapId)
    {
        mem2[0] = iapId;
        if(this == null)
        {
                return (int)this;
        }
        
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = __RuntimeMethodHiddenParam + 24 + 192 + 184, hiddenValue = __RuntimeMethodHiddenParam + 24 + 192 + 184, fakeValue = __RuntimeMethodHiddenParam, inited = __RuntimeMethodHiddenParam});
    }
    public System.Collections.Generic.List<int> GetAllUniqueIds()
    {
        var val_2;
        var val_3;
        var val_8;
        var val_9;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        label_9:
        if(((-1984243296) & 1) == 0)
        {
            goto label_4;
        }
        
        val_1.Add(item:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = X22, hiddenValue = X22, fakeValue = val_3.InitialType, inited = val_3.InitialType}));
        goto label_9;
        label_4:
        val_8 = 0;
        val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 96;
        val_2 = val_3;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 96 + 286) == 0)
        {
            goto label_19;
        }
        
        var val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 96 + 176;
        var val_8 = 0;
        val_7 = val_7 + 8;
        label_18:
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 96 + 176 + 8) + -8) == null)
        {
            goto label_17;
        }
        
        val_8 = val_8 + 1;
        val_7 = val_7 + 16;
        if(val_8 < (__RuntimeMethodHiddenParam + 24 + 192 + 96 + 286))
        {
            goto label_18;
        }
        
        goto label_19;
        label_17:
        val_9 = ((__RuntimeMethodHiddenParam + 24 + 192 + 96) + (((__RuntimeMethodHiddenParam + 24 + 192 + 96 + 176 + 8)) << 4)) + 296;
        label_19:
        val_3.Dispose();
        if( == 0)
        {
                return val_1;
        }
        
        return val_1;
    }
    public virtual bool IsOwnedItem(int uniqueId)
    {
        if(this == null)
        {
            
        }
    
    }
    public System.Collections.Generic.List<DataType> GetAllPurchaseableItemData()
    {
        var val_1;
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        val_1 = __RuntimeMethodHiddenParam;
        val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 24 + 294];
        val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 24 + 294;
        if((val_3 & 1) == 0)
        {
                val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 24 + 294];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 24 + 294;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 24 + 184 + 24) == 0)
        {
            goto label_8;
        }
        
        label_19:
        val_2 = ???;
        val_1 = ???;
        goto __RuntimeMethodHiddenParam + 24 + 192 + 56;
        label_8:
        val_4 = mem[val_1 + 24 + 192 + 24 + 294];
        val_4 = val_1 + 24 + 192 + 24 + 294;
        if((val_4 & 1) == 0)
        {
                val_4 = mem[val_1 + 24 + 192 + 24 + 294];
            val_4 = val_1 + 24 + 192 + 24 + 294;
        }
        
        val_5 = mem[val_1 + 24 + 192];
        val_5 = val_1 + 24 + 192;
        if(((val_1 + 24 + 192 + 24 + 294) & 1) == 0)
        {
                val_5 = mem[val_1 + 24 + 192];
            val_5 = val_1 + 24 + 192;
        }
        
        mem2[0] = val_1 + 24 + 192 + 40;
        if(val_2 != 0)
        {
            goto label_19;
        }
        
        goto label_19;
    }
    public AssetType LoadResourceById(int uniqueId)
    {
        var val_9;
        var val_10;
        var val_11;
        val_9 = __RuntimeMethodHiddenParam;
        mem2[0] = uniqueId;
        val_11 = this;
        if(this == null)
        {
                return (UnityEngine.AudioClip)GamePath.AssetPathToResourcePath(assetPath:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  __RuntimeMethodHiddenParam + 24 + 192 + 224));
        }
        
        val_9 = ???;
        val_10 = ???;
        goto __RuntimeMethodHiddenParam + 24 + 192 + 248;
    }
    public DataType GetItemDataById(int uniqueId)
    {
        mem2[0] = uniqueId;
        if(this == null)
        {
            
        }
    
    }
    public System.Collections.Generic.List<DataType> GetAllAvailableItemData()
    {
        if(this == null)
        {
            
        }
    
    }
    public T LoadResourceByAssetPath<T>(string assetPath)
    {
        string val_1 = GamePath.AssetPathToResourcePath(assetPath:  assetPath);
        goto __RuntimeMethodHiddenParam + 48;
    }
    protected GameItemInfo<DataType, AssetType>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    private bool <GetAllAvailableItemData>b__16_0(DataType x)
    {
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = X22, hiddenValue = X22, fakeValue = false, fakeValueChanged = true, inited = true})) != false)
        {
                return true;
        }
        
        int val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 53694464, fakeValue = x, inited = x});
        if(this == null)
        {
            
        }
    
    }

}
