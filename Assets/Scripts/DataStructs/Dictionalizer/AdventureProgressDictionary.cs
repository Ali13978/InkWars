using UnityEngine;

namespace DataStructs.Dictionalizer
{
    public class AdventureProgressDictionary : DictionaryOfDictionalizer<DataStructs.AdventureProgress>
    {
        // Methods
        public AdventureProgressDictionary(DataStructs.Dictionalizer.FirebaseDictionalizer owner, System.Reflection.FieldInfo aNewFieldInfo)
        {
        
        }
        public override void LoadDefault()
        {
            var val_11;
            var val_14;
            System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
            label_20:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_11 = 0;
            if(val_3.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_11 = 1;
            object val_7 = val_3.Current;
            if(null == 999999)
            {
                goto label_20;
            }
            
            null.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            new DataStructs.AdventureProgress() = new System.Object();
            mem[1152921529243436544] = this.owner;
            mem[1152921529243436552] = ???;
            ._characterName = null.ToString();
            null.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            this.Add(key:  null.ToString(), value:  new DataStructs.AdventureProgress());
            goto label_20;
            label_11:
            val_14 = 0;
            if(val_3 != null)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_3.Dispose();
            }
            
            if( == false)
            {
                    return;
            }
        
        }
        public DataStructs.AdventureProgress Get(CharacterNameID cid)
        {
            DataStructs.Dictionalizer.FirebaseDictionalizer val_7;
            var val_8;
            if(cid != 999999)
            {
                    val_7 = cid;
                string val_1 = cid.ToString();
                cid.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
                DataStructs.AdventureProgress val_2 = 0;
                bool val_3 = this.TryGetValue(key:  val_1, value: out  val_2);
                val_8 = val_2;
                if(val_8 != 0)
            {
                    return (DataStructs.AdventureProgress)val_8;
            }
            
                val_7 = this.owner;
                mem[1152921529243607120] = val_7;
                mem[1152921529243607128] = ???;
                ._characterName = val_1;
                this.Add(key:  val_1, value:  new DataStructs.AdventureProgress());
                val_8 = val_2;
                return (DataStructs.AdventureProgress)val_8;
            }
            
            System.Exception val_6 = new System.Exception(message:  "AdventureProgressDictionary.Get Fail: Character id is UNKNOW.");
        }
    
    }

}
