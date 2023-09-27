using UnityEngine;
public class ViewPrefab_CharacterBases : MonoBehaviour
{
    // Fields
    public static ViewPrefab_CharacterBases Instance;
    public UnityEngine.Canvas Canvas;
    
    // Methods
    private void Awake()
    {
        ViewPrefab_CharacterBases.Instance = this;
    }
    public ViewPrefab_CharacterBases()
    {
    
    }

}
