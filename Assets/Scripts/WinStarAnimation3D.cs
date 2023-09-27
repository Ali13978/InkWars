using UnityEngine;
public class WinStarAnimation3D : MonoBehaviour
{
    // Fields
    public static WinStarAnimation3D instance;
    public SeventyOneSquared.PDUnity starAnim1;
    public SeventyOneSquared.PDUnity starAnim2;
    
    // Methods
    private void Awake()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(0 == WinStarAnimation3D.instance)
        {
                val_3 = null;
            val_3 = null;
            WinStarAnimation3D.instance = this;
            return;
        }
        
        UnityEngine.Object.Destroy(obj:  this);
    }
    private void OnDestroy()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(this != WinStarAnimation3D.instance)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        WinStarAnimation3D.instance = 0;
    }
    public WinStarAnimation3D()
    {
    
    }
    private static WinStarAnimation3D()
    {
    
    }

}
