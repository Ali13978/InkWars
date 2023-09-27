using UnityEngine;
public class ChainBounce : MonoBehaviour
{
    // Fields
    public UnityEngine.AnimationCurve customEase;
    private System.Collections.Generic.List<UnityEngine.RectTransform> rectTransList;
    private DG.Tweening.Sequence chainAnimSequence;
    
    // Methods
    private void Awake()
    {
        var val_3 = null;
        if((ChainBounce.<>c.<>9__3_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        int val_1 = this.rectTransList.RemoveAll(match:  ChainBounce.<>c.<>9__3_0);
        return;
        label_3:
        ChainBounce.<>c.<>9__3_0 = new System.Predicate<UnityEngine.RectTransform>(object:  ChainBounce.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ChainBounce.<>c::<Awake>b__3_0(UnityEngine.RectTransform x));
        if(this.rectTransList != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    public void SetInitScale(float initScale)
    {
        List.Enumerator<T> val_1 = this.rectTransList.GetEnumerator();
        label_6:
        if(((-1472011256) & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(d:  initScale, a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        0.InitialType.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        goto label_6;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.RectTransform>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    public DG.Tweening.Sequence PlayAnimation(float fromScale = 0, float toScale = 1, float duration = 0.5, float delay = 0.1)
    {
        var val_10;
        if(this.chainAnimSequence != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.chainAnimSequence, complete:  false);
        }
        
        this.chainAnimSequence = DG.Tweening.DOTween.Sequence();
        val_10 = 0;
        goto label_4;
        label_11:
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  fromScale);
        this.rectTransList.Item[0].localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        float val_10 = 0f;
        val_10 = val_10 * delay;
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.chainAnimSequence, atPosition:  val_10, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rectTransList.Item[0], endValue:  toScale, duration:  duration), animCurve:  this.customEase));
        val_10 = 1;
        label_4:
        if(val_10 < this.rectTransList.Count)
        {
            goto label_11;
        }
        
        return (DG.Tweening.Sequence)this.chainAnimSequence;
    }
    public DG.Tweening.Sequence PlayAnimationAlpha(float fromScale = 0, float toScale = 1, float duration = 0.5, float delay = 0.1)
    {
        UnityEngine.RectTransform val_8;
        if(this.chainAnimSequence != null)
        {
                val_8 = 0;
            DG.Tweening.TweenExtensions.Kill(t:  this.chainAnimSequence, complete:  false);
        }
        
        this.chainAnimSequence = DG.Tweening.DOTween.Sequence();
        List.Enumerator<T> val_2 = this.rectTransList.GetEnumerator();
        goto label_9;
        label_10:
        UnityEngine.CanvasGroup val_4 = 0.InitialType.GetComponent<UnityEngine.CanvasGroup>();
        val_8 = 0;
        if(0 != val_4)
        {
                float val_8 = 0f;
            val_8 = val_8 * delay;
            val_8 = 0;
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.chainAnimSequence, atPosition:  val_8, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  val_4, endValue:  toScale, duration:  duration));
        }
        
        label_9:
        if(((-1471635736) & 1) != 0)
        {
            goto label_10;
        }
        
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.RectTransform>::Dispose(), rectTransform:  val_8, drivenProperties:  null);
        return (DG.Tweening.Sequence)this.chainAnimSequence;
    }
    public ChainBounce()
    {
        this.rectTransList = new System.Collections.Generic.List<UnityEngine.RectTransform>();
    }

}
