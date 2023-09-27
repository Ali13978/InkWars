using UnityEngine;
public class AimLineLengthAdapter : MonoBehaviour
{
    // Methods
    private void Start()
    {
        float val_17;
        var val_20;
        float val_19 = (float)UnityEngine.Screen.width;
        val_19 = val_19 / (float)UnityEngine.Screen.height;
        val_19 = val_19 + (-1.77f);
        val_19 = val_19 / 0.38833f;
        float val_4 = UnityEngine.Mathf.Lerp(a:  1f, b:  1.25f, t:  UnityEngine.Mathf.Clamp01(value:  val_19));
        UnityEngine.Vector3 val_6 = this.transform.localScale;
        val_17 = val_6.z;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_4 * val_6.x, y = val_6.y, z = val_17};
        System.Collections.IEnumerator val_10 = this.transform.GetEnumerator();
        goto label_16;
        label_23:
        var val_20 = 0;
        val_20 = val_20 + 1;
        object val_12 = val_10.Current;
        UnityEngine.Vector3 val_15 = 0.localScale;
        val_17 = val_15.z;
        val_15.x = val_15.x / val_4;
        0.localScale = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_17};
        label_16:
        var val_21 = 0;
        val_21 = val_21 + 1;
        if(val_10.MoveNext() == true)
        {
            goto label_23;
        }
        
        val_20 = 0;
        if(val_10 != null)
        {
                var val_22 = 0;
            val_22 = val_22 + 1;
            val_10.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public AimLineLengthAdapter()
    {
    
    }

}
