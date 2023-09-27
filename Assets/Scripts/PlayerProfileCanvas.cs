using UnityEngine;
public class PlayerProfileCanvas : MonoBehaviour
{
    // Fields
    private static PlayerProfileCanvas _inst;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.CanvasGroup fadeGroup;
    private UnityEngine.RectTransform panel;
    private DG.Tweening.Tweener fadeAnim;
    
    // Properties
    private static PlayerProfileCanvas instance { get; }
    
    // Methods
    private static PlayerProfileCanvas get_instance()
    {
        var val_5;
        PlayerProfileCanvas val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = PlayerProfileCanvas._inst;
        if(0 == val_6)
        {
                val_7 = null;
            val_7 = null;
            PlayerProfileCanvas._inst = UnityEngine.Object.Instantiate<PlayerProfileCanvas>(original:  UnityEngine.Resources.Load<PlayerProfileCanvas>(path:  "DynamicUI/PlayerProfileCanvas"));
            val_6 = PlayerProfileCanvas._inst.gameObject;
            val_6.SetActive(value:  false);
        }
        
        val_8 = null;
        val_8 = null;
        return (PlayerProfileCanvas)PlayerProfileCanvas._inst;
    }
    public static void Show()
    {
        PlayerProfileCanvas.instance.gameObject.SetActive(value:  true);
    }
    public static void Hide()
    {
        PlayerProfileCanvas.instance.Close(onDone:  0, onPreClose:  0);
    }
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_7;
        var val_8;
        var val_9;
        val_7 = 1152921505137836032;
        val_8 = null;
        val_8 = null;
        if(0 == PlayerProfileCanvas._inst)
        {
                val_9 = null;
            val_9 = null;
            PlayerProfileCanvas._inst = this;
        }
        
        if(0 != this.closeButton)
        {
                this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PlayerProfileCanvas::OnClose()));
            UnityEngine.Events.UnityAction val_6 = null;
            val_7 = val_6;
            val_6 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PlayerProfileCanvas::OnClose());
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
        
        this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PlayerProfileCanvas::OnClose()));
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
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.panel.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        this.fadeAnim = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.panel.GetComponent<UnityEngine.Transform>(), endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.5f), ease:  27);
    }
    private void OnClose()
    {
        this.Close(onDone:  0, onPreClose:  0);
    }
    public void Close(System.Action onDone, System.Action onPreClose)
    {
        var val_10;
        UnityEngine.CanvasGroup val_11;
        PlayerProfileCanvas.<>c__DisplayClass13_0 val_1 = new PlayerProfileCanvas.<>c__DisplayClass13_0();
        if(val_1 != null)
        {
                val_10 = val_1;
            .onDone = onDone;
        }
        else
        {
                val_10 = 16;
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
        
        val_11 = this.fadeGroup;
        if(0 != val_11)
        {
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            val_11 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.panel.GetComponent<UnityEngine.Transform>(), endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.5f), ease:  26);
            this.fadeAnim = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  val_11, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PlayerProfileCanvas.<>c__DisplayClass13_0::<Close>b__0()));
            return;
        }
        
        if(val_10 == 0)
        {
                return;
        }
        
        val_10.Invoke();
        this.fadeGroup.gameObject.SetActive(value:  false);
    }
    public PlayerProfileCanvas()
    {
    
    }
    private static PlayerProfileCanvas()
    {
    
    }

}
