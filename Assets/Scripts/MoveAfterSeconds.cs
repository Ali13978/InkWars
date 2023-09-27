using UnityEngine;
public class MoveAfterSeconds : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector3 targetPosition;
    public DG.Tweening.Ease easeType;
    public float timeToWait;
    public float duration;
    public bool playOnStart;
    public bool playOnEnable;
    public bool from;
    public bool local;
    private UnityEngine.RectTransform rt;
    private UnityEngine.Vector3 originalPosition;
    
    // Methods
    private void Awake()
    {
        UnityEngine.RectTransform val_8;
        UnityEngine.RectTransform val_9;
        UnityEngine.RectTransform val_1 = this.GetComponent<UnityEngine.RectTransform>();
        this.rt = val_1;
        if(this.local == false)
        {
            goto label_1;
        }
        
        if(val_1 == 0)
        {
            goto label_4;
        }
        
        val_8 = this.rt;
        if(val_8 != null)
        {
            goto label_12;
        }
        
        goto label_6;
        label_1:
        if(val_1 == 0)
        {
            goto label_9;
        }
        
        val_9 = this.rt;
        if(val_9 != null)
        {
            goto label_14;
        }
        
        goto label_11;
        label_4:
        val_8 = this.transform;
        if(val_8 != null)
        {
            goto label_12;
        }
        
        label_6:
        label_12:
        UnityEngine.Vector3 val_5 = val_8.localPosition;
        goto label_13;
        label_9:
        val_9 = this.transform;
        if(val_9 != null)
        {
            goto label_14;
        }
        
        label_11:
        label_14:
        UnityEngine.Vector3 val_7 = val_9.position;
        label_13:
        this.originalPosition = val_7;
        mem[1152921528542929252] = val_7.y;
        mem[1152921528542929256] = val_7.z;
    }
    private void Start()
    {
        if(this.playOnStart == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "Play " + this.name + " move after start");
        this.MoveToTargetPosition(onDone:  0);
    }
    private void OnEnable()
    {
        if(this.playOnEnable == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "Play " + this.name + " move after enabling object");
        this.MoveToTargetPosition(onDone:  0);
    }
    public void MoveToTargetPosition(DG.Tweening.TweenCallback onDone)
    {
        UnityEngine.RectTransform val_19;
        UnityEngine.RectTransform val_20;
        if(this.from == false)
        {
            goto label_1;
        }
        
        UnityEngine.Debug.Log(message:  "Moving in from " + this.targetPosition);
        if(this.rt != 0)
        {
            goto label_6;
        }
        
        UnityEngine.Transform val_3 = this.transform;
        goto label_7;
        label_1:
        if(this.rt != 0)
        {
            goto label_10;
        }
        
        UnityEngine.Transform val_5 = this.transform;
        goto label_11;
        label_6:
        val_19 = this.rt;
        label_7:
        if(this.local != false)
        {
                DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_19, endValue:  new UnityEngine.Vector3() {x = this.targetPosition}, duration:  this.duration, snapping:  false);
        }
        
        DG.Tweening.Tweener val_12 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  val_19, endValue:  new UnityEngine.Vector3() {x = this.targetPosition}, duration:  this.duration, snapping:  false), delay:  this.timeToWait), ease:  this.easeType), isIndependentUpdate:  true)), action:  onDone);
        return;
        label_10:
        val_20 = this.rt;
        label_11:
        if(this.local != false)
        {
                DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_20, endValue:  new UnityEngine.Vector3() {x = this.targetPosition}, duration:  this.duration, snapping:  false);
        }
        
        DG.Tweening.Tweener val_18 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  val_20, endValue:  new UnityEngine.Vector3() {x = this.targetPosition}, duration:  this.duration, snapping:  false), delay:  this.timeToWait), ease:  this.easeType), isIndependentUpdate:  true), action:  onDone);
    }
    public void MoveToOriginalPosition(DG.Tweening.TweenCallback onDone)
    {
        UnityEngine.RectTransform val_8;
        if(this.rt == 0)
        {
                UnityEngine.Transform val_2 = this.transform;
        }
        else
        {
                val_8 = this.rt;
        }
        
        if(this.local != false)
        {
                DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_8, endValue:  new UnityEngine.Vector3() {x = this.originalPosition}, duration:  this.duration, snapping:  false);
        }
        
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  val_8, endValue:  new UnityEngine.Vector3() {x = this.originalPosition}, duration:  this.duration, snapping:  false), ease:  this.easeType), isIndependentUpdate:  true), action:  onDone);
    }
    public MoveAfterSeconds()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.targetPosition = val_1;
        mem[1152921528543821340] = val_1.y;
        mem[1152921528543821344] = val_1.z;
        this.easeType = 27;
        this.duration = 1f;
        this.playOnStart = true;
        this.playOnEnable = true;
    }

}
