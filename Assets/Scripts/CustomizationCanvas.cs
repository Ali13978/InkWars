using UnityEngine;
public class CustomizationCanvas : MonoBehaviour
{
    // Fields
    private static CustomizationCanvas _inst;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.CanvasGroup fadeGroup;
    private DG.Tweening.Tweener fadeAnim;
    
    // Properties
    private static CustomizationCanvas instance { get; }
    
    // Methods
    private static CustomizationCanvas get_instance()
    {
        var val_5;
        CustomizationCanvas val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = CustomizationCanvas._inst;
        if(0 == val_6)
        {
                val_7 = null;
            val_7 = null;
            CustomizationCanvas._inst = UnityEngine.Object.Instantiate<CustomizationCanvas>(original:  UnityEngine.Resources.Load<CustomizationCanvas>(path:  "DynamicUI/CustomizationCanvas"));
            val_6 = CustomizationCanvas._inst.gameObject;
            val_6.SetActive(value:  false);
        }
        
        val_8 = null;
        val_8 = null;
        return (CustomizationCanvas)CustomizationCanvas._inst;
    }
    public static void Show()
    {
        DialogManager.ShowCustomDialog(dialog:  CustomizationCanvas.instance.GetComponent<UnityEngine.RectTransform>());
        GameAudio.PlayButtonSound();
    }
    public static void Hide()
    {
        CustomizationCanvas.instance.Close(onDone:  0, onPreClose:  0);
    }
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_7;
        var val_8;
        var val_9;
        val_7 = 1152921505133203456;
        val_8 = null;
        val_8 = null;
        if(0 == CustomizationCanvas._inst)
        {
                val_9 = null;
            val_9 = null;
            CustomizationCanvas._inst = this;
        }
        
        if(0 != this.closeButton)
        {
                this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CustomizationCanvas::OnClose()));
            UnityEngine.Events.UnityAction val_6 = null;
            val_7 = val_6;
            val_6 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CustomizationCanvas::OnClose());
            this.closeButton.onClick.AddListener(call:  val_6);
        }
        
        this.Open();
    }
    private void OnDisable()
    {
        if(0 == this.closeButton)
        {
                return;
        }
        
        this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CustomizationCanvas::OnClose()));
    }
    public void Open()
    {
        if(this.fadeAnim != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.fadeAnim, complete:  false);
        }
        
        if(0 == this.fadeGroup)
        {
                return;
        }
        
        this.fadeGroup.alpha = 0f;
        this.fadeAnim = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.fadeGroup, endValue:  1f, duration:  0.3f);
    }
    private void OnClose()
    {
        this.Close(onDone:  0, onPreClose:  0);
    }
    public void Close(System.Action onDone, System.Action onPreClose)
    {
        var val_8;
        UnityEngine.CanvasGroup val_9;
        CustomizationCanvas.<>c__DisplayClass12_0 val_1 = new CustomizationCanvas.<>c__DisplayClass12_0();
        if(val_1 != null)
        {
                val_8 = val_1;
            .onDone = onDone;
        }
        else
        {
                val_8 = 16;
            mem[16] = onDone;
        }
        
        .<>4__this = this;
        if(onPreClose != null)
        {
                onPreClose.Invoke();
        }
        
        if(this.fadeAnim != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.fadeAnim, complete:  false);
        }
        
        val_9 = this.fadeGroup;
        if(0 != val_9)
        {
                val_9 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.fadeGroup, endValue:  0f, duration:  0.3f);
            this.fadeAnim = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  val_9, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void CustomizationCanvas.<>c__DisplayClass12_0::<Close>b__0()));
            return;
        }
        
        if(val_8 == 0)
        {
                return;
        }
        
        val_8.Invoke();
        this.fadeGroup.gameObject.SetActive(value:  false);
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public CustomizationCanvas()
    {
    
    }
    private static CustomizationCanvas()
    {
    
    }

}
