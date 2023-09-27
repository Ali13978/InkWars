using UnityEngine;
public class StarSpinController : MonoBehaviour
{
    // Fields
    public bool isLeft;
    private StarSpinAnim starSpinAnim;
    
    // Methods
    private void Update()
    {
        float val_11;
        var val_12;
        var val_13;
        InkWars.Model.Model_Manager val_1 = InkWars.Model.Model_Manager.Instance;
        if(val_1.Model == null)
        {
            goto label_1;
        }
        
        if(this.isLeft == false)
        {
            goto label_2;
        }
        
        label_4:
        InkWars.Model.Model_Player val_2 = val_1.Model.LeftPlayer;
        goto label_3;
        label_1:
        if(this.isLeft == true)
        {
            goto label_4;
        }
        
        label_2:
        InkWars.Model.Model_Player val_3 = val_1.Model.RightPlayer;
        label_3:
        val_11 = val_3.StunnedTime;
        if(val_11 > 0f)
        {
            goto label_6;
        }
        
        if(this.starSpinAnim.gameObject.activeInHierarchy == false)
        {
            goto label_9;
        }
        
        val_12 = this.starSpinAnim.gameObject;
        val_13 = 0;
        goto label_12;
        label_9:
        val_11 = val_3.StunnedTime;
        label_6:
        if(val_11 <= 0f)
        {
                return;
        }
        
        if(this.starSpinAnim.gameObject.activeInHierarchy != false)
        {
                return;
        }
        
        val_12 = this.starSpinAnim.gameObject;
        val_13 = 1;
        label_12:
        val_12.SetActive(value:  true);
    }
    public StarSpinController()
    {
    
    }

}
