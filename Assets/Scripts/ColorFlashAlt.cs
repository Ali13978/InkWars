using UnityEngine;
public class ColorFlashAlt : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image m_Image;
    private float m_FinalValue;
    private float m_Length;
    private DG.Tweening.Ease m_Ease;
    private bool m_Flash;
    private UnityEngine.Color cOriginal;
    private UnityEngine.Color cTarget;
    private DG.Tweening.Tween flash;
    
    // Properties
    private UnityEngine.UI.Image Image { get; }
    
    // Methods
    private UnityEngine.UI.Image get_Image()
    {
        UnityEngine.UI.Image val_3;
        if(this.m_Image == 0)
        {
                this.m_Image = this.GetComponent<UnityEngine.UI.Image>();
            return val_3;
        }
        
        val_3 = this.m_Image;
        return val_3;
    }
    private void Awake()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.Image.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = 0f};
        UnityEngine.Color val_4 = this.Image.color;
        this.cOriginal = val_4;
        mem[1152921528427753332] = val_4.g;
        mem[1152921528427753336] = val_4.b;
        mem[1152921528427753340] = val_4.a;
        this.cTarget = val_4;
        mem[1152921528427753348] = val_4.g;
        mem[1152921528427753352] = val_4.b;
        mem[1152921528427753356] = this.m_FinalValue;
    }
    public void ToggleFlash()
    {
        this.m_Flash = this.m_Flash ^ 1;
        if(this.m_Flash != false)
        {
                this.StopFlash();
            return;
        }
        
        this.Flash();
    }
    public void Flash()
    {
        this.StopFlash();
        this.flash = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOColor(target:  this.Image, endValue:  new UnityEngine.Color() {r = this.cTarget}, duration:  this.m_Length), ease:  this.m_Ease), loops:  0, loopType:  1);
    }
    public void StopFlash()
    {
        DG.Tweening.Tween val_1 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tween>(t:  this.flash, loops:  0);
        DG.Tweening.TweenExtensions.Complete(t:  this.flash);
        DG.Tweening.TweenExtensions.Kill(t:  this.flash, complete:  false);
        if(this.Image == 0)
        {
                return;
        }
        
        this.Image.color = new UnityEngine.Color() {r = this.cOriginal, g = V9.16B, b = V10.16B, a = V11.16B};
    }
    private void OnValidate()
    {
        float val_5 = 1f;
        if(this.m_FinalValue > val_5)
        {
            goto label_1;
        }
        
        val_5 = 0f;
        if(this.m_FinalValue >= 0)
        {
            goto label_2;
        }
        
        label_1:
        this.m_FinalValue = val_5;
        label_2:
        if(this.m_Length <= 0f)
        {
                this.m_Length = 0.1f;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.Image)) == false)
        {
                return;
        }
        
        UnityEngine.Color val_4 = this.Image.color;
        this.cOriginal = val_4;
        mem[1152921528428307828] = val_4.g;
        mem[1152921528428307832] = val_4.b;
        mem[1152921528428307836] = val_4.a;
        mem[1152921528428307852] = this.m_FinalValue;
    }
    public ColorFlashAlt()
    {
        this.m_FinalValue = 1f;
        this.m_Length = 0.5f;
        this.m_Ease = 4;
    }

}
