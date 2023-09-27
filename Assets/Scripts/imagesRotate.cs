using UnityEngine;
public class imagesRotate : MonoBehaviour
{
    // Fields
    public float rotationSpeed;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.forward;
        this.transform.Rotate(axis:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, angle:  this.rotationSpeed * UnityEngine.Time.deltaTime);
    }
    public imagesRotate()
    {
        this.rotationSpeed = -10f;
    }

}
