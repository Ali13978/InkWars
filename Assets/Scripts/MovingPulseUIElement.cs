using UnityEngine;
public class MovingPulseUIElement : InteractiveUIElement
{
    // Fields
    private UnityEngine.Vector2 m_PulsingOffset;
    private bool m_FlipX;
    private bool m_FlipY;
    
    // Methods
    public override void InitializeLocalVariables()
    {
        Variables val_1 = this.Options;
        Variables val_3 = this.Options;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.OriginalImageAnchoredPosition, y = V8.16B, z = V9.16B});
        val_1.Image.rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
    }
    public override void Animate()
    {
        Variables val_1 = this.Options;
        Variables val_2 = this.Options;
        UnityEngine.Vector2 val_9 = this.m_PulsingOffset;
        val_9 = (this.m_FlipX == true) ? (-val_9) : (val_9);
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_9, y:  (this.m_FlipY == true) ? (-S1) : (S1));
        Variables val_6 = this.Options;
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1.MainSequence, t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  val_2.Image.rectTransform, endValue:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, duration:  val_6.LoopDuration, snapping:  false));
    }
    public override void Hide()
    {
    
    }
    protected override void OnValidate()
    {
        this.OnValidate();
        if(this.m_PulsingOffset < 0)
        {
                this.m_PulsingOffset = 0;
        }
        
        if(this.m_PulsingOffset >= 0)
        {
                return;
        }
        
        mem[1152921528548917140] = 0;
    }
    public MovingPulseUIElement()
    {
    
    }

}
