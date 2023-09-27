using UnityEngine;
public class StationaryPulseUIElement : InteractiveUIElement
{
    // Methods
    public override void InitializeLocalVariables()
    {
    
    }
    public override void Animate()
    {
        Variables val_1 = this.Options;
        Variables val_2 = this.Options;
        Variables val_4 = this.Options;
        Variables val_5 = this.Options;
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1.MainSequence, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_2.Image.rectTransform, endValue:  val_4.ScaleMultiplier, duration:  val_5.LoopDuration));
    }
    public override void Hide()
    {
    
    }
    public StationaryPulseUIElement()
    {
    
    }

}
