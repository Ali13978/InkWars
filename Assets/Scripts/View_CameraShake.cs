using UnityEngine;
public class View_CameraShake : MonoBehaviour
{
    // Fields
    public UnityEngine.RectTransform BasesTransform_Left;
    public UnityEngine.RectTransform BasesTransform_Right;
    private UnityEngine.Transform cameraTransform;
    public bool shakeActive;
    private float shakeIntensity;
    private float shakeIntensityScaler;
    private float shakeTime;
    private float shakeDecreaseFactor;
    private UnityEngine.Vector3 OriginalPos_Camera;
    private UnityEngine.Vector3 OriginalPos_BasesLeft;
    private UnityEngine.Vector3 OriginalPos_BasesRight;
    private UnityEngine.Vector3 ShakeOffset;
    
    // Methods
    public void CameraShake_Set(float intensity, float time)
    {
        intensity = this.shakeIntensityScaler * intensity;
        this.shakeIntensity = intensity;
        if(this.shakeActive != true)
        {
                UnityEngine.Transform val_2 = UnityEngine.Camera.main.transform;
            this.cameraTransform = val_2;
            UnityEngine.Vector3 val_3 = val_2.position;
            this.OriginalPos_Camera = val_3;
            mem[1152921528340272328] = val_3.y;
            mem[1152921528340272332] = val_3.z;
            UnityEngine.Vector3 val_4 = this.BasesTransform_Left.position;
            this.OriginalPos_BasesLeft = val_4;
            mem[1152921528340272340] = val_4.y;
            mem[1152921528340272344] = val_4.z;
            UnityEngine.Vector3 val_5 = this.BasesTransform_Right.position;
            this.OriginalPos_BasesRight = val_5;
            mem[1152921528340272352] = val_5.y;
            mem[1152921528340272356] = val_5.z;
        }
        
        this.shakeTime = time;
        this.shakeActive = true;
    }
    private void LateUpdate()
    {
        if(this.shakeActive == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.OriginalPos_Camera, y = V9.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = this.ShakeOffset, y = V10.16B, z = V11.16B});
        this.cameraTransform.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    private void FixedUpdate()
    {
        UnityEngine.RectTransform val_7;
        UnityEngine.Vector3 val_8;
        var val_9;
        var val_10;
        if(this.shakeActive == false)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_1 * this.shakeDecreaseFactor;
        val_1 = this.shakeTime - val_1;
        this.shakeTime = val_1;
        if(val_1 <= 0f)
        {
            goto label_2;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Random.insideUnitSphere;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  this.shakeIntensity);
        this.ShakeOffset = val_3;
        mem[1152921528340533228] = val_3.y;
        mem[1152921528340533232] = val_3.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.OriginalPos_BasesLeft, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.BasesTransform_Left.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        val_7 = this.BasesTransform_Right;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.OriginalPos_BasesRight, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = this.ShakeOffset, y = val_3.y, z = val_3.z});
        val_8 = val_5.x;
        val_9 = val_5.y;
        val_10 = val_5.z;
        if(val_7 != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_2:
        val_7 = this.cameraTransform;
        val_8 = this.OriginalPos_Camera;
        this.shakeActive = false;
        if(val_7 != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        val_7.position = new UnityEngine.Vector3() {x = val_8, y = V9.16B, z = V10.16B};
    }
    public View_CameraShake()
    {
        this.shakeIntensityScaler = 0.2f;
        this.shakeDecreaseFactor = 1f;
    }

}
