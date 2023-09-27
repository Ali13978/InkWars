using UnityEngine;
public class FingerInkUpAnim : MonoBehaviour
{
    // Fields
    private float shakeAmount;
    private int repetitions;
    private int repetitionCounter;
    private UnityEngine.Vector3 correctPos;
    
    // Methods
    private void Start()
    {
        UnityEngine.Vector3 val_3 = this.gameObject.transform.localPosition;
        this.correctPos = val_3;
        mem[1152921526118304648] = val_3.y;
        mem[1152921526118304652] = val_3.z;
        this.shakeAmount = 200f;
        this.repetitions = 0;
        this.repetitionCounter = 0;
    }
    public void changeFingerPosition()
    {
        int val_7;
        var val_8;
        int val_9;
        val_7 = this.repetitions;
        if(val_7 != 0)
        {
                val_8 = this;
            val_9 = this.repetitionCounter;
        }
        else
        {
                val_7 = 1;
            int val_1 = UnityEngine.Random.Range(min:  1, max:  8);
            val_9 = 0;
            val_8 = this;
            this.repetitionCounter = val_9;
            this.repetitions = val_1;
        }
        
        if(val_9 == val_1)
        {
                UnityEngine.Vector3 val_4 = UnityEngine.Random.insideUnitSphere;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  this.shakeAmount);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.correctPos, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            this.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            this.repetitions = 0;
            return;
        }
        
        val_9 = val_9 + 1;
        this.repetitionCounter = val_9;
    }
    public FingerInkUpAnim()
    {
    
    }

}
