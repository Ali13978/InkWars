using UnityEngine;
public class MoveToPointLoop : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector3 PosToMoveTo;
    public UnityEngine.Vector3 PosToTeleportBackTo;
    public float speed;
    
    // Methods
    private void Start()
    {
        UnityEngine.Vector3 val_2 = this.GetComponent<UnityEngine.RectTransform>().localPosition;
        this.PosToMoveTo = val_2;
        mem[1152921528543937436] = val_2.y;
        mem[1152921528543937440] = val_2.z;
    }
    private void Update()
    {
        var val_10;
        var val_11;
        float val_15;
        UnityEngine.Vector3 val_16;
        var val_17;
        var val_18;
        val_10 = this;
        val_11 = 1152921525069039472;
        UnityEngine.Vector3 val_2 = this.GetComponent<UnityEngine.RectTransform>().localPosition;
        val_15 = val_2.y;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = this.PosToMoveTo, y = V9.16B, z = V10.16B}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_15, z = val_2.z})) != false)
        {
                float val_10 = UnityEngine.Time.deltaTime;
            val_11 = this.GetComponent<UnityEngine.RectTransform>();
            val_10 = this.speed * val_10;
            UnityEngine.Vector3 val_7 = val_11.localPosition;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, target:  new UnityEngine.Vector3() {x = this.PosToMoveTo, y = val_15, z = val_2.x}, maxDistanceDelta:  val_10);
            val_16 = val_8.x;
            val_17 = val_8.y;
            val_18 = val_8.z;
            if((this.GetComponent<UnityEngine.RectTransform>()) != null)
        {
            goto label_9;
        }
        
        }
        else
        {
                val_16 = this.PosToTeleportBackTo;
            val_10 = this.GetComponent<UnityEngine.RectTransform>();
        }
        
        label_9:
        val_10.localPosition = new UnityEngine.Vector3() {x = val_16, y = V9.16B, z = V10.16B};
    }
    public MoveToPointLoop()
    {
        this.speed = 100f;
    }

}
