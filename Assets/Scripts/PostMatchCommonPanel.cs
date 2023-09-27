using UnityEngine;
public class PostMatchCommonPanel : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI m_title;
    private TMPro.TextMeshProUGUI m_bpWin;
    private TMPro.TextMeshProUGUI m_ppWin;
    private UnityEngine.UI.Text m_returningtoLobbyText;
    private UserInfoPanel playerInfoPanel;
    private UserInfoPanel opponentInfoPanel;
    private MotionPanelsControler m_playerUserPanelAnimCtrl;
    private MotionPanelsControler m_opponentUserPanelAinmCtrl;
    private MotionPanelsControler m_bottomRightPanel;
    private MotionPanelsControler m_rightFlag;
    private MotionPanelsControler m_leftFlag;
    private MotionPanelsControler m_ppPanel;
    private MotionPanelsControler m_bpPanel;
    private MotionPanelsControler m_heading;
    private BattleEnhancerIndicator playerIndicator;
    private BattleEnhancerIndicator opponentIndicator;
    private PointsGranter PP_graneter;
    private PointsGranter BP_graneter;
    private UnityEngine.UI.Image m_middleStrip;
    private UnityEngine.RectTransform m_scorePanel;
    private TMPro.TextMeshProUGUI m_score;
    private PointsGranter Score_graneter;
    private UnityEngine.RectTransform m_bonusPanel;
    private TMPro.TextMeshProUGUI m_bonus;
    public BattleEnhancerIndicator playerEnhancerIndicator;
    public BattleEnhancerIndicator opponentEnhancerIndicator;
    private BPTimerIndicator m_bpTimer;
    private RematchProgressBar m_rematchProgressBar;
    private PrizesPanel m_prizePanel;
    private PostMatchAnimationSettings m_animationSettings;
    private RankingController rankController;
    private UnityEngine.GameObject rematchPanel;
    private UnityEngine.GameObject stars;
    private PostMatchEnhancerData enhancerData;
    private RankUpAnimation rankAnimation;
    private RankUpRewardAnimation rankRewardAnimation;
    private UnityEngine.RectTransform BPCountPanel;
    private int rounds;
    public UnityEngine.UI.Image PlayerRankPlateBGLeft;
    public UnityEngine.UI.Image PlayerRankMedalImageLeft;
    public UnityEngine.UI.Image PlayerRankLevelImageLeft;
    public UnityEngine.UI.Image PlayerRankPlateBGRight;
    public UnityEngine.UI.Image PlayerRankMedalImageRight;
    public UnityEngine.UI.Image PlayerRankLevelImageRight;
    
    // Methods
    public void SetupHint(UnityEngine.UI.Image image, string text)
    {
        this.m_prizePanel.SetupHint(image:  image, text:  text);
    }
    public DG.Tweening.Sequence ShowRematchPanel(bool show = True)
    {
        var val_8;
        IntPtr val_10;
        PostMatchCommonPanel.<>c__DisplayClass38_0 val_1 = new PostMatchCommonPanel.<>c__DisplayClass38_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .show = show;
        DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
        val_8 = null;
        val_8 = null;
        if(Character_GlobalInfo.isCryptoMMOCMode != false)
        {
                val_10 = 1152921528677555136;
        }
        else
        {
                UnityEngine.Debug.Log(message:  "Show Rematch");
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  this.m_prizePanel.Hide());
            UnityEngine.Debug.Log(message:  "Show Rematch 2");
            DG.Tweening.TweenCallback val_6 = null;
            val_10 = 1152921528677572736;
        }
        
        val_6 = new DG.Tweening.TweenCallback(object:  val_1, method:  val_10);
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  val_6);
        return val_3;
    }
    public DG.Tweening.Sequence ShowPrizes(System.Collections.Generic.List<ProfileUnlockables_Base> list)
    {
        if(this.m_prizePanel != null)
        {
                return this.m_prizePanel.ShowPrizes(list:  list);
        }
        
        return this.m_prizePanel.ShowPrizes(list:  list);
    }
    public void GotoCharacterSelect()
    {
        GameAudio.PlayButtonSound();
        if(MVC_MusselTracker.GetMusselCount() < 2)
        {
                return;
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "CharacterSelect");
    }
    private System.Collections.IEnumerator TryUpdateProfile()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new PostMatchCommonPanel.<TryUpdateProfile>d__42(<>1__state:  0);
    }
    public void GotoLobby(int rounds = 0)
    {
        if(InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.isShuttingDown != false)
        {
                InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.ReloadNetworkLobbyScene(rounds:  0);
            return;
        }
        
        InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.ShutdownNetwork(forceAutoStart:  false, couldBeRageQuit:  false, reloadScene:  true, delay:  0f, notifyUser:  true);
    }
    public void BackButtonAction()
    {
        null = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
                GotoCharacterSelect();
            return;
        }
        
        GotoLobby(rounds:  0);
    }
    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        string val_1 = scene.m_Handle.name;
        if((System.String.op_Equality(a:  val_1, b:  "OfflineTitleScreen")) != true)
        {
                if((System.String.op_Equality(a:  val_1, b:  "Menu_Title_Screen")) != true)
        {
                if((System.String.op_Equality(a:  val_1, b:  "CharacterSelect")) == false)
        {
                return;
        }
        
        }
        
        }
        
        PostMatchCanvas.Hide();
    }
    public void LocalVSBackButton()
    {
        var val_1;
        string val_2;
        var val_3;
        GameAudio.PlayButtonSound();
        val_1 = null;
        val_1 = null;
        if(Character_GlobalInfo.isOfflineMode != false)
        {
                val_2 = "OfflineTitleScreen";
        }
        else
        {
                val_3 = null;
            val_3 = null;
            mainTitle.ShowModeSelectImmediately = false;
            val_2 = "Menu_Title_Screen";
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  val_2);
    }
    private void OnEnable()
    {
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void PostMatchCommonPanel::OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)));
        this.m_bonusPanel.gameObject.SetActive(value:  false);
        this.m_scorePanel.gameObject.SetActive(value:  false);
    }
    private void OnDisable()
    {
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void PostMatchCommonPanel::OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)));
        DG.Tweening.Sequence val_2 = this.ShowMiddleStrip(showUp:  false);
        DG.Tweening.Sequence val_3 = this.ShowUserPanel(showIn:  false, side:  2);
    }
    public void LocalVSRematchButton()
    {
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "CharacterSelect");
    }
    public void OnClickRematch()
    {
        DG.Tweening.Sequence val_1 = this.m_prizePanel.Hide();
        this.m_rematchProgressBar.Stop();
        DG.Tweening.Sequence val_2 = this.ShowRemachButtonGroup(showIn:  false);
    }
    public DG.Tweening.Sequence ShowRemachButtonGroup(bool showIn)
    {
        showIn = showIn;
        DG.Tweening.Sequence val_1 = this.m_bottomRightPanel.MoveTo(toEnd:  showIn);
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1f);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void PostMatchCommonPanel::<ShowRemachButtonGroup>b__51_0()));
        return val_1;
    }
    public DG.Tweening.Sequence ShowMiddleStrip(bool showUp = True)
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        if(showUp != false)
        {
            
        }
        
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScaleY(target:  this.m_middleStrip.GetComponent<UnityEngine.Transform>(), endValue:  0f, duration:  this.m_animationSettings.AnimSettings.blackBGAnim.duration), ease:  this.m_animationSettings.AnimSettings.blackBGAnim.ease));
        return val_1;
    }
    public void FillPlayerPoints()
    {
    
    }
    public DG.Tweening.Sequence ShowUserPanel(bool showIn, PlayerType side = 2)
    {
        if(side == 0)
        {
            goto label_1;
        }
        
        if(side != 1)
        {
            goto label_2;
        }
        
        if(this.m_opponentUserPanelAinmCtrl != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        showIn = showIn;
        return this.m_opponentUserPanelAinmCtrl.MoveTo(toEnd:  showIn);
        label_1:
        if(this.m_playerUserPanelAnimCtrl != null)
        {
            goto label_4;
        }
        
        goto label_5;
        label_2:
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        bool val_2 = showIn;
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.m_opponentUserPanelAinmCtrl.MoveTo(toEnd:  val_2));
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.m_playerUserPanelAnimCtrl.MoveTo(toEnd:  val_2));
        return val_1;
    }
    public DG.Tweening.Sequence ShowUserBattleEnhancer(bool showIn, PlayerType side = 2)
    {
        IntPtr val_9;
        PostMatchCommonPanel.<>c__DisplayClass55_0 val_1 = new PostMatchCommonPanel.<>c__DisplayClass55_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .showIn = showIn;
        DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
        if(side == 0)
        {
            goto label_5;
        }
        
        if(side != 1)
        {
            goto label_6;
        }
        
        val_9 = 1152921528679814272;
        goto label_8;
        label_5:
        val_9 = 1152921528679819392;
        goto label_8;
        label_6:
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PostMatchCommonPanel.<>c__DisplayClass55_0::<ShowUserBattleEnhancer>b__2()));
        DG.Tweening.TweenCallback val_6 = null;
        val_9 = 1152921528679833728;
        label_8:
        val_6 = new DG.Tweening.TweenCallback(object:  val_1, method:  val_9);
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  val_6);
        return val_3;
    }
    public DG.Tweening.Sequence ShowBPTimer(bool showIn)
    {
        IntPtr val_4;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        if(showIn != false)
        {
                val_4 = 1152921528679995904;
        }
        else
        {
                val_4 = 1152921528679996928;
        }
        
        new DG.Tweening.TweenCallback() = new DG.Tweening.TweenCallback(object:  this, method:  val_4);
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback());
        return val_1;
    }
    public DG.Tweening.Sequence ShowFlag(bool showIn, PlayerType side = 2)
    {
        CharacterClan val_2;
        CharacterClan val_5;
        bool val_14;
        DG.Tweening.Sequence val_15;
        val_14 = showIn;
        CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
        this.EnablePlayerRankLeft(enable:  true, rank:  RankingController.OriginalRank, Clan:  val_2);
        NetworkUserInfo val_3 = CloudOpponent.current;
        CharacterInfo val_4 = Character_GlobalInfo.GetOpponentPlayer();
        this.EnablePlayerRankRight(enable:  true, rank:  val_3.currentCharacterRank, Clan:  val_5);
        if(side == 0)
        {
            goto label_4;
        }
        
        if(side != 1)
        {
            goto label_5;
        }
        
        if(this.m_rightFlag != null)
        {
            goto label_8;
        }
        
        label_9:
        label_8:
        val_15 = this.m_rightFlag.MoveTo(toEnd:  val_14);
        return val_15;
        label_4:
        if(this.m_leftFlag != null)
        {
            goto label_8;
        }
        
        goto label_9;
        label_5:
        val_15 = DG.Tweening.DOTween.Sequence();
        val_14 = val_14;
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_15, t:  this.m_rightFlag.MoveTo(toEnd:  val_14));
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_15, t:  this.m_leftFlag.MoveTo(toEnd:  val_14));
        return val_15;
    }
    public DG.Tweening.Sequence ShowPP(bool showIn)
    {
        var val_22;
        object val_23;
        DG.Tweening.Sequence val_24;
        PointsGranter val_25;
        val_22 = null;
        val_22 = null;
        InkWars.Model.Model_Manager val_1 = InkWars.Model.Model_Manager.Instance;
        DataStructs.CharacterStats val_2 = DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  val_1.Model.Player1.Name);
        InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
        if(val_3.Model.GameResult == 1)
        {
            goto label_9;
        }
        
        InkWars.Model.Model_Manager val_5 = InkWars.Model.Model_Manager.Instance;
        if(val_5.Model.GameResult != 4)
        {
            goto label_12;
        }
        
        label_9:
        int val_7 = UnityEngine.Mathf.Abs(value:  Model_BP_PP_Library.BattlePoints_DeductionMultiplier_Normal);
        label_33:
        val_23 = "PP Points Gain : "("PP Points Gain : ") + val_7.ToString();
        UnityEngine.Debug.Log(message:  val_23);
        DG.Tweening.Sequence val_10 = DG.Tweening.DOTween.Sequence();
        if(showIn != false)
        {
                this.m_ppWin.text = val_7.ToString();
            DG.Tweening.Sequence val_12 = this.m_ppPanel.MoveTo(toEnd:  true);
            val_24 = val_12;
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_12, interval:  1f);
            val_25 = this.PP_graneter;
            val_23 = val_7;
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_24, t:  val_25.StartGranting(_points:  val_23, duration:  1.5f, _onComplete:  0));
            return (DG.Tweening.Sequence)val_24;
        }
        
        val_25 = this.m_ppPanel;
        val_24 = val_25.MoveTo(toEnd:  false);
        return (DG.Tweening.Sequence)val_24;
        label_12:
        InkWars.Model.Model_Manager val_17 = InkWars.Model.Model_Manager.Instance;
        if(val_17.Model.GameResult == 2)
        {
            goto label_27;
        }
        
        InkWars.Model.Model_Manager val_19 = InkWars.Model.Model_Manager.Instance;
        if(val_19.Model.GameResult != 5)
        {
            goto label_33;
        }
        
        label_27:
        int val_21 = UnityEngine.Mathf.Abs(value:  Model_BP_PP_Library.BattlePoints_DeductionMultiplier_Normal.__il2cppRuntimeField_4);
        goto label_33;
    }
    public DG.Tweening.Sequence RankChangeAnimation()
    {
        if(this.rankAnimation != null)
        {
                return this.rankAnimation.CreateRankChangeAnimation();
        }
        
        return this.rankAnimation.CreateRankChangeAnimation();
    }
    public DG.Tweening.Sequence RankRewardAnimation()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  val_1, isIndependentUpdate:  true);
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.1f);
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void PostMatchCommonPanel::<RankRewardAnimation>b__60_0()));
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.rankRewardAnimation.PlayRankRewardAnim());
        return val_1;
    }
    public void Init()
    {
    
    }
    public bool CheckForRankChange()
    {
        return (bool)(RankingController.NewRank != RankingController.OriginalRank) ? 1 : 0;
    }
    public DG.Tweening.Sequence ShowBP(bool showIn)
    {
        var val_27;
        PointsGranter val_28;
        val_27 = null;
        val_27 = null;
        InkWars.Model.Model_Manager val_1 = InkWars.Model.Model_Manager.Instance;
        DataStructs.CharacterStats val_2 = DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  val_1.Model.Player1.Name);
        InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
        if(val_3.Model.GameResult == 1)
        {
            goto label_9;
        }
        
        InkWars.Model.Model_Manager val_5 = InkWars.Model.Model_Manager.Instance;
        if(val_5.Model.GameResult != 4)
        {
            goto label_12;
        }
        
        label_9:
        int val_7 = UnityEngine.Mathf.Abs(value:  Model_BP_PP_Library.LastCalculated_BattlePoints);
        label_37:
        UnityEngine.Debug.Log(message:  "BP Points Gain : "("BP Points Gain : ") + val_7.ToString());
        DG.Tweening.Sequence val_10 = DG.Tweening.DOTween.Sequence();
        if(showIn != false)
        {
                this.m_bpWin.text = val_7.ToString();
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_bpPanel.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, duration:  0.5f));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_10, interval:  0.5f);
            val_28 = this.BP_graneter;
            DG.Tweening.Sequence val_17 = val_28.StartGranting(_points:  val_7, duration:  1.5f, _onComplete:  0);
        }
        else
        {
                val_28 = this.m_bpPanel.GetComponent<UnityEngine.RectTransform>();
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.zero;
        }
        
        DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_28, endValue:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, duration:  0.5f));
        return val_10;
        label_12:
        InkWars.Model.Model_Manager val_22 = InkWars.Model.Model_Manager.Instance;
        if(val_22.Model.GameResult == 2)
        {
            goto label_31;
        }
        
        InkWars.Model.Model_Manager val_24 = InkWars.Model.Model_Manager.Instance;
        if(val_24.Model.GameResult != 5)
        {
            goto label_37;
        }
        
        label_31:
        int val_26 = UnityEngine.Mathf.Abs(value:  Model_BP_PP_Library.BattlePoints_DeductionMultiplier_Normal.__il2cppRuntimeField_14);
        goto label_37;
    }
    public DG.Tweening.Sequence ShowHeading(bool showIn)
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        showIn = showIn;
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.m_heading.MoveTo(toEnd:  showIn));
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_scorePanel.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  this.m_animationSettings.AnimSettings.scoreTextAnim.duration), ease:  27));
        return val_1;
    }
    public DG.Tweening.Sequence ShowScore(bool displayMainPlayerScore = True)
    {
        .<>4__this = this;
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
        ._score = DG.Tweening.DOTween.__il2cppRuntimeField_cctor_finished;
        if(displayMainPlayerScore != true)
        {
                InkWars.Model.Model_Manager val_4 = InkWars.Model.Model_Manager.Instance;
            ._score = DG.Tweening.DOTween.__il2cppRuntimeField_cctor_finished;
        }
        
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  new PostMatchCommonPanel.<>c__DisplayClass65_0(), method:  System.Void PostMatchCommonPanel.<>c__DisplayClass65_0::<ShowScore>b__0()));
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.one;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_scorePanel, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  this.m_animationSettings.AnimSettings.scoreTextAnim.duration), ease:  27));
        return val_2;
    }
    public DG.Tweening.Sequence ShowFinalScore(bool displayMainPlayerScore = True)
    {
        int val_7;
        var val_8;
        DG.Tweening.TweenCallback val_10;
        val_7 = displayMainPlayerScore;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        InkWars.Model.Model_Manager val_2 = InkWars.Model.Model_Manager.Instance;
        if(val_2.Model == null)
        {
            goto label_4;
        }
        
        if(val_7 == false)
        {
            goto label_5;
        }
        
        label_10:
        if(val_2.Model.Player1 == null)
        {
            goto label_6;
        }
        
        label_11:
        if(val_7 <= false)
        {
            goto label_7;
        }
        
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.Score_graneter.StartGranting(_points:  val_7, duration:  1f, _onComplete:  0));
        return val_1;
        label_4:
        if(val_7 == true)
        {
            goto label_10;
        }
        
        label_5:
        if(val_2.Model.Player2 != null)
        {
            goto label_11;
        }
        
        label_6:
        label_7:
        val_8 = null;
        val_8 = null;
        val_10 = PostMatchCommonPanel.<>c.<>9__66_0;
        if(val_10 == null)
        {
                DG.Tweening.TweenCallback val_5 = null;
            val_10 = val_5;
            val_5 = new DG.Tweening.TweenCallback(object:  PostMatchCommonPanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PostMatchCommonPanel.<>c::<ShowFinalScore>b__66_0());
            PostMatchCommonPanel.<>c.<>9__66_0 = val_10;
        }
        
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  val_5);
        return val_1;
    }
    public DG.Tweening.Sequence ShowBonus(string bonus)
    {
        PostMatchCommonPanel.<>c__DisplayClass67_0 val_1 = new PostMatchCommonPanel.<>c__DisplayClass67_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .bonus = bonus;
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PostMatchCommonPanel.<>c__DisplayClass67_0::<ShowBonus>b__0()));
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.one;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_bonusPanel, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  this.m_animationSettings.AnimSettings.scoreTextAnim.duration), ease:  27));
        return val_2;
    }
    public DG.Tweening.Sequence HideBonus()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_bonusPanel, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  this.m_animationSettings.AnimSettings.scoreTextAnim.duration), ease:  26));
        return val_1;
    }
    public void Setup(string _title, string _score)
    {
        this.m_title.text = _title;
        this.m_score.text = _score;
    }
    public DG.Tweening.Sequence PlayHighScoreAnimation()
    {
        int val_10;
        var val_11;
        var val_12;
        int val_13;
        var val_14;
        var val_15;
        var val_16;
        DG.Tweening.TweenCallback val_18;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        val_10 = 1152921505064992768;
        val_11 = null;
        val_11 = null;
        val_12 = null;
        val_12 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Stats.AllTimeHighScore;
        val_13 = val_2.currentCryptoKey;
        if(Character_GlobalInfo.prevHighScore < (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_13, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited})))
        {
                val_14 = null;
            val_14 = null;
            val_15 = null;
            val_13 = Character_GlobalInfo.prevHighScore;
            val_15 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = DataStructs.UserDataDictionary.Stats.AllTimeHighScore;
            val_10 = val_4.fakeValue;
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.playerInfoPanel.PlayHighScoreAnim(prevHighScore:  val_13, highScore:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_10, inited = val_4.inited})));
            return val_1;
        }
        
        val_16 = null;
        val_16 = null;
        val_18 = PostMatchCommonPanel.<>c.<>9__70_0;
        if(val_18 == null)
        {
                DG.Tweening.TweenCallback val_8 = null;
            val_18 = val_8;
            val_8 = new DG.Tweening.TweenCallback(object:  PostMatchCommonPanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PostMatchCommonPanel.<>c::<PlayHighScoreAnimation>b__70_0());
            PostMatchCommonPanel.<>c.<>9__70_0 = val_18;
        }
        
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  val_8);
        return val_1;
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public void EnablePlayerRankLeft(bool enable, DataStructs.PlayerRank rank, CharacterClan Clan)
    {
        this.PlayerRankPlateBGLeft.gameObject.SetActive(value:  enable);
        if(enable == false)
        {
                return;
        }
        
        this.PlayerRankPlateBGLeft.sprite = RankingCollection.GetRankBGByClan(clan:  Clan);
        this.PlayerRankMedalImageLeft.gameObject.SetActive(value:  (rank > 10) ? 1 : 0);
        this.PlayerRankLevelImageLeft.gameObject.SetActive(value:  (rank < 11) ? 1 : 0);
        this.PlayerRankMedalImageLeft.sprite = RankingCollection.GetRankSpriteSmall(rank:  rank);
        this.PlayerRankLevelImageLeft.sprite = RankingCollection.GetRankSpriteSmall(rank:  rank);
    }
    public void EnablePlayerRankRight(bool enable, DataStructs.PlayerRank rank, CharacterClan Clan)
    {
        this.PlayerRankPlateBGLeft.gameObject.SetActive(value:  enable);
        if(enable == false)
        {
                return;
        }
        
        this.PlayerRankPlateBGRight.sprite = RankingCollection.GetRankBGByClan(clan:  Clan);
        this.PlayerRankMedalImageRight.gameObject.SetActive(value:  (rank > 10) ? 1 : 0);
        this.PlayerRankLevelImageRight.gameObject.SetActive(value:  (rank < 11) ? 1 : 0);
        this.PlayerRankMedalImageRight.sprite = RankingCollection.GetRankSpriteSmall(rank:  rank);
        this.PlayerRankLevelImageRight.sprite = RankingCollection.GetRankSpriteSmall(rank:  rank);
    }
    public PostMatchCommonPanel()
    {
    
    }
    private void <ShowRemachButtonGroup>b__51_0()
    {
        this.m_rematchProgressBar.StartProgress(_action:  new System.Action(object:  this, method:  public System.Void PostMatchCommonPanel::BackButtonAction()));
    }
    private void <ShowBPTimer>b__56_0()
    {
        this.m_bpTimer.m_updateLock = false;
    }
    private void <ShowBPTimer>b__56_1()
    {
        this.m_bpTimer.m_updateLock = true;
        this.m_bpTimer.GoBack();
    }
    private void <RankRewardAnimation>b__60_0()
    {
        this.BPCountPanel.gameObject.SetActive(value:  false);
    }

}
