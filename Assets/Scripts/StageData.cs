using UnityEngine;
[Serializable]
public class StageData : GameItemData
{
    // Fields
    public int levelId;
    public string subSpriteName;
    
    // Methods
    public UnityEngine.Sprite LoadStageSprite()
    {
        System.Collections.Generic.List<UnityEngine.Sprite> val_4 = new System.Collections.Generic.List<UnityEngine.Sprite>();
        val_4.AddRange(collection:  UnityEngine.Resources.LoadAll<UnityEngine.Sprite>(path:  GamePath.AssetPathToResourcePath(assetPath:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  static_value_03330000))));
        if(val_4 != null)
        {
                return val_4.Find(match:  new System.Predicate<UnityEngine.Sprite>(object:  this, method:  System.Boolean StageData::<LoadStageSprite>b__2_0(UnityEngine.Sprite x)));
        }
        
        return val_4.Find(match:  new System.Predicate<UnityEngine.Sprite>(object:  this, method:  System.Boolean StageData::<LoadStageSprite>b__2_0(UnityEngine.Sprite x)));
    }
    public StageData()
    {
    
    }
    private bool <LoadStageSprite>b__2_0(UnityEngine.Sprite x)
    {
        return System.String.op_Equality(a:  x.name, b:  this.subSpriteName);
    }

}
