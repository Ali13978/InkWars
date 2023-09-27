using UnityEngine;
[Serializable]
public class VIPData
{
    // Fields
    public string name;
    public string title;
    public int level;
    public bool isPopular;
    public string medalImgName;
    public UnityEngine.Vector2 medalImgSize;
    public float medalImgPosY;
    public bool unlockCharacters;
    public bool unlockCelebs;
    public bool unlockCustomizableItems;
    public InkWars.Model.CustomizationTier maxUnlockedItemTier;
    public bool unlockBundle;
    
    // Methods
    public VIPData()
    {
    
    }

}
