using UnityEngine;
public class ViewPrefab_Battlegrids : MonoBehaviour
{
    // Fields
    public static ViewPrefab_Battlegrids Instance;
    public UnityEngine.Canvas Canvas;
    
    // Methods
    private void Awake()
    {
        ViewPrefab_Battlegrids.Instance = this;
    }
    public ViewPrefab_Battlegrids()
    {
    
    }

}
