using UnityEngine;
public class SingleMessageDialogBox : MonoBehaviour
{
    // Fields
    private static SingleMessageDialogBox _inst;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.CanvasGroup fadeGroup;
    private TMPro.TextMeshProUGUI message;
    private DG.Tweening.Tweener fadeAnim;
    
    // Properties
    private static SingleMessageDialogBox instance { get; }
    
    // Methods
    private static SingleMessageDialogBox get_instance()
    {
        var val_5;
        SingleMessageDialogBox val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = SingleMessageDialogBox._inst;
        if(0 == val_6)
        {
                val_7 = null;
            val_7 = null;
            SingleMessageDialogBox._inst = UnityEngine.Object.Instantiate<SingleMessageDialogBox>(original:  UnityEngine.Resources.Load<SingleMessageDialogBox>(path:  "DynamicUI/SingleMessageDialogBox"));
            val_6 = SingleMessageDialogBox._inst.gameObject;
            val_6.SetActive(value:  false);
        }
        
        val_8 = null;
        val_8 = null;
        return (SingleMessageDialogBox)SingleMessageDialogBox._inst;
    }
    public static void Show(string msg)
    {
        SingleMessageDialogBox val_1 = SingleMessageDialogBox.instance;
        val_1.message.text = msg;
        SingleMessageDialogBox.instance.gameObject.SetActive(value:  true);
    }
    public static void Hide()
    {
        SingleMessageDialogBox.instance.Close(onDone:  0, onPreClose:  0);
    }
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_7;
        var val_8;
        var val_9;
        val_7 = 1152921505121914880;
        val_8 = null;
        val_8 = null;
        if(0 == SingleMessageDialogBox._inst)
        {
                val_9 = null;
            val_9 = null;
            SingleMessageDialogBox._inst = this;
        }
        
        if(0 != this.closeButton)
        {
                this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SingleMessageDialogBox::OnClose()));
            UnityEngine.Events.UnityAction val_6 = null;
            val_7 = val_6;
            val_6 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SingleMessageDialogBox::OnClose());
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
        
        this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SingleMessageDialogBox::OnClose()));
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
        this.fadeAnim = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.fadeGroup, endValue:  1f, duration:  0.5f);
    }
    private void OnClose()
    {
        this.Close(onDone:  0, onPreClose:  0);
    }
    public void Close(System.Action onDone, System.Action onPreClose)
    {
        var val_7;
        UnityEngine.CanvasGroup val_8;
        SingleMessageDialogBox.<>c__DisplayClass13_0 val_1 = new SingleMessageDialogBox.<>c__DisplayClass13_0();
        if(val_1 != null)
        {
                val_7 = val_1;
            .onDone = onDone;
        }
        else
        {
                val_7 = 16;
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
        
        val_8 = this.fadeGroup;
        if(0 != val_8)
        {
                val_8 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.fadeGroup, endValue:  0f, duration:  0.5f);
            this.fadeAnim = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  val_8, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void SingleMessageDialogBox.<>c__DisplayClass13_0::<Close>b__0()));
            return;
        }
        
        if(val_7 == 0)
        {
                return;
        }
        
        val_7.Invoke();
        this.fadeGroup.gameObject.SetActive(value:  false);
    }
    public SingleMessageDialogBox()
    {
    
    }
    private static SingleMessageDialogBox()
    {
    
    }

}
