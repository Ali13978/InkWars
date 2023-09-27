using UnityEngine;
public class UpdateTransformPosition : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform m_TargetTransform;
    private UnityEngine.Vector3 m_TargetOffset;
    
    // Methods
    private void Start()
    {
        if(0 != this.m_TargetTransform)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this);
    }
    private void Update()
    {
        UnityEngine.Vector3 val_2 = this.m_TargetTransform.position;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.m_TargetOffset, y = V11.16B, z = V10.16B});
        this.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public UpdateTransformPosition()
    {
    
    }

}
