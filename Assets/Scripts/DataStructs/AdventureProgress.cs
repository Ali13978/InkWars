using UnityEngine;

namespace DataStructs
{
    public class AdventureProgress : FirebaseDictionalizer
    {
        // Fields
        private string _characterName;
        private DataStructs.Dictionalizer.GameLevelDictionary level;
        
        // Properties
        public override string keyName { get; }
        public int TotalStars { get; }
        public int TotalInk { get; }
        
        // Methods
        public override string get_keyName()
        {
            return (string)this._characterName;
        }
        public AdventureProgress(string characterName, DataStructs.Dictionalizer.FirebaseDictionalizer node_before, System.Reflection.FieldInfo aNewBelonedDictionaryField)
        {
            val_1 = new System.Object();
            mem[1152921529195156048] = val_1;
            mem[1152921529195156056] = aNewBelonedDictionaryField;
            this._characterName = characterName;
        }
        protected override void CustomInitAfterLoadDefaults()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
            this.GetGameLevel(key:  0).GetAdventureGameMode(key:  1).IsPlayable = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue & 4294967295, fakeValueChanged = val_3.fakeValue & 4294967295, inited = val_3.fakeValue & 4294967295};
            var val_8 = 0;
            do
            {
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  80);
                this.GetGameLevel(key:  0).InkPercentage = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited};
                val_8 = val_8 + 1;
                var val_7 = 80 - 10;
            }
            while(val_8 != 4);
        
        }
        public DataStructs.GameLevel GetGameLevel(int key)
        {
            if(this.level != null)
            {
                    return this.level.Get(levelIdFrom0to11:  key);
            }
            
            return this.level.Get(levelIdFrom0to11:  key);
        }
        public DataStructs.GameLevel GetCurrentLevelData()
        {
            return this.GetGameLevel(key:  Character_GlobalInfo.stage_CurrentLevel - 1);
        }
        public DataStructs.GameLevel GetNextLevelData()
        {
            return (DataStructs.GameLevel)this.GetGameLevel(key:  Character_GlobalInfo.stage_CurrentLevel);
        }
        public System.Collections.Generic.List<DataStructs.GameLevel> GetAllLevels()
        {
            return System.Linq.Enumerable.ToList<DataStructs.GameLevel>(source:  this.level.Values);
        }
        public int GetPassedLevelCount(AdvGameMode mode)
        {
            bool val_8;
            var val_9;
            AdvGameMode val_7 = mode;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.level.Values.GetEnumerator();
            val_9 = 0;
            val_7 = (val_7 == 2) ? 4 : ((val_7 == 1) ? 3 : (0 + 1));
            goto label_3;
            label_8:
            var val_8 = 0;
            val_8 = val_8 | (0.InitialType.GetAdventureGameMode(key:  val_7));
            val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.passed, hiddenValue = val_5.passed, fakeValue = val_8, fakeValueChanged = val_8, inited = val_8});
            val_9 = val_9 + val_8;
            label_3:
            if(((-1180738568) & 1) != 0)
            {
                goto label_8;
            }
            
            0.Add(driver:  public System.Void Dictionary.ValueCollection.Enumerator<System.String, DataStructs.GameLevel>::Dispose(), rectTransform:  0, drivenProperties:  null);
            return (int)val_9;
        }
        public float GetPassedLevelProgress(AdvGameMode mode)
        {
            float val_3 = (float)this.GetPassedLevelCount(mode:  mode);
            val_3 = val_3 / ((mode == 1) ? 11f : 12f);
            return (float)val_3;
        }
        public int get_TotalStars()
        {
            var val_5;
            List.Enumerator<T> val_2 = this.GetAllLevels().GetEnumerator();
            val_5 = 0;
            goto label_2;
            label_4:
            val_5 = 0.InitialType.TotalStars + val_5;
            label_2:
            if(((-1180477672) & 1) != 0)
            {
                goto label_4;
            }
            
            0.Add(driver:  public System.Void List.Enumerator<DataStructs.GameLevel>::Dispose(), rectTransform:  null, drivenProperties:  null);
            return (int)val_5;
        }
        public int get_TotalInk()
        {
            var val_5;
            List.Enumerator<T> val_2 = this.GetAllLevels().GetEnumerator();
            val_5 = 0;
            goto label_2;
            label_6:
            val_5 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = X21, hiddenValue = X21, fakeValue = 0.InitialType, inited = 0.InitialType})) + val_5;
            label_2:
            if(((-1180349304) & 1) != 0)
            {
                goto label_6;
            }
            
            0.Add(driver:  public System.Void List.Enumerator<DataStructs.GameLevel>::Dispose(), rectTransform:  0, drivenProperties:  null);
            return (int)val_5;
        }
    
    }

}
