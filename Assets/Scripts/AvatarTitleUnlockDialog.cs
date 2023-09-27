using UnityEngine;
public class AvatarTitleUnlockDialog : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button closeButton;
    private TMPro.TextMeshProUGUI message;
    private TMPro.TextMeshProUGUI andOrTxt;
    private TMPro.TextMeshProUGUI message2Txt;
    private UnityEngine.GameObject message1Group;
    private UnityEngine.GameObject andOrGroup;
    private UnityEngine.GameObject message2Group;
    public SoftCurrencyBuyButton buyButton;
    
    // Methods
    public static AvatarTitleUnlockDialog Show(string msg1, string msg2, string andOrText, Currency currency = 0, int price = -1, System.Action purchaseDoneAction)
    {
        AvatarTitleUnlockDialog val_2 = UnityEngine.Object.Instantiate<AvatarTitleUnlockDialog>(original:  UnityEngine.Resources.Load<AvatarTitleUnlockDialog>(path:  "DynamicUI/AvatarTitleUnlockDialog"));
        if(val_2 != null)
        {
                val_2.Setup(msg1:  msg1, andOrText:  andOrText, msg2:  msg2, currency:  currency, price:  price, purchaseDoneAction:  purchaseDoneAction);
        }
        else
        {
                val_2.Setup(msg1:  msg1, andOrText:  andOrText, msg2:  msg2, currency:  currency, price:  price, purchaseDoneAction:  purchaseDoneAction);
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        DialogManager.ShowCustomDialog(dialog:  val_2.GetComponent<UnityEngine.RectTransform>(), scale:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        GameAudio.PlayButtonSound();
        return val_2;
    }
    public void Setup(string msg1, string andOrText, string msg2, Currency currency = 0, int price = -1, System.Action purchaseDoneAction)
    {
        bool val_9;
        this.message.text = msg1;
        this.message2Txt.text = msg2;
        this.andOrTxt.text = andOrText;
        this.message1Group.SetActive(value:  (~(System.String.IsNullOrEmpty(value:  msg1))) & 1);
        this.message2Group.SetActive(value:  (~(System.String.IsNullOrEmpty(value:  msg2))) & 1);
        if((System.String.IsNullOrEmpty(value:  msg1)) == false)
        {
            goto label_6;
        }
        
        val_9 = 0;
        if(this.andOrGroup != null)
        {
            goto label_9;
        }
        
        goto label_8;
        label_6:
        val_9 = (~(System.String.IsNullOrEmpty(value:  msg2))) & 1;
        if(this.andOrGroup != null)
        {
            goto label_9;
        }
        
        label_8:
        label_9:
        this.andOrGroup.SetActive(value:  val_9);
        if(price >= 1)
        {
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  price);
            this.buyButton.Setup(aNewItemName:  0, aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue, inited = val_7.inited}, aNewCurrency:  currency, purchaseDoneCallback:  purchaseDoneAction, customTitle:  0, customMessage:  0);
            return;
        }
        
        this.buyButton.gameObject.SetActive(value:  false);
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.5f), ease:  27);
        this.closeButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void AvatarTitleUnlockDialog::Close()));
    }
    private void OnDisable()
    {
        this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void AvatarTitleUnlockDialog::Close()));
    }
    public void Close()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  26), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void AvatarTitleUnlockDialog::<Close>b__12_0()));
    }
    public AvatarTitleUnlockDialog()
    {
    
    }
    private void <Close>b__12_0()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
