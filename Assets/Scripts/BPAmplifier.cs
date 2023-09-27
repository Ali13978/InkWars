using UnityEngine;
public class BPAmplifier : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform panel;
    private static BPAmplifier _inst;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.CanvasGroup fadeGroup;
    private DG.Tweening.Tweener fadeAnim;
    
    // Properties
    private static BPAmplifier instance { get; }
    
    // Methods
    private static BPAmplifier get_instance()
    {
        var val_5;
        BPAmplifier val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = BPAmplifier._inst;
        if(0 == val_6)
        {
                val_7 = null;
            val_7 = null;
            BPAmplifier._inst = UnityEngine.Object.Instantiate<BPAmplifier>(original:  UnityEngine.Resources.Load<BPAmplifier>(path:  "DynamicUI/BPAmplifierCanvas"));
            val_6 = BPAmplifier._inst.gameObject;
            val_6.SetActive(value:  false);
        }
        
        val_8 = null;
        val_8 = null;
        return (BPAmplifier)BPAmplifier._inst;
    }
    public static void Show()
    {
        BPAmplifier.instance.gameObject.SetActive(value:  true);
    }
    public static void Hide()
    {
        BPAmplifier.instance.Close(onDone:  0, onPreClose:  0);
    }
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_7;
        var val_8;
        var val_9;
        val_7 = 1152921505116749824;
        val_8 = null;
        val_8 = null;
        if(0 == BPAmplifier._inst)
        {
                val_9 = null;
            val_9 = null;
            BPAmplifier._inst = this;
        }
        
        if(0 != this.closeButton)
        {
                this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BPAmplifier::OnClose()));
            UnityEngine.Events.UnityAction val_6 = null;
            val_7 = val_6;
            val_6 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BPAmplifier::OnClose());
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
        
        this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BPAmplifier::OnClose()));
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
        BPAmplifier.<>c__DisplayClass13_0 val_1 = new BPAmplifier.<>c__DisplayClass13_0();
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
            this.fadeAnim = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  val_11, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void BPAmplifier.<>c__DisplayClass13_0::<Close>b__0()));
            return;
        }
        
        if(val_10 == 0)
        {
                return;
        }
        
        val_10.Invoke();
        this.fadeGroup.gameObject.SetActive(value:  false);
    }
    public BPAmplifier()
    {
    
    }
    private static BPAmplifier()
    {
    
    }

}
