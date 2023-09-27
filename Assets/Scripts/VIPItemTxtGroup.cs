using UnityEngine;
public class VIPItemTxtGroup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text titleTxt;
    private TMPro.TextMeshProUGUI countTxt;
    private UnityEngine.UI.Text additionalInfoTxt;
    
    // Methods
    public void SetTexts(string title, int count, string info)
    {
        UnityEngine.UI.Text val_9;
        UnityEngine.UI.Text val_10;
        val_9 = this.titleTxt;
        if(0 != val_9)
        {
                val_9 = this.titleTxt;
            var val_3 = ((System.String.IsNullOrEmpty(value:  title)) != true) ? " " : title;
        }
        
        if(0 == this.countTxt)
        {
            goto label_7;
        }
        
        if(count <= 0)
        {
            goto label_8;
        }
        
        if(this.countTxt != null)
        {
            goto label_14;
        }
        
        label_15:
        label_14:
        this.countTxt.text = System.String.Format(format:  "x {0}", arg0:  count);
        label_7:
        val_10 = this.additionalInfoTxt;
        if(0 != val_10)
        {
                val_10 = this.additionalInfoTxt;
            var val_8 = ((System.String.IsNullOrEmpty(value:  info)) != true) ? " " : info;
        }
        
        this.UpdateAdditionalInfoText();
        return;
        label_8:
        if(this.countTxt != null)
        {
            goto label_14;
        }
        
        goto label_15;
    }
    private void OnEnable()
    {
        this.UpdateAdditionalInfoText();
    }
    private void UpdateAdditionalInfoText()
    {
        if(0 == this.additionalInfoTxt)
        {
                return;
        }
        
        this.additionalInfoTxt.gameObject.SetActive(value:  (~(System.String.IsNullOrWhiteSpace(value:  this.additionalInfoTxt))) & 1);
    }
    public VIPItemTxtGroup()
    {
    
    }

}
