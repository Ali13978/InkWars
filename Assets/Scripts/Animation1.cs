using UnityEngine;
public class Animation1 : MonoBehaviour
{
    // Fields
    public float angle;
    private float radianAngle;
    public float midX;
    public float midY;
    public float radius;
    
    // Methods
    private void Start()
    {
        float val_1 = this.angle;
        val_1 = val_1 * 0.01745329f;
        this.radianAngle = val_1;
    }
    private void Update()
    {
        float val_8 = this.angle;
        val_8 = val_8 * 0.01745329f;
        this.radianAngle = val_8;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  this.midX + (this.radius * this.radianAngle), y:  this.midY + (this.radius * this.radianAngle));
        UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        this.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    public Animation1()
    {
    
    }

}
