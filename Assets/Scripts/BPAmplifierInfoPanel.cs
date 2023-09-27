using UnityEngine;
public class BPAmplifierInfoPanel : MonoBehaviour
{
    // Fields
    public InkWars.Model.BPAmplifierType amplifierType;
    private TMPro.TextMeshProUGUI title;
    private TMPro.TextMeshProUGUI infoTxt;
    
    // Methods
    private void OnEnable()
    {
        this.title.text = LanguageManager.GetText(key:  "Lk.Shop.Enhanser.Amp." + this.amplifierType);
        this.infoTxt.text = LanguageManager.GetText(key:  "Lk.Shop.Enhanser.Amp." + this.amplifierType + ".Info");
    }
    public BPAmplifierInfoPanel()
    {
    
    }

}
