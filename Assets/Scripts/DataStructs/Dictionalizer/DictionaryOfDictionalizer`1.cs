using UnityEngine;

namespace DataStructs.Dictionalizer
{
    public abstract class DictionaryOfDictionalizer<T> : Dictionary<string, T>, IDictionaryLoader
    {
        // Fields
        private DataStructs.Dictionalizer.FirebaseDictionalizer <owner>k__BackingField;
        protected System.Reflection.FieldInfo fieldInfo;
        
        // Properties
        protected DataStructs.Dictionalizer.FirebaseDictionalizer owner { get; set; }
        
        // Methods
        protected DataStructs.Dictionalizer.FirebaseDictionalizer get_owner()
        {
            return (DataStructs.Dictionalizer.FirebaseDictionalizer)this;
        }
        private void set_owner(DataStructs.Dictionalizer.FirebaseDictionalizer value)
        {
            mem[1152921529244283952] = value;
        }
        public DictionaryOfDictionalizer<T>(DataStructs.Dictionalizer.FirebaseDictionalizer aNewOwner, System.Reflection.FieldInfo aNewFieldInfo)
        {
            var val_1;
            var val_2;
            var val_6;
            var val_7;
            var val_8;
            if(this != null)
            {
                    val_6 = 0;
            }
            else
            {
                    val_6 = 1;
            }
            
            mem[1152921529244412360] = aNewFieldInfo;
            label_8:
            if(((-1132250576) & 1) == 0)
            {
                goto label_6;
            }
            
            val_2.InitialType.Load(data:  0);
            goto label_8;
            label_6:
            val_7 = 0;
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 80;
            val_1 = val_2;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 80 + 286) == 0)
            {
                goto label_16;
            }
            
            var val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 80 + 176;
            var val_6 = 0;
            val_5 = val_5 + 8;
            label_15:
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 80 + 176 + 8) + -8) == null)
            {
                goto label_14;
            }
            
            val_6 = val_6 + 1;
            val_5 = val_5 + 16;
            if(val_6 < (__RuntimeMethodHiddenParam + 24 + 192 + 80 + 286))
            {
                goto label_15;
            }
            
            goto label_16;
            label_14:
            val_8 = ((__RuntimeMethodHiddenParam + 24 + 192 + 80) + (((__RuntimeMethodHiddenParam + 24 + 192 + 80 + 176 + 8)) << 4)) + 296;
            label_16:
            val_2.Dispose();
            if( == 0)
            {
                    return;
            }
        
        }
        public abstract void LoadDefault(); // 0
        public void Load(System.Collections.Generic.Dictionary<string, object> data)
        {
            var val_1;
            var val_2;
            var val_15;
            var val_16;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_17;
            var val_18;
            var val_19;
            val_15 = __RuntimeMethodHiddenParam;
            val_16 = this;
            if(data == null)
            {
                    return;
            }
            
            label_15:
            if(((-1132093520) & 1) == 0)
            {
                goto label_4;
            }
            
            System.Type val_3 = val_2.InitialType;
            if((data.ContainsKey(key:  val_3)) == false)
            {
                goto label_15;
            }
            
            if((System.Type.op_Equality(left:  data.Item[val_3].GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    val_17 = data.Item[val_3].ToObject<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            }
            else
            {
                    val_17 = data.Item[val_3];
            }
            
            if((val_17 == null) || (this == null))
            {
                goto label_15;
            }
            
            this.Load(data:  val_17);
            goto label_15;
            label_4:
            val_18 = 0;
            val_15 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 128];
            val_15 = __RuntimeMethodHiddenParam + 24 + 192 + 128;
            val_2 = val_15;
            val_1 = val_2;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 128 + 286) == 0)
            {
                goto label_33;
            }
            
            var val_13 = __RuntimeMethodHiddenParam + 24 + 192 + 128 + 176;
            var val_14 = 0;
            val_13 = val_13 + 8;
            label_32:
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 128 + 176 + 8) + -8) == null)
            {
                goto label_31;
            }
            
            val_14 = val_14 + 1;
            val_13 = val_13 + 16;
            if(val_14 < (__RuntimeMethodHiddenParam + 24 + 192 + 128 + 286))
            {
                goto label_32;
            }
            
            goto label_33;
            label_31:
            val_19 = (val_15 + (((__RuntimeMethodHiddenParam + 24 + 192 + 128 + 176 + 8)) << 4)) + 296;
            label_33:
            val_2.Dispose();
            if( == 0)
            {
                    return;
            }
        
        }
    
    }

}
