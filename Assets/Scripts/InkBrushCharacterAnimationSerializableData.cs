using UnityEngine;
[Serializable]
public class InkBrushCharacterAnimationSerializableData : ScriptableObject
{
    // Fields
    public UnityEngine.Sprite Sprite;
    public bool ComesFromTopRight;
    public UnityEngine.Vector2 InitialLocation;
    public UnityEngine.Vector2 MiddleLocation;
    public UnityEngine.Vector2 Scale;
    public UnityEngine.Vector2 FinalLocation;
    public bool FlipHorizontally;
    
    // Properties
    public UnityEngine.Vector3 GetScale { get; }
    
    // Methods
    private void Awake()
    {
        float val_4;
        if(this.ComesFromTopRight != false)
        {
                UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  1500f, y:  1000f);
            val_4 = val_1.y;
            this.InitialLocation = val_1.x;
            mem[1152921528545026456] = val_4;
        }
        else
        {
                UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  -1500f, y:  -1000f);
            UnityEngine.Vector2 val_3;
            this.InitialLocation = val_2.x;
            mem[1152921528545026456] = val_2.y;
        }
        
        val_3 = new UnityEngine.Vector2(x:  -200f, y:  -600f);
        this.MiddleLocation = val_3.x;
        mem[1152921528545026464] = val_3.y;
    }
    public UnityEngine.Vector3 get_GetScale()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.Scale, y = V8.16B});
        val_1.x = val_1.x * ((this.FlipHorizontally == true) ? -1f : 1f);
        return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    public InkBrushCharacterAnimationSerializableData()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.one;
        this.Scale = val_1;
        mem[1152921528545250472] = val_1.y;
    }

}
