using UnityEngine;
public class RatioRepositionRescale : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector3 TabletPosition;
    private UnityEngine.Vector3 TabletScale;
    
    // Methods
    private void Awake()
    {
        float val_5 = (float)UnityEngine.Screen.width;
        val_5 = val_5 / (float)UnityEngine.Screen.height;
        if(val_5 >= 1.5f)
        {
                return;
        }
        
        if((double)val_5 >= 1.7)
        {
                return;
        }
        
        this.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = this.TabletScale, y = V9.16B, z = V10.16B};
        this.GetComponent<UnityEngine.RectTransform>().localPosition = new UnityEngine.Vector3() {x = this.TabletPosition, y = V9.16B, z = V10.16B};
    }
    public RatioRepositionRescale()
    {
        this.TabletPosition = 0;
        mem[1152921528743427760] = 0;
        this.TabletScale = 0;
        mem[1152921528743427772] = 0;
    }

}
