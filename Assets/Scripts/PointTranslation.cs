using UnityEngine;
public class PointTranslation : MonoBehaviour
{
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  1f, y:  0f);
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, d:  UnityEngine.Time.deltaTime);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        this.transform.Translate(translation:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, relativeTo:  1);
    }
    private void OnCollisionEnter2D(UnityEngine.Collision2D other)
    {
        this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public PointTranslation()
    {
    
    }

}
