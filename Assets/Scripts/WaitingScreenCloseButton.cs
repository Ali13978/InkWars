using UnityEngine;
public class WaitingScreenCloseButton : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject closeButton;
    
    // Methods
    private void Update()
    {
        var val_3;
        bool val_2 = InkWars.Model.MVCNetworkManager.Instance.IsTryingToJoin;
        if(this.closeButton == null)
        {
            goto label_4;
        }
        
        if(val_2 == false)
        {
            goto label_5;
        }
        
        label_7:
        val_3 = 0;
        goto label_6;
        label_4:
        if(val_2 == true)
        {
            goto label_7;
        }
        
        label_5:
        val_3 = 1;
        label_6:
        this.closeButton.SetActive(value:  true);
    }
    public WaitingScreenCloseButton()
    {
    
    }

}
