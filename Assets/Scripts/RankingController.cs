using UnityEngine;
public class RankingController : MonoBehaviour
{
    // Fields
    public AnimeEaseData m_RankImageSwapData;
    private RankingController.Data m_Data;
    private System.Collections.Generic.List<UnityEngine.RectTransform> m_RankingPanelList;
    private UnityEngine.AudioClip m_RankUpSFX;
    private UnityEngine.AudioClip m_RankDownSFX;
    private UnityEngine.AudioClip m_SwooshSFX;
    private UnityEngine.AudioClip m_NewRankSFX;
    private UnityEngine.GameObject ShellAwardObject;
    private UnityEngine.GameObject BPAwardObject;
    private DataStructs.PlayerRank m_Rank;
    private RankingConstraints m_UserRankingConstraints;
    private bool m_Demoted;
    private DG.Tweening.Sequence m_AnimationSequence;
    public static MatchOutcomePoints m_MatchOutcomeBP;
    public static MatchOutcomePoints m_MatchOutcomePP;
    internal static DataStructs.PlayerRank OriginalRank;
    internal static DataStructs.PlayerRank NewRank;
    internal static CodeStage.AntiCheat.ObscuredTypes.ObscuredInt OriginalBP;
    internal static CodeStage.AntiCheat.ObscuredTypes.ObscuredInt OriginalPP;
    private static bool <isRewardForRankUpThisMatch>k__BackingField;
    
    // Properties
    public static bool isRewardForRankUpThisMatch { get; set; }
    
    // Methods
    public static bool get_isRewardForRankUpThisMatch()
    {
        return (bool)RankingController.<isRewardForRankUpThisMatch>k__BackingField;
    }
    protected static void set_isRewardForRankUpThisMatch(bool value)
    {
        RankingController.<isRewardForRankUpThisMatch>k__BackingField = value;
    }
    private void Awake()
    {
        var val_6;
        this.InitializeListRankingPanelList();
        this.HideRankingPanels(_smooth:  false);
        val_6 = null;
        val_6 = null;
        this.m_Data.RankImage.sprite = RankingCollection.GetRankSprite(rank:  DataStructs.UserDataDictionary.Stats.CurrentCharacterRank);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.m_Data.RankUpShells.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        this.m_Data.RankUpShellsText.rectTransform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        this.m_Data.RankUpOpportunity.CalculateInitialTextImageScale();
        this.m_Data.RankDownWarning.CalculateInitialTextImageScale();
    }
    private void InitializeListRankingPanelList()
    {
        System.Collections.Generic.List<UnityEngine.RectTransform> val_1 = new System.Collections.Generic.List<UnityEngine.RectTransform>();
        this.m_RankingPanelList = val_1;
        val_1.Clear();
        this.m_RankingPanelList.Add(item:  this.m_Data.RankUpOpportunity.Panel);
        this.m_RankingPanelList.Add(item:  this.m_Data.RankDownWarning.Panel);
        this.m_RankingPanelList.Add(item:  this.m_Data.RankUpPanel);
        this.m_RankingPanelList.Add(item:  this.m_Data.RankDownPanel);
    }
    public static bool CheckCanGetRankUpRewardAtMatchConclusion()
    {
        var val_4;
        bool val_5;
        var val_6;
        if(RankingController.NewRank > RankingController.OriginalRank)
        {
                val_4 = null;
            val_4 = null;
            var val_3 = (RankingController.NewRank > DataStructs.UserDataDictionary.Stats.GetCurrentCharacterPVPStats().LastRewardedRank) ? 1 : 0;
        }
        else
        {
                val_5 = false;
        }
        
        val_6 = null;
        RankingController.<isRewardForRankUpThisMatch>k__BackingField = val_5;
        val_6 = null;
        return (bool)RankingController.<isRewardForRankUpThisMatch>k__BackingField;
    }
    public static DataStructs.PlayerRank DetermineUserRank(RankingConstraints _rank, int _battlePoints)
    {
        if((_rank.m_PointsToRankUp != 1) && (_rank.m_PointsToRankUp < _battlePoints))
        {
                return _rank.RankUp();
        }
        
        if(_rank.m_PointsToRankDown == 1)
        {
                return (DataStructs.PlayerRank)_rank.m_Rank;
        }
        
        if(_rank.m_PointsToRankDown <= _battlePoints)
        {
                return (DataStructs.PlayerRank)_rank.m_Rank;
        }
        
        return _rank.RankDown();
    }
    public bool CheckForRankPromotion(NetworkUserInfo _thisPlayer, NetworkUserInfo _opponent, bool _forceRank = False, bool _forceRankUp = False)
    {
        DataStructs.Stats val_26;
        int val_27;
        int val_28;
        var val_29;
        RankingConstraints val_30;
        int val_31;
        int val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        val_26 = this;
        if(_thisPlayer != null)
        {
                val_27 = _thisPlayer.currentCharacterBP;
        }
        else
        {
                val_27 = 0;
        }
        
        if(_opponent != null)
        {
                val_28 = _opponent.currentCharacterBP;
        }
        else
        {
                val_28 = 0;
        }
        
        MatchOutcomePoints val_1 = Model_BP_PP_Library.CalculateBattlePoints(battlePoints_Self:  0, rank_Self:  _thisPlayer.currentCharacterRank, battlePoints_Opponent:  0, rank_Opponent:  _opponent.currentCharacterRank);
        RankingController.m_MatchOutcomeBP = val_1.Points_Gain;
        RankingController.m_MatchOutcomeBP.__il2cppRuntimeField_3 = val_1.Points_Loss;
        RankingController.m_MatchOutcomeBP.__il2cppRuntimeField_8 = val_1.TotalPoints_AfterMatchWon;
        RankingController.m_MatchOutcomeBP.__il2cppRuntimeField_C = val_1.TotalPoints_AfterMatchLoss;
        MatchOutcomePoints val_2 = Model_BP_PP_Library.CalculatePlayerPoints(playerPoints_Self:  _thisPlayer.playerPoint, playerPoints_Opponent:  _opponent.playerPoint);
        RankingController.m_MatchOutcomePP = val_2.Points_Gain;
        RankingController.m_MatchOutcomeBP.__il2cppRuntimeField_14 = val_2.Points_Loss;
        RankingController.m_MatchOutcomeBP.__il2cppRuntimeField_18 = val_2.TotalPoints_AfterMatchWon;
        RankingController.m_MatchOutcomeBP.__il2cppRuntimeField_1C = val_2.TotalPoints_AfterMatchLoss;
        object[] val_3 = new object[2];
        val_3[0] = val_1;
        val_3[1] = val_2;
        UnityEngine.Debug.LogFormat(format:  "Match outcome BP: [{0}] - PP: [{1}]", args:  val_3);
        val_29 = null;
        val_29 = null;
        this.m_Data.RankImage.sprite = RankingCollection.GetRankSprite(rank:  DataStructs.UserDataDictionary.Stats.CurrentCharacterRank);
        int val_8 = val_1.TotalPoints_AfterMatchWon >> 32;
        this.m_UserRankingConstraints = RankingCollection.Get(rank:  DataStructs.UserDataDictionary.Stats.CurrentCharacterRank);
        if(val_7.m_PointsToRankDown >= val_8)
        {
            goto label_24;
        }
        
        val_30 = this.m_UserRankingConstraints;
        if(val_30 == null)
        {
            goto label_25;
        }
        
        val_31 = 1;
        goto label_26;
        label_24:
        val_31 = 0;
        goto label_27;
        label_25:
        val_31 = 1;
        label_27:
        val_30 = this.m_UserRankingConstraints;
        label_26:
        if(_forceRank == false)
        {
            goto label_28;
        }
        
        if(_forceRankUp == false)
        {
            goto label_30;
        }
        
        val_31 = this.m_UserRankingConstraints.m_PointsToRankUp;
        DataStructs.PlayerRank val_11 = RankingController.DetermineUserRank(_rank:  (_forceRank != true) ? (val_30) : 0, _battlePoints:  val_31 + 1);
        if(this != null)
        {
                if(_forceRank == true)
        {
            goto label_32;
        }
        
        }
        
        label_28:
        var val_12 = (val_31 != 0) ? val_1.TotalPoints_AfterMatchWon : (val_8);
        goto label_33;
        label_30:
        val_33 = this.m_UserRankingConstraints.m_PointsToRankDown - 1;
        label_33:
        label_32:
        this.m_Rank = RankingController.DetermineUserRank(_rank:  val_30, _battlePoints:  val_33);
        object[] val_14 = new object[2];
        val_14[0] = this.m_Rank;
        val_14[1] = this.m_UserRankingConstraints;
        UnityEngine.Debug.LogFormat(format:  "RANK: {0}, Constraints: {1}", args:  val_14);
        object[] val_15 = new object[1];
        val_15[0] = this.m_Rank;
        UnityEngine.Debug.LogFormat(format:  "NEW RANK", args:  val_15);
        NetworkUtils.SetImageSpriteWithSpriteSize(_i:  this.m_Data.RankImage, _s:  RankingCollection.GetRankSprite(rank:  this.m_Rank));
        val_34 = null;
        val_34 = null;
        int val_17 = val_1.Points_Gain >> 32;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_18 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_17);
        DataStructs.UserDataDictionary.GameSave.QuitLoss_BattleP = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_18.currentCryptoKey, hiddenValue = val_18.hiddenValue, fakeValue = val_18.fakeValue, inited = val_18.inited};
        int val_19 = val_2.Points_Gain >> 32;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_20 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_19);
        DataStructs.UserDataDictionary.GameSave.QuitLoss_PlayerP = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_20.currentCryptoKey, hiddenValue = val_20.hiddenValue, fakeValue = val_20.fakeValue, inited = val_20.inited};
        object[] val_21 = new object[2];
        val_21[0] = val_17;
        val_21[1] = val_19;
        UnityEngine.Debug.LogFormat(format:  "QuitLoss_BattleP: {0} - QuitLoss_PlayerP: {1}", args:  val_21);
        if(this.m_Rank > DataStructs.UserDataDictionary.Stats.CurrentCharacterRank)
        {
                val_35 = 1;
            this.SetActiveRankPanel(_panel:  this.m_Data.RankUpOpportunity.Panel, _rankData:  this.m_Data.RankUpOpportunity, _rankUp:  true);
            return (bool)val_35;
        }
        
        val_36 = null;
        val_36 = null;
        if(this.m_Rank < DataStructs.UserDataDictionary.Stats.CurrentCharacterRank)
        {
                this.SetActiveRankPanel(_panel:  this.m_Data.RankDownWarning.Panel, _rankData:  this.m_Data.RankDownWarning, _rankUp:  false);
            val_35 = 1;
            return (bool)val_35;
        }
        
        val_37 = null;
        val_37 = null;
        val_26 = DataStructs.UserDataDictionary.Stats;
        DataStructs.PlayerRank val_24 = val_26.CurrentCharacterRank;
        val_35 = 0;
        return (bool)val_35;
    }
    public bool CheckForNewRank(bool _forceRank = False, bool _forceRankUp = False)
    {
        CharacterNameID val_11;
        UnityEngine.Object val_14;
        var val_15;
        int val_16;
        var val_17;
        UnityEngine.RectTransform val_18;
        var val_19;
        val_14 = this;
        val_15 = null;
        val_15 = null;
        this.m_Data.RankImage.sprite = RankingCollection.GetRankSprite(rank:  DataStructs.UserDataDictionary.Stats.CurrentCharacterRank);
        this.m_UserRankingConstraints = RankingCollection.Get(rank:  DataStructs.UserDataDictionary.Stats.CurrentCharacterRank);
        val_16 = 1152921505103863808;
        NetworkUtils.SetImageSpriteWithSpriteSize(_i:  this.m_Data.RankImage, _s:  RankingCollection.GetRankSprite(rank:  RankingController.NewRank));
        if(RankingController.NewRank <= RankingController.OriginalRank)
        {
            goto label_10;
        }
        
        val_17 = null;
        val_17 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = DataStructs.UserDataDictionary.Items.Shells;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  this.m_UserRankingConstraints.m_Shells + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited})));
        val_16 = val_9.currentCryptoKey;
        DataStructs.UserDataDictionary.Items.Shells = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_16, hiddenValue = val_9.hiddenValue, fakeValue = val_9.fakeValue, inited = val_9.inited};
        val_18 = this.m_Data.RankUpPanel;
        goto label_19;
        label_10:
        if(RankingController.NewRank >= RankingController.OriginalRank)
        {
            goto label_20;
        }
        
        this.m_Demoted = true;
        val_18 = this.m_Data.RankDownPanel;
        label_19:
        this.SetActiveRankPanel(_panel:  val_18, _rankData:  0, _rankUp:  false);
        val_19 = 1;
        return (bool)val_19;
        label_20:
        if(RankingController.NewRank == RankingController.OriginalRank)
        {
                UnityEngine.Debug.Log(message:  "RANK STAYS THE SAME");
            CharacterInfo val_10 = Character_GlobalInfo.GetMainPlayer();
            UnlockableCollection.Setup(charID:  val_11);
            val_14 = UnityEngine.Object.FindObjectOfType<GameOverPanel>();
            if(0 != val_14)
        {
                val_14.ShowButtonGroup();
        }
        
        }
        
        val_19 = 0;
        return (bool)val_19;
    }
    private void SetActiveRankPanel(UnityEngine.RectTransform _panel, RankingController.RankOpportunityData _rankData, bool _rankUp = False)
    {
        var val_8;
        UnityEngine.RectTransform val_9;
        UnityEngine.RectTransform val_10;
        val_8 = 0;
        val_9 = 0;
        goto label_1;
        label_10:
        val_10 = _panel;
        if(_panel != this.m_RankingPanelList.Item[0])
        {
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            _panel.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            val_10 = val_9;
        }
        
        val_8 = 1;
        val_9 = val_10;
        label_1:
        if(val_8 < this.m_RankingPanelList.Count)
        {
            goto label_10;
        }
        
        if(this.m_AnimationSequence != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.m_AnimationSequence, complete:  false);
        }
        
        this.m_AnimationSequence = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), isIndependentUpdate:  true);
        this.m_Data.MainPanelTransparency.interactable = true;
        if(_rankData != null)
        {
                this.AnimateRankOpporunityPanel(_panel:  _rankData, _rankUp:  _rankUp);
            return;
        }
        
        this.AnimateRankGainPanel(_panel:  val_9);
    }
    private void AnimateRankOpporunityPanel(RankingController.RankOpportunityData _panel, bool _rankUp)
    {
        float val_33;
        RankingController.<>c__DisplayClass32_0 val_1 = new RankingController.<>c__DisplayClass32_0();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        ._panel = _panel;
        mem[1152921528456695768] = this;
        if(_panel != null)
        {
            goto label_34;
        }
        
        label_35:
        label_34:
        if(0 == _panel.Panel)
        {
                return;
        }
        
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.m_AnimationSequence, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_Data.MainPanelTransparency, endValue:  1f, duration:  0.25f));
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.m_AnimationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  _panel.Panel, endValue:  1f, duration:  0.3f), ease:  27));
        UnityEngine.Vector2 val_9 = mem[_panel.Arrows + 32].rectTransform.anchoredPosition;
        float val_33 = val_9.y;
        mem[_panel.Arrows + 32].gameObject.SetActive(value:  true);
        mem[_panel.Arrows + 40].gameObject.SetActive(value:  true);
        if(_rankUp == false)
        {
            goto label_32;
        }
        
        val_33 = 25f;
        goto label_33;
        label_1:
        mem[16] = _panel;
        mem[24] = this;
        if(mem[16] != 0)
        {
            goto label_34;
        }
        
        goto label_35;
        label_32:
        val_33 = -25f;
        label_33:
        val_33 = val_33 + val_33;
        DG.Tweening.Tweener val_15 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  mem[_panel.Arrows + 32].rectTransform, endValue:  val_33, duration:  0.4f, snapping:  false), ease:  4), loops:  0, loopType:  1);
        DG.Tweening.Tweener val_19 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  mem[_panel.Arrows + 40].rectTransform, endValue:  val_33, duration:  0.4f, snapping:  false), ease:  4), loops:  0, loopType:  1);
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = _panel.InitialTextImageScale, y = mem[_panel + 48 + 4], z = mem[_panel + 56]}, d:  1.15f);
        DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.m_AnimationSequence, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  _panel.TextImage.rectTransform, endValue:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, duration:  0.35f), ease:  mem[24]), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RankingController.<>c__DisplayClass32_0::<AnimateRankOpporunityPanel>b__0())));
        DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.m_AnimationSequence, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_Data.RankImage.rectTransform, endValue:  0.75f, duration:  0.55f), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RankingController.<>c__DisplayClass32_0::<AnimateRankOpporunityPanel>b__1())));
        DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.m_AnimationSequence, interval:  1.5f);
    }
    public void AnimateRankGainPanel(UnityEngine.RectTransform _panel)
    {
        RankingController.<>c__DisplayClass33_0 val_1 = new RankingController.<>c__DisplayClass33_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        ._panel = _panel;
        UnityEngine.Debug.LogFormat(format:  "####### ANIMATE RANK GAIN PANEL", args:  System.Array.Empty<System.Object>());
        if(0 == ((RankingController.<>c__DisplayClass33_0)[1152921528457135568]._panel))
        {
                return;
        }
        
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.m_AnimationSequence, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_Data.MainPanelTransparency, endValue:  1f, duration:  0.25f), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RankingController.<>c__DisplayClass33_0::<AnimateRankGainPanel>b__0())));
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.m_AnimationSequence, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (RankingController.<>c__DisplayClass33_0)[1152921528457135568]._panel, endValue:  1.4f, duration:  0.65f), ease:  27), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RankingController.<>c__DisplayClass33_0::<AnimateRankGainPanel>b__1())));
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.m_AnimationSequence, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_Data.RankImage.rectTransform, endValue:  1.3f, duration:  0.55f), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RankingController.<>c__DisplayClass33_0::<AnimateRankGainPanel>b__2())));
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.m_AnimationSequence, interval:  2f);
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.m_AnimationSequence, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RankingController.<>c__DisplayClass33_0::<AnimateRankGainPanel>b__3()));
    }
    private System.Collections.IEnumerator PerformRankImageSwap()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new RankingController.<PerformRankImageSwap>d__34();
    }
    public void FadeOut()
    {
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.m_AnimationSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_Data.MainPanelTransparency, endValue:  0f, duration:  0.35f), ease:  26));
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.m_AnimationSequence, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void RankingController::<FadeOut>b__35_0()));
    }
    private void TrySavePublicData()
    {
    
    }
    public void HideRankingPanels(bool _smooth)
    {
        this.m_Data.MainPanelTransparency.interactable = false;
        if(_smooth != false)
        {
                DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_Data.MainPanelTransparency, endValue:  0f, duration:  0.15f), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void RankingController::DeactivateRankingPanels()));
            return;
        }
        
        this.m_Data.MainPanelTransparency.alpha = 0f;
        this.DeactivateRankingPanels();
    }
    private void DeactivateRankingPanels()
    {
        goto label_1;
        label_11:
        if(0 != this.m_RankingPanelList.Item[0])
        {
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            this.m_RankingPanelList.Item[0].localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        
        0 = 1;
        label_1:
        if(0 < this.m_RankingPanelList.Count)
        {
            goto label_11;
        }
    
    }
    private void OnDrawGizmos()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.magenta;
        UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.25f);
        UnityEngine.Gizmos.DrawCube(center:  new UnityEngine.Vector3() {x = this.m_Data.RankImageFinalPosition, y = V8.16B, z = V9.16B}, size:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.25f);
        UnityEngine.Gizmos.DrawCube(center:  new UnityEngine.Vector3() {x = this.m_Data.ShellsTextFinalPosition, y = V9.16B, z = this.m_Data.RankImageFinalPosition}, size:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
    }
    public RankingController()
    {
        this.m_Data = new RankingController.Data();
    }
    private void <FadeOut>b__35_0()
    {
        this.HideRankingPanels(_smooth:  true);
    }

}
