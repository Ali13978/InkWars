using UnityEngine;
[Serializable]
public class DynamicMessageUIConstants : ScriptableObject
{
    // Fields
    public UnityEngine.Color HitComboColorGreen;
    public UnityEngine.Color HitComboColorYellow;
    public UnityEngine.Color HitComboColorOrange;
    public UnityEngine.Color HitComboColorRed;
    public UnityEngine.Color ComboTechniquePositive;
    public UnityEngine.Color ComboTechniqueNegative;
    public UnityEngine.Color ComboTechniqueSpecial;
    public float TimeToFadeOut;
    public float HitCountAnimationInLength;
    public float HitCountAnimationOutLength;
    public DG.Tweening.Ease HitCountAnimationEase;
    public float ReactionAnimationInLength;
    public float ReactionAnimationOutLength;
    public DG.Tweening.Ease ReactionAnimationEase;
    public float TechniqueAnimationInLength;
    public float TechniqueAnimationOutLength;
    public DG.Tweening.Ease TechniqueAnimationEase;
    public UnityEngine.AudioClip[] AudioClips;
    
    // Methods
    public DynamicMessageUIConstants()
    {
        this.TimeToFadeOut = 2.977471E+38f;
        this.HitCountAnimationInLength = 0.5f;
        this.HitCountAnimationOutLength = 0.5f;
        this.HitCountAnimationEase = 18;
        this.ReactionAnimationInLength = 0.5f;
        this.ReactionAnimationOutLength = 0.5f;
        this.ReactionAnimationEase = 18;
        this.TechniqueAnimationOutLength = 0.5f;
        this.TechniqueAnimationEase = 18;
    }

}
