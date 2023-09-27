using UnityEngine;
public class ExpressPurchaseCurrencyCanvas : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button closeButton;
    private TMPro.TextMeshProUGUI message1;
    private TMPro.TextMeshProUGUI message2;
    private UnityEngine.GameObject pearlsPanel;
    private UnityEngine.GameObject shellsPanel;
    private static ExpressPurchaseCurrencyCanvas _inst;
    
    // Properties
    private static ExpressPurchaseCurrencyCanvas instance { get; }
    
    // Methods
    private static ExpressPurchaseCurrencyCanvas get_instance()
    {
        var val_5;
        ExpressPurchaseCurrencyCanvas val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = ExpressPurchaseCurrencyCanvas._inst;
        if(0 == val_6)
        {
                val_7 = null;
            val_7 = null;
            ExpressPurchaseCurrencyCanvas._inst = UnityEngine.Object.Instantiate<ExpressPurchaseCurrencyCanvas>(original:  UnityEngine.Resources.Load<ExpressPurchaseCurrencyCanvas>(path:  "DynamicUI/ExpressPurchaseCurrencyCanvas"));
            val_6 = ExpressPurchaseCurrencyCanvas._inst.gameObject;
            val_6.SetActive(value:  false);
        }
        
        val_8 = null;
        val_8 = null;
        return (ExpressPurchaseCurrencyCanvas)ExpressPurchaseCurrencyCanvas._inst;
    }
    public static void Show(Currency currency = 0)
    {
        var val_20;
        var val_21;
        if(currency == 2)
        {
                val_20 = null;
            val_20 = null;
            MMOCUserProfile val_3 = NFUser.current.mmocUser.userProfile;
            UnityEngine.Application.OpenURL(url:  MMOCClientUser.SHOP_URL + "?prefill_username="("?prefill_username=") + val_3.username);
            return;
        }
        
        if(currency != 0)
        {
                ExpressPurchaseCurrencyCanvas val_5 = ExpressPurchaseCurrencyCanvas.instance;
            val_5.message1.text = "YOU DONT HAVE ENOUGH SHELLS FOR THIS";
            ExpressPurchaseCurrencyCanvas val_6 = ExpressPurchaseCurrencyCanvas.instance;
            val_6.message2.text = "TOP UP SHELLS NOW";
            ExpressPurchaseCurrencyCanvas val_7 = ExpressPurchaseCurrencyCanvas.instance;
            val_7.pearlsPanel.gameObject.SetActive(value:  false);
            ExpressPurchaseCurrencyCanvas val_9 = ExpressPurchaseCurrencyCanvas.instance;
            UnityEngine.GameObject val_10 = val_9.shellsPanel.gameObject;
            val_21 = 1;
        }
        else
        {
                ExpressPurchaseCurrencyCanvas val_11 = ExpressPurchaseCurrencyCanvas.instance;
            val_11.message1.text = "YOU DONT HAVE ENOUGH PEARLS FOR THIS";
            ExpressPurchaseCurrencyCanvas val_12 = ExpressPurchaseCurrencyCanvas.instance;
            val_12.message2.text = "TOP UP PEARLS NOW";
            ExpressPurchaseCurrencyCanvas val_13 = ExpressPurchaseCurrencyCanvas.instance;
            val_13.pearlsPanel.gameObject.SetActive(value:  true);
            ExpressPurchaseCurrencyCanvas val_15 = ExpressPurchaseCurrencyCanvas.instance;
            val_21 = 0;
        }
        
        val_15.shellsPanel.gameObject.SetActive(value:  false);
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.zero;
        DialogManager.ShowCustomDialog(dialog:  ExpressPurchaseCurrencyCanvas.instance.GetComponent<UnityEngine.RectTransform>(), scale:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.5f), ease:  27);
        this.closeButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void ExpressPurchaseCurrencyCanvas::Close()));
    }
    private void OnDisable()
    {
        this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void ExpressPurchaseCurrencyCanvas::Close()));
    }
    public void Close()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  26), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void ExpressPurchaseCurrencyCanvas::<Close>b__11_0()));
    }
    public ExpressPurchaseCurrencyCanvas()
    {
    
    }
    private static ExpressPurchaseCurrencyCanvas()
    {
    
    }
    private void <Close>b__11_0()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
