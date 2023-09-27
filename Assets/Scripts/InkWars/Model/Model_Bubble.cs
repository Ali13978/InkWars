using UnityEngine;

namespace InkWars.Model
{
    [Serializable]
    public class Model_Bubble
    {
        // Fields
        public InkWars.Model.BubbleTypes BubbleType;
        private InkWars.Model.BubbleTypes TypeBeforePop;
        public InkWars.Model.BubbleStates BubbleState;
        public int Health;
        private int _Score;
        public int suction_originalPosition;
        public bool enableSuction;
        public bool isGridRainbowBubble;
        private InkWars.Model.Player _scoreTargetID;
        public HitComboType ComboType;
        public bool Trashed;
        private InkWars.Model.Model_Player Player;
        public InkWars.Model.AimTarget AimTarget;
        public float TimePassed;
        public bool ShouldHitOpponentBubble;
        public bool ShouldAddToOwnGrid;
        public int PositionState;
        public float PositionTimeNormalized;
        public int TargetPoolIndex;
        public bool AddedToGrid;
        public int PopCount;
        public int Offset;
        private float _PopDelay;
        public bool Pop;
        public bool ShotAsInk;
        public bool m_isCrossBubbleHit;
        public string customPopType;
        public bool activeTypeSwitchAnim;
        
        // Properties
        public int Score { get; set; }
        public InkWars.Model.Player scoreTargetID { get; set; }
        public float PopDelay { get; set; }
        
        // Methods
        public int get_Score()
        {
            return (int)this._Score;
        }
        private void set_Score(int value)
        {
            this._Score = value;
        }
        public InkWars.Model.Player get_scoreTargetID()
        {
            return (InkWars.Model.Player)this._scoreTargetID;
        }
        private void set_scoreTargetID(InkWars.Model.Player value)
        {
            this._scoreTargetID = value;
        }
        public float get_PopDelay()
        {
            return (float)this._PopDelay;
        }
        public void set_PopDelay(float value)
        {
            this.Pop = true;
            this._PopDelay = value;
        }
        public Model_Bubble()
        {
            this.enableSuction = true;
        }
        public InkWars.Model.Player GetPlayerID()
        {
            if(this.Player != null)
            {
                    return (InkWars.Model.Player)this.Player.ID;
            }
            
            return (InkWars.Model.Player)this.Player.ID;
        }
        public Model_Bubble(InkWars.Model.Model_Player model_Player, int offset, string strType)
        {
            this.enableSuction = true;
            val_1 = new System.Object();
            this.SetAs_Grid(model_Player:  model_Player, offset:  offset, strType:  string val_1 = strType);
        }
        public Model_Bubble(InkWars.Model.Model_Player model_Player, InkWars.Model.BubbleTypes type, InkWars.Model.AimTarget aimTarget, int poolIndex)
        {
            this.enableSuction = true;
            this.Player = model_Player;
            this.BubbleType = type;
            this.AimTarget = aimTarget;
            this.TimePassed = 0f;
            this.PositionTimeNormalized = 0f;
            this.TargetPoolIndex = poolIndex;
            this.AddedToGrid = false;
            this.Pop = true;
            this._PopDelay = 0f;
            this.PopCount = 0;
            this.PositionState = 0;
            this.ShouldHitOpponentBubble = false;
            this.ShouldAddToOwnGrid = false;
            this.BubbleState = true;
            this.Health = ((type == 9) ? 1 : 0) << 1;
        }
        public void SetAs_Grid(InkWars.Model.Model_Player model_Player, int offset, string strType)
        {
            InkWars.Model.BubbleTypes val_9;
            this.Player = model_Player;
            this.BubbleState = 2;
            this.Offset = offset;
            uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  strType);
            if(val_1 > (-955516027))
            {
                goto label_1;
            }
            
            if(val_1 == (-1039404122))
            {
                goto label_2;
            }
            
            if(val_1 == (-955516027))
            {
                goto label_3;
            }
            
            if(val_1 != 1528554166)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  strType, b:  "SPD")) == false)
            {
                    return;
            }
            
            this.BubbleType = 12;
            this.Health = 2;
            this.enableSuction = false;
            return;
            label_1:
            if(val_1 > (-720629361))
            {
                goto label_7;
            }
            
            if(val_1 == (-905183170))
            {
                goto label_8;
            }
            
            if(val_1 != (-720629361))
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  strType, b:  "P")) == false)
            {
                    return;
            }
            
            val_9 = 4;
            goto label_21;
            label_7:
            if(val_1 == (-603186028))
            {
                goto label_12;
            }
            
            if(val_1 != (-687074123))
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  strType, b:  "R")) == false)
            {
                    return;
            }
            
            val_9 = 1;
            goto label_21;
            label_2:
            if((System.String.op_Equality(a:  strType, b:  "G")) == false)
            {
                    return;
            }
            
            val_9 = 6;
            goto label_21;
            label_3:
            if((System.String.op_Equality(a:  strType, b:  "B")) == false)
            {
                    return;
            }
            
            val_9 = 2;
            goto label_21;
            label_8:
            if((System.String.op_Equality(a:  strType, b:  "O")) == false)
            {
                    return;
            }
            
            val_9 = 5;
            goto label_21;
            label_12:
            if((System.String.op_Equality(a:  strType, b:  "Y")) == false)
            {
                    return;
            }
            
            val_9 = 3;
            label_21:
            this.BubbleType = val_9;
        }
        public void SetAs_Ink(InkWars.Model.Model_Player model_Player)
        {
            this.Player = model_Player;
            this.BubbleState = 3;
            this.BubbleType = 11;
        }
        public void SetAs_Target(InkWars.Model.Model_Player model_Player, InkWars.Model.BubbleTypes type, InkWars.Model.AimTarget aimTarget, int poolIndex)
        {
            int val_1 = (type == 9) ? 1 : 0;
            val_1 = val_1 << 1;
            this.Player = model_Player;
            this.BubbleType = type;
            this.AimTarget = aimTarget;
            this.TimePassed = 0f;
            this.PositionTimeNormalized = 0f;
            this.TargetPoolIndex = poolIndex;
            this.AddedToGrid = false;
            this._PopDelay = 0f;
            this.PopCount = 0;
            this.PositionState = 0;
            this.ShouldHitOpponentBubble = false;
            this.ShouldAddToOwnGrid = false;
            this.Pop = true;
            this.BubbleState = true;
            this.Health = val_1;
        }
        internal void Update(float deltaTime)
        {
            if(this.BubbleState != 1)
            {
                    return;
            }
            
            this.Update_Target(deltaTime:  deltaTime);
        }
        private void Update_Target(float deltaTime)
        {
            var val_7;
            float val_30;
            InkWars.Model.Model_Player val_31;
            InkWars.Model.Model_Player val_32;
            var val_33;
            InkWars.Model.Player val_34;
            var val_35;
            float val_37;
            var val_38;
            var val_39;
            var val_40;
            System.Single[] val_41;
            InkWars.Model.AimTarget val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_47;
            var val_48;
            InkWars.Model.Model_Bubble val_49;
            InkWars.Model.Model_Player val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            float val_62;
            int val_63;
            var val_64;
            var val_65;
            var val_66;
            var val_67;
            var val_68;
            var val_69;
            var val_70;
            val_30 = deltaTime;
            if(this.BubbleType == 0)
            {
                    return;
            }
            
            float val_29 = this.TimePassed;
            val_31 = this.Player;
            val_29 = val_29 + val_30;
            val_32 = val_31;
            this.TimePassed = val_29;
            if(val_31 == null)
            {
                    val_32 = this.Player;
                if(val_32 == null)
            {
                goto label_164;
            }
            
            }
            
            var val_1 = (this.Player.ID != 1) ? this.Player.Model.Player2 : this.Player.Model.Player1;
            this.m_isCrossBubbleHit = false;
            if(this.AimTarget > 7)
            {
                goto label_5;
            }
            
            var val_30 = 40826776;
            val_30 = (40826776 + (this.AimTarget) << 2) + val_30;
            goto (40826776 + (this.AimTarget) << 2 + 40826776);
            label_5:
            val_33 = 0;
            val_34 = 0;
            val_35 = 0;
            float val_31 = this.TimePassed;
            val_38 = null;
            val_38 = null;
            val_31 = val_31 + (this.Player.ID != 0x1 ? this.Player.Model.Player2 : this.Player.Model.Player1 + 32);
            val_39 = null;
            if(val_31 >= 0)
            {
                goto label_26;
            }
            
            val_40 = null;
            val_41 = InkWars.Model.Model_Constants.TotalTimeToReachEnemyGrid;
            val_42 = this.AimTarget;
            if(val_42 == 3)
            {
                goto label_89;
            }
            
            float val_32 = InkWars.Model.Model_Constants.TotalTimeToReachEnemyGrid.Length + 32;
            val_32 = val_32 * 0.5f;
            if((val_31 <= val_32) || (this.BubbleType == 10))
            {
                goto label_89;
            }
            
            if(val_1 != 0)
            {
                goto label_35;
            }
            
            goto label_35;
            label_26:
            val_43 = null;
            val_44 = null;
            if(val_31 >= 0)
            {
                goto label_40;
            }
            
            val_45 = null;
            float val_4 = UnityEngine.Mathf.InverseLerp(a:  this.Player.ID != 0x1 ? this.Player.Model.Player2 : this.Player.Model.Player1 + 32, b:  null, value:  val_31);
            if((this.BubbleType != 10) && (this.AimTarget != 3))
            {
                    val_1.DoSuction(aimTarget:  this.AimTarget);
            }
            
            val_41 = this.Player;
            val_47 = val_34;
            val_48 = val_33;
            val_49 = this;
            val_50 = val_1;
            goto label_53;
            label_40:
            val_51 = null;
            val_52 = null;
            if(val_31 >= 0)
            {
                goto label_58;
            }
            
            val_53 = null;
            val_41 = InkWars.Model.Model_Constants.TotalTimeToReachOwnGrid;
            val_42 = this.AimTarget;
            if(val_42 == 3)
            {
                goto label_89;
            }
            
            float val_33 = InkWars.Model.Model_Constants.TotalTimeToReachOwnGrid.Length + 32;
            val_33 = (this.Player.ID != 0x1 ? this.Player.Model.Player2 : this.Player.Model.Player1 + 32) - val_33;
            val_33 = val_33 * 0.5f;
            val_33 = (this.Player.ID != 0x1 ? this.Player.Model.Player2 : this.Player.Model.Player1 + 32) + val_33;
            if(val_31 <= val_33)
            {
                goto label_89;
            }
            
            val_41 = this.Player;
            label_35:
            val_41.DoSuction(aimTarget:  val_42);
            goto label_89;
            label_58:
            val_56 = null;
            val_41 = InkWars.Model.Model_Constants.TotalTimeToLeaveOwnGrid;
            if(val_31 >= 0)
            {
                goto label_89;
            }
            
            val_57 = null;
            val_57 = null;
            if(this.AimTarget != 3)
            {
                    this.Player.DoSuction(aimTarget:  this.AimTarget);
            }
            
            val_41 = this.Player;
            val_47 = val_34;
            val_48 = val_33;
            val_49 = this;
            val_50 = val_41;
            label_53:
            bool val_12 = val_41.HandleBubbleCollision(i:  UnityEngine.Mathf.InverseLerp(a:  this.Player.ID != 0x1 ? this.Player.Model.Player2 : this.Player.Model.Player1 + 32, b:  null, value:  val_31), ringIndex:  0, shootingAtTop:  false, bubble:  this, targetPlayer:  val_50);
            label_89:
            val_58 = null;
            val_58 = null;
            if(this.TimePassed >= 0)
            {
                goto label_105;
            }
            
            this.PositionState = 0;
            val_59 = null;
            val_30 = this.TimePassed;
            val_59 = null;
            val_37 = mem[InkWars.Model.Model_Constants.TotalTimeToReachEnemyGrid.Length + 32];
            val_37 = InkWars.Model.Model_Constants.TotalTimeToReachEnemyGrid.Length + 32;
            goto label_110;
            label_105:
            val_60 = null;
            val_60 = null;
            if(this.TimePassed >= 0)
            {
                goto label_115;
            }
            
            val_61 = null;
            val_61 = null;
            val_30 = mem[UnityEngine.Mathf.__il2cppRuntimeField_127 + 32];
            val_30 = UnityEngine.Mathf.__il2cppRuntimeField_127 + 32;
            val_62 = val_30;
            float val_13 = UnityEngine.Mathf.InverseLerp(a:  val_62, b:  null, value:  this.TimePassed);
            val_63 = 1;
            goto label_124;
            label_115:
            val_64 = null;
            val_30 = this.TimePassed;
            val_64 = null;
            if(val_30 >= 0)
            {
                goto label_129;
            }
            
            if(this.BubbleType == 7)
            {
                goto label_148;
            }
            
            bool val_14 = GenericFunctions.IsSuperType(bubbleType:  this.BubbleType);
            if(((val_14 == true) || ((val_14.IsRingEmpty(player:  this.Player, ringIndex:  0)) == true)) || ((val_1.HasBattleEnhancer(type:  1)) == true))
            {
                goto label_148;
            }
            
            this.PositionState = 2;
            val_65 = null;
            val_65 = null;
            val_30 = mem[UnityEngine.Mathf.__il2cppRuntimeField_127 + 32];
            val_30 = UnityEngine.Mathf.__il2cppRuntimeField_127 + 32;
            val_62 = val_30;
            float val_17 = UnityEngine.Mathf.InverseLerp(a:  val_62, b:  null, value:  this.TimePassed);
            goto label_157;
            label_129:
            val_66 = null;
            val_30 = this.TimePassed;
            val_66 = null;
            if(val_30 >= 0)
            {
                goto label_148;
            }
            
            val_67 = null;
            val_67 = null;
            val_30 = mem[UnityEngine.Mathf.__il2cppRuntimeField_127 + 32];
            val_30 = UnityEngine.Mathf.__il2cppRuntimeField_127 + 32;
            val_62 = val_30;
            float val_18 = UnityEngine.Mathf.InverseLerp(a:  val_62, b:  null, value:  this.TimePassed);
            val_63 = 3;
            label_124:
            this.PositionState = val_63;
            goto label_157;
            label_148:
            bool val_19 = this.Damage(responsiblePlayer:  this.Player.ID, forceKill:  true, isCrossBubbleHit:  false);
            return;
            label_164:
            if(W1 != 1)
            {
                goto label_165;
            }
            
            val_34 = 1179403647;
            val_7.Add(driver:  public System.Void List.Enumerator<InkWars.Model.Model_Bubble>::Dispose(), rectTransform:  null, drivenProperties:  null);
            if((W22 & 1) == 0)
            {
                    val_68 = mem[X23];
                val_68 = X23;
                if((((X23 + 295) & 2) != 0) && ((X23 + 216) == 0))
            {
                    val_68 = mem[X23];
                val_68 = X23;
            }
            
                if(this.TimePassed > (X23 + 184 + 156))
            {
                    if(this.BubbleType == 8)
            {
                    float val_35 = this.Player.buff.GetBuffValueSec(aNewType:  2);
                float val_25 = val_31.buff.GetBuffValueSec(aNewType:  3);
                val_25 = val_35 - val_25;
                val_35 = (((this.Player.HasBattleEnhancer(type:  3)) != true) ? 20f : 15f) + val_25;
                if(val_31 != null)
            {
                    float val_36 = this.Player.StunnedTime;
                val_36 = val_35 + val_36;
                mem2[0] = 0;
                val_36 = val_36 + (this.Player + 68 + 4);
                mem2[0] = val_36;
                val_34 = this.Player + 68 + -40;
                val_69 = InkWars.Model.Model_Events.Instance;
            }
            else
            {
                    val_31 = 68;
                val_25 = val_35 + (7.006492E-45f);
                mem[68] = val_25;
                val_25 = mem[68] + 0f;
                mem[68] = val_25;
                mem[72] = 0;
                val_69 = InkWars.Model.Model_Events.Instance;
                val_34 = 0;
            }
            
                if(val_27.OnStunned != null)
            {
                    val_27.OnStunned.Invoke(playerId:  val_34, stunLevel:  mem[68], isRevengeStun:  true);
            }
            
            }
            
                bool val_28 = this.Damage(responsiblePlayer:  this.Player.ID, forceKill:  true, isCrossBubbleHit:  false);
            }
            
            }
            
            val_70 = mem[X23];
            val_70 = X23;
            val_30 = this.TimePassed;
            if((((X23 + 295) & 2) != 0) && ((X23 + 216) == 0))
            {
                    val_70 = mem[X23];
                val_70 = X23;
            }
            
            val_37 = mem[X23 + 184 + 156];
            val_37 = X23 + 184 + 156;
            label_110:
            val_62 = val_30 / val_37;
            label_157:
            this.PositionTimeNormalized = val_62;
            return;
            label_165:
        }
        private bool IsRingEmpty(InkWars.Model.Model_Player player, int ringIndex)
        {
            InkWars.Model.Model_Bubble[] val_2;
            var val_3;
            if(ringIndex == 1)
            {
                goto label_0;
            }
            
            if(ringIndex != 0)
            {
                goto label_1;
            }
            
            val_2 = player.OuterRing;
            goto label_5;
            label_0:
            val_2 = player.MiddleRing;
            goto label_5;
            label_1:
            val_2 = player.InnerRing;
            label_5:
            var val_2 = 0;
            label_11:
            if(val_2 >= (mem[player.InnerRing] + 24))
            {
                goto label_8;
            }
            
            var val_1 = mem[player.InnerRing] + 0;
            val_2 = val_2 + 1;
            if(((mem[player.InnerRing] + 0) + 32 + 16) == 0)
            {
                goto label_11;
            }
            
            val_3 = 0;
            return (bool)val_3;
            label_8:
            val_3 = 1;
            return (bool)val_3;
        }
        private void Update_Grid(float deltaTime)
        {
        
        }
        private void Update_Ink(float deltaTime)
        {
        
        }
        public void SetScoreAndPopDelay(int score, float popDelay, InkWars.Model.Player scoreTarget, HitComboType comboType)
        {
            var val_1;
            InkWars.Model.BubbleTypes val_1 = this.TypeBeforePop;
            this._Score = score;
            this.activeTypeSwitchAnim = false;
            val_1 = val_1 - 12;
            if(val_1 <= 2)
            {
                    val_1 = null;
                val_1 = null;
                this._Score = InkWars.Model.Model_Constants.Score_BubblePop_SPD;
            }
            
            this._PopDelay = popDelay;
            this.Pop = true;
            this._scoreTargetID = scoreTarget;
            this.ComboType = comboType;
        }
        public bool IsBubbleSPD()
        {
            InkWars.Model.BubbleTypes val_2 = this.BubbleType;
            if(val_2 == 12)
            {
                    return true;
            }
            
            val_2 = val_2 - 13;
            return (bool)(val_2 < 2) ? 1 : 0;
        }
        public bool Damage(InkWars.Model.Player responsiblePlayer, bool forceKill = False, bool isCrossBubbleHit = False)
        {
            var val_10;
            InkWars.Model.BubbleStates val_11;
            var val_12;
            var val_13;
            int val_14;
            val_11 = this;
            InkWars.Model.BubbleTypes val_10 = this.BubbleType;
            val_10 = val_10 - 12;
            int val_1 = this.Health - 1;
            this.Health = val_1;
            if(val_10 > 2)
            {
                goto label_4;
            }
            
            if(this.Health == 1)
            {
                goto label_2;
            }
            
            if(this.Health == 2)
            {
                goto label_3;
            }
            
            if(this.Health != 3)
            {
                goto label_4;
            }
            
            val_12 = 12;
            goto label_6;
            label_2:
            val_12 = 14;
            goto label_6;
            label_3:
            val_12 = 13;
            label_6:
            this.BubbleType = 13;
            label_4:
            val_1 = forceKill | (val_1 >> 31);
            val_1 = val_1 + 7;
            val_1 = val_1 & 7;
            if(val_1 != false)
            {
                    val_13 = 0;
                return (bool)val_13;
            }
            
            InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
            if(val_3.Model.gamePhase == 1)
            {
                    this.TypeBeforePop = this.BubbleType;
            }
            
            val_14 = 0;
            this.BubbleType = 0;
            this.Health = val_14;
            int val_4 = val_14;
            if(this.BubbleState == 2)
            {
                    if((this.TryFindBubbleInRing(ring:  this.Player.OuterRing, ringId: out  val_4)) != false)
            {
                    val_14 = 0;
            }
            else
            {
                    if((this.TryFindBubbleInRing(ring:  this.Player.MiddleRing, ringId: out  val_4)) != false)
            {
                    val_14 = 1;
            }
            else
            {
                    if((this.TryFindBubbleInRing(ring:  this.Player.InnerRing, ringId: out  val_4)) != false)
            {
                    val_14 = 2;
            }
            else
            {
                    UnityEngine.Debug.LogError(message:  "Cannot find grid bubble popped");
                val_14 = 0;
            }
            
            }
            
            }
            
            }
            
            InkWars.Model.Model_Events val_8 = InkWars.Model.Model_Events.Instance;
            val_11 = this.BubbleState;
            val_10 = val_4;
            if(val_8.OnBubblePop != null)
            {
                    val_8.OnBubblePop.Invoke(state:  val_11, responsiblePlayer:  responsiblePlayer, targetPlayer:  this.Player.ID, ring:  0, index:  0, isCrossBubbleHit:  isCrossBubbleHit);
            }
            
            val_13 = 1;
            return (bool)val_13;
        }
        private bool TryFindBubbleInRing(InkWars.Model.Model_Bubble[] ring, out int ringId)
        {
            int val_1;
            var val_2;
            val_1 = 0;
            goto label_0;
            label_4:
            if(ring[0] == this)
            {
                goto label_2;
            }
            
            val_1 = 1;
            label_0:
            if(val_1 < ring.Length)
            {
                goto label_4;
            }
            
            val_2 = 0;
            goto label_5;
            label_2:
            val_2 = 1;
            label_5:
            ringId = val_1;
            return (bool)val_2;
        }
    
    }

}
