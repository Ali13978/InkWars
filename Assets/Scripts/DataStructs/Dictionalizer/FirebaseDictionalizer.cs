using UnityEngine;

namespace DataStructs.Dictionalizer
{
    public abstract class FirebaseDictionalizer
    {
        // Fields
        public DataStructs.Dictionalizer.FirebaseDictionalizer previousNode;
        private System.Reflection.FieldInfo belonedDictionaryField;
        
        // Properties
        public System.Collections.Generic.Dictionary<string, DataStructs.Dictionalizer.FirebaseDictionalizer[]> nextNodes { get; }
        public abstract string keyName { get; }
        
        // Methods
        public System.Collections.Generic.Dictionary<string, DataStructs.Dictionalizer.FirebaseDictionalizer[]> get_nextNodes()
        {
            var val_32;
            System.Func<System.Reflection.FieldInfo, System.Boolean> val_34;
            System.Type val_35;
            var val_37;
            var val_38;
            System.Type val_41;
            var val_42;
            var val_43;
            DataStructs.Dictionalizer.FirebaseDictionalizer val_47;
            var val_50;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_57;
            var val_58;
            string val_59;
            string val_60;
            System.Collections.Generic.Dictionary<System.String, DataStructs.Dictionalizer.FirebaseDictionalizer[]> val_1 = new System.Collections.Generic.Dictionary<System.String, DataStructs.Dictionalizer.FirebaseDictionalizer[]>();
            val_32 = null;
            val_32 = null;
            val_34 = FirebaseDictionalizer.<>c.<>9__3_0;
            if(val_34 == null)
            {
                    System.Func<System.Reflection.FieldInfo, System.Boolean> val_3 = null;
                val_34 = val_3;
                val_3 = new System.Func<System.Reflection.FieldInfo, System.Boolean>(object:  FirebaseDictionalizer.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FirebaseDictionalizer.<>c::<get_nextNodes>b__3_0(System.Reflection.FieldInfo x));
                FirebaseDictionalizer.<>c.<>9__3_0 = val_34;
            }
            
            var val_39 = 0;
            val_39 = val_39 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = System.Linq.Enumerable.Where<System.Reflection.FieldInfo>(source:  this.GetType(), predicate:  val_3).GetEnumerator();
            val_37 = 1152921505152266240;
            val_38 = 0;
            label_81:
            var val_40 = 0;
            val_40 = val_40 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_41 = 0;
            val_41 = val_41 + 1;
            val_41 = val_6.Current;
            val_35 = val_41;
            if((DataStructs.Dictionalizer.FirebaseDictionalizer.IsSubclassOfRawGeneric(toCheck:  val_35, generic:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_26;
            }
            
            val_42 = this;
            val_35 = val_41;
            if(val_35 == 0)
            {
                goto label_27;
            }
            
            if(val_35 == 0)
            {
                goto label_28;
            }
            
            System.Collections.Generic.List<DataStructs.Dictionalizer.FirebaseDictionalizer> val_13 = new System.Collections.Generic.List<DataStructs.Dictionalizer.FirebaseDictionalizer>();
            var val_45 = val_35;
            if((val_10 + 286) == 0)
            {
                goto label_32;
            }
            
            var val_42 = val_10 + 176;
            var val_43 = 0;
            val_42 = val_42 + 8;
            label_31:
            if(((val_10 + 176 + 8) + -8) == null)
            {
                goto label_30;
            }
            
            val_43 = val_43 + 1;
            val_42 = val_42 + 16;
            if(val_43 < (val_10 + 286))
            {
                goto label_31;
            }
            
            goto label_32;
            label_30:
            var val_44 = val_42;
            val_44 = val_44 + 3;
            val_45 = val_45 + val_44;
            val_43 = val_45 + 296;
            label_32:
            var val_46 = 0;
            val_46 = val_46 + 1;
            System.Collections.IEnumerator val_16 = val_35.Values.GetEnumerator();
            label_55:
            var val_47 = 0;
            val_47 = val_47 + 1;
            if(val_16.MoveNext() == false)
            {
                goto label_43;
            }
            
            var val_48 = 0;
            val_48 = val_48 + 1;
            val_47 = val_16.Current;
            if(val_47 == null)
            {
                goto label_49;
            }
            
            val_50 = null;
            if(null == null)
            {
                    val_50 = null;
            }
            
            val_47 = 0;
            null.Add(item:  val_47);
            goto label_55;
            label_43:
            val_52 = 0;
            val_53 = val_38 + 1;
            mem2[0] = 305;
            goto label_56;
            label_49:
            new System.Exception() = new System.Exception(message:  System.String.Format(format:  "Cannot convert {0} to FirebaseDictionalizer", arg0:  val_47.GetType()));
            goto label_115;
            label_56:
            if(val_16 != null)
            {
                    var val_49 = 0;
                val_49 = val_49 + 1;
                val_57 = public System.Void System.IDisposable::Dispose();
                val_16.Dispose();
            }
            
            if( != false)
            {
                    val_57 = 0;
            }
            
            if( != 1)
            {
                    var val_27 = (mem[1152921529458424048] == 305) ? 1 : 0;
                val_27 = (( >= 0) ? 1 : 0) & val_27;
                 =  - val_27;
            }
            
            val_1.Add(key:  val_41, value:  null.ToArray());
            goto label_81;
            label_17:
            var val_30 = val_38 + 1;
            val_58 = 0;
            mem2[0] = 347;
            if(val_6 != null)
            {
                goto label_82;
            }
            
            goto label_117;
            label_26:
            val_59 = System.String.Format(format:  "{0} marked as Dictionalize(FieldType.NODE) should be typeof(DictionaryOfDictionalizer<>) not {1}", arg0:  val_41, arg1:  val_41);
            new System.Exception() = new System.Exception(message:  val_59);
            val_42 = 0;
            label_27:
            val_60 = System.String.Format(format:  "{0} cannot be null", arg0:  val_59);
            new System.Exception() = new System.Exception(message:  val_60);
            label_28:
            new System.Exception() = new System.Exception(message:  System.String.Format(format:  "Cannot convert {0} to IDictionary type", arg0:  val_60));
            label_115:
            val_54 = 0;
            val_55 = new System.Exception();
            if(val_54 != 1)
            {
                goto label_116;
            }
            
            if(val_6 == null)
            {
                goto label_117;
            }
            
            label_82:
            var val_50 = 0;
            val_50 = val_50 + 1;
            val_6.Dispose();
            label_117:
            if(null == null)
            {
                    return val_1;
            }
            
            return val_1;
            label_116:
        }
        public abstract string get_keyName(); // 0
        public string GetFullPath()
        {
            System.Reflection.FieldInfo val_5;
            string val_6;
            string val_7;
            val_5 = this.belonedDictionaryField;
            if((System.Reflection.FieldInfo.op_Inequality(left:  0, right:  val_5)) != false)
            {
                    val_5 = ".";
                val_6 = this.belonedDictionaryField + val_5;
            }
            else
            {
                    val_6 = "";
            }
            
            val_7 = val_6 + this;
            if(this.previousNode == null)
            {
                    return val_7 + ".";
            }
            
            val_7 = this.previousNode + val_7;
            return val_7 + ".";
        }
        public FirebaseDictionalizer(DataStructs.Dictionalizer.FirebaseDictionalizer aNewPrevNode, System.Reflection.FieldInfo aNewBelonedDictionaryField)
        {
            val_1 = new System.Object();
            this.previousNode = aNewPrevNode;
            this.belonedDictionaryField = val_1;
        }
        protected virtual void CustomInitAfterLoadDefaults()
        {
        
        }
        protected void LoadDefaults()
        {
            IntPtr val_26;
            var val_27;
            System.Func<System.Reflection.FieldInfo, System.Boolean> val_29;
            var val_33;
            var val_34;
            var val_36;
            val_26 = 1152921505152425984;
            val_27 = null;
            val_27 = null;
            val_29 = FirebaseDictionalizer.<>c.<>9__9_0;
            if(val_29 == null)
            {
                    System.Func<System.Reflection.FieldInfo, System.Boolean> val_2 = null;
                val_29 = val_2;
                val_2 = new System.Func<System.Reflection.FieldInfo, System.Boolean>(object:  FirebaseDictionalizer.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FirebaseDictionalizer.<>c::<LoadDefaults>b__9_0(System.Reflection.FieldInfo x));
                FirebaseDictionalizer.<>c.<>9__9_0 = val_29;
            }
            
            var val_29 = 0;
            val_29 = val_29 + 1;
            System.Collections.Generic.IEnumerator<T> val_5 = System.Linq.Enumerable.Where<System.Reflection.FieldInfo>(source:  this.GetType(), predicate:  val_2).GetEnumerator();
            label_55:
            var val_30 = 0;
            val_30 = val_30 + 1;
            if(val_5.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_31 = 0;
            val_31 = val_31 + 1;
            T val_9 = val_5.Current;
            val_26 = null;
            if((DataStructs.Dictionalizer.FirebaseDictionalizer.IsSubclassOfRawGeneric(toCheck:  val_9, generic:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_26}))) == false)
            {
                goto label_26;
            }
            
            object[] val_12 = new object[2];
            val_12[0] = this;
            val_12[1] = val_9;
            val_9.SetValue(obj:  this, value:  System.Activator.CreateInstance(type:  val_9, args:  val_12));
            goto label_55;
            label_26:
            if((System.Type.op_Equality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), right:  val_9)) != true)
            {
                    if((System.Type.op_Equality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), right:  val_9)) != true)
            {
                    if((System.Type.op_Equality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), right:  val_9)) == false)
            {
                goto label_42;
            }
            
            }
            
            }
            
            label_49:
            val_9.SetValue(obj:  this, value:  System.Activator.CreateInstance(type:  val_9));
            goto label_55;
            label_42:
            if((val_9 & 1) == 0)
            {
                goto label_45;
            }
            
            val_26 = null;
            if((System.Type.op_Equality(left:  val_9, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_26}))) == true)
            {
                goto label_49;
            }
            
            label_45:
            if((System.Type.op_Equality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), right:  val_9)) == false)
            {
                goto label_52;
            }
            
            val_9.SetValue(obj:  this, value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  ""));
            goto label_55;
            label_17:
            val_33 = 0;
            if(val_5 != null)
            {
                goto label_56;
            }
            
            goto label_96;
            label_52:
            new System.Exception() = new System.Exception(message:  System.String.Format(format:  "{0} {1} is not supported for Firebase Data structure.", arg0:  val_9, arg1:  val_9));
            if(0 != 1)
            {
                goto label_95;
            }
            
            if(val_5 == null)
            {
                goto label_96;
            }
            
            label_56:
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_36 = public System.Void System.IDisposable::Dispose();
            val_5.Dispose();
            label_96:
            if(null != null)
            {
                    val_36 = 0;
            }
            
            val_34 = this;
            goto typeof(DataStructs.Dictionalizer.FirebaseDictionalizer).__il2cppRuntimeField_178;
            label_95:
        }
        public void Load(System.Collections.Generic.Dictionary<string, object> data)
        {
            object val_26;
            var val_92;
            object val_93;
            var val_94;
            System.Func<System.Reflection.FieldInfo, System.Boolean> val_96;
            UnityEngine.DrivenTransformProperties val_97;
            string val_101;
            var val_102;
            System.Collections.IDictionary val_103;
            System.Collections.IDictionary val_104;
            System.Collections.IDictionary val_105;
            var val_106;
            var val_107;
            var val_108;
            var val_109;
            var val_111;
            var val_112;
            System.Func<System.Reflection.FieldInfo, System.Boolean> val_114;
            object val_118;
            var val_119;
            string val_120;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_121;
            var val_122;
            var val_124;
            val_93 = data;
            this.LoadDefaults();
            if(val_93 == null)
            {
                    return;
            }
            
            val_94 = null;
            val_94 = null;
            val_96 = FirebaseDictionalizer.<>c.<>9__10_0;
            if(val_96 == null)
            {
                    val_96 = null;
                val_97 = public System.Void System.Func<System.Reflection.FieldInfo, System.Boolean>::.ctor(object object, IntPtr method);
                val_96 = new System.Func<System.Reflection.FieldInfo, System.Boolean>(object:  FirebaseDictionalizer.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FirebaseDictionalizer.<>c::<Load>b__10_0(System.Reflection.FieldInfo x));
                FirebaseDictionalizer.<>c.<>9__10_0 = val_96;
            }
            
            var val_97 = 0;
            val_97 = val_97 + 1;
            System.Collections.Generic.IEnumerator<T> val_5 = System.Linq.Enumerable.Where<System.Reflection.FieldInfo>(source:  this.GetType(), predicate:  null).GetEnumerator();
            label_180:
            var val_98 = 0;
            val_98 = val_98 + 1;
            if(val_5.MoveNext() == false)
            {
                goto label_18;
            }
            
            var val_99 = 0;
            val_99 = val_99 + 1;
            T val_9 = val_5.Current;
            if((val_93.ContainsKey(key:  val_9)) == false)
            {
                goto label_180;
            }
            
            val_101 = val_93.Item[val_9];
            if((System.Type.op_Equality(left:  val_9, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_28;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_14 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            val_9.SetValue(obj:  this, value:  val_14);
            goto label_85;
            label_28:
            if((System.Type.op_Equality(left:  val_9, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_34;
            }
            
            if((System.Int32.TryParse(s:  val_101, result: out  0)) == false)
            {
                goto label_36;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_19 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            val_9.SetValue(obj:  this, value:  val_19);
            goto label_85;
            label_34:
            if((System.Type.op_Equality(left:  val_9, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_42;
            }
            
            if((System.Single.TryParse(s:  val_101, result: out  float val_22 = -0.01971701f)) == false)
            {
                goto label_44;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_24 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  0f);
            val_9.SetValue(obj:  this, value:  val_26);
            goto label_85;
            label_42:
            if((System.Type.op_Equality(left:  val_9, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_50;
            }
            
            val_9.SetValue(obj:  this, value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_101));
            goto label_85;
            label_50:
            if(((val_9 & 1) == 0) || ((System.Type.op_Equality(left:  val_9, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false))
            {
                goto label_60;
            }
            
            if((System.Type.op_Equality(left:  val_101.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    if(val_101 != null)
            {
                    val_102 = null;
            }
            
                if(val_101 != null)
            {
                    val_102 = null;
            }
            
                val_101 = ToObject<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            }
            
            if((System.Type.op_Equality(left:  val_9 + 40, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_76;
            }
            
            if(val_101 == null)
            {
                goto label_77;
            }
            
            val_103 = val_101;
            if(val_103 != null)
            {
                goto label_78;
            }
            
            label_77:
            val_103 = 0;
            label_78:
            val_9.SetValue(obj:  this, value:  this.FromObjDictionary<CodeStage.AntiCheat.ObscuredTypes.ObscuredBool>(source:  val_103));
            goto label_85;
            label_76:
            if((System.Type.op_Equality(left:  val_9 + 40, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_82;
            }
            
            if(val_101 == null)
            {
                goto label_83;
            }
            
            val_104 = val_101;
            if(val_104 != null)
            {
                goto label_84;
            }
            
            label_83:
            val_104 = 0;
            label_84:
            val_9.SetValue(obj:  this, value:  this.FromObjDictionary<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>(source:  val_104));
            goto label_85;
            label_82:
            if((System.Type.op_Equality(left:  val_9 + 40, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_88;
            }
            
            if(val_101 == null)
            {
                goto label_89;
            }
            
            val_105 = val_101;
            if(val_105 != null)
            {
                goto label_90;
            }
            
            label_89:
            val_105 = 0;
            label_90:
            val_9.SetValue(obj:  this, value:  this.FromObjDictionary<System.String>(source:  val_105));
            label_85:
            if(val_9 != 0)
            {
                goto label_180;
            }
            
            goto label_180;
            label_36:
            new System.InvalidCastException() = new System.InvalidCastException(message:  "int cast failed value = "("int cast failed value = ") + val_101);
            goto label_184;
            label_44:
            new System.InvalidCastException() = new System.InvalidCastException(message:  "float cast failed value = "("float cast failed value = ") + val_101);
            goto label_184;
            label_60:
            new System.Exception() = new System.Exception(message:  System.String.Format(format:  "Found [Dictionalizable] on Invalid Variable Type {0}/{1}", arg0:  val_9, arg1:  val_9));
            goto label_184;
            label_88:
            new System.InvalidCastException() = new System.InvalidCastException(message:  "Found [Dictionalizable] on Invalid Dictionary Type only String, ObscuredBool, ObscuredInt are Supported");
            goto label_184;
            label_18:
            val_106 = 0;
            val_108 = 0;
            if(val_5 != null)
            {
                goto label_181;
            }
            
            goto label_200;
            label_184:
            val_106 = 0;
            val_107 = new System.InvalidCastException();
            if( != 1)
            {
                goto label_342;
            }
            
            val_106 = 0;
            if(val_5 == null)
            {
                goto label_200;
            }
            
            label_181:
            var val_100 = 0;
            val_100 = val_100 + 1;
            val_5.Dispose();
            label_200:
            if(val_106 != 1)
            {
                    var val_59 = (730 == 730) ? 1 : 0;
                val_59 = ((val_106 >= 0) ? 1 : 0) & val_59;
                val_111 = val_106 - val_59;
            }
            else
            {
                    val_111 = 0;
            }
            
            val_112 = null;
            val_112 = null;
            val_114 = FirebaseDictionalizer.<>c.<>9__10_1;
            if(val_114 == null)
            {
                    val_114 = null;
                val_97 = public System.Void System.Func<System.Reflection.FieldInfo, System.Boolean>::.ctor(object object, IntPtr method);
                val_114 = new System.Func<System.Reflection.FieldInfo, System.Boolean>(object:  FirebaseDictionalizer.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FirebaseDictionalizer.<>c::<Load>b__10_1(System.Reflection.FieldInfo x));
                FirebaseDictionalizer.<>c.<>9__10_1 = val_114;
            }
            
            var val_101 = 0;
            val_101 = val_101 + 1;
            val_92 = System.Linq.Enumerable.Where<System.Reflection.FieldInfo>(source:  this.GetType(), predicate:  null).GetEnumerator();
            label_294:
            var val_102 = 0;
            val_102 = val_102 + 1;
            if(val_92.MoveNext() == false)
            {
                goto label_224;
            }
            
            var val_103 = 0;
            val_103 = val_103 + 1;
            T val_69 = val_92.Current;
            if((val_93.ContainsKey(key:  val_69)) == false)
            {
                goto label_294;
            }
            
            if((DataStructs.Dictionalizer.FirebaseDictionalizer.IsSubclassOfRawGeneric(toCheck:  val_69, generic:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_234;
            }
            
            if(val_69 == 0)
            {
                goto label_235;
            }
            
            if(val_69 == 0)
            {
                goto label_236;
            }
            
            if((System.Type.op_Equality(left:  val_93.Item[val_69].GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_240;
            }
            
            val_118 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            object val_77 = val_93.Item[val_69];
            if(val_77 != null)
            {
                    val_119 = null;
            }
            
            if(val_77 == null)
            {
                goto label_246;
            }
            
            val_119 = null;
            goto label_246;
            label_234:
            object[] val_78 = new object[1];
            val_78[0] = val_69;
            UnityEngine.Debug.LogErrorFormat(format:  "Load from dictionary fail: Unknow target type {0}.", args:  val_78);
            goto label_294;
            label_236:
            label_235:
            object[] val_80 = new object[1];
            val_80[0] = val_69.GetType();
            UnityEngine.Debug.LogErrorFormat(format:  "Load from dictionary fail: cannot convert {0} to IDictionaryLoader.", args:  val_80);
            goto label_294;
            label_240:
            val_120 = val_69;
            val_118 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            val_121 = val_93.Item[val_120];
            if(val_121 == null)
            {
                goto label_263;
            }
            
            goto label_289;
            label_246:
            val_120 = public System.Collections.Generic.Dictionary<System.String, System.Object> Newtonsoft.Json.Linq.JToken::ToObject<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            val_121 = ToObject<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            if(val_121 != null)
            {
                goto label_289;
            }
            
            label_263:
            val_118 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            object val_85 = val_93.Item[val_69];
            object[] val_86 = new object[2];
            val_122 = mem[val_69 + 424 + 8];
            val_122 = val_69 + 424 + 8;
            if((val_69 != 0) && (val_69 == 0))
            {
                    val_122 = 0;
            }
            
            if(val_86.Length == 0)
            {
                    val_122 = 0;
            }
            
            val_86[0] = val_69;
            val_86[1] = val_93.Item[val_69].GetType();
            UnityEngine.Debug.LogErrorFormat(format:  "Load from dictionary fail: cannot convert {0} Type {1} to Dictionary<string, object>.", args:  val_86);
            goto label_294;
            label_289:
            var val_107 = val_69;
            if((val_69 + 286) == 0)
            {
                goto label_290;
            }
            
            var val_105 = val_69 + 176;
            var val_106 = 0;
            val_105 = val_105 + 8;
            label_292:
            if(((val_69 + 176 + 8) + -8) == null)
            {
                goto label_291;
            }
            
            val_106 = val_106 + 1;
            val_105 = val_105 + 16;
            if(val_106 < (val_69 + 286))
            {
                goto label_292;
            }
            
            label_290:
            val_118 = 0;
            goto label_293;
            label_291:
            val_107 = val_107 + (((val_69 + 176 + 8)) << 4);
            val_124 = val_107 + 296;
            label_293:
            val_69.Load(data:  null);
            goto label_294;
            label_224:
            var val_108 = 0;
            val_93 = 0;
            val_108 = val_108 + 1;
            mem2[0] = 1195;
            if(val_92 == null)
            {
                
            }
            else
            {
                    var val_109 = 0;
                val_109 = val_109 + 1;
            }
            
            if( == false)
            {
                    return;
            }
            
            return;
            label_342:
            if( == 1)
            {
                    if((null & 1) != 0)
            {
                    val_93 = 1152921504621596672.Message;
                UnityEngine.Debug.LogError(message:  val_93);
                return;
            }
            
                val_109 = 8;
                mem[8] = null;
                val_107 = val_109;
            }
        
        }
        private System.Collections.Generic.Dictionary<string, T> FromObjDictionary<T>(System.Collections.IDictionary source)
        {
            var val_44;
            var val_45;
            var val_48;
            string val_52;
            var val_53;
            var val_54;
            var val_56;
            var val_59;
            var val_64;
            var val_66;
            var val_72;
            val_44 = source;
            val_45 = 1152921504624791552;
            if((System.Type.op_Equality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 16}), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_57;
            }
            
            var val_59 = 0;
            val_59 = val_59 + 1;
            var val_60 = 0;
            val_60 = val_60 + 1;
            System.Collections.IEnumerator val_7 = val_44.Keys.GetEnumerator();
            goto label_15;
            label_40:
            var val_61 = 0;
            val_61 = val_61 + 1;
            val_48 = 1;
            var val_62 = 0;
            val_62 = val_62 + 1;
            val_48 = 0;
            object val_11 = val_44.Item[val_7.Current];
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            object val_14 = System.Convert.ChangeType(value:  val_12, conversionType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 16}));
            var val_16 = (X23 & (-4294967296)) | (__RuntimeMethodHiddenParam + 48 + 24 + 294);
            val_45 = 1152921504624791552;
            label_15:
            var val_63 = 0;
            val_63 = val_63 + 1;
            if(val_7.MoveNext() == true)
            {
                goto label_40;
            }
            
            val_52 = 0;
            val_53 = 0;
            if(val_7 != null)
            {
                    var val_64 = 0;
                val_64 = val_64 + 1;
                val_7.Dispose();
            }
            
            val_56 = ;
            if(val_56 == 1)
            {
                goto label_57;
            }
            
            if(458 != 458)
            {
                goto label_58;
            }
            
            return (System.Collections.Generic.Dictionary<System.String, T>)__RuntimeMethodHiddenParam + 48;
            label_57:
            val_56 = 0;
            label_58:
            if((System.Type.op_Equality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 16}), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_124;
            }
            
            var val_65 = 0;
            val_65 = val_65 + 1;
            var val_66 = 0;
            val_66 = val_66 + 1;
            System.Collections.IEnumerator val_26 = val_44.Keys.GetEnumerator();
            goto label_73;
            label_100:
            var val_67 = 0;
            val_67 = val_67 + 1;
            val_59 = 1;
            var val_68 = 0;
            val_68 = val_68 + 1;
            val_59 = 0;
            val_52 = val_44.Item[val_26.Current];
            if((System.Int32.TryParse(s:  val_52, result: out  0)) == false)
            {
                goto label_85;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_33 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            val_52 = System.Convert.ChangeType(value:  val_33, conversionType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 16}));
            var val_36 = 0 | (__RuntimeMethodHiddenParam + 48 + 24 + 294);
            val_45 = 1152921504624791552;
            label_73:
            var val_69 = 0;
            val_69 = val_69 + 1;
            if(val_26.MoveNext() == true)
            {
                goto label_100;
            }
            
            val_64 = 0;
            goto label_101;
            label_85:
            new System.InvalidCastException() = new System.InvalidCastException(message:  "int cast failed value = "("int cast failed value = ") + val_52);
            val_45 = 1152921504624791552;
            val_54 = new System.InvalidCastException();
            if(0 != 1)
            {
                goto label_172;
            }
            
            label_101:
            if(val_26 != null)
            {
                    var val_70 = 0;
                val_70 = val_70 + 1;
                val_26.Dispose();
            }
            
            val_56 = 1;
            if(val_56 == 1)
            {
                goto label_123;
            }
            
            if(458 != 458)
            {
                goto label_124;
            }
            
            return (System.Collections.Generic.Dictionary<System.String, T>)__RuntimeMethodHiddenParam + 48;
            label_123:
            val_56 = 0;
            label_124:
            val_66 = 0;
            if((System.Type.op_Equality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 16}), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                    return (System.Collections.Generic.Dictionary<System.String, T>)__RuntimeMethodHiddenParam + 48;
            }
            
            var val_71 = 0;
            val_71 = val_71 + 1;
            val_66 = 2;
            var val_72 = 0;
            val_72 = val_72 + 1;
            val_66 = 0;
            System.Collections.IEnumerator val_48 = val_44.Keys.GetEnumerator();
            val_45 = 1152921504687943680;
            label_163:
            var val_73 = 0;
            val_73 = val_73 + 1;
            val_66 = 0;
            if(val_48.MoveNext() == false)
            {
                goto label_144;
            }
            
            var val_74 = 0;
            val_74 = val_74 + 1;
            val_66 = 1;
            var val_75 = 0;
            val_75 = val_75 + 1;
            val_66 = 0;
            object val_56 = System.Convert.ChangeType(value:  val_44.Item[val_48.Current], conversionType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 16}));
            val_56 = (val_56 & (-4294967296)) | (__RuntimeMethodHiddenParam + 48 + 24 + 294);
            goto label_163;
            label_144:
            val_72 = 0;
            val_56 = 1152921504621170688;
            val_44 = val_48;
            if(val_44 != null)
            {
                    var val_76 = 0;
                val_76 = val_76 + 1;
                val_44.Dispose();
            }
            
            if( == false)
            {
                    return (System.Collections.Generic.Dictionary<System.String, T>)__RuntimeMethodHiddenParam + 48;
            }
            
            return (System.Collections.Generic.Dictionary<System.String, T>)__RuntimeMethodHiddenParam + 48;
            label_172:
        }
        public System.Collections.Generic.Dictionary<string, object> SaveRecursively()
        {
            string val_28;
            var val_34;
            var val_35;
            var val_42;
            System.Type val_2 = this.GetType();
            val_35 = 0;
            goto label_9;
            label_55:
            val_34 = 0;
            if((System.Reflection.CustomAttributeExtensions.GetCustomAttribute(element:  System.Type.__il2cppRuntimeField_byval_arg, attributeType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != null)
            {
                    val_34 = 0;
            }
            
            val_35 = 1;
            label_9:
            if(val_35 < null)
            {
                goto label_55;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_26 = this.nextNodes.GetEnumerator();
            label_66:
            if(((-1129502864) & 1) == 0)
            {
                goto label_57;
            }
            
            UnityEngine.Playables.PlayableHandle val_29 = GetHandle();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_30 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_42 = 0;
            goto label_58;
            label_64:
            null.set_Item(key:  val_28, value:  val_28);
            val_42 = 1;
            label_58:
            if(val_42 < 0)
            {
                goto label_64;
            }
            
            new System.Collections.Generic.Dictionary<System.String, System.Object>().set_Item(key:  val_29.m_Handle.ToInt64(), value:  null);
            goto label_66;
            label_57:
            Add(driver:  public System.Void Dictionary.Enumerator<System.String, DataStructs.Dictionalizer.FirebaseDictionalizer[]>::Dispose(), rectTransform:  typeof(System.Type).__il2cppRuntimeField_420, drivenProperties:  null);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>);
        }
        private System.Collections.Generic.Dictionary<string, object> ToObjDictionary(System.Collections.IDictionary source)
        {
            var val_28;
            var val_29;
            var val_35;
            var val_36;
            var val_38;
            System.Type val_39;
            object val_40;
            var val_41;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredString val_42;
            val_28 = source;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_28 == null)
            {
                    return val_1;
            }
            
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_29 = 2;
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_29 = 0;
            System.Collections.IEnumerator val_5 = val_28.Keys.GetEnumerator();
            label_69:
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_29 = 0;
            if(val_5.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_29 = 1;
            object val_9 = val_5.Current;
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_29 = 0;
            val_35 = public System.Object System.Collections.IDictionary::get_Item(object key);
            val_36 = val_28.Item[val_9];
            if(val_36 != null)
            {
                goto label_26;
            }
            
            object[] val_12 = new object[2];
            var val_39 = 0;
            val_39 = val_39 + 1;
            val_35 = 0;
            val_12[0] = val_28.Item[val_9].GetType();
            val_12[1] = val_9;
            UnityEngine.Debug.LogErrorFormat(format:  "Cannot convert {0} to object, key: {1}", args:  val_12);
            goto label_69;
            label_26:
            if((System.Type.op_Equality(left:  val_36.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_44;
            }
            
            val_38 = null;
            val_38 = null;
            val_40 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 21192704, hiddenValue = 268435456, fakeValue = 455270400, inited = false});
            goto label_64;
            label_44:
            if((System.Type.op_Equality(left:  val_36.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_50;
            }
            
            val_40 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {hiddenValue = 268435456, fakeValue = true, fakeValueChanged = true, inited = true});
            goto label_64;
            label_50:
            if((System.Type.op_Equality(left:  val_36.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_56;
            }
            
            val_41 = null;
            goto label_65;
            label_56:
            val_39 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if((System.Type.op_Equality(left:  val_36.GetType(), right:  val_39)) == false)
            {
                goto label_64;
            }
            
            val_40 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {currentCryptoKey = 21192704, hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4() {b4 = 16}, hiddenValueOld = 1152921504628039680, fakeValue = 5.107783E-37f, inited = false});
            goto label_64;
            label_65:
            if(null != )
            {
                    val_42 = 0;
            }
            
            val_39 = 0;
            val_40 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_42);
            label_64:
            val_1.Add(key:  val_9, value:  val_40);
            goto label_69;
            label_16:
            val_28 = 0;
            if(val_5 != null)
            {
                    var val_40 = 0;
                val_40 = val_40 + 1;
                val_5.Dispose();
            }
            
            if( == false)
            {
                    return val_1;
            }
            
            return val_1;
        }
        public void SaveVariable(string name, object obj)
        {
            var val_26;
            string val_27;
            IntPtr val_28;
            var val_29;
            var val_30;
            object val_31;
            var val_32;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredString val_33;
            System.Collections.IDictionary val_34;
            val_26 = obj;
            val_27 = name;
            if(IWServerDB_Cache.IsSaveCacheEnabled == false)
            {
                    return;
            }
            
            val_28 = null;
            if((System.Type.op_Equality(left:  val_26.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_28}))) == false)
            {
                goto label_7;
            }
            
            val_29 = null;
            val_29 = null;
            int val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 21192704, hiddenValue = 268435456, fakeValue = 455270400, inited = false});
            val_30 = 1152921504621490176;
            goto label_10;
            label_7:
            val_28 = null;
            if((System.Type.op_Equality(left:  val_26.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_28}))) == false)
            {
                goto label_14;
            }
            
            val_30 = 1152921504617123840;
            bool val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {hiddenValue = 268435456, fakeValue = false, fakeValueChanged = true, inited = true});
            label_10:
            label_36:
            label_47:
            val_31 = val_10;
            label_44:
            DataStructs.UserDataDictionary.OnValueChanged(key:  val_27, obj:  val_10);
            val_27 = this.GetFullPath() + val_27;
            IWServerDB_Cache.AddToCache(path:  val_27, data:  val_10);
            return;
            label_14:
            if((System.Type.op_Equality(left:  val_26.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_24;
            }
            
            val_32 = null;
            val_32 = null;
            if((val_26 != null) && (null != val_32))
            {
                    val_33 = 0;
            }
            
            string val_16 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_33);
            goto label_47;
            label_24:
            if((System.Type.op_Equality(left:  val_26.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_33;
            }
            
            float val_20 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {currentCryptoKey = 21192704, hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4() {b4 = 16}, hiddenValueOld = 1152921504628039680, fakeValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.__il2cppRuntimeField_cctor_finished, inited = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.__il2cppRuntimeField_cctor_finished});
            goto label_36;
            label_33:
            if(((val_26.GetType() & 1) == 0) || ((System.Type.op_Equality(left:  val_26.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false))
            {
                goto label_44;
            }
            
            if(val_26 == null)
            {
                goto label_45;
            }
            
            val_34 = val_26;
            if(val_34 != null)
            {
                goto label_46;
            }
            
            label_45:
            val_34 = 0;
            label_46:
            System.Collections.Generic.Dictionary<System.String, System.Object> val_25 = X0.ToObjDictionary(source:  val_34);
            goto label_47;
        }
        public void SaveVariableImmediately(string name, object obj)
        {
            if(IWServerDB_Cache.IsSaveCacheEnabled == false)
            {
                    return;
            }
            
            this.SaveVariable(name:  name, obj:  obj);
        }
        public static bool IsSubclassOfRawGeneric(System.Type toCheck, System.Type generic)
        {
            System.Type val_5;
            System.Type val_6;
            var val_7;
            val_6 = toCheck;
            goto label_1;
            label_12:
            val_5 = val_6;
            if((val_6 & 1) != 0)
            {
                    val_5 = val_6;
            }
            
            if((System.Type.op_Equality(left:  generic, right:  val_5)) == true)
            {
                goto label_6;
            }
            
            val_6 = val_6;
            label_1:
            if((System.Type.op_Inequality(left:  val_6, right:  0)) == false)
            {
                goto label_9;
            }
            
            val_5 = null;
            if((System.Type.op_Inequality(left:  val_6, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_5}))) == true)
            {
                goto label_12;
            }
            
            label_9:
            val_7 = 0;
            return (bool)val_7;
            label_6:
            val_7 = 1;
            return (bool)val_7;
        }
    
    }

}
