using UnityEngine;
public class PostMatchStarAnim : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image img;
    private UnityEngine.RectTransform rt;
    public float distScale;
    
    // Methods
    private void Start()
    {
        this.img = this.GetComponent<UnityEngine.UI.Image>();
        this.rt = this.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  UnityEngine.Random.value * 360f);
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.left;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        UnityEngine.Vector3 val_8 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  0.2f);
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  this.distScale);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  (float)UnityEngine.Screen.height);
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  UnityEngine.Random.value + 0.5f);
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        UnityEngine.Vector2 val_17 = this.rt.anchoredPosition;
        UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}, b:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
        UnityEngine.Color val_19 = UnityEngine.Color.clear;
        this.img.color = new UnityEngine.Color() {r = val_19.r, g = val_19.g, b = val_19.b, a = val_19.a};
        DG.Tweening.Sequence val_20 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  val_20, delay:  0.3f);
        UnityEngine.Color val_22 = UnityEngine.Color.white;
        DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_20, t:  DG.Tweening.ShortcutExtensions46.DOColor(target:  this.img, endValue:  new UnityEngine.Color() {r = val_22.r, g = val_22.g, b = val_22.b, a = val_22.a}, duration:  0.001f));
        float val_26 = UnityEngine.Random.value * 360f;
        DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_20, t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this.rt, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.001f, mode:  0));
        DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_20, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.rt, endValue:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y}, duration:  1f, snapping:  false), ease:  21), isIndependentUpdate:  true));
        DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_20, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.img, endValue:  0f, duration:  1f), ease:  1));
        DG.Tweening.Sequence val_37 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_20, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void PostMatchStarAnim::<Start>b__3_0()));
    }
    public PostMatchStarAnim()
    {
        this.distScale = 1f;
    }
    private void <Start>b__3_0()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
