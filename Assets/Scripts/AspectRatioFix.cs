using UnityEngine;
public class AspectRatioFix : MonoBehaviour
{
    // Fields
    private const float aspectScaler = 1.122807;
    public UnityEngine.Vector3 nudge;
    public bool isPlayerBubble;
    public int ringIndex;
    public int ringId;
    public UnityEngine.GameObject anchoredObject;
    public bool FlipFix;
    private UnityEngine.Animation animation;
    private UnityEngine.RectTransform rt;
    private UnityEngine.Camera canvasCamera;
    public AspectRatioFix.AspectRatioFixTypes FixType;
    
    // Methods
    private void Start()
    {
        var val_34;
        float val_35;
        float val_43;
        UnityEngine.Vector3 val_44;
        float val_45;
        float val_46;
        float val_47;
        this.canvasCamera = UnityEngine.GameObject.Find(name:  "Canvas-Camera").GetComponent<UnityEngine.Camera>();
        this.animation = this.GetComponent<UnityEngine.Animation>();
        this.rt = this.GetComponent<UnityEngine.RectTransform>();
        val_34 = null;
        val_34 = null;
        val_35 = InstanceAnimator.UniversalX;
        if(this.FixType <= 5)
        {
                var val_34 = 40828080 + (this.FixType) << 2;
            val_34 = val_34 + 40828080;
        }
        else
        {
                val_44 = this.nudge;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.one;
            val_45 = ;
            val_46 = val_20.z;
            val_47 = 3.56f;
            if((val_35 == val_47) && ((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_44, y = val_45, z = val_46}, rhs:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z})) != false))
        {
                UnityEngine.Transform val_25 = this.transform;
            UnityEngine.Vector3 val_26 = val_25.localPosition;
            val_35 = this.nudge;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = val_35, y = val_10.z, z = val_44});
            val_43 = val_27.x;
            val_44 = val_27.z;
            val_47 = val_43;
            val_45 = val_27.y;
            val_46 = val_44;
            val_25.localPosition = new UnityEngine.Vector3() {x = val_47, y = val_45, z = val_46};
        }
        
            if(this.FlipFix == false)
        {
                return;
        }
        
            UnityEngine.Vector3 val_29 = this.transform.localPosition;
            this.transform.localPosition = new UnityEngine.Vector3() {x = -val_29.x, y = val_29.y, z = val_29.z};
            UnityEngine.Vector3 val_32 = this.transform.localScale;
            this.transform.localScale = new UnityEngine.Vector3() {x = -val_32.x, y = val_32.y, z = val_32.z};
        }
    
    }
    private void LateUpdate()
    {
        AspectRatioFixTypes val_89 = this.FixType;
        val_89 = val_89 - 4;
        if(val_89 <= 5)
        {
                var val_90 = 40828104 + ((this.FixType - 4)) << 2;
            val_90 = val_90 + 40828104;
        }
        else
        {
                UnityEngine.Object.Destroy(obj:  this);
        }
    
    }
    public AspectRatioFix()
    {
    
    }

}
