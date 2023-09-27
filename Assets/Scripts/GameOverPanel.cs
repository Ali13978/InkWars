using UnityEngine;
public class GameOverPanel : MonoBehaviour
{
    // Fields
    public bool LAN_PVP_TEST;
    public GameOverPanel.DataUIRef dataUIRef;
    private InkWars.Model.GameResult gameResult;
    private bool player1AtLeft;
    public System.Collections.Generic.List<UnityEngine.GameObject> HideOnDisconnect;
    public GameOverPanel.PostMatchAudioClips AudioClips;
    public GameOverPanel.AnimData AnimSettings;
    public GameOverPanel.CanvasGroupRef animRef;
    private UnityEngine.RectTransform MainPanelRect;
    private UnityEngine.RectTransform initialPanel;
    private DG.Tweening.Sequence animationSequence;
    private CharacterData player1Data;
    private CharacterData player2Data;
    private GameOverPanelSummary summaryReference;
    private static GameOverPanel <instance>k__BackingField;
    private bool init;
    private bool disconnectCompleted;
    
    // Properties
    public static GameOverPanel instance { get; set; }
    
    // Methods
    public static GameOverPanel get_instance()
    {
        return (GameOverPanel)GameOverPanel.<instance>k__BackingField;
    }
    protected static void set_instance(GameOverPanel value)
    {
        GameOverPanel.<instance>k__BackingField = value;
    }
    public static void ShowBanner()
    {
        if(0 == (GameOverPanel.<instance>k__BackingField))
        {
                return;
        }
    
    }
    private void Awake()
    {
        if(0 == (GameOverPanel.<instance>k__BackingField))
        {
                GameOverPanel.<instance>k__BackingField = this;
        }
        else
        {
                UnityEngine.Object.Destroy(obj:  this);
        }
        
        this.MainPanelRect = this.GetComponent<UnityEngine.RectTransform>();
        DG.Tweening.IDOTweenInit val_3 = DG.Tweening.DOTween.Init(recycleAllByDefault:  new System.Nullable<System.Boolean>() {HasValue = false}, useSafeMode:  new System.Nullable<System.Boolean>() {HasValue = false}, logBehaviour:  new System.Nullable<DG.Tweening.LogBehaviour>() {HasValue = false});
        this.LAN_PVP_TEST = false;
    }
    private void OnDestroy()
    {
        UnityEngine.Object val_2 = this;
        if(this != (GameOverPanel.<instance>k__BackingField))
        {
                return;
        }
        
        GameOverPanel.<instance>k__BackingField = 0;
    }
    public void Animate()
    {
        if(this.init == false)
        {
                return;
        }
        
        if(MVC_Bot_Base.NetworkControlMode != 0)
        {
                UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.DropAfterSeconds(seconds:  5f));
        }
        
        TimeTracker.AssignRewardTime();
        this.SetupData();
        this.PlayAnimSequence();
    }
    private System.Collections.IEnumerator DropAfterSeconds(float seconds)
    {
        object val_1 = 16992;
        val_1 = new System.Object();
        if(val_1 != 0)
        {
                return (System.Collections.IEnumerator)val_1;
        }
        
        return (System.Collections.IEnumerator)val_1;
    }
    private void Start()
    {
        float val_12;
        var val_13;
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0f, y:  1200f);
        val_12 = val_1.x;
        this.MainPanelRect.anchoredPosition = new UnityEngine.Vector2() {x = val_12, y = val_1.y};
        val_13 = null;
        val_13 = null;
        this.player1AtLeft = true;
        InkWars.Model.Model_Manager val_2 = InkWars.Model.Model_Manager.Instance;
        InkWars.Model.Model_Player val_3 = val_2.Model.GetPlayer(PlayerNumber:  0);
        CharacterAssetLoader.Get(id:  val_3.Name, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  this, method:  System.Void GameOverPanel::<Start>b__29_0(CharacterAssetLoader loader)));
        InkWars.Model.Model_Manager val_5 = InkWars.Model.Model_Manager.Instance;
        InkWars.Model.Model_Player val_6 = val_5.Model.GetPlayer(PlayerNumber:  1);
        CharacterAssetLoader.Get(id:  val_6.Name, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  this, method:  System.Void GameOverPanel::<Start>b__29_1(CharacterAssetLoader loader)));
        UnityEngine.CanvasGroup val_8 = this.animRef.buttonsGroup.GetComponent<UnityEngine.CanvasGroup>();
        if(0 != val_8)
        {
                val_12 = 0f;
            val_8.alpha = val_12;
        }
        
        if(0 != this.animRef.extraScoreTextGroup)
        {
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            this.animRef.extraScoreTextGroup.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        }
        
        this.init = true;
    }
    private void Update()
    {
        var val_6 = this;
        if(this.disconnectCompleted == true)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  InkWars.Model.MVC_Multiplayer_Manager_Base.Instance)) == false)
        {
                return;
        }
        
        InkWars.Model.MVC_Multiplayer_Manager_Base val_3 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
        if(val_3.IsDisconnected == false)
        {
                return;
        }
        
        this.disconnectCompleted = true;
        List.Enumerator<T> val_4 = this.HideOnDisconnect.GetEnumerator();
        label_14:
        if(((-1432030904) & 1) == 0)
        {
            goto label_12;
        }
        
        0.InitialType.SetActive(value:  false);
        goto label_14;
        label_12:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.GameObject>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    private bool GetPVPShareEnable()
    {
        var val_7;
        GameMode val_8;
        var val_9;
        val_7 = null;
        val_7 = null;
        val_8 = Character_GlobalInfo.gameMode;
        if(val_8 == 5)
        {
                val_9 = ((this.gameResult != 6) ? 1 : 0) & ((this.gameResult != 3) ? 1 : 0);
            return (bool)val_9;
        }
        
        val_7 = null;
        val_8 = Character_GlobalInfo.gameMode;
        if(val_8 == 6)
        {
            goto label_7;
        }
        
        val_8 = Character_GlobalInfo.gameMode;
        if(val_8 != 10)
        {
            goto label_10;
        }
        
        label_7:
        val_9 = ((this.gameResult == 4) ? 1 : 0) | ((this.gameResult == 1) ? 1 : 0);
        return (bool)val_9;
        label_10:
        val_9 = 1;
        return (bool)val_9;
    }
    private void PlayAnimSequence()
    {
        float val_65;
        var val_66;
        GameMode val_67;
        CanvasGroupRef val_68;
        if(this.animationSequence != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.animationSequence, complete:  false);
        }
        
        if(0 != this.dataUIRef.shareButton)
        {
                this.dataUIRef.shareButton.gameObject.SetActive(value:  this.GetPVPShareEnable());
        }
        
        this.initialPanel.gameObject.SetActive(value:  true);
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), isIndependentUpdate:  true);
        this.animationSequence = val_7;
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.zero;
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.MainPanelRect, endValue:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, duration:  this.AnimSettings.dropDownAnim.duration, snapping:  false), ease:  this.AnimSettings.dropDownAnim.ease), isIndependentUpdate:  true));
        UnityEngine.Transform val_13 = (this.gameResult == 6) ? this.animRef.drawBlackBGGroup : this.animRef.winLoseBlackBGGroup;
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.animationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScaleX(target:  val_13, endValue:  0f, duration:  this.AnimSettings.blackBGAnim.duration)), ease:  this.AnimSettings.blackBGAnim.ease), isIndependentUpdate:  true));
        DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.animationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScaleY(target:  val_13, endValue:  0.01f, duration:  this.AnimSettings.blackBGAnim.duration)), ease:  this.AnimSettings.blackBGAnim.ease), isIndependentUpdate:  true));
        DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.animationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.animRef.leftCharacterIconGroup, endValue:  -300f, duration:  this.AnimSettings.playerAvatarAnim.duration, snapping:  false)), ease:  this.AnimSettings.playerAvatarAnim.ease), isIndependentUpdate:  true));
        DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.animationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.animRef.rightCharacterIconGroup, endValue:  300f, duration:  this.AnimSettings.playerAvatarAnim.duration, snapping:  false)), ease:  this.AnimSettings.playerAvatarAnim.ease), isIndependentUpdate:  true));
        DG.Tweening.Sequence val_38 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.animationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.animRef.winnerTitleGroup, endValue:  400f, duration:  this.AnimSettings.winnerTextAnim.duration, snapping:  false)), ease:  this.AnimSettings.winnerTextAnim.ease), isIndependentUpdate:  true));
        DG.Tweening.Sequence val_43 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.animationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOText(target:  this.animRef.quoteTextGroup.GetComponent<UnityEngine.UI.Text>(), endValue:  "", duration:  this.AnimSettings.quoteTextAnim.duration, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0)), isIndependentUpdate:  true));
        UnityEngine.Vector2 val_44 = UnityEngine.Vector2.zero;
        val_65 = val_44.x;
        DG.Tweening.Sequence val_49 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.animationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOSizeDelta(target:  this.animRef.scoreTextGroup, endValue:  new UnityEngine.Vector2() {x = val_65, y = val_44.y}, duration:  this.AnimSettings.scoreTextAnim.duration, snapping:  false)), ease:  this.AnimSettings.scoreTextAnim.ease), isIndependentUpdate:  true));
        val_66 = null;
        val_66 = null;
        val_67 = Character_GlobalInfo.gameMode;
        if(val_67 == 6)
        {
            goto label_56;
        }
        
        val_67 = Character_GlobalInfo.gameMode;
        if(val_67 != 10)
        {
            goto label_59;
        }
        
        label_56:
        if((this.gameResult == 1) || (this.gameResult == 4))
        {
            goto label_61;
        }
        
        label_59:
        if(this.LAN_PVP_TEST == false)
        {
            goto label_62;
        }
        
        label_61:
        DG.Tweening.Sequence val_52 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.animationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.animRef.scoreTextGroup, endValue:  -215f, duration:  0.35f, snapping:  false), ease:  27));
        val_68 = this.animRef;
        if(this.animRef != null)
        {
            goto label_64;
        }
        
        val_68 = this.animRef;
        if(val_68 == null)
        {
            goto label_65;
        }
        
        label_64:
        UnityEngine.Vector2 val_53 = this.animRef.extraScoreTextGroup.anchoredPosition;
        val_65 = 0.6f;
        val_53.x = val_53.x + 200f;
        DG.Tweening.Sequence val_57 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.animationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.animRef.extraScoreTextGroup, endValue:  val_53.x, duration:  val_65, snapping:  false)), ease:  27));
        DG.Tweening.Sequence val_60 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.animationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.animRef.extraScoreTextGroup, endValue:  1f, duration:  val_65), ease:  7));
        label_62:
        DG.Tweening.Sequence val_61 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.animationSequence, interval:  this.AnimSettings.delayBeforeButtonAppears.duration);
        DG.Tweening.Sequence val_63 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.animationSequence, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void GameOverPanel::<PlayAnimSequence>b__32_0()));
        return;
        label_65:
    }
    public void ShowButtonGroup()
    {
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0f, y:  -120f);
        this.animRef.buttonsGroup.anchoredPosition = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        UnityEngine.CanvasGroup val_2 = this.animRef.buttonsGroup.GetComponent<UnityEngine.CanvasGroup>();
        if(0 != val_2)
        {
                DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  val_2, endValue:  1f, duration:  this.AnimSettings.buttonGroupAnim.duration), ease:  this.AnimSettings.buttonGroupAnim.ease), isIndependentUpdate:  true);
        }
        
        DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.animRef.buttonsGroup, endValue:  0f, duration:  this.AnimSettings.buttonGroupAnim.duration, snapping:  false), ease:  this.AnimSettings.buttonGroupAnim.ease), isIndependentUpdate:  true);
    }
    public void ShowSecondStage()
    {
        this.summaryReference.Animate();
    }
    private void SetupData()
    {
        InkWars.Model.Model_Manager val_1 = InkWars.Model.Model_Manager.Instance;
        this.gameResult = val_1.Model.GameResult;
        this.SetWinnerAndScoreTitle();
        this.SetPlayerData();
    }
    private void SetWinnerAndScoreTitle()
    {
        float val_13;
        float val_14;
        float val_15;
        DataUIRef val_17;
        var val_18;
        UnityEngine.UI.Text val_19;
        var val_20;
        GameMode val_21;
        var val_22;
        var val_23;
        UnityEngine.UI.Text val_24;
        var val_26;
        GameMode val_27;
        val_17 = this;
        InkWars.Model.GameResult val_18 = this.gameResult;
        if(val_18 > 6)
        {
            goto label_4;
        }
        
        var val_17 = 1;
        val_17 = val_17 << val_18;
        if((val_17 & 18) != 0)
        {
            goto label_2;
        }
        
        val_17 = val_17 & 36;
        if(val_17 != 0)
        {
            goto label_3;
        }
        
        val_18 = 1 << val_18;
        val_18 = val_18 & 72;
        if(val_18 == 0)
        {
            goto label_4;
        }
        
        if(this.dataUIRef.winnerTitle != null)
        {
            goto label_7;
        }
        
        goto label_7;
        label_2:
        InkWars.Model.Model_Manager val_2 = InkWars.Model.Model_Manager.Instance;
        InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
        val_18 = 1152921504621490176;
        string val_4 = "SCORE: "("SCORE: ") + val_18;
        string val_5 = System.String.Format(format:  "+ {0} WIN BONUS!", arg0:  ???);
        val_19 = this.dataUIRef.winnerTitle;
        val_20 = null;
        val_20 = null;
        val_21 = Character_GlobalInfo.gameMode;
        if(val_21 == 6)
        {
            goto label_21;
        }
        
        val_21 = Character_GlobalInfo.gameMode;
        if(val_21 != 10)
        {
            goto label_24;
        }
        
        label_21:
        val_22 = "YOU WIN!";
        goto label_53;
        label_3:
        val_23 = null;
        val_23 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
            goto label_28;
        }
        
        InkWars.Model.Model_Manager val_6 = InkWars.Model.Model_Manager.Instance;
        InkWars.Model.Model_Manager val_7 = InkWars.Model.Model_Manager.Instance;
        string val_8 = "SCORE: "("SCORE: ") + Character_GlobalInfo.gameMode;
        val_24 = this.dataUIRef.extraScoreText;
        string val_9 = System.String.Format(format:  "+ {0} WIN BONUS!", arg0:  ???);
        goto label_38;
        label_4:
        val_17 = this.dataUIRef;
        goto label_39;
        label_28:
        val_24 = this.dataUIRef.scoreText;
        InkWars.Model.Model_Manager val_10 = InkWars.Model.Model_Manager.Instance;
        string val_11 = "SCORE: "("SCORE: ") + Character_GlobalInfo.gameMode;
        label_38:
        val_26 = null;
        val_19 = this.dataUIRef.winnerTitle;
        val_26 = null;
        val_27 = Character_GlobalInfo.gameMode;
        if(val_27 == 6)
        {
            goto label_48;
        }
        
        val_27 = Character_GlobalInfo.gameMode;
        if(val_27 != 10)
        {
            goto label_51;
        }
        
        label_48:
        val_22 = "YOU LOSE!";
        goto label_53;
        label_24:
        val_22 = "PLAYER 1 WINS!";
        goto label_53;
        label_51:
        val_22 = "PLAYER 2 WINS!";
        label_53:
        label_7:
        label_39:
        QuoteData val_12 = this.dataUIRef.quoteData.GetQuoteData();
        this.dataUIRef.quoteText.color = new UnityEngine.Color() {r = Character_GlobalInfo.gameMode, g = val_13, b = val_14, a = val_15};
    }
    public void SetPlayerData()
    {
        CharacterNameID val_18;
        CharacterNameID val_21;
        var val_35;
        var val_36;
        var val_37;
        GameOverPanel.<>c__DisplayClass37_0 val_1 = new GameOverPanel.<>c__DisplayClass37_0();
        .<>4__this = this;
        .player1Image = (this.player1AtLeft == true) ? this.dataUIRef.leftCharacterImage : this.dataUIRef.rightCharacterImage;
        .player2Image = (this.player1AtLeft == true) ? this.dataUIRef.rightCharacterImage : this.dataUIRef.leftCharacterImage;
        if(this.gameResult != 1)
        {
            goto label_4;
        }
        
        val_35 = 0;
        val_36 = 1;
        goto label_6;
        label_4:
        var val_4 = (this.gameResult == 4) ? 1 : 0;
        var val_5 = (this.gameResult != 4) ? 1 : 0;
        if(this.gameResult != 2)
        {
            goto label_6;
        }
        
        val_37 = 1;
        goto label_7;
        label_6:
        var val_6 = (this.gameResult == 5) ? 1 : 0;
        label_7:
        if(val_35 != 0)
        {
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        }
        else
        {
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  2f);
        }
        
        (GameOverPanel.<>c__DisplayClass37_0)[1152921528947319264].player1Image.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        if(val_6 != 0)
        {
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  2f);
        }
        else
        {
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
        }
        
        (GameOverPanel.<>c__DisplayClass37_0)[1152921528947319264].player2Image.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        UnityEngine.RectTransform val_15 = this.dataUIRef.leftCharacterImage.GetComponent<UnityEngine.RectTransform>();
        float val_16 = val_15.SwipeRectTransformX(rectTrans:  val_15);
        CharacterInfo val_17 = Character_GlobalInfo.GetMainPlayer();
        CharacterAssetLoader.Get(id:  val_18, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  val_1, method:  System.Void GameOverPanel.<>c__DisplayClass37_0::<SetPlayerData>b__0(CharacterAssetLoader loader)));
        CharacterInfo val_20 = Character_GlobalInfo.GetOpponentPlayer();
        CharacterAssetLoader.Get(id:  val_21, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  val_1, method:  System.Void GameOverPanel.<>c__DisplayClass37_0::<SetPlayerData>b__1(CharacterAssetLoader loader)));
        var val_26 = (this.gameResult == 3) ? 1 : 0;
        val_26 = ((this.gameResult == 6) ? 1 : 0) ^ val_26;
        this.animRef.winLoseBlackBGGroup.gameObject.SetActive(value:  val_26 ^ 1);
        this.animRef.drawBlackBGGroup.gameObject.SetActive(value:  ((this.gameResult == 6) ? 1 : 0) | ((this.gameResult == 3) ? 1 : 0));
        bool val_35 = this.player1AtLeft;
        if((val_36 & val_35) != true)
        {
                val_35 = val_35 ^ 1;
            val_35 = val_6 & val_35;
            if(val_35 == false)
        {
            goto label_46;
        }
        
        }
        
        label_46:
        UnityEngine.Vector3 val_32 = this.animRef.winLoseBlackBGGroup.localScale;
        this.animRef.winLoseBlackBGGroup.localScale = new UnityEngine.Vector3() {x = -1f, y = val_32.y, z = val_32.z};
        this.dataUIRef.leftDataPanel.gameObject.SetActive(value:  false);
        this.dataUIRef.rightDataPanel.gameObject.SetActive(value:  false);
    }
    public void BackToTitle()
    {
        var val_6;
        GameMode val_7;
        var val_8;
        val_6 = null;
        val_6 = null;
        val_7 = Character_GlobalInfo.gameMode;
        if(val_7 == 6)
        {
            goto label_3;
        }
        
        val_7 = Character_GlobalInfo.gameMode;
        if(val_7 != 10)
        {
            goto label_6;
        }
        
        label_3:
        if(0 != RematchPanel.Instance)
        {
                RematchPanel.Instance.SendNetworkMessage(message:  9, showWaitingMessage:  false);
        }
        
        LoadingScreenController val_4 = LoadingScreenController.instance;
        val_8 = null;
        val_8 = null;
        if((GameOverPanel.<>c.<>9__38_0) == null)
        {
            goto label_15;
        }
        
        label_20:
        val_4.FlyIn(duration:  0.8f, onDone:  GameOverPanel.<>c.<>9__38_0);
        return;
        label_15:
        GameOverPanel.<>c.<>9__38_0 = new System.Action(object:  GameOverPanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameOverPanel.<>c::<BackToTitle>b__38_0());
        if(val_4 != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_6:
        GameOverPanel.BackToTitle_Finish();
    }
    private System.Collections.IEnumerator DelayBackToTitleFinish()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new GameOverPanel.<DelayBackToTitleFinish>d__39();
    }
    public static void BackToTitle_Finish()
    {
        var val_3;
        GameMode val_4;
        CharBundleManager.UnloadUnusedAssets();
        val_3 = null;
        val_3 = null;
        val_4 = Character_GlobalInfo.gameMode;
        if(val_4 == 6)
        {
            goto label_3;
        }
        
        val_4 = Character_GlobalInfo.gameMode;
        if(val_4 != 10)
        {
            goto label_6;
        }
        
        label_3:
        InkWars.Model.MVC_Multiplayer_Manager_Base val_1 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
        val_1.ConnectionStatus = 0;
        InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.ShutdownNetwork(forceAutoStart:  false, couldBeRageQuit:  false, reloadScene:  true, delay:  0f, notifyUser:  true);
        return;
        label_6:
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "Menu_Title_Screen", minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
    }
    public void Replay()
    {
        bool val_1 = ExpressShellPurchaseCanvas.IsNoShellAndShowExpressPurchase();
        if(val_1 != false)
        {
                return;
        }
        
        val_1.RematchCharacterSelect();
    }
    public void CharacterSelect()
    {
        bool val_1 = ExpressShellPurchaseCanvas.IsNoShellAndShowExpressPurchase();
        if(val_1 != false)
        {
                return;
        }
        
        val_1.RematchCharacterSelect();
    }
    private void RematchCharacterSelect()
    {
        null = null;
        if((Character_GlobalInfo.gameMode != 10) && (Character_GlobalInfo.gameMode != 6))
        {
                if(Character_GlobalInfo.gameMode != 5)
        {
                return;
        }
        
            AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "CharacterSelect", minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
            return;
        }
        
        RematchPanel.Instance.SendNetworkMessage(message:  2, showWaitingMessage:  true);
    }
    public void InitUserData()
    {
    
    }
    private float SwipeRectTransformX(UnityEngine.RectTransform rectTrans)
    {
        float val_3;
        if(0 == rectTrans)
        {
                UnityEngine.Debug.LogError(message:  "SwipeRectTransformX cannot take null RectTransform.");
            val_3 = 0f;
            return val_3;
        }
        
        UnityEngine.Vector3 val_2 = rectTrans.localScale;
        val_3 = -val_2.x;
        rectTrans.localScale = new UnityEngine.Vector3() {x = val_3, y = val_2.y, z = val_2.z};
        return val_3;
    }
    public GameOverPanel()
    {
        this.dataUIRef = new GameOverPanel.DataUIRef();
        this.AudioClips = new GameOverPanel.PostMatchAudioClips();
        this.AnimSettings = new GameOverPanel.AnimData();
        this.animRef = new GameOverPanel.CanvasGroupRef();
    }
    private void <Start>b__29_0(CharacterAssetLoader loader)
    {
        this.player1Data = loader.LoadCharacterData();
    }
    private void <Start>b__29_1(CharacterAssetLoader loader)
    {
        this.player2Data = loader.LoadCharacterData();
    }
    private void <PlayAnimSequence>b__32_0()
    {
        var val_4;
        GameMode val_5;
        val_4 = null;
        val_4 = null;
        val_5 = Character_GlobalInfo.gameMode;
        if(val_5 != 6)
        {
                val_5 = Character_GlobalInfo.gameMode;
            if(val_5 != 10)
        {
                if(this.LAN_PVP_TEST == false)
        {
            goto label_7;
        }
        
        }
        
        }
        
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.initialPanel, endValue:  -1280f, duration:  1f, snapping:  false), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void GameOverPanel::<PlayAnimSequence>b__32_1()));
        return;
        label_7:
        this.ShowButtonGroup();
        GameOverPanel.ShowBanner();
    }
    private void <PlayAnimSequence>b__32_1()
    {
        this.ShowSecondStage();
    }

}
