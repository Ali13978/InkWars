using UnityEngine;
[Serializable]
public class RankingController.RankOpportunityData
{
    // Fields
    public UnityEngine.RectTransform Panel;
    public UnityEngine.UI.Image TextImage;
    public UnityEngine.UI.Image[] Arrows;
    public TMPro.TextMeshProUGUI RankText;
    public UnityEngine.Vector3 InitialTextImageScale;
    
    // Methods
    public void CalculateInitialTextImageScale()
    {
        UnityEngine.Vector3 val_2 = this.TextImage.rectTransform.localScale;
        this.InitialTextImageScale = val_2;
        mem[1152921528458482308] = val_2.y;
        mem[1152921528458482312] = val_2.z;
    }
    public RankingController.RankOpportunityData()
    {
    
    }

}
