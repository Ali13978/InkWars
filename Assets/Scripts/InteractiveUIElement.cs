using UnityEngine;
public abstract class InteractiveUIElement : MonoBehaviour
{
    // Fields
    protected InteractiveUIElement.Variables m_Variables;
    
    // Properties
    public InteractiveUIElement.Variables Options { get; set; }
    
    // Methods
    public InteractiveUIElement.Variables get_Options()
    {
        return (Variables)this.m_Variables;
    }
    public void set_Options(InteractiveUIElement.Variables value)
    {
        this.m_Variables = value;
    }
    protected virtual void Awake()
    {
        this.SetupComponents();
    }
    protected virtual void Start()
    {
        if(this.m_Variables.AnimateFromStart == false)
        {
                return;
        }
        
        this.InitializeSequence();
        this = ???;
        goto typeof(InteractiveUIElement).__il2cppRuntimeField_1A8;
    }
    private void SetupComponents()
    {
        Variables val_15;
        UnityEngine.Object val_16;
        val_15 = 1152921504858337280;
        if(0 == this.m_Variables.MainPanel)
        {
                this.m_Variables.MainPanel = this.GetComponent<UnityEngine.RectTransform>();
        }
        
        if(0 == this.m_Variables.Transparency)
        {
                this.m_Variables.Transparency = this.m_Variables.MainPanel.GetComponent<UnityEngine.CanvasGroup>();
        }
        
        if(0 == this.m_Variables.Image)
        {
                this.m_Variables.Image = this.m_Variables.MainPanel.GetComponent<UnityEngine.UI.Image>();
        }
        
        if(0 == this.m_Variables.Image)
        {
                this.m_Variables.Image = this.m_Variables.MainPanel.GetComponentInChildren<UnityEngine.UI.Image>();
        }
        
        val_16 = this.m_Variables.Image;
        if(0 != val_16)
        {
                UnityEngine.Vector3 val_11 = this.m_Variables.Image.rectTransform.localScale;
            this.m_Variables.OriginalImageScale = val_11;
            mem2[0] = val_11.y;
            mem2[0] = val_11.z;
            val_15 = this.m_Variables;
            val_16 = 0;
            UnityEngine.Vector2 val_13 = this.m_Variables.Image.rectTransform.anchoredPosition;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
            this.m_Variables.OriginalImageAnchoredPosition = val_14;
            mem2[0] = val_14.y;
            mem2[0] = val_14.z;
        }
    
    }
    public abstract void InitializeLocalVariables(); // 0
    protected virtual void ResetVisualFieldValues()
    {
        Variables val_4;
        this.m_Variables.Image.rectTransform.localScale = new UnityEngine.Vector3() {x = this.m_Variables.OriginalImageScale, y = V9.16B, z = V10.16B};
        if(0 == this.m_Variables.Transparency)
        {
                return;
        }
        
        val_4 = this.m_Variables;
        if(this.m_Variables != null)
        {
            goto label_9;
        }
        
        val_4 = this.m_Variables;
        if(val_4 == null)
        {
            goto label_10;
        }
        
        label_9:
        this.m_Variables.Transparency.alpha = (this.m_Variables.HideOnStart == true) ? 0f : 1f;
        return;
        label_10:
    }
    protected void InitializeSequence()
    {
        Variables val_7;
        this.ResetSequence();
        val_7 = this.m_Variables;
        if(this.m_Variables == null)
        {
                val_7 = this.m_Variables;
        }
        
        if(this.m_Variables.Looping != false)
        {
                DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), isIndependentUpdate:  true), loops:  0, loopType:  this.m_Variables.LoopType), ease:  this.m_Variables.Ease);
        }
        
        this.m_Variables.MainSequence = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), isIndependentUpdate:  true);
    }
    private void ResetSequence()
    {
        if(this.m_Variables.MainSequence == null)
        {
                return;
        }
        
        if(this.m_Variables.Looping != false)
        {
                DG.Tweening.Sequence val_1 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  this.m_Variables.MainSequence, loops:  0);
            DG.Tweening.TweenExtensions.Complete(t:  this.m_Variables.MainSequence);
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.m_Variables.MainSequence, complete:  false);
    }
    public abstract void Animate(); // 0
    public void StopAnimation()
    {
        this.ResetSequence();
        goto typeof(InteractiveUIElement).__il2cppRuntimeField_198;
    }
    public abstract void Hide(); // 0
    protected virtual void OnValidate()
    {
        if(UnityEngine.Application.isPlaying != true)
        {
                this.SetupComponents();
        }
        
        if(this.m_Variables.ScaleMultiplier > 0f)
        {
                return;
        }
        
        this = this.m_Variables;
        this.m_Variables.ScaleMultiplier = 0.1f;
    }
    protected InteractiveUIElement()
    {
        InteractiveUIElement.Variables val_1 = null;
        .Interactable = true;
        .BlockRaycasts = true;
        .ScaleMultiplier = 1f;
        val_1 = new InteractiveUIElement.Variables();
        this.m_Variables = val_1;
    }

}
