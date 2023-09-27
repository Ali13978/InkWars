using UnityEngine;
public class GameOverPanelSummary : MonoBehaviour
{
    // Fields
    private GameOverPanelSummary.DataUIRef m_DataReferences;
    private GameOverPanelSummary.AnimationData m_AnimationData;
    private GameOverPanelSummary.RectTransformGroup m_RectTransforms;
    private GameOverPanelSummary.FontInformation m_FontInformation;
    private UnityEngine.AudioClip m_CountingClip;
    private UnityEngine.AudioClip m_CountingDoneClip;
    private RankingController rankController;
    private bool m_IsAnimating;
    private DG.Tweening.Sequence m_AnimationSequence;
    private MatchOutcomePoints m_MatchOutcomePoints;
    private bool m_PointsRemainUnchaged;
    private bool PlayerLost;
    private bool m_PPSaved;
    private bool m_BPSaved;
    private UnityEngine.AudioSource m_AudioSource;
    private int m_OriginalPP;
    private int m_TotalPP;
    private int m_EarnedPP;
    private int m_OriginalBP;
    private int m_TotalBP;
    private int m_EarnedBP;
    
    // Methods
    protected void Awake()
    {
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  -1280f, y:  0f);
        this.m_RectTransforms.MainPanelRect.anchoredPosition = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  0f, y:  256f);
        this.m_RectTransforms.CharacterInformationPanelRect.anchoredPosition = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
    }
    private void OnEnable()
    {
        InkWars.Model.Model_Events.Instance.add_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void GameOverPanelSummary::OnGameResult(InkWars.Model.GameResult result, bool isFinished)));
        this.Setup();
    }
    private void OnDisable()
    {
        if(0 == InkWars.Model.Model_Events.Instance)
        {
                return;
        }
        
        InkWars.Model.Model_Events.Instance.remove_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void GameOverPanelSummary::OnGameResult(InkWars.Model.GameResult result, bool isFinished)));
    }
    public void InitializeTotalScores(int _playerPoints, int _battlePoints)
    {
        this.m_DataReferences.PlayerPointsTotalScoreText.text = _playerPoints.ToString();
        this.m_DataReferences.BattlePointsTotalScoreText.text = _battlePoints.ToString();
    }
    public void InitializeEarnedScores(int _playerPointsEarned, int _battlePointsEarned)
    {
        this.m_DataReferences.PlayerPointsEarnedScoreText.text = _playerPointsEarned.ToString();
        this.m_DataReferences.BattlePointsEarnedScoreText.text = _battlePointsEarned.ToString();
        this.m_DataReferences.PlayerPointsEarnedScore = _playerPointsEarned;
        this.m_DataReferences.BattlePointsEarnedScore = _battlePointsEarned;
    }
    protected void Setup()
    {
        MatchOutcomePoints val_5;
        UnityEngine.Debug.Log(message:  "-- Acquired PP and BP from user");
        if(this.PlayerLost != false)
        {
                this.m_OriginalPP = (RankingController.m_MatchOutcomeBP.__il2cppRuntimeField_18 - RankingController.m_MatchOutcomePP);
            this.m_TotalPP = RankingController.m_MatchOutcomeBP.__il2cppRuntimeField_1C;
            this.m_EarnedPP = RankingController.m_MatchOutcomeBP.__il2cppRuntimeField_14;
            this.m_OriginalBP = (RankingController.m_MatchOutcomeBP.__il2cppRuntimeField_8 - RankingController.m_MatchOutcomeBP);
            this.m_TotalBP = RankingController.m_MatchOutcomeBP.__il2cppRuntimeField_C;
        }
        else
        {
                this.m_TotalPP = RankingController.m_MatchOutcomeBP.__il2cppRuntimeField_18;
            this.m_EarnedPP = RankingController.m_MatchOutcomePP;
            this.m_OriginalPP = (RankingController.m_MatchOutcomeBP.__il2cppRuntimeField_18 - RankingController.m_MatchOutcomePP);
            this.m_TotalBP = RankingController.m_MatchOutcomeBP.__il2cppRuntimeField_8;
            val_5 = RankingController.m_MatchOutcomeBP;
            this.m_OriginalBP = (RankingController.m_MatchOutcomeBP.__il2cppRuntimeField_8 - RankingController.m_MatchOutcomeBP);
        }
        
        this.m_EarnedBP = val_5;
        if(this.m_PointsRemainUnchaged != false)
        {
                this.m_EarnedPP = 0;
            this.m_EarnedBP = 0;
        }
        
        object[] val_4 = new object[6];
        if(val_4 == null)
        {
            goto label_6;
        }
        
        if(this.m_TotalBP != 0)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(this.m_TotalBP == 0)
        {
            goto label_10;
        }
        
        label_7:
        label_10:
        val_4[0] = this.m_TotalBP;
        val_4[1] = this.m_EarnedBP;
        val_4[2] = this.m_OriginalBP;
        val_4[3] = this.m_TotalPP;
        val_4[4] = this.m_EarnedPP;
        val_4[5] = this.m_OriginalPP;
        UnityEngine.Debug.LogFormat(format:  "##### BP: [Total: {0}, Earned: {1}, Original: {2}] - PP: [Total: {3}, Earned: {4}, Original: {5}]", args:  val_4);
        this.InitializeTotalScores(_playerPoints:  this.m_OriginalPP, _battlePoints:  this.m_OriginalBP);
        this.InitializeEarnedScores(_playerPointsEarned:  this.m_EarnedPP, _battlePointsEarned:  this.m_EarnedBP);
    }
    public void Animate()
    {
        if(this.m_AnimationSequence != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.m_AnimationSequence, complete:  false);
        }
        
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), isIndependentUpdate:  true);
        this.m_AnimationSequence = val_2;
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.m_RectTransforms.MainPanelRect, endValue:  0f, duration:  this.m_AnimationData.mainPanelAnimation.duration, snapping:  false), ease:  this.m_AnimationData.mainPanelAnimation.ease), isIndependentUpdate:  true));
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.m_AnimationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.m_RectTransforms.PlayerPointsScorePanelRect, endValue:  -250f, duration:  this.m_AnimationData.PlayerPointsPanel.duration, snapping:  false), ease:  this.m_AnimationData.PlayerPointsPanel.ease)), isIndependentUpdate:  true));
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.m_AnimationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.m_RectTransforms.BattlePointsScorePanelRect, endValue:  -250f, duration:  this.m_AnimationData.BattlePointsPanel.duration, snapping:  false), ease:  this.m_AnimationData.BattlePointsPanel.ease)), isIndependentUpdate:  true));
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.m_AnimationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.m_RectTransforms.CharacterInformationPanelRect, endValue:  0f, duration:  this.m_AnimationData.CharacterInformationPanel.duration, snapping:  false), ease:  this.m_AnimationData.CharacterInformationPanel.ease), isIndependentUpdate:  true));
        DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.m_AnimationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.m_RectTransforms.WinnerTextRect, endValue:  -235f, duration:  this.m_AnimationData.WinnerText.duration, snapping:  false), ease:  this.m_AnimationData.WinnerText.ease), isIndependentUpdate:  true));
        DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.m_AnimationSequence, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void GameOverPanelSummary::<Animate>b__32_0()));
    }
    public void HidePointPanels()
    {
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_DataReferences.PlayerPointsEarnedScoreText.rectTransform, endValue:  0f, duration:  0.6f), ease:  26);
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_DataReferences.BattlePointsEarnedScoreText.rectTransform, endValue:  0f, duration:  0.6f), ease:  26);
        DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.m_DataReferences.DescriptionPP, endValue:  -75f, duration:  0.15f, snapping:  false), delay:  0.4f), ease:  11);
        DG.Tweening.Tweener val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.m_DataReferences.DescriptionBP, endValue:  -75f, duration:  0.15f, snapping:  false), delay:  0.4f), ease:  11);
    }
    private void SetupComponents()
    {
        DataUIRef val_19;
        DataUIRef val_20;
        DataUIRef val_21;
        if(this.m_PointsRemainUnchaged == false)
        {
            goto label_2;
        }
        
        UnityEngine.Vector2 val_1 = this.m_DataReferences.PositiveSignPP.anchoredPosition;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_1.x, y:  25f);
        this.m_DataReferences.PositiveSignPP.anchoredPosition = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        val_19 = this.m_DataReferences;
        if(this.m_DataReferences != null)
        {
            goto label_6;
        }
        
        val_19 = this.m_DataReferences;
        if(val_19 == null)
        {
            goto label_15;
        }
        
        label_6:
        UnityEngine.Vector2 val_3 = this.m_DataReferences.PositiveSignBP.anchoredPosition;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_3.x, y:  25f);
        this.m_DataReferences.PositiveSignBP.anchoredPosition = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        val_20 = this.m_DataReferences;
        if(this.m_DataReferences != null)
        {
            goto label_10;
        }
        
        val_20 = this.m_DataReferences;
        if(val_20 == null)
        {
            goto label_15;
        }
        
        label_10:
        UnityEngine.Vector2 val_5 = this.m_DataReferences.NegativeSignPP.anchoredPosition;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_5.x, y:  -25f);
        this.m_DataReferences.NegativeSignPP.anchoredPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        val_21 = this.m_DataReferences;
        if(this.m_DataReferences != null)
        {
            goto label_14;
        }
        
        val_21 = this.m_DataReferences;
        if(val_21 == null)
        {
            goto label_15;
        }
        
        label_14:
        UnityEngine.Vector2 val_7 = this.m_DataReferences.NegativeSignBP.anchoredPosition;
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_7.x, y:  -25f);
        this.m_DataReferences.NegativeSignBP.anchoredPosition = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
        this.m_DataReferences.PlayerPointsEarnedScoreText.font = this.m_FontInformation.Draw;
        this.m_DataReferences.BattlePointsTotalScoreText.font = this.m_FontInformation.Draw;
        return;
        label_2:
        if(this.PlayerLost != false)
        {
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        }
        else
        {
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        }
        
        this.m_DataReferences.PositiveSignPP.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        if(this.PlayerLost != false)
        {
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
        }
        else
        {
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
        }
        
        this.m_DataReferences.NegativeSignPP.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        if(this.PlayerLost != false)
        {
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
        }
        else
        {
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
        }
        
        this.m_DataReferences.PositiveSignBP.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        if(this.PlayerLost != false)
        {
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
        }
        else
        {
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
        }
        
        this.m_DataReferences.NegativeSignBP.localScale = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        this.m_DataReferences.PlayerPointsEarnedScoreText.font = (this.PlayerLost == true) ? this.m_FontInformation.NegativeSign : this.m_FontInformation.PositiveSign;
        this.m_DataReferences.BattlePointsEarnedScoreText.font = (this.PlayerLost == true) ? this.m_FontInformation.NegativeSign : this.m_FontInformation.PositiveSign;
        return;
        label_15:
    }
    private System.Collections.IEnumerator PerformTextAnimations()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new GameOverPanelSummary.<PerformTextAnimations>d__35();
    }
    private System.Collections.IEnumerator OnSummaryAnimationEnd()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new GameOverPanelSummary.<OnSummaryAnimationEnd>d__36();
    }
    private System.Collections.IEnumerator SubtractText(TMPro.TextMeshProUGUI _totalPointsText, TMPro.TextMeshProUGUI _earnedPointsText, int _totalPoints, int _earnedPoints, bool _overwritePP, bool _subtract)
    {
        GameOverPanelSummary.<SubtractText>d__37 val_1 = new GameOverPanelSummary.<SubtractText>d__37();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            ._totalPointsText = _totalPointsText;
            ._earnedPointsText = _earnedPointsText;
            ._totalPoints = _totalPoints;
            ._earnedPoints = _earnedPoints;
            ._overwritePP = _overwritePP;
        }
        else
        {
                mem[72] = this;
            mem[48] = _totalPointsText;
            mem[56] = _earnedPointsText;
            mem[32] = _totalPoints;
            ._earnedPoints = _earnedPoints;
            mem[64] = _overwritePP;
        }
        
        ._subtract = _subtract;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator PlayCountingSound(float _delay)
    {
        GameOverPanelSummary.<PlayCountingSound>d__38 val_1 = new GameOverPanelSummary.<PlayCountingSound>d__38();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[32] = this;
        }
        
        ._delay = _delay;
        return (System.Collections.IEnumerator)val_1;
    }
    private void OnGameResult(InkWars.Model.GameResult result, bool isFinished)
    {
        var val_3;
        object val_4;
        var val_5;
        val_3 = isFinished;
        val_4 = this;
        if(val_3 == false)
        {
                return;
        }
        
        val_3 = 1152921505064992768;
        val_5 = null;
        val_5 = null;
        if(Character_GlobalInfo.gameMode != 10)
        {
                if(Character_GlobalInfo.gameMode != 6)
        {
                return;
        }
        
        }
        
        this.m_PointsRemainUnchaged = false;
        if((result - 1) <= 5)
        {
                var val_3 = 40825792 + ((result - 1)) << 2;
            val_3 = val_3 + 40825792;
        }
        else
        {
                this.Setup();
            this.SetupComponents();
            object[] val_2 = new object[1];
            val_4 = this.PlayerLost;
            val_2[0] = val_4;
            UnityEngine.Debug.LogFormat(format:  "######## ON GAME RESULT ########\nPLAYER LOST: {0}", args:  val_2);
            TimeTracker.AssignRewardTime();
        }
    
    }
    public GameOverPanelSummary()
    {
        this.m_DataReferences = new GameOverPanelSummary.DataUIRef();
        this.m_AnimationData = new GameOverPanelSummary.AnimationData();
        this.m_RectTransforms = new GameOverPanelSummary.RectTransformGroup();
        this.m_FontInformation = new GameOverPanelSummary.FontInformation();
    }
    private void <Animate>b__32_0()
    {
        this.m_IsAnimating = true;
        if(this.m_PointsRemainUnchaged != false)
        {
                System.Collections.IEnumerator val_1 = this.OnSummaryAnimationEnd();
        }
        
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.PerformTextAnimations());
    }

}
