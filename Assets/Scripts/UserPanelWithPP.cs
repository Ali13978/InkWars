using UnityEngine;
public class UserPanelWithPP : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text nameTxt;
    private TMPro.TextMeshProUGUI ppTxt;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    private void OnEnable()
    {
        null = null;
        string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  DataStructs.UserDataDictionary.Settings.UserName);
        Utility.SetBoldTextWithBlackOutline(txtObj:  this.nameTxt);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Stats.PlayerPoints;
        this.ppTxt.text = val_3.currentCryptoKey.ToString();
    }
    public UserPanelWithPP()
    {
    
    }

}
