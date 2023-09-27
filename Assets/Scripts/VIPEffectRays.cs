using UnityEngine;
public class VIPEffectRays : MonoBehaviour
{
    // Fields
    private UnityEngine.CanvasGroup lightEffect;
    private UnityEngine.CanvasGroup ray;
    public VIPEffectRays.AnimSetData lightRotate;
    public VIPEffectRays.AnimSetData lightScale;
    public VIPEffectRays.AnimSetData lightFade;
    public VIPEffectRays.AnimSetData rayRotate;
    public VIPEffectRays.AnimSetData rayScale;
    public VIPEffectRays.AnimSetData rayFade;
    private System.Collections.Generic.List<DG.Tweening.Tweener> twList;
    
    // Methods
    private void OnEnable()
    {
        this.AddCanvasGroupAnim(target:  this.lightEffect, rotateSet:  this.lightRotate, scaleSet:  this.lightScale, fadeSet:  this.lightFade);
        this.AddCanvasGroupAnim(target:  this.ray, rotateSet:  this.rayRotate, scaleSet:  this.rayScale, fadeSet:  this.rayFade);
    }
    private void AddCanvasGroupAnim(UnityEngine.CanvasGroup target, VIPEffectRays.AnimSetData rotateSet, VIPEffectRays.AnimSetData scaleSet, VIPEffectRays.AnimSetData fadeSet)
    {
        float val_14;
        float val_15;
        UnityEngine.RectTransform val_1 = target.GetComponent<UnityEngine.RectTransform>();
        this.twList.Add(item:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DORotate(target:  val_1, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  rotateSet.duration, mode:  3), loops:  0, loopType:  0), ease:  rotateSet.ease));
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        val_1.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  scaleSet.value1);
        if(scaleSet != null)
        {
                val_14 = scaleSet.duration;
        }
        else
        {
                val_14 = 1.68059E-38f;
        }
        
        this.twList.Add(item:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOPunchScale(target:  val_1, punch:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  val_14, vibrato:  (int)scaleSet.value2, elasticity:  1f), loops:  0, loopType:  0), ease:  scaleSet.ease));
        target.alpha = 1f;
        if(fadeSet != null)
        {
                val_15 = fadeSet.value1;
        }
        else
        {
                val_15 = 1.437793E-38f;
        }
        
        this.twList.Add(item:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  target, endValue:  val_15, duration:  fadeSet.duration), loops:  0, loopType:  1), ease:  fadeSet.ease));
    }
    private void OnDisable()
    {
        if(this.twList == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = this.twList.GetEnumerator();
        label_4:
        if(((-1340541032) & 1) == 0)
        {
            goto label_2;
        }
        
        System.Type val_2 = 0.InitialType;
        if(val_2 == null)
        {
            goto label_4;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  val_2, complete:  false);
        goto label_4;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<DG.Tweening.Tweener>::Dispose(), rectTransform:  null, drivenProperties:  null);
        this = this.twList;
        this.Clear();
    }
    public VIPEffectRays()
    {
        VIPEffectRays.AnimSetData val_1 = null;
        .duration = 10f;
        .ease = 1;
        val_1 = new VIPEffectRays.AnimSetData();
        this.lightRotate = val_1;
        VIPEffectRays.AnimSetData val_2 = null;
        .duration = 10f;
        .ease = 1;
        val_2 = new VIPEffectRays.AnimSetData();
        this.lightScale = val_2;
        VIPEffectRays.AnimSetData val_3 = null;
        .duration = 10f;
        .ease = 1;
        val_3 = new VIPEffectRays.AnimSetData();
        this.lightFade = val_3;
        VIPEffectRays.AnimSetData val_4 = null;
        .duration = 10f;
        .ease = 1;
        val_4 = new VIPEffectRays.AnimSetData();
        this.rayRotate = val_4;
        VIPEffectRays.AnimSetData val_5 = null;
        .duration = 10f;
        .ease = 1;
        val_5 = new VIPEffectRays.AnimSetData();
        this.rayScale = val_5;
        VIPEffectRays.AnimSetData val_6 = null;
        .duration = 10f;
        .ease = 1;
        val_6 = new VIPEffectRays.AnimSetData();
        this.rayFade = val_6;
        this.twList = new System.Collections.Generic.List<DG.Tweening.Tweener>();
    }

}
