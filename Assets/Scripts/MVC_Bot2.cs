using UnityEngine;
public class MVC_Bot2 : MVC_Bot_Base
{
    // Fields
    public MVC_Bot2_Settings Settings;
    internal bool BattleEnhancer_WaitForRingClear;
    internal bool BattleEnhancer_WaitForStunnerEquipped;
    internal float BattleEnhancerTime;
    
    // Properties
    public float R { get; }
    
    // Methods
    private void OnEnable()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(Character_GlobalInfo.gameMode == 4)
        {
                int val_1 = UnityEngine.Random.Range(min:  0, max:  3);
            if(val_1 == 0)
        {
                if((UnityEngine.Random.Range(min:  val_1, max:  2)) != 0)
        {
                val_6 = 9;
        }
        else
        {
                val_6 = 8;
        }
        
            mem[1152921528291776472] = val_6;
        }
        
        }
        
        InkWars.Model.Model_Events.Instance.add_OnModelStart(value:  new Model_Events.BasicDelegate(object:  this, method:  System.Void MVC_Bot2::OnModelStart()));
    }
    private void OnDisable()
    {
        if(InkWars.Model.Model_Events.Instance == 0)
        {
                return;
        }
        
        InkWars.Model.Model_Events.Instance.remove_OnModelStart(value:  new Model_Events.BasicDelegate(object:  this, method:  System.Void MVC_Bot2::OnModelStart()));
    }
    private void OnModelStart()
    {
        InkWars.Model.Model_Manager val_1 = InkWars.Model.Model_Manager.Instance;
        if((val_1.Model.Feature_BattleEnhancer == false) || (CloudOpponent.current == null))
        {
            goto label_6;
        }
        
        NetworkUserInfo val_3 = CloudOpponent.current;
        if(val_3.enhancerID == 0)
        {
            goto label_6;
        }
        
        NetworkUserInfo val_4 = CloudOpponent.current;
        BattleEnhancerItem val_5 = BattleEnhancerItem.FromInt(number:  val_4.enhancerID);
        InkWars.Model.Model_Player val_6 = this.Player;
        val_6.BattleEnhancerType = val_5.enhancerType;
        InkWars.Model.Model_Player val_7 = this.Player;
        val_7.BattleEnhancerLevel = val_5.level;
        InkWars.Model.Model_Manager val_8 = InkWars.Model.Model_Manager.Instance;
        float val_17 = 10f;
        val_17 = UnityEngine.Random.value * val_17;
        if(val_17 <= (float)this.Settings.Intelligence_Factor)
        {
            goto label_14;
        }
        
        float val_10 = (float)val_8.Model.CountdownTime * 1.5f;
        UnityEngine.MonoBehaviour.print(message:  "Failed second intelligence test, using enhancer irrationally after a random time period");
        float val_18 = -10f;
        val_18 = val_10 + val_18;
        this.BattleEnhancerTime = UnityEngine.Random.Range(min:  10f, max:  (val_10 < 0) ? 50f : (val_18));
        return;
        label_6:
        this.BattleEnhancerTime = 0f;
        return;
        label_14:
        this.BattleEnhancerTime = UnityEngine.Random.Range(min:  this.Settings.MinReactionTime, max:  this.Settings.MaxReactionTime);
        UnityEngine.MonoBehaviour.print(message:  "Passed second intelligence test, using enhancer rationally");
        InkWars.Model.Model_Player val_16 = this.Player;
        if(val_16.BattleEnhancerType != 6)
        {
                if(val_16.BattleEnhancerType != 1)
        {
                return;
        }
        
            this.BattleEnhancer_WaitForRingClear = val_16.BattleEnhancerType;
            return;
        }
        
        this.BattleEnhancer_WaitForStunnerEquipped = true;
    }
    public float get_R()
    {
        return UnityEngine.Random.value;
    }
    public void FixedUpdate()
    {
        var val_29;
        var val_152;
        float val_153;
        var val_154;
        var val_155;
        float val_156;
        var val_157;
        var val_158;
        float val_159;
        var val_160;
        System.Func<BotDecision, System.Single> val_162;
        var val_163;
        System.Func<BotDecision, System.Single> val_165;
        var val_169;
        var val_170;
        val_152 = this;
        if((UnityEngine.Object.op_Implicit(exists:  InkWars.Model.Model_Manager.Instance)) == false)
        {
                return;
        }
        
        InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
        if(val_3.Model.gamePhase == 0)
        {
                return;
        }
        
        InkWars.Model.Model_Manager val_4 = InkWars.Model.Model_Manager.Instance;
        if(val_4.Model.PauseForRevengeSuper > 0f)
        {
                return;
        }
        
        InkWars.Model.Model_Manager val_5 = InkWars.Model.Model_Manager.Instance;
        if(val_5.Model.PauseForStunBreak > 0f)
        {
                return;
        }
        
        if(this.BattleEnhancer_WaitForStunnerEquipped == false)
        {
            goto label_13;
        }
        
        InkWars.Model.Model_Player val_6 = this.Player;
        if(val_6.LoadedBubble != 8)
        {
            goto label_26;
        }
        
        this.BattleEnhancer_WaitForStunnerEquipped = false;
        goto label_26;
        label_13:
        if(this.BattleEnhancer_WaitForRingClear != false)
        {
                if((this.Player.LaneCount(ring:  val_7.InnerRing)) != 0)
        {
                if((this.Player.LaneCount(ring:  val_9.MiddleRing)) != 0)
        {
                if((this.Player.LaneCount(ring:  val_11.OuterRing)) != 0)
        {
            goto label_26;
        }
        
        }
        
        }
        
            this.BattleEnhancer_WaitForRingClear = false;
        }
        else
        {
                if(this.BattleEnhancerTime > 0f)
        {
                float val_13 = UnityEngine.Time.fixedDeltaTime;
            val_13 = this.BattleEnhancerTime - val_13;
            this.BattleEnhancerTime = val_13;
            if(val_13 <= 0f)
        {
                InkWars.Model.Model_Player val_14 = this.Player;
            val_14.TryEquipBattleEnhancer = true;
        }
        
        }
        
        }
        
        label_26:
        InkWars.Model.Model_Player val_15 = this.Player;
        val_153 = val_15.StunnedTime;
        if(val_153 > 0f)
        {
            goto label_29;
        }
        
        val_153 = val_16.ReloadingTime;
        if(val_153 <= 0f)
        {
            goto label_31;
        }
        
        label_29:
        this.Player.TryAimAt = 99;
        val_154 = val_152;
        if(this.BattleEnhancerTime <= 0f)
        {
            goto label_34;
        }
        
        val_155 = 1.401298E-45f;
        mem[1152921528294703184] = true;
        goto label_34;
        label_31:
        val_154 = val_152;
        label_34:
        if(this.BattleEnhancerTime <= 0f)
        {
            goto label_35;
        }
        
        val_156 = this.BattleEnhancerTime - UnityEngine.Time.fixedDeltaTime;
        mem[1152921528294703184] = val_156;
        if(val_156 <= 0f)
        {
                this.Player.TryAimAt = this.Player;
            InkWars.Model.AimTarget val_21 = this.Player.AimTarget;
            val_157 = this.Player;
            if(val_21 != val_157.TryAimAt)
        {
                UnityEngine.MonoBehaviour.print(message:  "bot aim error");
            val_157 = this.Player;
            val_157.AimTarget = val_21;
        }
        
            InkWars.Model.Model_Player val_25 = this.Player;
            val_25.TryShoot = true;
            val_156 = mem[1152921528294703184];
        }
        
        float val_26 = UnityEngine.Mathf.InverseLerp(a:  V9.16B, b:  0f, value:  val_156);
        InkWars.Model.Model_Player val_27 = this.Player;
        float val_28 = UnityEngine.Mathf.Lerp(a:  3f, b:  val_26, t:  val_26);
        if(val_28 >= 0f)
        {
            goto label_45;
        }
        
        if((double)val_28 != (-0.5))
        {
            goto label_46;
        }
        
        val_158 = val_29;
        val_159 = -1f;
        goto label_47;
        label_35:
        InkWars.Model.Model_Manager val_30 = InkWars.Model.Model_Manager.Instance;
        if(val_30.Model.Feature_InkEmUp == false)
        {
            goto label_53;
        }
        
        InkWars.Model.Model_Manager val_31 = InkWars.Model.Model_Manager.Instance;
        if(val_31.Model.InkEmUp_CurrentPhase != 4)
        {
            goto label_53;
        }
        
        if(this.BattleEnhancerTime > 0f)
        {
            goto label_54;
        }
        
        mem[1152921528294703180] = UnityEngine.Random.Range(min:  val_153, max:  null);
        val_152 = this.Player;
        val_33.TryInk = true;
        return;
        label_53:
        InkWars.Model.Model_Manager val_34 = InkWars.Model.Model_Manager.Instance;
        if(val_34.Model.GameResult != 0)
        {
                return;
        }
        
        if(this.BattleEnhancerTime <= 0f)
        {
            goto label_60;
        }
        
        label_54:
        float val_36 = UnityEngine.Time.fixedDeltaTime;
        val_36 = this.BattleEnhancerTime - val_36;
        mem[1152921528294703180] = val_36;
        return;
        label_45:
        if((double)val_28 != 0.5)
        {
            goto label_61;
        }
        
        val_158 = val_29;
        val_159 = 1f;
        label_47:
        val_159 = (float)val_158 + val_159;
        if(val_27 != null)
        {
            goto label_65;
        }
        
        label_66:
        label_65:
        label_89:
        val_27.TryAimAt = (int)(((long)val_158 & 1) != 0) ? ((float)val_158) : (val_159);
        return;
        label_46:
        float val_156 = -0.5f;
        val_156 = val_28 + val_156;
        if(val_27 != null)
        {
            goto label_65;
        }
        
        goto label_66;
        label_61:
        float val_157 = 0.5f;
        val_157 = val_28 + val_157;
        if(val_27 != null)
        {
            goto label_65;
        }
        
        goto label_66;
        label_60:
        mem[1152921528294703180] = UnityEngine.Random.Range(min:  this.Settings.MinReactionTime, max:  this.Settings.MaxReactionTime);
        if(val_30.Model.Feature_InkEmUp != false)
        {
                if(this.Player.BubbleCount <= 18)
        {
                InkWars.Model.Model_Player val_43 = this.Player;
            val_43.SpareBubble = ;
            mem[1152921528294703160] = 0;
        }
        
        }
        
        InkWars.Model.Model_Player val_44 = this.Player;
        if(val_44.StunnedTime > 0f)
        {
                if(this.Settings.RevengeSuperDefensiveOrientation != 10)
        {
                InkWars.Model.Model_Player val_45 = this.Player;
            if(val_45.StunnedTime >= 0)
        {
                return;
        }
        
        }
        
            if(this.Player.CanBreakStun() == false)
        {
                return;
        }
        
            InkWars.Model.Model_Player val_48 = this.Player;
            val_48.TryStunBreak = true;
            return;
        }
        
        InkWars.Model.Model_Player val_49 = this.Player;
        if(val_49.ReloadingTime > 0f)
        {
            goto label_85;
        }
        
        InkWars.Model.Model_Player val_50 = this.Player;
        float val_158 = val_50.SwitchingTime;
        if(val_158 <= 0f)
        {
            goto label_87;
        }
        
        label_85:
        if(this.Player != null)
        {
            goto label_89;
        }
        
        goto label_89;
        label_87:
        InkWars.Model.Model_Player val_52 = this.Player;
        if(val_52.RevengeSuperState != 1)
        {
            goto label_99;
        }
        
        if(this.Settings.RevengeSuperOffensiveOrientation == 0)
        {
            goto label_97;
        }
        
        if(this.Settings.RevengeSuperOffensiveOrientation == 2)
        {
            goto label_94;
        }
        
        if(this.Settings.RevengeSuperOffensiveOrientation != 1)
        {
            goto label_99;
        }
        
        InkWars.Model.Model_Player val_53 = this.Player;
        if((GenericFunctions.IsMiddleSuper(bubbleType:  val_53.RevengeSuperType)) == true)
        {
            goto label_97;
        }
        
        label_94:
        InkWars.Model.Model_Player val_55 = this.Player;
        if(val_55.RevengeSuperType != 10)
        {
            goto label_99;
        }
        
        label_97:
        InkWars.Model.Model_Player val_56 = this.Player;
        val_56.TryEquipSuper = true;
        return;
        label_99:
        val_158 = val_158 * 0.5f;
        mem[1152921528294703192] = 3;
        mem[1152921528294703180] = val_158;
        mem[1152921528294703184] = val_158;
        mem[1152921528294703188] = val_158;
        InkWars.Model.Model_Player val_57 = this.Player;
        if(val_57.LoadedBubble == 8)
        {
                label_203:
            mem[1152921528294703192] = 7;
            return;
        }
        
        System.Collections.Generic.List<BotDecision> val_58 = new System.Collections.Generic.List<BotDecision>();
        InkWars.Model.Model_Player val_59 = this.Player;
        InkWars.Model.Model_Player val_60 = this.Player;
        InkWars.Model.Model_Player val_61 = this.OtherPlayer;
        InkWars.Model.Model_Player val_62 = this.OtherPlayer;
        InkWars.Model.Model_Player val_63 = this.OtherPlayer;
        this.TestLane(OutList:  val_58, decisionType:  0, loadedBubble:  val_59.LoadedBubble, playerRing:  val_60.OuterRing, opponentRing:  val_61.OuterRing, fromTop:  true, sideRing1:  val_62.MiddleRing, sideRing2:  0, opponentTargetBubbles:  val_63.TargetBubbles);
        InkWars.Model.Model_Player val_64 = this.Player;
        InkWars.Model.Model_Player val_65 = this.Player;
        InkWars.Model.Model_Player val_66 = this.OtherPlayer;
        InkWars.Model.Model_Player val_67 = this.OtherPlayer;
        InkWars.Model.Model_Player val_68 = this.OtherPlayer;
        this.TestLane(OutList:  val_58, decisionType:  1, loadedBubble:  val_64.LoadedBubble, playerRing:  val_65.MiddleRing, opponentRing:  val_66.MiddleRing, fromTop:  true, sideRing1:  val_67.InnerRing, sideRing2:  val_68.OuterRing, opponentTargetBubbles:  0);
        InkWars.Model.Model_Player val_69 = this.Player;
        InkWars.Model.Model_Player val_70 = this.Player;
        InkWars.Model.Model_Player val_71 = this.OtherPlayer;
        InkWars.Model.Model_Player val_72 = this.OtherPlayer;
        InkWars.Model.Model_Player val_73 = this.OtherPlayer;
        this.TestLane(OutList:  val_58, decisionType:  2, loadedBubble:  val_69.LoadedBubble, playerRing:  val_70.InnerRing, opponentRing:  val_71.InnerRing, fromTop:  true, sideRing1:  val_72.MiddleRing, sideRing2:  0, opponentTargetBubbles:  val_73.TargetBubbles);
        InkWars.Model.Model_Player val_74 = this.Player;
        InkWars.Model.Model_Player val_75 = this.Player;
        InkWars.Model.Model_Player val_76 = this.OtherPlayer;
        InkWars.Model.Model_Player val_77 = this.OtherPlayer;
        InkWars.Model.Model_Player val_78 = this.OtherPlayer;
        this.TestLane(OutList:  val_58, decisionType:  3, loadedBubble:  val_74.LoadedBubble, playerRing:  val_75.InnerRing, opponentRing:  val_76.InnerRing, fromTop:  false, sideRing1:  val_77.MiddleRing, sideRing2:  0, opponentTargetBubbles:  val_78.TargetBubbles);
        InkWars.Model.Model_Player val_79 = this.Player;
        InkWars.Model.Model_Player val_80 = this.Player;
        InkWars.Model.Model_Player val_81 = this.OtherPlayer;
        InkWars.Model.Model_Player val_82 = this.OtherPlayer;
        InkWars.Model.Model_Player val_83 = this.OtherPlayer;
        InkWars.Model.Model_Player val_84 = this.OtherPlayer;
        this.TestLane(OutList:  val_58, decisionType:  4, loadedBubble:  val_79.LoadedBubble, playerRing:  val_80.MiddleRing, opponentRing:  val_81.MiddleRing, fromTop:  false, sideRing1:  val_82.InnerRing, sideRing2:  val_83.OuterRing, opponentTargetBubbles:  val_84.TargetBubbles);
        InkWars.Model.Model_Player val_85 = this.Player;
        InkWars.Model.Model_Player val_86 = this.Player;
        InkWars.Model.Model_Player val_87 = this.OtherPlayer;
        InkWars.Model.Model_Player val_88 = this.OtherPlayer;
        InkWars.Model.Model_Player val_89 = this.OtherPlayer;
        this.TestLane(OutList:  val_58, decisionType:  5, loadedBubble:  val_85.LoadedBubble, playerRing:  val_86.OuterRing, opponentRing:  val_87.OuterRing, fromTop:  false, sideRing1:  val_88.MiddleRing, sideRing2:  0, opponentTargetBubbles:  val_89.TargetBubbles);
        if(val_58.Count == 0)
        {
                .DecisionType = 7;
            .RandomValue = UnityEngine.Random.value;
            .IsRegularShot = false;
            val_58.Add(item:  new MVC_Bot2.BotDecision());
            System.Collections.Generic.List<BotDecision> val_93 = new System.Collections.Generic.List<BotDecision>();
            InkWars.Model.Model_Player val_94 = this.Player;
            InkWars.Model.Model_Player val_95 = this.Player;
            InkWars.Model.Model_Player val_96 = this.OtherPlayer;
            InkWars.Model.Model_Player val_97 = this.OtherPlayer;
            this.TestLane(OutList:  val_93, decisionType:  0, loadedBubble:  val_94.LoadedBubble, playerRing:  val_95.OuterRing, opponentRing:  val_96.OuterRing, fromTop:  true, sideRing1:  val_97.MiddleRing, sideRing2:  0, opponentTargetBubbles:  0);
            InkWars.Model.Model_Player val_98 = this.Player;
            InkWars.Model.Model_Player val_99 = this.Player;
            InkWars.Model.Model_Player val_100 = this.OtherPlayer;
            InkWars.Model.Model_Player val_101 = this.OtherPlayer;
            InkWars.Model.Model_Player val_102 = this.OtherPlayer;
            this.TestLane(OutList:  val_93, decisionType:  1, loadedBubble:  val_98.LoadedBubble, playerRing:  val_99.MiddleRing, opponentRing:  val_100.MiddleRing, fromTop:  true, sideRing1:  val_101.InnerRing, sideRing2:  val_102.OuterRing, opponentTargetBubbles:  0);
            InkWars.Model.Model_Player val_103 = this.Player;
            InkWars.Model.Model_Player val_104 = this.Player;
            InkWars.Model.Model_Player val_105 = this.OtherPlayer;
            InkWars.Model.Model_Player val_106 = this.OtherPlayer;
            this.TestLane(OutList:  val_93, decisionType:  2, loadedBubble:  val_103.LoadedBubble, playerRing:  val_104.InnerRing, opponentRing:  val_105.InnerRing, fromTop:  true, sideRing1:  val_106.MiddleRing, sideRing2:  0, opponentTargetBubbles:  0);
            InkWars.Model.Model_Player val_107 = this.Player;
            InkWars.Model.Model_Player val_108 = this.Player;
            InkWars.Model.Model_Player val_109 = this.OtherPlayer;
            InkWars.Model.Model_Player val_110 = this.OtherPlayer;
            this.TestLane(OutList:  val_93, decisionType:  3, loadedBubble:  val_107.LoadedBubble, playerRing:  val_108.InnerRing, opponentRing:  val_109.InnerRing, fromTop:  false, sideRing1:  val_110.MiddleRing, sideRing2:  0, opponentTargetBubbles:  0);
            InkWars.Model.Model_Player val_111 = this.Player;
            InkWars.Model.Model_Player val_112 = this.Player;
            InkWars.Model.Model_Player val_113 = this.OtherPlayer;
            InkWars.Model.Model_Player val_114 = this.OtherPlayer;
            InkWars.Model.Model_Player val_115 = this.OtherPlayer;
            this.TestLane(OutList:  val_93, decisionType:  4, loadedBubble:  val_111.LoadedBubble, playerRing:  val_112.MiddleRing, opponentRing:  val_113.MiddleRing, fromTop:  false, sideRing1:  val_114.InnerRing, sideRing2:  val_115.OuterRing, opponentTargetBubbles:  0);
            InkWars.Model.Model_Player val_116 = this.Player;
            InkWars.Model.Model_Player val_117 = this.Player;
            InkWars.Model.Model_Player val_118 = this.OtherPlayer;
            InkWars.Model.Model_Player val_119 = this.OtherPlayer;
            this.TestLane(OutList:  val_93, decisionType:  5, loadedBubble:  val_116.LoadedBubble, playerRing:  val_117.OuterRing, opponentRing:  val_118.OuterRing, fromTop:  false, sideRing1:  val_119.MiddleRing, sideRing2:  0, opponentTargetBubbles:  0);
            if(val_93.Count >= 1)
        {
                .DecisionType = 6;
            .RandomValue = UnityEngine.Random.value;
            .IsRegularShot = false;
            val_58.Add(item:  new MVC_Bot2.BotDecision());
        }
        
        }
        
        if((UnityEngine.Random.value * 10f) > (float)this.Settings.Intelligence_Factor)
        {
                val_58.Add(item:  this.Panic());
        }
        
        val_160 = null;
        val_160 = null;
        val_162 = MVC_Bot2.<>c.<>9__11_0;
        if(val_162 == null)
        {
                System.Func<BotDecision, System.Single> val_126 = null;
            val_162 = val_126;
            val_126 = new System.Func<BotDecision, System.Single>(object:  MVC_Bot2.<>c.__il2cppRuntimeField_static_fields, method:  System.Single MVC_Bot2.<>c::<FixedUpdate>b__11_0(MVC_Bot2.BotDecision p));
            MVC_Bot2.<>c.<>9__11_0 = val_162;
        }
        
        if(val_128.PanicDecision == false)
        {
            goto label_177;
        }
        
        label_236:
        if(val_128.DecisionType > 7)
        {
            goto label_203;
        }
        
        var val_159 = 40826236 + (val_128.DecisionType) << 2;
        val_159 = val_159 + 40826236;
        goto (40826236 + (val_128.DecisionType) << 2 + 40826236);
        label_177:
        if((val_128.IsRegularShot == false) || ((UnityEngine.Random.value * 10f) >= 0))
        {
            goto label_236;
        }
        
        int val_132 = this.Player.LaneCount(ring:  val_131.InnerRing);
        int val_134 = this.Player.LaneCount(ring:  val_133.MiddleRing);
        val_163 = null;
        int val_161 = this.Player.LaneCount(ring:  val_135.OuterRing);
        val_163 = null;
        val_165 = MVC_Bot2.<>c.<>9__11_1;
        if(val_165 == null)
        {
                System.Func<BotDecision, System.Single> val_137 = null;
            val_165 = val_137;
            val_137 = new System.Func<BotDecision, System.Single>(object:  MVC_Bot2.<>c.__il2cppRuntimeField_static_fields, method:  System.Single MVC_Bot2.<>c::<FixedUpdate>b__11_1(MVC_Bot2.BotDecision p));
            MVC_Bot2.<>c.<>9__11_1 = val_165;
        }
        
        var val_160 = 0;
        val_160 = val_160 + 1;
        System.Collections.Generic.IEnumerator<T> val_141 = System.Linq.Enumerable.OrderBy<BotDecision, System.Single>(source:  val_58, keySelector:  val_137).GetEnumerator();
        val_161 = ((val_134 > val_132) ? 1 : 0) | ((val_134 > val_161) ? 1 : 0);
        label_223:
        var val_162 = 0;
        val_162 = val_162 + 1;
        if(val_141.MoveNext() == false)
        {
            goto label_209;
        }
        
        var val_163 = 0;
        val_163 = val_163 + 1;
        val_169 = val_141.Current;
        var val_164 = val_153 + 16;
        if(val_164 > 5)
        {
            goto label_223;
        }
        
        val_164 = 1 << val_164;
        if((val_164 & 33) != 0)
        {
            goto label_217;
        }
        
        val_164 = val_164 & 18;
        if(val_164 == 0)
        {
            goto label_218;
        }
        
        if((val_161 & 1) != 0)
        {
            goto label_223;
        }
        
        goto label_222;
        label_217:
        if((((val_161 > val_132) ? 1 : 0) | ((val_161 > val_134) ? 1 : 0)) != 0)
        {
            goto label_223;
        }
        
        goto label_222;
        label_218:
        if(((((val_132 > val_134) ? 1 : 0) | ((val_132 > val_161) ? 1 : 0)) & 1) != 0)
        {
            goto label_223;
        }
        
        label_222:
        val_170 = 0;
        if(val_141 != null)
        {
            goto label_224;
        }
        
        goto label_230;
        label_209:
        val_170 = 0;
        val_169 = System.Linq.Enumerable.First<BotDecision>(source:  System.Linq.Enumerable.OrderBy<BotDecision, System.Single>(source:  val_58, keySelector:  val_126));
        if(val_141 == null)
        {
            goto label_230;
        }
        
        label_224:
        var val_165 = 0;
        val_165 = val_165 + 1;
        val_141.Dispose();
        label_230:
        if(val_169 != null)
        {
            goto label_236;
        }
    
    }
    private int LaneCount(InkWars.Model.Model_Bubble[] ring)
    {
        var val_2;
        var val_3;
        val_2 = 0;
        val_3 = 0;
        goto label_0;
        label_9:
        if((ring[0] == null) || (ring[0x0][0].BubbleType == 0))
        {
            goto label_7;
        }
        
        if(ring[0x0][0].BubbleType == 14)
        {
            goto label_4;
        }
        
        if(ring[0x0][0].BubbleType != 12)
        {
            goto label_5;
        }
        
        val_3 = 3;
        goto label_7;
        label_4:
        val_3 = 2;
        goto label_7;
        label_5:
        label_7:
        val_2 = 1;
        label_0:
        if(val_2 < ring.Length)
        {
            goto label_9;
        }
        
        return (int)(0 != ring[0x0][0].BubbleType) ? (val_3 + 1) : (val_3);
    }
    private MVC_Bot2.BotDecision Panic()
    {
        var val_12;
        Decision val_13;
        if(((UnityEngine.Random.Range(min:  0, max:  8)) - 1) <= 6)
        {
                var val_12 = 40826268 + ((val_1 - 1)) << 2;
            val_12 = val_12 + 40826268;
        }
        else
        {
                MVC_Bot2.BotDecision val_4 = null;
            val_12 = val_4;
            val_4 = new MVC_Bot2.BotDecision();
            val_13 = 0;
            .DecisionType = ;
            .RandomValue = UnityEngine.Random.value;
            .IsRegularShot = false;
            .PanicDecision = true;
            return (BotDecision);
        }
    
    }
    private void TestLane(System.Collections.Generic.List<MVC_Bot2.BotDecision> OutList, MVC_Bot2.BotDecision.Decision decisionType, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.Model_Bubble[] playerRing, InkWars.Model.Model_Bubble[] opponentRing, bool fromTop, InkWars.Model.Model_Bubble[] sideRing1, InkWars.Model.Model_Bubble[] sideRing2, System.Collections.Generic.List<InkWars.Model.Model_Bubble> opponentTargetBubbles)
    {
        var val_11;
        var val_12;
        var val_49;
        var val_50;
        InkWars.Model.Model_Bubble val_51;
        var val_52;
        var val_53;
        var val_54;
        float val_55;
        System.Collections.Generic.List<BotDecision> val_56;
        var val_57;
        var val_58;
        System.Collections.Generic.List<BotDecision> val_59;
        val_49 = 23076;
        if(opponentRing == null)
        {
                val_49 = 0;
        }
        
        var val_3 = ((fromTop & true) != 0) ? (-1) : 1;
        var val_4 = (fromTop != true) ? 0 : (opponentRing.Length - 1);
        if((opponentTargetBubbles == null) || ((this.LaneCount(ring:  playerRing)) != 0))
        {
            goto label_29;
        }
        
        int val_6 = opponentTargetBubbles.Count;
        if(val_6 < 1)
        {
            goto label_29;
        }
        
        bool val_7 = fromTop;
        InkWars.Model.BubbleTypes val_8 = val_6.GetFirstBubble(opponentRing:  opponentRing, fromTop:  val_7, ignoreBubble:  0);
        if(decisionType <= 5)
        {
                val_53 = mem[40826512 + (decisionType) << 2];
            val_53 = 40826512 + (decisionType) << 2;
        }
        else
        {
                val_53 = 0;
        }
        
        List.Enumerator<T> val_10 = opponentTargetBubbles.GetEnumerator();
        label_20:
        if(((-2078907040) & 1) == 0)
        {
            goto label_7;
        }
        
        if((val_11 != val_53) || (val_13._impl == val_8))
        {
            goto label_20;
        }
        
        if(val_13._impl != 7)
        {
                var val_15 = (val_8 == loadedBubble) ? 1 : 0;
            val_15 = val_15 | val_12.InitialType.IsBubbleSPD();
            if(val_15 != true)
        {
                if(((GenericFunctions.IsMiddleSuper(bubbleType:  loadedBubble)) != true) && (loadedBubble != 7))
        {
                if(loadedBubble != 10)
        {
            goto label_20;
        }
        
        }
        
        }
        
        }
        
        if((val_13._impl != (val_8.GetFirstBubble(opponentRing:  opponentRing, fromTop:  val_7, ignoreBubble:  val_8))) || ((UnityEngine.Random.value * 10f) >= 0))
        {
            goto label_20;
        }
        
        new MVC_Bot2.BotDecision() = new System.Object();
        .DecisionType = decisionType;
        .RandomValue = UnityEngine.Random.value;
        .IsRegularShot = false;
        OutList.Add(item:  new MVC_Bot2.BotDecision());
        goto label_20;
        label_7:
        val_12.Add(driver:  public System.Void List.Enumerator<InkWars.Model.Model_Bubble>::Dispose(), rectTransform:  val_7, drivenProperties:  val_8);
        val_50 = (opponentRing.Length < 0) ? (opponentRing.Length + 1) : opponentRing.Length;
        label_29:
        val_54 =  >> 1;
        InkWars.Model.Model_Bubble val_45 = opponentRing[(long)val_54];
        if((opponentRing[(long)(int)((opponentRing.Length < 0 ? (opponentRing.Length + 1) : opponentRing.Length >> 1))][0].BubbleType) == 0)
        {
            goto label_33;
        }
        
        label_62:
        if((val_4 & 2147483648) != 0)
        {
            goto label_65;
        }
        
        label_64:
        val_50 = 1152921528293632528;
        label_45:
        if(val_4 >= opponentRing.Length)
        {
            goto label_65;
        }
        
        InkWars.Model.Model_Bubble val_46 = opponentRing[(long)val_4];
        if((opponentRing[(long)(int)(fromTop != true ? 0 : (opponentRing.Length - 1))][0].BubbleType) != 0)
        {
            goto label_38;
        }
        
        if(val_54 == val_4)
        {
                InkWars.Model.BubbleTypes val_21 = this.GetBridgeBubble(sideRing:  sideRing1);
            if(val_21 != loadedBubble)
        {
                if((val_21.GetBridgeBubble(sideRing:  sideRing2)) != loadedBubble)
        {
            goto label_43;
        }
        
        }
        
            val_55 = UnityEngine.Random.value;
            if((val_55 * 10f) < 0)
        {
                .DecisionType = decisionType;
            .RandomValue = UnityEngine.Random.value;
            .IsRegularShot = false;
            val_56 = OutList;
            if(val_56 == 0)
        {
                val_56 = OutList;
        }
        
            val_56.Add(item:  new MVC_Bot2.BotDecision());
        }
        
        }
        
        label_43:
        val_52 = val_4 + val_3;
        if((val_52 & 2147483648) == 0)
        {
            goto label_45;
        }
        
        label_65:
        if(loadedBubble == 7)
        {
                return;
        }
        
        if((GenericFunctions.IsSuperType(bubbleType:  loadedBubble)) == true)
        {
                return;
        }
        
        if(fromTop == false)
        {
            goto label_48;
        }
        
        val_57 = 0;
        val_58 = 1;
        goto label_49;
        label_33:
        var val_48 = val_54;
        label_54:
        var val_28 = (-val_3) + val_48;
        if(((val_28 & 2147483648) != 0) || (val_28 >= opponentRing.Length))
        {
            goto label_62;
        }
        
        InkWars.Model.Model_Bubble val_47 = opponentRing[(long)val_28];
        val_48 = val_48 - val_3;
        if((opponentRing[(long)(int)(((fromTop & true)!=0 ?  (-1) : 1 + (opponentRing.Length < 0 ? (opponentRing.Length + 1) : opponentRing.Length >> 1)))][0].BubbleType) == 0)
        {
            goto label_54;
        }
        
        if((this.GetBridgeBubble(sideRing:  sideRing1, checkDirection:  -val_3)) != (opponentRing[(long)(int)(((fromTop & true)!=0 ?  (-1) : 1 + (opponentRing.Length < 0 ? (opponentRing.Length + 1) : opponentRing.Length >> 1)))] + 32 + 16))
        {
                if((this.GetBridgeBubble(sideRing:  sideRing2, checkDirection:  -val_3)) != (opponentRing[(long)(int)(((fromTop & true)!=0 ?  (-1) : 1 + (opponentRing.Length < 0 ? (opponentRing.Length + 1) : opponentRing.Length >> 1)))] + 32 + 16))
        {
            goto label_62;
        }
        
        }
        
        float val_49 = 10f;
        val_49 = UnityEngine.Random.value * val_49;
        if(val_49 >= 0)
        {
            goto label_62;
        }
        
        .DecisionType = decisionType;
        .RandomValue = UnityEngine.Random.value;
        .IsRegularShot = false;
        val_59 = OutList;
        if(val_59 == 0)
        {
                val_59 = OutList;
        }
        
        val_59.Add(item:  new MVC_Bot2.BotDecision());
        if((val_4 & 2147483648) == 0)
        {
            goto label_64;
        }
        
        goto label_65;
        label_38:
        if(((opponentRing[(long)(int)(fromTop != true ? 0 : (opponentRing.Length - 1))] + 32.IsBubbleSPD()) != true) && ((opponentRing[(long)(int)(fromTop != true ? 0 : (opponentRing.Length - 1))] + 32 + 16) != 7))
        {
                val_52 = mem[opponentRing[(long)(int)(fromTop != true ? 0 : (opponentRing.Length - 1))] + 32];
            val_52 = opponentRing[(long)(int)(fromTop != true ? 0 : (opponentRing.Length - 1))] + 32;
            if((loadedBubble != 7) && ((opponentRing[(long)(int)(fromTop != true ? 0 : (opponentRing.Length - 1))] + 32 + 16) != loadedBubble))
        {
                if(loadedBubble != 10)
        {
                if((GenericFunctions.IsMiddleSuper(bubbleType:  loadedBubble)) == false)
        {
                return;
        }
        
        }
        
        }
        
        }
        
        val_55 = UnityEngine.Random.value;
        val_52 = mem[1152921528297755936];
        if((val_55 * 10f) >= 0)
        {
                return;
        }
        
        .DecisionType = decisionType;
        .RandomValue = UnityEngine.Random.value;
        .IsRegularShot = true;
        label_102:
        OutList.Add(item:  new MVC_Bot2.BotDecision());
        return;
        label_48:
        val_57 = playerRing.Length - 1;
        if((val_57 & 2147483648) != 0)
        {
                return;
        }
        
        val_58 = 0;
        label_49:
        val_52 = val_57 + 1;
        label_89:
        val_54 = val_52 - 1;
        if(val_54 >= playerRing.Length)
        {
                return;
        }
        
        val_51 = playerRing[(long)val_54];
        if((playerRing[(long)(int)((((playerRing.Length - 1) + 1) - 1))][0].BubbleType) != 0)
        {
            goto label_88;
        }
        
        val_52 = val_52 + val_58;
        if(((val_52 - 1) & 2147483648) == 0)
        {
            goto label_89;
        }
        
        return;
        label_88:
        if(val_52 == 1)
        {
                return;
        }
        
        if((playerRing[(long)(int)((((playerRing.Length - 1) + 1) - 1))] + 32.IsBubbleSPD()) == true)
        {
                return;
        }
        
        if(playerRing.Length == val_52)
        {
                return;
        }
        
        val_52 = mem[playerRing[(long)(int)((((playerRing.Length - 1) + 1) - 1))] + 32];
        val_52 = playerRing[(long)(int)((((playerRing.Length - 1) + 1) - 1))] + 32;
        if((playerRing[(long)(int)((((playerRing.Length - 1) + 1) - 1))] + 32 + 16) == loadedBubble)
        {
                return;
        }
        
        val_55 = UnityEngine.Random.value;
        val_52 = mem[1152921528297755936];
        float val_50 = 10f;
        val_50 = val_55 * val_50;
        if(val_50 >= 0)
        {
                return;
        }
        
        MVC_Bot2.BotDecision val_43 = new MVC_Bot2.BotDecision();
        .DecisionType = decisionType;
        .RandomValue = UnityEngine.Random.value;
        .IsRegularShot = false;
        if(OutList != 0)
        {
            goto label_102;
        }
        
        goto label_102;
    }
    private InkWars.Model.BubbleTypes GetFirstBubble(InkWars.Model.Model_Bubble[] opponentRing, bool fromTop, InkWars.Model.BubbleTypes ignoreBubble = 0)
    {
        var val_2;
        var val_3;
        if(fromTop == false)
        {
            goto label_0;
        }
        
        val_2 = 0;
        val_3 = 1;
        if(opponentRing != null)
        {
            goto label_5;
        }
        
        goto label_2;
        label_0:
        val_2 = opponentRing.Length - 1;
        if((val_2 & 2147483648) != 0)
        {
                return 0;
        }
        
        val_3 = 0;
        label_13:
        if(opponentRing != null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        if(val_2 >= opponentRing.Length)
        {
                return 0;
        }
        
        InkWars.Model.Model_Bubble val_1 = opponentRing[(long)val_2];
        if((opponentRing[(long)(int)((opponentRing.Length - 1))][0].BubbleType) != 0)
        {
                if((opponentRing[(long)(int)((opponentRing.Length - 1))] + 32 + 16) != ignoreBubble)
        {
            goto label_12;
        }
        
        }
        
        val_2 = val_2 + val_3;
        if((val_2 & 2147483648) == 0)
        {
            goto label_13;
        }
        
        return 0;
        label_12:
        if((opponentRing[(long)(int)((opponentRing.Length - 1))] + 32) != 0)
        {
                return 0;
        }
        
        return 0;
    }
    private InkWars.Model.AimTarget DecisionTypeToAimTarget(MVC_Bot2.BotDecision.Decision decisionType)
    {
        if(decisionType > 5)
        {
                return 0;
        }
        
        return (InkWars.Model.AimTarget)40826512 + (decisionType) << 2;
    }
    private InkWars.Model.BubbleTypes GetBridgeBubble(InkWars.Model.Model_Bubble[] sideRing)
    {
        InkWars.Model.Model_Bubble val_3;
        InkWars.Model.BubbleTypes val_4;
        val_3 = sideRing;
        if((val_3 != null) && (sideRing.Length != 0))
        {
                var val_1 = (sideRing.Length < 0) ? (sideRing.Length + 1) : sideRing.Length;
            var val_2 = val_1 >> 1;
            val_3 = val_3[(long)(val_1 >> 1) & 2147483647];
            val_4 = sideRing[(long)((sideRing.Length < 0 ? (sideRing.Length + 1) : sideRing.Length>>1) & 0x7FFFFFFF)][0].BubbleType;
            return (InkWars.Model.BubbleTypes)val_4;
        }
        
        val_4 = 0;
        return (InkWars.Model.BubbleTypes)val_4;
    }
    private InkWars.Model.BubbleTypes GetBridgeBubble(InkWars.Model.Model_Bubble[] sideRing, int checkDirection)
    {
        var val_4;
        if((sideRing == null) || (sideRing.Length == 0))
        {
            goto label_7;
        }
        
        var val_1 = (sideRing.Length < 0) ? (sideRing.Length + 1) : sideRing.Length;
        if((val_1 >> 31) != 0)
        {
            goto label_7;
        }
        
        val_1 = val_1 >> 1;
        if(val_1 >= sideRing.Length)
        {
            goto label_7;
        }
        
        label_8:
        InkWars.Model.Model_Bubble val_4 = sideRing[(long)val_1];
        if((sideRing[(long)(int)((sideRing.Length < 0 ? (sideRing.Length + 1) : sideRing.Length >> 1))][0].BubbleType) != 0)
        {
            goto label_6;
        }
        
        val_1 = (long)val_1 + checkDirection;
        if((val_1 >> 31) != 0)
        {
            goto label_7;
        }
        
        val_4 = 0;
        if(val_1 < sideRing.Length)
        {
            goto label_8;
        }
        
        return (InkWars.Model.BubbleTypes)val_4;
        label_7:
        val_4 = 0;
        return (InkWars.Model.BubbleTypes)val_4;
        label_6:
        if((sideRing[(long)(int)((sideRing.Length < 0 ? (sideRing.Length + 1) : sideRing.Length >> 1))] + 32) != 0)
        {
                return (InkWars.Model.BubbleTypes)val_4;
        }
        
        return (InkWars.Model.BubbleTypes)val_4;
    }
    public MVC_Bot2()
    {
        mem[1152921528298848380] = ;
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
