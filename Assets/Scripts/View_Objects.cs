using UnityEngine;
[Serializable]
public class View_Objects
{
    // Fields
    public bool LeftSide;
    public float DefaultAimAngle;
    public CharAnimationController PlayerAnimator;
    public UnityEngine.GameObject Grid;
    public UnityEngine.Transform GridEntryIndicator;
    public UnityEngine.Transform CenterPoint;
    public UnityEngine.Transform InkPool;
    public UnityEngine.Animator LineRenderer;
    public View_BridgeManager BridgeManager;
    public TMPro.TextMeshProUGUI ScoreText;
    private TMPro.TextMeshProUGUI ScoreMultiplier;
    public TMPro.TextMeshProUGUI StunCounter;
    public UnityEngine.CanvasGroup StunBreakDoubleTapTransparency;
    public UnityEngine.CanvasGroup NoStunBreakDoubleTapTransparency;
    public UnityEngine.UI.Image Switcher;
    public UnityEngine.UI.Image ActiveBubble;
    public UnityEngine.UI.Image InActiveBubble;
    public UnityEngine.UI.Image PuzzleBase;
    public UnityEngine.UI.Image InactiveBase;
    public UnityEngine.UI.Image ActiveBase;
    public ColorFlash ActiveBaseColorFlash;
    public View_Bubble[] OuterRing;
    public View_Bubble[] MiddleRing;
    public View_Bubble[] InnerRing;
    public View_Bubble[] TargetBubblePool;
    public int ScoreCalculated;
    public int ScoreDisplay;
    private float currentStunnerFlipValue;
    private UnityEngine.Vector3 ActiveBubblePosition;
    private UnityEngine.Vector3 InActiveBubblePosition;
    private UnityEngine.Vector3 ActiveBubbleScale;
    private UnityEngine.Vector3 InActiveBubbleScale;
    internal UnityEngine.Vector3[] OuterRingSpline;
    private UnityEngine.Vector3[] MiddleRingSpline;
    private UnityEngine.Vector3[] InnerRingSpline;
    private float[] OuterRingOffsets;
    private float[] MiddleRingOffsets;
    private float[] InnerRingOffsets;
    private InkWars.Model.Model_Player m_PlayerModel;
    public bool AnimTrigger_Win;
    public bool AnimTrigger_Lose;
    public bool AnimTrigger_Draw;
    public bool AnimTrigger_Attack;
    public bool AnimTrigger_CancelAttack;
    private bool AnimPlayed_Lose;
    private View_Objects.LineRendererStates _lineRendererStates;
    internal bool firstSync;
    private float ScoreMultiplierTimeElapsed;
    private bool shakeActive;
    private UnityEngine.Vector3 characterOriginalPosition;
    private float shakeIntensity;
    private float shakeIntensityScaler;
    public UnityEngine.UI.Text PlayerName;
    public UnityEngine.UI.Image PlayerNameBackingImage;
    public UnityEngine.UI.Image PlayerRankPlateBG;
    public UnityEngine.UI.Image PlayerRankMedalImage;
    public UnityEngine.UI.Image PlayerRankLevelImage;
    internal RevengeAnimationController RevengeAnimationController;
    
    // Properties
    public InkWars.Model.Model_Player TargetModelPlayer { get; }
    private View_Objects.LineRendererStates LineRendererState { get; set; }
    public CharacterClan Clan { get; }
    
    // Methods
    public InkWars.Model.Model_Player get_TargetModelPlayer()
    {
        return (InkWars.Model.Model_Player)this.m_PlayerModel;
    }
    private View_Objects.LineRendererStates get_LineRendererState()
    {
        return (LineRendererStates)this._lineRendererStates;
    }
    private void set_LineRendererState(View_Objects.LineRendererStates value)
    {
        string val_13;
        UnityEngine.RectTransform val_14;
        var val_17;
        var val_18;
        if(this._lineRendererStates == value)
        {
                return;
        }
        
        System.Collections.IEnumerator val_2 = this.LineRenderer.transform.GetEnumerator();
        label_22:
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_14 = 0;
        if(val_2.MoveNext() == false)
        {
            goto label_9;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_17 = val_2.Current;
        if(val_17 != null)
        {
                val_17 = 0;
        }
        
        val_17.gameObject.SetActive(value:  (value != 0) ? 1 : 0);
        goto label_22;
        label_9:
        val_18 = 0;
        val_13 = val_2;
        if(val_13 != null)
        {
                var val_17 = 0;
            val_17 = val_17 + 1;
            val_14 = 0;
            val_13.Dispose();
        }
        
        if( != false)
        {
                val_14 = 0;
        }
        
        if(value != 0)
        {
                val_13 = value.ToString();
            value.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_14, drivenProperties:  null);
            this.LineRenderer.Play(stateName:  val_13, layer:  0, normalizedTime:  0f);
        }
        
        this._lineRendererStates = null;
    }
    public void LoadCharacter(InkWars.Model.Model_Player player)
    {
        System.Collections.IEnumerator val_4;
        this.PlayerAnimator.RetrieveCharacterBundle(charNameID:  player.Name);
        if(this.PlayerAnimator != null)
        {
                val_4 = this.PlayerAnimator.LoadAnimations_Gameplay();
        }
        else
        {
                val_4 = 0.LoadAnimations_Gameplay();
        }
        
        UnityEngine.Coroutine val_3 = this.PlayerAnimator.StartCoroutine(routine:  val_4);
        this.SetSwitcherBubblesScalesAndPositions();
        this.CreateGridBubbles(ring:  this.OuterRing, modelRing:  player.OuterRing, ringName:  static_value_0332F130);
        this.CreateGridBubbles(ring:  this.MiddleRing, modelRing:  player.MiddleRing, ringName:  static_value_0332F138);
        this.CreateGridBubbles(ring:  this.InnerRing, modelRing:  player.InnerRing, ringName:  "InnerRing");
        this.NoStunBreakDoubleTapTransparency.alpha = 0f;
        this.StunBreakDoubleTapTransparency.alpha = 0f;
    }
    private void SetSwitcherBubblesScalesAndPositions()
    {
        float val_17;
        UnityEngine.Vector3 val_2 = this.ActiveBubble.transform.localScale;
        val_17 = val_2.x;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_17, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) == true)
        {
                return;
        }
        
        UnityEngine.Vector3 val_6 = this.InActiveBubble.transform.localScale;
        val_17 = val_6.x;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_17, y = val_6.y, z = val_6.z}, rhs:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})) == true)
        {
                return;
        }
        
        UnityEngine.Vector3 val_10 = this.ActiveBubble.transform.localPosition;
        this.ActiveBubblePosition = val_10;
        mem[1152921528361202592] = val_10.y;
        mem[1152921528361202596] = val_10.z;
        UnityEngine.Vector3 val_12 = this.InActiveBubble.transform.localPosition;
        this.InActiveBubblePosition = val_12;
        mem[1152921528361202604] = val_12.y;
        mem[1152921528361202608] = val_12.z;
        UnityEngine.Vector3 val_14 = this.ActiveBubble.transform.localScale;
        this.ActiveBubbleScale = val_14;
        mem[1152921528361202616] = val_14.y;
        mem[1152921528361202620] = val_14.z;
        UnityEngine.Vector3 val_16 = this.InActiveBubble.transform.localScale;
        this.InActiveBubbleScale = val_16;
        mem[1152921528361202628] = val_16.y;
        mem[1152921528361202632] = val_16.z;
    }
    public void GenerateSplines()
    {
        UnityEngine.Vector3[] val_1 = this.GenerateSpline(ring:  this.OuterRing);
        this.OuterRingSpline = val_1;
        UnityEngine.Vector3[] val_2 = val_1.GenerateSpline(ring:  this.MiddleRing);
        this.MiddleRingSpline = val_2;
        this.InnerRingSpline = val_2.GenerateSpline(ring:  this.InnerRing);
    }
    public void LoadBubbles()
    {
        this.GenerateSplines();
        this.InitialPosition(ring:  this.OuterRing, offsets:  this.OuterRingOffsets, bridge:  8);
        this.InitialPosition(ring:  this.MiddleRing, offsets:  this.MiddleRingOffsets, bridge:  6);
        this.InitialPosition(ring:  this.InnerRing, offsets:  this.InnerRingOffsets, bridge:  4);
        this.EnableSwitcherBubbles(enable:  true);
        this.ActiveBaseColorFlash = this.ActiveBase.gameObject.GetComponent<ColorFlash>();
    }
    public void EnableSwitcherBubbles(bool enable)
    {
        this.ActiveBubble.gameObject.SetActive(value:  enable);
        this.InActiveBubble.gameObject.SetActive(value:  enable);
    }
    private void CreateGridBubbles(View_Bubble[] ring, InkWars.Model.Model_Bubble[] modelRing, string ringName)
    {
        View_Bubble val_20;
        View_Bubble val_21;
        var val_22;
        UnityEngine.Transform val_2 = this.Grid.transform.Find(n:  ringName);
        int val_3 = val_2.childCount;
        UnityEngine.GameObject[] val_4 = new UnityEngine.GameObject[0];
        int val_5 = val_2.childCount;
        if(val_5 <= 0)
        {
            goto label_5;
        }
        
        var val_19 = 0;
        label_36:
        UnityEngine.Transform val_6 = val_2.GetChild(index:  0);
        UnityEngine.GameObject val_7 = val_6.gameObject;
        if(val_4 == null)
        {
            goto label_8;
        }
        
        if(val_7 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_7 == null)
        {
            goto label_12;
        }
        
        label_9:
        label_12:
        mem2[0] = val_7;
        View_Core val_8 = View_Core.Instance;
        UnityEngine.Vector3 val_9 = val_6.position;
        UnityEngine.Quaternion val_10 = val_6.rotation;
        val_20 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_8.templateBubble, position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, rotation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, parent:  val_6.transform.parent).GetComponent<View_Bubble>();
        if(ring == null)
        {
            goto label_22;
        }
        
        if(val_20 != null)
        {
            goto label_23;
        }
        
        goto label_26;
        label_22:
        if(val_20 == null)
        {
            goto label_26;
        }
        
        label_23:
        label_26:
        mem2[0] = val_20;
        UnityEngine.Vector3 val_18 = val_2.GetChild(index:  0).transform.localScale;
        1152921508830195616.transform.localScale = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        1152921508830195616.ResetBubble();
        val_19 = val_19 + 1;
        if(val_5 != val_19)
        {
            goto label_36;
        }
        
        goto label_37;
        label_5:
        label_37:
        val_21 = 0;
        goto label_38;
        label_43:
        UnityEngine.Object.Destroy(obj:  val_4[0]);
        val_21 = 1;
        label_38:
        if(val_21 < null)
        {
            goto label_43;
        }
        
        val_22 = 0;
        goto label_44;
        label_50:
        val_21 = ring[0];
        val_22 = 1;
        ring[0x0][0].modelBubble = modelRing[0];
        label_44:
        if(val_22 < ring.Length)
        {
            goto label_50;
        }
    
    }
    public void SyncRings(InkWars.Model.Model_Player playerModel)
    {
        View_Core val_1 = View_Core.Instance;
        if(val_1.SyncPlayerRings == false)
        {
                return;
        }
        
        this.SyncRing(spriteBubbles:  this.OuterRing, modelBubbles:  playerModel.OuterRing, Offsets:  this.OuterRingOffsets, Spline:  this.OuterRingSpline);
        this.SyncRing(spriteBubbles:  this.MiddleRing, modelBubbles:  playerModel.MiddleRing, Offsets:  this.MiddleRingOffsets, Spline:  this.MiddleRingSpline);
        this.SyncRing(spriteBubbles:  this.InnerRing, modelBubbles:  playerModel.InnerRing, Offsets:  this.InnerRingOffsets, Spline:  this.InnerRingSpline);
        this.CheckRingforEmpty(whirlpool:  this.BridgeManager.InnerWhirlPool, ring:  this.InnerRing);
        this.CheckRingforEmpty(whirlpool:  this.BridgeManager.MiddleWhirlPool, ring:  this.MiddleRing);
        this.CheckRingforEmpty(whirlpool:  this.BridgeManager.OuterWhirlPool, ring:  this.OuterRing);
    }
    private void CheckRingforEmpty(View_Whirlpool whirlpool, View_Bubble[] ring)
    {
        if(whirlpool.RingEmpty != false)
        {
                return;
        }
        
        InkWars.Model.Model_Manager val_1 = InkWars.Model.Model_Manager.Instance;
        if(val_1.Model.gamePhase == 0)
        {
                return;
        }
        
        var val_4 = 0;
        whirlpool.RingEmpty = true;
        label_9:
        if(val_4 >= ring.Length)
        {
            goto label_6;
        }
        
        val_4 = val_4 + 1;
        if(ring[0].bubbleType == 0)
        {
            goto label_9;
        }
        
        whirlpool.RingEmpty = false;
        return;
        label_6:
        if(whirlpool.RingEmpty == false)
        {
                return;
        }
        
        whirlpool.TriggerPlug();
        this.BridgeManager.UpdateGlow();
    }
    private void InitialPosition(View_Bubble[] ring, float[] offsets, int bridge)
    {
        float val_9;
        var val_10;
        View_Bubble val_11;
        if(ring == null)
        {
            goto label_1;
        }
        
        label_26:
        int val_10 = ring.Length;
        val_10 = val_10 - 1;
        val_9 = (float)val_10;
        offsets[(long)val_10] = val_9;
        int val_12 = ring.Length;
        if((val_12 - 1) < 2)
        {
                return;
        }
        
        label_23:
        if(1 >= bridge)
        {
            goto label_5;
        }
        
        offsets[1] = 0f;
        val_10 = ring[1].transform;
        val_11 = ring[0];
        if(val_11 != null)
        {
            goto label_16;
        }
        
        goto label_11;
        label_5:
        val_12 = val_12 - 1;
        offsets[1] = (float)val_12;
        val_10 = ring[1].transform;
        val_11 = ring[((-4294967296) + ((ring.Length) << 32)) >> 32];
        if(val_11 != null)
        {
            goto label_16;
        }
        
        label_11:
        label_16:
        UnityEngine.Vector3 val_7 = val_11.transform.position;
        val_9 = val_7.x;
        val_10.position = new UnityEngine.Vector3() {x = val_9, y = val_7.y, z = val_7.z};
        if(bridge == 1)
        {
                View_Bubble[].__il2cppRuntimeField_methods.__unknownFiledOffset_70 = "BridgePop";
        }
        
        if((1 + 1) < (ring.Length - 1))
        {
            goto label_23;
        }
        
        return;
        label_1:
        if(offsets != null)
        {
            goto label_26;
        }
        
        goto label_26;
    }
    private UnityEngine.Vector3[] GenerateSpline(View_Bubble[] ring)
    {
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[0];
        if(ring.Length < 1)
        {
                return val_1;
        }
        
        do
        {
            UnityEngine.Vector3 val_3 = ring[0].transform.position;
            var val_4 = val_1 + (0 * 12);
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
        }
        while((0 + 1) < ring.Length);
        
        return val_1;
    }
    internal void FirstSync(InkWars.Model.Model_Player playerModel, InkWars.Model.Model_Player otherPlayerModel, InkWars.Model.Model_Core model, View_Objects otherPlayer)
    {
        InkWars.Model.Model_Player val_65;
        var val_66;
        GameMode val_67;
        int val_68;
        var val_69;
        int val_72;
        var val_73;
        int val_74;
        UnityEngine.Sprite val_75;
        var val_76;
        View_Bubble[] val_77;
        var val_78;
        View_Bubble val_79;
        var val_80;
        string val_82;
        var val_85;
        var val_87;
        var val_88;
        var val_89;
        val_65 = playerModel;
        this.m_PlayerModel = val_65;
        this.firstSync = true;
        val_66 = null;
        val_66 = null;
        val_67 = Character_GlobalInfo.gameMode;
        if(val_67 == 6)
        {
            goto label_3;
        }
        
        val_66 = null;
        val_67 = Character_GlobalInfo.gameMode;
        if(val_67 != 10)
        {
            goto label_6;
        }
        
        label_3:
        if(playerModel.ID != 0)
        {
                NetworkUserInfo val_1 = CloudOpponent.current;
            val_68 = val_1.switcherID;
        }
        else
        {
                val_69 = null;
            val_69 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Settings.SelectedSwitcher;
            val_68 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited});
        }
        
        View_Core val_4 = View_Core.Instance;
        CharacterData val_5 = CharacterDataManager.Get(id:  playerModel.Name);
        label_135:
        label_176:
        this.Switcher.sprite = val_4.m_switcherCollection.GetSwitcherSpriteByID(id:  val_68, charATKLv:  val_5.status.attack);
        if(playerModel.Clan > 3)
        {
            goto label_23;
        }
        
        var val_65 = 40829132 + (playerModel.Clan) << 2;
        val_65 = val_65 + 40829132;
        goto (40829132 + (playerModel.Clan) << 2 + 40829132);
        label_6:
        if(Character_GlobalInfo.IsAdventureMode() == false)
        {
            goto label_30;
        }
        
        if(playerModel.ID == 0)
        {
            goto label_32;
        }
        
        val_72 = 0;
        goto label_33;
        label_23:
        val_73 = null;
        val_73 = null;
        GameMode val_67 = Character_GlobalInfo.gameMode;
        val_67 = val_67 - 3;
        if(val_67 > 7)
        {
            goto label_50;
        }
        
        var val_68 = 40829148 + ((Character_GlobalInfo.gameMode - 3)) << 2;
        val_68 = val_68 + 40829148;
        goto (40829148 + ((Character_GlobalInfo.gameMode - 3)) << 2 + 40829148);
        label_50:
        if(playerModel.ID != 0)
        {
                UnityEngine.SpriteRenderer val_24 = this.Grid.GetComponent<UnityEngine.SpriteRenderer>();
            View_Core val_25 = View_Core.Instance;
            val_75 = val_25.BattleGridColors[playerModel.Clan];
        }
        else
        {
                val_76 = null;
            val_76 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_26 = DataStructs.UserDataDictionary.Settings.SelectedBattleGrid;
            val_74 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_26.currentCryptoKey, hiddenValue = val_26.hiddenValue, fakeValue = val_26.fakeValue, inited = val_26.inited});
            if(val_74 == 0)
        {
                val_74 = playerModel.Clan;
        }
        
            View_Core val_29 = View_Core.Instance;
            val_75 = val_29.m_battleGridCollection.GetBattleGridSpriteByID(id:  val_74);
        }
        
        this.Grid.GetComponent<UnityEngine.SpriteRenderer>().sprite = val_75;
        UnityEngine.Color val_31 = UnityEngine.Color.white;
        this.InactiveBase.color = new UnityEngine.Color() {r = val_31.r, g = val_31.g, b = val_31.b, a = val_31.a};
        UnityEngine.Color val_32 = UnityEngine.Color.white;
        this.ActiveBase.color = new UnityEngine.Color() {r = val_32.r, g = val_32.g, b = val_32.b, a = val_32.a};
        this.ActiveBase.gameObject.SetActive(value:  false);
        this.EnableSwitcherBubbles(enable:  false);
        val_77 = new View_Bubble[5];
        this.TargetBubblePool = val_77;
        val_78 = 0;
        goto label_91;
        label_100:
        val_77 = this.TargetBubblePool;
        val_78 = 1;
        label_91:
        View_Core val_35 = View_Core.Instance;
        val_79 = Instance_Manager.InstantiateOn<UnityEngine.GameObject>(Original:  val_35.templateBubble).GetComponent<View_Bubble>();
        if(val_77 == null)
        {
            goto label_94;
        }
        
        if(val_79 != null)
        {
            goto label_95;
        }
        
        goto label_98;
        label_94:
        if(val_79 == null)
        {
            goto label_98;
        }
        
        label_95:
        label_98:
        val_77[val_78] = val_79;
        if(val_78 != 4)
        {
            goto label_100;
        }
        
        val_80 = null;
        val_80 = null;
        GameMode val_71 = Character_GlobalInfo.gameMode;
        val_71 = val_71 - 1;
        if(val_71 > 9)
        {
            goto label_103;
        }
        
        var val_72 = 40829180 + ((Character_GlobalInfo.gameMode - 1)) << 2;
        val_72 = val_72 + 40829180;
        goto (40829180 + ((Character_GlobalInfo.gameMode - 1)) << 2 + 40829180);
        label_103:
        val_82 = CharacterHelper.GetLocalizedClanAndName(cid:  playerModel.Name);
        val_65 = playerModel.ID;
        goto label_149;
        label_30:
        View_Core val_44 = View_Core.Instance;
        val_85 = null;
        val_85 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_45 = DataStructs.UserDataDictionary.Settings.SelectedSwitcher;
        int val_46 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_45.currentCryptoKey, hiddenValue = val_45.hiddenValue, fakeValue = val_45.fakeValue, inited = val_45.inited});
        CharacterData val_47 = CharacterDataManager.Get(id:  playerModel.Name);
        if(val_44.m_switcherCollection != null)
        {
            goto label_135;
        }
        
        goto label_135;
        label_149:
        this.AddPlayerName(playerName:  null);
        if((playerModel + 28 + 28 + 28) == 0)
        {
            goto label_150;
        }
        
        NetworkUserInfo val_54 = CloudOpponent.current;
        if(model != null)
        {
            goto label_157;
        }
        
        label_158:
        label_157:
        this.EnablePlayerRank(enable:  model.Feature_PlayeRankPlates, rank:  val_54.currentCharacterRank);
        this.ScoreMultiplier.text = "";
        return;
        label_150:
        val_87 = null;
        val_87 = null;
        DataStructs.PlayerRank val_55 = DataStructs.UserDataDictionary.Stats.CurrentCharacterRank;
        if(model != null)
        {
            goto label_157;
        }
        
        goto label_158;
        label_32:
        val_88 = null;
        val_88 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_56 = DataStructs.UserDataDictionary.Settings.SelectedSwitcher;
        val_72 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_56.currentCryptoKey, hiddenValue = val_56.hiddenValue, fakeValue = val_56.fakeValue, inited = val_56.inited});
        if(playerModel.ID == 0)
        {
            goto label_164;
        }
        
        label_33:
        val_89 = null;
        val_89 = null;
        int val_60 = UnityEngine.Mathf.Clamp(value:  Character_GlobalInfo.stage_CurrentLevel - 1, min:  0, max:  11);
        System.Int32[] val_61 = InkWars.Model.Model_Constants.AdventureModeAttackRatings + (((long)(int)(val_60)) << 2);
        label_181:
        View_Core val_62 = View_Core.Instance;
        UnityEngine.Sprite val_63 = val_62.m_switcherCollection.GetSwitcherSpriteByID(id:  val_72, charATKLv:  263726320);
        if(this.Switcher != null)
        {
            goto label_176;
        }
        
        goto label_176;
        label_164:
        CharacterData val_64 = CharacterDataManager.Get(id:  playerModel.Name);
        if(val_64.status != null)
        {
            goto label_181;
        }
        
        goto label_181;
    }
    internal void SyncCharacterAnimations(InkWars.Model.Model_Player playerModel, InkWars.Model.Model_Player otherPlayerModel, InkWars.Model.Model_Core model, View_Objects otherPlayer)
    {
        CharAnimationController val_12;
        var val_13;
        var val_14;
        CharAnimationController val_15;
        if(model.PauseForRevengeSuper > 0f)
        {
                return;
        }
        
        if(this.AnimTrigger_Attack != false)
        {
                this.PlayerAnimator.PlayAnimation(newAnimName:  0, forceOverride:  false);
            this.AnimTrigger_Attack = false;
        }
        
        if(model.gamePhase == 2)
        {
            goto label_5;
        }
        
        if(model.gamePhase != 1)
        {
            goto label_47;
        }
        
        this.ActiveBase.gameObject.SetActive(value:  true);
        if(playerModel.StunnedTime <= 0f)
        {
            goto label_10;
        }
        
        this.PlayerAnimator.PlayAnimation(newAnimName:  13, forceOverride:  false);
        InkWars.Model.Model_Player val_2 = model.GetPlayer(PlayerNumber:  otherPlayerModel.ID);
        int val_12 = val_2.AttackLevel;
        val_12 = val_12 + 1;
        this.CharacterShake_Set(intensity:  (float)val_12);
        this.StunCounter.gameObject.SetActive(value:  true);
        if(playerModel.CanBreakStun() == true)
        {
            goto label_28;
        }
        
        this.ActiveBase.gameObject.SetActive(value:  false);
        goto label_28;
        label_5:
        if(this.AnimTrigger_Draw == false)
        {
            goto label_20;
        }
        
        this.PlayerAnimator.PlayAnimation(newAnimName:  6, forceOverride:  false);
        this.ActiveBase.gameObject.SetActive(value:  false);
        this.BridgeManager.BridgeGlow.ChangeGlow(state:  3);
        this.AnimTrigger_Draw = false;
        goto label_47;
        label_10:
        if((playerModel.AimTarget != 1) && (playerModel.ReloadingTime <= 0f))
        {
                this.PlayerAnimator.PlayAnimation(newAnimName:  1, forceOverride:  false);
        }
        
        label_28:
        if(this.AnimTrigger_CancelAttack == false)
        {
            goto label_47;
        }
        
        if(this.PlayerAnimator.currentAnimationName != 1)
        {
                if(this.PlayerAnimator.currentAnimationName != 2)
        {
            goto label_34;
        }
        
        }
        
        this.PlayerAnimator.PlayAnimation(newAnimName:  8, forceOverride:  true);
        label_34:
        this.AnimTrigger_CancelAttack = false;
        goto label_47;
        label_20:
        if(this.AnimTrigger_Lose == false)
        {
            goto label_37;
        }
        
        val_12 = this.PlayerAnimator;
        if(val_12 == null)
        {
            goto label_38;
        }
        
        if(this.PlayerAnimator.currentAnimationName != 13)
        {
            goto label_76;
        }
        
        label_75:
        val_13 = 14;
        goto label_40;
        label_37:
        if(this.AnimTrigger_Win == false)
        {
            goto label_47;
        }
        
        this.PlayerAnimator.PlayAnimation(newAnimName:  15, forceOverride:  false);
        this.ActiveBase.gameObject.SetActive(value:  false);
        this.BridgeManager.BridgeGlow.ChangeGlow(state:  3);
        this.AnimTrigger_Win = false;
        goto label_47;
        label_38:
        if(this.PlayerAnimator == null)
        {
            goto label_48;
        }
        
        val_12 = this.PlayerAnimator;
        if(this.PlayerAnimator.currentAnimationName == 13)
        {
            goto label_75;
        }
        
        label_76:
        val_13 = 9;
        label_40:
        val_12.PlayAnimation(newAnimName:  9, forceOverride:  false);
        this.ActiveBase.gameObject.SetActive(value:  false);
        this.BridgeManager.BridgeGlow.ChangeGlow(state:  3);
        this.AnimTrigger_Lose = false;
        label_47:
        if(this.PlayerAnimator.attackAnimEnded != false)
        {
                val_14 = null;
            val_14 = null;
            System.Single[] val_10 = InkWars.Model.Model_Constants.CharacterReload_MaxPostAttackDuration + ((playerModel.SpeedLevel) << 2);
            if(playerModel.ReloadingTime < 0)
        {
                this.PlayerAnimator.pause = false;
            this.PlayerAnimator.attackAnimEnded = false;
            this.PlayerAnimator.PlayAnimation(newAnimName:  11, forceOverride:  false);
        }
        else
        {
                this.CharacterShake_Set(intensity:  0.5f);
        }
        
        }
        
        val_15 = this.PlayerAnimator;
        if((this.PlayerAnimator.receiveDamageAnimEnded != false) && (playerModel.StunnedTime <= 0f))
        {
                this.PlayerAnimator.PlayAnimation(newAnimName:  12, forceOverride:  false);
            this.PlayerAnimator.receiveDamageAnimEnded = false;
            this.PlayerAnimator.pause = false;
            val_15 = this.StunCounter.gameObject;
            val_15.SetActive(value:  false);
        }
        
        this.CharacterShake_Update(playerModel:  playerModel);
        return;
        label_48:
        if(this.PlayerAnimator.currentAnimationName == 13)
        {
            goto label_75;
        }
        
        goto label_76;
    }
    public void SetBaseReloadPercentage(InkWars.Model.Model_Player playerModel)
    {
        float val_2;
        if(playerModel != null)
        {
                val_2 = playerModel.ReloadingTime;
        }
        else
        {
                val_2 = 0f;
        }
        
        float val_1 = val_2 / playerModel.FullReloadTime;
        val_1 = 1f - val_1;
        this.ActiveBase.fillAmount = val_1;
    }
    private void SetBase_StunBreaker()
    {
        if(this.m_PlayerModel.Clan == 0)
        {
            goto label_1;
        }
        
        if(this.m_PlayerModel.Clan == 2)
        {
            goto label_2;
        }
        
        if(this.m_PlayerModel.Clan != 1)
        {
                return;
        }
        
        View_Core val_1 = View_Core.Instance;
        View_Core val_2 = View_Core.Instance;
        if(val_2.TakoActiveBase != null)
        {
            goto label_16;
        }
        
        label_17:
        label_16:
        int val_7 = val_2.TakoActiveBase.Length;
        val_7 = val_7 - 1;
        this.ActiveBase.sprite = val_1.TakoActiveBase[(long)val_7];
        return;
        label_1:
        View_Core val_3 = View_Core.Instance;
        View_Core val_4 = View_Core.Instance;
        if(val_4.IkaActiveBase != null)
        {
            goto label_16;
        }
        
        goto label_17;
        label_2:
        View_Core val_5 = View_Core.Instance;
        View_Core val_6 = View_Core.Instance;
        if(val_6.SpecialActiveBase != null)
        {
            goto label_16;
        }
        
        goto label_17;
    }
    public void ResetStunStates()
    {
        this.NoStunBreakDoubleTapTransparency.alpha = 0f;
        this.StunBreakDoubleTapTransparency.alpha = 0f;
        this.ResetBase();
        this.ActiveBaseColorFlash.StopFlash();
    }
    public void ResetCharacterLayer()
    {
        this.PlayerAnimator.SetSortingLayer(_sortingLayer:  9);
    }
    internal void Sync(InkWars.Model.Model_Player playerModel, InkWars.Model.Model_Player otherPlayerModel, InkWars.Model.Model_Core model, View_Objects otherPlayer)
    {
        View_Objects val_85;
        var val_86;
        var val_87;
        int val_88;
        float val_89;
        float val_91;
        TMPro.TextMeshProUGUI val_98;
        var val_99;
        UnityEngine.CanvasGroup val_100;
        float val_101;
        UnityEngine.Vector3 val_102;
        float val_106;
        float val_107;
        UnityEngine.Vector3 val_108;
        float val_109;
        UnityEngine.Object val_110;
        LineRendererStates val_113;
        var val_116;
        var val_117;
        var val_118;
        var val_122;
        var val_123;
        var val_124;
        int val_125;
        View_Objects val_126;
        float val_127;
        int val_128;
        var val_167;
        val_85 = this;
        if(this.firstSync != true)
        {
                this.FirstSync(playerModel:  playerModel, otherPlayerModel:  otherPlayerModel, model:  model, otherPlayer:  otherPlayer);
        }
        
        val_86 = 1152921505064992768;
        val_87 = null;
        val_87 = null;
        if((Character_GlobalInfo.gameMode == 3) && (playerModel.ID == 0))
        {
                InkWars.Model.Model_Manager val_2 = InkWars.Model.Model_Manager.Instance;
            int val_3 = Character_GlobalInfo.stage_CurrentLevel + 2;
            object[] val_5 = new object[2];
            val_5[0] = val_3 - val_2.Model.PuzzleBubblesLeft;
            val_86 = 1152921505064992768;
            val_5[1] = val_3;
            string val_6 = LanguageManager.GetTextFormat(key:  "LK.Puzzle.Shots", list:  val_5);
        }
        
        this.SyncCharacterAnimations(playerModel:  playerModel, otherPlayerModel:  otherPlayerModel, model:  model, otherPlayer:  otherPlayer);
        val_88 = this.ScoreCalculated;
        int val_7 = val_88 - this.ScoreDisplay;
        if(val_7 >= 5)
        {
                float val_72 = 0.03f;
            val_89 = (float)val_7;
            val_72 = val_89 * val_72;
            val_88 = (UnityEngine.Mathf.CeilToInt(f:  val_72)) + this.ScoreDisplay;
        }
        
        this.ScoreDisplay = val_88;
        this.ScoreText.text = this.ScoreDisplay.ToString();
        val_91 = this.ScoreMultiplierTimeElapsed + UnityEngine.Time.deltaTime;
        this.ScoreMultiplierTimeElapsed = val_91;
        if(val_91 > 1f)
        {
                this.ScoreMultiplier.text = "";
        }
        
        if(playerModel.TechRecordForView > 3)
        {
            goto label_26;
        }
        
        var val_73 = 40829308 + (playerModel.TechRecordForView) << 2;
        val_73 = val_73 + 40829308;
        goto (40829308 + (playerModel.TechRecordForView) << 2 + 40829308);
        label_26:
        playerModel.TechRecordForView = 0;
        this.SetBaseReloadPercentage(playerModel:  playerModel);
        val_98 = this.StunCounter;
        if(playerModel.StunnedTime <= 0f)
        {
            goto label_40;
        }
        
        val_98.enabled = true;
        val_98 = this.StunCounter;
        val_98.text = playerModel + 68.ToString(format:  "F2")(playerModel + 68.ToString(format:  "F2")) + "sec";
        if(playerModel.ID == 0)
        {
            goto label_42;
        }
        
        val_99 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
            goto label_54;
        }
        
        label_42:
        if(playerModel.CanBreakStun() == false)
        {
            goto label_46;
        }
        
        this.ActiveBase.fillAmount = 1f;
        this.SetBase_StunBreaker();
        this.ActiveBaseColorFlash.Flash();
        this.StunBreakDoubleTapTransparency.alpha = 1f;
        val_100 = this.NoStunBreakDoubleTapTransparency;
        if(val_100 != null)
        {
            goto label_51;
        }
        
        goto label_51;
        label_40:
        val_98.enabled = false;
        goto label_57;
        label_46:
        if((otherPlayerModel.HasBattleEnhancer(type:  6)) == false)
        {
            goto label_54;
        }
        
        this.StunBreakDoubleTapTransparency.alpha = 0f;
        val_100 = this.NoStunBreakDoubleTapTransparency;
        label_51:
        val_100.alpha = 1f;
        label_54:
        val_91 = mem[playerModel + 68];
        val_91 = playerModel + 68;
        val_89 = 3f;
        if(val_91 < 0)
        {
                this.ResetStunStates();
        }
        
        label_57:
        val_102 = this.ActiveBubbleScale;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.zero;
        val_106 = val_102;
        val_107 = playerModel.StunnedTime;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_106, y = val_107, z = val_14.y}, rhs:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z})) != false)
        {
                this.SetSwitcherBubblesScalesAndPositions();
        }
        else
        {
                float val_21 = playerModel.SwitchingTime / (-0.1f);
            val_21 = val_21 + 1f;
            val_108 = this.ActiveBubblePosition;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_108, y = V13.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = this.InActiveBubblePosition, y = playerModel.SwitchingTime, z = val_14.y}, t:  val_21);
            this.InActiveBubble.transform.localPosition = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.InActiveBubblePosition, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = this.ActiveBubblePosition, y = playerModel.SwitchingTime, z = val_14.y}, t:  val_21);
            this.ActiveBubble.transform.localPosition = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.ActiveBubbleScale, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = this.InActiveBubbleScale, y = playerModel.SwitchingTime, z = val_14.y}, t:  val_21);
            this.InActiveBubble.transform.localScale = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.InActiveBubbleScale, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = this.ActiveBubbleScale, y = playerModel.SwitchingTime, z = val_14.y}, t:  val_21);
            val_101 = val_29.x;
            val_102 = val_29.z;
            val_106 = val_101;
            val_107 = val_29.y;
            this.ActiveBubble.transform.localScale = new UnityEngine.Vector3() {x = val_106, y = val_107, z = val_102};
        }
        
        this.SwitcherSpecialBubbleAnimation(image:  this.ActiveBubble, type:  playerModel.LoadedBubble);
        this.SwitcherSpecialBubbleAnimation(image:  this.InActiveBubble, type:  playerModel.SpareBubble);
        if((playerModel.AimTarget == 1) || (model.gamePhase != 1))
        {
            goto label_74;
        }
        
        val_110 = 0;
        if(playerModel.AimTarget > 6)
        {
            goto label_75;
        }
        
        var val_74 = 40829324 + (val_31) << 2;
        val_74 = val_74 + 40829324;
        goto (40829324 + (val_31) << 2 + 40829324);
        label_74:
        val_113 = 0;
        this.AnimTrigger_CancelAttack = true;
        goto label_79;
        label_75:
        if((UnityEngine.Object.op_Implicit(exists:  null)) != false)
        {
                UnityEngine.Vector3 val_34 = position;
            UnityEngine.Vector3 val_36 = this.LineRenderer.transform.position;
            UnityEngine.Vector3 val_37 = position;
            val_102 = val_37.x;
            UnityEngine.Vector3 val_39 = this.LineRenderer.transform.position;
            float val_41 = val_102 - val_39.x;
            val_101 = (val_34.y - val_36.y) * 57.29578f;
            val_116 = this.LineRenderer.transform;
            val_117 = 0f;
        }
        else
        {
                val_116 = this.LineRenderer.transform;
            val_117 = 0f;
        }
        
        val_116.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        bool val_45 = playerModel.CanShoot;
        if(playerModel.AimTarget != 3)
        {
            goto label_102;
        }
        
        if(val_45 == false)
        {
            goto label_103;
        }
        
        val_113 = 3;
        goto label_107;
        label_102:
        if(val_45 == false)
        {
            goto label_105;
        }
        
        val_113 = 1;
        goto label_107;
        label_103:
        val_113 = 4;
        goto label_107;
        label_105:
        val_113 = 2;
        label_107:
        label_79:
        this.LineRendererState = val_113;
        this.SyncRings(playerModel:  playerModel);
        val_118 = 0;
        goto label_108;
        label_238:
        InkWars.Model.Model_Bubble val_46 = playerModel.TargetBubbles.Item[0];
        if(val_46.BubbleType == 0)
        {
            goto label_112;
        }
        
        InkWars.Model.Model_Bubble val_47 = playerModel.TargetBubbles.Item[0];
        View_Bubble val_75 = this.TargetBubblePool[0];
        View_Core val_49 = View_Core.Instance;
        val_75.gameObject.SetActive(value:  (val_49.enableBubbleDisplay == true) ? 1 : 0);
        this.TargetBubblePool[0x0][0].modelBubble = val_47;
        val_75.SetBubble(type:  val_47.BubbleType, bubbleAddedToGrid:  false);
        val_98 = this.CenterPoint;
        UnityEngine.Vector3 val_51 = val_98.position;
        val_122 = val_51.x;
        val_123 = val_51.y;
        val_124 = val_51.z;
        if(val_47.AimTarget == 7)
        {
            goto label_122;
        }
        
        if(val_47.AimTarget != 3)
        {
            goto label_123;
        }
        
        UnityEngine.Vector3 val_52 = UnityEngine.Vector3.zero;
        val_101 = val_52.x;
        UnityEngine.Vector3 val_53 = this.CenterPoint.position;
        val_98 = this.CenterPoint;
        val_102 = val_53.z;
        UnityEngine.Vector3 val_54 = val_98.position;
        UnityEngine.Vector3 val_55 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z}, b:  new UnityEngine.Vector3() {x = val_101, y = val_52.y, z = val_102}, t:  val_47.PositionTimeNormalized);
        val_125 = 0;
        goto label_128;
        label_112:
        val_98 = 0;
        InkWars.Model.Model_Bubble val_56 = playerModel.TargetBubbles.Item[0];
        this.TargetBubblePool[val_98].SetBubble(type:  0, bubbleAddedToGrid:  (val_56.AddedToGrid == true) ? 1 : 0);
        this.TargetBubblePool[val_98].gameObject.SetActive(value:  false);
        goto label_138;
        label_122:
        UnityEngine.Vector3 val_59 = this.CenterPoint.position;
        val_126 = otherPlayer;
        if(val_126 == 0)
        {
                val_126 = otherPlayer;
        }
        
        val_98 = mem[otherPlayer + 48];
        val_98 = otherPlayer + 48;
        UnityEngine.Vector3 val_60 = val_98.position;
        val_109 = val_60.y;
        val_108 = val_60.z;
        UnityEngine.Vector3 val_61 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z}, b:  new UnityEngine.Vector3() {x = val_60.x, y = val_109, z = val_108}, t:  val_47.PositionTimeNormalized);
        val_101 = val_61.x;
        val_127 = val_61.y;
        val_102 = val_61.z;
        val_128 = val_47.PositionState;
        goto label_170;
        label_123:
        val_128 = val_47;
        if(val_47.PositionState > 3)
        {
            goto label_170;
        }
        
        var val_78 = 40829352 + (val_47.PositionState) << 2;
        val_78 = val_78 + 40829352;
        goto (40829352 + (val_47.PositionState) << 2 + 40829352);
        label_170:
        val_125 = mem[val_47 + 76];
        val_125 = val_47 + 76;
        label_128:
        val_75.SetPosition(pos:  new UnityEngine.Vector3() {}, posState:  val_125);
        label_138:
        val_118 = 1;
        label_108:
        if(val_118 < playerModel.TargetBubbles.Count)
        {
            goto label_238;
        }
        
        val_167 = null;
        val_167 = null;
        if(Character_GlobalInfo.gameMode != 1)
        {
                return;
        }
        
        if(playerModel.ID != 1)
        {
                return;
        }
        
        val_85 = this.LineRenderer.gameObject;
        val_85.SetActive(value:  false);
    }
    internal void SwitcherSpecialBubbleAnimation(UnityEngine.UI.Image image, InkWars.Model.BubbleTypes type)
    {
        InkWars.Model.BubbleTypes val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        float val_37;
        var val_38;
        val_31 = type;
        val_32 = image;
        if(val_31 == 0)
        {
                return;
        }
        
        View_Core val_1 = View_Core.Instance;
        val_33 = null;
        val_33 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Settings.SelectedBubble;
        val_32.sprite = val_1.m_bubblesCollection.GetBubbleSpriteByFamilyAndType(family:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited}), type:  val_31);
        if(val_31 > 16)
        {
                return;
        }
        
        var val_31 = 1;
        val_31 = val_31 << val_31;
        if((val_31 & 638) == 0)
        {
            goto label_11;
        }
        
        val_32.transform.localRotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        if(val_32 == null)
        {
            goto label_14;
        }
        
        val_34 = val_32.transform;
        goto label_15;
        label_11:
        val_31 = val_31 & 99456;
        if(val_31 == 0)
        {
            goto label_16;
        }
        
        val_35 = null;
        val_35 = null;
        View_Core val_8 = View_Core.Instance;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = InkWars.Model.Model_Constants.AI_Level_XTreme, y = InkWars.Model.Model_Constants.AI_Level_XTreme.__il2cppRuntimeField_4, z = InkWars.Model.Model_Constants.AI_Level_XTreme.__il2cppRuntimeField_8}, d:  val_8.DeltaTime);
        UnityEngine.Transform val_10 = val_32.transform;
        UnityEngine.Vector3 val_11 = val_10.localEulerAngles;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        val_10.localEulerAngles = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        return;
        label_14:
        val_34 = val_32.transform;
        label_15:
        val_31 = val_32.transform;
        UnityEngine.Vector3 val_15 = val_31.localScale;
        val_32 = val_32.transform;
        UnityEngine.Vector3 val_17 = val_32.localScale;
        UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  System.Math.Abs(val_15.x), y:  val_17.y);
        UnityEngine.Vector3 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
        label_53:
        val_34.localScale = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        return;
        label_16:
        if(val_31 != 8)
        {
                return;
        }
        
        val_32.transform.localRotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        float val_22 = this.currentStunnerFlipValue - UnityEngine.Time.deltaTime;
        this.currentStunnerFlipValue = val_22;
        val_36 = null;
        val_36 = null;
        val_37 = InkWars.Model.Model_Constants.StunnerBubbleFlipTime;
        if(val_22 >= 0)
        {
            goto label_38;
        }
        
        val_37 = InkWars.Model.Model_Constants.StunnerBubbleFlipTime;
        this.currentStunnerFlipValue = val_37;
        if(val_32 != null)
        {
            goto label_41;
        }
        
        goto label_43;
        label_38:
        val_37 = this.currentStunnerFlipValue;
        if(val_32 == null)
        {
            goto label_43;
        }
        
        label_41:
        val_38 = val_32.transform;
        goto label_44;
        label_43:
        val_38 = val_32.transform;
        label_44:
        UnityEngine.Vector3 val_26 = val_32.transform.localScale;
        if(val_37 < 0)
        {
                UnityEngine.Vector3 val_28 = val_32.transform.localScale;
        }
        else
        {
                UnityEngine.Vector3 val_30 = val_32.transform.localScale;
        }
        
        if(val_38 != null)
        {
            goto label_53;
        }
        
        goto label_53;
    }
    internal void SuctionAnimation(int ringID, int ringIndex, int amount)
    {
        System.Single[] val_1;
        if(ringID == 2)
        {
            goto label_0;
        }
        
        if(ringID == 1)
        {
            goto label_1;
        }
        
        if(ringID != 0)
        {
                return;
        }
        
        val_1 = this.OuterRingOffsets;
        if(val_1 != null)
        {
            goto label_7;
        }
        
        goto label_8;
        label_0:
        val_1 = this.InnerRingOffsets;
        if(val_1 != null)
        {
            goto label_7;
        }
        
        label_8:
        label_7:
        float val_1 = val_1[(long)ringIndex];
        val_1 = val_1 + (float)amount;
        val_1[(long)ringIndex] = val_1;
        return;
        label_1:
        if(this.MiddleRingOffsets != null)
        {
            goto label_7;
        }
        
        goto label_8;
    }
    internal void ShootAnimation()
    {
        this.PlayerAnimator.PlayAnimation(newAnimName:  0, forceOverride:  false);
    }
    private void SyncRing(View_Bubble[] spriteBubbles, InkWars.Model.Model_Bubble[] modelBubbles, float[] Offsets, UnityEngine.Vector3[] Spline)
    {
        var val_4;
        int val_5;
        int val_6;
        float val_7;
        float val_8;
        val_4 = 0;
        goto label_0;
        label_36:
        InkWars.Model.Model_Bubble val_5 = modelBubbles[0];
        spriteBubbles[0].SetBubble(type:  modelBubbles[0x0][0].BubbleType, bubbleAddedToGrid:  false);
        float val_7 = UnityEngine.Time.deltaTime;
        if(Offsets != null)
        {
                val_5 = Offsets.Length;
            val_6 = val_5;
        }
        else
        {
                val_6 = Offsets.Length;
            val_5 = Offsets.Length;
        }
        
        val_7 = val_7 * (float)val_6;
        val_7 = val_7 * 0.5f;
        if(Offsets[0] >= 0)
        {
            goto label_11;
        }
        
        val_7 = val_7 + (Offsets[0x0] + 32);
        mem2[0] = val_7;
        if(val_4 >= Offsets.Length)
        {
                val_7 = mem[Offsets[0x0] + 32];
            val_7 = Offsets[0x0] + 32;
        }
        
        if(val_7 > ((float)modelBubbles[0x0] + 32 + 96))
        {
            goto label_16;
        }
        
        goto label_26;
        label_11:
        if((Offsets[0x0] + 32) <= ((float)modelBubbles[0x0] + 32 + 96))
        {
            goto label_26;
        }
        
        val_8 = (Offsets[0x0] + 32) - val_7;
        mem2[0] = val_8;
        if(val_4 >= Offsets.Length)
        {
                val_8 = mem[Offsets[0x0] + 32];
            val_8 = Offsets[0x0] + 32;
        }
        
        if(val_8 >= 0)
        {
            goto label_26;
        }
        
        label_16:
        mem2[0] = (float)modelBubbles[0x0] + 32 + 96;
        label_26:
        int val_8 = Spline.Length;
        val_8 = val_8 - 1;
        float val_9 = (float)val_8;
        val_9 = (Offsets[0x0] + 32) / val_9;
        UnityEngine.Vector3 val_3 = GenericFunctions.SplineLerp(spline:  Spline, i:  val_9);
        spriteBubbles[0x0] + 32.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        val_4 = 1;
        label_0:
        if(val_4 < spriteBubbles.Length)
        {
            goto label_36;
        }
    
    }
    private static void SetBubbleRenderer(UnityEngine.GameObject spriteBubble, InkWars.Model.BubbleTypes bubbleType)
    {
        var val_7;
        if(spriteBubble == null)
        {
            goto label_1;
        }
        
        if(bubbleType == 0)
        {
            goto label_2;
        }
        
        label_11:
        spriteBubble.SetActive(value:  true);
        View_Core val_2 = View_Core.Instance;
        val_7 = null;
        val_7 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Settings.SelectedBubble;
        spriteBubble.GetComponent<UnityEngine.SpriteRenderer>().sprite = val_2.m_bubblesCollection.GetBubbleSpriteByFamilyAndType(family:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited}), type:  bubbleType);
        return;
        label_1:
        UnityEngine.SpriteRenderer val_6 = 0.GetComponent<UnityEngine.SpriteRenderer>();
        if(bubbleType != 0)
        {
            goto label_11;
        }
        
        label_2:
        spriteBubble.SetActive(value:  false);
    }
    private static UnityEngine.Vector3 Rotate(UnityEngine.Vector3 v, float radians)
    {
        float val_5 = radians;
        radians = v.x * radians;
        val_5 = (v.x * val_5) - (v.y * radians);
        return new UnityEngine.Vector3() {x = val_5, y = radians + (v.y * val_5), z = v.z};
    }
    public void SetScoreMultiplierText(HitComboType comboType)
    {
        if(comboType <= 4)
        {
                var val_1 = 40829480 + (comboType) << 2;
            val_1 = val_1 + 40829480;
        }
        else
        {
                this.ScoreMultiplierTimeElapsed = 0f;
        }
    
    }
    private void CharacterShake_Set(float intensity)
    {
        intensity = this.shakeIntensityScaler * intensity;
        this.shakeIntensity = intensity;
        if(this.shakeActive != true)
        {
                UnityEngine.Vector3 val_2 = this.PlayerAnimator.transform.localPosition;
            this.characterOriginalPosition = val_2;
            mem[1152921528371671652] = val_2.y;
            mem[1152921528371671656] = val_2.z;
        }
        
        this.shakeActive = true;
    }
    private void CharacterShake_Update(InkWars.Model.Model_Player playerModel)
    {
        float val_6;
        var val_7;
        if(this.shakeActive == false)
        {
                return;
        }
        
        val_6 = playerModel.StunnedTime;
        if(val_6 <= 0f)
        {
                val_7 = null;
            val_7 = null;
            System.Single[] val_1 = InkWars.Model.Model_Constants.CharacterReload_MaxPostAttackDuration + ((playerModel.SpeedLevel) << 2);
            val_6 = mem[(InkWars.Model.Model_Constants.CharacterReload_MaxPostAttackDuration + (playerModel.SpeedLevel) << 2) + 32];
            val_6 = (InkWars.Model.Model_Constants.CharacterReload_MaxPostAttackDuration + (playerModel.SpeedLevel) << 2) + 32;
            if(playerModel.ReloadingTime < 0)
        {
                this.CharacterShake_Reset();
            return;
        }
        
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Random.insideUnitSphere;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  this.shakeIntensity);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.characterOriginalPosition, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        this.PlayerAnimator.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public void CharacterShake_Reset()
    {
        this.shakeActive = false;
        this.PlayerAnimator.transform.localPosition = new UnityEngine.Vector3() {x = this.characterOriginalPosition, y = V9.16B, z = V10.16B};
    }
    public void SetBase(UnityEngine.UI.Image _image, UnityEngine.Sprite _sprite)
    {
        _image.sprite = _sprite;
    }
    public void ResetBase()
    {
        if(this.m_PlayerModel.Clan > 3)
        {
                return;
        }
        
        var val_1 = 40829220 + (this.m_PlayerModel.Clan) << 2;
        val_1 = val_1 + 40829220;
        goto (40829220 + (this.m_PlayerModel.Clan) << 2 + 40829220);
    }
    private void ResetIkaBase()
    {
        View_Core val_1 = View_Core.Instance;
        this.ActiveBase.sprite = val_1.IkaActiveBase[this.m_PlayerModel.SpeedLevel];
    }
    private void ResetTakoBase()
    {
        View_Core val_1 = View_Core.Instance;
        this.ActiveBase.sprite = val_1.TakoActiveBase[this.m_PlayerModel.SpeedLevel];
    }
    private void ResetSpecialBase()
    {
        View_Core val_1 = View_Core.Instance;
        this.ActiveBase.sprite = val_1.SpecialActiveBase[this.m_PlayerModel.SpeedLevel];
    }
    private void ResetSharkBase()
    {
        View_Core val_1 = View_Core.Instance;
        this.ActiveBase.sprite = val_1.SharkActiveBase[this.m_PlayerModel.SpeedLevel];
    }
    public CharacterClan get_Clan()
    {
        if(this.m_PlayerModel != null)
        {
                return (CharacterClan)this.m_PlayerModel.Clan;
        }
        
        return (CharacterClan)this.m_PlayerModel.Clan;
    }
    public void AddPlayerName(string playerName)
    {
        this.PlayerNameBackingImage.gameObject.SetActive(value:  true);
        View_Core val_2 = View_Core.Instance;
        this.PlayerNameBackingImage.sprite = val_2.PlayerNameBackingStrips[this.m_PlayerModel.Clan];
        if(this.PlayerName == null)
        {
            
        }
    
    }
    public void EnablePlayerRank(bool enable, DataStructs.PlayerRank rank)
    {
        this.PlayerRankPlateBG.gameObject.SetActive(value:  enable);
        if(enable == false)
        {
                return;
        }
        
        this.PlayerRankPlateBG.sprite = RankingCollection.GetRankBGByClan(clan:  this.m_PlayerModel.Clan);
        this.PlayerRankMedalImage.gameObject.SetActive(value:  (rank > 10) ? 1 : 0);
        this.PlayerRankLevelImage.gameObject.SetActive(value:  (rank < 11) ? 1 : 0);
        this.PlayerRankMedalImage.sprite = RankingCollection.GetRankSpriteSmall(rank:  rank);
        this.PlayerRankLevelImage.sprite = RankingCollection.GetRankSpriteSmall(rank:  rank);
    }
    public void SetGridEntryIndicatorEnable(bool enable)
    {
        this.GridEntryIndicator.gameObject.SetActive(value:  enable);
    }
    public View_Objects()
    {
        this.OuterRingOffsets = new float[17];
        this.MiddleRingOffsets = new float[13];
        this.InnerRingOffsets = new float[9];
        this.shakeIntensityScaler = 0.2f;
    }

}
