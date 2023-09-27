using UnityEngine;
public class TempPopupUI : MonoBehaviour
{
    // Methods
    public void buttonClose()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public TempPopupUI()
    {
    
    }

}
