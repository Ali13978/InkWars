using UnityEngine;
public class StarSpinAnim : MonoBehaviour
{
    // Fields
    private UnityEngine.SpriteRenderer starTemplate;
    private System.Collections.Generic.List<UnityEngine.Transform> path;
    public float spinDuration;
    private System.Collections.Generic.List<DG.Tweening.Tween> animList;
    private System.Collections.Generic.List<UnityEngine.GameObject> starList;
    private float cd;
    
    // Methods
    private UnityEngine.Vector3[] GetLocalPath()
    {
        System.Collections.Generic.List<UnityEngine.Vector3> val_1 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        List.Enumerator<T> val_2 = this.path.GetEnumerator();
        label_5:
        if(((-1324932792) & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Vector3 val_4 = 0.InitialType.localPosition;
        val_1.Add(item:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        goto label_5;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.Transform>::Dispose(), rectTransform:  null, drivenProperties:  null);
        if(val_1 != null)
        {
                return (UnityEngine.Vector3[])val_1.ToArray();
        }
        
        return (UnityEngine.Vector3[])val_1.ToArray();
    }
    private void OnEnable()
    {
        var val_7;
        this.CleanAnimList();
        this.transform.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.animList.Add(item:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.6f, mode:  0), loops:  0, loopType:  1));
        this.GetComponent<UnityEngine.SpriteRenderer>().sortingOrder = 10;
        val_7 = 0;
        goto label_4;
        label_8:
        this.GetComponentsInChildren<UnityEngine.SpriteRenderer>(includeInactive:  true)[0].sortingOrder = 11;
        val_7 = 1;
        label_4:
        if(val_7 < val_6.Length)
        {
            goto label_8;
        }
    
    }
    private void OnDisable()
    {
        this.CleanAnimList();
    }
    private void Update()
    {
        if(this.cd > 0f)
        {
                float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.cd - val_1;
            this.cd = val_1;
            return;
        }
        
        float val_2 = UnityEngine.Random.Range(min:  0.4f, max:  0.7f);
        val_2 = val_2 * this.spinDuration;
        this.cd = val_2;
        this.SpinStar();
    }
    private void CleanAnimList()
    {
        var val_3;
        List.Enumerator<T> val_1 = this.animList.GetEnumerator();
        label_4:
        if(((-1324277936) & 1) == 0)
        {
            goto label_2;
        }
        
        System.Type val_4 = val_3.InitialType;
        if(val_4 == null)
        {
            goto label_4;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  val_4, complete:  false);
        goto label_4;
        label_2:
        val_3.Add(driver:  public System.Void List.Enumerator<DG.Tweening.Tween>::Dispose(), rectTransform:  null, drivenProperties:  null);
        this.animList.Clear();
        List.Enumerator<T> val_5 = this.starList.GetEnumerator();
        label_18:
        if(((-1324277960) & 1) == 0)
        {
            goto label_11;
        }
        
        System.Type val_6 = 0.InitialType;
        if(0 == val_6)
        {
            goto label_18;
        }
        
        UnityEngine.Object.Destroy(obj:  val_6.gameObject);
        goto label_18;
        label_11:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.GameObject>::Dispose(), rectTransform:  0, drivenProperties:  null);
        this.starList.Clear();
    }
    private void SpinStar()
    {
        .<>4__this = this;
        UnityEngine.Vector3 val_3 = this.starTemplate.transform.position;
        UnityEngine.Quaternion val_5 = this.starTemplate.transform.rotation;
        UnityEngine.SpriteRenderer val_8 = UnityEngine.Object.Instantiate<UnityEngine.SpriteRenderer>(original:  this.starTemplate, position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, parent:  this.starTemplate.transform.parent);
        .star = val_8;
        val_8.gameObject.SetActive(value:  true);
        this.starList.Add(item:  (StarSpinAnim.<>c__DisplayClass11_0)[1152921529052731664].star.gameObject);
        DG.Tweening.Sequence val_11 = DG.Tweening.DOTween.Sequence();
        .anim = val_11;
        float val_26 = this.spinDuration;
        val_26 = val_26 * 1.5f;
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_11, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalPath(target:  (StarSpinAnim.<>c__DisplayClass11_0)[1152921529052731664].star.transform, path:  this.GetLocalPath(), duration:  val_26, pathType:  0, pathMode:  3, resolution:  10, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), ease:  4));
        DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Join(s:  (StarSpinAnim.<>c__DisplayClass11_0)[1152921529052731664].anim, t:  DG.Tweening.ShortcutExtensions43.DOFade(target:  (StarSpinAnim.<>c__DisplayClass11_0)[1152921529052731664].star, endValue:  1f, duration:  this.spinDuration * 0.25f));
        float val_27 = this.spinDuration;
        val_27 = val_27 * 1.2f;
        DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Join(s:  (StarSpinAnim.<>c__DisplayClass11_0)[1152921529052731664].anim, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions43.DOFade(target:  (StarSpinAnim.<>c__DisplayClass11_0)[1152921529052731664].star, endValue:  0f, duration:  this.spinDuration * 0.25f), delay:  val_27));
        DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  (StarSpinAnim.<>c__DisplayClass11_0)[1152921529052731664].anim, action:  new DG.Tweening.TweenCallback(object:  new StarSpinAnim.<>c__DisplayClass11_0(), method:  System.Void StarSpinAnim.<>c__DisplayClass11_0::<SpinStar>b__0()));
        this.animList.Add(item:  (StarSpinAnim.<>c__DisplayClass11_0)[1152921529052731664].anim);
    }
    public StarSpinAnim()
    {
        this.path = new System.Collections.Generic.List<UnityEngine.Transform>();
        this.spinDuration = 0.6f;
        this.animList = new System.Collections.Generic.List<DG.Tweening.Tween>();
        this.starList = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
