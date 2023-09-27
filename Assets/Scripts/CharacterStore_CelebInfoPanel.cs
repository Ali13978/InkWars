using UnityEngine;
public class CharacterStore_CelebInfoPanel : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Text panelText;
    public UnityEngine.UI.Image photo;
    
    // Methods
    public void SetCelebInfo(UnityEngine.Sprite photoSprite, string text)
    {
        this.photo.sprite = photoSprite;
    }
    public CharacterStore_CelebInfoPanel()
    {
    
    }

}
