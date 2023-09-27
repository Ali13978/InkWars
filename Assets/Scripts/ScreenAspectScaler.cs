using UnityEngine;
public class ScreenAspectScaler : MonoBehaviour
{
    // Fields
    public float scaleAtIPhoneX;
    public float scaleAt16By9;
    public float scaleAt4By3;
    
    // Methods
    private void Start()
    {
        float val_8;
        float val_9;
        float val_10;
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        val_8 = 1.333333f;
        val_9 = (float)UnityEngine.Screen.width;
        val_10 = (float)UnityEngine.Screen.height;
        float val_3 = val_9 / val_10;
        if(val_3 >= 0)
        {
            goto label_1;
        }
        
        val_11 = this.scaleAt4By3;
        goto label_10;
        label_1:
        if(val_3 >= 0)
        {
            goto label_3;
        }
        
        val_13 = this.scaleAt16By9;
        val_12 = this.scaleAt4By3;
        val_14 = -1.333333f;
        val_15 = 0.4444444f;
        goto label_6;
        label_3:
        val_8 = 2.165333f;
        if(val_3 >= 0)
        {
            goto label_7;
        }
        
        val_13 = this.scaleAtIPhoneX;
        val_12 = this.scaleAt16By9;
        val_14 = -1.777778f;
        val_15 = 0.3875555f;
        label_6:
        val_14 = val_3 + val_14;
        val_10 = val_14 / val_15;
        val_8 = val_12;
        val_9 = val_13;
        val_11 = UnityEngine.Mathf.Lerp(a:  val_8, b:  val_9, t:  val_10);
        goto label_10;
        label_7:
        val_11 = this.scaleAtIPhoneX;
        label_10:
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  val_11);
        this.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    public ScreenAspectScaler()
    {
        this.scaleAtIPhoneX = 1f;
        this.scaleAt16By9 = 1f;
        this.scaleAt4By3 = 1f;
    }

}
