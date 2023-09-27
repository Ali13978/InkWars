using UnityEngine;
public class autodel : MonoBehaviour
{
    // Methods
    private void Start()
    {
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  270f, y:  0f, z:  0f);
        this.gameObject.transform.rotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
        this.gameObject.GetComponent<UnityEngine.ParticleSystem>().GetComponent<UnityEngine.Renderer>().sortingOrder = 4;
        this.Invoke(methodName:  "destroythis", time:  4f);
    }
    private void Update()
    {
    
    }
    private void destroythis()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public autodel()
    {
    
    }

}
