using UnityEngine;
public class PurchaseAndEquipDialog : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button closeButton;
    private TMPro.TextMeshProUGUI message;
    private TMPro.TextMeshProUGUI mtitle;
    public SoftCurrencyBuyButton buyButton;
    private static PurchaseAndEquipDialog _inst;
    
    // Properties
    private static PurchaseAndEquipDialog instance { get; }
    
    // Methods
    private static PurchaseAndEquipDialog get_instance()
    {
        var val_5;
        PurchaseAndEquipDialog val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = PurchaseAndEquipDialog._inst;
        if(0 == val_6)
        {
                val_7 = null;
            val_7 = null;
            PurchaseAndEquipDialog._inst = UnityEngine.Object.Instantiate<PurchaseAndEquipDialog>(original:  UnityEngine.Resources.Load<PurchaseAndEquipDialog>(path:  "DynamicUI/PurchaseAndEquipDialog"));
            val_6 = PurchaseAndEquipDialog._inst.gameObject;
            val_6.SetActive(value:  false);
        }
        
        val_8 = null;
        val_8 = null;
        return (PurchaseAndEquipDialog)PurchaseAndEquipDialog._inst;
    }
    public static PurchaseAndEquipDialog Show(string msg, string title, Currency currency = 0, int price = -1, System.Action purchaseDoneAction)
    {
        int val_10;
        TMPro.TextMeshProUGUI val_11;
        val_10 = price;
        PurchaseAndEquipDialog val_1 = PurchaseAndEquipDialog.instance;
        val_1.message.text = msg;
        PurchaseAndEquipDialog val_2 = PurchaseAndEquipDialog.instance;
        val_11 = val_2.mtitle;
        val_11.text = title;
        if(val_10 >= 1)
        {
                PurchaseAndEquipDialog val_3 = PurchaseAndEquipDialog.instance;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_10);
            val_10 = val_4.currentCryptoKey;
            val_11 = val_4.fakeValue;
            val_3.buyButton.Setup(aNewItemName:  0, aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_10, hiddenValue = val_4.hiddenValue, fakeValue = val_11, inited = val_4.inited}, aNewCurrency:  currency, purchaseDoneCallback:  purchaseDoneAction, customTitle:  0, customMessage:  0);
        }
        else
        {
                PurchaseAndEquipDialog val_5 = PurchaseAndEquipDialog.instance;
            val_5.buyButton.gameObject.SetActive(value:  false);
        }
        
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        DialogManager.ShowCustomDialog(dialog:  PurchaseAndEquipDialog.instance.GetComponent<UnityEngine.RectTransform>(), scale:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        return PurchaseAndEquipDialog.instance;
    }
    public static PurchaseAndEquipDialog Show(string msg, Currency currency = 0, int price = -1, System.Action purchaseDoneAction)
    {
        int val_9;
        TMPro.TextMeshProUGUI val_10;
        val_9 = price;
        PurchaseAndEquipDialog val_1 = PurchaseAndEquipDialog.instance;
        val_10 = val_1.message;
        val_10.text = msg;
        if(val_9 >= 1)
        {
                PurchaseAndEquipDialog val_2 = PurchaseAndEquipDialog.instance;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_9);
            val_9 = val_3.currentCryptoKey;
            val_10 = val_3.fakeValue;
            val_2.buyButton.Setup(aNewItemName:  0, aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_9, hiddenValue = val_3.hiddenValue, fakeValue = val_10, inited = val_3.inited}, aNewCurrency:  currency, purchaseDoneCallback:  purchaseDoneAction, customTitle:  0, customMessage:  0);
        }
        else
        {
                PurchaseAndEquipDialog val_4 = PurchaseAndEquipDialog.instance;
            val_4.buyButton.gameObject.SetActive(value:  false);
        }
        
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        DialogManager.ShowCustomDialog(dialog:  PurchaseAndEquipDialog.instance.GetComponent<UnityEngine.RectTransform>(), scale:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        return PurchaseAndEquipDialog.instance;
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.5f), ease:  27);
        this.closeButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void PurchaseAndEquipDialog::Close()));
    }
    private void OnDisable()
    {
        this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void PurchaseAndEquipDialog::Close()));
    }
    public void Close()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  26), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void PurchaseAndEquipDialog::<Close>b__11_0()));
    }
    public PurchaseAndEquipDialog()
    {
    
    }
    private static PurchaseAndEquipDialog()
    {
    
    }
    private void <Close>b__11_0()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
