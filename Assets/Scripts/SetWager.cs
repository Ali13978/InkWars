using UnityEngine;
public class SetWager : MonoBehaviour
{
    // Fields
    private TMPro.TMP_InputField wagerInput;
    private TMPro.TextMeshProUGUI wagerTxt;
    private MotionPanelsControler watingAnimation;
    private UnityEngine.GameObject wallpaper;
    public static decimal privateWager;
    
    // Methods
    private void OnEnable()
    {
        this.wagerInput.onEndEdit.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void SetWager::SetWagerDone(string wager)));
    }
    private void OnDisable()
    {
        this.wagerInput.onEndEdit.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void SetWager::SetWagerDone(string wager)));
    }
    private void SetWagerDone(string wager)
    {
        decimal val_6;
        SetWager.<>c__DisplayClass7_0 val_1 = new SetWager.<>c__DisplayClass7_0();
        if(val_1 != null)
        {
                val_6 = val_1;
            .wagerFloat = 0m;
            mem[1152921529085470400] = this;
            mem[1152921529085470416] = 0;
        }
        else
        {
                mem[16] = this;
            val_6 = 24m;
            mem[32] = 0;
            mem[24] = 0;
        }
        
        if((System.Decimal.TryParse(s:  wager, result: out  new System.Decimal())) != false)
        {
                DialogManager.ShowLoading();
            MMOCUser.current.GetUserProfile(onGetUserProfileDone:  new UnityEngine.Events.UnityAction<MMOCUserProfile>(object:  val_1, method:  System.Void SetWager.<>c__DisplayClass7_0::<SetWagerDone>b__0(MMOCClientUser.MMOCUserProfile profile)));
            return;
        }
        
        DialogPanel val_5 = DialogManager.Show(title:  "LK.FetchData.Error", message:  "LK.Wager.InvalidWager", cancelButtonTitle:  0, onCancelCallback:  0);
    }
    private void Checkwagers(decimal wager, decimal enteredAmount)
    {
        int val_11;
        var val_12;
        var val_13;
        val_11 = enteredAmount.flags;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_11, hi = enteredAmount.hi, lo = enteredAmount.lo, mid = enteredAmount.mid}, d2:  new System.Decimal())) == true)
        {
            goto label_3;
        }
        
        val_11 = enteredAmount.lo;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_11, hi = enteredAmount.hi, lo = val_11, mid = enteredAmount.mid}, d2:  new System.Decimal())) == false)
        {
            goto label_6;
        }
        
        label_3:
        label_17:
        NoEnoughWager val_4 = NoEnoughWager.Show(msg1:  LanguageManager.GetText(key:  "LK.PrivateWager.InvalidWager2"));
        return;
        label_6:
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = wager.flags, hi = wager.hi, lo = wager.lo, mid = wager.mid}, d2:  new System.Decimal() {flags = val_11, hi = enteredAmount.hi, lo = enteredAmount.lo, mid = enteredAmount.mid})) == false)
        {
            goto label_9;
        }
        
        object[] val_6 = new object[2];
        val_6[0] = "<br>";
        val_6[1] = enteredAmount;
        string val_7 = LanguageManager.GetTextFormat(key:  "LK.Lobby.NoWagerMessage", list:  val_6);
        goto label_17;
        label_9:
        val_12 = null;
        val_12 = null;
        SetWager.privateWager = val_11;
        SetWager.privateWager.__il2cppRuntimeField_3 = enteredAmount.hi;
        SetWager.privateWager.__il2cppRuntimeField_8 = enteredAmount.lo;
        SetWager.privateWager.__il2cppRuntimeField_C = enteredAmount.mid;
        this.wagerTxt.text = val_11.ToString();
        this.watingAnimation.Animate();
        this.wallpaper.gameObject.SetActive(value:  false);
        val_13 = null;
        val_13 = null;
        Character_GlobalInfo.isCryptoMMOCMode = true;
        MultiplayerConnector val_10 = MultiplayerConnector.Instance;
        val_10.m_multiplayerManager.Click_HostPrivateMatch();
    }
    public SetWager()
    {
    
    }
    private static SetWager()
    {
    
    }

}
