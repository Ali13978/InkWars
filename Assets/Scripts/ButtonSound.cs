using UnityEngine;
public class ButtonSound : MonoBehaviour
{
    // Methods
    private void Start()
    {
        UnityEngine.UI.Button val_1 = this.GetComponent<UnityEngine.UI.Button>();
        if(0 != val_1)
        {
                val_1.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  0, method:  public static System.Void GameAudio::PlayButtonSound()));
        }
        
        UnityEngine.Object.Destroy(obj:  this);
    }
    public ButtonSound()
    {
    
    }

}
