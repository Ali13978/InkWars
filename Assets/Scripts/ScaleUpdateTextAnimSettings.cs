using UnityEngine;
[Serializable]
public class UserBattleDataPanel.ScaleUpdateTextAnimSettings
{
    // Fields
    public float enlargeDuration;
    public DG.Tweening.Ease enlargeEase;
    public float textScale;
    public float updateTextDuration;
    public float updatedTextDisplayDelay;
    public float narrowDuration;
    public DG.Tweening.Ease narrowEase;
    public UnityEngine.Vector2 leftOffset;
    public UnityEngine.AudioClip starSound;
    
    // Methods
    public UserBattleDataPanel.ScaleUpdateTextAnimSettings()
    {
        this.enlargeDuration = 0.5f;
        this.enlargeEase = 27;
        this.narrowEase = 30;
        this.textScale = ;
        this.updateTextDuration = ;
        this.updatedTextDisplayDelay = 0.5f;
        this.narrowDuration = 0.5f;
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  50f, y:  -50f);
        this.leftOffset = val_1.x;
        mem[1152921529072697360] = val_1.y;
    }

}
