using UnityEngine;

namespace InkWars.Model
{
    [Serializable]
    public class Model_Core
    {
        // Fields
        public bool Feature_InkEmUp;
        public bool Feature_StunBreak;
        public InkWars.Model.Model_Core.PowerupFeatureMode Feature_Powerup;
        public bool Feature_PlayerNamePlates;
        public bool Feature_BattleEnhancer;
        public bool Feature_PlayeRankPlates;
        private bool ModelStarted;
        public InkWars.Model.Model_Player Player1;
        public InkWars.Model.Model_Player Player2;
        public InkWars.Model.Model_Player WinningPlayer;
        public InkWars.Model.GamePhase gamePhase;
        public float GameTime;
        public bool PlayersFlippedLocally;
        public float PauseForRevengeSuper;
        public float PauseForStunBreak;
        public float DoubleKOGraceTime;
        public int CountdownTime;
        private InkWars.Model.GameResult _gameResult;
        private bool _isGameResultForEndGameSet;
        public InkWars.Model.Model_Core.InkEmUp_Phase InkEmUp_CurrentPhase;
        public InkWars.Model.Model_Player InkEmUp_Player;
        public InkWars.Model.Model_Bubble[] InkEmUp_InkBubbles;
        public int InkEmUp_InkIndex;
        public float InkEmUp_TimeRemaining;
        internal int PuzzleBubblesLeft;
        
        // Properties
        public InkWars.Model.Model_Player LeftPlayer { get; }
        public InkWars.Model.Model_Player RightPlayer { get; }
        public InkWars.Model.GameResult GameResult { get; set; }
        public float TimeLeft { get; }
        
        // Methods
        public Model_Core()
        {
            this.DoubleKOGraceTime = 0.09970702f;
            this.CountdownTime = 0;
            this.InkEmUp_TimeRemaining = 10f;
            InkWars.Model.Model_Player val_1 = new InkWars.Model.Model_Player();
            if(val_1 != null)
            {
                    .Model = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .ID = 0;
            this.Player1 = val_1;
            InkWars.Model.Model_Player val_2 = new InkWars.Model.Model_Player();
            if(val_2 != null)
            {
                    .Model = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .ID = 1;
            this.Player2 = val_2;
        }
        public void SetupFlip()
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            if(Character_GlobalInfo.gameMode == 5)
            {
                goto label_3;
            }
            
            if(Character_GlobalInfo.gameMode != 8)
            {
                goto label_4;
            }
            
            val_6 = DeviceBasedData.playerAtLeftForQuickPlay ^ 1;
            goto label_6;
            label_3:
            val_6 = 0;
            goto label_6;
            label_4:
            val_7 = null;
            val_7 = null;
            bool val_3 = (DataStructs.UserDataDictionary.Settings.FlipNegateX == 1) ? 1 : 0;
            label_6:
            val_3 = val_3 & 1;
            this.PlayersFlippedLocally = val_3;
        }
        public InkWars.Model.Model_Player get_LeftPlayer()
        {
            return (InkWars.Model.Model_Player)(this.PlayersFlippedLocally == false) ? this.Player1 : this.Player2;
        }
        public InkWars.Model.Model_Player get_RightPlayer()
        {
            return (InkWars.Model.Model_Player)(this.PlayersFlippedLocally == false) ? this.Player2 : this.Player1;
        }
        public InkWars.Model.GameResult get_GameResult()
        {
            return (InkWars.Model.GameResult)this._gameResult;
        }
        private void set_GameResult(InkWars.Model.GameResult value)
        {
            var val_13;
            var val_16;
            GameMode val_17;
            if(this._gameResult == value)
            {
                    return;
            }
            
            this._gameResult = value;
            if((value - 1) > 5)
            {
                goto label_2;
            }
            
            var val_11 = 40826808 + ((value - 1)) << 2;
            val_11 = val_11 + 40826808;
            goto (40826808 + ((value - 1)) << 2 + 40826808);
            label_2:
            this.WinningPlayer = 0;
            val_16 = null;
            val_16 = null;
            val_17 = Character_GlobalInfo.gameMode;
            if(val_17 == 6)
            {
                goto label_33;
            }
            
            val_17 = Character_GlobalInfo.gameMode;
            if(val_17 != 10)
            {
                goto label_36;
            }
            
            label_33:
            val_13 = 0;
            NFUser.current.CheckMMOCGemsChangedAfterDelay(delayInSeconds:  15f, diffDir:  0);
            label_36:
            if((value - 4) > 2)
            {
                
            }
            else
            {
                    float val_12 = (float)this.CountdownTime;
                val_12 = val_12 * 1.5f;
                this.GameTime = val_12;
            }
            
            InkWars.Model.Model_Events val_10 = InkWars.Model.Model_Events.Instance;
            if(val_10.OnGameResult != null)
            {
                    val_10.OnGameResult.Invoke(result:  this._gameResult, afterFinished:  false);
            }
            
            this.gamePhase = 2;
            this.MatchConclusion();
        }
        public float get_TimeLeft()
        {
            if(this.CountdownTime == 1)
            {
                    return -1f;
            }
            
            float val_2 = (float)this.CountdownTime;
            float val_1 = -1.5f;
            val_1 = this.GameTime / val_1;
            val_2 = val_2 + val_1;
            return UnityEngine.Mathf.Max(a:  val_2, b:  0f);
        }
        public void Update(float deltaTime)
        {
            if(this.ModelStarted != true)
            {
                    this.ModelStarted = true;
                this._isGameResultForEndGameSet = false;
                InkWars.Model.Model_Events val_1 = InkWars.Model.Model_Events.Instance;
                if(val_1.OnModelStart != null)
            {
                    val_1.OnModelStart.Invoke();
            }
            
            }
            
            if(this.Player1.IsReady == false)
            {
                    return;
            }
            
            if(this.Player2.IsReady == false)
            {
                    return;
            }
            
            if(this.gamePhase < 1)
            {
                    return;
            }
            
            float val_4 = this.PauseForRevengeSuper;
            if(val_4 > 0f)
            {
                    val_4 = val_4 - deltaTime;
                this.PauseForRevengeSuper = (val_4 <= 0f) ? 0f : (val_4);
                return;
            }
            
            float val_5 = this.PauseForStunBreak;
            if(val_5 > 0f)
            {
                    val_5 = val_5 - deltaTime;
                this.PauseForStunBreak = (val_5 <= 0f) ? 0f : (val_5);
                return;
            }
            
            this.InkEmUp_Update(deltaTime:  deltaTime);
            this.Player1.Update(deltaTime:  deltaTime);
            this.Player2.Update(deltaTime:  deltaTime);
            if(this._gameResult != 0)
            {
                    return;
            }
            
            float val_6 = this.GameTime;
            val_6 = val_6 + deltaTime;
            this.GameTime = val_6;
            this.CheckIfGameIsEnded(deltaTime:  deltaTime);
        }
        public void CheckIfGameIsEnded(float deltaTime)
        {
            var val_3;
            var val_20;
            float val_21;
            InkWars.Model.GameResult val_22;
            InkWars.Model.Model_Player val_23;
            if(this._isGameResultForEndGameSet != false)
            {
                    return;
            }
            
            val_20 = null;
            val_20 = null;
            if(Character_GlobalInfo.gameMode != 3)
            {
                goto label_4;
            }
            
            List.Enumerator<T> val_1 = this.Player1.TargetBubbles.GetEnumerator();
            label_9:
            if(((-1122545600) & 1) == 0)
            {
                goto label_7;
            }
            
            System.Type val_4 = val_3.InitialType;
            if(val_4._impl == 0)
            {
                goto label_9;
            }
            
            val_3.Add(driver:  public System.Void List.Enumerator<InkWars.Model.Model_Bubble>::Dispose(), rectTransform:  null, drivenProperties:  null);
            return;
            label_4:
            if(this.TimeLeft != 0f)
            {
                goto label_12;
            }
            
            if(this.Player1.BubbleCount != this.Player2.BubbleCount)
            {
                goto label_14;
            }
            
            this.GameResult = 6;
            this.Player1.Destroy_RemainingBubbles(scorePerBubble:  0);
            goto label_16;
            label_12:
            if(this.Player1.NoBubblesLeft != true)
            {
                    if(this.Player2.NoBubblesLeft == false)
            {
                    return;
            }
            
            }
            
            val_21 = this.DoubleKOGraceTime;
            if(val_21 > 0f)
            {
                goto label_20;
            }
            
            if((this.Player1.NoBubblesLeft == false) || (this.Player2.NoBubblesLeft == false))
            {
                goto label_24;
            }
            
            val_22 = 3;
            goto label_25;
            label_14:
            if(this.Player1.BubbleCount <= this.Player2.BubbleCount)
            {
                goto label_28;
            }
            
            this.WinningPlayer = this.Player1;
            this.GameResult = 4;
            label_16:
            if(this.Player2 != null)
            {
                goto label_32;
            }
            
            label_33:
            label_32:
            this.Player2.Destroy_RemainingBubbles(scorePerBubble:  0);
            goto label_30;
            label_7:
            val_3.Add(driver:  public System.Void List.Enumerator<InkWars.Model.Model_Bubble>::Dispose(), rectTransform:  null, drivenProperties:  null);
            goto label_42;
            label_28:
            this.WinningPlayer = this.Player2;
            this.GameResult = 5;
            if(this.Player1 != null)
            {
                goto label_32;
            }
            
            goto label_33;
            label_24:
            if(this.Player2.NoBubblesLeft == false)
            {
                goto label_35;
            }
            
            this.WinningPlayer = this.Player1;
            goto label_36;
            label_35:
            if(this.Player1.NoBubblesLeft == false)
            {
                    return;
            }
            
            this.WinningPlayer = this.Player2;
            goto label_39;
            label_42:
            if(this.Player1.NoBubblesLeft == true)
            {
                goto label_44;
            }
            
            val_23 = this;
            if(this.Player2.NoBubblesLeft == false)
            {
                goto label_46;
            }
            
            label_44:
            val_21 = this.DoubleKOGraceTime;
            if(val_21 <= 0f)
            {
                goto label_47;
            }
            
            label_20:
            val_21 = val_21 - deltaTime;
            this.DoubleKOGraceTime = val_21;
            return;
            label_47:
            val_23 = this.Player2;
            label_46:
            if(mem[this.Player2].NoBubblesLeft == false)
            {
                goto label_50;
            }
            
            label_36:
            this.GameResult = 1;
            this._isGameResultForEndGameSet = true;
            return;
            label_50:
            if(this.Player1.NoBubblesLeft == false)
            {
                    return;
            }
            
            label_39:
            val_22 = 2;
            label_25:
            this.GameResult = val_22;
            label_30:
            this._isGameResultForEndGameSet = true;
        }
        public void SetGameEndResult(InkWars.Model.GameResult result)
        {
            if(this._isGameResultForEndGameSet != false)
            {
                    return;
            }
            
            this._isGameResultForEndGameSet = true;
            this.GameResult = result;
        }
        public void ShootBubble(InkWars.Model.Player PlayerNumber, InkWars.Model.AimTarget aimTarget)
        {
            this.AimLine(PlayerNumber:  PlayerNumber, aimTarget:  aimTarget);
            var val_1 = (PlayerNumber != 0) ? this.Player2 : this.Player1;
            mem2[0] = 1;
        }
        public void AimLine(InkWars.Model.Player PlayerNumber, InkWars.Model.AimTarget aimTarget)
        {
            (PlayerNumber != 0) ? this.Player2 : this.Player1.TryAimAt = aimTarget;
        }
        public void SwitchBubble(InkWars.Model.Player PlayerNumber)
        {
            var val_1 = (PlayerNumber != 0) ? this.Player2 : this.Player1;
            mem2[0] = 1;
        }
        public InkWars.Model.Model_Player GetPlayer(InkWars.Model.Player PlayerNumber)
        {
            return (InkWars.Model.Model_Player)(PlayerNumber != 0) ? this.Player2 : this.Player1;
        }
        public InkWars.Model.Model_Player GetPlayerWithFlip(InkWars.Model.Player PlayerNumber)
        {
            return (InkWars.Model.Model_Player)(PlayerNumber != 0) ? ((this.PlayersFlippedLocally == false) ? this.Player2 : this.Player1) : ((this.PlayersFlippedLocally == false) ? this.Player1 : this.Player2);
        }
        public static void Log(string logdata)
        {
            UnityEngine.MonoBehaviour.print(message:  logdata);
        }
        private void MatchConclusion()
        {
            InkWars.Model.Model_Player val_96;
            InkWars.Model.GameResult val_97;
            var val_98;
            var val_123;
            this.Player1.Finish();
            this.Player2.Finish();
            if(this.Feature_InkEmUp != false)
            {
                    this.InkEmUp_ActivatedCheck();
            }
            
            if(this.WinningPlayer == null)
            {
                goto label_4;
            }
            
            this.WinningPlayer.MatchEndScoreCalculation();
            var val_1 = (this.WinningPlayer.ID != 1) ? (this.Player2) : (this.Player1);
            if(val_1 != 0)
            {
                goto label_43;
            }
            
            label_44:
            label_43:
            val_1.Destroy_RemainingBubbles(scorePerBubble:  0);
            val_96 = 1152921505064992768;
            val_97 = this._gameResult;
            val_98 = null;
            var val_2 = (val_97 == 1) ? 1 : 0;
            val_98 = null;
            GameMode val_96 = Character_GlobalInfo.gameMode;
            val_96 = val_96 - 1;
            if(val_96 > 5)
            {
                goto label_76;
            }
            
            var val_97 = 40826832 + ((Character_GlobalInfo.gameMode - 1)) << 2;
            val_97 = val_97 + 40826832;
            goto (40826832 + ((Character_GlobalInfo.gameMode - 1)) << 2 + 40826832);
            label_4:
            this.Player1.Destroy_RemainingBubbles(scorePerBubble:  0);
            if(this.Player2 != null)
            {
                goto label_43;
            }
            
            goto label_44;
            label_76:
            val_123 = null;
            if((Character_GlobalInfo.gameMode - 1) >= 4)
            {
                goto label_185;
            }
            
            val_96 = this.Player1;
            NewUnlocks val_91 = AvatarTitleUnlockChecker.CheckUnlocks_Adventure(charID:  this.Player1.Name, victorious:   | ((val_97 == 4) ? 1 : 0), resetPrevResult:  true);
            goto label_193;
            label_185:
            if(Character_GlobalInfo.gameMode == 5)
            {
                goto label_188;
            }
            
            if(Character_GlobalInfo.gameMode != 6)
            {
                goto label_193;
            }
            
            val_96 = this.Player2.Name;
            NetworkUserInfo val_92 = CloudOpponent.current;
            NewUnlocks val_93 = AvatarTitleUnlockChecker.CheckUnlocks_PVP_NetworkRanked(charID:  this.Player1.Name, opponentCharID:  val_96, opponentPlayerID:  val_92.userName, result:  this._gameResult, resetPrevResult:  true);
            goto label_193;
            label_188:
            NewUnlocks val_94 = AvatarTitleUnlockChecker.CheckUnlocks_PVP_Local(result:  this._gameResult, resetPrevResult:  true);
            label_193:
            InkWars.Model.Model_Events val_95 = InkWars.Model.Model_Events.Instance;
            if(val_95.OnGameResult == null)
            {
                    return;
            }
            
            val_95.OnGameResult.Invoke(result:  this._gameResult, afterFinished:  true);
        }
        public void OnBeforePostMatch()
        {
            int val_74;
            var val_75;
            InkWars.Model.GameResult val_76;
            bool val_77;
            var val_78;
            val_74 = this;
            val_75 = null;
            val_75 = null;
            val_76 = this._gameResult;
            GameMode val_3 = Character_GlobalInfo.gameMode - 1;
            val_77 = ((val_76 == 1) ? 1 : 0) | ((val_76 == 4) ? 1 : 0);
            if(val_3 <= 3)
            {
                    if(Character_GlobalInfo.gameMode == 1)
            {
                    if(Character_GlobalInfo.stage_CurrentLevel == 12)
            {
                goto label_9;
            }
            
            }
            
                NewUnlocks val_5 = AvatarTitleUnlockChecker.CheckUnlocks_Adventure(charID:  this.Player1.Name, victorious:  val_77, resetPrevResult:  false);
                val_78 = null;
                val_78 = null;
                DataStructs.UserDataDictionary.Stats.ApplyCurrentAdventureStats(isPlayerWins:  val_77);
            }
            
            label_9:
            if(val_3 > 5)
            {
                    return;
            }
            
            var val_73 = 40826872;
            val_73 = (40826872 + ((Character_GlobalInfo.gameMode - 1)) << 2) + val_73;
            goto (40826872 + ((Character_GlobalInfo.gameMode - 1)) << 2 + 40826872);
        }
        private void InkEmUp_Update(float deltaTime)
        {
            if(this.Feature_InkEmUp == false)
            {
                    return;
            }
            
            InkEmUp_Phase val_7 = this.InkEmUp_CurrentPhase;
            val_7 = val_7 - 1;
            if(val_7 > 3)
            {
                    return;
            }
            
            var val_8 = 40826856 + ((this.InkEmUp_CurrentPhase - 1)) << 2;
            val_8 = val_8 + 40826856;
            goto (40826856 + ((this.InkEmUp_CurrentPhase - 1)) << 2 + 40826856);
        }
        private void InkEmUp_ActivatedCheck()
        {
            var val_3;
            var val_4;
            if(this.Feature_InkEmUp == false)
            {
                    return;
            }
            
            if(this._gameResult == 2)
            {
                goto label_2;
            }
            
            if((this._gameResult != 1) || ((this.InkEmUp_PlayerCheck(winner:  this.Player1)) == false))
            {
                goto label_9;
            }
            
            val_3 = null;
            val_3 = null;
            DataStructs.UserDataDictionary.Stats.Increment_InkingSequencesTriggered();
            goto label_9;
            label_2:
            if((this.InkEmUp_PlayerCheck(winner:  this.Player2)) != false)
            {
                    val_4 = null;
                val_4 = null;
                DataStructs.UserDataDictionary.Stats.Increment_BeenInked();
            }
            
            label_9:
            if(this.InkEmUp_Player != null)
            {
                    return;
            }
            
            this.Feature_InkEmUp = false;
        }
        private bool InkEmUp_PlayerCheck(InkWars.Model.Model_Player winner)
        {
            var val_4;
            int val_1 = CharacterHelper.GetMinBubbleCountForInkSequence(winnerId:  winner.Name);
            int val_2 = winner.BubbleCount;
            this.InkEmUp_CurrentPhase = (val_2 >= val_1) ? 1 : 0;
            if(val_2 < val_1)
            {
                    val_4 = 0;
                return (bool)val_4;
            }
            
            val_4 = 1;
            this.InkEmUp_Player = winner;
            return (bool)val_4;
        }
        private void InkEmUp_ConvertToInk()
        {
            this.InkEmUp_InkIndex = 0;
            int val_1 = this.InkEmUp_Player.BubbleCount;
            this.InkEmUp_InkBubbles = new InkWars.Model.Model_Bubble[0];
            this.ConvertToInk(ring:  this.InkEmUp_Player.InnerRing);
            this.ConvertToInk(ring:  this.InkEmUp_Player.MiddleRing);
            this.ConvertToInk(ring:  this.InkEmUp_Player.OuterRing);
            this.InkEmUp_InkIndex = 0;
        }
        private void ConvertToInk(InkWars.Model.Model_Bubble[] ring)
        {
            goto label_0;
            label_8:
            if(ring[0x0][0].BubbleType != 0)
            {
                    this.InkEmUp_InkBubbles[this.InkEmUp_InkIndex] = ring[0];
                int val_2 = this.InkEmUp_InkIndex;
                val_2 = val_2 + 1;
                this.InkEmUp_InkIndex = val_2;
                ring[0x0][0].BubbleState = 3;
                ring[0x0][0].Player = this.InkEmUp_Player;
                ring[0x0][0].BubbleType = 11;
            }
            
            0 = 1;
            label_0:
            if(0 < ring.Length)
            {
                goto label_8;
            }
        
        }
    
    }

}
