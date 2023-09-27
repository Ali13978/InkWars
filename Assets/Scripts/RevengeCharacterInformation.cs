using UnityEngine;
public class RevengeCharacterInformation : MonoBehaviour
{
    // Fields
    private UnityEngine.CanvasGroup m_Transparency;
    private RevengeCharacterInformation.BubbleInfo m_BubbleInfo;
    private RevengeCharacterInformation.RevengeClips m_RevengeClips;
    private RevengeGradients m_Gradients;
    
    // Properties
    public RevengeCharacterInformation.BubbleInfo BubbleInformation { get; }
    public RevengeCharacterInformation.RevengeClips RevengeSuperClip { get; }
    public RevengeGradients Gradients { get; }
    
    // Methods
    public RevengeCharacterInformation.BubbleInfo get_BubbleInformation()
    {
        return (BubbleInfo)this.m_BubbleInfo;
    }
    public RevengeCharacterInformation.RevengeClips get_RevengeSuperClip()
    {
        return (RevengeClips)this.m_RevengeClips;
    }
    public RevengeGradients get_Gradients()
    {
        return (RevengeGradients)this.m_Gradients;
    }
    private void Start()
    {
        InkWars.Model.Model_Manager val_2 = InkWars.Model.Model_Manager.Instance;
        this.gameObject.SetActive(value:  (val_2.Model.Feature_Powerup == 1) ? 1 : 0);
        if(0 == this.m_Transparency)
        {
                this.m_Transparency = this.GetComponent<UnityEngine.CanvasGroup>();
        }
        
        this.Hide();
    }
    public void Show()
    {
        this.m_Transparency.alpha = 1f;
    }
    public void Hide()
    {
        this.m_Transparency.alpha = 0f;
    }
    public RevengeCharacterInformation()
    {
    
    }

}
