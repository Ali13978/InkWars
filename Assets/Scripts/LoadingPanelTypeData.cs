using UnityEngine;
[Serializable]
public class LoadingPanelTypeData
{
    // Fields
    public string name;
    public System.Collections.Generic.List<CharacterStatType> typeList;
    public System.Collections.Generic.List<UnityEngine.Sprite> typeTagList;
    public string info;
    public string strategy;
    public int skillLevel;
    public System.Collections.Generic.List<UnityEngine.Sprite> characterImageList;
    
    // Methods
    public LoadingPanelTypeData()
    {
        this.typeList = new System.Collections.Generic.List<CharacterStatType>();
        this.typeTagList = new System.Collections.Generic.List<UnityEngine.Sprite>();
        this.characterImageList = new System.Collections.Generic.List<UnityEngine.Sprite>();
    }

}
