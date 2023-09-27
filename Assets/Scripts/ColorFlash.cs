using UnityEngine;
public class ColorFlash : MonoBehaviour
{
    // Fields
    private UnityEngine.SpriteRenderer m_SpriteRenderer;
    private UnityEngine.UI.Image m_Image;
    private UnityEngine.Material material;
    private UnityEngine.Material m_FlashMaterial;
    private string m_ShaderName;
    private string m_ShaderProperty;
    private float m_ShaderPropertyDefaultValue;
    private float m_FinalValue;
    private float m_Length;
    private DG.Tweening.Ease m_Ease;
    private bool m_IsSprite;
    private bool m_IsFlashing;
    private bool m_FlashFromStart;
    private DG.Tweening.Tween m_FlashAnimation;
    
    // Properties
    public UnityEngine.Color color { get; set; }
    
    // Methods
    public UnityEngine.Color get_color()
    {
        if(this.m_IsSprite != false)
        {
                if(this.m_SpriteRenderer != null)
        {
                return this.m_SpriteRenderer.color;
        }
        
            return this.m_SpriteRenderer.color;
        }
        
        if(this.m_Image != null)
        {
                return this.m_Image.color;
        }
        
        return this.m_Image.color;
    }
    public void set_color(UnityEngine.Color value)
    {
        if(this.m_IsSprite != false)
        {
                this.m_SpriteRenderer.color = new UnityEngine.Color() {r = value.r, g = value.g, b = value.b, a = value.a};
            return;
        }
        
        this.m_Image.color = new UnityEngine.Color() {r = value.r, g = value.g, b = value.b, a = value.a};
    }
    private void Awake()
    {
        if(this.m_IsSprite == false)
        {
            goto label_1;
        }
        
        UnityEngine.SpriteRenderer val_1 = this.GetComponent<UnityEngine.SpriteRenderer>();
        this.m_SpriteRenderer = val_1;
        if(val_1 != null)
        {
            goto label_3;
        }
        
        label_4:
        label_3:
        this.material = 0.GetComponent<UnityEngine.Material>();
        return;
        label_1:
        UnityEngine.UI.Image val_3 = this.GetComponent<UnityEngine.UI.Image>();
        this.m_Image = val_3;
        if(val_3 != null)
        {
            goto label_3;
        }
        
        goto label_4;
    }
    private void Start()
    {
        UnityEngine.Material val_4;
        if((UnityEngine.Object.op_Implicit(exists:  this.m_FlashMaterial)) != false)
        {
                val_4 = this.m_FlashMaterial;
        }
        else
        {
                val_4 = new UnityEngine.Material();
            val_4 = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  this.m_ShaderName));
            this.m_FlashMaterial = val_4;
        }
        
        this.material = val_4;
        if(this.m_IsSprite != false)
        {
                this.m_SpriteRenderer.material = new UnityEngine.Material();
        }
        
        if(this.m_FlashFromStart == false)
        {
                return;
        }
        
        this.Flash();
    }
    public void ToggleFlash()
    {
        if(this.m_IsFlashing != false)
        {
                UnityEngine.Debug.Log(message:  ">> Stopping Flash");
            this.StopFlash();
            return;
        }
        
        UnityEngine.Debug.Log(message:  ">> Beginning Flash");
        this.Flash();
    }
    public void Flash()
    {
        if(this.m_IsFlashing == true)
        {
                return;
        }
        
        this.StopFlash();
        if(0 != this.material)
        {
                this.m_FlashAnimation = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOFloat(target:  this.material, endValue:  this.m_FinalValue, property:  this.m_ShaderProperty, duration:  this.m_Length), ease:  this.m_Ease), loops:  0, loopType:  1);
        }
        
        this.m_IsFlashing = true;
    }
    public void StopFlash()
    {
        if(this.m_IsFlashing == false)
        {
                return;
        }
        
        DG.Tweening.Tween val_1 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tween>(t:  this.m_FlashAnimation, loops:  0);
        DG.Tweening.TweenExtensions.Complete(t:  this.m_FlashAnimation);
        DG.Tweening.TweenExtensions.Kill(t:  this.m_FlashAnimation, complete:  false);
        if(0 != this.material)
        {
                this.material.SetFloat(name:  this.m_ShaderProperty, value:  this.m_ShaderPropertyDefaultValue);
        }
        
        this.m_IsFlashing = false;
    }
    private void OnValidate()
    {
        if(this.m_Length > 0f)
        {
                return;
        }
        
        this.m_Length = 0.1f;
    }
    public ColorFlash()
    {
        this.m_ShaderName = "Sprites/SpriteWithFlash";
        this.m_FinalValue = 1f;
        this.m_Length = 0.5f;
        this.m_Ease = 4;
        this.m_ShaderProperty = "_FlashAmount";
        this.m_IsSprite = true;
    }

}
