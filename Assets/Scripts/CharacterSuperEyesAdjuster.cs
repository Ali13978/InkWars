using UnityEngine;
public class CharacterSuperEyesAdjuster : MonoBehaviour
{
    // Fields
    public CharacterNameID cid;
    private CharacterNameID lastCid;
    private UnityEngine.UI.Image img;
    private UnityEngine.RectTransform rt;
    private UnityEngine.Sprite sp;
    private CharacterData cd;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Object.Destroy(obj:  this);
    }
    public CharacterSuperEyesAdjuster()
    {
        this.cid = 999999;
    }

}
