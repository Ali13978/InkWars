using UnityEngine;

namespace DataStructs.Dictionalizer
{
    public class AdventureGameModeDictionary : DictionaryOfDictionalizer<DataStructs.AdventureGameMode>
    {
        // Fields
        private const string NORMAL_MODE_KEY = "normal";
        private const string PUZZLE_MODE_KEY = "puzzle";
        private const string EXBATTLE_MODE_KEY = "extrabattle";
        
        // Methods
        public AdventureGameModeDictionary(DataStructs.Dictionalizer.FirebaseDictionalizer owner, System.Reflection.FieldInfo aNewFieldInfo)
        {
        
        }
        public override void LoadDefault()
        {
            mem[1152921529242936432] = this.owner;
            mem[1152921529242936440] = ???;
            ._gameMode = "normal";
            this.Add(key:  "normal", value:  new DataStructs.AdventureGameMode());
            mem[1152921529242944624] = this.owner;
            mem[1152921529242944632] = "normal";
            ._gameMode = "puzzle";
            this.Add(key:  "puzzle", value:  new DataStructs.AdventureGameMode());
            mem[1152921529242952816] = this.owner;
            mem[1152921529242952824] = 1152921529242849440;
            ._gameMode = "extrabattle";
            this.Add(key:  "extrabattle", value:  new DataStructs.AdventureGameMode());
        }
        public DataStructs.AdventureGameMode Get(GameMode aNewMode)
        {
            DataStructs.Dictionalizer.FirebaseDictionalizer val_10;
            var val_11;
            string val_12;
            var val_13;
            if((aNewMode - 1) < 2)
            {
                goto label_1;
            }
            
            if(aNewMode == 3)
            {
                goto label_2;
            }
            
            val_11 = 0;
            if(aNewMode != 4)
            {
                goto label_3;
            }
            
            val_12 = "extrabattle";
            goto label_5;
            label_1:
            val_12 = "normal";
            goto label_5;
            label_2:
            val_12 = "puzzle";
            label_5:
            label_3:
            if((System.String.IsNullOrEmpty(value:  val_12)) != true)
            {
                    DataStructs.AdventureGameMode val_3 = 0;
                bool val_4 = this.TryGetValue(key:  val_12, value: out  val_3);
                val_13 = val_3;
                if(val_13 != 0)
            {
                    return (DataStructs.AdventureGameMode)val_13;
            }
            
                val_10 = this.owner;
                mem[1152921529243108016] = val_10;
                mem[1152921529243108024] = ???;
                ._gameMode = val_12;
                this.Add(key:  val_12, value:  new DataStructs.AdventureGameMode());
                val_13 = val_3;
                return (DataStructs.AdventureGameMode)val_13;
            }
            
            System.Exception val_9 = new System.Exception(message:  System.String.Format(format:  "AdventureGameModeDictionary.Get Fail: {0} is not supportted.", arg0:  aNewMode.ToString()));
        }
    
    }

}
