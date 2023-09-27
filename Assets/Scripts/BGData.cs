using UnityEngine;
[Serializable]
public class TitleBGCollection.BGData
{
    // Fields
    public Titles_BG_Type type;
    public UnityEngine.Sprite image;
    public UnityEngine.Color coverColor;
    
    // Methods
    public TitleBGCollection.BGData()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.clear;
        this.coverColor = val_1;
        mem[1152921528322720916] = val_1.g;
        mem[1152921528322720920] = val_1.b;
        mem[1152921528322720924] = val_1.a;
    }

}
