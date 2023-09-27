using UnityEngine;
public class Rotate : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector3 angle;
    
    // Methods
    private void Start()
    {
        UnityEngine.Vector3 val_2 = this.transform.eulerAngles;
        this.angle = val_2;
        mem[1152921529123632636] = val_2.y;
        mem[1152921529123632640] = val_2.z;
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_1 * 100f;
        val_1 = S8 + val_1;
        mem[1152921529123752828] = val_1;
        this.transform.eulerAngles = new UnityEngine.Vector3() {x = this.angle, y = V9.16B, z = V10.16B};
    }
    public Rotate()
    {
    
    }

}
