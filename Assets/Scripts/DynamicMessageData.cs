using UnityEngine;
[Serializable]
public class DynamicMessageUIController.DynamicMessageData
{
    // Fields
    public UnityEngine.CanvasGroup Transparency;
    public UnityEngine.CanvasGroup TransparencyTechnique;
    public bool IsShowingPanel;
    public bool IsShowingTechnique;
    public UnityEngine.RectTransform HitCountPanel;
    public UnityEngine.RectTransform ImageHitsPanel;
    public TMPro.TextMeshProUGUI HitCountText;
    public TMPro.TextMeshProUGUI HitCountComboNameText;
    public float hitCountTargetPosX;
    public float hitCountOriginalPosX;
    public float hitCountImageWidth;
    public UnityEngine.RectTransform ReactionPanel;
    public TMPro.TextMeshProUGUI ReactionText;
    public float reactionTargetPosX;
    public float reactionOriginalPosX;
    public float reactionImageWidth;
    public UnityEngine.RectTransform TechniquePanel;
    public TMPro.TextMeshProUGUI TechniqueText;
    public UnityEngine.UI.Image TechniqueImage;
    public float techniqueTargetPosX;
    public float techniqueOriginalPosX;
    public float techniqueImageWidth;
    
    // Methods
    public void Initialize()
    {
        UnityEngine.Vector2 val_1 = this.HitCountPanel.anchoredPosition;
        this.hitCountTargetPosX = val_1.x;
        this.hitCountOriginalPosX = val_1.x;
        UnityEngine.Rect val_2 = this.HitCountPanel.rect;
        val_2.m_XMin = val_2.m_XMin + 40f;
        this.hitCountImageWidth = val_2.m_XMin;
        UnityEngine.Vector2 val_3 = this.ReactionPanel.anchoredPosition;
        this.reactionTargetPosX = val_3.x;
        this.reactionOriginalPosX = val_3.x;
        UnityEngine.Rect val_4 = this.ReactionPanel.rect;
        this.reactionImageWidth = val_4.m_XMin;
        UnityEngine.Vector2 val_5 = this.TechniquePanel.anchoredPosition;
        this.techniqueTargetPosX = val_5.x;
        this.techniqueOriginalPosX = val_5.x;
        UnityEngine.Rect val_6 = this.TechniquePanel.rect;
        this.techniqueImageWidth = val_6.m_XMin;
    }
    public DynamicMessageUIController.DynamicMessageData()
    {
    
    }

}
