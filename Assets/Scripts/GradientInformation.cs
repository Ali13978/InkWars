using UnityEngine;
[Serializable]
public class GradientInformation
{
    // Fields
    public UnityEngine.Color TopColor;
    public UnityEngine.Color BottomColor;
    public float Brightness;
    
    // Methods
    public GradientInformation()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.TopColor = val_1;
        mem[1152921528551005252] = val_1.g;
        mem[1152921528551005256] = val_1.b;
        mem[1152921528551005260] = val_1.a;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.BottomColor = val_2;
        mem[1152921528551005268] = val_2.g;
        mem[1152921528551005272] = val_2.b;
        mem[1152921528551005276] = val_2.a;
        this.Brightness = 1f;
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        this.BottomColor = val_3;
        mem[1152921528551005268] = val_3.g;
        mem[1152921528551005272] = val_3.b;
        mem[1152921528551005276] = val_3.a;
        this.TopColor = val_3;
        mem[1152921528551005252] = val_3.g;
        mem[1152921528551005256] = val_3.b;
        mem[1152921528551005260] = val_3.a;
        this.Brightness = 1f;
    }
    public void ApplyPropertiesToMaterial(UnityEngine.Material _material)
    {
        _material.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = this.TopColor, g = V9.16B, b = V10.16B, a = V11.16B});
        _material.SetColor(name:  "_Color2", value:  new UnityEngine.Color() {r = this.BottomColor, g = V9.16B, b = V10.16B, a = V11.16B});
        _material.SetFloat(name:  "_Brightness", value:  this.Brightness);
    }

}
