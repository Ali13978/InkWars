using UnityEngine;

namespace DataStructs
{
    public class Items : FirebaseDictionalizer
    {
        // Fields
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt pearls;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt shells;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt mussels;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt stunnerBall;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt ironBall;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt colorEraserBall;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool noAds;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool starterBundle;
        private System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> battleEnhancerCount;
        private System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> bpAmplifierCount;
        private System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool> characterUnlocked;
        private System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool> musicUnlocked;
        private System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool> stageUnlocked;
        private System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool> avatarUnlocked;
        private System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool> titleUnlocked;
        private System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool> battleGridUnlocked;
        private System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool> switcherUnlocked;
        private System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool> bubbleUnlocked;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt vipLevel;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString vipExpireTimeUTC;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString vipStartTimeUTC;
        
        // Properties
        public override string keyName { get; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Pearls { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Shells { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Mussels { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt StunnerBall { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt IronBall { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt ColorEraserBall { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool NoAds { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool StarterBundle { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt VipLevel { get; set; }
        public System.DateTime VipExpireTimeUTC { get; set; }
        public System.DateTime VipStartTimeUTC { get; set; }
        
        // Methods
        public override string get_keyName()
        {
            return "items";
        }
        public Items()
        {
            val_1 = new System.Object();
            mem[1152921529199540864] = 0;
            mem[1152921529199540872] = 0;
        }
        protected override void CustomInitAfterLoadDefaults()
        {
            var val_8;
            var val_9;
            System.Predicate<CharacterData> val_11;
            val_8 = this;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  232);
            this.pearls = val_1;
            mem[1152921529199666200] = val_1.fakeValue;
            mem[1152921529199666204] = val_1.inited;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  8);
            this.mussels = val_2;
            mem[1152921529199666232] = val_2.fakeValue;
            mem[1152921529199666236] = val_2.inited;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  80);
            this.shells = val_3;
            mem[1152921529199666216] = val_3.fakeValue;
            mem[1152921529199666220] = val_3.inited;
            AvatarTitleUnlockChecker.SetDefaultUnlocks();
            val_9 = null;
            val_9 = null;
            val_11 = Items.<>c.<>9__24_0;
            if(val_11 == null)
            {
                    System.Predicate<CharacterData> val_4 = null;
                val_11 = val_4;
                val_4 = new System.Predicate<CharacterData>(object:  Items.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Items.<>c::<CustomInitAfterLoadDefaults>b__24_0(CharacterData x));
                Items.<>c.<>9__24_0 = val_11;
            }
            
            List.Enumerator<T> val_6 = CharacterDataManager.FindAll(match:  val_4).GetEnumerator();
            label_13:
            if(((-1176996664) & 1) == 0)
            {
                goto label_11;
            }
            
            System.Type val_7 = 0.InitialType;
            this.SetCharacterUnlock(id:  public CharacterData List.Enumerator<CharacterData>::get_Current(), unlocked:  true, displayAvatarUnlockPopup:  false);
            goto label_13;
            label_11:
            0.Add(driver:  public System.Void List.Enumerator<CharacterData>::Dispose(), rectTransform:  System.Boolean Items.<>c::<CustomInitAfterLoadDefaults>b__24_0(CharacterData x), drivenProperties:  public System.Void System.Predicate<CharacterData>::.ctor(object object, IntPtr method));
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Pearls()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.pearls, hiddenValue = this.pearls, inited = false};
        }
        public void set_Pearls(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Max(a:  0, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = value.currentCryptoKey, hiddenValue = value.hiddenValue, fakeValue = value.fakeValue, inited = value.inited})));
            this.pearls = val_3;
            mem[1152921529199907688] = val_3.fakeValue;
            mem[1152921529199907692] = val_3.inited;
            this.SaveVariableImmediately(name:  "pearls", obj:  val_3);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Shells()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.shells, hiddenValue = this.shells, inited = false};
        }
        public void set_Shells(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Max(a:  0, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = value.currentCryptoKey, hiddenValue = value.hiddenValue, fakeValue = value.fakeValue, inited = value.inited})));
            this.shells = val_3;
            mem[1152921529200142024] = val_3.fakeValue;
            mem[1152921529200142028] = val_3.inited;
            this.SaveVariableImmediately(name:  "shells", obj:  val_3);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_Mussels()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.mussels, hiddenValue = this.mussels, inited = false};
        }
        public void set_Mussels(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.mussels = value;
            mem[1152921529200376376] = value.fakeValue;
            mem[1152921529200376380] = value.inited;
            this.SaveVariable(name:  "mussels", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_StunnerBall()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.stunnerBall, hiddenValue = this.stunnerBall, inited = false};
        }
        public void set_StunnerBall(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.stunnerBall = value;
            mem[1152921529200610728] = value.fakeValue;
            mem[1152921529200610732] = value.inited;
            this.SaveVariableImmediately(name:  "stunnerBall", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_IronBall()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.ironBall, hiddenValue = this.ironBall, inited = false};
        }
        public void set_IronBall(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.ironBall = value;
            mem[1152921529200845080] = value.fakeValue;
            mem[1152921529200845084] = value.inited;
            this.SaveVariableImmediately(name:  "ironBall", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_ColorEraserBall()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.colorEraserBall, hiddenValue = this.colorEraserBall, inited = false};
        }
        public void set_ColorEraserBall(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.colorEraserBall = value;
            mem[1152921529201079448] = value.fakeValue;
            mem[1152921529201079452] = value.inited;
            this.SaveVariableImmediately(name:  "colorEraserBall", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool get_NoAds()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = this.noAds, hiddenValue = this.noAds, fakeValue = false, fakeValueChanged = false, inited = false};
        }
        public void set_NoAds(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value)
        {
            this.noAds = value;
            mem[1152921529201313784] = value.fakeValue;
            mem[1152921529201313785] = value.fakeValueChanged;
            mem[1152921529201313786] = value.inited;
            this.SaveVariableImmediately(name:  "noAds", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool get_StarterBundle()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = this.starterBundle, hiddenValue = this.starterBundle, fakeValue = false, fakeValueChanged = false, inited = false};
        }
        public void set_StarterBundle(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value)
        {
            this.starterBundle = value;
            mem[1152921529201548132] = value.fakeValue;
            mem[1152921529201548133] = value.fakeValueChanged;
            mem[1152921529201548134] = value.inited;
            this.SaveVariable(name:  "starterBundle", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_VipLevel()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.vipLevel, hiddenValue = this.vipLevel, inited = false};
        }
        protected void set_VipLevel(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.vipLevel = value;
            mem[1152921529201782560] = value.fakeValue;
            mem[1152921529201782564] = value.inited;
            this.SaveVariableImmediately(name:  "vipLevel", obj:  value);
        }
        public System.DateTime get_VipExpireTimeUTC()
        {
            null = null;
            bool val_2 = System.DateTime.TryParse(s:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  this.vipExpireTimeUTC), result: out  new System.DateTime() {dateData = System.DateTime.MinValue});
            return (System.DateTime)System.DateTime.MinValue;
        }
        public void set_VipExpireTimeUTC(System.DateTime value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredString val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  value.dateData);
            this.vipExpireTimeUTC = val_1;
            this.SaveVariableImmediately(name:  "vipExpireTimeUTC", obj:  val_1);
        }
        public System.DateTime get_VipStartTimeUTC()
        {
            null = null;
            bool val_2 = System.DateTime.TryParse(s:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  this.vipStartTimeUTC), result: out  new System.DateTime() {dateData = System.DateTime.MaxValue});
            return (System.DateTime)System.DateTime.MaxValue;
        }
        protected void set_VipStartTimeUTC(System.DateTime value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredString val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  value.dateData);
            this.vipStartTimeUTC = val_1;
            this.SaveVariableImmediately(name:  "vipStartTimeUTC", obj:  val_1);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetBattleEnhancerCount(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt defaultValue)
        {
            bool val_1 = this.battleEnhancerCount.TryGetValue(key:  key, value: out  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = defaultValue.currentCryptoKey, hiddenValue = defaultValue.hiddenValue, fakeValue = defaultValue.fakeValue, inited = defaultValue.inited});
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = defaultValue.currentCryptoKey, hiddenValue = defaultValue.hiddenValue, fakeValue = defaultValue.fakeValue, inited = defaultValue.inited};
        }
        public void SetBattleEnhancerCount(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt aNewValue)
        {
            System.Collections.Generic.Dictionary<System.String, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> val_5;
            string val_6;
            if((System.String.IsNullOrEmpty(value:  key)) == true)
            {
                    return;
            }
            
            int val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = aNewValue.fakeValue, inited = aNewValue.inited});
            bool val_3 = this.battleEnhancerCount.ContainsKey(key:  key);
            val_5 = this.battleEnhancerCount;
            if(val_5 == null)
            {
                goto label_6;
            }
            
            if(val_3 == false)
            {
                goto label_7;
            }
            
            label_9:
            val_6 = key;
            val_5.set_Item(key:  val_6, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = aNewValue.fakeValue, inited = aNewValue.inited});
            goto label_8;
            label_6:
            if(val_3 == true)
            {
                goto label_9;
            }
            
            label_7:
            val_6 = key;
            val_5.Add(key:  val_6, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = aNewValue.fakeValue, inited = aNewValue.inited});
            label_8:
            this.SaveVariableImmediately(name:  "battleEnhancerCount." + key, obj:  aNewValue);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetBpAmplifierCount(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt defaultValue)
        {
            bool val_1 = this.bpAmplifierCount.TryGetValue(key:  key, value: out  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = defaultValue.currentCryptoKey, hiddenValue = defaultValue.hiddenValue, fakeValue = defaultValue.fakeValue, inited = defaultValue.inited});
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = defaultValue.currentCryptoKey, hiddenValue = defaultValue.hiddenValue, fakeValue = defaultValue.fakeValue, inited = defaultValue.inited};
        }
        public void SetBpAmplifierCount(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt aNewValue)
        {
            System.Collections.Generic.Dictionary<System.String, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> val_5;
            string val_6;
            if((System.String.IsNullOrEmpty(value:  key)) == true)
            {
                    return;
            }
            
            int val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = aNewValue.fakeValue, inited = aNewValue.inited});
            bool val_3 = this.bpAmplifierCount.ContainsKey(key:  key);
            val_5 = this.bpAmplifierCount;
            if(val_5 == null)
            {
                goto label_6;
            }
            
            if(val_3 == false)
            {
                goto label_7;
            }
            
            label_9:
            val_6 = key;
            val_5.set_Item(key:  val_6, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = aNewValue.fakeValue, inited = aNewValue.inited});
            goto label_8;
            label_6:
            if(val_3 == true)
            {
                goto label_9;
            }
            
            label_7:
            val_6 = key;
            val_5.Add(key:  val_6, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = aNewValue.fakeValue, inited = aNewValue.inited});
            label_8:
            this.SaveVariableImmediately(name:  "bpAmplifierCount." + key, obj:  aNewValue);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool GetCharacterUnlocked(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool defaultValue)
        {
            bool val_1 = this.characterUnlocked.TryGetValue(key:  key, value: out  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited});
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, hiddenValue = defaultValue.hiddenValue, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited};
        }
        public void SetCharacterUnlocked(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool aNewValue)
        {
            bool val_6;
            string val_7;
            if((System.String.IsNullOrEmpty(value:  key)) == true)
            {
                    return;
            }
            
            val_6 = aNewValue.fakeValue & 4294967295;
            bool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            bool val_3 = this.characterUnlocked.ContainsKey(key:  key);
            if(this.characterUnlocked == null)
            {
                goto label_6;
            }
            
            if(val_3 == false)
            {
                goto label_7;
            }
            
            label_9:
            val_7 = key;
            this.characterUnlocked.set_Item(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            goto label_8;
            label_6:
            if(val_3 == true)
            {
                goto label_9;
            }
            
            label_7:
            val_7 = key;
            this.characterUnlocked.Add(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            label_8:
            this.SaveVariableImmediately(name:  "characterUnlocked." + key, obj:  aNewValue);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool GetMusicUnlocked(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool defaultValue)
        {
            bool val_1 = this.musicUnlocked.TryGetValue(key:  key, value: out  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited});
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, hiddenValue = defaultValue.hiddenValue, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited};
        }
        public void SetMusicUnlocked(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool aNewValue)
        {
            bool val_6;
            string val_7;
            if((System.String.IsNullOrEmpty(value:  key)) == true)
            {
                    return;
            }
            
            val_6 = aNewValue.fakeValue & 4294967295;
            bool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            bool val_3 = this.musicUnlocked.ContainsKey(key:  key);
            if(this.musicUnlocked == null)
            {
                goto label_6;
            }
            
            if(val_3 == false)
            {
                goto label_7;
            }
            
            label_9:
            val_7 = key;
            this.musicUnlocked.set_Item(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            goto label_8;
            label_6:
            if(val_3 == true)
            {
                goto label_9;
            }
            
            label_7:
            val_7 = key;
            this.musicUnlocked.Add(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            label_8:
            this.SaveVariableImmediately(name:  "musicUnlocked." + key, obj:  aNewValue);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool GetStageUnlocked(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool defaultValue)
        {
            bool val_1 = this.stageUnlocked.TryGetValue(key:  key, value: out  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited});
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, hiddenValue = defaultValue.hiddenValue, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited};
        }
        public void SetStageUnlocked(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool aNewValue)
        {
            bool val_6;
            string val_7;
            if((System.String.IsNullOrEmpty(value:  key)) == true)
            {
                    return;
            }
            
            val_6 = aNewValue.fakeValue & 4294967295;
            bool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            bool val_3 = this.stageUnlocked.ContainsKey(key:  key);
            if(this.stageUnlocked == null)
            {
                goto label_6;
            }
            
            if(val_3 == false)
            {
                goto label_7;
            }
            
            label_9:
            val_7 = key;
            this.stageUnlocked.set_Item(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            goto label_8;
            label_6:
            if(val_3 == true)
            {
                goto label_9;
            }
            
            label_7:
            val_7 = key;
            this.stageUnlocked.Add(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            label_8:
            this.SaveVariableImmediately(name:  "stageUnlocked." + key, obj:  aNewValue);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool GetAvatarUnlocked(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool defaultValue)
        {
            bool val_1 = this.avatarUnlocked.TryGetValue(key:  key, value: out  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited});
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, hiddenValue = defaultValue.hiddenValue, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited};
        }
        public void SetAvatarUnlocked(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool aNewValue)
        {
            bool val_6;
            string val_7;
            if((System.String.IsNullOrEmpty(value:  key)) == true)
            {
                    return;
            }
            
            val_6 = aNewValue.fakeValue & 4294967295;
            bool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            bool val_3 = this.avatarUnlocked.ContainsKey(key:  key);
            if(this.avatarUnlocked == null)
            {
                goto label_6;
            }
            
            if(val_3 == false)
            {
                goto label_7;
            }
            
            label_9:
            val_7 = key;
            this.avatarUnlocked.set_Item(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            goto label_8;
            label_6:
            if(val_3 == true)
            {
                goto label_9;
            }
            
            label_7:
            val_7 = key;
            this.avatarUnlocked.Add(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            label_8:
            this.SaveVariableImmediately(name:  "avatarUnlocked." + key, obj:  aNewValue);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool GetTitleUnlocked(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool defaultValue)
        {
            bool val_1 = this.titleUnlocked.TryGetValue(key:  key, value: out  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited});
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, hiddenValue = defaultValue.hiddenValue, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited};
        }
        public void SetTitleUnlocked(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool aNewValue)
        {
            bool val_6;
            string val_7;
            if((System.String.IsNullOrEmpty(value:  key)) == true)
            {
                    return;
            }
            
            val_6 = aNewValue.fakeValue & 4294967295;
            bool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            bool val_3 = this.titleUnlocked.ContainsKey(key:  key);
            if(this.titleUnlocked == null)
            {
                goto label_6;
            }
            
            if(val_3 == false)
            {
                goto label_7;
            }
            
            label_9:
            val_7 = key;
            this.titleUnlocked.set_Item(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            goto label_8;
            label_6:
            if(val_3 == true)
            {
                goto label_9;
            }
            
            label_7:
            val_7 = key;
            this.titleUnlocked.Add(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            label_8:
            this.SaveVariableImmediately(name:  "titleUnlocked." + key, obj:  aNewValue);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool GetBattleGridUnlocked(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool defaultValue)
        {
            bool val_1 = this.battleGridUnlocked.TryGetValue(key:  key, value: out  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited});
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, hiddenValue = defaultValue.hiddenValue, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited};
        }
        public void SetBattleGridUnlocked(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool aNewValue)
        {
            bool val_6;
            string val_7;
            if((System.String.IsNullOrEmpty(value:  key)) == true)
            {
                    return;
            }
            
            val_6 = aNewValue.fakeValue & 4294967295;
            bool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            bool val_3 = this.battleGridUnlocked.ContainsKey(key:  key);
            if(this.battleGridUnlocked == null)
            {
                goto label_6;
            }
            
            if(val_3 == false)
            {
                goto label_7;
            }
            
            label_9:
            val_7 = key;
            this.battleGridUnlocked.set_Item(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            goto label_8;
            label_6:
            if(val_3 == true)
            {
                goto label_9;
            }
            
            label_7:
            val_7 = key;
            this.battleGridUnlocked.Add(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            label_8:
            this.SaveVariableImmediately(name:  "battleGridUnlocked." + key, obj:  aNewValue);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool GetSwitcherUnlocked(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool defaultValue)
        {
            bool val_1 = this.switcherUnlocked.TryGetValue(key:  key, value: out  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited});
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, hiddenValue = defaultValue.hiddenValue, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited};
        }
        public void SetSwitcherUnlocked(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool aNewValue)
        {
            bool val_6;
            string val_7;
            if((System.String.IsNullOrEmpty(value:  key)) == true)
            {
                    return;
            }
            
            val_6 = aNewValue.fakeValue & 4294967295;
            bool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            bool val_3 = this.switcherUnlocked.ContainsKey(key:  key);
            if(this.switcherUnlocked == null)
            {
                goto label_6;
            }
            
            if(val_3 == false)
            {
                goto label_7;
            }
            
            label_9:
            val_7 = key;
            this.switcherUnlocked.set_Item(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            goto label_8;
            label_6:
            if(val_3 == true)
            {
                goto label_9;
            }
            
            label_7:
            val_7 = key;
            this.switcherUnlocked.Add(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            label_8:
            this.SaveVariableImmediately(name:  "switcherUnlocked." + key, obj:  aNewValue);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool GetBubbleUnlocked(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool defaultValue)
        {
            bool val_1 = this.bubbleUnlocked.TryGetValue(key:  key, value: out  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited});
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, hiddenValue = defaultValue.hiddenValue, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited};
        }
        public void SetBubbleUnlocked(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool aNewValue)
        {
            bool val_6;
            string val_7;
            if((System.String.IsNullOrEmpty(value:  key)) == true)
            {
                    return;
            }
            
            val_6 = aNewValue.fakeValue & 4294967295;
            bool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            bool val_3 = this.bubbleUnlocked.ContainsKey(key:  key);
            if(this.bubbleUnlocked == null)
            {
                goto label_6;
            }
            
            if(val_3 == false)
            {
                goto label_7;
            }
            
            label_9:
            val_7 = key;
            this.bubbleUnlocked.set_Item(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            goto label_8;
            label_6:
            if(val_3 == true)
            {
                goto label_9;
            }
            
            label_7:
            val_7 = key;
            this.bubbleUnlocked.Add(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            label_8:
            this.SaveVariableImmediately(name:  "bubbleUnlocked." + key, obj:  aNewValue);
        }
        public string GenerateEnhancerKey(InkWars.Model.BattleEnhancerType type, int level)
        {
            type.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  level, drivenProperties:  null);
            return (string)type.ToString() + "_lv" + level.ToString();
        }
        public string GenerateTournamentEnhancerKey(string tournamentKey, InkWars.Model.BattleEnhancerType type, int level)
        {
            UnityEngine.RectTransform val_5;
            string[] val_1 = new string[5];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(tournamentKey != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(tournamentKey == null)
            {
                goto label_5;
            }
            
            label_2:
            if(tournamentKey == null)
            {
                    val_5 = 0;
            }
            
            label_5:
            if(val_1.Length == 0)
            {
                    val_5 = 0;
            }
            
            val_1[0] = tournamentKey;
            if("_" == null)
            {
                    val_5 = 0;
            }
            
            if(val_1.Length <= 1)
            {
                    val_5 = 0;
            }
            
            val_1[1] = "_";
            type.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_5, drivenProperties:  level);
            val_1[2] = type.ToString();
            val_1[3] = "_lv";
            val_1[4] = level.ToString();
            return (string)+val_1;
        }
        public int GetEnhancerCount(InkWars.Model.BattleEnhancerType type, int level, int defaultValue = 0)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  defaultValue);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = this.GetBattleEnhancerCount(key:  this.GenerateEnhancerKey(type:  type, level:  level), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited});
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited});
        }
        public int GetTournamentEnhancerCount(string tournamentKey, InkWars.Model.BattleEnhancerType type, int level, int defaultValue = 8)
        {
            bool val_1 = System.String.IsNullOrWhiteSpace(value:  tournamentKey);
            if(val_1 != false)
            {
                    return (int)defaultValue;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  defaultValue);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = this.GetBattleEnhancerCount(key:  val_1.GenerateTournamentEnhancerKey(tournamentKey:  tournamentKey, type:  type, level:  level), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited});
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited});
        }
        public void SetTournamentEnhancerCount(string tournamentKey, InkWars.Model.BattleEnhancerType type, int level, int count)
        {
            bool val_1 = System.String.IsNullOrWhiteSpace(value:  tournamentKey);
            if(val_1 != false)
            {
                    return;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  count);
            this.SetBattleEnhancerCount(key:  val_1.GenerateTournamentEnhancerKey(tournamentKey:  tournamentKey, type:  type, level:  level), aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited});
        }
        public void SetEnhancerCount(InkWars.Model.BattleEnhancerType type, int level, int count)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  count);
            this.SetBattleEnhancerCount(key:  this.GenerateEnhancerKey(type:  type, level:  level), aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited});
        }
        public void AddEnhancerCount(InkWars.Model.BattleEnhancerType type, int level, int count)
        {
            this.SetEnhancerCount(type:  type, level:  level, count:  (this.GetEnhancerCount(type:  type, level:  level, defaultValue:  0)) + count);
        }
        public string GenerateAmplifierKey(InkWars.Model.BPAmplifierType type, int level)
        {
            type.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  level, drivenProperties:  null);
            return (string)type.ToString() + "_" + level.ToString();
        }
        private BPAmplifierItem GetAmpliferFromKey(string key)
        {
            char[] val_2 = new char[1];
            val_2[0] = '_';
            System.String[] val_3 = key.Split(separator:  val_2);
            object val_5 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_3[0]);
            .amplifierType = null;
            .precentage = System.Int32.Parse(s:  val_3[1]);
            return (BPAmplifierItem)new BPAmplifierItem();
        }
        public int GetAmplifierCount(InkWars.Model.BPAmplifierType type, int level, int defaultValue = 0)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  defaultValue);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = this.GetBpAmplifierCount(key:  this.GenerateAmplifierKey(type:  type, level:  level), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited});
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited});
        }
        public void SetAmplifierCount(InkWars.Model.BPAmplifierType type, int level, int count)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  count);
            this.SetBpAmplifierCount(key:  this.GenerateAmplifierKey(type:  type, level:  level), aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited});
        }
        public void AddAmplifier(InkWars.Model.BPAmplifierType type, int level)
        {
            this.SetAmplifierCount(type:  type, level:  level, count:  (this.GetAmplifierCount(type:  type, level:  level, defaultValue:  0)) + 1);
        }
        public void RemoveAmplifier(InkWars.Model.BPAmplifierType type, int level)
        {
            this.SetAmplifierCount(type:  type, level:  level, count:  UnityEngine.Mathf.Max(a:  0, b:  (this.GetAmplifierCount(type:  type, level:  level, defaultValue:  0)) - 1));
        }
        public BPAmplifierList GetAmplifierList()
        {
            var val_5;
            var val_10;
            int val_11;
            int val_12;
            BPAmplifierList val_1 = new BPAmplifierList();
            val_10 = this.bpAmplifierCount.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = val_10.GetEnumerator();
            goto label_8;
            label_13:
            System.Type val_6 = val_5.InitialType;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = this.bpAmplifierCount.Item[val_6];
            val_11 = val_7.fakeValue;
            val_12 = 0;
            int val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_11, inited = val_7.inited});
            val_10 = val_8;
            if((val_10 != 0) && (val_10 >= 1))
            {
                    var val_10 = 0;
                do
            {
                if((val_8.GetAmpliferFromKey(key:  val_6)) != null)
            {
                    val_11 = val_9.amplifierType;
            }
            else
            {
                    val_11 = val_9.amplifierType;
            }
            
                val_12 = val_9.precentage;
                val_1.AddToList(type:  val_11, precentage:  val_12);
                val_10 = val_10 + 1;
            }
            while(val_10 < val_10);
            
            }
            
            label_8:
            if(((-1169526352) & 1) != 0)
            {
                goto label_13;
            }
            
            val_5.Add(driver:  public System.Void Dictionary.KeyCollection.Enumerator<System.String, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>::Dispose(), rectTransform:  val_12, drivenProperties:  0);
            return val_1;
        }
        protected string GetAvatarUnlockKey(Avatars_Common_Key key)
        {
            key.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            return (string)key.ToString();
        }
        protected string GetAvatarUnlockKey(Avatars_Specific_Key key, CharacterNameID characterId)
        {
            characterId.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  characterId, drivenProperties:  null);
            key.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  characterId, drivenProperties:  null);
            return (string)characterId.ToString() + "_" + key.ToString();
        }
        public bool GetAvatarUnlocked(Avatars_Common_Key key)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_4 = this.GetAvatarUnlocked(key:  this.GetAvatarUnlockKey(key:  key), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
            val_4.fakeValue = val_4.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, fakeValueChanged = val_4.fakeValue, inited = val_4.fakeValue});
        }
        public bool GetAvatarUnlocked(Avatars_Specific_Key key, CharacterNameID characterId)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_4 = this.GetAvatarUnlocked(key:  this.GetAvatarUnlockKey(key:  key, characterId:  characterId), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
            val_4.fakeValue = val_4.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, fakeValueChanged = val_4.fakeValue, inited = val_4.fakeValue});
        }
        public void SetAvatarUnlocked(Avatars_Common_Key key, bool isUnlock)
        {
            var val_7;
            bool val_1 = this.GetAvatarUnlocked(key:  key);
            if(val_1 ^ isUnlock == false)
            {
                    return;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  isUnlock);
            this.SetAvatarUnlocked(key:  val_1.GetAvatarUnlockKey(key:  key), aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue & 4294967295, fakeValueChanged = val_5.fakeValue & 4294967295, inited = val_5.fakeValue & 4294967295});
            if(isUnlock == false)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            NewUnlocks.NewUnlocksThisCheck.Add(key:  key);
        }
        public void SetAvatarUnlocked(Avatars_Specific_Key key, CharacterNameID characterId, bool isUnlock)
        {
            var val_7;
            bool val_1 = this.GetAvatarUnlocked(key:  key, characterId:  characterId);
            if(val_1 ^ isUnlock == false)
            {
                    return;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  isUnlock);
            this.SetAvatarUnlocked(key:  val_1.GetAvatarUnlockKey(key:  key, characterId:  characterId), aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue & 4294967295, fakeValueChanged = val_5.fakeValue & 4294967295, inited = val_5.fakeValue & 4294967295});
            if(isUnlock == false)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            NewUnlocks.NewUnlocksThisCheck.Add(key:  key);
        }
        public bool GetAvatarUnlocked(ProfileUnlockables_Avatar avatar)
        {
            var val_4;
            if((avatar & 1) != 0)
            {
                    val_4 = this;
                bool val_1 = this.GetAvatarUnlocked(key:  avatar.CommonKey);
                return (bool)this.GetAvatarUnlocked(key:  avatar.SpecificKey, characterId:  null);
            }
            
            val_4 = this;
            return (bool)this.GetAvatarUnlocked(key:  avatar.SpecificKey, characterId:  null);
        }
        public void SetAvatarUnlocked(ProfileUnlockables_Avatar avatar, bool isUnlock)
        {
            if((avatar & 1) != 0)
            {
                    isUnlock = isUnlock;
                this.SetAvatarUnlocked(key:  avatar.CommonKey, isUnlock:  isUnlock);
                return;
            }
            
            this.SetAvatarUnlocked(key:  avatar.SpecificKey, characterId:  isUnlock, isUnlock:  isUnlock);
        }
        public bool IsAvatarEligibleForPurchase(ProfileUnlockables_Avatar avatar)
        {
            int val_9;
            var val_10;
            Avatars_Specific_Key val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_9 = avatar;
            if((val_9 & 1) == 0)
            {
                goto label_2;
            }
            
            label_30:
            val_10 = 0;
            return (bool)val_10;
            label_2:
            val_11 = avatar.SpecificKey;
            if(val_11 != 8)
            {
                goto label_4;
            }
            
            val_12 = null;
            val_12 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  W21).TotalMatchPlayed;
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited})) > 79)
            {
                goto label_23;
            }
            
            val_11 = avatar.SpecificKey;
            label_4:
            if(val_11 != 7)
            {
                goto label_12;
            }
            
            val_13 = null;
            val_13 = null;
            if((DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  val_2.fakeValue).BPRank) == 7)
            {
                goto label_23;
            }
            
            val_11 = avatar.SpecificKey;
            label_12:
            if(val_11 != 9)
            {
                goto label_18;
            }
            
            val_14 = null;
            val_14 = null;
            if((DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  val_2.fakeValue).BPRank) >= 7)
            {
                goto label_23;
            }
            
            val_11 = avatar.SpecificKey;
            label_18:
            if(val_11 != 10)
            {
                goto label_30;
            }
            
            val_15 = null;
            val_15 = null;
            val_9 = mem[DataStructs.UserDataDictionary.Stats + 48 + 8];
            val_9 = DataStructs.UserDataDictionary.Stats + 48 + 8;
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = val_9, inited = val_9})) < 8888)
            {
                goto label_30;
            }
            
            label_23:
            val_10 = 1;
            return (bool)val_10;
        }
        protected string GetTitleUnlockKey(Titles_Common_Key key)
        {
            key.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            return (string)key.ToString();
        }
        protected string GetTitleUnlockKey(Titles_Specific_Key key, CharacterNameID characterId)
        {
            characterId.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  characterId, drivenProperties:  null);
            key.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  characterId, drivenProperties:  null);
            return (string)characterId.ToString() + "_" + key.ToString();
        }
        public bool GetTitleUnlocked(Titles_Common_Key key)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_4 = this.GetTitleUnlocked(key:  this.GetTitleUnlockKey(key:  key), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
            val_4.fakeValue = val_4.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, fakeValueChanged = val_4.fakeValue, inited = val_4.fakeValue});
        }
        public bool GetTitleUnlocked(Titles_Specific_Key key, CharacterNameID characterId)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_4 = this.GetTitleUnlocked(key:  this.GetTitleUnlockKey(key:  key, characterId:  characterId), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
            val_4.fakeValue = val_4.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, fakeValueChanged = val_4.fakeValue, inited = val_4.fakeValue});
        }
        public void SetTitleUnlocked(Titles_Common_Key key, bool isUnlock)
        {
            var val_7;
            bool val_1 = this.GetTitleUnlocked(key:  key);
            if(val_1 ^ isUnlock == false)
            {
                    return;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  isUnlock);
            this.SetTitleUnlocked(key:  val_1.GetTitleUnlockKey(key:  key), aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue & 4294967295, fakeValueChanged = val_5.fakeValue & 4294967295, inited = val_5.fakeValue & 4294967295});
            if(isUnlock == false)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            NewUnlocks.NewUnlocksThisCheck.Add(key:  key);
        }
        public void SetTitleUnlocked(Titles_Specific_Key key, CharacterNameID characterId, bool isUnlock)
        {
            var val_7;
            bool val_1 = this.GetTitleUnlocked(key:  key, characterId:  characterId);
            if(val_1 ^ isUnlock == false)
            {
                    return;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  isUnlock);
            this.SetTitleUnlocked(key:  val_1.GetTitleUnlockKey(key:  key, characterId:  characterId), aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue & 4294967295, fakeValueChanged = val_5.fakeValue & 4294967295, inited = val_5.fakeValue & 4294967295});
            if(isUnlock == false)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            NewUnlocks.NewUnlocksThisCheck.Add(key:  key);
        }
        public bool GetTitleUnlocked(ProfileUnlockables_Title title)
        {
            var val_4;
            if((title & 1) != 0)
            {
                    val_4 = this;
                bool val_1 = this.GetTitleUnlocked(key:  title.CommonKey);
                return (bool)this.GetTitleUnlocked(key:  title.SpecificKey, characterId:  null);
            }
            
            val_4 = this;
            return (bool)this.GetTitleUnlocked(key:  title.SpecificKey, characterId:  null);
        }
        public void SetTitleUnlocked(ProfileUnlockables_Title title, bool isUnlock)
        {
            if((title & 1) != 0)
            {
                    isUnlock = isUnlock;
                this.SetTitleUnlocked(key:  title.CommonKey, isUnlock:  isUnlock);
                return;
            }
            
            this.SetTitleUnlocked(key:  title.SpecificKey, characterId:  isUnlock, isUnlock:  isUnlock);
        }
        public void SetCharacterUnlock(CharacterNameID id, bool unlocked, bool displayAvatarUnlockPopup = True)
        {
            CharacterNameID val_11;
            var val_12;
            val_11 = displayAvatarUnlockPopup;
            val_12 = id;
            id.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  unlocked, drivenProperties:  displayAvatarUnlockPopup);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            bool val_3 = val_2.fakeValue & 4294967295;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_4 = this.GetCharacterUnlocked(key:  id.ToString(), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_3, fakeValueChanged = val_3, inited = val_3});
            val_4.fakeValue = val_4.fakeValue & 4294967295;
            if(((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, fakeValueChanged = val_4.fakeValue, inited = val_4.fakeValue})) ^ unlocked) == false)
            {
                    return;
            }
            
            val_12 = null;
            null.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  val_3);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  unlocked);
            this.SetCharacterUnlocked(key:  null.ToString(), aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_9.currentCryptoKey, hiddenValue = val_9.hiddenValue, fakeValue = val_9.fakeValue & 4294967295, fakeValueChanged = val_9.fakeValue & 4294967295, inited = val_9.fakeValue & 4294967295});
            if(unlocked == false)
            {
                    return;
            }
            
            AvatarTitleUnlockChecker.UnlockCharacterDefaults(charID:  null);
            if(val_11 == false)
            {
                    return;
            }
            
            val_11 = null;
            UnlockableCollection.Setup(charID:  val_11);
        }
        public bool IsCharacterLocked(CharacterNameID id)
        {
            var val_11;
            var val_12;
            if((VIP.IsCharacterUnlockedByVip(cid:  id)) == false)
            {
                goto label_3;
            }
            
            label_13:
            val_12 = 0;
            goto label_4;
            label_3:
            if(0 == (CharacterDataManager.Get(id:  id)))
            {
                goto label_9;
            }
            
            CharacterData val_4 = CharacterDataManager.Get(id:  id);
            if(val_4.unlockType == 1)
            {
                goto label_13;
            }
            
            label_9:
            val_11 = id;
            id.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_8 = this.GetCharacterUnlocked(key:  id.ToString(), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue & 4294967295, fakeValueChanged = val_6.fakeValue & 4294967295, inited = val_6.fakeValue & 4294967295});
            val_8.fakeValue = val_8.fakeValue & 4294967295;
            bool val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_8.currentCryptoKey, hiddenValue = val_8.hiddenValue, fakeValue = val_8.fakeValue, fakeValueChanged = val_8.fakeValue, inited = val_8.fakeValue});
            val_12 = val_9 ^ 1;
            label_4:
            val_9 = val_12;
            return (bool)val_9;
        }
        private string GetBattleGridKey(int id)
        {
            return (string)"BattleGrid" + id.ToString();
        }
        public bool GetBattleGridUnlocked(int id, bool includeVipUnlock = True)
        {
            bool val_1 = VIP.IsBattleGridUnlockedByVip(gridId:  id);
            if((val_1 != false) && (includeVipUnlock != false))
            {
                    return true;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_5 = this.GetBattleGridUnlocked(key:  val_1.GetBattleGridKey(id:  id), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue & 4294967295, fakeValueChanged = val_3.fakeValue & 4294967295, inited = val_3.fakeValue & 4294967295});
            val_5.fakeValue = val_5.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, fakeValueChanged = val_5.fakeValue, inited = val_5.fakeValue});
        }
        public void SetBattleGridUnlocked(int id, bool unlocked)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  unlocked);
            this.SetBattleGridUnlocked(key:  this.GetBattleGridKey(id:  id), aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue & 4294967295, fakeValueChanged = val_3.fakeValue & 4294967295, inited = val_3.fakeValue & 4294967295});
        }
        private string GetSwitcherKey(int id)
        {
            return (string)"Switcher" + id.ToString();
        }
        public bool GetSwitcherUnlocked(int id, bool includeVipUnlock = True)
        {
            bool val_1 = VIP.IsSwitcherUnlockedByVip(switcherId:  id);
            if((val_1 != false) && (includeVipUnlock != false))
            {
                    return true;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_5 = this.GetSwitcherUnlocked(key:  val_1.GetSwitcherKey(id:  id), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue & 4294967295, fakeValueChanged = val_3.fakeValue & 4294967295, inited = val_3.fakeValue & 4294967295});
            val_5.fakeValue = val_5.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, fakeValueChanged = val_5.fakeValue, inited = val_5.fakeValue});
        }
        public void SetSwitcherUnlocked(int id, bool unlocked)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  unlocked);
            this.SetSwitcherUnlocked(key:  this.GetSwitcherKey(id:  id), aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue & 4294967295, fakeValueChanged = val_3.fakeValue & 4294967295, inited = val_3.fakeValue & 4294967295});
        }
        public bool GetBubbleUnlocked(InkWars.Model.BubbleFamily id, bool includeVipUnlock = True)
        {
            InkWars.Model.BubbleFamily val_8;
            var val_9;
            val_8 = id;
            if(((VIP.IsBubbleSetUnlockedByVip(bubbleId:  val_8)) != false) && (includeVipUnlock != false))
            {
                    val_9 = 1;
                return (bool)CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, fakeValueChanged = val_5.fakeValue, inited = val_5.fakeValue});
            }
            
            val_8 = val_8;
            val_8.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  includeVipUnlock, drivenProperties:  null);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            val_9 = this;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_5 = this.GetBubbleUnlocked(key:  val_8.ToString(), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue & 4294967295, fakeValueChanged = val_3.fakeValue & 4294967295, inited = val_3.fakeValue & 4294967295});
            val_5.fakeValue = val_5.fakeValue & 4294967295;
            return (bool)CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, fakeValueChanged = val_5.fakeValue, inited = val_5.fakeValue});
        }
        public void SetBubbleUnlocked(InkWars.Model.BubbleFamily id, bool unlocked)
        {
            id.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  unlocked, drivenProperties:  null);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  unlocked);
            this.SetBubbleUnlocked(key:  id.ToString(), aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue & 4294967295, fakeValueChanged = val_3.fakeValue & 4294967295, inited = val_3.fakeValue & 4294967295});
        }
        public void TrySetToDefaultBattleGrid()
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            if((this.GetBattleGridUnlocked(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Settings + 208 + 8, inited = DataStructs.UserDataDictionary.Settings + 208 + 8}), includeVipUnlock:  true)) != false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            DataStructs.UserDataDictionary.Settings.SelectedBattleGrid = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
        }
        public void TrySetToDefaultBattleBubble()
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            if((this.GetBubbleUnlocked(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Settings + 240 + 8, inited = DataStructs.UserDataDictionary.Settings + 240 + 8}), includeVipUnlock:  true)) != false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            DataStructs.UserDataDictionary.Settings.SelectedBubble = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
        }
        public void TrySetToDefaultSwitcher()
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            if((this.GetSwitcherUnlocked(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Settings + 224 + 8, inited = DataStructs.UserDataDictionary.Settings + 224 + 8}), includeVipUnlock:  true)) != false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            DataStructs.UserDataDictionary.Settings.SelectedSwitcher = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
        }
        public bool IsMusicUnlocked(int id)
        {
            var val_8;
            var val_9;
            val_8 = null;
            val_8 = null;
            if((GameInfo.music.IsDefaultId(id:  id)) != false)
            {
                    val_9 = 1;
                return (bool)CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, fakeValueChanged = val_5.fakeValue, inited = val_5.fakeValue});
            }
            
            id.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  public System.Boolean GameItemInfo<MusicData, UnityEngine.AudioClip>::IsDefaultId(int id), drivenProperties:  null);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            val_9 = this;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_5 = this.GetMusicUnlocked(key:  id.ToString(), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue & 4294967295, fakeValueChanged = val_3.fakeValue & 4294967295, inited = val_3.fakeValue & 4294967295});
            val_5.fakeValue = val_5.fakeValue & 4294967295;
            return (bool)CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, fakeValueChanged = val_5.fakeValue, inited = val_5.fakeValue});
        }
        public void SetMusicUnlock(int id, bool unlock)
        {
            id.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  unlock, drivenProperties:  null);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  unlock);
            this.SetMusicUnlocked(key:  id.ToString(), aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue & 4294967295, fakeValueChanged = val_3.fakeValue & 4294967295, inited = val_3.fakeValue & 4294967295});
        }
        public bool IsStageUnlock(int id)
        {
            var val_8;
            var val_9;
            val_8 = null;
            val_8 = null;
            if((GameInfo.stage.IsDefaultId(id:  id)) != false)
            {
                    val_9 = 1;
                return (bool)CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, fakeValueChanged = val_5.fakeValue, inited = val_5.fakeValue});
            }
            
            id.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  public System.Boolean GameItemInfo<StageData, UnityEngine.Sprite>::IsDefaultId(int id), drivenProperties:  null);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            val_9 = this;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_5 = this.GetStageUnlocked(key:  id.ToString(), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue & 4294967295, fakeValueChanged = val_3.fakeValue & 4294967295, inited = val_3.fakeValue & 4294967295});
            val_5.fakeValue = val_5.fakeValue & 4294967295;
            return (bool)CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, fakeValueChanged = val_5.fakeValue, inited = val_5.fakeValue});
        }
        public void SetStageUnlock(int id, bool unlock)
        {
            id.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  unlock, drivenProperties:  null);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  unlock);
            this.SetStageUnlocked(key:  id.ToString(), aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue & 4294967295, fakeValueChanged = val_3.fakeValue & 4294967295, inited = val_3.fakeValue & 4294967295});
        }
        public void AddSpecialBallCountById(string id, int addition)
        {
            if((System.String.op_Equality(a:  id, b:  "Color_Eraser_Ball_Count")) != false)
            {
                    int val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.colorEraserBall, hiddenValue = this.colorEraserBall, fakeValue = id, inited = id});
                val_2 = val_2 + addition;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_2);
                this.ColorEraserBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
                return;
            }
            
            if((System.String.op_Equality(a:  id, b:  "Iron_Ball_Count")) != false)
            {
                    int val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.ironBall, hiddenValue = this.ironBall, fakeValue = id, inited = id});
                val_5 = val_5 + addition;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_5);
                this.IronBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited};
                return;
            }
            
            if((System.String.op_Equality(a:  id, b:  "Stunner_Ball_Count")) == false)
            {
                    return;
            }
            
            int val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.stunnerBall, hiddenValue = this.stunnerBall, fakeValue = id, inited = id});
            val_8 = val_8 + addition;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_8);
            this.StunnerBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_9.currentCryptoKey, hiddenValue = val_9.hiddenValue, fakeValue = val_9.fakeValue, inited = val_9.inited};
        }
        public int GetSpecialBallCountById(string id)
        {
            var val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5;
            if((System.String.op_Equality(a:  id, b:  "Color_Eraser_Ball_Count")) != false)
            {
                    val_4 = 1152921505062117376;
                val_5 = this.colorEraserBall;
                return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5, hiddenValue = val_5, fakeValue = -1164656336, inited = true});
            }
            
            if((System.String.op_Equality(a:  id, b:  "Iron_Ball_Count")) != false)
            {
                    val_4 = 1152921505062117376;
                val_5 = this.ironBall;
                return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5, hiddenValue = val_5, fakeValue = -1164656336, inited = true});
            }
            
            if((System.String.op_Equality(a:  id, b:  "Stunner_Ball_Count")) == false)
            {
                    return 0;
            }
            
            val_4 = 1152921505062117376;
            val_5 = this.stunnerBall;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5, hiddenValue = val_5, fakeValue = -1164656336, inited = true});
        }
        public void PurchaseVip(int level, int durationInDays)
        {
            if(VIP.isVipActived != false)
            {
                    if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.vipLevel, hiddenValue = this.vipLevel, fakeValue = 53678080, inited = false})) > level)
            {
                    return;
            }
            
            }
            
            VIP.shouldShowVIPExpiredNotice = true;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  level);
            this.VipLevel = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
            if(VIP.isVipActived != false)
            {
                    System.DateTime val_5 = this.VipExpireTimeUTC;
            }
            else
            {
                    System.DateTime val_6 = NFServerTime.GetUTC();
            }
            
            System.DateTime val_7 = val_6.dateData.AddDays(value:  (double)durationInDays);
            this.VipExpireTimeUTC = new System.DateTime() {dateData = val_7.dateData};
            System.DateTime val_8 = NFServerTime.GetUTC();
            this.VipStartTimeUTC = new System.DateTime() {dateData = val_8.dateData};
        }
    
    }

}
