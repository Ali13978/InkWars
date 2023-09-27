using UnityEngine;
public class MusselCountController : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text countTxt;
    private UnityEngine.UI.Text timerTxt;
    private TMPro.TextMeshProUGUI countTMPro;
    private TMPro.TextMeshProUGUI timerTMPro;
    
    // Methods
    private void OnEnable()
    {
        null = null;
        DataStructs.UserDataDictionary.OnCurrencyChanged.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void MusselCountController::OnMusselChanged()));
        this.OnMusselChanged();
        this.InvokeRepeating(methodName:  "OnTimerChanged", time:  0f, repeatRate:  1f);
    }
    private void OnDisable()
    {
        null = null;
        DataStructs.UserDataDictionary.OnCurrencyChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void MusselCountController::OnMusselChanged()));
        this.CancelInvoke(methodName:  "OnTimerChanged");
    }
    private void OnMusselChanged()
    {
        TMPro.TextMeshProUGUI val_7;
        var val_8;
        var val_9;
        val_7 = this;
        if(0 != this.countTxt)
        {
                val_8 = null;
            val_8 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Items.Mussels;
            string val_3 = val_2.currentCryptoKey.ToString();
        }
        
        if(0 == this.countTMPro)
        {
                return;
        }
        
        val_7 = this.countTMPro;
        val_9 = null;
        val_9 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Items.Mussels;
        val_7.text = val_5.currentCryptoKey.ToString();
    }
    private void OnTimerChanged()
    {
        if(0 != this.timerTxt)
        {
                string val_2 = MVC_MusselTracker.GetTimeTilNextMussel();
        }
        
        if(0 == this.timerTMPro)
        {
                return;
        }
        
        this.timerTMPro.text = MVC_MusselTracker.GetTimeTilNextMussel();
    }
    public MusselCountController()
    {
    
    }

}
