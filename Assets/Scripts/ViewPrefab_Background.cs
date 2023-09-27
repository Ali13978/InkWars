using UnityEngine;
public class ViewPrefab_Background : MonoBehaviour
{
    // Fields
    private static ViewPrefab_Background _instance;
    public UnityEngine.Canvas Canvas;
    public InGameBackgroundController BackgroundController;
    
    // Properties
    public static ViewPrefab_Background Instance { get; }
    
    // Methods
    public static ViewPrefab_Background get_Instance()
    {
        if(ViewPrefab_Background._instance != 0)
        {
                return (ViewPrefab_Background)ViewPrefab_Background._instance;
        }
        
        ViewPrefab_Background._instance = UnityEngine.Object.FindObjectOfType<ViewPrefab_Background>();
        return (ViewPrefab_Background)ViewPrefab_Background._instance;
    }
    public ViewPrefab_Background()
    {
    
    }

}
