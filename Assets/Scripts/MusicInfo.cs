using UnityEngine;
public class MusicInfo : GameItemInfo<MusicData, UnityEngine.AudioClip>
{
    // Properties
    protected override string resourcePath { get; }
    
    // Methods
    protected override string get_resourcePath()
    {
        return "GameData/MusicData.json";
    }
    public override bool IsOwnedItem(int uniqueId)
    {
        var val_2;
        if((this.IsOwnedItem(uniqueId:  uniqueId)) != false)
        {
                return true;
        }
        
        val_2 = null;
        val_2 = null;
        if(DataStructs.UserDataDictionary.Items != null)
        {
                return DataStructs.UserDataDictionary.Items.IsMusicUnlocked(id:  uniqueId);
        }
        
        return DataStructs.UserDataDictionary.Items.IsMusicUnlocked(id:  uniqueId);
    }
    public System.Collections.Generic.List<int> GetAllRandomBGMIds()
    {
        var val_10;
        var val_11;
        var val_13;
        var val_14;
        GameItemInfo.GameItemCollection<DataType, AssetType> val_1 = this.data;
        val_10 = 1152921505100242944;
        val_11 = null;
        val_11 = null;
        if((MusicInfo.<>c.<>9__3_0) == null)
        {
            goto label_4;
        }
        
        label_16:
        val_13 = val_1.FindAll(match:  MusicInfo.<>c.<>9__3_0);
        if(val_13 == null)
        {
            goto label_6;
        }
        
        System.Collections.Generic.List<System.Int32> val_3 = null;
        val_14 = val_3;
        val_3 = new System.Collections.Generic.List<System.Int32>();
        List.Enumerator<T> val_4 = val_13.GetEnumerator();
        val_10 = 1152921528400932624;
        label_12:
        if(((-1975687800) & 1) == 0)
        {
            goto label_7;
        }
        
        val_3.Add(item:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = X22, hiddenValue = X22, fakeValue = 0.InitialType, inited = 0.InitialType}));
        goto label_12;
        label_4:
        MusicInfo.<>c.<>9__3_0 = new System.Predicate<MusicData>(object:  MusicInfo.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MusicInfo.<>c::<GetAllRandomBGMIds>b__3_0(MusicData x));
        if(val_1 != null)
        {
            goto label_16;
        }
        
        goto label_16;
        label_7:
        0.Add(driver:  public System.Void List.Enumerator<MusicData>::Dispose(), rectTransform:  public System.Collections.Generic.List<T> System.Collections.Generic.List<MusicData>::FindAll(System.Predicate<T> match), drivenProperties:  null);
        if(val_3.Count != 0)
        {
                return (System.Collections.Generic.List<System.Int32>)val_14;
        }
        
        label_6:
        val_14 = this.GetAllDefaultItemIntBasedIds();
        return (System.Collections.Generic.List<System.Int32>)val_14;
    }
    public MusicInfo()
    {
    
    }

}
