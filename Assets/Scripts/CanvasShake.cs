using UnityEngine;
public class CanvasShake : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform canvas_Transform;
    public static float shake;
    public static float shakeAmount;
    public float decreaseFactor;
    private UnityEngine.Vector3 originalPos;
    
    // Methods
    private void Awake()
    {
        null = null;
        CanvasShake.shake = 1.5f;
        CanvasShake.shakeAmount = 0.23f;
        this.decreaseFactor = 1f;
    }
    private void Update()
    {
        var val_10;
        var val_12;
        if(this.canvas_Transform == 0)
        {
                UnityEngine.GameObject val_2 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "instructionGameplay");
            if(0 == val_2)
        {
                return;
        }
        
            UnityEngine.Transform val_4 = val_2.GetComponent<UnityEngine.Transform>();
            this.canvas_Transform = val_4;
            UnityEngine.Vector3 val_5 = val_4.localPosition;
            this.originalPos = val_5;
            mem[1152921526223937384] = val_5.y;
            mem[1152921526223937388] = val_5.z;
        }
        
        val_10 = null;
        val_10 = null;
        if(CanvasShake.shake > 0f)
        {
                UnityEngine.Vector3 val_6 = UnityEngine.Random.insideUnitSphere;
            val_12 = null;
            val_12 = null;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  CanvasShake.shakeAmount);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.originalPos, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            this.canvas_Transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            float val_9 = UnityEngine.Time.deltaTime;
            val_9 = val_9 * this.decreaseFactor;
            val_9 = CanvasShake.shake - val_9;
            CanvasShake.shake = val_9;
            return;
        }
        
        CanvasShake.shake = 0f;
        this.canvas_Transform.localPosition = new UnityEngine.Vector3() {x = this.originalPos, y = V9.16B, z = V10.16B};
    }
    public CanvasShake()
    {
        this.decreaseFactor = 1f;
    }
    private static CanvasShake()
    {
        CanvasShake.shake = 1.5f;
        CanvasShake.shakeAmount = 0.23f;
    }

}
