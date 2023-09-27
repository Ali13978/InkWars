using UnityEngine;
public class CameraShake : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform camTransform;
    public static float shake;
    public static float shakeAmount;
    public float decreaseFactor;
    private UnityEngine.Vector3 originalPos;
    
    // Methods
    private void Awake()
    {
        null = null;
        CameraShake.shakeAmount = 0.5f;
        CameraShake.shake = 1.5f;
        this.decreaseFactor = 1f;
    }
    private void OnEnable()
    {
    
    }
    private void Update()
    {
        var val_9;
        var val_11;
        if(this.camTransform == 0)
        {
                UnityEngine.Transform val_3 = UnityEngine.Camera.main.transform;
            this.camTransform = val_3;
            UnityEngine.Vector3 val_4 = val_3.localPosition;
            this.originalPos = val_4;
            mem[1152921526223448312] = val_4.y;
            mem[1152921526223448316] = val_4.z;
        }
        
        val_9 = null;
        val_9 = null;
        if(CameraShake.shake > 0f)
        {
                UnityEngine.Vector3 val_5 = UnityEngine.Random.insideUnitSphere;
            val_11 = null;
            val_11 = null;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  CameraShake.shakeAmount);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.originalPos, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            this.camTransform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            float val_8 = UnityEngine.Time.deltaTime;
            val_8 = val_8 * this.decreaseFactor;
            val_8 = CameraShake.shake - val_8;
            CameraShake.shake = val_8;
            return;
        }
        
        CameraShake.shake = 0f;
        this.camTransform.localPosition = new UnityEngine.Vector3() {x = this.originalPos, y = V9.16B, z = V10.16B};
    }
    public CameraShake()
    {
        this.decreaseFactor = 1f;
    }
    private static CameraShake()
    {
        CameraShake.shake = 1.5f;
        CameraShake.shakeAmount = 0.5f;
    }

}
