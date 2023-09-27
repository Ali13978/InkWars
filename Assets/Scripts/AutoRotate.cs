using UnityEngine;
public class AutoRotate : MonoBehaviour
{
    // Fields
    public bool step;
    public float angle;
    public float speed;
    private UnityEngine.RectTransform rt;
    private float timer;
    
    // Methods
    private void Awake()
    {
        this.rt = this.GetComponent<UnityEngine.RectTransform>();
    }
    private void Update()
    {
        float val_6;
        if(this.step != false)
        {
                float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.timer + val_1;
            this.timer = val_1;
            if(val_1 <= this.speed)
        {
                return;
        }
        
            val_6 = this.angle;
            val_1 = val_1 - this.speed;
            this.timer = val_1;
            if(this.rt != null)
        {
            goto label_3;
        }
        
        }
        else
        {
                val_6 = UnityEngine.Time.deltaTime;
        }
        
        label_3:
        this.rt.Rotate(xAngle:  0f, yAngle:  0f, zAngle:  (this.angle * this.speed) * val_6);
    }
    public AutoRotate()
    {
        this.speed = 1f;
    }

}
