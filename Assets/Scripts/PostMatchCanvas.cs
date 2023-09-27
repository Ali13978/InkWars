using UnityEngine;
public class PostMatchCanvas : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject RematchPanel;
    private UnityEngine.RectTransform playerInfo;
    private UnityEngine.RectTransform OpponentInfo;
    private PostMatchCommonPanel commonPanel;
    private MatchLosePanel losePanel;
    private MatchWinPanel winPanel;
    private MatchDrawPanel drawPanel;
    private PostMatchAnimationSettings m_animationSettings;
    private UnityEngine.GameObject AdController;
    private View_PVPGameOverQuote quoteData;
    private TMPro.TextMeshProUGUI win;
    private TMPro.TextMeshProUGUI lose;
    private TMPro.TextMeshProUGUI draw;
    private TMPro.TextMeshProUGUI pearls;
    private TMPro.TextMeshProUGUI shells;
    private TMPro.TextMeshProUGUI playerPoints;
    private TMPro.TextMeshProUGUI battlePoints;
    private UnityEngine.UI.Text m_returningtoLobbyText;
    private UnityEngine.UI.Image rank;
    private UnityEngine.GameObject winEffect;
    public UnityEngine.AudioClip winAudioClip;
    public static bool IsPublicMatch;
    public static bool IsPrivateWagerMatch;
    private static PostMatchCanvas m_Instance;
    public PostMatchCanvas.AnimData AnimSettings;
    private float animationDuration;
    private UnityEngine.ParticleSystem starFX;
    private GameStatus m_status;
    private System.Action m_replayAction;
    private System.Action m_backButtonAction;
    private Prize m_prize;
    private int score;
    private int bp;
    private int pp;
    private int bonus;
    
    // Properties
    public static PostMatchCanvas Instance { get; }
    
    // Methods
    public static PostMatchCanvas get_Instance()
    {
        var val_4;
        PostMatchCanvas val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        val_5 = PostMatchCanvas.m_Instance;
        if(0 == val_5)
        {
                val_6 = null;
            val_5 = UnityEngine.Object.Instantiate<PostMatchCanvas>(original:  UnityEngine.Resources.Load<PostMatchCanvas>(path:  "DynamicUI/PostMatchCanvas"));
            val_6 = null;
            PostMatchCanvas.m_Instance = val_5;
        }
        else
        {
                val_6 = null;
        }
        
        val_6 = null;
        return (PostMatchCanvas)PostMatchCanvas.m_Instance;
    }
    private void Start()
    {
        this.starFX = UnityEngine.Resources.Load<UnityEngine.ParticleSystem>(path:  "DynamicUI/FX_Sparkels");
    }
    private DG.Tweening.Sequence UpdateWLD()
    {
        InkWars.Model.Model_Core val_55;
        var val_56;
        IntPtr val_58;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        InkWars.Model.Model_Manager val_2 = InkWars.Model.Model_Manager.Instance;
        val_55 = val_2.Model;
        InkWars.Model.GameResult val_3 = val_55.GameResult;
        if(val_3 > 6)
        {
                return val_1;
        }
        
        var val_55 = 1;
        val_55 = val_55 << val_3;
        if((val_55 & 18) != 0)
        {
            goto label_6;
        }
        
        val_55 = val_55 & 36;
        if(val_55 != 0)
        {
            goto label_7;
        }
        
        var val_56 = 1;
        val_56 = val_56 << val_3;
        val_56 = val_56 & 72;
        if(val_56 == 0)
        {
                return val_1;
        }
        
        UnityEngine.RectTransform val_5 = this.draw.GetComponent<UnityEngine.RectTransform>();
        val_56 = 1152921504886558720;
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void PostMatchCanvas::<UpdateWLD>b__32_6()));
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  5f);
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_5, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.5f), ease:  27));
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void PostMatchCanvas::<UpdateWLD>b__32_7()));
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1f);
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
        DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_5, endValue:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, duration:  0.5f), ease:  30));
        val_58 = 1152921528666938464;
        goto label_17;
        label_6:
        .<>4__this = this;
        .winRT = this.win.GetComponent<UnityEngine.RectTransform>();
        val_56 = 1152921504886558720;
        DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void PostMatchCanvas::<UpdateWLD>b__32_0()));
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, d:  5f);
        DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (PostMatchCanvas.<>c__DisplayClass32_0)[1152921528667218720].winRT, endValue:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, duration:  0.5f), ease:  27));
        DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOShakePosition(target:  (PostMatchCanvas.<>c__DisplayClass32_0)[1152921528667218720].winRT, duration:  0.5f, strength:  10f, vibrato:  30, randomness:  90f, snapping:  false, fadeOut:  false));
        DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  new PostMatchCanvas.<>c__DisplayClass32_0(), method:  System.Void PostMatchCanvas.<>c__DisplayClass32_0::<UpdateWLD>b__1()));
        DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1.5f);
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.one;
        DG.Tweening.Sequence val_37 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (PostMatchCanvas.<>c__DisplayClass32_0)[1152921528667218720].winRT, endValue:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, duration:  0.5f), ease:  30));
        val_58 = 1152921528667023456;
        goto label_17;
        label_7:
        UnityEngine.RectTransform val_38 = this.lose.GetComponent<UnityEngine.RectTransform>();
        val_56 = 1152921504886558720;
        DG.Tweening.Sequence val_40 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void PostMatchCanvas::<UpdateWLD>b__32_3()));
        UnityEngine.Vector3 val_41 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z}, d:  5f);
        DG.Tweening.Sequence val_45 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_38, endValue:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z}, duration:  0.5f), ease:  27));
        DG.Tweening.Sequence val_47 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void PostMatchCanvas::<UpdateWLD>b__32_4()));
        DG.Tweening.Sequence val_48 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1f);
        UnityEngine.Vector3 val_49 = UnityEngine.Vector3.one;
        DG.Tweening.Sequence val_52 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_38, endValue:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z}, duration:  0.5f), ease:  30));
        DG.Tweening.TweenCallback val_53 = null;
        val_58 = 1152921528667083872;
        label_17:
        val_55 = val_53;
        val_53 = new DG.Tweening.TweenCallback(object:  this, method:  val_58);
        DG.Tweening.Sequence val_54 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  val_53);
        return val_1;
    }
    private void OnEnable()
    {
        var val_4;
        var val_5;
        if(0 != this.winEffect)
        {
                SeventyOneSquared.PDUnity val_2 = this.winEffect.GetComponentInChildren<SeventyOneSquared.PDUnity>();
            val_2.Running = true;
        }
        
        val_4 = null;
        val_4 = null;
        if(0 != PostMatchCanvas.m_Instance)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        PostMatchCanvas.m_Instance = this;
    }
    private void ResetStatsOnUI(bool applyDiffForAnim = True)
    {
        string val_55;
        int val_56;
        var val_57;
        string val_58;
        var val_59;
        TMPro.TextMeshProUGUI val_60;
        var val_61;
        var val_62;
        int val_63;
        int val_64;
        int val_65;
        int val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_71;
        var val_72;
        var val_73;
        int val_74;
        var val_75;
        var val_76;
        decimal val_77;
        var val_78;
        val_55 = applyDiffForAnim;
        val_56 = PublicWagerData.GetDataByLevel(level:  PublicWagerData.selectedWagerLevel);
        val_57 = null;
        val_57 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Stats.TotalPVPWins;
        this.win.text = val_3.currentCryptoKey.ToString();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Stats.TotalPVPLosses;
        this.lose.text = val_5.currentCryptoKey.ToString();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = DataStructs.UserDataDictionary.Stats.TotalPVPDraws;
        this.draw.text = val_7.currentCryptoKey.ToString();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = DataStructs.UserDataDictionary.Stats.PlayerPoints;
        val_58 = val_9.currentCryptoKey.ToString();
        this.playerPoints.text = val_58;
        InkWars.Model.Model_Manager val_11 = InkWars.Model.Model_Manager.Instance;
        InkWars.Model.GameResult val_12 = val_11.Model.GameResult;
        if(val_12 > 6)
        {
                return;
        }
        
        var val_55 = 1;
        val_55 = val_55 << val_12;
        if((val_55 & 18) != 0)
        {
            goto label_14;
        }
        
        val_55 = val_55 & 36;
        if(val_55 != 0)
        {
            goto label_15;
        }
        
        var val_56 = 1;
        val_56 = val_56 << val_12;
        val_56 = val_56 & 72;
        if(val_56 == 0)
        {
                return;
        }
        
        NetworkUserInfo val_14 = DataStructs.UserDataDictionary.ToNetworkUserInfo();
        int val_57 = val_14.draw;
        val_57 = val_57 - val_55;
        this.draw.text = val_57.ToString();
        if(val_2.m_currency == 0)
        {
            goto label_22;
        }
        
        val_59 = null;
        val_60 = this.shells;
        val_59 = null;
        val_61 = DataStructs.UserDataDictionary.Items;
        val_62 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_17 = val_61.Shells;
        goto label_26;
        label_14:
        NetworkUserInfo val_18 = DataStructs.UserDataDictionary.ToNetworkUserInfo();
        int val_58 = val_18.win;
        val_58 = val_58 - val_55;
        this.win.text = val_58.ToString();
        NetworkUserInfo val_21 = DataStructs.UserDataDictionary.ToNetworkUserInfo();
        if(val_55 == false)
        {
            goto label_34;
        }
        
        val_63 = Model_BP_PP_Library.BattlePoints_DeductionMultiplier_Normal;
        int val_22 = UnityEngine.Mathf.Abs(value:  val_63);
        goto label_37;
        label_15:
        NetworkUserInfo val_23 = DataStructs.UserDataDictionary.ToNetworkUserInfo();
        int val_59 = val_23.lose;
        val_59 = val_59 - val_55;
        this.lose.text = val_59.ToString();
        int val_27 = System.Int32.Parse(s:  this.playerPoints.text);
        NetworkUserInfo val_28 = DataStructs.UserDataDictionary.ToNetworkUserInfo();
        val_58 = val_28.playerPoint;
        if(val_55 == false)
        {
            goto label_47;
        }
        
        val_64 = Model_BP_PP_Library.BattlePoints_DeductionMultiplier_Normal.__il2cppRuntimeField_4;
        int val_29 = UnityEngine.Mathf.Abs(value:  val_64);
        goto label_50;
        label_34:
        val_63 = 0;
        label_37:
        this.playerPoints.text = val_21.playerPoint - val_63.ToString();
        NetworkUserInfo val_32 = DataStructs.UserDataDictionary.ToNetworkUserInfo();
        if(val_55 == false)
        {
            goto label_55;
        }
        
        val_65 = Model_BP_PP_Library.LastCalculated_BattlePoints;
        int val_33 = UnityEngine.Mathf.Abs(value:  val_65);
        goto label_58;
        label_47:
        val_64 = 0;
        label_50:
        this.playerPoints.text = val_64 + val_58.ToString();
        int val_37 = System.Int32.Parse(s:  this.playerPoints.text);
        val_60 = this.battlePoints;
        NetworkUserInfo val_38 = DataStructs.UserDataDictionary.ToNetworkUserInfo();
        val_56 = val_38.currentCharacterBP;
        if(val_55 == false)
        {
            goto label_65;
        }
        
        val_66 = Model_BP_PP_Library.BattlePoints_DeductionMultiplier_Normal.__il2cppRuntimeField_14;
        int val_39 = UnityEngine.Mathf.Abs(value:  val_66);
        goto label_68;
        label_55:
        val_65 = 0;
        label_58:
        this.battlePoints.text = val_32.currentCharacterBP - val_65.ToString();
        if(val_2.m_currency == 0)
        {
            goto label_71;
        }
        
        val_67 = null;
        val_60 = this.shells;
        val_67 = null;
        val_68 = DataStructs.UserDataDictionary.Items;
        val_69 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_42 = val_68.Shells;
        goto label_75;
        label_65:
        val_66 = 0;
        label_68:
        string val_44 = val_66 + val_56.ToString();
        goto label_76;
        label_22:
        val_71 = null;
        val_60 = this.pearls;
        val_71 = null;
        val_61 = DataStructs.UserDataDictionary.Items;
        val_62 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_45 = val_61.Pearls;
        label_26:
        val_72 = 1152921504618348544;
        val_73 = 0;
        decimal val_47 = System.Decimal.op_Implicit(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_45.currentCryptoKey, hiddenValue = val_45.hiddenValue, fakeValue = val_45.fakeValue, inited = val_45.inited}));
        val_56 = val_47.flags;
        val_74 = val_47.lo;
        if(val_55 == false)
        {
            goto label_93;
        }
        
        val_75 = 0;
        decimal val_48 = PublicWagerData.lastWager;
        goto label_85;
        label_71:
        val_76 = null;
        val_60 = this.pearls;
        val_76 = null;
        val_68 = DataStructs.UserDataDictionary.Items;
        val_69 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_49 = val_68.Pearls;
        label_75:
        val_72 = 1152921504618348544;
        val_73 = 0;
        decimal val_51 = System.Decimal.op_Implicit(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_49.currentCryptoKey, hiddenValue = val_49.hiddenValue, fakeValue = val_49.fakeValue, inited = val_49.inited}));
        val_56 = val_51.flags;
        val_74 = val_51.lo;
        if(val_55 == false)
        {
            goto label_93;
        }
        
        val_75 = 0;
        decimal val_52 = PublicWagerData.lastPrize;
        label_85:
        val_77 = val_52.flags;
        val_58 = val_52.lo;
        goto label_94;
        label_93:
        val_78 = null;
        val_78 = null;
        val_77 = System.Decimal.Zero;
        label_94:
        decimal val_53 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = val_56, hi = val_47.hi, lo = val_74, mid = val_47.mid}, d2:  new System.Decimal() {flags = val_77, hi = val_77, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        label_76:
        val_55 = val_53.flags.ToString();
        val_60.text = val_55;
    }
    public static void Hide()
    {
        PostMatchCanvas.Instance.gameObject.SetActive(value:  false);
        UnityEngine.Object.Destroy(obj:  PostMatchCanvas.Instance);
    }
    public void ShowLocal()
    {
        this.gameObject.SetActive(value:  true);
        this.DoAnimations();
    }
    public static void Show()
    {
        PostMatchCanvas.Instance.gameObject.SetActive(value:  true);
        DialogManager.ShowCustomDialog(dialog:  PostMatchCanvas.Instance.GetComponent<UnityEngine.RectTransform>());
        PostMatchCanvas.Instance.DoAnimations();
    }
    public void DoAnimations()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        val_6 = null;
        val_6 = null;
        this.ResetStatsOnUI(applyDiffForAnim:  (Character_GlobalInfo.gameMode == 6) ? 1 : 0);
        InkWars.Model.Model_Manager val_2 = InkWars.Model.Model_Manager.Instance;
        InkWars.Model.GameResult val_3 = val_2.Model.GameResult;
        if(val_3 > 6)
        {
                return;
        }
        
        var val_5 = 1;
        val_5 = val_5 << val_3;
        if((val_5 & 18) != 0)
        {
            goto label_11;
        }
        
        val_5 = val_5 & 36;
        if(val_5 != 0)
        {
            goto label_12;
        }
        
        var val_6 = 1;
        val_6 = val_6 << val_3;
        val_6 = val_6 & 72;
        if(val_6 == 0)
        {
                return;
        }
        
        this.Draw();
        return;
        label_11:
        this.Win();
        return;
        label_12:
        this.Lose();
    }
    private void Update()
    {
    
    }
    private void Animate()
    {
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), isIndependentUpdate:  true);
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.playerInfo, endValue:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, duration:  this.AnimSettings.dropDownAnim.duration, snapping:  false), ease:  this.AnimSettings.dropDownAnim.ease), isIndependentUpdate:  true));
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.zero;
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.OpponentInfo, endValue:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, duration:  this.AnimSettings.dropDownAnim.duration, snapping:  false), ease:  this.AnimSettings.dropDownAnim.ease), isIndependentUpdate:  true));
    }
    private void Lose()
    {
        var val_4;
        this.losePanel.gameObject.SetActive(value:  true);
        val_4 = null;
        val_4 = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
                this.commonPanel.Setup(_title:  LanguageManager.GetText(key:  "LK.P2Wins"), _score:  "");
            this.LocalLoseAnimation();
            return;
        }
        
        this.commonPanel.Setup(_title:  LanguageManager.GetText(key:  "LK.YouLose"), _score:  "");
        this.LoseCoroutine();
    }
    private void LoseCoroutine()
    {
        string val_19;
        float val_20;
        var val_88;
        System.Collections.Generic.List<ProfileUnlockables_Base> val_89;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.4f);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowMiddleStrip(showUp:  true));
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.4f);
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.losePanel.ShowCharacters(showIn:  true));
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.6f);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowHeading(showIn:  true));
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowUserPanel(showIn:  true, side:  2));
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowFlag(showIn:  true, side:  2));
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowUserBattleEnhancer(showIn:  true, side:  2));
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.6f);
        QuoteData val_18 = this.quoteData.GetQuoteData();
        DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.losePanel.ShowDialog(_text:  new QuoteData() {color = new UnityEngine.Color() {r = val_20, g = val_20, b = val_20, a = val_20}, quote = val_19}));
        DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
        DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowScore(displayMainPlayerScore:  true));
        DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1f);
        DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.PlayHighScoreAnimation());
        DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowUserBattleEnhancer(showIn:  false, side:  2));
        val_88 = null;
        val_88 = null;
        if(PostMatchCanvas.IsPublicMatch != false)
        {
                DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.UpdateWLD());
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1f);
            DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.losePanel.HideDialog());
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1f);
            DG.Tweening.Sequence val_38 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowFlag(showIn:  false, side:  2));
            DG.Tweening.Sequence val_40 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowUserPanel(showIn:  false, side:  1));
            DG.Tweening.Sequence val_42 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.losePanel.ShowCharacters(showIn:  false));
            DG.Tweening.Sequence val_43 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1f);
            DG.Tweening.Sequence val_45 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowBP(showIn:  true));
            DG.Tweening.Sequence val_47 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowPP(showIn:  true));
            DG.Tweening.Sequence val_49 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowBPTimer(showIn:  true));
            if(RankingController.NewRank != RankingController.OriginalRank)
        {
                DG.Tweening.Sequence val_51 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowPP(showIn:  false));
            DG.Tweening.Sequence val_53 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.RankChangeAnimation());
        }
        
            DG.Tweening.Sequence val_55 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowBP(showIn:  false));
            DG.Tweening.Sequence val_57 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowPP(showIn:  false));
            DG.Tweening.Sequence val_59 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowHeading(showIn:  false));
            DG.Tweening.Sequence val_61 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowBPTimer(showIn:  false));
            DG.Tweening.Sequence val_62 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1f);
            DG.Tweening.Sequence val_64 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.losePanel.ShowTips());
            DG.Tweening.Sequence val_65 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  3f);
            DG.Tweening.Sequence val_67 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.losePanel.HideTips());
            DG.Tweening.Sequence val_68 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1f);
            CharacterInfo val_69 = Character_GlobalInfo.GetMainPlayer();
            val_89 = this.GenerateKeys(charID:  val_20);
            if(val_89.Count >= 1)
        {
                DG.Tweening.Sequence val_73 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowPrizes(list:  val_89));
            DG.Tweening.Sequence val_74 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  2f);
        }
        
            DG.Tweening.Sequence val_75 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1f);
        }
        else
        {
                DG.Tweening.Sequence val_77 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.losePanel.HideDialog());
            DG.Tweening.Sequence val_79 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowFlag(showIn:  false, side:  2));
            DG.Tweening.Sequence val_81 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowUserPanel(showIn:  false, side:  1));
            DG.Tweening.Sequence val_83 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.losePanel.ShowCharacters(showIn:  false));
            val_89 = this.commonPanel;
            DG.Tweening.Sequence val_85 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  val_89.ShowHeading(showIn:  false));
        }
        
        DG.Tweening.Sequence val_87 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowRematchPanel(show:  true));
    }
    private DG.Tweening.Sequence ResetForRematch()
    {
        return DG.Tweening.DOTween.Sequence();
    }
    private void Draw()
    {
        var val_2;
        this.commonPanel.Setup(_title:  LanguageManager.GetText(key:  "LK.Draw"), _score:  "");
        val_2 = null;
        val_2 = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
                this.LocalDrawAnimation();
            return;
        }
        
        this.DrawCoroutine();
    }
    private System.Collections.Generic.List<ProfileUnlockables_Base> GenerateKeys(CharacterNameID charID)
    {
        var val_4;
        var val_18;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        System.Collections.Generic.List<ProfileUnlockables_Base> val_1 = new System.Collections.Generic.List<ProfileUnlockables_Base>();
        val_18 = null;
        val_18 = null;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_9:
        if(((-1706123616) & 1) == 0)
        {
            goto label_5;
        }
        
        val_1.Add(item:  TitleCollection.GetSpecificTitleByKey(cid:  charID, key:  val_4.GetHashCode()));
        goto label_9;
        label_5:
        val_4.Add(driver:  public System.Void List.Enumerator<Titles_Specific_Key>::Dispose(), rectTransform:  null, drivenProperties:  null);
        val_20 = null;
        val_20 = null;
        List.Enumerator<T> val_7 = GetEnumerator();
        label_23:
        if(((-1706123648) & 1) == 0)
        {
            goto label_19;
        }
        
        val_1.Add(item:  TitleCollection.GetCommonTitleByKey(key:  val_4.GetHashCode()));
        goto label_23;
        label_19:
        val_4.Add(driver:  public System.Void List.Enumerator<Titles_Common_Key>::Dispose(), rectTransform:  null, drivenProperties:  null);
        val_21 = null;
        val_21 = null;
        List.Enumerator<T> val_10 = GetEnumerator();
        label_37:
        if(((-1706123680) & 1) == 0)
        {
            goto label_33;
        }
        
        val_1.Add(item:  AvatarCollection.GetSpecificAvatarByKey(cid:  charID, key:  val_4.GetHashCode()));
        goto label_37;
        label_33:
        val_4.Add(driver:  public System.Void List.Enumerator<Avatars_Specific_Key>::Dispose(), rectTransform:  null, drivenProperties:  null);
        val_22 = 0;
        if( != 1)
        {
                var val_13 = (209 == 209) ? 1 : 0;
            val_13 = (( >= 0) ? 1 : 0) & val_13;
             =  - val_13;
             =  + 1;
            val_23 = (long);
        }
        else
        {
                val_23 = 0;
        }
        
        val_24 = null;
        val_24 = null;
        List.Enumerator<T> val_15 = GetEnumerator();
        label_53:
        if(((-1706123704) & 1) == 0)
        {
            goto label_49;
        }
        
        val_1.Add(item:  AvatarCollection.GetCommonAvatarByKey(key:  0.GetHashCode()));
        goto label_53;
        label_49:
        0.Add(driver:  public System.Void List.Enumerator<Avatars_Common_Key>::Dispose(), rectTransform:  null, drivenProperties:  null);
        return val_1;
    }
    private void DrawCoroutine()
    {
        string val_8;
        float val_9;
        System.Collections.Generic.List<ProfileUnlockables_Base> val_48;
        var val_49;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.4f);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowMiddleStrip(showUp:  true));
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.drawPanel.ShowCharacters(showIn:  true));
        QuoteData val_7 = this.quoteData.GetQuoteData();
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.drawPanel.ShowDialog(_text:  new QuoteData() {color = new UnityEngine.Color() {r = val_9, g = val_9, b = val_9, a = val_9}, quote = val_8}));
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowHeading(showIn:  true));
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowScore(displayMainPlayerScore:  true));
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.5f);
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowUserPanel(showIn:  true, side:  2));
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowFlag(showIn:  true, side:  2));
        DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowUserBattleEnhancer(showIn:  true, side:  2));
        DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.5f);
        DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.UpdateWLD());
        DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.5f);
        DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.drawPanel.HideDialog());
        DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowHeading(showIn:  false));
        DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowFlag(showIn:  false, side:  2));
        DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowUserPanel(showIn:  false, side:  1));
        DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.drawPanel.ShowCharacters(showIn:  false));
        DG.Tweening.Sequence val_38 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.commonPanel.ShowUserBattleEnhancer(showIn:  false, side:  2));
        DG.Tweening.Sequence val_39 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1f);
        val_48 = 1152921505119145984;
        val_49 = null;
        val_49 = null;
        if(PostMatchCanvas.IsPublicMatch != false)
        {
                CharacterInfo val_40 = Character_GlobalInfo.GetMainPlayer();
            val_48 = this.GenerateKeys(charID:  val_9);
            if(val_48.Count >= 1)
        {
                DG.Tweening.Sequence val_44 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowPrizes(list:  val_48));
            DG.Tweening.Sequence val_45 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  2f);
        }
        
        }
        
        DG.Tweening.Sequence val_47 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowRematchPanel(show:  true));
    }
    private void Win()
    {
        null = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
                this.commonPanel.Setup(_title:  LanguageManager.GetText(key:  "LK.P1Wins"), _score:  "");
            this.LocalWinAnimation();
            return;
        }
        
        this.commonPanel.Setup(_title:  LanguageManager.GetText(key:  "LK.YouWin"), _score:  "");
        this.WinCoroutine();
    }
    private void WinCoroutine()
    {
        string val_20;
        float val_21;
        var val_101;
        var val_102;
        DG.Tweening.TweenCallback val_104;
        PostMatchCommonPanel val_105;
        var val_106;
        var val_107;
        var val_108;
        InkWars.Model.Model_Manager val_1 = InkWars.Model.Model_Manager.Instance;
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.4f);
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.commonPanel.ShowMiddleStrip(showUp:  true));
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.4f);
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.winPanel.ShowCharacters(showIn:  true));
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.6f);
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.commonPanel.ShowHeading(showIn:  true));
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.commonPanel.ShowUserPanel(showIn:  true, side:  2));
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.commonPanel.ShowFlag(showIn:  true, side:  2));
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.commonPanel.ShowUserBattleEnhancer(showIn:  true, side:  2));
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.6f);
        QuoteData val_19 = this.quoteData.GetQuoteData();
        DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.winPanel.ShowDialog(_text:  new QuoteData() {color = new UnityEngine.Color() {r = val_21, g = val_21, b = val_21, a = val_21}, quote = val_20}));
        DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.2f);
        DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.commonPanel.ShowScore(displayMainPlayerScore:  true));
        DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.2f);
        DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.commonPanel.ShowBonus(bonus:  true.ToString()));
        DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.2f);
        DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.commonPanel.ShowFinalScore(displayMainPlayerScore:  true));
        DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.2f);
        DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.commonPanel.HideBonus());
        DG.Tweening.Sequence val_38 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.commonPanel.PlayHighScoreAnimation());
        DG.Tweening.Sequence val_39 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  1f);
        DG.Tweening.Sequence val_41 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.commonPanel.ShowUserBattleEnhancer(showIn:  false, side:  2));
        val_101 = null;
        val_101 = null;
        if(PostMatchCanvas.IsPublicMatch == false)
        {
            goto label_22;
        }
        
        DG.Tweening.Sequence val_43 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.UpdateWLD());
        DG.Tweening.Sequence val_44 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  1f);
        DG.Tweening.Sequence val_46 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.winPanel.HideDialog());
        DG.Tweening.Sequence val_48 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.commonPanel.ShowFlag(showIn:  false, side:  2));
        DG.Tweening.Sequence val_50 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.commonPanel.ShowUserPanel(showIn:  false, side:  1));
        DG.Tweening.Sequence val_52 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.winPanel.ShowCharacters(showIn:  false));
        val_102 = null;
        val_102 = null;
        val_104 = PostMatchCanvas.<>c.<>9__48_0;
        if(val_104 == null)
        {
                DG.Tweening.TweenCallback val_53 = null;
            val_104 = val_53;
            val_53 = new DG.Tweening.TweenCallback(object:  PostMatchCanvas.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PostMatchCanvas.<>c::<WinCoroutine>b__48_0());
            PostMatchCanvas.<>c.<>9__48_0 = val_104;
        }
        
        DG.Tweening.Sequence val_54 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  val_53);
        DG.Tweening.Sequence val_55 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  1f);
        DG.Tweening.Sequence val_57 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.commonPanel.ShowBP(showIn:  true));
        DG.Tweening.Sequence val_59 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.commonPanel.ShowPP(showIn:  true));
        DG.Tweening.Sequence val_61 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.commonPanel.ShowBPTimer(showIn:  true));
        if(RankingController.NewRank == RankingController.OriginalRank)
        {
            goto label_42;
        }
        
        DG.Tweening.Sequence val_63 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.commonPanel.ShowPP(showIn:  false));
        DG.Tweening.Sequence val_65 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.commonPanel.RankChangeAnimation());
        if(RankingController.isRewardForRankUpThisMatch == false)
        {
            goto label_40;
        }
        
        DG.Tweening.Sequence val_68 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.commonPanel.RankRewardAnimation());
        goto label_42;
        label_22:
        DG.Tweening.Sequence val_70 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.winPanel.HideDialog());
        DG.Tweening.Sequence val_72 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.commonPanel.ShowFlag(showIn:  false, side:  2));
        DG.Tweening.Sequence val_74 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.commonPanel.ShowUserPanel(showIn:  false, side:  1));
        DG.Tweening.Sequence val_76 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.winPanel.ShowCharacters(showIn:  false));
        val_105 = this.commonPanel;
        DG.Tweening.Sequence val_78 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  val_105.ShowHeading(showIn:  false));
        goto label_73;
        label_40:
        UnityEngine.Debug.Log(message:  "No Rewards");
        label_42:
        DG.Tweening.Sequence val_80 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.commonPanel.ShowPP(showIn:  false));
        DG.Tweening.Sequence val_82 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.commonPanel.ShowBP(showIn:  false));
        DG.Tweening.Sequence val_84 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.commonPanel.ShowHeading(showIn:  false));
        DG.Tweening.Sequence val_86 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  this.commonPanel.ShowBPTimer(showIn:  false));
        CharacterInfo val_87 = Character_GlobalInfo.GetMainPlayer();
        val_105 = this.GenerateKeys(charID:  val_21);
        if(val_105.Count <= 0)
        {
            goto label_58;
        }
        
        label_72:
        DG.Tweening.Sequence val_91 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.commonPanel.ShowPrizes(list:  val_105));
        DG.Tweening.Sequence val_92 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  2f);
        label_73:
        DG.Tweening.Sequence val_93 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  1f);
        DG.Tweening.Sequence val_95 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  this.commonPanel.ShowRematchPanel(show:  true));
        return;
        label_58:
        val_106 = null;
        val_106 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_97.m_price, hi = val_97.m_price, lo = PublicWagerData.GetDataByLevel(level:  PublicWagerData.selectedWagerLevel), mid = PublicWagerData.GetDataByLevel(level:  PublicWagerData.selectedWagerLevel)}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) != false)
        {
                if(InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch == false)
        {
            goto label_72;
        }
        
        }
        
        val_107 = null;
        val_107 = null;
        val_108 = null;
        val_108 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = SetWager.privateWager, hi = SetWager.privateWager, lo = SetWager.privateWager.__il2cppRuntimeField_8, mid = SetWager.privateWager.__il2cppRuntimeField_8}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == true)
        {
            goto label_72;
        }
        
        goto label_73;
    }
    private void LocalDrawAnimation()
    {
        string val_8;
        float val_9;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.4f);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowMiddleStrip(showUp:  true));
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.drawPanel.ShowCharacters(showIn:  true));
        QuoteData val_7 = this.quoteData.GetQuoteData();
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.drawPanel.ShowDialog(_text:  new QuoteData() {color = new UnityEngine.Color() {r = val_9, g = val_9, b = val_9, a = val_9}, quote = val_8}));
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowHeading(showIn:  true));
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.5f);
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  0, method:  public static System.Void UnlockableCollection::DisplayNewUnlocksOneByOne()));
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowRemachButtonGroup(showIn:  true));
    }
    private void LocalLoseAnimation()
    {
        string val_13;
        float val_14;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.4f);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowMiddleStrip(showUp:  true));
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.4f);
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.losePanel.ShowCharacters(showIn:  true));
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.6f);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowHeading(showIn:  true));
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.6f);
        QuoteData val_12 = this.quoteData.GetQuoteData();
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.losePanel.ShowDialog(_text:  new QuoteData() {color = new UnityEngine.Color() {r = val_14, g = val_14, b = val_14, a = val_14}, quote = val_13}));
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
        InkWars.Model.Model_Manager val_18 = InkWars.Model.Model_Manager.Instance;
        DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowScore(displayMainPlayerScore:  (val_18.Model.PlayersFlippedLocally == true) ? 1 : 0));
        DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.5f);
        DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  0, method:  public static System.Void UnlockableCollection::DisplayNewUnlocksOneByOne()));
        DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowRemachButtonGroup(showIn:  true));
    }
    private void LocalWinAnimation()
    {
        string val_13;
        float val_14;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.4f);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowMiddleStrip(showUp:  true));
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.4f);
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.winPanel.ShowCharacters(showIn:  true));
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.6f);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowHeading(showIn:  true));
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.6f);
        QuoteData val_12 = this.quoteData.GetQuoteData();
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.winPanel.ShowDialog(_text:  new QuoteData() {color = new UnityEngine.Color() {r = val_14, g = val_14, b = val_14, a = val_14}, quote = val_13}));
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
        DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowScore(displayMainPlayerScore:  true));
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.5f);
        DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  0, method:  public static System.Void UnlockableCollection::DisplayNewUnlocksOneByOne()));
        DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.commonPanel.ShowRemachButtonGroup(showIn:  true));
    }
    public void EnablePlayerRank(bool enable, DataStructs.PlayerRank rank, CharacterClan Clan)
    {
    
    }
    public void SetGameStatus(GameStatus status)
    {
        this.m_status = status;
    }
    public void SetScore(int value)
    {
        this.score = value;
    }
    public void SetBattlePoints(int value)
    {
        this.bp = value;
    }
    public void SetPlayerPoints(int value)
    {
        this.pp = value;
    }
    public void SetBonus(int value)
    {
        this.bonus = value;
    }
    public void SetActions(System.Action back, System.Action replay)
    {
        this.m_replayAction = replay;
        this.m_backButtonAction = back;
    }
    public void SetLoseTips(CharacterNameID tag, string tips)
    {
        this.losePanel.SetLoseTips(tag:  tag, tips:  tips);
    }
    public void SetPrize(Prize prize)
    {
        this.m_prize = prize;
    }
    public void PlayStarAnimation(UnityEngine.RectTransform parent)
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.PlayStarAnimation(parent:  parent, anchoredPosition:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, scale:  1f);
    }
    public void PlayStarAnimation(UnityEngine.RectTransform parent, UnityEngine.Vector2 anchoredPosition, float scale = 1)
    {
        if(0 == this.starFX)
        {
                return;
        }
        
        UnityEngine.ParticleSystem val_2 = UnityEngine.Object.Instantiate<UnityEngine.ParticleSystem>(original:  this.starFX);
        val_2.transform.SetParent(p:  parent);
        UnityEngine.Transform val_4 = val_2.transform;
        UnityEngine.Vector3 val_5 = val_4.localScale;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  scale);
        val_4.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        val_2.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = anchoredPosition.x, y = anchoredPosition.y};
        val_2.gameObject.SetActive(value:  true);
    }
    public PostMatchCanvas()
    {
        this.AnimSettings = new PostMatchCanvas.AnimData();
        this.animationDuration = 0.5f;
    }
    private static PostMatchCanvas()
    {
    
    }
    private void <UpdateWLD>b__32_0()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.green;
        if(this.win == null)
        {
            
        }
    
    }
    private void <UpdateWLD>b__32_2()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        if(this.win == null)
        {
            
        }
    
    }
    private void <UpdateWLD>b__32_3()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.red;
        if(this.lose == null)
        {
            
        }
    
    }
    private void <UpdateWLD>b__32_4()
    {
        NetworkUserInfo val_1 = DataStructs.UserDataDictionary.ToNetworkUserInfo();
        this.lose.text = val_1.lose.ToString();
    }
    private void <UpdateWLD>b__32_5()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        if(this.lose == null)
        {
            
        }
    
    }
    private void <UpdateWLD>b__32_6()
    {
        if(this.draw != null)
        {
                return;
        }
    
    }
    private void <UpdateWLD>b__32_7()
    {
        NetworkUserInfo val_1 = DataStructs.UserDataDictionary.ToNetworkUserInfo();
        this.draw.text = val_1.draw.ToString();
    }
    private void <UpdateWLD>b__32_8()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        if(this.draw == null)
        {
            
        }
    
    }

}
