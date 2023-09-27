using UnityEngine;

namespace DataStructs
{
    public class GameLevel : FirebaseDictionalizer
    {
        // Fields
        private int _gameLevel;
        private DataStructs.Dictionalizer.AdventureGameModeDictionary mode;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt inkPercentage;
        
        // Properties
        public override string keyName { get; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt InkPercentage { get; set; }
        public int LevelId { get; }
        public int TotalStars { get; }
        public DataStructs.AdventureGameMode PuzzleMode { get; }
        public DataStructs.AdventureGameMode NormalMode { get; }
        public DataStructs.AdventureGameMode ExBattleMode { get; }
        
        // Methods
        public override string get_keyName()
        {
            return this._gameLevel.ToString();
        }
        public GameLevel(int gameLevel, DataStructs.Dictionalizer.FirebaseDictionalizer node_before, System.Reflection.FieldInfo aNewBelonedDictionaryField)
        {
            val_1 = new System.Object();
            mem[1152921529196553936] = val_1;
            mem[1152921529196553944] = aNewBelonedDictionaryField;
            this._gameLevel = gameLevel;
        }
        public DataStructs.AdventureGameMode GetAdventureGameMode(GameMode key)
        {
            if(this.mode != null)
            {
                    return this.mode.Get(aNewMode:  key);
            }
            
            return this.mode.Get(aNewMode:  key);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_InkPercentage()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.inkPercentage, hiddenValue = this.inkPercentage, inited = false};
        }
        public void set_InkPercentage(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.inkPercentage = value;
            mem[1152921529196919768] = value.fakeValue;
            mem[1152921529196919772] = value.inited;
            this.SaveVariableImmediately(name:  "inkPercentage", obj:  value);
        }
        public int get_LevelId()
        {
            return (int)this._gameLevel;
        }
        public System.Collections.Generic.List<DataStructs.AdventureGameMode> GetAllModes()
        {
            return System.Linq.Enumerable.ToList<DataStructs.AdventureGameMode>(source:  this.mode.Values);
        }
        public int get_TotalStars()
        {
            DataStructs.AdventureGameMode val_3 = this.GetAdventureGameMode(key:  3);
            DataStructs.AdventureGameMode val_5 = this.GetAdventureGameMode(key:  4);
            int val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.stars, hiddenValue = val_5.stars, fakeValue = 4, inited = false});
            val_6 = ((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.stars, hiddenValue = val_3.stars, fakeValue = 3, inited = false})) + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.stars, hiddenValue = val_1.stars, fakeValue = this.GetAdventureGameMode(key:  1), inited = this.GetAdventureGameMode(key:  1)}))) + val_6;
            return (int)val_6;
        }
        public DataStructs.AdventureGameMode GetGameModeByAdvGameModeID(AdvGameMode mode)
        {
            mode = (mode == 2) ? 4 : ((mode == 1) ? 3 : (0 + 1));
            return this.GetAdventureGameMode(key:  mode);
        }
        public DataStructs.AdventureGameMode get_PuzzleMode()
        {
            return this.GetAdventureGameMode(key:  3);
        }
        public DataStructs.AdventureGameMode get_NormalMode()
        {
            return this.GetAdventureGameMode(key:  1);
        }
        public DataStructs.AdventureGameMode get_ExBattleMode()
        {
            return this.GetAdventureGameMode(key:  4);
        }
        public void UpdateRecordsByScore(GameMode mode, int score)
        {
            var val_10;
            DataStructs.AdventureGameMode val_1 = this.GetAdventureGameMode(key:  mode);
            if(val_1 == null)
            {
                    return;
            }
            
            val_10 = null;
            val_10 = null;
            Character_GlobalInfo.prevHighScore = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.highscore, hiddenValue = val_1.highscore, fakeValue = -1178770528, inited = true});
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Max(a:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.highscore, hiddenValue = val_1.highscore, fakeValue = -1178770528, inited = true}), b:  score));
            val_1.Highscore = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited};
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Max(a:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.stars, hiddenValue = val_1.stars, fakeValue = val_5.currentCryptoKey, inited = val_5.hiddenValue}), b:  AdventureLevelDataCollection.GetCurrentStarsByScore(score:  score)));
            val_1.Stars = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_9.currentCryptoKey, hiddenValue = val_9.hiddenValue, fakeValue = val_9.fakeValue, inited = val_9.inited};
        }
    
    }

}
