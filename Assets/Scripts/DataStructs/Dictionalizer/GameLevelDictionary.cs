using UnityEngine;

namespace DataStructs.Dictionalizer
{
    public class GameLevelDictionary : DictionaryOfDictionalizer<DataStructs.GameLevel>
    {
        // Fields
        public const int MIN_LEVEL_ID = 0;
        public const int MAX_LEVEL_ID = 11;
        
        // Methods
        public GameLevelDictionary(DataStructs.Dictionalizer.FirebaseDictionalizer owner, System.Reflection.FieldInfo aNewFieldInfo)
        {
        
        }
        public override void LoadDefault()
        {
            do
            {
                mem[1152921529244894000] = this.owner;
                mem[1152921529244894008] = ???;
                ._gameLevel = 0;
                this.Add(key:  0.ToString(), value:  new DataStructs.GameLevel());
            }
            while(1 < 12);
        
        }
        public DataStructs.GameLevel Get(int levelIdFrom0to11)
        {
            DataStructs.Dictionalizer.FirebaseDictionalizer val_9;
            var val_10;
            if(levelIdFrom0to11 < 12)
            {
                    int val_1 = UnityEngine.Mathf.Clamp(value:  levelIdFrom0to11, min:  0, max:  11);
                string val_2 = val_1.ToString();
                DataStructs.GameLevel val_3 = 0;
                bool val_4 = this.TryGetValue(key:  val_2, value: out  val_3);
                val_10 = val_3;
                if(val_10 != 0)
            {
                    return (DataStructs.GameLevel)val_10;
            }
            
                val_9 = this.owner;
                mem[1152921529245053280] = val_9;
                mem[1152921529245053288] = ???;
                ._gameLevel = val_1;
                this.Add(key:  val_2, value:  new DataStructs.GameLevel());
                val_10 = val_3;
                return (DataStructs.GameLevel)val_10;
            }
            
            System.Exception val_8 = new System.Exception(message:  System.String.Format(format:  "GetGameLevel Fail: Level Id must between {0} and {1}.", arg0:  0, arg1:  11));
        }
    
    }

}
