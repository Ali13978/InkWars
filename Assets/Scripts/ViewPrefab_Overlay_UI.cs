using UnityEngine;
public class ViewPrefab_Overlay_UI : MonoBehaviour
{
    // Fields
    public static ViewPrefab_Overlay_UI Instance;
    public UnityEngine.Canvas Canvas;
    
    // Methods
    private void Awake()
    {
        ViewPrefab_Overlay_UI.Instance = this;
    }
    public ViewPrefab_Overlay_UI()
    {
    
    }

}
