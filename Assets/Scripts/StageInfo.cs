using UnityEngine;
public class StageInfo : GameItemInfo<StageData, UnityEngine.Sprite>
{
    // Properties
    protected override string resourcePath { get; }
    
    // Methods
    protected override string get_resourcePath()
    {
        return "GameData/StageData.json";
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
                return DataStructs.UserDataDictionary.Items.IsStageUnlock(id:  uniqueId);
        }
        
        return DataStructs.UserDataDictionary.Items.IsStageUnlock(id:  uniqueId);
    }
    public StageData GetStageDataByLevelId(int levelId)
    {
        .levelId = levelId;
        GameItemInfo.GameItemCollection<DataType, AssetType> val_2 = this.data;
        if(val_2 != null)
        {
                return val_2.Find(match:  new System.Predicate<StageData>(object:  new StageInfo.<>c__DisplayClass3_0(), method:  System.Boolean StageInfo.<>c__DisplayClass3_0::<GetStageDataByLevelId>b__0(StageData x)));
        }
        
        return val_2.Find(match:  new System.Predicate<StageData>(object:  new StageInfo.<>c__DisplayClass3_0(), method:  System.Boolean StageInfo.<>c__DisplayClass3_0::<GetStageDataByLevelId>b__0(StageData x)));
    }
    public StageInfo()
    {
    
    }

}
