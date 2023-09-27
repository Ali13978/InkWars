using UnityEngine;

namespace DataStructs
{
    public class Stats : FirebaseDictionalizer
    {
        // Fields
        private DataStructs.Dictionalizer.CharacterStatsDictionary charactersStatsPVP;
        private System.Collections.Generic.Dictionary<string, string> listOpponentID;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt playerPoints;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt localPvPMatches;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt itemsBougth;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt allTimeHighScore;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt allTimeHighBP;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString allTimeHighCharacter;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt totalAdventureGames;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt firedStunner;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt firedIron;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt firedColorEraserBall;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt firedTotalShots;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt ink_Sequences;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt maximum_Chains;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt biggest_Combo;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt mostInkBubbles;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt puzzlesMinimumShots;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt battlesNoPower;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt shareScreenCount;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt inviteCount;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt fastestVictory;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt winStreak_Longest;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt winStreak_Current;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt mostBubblesRetained;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt totalMatches_Started;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt totalMatches_Completed;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt inkingSequencesTriggered;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt beenInked;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt techniques_ReboundSave;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt techniques_ReboundSuicide;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt techniques_ReboundInterception;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt techniques_ReboundCounter;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt techniques_BeenIntercepted;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt techniques_BeenCountered;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt superBubbleShot_Stunner;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt superBubbleShot_CannonBall;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt superBubbleShot_Eraser;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt superBubbleShot_RainbowTransformer;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt superBubbleShot_Virus;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt stunBreaks;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt biggestCombo_Ring;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt biggestCombo_Cross;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt biggestCombo_Bridge;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt biggestCombo_CrossBridge;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt publicMatch_currentLevel;
        private static DataStructs.Stats.AdventureOneMatchStats currAdvStats;
        
        // Properties
        public override string keyName { get; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt PlayerPoints { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt LocalPvPMatches { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt NetworkPvPMatchesPlayed { get; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt ItemsBougth { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt NetworkWins { get; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt NetworkLoses { get; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt NetworkDraws { get; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt AllTimeHighScore { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt AllTimeHighBP { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString AllTimeHighCharacter { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt TotalAdventureGames { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt FiredStunner { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt FiredIron { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt FiredColorEraserBall { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt FiredTotalShots { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Ink_Sequences { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Maximum_Chains { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt BubblesShot { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Biggest_Combo { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt MostInkBubbles { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt PuzzlesMinimumShots { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt BattlesNoPower { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt ShareScreenCount { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt InviteCount { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt FastestVictory { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt WinStreak_Longest { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt WinStreak_Current { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt MostBubblesRetained { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt TotalMatches_Started { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt TotalMatches_Completed { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt InkingSequencesTriggered { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt BeenInked { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Techniques_ReboundSave { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Techniques_ReboundSuicide { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Techniques_ReboundInterception { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Techniques_ReboundCounter { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Techniques_BeenIntercepted { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Techniques_BeenCountered { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SuperBubbleShot_Stunner { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SuperBubbleShot_CannonBall { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SuperBubbleShot_RainbowTransformer { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SuperBubbleShot_Virus { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SuperBubbleShot_Eraser { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt StunBreaks { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt BiggestCombo_Ring { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt BiggestCombo_Cross { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt BiggestCombo_Bridge { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt BiggestCombo_CrossBridge { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt PublicMatch_CurrentLevel { get; set; }
        public DataStructs.PlayerRank CurrentCharacterRank { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt CurrentCharacterBP { get; set; }
        public CharacterNameID AllTimeBestCharacter { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt DayPassedSinceSignUp { get; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt TotalPVPWins { get; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt TotalPVPLosses { get; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt TotalPVPDraws { get; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat AverageShots { get; }
        
        // Methods
        public override string get_keyName()
        {
            return "stats";
        }
        public Stats()
        {
            val_1 = new System.Object();
            mem[1152921529219160288] = 0;
            mem[1152921529219160296] = 0;
        }
        protected override void CustomInitAfterLoadDefaults()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  2147483647);
            this.FastestVictory = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
            this.AllTimeBestCharacter = 20;
        }
        public string GetListOpponentID(string key, string defaultValue)
        {
            string val_2 = defaultValue;
            bool val_3 = this.listOpponentID.TryGetValue(key:  key.Replace(oldValue:  ".", newValue:  ""), value: out  val_2);
            return val_2;
        }
        public void SetListOpponentID(string key, string aNewValue)
        {
            string val_5;
            if(aNewValue == null)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  key)) == true)
            {
                    return;
            }
            
            string val_2 = key.Replace(oldValue:  ".", newValue:  "");
            bool val_3 = this.listOpponentID.ContainsKey(key:  val_2);
            if(this.listOpponentID == null)
            {
                goto label_5;
            }
            
            if(val_3 == false)
            {
                goto label_6;
            }
            
            label_9:
            val_5 = val_2;
            this.listOpponentID.set_Item(key:  val_5, value:  aNewValue);
            if(val_2 != null)
            {
                goto label_10;
            }
            
            goto label_8;
            label_5:
            if(val_3 == true)
            {
                goto label_9;
            }
            
            label_6:
            val_5 = val_2;
            this.listOpponentID.Add(key:  val_5, value:  aNewValue);
            if(val_2 != null)
            {
                goto label_10;
            }
            
            label_8:
            label_10:
            this.SaveVariableImmediately(name:  "listOpponentID." + val_2, obj:  aNewValue);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_PlayerPoints()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.playerPoints, hiddenValue = this.playerPoints, inited = false};
        }
        public void set_PlayerPoints(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Max(a:  0, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = value.currentCryptoKey, hiddenValue = value.hiddenValue, fakeValue = value.fakeValue, inited = value.inited})));
            this.playerPoints = val_3;
            mem[1152921529219807576] = val_3.fakeValue;
            mem[1152921529219807580] = val_3.inited;
            this.SaveVariableImmediately(name:  "playerPoints", obj:  val_3);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_LocalPvPMatches()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.localPvPMatches, hiddenValue = this.localPvPMatches, inited = false};
        }
        public void set_LocalPvPMatches(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.localPvPMatches = value;
            mem[1152921529220041944] = value.fakeValue;
            mem[1152921529220041948] = value.inited;
            this.SaveVariableImmediately(name:  "localPvPMatches", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_NetworkPvPMatchesPlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = this.TotalPVPWins;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = this.TotalPVPLosses;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = this.TotalPVPDraws;
            int val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited});
            val_6 = ((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited})) + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited}))) + val_6;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_6);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_ItemsBougth()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.itemsBougth, hiddenValue = this.itemsBougth, inited = false};
        }
        public void set_ItemsBougth(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.itemsBougth = value;
            mem[1152921529220388296] = value.fakeValue;
            mem[1152921529220388300] = value.inited;
            this.SaveVariable(name:  "itemsBougth", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_NetworkWins()
        {
            return this.TotalPVPWins;
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_NetworkLoses()
        {
            return this.TotalPVPLosses;
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_NetworkDraws()
        {
            return this.TotalPVPDraws;
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_AllTimeHighScore()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.allTimeHighScore, hiddenValue = this.allTimeHighScore, inited = false};
        }
        public void set_AllTimeHighScore(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.allTimeHighScore = value;
            mem[1152921529220958664] = value.fakeValue;
            mem[1152921529220958668] = value.inited;
            this.SaveVariable(name:  "allTimeHighScore", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_AllTimeHighBP()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.allTimeHighBP, hiddenValue = this.allTimeHighBP, inited = false};
        }
        public void set_AllTimeHighBP(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.allTimeHighBP = value;
            mem[1152921529221193016] = value.fakeValue;
            mem[1152921529221193020] = value.inited;
            this.SaveVariable(name:  "allTimeHighBP", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_AllTimeHighCharacter()
        {
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)this.allTimeHighCharacter;
        }
        public void set_AllTimeHighCharacter(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            this.allTimeHighCharacter = value;
            this.SaveVariable(name:  "allTimeHighCharacter", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_TotalAdventureGames()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.totalAdventureGames, hiddenValue = this.totalAdventureGames, inited = false};
        }
        public void set_TotalAdventureGames(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.totalAdventureGames = value;
            mem[1152921529221667888] = value.fakeValue;
            mem[1152921529221667892] = value.inited;
            this.SaveVariable(name:  "totalAdventureGames", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_FiredStunner()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.firedStunner, hiddenValue = this.firedStunner, inited = false};
        }
        public void set_FiredStunner(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.firedStunner = value;
            mem[1152921529221902240] = value.fakeValue;
            mem[1152921529221902244] = value.inited;
            this.SaveVariableImmediately(name:  "firedStunner", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_FiredIron()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.firedIron, hiddenValue = this.firedIron, inited = false};
        }
        public void set_FiredIron(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.firedIron = value;
            mem[1152921529222136592] = value.fakeValue;
            mem[1152921529222136596] = value.inited;
            this.SaveVariableImmediately(name:  "firedIron", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_FiredColorEraserBall()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.firedColorEraserBall, hiddenValue = this.firedColorEraserBall, inited = false};
        }
        public void set_FiredColorEraserBall(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.firedColorEraserBall = value;
            mem[1152921529222370960] = value.fakeValue;
            mem[1152921529222370964] = value.inited;
            this.SaveVariableImmediately(name:  "firedColorEraserBall", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_FiredTotalShots()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.firedTotalShots, hiddenValue = this.firedTotalShots, inited = false};
        }
        public void set_FiredTotalShots(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.firedTotalShots = value;
            mem[1152921529222605328] = value.fakeValue;
            mem[1152921529222605332] = value.inited;
            this.SaveVariableImmediately(name:  "firedTotalShots", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Ink_Sequences()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.ink_Sequences, hiddenValue = this.ink_Sequences, inited = false};
        }
        public void set_Ink_Sequences(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.ink_Sequences = value;
            mem[1152921529222839680] = value.fakeValue;
            mem[1152921529222839684] = value.inited;
            this.SaveVariableImmediately(name:  "ink_Sequences", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Maximum_Chains()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.maximum_Chains, hiddenValue = this.maximum_Chains, inited = false};
        }
        public void set_Maximum_Chains(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.maximum_Chains = value;
            mem[1152921529223074032] = value.fakeValue;
            mem[1152921529223074036] = value.inited;
            this.SaveVariableImmediately(name:  "maximum_Chains", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_BubblesShot()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.firedTotalShots, hiddenValue = this.firedTotalShots, inited = false};
        }
        public void set_BubblesShot(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.FiredTotalShots = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = value.currentCryptoKey, hiddenValue = value.hiddenValue, fakeValue = value.fakeValue, inited = value.inited};
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Biggest_Combo()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.biggest_Combo, hiddenValue = this.biggest_Combo, inited = false};
        }
        public void set_Biggest_Combo(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.biggest_Combo = value;
            mem[1152921529223532384] = value.fakeValue;
            mem[1152921529223532388] = value.inited;
            this.SaveVariableImmediately(name:  "biggest_Combo", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_MostInkBubbles()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.mostInkBubbles, hiddenValue = this.mostInkBubbles, inited = false};
        }
        public void set_MostInkBubbles(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.mostInkBubbles = value;
            mem[1152921529223766736] = value.fakeValue;
            mem[1152921529223766740] = value.inited;
            this.SaveVariable(name:  "mostInkBubbles", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_PuzzlesMinimumShots()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.puzzlesMinimumShots, hiddenValue = this.puzzlesMinimumShots, inited = false};
        }
        public void set_PuzzlesMinimumShots(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.puzzlesMinimumShots = value;
            mem[1152921529224001104] = value.fakeValue;
            mem[1152921529224001108] = value.inited;
            this.SaveVariableImmediately(name:  "puzzlesMinimumShots", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_BattlesNoPower()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.battlesNoPower, hiddenValue = this.battlesNoPower, inited = false};
        }
        public void set_BattlesNoPower(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.battlesNoPower = value;
            mem[1152921529224235456] = value.fakeValue;
            mem[1152921529224235460] = value.inited;
            this.SaveVariableImmediately(name:  "battlesNoPower", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_ShareScreenCount()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.shareScreenCount, hiddenValue = this.shareScreenCount, inited = false};
        }
        public void set_ShareScreenCount(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.shareScreenCount = value;
            mem[1152921529224469824] = value.fakeValue;
            mem[1152921529224469828] = value.inited;
            this.SaveVariableImmediately(name:  "shareScreenCount", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_InviteCount()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.inviteCount, hiddenValue = this.inviteCount, inited = false};
        }
        public void set_InviteCount(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.inviteCount = value;
            mem[1152921529224704176] = value.fakeValue;
            mem[1152921529224704180] = value.inited;
            this.SaveVariableImmediately(name:  "inviteCount", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_FastestVictory()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.fastestVictory, hiddenValue = this.fastestVictory, inited = false};
        }
        public void set_FastestVictory(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.fastestVictory = value;
            mem[1152921529224938528] = value.fakeValue;
            mem[1152921529224938532] = value.inited;
            this.SaveVariableImmediately(name:  "fastestVictory", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_WinStreak_Longest()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.winStreak_Longest, hiddenValue = this.winStreak_Longest, inited = false};
        }
        public void set_WinStreak_Longest(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.winStreak_Longest = value;
            mem[1152921529225172896] = value.fakeValue;
            mem[1152921529225172900] = value.inited;
            this.SaveVariableImmediately(name:  "winStreak_Longest", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_WinStreak_Current()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.winStreak_Current, hiddenValue = this.winStreak_Current, inited = false};
        }
        public void set_WinStreak_Current(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.winStreak_Current = value;
            mem[1152921529225407264] = value.fakeValue;
            mem[1152921529225407268] = value.inited;
            this.SaveVariableImmediately(name:  "winStreak_Current", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_MostBubblesRetained()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.mostBubblesRetained, hiddenValue = this.mostBubblesRetained, inited = false};
        }
        public void set_MostBubblesRetained(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.mostBubblesRetained = value;
            mem[1152921529225641632] = value.fakeValue;
            mem[1152921529225641636] = value.inited;
            this.SaveVariableImmediately(name:  "mostBubblesRetained", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_TotalMatches_Started()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.totalMatches_Started, hiddenValue = this.totalMatches_Started, inited = false};
        }
        public void set_TotalMatches_Started(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.totalMatches_Started = value;
            mem[1152921529225876000] = value.fakeValue;
            mem[1152921529225876004] = value.inited;
            this.SaveVariableImmediately(name:  "totalMatches_Started", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_TotalMatches_Completed()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.totalMatches_Completed, hiddenValue = this.totalMatches_Completed, inited = false};
        }
        public void set_TotalMatches_Completed(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.totalMatches_Completed = value;
            mem[1152921529226110368] = value.fakeValue;
            mem[1152921529226110372] = value.inited;
            this.SaveVariableImmediately(name:  "totalMatches_Completed", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_InkingSequencesTriggered()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.inkingSequencesTriggered, hiddenValue = this.inkingSequencesTriggered, inited = false};
        }
        public void set_InkingSequencesTriggered(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.inkingSequencesTriggered = value;
            mem[1152921529226344752] = value.fakeValue;
            mem[1152921529226344756] = value.inited;
            this.SaveVariableImmediately(name:  "inkingSequencesTriggered", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_BeenInked()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.beenInked, hiddenValue = this.beenInked, inited = false};
        }
        public void set_BeenInked(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.beenInked = value;
            mem[1152921529226579104] = value.fakeValue;
            mem[1152921529226579108] = value.inited;
            this.SaveVariableImmediately(name:  "beenInked", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Techniques_ReboundSave()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.techniques_ReboundSave, hiddenValue = this.techniques_ReboundSave, inited = false};
        }
        public void set_Techniques_ReboundSave(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.techniques_ReboundSave = value;
            mem[1152921529226813472] = value.fakeValue;
            mem[1152921529226813476] = value.inited;
            this.SaveVariableImmediately(name:  "techniques_ReboundSave", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Techniques_ReboundSuicide()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.techniques_ReboundSuicide, hiddenValue = this.techniques_ReboundSuicide, inited = false};
        }
        public void set_Techniques_ReboundSuicide(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.techniques_ReboundSuicide = value;
            mem[1152921529227047856] = value.fakeValue;
            mem[1152921529227047860] = value.inited;
            this.SaveVariableImmediately(name:  "techniques_ReboundSuicide", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Techniques_ReboundInterception()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.techniques_ReboundInterception, hiddenValue = this.techniques_ReboundInterception, inited = false};
        }
        public void set_Techniques_ReboundInterception(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.techniques_ReboundInterception = value;
            mem[1152921529227282240] = value.fakeValue;
            mem[1152921529227282244] = value.inited;
            this.SaveVariableImmediately(name:  "techniques_ReboundInterception", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Techniques_ReboundCounter()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.techniques_ReboundCounter, hiddenValue = this.techniques_ReboundCounter, inited = false};
        }
        public void set_Techniques_ReboundCounter(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.techniques_ReboundCounter = value;
            mem[1152921529227516624] = value.fakeValue;
            mem[1152921529227516628] = value.inited;
            this.SaveVariableImmediately(name:  "techniques_ReboundCounter", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Techniques_BeenIntercepted()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.techniques_BeenIntercepted, hiddenValue = this.techniques_BeenIntercepted, inited = false};
        }
        public void set_Techniques_BeenIntercepted(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.techniques_BeenIntercepted = value;
            mem[1152921529227751008] = value.fakeValue;
            mem[1152921529227751012] = value.inited;
            this.SaveVariableImmediately(name:  "techniques_BeenIntercepted", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Techniques_BeenCountered()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.techniques_BeenCountered, hiddenValue = this.techniques_BeenCountered, inited = false};
        }
        public void set_Techniques_BeenCountered(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.techniques_BeenCountered = value;
            mem[1152921529227985392] = value.fakeValue;
            mem[1152921529227985396] = value.inited;
            this.SaveVariableImmediately(name:  "techniques_BeenCountered", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_SuperBubbleShot_Stunner()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.superBubbleShot_Stunner, hiddenValue = this.superBubbleShot_Stunner, inited = false};
        }
        public void set_SuperBubbleShot_Stunner(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.superBubbleShot_Stunner = value;
            mem[1152921529228219776] = value.fakeValue;
            mem[1152921529228219780] = value.inited;
            this.SaveVariableImmediately(name:  "superBubbleShot_Stunner", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_SuperBubbleShot_CannonBall()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.superBubbleShot_CannonBall, hiddenValue = this.superBubbleShot_CannonBall, inited = false};
        }
        public void set_SuperBubbleShot_CannonBall(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.superBubbleShot_CannonBall = value;
            mem[1152921529228454160] = value.fakeValue;
            mem[1152921529228454164] = value.inited;
            this.SaveVariableImmediately(name:  "superBubbleShot_CannonBall", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_SuperBubbleShot_RainbowTransformer()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.superBubbleShot_RainbowTransformer, hiddenValue = this.superBubbleShot_RainbowTransformer, inited = false};
        }
        public void set_SuperBubbleShot_RainbowTransformer(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.superBubbleShot_RainbowTransformer = value;
            mem[1152921529228688576] = value.fakeValue;
            mem[1152921529228688580] = value.inited;
            this.SaveVariableImmediately(name:  "superBubbleShot_RainbowTransformer", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_SuperBubbleShot_Virus()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.superBubbleShot_Virus, hiddenValue = this.superBubbleShot_Virus, inited = false};
        }
        public void set_SuperBubbleShot_Virus(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.superBubbleShot_Virus = value;
            mem[1152921529228922944] = value.fakeValue;
            mem[1152921529228922948] = value.inited;
            this.SaveVariableImmediately(name:  "superBubbleShot_Virus", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_SuperBubbleShot_Eraser()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.superBubbleShot_Eraser, hiddenValue = this.superBubbleShot_Eraser, inited = false};
        }
        public void set_SuperBubbleShot_Eraser(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.superBubbleShot_Eraser = value;
            mem[1152921529229157264] = value.fakeValue;
            mem[1152921529229157268] = value.inited;
            this.SaveVariableImmediately(name:  "superBubbleShot_Eraser", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_StunBreaks()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.stunBreaks, hiddenValue = this.stunBreaks, inited = false};
        }
        public void set_StunBreaks(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.stunBreaks = value;
            mem[1152921529229391648] = value.fakeValue;
            mem[1152921529229391652] = value.inited;
            this.SaveVariableImmediately(name:  "stunBreaks", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_BiggestCombo_Ring()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.biggestCombo_Ring, hiddenValue = this.biggestCombo_Ring, inited = false};
        }
        public void set_BiggestCombo_Ring(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.biggestCombo_Ring = value;
            mem[1152921529229626016] = value.fakeValue;
            mem[1152921529229626020] = value.inited;
            this.SaveVariableImmediately(name:  "biggestCombo_Ring", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_BiggestCombo_Cross()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.biggestCombo_Cross, hiddenValue = this.biggestCombo_Cross, inited = false};
        }
        public void set_BiggestCombo_Cross(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.biggestCombo_Cross = value;
            mem[1152921529229860384] = value.fakeValue;
            mem[1152921529229860388] = value.inited;
            this.SaveVariableImmediately(name:  "biggestCombo_Cross", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_BiggestCombo_Bridge()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.biggestCombo_Bridge, hiddenValue = this.biggestCombo_Bridge, inited = false};
        }
        public void set_BiggestCombo_Bridge(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.biggestCombo_Bridge = value;
            mem[1152921529230094752] = value.fakeValue;
            mem[1152921529230094756] = value.inited;
            this.SaveVariableImmediately(name:  "biggestCombo_Bridge", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_BiggestCombo_CrossBridge()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.biggestCombo_CrossBridge, hiddenValue = this.biggestCombo_CrossBridge, inited = false};
        }
        public void set_BiggestCombo_CrossBridge(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.biggestCombo_CrossBridge = value;
            mem[1152921529230329136] = value.fakeValue;
            mem[1152921529230329140] = value.inited;
            this.SaveVariableImmediately(name:  "biggestCombo_CrossBridge", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_PublicMatch_CurrentLevel()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.publicMatch_currentLevel, hiddenValue = this.publicMatch_currentLevel, inited = false};
        }
        public void set_PublicMatch_CurrentLevel(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.publicMatch_currentLevel = value;
            mem[1152921529230563520] = value.fakeValue;
            mem[1152921529230563524] = value.inited;
            this.SaveVariableImmediately(name:  "publicMatch_currentLevel", obj:  value);
        }
        public void ApplyCurrentAdventureStats(bool isPlayerWins)
        {
            var val_2;
            if(Character_GlobalInfo.IsAdventureMode() == false)
            {
                    return;
            }
            
            val_2 = null;
            val_2 = null;
            if(DataStructs.Stats.currAdvStats == null)
            {
                    return;
            }
            
            val_2 = null;
            isPlayerWins = isPlayerWins;
            0.Apply(playerWins:  isPlayerWins);
            this.ResetAdventureStats();
        }
        public void ResetAdventureStats()
        {
            var val_2 = null;
            DataStructs.Stats.currAdvStats = new Stats.AdventureOneMatchStats();
        }
        private void SetAdventureBiggestCombo(int value)
        {
            int val_5;
            var val_6;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7;
            var val_8;
            val_5 = value;
            val_6 = null;
            val_6 = null;
            val_7 = mem[DataStructs.Stats.currAdvStats + 96];
            val_7 = DataStructs.Stats.currAdvStats.biggest_Combo;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Max(a:  val_5, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.Stats.currAdvStats + 96 + 8, inited = DataStructs.Stats.currAdvStats + 96 + 8})));
            DataStructs.Stats.currAdvStats.biggest_Combo = val_3;
            DataStructs.Stats.currAdvStats.__unknownFiledOffset_68 = val_3.fakeValue;
            mem[4] = val_3.inited;
            if(val_5 < 4)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            val_7 = DataStructs.Stats.currAdvStats;
            val_5 = mem[DataStructs.Stats.currAdvStats + 64 + 8];
            val_5 = DataStructs.Stats.currAdvStats + 64 + 8;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = val_5, inited = val_5});
            DataStructs.Stats.currAdvStats.maximum_Chains = val_4;
            DataStructs.Stats.currAdvStats.__unknownFiledOffset_48 = val_4.fakeValue;
            mem[4] = val_4.inited;
        }
        private void AddAdventureTotalBubbleShot()
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.Stats.currAdvStats + 80 + 8, inited = DataStructs.Stats.currAdvStats + 80 + 8});
            DataStructs.Stats.currAdvStats.firedTotalShots = val_1;
            DataStructs.Stats.currAdvStats.__unknownFiledOffset_58 = val_1.fakeValue;
            mem[4] = val_1.inited;
        }
        private void AddAdventureInkBubbleShot()
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.Stats.currAdvStats + 112 + 8, inited = DataStructs.Stats.currAdvStats + 112 + 8});
            DataStructs.Stats.currAdvStats.mostInkBubbles = val_1;
            DataStructs.Stats.currAdvStats.__unknownFiledOffset_78 = val_1.fakeValue;
            mem[4] = val_1.inited;
        }
        private void SetAdventurePowerBallFired(InkWars.Model.BubbleTypes type)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_6 = type;
            if(val_6 == 8)
            {
                goto label_1;
            }
            
            if(val_6 == 9)
            {
                goto label_2;
            }
            
            if(val_6 != 10)
            {
                    return;
            }
            
            val_7 = 1152921505151361024;
            val_8 = null;
            val_8 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.Stats.currAdvStats + 48 + 8, inited = DataStructs.Stats.currAdvStats + 48 + 8});
            DataStructs.Stats.currAdvStats.firedColorEraserBall = val_1;
            DataStructs.Stats.currAdvStats.__unknownFiledOffset_38 = val_1.fakeValue;
            mem[4] = val_1.inited;
            goto label_15;
            label_1:
            val_7 = 1152921505151361024;
            val_9 = null;
            val_9 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.Stats.currAdvStats + 16 + 8, inited = DataStructs.Stats.currAdvStats + 16 + 8});
            DataStructs.Stats.currAdvStats.firedStunner = val_2;
            DataStructs.Stats.currAdvStats.__unknownFiledOffset_18 = val_2.fakeValue;
            mem[4] = val_2.inited;
            goto label_15;
            label_2:
            val_7 = 1152921505151361024;
            val_10 = null;
            val_10 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.Stats.currAdvStats + 32 + 8, inited = DataStructs.Stats.currAdvStats + 32 + 8});
            DataStructs.Stats.currAdvStats.firedIron = val_3;
            DataStructs.Stats.currAdvStats.__unknownFiledOffset_28 = val_3.fakeValue;
            mem[4] = val_3.inited;
            label_15:
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
            val_6 = val_4.currentCryptoKey;
            DataStructs.Stats.currAdvStats.usePower = val_4;
            DataStructs.Stats.currAdvStats.__unknownFiledOffset_88 = val_4.fakeValue & 4294967295;
        }
        public DataStructs.CharacterStats GetCharacterStats(CharacterNameID key)
        {
            if(this.charactersStatsPVP != null)
            {
                    return this.charactersStatsPVP.Get(cid:  key);
            }
            
            return this.charactersStatsPVP.Get(cid:  key);
        }
        public void Update_CharacterRecord(CharacterNameID charID, InkWars.Model.GameResult result, CharacterNameID opponentID, DataStructs.PlayerRank rank, int battlePoints)
        {
            var val_11;
            int val_12;
            int val_13;
            val_11 = null;
            val_11 = null;
            DataStructs.CharacterStats val_1 = DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  charID);
            if(result > 6)
            {
                    return;
            }
            
            var val_11 = 1;
            val_11 = val_11 << result;
            if((val_11 & 18) != 0)
            {
                goto label_5;
            }
            
            val_11 = val_11 & 36;
            if(val_11 != 0)
            {
                goto label_6;
            }
            
            var val_12 = 1;
            val_12 = val_12 << result;
            val_12 = val_12 & 72;
            if(val_12 == 0)
            {
                    return;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            if(val_1 == null)
            {
                goto label_10;
            }
            
            val_12 = val_3.currentCryptoKey;
            val_1.WinStreakCurrent = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_12, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
            goto label_11;
            label_5:
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.win, hiddenValue = val_1.win, fakeValue = result, inited = result});
            val_1.Win = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited};
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.winStreakCurrent, hiddenValue = val_1.winStreakCurrent, fakeValue = val_4.currentCryptoKey, inited = val_4.hiddenValue});
            val_1.WinStreakCurrent = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited};
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.winStreakCurrent, hiddenValue = val_1.winStreakCurrent, fakeValue = val_5.currentCryptoKey, inited = val_5.hiddenValue})) <= (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.winStreakLongest, hiddenValue = val_1.winStreakLongest, fakeValue = val_5.currentCryptoKey, inited = val_5.hiddenValue})))
            {
                    return;
            }
            
            val_1.WinStreakLongest = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.winStreakCurrent, hiddenValue = val_1.winStreakCurrent, inited = false};
            return;
            label_6:
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            if(val_1 == null)
            {
                goto label_18;
            }
            
            val_13 = val_8.currentCryptoKey;
            val_1.WinStreakCurrent = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_13, hiddenValue = val_8.hiddenValue, fakeValue = val_8.fakeValue, inited = val_8.inited};
            goto label_19;
            label_10:
            val_12 = val_3.currentCryptoKey;
            0.WinStreakCurrent = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_12, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
            label_11:
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.draw, hiddenValue = val_1.draw, fakeValue = val_12, inited = val_3.hiddenValue});
            val_1.Draw = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_9.currentCryptoKey, hiddenValue = val_9.hiddenValue, fakeValue = val_9.fakeValue, inited = val_9.inited};
            return;
            label_18:
            val_13 = val_8.currentCryptoKey;
            0.WinStreakCurrent = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_13, hiddenValue = val_8.hiddenValue, fakeValue = val_8.fakeValue, inited = val_8.inited};
            label_19:
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.loss, hiddenValue = val_1.loss, fakeValue = val_13, inited = val_8.hiddenValue});
            val_1.Loss = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_10.currentCryptoKey, hiddenValue = val_10.hiddenValue, fakeValue = val_10.fakeValue, inited = val_10.inited};
        }
        public void Increment_TotalMatches_Played(CharacterNameID charID)
        {
            var val_2;
            GameMode val_3;
            var val_4;
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
            
            val_4 = null;
            val_4 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 408 + 8, inited = DataStructs.UserDataDictionary.Stats + 408 + 8});
            DataStructs.UserDataDictionary.Stats.TotalMatches_Started = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        }
        public DataStructs.CharacterStats GetCharacterPVPStats(CharacterNameID cid)
        {
            if(this.charactersStatsPVP != null)
            {
                    return this.charactersStatsPVP.Get(cid:  cid);
            }
            
            return this.charactersStatsPVP.Get(cid:  cid);
        }
        public DataStructs.CharacterStats GetCurrentCharacterPVPStats()
        {
            CharacterNameID val_2;
            CharacterInfo val_1 = Character_GlobalInfo.GetLeftPlayer();
            return (DataStructs.CharacterStats)this.GetCharacterPVPStats(cid:  val_2);
        }
        public DataStructs.PlayerRank get_CurrentCharacterRank()
        {
            CharacterNameID val_2;
            CharacterInfo val_1 = Character_GlobalInfo.GetLeftPlayer();
            return (DataStructs.PlayerRank)this.GetCharacterPVPStats(cid:  val_2).BPRank;
        }
        public void set_CurrentCharacterRank(DataStructs.PlayerRank value)
        {
            CharacterNameID val_2;
            CharacterInfo val_1 = Character_GlobalInfo.GetLeftPlayer();
            this.GetCharacterPVPStats(cid:  val_2).BPRank = value;
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_CurrentCharacterBP()
        {
            CharacterNameID val_2;
            CharacterInfo val_1 = Character_GlobalInfo.GetLeftPlayer();
            if((this.GetCharacterPVPStats(cid:  val_2)) != null)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.bp, hiddenValue = val_3.bp, fakeValue = val_2, inited = val_2};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.bp, hiddenValue = val_3.bp, fakeValue = val_2, inited = val_2};
        }
        public void set_CurrentCharacterBP(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            CharacterNameID val_2;
            CharacterInfo val_1 = Character_GlobalInfo.GetLeftPlayer();
            this.GetCharacterPVPStats(cid:  val_2).Bp = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = value.currentCryptoKey, hiddenValue = value.hiddenValue, fakeValue = value.fakeValue, inited = value.inited};
        }
        public DataStructs.CharacterStats GetHighestRank()
        {
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_4 = this.charactersStatsPVP.Values.GetEnumerator();
            label_11:
            label_8:
            if(((-1143953224) & 1) == 0)
            {
                goto label_4;
            }
            
            System.Type val_5 = 0.InitialType;
            if(0 >= (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = X22, hiddenValue = X22, fakeValue = X23, inited = X23})))
            {
                goto label_8;
            }
            
            int val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {fakeValue = X22, inited = X22});
            goto label_11;
            label_4:
            0.Add(driver:  public System.Void Dictionary.ValueCollection.Enumerator<System.String, DataStructs.CharacterStats>::Dispose(), rectTransform:  null, drivenProperties:  null);
            return (DataStructs.CharacterStats)System.Linq.Enumerable.FirstOrDefault<DataStructs.CharacterStats>(source:  this.charactersStatsPVP.Values);
        }
        public CharacterNameID get_AllTimeBestCharacter()
        {
            CharacterNameID val_2 = 999999;
            bool val_3 = System.Enum.TryParse<CharacterNameID>(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  this.allTimeHighCharacter), result: out  val_2);
            return val_2;
        }
        public void set_AllTimeBestCharacter(CharacterNameID value)
        {
            value.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            this.AllTimeHighCharacter = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  value.ToString());
        }
        public bool HasPlayedWithPlayer(string userId)
        {
            bool val_2 = System.String.IsNullOrEmpty(value:  this.GetListOpponentID(key:  userId, defaultValue:  ""));
            val_2 = (~val_2) & 1;
            return (bool)val_2;
        }
        public void SetPlayedWithPlayer(string userId)
        {
            if((this.HasPlayedWithPlayer(userId:  userId)) != false)
            {
                    return;
            }
            
            this.SetListOpponentID(key:  userId, aNewValue:  userId);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetUniquePlayerCount()
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  this.listOpponentID.Keys.Count);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_DayPassedSinceSignUp()
        {
            var val_8;
            System.DateTime val_1 = System.DateTime.UtcNow;
            val_8 = null;
            val_8 = null;
            System.DateTime val_3 = System.Convert.ToDateTime(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  DataStructs.UserDataDictionary.GameSave.signUpDate));
            System.DateTime val_4 = System.DateTime.UtcNow;
            System.TimeSpan val_5 = val_4.dateData.Subtract(value:  new System.DateTime() {dateData = val_3.dateData});
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  (int)val_5._ticks.TotalDays);
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue, inited = val_7.inited};
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_TotalPVPWins()
        {
            int val_6;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.charactersStatsPVP.Values.GetEnumerator();
            val_6 = 0;
            goto label_3;
            label_7:
            val_6 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = X21, hiddenValue = X21, fakeValue = 0.InitialType, inited = 0.InitialType})) + val_6;
            label_3:
            if(((-1143033016) & 1) != 0)
            {
                goto label_7;
            }
            
            0.Add(driver:  public System.Void Dictionary.ValueCollection.Enumerator<System.String, DataStructs.CharacterStats>::Dispose(), rectTransform:  0, drivenProperties:  null);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_6);
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited};
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_TotalPVPLosses()
        {
            int val_6;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.charactersStatsPVP.Values.GetEnumerator();
            val_6 = 0;
            goto label_3;
            label_7:
            val_6 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = X21, hiddenValue = X21, fakeValue = 0.InitialType, inited = 0.InitialType})) + val_6;
            label_3:
            if(((-1142896440) & 1) != 0)
            {
                goto label_7;
            }
            
            0.Add(driver:  public System.Void Dictionary.ValueCollection.Enumerator<System.String, DataStructs.CharacterStats>::Dispose(), rectTransform:  0, drivenProperties:  null);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_6);
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited};
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_TotalPVPDraws()
        {
            int val_6;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.charactersStatsPVP.Values.GetEnumerator();
            val_6 = 0;
            goto label_3;
            label_7:
            val_6 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = X21, hiddenValue = X21, fakeValue = 0.InitialType, inited = 0.InitialType})) + val_6;
            label_3:
            if(((-1142759864) & 1) != 0)
            {
                goto label_7;
            }
            
            0.Add(driver:  public System.Void Dictionary.ValueCollection.Enumerator<System.String, DataStructs.CharacterStats>::Dispose(), rectTransform:  0, drivenProperties:  null);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_6);
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited};
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat get_AverageShots()
        {
            float val_5;
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.totalAdventureGames, hiddenValue = this.totalAdventureGames, fakeValue = 53678080, inited = false})) != 0)
            {
                    CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = this.totalAdventureGames;
                val_4 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.firedTotalShots, hiddenValue = this.firedTotalShots, fakeValue = 53678080, inited = false})) / (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4, hiddenValue = val_4, fakeValue = 53678080, inited = false}));
                val_5 = (float)val_4;
                return CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  val_5 = 0f);
            }
            
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  val_5);
        }
        public void AddSpecialBallUsedById(string id, int addition)
        {
            if((System.String.op_Equality(a:  id = id, b:  "Color_Eraser_Ball_Used")) != false)
            {
                    int val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.firedColorEraserBall, hiddenValue = this.firedColorEraserBall, fakeValue = id, inited = id});
                val_2 = val_2 + addition;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_2);
                this.FiredColorEraserBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
            }
            else
            {
                    if((System.String.op_Equality(a:  id, b:  "Iron_Ball_Used")) != false)
            {
                    int val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.firedIron, hiddenValue = this.firedIron, fakeValue = id, inited = id});
                val_5 = val_5 + addition;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_5);
                this.FiredIron = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited};
            }
            else
            {
                    if((System.String.op_Equality(a:  id, b:  "Stunner_Ball_Used")) != false)
            {
                    int val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.firedStunner, hiddenValue = this.firedStunner, fakeValue = id, inited = id});
                val_8 = val_8 + addition;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_8);
                this.FiredStunner = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_9.currentCryptoKey, hiddenValue = val_9.hiddenValue, fakeValue = val_9.fakeValue, inited = val_9.inited};
            }
            
            }
            
            }
            
            UnityEngine.Debug.Log(message:  "Special Ball being set");
        }
        public int GetSpecialBallUsedById(string id)
        {
            var val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5;
            if((System.String.op_Equality(a:  id, b:  "Color_Eraser_Ball_Used")) != false)
            {
                    val_4 = 1152921505062117376;
                val_5 = this.firedColorEraserBall;
                return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5, hiddenValue = val_5, fakeValue = -1142305040, inited = true});
            }
            
            if((System.String.op_Equality(a:  id, b:  "Iron_Ball_Used")) != false)
            {
                    val_4 = 1152921505062117376;
                val_5 = this.firedIron;
                return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5, hiddenValue = val_5, fakeValue = -1142305040, inited = true});
            }
            
            if((System.String.op_Equality(a:  id, b:  "Stunner_Ball_Used")) == false)
            {
                    return 0;
            }
            
            val_4 = 1152921505062117376;
            val_5 = this.firedStunner;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5, hiddenValue = val_5, fakeValue = -1142305040, inited = true});
        }
        public void Update_ProfileRecord(InkWars.Model.GameResult result, float gameTime, int BubblesRetained)
        {
            int val_11;
            int val_12;
            var val_13;
            DataStructs.Stats val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_19;
            var val_20;
            var val_21;
            val_11 = BubblesRetained;
            float val_12 = gameTime;
            val_12 = result;
            val_13 = null;
            val_13 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 424 + 8, inited = DataStructs.UserDataDictionary.Stats + 424 + 8});
            DataStructs.UserDataDictionary.Stats.TotalMatches_Completed = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
            val_14 = DataStructs.UserDataDictionary.Stats;
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 392 + 8, inited = DataStructs.UserDataDictionary.Stats + 392 + 8})) < val_11)
            {
                    val_15 = null;
                val_15 = null;
                val_14 = DataStructs.UserDataDictionary.Stats;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_11);
                val_11 = val_3.currentCryptoKey;
                val_14.MostBubblesRetained = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_11, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
            }
            
            if(val_12 > 6)
            {
                    return;
            }
            
            var val_11 = 1;
            val_11 = val_11 << val_12;
            if((val_11 & 108) != 0)
            {
                    val_16 = null;
                val_16 = null;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
                DataStructs.UserDataDictionary.Stats.WinStreak_Current = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited};
                return;
            }
            
            val_11 = val_11 & 18;
            if(val_11 == 0)
            {
                    return;
            }
            
            val_17 = null;
            val_17 = null;
            val_14 = mem[DataStructs.UserDataDictionary.Stats + 376];
            val_14 = DataStructs.UserDataDictionary.Stats.winStreak_Current;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 376 + 8, inited = DataStructs.UserDataDictionary.Stats + 376 + 8});
            DataStructs.UserDataDictionary.Stats.WinStreak_Current = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited};
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 376 + 8, inited = DataStructs.UserDataDictionary.Stats + 376 + 8})) > (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 360 + 8, inited = DataStructs.UserDataDictionary.Stats + 360 + 8})))
            {
                    val_18 = null;
                val_18 = null;
                if(DataStructs.UserDataDictionary.Stats != null)
            {
                    val_19 = mem[DataStructs.UserDataDictionary.Stats + 376];
                val_19 = DataStructs.UserDataDictionary.Stats.winStreak_Current;
                val_14 = mem[DataStructs.UserDataDictionary.Stats + 376 + 8];
                val_14 = DataStructs.UserDataDictionary.Stats + 376 + 8;
            }
            else
            {
                    val_19 = 1050028;
                val_14 = 1050028;
            }
            
                DataStructs.UserDataDictionary.Stats.WinStreak_Longest = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 1050028, fakeValue = 1050028, inited = false};
            }
            
            val_20 = null;
            val_20 = null;
            val_12 = mem[DataStructs.UserDataDictionary.Stats + 344 + 8];
            val_12 = DataStructs.UserDataDictionary.Stats + 344 + 8;
            int val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = val_12, inited = val_12});
            val_12 = val_12 / 1.5f;
            if(val_12 >= 0)
            {
                    return;
            }
            
            val_21 = null;
            val_21 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  (int)val_12);
            DataStructs.UserDataDictionary.Stats.FastestVictory = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_10.currentCryptoKey, hiddenValue = val_10.hiddenValue, fakeValue = val_10.fakeValue, inited = val_10.inited};
        }
        public void Increment_InkingSequencesTriggered()
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = null;
            val_4 = null;
            if((Character_GlobalInfo.gameMode - 1) < 4)
            {
                    val_5 = null;
                val_5 = null;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 216 + 8, inited = DataStructs.UserDataDictionary.Stats + 216 + 8});
                DataStructs.UserDataDictionary.Stats.Ink_Sequences = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited};
                return;
            }
            
            if(Character_GlobalInfo.gameMode != 10)
            {
                    if(Character_GlobalInfo.gameMode != 6)
            {
                    return;
            }
            
            }
            
            val_6 = null;
            val_6 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 440 + 8, inited = DataStructs.UserDataDictionary.Stats + 440 + 8});
            DataStructs.UserDataDictionary.Stats.InkingSequencesTriggered = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
        }
        public void Increment_BeenInked()
        {
            var val_2;
            GameMode val_3;
            var val_4;
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
            
            val_4 = null;
            val_4 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 456 + 8, inited = DataStructs.UserDataDictionary.Stats + 456 + 8});
            DataStructs.UserDataDictionary.Stats.BeenInked = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        }
        public void Increment_Techniques_ReboundSave()
        {
            var val_2;
            GameMode val_3;
            var val_4;
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
            
            val_4 = null;
            val_4 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 472 + 8, inited = DataStructs.UserDataDictionary.Stats + 472 + 8});
            DataStructs.UserDataDictionary.Stats.Techniques_ReboundSave = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        }
        public void Increment_Techniques_ReboundSuicide()
        {
            var val_2;
            GameMode val_3;
            var val_4;
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
            
            val_4 = null;
            val_4 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 488 + 8, inited = DataStructs.UserDataDictionary.Stats + 488 + 8});
            DataStructs.UserDataDictionary.Stats.Techniques_ReboundSuicide = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        }
        public void Increment_Techniques_ReboundInterception()
        {
            var val_2;
            GameMode val_3;
            var val_4;
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
            
            val_4 = null;
            val_4 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 504 + 8, inited = DataStructs.UserDataDictionary.Stats + 504 + 8});
            DataStructs.UserDataDictionary.Stats.Techniques_ReboundInterception = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        }
        public void Increment_Techniques_ReboundCounter()
        {
            var val_2;
            GameMode val_3;
            var val_4;
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
            
            val_4 = null;
            val_4 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 528, inited = DataStructs.UserDataDictionary.Stats + 528});
            DataStructs.UserDataDictionary.Stats.Techniques_ReboundCounter = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        }
        public void Increment_Techniques_BeenIntercepted()
        {
            var val_2;
            GameMode val_3;
            var val_4;
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
            
            val_4 = null;
            val_4 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 544, inited = DataStructs.UserDataDictionary.Stats + 544});
            DataStructs.UserDataDictionary.Stats.Techniques_BeenIntercepted = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        }
        public void Increment_Techniques_BeenCountered()
        {
            var val_2;
            GameMode val_3;
            var val_4;
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
            
            val_4 = null;
            val_4 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 560, inited = DataStructs.UserDataDictionary.Stats + 560});
            DataStructs.UserDataDictionary.Stats.Techniques_BeenCountered = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        }
        public void Increment_SuperBubbleShot_Stunner()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((Character_GlobalInfo.gameMode - 1) < 4)
            {
                    SetAdventurePowerBallFired(type:  8);
                return;
            }
            
            if(Character_GlobalInfo.gameMode != 10)
            {
                    if(Character_GlobalInfo.gameMode != 6)
            {
                    return;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 576, inited = DataStructs.UserDataDictionary.Stats + 576});
            DataStructs.UserDataDictionary.Stats.SuperBubbleShot_Stunner = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited};
        }
        public void Increment_SuperBubbleShot_CannonBall()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((Character_GlobalInfo.gameMode - 1) < 4)
            {
                    SetAdventurePowerBallFired(type:  9);
                return;
            }
            
            if(Character_GlobalInfo.gameMode != 10)
            {
                    if(Character_GlobalInfo.gameMode != 6)
            {
                    return;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 592, inited = DataStructs.UserDataDictionary.Stats + 592});
            DataStructs.UserDataDictionary.Stats.SuperBubbleShot_CannonBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited};
        }
        public void Increment_SuperBubbleShot_RainbowTransformer()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(Character_GlobalInfo.gameMode != 10)
            {
                    if(Character_GlobalInfo.gameMode != 6)
            {
                    return;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 624, inited = DataStructs.UserDataDictionary.Stats + 624});
            DataStructs.UserDataDictionary.Stats.SuperBubbleShot_RainbowTransformer = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        }
        public void Increment_SuperBubbleShot_Virus()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(Character_GlobalInfo.gameMode != 10)
            {
                    if(Character_GlobalInfo.gameMode != 6)
            {
                    return;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 640, inited = DataStructs.UserDataDictionary.Stats + 640});
            DataStructs.UserDataDictionary.Stats.SuperBubbleShot_Virus = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        }
        public void Increment_SuperBubbleShot_Eraser()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((Character_GlobalInfo.gameMode - 1) < 4)
            {
                    SetAdventurePowerBallFired(type:  10);
                return;
            }
            
            if(Character_GlobalInfo.gameMode != 10)
            {
                    if(Character_GlobalInfo.gameMode != 6)
            {
                    return;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 608, inited = DataStructs.UserDataDictionary.Stats + 608});
            DataStructs.UserDataDictionary.Stats.SuperBubbleShot_Eraser = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited};
        }
        public void Increment_StunBreaks()
        {
            var val_2;
            GameMode val_3;
            var val_4;
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
            
            val_4 = null;
            val_4 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 656, inited = DataStructs.UserDataDictionary.Stats + 656});
            DataStructs.UserDataDictionary.Stats.StunBreaks = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        }
        public void Update_BiggestCombo_Ring(int value)
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            if((Character_GlobalInfo.gameMode - 1) < 4)
            {
                    SetAdventureBiggestCombo(value:  value);
                return;
            }
            
            if(Character_GlobalInfo.gameMode != 10)
            {
                    if(Character_GlobalInfo.gameMode != 6)
            {
                    return;
            }
            
            }
            
            val_6 = null;
            val_6 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Max(a:  value, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 672, inited = DataStructs.UserDataDictionary.Stats + 672})));
            DataStructs.UserDataDictionary.Stats.BiggestCombo_Ring = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited};
        }
        public void Update_BiggestCombo_Cross(int value)
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            if((Character_GlobalInfo.gameMode - 1) < 4)
            {
                    SetAdventureBiggestCombo(value:  value);
                return;
            }
            
            if(Character_GlobalInfo.gameMode != 10)
            {
                    if(Character_GlobalInfo.gameMode != 6)
            {
                    return;
            }
            
            }
            
            val_6 = null;
            val_6 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Max(a:  value, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 688, inited = DataStructs.UserDataDictionary.Stats + 688})));
            DataStructs.UserDataDictionary.Stats.BiggestCombo_Cross = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited};
        }
        public void Update_BiggestCombo_Bridge(int value)
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            if((Character_GlobalInfo.gameMode - 1) < 4)
            {
                    SetAdventureBiggestCombo(value:  value);
                return;
            }
            
            if(Character_GlobalInfo.gameMode != 10)
            {
                    if(Character_GlobalInfo.gameMode != 6)
            {
                    return;
            }
            
            }
            
            val_6 = null;
            val_6 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Max(a:  value, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 704, inited = DataStructs.UserDataDictionary.Stats + 704})));
            DataStructs.UserDataDictionary.Stats.BiggestCombo_Bridge = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited};
        }
        public void Update_BiggestCombo_CrossBridge(int value)
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            if((Character_GlobalInfo.gameMode - 1) < 4)
            {
                    SetAdventureBiggestCombo(value:  value);
                return;
            }
            
            if(Character_GlobalInfo.gameMode != 10)
            {
                    if(Character_GlobalInfo.gameMode != 6)
            {
                    return;
            }
            
            }
            
            val_6 = null;
            val_6 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Max(a:  value, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 720, inited = DataStructs.UserDataDictionary.Stats + 720})));
            DataStructs.UserDataDictionary.Stats.BiggestCombo_CrossBridge = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited};
        }
        public void IncreaseTotalBubbleShoot()
        {
            null = null;
            GameMode val_1 = Character_GlobalInfo.gameMode;
            val_1 = val_1 - 1;
            if(val_1 > 3)
            {
                    return;
            }
            
            AddAdventureTotalBubbleShot();
        }
        public void IncreaseInkBubbleShoot()
        {
            null = null;
            GameMode val_1 = Character_GlobalInfo.gameMode;
            val_1 = val_1 - 1;
            if(val_1 > 3)
            {
                    return;
            }
            
            AddAdventureInkBubbleShot();
        }
        private static Stats()
        {
            DataStructs.Stats.currAdvStats = new Stats.AdventureOneMatchStats();
        }
    
    }

}
