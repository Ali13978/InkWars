using UnityEngine;

namespace DataStructs
{
    public class AdventureGameMode : FirebaseDictionalizer
    {
        // Fields
        private string _gameMode;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool isPlayable;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool passed;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt highscore;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt stars;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt shortestPassTime;
        
        // Properties
        public override string keyName { get; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool IsPlayable { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool Passed { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Highscore { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Stars { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt ShortestPassTime { get; set; }
        
        // Methods
        public override string get_keyName()
        {
            return (string)this._gameMode;
        }
        public AdventureGameMode(string gameMode, DataStructs.Dictionalizer.FirebaseDictionalizer node_before, System.Reflection.FieldInfo aNewBelonedDictionaryField)
        {
            val_1 = new System.Object();
            mem[1152921529198132912] = val_1;
            mem[1152921529198132920] = aNewBelonedDictionaryField;
            this._gameMode = gameMode;
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool get_IsPlayable()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = this.isPlayable, hiddenValue = this.isPlayable, fakeValue = false, fakeValueChanged = false, inited = false};
        }
        public void set_IsPlayable(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value)
        {
            this.isPlayable = value;
            mem[1152921529198374448] = value.fakeValue;
            mem[1152921529198374449] = value.fakeValueChanged;
            mem[1152921529198374450] = value.inited;
            this.SaveVariable(name:  "isPlayable", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool get_Passed()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = this.passed, hiddenValue = this.passed, fakeValue = false, fakeValueChanged = false, inited = false};
        }
        public void set_Passed(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value)
        {
            this.passed = value;
            mem[1152921529198608780] = value.fakeValue;
            mem[1152921529198608781] = value.fakeValueChanged;
            mem[1152921529198608782] = value.inited;
            this.SaveVariable(name:  "passed", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Highscore()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.highscore, hiddenValue = this.highscore, inited = false};
        }
        public void set_Highscore(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.highscore = value;
            mem[1152921529198843128] = value.fakeValue;
            mem[1152921529198843132] = value.inited;
            this.SaveVariableImmediately(name:  "highscore", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Stars()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.stars, hiddenValue = this.stars, inited = false};
        }
        public void set_Stars(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.stars = value;
            mem[1152921529199077464] = value.fakeValue;
            mem[1152921529199077468] = value.inited;
            this.SaveVariableImmediately(name:  "stars", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_ShortestPassTime()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.shortestPassTime, hiddenValue = this.shortestPassTime, inited = false};
        }
        public void set_ShortestPassTime(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.shortestPassTime = value;
            mem[1152921529199311832] = value.fakeValue;
            mem[1152921529199311836] = value.inited;
            this.SaveVariableImmediately(name:  "shortestPassTime", obj:  value);
        }
    
    }

}
