using UnityEngine;
[Serializable]
public class SDFStyleData
{
    // Fields
    public FontSubStyle style;
    public float dilate;
    public float outlineThickness;
    public UnityEngine.Color outlineColor;
    
    // Methods
    public SDFStyleData()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.clear;
        this.outlineColor = val_1;
        mem[1152921526154495872] = val_1.g;
        mem[1152921526154495876] = val_1.b;
        mem[1152921526154495880] = val_1.a;
    }

}
