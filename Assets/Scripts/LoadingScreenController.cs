using UnityEngine;
public class LoadingScreenController : MonoBehaviour
{
    // Fields
    public static UnityEngine.Events.UnityEvent OnFlyInDone;
    public static UnityEngine.Events.UnityEvent OnFlyOutDone;
    private static bool <isShowing>k__BackingField;
    private static LoadingScreenController _inst;
    public UnityEngine.RectTransform animPanel;
    private UnityEngine.RectTransform canvasRect;
    private DG.Tweening.Tweener flyAnimTweener;
    
    // Properties
    public static bool isShowing { get; set; }
    public static LoadingScreenController instance { get; }
    public bool isPlayAnimation { get; }
    
    // Methods
    public static bool get_isShowing()
    {
        null = null;
        return (bool)LoadingScreenController.<isShowing>k__BackingField;
    }
    private static void set_isShowing(bool value)
    {
        null = null;
        LoadingScreenController.<isShowing>k__BackingField = value;
    }
    public static LoadingScreenController get_instance()
    {
        var val_6;
        LoadingScreenController val_7;
        LoadingScreenController val_8;
        var val_9;
        var val_10;
        val_6 = null;
        val_6 = null;
        val_7 = LoadingScreenController._inst;
        if(0 == val_7)
        {
                val_7 = UnityEngine.Resources.Load<LoadingScreenController>(path:  "DynamicUI/LoadingScreenCanvas");
            val_8 = 0;
            if(0 == val_7)
        {
                return val_8;
        }
        
            val_9 = null;
            val_9 = null;
            LoadingScreenController._inst = UnityEngine.Object.Instantiate<LoadingScreenController>(original:  val_7);
            val_7 = LoadingScreenController._inst;
            UnityEngine.Object.DontDestroyOnLoad(target:  val_7.gameObject);
        }
        
        val_10 = null;
        val_10 = null;
        val_8 = LoadingScreenController._inst;
        return val_8;
    }
    public static void CreateAndInit()
    {
        LoadingScreenController val_1 = LoadingScreenController.instance;
    }
    public bool get_isPlayAnimation()
    {
        if(this.flyAnimTweener == null)
        {
                return (bool)this.flyAnimTweener;
        }
        
        return DG.Tweening.TweenExtensions.IsPlaying(t:  this.flyAnimTweener);
    }
    private void Awake()
    {
        this.canvasRect = this.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.Init());
    }
    private System.Collections.IEnumerator Init()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LoadingScreenController.<Init>d__16();
    }
    public void FlyIn(float duration = 1, System.Action onDone)
    {
        .onDone = onDone;
        LoadingScreenController.isShowing = true;
        if(this.flyAnimTweener != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.flyAnimTweener, complete:  false);
        }
        
        this.animPanel.gameObject.SetActive(value:  true);
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        this.animPanel.anchoredPosition = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        UnityEngine.Vector2 val_4 = this.canvasRect.sizeDelta;
        this.flyAnimTweener = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMoveY(target:  this.animPanel, endValue:  val_4.y, duration:  duration, snapping:  false)), action:  new DG.Tweening.TweenCallback(object:  new LoadingScreenController.<>c__DisplayClass17_0(), method:  System.Void LoadingScreenController.<>c__DisplayClass17_0::<FlyIn>b__0())), ease:  4);
    }
    public void FlyOut(float duration = 1, System.Action onDone)
    {
        LoadingScreenController.<>c__DisplayClass18_0 val_1 = new LoadingScreenController.<>c__DisplayClass18_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .onDone = onDone;
        if(this.flyAnimTweener != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.flyAnimTweener, complete:  false);
        }
        
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.animPanel.anchoredPosition = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        UnityEngine.Vector2 val_3 = this.canvasRect.sizeDelta;
        this.flyAnimTweener = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMoveY(target:  this.animPanel, endValue:  val_3.y, duration:  duration, snapping:  false), delay:  0.2f), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void LoadingScreenController.<>c__DisplayClass18_0::<FlyOut>b__0())), ease:  4);
    }
    public LoadingScreenController()
    {
    
    }
    private static LoadingScreenController()
    {
        LoadingScreenController.OnFlyInDone = new UnityEngine.Events.UnityEvent();
        LoadingScreenController.OnFlyOutDone = new UnityEngine.Events.UnityEvent();
    }

}
