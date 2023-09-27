using UnityEngine;
public class UpdateMusselsCounters : MonoBehaviour
{
    // Fields
    public TMPro.TextMeshProUGUI text_MusselCount;
    public TMPro.TextMeshProUGUI text_MusselTimeTilReplenishment;
    
    // Methods
    private void Update()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.Mussels;
        this.text_MusselCount.text = val_1.currentCryptoKey.ToString();
        this.text_MusselTimeTilReplenishment.text = MVC_MusselTracker.GetTimeTilNextMussel();
    }
    public UpdateMusselsCounters()
    {
    
    }

}
