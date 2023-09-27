using UnityEngine;
public class ToggleScaleAnimator : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Toggle button;
    private UnityEngine.UI.Image m_activeImage;
    private UnityEngine.UI.Image m_inActiveImage;
    private UnityEngine.UI.Image m_imageBG;
    private float m_animationDuration;
    
    // Methods
    private void Awake()
    {
        this.button = this.GetComponent<UnityEngine.UI.Toggle>();
    }
    private void Start()
    {
        this.SetEnable(enabled:  this.button.isOn);
        if(this.button.isOn == false)
        {
                return;
        }
        
        MainThreadDispatcher.Invoke(action:  new System.Action(object:  this, method:  System.Void ToggleScaleAnimator::<Start>b__6_0()), delay:  0.1f);
    }
    private void OnEnable()
    {
        this.button.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void ToggleScaleAnimator::OnToggleValueChange(bool value)));
    }
    private void OnDisable()
    {
        this.button.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void ToggleScaleAnimator::OnToggleValueChange(bool value)));
    }
    private void OnToggleValueChange(bool value)
    {
        var val_18;
        var val_19;
        ToggleScaleAnimator.<>c__DisplayClass9_0 val_1 = new ToggleScaleAnimator.<>c__DisplayClass9_0();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        bool val_2 = value;
        val_18 = val_1;
        .value = val_2;
        mem[1152921528935697488] = this;
        if(val_2 == false)
        {
            goto label_2;
        }
        
        label_13:
        DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector2 val_5 = this.m_imageBG.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
        UnityEngine.Vector2 val_7 = this.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
        if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y})) > 500f)
        {
                this.m_animationDuration = 0.3f;
        }
        
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void ToggleScaleAnimator.<>c__DisplayClass9_0::<OnToggleValueChange>b__0()));
        UnityEngine.Vector2 val_13 = this.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.m_imageBG.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, duration:  this.m_animationDuration, snapping:  false));
        return;
        label_1:
        mem[16] = this;
        val_18 = 24;
        mem[24] = value;
        if(mem[24] == true)
        {
            goto label_13;
        }
        
        label_2:
        if(val_1 != null)
        {
                val_19 = 0;
        }
        
        this.SetEnable(enabled:  (mem[24] == true) ? 1 : 0);
    }
    private void SetEnable(bool enabled)
    {
        this.m_inActiveImage.gameObject.SetActive(value:  (~enabled) & 1);
        this.m_activeImage.gameObject.SetActive(value:  enabled);
    }
    public ToggleScaleAnimator()
    {
        this.m_animationDuration = 0.5f;
    }
    private void <Start>b__6_0()
    {
        this.OnToggleValueChange(value:  this.button.isOn);
    }

}
