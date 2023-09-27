using UnityEngine;
public class AdventureLosePostMatchCanvas : DynamicUISingleton<AdventureLosePostMatchCanvas>
{
    // Fields
    private UnityEngine.UI.Button replayButton;
    private UnityEngine.UI.Button storeButton;
    private UnityEngine.UI.Image loserPoseImg;
    private UnityEngine.UI.Image lightImg;
    private UnityEngine.CanvasGroup panelFadeGroup;
    private bool enableAnim;
    
    // Methods
    protected override void OnEnable()
    {
        CharacterNameID val_9;
        this.OnEnable();
        if(this.enableAnim == false)
        {
                return;
        }
        
        ButtonClickedEvent val_1 = this.replayButton.onClick;
        val_1.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AdventureLosePostMatchCanvas::OnRetry()));
        val_1.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  0, method:  public static System.Void AdventurePostMatch::Back()));
        this.storeButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  0, method:  public static System.Void DynamicUISingleton<ExpressPowerBallPurchaseCanvas>::Show()));
        UnityEngine.Color val_7 = UnityEngine.Color.clear;
        this.loserPoseImg.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
        CharacterInfo val_8 = Character_GlobalInfo.GetMainPlayer();
        CharacterAssetLoader.Get(id:  val_9, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  this, method:  System.Void AdventureLosePostMatchCanvas::<OnEnable>b__6_0(CharacterAssetLoader loader)));
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        ButtonClickedEvent val_1 = this.replayButton.onClick;
        val_1.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AdventureLosePostMatchCanvas::OnRetry()));
        val_1.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  0, method:  public static System.Void AdventurePostMatch::Back()));
        this.storeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  0, method:  public static System.Void DynamicUISingleton<ExpressPowerBallPurchaseCanvas>::Show()));
        DynamicUISingleton<PowerBallAdsRewardPanel>.Hide();
    }
    private void Start()
    {
        this.enableAnim = true;
        goto typeof(AdventureLosePostMatchCanvas).__il2cppRuntimeField_1B8;
    }
    private void OnRetry()
    {
        var val_1 = null;
        if(Character_GlobalInfo.gameMode == 2)
        {
                Character_GlobalInfo.gameMode = 1;
        }
        
        AdventurePostMatch.PlayAgain();
    }
    private void PlayEnterAnim()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  val_1, isIndependentUpdate:  true);
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.panelFadeGroup, endValue:  0f, duration:  1f)));
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.lightImg, endValue:  0f, duration:  1.2f)), ease:  30));
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1f);
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.storeButton.GetComponent<UnityEngine.RectTransform>(), endValue:  -200f, duration:  0.8f, snapping:  false)), ease:  3));
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.storeButton.GetComponent<UnityEngine.RectTransform>(), endValue:  -200f, duration:  0.8f, snapping:  false)), ease:  3));
        DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.replayButton.GetComponent<UnityEngine.RectTransform>(), endValue:  -200f, duration:  0.8f, snapping:  false)), ease:  3));
    }
    protected override void PlayShowAnim()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    protected override void PlayHideAnim()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public AdventureLosePostMatchCanvas()
    {
    
    }
    private void <OnEnable>b__6_0(CharacterAssetLoader loader)
    {
        CharacterPostMatchPoseCollection val_1 = loader.LoadPoseCollection();
        this.loserPoseImg.sprite = val_1.losePose;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.loserPoseImg.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        this.PlayEnterAnim();
    }

}
