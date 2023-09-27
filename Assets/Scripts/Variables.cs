using UnityEngine;
[Serializable]
public class InteractiveUIElement.Variables
{
    // Fields
    public UnityEngine.RectTransform MainPanel;
    public UnityEngine.CanvasGroup Transparency;
    public bool Interactable;
    public bool BlockRaycasts;
    public bool HideOnStart;
    public UnityEngine.UI.Image Image;
    public UnityEngine.Vector3 OriginalImageAnchoredPosition;
    public UnityEngine.Vector3 OriginalImageScale;
    public float ScaleMultiplier;
    public bool AnimateFromStart;
    public bool Looping;
    public DG.Tweening.Ease Ease;
    public DG.Tweening.LoopType LoopType;
    public float LoopDuration;
    public DG.Tweening.Sequence MainSequence;
    
    // Methods
    public InteractiveUIElement.Variables()
    {
        this.Interactable = true;
        this.BlockRaycasts = true;
        this.ScaleMultiplier = 1f;
    }

}
