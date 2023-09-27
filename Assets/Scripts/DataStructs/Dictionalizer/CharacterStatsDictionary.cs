using UnityEngine;

namespace DataStructs.Dictionalizer
{
    public class CharacterStatsDictionary : DictionaryOfDictionalizer<DataStructs.CharacterStats>
    {
        // Methods
        public CharacterStatsDictionary(DataStructs.Dictionalizer.FirebaseDictionalizer owner, System.Reflection.FieldInfo aNewFieldInfo)
        {
        
        }
        public override void LoadDefault()
        {
            var val_10;
            var val_13;
            System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
            label_19:
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_10 = 0;
            if(val_3.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_10 = 1;
            object val_7 = val_3.Current;
            if(null == 999999)
            {
                goto label_19;
            }
            
            new DataStructs.CharacterStats() = new System.Object();
            mem[1152921529243908000] = this.owner;
            mem[1152921529243908008] = ???;
            .<characterName>k__BackingField = null;
            null.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            this.Add(key:  null.ToString(), value:  new DataStructs.CharacterStats());
            goto label_19;
            label_11:
            val_13 = 0;
            if(val_3 != null)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_3.Dispose();
            }
            
            if( == false)
            {
                    return;
            }
        
        }
        public DataStructs.CharacterStats Get(CharacterNameID cid)
        {
            DataStructs.Dictionalizer.FirebaseDictionalizer val_7;
            var val_8;
            if(cid != 999999)
            {
                    val_7 = cid;
                string val_1 = cid.ToString();
                cid.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
                DataStructs.CharacterStats val_2 = 0;
                bool val_3 = this.TryGetValue(key:  val_1, value: out  val_2);
                val_8 = val_2;
                if(val_8 != 0)
            {
                    return (DataStructs.CharacterStats)val_8;
            }
            
                val_7 = this.owner;
                mem[1152921529244079600] = val_7;
                mem[1152921529244079608] = ???;
                .<characterName>k__BackingField = null;
                this.Add(key:  val_1, value:  new DataStructs.CharacterStats());
                val_8 = val_2;
                return (DataStructs.CharacterStats)val_8;
            }
            
            System.Exception val_6 = new System.Exception(message:  "CharacterStatsDictionary.Get Fail: Character id is UNKNOW.");
        }
    
    }

}
