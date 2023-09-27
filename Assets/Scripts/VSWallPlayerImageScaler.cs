using UnityEngine;
public class VSWallPlayerImageScaler : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform playerAvatarImage;
    private UnityEngine.Vector3 originAvatarScale;
    
    // Methods
    private void Awake()
    {
        UnityEngine.RectTransform val_1 = this.GetComponent<UnityEngine.RectTransform>();
        this.playerAvatarImage = val_1;
        UnityEngine.Vector3 val_2 = val_1.localScale;
        this.originAvatarScale = val_2;
        mem[1152921529079226580] = val_2.y;
        mem[1152921529079226584] = val_2.z;
    }
    private void OnEnable()
    {
        float val_2 = UnityEngine.Camera.main.aspect;
        val_2 = val_2 / 1.33f;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.originAvatarScale, y = V8.16B, z = V9.16B}, d:  val_2 * 0.9f);
        this.playerAvatarImage.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public VSWallPlayerImageScaler()
    {
    
    }

}
