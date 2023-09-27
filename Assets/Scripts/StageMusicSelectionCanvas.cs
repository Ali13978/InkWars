using UnityEngine;
public class StageMusicSelectionCanvas : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform panel;
    private static StageMusicSelectionCanvas _inst;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button applyButton;
    private SingleStageSelectionMenu stageSelection;
    private MusicSelectionController musicSelection;
    private UnityEngine.UI.Button executer;
    private UnityEngine.CanvasGroup fadeGroup;
    private DG.Tweening.Tweener fadeAnim;
    
    // Properties
    private static StageMusicSelectionCanvas instance { get; }
    
    // Methods
    private static StageMusicSelectionCanvas get_instance()
    {
        var val_5;
        StageMusicSelectionCanvas val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = StageMusicSelectionCanvas._inst;
        if(0 == val_6)
        {
                val_7 = null;
            val_7 = null;
            StageMusicSelectionCanvas._inst = UnityEngine.Object.Instantiate<StageMusicSelectionCanvas>(original:  UnityEngine.Resources.Load<StageMusicSelectionCanvas>(path:  "DynamicUI/StageMusicSelectionCanvas"));
            val_6 = StageMusicSelectionCanvas._inst.gameObject;
            val_6.SetActive(value:  false);
        }
        
        val_8 = null;
        val_8 = null;
        return (StageMusicSelectionCanvas)StageMusicSelectionCanvas._inst;
    }
    public static void Show()
    {
        DialogManager.ShowCustomDialog(dialog:  StageMusicSelectionCanvas.instance.GetComponent<UnityEngine.RectTransform>());
    }
    public static void Hide()
    {
        StageMusicSelectionCanvas.instance.Close(onDone:  0, onPreClose:  0);
    }
    private void Awake()
    {
        this.executer = this.GetComponent<UnityEngine.UI.Button>();
    }
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_13;
        var val_14;
        var val_15;
        val_13 = 1152921505122021376;
        val_14 = null;
        val_14 = null;
        if(0 == StageMusicSelectionCanvas._inst)
        {
                val_15 = null;
            val_15 = null;
            StageMusicSelectionCanvas._inst = this;
        }
        
        if(0 != this.closeButton)
        {
                this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void StageMusicSelectionCanvas::OnClose()));
            UnityEngine.Events.UnityAction val_6 = null;
            val_13 = val_6;
            val_6 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void StageMusicSelectionCanvas::OnClose());
            this.closeButton.onClick.AddListener(call:  val_6);
        }
        
        if(0 != this.applyButton)
        {
                UnityEngine.Events.UnityAction val_9 = null;
            val_13 = val_9;
            val_9 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void StageMusicSelectionCanvas::OnApplyChanges());
            this.applyButton.onClick.AddListener(call:  val_9);
        }
        
        if(0 != this.executer)
        {
                UnityEngine.Events.UnityAction val_12 = null;
            val_13 = val_12;
            val_12 = new UnityEngine.Events.UnityAction(object:  0, method:  public static System.Void StageMusicSelectionCanvas::Show());
            this.executer.onClick.AddListener(call:  val_12);
        }
        
        this.Open();
    }
    private void OnDisable()
    {
        UnityEngine.Events.UnityAction val_10;
        if(0 != this.closeButton)
        {
                UnityEngine.Events.UnityAction val_3 = null;
            val_10 = val_3;
            val_3 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void StageMusicSelectionCanvas::OnClose());
            this.closeButton.onClick.RemoveListener(call:  val_3);
        }
        
        if(0 != this.applyButton)
        {
                UnityEngine.Events.UnityAction val_6 = null;
            val_10 = val_6;
            val_6 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void StageMusicSelectionCanvas::OnApplyChanges());
            this.applyButton.onClick.RemoveListener(call:  val_6);
        }
        
        if(0 == this.executer)
        {
                return;
        }
        
        this.executer.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  0, method:  public static System.Void StageMusicSelectionCanvas::Show()));
    }
    private void OnApplyChanges()
    {
        this.stageSelection.Apply();
        this.musicSelection.Apply();
        this.Close(onDone:  0, onPreClose:  0);
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
        StageMusicSelectionCanvas.<>c__DisplayClass19_0 val_1 = new StageMusicSelectionCanvas.<>c__DisplayClass19_0();
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
            this.fadeAnim = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  val_11, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void StageMusicSelectionCanvas.<>c__DisplayClass19_0::<Close>b__0()));
            return;
        }
        
        if(val_10 == 0)
        {
                return;
        }
        
        val_10.Invoke();
        this.fadeGroup.gameObject.SetActive(value:  false);
    }
    public StageMusicSelectionCanvas()
    {
    
    }
    private static StageMusicSelectionCanvas()
    {
    
    }

}
