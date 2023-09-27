using UnityEngine;
public class CharacterUnlockButtonTitleAdjuster : MonoBehaviour
{
    // Methods
    private void Start()
    {
        UnityEngine.RectTransform val_1 = this.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Vector2 val_2 = val_1.anchoredPosition;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = 208f, z = val_3.z});
        val_1.anchoredPosition = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        UnityEngine.Object.Destroy(obj:  this);
    }
    public CharacterUnlockButtonTitleAdjuster()
    {
    
    }

}
