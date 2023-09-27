using UnityEngine;
public class DialogPanel : MonoBehaviour
{
    // Fields
    public DG.Tweening.Ease inEase;
    public DG.Tweening.Ease outEase;
    public float inDuration;
    public float outDuration;
    public UnityEngine.Transform panel;
    public UnityEngine.UI.Image inputBlockerBG;
    public TMPro.TextMeshProUGUI titleTxt;
    public TMPro.TextMeshProUGUI messageTxt;
    public UnityEngine.UI.Button cancelButton;
    public UnityEngine.UI.Button confirmButton;
    public UnityEngine.UI.ScrollRect messageScrollView;
    public TMPro.TextMeshProUGUI cancelButtonTitleTxt;
    public TMPro.TextMeshProUGUI confirmButtonTitleTxt;
    public UnityEngine.GameObject buttonGroup;
    public UnityEngine.UI.Button roundCloseButton;
    
    // Methods
    private void Awake()
    {
        this.cancelButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void DialogPanel::Close()));
        this.confirmButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void DialogPanel::Close()));
        this.roundCloseButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void DialogPanel::Close()));
    }
    private void DoShowAnimation()
    {
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.inputBlockerBG, endValue:  0f, duration:  this.inDuration)), isIndependentUpdate:  true);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.panel, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  this.inDuration)), ease:  this.inEase), isIndependentUpdate:  true), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void DialogPanel::<DoShowAnimation>b__16_0()));
    }
    private void AdjustForSingleLineMessage()
    {
        UnityEngine.Vector2 val_2 = this.messageTxt.GetComponent<UnityEngine.RectTransform>().sizeDelta;
        if(val_2.y >= 0)
        {
                return;
        }
        
        this.messageTxt.text = "\r\n" + this.messageTxt.text;
    }
    public void Close()
    {
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.inputBlockerBG, endValue:  0f, duration:  this.outDuration), isIndependentUpdate:  true);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.panel, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  this.outDuration), ease:  this.outEase), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void DialogPanel::<Close>b__18_0())), isIndependentUpdate:  true);
    }
    public DialogPanel RemoveCloseEventToCancelButton()
    {
        this.cancelButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void DialogPanel::Close()));
        return (DialogPanel)this;
    }
    public DialogPanel RemoveCloseEventToConfirmButton()
    {
        this.confirmButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void DialogPanel::Close()));
        return (DialogPanel)this;
    }
    public DialogPanel Show(string title, string message, string cancelButtonTitle, UnityEngine.Events.UnityAction onCancelCallback)
    {
        UnityEngine.GameObject val_9;
        this.titleTxt.text = LanguageManager.GetText(key:  title);
        this.messageTxt.text = LanguageManager.GetText(key:  message);
        this.cancelButton.gameObject.SetActive(value:  true);
        this.cancelButtonTitleTxt.text = LanguageManager.GetText(key:  cancelButtonTitle);
        val_9 = this.buttonGroup;
        val_9.SetActive(value:  false);
        if(onCancelCallback != null)
        {
                val_9 = this.cancelButton.onClick;
            val_9.AddListener(call:  onCancelCallback);
            this.buttonGroup.SetActive(value:  true);
        }
        
        this.cancelButton.gameObject.SetActive(value:  true);
        this.roundCloseButton.gameObject.SetActive(value:  true);
        this.gameObject.SetActive(value:  true);
        this.DoShowAnimation();
        return (DialogPanel)this;
    }
    public DialogPanel ShowWithConfirmButton(string title, string message, string confirmButtonTitle, string cancelButtonTitle, UnityEngine.Events.UnityAction onConfirmCallback, UnityEngine.Events.UnityAction onCancelCallback)
    {
        DialogPanel val_1 = this.Show(title:  title, message:  message, cancelButtonTitle:  cancelButtonTitle, onCancelCallback:  onCancelCallback);
        this.buttonGroup.SetActive(value:  true);
        this.confirmButtonTitleTxt.text = LanguageManager.GetText(key:  confirmButtonTitle);
        if(onConfirmCallback != null)
        {
                this.confirmButton.onClick.AddListener(call:  onConfirmCallback);
        }
        
        this.roundCloseButton.gameObject.SetActive(value:  false);
        this.cancelButton.gameObject.SetActive(value:  (~(System.String.IsNullOrEmpty(value:  cancelButtonTitle))) & 1);
        this.confirmButton.gameObject.SetActive(value:  true);
        return (DialogPanel)this;
    }
    public DialogPanel SetInEase(DG.Tweening.Ease aNewEase)
    {
        this.inEase = aNewEase;
        return (DialogPanel)this;
    }
    public DialogPanel SetOutEase(DG.Tweening.Ease aNewEase)
    {
        this.outEase = aNewEase;
        return (DialogPanel)this;
    }
    public DialogPanel SetInDuration(float aNewDuration)
    {
        this.inDuration = aNewDuration;
        return (DialogPanel)this;
    }
    public DialogPanel SetOutDuration(float aNewDuration)
    {
        this.outDuration = aNewDuration;
        return (DialogPanel)this;
    }
    public DialogPanel()
    {
        this.inEase = 31;
        this.inDuration = 0.5f;
        this.outDuration = 5.510186E-41f;
    }
    private void <DoShowAnimation>b__16_0()
    {
        this.AdjustForSingleLineMessage();
        this.messageScrollView.verticalNormalizedPosition = 1f;
    }
    private void <Close>b__18_0()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
