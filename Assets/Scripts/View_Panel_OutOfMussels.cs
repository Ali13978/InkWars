using UnityEngine;
public class View_Panel_OutOfMussels : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject NotEnoughPearls;
    public UnityEngine.GameObject MusselReward;
    public TMPro.TextMeshProUGUI Text_PearlCost_One;
    public TMPro.TextMeshProUGUI Text_PearlCost_Four;
    public UnityEngine.GameObject[] AdButtons;
    
    // Methods
    private void Start()
    {
        this.Text_PearlCost_One.text = 300.ToString();
        this.Text_PearlCost_Four.text = 1000.ToString();
    }
    private void OnEnable()
    {
    
    }
    private void OnDisable()
    {
    
    }
    private void Update()
    {
    
    }
    public void Button_OutOfMussels_Close()
    {
        this.gameObject.SetActive(value:  true);
    }
    public void Button_BuyMussels(BuyMussels mussels)
    {
        var val_3;
        var val_4;
        if(MVC_MusselTracker.GetMusselCount() >= MVC_MusselTracker.MAX_MUSSELS)
        {
            goto label_3;
        }
        
        if(mussels == 1)
        {
            goto label_4;
        }
        
        if(mussels != 0)
        {
                return;
        }
        
        val_3 = 1;
        val_4 = 300;
        goto label_6;
        label_3:
        this.gameObject.SetActive(value:  false);
        return;
        label_4:
        val_3 = 4;
        val_4 = 1000;
        label_6:
        this.BuyMusselsWithPearls(musselCount:  4, PearlCost:  232);
    }
    private void BuyMusselsWithPearls(int musselCount, int PearlCost)
    {
        var val_6;
        var val_7;
        val_6 = null;
        val_6 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.Pearls;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})) < PearlCost)
        {
                this.NotEnoughPearls.SetActive(value:  true);
            return;
        }
        
        val_7 = null;
        val_7 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Items.Pearls;
        int val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited});
        val_4 = val_4 - PearlCost;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_4);
        DataStructs.UserDataDictionary.Items.Pearls = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited};
        MVC_MusselTracker.AddMussels(number:  musselCount);
    }
    private void OnAdDone()
    {
        this.OnVideoFinished(ad_was_shown:  false);
    }
    public void ShowUnityRewardedAd()
    {
    
    }
    private void OnVideoFinished(bool ad_was_shown)
    {
        null = null;
        MVC_MusselTracker.AddMussels(number:  MVC_MusselTracker.MAX_MUSSELS);
        this.MusselReward.SetActive(value:  true);
        this.HideAdButtons();
    }
    public void HideAdButtons()
    {
        goto label_0;
        label_4:
        this.AdButtons[0].SetActive(value:  false);
        0 = 1;
        label_0:
        if(0 < this.AdButtons.Length)
        {
            goto label_4;
        }
    
    }
    public View_Panel_OutOfMussels()
    {
    
    }

}
