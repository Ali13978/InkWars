using UnityEngine;
public class FontSubStyleCollection : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<FontSubStyleCollection.FontSubStyleData> items;
    public System.Collections.Generic.List<SDFStyleData> presets;
    private static FontSubStyleCollection _inst;
    
    // Properties
    private static FontSubStyleCollection instance { get; }
    
    // Methods
    private static FontSubStyleCollection get_instance()
    {
        var val_3;
        FontSubStyleCollection val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = FontSubStyleCollection._inst;
        if(0 == val_4)
        {
                val_5 = null;
            val_4 = UnityEngine.Resources.Load<FontSubStyleCollection>(path:  "FontSubStyleCollection");
            val_5 = null;
            FontSubStyleCollection._inst = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (FontSubStyleCollection)FontSubStyleCollection._inst;
    }
    public static UnityEngine.Material GetMaterial(FontSubStyle style)
    {
        UnityEngine.Material val_5;
        .style = style;
        FontSubStyleCollection val_2 = FontSubStyleCollection.instance;
        if((val_2.items.Find(match:  new System.Predicate<FontSubStyleData>(object:  new FontSubStyleCollection.<>c__DisplayClass6_0(), method:  System.Boolean FontSubStyleCollection.<>c__DisplayClass6_0::<GetMaterial>b__0(FontSubStyleCollection.FontSubStyleData x)))) == null)
        {
                return val_5;
        }
        
        val_5 = val_4.fontMaterial;
        return val_5;
    }
    public static SDFStyleData GetMaterialData(FontSubStyle style)
    {
        .style = style;
        FontSubStyleCollection val_2 = FontSubStyleCollection.instance;
        System.Predicate<SDFStyleData> val_3 = 1152921505096835072;
        val_3 = new System.Predicate<SDFStyleData>(object:  new FontSubStyleCollection.<>c__DisplayClass7_0(), method:  System.Boolean FontSubStyleCollection.<>c__DisplayClass7_0::<GetMaterialData>b__0(SDFStyleData x));
        if(val_2.presets != null)
        {
                return val_2.presets.Find(match:  val_3);
        }
        
        return val_2.presets.Find(match:  val_3);
    }
    public FontSubStyleCollection()
    {
        this.items = new System.Collections.Generic.List<FontSubStyleData>();
        this.presets = new System.Collections.Generic.List<SDFStyleData>();
    }
    private static FontSubStyleCollection()
    {
    
    }

}
