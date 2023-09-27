using UnityEngine;

namespace InkWars.Model
{
    [Serializable]
    public class Model_Player
    {
        // Fields
        internal InkWars.Model.Model_Core Model;
        internal bool IsReady;
        public InkWars.Model.Player ID;
        public CharacterClan Clan;
        public CharacterNameID Name;
        public int AttackLevel;
        public int SpeedLevel;
        public InkWars.Model.BubbleTypes MiddleSuper;
        public InkWars.Model.BubbleTypes LoadedBubble;
        public InkWars.Model.BubbleTypes SpareBubble;
        public bool TryEquipSuper;
        public bool TryEquipBattleEnhancer;
        public bool TryEquipBPAmplifier;
        public bool TryShoot;
        public bool TryInk;
        public bool TrySwitch;
        public bool TryStunBreak;
        public float StunnedTime;
        public float ReloadingTime;
        public float FullReloadTime;
        public float SwitchingTime;
        public InkWars.Model.BubbleTypes RevengeSuperType;
        public InkWars.Model.RevengeSuperEventState RevengeSuperState;
        public InkWars.Model.AimTarget RevengerSuperAimTarget;
        public InkWars.Model.BattleEnhancerType BattleEnhancerType;
        public InkWars.Model.BattleEnhancerState BattleEnhancerState;
        public int BattleEnhancerLevel;
        public float BattleEnhancerTimeLeft;
        public System.Collections.Generic.List<InkWars.Model.Model_Bubble> TargetBubbles;
        public InkWars.Model.Model_Bubble[] OuterRing;
        public InkWars.Model.Model_Bubble[] MiddleRing;
        public InkWars.Model.Model_Bubble[] InnerRing;
        private System.Collections.Generic.List<InkWars.Model.Model_Bubble> PoppedBubblesRef;
        private System.Collections.Generic.List<int> PoppedBubblesRef_DelayCount;
        public Techniques TechRecordForView;
        public InkWars.Model.MatchEndScoreCard ScoreCard;
        private InkWars.Model.AimTarget _aimTarget;
        private InkWars.Model.AimTarget _tryAimAt;
        private float _revengeSuperLevel;
        public int BubblesRemainingOnMatchConclusion;
        private PlayerBuff <buff>k__BackingField;
        private int nextTargetPoolIndex;
        
        // Properties
        public bool NoBubblesLeft { get; }
        public InkWars.Model.AimTarget AimTarget { get; set; }
        public InkWars.Model.AimTarget TryAimAt { get; set; }
        public float RevengeSuperLevel { get; set; }
        public bool CanShoot { get; }
        public bool CanAim { get; }
        public int BubbleCount { get; }
        public PlayerBuff buff { get; set; }
        
        // Methods
        public bool get_NoBubblesLeft()
        {
            return (bool)(this.BubbleCount == 0) ? 1 : 0;
        }
        public InkWars.Model.AimTarget get_AimTarget()
        {
            return (InkWars.Model.AimTarget)this._aimTarget;
        }
        public void set_AimTarget(InkWars.Model.AimTarget value)
        {
            if(this._aimTarget != value)
            {
                    InkWars.Model.Model_Events.Instance.Event_AimLine(Id:  this.ID, aimTarget:  value);
            }
            
            this._aimTarget = value;
        }
        public InkWars.Model.AimTarget get_TryAimAt()
        {
            return (InkWars.Model.AimTarget)this._tryAimAt;
        }
        public void set_TryAimAt(InkWars.Model.AimTarget value)
        {
            this._tryAimAt = (this.LoadedBubble == 8) ? 7 : value;
        }
        public float Get_RevengeSuper()
        {
            return (float)this._revengeSuperLevel;
        }
        public float get_RevengeSuperLevel()
        {
            return (float)this._revengeSuperLevel;
        }
        public void set_RevengeSuperLevel(float value)
        {
            if(this.Model.Feature_Powerup == 1)
            {
                    0f = value;
            }
            
            this._revengeSuperLevel = UnityEngine.Mathf.Clamp(value:  0f, min:  0f, max:  100f);
        }
        public void AddToRevengeSuper(float amount, bool force = False)
        {
            if(force != true)
            {
                    InkWars.Model.Model_Player val_2 = this.Model.GetPlayer(PlayerNumber:  1 - this.ID);
                if(((val_2.Model.Feature_BattleEnhancer != false) && (val_2.BattleEnhancerState == 1)) && (val_2.BattleEnhancerType == 5))
            {
                    return;
            }
            
            }
            
            CharacterData val_3 = CharacterDataManager.Get(id:  this.Name);
            InkWars.Model.Model_Player val_5 = this.Model.GetPlayer(PlayerNumber:  1 - this.ID);
            float val_7 = val_5.<buff>k__BackingField.GetBuffValuePercent01(aNewType:  9);
            val_7 = (this.<buff>k__BackingField.GetBuffValuePercent01(aNewType:  8)) - val_7;
            val_7 = val_3.superMeterGainRateFactor + val_7;
            val_7 = val_7 * amount;
            val_7 = this._revengeSuperLevel + val_7;
            this.RevengeSuperLevel = val_7;
        }
        public bool get_CanShoot()
        {
            var val_3;
            if(((this.ReloadingTime == 0f) && (this.SwitchingTime == 0f)) && (this.StunnedTime == 0f))
            {
                    val_3 = this;
                if(this.BubbleCount == 0)
            {
                    return (bool)val_3;
            }
            
                var val_2 = (this._aimTarget != 1) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public bool get_CanAim()
        {
            return (bool)(this.BubbleCount != 0) ? 1 : 0;
        }
        public Model_Player()
        {
            this.MiddleSuper = 9;
            this.BattleEnhancerLevel = 1;
            this.TargetBubbles = new System.Collections.Generic.List<InkWars.Model.Model_Bubble>();
            this.OuterRing = new InkWars.Model.Model_Bubble[17];
            this.MiddleRing = new InkWars.Model.Model_Bubble[13];
            this.InnerRing = new InkWars.Model.Model_Bubble[9];
            this.PoppedBubblesRef = new System.Collections.Generic.List<InkWars.Model.Model_Bubble>();
            this.PoppedBubblesRef_DelayCount = new System.Collections.Generic.List<System.Int32>();
            this._aimTarget = 0;
            var val_9 = 0;
            do
            {
                this.TargetBubbles.Add(item:  new InkWars.Model.Model_Bubble(model_Player:  this, type:  0, aimTarget:  0, poolIndex:  0));
                val_9 = val_9 + 1;
            }
            while(val_9 != 5);
            
            this.<buff>k__BackingField = new PlayerBuff();
        }
        internal void Finish()
        {
            this.AimTarget = 0;
            List.Enumerator<T> val_1 = this.TargetBubbles.GetEnumerator();
            label_4:
            if(((-1096327848) & 1) == 0)
            {
                goto label_2;
            }
            
            bool val_3 = 0.InitialType.Damage(responsiblePlayer:  this.ID, forceKill:  true, isCrossBubbleHit:  false);
            goto label_4;
            label_2:
            0.Add(driver:  public System.Void List.Enumerator<InkWars.Model.Model_Bubble>::Dispose(), rectTransform:  null, drivenProperties:  null);
            this.StunnedTime = 0f;
            this.BubblesRemainingOnMatchConclusion = this.BubbleCount;
        }
        public bool HasBattleEnhancer(InkWars.Model.BattleEnhancerType type)
        {
            var val_2;
            if((this.Model.Feature_BattleEnhancer != false) && (this.BattleEnhancerState == 1))
            {
                    var val_1 = (this.BattleEnhancerType == type) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        public int get_BubbleCount()
        {
            null = null;
            if(Character_GlobalInfo.gameMode == 3)
            {
                    if(this.ID == 0)
            {
                goto label_4;
            }
            
            }
            
            int val_1 = RingCount(ring:  this.InnerRing);
            int val_2 = val_1.RingCount(ring:  this.MiddleRing);
            int val_3 = val_2.RingCount(ring:  this.OuterRing);
            val_3 = (val_2 + val_1) + val_3;
            return (int)val_3;
            label_4:
            if(this.Model != null)
            {
                    return (int)val_3;
            }
            
            return (int)val_3;
        }
        public PlayerBuff get_buff()
        {
            return (PlayerBuff)this.<buff>k__BackingField;
        }
        public void set_buff(PlayerBuff value)
        {
            this.<buff>k__BackingField = value;
        }
        internal void TryReturnLoadedPowerBall()
        {
            var val_11;
            var val_12;
            var val_13;
            if(this.ID != 0)
            {
                    return;
            }
            
            if(this.Model.Feature_Powerup != 2)
            {
                    return;
            }
            
            if((GenericFunctions.IsSuperType(bubbleType:  this.LoadedBubble)) == false)
            {
                    return;
            }
            
            if(this.LoadedBubble == 8)
            {
                goto label_5;
            }
            
            if(this.LoadedBubble == 10)
            {
                goto label_6;
            }
            
            if(this.LoadedBubble != 9)
            {
                goto label_21;
            }
            
            val_11 = null;
            val_11 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Items.IronBall;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited});
            DataStructs.UserDataDictionary.Items.IronBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
            goto label_21;
            label_5:
            val_12 = null;
            val_12 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = DataStructs.UserDataDictionary.Items.StunnerBall;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited});
            DataStructs.UserDataDictionary.Items.StunnerBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited};
            goto label_21;
            label_6:
            val_13 = null;
            val_13 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = DataStructs.UserDataDictionary.Items.ColorEraserBall;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited});
            DataStructs.UserDataDictionary.Items.ColorEraserBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue, inited = val_7.inited};
            label_21:
            this.LoadedBubble = this.GetNextBubble(otherPlayer:  this.Model.GetPlayer(PlayerNumber:  1 - this.ID));
        }
        internal void Update(float deltaTime)
        {
            var val_27;
            var val_28;
            InkWars.Model.AimTarget val_29;
            InkWars.Model.AimTarget val_30;
            InkWars.Model.BattleEnhancerType val_33;
            InkWars.Model.RevengeSuperEventState val_34;
            InkWars.Model.BubbleTypes val_35;
            InkWars.Model.Player val_36;
            InkWars.Model.BubbleTypes val_37;
            InkWars.Model.RevengeSuperEventState val_38;
            var val_39;
            val_27 = this;
            if(this.StunnedTime == 0f)
            {
                    this.ReloadingTime = (this.ReloadingTime > deltaTime) ? (this.ReloadingTime - deltaTime) : 0f;
            }
            
            if(this.Model.GameResult != 0)
            {
                    return;
            }
            
            InkWars.Model.MatchEndScoreCard val_27 = this.ScoreCard;
            val_27 = val_27 + deltaTime;
            this.ScoreCard = val_27;
            if(this.TryStunBreak != false)
            {
                    if(this.CanBreakStun() != false)
            {
                    this.BreakStun(overrideRevengeSuper:  -1f, otherLoadedBubble:  0, otherSpareBubble:  0);
                this.TryStunBreak = false;
                if(this.ID != 0)
            {
                    return;
            }
            
                val_28 = null;
                val_28 = null;
                DataStructs.UserDataDictionary.Stats.Increment_StunBreaks();
                return;
            }
            
            }
            
            this.TryStunBreak = false;
            this.StunnedTime = (this.StunnedTime > deltaTime) ? (this.StunnedTime - deltaTime) : 0f;
            this.SwitchingTime = (this.SwitchingTime > deltaTime) ? (this.SwitchingTime - deltaTime) : 0f;
            if(this.RevengeSuperState == 3)
            {
                    if(this.LoadedBubble == 8)
            {
                    val_29 = 7;
                this.RevengerSuperAimTarget = val_29;
            }
            else
            {
                    val_29 = this.RevengerSuperAimTarget;
            }
            
                this.AimTarget = val_29;
                this.RevengeSuperState = -4294967296;
                InkWars.Model.Model_Events.Instance.Event_RevengeSuper(id:  this.ID, revengeSuperType:  0, state:  4);
                this.Shoot(type:  this.LoadedBubble, nextBubble:  0, sendOverNetwork:  false, pingTime:  -1f);
            }
            
            if(this.BubbleCount == 0)
            {
                goto label_15;
            }
            
            if(this.TryShoot != false)
            {
                    if(this.CanShoot != false)
            {
                    this.Shoot(type:  this.LoadedBubble, nextBubble:  0, sendOverNetwork:  true, pingTime:  -1f);
            }
            
                this.AimTarget = 0;
                this.TryShoot = false;
            }
            
            val_30 = this._tryAimAt;
            if(val_30 == 1)
            {
                goto label_20;
            }
            
            if(val_30 == 99)
            {
                    val_30 = 0;
            }
            
            this.AimTarget = val_30;
            this._tryAimAt = 0;
            goto label_20;
            label_15:
            this.AimTarget = 0;
            label_20:
            if((this.TrySwitch != false) && (this.SwitchingTime == 0f))
            {
                    this.TryReturnLoadedPowerBall();
                this.Switch(manualSwitch:  true);
            }
            
            this.TrySwitch = false;
            if(this.Model.Feature_BattleEnhancer == false)
            {
                goto label_24;
            }
            
            if(this.BattleEnhancerState == 1)
            {
                goto label_25;
            }
            
            if((this.BattleEnhancerState != 0) || (this.TryEquipBattleEnhancer == false))
            {
                goto label_38;
            }
            
            if(this.BattleEnhancerType > 5)
            {
                goto label_28;
            }
            
            var val_28 = 40830592;
            val_28 = (40830592 + (this.BattleEnhancerType) << 2) + val_28;
            goto (40830592 + (this.BattleEnhancerType) << 2 + 40830592);
            label_25:
            float val_30 = this.BattleEnhancerTimeLeft;
            float val_29 = -1.5f;
            val_29 = deltaTime / val_29;
            val_30 = val_30 + val_29;
            this.BattleEnhancerTimeLeft = val_30;
            if(val_30 > 0f)
            {
                goto label_38;
            }
            
            this.BattleEnhancerTimeLeft = 0f;
            this.BattleEnhancerType = 8589934592;
            val_33 = this.BattleEnhancerType;
            InkWars.Model.Model_Events.Instance.Event_BattleEnhancer(timestamp:  this.Model.TimeLeft, id:  this.ID, type:  val_33, state:  this.BattleEnhancerState, level:  this.BattleEnhancerLevel);
            goto label_38;
            label_28:
            this.BattleEnhancerTimeLeft = (float)(UnityEngine.Mathf.Clamp(value:  this.BattleEnhancerLevel, min:  1, max:  6)) * ((this.BattleEnhancerType == 4) ? 8 : 10);
            this.BattleEnhancerState = 1;
            val_33 = this.BattleEnhancerType;
            InkWars.Model.Model_Events.Instance.Event_BattleEnhancer(timestamp:  this.Model.TimeLeft, id:  this.ID, type:  val_33, state:  this.BattleEnhancerState, level:  this.BattleEnhancerLevel);
            if(this.BattleEnhancerType == 2)
            {
                    this.SpareBubble = 7;
            }
            
            label_38:
            this.TryEquipBattleEnhancer = false;
            label_24:
            if(this.Model.Feature_Powerup != 1)
            {
                goto label_57;
            }
            
            if((this.TryEquipSuper == false) || (this.RevengeSuperType == 0))
            {
                goto label_42;
            }
            
            val_34 = this.RevengeSuperState;
            if(val_34 != 1)
            {
                goto label_43;
            }
            
            this.RevengeSuper_Equip();
            label_42:
            val_34 = this.RevengeSuperState;
            label_43:
            this.TryEquipSuper = false;
            if(val_34 == 1)
            {
                goto label_44;
            }
            
            if(val_34 != 0)
            {
                goto label_57;
            }
            
            float val_32 = this._revengeSuperLevel;
            this.RevengeSuperType = 0;
            if(val_32 >= 0)
            {
                goto label_46;
            }
            
            float val_31 = 0f;
            val_31 = deltaTime * val_31;
            val_32 = val_32 + val_31;
            this.RevengeSuperLevel = val_32;
            goto label_57;
            label_44:
            if(this._revengeSuperLevel != 100f)
            {
                goto label_48;
            }
            
            int val_23 = this.BubbleCount - (this.Model.GetPlayer(PlayerNumber:  1 - this.ID).BubbleCount);
            if(val_23 <= 8)
            {
                goto label_50;
            }
            
            val_35 = 8;
            goto label_56;
            label_46:
            this.RevengeSuperState = 1;
            goto label_57;
            label_48:
            this.RevengeSuperState = 0;
            InkWars.Model.Model_Events val_24 = InkWars.Model.Model_Events.Instance;
            val_36 = this.ID;
            val_37 = this.RevengeSuperType;
            val_38 = 0;
            goto label_54;
            label_50:
            if(val_23 >= 12)
            {
                    val_35 = this.MiddleSuper;
            }
            else
            {
                    val_35 = 10;
            }
            
            label_56:
            if(this.RevengeSuperType == 10)
            {
                goto label_57;
            }
            
            this.RevengeSuperType = 10;
            val_38 = 1;
            val_36 = this.ID;
            val_37 = this.RevengeSuperType;
            label_54:
            InkWars.Model.Model_Events.Instance.Event_RevengeSuper(id:  val_36, revengeSuperType:  val_37, state:  val_38);
            label_57:
            val_27 = this.TargetBubbles.ToArray();
            val_39 = 0;
            goto label_60;
            label_64:
            val_27[0].Update(deltaTime:  deltaTime);
            val_39 = 1;
            label_60:
            if(val_39 < val_26.Length)
            {
                goto label_64;
            }
        
        }
        public void RevengeSuper_Equip()
        {
            this.RevengeSuperState = 2;
            this.SpareBubble = this.RevengeSuperType;
            InkWars.Model.Model_Events.Instance.Event_RevengeSuper(id:  this.ID, revengeSuperType:  this.RevengeSuperType, state:  2);
            this.Switch(manualSwitch:  false);
        }
        public void BreakStun(float overrideRevengeSuper = -1, InkWars.Model.BubbleTypes otherLoadedBubble = 0, InkWars.Model.BubbleTypes otherSpareBubble = 0)
        {
            InkWars.Model.Model_Core val_13;
            float val_14;
            float val_1 = this.GetBreakStunSuperLevel();
            val_1 = this._revengeSuperLevel - val_1;
            this.RevengeSuperLevel = val_1;
            this.RevengeSuperLevel = UnityEngine.Mathf.Max(a:  this._revengeSuperLevel, b:  0f);
            this.StunnedTime = 0f;
            if(overrideRevengeSuper <= (-1f))
            {
                goto label_3;
            }
            
            this.RevengeSuperLevel = overrideRevengeSuper;
            if(this.RevengeSuperState != 2)
            {
                goto label_6;
            }
            
            this.RevengeSuperState = 0;
            this.LoadedBubble = otherLoadedBubble;
            this.SpareBubble = otherSpareBubble;
            goto label_9;
            label_3:
            if(this.RevengeSuperState != 2)
            {
                goto label_6;
            }
            
            this.RevengeSuperState = 0;
            if((GenericFunctions.IsSuperType(bubbleType:  this.LoadedBubble)) != false)
            {
                    this.LoadedBubble = this.GetNextBubble(otherPlayer:  this.Model.GetPlayer(PlayerNumber:  1 - this.ID));
            }
            
            if((GenericFunctions.IsSuperType(bubbleType:  this.SpareBubble)) != false)
            {
                    this.SpareBubble = this.GetNextBubble(otherPlayer:  this.Model.GetPlayer(PlayerNumber:  1 - this.ID));
            }
            
            label_9:
            InkWars.Model.Model_Events.Instance.Event_RevengeSuper(id:  this.ID, revengeSuperType:  this.RevengeSuperType, state:  0);
            label_6:
            val_13 = this.Model;
            if(val_13 != null)
            {
                    val_14 = this.Model.PauseForStunBreak;
            }
            else
            {
                    val_13 = 72;
                val_14 = 0f;
            }
            
            float val_13 = 1f;
            val_13 = val_14 + val_13;
            mem[72] = val_13;
            InkWars.Model.Model_Events.Instance.Event_StunBreak(id:  this.ID, revengeSuperLevel:  this._revengeSuperLevel, loadedBubble:  this.LoadedBubble, spareBubble:  this.SpareBubble);
        }
        public bool CanBreakStun()
        {
            InkWars.Model.Model_Player val_2 = this.Model.GetPlayer(PlayerNumber:  1 - this.ID);
            if((val_2.Model.Feature_BattleEnhancer != false) && (val_2.BattleEnhancerState == 1))
            {
                    if(val_2.BattleEnhancerType == 6)
            {
                    return false;
            }
            
            }
            
            if(this.Model.Feature_StunBreak != false)
            {
                    if(this.StunnedTime >= 3f)
            {
                goto label_8;
            }
            
            }
            
            return false;
            label_8:
            if(this._revengeSuperLevel >= this.GetBreakStunSuperLevel())
            {
                    return false;
            }
            
            var val_4 = (this._revengeSuperLevel == 100f) ? 1 : 0;
            return false;
        }
        private float GetBreakStunSuperLevel()
        {
            InkWars.Model.Model_Player val_3 = this.Model.GetPlayer(PlayerNumber:  1 - this.ID);
            float val_4 = val_3.<buff>k__BackingField.GetBuffValuePercent01(aNewType:  11);
            float val_5 = 1f;
            float val_6 = 10f;
            val_5 = val_5 - (this.<buff>k__BackingField.GetBuffValuePercent01(aNewType:  10));
            val_6 = this.StunnedTime * val_6;
            val_4 = val_5 + val_4;
            val_4 = val_6 * val_4;
            return (float)val_4;
        }
        internal void ShootInkEmUp()
        {
            InkWars.Model.Model_Core val_2;
            InkWars.Model.Model_Bubble[] val_3;
            InkWars.Model.Model_Core val_4;
            InkWars.Model.Model_Core val_5;
            var val_6;
            InkWars.Model.Model_Core val_7;
            int val_8;
            var val_9;
            val_2 = this.Model;
            if(this.Model != null)
            {
                goto label_1;
            }
            
            val_2 = this.Model;
            if(val_2 == null)
            {
                goto label_11;
            }
            
            label_1:
            val_3 = this.Model.InkEmUp_InkBubbles;
            if(this.Model.InkEmUp_InkIndex >= this.Model.InkEmUp_InkBubbles.Length)
            {
                    return;
            }
            
            val_4 = this.Model;
            if(this.Model != null)
            {
                goto label_5;
            }
            
            val_4 = this.Model;
            if(val_4 == null)
            {
                goto label_11;
            }
            
            label_5:
            InkWars.Model.Model_Bubble val_2 = this.Model.InkEmUp_InkBubbles[this.Model.InkEmUp_InkIndex];
            this.Model.InkEmUp_InkBubbles[this.Model.InkEmUp_InkIndex][0].ShotAsInk = true;
            val_5 = this.Model;
            if(this.Model != null)
            {
                goto label_10;
            }
            
            val_5 = this.Model;
            if(val_5 == null)
            {
                goto label_11;
            }
            
            label_10:
            val_6 = null;
            val_6 = null;
            this.Model.InkEmUp_InkBubbles[this.Model.InkEmUp_InkIndex].SetScoreAndPopDelay(score:  InkWars.Model.Model_Constants.ScoreInkEmUp_Hit, popDelay:  0f, scoreTarget:  this.ID, comboType:  0);
            val_7 = this.Model;
            if(val_7 != null)
            {
                    val_8 = this.Model.InkEmUp_InkIndex;
            }
            else
            {
                    val_7 = 112;
                val_8 = 65536;
            }
            
            mem[112] = 65537;
            if(this.ID == 0)
            {
                    val_9 = null;
                val_9 = null;
                DataStructs.UserDataDictionary.Stats.IncreaseInkBubbleShoot();
            }
            
            val_3 = InkWars.Model.Model_Events.Instance;
            val_3.Event_OnInkEmUpShot(id:  this.ID, timeRemaining:  this.Model.InkEmUp_TimeRemaining);
            this.TryInk = false;
            return;
            label_11:
        }
        private int RingCount(InkWars.Model.Model_Bubble[] ring)
        {
            var val_2;
            var val_3;
            val_2 = 0;
            val_3 = 0;
            goto label_0;
            label_4:
            InkWars.Model.Model_Bubble val_2 = ring[0];
            val_2 = 1;
            label_0:
            if(val_2 < ring.Length)
            {
                goto label_4;
            }
            
            return (int)(ring[0x0][0].BubbleType != 0) ? (val_3 + 1) : (val_3);
        }
        internal void Shoot(InkWars.Model.BubbleTypes type, InkWars.Model.BubbleTypes nextBubble = 0, bool sendOverNetwork = True, float pingTime = -1)
        {
            var val_22;
            InkWars.Model.BubbleTypes val_23;
            var val_24;
            var val_25;
            var val_26;
            InkWars.Model.AimTarget val_28;
            var val_29;
            InkWars.Model.BubbleTypes val_30;
            var val_31;
            val_22 = nextBubble;
            InkWars.Model.Model_Player val_2 = this.Model.GetPlayer(PlayerNumber:  1 - this.ID);
            if( && (this.StunnedTime > 0f))
            {
                    UnityEngine.MonoBehaviour.print(message:  "Stunned time issue!");
                this.StunnedTime = 0f;
                if(val_22 == 0)
            {
                    val_23 = this.GetNextBubble(otherPlayer:  val_2);
            }
            
                this.LoadedBubble = val_23;
                this.Switch(manualSwitch:  true);
                return;
            }
            
            if(this.ID == 0)
            {
                goto label_5;
            }
            
            label_73:
            val_24 = null;
            val_24 = null;
            if((Character_GlobalInfo.gameMode == 3) && (this._aimTarget != 3))
            {
                    this.Model.PuzzleBubblesLeft = UnityEngine.Mathf.Max(a:  this.Model.PuzzleBubblesLeft - 1, b:  0);
            }
            
            if(((this.Model.Feature_Powerup == 1) && (this.RevengeSuperState == 2)) && (this.RevengeSuperType == type))
            {
                    this.RevengeSuperAnimate(type:  type);
                return;
            }
            
            this.TargetBubbles.Item[this.nextTargetPoolIndex].SetAs_Target(model_Player:  this, type:  type, aimTarget:  this._aimTarget, poolIndex:  this.nextTargetPoolIndex);
            InkWars.Model.Model_Bubble val_8 = this.TargetBubbles.Item[this.nextTargetPoolIndex];
            if(pingTime == (-1f))
            {
                goto label_20;
            }
            
            float val_9 = UnityEngine.Mathf.Clamp(value:  pingTime, min:  0f, max:  0.5f);
            if(val_8 == null)
            {
                goto label_23;
            }
            
            val_25 = val_8;
            val_8.TimePassed = val_9;
            goto label_24;
            label_5:
            val_26 = null;
            val_26 = null;
            DataStructs.UserDataDictionary.Stats.IncreaseTotalBubbleShoot();
            if((type - 8) > 8)
            {
                goto label_73;
            }
            
            var val_22 = 40830616;
            val_22 = (40830616 + ((type - 8)) << 2) + val_22;
            goto (40830616 + ((type - 8)) << 2 + 40830616);
            label_23:
            val_25 = val_8;
            val_8.TimePassed = val_9;
            label_24:
            UnityEngine.MonoBehaviour.print(message:  "Bubble delta " + val_8 + 68(val_8 + 68));
            label_20:
            int val_23 = this.nextTargetPoolIndex;
            val_28 = this._aimTarget;
            val_23 = val_23 + 1;
            val_23 = val_23 - 0;
            this.nextTargetPoolIndex = val_23;
            if(val_28 != 3)
            {
                goto label_33;
            }
            
            if(val_8 == null)
            {
                goto label_34;
            }
            
            val_8.Trashed = true;
            goto label_35;
            label_33:
            val_29 = 1152921529283455468;
            goto label_36;
            label_34:
            val_8.Trashed = true;
            label_35:
            val_8.customPopType = "Trashed";
            val_28 = this._aimTarget;
            val_29 = 1152921529283455476;
            label_36:
            InkWars.Model.AimTarget val_11 = val_28 + 1;
            mem[1152921529283455476] = null;
            if(val_11 > 8)
            {
                goto label_38;
            }
            
            var val_24 = 1;
            val_24 = val_24 << val_11;
            val_24 = val_24 & 273;
            if(val_24 == 0)
            {
                goto label_38;
            }
            
            label_75:
            this.ReloadingTime = this.FullReloadTime;
            if(val_22 == 0)
            {
                    val_30 = this.GetNextBubble(otherPlayer:  val_2);
            }
            
            this.LoadedBubble = val_30;
            InkWars.Model.Model_Events.Instance.Event_Shot(timeStamp:  this.Model.GameTime, Id:  this.ID, aimTarget:  this._aimTarget, shotBubble:  type, loadedBubble:  this.LoadedBubble, spareBubble:  this.SpareBubble, sendOverNetwork:  sendOverNetwork);
            if(this.LoadedBubble != 7)
            {
                    this.Switch(manualSwitch:  false);
            }
            
            this.AimTarget = 0;
            this.TryShoot = false;
            return;
            label_38:
            if((InkWars.Model.Model_Player.GetAimedAtBubble(aimTarget:  val_28, player:  val_2)) == 0)
            {
                goto label_43;
            }
            
            if(type != 7)
            {
                goto label_44;
            }
            
            val_31 = 1;
            if(val_8 != null)
            {
                goto label_56;
            }
            
            goto label_46;
            label_43:
            if((type == 7) || ((GenericFunctions.IsSuperType(bubbleType:  type)) == true))
            {
                goto label_75;
            }
            
            InkWars.Model.BubbleTypes val_17 = InkWars.Model.Model_Player.GetAimedAtBubble(aimTarget:  this._aimTarget, player:  this);
            if(val_17 > 14)
            {
                goto label_50;
            }
            
            var val_25 = 1;
            val_25 = val_25 << val_17;
            val_25 = val_25 & 28800;
            if(val_25 == 0)
            {
                goto label_50;
            }
            
            val_8.ShouldAddToOwnGrid = false;
            goto label_75;
            label_44:
            val_31 = 1;
            if(val_8 != null)
            {
                goto label_56;
            }
            
            label_46:
            label_56:
            val_8.ShouldHitOpponentBubble = (type == 12) ? 1 : 0;
            goto label_75;
            label_50:
            val_8.ShouldAddToOwnGrid = (val_17 != type) ? 1 : 0;
            goto label_75;
        }
        public void RevengeSuperAnimate(InkWars.Model.BubbleTypes type)
        {
            InkWars.Model.Model_Core val_2;
            float val_3;
            this.RevengeSuperType = 0;
            this.RevengeSuperLevel = 0f;
            val_2 = this.Model;
            this.RevengeSuperState = 3;
            if(val_2 != null)
            {
                    val_3 = this.Model.PauseForRevengeSuper;
            }
            else
            {
                    val_2 = 68;
                val_3 = 7.006492E-45f;
            }
            
            float val_2 = 2f;
            val_2 = val_3 + val_2;
            mem[68] = val_2;
            InkWars.Model.Model_Events.Instance.Event_RevengeSuper(id:  this.ID, revengeSuperType:  type, state:  3);
            this.RevengerSuperAimTarget = this._aimTarget;
        }
        private static InkWars.Model.BubbleTypes GetAimedAtBubble(InkWars.Model.AimTarget aimTarget, InkWars.Model.Model_Player player)
        {
            if(aimTarget > 6)
            {
                    return 0;
            }
            
            var val_4 = 40830652 + (aimTarget) << 2;
            val_4 = val_4 + 40830652;
            goto (40830652 + (aimTarget) << 2 + 40830652);
        }
        private static InkWars.Model.BubbleTypes GetFirstBubble(InkWars.Model.Model_Bubble[] Ring, bool fromTop)
        {
            var val_1;
            var val_2;
            var val_4;
            val_1 = Ring;
            if(fromTop == false)
            {
                goto label_0;
            }
            
            val_2 = 0;
            goto label_1;
            label_6:
            val_2 = 1;
            label_1:
            if(val_2 >= Ring.Length)
            {
                goto label_9;
            }
            
            InkWars.Model.Model_Bubble val_1 = val_1[1];
            if(Ring[0x1][0].BubbleType == 0)
            {
                goto label_6;
            }
            
            goto label_7;
            label_0:
            label_12:
            val_2 = Ring.Length - 1;
            if((val_2 & 2147483648) != 0)
            {
                goto label_9;
            }
            
            InkWars.Model.Model_Bubble val_2 = val_1[(long)val_2];
            if((Ring[(long)(int)((Ring.Length - 1))][0].BubbleType) == 0)
            {
                goto label_12;
            }
            
            label_7:
            val_1 = mem[Ring[(long)(int)((Ring.Length - 1))] + 32];
            val_1 = Ring[(long)(int)((Ring.Length - 1))] + 32;
            val_4 = mem[Ring[(long)(int)((Ring.Length - 1))] + 32 + 16];
            val_4 = Ring[(long)(int)((Ring.Length - 1))] + 32 + 16;
            return (InkWars.Model.BubbleTypes)val_4;
            label_9:
            val_4 = 0;
            return (InkWars.Model.BubbleTypes)val_4;
        }
        public bool HandleBubbleCollision(float i, int ringIndex, bool shootingAtTop, InkWars.Model.Model_Bubble bubble, InkWars.Model.Model_Player targetPlayer)
        {
            var val_85;
            InkWars.Model.Model_Player val_97;
            InkWars.Model.Model_Bubble val_98;
            InkWars.Model.BubbleTypes val_99;
            int val_100;
            float val_101;
            var val_102;
            var val_103;
            var val_105;
            var val_106;
            var val_107;
            InkWars.Model.Model_Bubble val_108;
            var val_109;
            var val_110;
            var val_111;
            var val_112;
            var val_113;
            InkWars.Model.Player val_114;
            var val_115;
            InkWars.Model.BubbleTypes val_116;
            InkWars.Model.Model_Bubble[] val_117;
            int val_118;
            var val_119;
            var val_120;
            var val_121;
            int val_122;
            var val_123;
            float val_124;
            float val_125;
            var val_126;
            float val_127;
            var val_128;
            var val_129;
            var val_130;
            float val_131;
            var val_132;
            val_97 = targetPlayer;
            val_98 = bubble;
            val_99 = shootingAtTop;
            val_100 = ringIndex;
            val_101 = i;
            val_102 = this;
            if(val_100 == 0)
            {
                goto label_1;
            }
            
            if(val_100 == 1)
            {
                goto label_2;
            }
            
            if(val_100 != 2)
            {
                goto label_3;
            }
            
            if(val_97 != null)
            {
                goto label_7;
            }
            
            goto label_7;
            label_2:
            if(val_97 != null)
            {
                goto label_7;
            }
            
            goto label_7;
            label_1:
            label_7:
            val_103 = mem[targetPlayer.OuterRing];
            if(val_103 != 0)
            {
                goto label_9;
            }
            
            goto label_10;
            label_3:
            val_103 = 0;
            label_10:
            label_9:
            var val_93 = 10260432;
            val_93 = val_93 - 1;
            float val_94 = (float)val_93;
            val_94 = val_94 * val_101;
            int val_1 = UnityEngine.Mathf.FloorToInt(f:  val_94);
            var val_95 = ~val_1;
            val_95 = val_95 + 10260432;
            var val_2 = (val_99 != true) ? (val_1) : (val_95);
            var val_3 = val_103 + (((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3);
            val_105 = mem[(val_103 + ((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3) + 32];
            val_105 = (val_103 + ((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3) + 32;
            if(val_105 == 0)
            {
                goto label_17;
            }
            
            if(val_2 >= 10260432)
            {
                    val_105 = mem[(val_103 + ((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3) + 32];
                val_105 = (val_103 + ((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3) + 32;
                if(val_105 == 0)
            {
                goto label_198;
            }
            
            }
            
            if(((val_103 + ((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3) + 32 + 16) == 0)
            {
                goto label_17;
            }
            
            if(((val_103 + ((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3) + 32 + 16) != 7)
            {
                goto label_20;
            }
            
            if((bubble.BubbleType > 6) || ((val_2 & 2147483648) != 0))
            {
                goto label_31;
            }
            
            var val_96 = val_2;
            label_30:
            if(val_96 >= 10260432)
            {
                goto label_27;
            }
            
            var val_5 = val_103 + (((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3);
            if(((val_103 + ((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3) + 32 + 16) != 7)
            {
                goto label_27;
            }
            
            val_96 = val_96 + (((val_99 & true) != 0) ? (-1) : 1);
            mem2[0] = bubble.BubbleType;
            if((val_96 & 2147483648) == 0)
            {
                goto label_30;
            }
            
            label_27:
            val_100 = val_100;
            val_106 = val_2;
            goto label_31;
            label_17:
            val_107 = 0;
            return (bool)val_107;
            label_20:
            if(val_98 == null)
            {
                goto label_65;
            }
            
            label_31:
            label_65:
            if((bubble.BubbleType - 9) > 7)
            {
                goto label_34;
            }
            
            var val_97 = 40830680 + ((bubble.BubbleType - 9)) << 2;
            val_97 = val_97 + 40830680;
            goto (40830680 + ((bubble.BubbleType - 9)) << 2 + 40830680);
            label_34:
            if((bubble.BubbleType != ((val_103 + ((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3) + 32 + 16)) && (bubble.BubbleType != 7))
            {
                    if(((val_103 + ((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3) + 32.IsBubbleSPD()) == false)
            {
                goto label_62;
            }
            
            }
            
            if(val_97 == val_102)
            {
                goto label_63;
            }
            
            goto label_64;
            label_63:
            InkWars.Model.Model_Events val_18 = InkWars.Model.Model_Events.Instance;
            if(bubble.ShouldAddToOwnGrid == false)
            {
                goto label_70;
            }
            
            new PlayerMessage() = new PlayerMessage(PlayerID:  1 - targetPlayer.ID, HitCount:  0, ComboType:  0, ComboTechnique:  3);
            val_18.Event_Message(message:  new PlayerMessage());
            targetPlayer.Model.GetPlayer(PlayerNumber:  1 - targetPlayer.ID).RecordTechnique(tech:  3);
            InkWars.Model.Model_Events.Instance.Event_Message(message:  new PlayerMessage(PlayerID:  targetPlayer.ID, HitCount:  0, ComboType:  0, ComboTechnique:  8));
            val_97.RecordTechnique(tech:  8);
            label_64:
            var val_25 = ((val_99 & true) != 0) ? (-0) : 0;
            val_25 = val_2 + val_25;
            if(((val_103 + ((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3) + 32.Damage(responsiblePlayer:  this.ID, forceKill:  false, isCrossBubbleHit:  false)) == false)
            {
                goto label_79;
            }
            
            val_108 = (val_103 + ((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3) + 32;
            this.PoppedBubblesRef.Add(item:  val_108);
            if(this.PoppedBubblesRef_DelayCount == null)
            {
                goto label_82;
            }
            
            val_109 = this.PoppedBubblesRef_DelayCount.Count;
            goto label_83;
            label_79:
            val_98 = val_98;
            val_108 = (val_103 + ((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3) + 32;
            val_110 = 0;
            goto label_84;
            label_82:
            val_109 = 0.Count;
            label_83:
            this.PoppedBubblesRef_DelayCount.Add(item:  val_109 + 1);
            val_98 = val_98;
            val_110 = 1;
            label_84:
            var val_98 = 0;
            int val_33 = ((val_99 & true) != 0) ? (-1) : 1;
            val_98 = val_2 - val_98;
            goto label_85;
            label_101:
            var val_34 = val_2 + val_33;
            if(((val_34 & 2147483648) != 0) || (val_34 >= 10260432))
            {
                goto label_102;
            }
            
            var val_35 = val_103 + (((long)(int)((val_99 != true ? val_1 : (~(val_1) + 10260432) + (val_99 & true)!=0 ?  (-1) : 1))) << 3);
            if(((val_103 + ((long)(int)((val_99 != true ? val_1 : (~(val_1) + 10260432) + (val_99 & true)!=0 ?  (-1) : 1))) << 3) + 32 + 16) != ((val_103 + ((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3) + 32 + 16))
            {
                goto label_90;
            }
            
            var val_99 = ((0 == val_2) ? 1 : 0) | ((val_25 == 0) ? 1 : 0);
            val_99 = val_99 | ((val_98 == val_33) ? 1 : 0);
            if(((val_103 + ((long)(int)((val_99 != true ? val_1 : (~(val_1) + 10260432) + (val_99 & true)!=0 ?  (-1) : 1))) << 3) + 32.Damage(responsiblePlayer:  this.ID, forceKill:  false, isCrossBubbleHit:  false)) == false)
            {
                goto label_168;
            }
            
            val_102 = val_102;
            val_108 = (val_103 + ((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3) + 32;
            val_97 = val_97;
            this.PoppedBubblesRef.Add(item:  (val_103 + ((long)(int)((val_99 != true ? val_1 : (~(val_1) + 10260432) + (val_99 & true)!=0 ?  (-1) : 1))) << 3) + 32);
            val_106 = val_2;
            this.PoppedBubblesRef_DelayCount.Add(item:  (UnityEngine.Mathf.Abs(value:  val_33)) + 1);
            val_98 = val_98;
            val_33 = val_33 + val_33;
            label_85:
            if(val_108.IsBubbleSPD() == false)
            {
                goto label_101;
            }
            
            goto label_102;
            label_90:
            val_102 = val_102;
            val_97 = val_97;
            label_102:
            val_100 = val_100;
            label_168:
            val_103 = 1152921504848166912;
            label_202:
            if((1 & 1) != 0)
            {
                    val_111 = 92;
                val_100 = val_100;
                mem[92] = 2;
                val_99 = mem[bubble + 16];
                val_99 = bubble + 16;
                val_112 = val_98;
                val_113 = val_102;
                val_114 = this.ID;
                val_115 = 1;
            }
            else
            {
                    val_111 = val_98;
                var val_100 = bubble + 92;
                val_112 = val_98;
                val_113 = val_102;
                val_99 = bubble + 92 + -76;
                val_100 = 2 + val_100;
                mem2[0] = val_100;
                val_114 = this.ID;
                val_115 = 0;
            }
            
            val_107 = 0;
            if((val_112.Damage(responsiblePlayer:  val_114, forceKill:  false, isCrossBubbleHit:  false)) == false)
            {
                    return (bool)val_107;
            }
            
            int val_44 = bubble + 92;
            if((val_99 & 1) == 0)
            {
                goto label_118;
            }
            
            if((bubble + 92) >= 2)
            {
                    bool val_45 = true;
            }
            
            int val_43 = UnityEngine.Mathf.Abs(value:  0 - val_2);
            if(val_100 == 2)
            {
                goto label_111;
            }
            
            val_116 = (val_103 + ((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3) + 32 + 16;
            if(val_100 == 1)
            {
                goto label_112;
            }
            
            if((val_100 != 0) || ((this.AttemptBridgePop(ring:  targetPlayer.MiddleRing, bubble:  0, bridge:  6, currentDelayChain:  val_43, bubbleType:  val_116, poptotal: ref  val_44, crosslink: ref  val_45)) == false))
            {
                goto label_118;
            }
            
            val_117 = targetPlayer.InnerRing;
            val_118 = val_43 + 1;
            val_119 = 4;
            goto label_116;
            label_111:
            val_116 = (val_103 + ((long)(int)(val_99 != true ? val_1 : (~(val_1) + 10260432))) << 3) + 32 + 16;
            if((this.AttemptBridgePop(ring:  targetPlayer.MiddleRing, bubble:  0, bridge:  6, currentDelayChain:  val_43, bubbleType:  val_116, poptotal: ref  val_44, crosslink: ref  val_45)) == false)
            {
                goto label_118;
            }
            
            val_117 = targetPlayer.OuterRing;
            val_118 = val_43 + 1;
            val_119 = 8;
            label_116:
            var val_49 = ((this.AttemptBridgePop(ring:  val_117, bubble:  0, bridge:  8, currentDelayChain:  val_118, bubbleType:  val_116, poptotal: ref  val_44, crosslink: ref  val_45)) != true) ? (1 + 1) : 1;
            goto label_146;
            label_118:
            val_120 = 0;
            label_146:
            InkWars.Model.Model_Player val_51 = this.Model.GetPlayer(PlayerNumber:  1 - this.ID);
            if(((this.Model.Feature_BattleEnhancer != false) && (this.BattleEnhancerState == 1)) && (this.BattleEnhancerType == 3))
            {
                    int val_101 = val_44;
                val_121 = 1;
                val_101 = val_101 + 1;
            }
            else
            {
                    if(1 != 0)
            {
                    if(((val_51.Model.Feature_BattleEnhancer != false) && (val_51.BattleEnhancerState == 1)) && (val_51.BattleEnhancerType == 3))
            {
                    int val_102 = val_101;
                val_102 = val_102 + 1;
                int val_58 = val_102;
            }
            
                val_121 = 1;
            }
            else
            {
                    val_121 = 0;
            }
            
            }
            
            val_122 = val_58;
            var val_52 = (val_97 != val_102) ? 1 : 0;
            val_52 = val_121 | val_52;
            val_115 = 0;
            if((val_52 != 1) || (val_122 < 3))
            {
                goto label_134;
            }
            
            val_123 = null;
            HitComboType val_55 = (val_120 < 1) ? ((val_45 != 0) ? (1 + 1) : 1) : ((val_45 != 0) ? (3 + 1) : 3);
            val_123 = null;
            System.Single[] val_56 = InkWars.Model.Model_Constants.StunTime + ((this.AttackLevel) << 2);
            val_124 = mem[(InkWars.Model.Model_Constants.StunTime + (this.AttackLevel) << 2) + 32];
            val_124 = (InkWars.Model.Model_Constants.StunTime + (this.AttackLevel) << 2) + 32;
            var val_57 = val_55 & 7;
            val_125 = val_124 * (float)val_122;
            if(val_57 == 4)
            {
                goto label_139;
            }
            
            if(val_57 == 3)
            {
                goto label_140;
            }
            
            if(val_57 != 2)
            {
                goto label_141;
            }
            
            val_126 = null;
            val_126 = null;
            val_127 = 1152921505152749632;
            goto label_149;
            label_112:
            bool val_59 = this.AttemptBridgePop(ring:  targetPlayer.OuterRing, bubble:  0, bridge:  8, currentDelayChain:  val_43, bubbleType:  val_116, poptotal: ref  val_58, crosslink: ref  val_45);
            val_116 = val_59;
            var val_62 = ((this.AttemptBridgePop(ring:  targetPlayer.InnerRing, bubble:  0, bridge:  4, currentDelayChain:  val_43, bubbleType:  val_116, poptotal: ref  val_58, crosslink: ref  val_45)) != true) ? ((val_59 != true) ? (1 + 1) : 1) : (val_116);
            goto label_146;
            label_139:
            val_128 = null;
            val_128 = null;
            val_127 = 1152921505152749640;
            goto label_149;
            label_140:
            val_129 = null;
            val_129 = null;
            val_127 = 1152921505152749636;
            label_149:
            val_125 = val_125 * val_127;
            label_141:
            if(val_97 != null)
            {
                    val_130 = val_97;
                val_131 = targetPlayer.ReloadingTime;
            }
            else
            {
                    val_130 = 72;
                val_131 = 0f;
            }
            
            mem[72] = 0;
            val_125 = val_125 + val_131;
            float val_64 = targetPlayer.<buff>k__BackingField.GetBuffValueSec(aNewType:  3);
            val_64 = (this.<buff>k__BackingField.GetBuffValueSec(aNewType:  2)) - val_64;
            val_64 = val_125 + val_64;
            val_64 = targetPlayer.StunnedTime + val_64;
            targetPlayer.StunnedTime = val_64;
            val_101 = targetPlayer.StunnedTime;
            InkWars.Model.Model_Events.Instance.Event_Stunned(id:  targetPlayer.ID, stunLevel:  val_101, isRevengeStun:  false);
            val_114 = this.ID;
            InkWars.Model.Model_Events.Instance.Event_Message(message:  new PlayerMessage(PlayerID:  val_114, HitCount:  val_58, ComboType:  val_55, ComboTechnique:  0));
            val_122 = val_58;
            label_134:
            if((val_97 != val_102) && (val_122 >= 1))
            {
                    float val_103 = (float)val_122;
                val_103 = val_103 * 3f;
                this.AddToRevengeSuper(amount:  val_103, force:  false);
                val_122 = val_58;
                if(val_122 >= 1)
            {
                    var val_104 = 0;
                val_101 = 2f;
                do
            {
                val_97.AddToRevengeSuper(amount:  8f, force:  false);
                float val_69 = UnityEngine.Mathf.Max(a:  val_101, b:  8f + (-2f));
                val_122 = val_58;
                val_104 = val_104 + 1;
            }
            while(val_104 < val_122);
            
            }
            
            }
            
            this.AddScoreAndPopDelay(popTotal:  val_122, type:  val_99, hitCombo:  val_55, isOwnGrid:  (val_97 == val_102) ? 1 : 0);
            if(val_97 != val_102)
            {
                    mem[1152921529284902896] = (((bubble + 92 + 1) + 1) + UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished);
            }
            else
            {
                    mem2[0] = (((bubble + 92 + 1) + 1) + UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished);
            }
            
            val_107 = 1;
            return (bool)val_107;
            label_62:
            var val_71 = ((val_99 & true) != 0) ? (-0) : 0;
            val_71 = val_2 + val_71;
            if(((val_71 & 2147483648) != 0) || (val_71 >= 10260432))
            {
                goto label_170;
            }
            
            var val_72 = val_103 + (((long)(int)((val_99 != true ? val_1 : (~(val_1) + 10260432) + (val_99 & true)!=0 ?  (-0) : 0))) << 3);
            mem2[0] = bubble.BubbleType;
            bubble.AddedToGrid = true;
            if(val_97 == val_102)
            {
                goto label_173;
            }
            
            InkWars.Model.Model_Events val_73 = InkWars.Model.Model_Events.Instance;
            if(bubble.ShouldHitOpponentBubble == false)
            {
                goto label_174;
            }
            
            new PlayerMessage() = new PlayerMessage(PlayerID:  1 - this.ID, HitCount:  0, ComboType:  0, ComboTechnique:  2);
            val_73.Event_Message(message:  new PlayerMessage());
            this.Model.GetPlayer(PlayerNumber:  1 - this.ID).RecordTechnique(tech:  2);
            InkWars.Model.Model_Events.Instance.Event_Message(message:  new PlayerMessage(PlayerID:  this.ID, HitCount:  0, ComboType:  0, ComboTechnique:  7));
            val_132 = 7;
            goto label_179;
            label_70:
            new PlayerMessage() = new PlayerMessage(PlayerID:  targetPlayer.ID, HitCount:  0, ComboType:  0, ComboTechnique:  6);
            val_18.Event_Message(message:  new PlayerMessage());
            val_97.RecordTechnique(tech:  6);
            goto label_64;
            label_170:
            val_71 = val_71 + 1;
            mem[1152921529284902904] = val_71;
            goto label_202;
            label_173:
            InkWars.Model.Model_Player val_82 = targetPlayer.Model.GetPlayer(PlayerNumber:  1 - targetPlayer.ID);
            List.Enumerator<T> val_83 = val_82.TargetBubbles.GetEnumerator();
            label_191:
            if(((-1091760192) & 1) == 0)
            {
                goto label_186;
            }
            
            System.Type val_86 = val_85.InitialType;
            if(((val_86._impl == 0) || (val_86._impl == 0)) || (val_100 != bubble.AimTarget))
            {
                goto label_191;
            }
            
            val_85.Add(driver:  public System.Void List.Enumerator<InkWars.Model.Model_Bubble>::Dispose(), rectTransform:  0, drivenProperties:  bubble);
            mem2[0] = 53472721;
            goto label_202;
            label_174:
            new PlayerMessage() = new PlayerMessage(PlayerID:  this.ID, HitCount:  0, ComboType:  0, ComboTechnique:  9);
            val_73.Event_Message(message:  new PlayerMessage());
            InkWars.Model.Model_Events.Instance.Event_Message(message:  new PlayerMessage(PlayerID:  1 - this.ID, HitCount:  0, ComboType:  0, ComboTechnique:  4));
            val_132 = 9;
            label_179:
            this.RecordTechnique(tech:  9);
            mem[1152921529284902904] = 2;
            goto label_202;
            label_186:
            val_85.Add(driver:  public System.Void List.Enumerator<InkWars.Model.Model_Bubble>::Dispose(), rectTransform:  0, drivenProperties:  bubble);
            goto label_200;
            label_198:
            if(0 != 1)
            {
                goto label_199;
            }
            
            val_85.Add(driver:  public System.Void List.Enumerator<InkWars.Model.Model_Bubble>::Dispose(), rectTransform:  0, drivenProperties:  bubble);
            label_200:
            InkWars.Model.Model_Events.Instance.Event_Message(message:  new PlayerMessage(PlayerID:  targetPlayer.ID, HitCount:  val_58, ComboType:  0, ComboTechnique:  1));
            val_97.RecordTechnique(tech:  1);
            mem2[0] = 1152921505103650817;
            goto label_202;
            label_199:
        }
        private void RainbowRing(InkWars.Model.BubbleTypes fromBubbleType, InkWars.Model.BubbleTypes toBubbleType, InkWars.Model.Model_Bubble[] ring)
        {
            goto label_0;
            label_11:
            InkWars.Model.Model_Bubble val_1 = ring[0];
            if(ring[0x0][0].BubbleType == fromBubbleType)
            {
                    mem2[0] = 1;
                mem2[0] = toBubbleType;
                mem2[0] = 1;
            }
            
            0 = 1;
            label_0:
            if(0 < ring.Length)
            {
                goto label_11;
            }
        
        }
        private void InfectRing(int infectDir, InkWars.Model.BubbleTypes bubbleType, InkWars.Model.Model_Bubble[] ring)
        {
            var val_3;
            var val_4;
            var val_5;
            if(infectDir > 0)
            {
                    val_3 = 0;
            }
            else
            {
                    val_3 = ring.Length - 1;
                if((val_3 & 2147483648) != 0)
            {
                    return;
            }
            
            }
            
            val_4 = 0;
            do
            {
                if(val_3 >= ring.Length)
            {
                    return;
            }
            
                InkWars.Model.Model_Bubble val_3 = ring[(long)val_3];
                val_5 = val_4 | (((ring[(long)(int)((ring.Length - 1))][0].BubbleType) == bubbleType) ? 1 : 0);
                if((ring[(long)(int)((ring.Length - 1))][0].BubbleType) != bubbleType)
            {
                    if((val_4 ^ 1 & 1) == 0)
            {
                    mem2[0] = bubbleType;
                val_5 = 0;
                mem2[0] = 1;
            }
            
            }
            
                val_3 = val_3 + infectDir;
                val_4 = val_5;
            }
            while((val_3 & 2147483648) == 0);
        
        }
        private void AddScoreAndPopDelay(int popTotal, InkWars.Model.BubbleTypes type, HitComboType hitCombo, bool isOwnGrid)
        {
            HitComboType val_11;
            System.Collections.Generic.List<InkWars.Model.Model_Bubble> val_12;
            InkWars.Model.Player val_13;
            var val_14;
            var val_15;
            InkWars.Model.Player val_16;
            var val_17;
            var val_18;
            var val_19;
            int val_21;
            var val_22;
            val_11 = hitCombo;
            val_12 = type;
            if(val_12 == 9)
            {
                goto label_1;
            }
            
            if(val_12 != 10)
            {
                goto label_2;
            }
            
            val_13 = 1152921528297644816;
            val_14 = 0;
            goto label_5;
            label_12:
            val_15 = null;
            val_15 = null;
            val_16 = this.ID;
            float val_10 = (float)this.PoppedBubblesRef_DelayCount.Item[0];
            val_10 = InkWars.Model.Model_Constants.BubblePopSubsequentDelay * val_10;
            this.PoppedBubblesRef.Item[0].SetScoreAndPopDelay(score:  InkWars.Model.Model_Constants.Score_BubblePop_Eraser, popDelay:  val_10, scoreTarget:  val_16, comboType:  val_11);
            val_14 = 1;
            label_5:
            val_12 = this.PoppedBubblesRef;
            if(val_14 < val_12.Count)
            {
                goto label_12;
            }
            
            goto label_25;
            label_1:
            val_13 = 1152921528297644816;
            val_17 = 0;
            goto label_16;
            label_23:
            val_18 = null;
            val_18 = null;
            val_16 = this.ID;
            float val_11 = (float)this.PoppedBubblesRef_DelayCount.Item[0];
            val_11 = InkWars.Model.Model_Constants.BubblePopSubsequentDelay * val_11;
            this.PoppedBubblesRef.Item[0].SetScoreAndPopDelay(score:  InkWars.Model.Model_Constants.Score_BubblePop_CannonBall, popDelay:  val_11, scoreTarget:  val_16, comboType:  val_11);
            val_17 = 1;
            label_16:
            val_12 = this.PoppedBubblesRef;
            if(val_17 < val_12.Count)
            {
                goto label_23;
            }
            
            goto label_25;
            label_2:
            if(popTotal >= 1)
            {
                    do
            {
                val_19 = null;
                val_19 = null;
                if(isOwnGrid != false)
            {
                    val_21 = InkWars.Model.Model_Constants.Score_BubblePop_Suicide;
            }
            else
            {
                    val_21 = InkWars.Model.Model_Constants.Score_BubblePop_Base + (InkWars.Model.Model_Constants.Score_BubblePop_ComboAdd * 0);
            }
            
                val_16 = this.PoppedBubblesRef;
                if(0 < val_16.Count)
            {
                    val_16 = this.PoppedBubblesRef.Item[0];
                val_22 = null;
                val_22 = null;
                val_13 = this.ID;
                float val_12 = (float)this.PoppedBubblesRef_DelayCount.Item[0];
                val_12 = InkWars.Model.Model_Constants.BubblePopSubsequentDelay * val_12;
                val_16.SetScoreAndPopDelay(score:  val_21, popDelay:  val_12, scoreTarget:  val_13, comboType:  val_11);
            }
            
                val_12 = 0 + 1;
            }
            while(popTotal != val_12);
            
            }
            
            label_25:
            if(val_11 <= 4)
            {
                    var val_13 = 40830712 + (hitCombo) << 2;
                val_13 = val_13 + 40830712;
            }
            else
            {
                    this.PoppedBubblesRef.Clear();
                this.PoppedBubblesRef_DelayCount.Clear();
            }
        
        }
        private void RecordTechnique(Techniques tech)
        {
            var val_2;
            GameMode val_3;
            val_2 = null;
            val_2 = null;
            val_3 = Character_GlobalInfo.gameMode;
            if(val_3 != 6)
            {
                    val_3 = Character_GlobalInfo.gameMode;
                if(val_3 != 10)
            {
                    return;
            }
            
            }
            
            if(this.ID != 0)
            {
                    return;
            }
            
            this.TechRecordForView = tech;
            if((tech - 1) > 7)
            {
                    return;
            }
            
            var val_2 = 40830732 + ((tech - 1)) << 2;
            val_2 = val_2 + 40830732;
            goto (40830732 + ((tech - 1)) << 2 + 40830732);
        }
        private int PopAllInRing(InkWars.Model.BubbleTypes poppedType, InkWars.Model.Model_Bubble[] ring)
        {
            var val_3;
            var val_4;
            InkWars.Model.Model_Bubble val_5;
            val_3 = 0;
            val_4 = 0;
            goto label_1;
            label_10:
            val_5 = ring[0];
            if((ring[0x0][0].BubbleType == poppedType) && ((val_5.Damage(responsiblePlayer:  this.ID, forceKill:  false, isCrossBubbleHit:  false)) != false))
            {
                    if((System.String.IsNullOrEmpty(value:  ring[0x0][0].customPopType)) != false)
            {
                    ring[0x0][0].customPopType = "PopByEraser";
            }
            
                this.PoppedBubblesRef.Add(item:  val_5);
                val_5 = this.PoppedBubblesRef_DelayCount;
                val_5.Add(item:  0);
                val_4 = 1;
            }
            
            val_3 = 1;
            label_1:
            if(val_3 < ring.Length)
            {
                goto label_10;
            }
            
            return (int)val_4;
        }
        private int PopAll(InkWars.Model.BubbleTypes poppedType, InkWars.Model.Model_Player targetPlayer)
        {
            var val_7;
            var val_8;
            if(targetPlayer != null)
            {
                    val_7 = this.PopAllInRing(poppedType:  poppedType, ring:  targetPlayer.OuterRing);
                val_8 = this.PopAllInRing(poppedType:  poppedType, ring:  targetPlayer.MiddleRing);
            }
            else
            {
                    val_7 = this.PopAllInRing(poppedType:  poppedType, ring:  1);
                val_8 = this.PopAllInRing(poppedType:  poppedType, ring:  48980696);
            }
            
            int val_5 = this.PopAllInRing(poppedType:  poppedType, ring:  targetPlayer.InnerRing);
            val_5 = (val_7 + val_8) + val_5;
            return (int)val_5;
        }
        private bool AttemptBridgePop(InkWars.Model.Model_Bubble[] ring, InkWars.Model.Model_Bubble bubble, int bridge, int currentDelayChain, InkWars.Model.BubbleTypes bubbleType, ref int poptotal, ref bool crosslink)
        {
            var val_11;
            var val_12;
            InkWars.Model.Model_Bubble val_13;
            InkWars.Model.Model_Bubble val_14;
            var val_15;
            var val_16;
            val_11 = 1152921529287358144;
            val_12 = 1152921529287354080;
            var val_12 = (long)bridge;
            val_13 = ring[val_12];
            if(ring[(long)(int)(bridge)][0].BubbleType != bubbleType)
            {
                goto label_4;
            }
            
            val_11 = 0;
            if((bridge & 2147483648) != 0)
            {
                goto label_11;
            }
            
            val_13 = currentDelayChain + 1;
            label_17:
            val_14 = ring[val_12];
            if(ring[(long)(int)(bridge)][0].BubbleType != bubbleType)
            {
                goto label_11;
            }
            
            val_14 = ring[val_12];
            if((val_14.Damage(responsiblePlayer:  this.ID, forceKill:  false, isCrossBubbleHit:  false)) == false)
            {
                goto label_11;
            }
            
            this.PoppedBubblesRef.Add(item:  ring[val_12]);
            val_14 = this.PoppedBubblesRef_DelayCount;
            val_14.Add(item:  val_13 + (UnityEngine.Mathf.Abs(value:  0)));
            val_12 = val_12 - 1;
            val_11 = val_11 + 1;
            if(val_12 > 0)
            {
                goto label_17;
            }
            
            label_11:
            if((bridge + 1) >= ring.Length)
            {
                goto label_18;
            }
            
            int val_13 = currentDelayChain;
            var val_14 = 1;
            val_15 = val_11;
            val_13 = val_13 + 1;
            label_30:
            val_12 = (long)bridge + val_14;
            val_14 = ring[val_12];
            if((ring[(long)(int)((bridge + 1))][0].BubbleType) != bubbleType)
            {
                goto label_21;
            }
            
            val_14 = mem[ring[(long)(int)((bridge + 1))] + 32];
            val_14 = ring[(long)(int)((bridge + 1))] + 32;
            if((val_14.Damage(responsiblePlayer:  this.ID, forceKill:  false, isCrossBubbleHit:  false)) == false)
            {
                goto label_33;
            }
            
            this.PoppedBubblesRef.Add(item:  ring[(long)(int)((bridge + 1))] + 32);
            val_14 = this.PoppedBubblesRef_DelayCount;
            val_14.Add(item:  val_13 + (UnityEngine.Mathf.Abs(value:  1)));
            val_14 = val_14 + 1;
            val_15 = val_15 + 1;
            if((bridge + val_14) < ring.Length)
            {
                goto label_30;
            }
            
            goto label_33;
            label_4:
            val_16 = 0;
            return (bool)val_16;
            label_18:
            val_15 = val_11;
            goto label_33;
            label_21:
            val_15 = (val_11 + val_14) - 1;
            label_33:
            if(val_15 >= 2)
            {
                    crosslink = true;
            }
            
            val_16 = 1;
            int val_15 = poptotal;
            val_15 = val_15 + val_15;
            poptotal = val_15;
            return (bool)val_16;
        }
        public InkWars.Model.BubbleTypes GetNextBubble(InkWars.Model.Model_Player otherPlayer)
        {
            InkWars.Model.Model_Core val_13;
            var val_14;
            InkWars.Model.BubbleTypes val_15;
            var val_16;
            float val_17;
            float val_18;
            var val_19;
            val_13 = 1152921505064992768;
            val_14 = null;
            val_14 = null;
            if(Character_GlobalInfo.gameMode == 3)
            {
                    val_15 = this.LoadedBubble;
                return (InkWars.Model.BubbleTypes)val_15;
            }
            
            val_16 = null;
            val_16 = null;
            System.Single[] val_1 = InkWars.Model.Model_Constants.RainbowFrequency + ((this.AttackLevel) << 2);
            float val_13 = this.<buff>k__BackingField.GetBuffValuePercent01(aNewType:  0);
            float val_3 = otherPlayer.<buff>k__BackingField.GetBuffValuePercent01(aNewType:  1);
            val_13 = this.Model;
            if((this.Model.Feature_BattleEnhancer == false) || (this.BattleEnhancerState != 1))
            {
                goto label_14;
            }
            
            val_17 = (((InkWars.Model.Model_Constants.RainbowFrequency + (this.AttackLevel) << 2) + 32) + val_13) - val_3;
            if(this.BattleEnhancerType != 2)
            {
                goto label_15;
            }
            
            val_18 = 0.25f;
            goto label_16;
            label_14:
            val_17 = (((InkWars.Model.Model_Constants.RainbowFrequency + (this.AttackLevel) << 2) + 32) + val_13) - val_3;
            label_15:
            val_18 = 0f;
            label_16:
            val_13 = val_17 + val_18;
            if(UnityEngine.Random.value > (UnityEngine.Mathf.Clamp(value:  val_13, min:  0f, max:  0.4f)))
            {
                    val_19 = null;
                val_19 = null;
                System.Single[] val_11 = InkWars.Model.Model_Constants.MatchFrequency + ((this.AttackLevel) << 2);
                float val_12 = UnityEngine.Random.value - (this.<buff>k__BackingField.GetBuffValuePercent01(aNewType:  4));
                val_12 = val_12 + (otherPlayer.<buff>k__BackingField.GetBuffValuePercent01(aNewType:  5));
                if(val_12 >= 0)
            {
                    return otherPlayer.NonMatchingBubble();
            }
            
                return otherPlayer.MatchingBubble();
            }
            
            val_15 = 7;
            return (InkWars.Model.BubbleTypes)val_15;
        }
        private InkWars.Model.BubbleTypes MatchingBubble()
        {
            var val_11;
            System.Predicate<InkWars.Model.BubbleTypes> val_13;
            var val_14;
            System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes> val_1 = new System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes>();
            val_1.FindMatchingBubbles(matchingBubbleList:  val_1, ring:  this.OuterRing);
            val_1.FindMatchingBubbles(matchingBubbleList:  val_1, ring:  this.MiddleRing);
            val_1.FindMatchingBubbles(matchingBubbleList:  val_1, ring:  this.InnerRing);
            val_11 = null;
            val_11 = null;
            val_13 = Model_Player.<>c.<>9__88_0;
            if(val_13 == null)
            {
                goto label_3;
            }
            
            if(val_1 == null)
            {
                goto label_4;
            }
            
            label_8:
            int val_2 = val_1.RemoveWhere(match:  val_13);
            goto label_5;
            label_3:
            System.Predicate<InkWars.Model.BubbleTypes> val_3 = null;
            val_13 = val_3;
            val_3 = new System.Predicate<InkWars.Model.BubbleTypes>(object:  Model_Player.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Model_Player.<>c::<MatchingBubble>b__88_0(InkWars.Model.BubbleTypes p));
            Model_Player.<>c.<>9__88_0 = val_13;
            if(val_1 != null)
            {
                goto label_8;
            }
            
            label_4:
            int val_4 = val_1.RemoveWhere(match:  val_3);
            label_5:
            if(val_1.Count != 0)
            {
                    System.Collections.Generic.List<InkWars.Model.BubbleTypes> val_6 = new System.Collections.Generic.List<InkWars.Model.BubbleTypes>(collection:  val_1);
                if(val_6 != null)
            {
                    return val_6.Item[UnityEngine.Random.Range(min:  0, max:  val_6.Count)];
            }
            
                return val_6.Item[UnityEngine.Random.Range(min:  0, max:  val_6.Count)];
            }
            
            val_14 = null;
            val_14 = null;
            int val_9 = UnityEngine.Random.Range(min:  0, max:  InkWars.Model.Model_Constants.RegularBubbles.Length);
            InkWars.Model.BubbleTypes[] val_10 = InkWars.Model.Model_Constants.RegularBubbles + (((long)(int)(val_9)) << 2);
            return (InkWars.Model.BubbleTypes)(InkWars.Model.Model_Constants.RegularBubbles + ((long)(int)(val_9)) << 2) + 32;
        }
        internal void DoSuction(InkWars.Model.AimTarget aimTarget)
        {
            var val_5;
            InkWars.Model.AimTarget val_1 = aimTarget - 1;
            bool val_4 = ((aimTarget == 0) ? 1 : 0) | ((val_1 < 2) ? 1 : 0);
            if(val_1 <= 4)
            {
                    val_5 = mem[40830880 + ((aimTarget - 1)) << 2];
                val_5 = 40830880 + ((aimTarget - 1)) << 2;
            }
            else
            {
                    val_5 = 0;
            }
            
            this.DoSuctionOnRing(RingID:  0, TargetBubbleRingID:  0, Bridge:  8, fromTop:  val_4);
            this.DoSuctionOnRing(RingID:  1, TargetBubbleRingID:  0, Bridge:  6, fromTop:  val_4);
            this.DoSuctionOnRing(RingID:  2, TargetBubbleRingID:  0, Bridge:  4, fromTop:  val_4);
        }
        private void DoSuctionOnRing(int RingID, int TargetBubbleRingID, int Bridge, bool fromTop)
        {
            int val_8;
            InkWars.Model.Model_Bubble[] val_9;
            var val_10;
            var val_11;
            InkWars.Model.Player val_12;
            var val_13;
            var val_14;
            val_8 = Bridge;
            if(RingID == 2)
            {
                goto label_1;
            }
            
            if(RingID == 1)
            {
                goto label_2;
            }
            
            if(RingID != 0)
            {
                goto label_3;
            }
            
            val_9 = this.OuterRing;
            goto label_5;
            label_1:
            val_9 = this.InnerRing;
            goto label_5;
            label_2:
            val_9 = this.MiddleRing;
            label_5:
            val_10 = mem[this.MiddleRing];
            var val_1 = (val_10 == 0) ? 1 : 0;
            goto label_6;
            label_3:
            val_10 = 0;
            val_11 = 1;
            label_6:
            var val_13 = 0;
            do
            {
                if(val_13 >= 10260432)
            {
                    return;
            }
            
                var val_2 = val_10 + 0;
                val_12 = mem[(val_10 + 0) + 32];
                val_12 = (val_10 + 0) + 32;
                val_13 = val_13 + 1;
            }
            while(((val_10 + 0) + 32 + 16) == 0);
            
            val_13 = 10260432;
            if(val_13 >= 1)
            {
                    do
            {
                var val_3 = val_10 + 0;
                val_12 = mem[(val_10 + 0) + 32 + 16];
                val_12 = (val_10 + 0) + 32 + 16;
                mem2[0] = (val_12 != 0) ? 0 : (!0);
                val_11 = mem[(val_10 + 0) + 32];
                val_11 = (val_10 + 0) + 32;
                mem2[0] = 0;
                val_13 = 10260432;
            }
            while((0 + 1) < val_13);
            
            }
            
            if(val_13 >= 1)
            {
                    var val_14 = 0;
                do
            {
                val_11 = val_10 + 0;
                val_12 = mem[(val_10 + 0) + 32];
                val_12 = (val_10 + 0) + 32;
                if(0 != ((val_10 + 0) + 32 + 36))
            {
                    val_12 = mem[(val_10 + 0) + 32];
                val_12 = (val_10 + 0) + 32;
                if(((val_10 + 0) + 32 + 36) != 1)
            {
                    val_12 = this.ID;
                val_11 = mem[(val_10 + 0) + 32 + 36];
                val_11 = (val_10 + 0) + 32 + 36;
                InkWars.Model.Model_Events.Instance.Event_BubbleSuction(iD:  val_12, ringID:  RingID, ringIndex:  0, amount:  val_14 + val_11);
            }
            
            }
            
                val_14 = val_14 - 1;
            }
            while((0 + 1) < 10260432);
            
            }
            
            if(fromTop != false)
            {
                    this.SuctionFromTop(RingID:  RingID, TargetBubbleRingID:  TargetBubbleRingID, Bridge:  val_8, BridgeOffset:  1);
                this.SuctionFromBottom(RingID:  RingID, TargetBubbleRingID:  TargetBubbleRingID, Bridge:  val_8, BridgeOffset:  2);
            }
            else
            {
                    this.SuctionFromBottom(RingID:  RingID, TargetBubbleRingID:  TargetBubbleRingID, Bridge:  val_8, BridgeOffset:  1);
                this.SuctionFromTop(RingID:  RingID, TargetBubbleRingID:  TargetBubbleRingID, Bridge:  val_8, BridgeOffset:  2);
            }
            
            var val_9 = val_10 + (((long)(int)(Bridge)) << 3);
            val_14 = mem[(val_10 + ((long)(int)(Bridge)) << 3) + 32];
            val_14 = (val_10 + ((long)(int)(Bridge)) << 3) + 32;
            if(val_14 == 0)
            {
                goto label_37;
            }
            
            if(10260432 > val_8)
            {
                goto label_35;
            }
            
            val_14 = mem[(val_10 + ((long)(int)(Bridge)) << 3) + 32];
            val_14 = (val_10 + ((long)(int)(Bridge)) << 3) + 32;
            if(val_14 == 0)
            {
                goto label_36;
            }
            
            label_35:
            if(((val_10 + ((long)(int)(Bridge)) << 3) + 32 + 16) != 0)
            {
                    val_8 = mem[(val_10 + ((long)(int)(Bridge)) << 3) + 32];
                val_8 = (val_10 + ((long)(int)(Bridge)) << 3) + 32;
                mem2[0] = "BridgePop";
            }
            
            label_37:
            if(10260432 < 1)
            {
                    return;
            }
            
            var val_15 = 0;
            do
            {
                val_8 = 0;
                val_12 = val_10 + 0;
                if((val_8 != ((val_10 + 0) + 32 + 36)) && (((val_10 + 0) + 32 + 36) != 1))
            {
                    val_11 = InkWars.Model.Model_Events.Instance;
                val_12 = mem[(val_10 + 0) + 32 + 36];
                val_12 = (val_10 + 0) + 32 + 36;
                val_11.Event_BubbleSuction(iD:  this.ID, ringID:  RingID, ringIndex:  0, amount:  val_15 + val_12);
            }
            
                val_15 = val_15 - 1;
            }
            while((val_8 + 1) < 10260432);
            
            return;
            label_36:
        }
        private InkWars.Model.Model_Bubble[] GetRing(int ringID)
        {
            InkWars.Model.Model_Bubble[] val_1;
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
                    return 0;
            }
            
            val_1 = this.OuterRing;
            return (InkWars.Model.Model_Bubble[])mem[this.MiddleRing];
            label_0:
            val_1 = this.InnerRing;
            return (InkWars.Model.Model_Bubble[])mem[this.MiddleRing];
            label_1:
            val_1 = this.MiddleRing;
            return (InkWars.Model.Model_Bubble[])mem[this.MiddleRing];
        }
        private void SuctionFromTop(int RingID, int TargetBubbleRingID, int Bridge, int BridgeOffset)
        {
            InkWars.Model.Model_Bubble[] val_6;
            var val_7;
            var val_8;
            var val_9;
            InkWars.Model.Model_Bubble[] val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            int val_5 = Bridge;
            if(RingID == 2)
            {
                goto label_0;
            }
            
            if(RingID == 1)
            {
                goto label_1;
            }
            
            if(RingID != 0)
            {
                goto label_2;
            }
            
            val_6 = this.OuterRing;
            goto label_4;
            label_0:
            val_6 = this.InnerRing;
            goto label_4;
            label_1:
            val_6 = this.MiddleRing;
            label_4:
            val_7 = mem[this.MiddleRing];
            goto label_5;
            label_2:
            val_7 = 0;
            label_5:
            if((RingID == TargetBubbleRingID) || (BridgeOffset != 2))
            {
                goto label_13;
            }
            
            val_8 = val_5;
            label_12:
            if(val_8 >= 10260432)
            {
                goto label_9;
            }
            
            var val_1 = val_7 + (((long)(int)(Bridge)) << 3);
            val_8 = val_8 + 1;
            if(((val_7 + ((long)(int)(Bridge)) << 3) + 32 + 16) == 0)
            {
                goto label_12;
            }
            
            val_9 = 2;
            goto label_13;
            label_9:
            val_9 = 1;
            label_13:
            val_5 = val_5 - val_9;
            label_57:
            val_10 = this.OuterRing;
            if(RingID == 0)
            {
                goto label_16;
            }
            
            if(RingID == 2)
            {
                goto label_15;
            }
            
            val_10 = this.MiddleRing;
            if(RingID == 1)
            {
                goto label_16;
            }
            
            val_11 = 0;
            if((val_5 & 2147483648) == 0)
            {
                goto label_17;
            }
            
            return;
            label_15:
            val_10 = this.InnerRing;
            label_16:
            val_11 = mem[this.InnerRing];
            val_11 = val_10;
            if((val_5 & 2147483648) != 0)
            {
                    return;
            }
            
            label_17:
            val_8 = 0;
            val_12 = val_5;
            do
            {
                InkWars.Model.Model_Bubble[] val_2 = val_11 + (((long)(int)((Bridge - val_9))) << 3);
                if(((this.InnerRing + ((long)(int)((Bridge - val_9))) << 3) + 32 + 16) != 0)
            {
                    var val_6 = (this.InnerRing + ((long)(int)((Bridge - val_9))) << 3) + 32 + 40;
                val_6 = val_12 + val_6;
                val_12 = val_6 - 1;
            }
            
                InkWars.Model.Model_Bubble[] val_4 = val_11 + (((long)(int)(((((Bridge - val_9) + (this.InnerRing + ((long)(int)((Bridge - val_9))) << 3) + 32 + 40) - 1) + 1))) << 3);
                val_13 = mem[(this.InnerRing + ((long)(int)(((((Bridge - val_9) + (this.InnerRing + ((long)(int)((Bridge - val_9))) << 3) + 32 + 40) - 1) + 1))) << 3) + 32];
                val_13 = (this.InnerRing + ((long)(int)(((((Bridge - val_9) + (this.InnerRing + ((long)(int)((Bridge - val_9))) << 3) + 32 + 40) - 1) + 1))) << 3) + 32;
                if(((this.InnerRing + ((long)(int)(((((Bridge - val_9) + (this.InnerRing + ((long)(int)((Bridge - val_9))) << 3) + 32 + 40) - 1) + 1))) << 3) + 32 + 16) == 0)
            {
                    val_13 = val_11 + (((long)(int)((((Bridge - val_9) + (this.InnerRing + ((long)(int)((Bridge - val_9))) << 3) + 32 + 40) - 1))) << 3);
                if(((this.InnerRing + ((long)(int)((((Bridge - val_9) + (this.InnerRing + ((long)(int)((Bridge - val_9))) << 3) + 32 + 40) - 1))) << 3) + 32 + 16) != 0)
            {
                    val_14 = mem[this.InnerRing + 24];
                val_14 = this.InnerRing + 24;
                if(((long)val_12 + 1) >= val_14)
            {
                    val_14 = mem[this.InnerRing + 24];
                val_14 = this.InnerRing + 24;
            }
            
                mem2[0] = (this.InnerRing + ((long)(int)((((Bridge - val_9) + (this.InnerRing + ((long)(int)((Bridge - val_9))) << 3) + 32 + 40) - 1))) << 3) + 32 + 16;
                val_15 = mem[this.InnerRing + 24];
                val_15 = this.InnerRing + 24;
                if(((long)val_12 + 1) >= val_15)
            {
                    val_15 = mem[this.InnerRing + 24];
                val_15 = this.InnerRing + 24;
            }
            
                mem2[0] = (this.InnerRing + ((long)(int)((((Bridge - val_9) + (this.InnerRing + ((long)(int)((Bridge - val_9))) << 3) + 32 + 40) - 1))) << 3) + 32 + 28;
                val_16 = mem[this.InnerRing + 24];
                val_16 = this.InnerRing + 24;
                if(((long)val_12 + 1) >= val_16)
            {
                    val_16 = mem[this.InnerRing + 24];
                val_16 = this.InnerRing + 24;
            }
            
                mem2[0] = (this.InnerRing + ((long)(int)((((Bridge - val_9) + (this.InnerRing + ((long)(int)((Bridge - val_9))) << 3) + 32 + 40) - 1))) << 3) + 32 + 36;
                val_17 = mem[this.InnerRing + 24];
                val_17 = this.InnerRing + 24;
                if(((long)val_12 + 1) >= val_17)
            {
                    val_17 = mem[this.InnerRing + 24];
                val_17 = this.InnerRing + 24;
            }
            
                mem2[0] = (this.InnerRing + ((long)(int)((((Bridge - val_9) + (this.InnerRing + ((long)(int)((Bridge - val_9))) << 3) + 32 + 40) - 1))) << 3) + 32 + 40;
                mem2[0] = 0;
                mem2[0] = 0;
                mem2[0] = 0;
                val_8 = 1;
                mem2[0] = val_8;
            }
            
            }
            
                val_12 = val_12 - 1;
            }
            while((val_12 & 2147483648) == 0);
            
            if((val_8 & 1) != 0)
            {
                goto label_57;
            }
        
        }
        private void SuctionFromBottom(int RingID, int TargetBubbleRingID, int Bridge, int BridgeOffset)
        {
            var val_7;
            InkWars.Model.Model_Bubble[] val_8;
            var val_9;
            var val_10;
            InkWars.Model.Model_Bubble[] val_11;
            var val_12;
            int val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_7 = Bridge;
            if(RingID == 2)
            {
                goto label_0;
            }
            
            if(RingID == 1)
            {
                goto label_1;
            }
            
            if(RingID != 0)
            {
                goto label_2;
            }
            
            val_8 = this.OuterRing;
            goto label_4;
            label_0:
            val_8 = this.InnerRing;
            goto label_4;
            label_1:
            val_8 = this.MiddleRing;
            label_4:
            val_9 = mem[this.MiddleRing];
            goto label_5;
            label_2:
            val_9 = 0;
            label_5:
            if((RingID == TargetBubbleRingID) || (BridgeOffset != 2))
            {
                goto label_14;
            }
            
            if((val_7 & 2147483648) != 0)
            {
                goto label_8;
            }
            
            var val_6 = (long)val_7;
            label_13:
            var val_1 = val_9 + (((long)(int)(Bridge)) << 3);
            if(((val_9 + ((long)(int)(Bridge)) << 3) + 32 + 16) != 0)
            {
                goto label_12;
            }
            
            val_6 = val_6 - 1;
            if(val_6 > 0)
            {
                goto label_13;
            }
            
            label_8:
            val_10 = 1;
            goto label_14;
            label_12:
            val_10 = 2;
            label_14:
            label_57:
            val_11 = this.OuterRing;
            if(RingID == 0)
            {
                goto label_17;
            }
            
            if(RingID == 2)
            {
                goto label_16;
            }
            
            val_11 = this.MiddleRing;
            if(RingID == 1)
            {
                goto label_17;
            }
            
            val_12 = 0;
            goto label_18;
            label_16:
            val_11 = this.InnerRing;
            label_17:
            val_12 = mem[this.InnerRing];
            val_12 = val_11;
            label_18:
            val_13 = val_10 + val_7;
            val_14 = 0;
            goto label_19;
            label_56:
            InkWars.Model.Model_Bubble[] val_3 = val_12 + (((long)(int)((val_10 + Bridge))) << 3);
            if(((this.InnerRing + ((long)(int)((val_10 + Bridge))) << 3) + 32 + 16) != 0)
            {
                    var val_7 = (this.InnerRing + ((long)(int)((val_10 + Bridge))) << 3) + 32 + 40;
                val_7 = val_7 ^ 1;
                val_13 = val_13 + val_7;
            }
            
            InkWars.Model.Model_Bubble[] val_5 = val_12 + (((long)(int)((((val_10 + Bridge) + ((this.InnerRing + ((long)(int)((val_10 + Bridge))) << 3) + 32 + 40 ^ 1)) - 1))) << 3);
            val_15 = mem[(this.InnerRing + ((long)(int)((((val_10 + Bridge) + ((this.InnerRing + ((long)(int)((val_10 + Bridge))) << 3) + 32 + 40 ^ 1)) - 1))) << 3) + 32];
            val_15 = (this.InnerRing + ((long)(int)((((val_10 + Bridge) + ((this.InnerRing + ((long)(int)((val_10 + Bridge))) << 3) + 32 + 40 ^ 1)) - 1))) << 3) + 32;
            if(((this.InnerRing + ((long)(int)((((val_10 + Bridge) + ((this.InnerRing + ((long)(int)((val_10 + Bridge))) << 3) + 32 + 40 ^ 1)) - 1))) << 3) + 32 + 16) == 0)
            {
                    val_15 = val_12 + (((long)(int)(((val_10 + Bridge) + ((this.InnerRing + ((long)(int)((val_10 + Bridge))) << 3) + 32 + 40 ^ 1)))) << 3);
                val_7 = mem[(this.InnerRing + ((long)(int)(((val_10 + Bridge) + ((this.InnerRing + ((long)(int)((val_10 + Bridge))) << 3) + 32 + 40 ^ 1)))) << 3) + 32];
                val_7 = (this.InnerRing + ((long)(int)(((val_10 + Bridge) + ((this.InnerRing + ((long)(int)((val_10 + Bridge))) << 3) + 32 + 40 ^ 1)))) << 3) + 32;
                if(((this.InnerRing + ((long)(int)(((val_10 + Bridge) + ((this.InnerRing + ((long)(int)((val_10 + Bridge))) << 3) + 32 + 40 ^ 1)))) << 3) + 32 + 16) != 0)
            {
                    val_16 = mem[this.InnerRing + 24];
                val_16 = this.InnerRing + 24;
                if(((long)val_13 - 1) >= val_16)
            {
                    val_16 = mem[this.InnerRing + 24];
                val_16 = this.InnerRing + 24;
            }
            
                mem2[0] = (this.InnerRing + ((long)(int)(((val_10 + Bridge) + ((this.InnerRing + ((long)(int)((val_10 + Bridge))) << 3) + 32 + 40 ^ 1)))) << 3) + 32 + 16;
                val_17 = mem[this.InnerRing + 24];
                val_17 = this.InnerRing + 24;
                if(((long)val_13 - 1) >= val_17)
            {
                    val_17 = mem[this.InnerRing + 24];
                val_17 = this.InnerRing + 24;
            }
            
                mem2[0] = (this.InnerRing + ((long)(int)(((val_10 + Bridge) + ((this.InnerRing + ((long)(int)((val_10 + Bridge))) << 3) + 32 + 40 ^ 1)))) << 3) + 32 + 28;
                val_18 = mem[this.InnerRing + 24];
                val_18 = this.InnerRing + 24;
                if(((long)val_13 - 1) >= val_18)
            {
                    val_18 = mem[this.InnerRing + 24];
                val_18 = this.InnerRing + 24;
            }
            
                mem2[0] = (this.InnerRing + ((long)(int)(((val_10 + Bridge) + ((this.InnerRing + ((long)(int)((val_10 + Bridge))) << 3) + 32 + 40 ^ 1)))) << 3) + 32 + 36;
                val_19 = mem[this.InnerRing + 24];
                val_19 = this.InnerRing + 24;
                if(((long)val_13 - 1) >= val_19)
            {
                    val_19 = mem[this.InnerRing + 24];
                val_19 = this.InnerRing + 24;
            }
            
                val_7 = mem[(this.InnerRing + ((long)(int)(((val_10 + Bridge) + ((this.InnerRing + ((long)(int)((val_10 + Bridge))) << 3) + 32 + 40 ^ 1)))) << 3) + 32 + 40];
                val_7 = (this.InnerRing + ((long)(int)(((val_10 + Bridge) + ((this.InnerRing + ((long)(int)((val_10 + Bridge))) << 3) + 32 + 40 ^ 1)))) << 3) + 32 + 40;
                mem2[0] = val_7;
                mem2[0] = 0;
                mem2[0] = 0;
                mem2[0] = 0;
                val_14 = 1;
                mem2[0] = val_14;
            }
            
            }
            
            val_13 = val_13 + 1;
            label_19:
            if(val_13 < (this.InnerRing + 24))
            {
                goto label_56;
            }
            
            if((val_14 & 1) != 0)
            {
                goto label_57;
            }
        
        }
        private InkWars.Model.BubbleTypes NonMatchingBubble()
        {
            System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes> val_13;
            var val_14;
            System.Predicate<InkWars.Model.BubbleTypes> val_16;
            Model_Player.<>c__DisplayClass94_0 val_1 = new Model_Player.<>c__DisplayClass94_0();
            System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes> val_2 = new System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes>();
            if(val_1 != null)
            {
                    val_13 = val_1;
                .matchingBubbleList = val_2;
            }
            else
            {
                    val_13 = 16;
                mem[16] = val_2;
            }
            
            this.FindMatchingBubbles(matchingBubbleList:  val_2, ring:  this.OuterRing);
            this.FindMatchingBubbles(matchingBubbleList:  val_2, ring:  this.MiddleRing);
            this.FindMatchingBubbles(matchingBubbleList:  val_2, ring:  this.InnerRing);
            System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes> val_3 = new System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes>();
            val_3.FindAllBubbles(matchingBubbleList:  val_3, ring:  this.OuterRing);
            val_3.FindAllBubbles(matchingBubbleList:  val_3, ring:  this.MiddleRing);
            val_3.FindAllBubbles(matchingBubbleList:  val_3, ring:  this.InnerRing);
            int val_5 = val_3.RemoveWhere(match:  new System.Predicate<InkWars.Model.BubbleTypes>(object:  val_1, method:  System.Boolean Model_Player.<>c__DisplayClass94_0::<NonMatchingBubble>b__0(InkWars.Model.BubbleTypes p)));
            val_14 = null;
            val_14 = null;
            val_16 = Model_Player.<>c.<>9__94_1;
            if(val_16 == null)
            {
                goto label_8;
            }
            
            if(val_3 == null)
            {
                goto label_9;
            }
            
            label_13:
            int val_6 = val_3.RemoveWhere(match:  val_16);
            goto label_10;
            label_8:
            System.Predicate<InkWars.Model.BubbleTypes> val_7 = null;
            val_16 = val_7;
            val_7 = new System.Predicate<InkWars.Model.BubbleTypes>(object:  Model_Player.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Model_Player.<>c::<NonMatchingBubble>b__94_1(InkWars.Model.BubbleTypes p));
            Model_Player.<>c.<>9__94_1 = val_16;
            if(val_3 != null)
            {
                goto label_13;
            }
            
            label_9:
            int val_8 = val_3.RemoveWhere(match:  val_7);
            label_10:
            if(val_3.Count == 0)
            {
                    return this.MatchingBubble();
            }
            
            System.Collections.Generic.List<InkWars.Model.BubbleTypes> val_10 = new System.Collections.Generic.List<InkWars.Model.BubbleTypes>(collection:  val_3);
            if(val_10 != null)
            {
                    return val_10.Item[UnityEngine.Random.Range(min:  0, max:  val_10.Count)];
            }
            
            return val_10.Item[UnityEngine.Random.Range(min:  0, max:  val_10.Count)];
        }
        private void FindMatchingBubbles(System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes> matchingBubbleList, InkWars.Model.Model_Bubble[] ring)
        {
            var val_3;
            int val_4;
            val_3 = 0;
            goto label_1;
            label_6:
            InkWars.Model.Model_Bubble val_3 = ring[0];
            if(ring[0x0][0].BubbleType != 0)
            {
                goto label_4;
            }
            
            val_3 = 1;
            label_1:
            val_4 = ring.Length;
            if(val_3 < val_4)
            {
                goto label_6;
            }
            
            goto label_14;
            label_4:
            bool val_1 = matchingBubbleList.Add(item:  ring[0x0] + 32 + 16);
            val_4 = ring.Length;
            do
            {
                label_14:
                val_4 = val_4 - 1;
                if((val_4 & 2147483648) != 0)
            {
                    return;
            }
            
                InkWars.Model.Model_Bubble val_4 = ring[(long)val_4];
            }
            while((ring[(long)(int)((ring.Length - 1))][0].BubbleType) == 0);
            
            bool val_2 = matchingBubbleList.Add(item:  ring[(long)(int)((ring.Length - 1))] + 32 + 16);
        }
        private void FindAllBubbles(System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes> matchingBubbleList, InkWars.Model.Model_Bubble[] ring)
        {
            InkWars.Model.BubbleTypes val_2;
            goto label_1;
            label_9:
            InkWars.Model.Model_Bubble val_2 = ring[0];
            if(ring[0x0][0].BubbleType != 0)
            {
                    val_2 = mem[ring[0x0] + 32 + 16];
                val_2 = ring[0x0] + 32 + 16;
                bool val_1 = matchingBubbleList.Add(item:  val_2);
            }
            
            0 = 1;
            label_1:
            if(0 < ring.Length)
            {
                goto label_9;
            }
        
        }
        internal void Switch(bool manualSwitch)
        {
            this.LoadedBubble = this.SpareBubble;
            this.SpareBubble = this.LoadedBubble;
            this.SwitchingTime = 0.1f;
            InkWars.Model.Model_Events.Instance.Event_Switch(Id:  this.ID, loadedBubble:  this.LoadedBubble, spareBubble:  this.SpareBubble, manualSwitch:  manualSwitch);
        }
        public void MatchEndScoreCalculation()
        {
            var val_8;
            float val_1 = this.Model.TimeLeft;
            System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes> val_3 = new System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes>();
            val_3.FindAllBubbles(matchingBubbleList:  val_3, ring:  this.InnerRing);
            val_3.FindAllBubbles(matchingBubbleList:  val_3, ring:  this.MiddleRing);
            val_3.FindAllBubbles(matchingBubbleList:  val_3, ring:  this.OuterRing);
            int val_8 = this.BubbleCount;
            val_8 = (val_8 * ((int)UnityEngine.Mathf.Max(a:  1f, b:  val_1))) * val_3.Count;
            mem[1152921529289977964] = (int)UnityEngine.Mathf.Max(a:  1f, b:  val_1);
            InkWars.Model.MatchEndScoreCard val_9 = this.ScoreCard;
            mem[1152921529289977968] = this.BubbleCount;
            mem[1152921529289977976] = val_3;
            mem[1152921529289977984] = val_8;
            if(val_9 > 0f)
            {
                    val_9 = val_1 / val_9;
                mem[1152921529289977956] = val_9;
            }
            
            if(this.Model.InkEmUp_CurrentPhase != 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            this.Destroy_RemainingBubbles(scorePerBubble:  InkWars.Model.Model_Constants.ScoreInkEmUp_BubblesRemaining);
        }
        public void Destroy_RemainingBubbles(int scorePerBubble)
        {
            this.Destroy_RemainingBubbles(ring:  this.OuterRing, score:  scorePerBubble);
            this.Destroy_RemainingBubbles(ring:  this.MiddleRing, score:  scorePerBubble);
            this.Destroy_RemainingBubbles(ring:  this.InnerRing, score:  scorePerBubble);
        }
        private void Destroy_RemainingBubbles(InkWars.Model.Model_Bubble[] ring, int score)
        {
            goto label_0;
            label_5:
            InkWars.Model.Model_Bubble val_2 = ring[0];
            if(ring[0x0][0].BubbleType != 0)
            {
                    val_2.SetScoreAndPopDelay(score:  score, popDelay:  0f, scoreTarget:  this.ID, comboType:  0);
                bool val_1 = val_2.Damage(responsiblePlayer:  this.ID, forceKill:  true, isCrossBubbleHit:  false);
            }
            
            0 = 1;
            label_0:
            if(0 < ring.Length)
            {
                goto label_5;
            }
        
        }
    
    }

}
