using UnityEngine;
public class FadeInAfterSeconds : MonoBehaviour
{
    // Fields
    public DG.Tweening.Ease easeType;
    public float timeToWait;
    public float duration;
    public bool shouldZoomIn;
    public bool playOnStart;
    public bool playOnEnable;
    public bool fadeOut;
    public bool fadeOutDelay;
    private UnityEngine.RectTransform rt;
    private UnityEngine.Vector3 originalScale;
    
    // Methods
    private void Awake()
    {
        UnityEngine.RectTransform val_5;
        UnityEngine.RectTransform val_1 = this.GetComponent<UnityEngine.RectTransform>();
        this.rt = val_1;
        if(val_1 != 0)
        {
            goto label_3;
        }
        
        val_5 = this.transform;
        if(val_5 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_3:
        val_5 = this.rt;
        if(val_5 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        UnityEngine.Vector3 val_4 = val_5.localScale;
        this.originalScale = val_4;
        mem[1152921528238982940] = val_4.y;
        mem[1152921528238982944] = val_4.z;
    }
    private void Start()
    {
        UnityEngine.RectTransform val_6;
        var val_7;
        if(this.fadeOut != false)
        {
                this.FadeOut();
            return;
        }
        
        if(this.playOnStart == false)
        {
                return;
        }
        
        if(this.shouldZoomIn != false)
        {
                if(this.rt == 0)
        {
                val_6 = this.transform;
            val_7 = null;
        }
        else
        {
                val_6 = this.rt;
            val_7 = null;
        }
        
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_6.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        
        UnityEngine.Debug.Log(message:  "Play " + this.name + " fade after start");
        this.FadeIn();
    }
    private void OnEnable()
    {
        UnityEngine.RectTransform val_6;
        var val_7;
        if(this.playOnEnable == false)
        {
                return;
        }
        
        if(this.shouldZoomIn != false)
        {
                if(this.rt == 0)
        {
                val_6 = this.transform;
            val_7 = null;
        }
        else
        {
                val_6 = this.rt;
            val_7 = null;
        }
        
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_6.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        
        UnityEngine.Debug.Log(message:  "Play " + this.name + " fade after enabling object");
        this.FadeIn();
    }
    public void FadeIn()
    {
        UnityEngine.RectTransform val_31;
        DG.Tweening.Tweener val_32;
        IntPtr val_34;
        UnityEngine.RectTransform val_35;
        if(this.shouldZoomIn == false)
        {
            goto label_1;
        }
        
        UnityEngine.Debug.Log(message:  "Zoom in");
        label_33:
        if(this.rt != 0)
        {
            goto label_6;
        }
        
        UnityEngine.Transform val_2 = this.transform;
        goto label_7;
        label_1:
        if((this.transform.GetComponent<UnityEngine.CanvasGroup>()) == 0)
        {
            goto label_11;
        }
        
        UnityEngine.Debug.Log(message:  "CanvasGroup");
        if(this.rt != 0)
        {
            goto label_16;
        }
        
        val_32 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.transform.GetComponent<UnityEngine.CanvasGroup>(), endValue:  1f, duration:  this.duration), delay:  this.timeToWait), ease:  this.easeType), isIndependentUpdate:  true);
        val_34 = 1152921528239444896;
        goto label_18;
        label_6:
        val_31 = this.rt;
        label_7:
        label_35:
        DG.Tweening.Tweener val_16 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_31, endValue:  new UnityEngine.Vector3() {x = this.originalScale}, duration:  this.duration), delay:  this.timeToWait), ease:  this.easeType), isIndependentUpdate:  true);
        return;
        label_11:
        if((this.transform.GetComponent<UnityEngine.UI.Image>()) == 0)
        {
            goto label_22;
        }
        
        UnityEngine.Debug.Log(message:  "Image");
        if(this.rt != 0)
        {
            goto label_27;
        }
        
        val_35 = this.transform;
        if(val_35 != null)
        {
            goto label_34;
        }
        
        goto label_29;
        label_16:
        val_32 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.rt.GetComponent<UnityEngine.CanvasGroup>(), endValue:  1f, duration:  this.duration), delay:  this.timeToWait), ease:  this.easeType), isIndependentUpdate:  true);
        DG.Tweening.TweenCallback val_27 = null;
        val_34 = 1152921528239519728;
        label_18:
        val_27 = new DG.Tweening.TweenCallback(object:  this, method:  val_34);
        DG.Tweening.Tweener val_28 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  val_32, action:  val_27);
        return;
        label_22:
        UnityEngine.Debug.Log(message:  "Zoom in (Could not find image or canvas group");
        goto label_33;
        label_27:
        val_35 = this.rt;
        if(val_35 != null)
        {
            goto label_34;
        }
        
        label_29:
        label_34:
        DG.Tweening.Tweener val_30 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_35.GetComponent<UnityEngine.UI.Image>(), endValue:  1f, duration:  this.duration);
        goto label_35;
    }
    public void FadeOut()
    {
        UnityEngine.RectTransform val_30;
        var val_31;
        var val_32;
        UnityEngine.RectTransform val_33;
        UnityEngine.RectTransform val_34;
        float val_35;
        var val_37;
        if(this.shouldZoomIn == false)
        {
            goto label_1;
        }
        
        UnityEngine.Debug.Log(message:  "Zoom in");
        if(this.rt != 0)
        {
            goto label_40;
        }
        
        val_30 = this.transform;
        val_31 = null;
        goto label_9;
        label_1:
        val_32 = 1152921504858337280;
        if((this.transform.GetComponent<UnityEngine.CanvasGroup>()) == 0)
        {
            goto label_13;
        }
        
        UnityEngine.Debug.Log(message:  "CanvasGroup");
        val_32 = this.transform.GetComponent<UnityEngine.CanvasGroup>();
        val_32.blocksRaycasts = false;
        if(this.rt != 0)
        {
            goto label_20;
        }
        
        val_33 = this.transform;
        if(val_33 != null)
        {
            goto label_34;
        }
        
        goto label_22;
        label_13:
        if((this.transform.GetComponent<UnityEngine.UI.Image>()) == 0)
        {
            goto label_26;
        }
        
        UnityEngine.Debug.Log(message:  "Image");
        if(this.rt != 0)
        {
            goto label_31;
        }
        
        val_34 = this.transform;
        if(val_34 != null)
        {
            goto label_50;
        }
        
        goto label_33;
        label_20:
        val_33 = this.rt;
        if(val_33 != null)
        {
            goto label_34;
        }
        
        label_22:
        label_34:
        val_35 = 0f;
        DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_33.GetComponent<UnityEngine.CanvasGroup>(), endValue:  0f, duration:  this.duration);
        goto label_35;
        label_26:
        UnityEngine.Debug.Log(message:  "Zoom in (Could not find image or canvas group");
        if(this.rt != 0)
        {
            goto label_40;
        }
        
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.zero;
        if(this.fadeOutDelay == false)
        {
            goto label_43;
        }
        
        goto label_44;
        label_40:
        val_30 = this.rt;
        val_31 = null;
        label_9:
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_23 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_30, endValue:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, duration:  this.duration);
        if(this.fadeOutDelay != false)
        {
            
        }
        
        val_37 = 1152921528239422368;
        goto label_49;
        label_31:
        val_34 = this.rt;
        if(val_34 != null)
        {
            goto label_50;
        }
        
        label_33:
        label_50:
        val_35 = 0f;
        label_35:
        if(this.fadeOutDelay != false)
        {
                val_35 = this.timeToWait;
        }
        
        val_37 = 1152921528239422368;
        label_49:
        label_52:
        DG.Tweening.Tweener val_28 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  val_34.GetComponent<UnityEngine.UI.Image>(), endValue:  0f, duration:  this.duration), delay:  val_35), ease:  this.easeType), isIndependentUpdate:  true);
        return;
        label_43:
        label_44:
        DG.Tweening.Tweener val_29 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, duration:  this.duration), ease:  this.easeType), delay:  0f);
        goto label_52;
    }
    public FadeInAfterSeconds()
    {
        this.easeType = 27;
        this.duration = 1f;
        this.playOnStart = true;
        this.playOnEnable = true;
    }
    private void <FadeIn>b__13_0()
    {
        this.transform.GetComponent<UnityEngine.CanvasGroup>().blocksRaycasts = true;
    }
    private void <FadeIn>b__13_1()
    {
        this.rt.GetComponent<UnityEngine.CanvasGroup>().blocksRaycasts = true;
    }

}
