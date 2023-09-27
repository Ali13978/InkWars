using UnityEngine;
public class LevelMenuCharacterPanelController : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform m_CharacterInformationPanel;
    private float m_TargetCharacterInformationPanelPosition;
    private CharacterAvatarController m_CurrentCharaterAvatar;
    private UnityEngine.RectTransform m_ArrowExpandClose;
    private UnityEngine.CanvasGroup m_StarCountTransparency;
    private UnityEngine.UI.Text m_StarCountText;
    private UnityEngine.CanvasGroup m_InkMeterTransparency;
    private UnityEngine.UI.Text m_InkMeterText;
    private UnityEngine.RectTransform m_MusselInformationPanel;
    private UnityEngine.UI.Text m_MusselCountText;
    private UnityEngine.UI.Text m_MusselTimerText;
    private UnityEngine.RectTransform m_BallInformationPanel;
    private float m_TargetBallInformationPanelPosition;
    private UnityEngine.UI.Text m_StunnerBallText;
    private UnityEngine.UI.Text m_CannonBallText;
    private UnityEngine.UI.Text m_EraserBallText;
    private float m_AnimationLength;
    private DG.Tweening.Ease m_AnimationEaseType;
    private bool m_IsExpanding;
    private bool m_IsPanelExpanded;
    private DG.Tweening.Sequence expand;
    private DG.Tweening.Sequence shrink;
    
    // Methods
    private void Awake()
    {
        this.m_StarCountTransparency.alpha = 0f;
        this.m_InkMeterTransparency.alpha = 0f;
        this.expand = DG.Tweening.DOTween.Sequence();
        this.shrink = DG.Tweening.DOTween.Sequence();
    }
    private void Start()
    {
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.m_ArrowExpandClose, endValue:  75f, duration:  0.5f, snapping:  false), ease:  4), loops:  0, loopType:  1);
        this.CalculatePanelVariables();
    }
    private void LateUpdate()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.Mussels;
        string val_2 = val_1.currentCryptoKey.ToString();
        string val_3 = MVC_MusselTracker.GetTimeTilNextMussel();
        this.UpdatePowerBallCount();
    }
    public void ToggleCharacterInformationPanelExpand()
    {
        if(this.m_IsExpanding != false)
        {
                return;
        }
        
        this.m_IsPanelExpanded = this.m_IsPanelExpanded ^ 1;
        if(this.m_IsPanelExpanded != false)
        {
                this.ShrinkCharacterInformationPanel();
            return;
        }
        
        this.ExpandCharacterInformationPanel();
    }
    public void CalculatePanelVariables()
    {
        CharacterNameID val_2;
        var val_13;
        UnityEngine.Debug.Log(message:  ">> Calculating variables for the character information panel");
        CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
        this.m_CurrentCharaterAvatar.Init(cid:  val_2, aNewMaskType:  0, reloadAvatar:  true, isFaceLeft:  true);
        val_13 = null;
        val_13 = null;
        string val_6 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().TotalStars.ToString() + "/105"("/105");
        UnityEngine.Debug.Log(message:  "Character stars: "("Character stars: ") + this.m_StarCountText);
        string val_11 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().TotalInk.ToString() + "/1200"("/1200");
        UnityEngine.Debug.Log(message:  "Character ink percentage: "("Character ink percentage: ") + this.m_InkMeterText);
        this.UpdatePowerBallCount();
    }
    private void UpdatePowerBallCount()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.StunnerBall;
        string val_2 = val_1.currentCryptoKey.ToString();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Items.IronBall;
        string val_4 = val_3.currentCryptoKey.ToString();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Items.ColorEraserBall;
        string val_6 = val_5.currentCryptoKey.ToString();
        if(this.m_EraserBallText != null)
        {
                return;
        }
    
    }
    private void ExpandCharacterInformationPanel()
    {
        this.m_IsExpanding = true;
        float val_16 = this.m_AnimationLength;
        val_16 = val_16 * 0.5f;
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions.DORotate(target:  this.m_ArrowExpandClose, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_16, mode:  0);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.expand, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.m_CharacterInformationPanel, endValue:  0f, duration:  this.m_AnimationLength, snapping:  false), ease:  this.m_AnimationEaseType));
        float val_17 = this.m_AnimationLength;
        val_17 = val_17 * 0.5f;
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.expand, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_StarCountTransparency, endValue:  1f, duration:  this.m_AnimationLength), delay:  val_17));
        float val_18 = this.m_AnimationLength;
        val_18 = val_18 * 0.5f;
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.expand, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_InkMeterTransparency, endValue:  1f, duration:  this.m_AnimationLength), delay:  val_18));
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.expand, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.m_BallInformationPanel, endValue:  0f, duration:  this.m_AnimationLength, snapping:  false), ease:  this.m_AnimationEaseType), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void LevelMenuCharacterPanelController::<ExpandCharacterInformationPanel>b__28_0())));
    }
    private void ShrinkCharacterInformationPanel()
    {
        this.m_IsExpanding = true;
        float val_16 = this.m_AnimationLength;
        val_16 = val_16 * 0.5f;
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions.DORotate(target:  this.m_ArrowExpandClose, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_16, mode:  0);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.shrink, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.m_CharacterInformationPanel, endValue:  this.m_TargetCharacterInformationPanelPosition, duration:  this.m_AnimationLength, snapping:  false), ease:  this.m_AnimationEaseType));
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.shrink, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_StarCountTransparency, endValue:  0f, duration:  this.m_AnimationLength * 0.5f));
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.shrink, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_InkMeterTransparency, endValue:  0f, duration:  this.m_AnimationLength * 0.5f));
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.shrink, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.m_BallInformationPanel, endValue:  this.m_TargetBallInformationPanelPosition, duration:  this.m_AnimationLength, snapping:  false), ease:  this.m_AnimationEaseType), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void LevelMenuCharacterPanelController::<ShrinkCharacterInformationPanel>b__29_0())));
    }
    public LevelMenuCharacterPanelController()
    {
        this.m_AnimationLength = 0.5f;
        this.m_AnimationEaseType = 12;
    }
    private void <ExpandCharacterInformationPanel>b__28_0()
    {
        UnityEngine.Debug.Log(message:  "Finished expanding");
        this.m_IsExpanding = false;
    }
    private void <ShrinkCharacterInformationPanel>b__29_0()
    {
        UnityEngine.Debug.Log(message:  "Finished shrinking");
        this.m_IsExpanding = false;
    }

}
