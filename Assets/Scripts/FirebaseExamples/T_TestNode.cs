using UnityEngine;

namespace FirebaseExamples
{
    public class T_TestNode : FirebaseDictionalizer
    {
        // Fields
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool test_bool;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt test_int;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString test_string;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat test_float;
        private System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool> test_dictionary_str_bool;
        private System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> test_dictionary_str_int;
        
        // Properties
        public override string keyName { get; }
        
        // Methods
        public override string get_keyName()
        {
            return "TESTNODE";
        }
        public T_TestNode()
        {
            this.test_dictionary_str_bool = new System.Collections.Generic.Dictionary<System.String, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool>();
            this.test_dictionary_str_int = new System.Collections.Generic.Dictionary<System.String, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>();
        }
        public void PopulateDicts()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            this.test_dictionary_str_bool.Add(key:  "test1", value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
            this.test_dictionary_str_bool.Add(key:  "test2", value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue & 4294967295, fakeValueChanged = val_3.fakeValue & 4294967295, inited = val_3.fakeValue & 4294967295});
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  12030021);
            this.test_dictionary_str_int.Add(key:  "test1", value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited});
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  -1312882);
            this.test_dictionary_str_int.Add(key:  "test2", value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited});
        }
        public override string ToString()
        {
            var val_10;
            System.Func<System.Reflection.FieldInfo, System.Boolean> val_12;
            var val_16;
            var val_17;
            val_10 = null;
            val_10 = null;
            val_12 = T_TestNode.<>c.<>9__10_0;
            if(val_12 == null)
            {
                    System.Func<System.Reflection.FieldInfo, System.Boolean> val_2 = null;
                val_12 = val_2;
                val_2 = new System.Func<System.Reflection.FieldInfo, System.Boolean>(object:  T_TestNode.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean T_TestNode.<>c::<ToString>b__10_0(System.Reflection.FieldInfo x));
                T_TestNode.<>c.<>9__10_0 = val_12;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            System.Collections.Generic.IEnumerator<T> val_5 = System.Linq.Enumerable.Where<System.Reflection.FieldInfo>(source:  this.GetType(), predicate:  val_2).GetEnumerator();
            label_41:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_5.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            T val_9 = val_5.Current;
            val_16 = 5;
            string[] val_10 = new string[5];
            if("" == null)
            {
                    val_16 = 0;
            }
            
            if(val_10.Length == 0)
            {
                    val_16 = 0;
            }
            
            val_10[0] = "";
            val_10[1] = val_9;
            val_10[2] = " ";
            val_10[3] = val_9;
            val_10[4] = "\n";
            string val_11 = +val_10;
            goto label_41;
            label_17:
            val_17 = 0;
            if(val_5 == null)
            {
                
            }
            else
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_5.Dispose();
            }
            
            if( == false)
            {
                    return "";
            }
            
            return "";
        }
    
    }

}
