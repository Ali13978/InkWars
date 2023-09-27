using UnityEngine;
[Serializable]
public class Control_Manager : MonoBehaviour
{
    // Fields
    public Control_Input LeftControl;
    public Control_Input RightControl;
    
    // Properties
    private static InkWars.Model.Model_Core Model { get; }
    
    // Methods
    private static InkWars.Model.Model_Core get_Model()
    {
        if(InkWars.Model.Model_Manager.Instance == 0)
        {
                return 0;
        }
        
        InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
        0 = val_3.Model;
        return 0;
    }
    private void Awake()
    {
        if(0 == this.LeftControl)
        {
                UnityEngine.Debug.LogError(message:  "LEFT CONTROL NOT SETUP");
        }
        
        if(0 != this.RightControl)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  "RIGHT CONTROL NOT SETUP");
    }
    private void Update()
    {
        var val_9;
        bool val_10;
        var val_11;
        var val_12;
        if(Control_Manager.Model == null)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.RightControl.gameObject;
        val_9 = null;
        val_9 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
            goto label_5;
        }
        
        val_10 = 1;
        if(val_2 != null)
        {
            goto label_9;
        }
        
        goto label_7;
        label_5:
        InkWars.Model.Model_Core val_3 = Control_Manager.Model;
        val_10 = val_3.PlayersFlippedLocally;
        if(val_2 != null)
        {
            goto label_9;
        }
        
        label_7:
        label_9:
        val_2.SetActive(value:  (val_10 == true) ? 1 : 0);
        UnityEngine.GameObject val_5 = this.LeftControl.gameObject;
        val_11 = null;
        val_11 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
            goto label_13;
        }
        
        val_12 = 1;
        if(val_5 != null)
        {
            goto label_17;
        }
        
        goto label_15;
        label_13:
        InkWars.Model.Model_Core val_6 = Control_Manager.Model;
        bool val_8 = val_6.PlayersFlippedLocally;
        val_8 = val_8 ^ 1;
        val_12 = val_8 & 255;
        if(val_5 != null)
        {
            goto label_17;
        }
        
        label_15:
        label_17:
        val_5.SetActive(value:  (val_12 == true) ? 1 : 0);
    }
    public Control_Manager()
    {
    
    }

}
