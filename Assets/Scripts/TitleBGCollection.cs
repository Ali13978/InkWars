using UnityEngine;
public class TitleBGCollection : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<TitleBGCollection.BGData> list;
    
    // Methods
    public UnityEngine.Sprite GetSpriteByType(Titles_BG_Type type)
    {
        UnityEngine.Sprite val_4;
        .type = type;
        if((this.list.Find(match:  new System.Predicate<BGData>(object:  new TitleBGCollection.<>c__DisplayClass2_0(), method:  System.Boolean TitleBGCollection.<>c__DisplayClass2_0::<GetSpriteByType>b__0(TitleBGCollection.BGData x)))) == null)
        {
                return val_4;
        }
        
        val_4 = val_3.image;
        return val_4;
    }
    public UnityEngine.Color GetColorByType(Titles_BG_Type type)
    {
        .type = type;
        if((this.list.Find(match:  new System.Predicate<BGData>(object:  new TitleBGCollection.<>c__DisplayClass3_0(), method:  System.Boolean TitleBGCollection.<>c__DisplayClass3_0::<GetColorByType>b__0(TitleBGCollection.BGData x)))) == null)
        {
                return UnityEngine.Color.clear;
        }
        
        return new UnityEngine.Color() {r = val_3.coverColor};
    }
    public TitleBGCollection()
    {
        this.list = new System.Collections.Generic.List<BGData>();
    }

}
