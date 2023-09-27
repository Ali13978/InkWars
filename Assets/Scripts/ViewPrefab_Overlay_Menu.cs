using UnityEngine;
public class ViewPrefab_Overlay_Menu : MonoBehaviour
{
    // Fields
    public static ViewPrefab_Overlay_Menu Instance;
    public UnityEngine.Canvas Canvas;
    
    // Methods
    private void Awake()
    {
        ViewPrefab_Overlay_Menu.Instance = this;
    }
    public ViewPrefab_Overlay_Menu()
    {
    
    }

}
