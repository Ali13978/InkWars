using UnityEngine;

namespace DataStructs
{
    public class Settings : FirebaseDictionalizer
    {
        // Fields
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool musicEnabled;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool soundEnabled;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool leftHandEnabled;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat controllerSensitivity;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString userName;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString password;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString facebookID;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString ggpID;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString email;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString selectedFlag;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt selectedMusicTrack;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt selectedBackgroundImage;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt selectedAvatar;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt selectedTitle;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt selectedBattleGrid;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt selectedSwitcher;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt selectedBubble;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt selectedGameDuration;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt selectedBattleEnhancer;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt selectedBPAmplifier;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString language;
        
        // Properties
        public override string keyName { get; }
        public UnityEngine.SystemLanguage Language { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool MusicEnabled { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SoundEnabled { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool LeftHandEnabled { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat ControllerSensitivity { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString UserName { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString Password { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString GGPID { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString FacebookID { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString Email { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString SelectedFlag { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SelectedMusicTrack { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SelectedBackgroundImage { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SelectedAvatar { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SelectedTitle { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SelectedBattleGrid { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SelectedSwitcher { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SelectedBubble { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SelectedGameDuration { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SelectedBattleEnhancer { get; set; }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SelectedBPAmplifier { get; set; }
        public int FlipNegateX { get; set; }
        public int LanMusicIndex { get; set; }
        public DataStructs.Flag UserFlag { get; set; }
        public DataStructs.PlayerRegion Region { get; }
        
        // Methods
        public override string get_keyName()
        {
            return "settings";
        }
        public Settings()
        {
            val_1 = new System.Object();
            mem[1152921529212695104] = 0;
            mem[1152921529212695112] = 0;
        }
        protected override void CustomInitAfterLoadDefaults()
        {
            var val_18;
            this.UserFlag = 125;
            val_18 = null;
            val_18 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  GameInfo.music.GetRandomDefaultIds());
            this.SelectedMusicTrack = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited};
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  GameInfo.stage.GetRandomDefaultIds());
            this.SelectedBackgroundImage = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited};
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  AvatarCollection.GetAvatarIntId(key:  1, cid:  63));
            this.SelectedAvatar = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited};
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  TitleCollection.GetTitleIntId(key:  1, cid:  63));
            this.SelectedTitle = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_8.currentCryptoKey, hiddenValue = val_8.hiddenValue, fakeValue = val_8.fakeValue, inited = val_8.inited};
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  99);
            this.SelectedGameDuration = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_9.currentCryptoKey, hiddenValue = val_9.hiddenValue, fakeValue = val_9.fakeValue, inited = val_9.inited};
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  DeviceBasedData.playerAtLeftForQuickPlay);
            this.LeftHandEnabled = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_12.currentCryptoKey, hiddenValue = val_12.hiddenValue, fakeValue = val_12.fakeValue & 4294967295, fakeValueChanged = val_12.fakeValue & 4294967295, inited = val_12.fakeValue & 4294967295};
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_14 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
            this.MusicEnabled = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_14.currentCryptoKey, hiddenValue = val_14.hiddenValue, fakeValue = val_14.fakeValue & 4294967295, fakeValueChanged = val_14.fakeValue & 4294967295, inited = val_14.fakeValue & 4294967295};
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_16 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
            this.SoundEnabled = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_16.currentCryptoKey, hiddenValue = val_16.hiddenValue, fakeValue = val_16.fakeValue & 4294967295, fakeValueChanged = val_16.fakeValue & 4294967295, inited = val_16.fakeValue & 4294967295};
        }
        public UnityEngine.SystemLanguage get_Language()
        {
            UnityEngine.SystemLanguage val_2 = 10;
            bool val_3 = System.Enum.TryParse<UnityEngine.SystemLanguage>(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  this.language), result: out  val_2);
            return val_2;
        }
        public void set_Language(UnityEngine.SystemLanguage value)
        {
            value.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredString val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  value.ToString());
            this.language = val_2;
            this.SaveVariable(name:  "language", obj:  val_2);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool get_MusicEnabled()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = this.musicEnabled, hiddenValue = this.musicEnabled, fakeValue = false, fakeValueChanged = false, inited = false};
        }
        public void set_MusicEnabled(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value)
        {
            this.musicEnabled = value;
            mem[1152921529213310616] = value.fakeValue;
            mem[1152921529213310617] = value.fakeValueChanged;
            mem[1152921529213310618] = value.inited;
            this.SaveVariableImmediately(name:  "musicEnabled", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool get_SoundEnabled()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = this.soundEnabled, hiddenValue = this.soundEnabled, fakeValue = false, fakeValueChanged = false, inited = false};
        }
        public void set_SoundEnabled(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value)
        {
            this.soundEnabled = value;
            mem[1152921529213544964] = value.fakeValue;
            mem[1152921529213544965] = value.fakeValueChanged;
            mem[1152921529213544966] = value.inited;
            this.SaveVariableImmediately(name:  "soundEnabled", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool get_LeftHandEnabled()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = this.leftHandEnabled, hiddenValue = this.leftHandEnabled, fakeValue = false, fakeValueChanged = false, inited = false};
        }
        public void set_LeftHandEnabled(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value)
        {
            this.leftHandEnabled = value;
            mem[1152921529213779328] = value.fakeValue;
            mem[1152921529213779329] = value.fakeValueChanged;
            mem[1152921529213779330] = value.inited;
            this.SaveVariableImmediately(name:  "leftHandEnabled", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat get_ControllerSensitivity()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_0;
            val_0.fakeValue = ;
            val_0.currentCryptoKey = this.controllerSensitivity;
            return val_0;
        }
        public void set_ControllerSensitivity(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat value)
        {
            mem[1152921529214135352] = value.fakeValue;
            this.controllerSensitivity = value.currentCryptoKey;
            this.SaveVariableImmediately(name:  "controllerSensitivity", obj:  this.controllerSensitivity);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_UserName()
        {
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)this.userName;
        }
        public void set_UserName(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            this.userName = value;
            this.SaveVariableImmediately(name:  "userName", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_Password()
        {
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)this.password;
        }
        public void set_Password(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            this.password = value;
            this.SaveVariableImmediately(name:  "password", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_GGPID()
        {
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)this.ggpID;
        }
        public void set_GGPID(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            this.ggpID = value;
            this.SaveVariableImmediately(name:  "ggpID", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_FacebookID()
        {
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)this.facebookID;
        }
        public void set_FacebookID(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            this.facebookID = value;
            this.SaveVariableImmediately(name:  "facebookID", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_Email()
        {
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)this.email;
        }
        public void set_Email(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            this.email = value;
            this.SaveVariableImmediately(name:  "email", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_SelectedFlag()
        {
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)this.selectedFlag;
        }
        public void set_SelectedFlag(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            this.selectedFlag = value;
            this.SaveVariableImmediately(name:  "selectedFlag", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_SelectedMusicTrack()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.selectedMusicTrack, hiddenValue = this.selectedMusicTrack, inited = false};
        }
        public void set_SelectedMusicTrack(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.selectedMusicTrack = value;
            mem[1152921529215852440] = value.fakeValue;
            mem[1152921529215852444] = value.inited;
            this.SaveVariableImmediately(name:  "selectedMusicTrack", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_SelectedBackgroundImage()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.selectedBackgroundImage, hiddenValue = this.selectedBackgroundImage, inited = false};
        }
        public void set_SelectedBackgroundImage(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.selectedBackgroundImage = value;
            mem[1152921529216086824] = value.fakeValue;
            mem[1152921529216086828] = value.inited;
            this.SaveVariableImmediately(name:  "selectedBackgroundImage", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_SelectedAvatar()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.selectedAvatar, hiddenValue = this.selectedAvatar, inited = false};
        }
        public void set_SelectedAvatar(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.selectedAvatar = value;
            mem[1152921529216321176] = value.fakeValue;
            mem[1152921529216321180] = value.inited;
            this.SaveVariableImmediately(name:  "selectedAvatar", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_SelectedTitle()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.selectedTitle, hiddenValue = this.selectedTitle, inited = false};
        }
        public void set_SelectedTitle(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.selectedTitle = value;
            mem[1152921529216555528] = value.fakeValue;
            mem[1152921529216555532] = value.inited;
            this.SaveVariableImmediately(name:  "selectedTitle", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_SelectedBattleGrid()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.selectedBattleGrid, hiddenValue = this.selectedBattleGrid, inited = false};
        }
        public void set_SelectedBattleGrid(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.selectedBattleGrid = value;
            mem[1152921529216789896] = value.fakeValue;
            mem[1152921529216789900] = value.inited;
            this.SaveVariableImmediately(name:  "selectedBattleGrid", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_SelectedSwitcher()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.selectedSwitcher, hiddenValue = this.selectedSwitcher, inited = false};
        }
        public void set_SelectedSwitcher(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.selectedSwitcher = value;
            mem[1152921529217024264] = value.fakeValue;
            mem[1152921529217024268] = value.inited;
            this.SaveVariableImmediately(name:  "selectedSwitcher", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_SelectedBubble()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.selectedBubble, hiddenValue = this.selectedBubble, inited = false};
        }
        public void set_SelectedBubble(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.selectedBubble = value;
            mem[1152921529217258616] = value.fakeValue;
            mem[1152921529217258620] = value.inited;
            this.SaveVariableImmediately(name:  "selectedBubble", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_SelectedGameDuration()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.selectedGameDuration, hiddenValue = this.selectedGameDuration, inited = false};
        }
        public void set_SelectedGameDuration(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.selectedGameDuration = value;
            mem[1152921529217492984] = value.fakeValue;
            mem[1152921529217492988] = value.inited;
            this.SaveVariableImmediately(name:  "selectedGameDuration", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_SelectedBattleEnhancer()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.selectedBattleEnhancer, hiddenValue = this.selectedBattleEnhancer, inited = false};
        }
        public void set_SelectedBattleEnhancer(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.selectedBattleEnhancer = value;
            mem[1152921529217727352] = value.fakeValue;
            mem[1152921529217727356] = value.inited;
            this.SaveVariableImmediately(name:  "selectedBattleEnhancer", obj:  value);
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_SelectedBPAmplifier()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.selectedBPAmplifier, hiddenValue = this.selectedBPAmplifier, inited = false};
        }
        public void set_SelectedBPAmplifier(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            this.selectedBPAmplifier = value;
            mem[1152921529217961720] = value.fakeValue;
            mem[1152921529217961724] = value.inited;
            this.SaveVariableImmediately(name:  "selectedBPAmplifier", obj:  value);
        }
        public int get_FlipNegateX()
        {
            return (int)(((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = this.leftHandEnabled, hiddenValue = this.leftHandEnabled, fakeValue = true, fakeValueChanged = true, inited = true})) & true) != 0) ? (-1) : 1;
        }
        public void set_FlipNegateX(int value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  (value > 0) ? 1 : 0);
            this.LeftHandEnabled = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295};
        }
        public int get_LanMusicIndex()
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.selectedMusicTrack, hiddenValue = this.selectedMusicTrack, fakeValue = -1158348208, inited = true});
        }
        public void set_LanMusicIndex(int value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  value);
            this.SelectedMusicTrack = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        }
        public DataStructs.Flag get_UserFlag()
        {
            DataStructs.Flag val_2 = 0;
            bool val_3 = System.Enum.TryParse<DataStructs.Flag>(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  this.selectedFlag), result: out  val_2);
            return val_2;
        }
        public void set_UserFlag(DataStructs.Flag value)
        {
            value.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            this.SelectedFlag = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  value.ToString());
        }
        public DataStructs.PlayerRegion get_Region()
        {
            return DataStructs.CountryToRegion.ToRegion(flag:  this.UserFlag);
        }
        public bool HasSetupLanguage()
        {
            bool val_2 = System.String.IsNullOrWhiteSpace(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  this.language));
            val_2 = (~val_2) & 1;
            return (bool)val_2;
        }
    
    }

}
