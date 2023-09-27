using UnityEngine;

namespace DataStructs
{
    public class CharacterStats : FirebaseDictionalizer
    {
        // Fields
        private CharacterNameID <characterName>k__BackingField;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt bp;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString rank;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt win;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt loss;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt draw;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt winStreakLongest;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt winStreakCurrent;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt highScores;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt totalMatchPlayed;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString rewardedRank;
        
        // Properties
        public CharacterNameID characterName { get; set; }
        public override string keyName { get; }
        public DataStructs.PlayerRank BPRank { get; set; }
        public DataStructs.PlayerRank LastRewardedRank { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Bp { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString RewardedRank { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString Rank { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Win { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Loss { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Draw { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt WinStreakLongest { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt WinStreakCurrent { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt HighScores { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt TotalMatchPlayed { get; }
        
        // Methods
        public CharacterNameID get_characterName()
        {
            return (CharacterNameID)this.<characterName>k__BackingField;
        }
        protected void set_characterName(CharacterNameID value)
        {
            this.<characterName>k__BackingField = value;
        }
        public override string get_keyName()
        {
            this.<characterName>k__BackingField.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            return (string)this.<characterName>k__BackingField.ToString();
        }
        public CharacterStats(CharacterNameID aNewCharacterName, DataStructs.Dictionalizer.FirebaseDictionalizer node_before, System.Reflection.FieldInfo aNewBelonedDictionaryField)
        {
            val_1 = new System.Object();
            mem[1152921529237555456] = val_1;
            mem[1152921529237555464] = aNewBelonedDictionaryField;
            this.<characterName>k__BackingField = aNewCharacterName;
        }
        public DataStructs.PlayerRank get_BPRank()
        {
            var val_4;
            DataStructs.PlayerRank val_2 = 1;
            bool val_3 = System.Enum.TryParse<DataStructs.PlayerRank>(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  this.rank), result: out  val_2);
            val_4 = val_2;
            if(val_4 != 0)
            {
                    return (DataStructs.PlayerRank)val_4;
            }
            
            val_4 = 1;
            return (DataStructs.PlayerRank)val_4;
        }
        public void set_BPRank(DataStructs.PlayerRank value)
        {
            if(this.BPRank == value)
            {
                    return;
            }
            
            value.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            this.Rank = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  value.ToString());
        }
        public DataStructs.PlayerRank get_LastRewardedRank()
        {
            var val_4;
            DataStructs.PlayerRank val_2 = 1;
            bool val_3 = System.Enum.TryParse<DataStructs.PlayerRank>(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  this.rewardedRank), result: out  val_2);
            val_4 = val_2;
            if(val_4 != 0)
            {
                    return (DataStructs.PlayerRank)val_4;
            }
            
            val_4 = 1;
            return (DataStructs.PlayerRank)val_4;
        }
        public void set_LastRewardedRank(DataStructs.PlayerRank value)
        {
            if(this.LastRewardedRank == value)
            {
                    return;
            }
            
            value.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            this.RewardedRank = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  value.ToString());
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Bp()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.bp, hiddenValue = this.bp, inited = false};
        }
        public void set_Bp(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Max(a:  0, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = value.currentCryptoKey, hiddenValue = value.hiddenValue, fakeValue = value.fakeValue, inited = value.inited})));
            this.bp = val_3;
            mem[1152921529238359580] = val_3.fakeValue;
            mem[1152921529238359584] = val_3.inited;
            this.SaveVariableImmediately(name:  "bp", obj:  val_3);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_RewardedRank()
        {
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)this.rewardedRank;
        }
        public void set_RewardedRank(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            this.rewardedRank = value;
            this.SaveVariableImmediately(name:  "rewardedRank", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_Rank()
        {
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)this.rank;
        }
        public void set_Rank(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            this.rank = value;
            this.SaveVariableImmediately(name:  "rank", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Win()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.win, hiddenValue = this.win, inited = false};
        }
        public void set_Win(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.win = value;
            mem[1152921529239074792] = value.fakeValue;
            mem[1152921529239074796] = value.inited;
            this.SaveVariableImmediately(name:  "win", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Loss()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.loss, hiddenValue = this.loss, inited = false};
        }
        public void set_Loss(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.loss = value;
            mem[1152921529239309128] = value.fakeValue;
            mem[1152921529239309132] = value.inited;
            this.SaveVariableImmediately(name:  "loss", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Draw()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.draw, hiddenValue = this.draw, inited = false};
        }
        public void set_Draw(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.draw = value;
            mem[1152921529239543384] = value.fakeValue;
            mem[1152921529239543388] = value.inited;
            this.SaveVariableImmediately(name:  "draw", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_WinStreakLongest()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.winStreakLongest, hiddenValue = this.winStreakLongest, inited = false};
        }
        public void set_WinStreakLongest(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.winStreakLongest = value;
            mem[1152921529239777752] = value.fakeValue;
            mem[1152921529239777756] = value.inited;
            this.SaveVariableImmediately(name:  "winStreakLongest", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_WinStreakCurrent()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.winStreakCurrent, hiddenValue = this.winStreakCurrent, inited = false};
        }
        public void set_WinStreakCurrent(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.winStreakCurrent = value;
            mem[1152921529240012120] = value.fakeValue;
            mem[1152921529240012124] = value.inited;
            this.SaveVariableImmediately(name:  "winStreakCurrent", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_HighScores()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.highScores, hiddenValue = this.highScores, inited = false};
        }
        public void set_HighScores(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.highScores = value;
            mem[1152921529240246472] = value.fakeValue;
            mem[1152921529240246476] = value.inited;
            this.SaveVariableImmediately(name:  "highScores", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_TotalMatchPlayed()
        {
            int val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.draw, hiddenValue = this.draw, fakeValue = 53678080, inited = false});
            val_3 = ((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.loss, hiddenValue = this.loss, fakeValue = 53678080, inited = false})) + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.win, hiddenValue = this.win, fakeValue = 53678080, inited = false}))) + val_3;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_3);
        }
    
    }

}
