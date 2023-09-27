using UnityEngine;
public class RatioRectTransformAdjuster : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector3 TabletPosition;
    private UnityEngine.Vector2 TabletWidthHeight;
    
    // Methods
    private void Start()
    {
        if((double)UnityEngine.Camera.main.aspect >= 1.7)
        {
                return;
        }
        
        if(UnityEngine.Camera.main.aspect >= 1.5f)
        {
                return;
        }
        
        this.GetComponent<UnityEngine.RectTransform>().sizeDelta = new UnityEngine.Vector2() {x = this.TabletWidthHeight, y = V9.16B};
        this.GetComponent<UnityEngine.RectTransform>().localPosition = new UnityEngine.Vector3() {x = this.TabletPosition, y = V9.16B, z = V10.16B};
    }
    public RatioRectTransformAdjuster()
    {
        this.TabletPosition = 0;
        mem[1152921526344185840] = 0;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.TabletWidthHeight = val_1;
        mem[1152921526344185848] = val_1.y;
    }

}
