using UnityEngine;
[Serializable]
public class CharacterAnimationData
{
    // Fields
    public UnityEngine.UI.Image Image;
    private UnityEngine.Vector2 m_InitialLocation;
    private UnityEngine.Vector2 m_MiddleLocation;
    private UnityEngine.Vector2 m_FinalLocation;
    
    // Properties
    public bool IsNull { get; }
    public UnityEngine.RectTransform Transform { get; }
    public UnityEngine.Vector2 Position { get; set; }
    public UnityEngine.Vector2 InitialLocation { get; set; }
    public UnityEngine.Vector2 MiddleLocation { get; set; }
    public UnityEngine.Vector2 FinalLocation { get; set; }
    public UnityEngine.Vector3[] FinalPath { get; }
    public UnityEngine.Vector3[] OriginalPath { get; }
    
    // Methods
    public void DrawGizmos(UnityEngine.Color _gizmosColor)
    {
        UnityEngine.Gizmos.color = new UnityEngine.Color() {r = _gizmosColor.r, g = _gizmosColor.g, b = _gizmosColor.b, a = _gizmosColor.a};
        UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.m_InitialLocation, y = _gizmosColor.a});
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        UnityEngine.Gizmos.DrawCube(center:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, size:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.m_InitialLocation, y = val_3.y});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.m_MiddleLocation, y = val_7.y});
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, to:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.m_MiddleLocation, y = val_7.y});
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
        UnityEngine.Gizmos.DrawCube(center:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, size:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.m_MiddleLocation, y = val_13.y});
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.m_FinalLocation, y = val_17.y});
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, to:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        UnityEngine.Vector3 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.m_FinalLocation, y = val_17.y});
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.one;
        UnityEngine.Gizmos.DrawCube(center:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, size:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
    }
    public bool get_IsNull()
    {
        return UnityEngine.Object.op_Equality(x:  0, y:  this.Image);
    }
    public UnityEngine.RectTransform get_Transform()
    {
        if(0 == this.Image)
        {
                return 0;
        }
        
        if(this.Image != null)
        {
                return this.Image.rectTransform;
        }
        
        return this.Image.rectTransform;
    }
    public UnityEngine.Vector2 get_Position()
    {
        UnityEngine.RectTransform val_1 = this.Image.rectTransform;
        if(val_1 != null)
        {
                return val_1.anchoredPosition;
        }
        
        return val_1.anchoredPosition;
    }
    public void set_Position(UnityEngine.Vector2 value)
    {
        this.Image.rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = value.x, y = value.y};
    }
    public UnityEngine.Vector2 get_InitialLocation()
    {
        return new UnityEngine.Vector2() {x = this.m_InitialLocation};
    }
    public void set_InitialLocation(UnityEngine.Vector2 value)
    {
        this.m_InitialLocation = value;
        mem[1152921528563235132] = value.y;
    }
    public UnityEngine.Vector2 get_MiddleLocation()
    {
        return new UnityEngine.Vector2() {x = this.m_MiddleLocation};
    }
    public void set_MiddleLocation(UnityEngine.Vector2 value)
    {
        this.m_MiddleLocation = value;
        mem[1152921528563459140] = value.y;
    }
    public UnityEngine.Vector2 get_FinalLocation()
    {
        return new UnityEngine.Vector2() {x = this.m_FinalLocation};
    }
    public void set_FinalLocation(UnityEngine.Vector2 value)
    {
        this.m_FinalLocation = value;
        mem[1152921528563683148] = value.y;
    }
    public UnityEngine.Vector3[] get_FinalPath()
    {
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[2];
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.m_MiddleLocation, y = V8.16B});
        val_1[0] = val_2;
        val_1[0] = val_2.y;
        val_1[0] = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.m_FinalLocation, y = val_2.y});
        val_1[1] = val_3;
        val_1[1] = val_3.y;
        val_1[1] = val_3.z;
        return val_1;
    }
    public UnityEngine.Vector3[] get_OriginalPath()
    {
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[2];
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.m_MiddleLocation, y = V8.16B});
        val_1[0] = val_2;
        val_1[0] = val_2.y;
        val_1[0] = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.m_InitialLocation, y = val_2.y});
        val_1[1] = val_3;
        val_1[1] = val_3.y;
        val_1[1] = val_3.z;
        return val_1;
    }
    public CharacterAnimationData()
    {
    
    }

}
