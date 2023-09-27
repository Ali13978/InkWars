using UnityEngine;
public class BPAmplifierShopCountPanel : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI countTxt;
    
    // Methods
    private void OnEnable()
    {
        this.UpdateCount();
    }
    public void UpdateCount()
    {
        TMPro.TextMeshProUGUI val_7;
        var val_8;
        val_7 = this;
        if(0 == this.countTxt)
        {
                return;
        }
        
        val_7 = this.countTxt;
        val_8 = null;
        val_8 = null;
        val_7.text = DataStructs.UserDataDictionary.Items.GetAmplifierList().Count.ToString() + "/"("/") + 8.ToString();
    }
    public BPAmplifierShopCountPanel()
    {
    
    }

}
