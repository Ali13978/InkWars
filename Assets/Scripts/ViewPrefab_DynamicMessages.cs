using UnityEngine;
public class ViewPrefab_DynamicMessages : MonoBehaviour
{
    // Fields
    public static ViewPrefab_DynamicMessages Instance;
    public UnityEngine.Canvas Canvas;
    
    // Methods
    private void Awake()
    {
        ViewPrefab_DynamicMessages.Instance = this;
    }
    public ViewPrefab_DynamicMessages()
    {
    
    }

}
