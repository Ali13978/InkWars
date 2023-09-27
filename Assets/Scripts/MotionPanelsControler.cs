using UnityEngine;
public class MotionPanelsControler : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<MotionPanleAnimation> m_motionPanelAnims;
    private AnimationType m_animation;
    private bool m_isBiDirectional;
    private UnityEngine.UI.Button m_executer;
    public MotionPanelsControler.PreCondition m_preCondition;
    private uint m_state;
    
    // Methods
    private void OnEnable()
    {
        if(0 == this.m_executer)
        {
                return;
        }
        
        this.m_executer.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void MotionPanelsControler::CheckConditions()));
    }
    private void OnDisable()
    {
        if(0 == this.m_executer)
        {
                return;
        }
        
        this.m_executer.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void MotionPanelsControler::CheckConditions()));
    }
    public void MoveTo(UnityEngine.RectTransform trans, UnityEngine.Vector2 pos, float duration, DG.Tweening.Ease ease)
    {
        DG.Tweening.Tweener val_2 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  trans, endValue:  new UnityEngine.Vector2() {x = pos.x, y = pos.y}, duration:  duration, snapping:  false), ease:  ease);
    }
    public void CheckConditions()
    {
        if(this.m_preCondition != null)
        {
                if(this.m_preCondition.Invoke() == false)
        {
                return;
        }
        
        }
        
        this.Animate();
    }
    public void Animate()
    {
        if(this.m_isBiDirectional == false)
        {
            goto label_0;
        }
        
        if(this.m_state == 0)
        {
            goto label_1;
        }
        
        DG.Tweening.Sequence val_1 = this.MovetoStart();
        goto label_2;
        label_0:
        DG.Tweening.Sequence val_2 = this.MovetoEnd();
        return;
        label_1:
        DG.Tweening.Sequence val_3 = this.MovetoEnd();
        label_2:
        uint val_4 = ~this.m_state;
        val_4 = val_4 & 1;
        this.m_state = val_4;
    }
    public DG.Tweening.Sequence MovetoEnd()
    {
        var val_4;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        List.Enumerator<T> val_2 = this.m_motionPanelAnims.GetEnumerator();
        label_16:
        if(((-1749989696) & 1) == 0)
        {
            goto label_4;
        }
        
        System.Type val_5 = val_4.InitialType;
        if(this.m_animation == 0)
        {
            goto label_5;
        }
        
        if(this.m_animation != 1)
        {
            goto label_16;
        }
        
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = V10.16B, y = V8.16B, z = V9.16B});
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  X22.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, duration:  V9.16B, snapping:  false), ease:  0));
        goto label_16;
        label_5:
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = V10.16B, y = V8.16B, z = V9.16B});
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  X22.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, duration:  V9.16B, snapping:  false), ease:  0));
        goto label_16;
        label_4:
        val_4.Add(driver:  public System.Void List.Enumerator<MotionPanleAnimation>::Dispose(), rectTransform:  null, drivenProperties:  null);
        return val_1;
    }
    public DG.Tweening.Sequence MoveTo(bool toEnd)
    {
        if(toEnd == false)
        {
                return this.MovetoStart();
        }
        
        return this.MovetoEnd();
    }
    public DG.Tweening.Sequence MovetoStart()
    {
        var val_4;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        List.Enumerator<T> val_2 = this.m_motionPanelAnims.GetEnumerator();
        label_16:
        if(((-1749667392) & 1) == 0)
        {
            goto label_4;
        }
        
        System.Type val_5 = val_4.InitialType;
        if(this.m_animation == 0)
        {
            goto label_5;
        }
        
        if(this.m_animation != 1)
        {
            goto label_16;
        }
        
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = V10.16B, y = V8.16B, z = V9.16B});
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  X22.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, duration:  V9.16B, snapping:  false), ease:  0));
        goto label_16;
        label_5:
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = V10.16B, y = V8.16B, z = V9.16B});
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  X22.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, duration:  V9.16B, snapping:  false), ease:  0));
        goto label_16;
        label_4:
        val_4.Add(driver:  public System.Void List.Enumerator<MotionPanleAnimation>::Dispose(), rectTransform:  null, drivenProperties:  null);
        return val_1;
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public MotionPanelsControler()
    {
    
    }

}
