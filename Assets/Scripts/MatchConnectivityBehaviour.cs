using UnityEngine;
public class MatchConnectivityBehaviour : InstantiablePrefab<MatchConnectivityBehaviour>
{
    // Fields
    private UnityEngine.UI.Image m_TypeImage;
    private UnityEngine.UI.Image m_TypeIcon;
    private MatchConnectivityBehaviour.TypeImages m_TypeImages;
    private MatchConnectivityBehaviour.TypeImages m_TypeIcons;
    private TMPro.TextMeshProUGUI m_ConnectionLostText;
    private UnityEngine.UI.Text m_LowerCornerDescriptionText;
    private string m_ConnectionLostString;
    private string m_LowerCornerDescriptionString;
    
    // Properties
    public static MatchConnectivityBehaviour Instance { get; }
    
    // Methods
    public static MatchConnectivityBehaviour get_Instance()
    {
        T val_4 = InstantiablePrefab<T>.m_Instance;
        if(0 != val_4)
        {
                return (MatchConnectivityBehaviour)InstantiablePrefab<T>.m_Instance;
        }
        
        val_4 = UnityEngine.Resources.Load<MatchConnectivityBehaviour>(path:  "DynamicUI/MatchConnectivity");
        InstantiablePrefab<T>.m_Instance = UnityEngine.Object.Instantiate<MatchConnectivityBehaviour>(original:  val_4);
        return (MatchConnectivityBehaviour)InstantiablePrefab<T>.m_Instance;
    }
    public static void Setup(MatchConnectivityBehaviour.Status _status, float _duration = -1)
    {
        if(_status > 5)
        {
                return;
        }
        
        var val_14 = 40826484 + (_status) << 2;
        val_14 = val_14 + 40826484;
        goto (40826484 + (_status) << 2 + 40826484);
    }
    private void SetError(MatchConnectivityBehaviour.Status _type)
    {
        if(_type == 3)
        {
            goto label_0;
        }
        
        if(_type != 1)
        {
                return;
        }
        
        this.m_TypeImage.sprite = this.m_TypeImages.Interrupted;
        if(this.m_TypeIcon != null)
        {
            goto label_9;
        }
        
        label_10:
        label_9:
        this.m_TypeIcon.sprite = this.m_TypeIcons.Interrupted;
        return;
        label_0:
        this.m_TypeImage.sprite = this.m_TypeImages.Unsuccessful;
        if(this.m_TypeIcon != null)
        {
            goto label_9;
        }
        
        goto label_10;
    }
    public override void InitializeLocalVariables()
    {
        this.m_ConnectionLostText.text = this.m_ConnectionLostString;
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), loops:  0);
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions46.DOText(target:  this.m_LowerCornerDescriptionText, endValue:  this.m_LowerCornerDescriptionString + ".", duration:  1f, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0));
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions46.DOText(target:  this.m_LowerCornerDescriptionText, endValue:  this.m_LowerCornerDescriptionString + "..", duration:  1f, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0));
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions46.DOText(target:  this.m_LowerCornerDescriptionText, endValue:  this.m_LowerCornerDescriptionString + "...", duration:  1f, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0));
    }
    public override void Animate()
    {
    
    }
    public override void Hide()
    {
        Variables val_1 = this.Options;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_1.Transparency, endValue:  0f, duration:  0.15f);
    }
    public MatchConnectivityBehaviour()
    {
    
    }

}
