using UnityEngine;
public class AdventureWinPostMatchCanvas : DynamicUISingleton<AdventureWinPostMatchCanvas>
{
    // Fields
    private UnityEngine.RectTransform WinPanel;
    private UnityEngine.UI.Image WinPanel_Dynamic;
    private UnityEngine.UI.Text WinPanel_Score;
    private UnityEngine.UI.Text WinPanel_YouveCrackedThePuzzle;
    private UnityEngine.UI.Image star1Image;
    private UnityEngine.UI.Image star2Image;
    private UnityEngine.UI.Image star3Image;
    private UnityEngine.AudioClip star1Sfx;
    private UnityEngine.AudioClip star2Sfx;
    private UnityEngine.AudioClip star3Sfx;
    private UnityEngine.AudioClip highScoreReplaceSfx;
    private UnityEngine.AudioClip highScoreBounceSfx;
    private UnityEngine.RectTransform topScorePanel;
    private UnityEngine.UI.Text topScoreTxt;
    private UnityEngine.UI.VerticalLayoutGroup rewardGroup;
    private UnityEngine.RectTransform powerBallPanel;
    private UnityEngine.RectTransform powerBallGroup;
    private UnityEngine.UI.Text powerBallNameTxt;
    private UnityEngine.UI.Text powerBallCountTxt;
    private UnityEngine.UI.Image powerBallImage;
    private UnityEngine.RectTransform shellPanel;
    private UnityEngine.UI.Text shellCountTxt;
    private UnityEngine.RectTransform pearlPanel;
    private UnityEngine.UI.Text pearlCountTxt;
    private UnityEngine.GameObject coinAnimObject;
    private UnityEngine.RectTransform buttonGroup;
    private UnityEngine.UI.Button replayButton;
    private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt currMatchScore;
    private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt levelHighScore;
    private bool isPuzzle;
    private bool enableAnim;
    
    // Methods
    protected override void OnEnable()
    {
        CharacterNameID val_67;
        var val_69;
        int val_70;
        var val_71;
        var val_72;
        this.OnEnable();
        if(this.enableAnim == false)
        {
                return;
        }
        
        ButtonClickedEvent val_1 = this.replayButton.onClick;
        val_1.AddListener(call:  new UnityEngine.Events.UnityAction(object:  0, method:  public static System.Void AdventurePostMatch::PlayAgain()));
        val_1.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  0, method:  public static System.Void AdventurePostMatch::Back()));
        this.coinAnimObject.SetActive(value:  false);
        val_69 = null;
        val_69 = null;
        this.isPuzzle = (Character_GlobalInfo.gameMode == 3) ? 1 : 0;
        InkWars.Model.Model_Manager val_6 = InkWars.Model.Model_Manager.Instance;
        int val_7 = AdventureLevelDataCollection.GetCurrentStarsByScore(score:  W23);
        AdventureModeSettings val_8 = AdventureLevelDataCollection.GetCurrentModeSetting();
        if(Character_GlobalInfo.gameMode == 4)
        {
                val_70 = W23;
            int val_9 = Character_GlobalInfo.GetAdventurePearlRewardsCount_Ex(score:  val_70);
        }
        else
        {
                val_70 = W23;
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_13 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  W23);
        this.currMatchScore = val_13;
        mem[1152921528900270088] = val_13.fakeValue;
        mem[1152921528900270092] = val_13.inited;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_14 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  Character_GlobalInfo.prevHighScore);
        this.levelHighScore = val_14;
        mem[1152921528900270104] = val_14.fakeValue;
        mem[1152921528900270108] = val_14.inited;
        string val_15 = ???.ToString();
        string val_16 = Character_GlobalInfo.prevHighScore.ToString();
        string val_17 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_8.reward.quantity, hiddenValue = val_8.reward.quantity, fakeValue = X24, inited = X24}).ToString();
        string val_20 = Character_GlobalInfo.GetAdventurePearlRewardsCount_Normal(score:  val_70).ToString()(Character_GlobalInfo.GetAdventurePearlRewardsCount_Normal(score:  val_70).ToString()) + " " + LanguageManager.GetText(key:  "Lk.Shop.Pearls")(LanguageManager.GetText(key:  "Lk.Shop.Pearls"));
        string val_23 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_8.reward.quantity, hiddenValue = val_8.reward.quantity, fakeValue = X24, inited = X24}).ToString()(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_8.reward.quantity, hiddenValue = val_8.reward.quantity, fakeValue = X24, inited = X24}).ToString()) + " " + LanguageManager.GetText(key:  "Lk.Shop.Shells")(LanguageManager.GetText(key:  "Lk.Shop.Shells"));
        eInkUnlockable val_24 = val_8.reward.item - 5;
        val_71 = this.powerBallPanel.transform.parent.gameObject;
        val_71.SetActive(value:  ((val_24 == 2) ? 1 : 0) | ((val_24 < 2) ? 1 : 0));
        if((val_8.reward.item - 4) <= 2)
        {
                this.powerBallImage.sprite = AdventureLevelDataCollection.GetRewardItemSprite(type:  val_8.reward.item);
            val_71 = LanguageManager.GetText(key:  "K.rewards." + AdventureLevelDataCollection.GetRewardItemName(type:  val_8.reward.item)(AdventureLevelDataCollection.GetRewardItemName(type:  val_8.reward.item)));
        }
        
        this.shellPanel.transform.parent.gameObject.SetActive(value:  (val_8.reward.item == 1) ? 1 : 0);
        this.pearlPanel.transform.parent.gameObject.SetActive(value:  (this.isPuzzle == false) ? 1 : 0);
        if(this.isPuzzle != false)
        {
                val_72 = null;
            val_72 = null;
            if(Character_GlobalInfo.firstTimePassPuzzle != true)
        {
                this.powerBallPanel.transform.parent.gameObject.SetActive(value:  false);
            this.shellPanel.transform.parent.gameObject.SetActive(value:  false);
            this.pearlPanel.transform.parent.gameObject.SetActive(value:  false);
        }
        
        }
        
        this.star1Image.gameObject.SetActive(value:  (val_7 > 0) ? 1 : 0);
        this.star2Image.gameObject.SetActive(value:  (val_7 > 1) ? 1 : 0);
        this.star3Image.gameObject.SetActive(value:  (val_7 > 2) ? 1 : 0);
        this.powerBallPanel.gameObject.SetActive(value:  false);
        this.shellPanel.gameObject.SetActive(value:  false);
        this.pearlPanel.gameObject.SetActive(value:  false);
        this.WinPanel_Score.enabled = (this.isPuzzle == false) ? 1 : 0;
        this.WinPanel_YouveCrackedThePuzzle.enabled = (this.isPuzzle == true) ? 1 : 0;
        string val_64 = ???.ToString();
        UnityEngine.Color val_65 = UnityEngine.Color.clear;
        this.WinPanel_Dynamic.color = new UnityEngine.Color() {r = val_65.r, g = val_65.g, b = val_65.b, a = val_65.a};
        CharacterInfo val_66 = Character_GlobalInfo.GetMainPlayer();
        CharacterAssetLoader.Get(id:  val_67, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  this, method:  System.Void AdventureWinPostMatchCanvas::<OnEnable>b__31_0(CharacterAssetLoader loader)));
    }
    private void Start()
    {
        this.enableAnim = true;
        goto typeof(AdventureWinPostMatchCanvas).__il2cppRuntimeField_1B8;
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        this.replayButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  0, method:  public static System.Void AdventurePostMatch::PlayAgain()));
        this.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  0, method:  public static System.Void AdventurePostMatch::Back()));
    }
    private void PlayEnterAnim()
    {
        UnityEngine.Transform val_134;
        var val_135;
        UnityEngine.Transform val_136;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  val_1, isIndependentUpdate:  true);
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.WinPanel_Dynamic.GetComponent<UnityEngine.RectTransform>(), endValue:  -600f, duration:  0.5f, snapping:  false)), ease:  3));
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.WinPanel, endValue:  800f, duration:  0.5f, snapping:  false)), ease:  27));
        if(this.isPuzzle != false)
        {
                DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.topScorePanel, endValue:  -500f, duration:  0f, snapping:  false);
        }
        
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.topScorePanel, endValue:  -500f, duration:  0.5f, snapping:  false)), ease:  3));
        if(this.WinPanel_Score.gameObject.activeInHierarchy != false)
        {
                DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOText(target:  this.WinPanel_Score, endValue:  "", duration:  0.3f, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0)));
        }
        
        if(this.WinPanel_YouveCrackedThePuzzle.gameObject.activeInHierarchy != false)
        {
                DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOText(target:  this.WinPanel_YouveCrackedThePuzzle, endValue:  "", duration:  0.3f, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0)));
        }
        
        if(this.star1Image.gameObject.activeInHierarchy != false)
        {
                DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void AdventureWinPostMatchCanvas::<PlayEnterAnim>b__34_0()));
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.star1Image.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, duration:  0.4f)), ease:  27));
        }
        
        if(this.star2Image.gameObject.activeInHierarchy != false)
        {
                DG.Tweening.Sequence val_40 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void AdventureWinPostMatchCanvas::<PlayEnterAnim>b__34_1()));
            UnityEngine.Vector3 val_42 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_46 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.star2Image.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z}, duration:  0.4f)), ease:  27));
        }
        
        val_134 = this.star3Image.gameObject;
        if(val_134.activeInHierarchy != false)
        {
                DG.Tweening.Sequence val_50 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void AdventureWinPostMatchCanvas::<PlayEnterAnim>b__34_2()));
            val_134 = this.star3Image.GetComponent<UnityEngine.RectTransform>();
            UnityEngine.Vector3 val_52 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_56 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_134, endValue:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z}, duration:  0.4f)), ease:  27));
        }
        
        val_135 = 1152921505062117376;
        if(((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.levelHighScore, hiddenValue = this.levelHighScore, fakeValue = val_134, inited = val_134})) < (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.currMatchScore, hiddenValue = this.currMatchScore, fakeValue = val_134, inited = val_134}))) && (this.isPuzzle != true))
        {
                DG.Tweening.Sequence val_59 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.5f);
            UnityEngine.RectTransform val_60 = this.topScoreTxt.GetComponent<UnityEngine.RectTransform>();
            UnityEngine.Vector3 val_61 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_62 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z}, d:  1.8f);
            DG.Tweening.Sequence val_65 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_60, endValue:  new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z}, duration:  0.5f), ease:  27));
            DG.Tweening.Sequence val_67 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void AdventureWinPostMatchCanvas::<PlayEnterAnim>b__34_3()));
            DG.Tweening.Sequence val_71 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions46.DOText(target:  this.topScoreTxt, endValue:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.currMatchScore, hiddenValue = this.currMatchScore, fakeValue = 1152921505062117376, inited = false}).ToString(), duration:  0.2f, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0));
            DG.Tweening.Sequence val_72 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.5f);
            DG.Tweening.Sequence val_74 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void AdventureWinPostMatchCanvas::<PlayEnterAnim>b__34_4()));
            UnityEngine.Vector3 val_75 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_78 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_60, endValue:  new UnityEngine.Vector3() {x = val_75.x, y = val_75.y, z = val_75.z}, duration:  0.4f), ease:  30));
        }
        
        if(this.powerBallPanel.gameObject.activeInHierarchy != false)
        {
                DG.Tweening.Sequence val_84 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.powerBallPanel, endValue:  -500f, duration:  0.3f, snapping:  false)), ease:  3));
        }
        
        if(this.shellPanel.gameObject.activeInHierarchy != false)
        {
                DG.Tweening.Sequence val_90 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.shellPanel, endValue:  -500f, duration:  0.3f, snapping:  false)), ease:  3));
        }
        
        if(this.pearlPanel.gameObject.activeInHierarchy != false)
        {
                DG.Tweening.Sequence val_96 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.pearlPanel, endValue:  -500f, duration:  0.3f, snapping:  false)), ease:  3));
        }
        
        if(this.powerBallPanel.gameObject.activeInHierarchy != false)
        {
                DG.Tweening.Sequence val_100 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  0, method:  public static System.Void GameAudio::PlayPurchaseSound()));
            UnityEngine.Vector3 val_101 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_102 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_101.x, y = val_101.y, z = val_101.z}, d:  0.1f);
            DG.Tweening.Sequence val_104 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.powerBallGroup, punch:  new UnityEngine.Vector3() {x = val_102.x, y = val_102.y, z = val_102.z}, duration:  0.6f, vibrato:  0, elasticity:  1f));
        }
        
        if(this.shellPanel.gameObject.activeInHierarchy != false)
        {
                DG.Tweening.Sequence val_108 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void AdventureWinPostMatchCanvas::CurrencyRewardEffect()));
            UnityEngine.Vector3 val_110 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_111 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_110.x, y = val_110.y, z = val_110.z}, d:  0.1f);
            DG.Tweening.Sequence val_113 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.shellCountTxt.GetComponent<UnityEngine.RectTransform>(), punch:  new UnityEngine.Vector3() {x = val_111.x, y = val_111.y, z = val_111.z}, duration:  0.6f, vibrato:  0, elasticity:  1f));
        }
        
        val_136 = this.pearlPanel.gameObject;
        if(val_136.activeInHierarchy != false)
        {
                DG.Tweening.Sequence val_117 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void AdventureWinPostMatchCanvas::CurrencyRewardEffect()));
            val_136 = this.pearlCountTxt.GetComponent<UnityEngine.RectTransform>();
            UnityEngine.Vector3 val_119 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_120 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_119.x, y = val_119.y, z = val_119.z}, d:  0.1f);
            DG.Tweening.Sequence val_122 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOPunchScale(target:  val_136, punch:  new UnityEngine.Vector3() {x = val_120.x, y = val_120.y, z = val_120.z}, duration:  0.6f, vibrato:  0, elasticity:  1f));
        }
        
        DG.Tweening.Sequence val_123 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.5f);
        UnityEngine.Vector3 val_124 = UnityEngine.Vector3.zero;
        DG.Tweening.Sequence val_128 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.buttonGroup, endValue:  new UnityEngine.Vector3() {x = val_124.x, y = val_124.y, z = val_124.z}, duration:  0.5f)), ease:  27));
        DG.Tweening.Sequence val_130 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  0, method:  public static System.Void UnlockableCollection::DisplayNewUnlocksOneByOne()));
    }
    private void CurrencyRewardEffect()
    {
        GameAudio.PlayPurchaseSound();
        this.coinAnimObject.SetActive(value:  true);
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
    public AdventureWinPostMatchCanvas()
    {
    
    }
    private void <OnEnable>b__31_0(CharacterAssetLoader loader)
    {
        this.WinPanel_Dynamic.sprite = loader.LoadPose_Dynamic();
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.WinPanel_Dynamic.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        this.powerBallPanel.gameObject.SetActive(value:  true);
        this.shellPanel.gameObject.SetActive(value:  true);
        this.pearlPanel.gameObject.SetActive(value:  true);
        this.PlayEnterAnim();
    }
    private void <PlayEnterAnim>b__34_0()
    {
        UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.star1Sfx, volume:  1f);
    }
    private void <PlayEnterAnim>b__34_1()
    {
        UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.star2Sfx, volume:  1f);
    }
    private void <PlayEnterAnim>b__34_2()
    {
        UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.star3Sfx, volume:  1f);
    }
    private void <PlayEnterAnim>b__34_3()
    {
        UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.highScoreReplaceSfx, volume:  1f);
    }
    private void <PlayEnterAnim>b__34_4()
    {
        UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.highScoreBounceSfx, volume:  1f);
    }

}
