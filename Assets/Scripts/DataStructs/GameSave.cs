using UnityEngine;

namespace DataStructs
{
    public class GameSave : FirebaseDictionalizer
    {
        // Fields
        private DataStructs.Dictionalizer.AdventureProgressDictionary adventureProgress;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString musselLastRechargeTime;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString lastDailyRewardTime;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString signUpDate;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt lastRateUpDaySinceSignUp;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString lastOnlineTime;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString lastInGameTime;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt consecutiveDaysPlayed;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt dailyRewardCounter;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString lastPlayedCharacter;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt quitLoss_BattleP;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt quitLoss_PlayerP;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString bpAmplifierExpiryTime;
        private System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> achievementProgress;
        private System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool> gameSaveFlags;
        
        // Properties
        public override string keyName { get; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString MusselLastRechargeTime { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString LastDailyRewardTime { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString SignUpDate { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt LastRateUpDaySinceSignUp { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString LastOnlineTime { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString LastInGameTime { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt ConsecutiveDaysPlayed { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt DailyRewardCounter { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString LastPlayedCharacter { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt QuitLoss_BattleP { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt QuitLoss_PlayerP { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString BpAmplifierExpiryTime { get; set; }
        public CharacterNameID LastPlayedPVPCharacter { get; set; }
        public System.DateTime BPAmplifierExpireDate { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt LastInGameDaySinceSignUp { get; }
        public bool IsRateUsShown { get; set; }
        public bool IsRateUsClicked { get; set; }
        public bool IsDemoPlayed { get; set; }
        public bool EnhancerInfoPlayed { get; set; }
        public bool AdvancedTutorialPlayed { get; set; }
        public bool PVPTutorialPlayed { get; set; }
        public bool IsMainInteractiveTutorialPlayed { get; set; }
        public bool IsTutorialPlayedForFirstTime { get; set; }
        public bool IsTutorialZeroPlayed { get; set; }
        public bool IsTutorialOnePlayed { get; set; }
        public bool IsTutorialTwoPlayed { get; set; }
        public bool IsTutorialThreePlayed { get; set; }
        public bool IsTutorialFourPlayed { get; set; }
        public bool IsTutorialFivePlayed { get; set; }
        public bool IsTutorialSixPlayed { get; set; }
        public bool IsTutorialSevenPlayed { get; set; }
        public bool IsTutorialEightPlayed { get; set; }
        public bool IsStatsInstructionDisplayed { get; set; }
        public bool isTakoStoryStartPlayed { get; set; }
        public bool isIkaStoryStartPlayed { get; set; }
        public bool isInkUpInteractiveTutorialPlayed { get; set; }
        public bool IsSorryPlayed { get; set; }
        public bool IsCharacterUnlockedFirstTime { get; set; }
        public bool playCharacterRollAnim { get; set; }
        
        // Methods
        public override string get_keyName()
        {
            return "gamesave";
        }
        public GameSave()
        {
            val_1 = new System.Object();
            mem[1152921529182666528] = 0;
            mem[1152921529182666536] = 0;
        }
        public DataStructs.AdventureProgress GetAdventureProgress(CharacterNameID key)
        {
            if(this.adventureProgress != null)
            {
                    return this.adventureProgress.Get(cid:  key);
            }
            
            return this.adventureProgress.Get(cid:  key);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_MusselLastRechargeTime()
        {
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)this.musselLastRechargeTime;
        }
        public void set_MusselLastRechargeTime(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            this.musselLastRechargeTime = value;
            this.SaveVariableImmediately(name:  "musselLastRechargeTime", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_LastDailyRewardTime()
        {
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)this.lastDailyRewardTime;
        }
        public void set_LastDailyRewardTime(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            this.lastDailyRewardTime = value;
            this.SaveVariableImmediately(name:  "lastDailyRewardTime", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_SignUpDate()
        {
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)this.signUpDate;
        }
        public void set_SignUpDate(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            this.signUpDate = value;
            this.SaveVariable(name:  "signUpDate", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_LastRateUpDaySinceSignUp()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.lastRateUpDaySinceSignUp, hiddenValue = this.lastRateUpDaySinceSignUp, inited = false};
        }
        public void set_LastRateUpDaySinceSignUp(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.lastRateUpDaySinceSignUp = value;
            mem[1152921529183745688] = value.fakeValue;
            mem[1152921529183745692] = value.inited;
            this.SaveVariableImmediately(name:  "lastRateUpDaySinceSignUp", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_LastOnlineTime()
        {
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)this.lastOnlineTime;
        }
        public void set_LastOnlineTime(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            this.lastOnlineTime = value;
            this.SaveVariableImmediately(name:  "lastOnlineTime", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_LastInGameTime()
        {
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)this.lastInGameTime;
        }
        public void set_LastInGameTime(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            this.lastInGameTime = value;
            this.SaveVariableImmediately(name:  "lastInGameTime", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_ConsecutiveDaysPlayed()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.consecutiveDaysPlayed, hiddenValue = this.consecutiveDaysPlayed, inited = false};
        }
        public void set_ConsecutiveDaysPlayed(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.consecutiveDaysPlayed = value;
            mem[1152921529184461032] = value.fakeValue;
            mem[1152921529184461036] = value.inited;
            this.SaveVariableImmediately(name:  "consecutiveDaysPlayed", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_DailyRewardCounter()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.dailyRewardCounter, hiddenValue = this.dailyRewardCounter, inited = false};
        }
        public void set_DailyRewardCounter(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.dailyRewardCounter = value;
            mem[1152921529184695400] = value.fakeValue;
            mem[1152921529184695404] = value.inited;
            this.SaveVariableImmediately(name:  "dailyRewardCounter", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_LastPlayedCharacter()
        {
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)this.lastPlayedCharacter;
        }
        public void set_LastPlayedCharacter(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            this.lastPlayedCharacter = value;
            this.SaveVariable(name:  "lastPlayedCharacter", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_QuitLoss_BattleP()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.quitLoss_BattleP, hiddenValue = this.quitLoss_BattleP, inited = false};
        }
        public void set_QuitLoss_BattleP(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.quitLoss_BattleP = value;
            mem[1152921529185170272] = value.fakeValue;
            mem[1152921529185170276] = value.inited;
            this.SaveVariable(name:  "quitLoss_BattleP", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_QuitLoss_PlayerP()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.quitLoss_PlayerP, hiddenValue = this.quitLoss_PlayerP, inited = false};
        }
        public void set_QuitLoss_PlayerP(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.quitLoss_PlayerP = value;
            mem[1152921529185404640] = value.fakeValue;
            mem[1152921529185404644] = value.inited;
            this.SaveVariable(name:  "quitLoss_PlayerP", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_BpAmplifierExpiryTime()
        {
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)this.bpAmplifierExpiryTime;
        }
        public void set_BpAmplifierExpiryTime(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            this.bpAmplifierExpiryTime = value;
            this.SaveVariable(name:  "bpAmplifierExpiryTime", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetAchievementProgress(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt defaultValue)
        {
            bool val_1 = this.achievementProgress.TryGetValue(key:  key, value: out  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = defaultValue.currentCryptoKey, hiddenValue = defaultValue.hiddenValue, fakeValue = defaultValue.fakeValue, inited = defaultValue.inited});
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = defaultValue.currentCryptoKey, hiddenValue = defaultValue.hiddenValue, fakeValue = defaultValue.fakeValue, inited = defaultValue.inited};
        }
        public void SetAchievementProgress(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt aNewValue)
        {
            System.Collections.Generic.Dictionary<System.String, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> val_5;
            string val_6;
            if((System.String.IsNullOrEmpty(value:  key)) == true)
            {
                    return;
            }
            
            int val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = aNewValue.fakeValue, inited = aNewValue.inited});
            bool val_3 = this.achievementProgress.ContainsKey(key:  key);
            val_5 = this.achievementProgress;
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
            this.SaveVariable(name:  "achievementProgress." + key, obj:  aNewValue);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool GetGameSaveFlags(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool defaultValue)
        {
            bool val_1 = this.gameSaveFlags.TryGetValue(key:  key, value: out  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited});
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = defaultValue.currentCryptoKey, hiddenValue = defaultValue.hiddenValue, fakeValue = defaultValue.fakeValue, fakeValueChanged = defaultValue.fakeValueChanged, inited = defaultValue.inited};
        }
        public void SetGameSaveFlags(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredBool aNewValue)
        {
            bool val_6;
            string val_7;
            if((System.String.IsNullOrEmpty(value:  key)) == true)
            {
                    return;
            }
            
            val_6 = aNewValue.fakeValue & 4294967295;
            bool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            bool val_3 = this.gameSaveFlags.ContainsKey(key:  key);
            if(this.gameSaveFlags == null)
            {
                goto label_6;
            }
            
            if(val_3 == false)
            {
                goto label_7;
            }
            
            label_9:
            val_7 = key;
            this.gameSaveFlags.set_Item(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            goto label_8;
            label_6:
            if(val_3 == true)
            {
                goto label_9;
            }
            
            label_7:
            val_7 = key;
            this.gameSaveFlags.Add(key:  val_7, value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = aNewValue.currentCryptoKey, hiddenValue = aNewValue.hiddenValue, fakeValue = val_6, fakeValueChanged = val_6, inited = val_6});
            label_8:
            this.SaveVariable(name:  "gameSaveFlags." + key, obj:  aNewValue);
        }
        public bool IsAchievementUnlocked(AchievementIds id)
        {
            id.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = this.GetAchievementProgress(key:  id.ToString(), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited});
            return (bool)((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited})) == 100) ? 1 : 0;
        }
        public void SetAchievementProcess(AchievementIds id, int process)
        {
            int val_16;
            int val_17;
            var val_19;
            int val_1 = UnityEngine.Mathf.Clamp(value:  process, min:  0, max:  100);
            id.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  100, drivenProperties:  0);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_1);
            val_16 = val_3.currentCryptoKey;
            this.SetAchievementProgress(key:  id.ToString(), aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_16, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited});
            val_17 = UnityEngine.Social.localUser;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_16 = 1;
            if(val_17.authenticated != false)
            {
                    val_16 = 0;
                UnityEngine.Social.ReportProgress(achievementID:  AchievementInfo.GetSocialAchievementId(aid:  null), progress:  (double)(float)val_1, callback:  0);
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_9 = this.achievementProgress.Values.GetEnumerator();
            val_19 = 0;
            goto label_15;
            label_18:
            UnityEngine.Playables.PlayableHandle val_10 = 0.GetHandle();
            val_17 = val_10.m_Version;
            val_16 = 0;
            label_15:
            if(( & 1) != 0)
            {
                goto label_18;
            }
            
            0.Add(driver:  public System.Void Dictionary.ValueCollection.Enumerator<System.String, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>::Dispose(), rectTransform:  val_16, drivenProperties:  val_3.fakeValue);
            if((((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_10.m_Handle, hiddenValue = val_10.m_Handle, fakeValue = val_17, inited = val_17})) == 100) ? (val_19 + 1) : (val_19)) != ((System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).Length) - 1))
            {
                    return;
            }
        
        }
        public void UnlockAchievement(AchievementIds id)
        {
            this.SetAchievementProcess(id:  id, process:  100);
        }
        public CharacterNameID get_LastPlayedPVPCharacter()
        {
            CharacterNameID val_2 = 999999;
            bool val_3 = System.Enum.TryParse<CharacterNameID>(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  this.lastPlayedCharacter), result: out  val_2);
            return val_2;
        }
        public void set_LastPlayedPVPCharacter(CharacterNameID value)
        {
            value.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            this.LastPlayedCharacter = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  value.ToString());
        }
        public DataStructs.AdventureProgress GetAdventureProgressByID(CharacterNameID cid)
        {
            DataStructs.Dictionalizer.AdventureProgressDictionary val_8;
            string val_9;
            var val_10;
            val_8 = this;
            DataStructs.AdventureProgress val_2 = 0;
            val_9 = cid.ToString();
            cid.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            bool val_3 = this.adventureProgress.TryGetValue(key:  val_9, value: out  val_2);
            val_10 = val_2;
            if(val_10 != 0)
            {
                    return (DataStructs.AdventureProgress)val_10;
            }
            
            System.Type val_4 = this.GetType();
            string val_5 = null.ToString();
            null.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  16, drivenProperties:  typeof(System.Type).__il2cppRuntimeField_3F0);
            object val_6 = 39720456;
            val_6 = new System.Object();
            val_8 = this.adventureProgress;
            null.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  16, drivenProperties:  typeof(System.Type).__il2cppRuntimeField_3F0);
            val_9 = val_6;
            val_8.Add(key:  null.ToString(), value:  val_9);
            val_10 = val_6;
            return (DataStructs.AdventureProgress)val_10;
        }
        public DataStructs.AdventureProgress GetAdventureProgressForCurrentCharacter()
        {
            CharacterNameID val_2;
            CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
            return (DataStructs.AdventureProgress)this.GetAdventureProgressByID(cid:  val_2);
        }
        public System.Collections.Generic.List<DataStructs.AdventureProgress> GetAllAdventureSaves()
        {
            return System.Linq.Enumerable.ToList<DataStructs.AdventureProgress>(source:  this.adventureProgress.Values);
        }
        private string GetCharacterUsedKey(CharacterNameID cid)
        {
            cid.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            return (string)cid.ToString() + "_Used";
        }
        public bool GetCurrentCharacterUsed()
        {
            CharacterNameID val_2;
            CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_6 = this.GetGameSaveFlags(key:  this.GetCharacterUsedKey(cid:  val_2), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue & 4294967295, fakeValueChanged = val_4.fakeValue & 4294967295, inited = val_4.fakeValue & 4294967295});
            val_6.fakeValue = val_6.fakeValue & 4294967295;
            return (bool)CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, fakeValueChanged = val_6.fakeValue, inited = val_6.fakeValue});
        }
        public void SetCurrentCharacterUsed(bool used)
        {
            CharacterNameID val_2;
            CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  used);
            this.SetGameSaveFlags(key:  this.GetCharacterUsedKey(cid:  val_2), aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue & 4294967295, fakeValueChanged = val_5.fakeValue & 4294967295, inited = val_5.fakeValue & 4294967295});
        }
        public bool GetCharacterUsed(CharacterNameID cid)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_4 = this.GetGameSaveFlags(key:  this.GetCharacterUsedKey(cid:  cid), defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
            val_4.fakeValue = val_4.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, fakeValueChanged = val_4.fakeValue, inited = val_4.fakeValue});
        }
        public void SetCharacterUsed(CharacterNameID cid, bool used)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  used);
            this.SetGameSaveFlags(key:  this.GetCharacterUsedKey(cid:  cid), aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue & 4294967295, fakeValueChanged = val_3.fakeValue & 4294967295, inited = val_3.fakeValue & 4294967295});
        }
        public int GetTotalInkProgress()
        {
            var val_4;
            var val_10;
            var val_16;
            var val_17;
            UnityEngine.RectTransform val_18;
            var val_19;
            var val_20;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.adventureProgress.Values.GetEnumerator();
            val_16 = 0;
            val_17 = 0;
            goto label_16;
            label_17:
            List.Enumerator<T> val_7 = val_4.InitialType.GetAllLevels().GetEnumerator();
            goto label_6;
            label_10:
            val_18 = 0;
            val_16 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = X21, hiddenValue = X21, fakeValue = val_4.InitialType, inited = val_4.InitialType})) + val_16;
            label_6:
            if(((-1188391568) & 1) != 0)
            {
                goto label_10;
            }
            
            val_19 = 1;
            val_20 = 0;
            val_4.Add(driver:  public System.Void List.Enumerator<DataStructs.GameLevel>::Dispose(), rectTransform:  val_18, drivenProperties:  null);
            if( != 0)
            {
                    val_18 = 0;
            }
            
            val_17 = 0;
            if( != 1)
            {
                    var val_11 = (val_10 == 88) ? 1 : 0;
                val_11 = (( >= 0) ? 1 : 0) & val_11;
                val_17 =  - val_11;
            }
            
            label_16:
            if(((-1188391536) & 1) != 0)
            {
                goto label_17;
            }
            
            var val_13 = val_17 + 1;
            mem2[0] = 113;
            val_4.Add(driver:  public System.Void Dictionary.ValueCollection.Enumerator<System.String, DataStructs.AdventureProgress>::Dispose(), rectTransform:  val_18, drivenProperties:  null);
            return (int)val_16;
        }
        public int GetTotalStars()
        {
            var val_4;
            var val_8;
            var val_15;
            var val_24;
            UnityEngine.RectTransform val_25;
            var val_26;
            var val_27;
            var val_28;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.adventureProgress.Values.GetEnumerator();
            var val_21 = 0;
            val_24 = 0;
            goto label_28;
            label_29:
            List.Enumerator<T> val_7 = val_4.InitialType.GetAllLevels().GetEnumerator();
            goto label_8;
            label_17:
            0.Add(driver:  public System.Void List.Enumerator<DataStructs.AdventureGameMode>::Dispose(), rectTransform:  null, drivenProperties:  null);
            if(val_7.current != 0)
            {
                    val_25 = 0;
            }
            
            val_26 = 0;
            if( != 1)
            {
                    var val_9 = (val_8 == 110) ? 1 : 0;
                val_9 = (( >= 0) ? 1 : 0) & val_9;
                val_26 =  - val_9;
            }
            
            label_8:
            if(((-1188226320) & 1) == 0)
            {
                goto label_9;
            }
            
            List.Enumerator<T> val_13 = val_4.InitialType.GetAllModes().GetEnumerator();
            goto label_12;
            label_16:
            val_21 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {fakeValue = val_15.InitialType, inited = val_15.InitialType})) + val_21;
            label_12:
            if(((-1188226352) & 1) != 0)
            {
                goto label_16;
            }
            
             = val_26 + 1;
            mem2[0] = 110;
            goto label_17;
            label_9:
            val_27 = val_26 + 1;
            val_28 = 0;
            mem2[0] = 135;
            val_4.Add(driver:  public System.Void List.Enumerator<DataStructs.GameLevel>::Dispose(), rectTransform:  0, drivenProperties:  null);
            if( != 0)
            {
                    val_25 = 0;
            }
            
            val_24 = 0;
            if( != 1)
            {
                    var val_18 = ((1152921529188424336 + (((val_24 - (val_24 >= 0x0 ? 1 : 0 & val_8 == 0x6E ? 1 : 0)) + 1)) << 2) == 135) ? 1 : 0;
                val_18 = (( >= 0) ? 1 : 0) & val_18;
                val_24 =  - val_18;
            }
            
            label_28:
            if(((-1188226288) & 1) != 0)
            {
                goto label_29;
            }
            
            var val_20 = val_24 + 1;
            mem2[0] = 160;
            val_4.Add(driver:  public System.Void Dictionary.ValueCollection.Enumerator<System.String, DataStructs.AdventureProgress>::Dispose(), rectTransform:  val_25, drivenProperties:  null);
            return (int)val_21;
        }
        public System.Collections.Generic.List<int> GetUniqueGameModePlayed(AdvGameMode mode, CharacterClan clan)
        {
            var val_6;
            var val_7;
            var val_19;
            DataStructs.GameSave val_24;
            var val_26;
            System.Predicate<CharacterData> val_27;
            IntPtr val_28;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            val_24 = this;
            .clan = clan;
            System.Collections.Generic.List<System.Int32> val_2 = null;
            val_26 = val_2;
            val_2 = new System.Collections.Generic.List<System.Int32>();
            System.Predicate<CharacterData> val_3 = null;
            val_27 = val_3;
            val_28 = System.Boolean GameSave.<>c__DisplayClass75_0::<GetUniqueGameModePlayed>b__0(CharacterData x);
            val_3 = new System.Predicate<CharacterData>(object:  new GameSave.<>c__DisplayClass75_0(), method:  val_28);
            List.Enumerator<T> val_5 = CharacterDataManager.FindAll(match:  val_3).GetEnumerator();
            val_30 = 1152921529188579888;
            val_31 = 0;
            goto label_38;
            label_39:
            List.Enumerator<T> val_11 = this.adventureProgress.Get(cid:  val_7.InitialType).GetAllLevels().GetEnumerator();
            label_27:
            if(((-1188023184) & 1) == 0)
            {
                goto label_10;
            }
            
            System.Type val_12 = val_7.InitialType;
            if(mode == 0)
            {
                goto label_11;
            }
            
            if(mode == 1)
            {
                goto label_12;
            }
            
            if(mode != 2)
            {
                goto label_27;
            }
            
            val_32 = val_12.GetAdventureGameMode(key:  4);
            goto label_17;
            label_11:
            val_32 = val_12.GetAdventureGameMode(key:  1);
            goto label_17;
            label_12:
            val_32 = val_12.GetAdventureGameMode(key:  3);
            label_17:
            if(val_32 == null)
            {
                goto label_27;
            }
            
            var val_23 = val_6;
            val_23 = val_23 & (-4294967296);
            if(((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_15.passed, hiddenValue = val_15.passed, fakeValue = val_23 | val_30, fakeValueChanged = val_23 | val_30, inited = val_23 | val_30})) == false) || ((val_2.Contains(item:  val_15.passed)) == true))
            {
                goto label_27;
            }
            
            val_2.Add(item:  val_12);
            goto label_27;
            label_10:
            val_33 = 1;
            val_27 = 0;
            val_7.Add(driver:  public System.Void List.Enumerator<DataStructs.GameLevel>::Dispose(), rectTransform:  val_28, drivenProperties:  public System.Void System.Predicate<CharacterData>::.ctor(object object, IntPtr method));
            if( != 0)
            {
                    val_28 = 0;
            }
            
            val_31 = 0;
            if( != 1)
            {
                    var val_20 = (val_19 == 217) ? 1 : 0;
                val_20 = (( >= 0) ? 1 : 0) & val_20;
                val_31 =  - val_20;
            }
            
            label_38:
            if(((-1188023152) & 1) != 0)
            {
                goto label_39;
            }
            
            var val_22 = val_31 + 1;
            mem2[0] = 245;
            val_7.Add(driver:  public System.Void List.Enumerator<CharacterData>::Dispose(), rectTransform:  val_28, drivenProperties:  public System.Void System.Predicate<CharacterData>::.ctor(object object, IntPtr method));
            return (System.Collections.Generic.List<System.Int32>)val_26;
        }
        public System.Collections.Generic.List<int> GetUniqueGameModePlayed(AdvGameMode mode)
        {
            var val_4;
            var val_5;
            var val_16;
            var val_22;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            System.Collections.Generic.List<System.Int32> val_1 = null;
            val_22 = val_1;
            val_1 = new System.Collections.Generic.List<System.Int32>();
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = this.adventureProgress.Values.GetEnumerator();
            val_24 = 1152921529188227888;
            val_25 = 0;
            goto label_34;
            label_35:
            List.Enumerator<T> val_8 = val_5.InitialType.GetAllLevels().GetEnumerator();
            label_23:
            if(((-1187812880) & 1) == 0)
            {
                goto label_6;
            }
            
            System.Type val_9 = val_5.InitialType;
            if(mode == 0)
            {
                goto label_7;
            }
            
            if(mode == 1)
            {
                goto label_8;
            }
            
            if(mode != 2)
            {
                goto label_23;
            }
            
            val_26 = val_9.GetAdventureGameMode(key:  4);
            goto label_13;
            label_7:
            val_26 = val_9.GetAdventureGameMode(key:  1);
            goto label_13;
            label_8:
            val_26 = val_9.GetAdventureGameMode(key:  3);
            label_13:
            if(val_26 == null)
            {
                goto label_23;
            }
            
            var val_20 = val_4;
            val_20 = val_20 & (-4294967296);
            if(((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_12.passed, hiddenValue = val_12.passed, fakeValue = val_20 | 1152921529188228912, fakeValueChanged = val_20 | 1152921529188228912, inited = val_20 | 1152921529188228912})) == false) || ((val_1.Contains(item:  val_12.passed)) == true))
            {
                goto label_23;
            }
            
            val_1.Add(item:  val_9);
            goto label_23;
            label_6:
            val_27 = 1;
            val_28 = 0;
            val_5.Add(driver:  public System.Void List.Enumerator<DataStructs.GameLevel>::Dispose(), rectTransform:  null, drivenProperties:  null);
            val_25 = 0;
            if( != 1)
            {
                    var val_17 = (val_16 == 176) ? 1 : 0;
                val_17 = (( >= 0) ? 1 : 0) & val_17;
                val_25 =  - val_17;
            }
            
            label_34:
            if(((-1187812848) & 1) != 0)
            {
                goto label_35;
            }
            
            var val_19 = val_25 + 1;
            mem2[0] = 204;
            val_5.Add(driver:  public System.Void Dictionary.ValueCollection.Enumerator<System.String, DataStructs.AdventureProgress>::Dispose(), rectTransform:  0, drivenProperties:  null);
            return (System.Collections.Generic.List<System.Int32>)val_22;
        }
        public System.DateTime get_BPAmplifierExpireDate()
        {
            System.DateTime val_1 = System.DateTime.Now;
            bool val_3 = System.DateTime.TryParse(s:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  this.bpAmplifierExpiryTime), result: out  new System.DateTime() {dateData = val_1.dateData});
            return (System.DateTime)val_1.dateData;
        }
        public void set_BPAmplifierExpireDate(System.DateTime value)
        {
            this.BpAmplifierExpiryTime = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  value.dateData);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_LastInGameDaySinceSignUp()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.DateTime val_3 = System.Convert.ToDateTime(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  this.signUpDate));
            System.DateTime val_4 = System.DateTime.UtcNow;
            System.DateTime val_6 = System.Convert.ToDateTime(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  this.lastInGameTime));
            System.TimeSpan val_7 = val_6.dateData.Subtract(value:  new System.DateTime() {dateData = val_3.dateData});
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  (int)val_7._ticks.TotalDays);
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_9.currentCryptoKey, hiddenValue = val_9.hiddenValue, fakeValue = val_9.fakeValue, inited = val_9.inited};
        }
        public bool get_IsRateUsShown()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsRateUsShown", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsRateUsShown(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsRateUsShown", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_IsRateUsClicked()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsRateUsClicked", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsRateUsClicked(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsRateUsClicked", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_IsDemoPlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsDemoPlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsDemoPlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsDemoPlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_EnhancerInfoPlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "EnhancerInfoPlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_EnhancerInfoPlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "EnhancerInfoPlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_AdvancedTutorialPlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "AdvancedTutorialPlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_AdvancedTutorialPlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "AdvancedTutorialPlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_PVPTutorialPlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "PVPTutorialPlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_PVPTutorialPlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "PVPTutorialPlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_IsMainInteractiveTutorialPlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsMainInteractiveTutorialPlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsMainInteractiveTutorialPlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsMainInteractiveTutorialPlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_IsTutorialPlayedForFirstTime()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsTutorialPlayedForFirstTime", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsTutorialPlayedForFirstTime(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsTutorialPlayedForFirstTime", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_IsTutorialZeroPlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsTutorialZeroPlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsTutorialZeroPlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsTutorialZeroPlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_IsTutorialOnePlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsTutorialOnePlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsTutorialOnePlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsTutorialOnePlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_IsTutorialTwoPlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsTutorialTwoPlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsTutorialTwoPlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsTutorialTwoPlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_IsTutorialThreePlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsTutorialThreePlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsTutorialThreePlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsTutorialThreePlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_IsTutorialFourPlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsTutorialFourPlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsTutorialFourPlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsTutorialFourPlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_IsTutorialFivePlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsTutorialFivePlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsTutorialFivePlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsTutorialFivePlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_IsTutorialSixPlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsTutorialSixPlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsTutorialSixPlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsTutorialSixPlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_IsTutorialSevenPlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsTutorialSevenPlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsTutorialSevenPlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsTutorialSevenPlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_IsTutorialEightPlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsTutorialEightPlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsTutorialEightPlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsTutorialEightPlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_IsStatsInstructionDisplayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsStatsInstructionDisplayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsStatsInstructionDisplayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsStatsInstructionDisplayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_isTakoStoryStartPlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "isTakoStoryStartPlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_isTakoStoryStartPlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "isTakoStoryStartPlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_isIkaStoryStartPlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "isIkaStoryStartPlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_isIkaStoryStartPlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "isIkaStoryStartPlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_isInkUpInteractiveTutorialPlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "isInkUpInteractiveTutorialPlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_isInkUpInteractiveTutorialPlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "isInkUpInteractiveTutorialPlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_IsSorryPlayed()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsSorryPlayed", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsSorryPlayed(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsSorryPlayed", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_IsCharacterUnlockedFirstTime()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.GetGameSaveFlags(key:  "IsCharacterUnlockedFirstTime", defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue & 4294967295, fakeValueChanged = val_1.fakeValue & 4294967295, inited = val_1.fakeValue & 4294967295});
            val_3.fakeValue = val_3.fakeValue & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue});
        }
        public void set_IsCharacterUnlockedFirstTime(bool value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  value);
            this.SetGameSaveFlags(key:  "IsCharacterUnlockedFirstTime", aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        public bool get_playCharacterRollAnim()
        {
            return false;
        }
        public void set_playCharacterRollAnim(bool value)
        {
        
        }
    
    }

}
