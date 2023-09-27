using UnityEngine;
public class HiddenIfNotLogin : MonoBehaviour
{
    // Fields
    public bool hiddenIfNotLogin;
    public bool hiddenForGameMode;
    public GameMode targetMode;
    
    // Methods
    private void OnEnable()
    {
        var val_3;
        if(this.hiddenForGameMode == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        this.gameObject.SetActive(value:  (this.targetMode != Character_GlobalInfo.gameMode) ? 1 : 0);
    }
    public HiddenIfNotLogin()
    {
        this.hiddenForGameMode = true;
        this.targetMode = 8;
    }

}
