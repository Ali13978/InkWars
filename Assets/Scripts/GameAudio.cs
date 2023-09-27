using UnityEngine;
public class GameAudio : MonoBehaviour
{
    // Fields
    private static CommonSoundSfx _commonSounds;
    private static GameAudio _inst;
    private static UnityEngine.AudioSource _music;
    private static GameAudio.SoundList _sound;
    private static UnityEngine.AudioSource _unpausebleSound;
    private static System.DateTime lastButtonSoundPlayTime;
    private static System.DateTime lastBubblePopPlayTime;
    private static float BubblePopTimeDifferential;
    private static System.DateTime lastPurchaseSoundPlayTime;
    private bool enableCustomMusicLoop;
    private UnityEngine.AudioClip currentCustomLoopClip;
    private float loopStart;
    private float loopEnd;
    
    // Properties
    public static CommonSoundSfx commonSounds { get; }
    private static GameAudio instance { get; set; }
    public static UnityEngine.AudioSource music { get; }
    public static GameAudio.SoundList sound { get; }
    private static UnityEngine.AudioSource unpausableSound { get; }
    
    // Methods
    public static CommonSoundSfx get_commonSounds()
    {
        var val_3;
        CommonSoundSfx val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = GameAudio._commonSounds;
        if(0 == val_4)
        {
                val_5 = null;
            val_4 = UnityEngine.Resources.Load<CommonSoundSfx>(path:  "Sound/CommonSoundSfx");
            val_5 = null;
            GameAudio._commonSounds = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (CommonSoundSfx)GameAudio._commonSounds;
    }
    private static GameAudio get_instance()
    {
        var val_4;
        GameAudio val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        val_5 = GameAudio._inst;
        if(0 == val_5)
        {
                UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "GameAudio");
            UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
            val_6 = null;
            val_5 = val_2.AddComponent<GameAudio>();
            val_6 = null;
            GameAudio._inst = val_5;
        }
        else
        {
                val_6 = null;
        }
        
        val_6 = null;
        return (GameAudio)GameAudio._inst;
    }
    private static void set_instance(GameAudio value)
    {
        null = null;
        GameAudio._inst = value;
    }
    public static UnityEngine.AudioSource get_music()
    {
        var val_5;
        UnityEngine.AudioSource val_6;
        var val_7;
        val_5 = null;
        val_5 = null;
        val_6 = GameAudio._music;
        if(0 == val_6)
        {
                GameAudio._music = GameAudio.instance.gameObject.AddComponent<UnityEngine.AudioSource>();
            GameAudio._music.playOnAwake = false;
            GameAudio._music.loop = true;
            val_6 = GameAudio._music;
            val_6.volume = 0.45f;
        }
        
        val_7 = null;
        val_7 = null;
        return (UnityEngine.AudioSource)GameAudio._music;
    }
    private static void ResetMusic()
    {
        GameAudio val_1 = GameAudio.instance;
        val_1.enableCustomMusicLoop = false;
        GameAudio.music.Stop();
        GameAudio.music.time = 0f;
        GameAudio val_4 = GameAudio.instance;
        val_4.loopStart = 0f;
        GameAudio val_5 = GameAudio.instance;
        val_5.loopEnd = 0f;
    }
    public static void SwitchMusic(UnityEngine.AudioClip clip, float customLoopStartTime = 0, float customLoopEndTime = 0, bool forcePlay = False)
    {
        UnityEngine.AudioClip val_11 = clip;
        if(GameAudio.music.clip == val_11)
        {
                if(forcePlay == false)
        {
                return;
        }
        
        }
        
        GameAudio.ResetMusic();
        if(0 == val_11)
        {
                return;
        }
        
        GameAudio.music.clip = val_11;
        GameAudio.music.Play();
        if(customLoopEndTime <= customLoopStartTime)
        {
                return;
        }
        
        if(customLoopStartTime <= 0.01f)
        {
                return;
        }
        
        if(customLoopEndTime <= 0.01f)
        {
                return;
        }
        
        GameAudio val_7 = GameAudio.instance;
        val_7.enableCustomMusicLoop = true;
        GameAudio val_8 = GameAudio.instance;
        val_8.currentCustomLoopClip = val_11;
        GameAudio val_9 = GameAudio.instance;
        val_9.loopStart = customLoopStartTime;
        val_11 = GameAudio.instance;
        val_10.loopEnd = customLoopEndTime;
    }
    public static void SwitchMusicOneShot(UnityEngine.AudioClip clip, bool forcePlay = False)
    {
        if(GameAudio.music.clip == clip)
        {
                if(forcePlay == false)
        {
                return;
        }
        
        }
        
        GameAudio.ResetMusic();
        if(0 == clip)
        {
                return;
        }
        
        GameAudio.music.clip = clip;
        GameAudio.music.PlayOneShot(clip:  clip);
    }
    public static void PlayMusicOneShot(UnityEngine.AudioClip clip)
    {
        if(0 == clip)
        {
                return;
        }
        
        GameAudio.music.PlayOneShot(clip:  clip);
    }
    public static void SwitchMusic(MusicIds musicId, bool forcePlay = False)
    {
        null = null;
        MusicData val_1 = GameInfo.music.GetItemDataById(uniqueId:  musicId);
        GameAudio.SwitchMusic(clip:  GameInfo.music.LoadResourceById(uniqueId:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = X23, hiddenValue = X23, fakeValue = 1152921505099071488, inited = false})), customLoopStartTime:  val_1.loopStart, customLoopEndTime:  val_1.loopEnd, forcePlay:  forcePlay);
    }
    public static GameAudio.SoundList get_sound()
    {
        null = null;
        return (SoundList)GameAudio._sound;
    }
    private static UnityEngine.AudioSource get_unpausableSound()
    {
        var val_5;
        UnityEngine.AudioSource val_6;
        var val_7;
        val_5 = null;
        val_5 = null;
        val_6 = GameAudio._unpausebleSound;
        if(0 == val_6)
        {
                GameAudio._unpausebleSound = GameAudio.instance.gameObject.AddComponent<UnityEngine.AudioSource>();
            GameAudio._unpausebleSound.playOnAwake = false;
            val_6 = GameAudio._unpausebleSound;
            val_6.loop = false;
        }
        
        val_7 = null;
        val_7 = null;
        return (UnityEngine.AudioSource)GameAudio._unpausebleSound;
    }
    public static void PlayButtonSound()
    {
        ulong val_7;
        var val_8;
        var val_9;
        System.DateTime val_1 = System.DateTime.Now;
        val_7 = val_1.dateData;
        val_8 = null;
        val_8 = null;
        System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_7}, d2:  new System.DateTime() {dateData = GameAudio.lastButtonSoundPlayTime});
        if(val_2._ticks.TotalSeconds < 0)
        {
                return;
        }
        
        System.DateTime val_4 = System.DateTime.Now;
        val_9 = null;
        val_9 = null;
        GameAudio.lastButtonSoundPlayTime = val_4.dateData;
        val_7 = GameAudio.unpausableSound;
        CommonSoundSfx val_6 = GameAudio.commonSounds;
        val_7.PlayOneShot(clip:  val_6.buttonSound);
    }
    public static void PlayBubbleSwitchSound()
    {
        CommonSoundSfx val_2 = GameAudio.commonSounds;
        GameAudio.unpausableSound.PlayOneShot(clip:  val_2.switchBubbelSound);
    }
    public static void PlayBubblePopSound()
    {
        ulong val_7;
        var val_8;
        var val_9;
        System.DateTime val_1 = System.DateTime.Now;
        val_7 = val_1.dateData;
        val_8 = null;
        val_8 = null;
        System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_7}, d2:  new System.DateTime() {dateData = GameAudio.lastBubblePopPlayTime});
        if(val_2._ticks.TotalSeconds < 0)
        {
                return;
        }
        
        System.DateTime val_4 = System.DateTime.Now;
        val_9 = null;
        val_9 = null;
        GameAudio.lastBubblePopPlayTime = val_4.dateData;
        val_7 = GameAudio.unpausableSound;
        CommonSoundSfx val_6 = GameAudio.commonSounds;
        val_7.PlayOneShot(clip:  val_6.bubblePopSound);
    }
    public static void PlayPurchaseSound()
    {
        ulong val_10;
        var val_11;
        var val_12;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_10 = val_1.m_Handle.name;
        if((val_10.Contains(value:  "LoadingScene")) == true)
        {
                return;
        }
        
        System.DateTime val_4 = System.DateTime.Now;
        val_10 = val_4.dateData;
        val_11 = null;
        val_11 = null;
        System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_10}, d2:  new System.DateTime() {dateData = GameAudio.lastPurchaseSoundPlayTime});
        if(val_5._ticks.TotalSeconds < 0)
        {
                return;
        }
        
        System.DateTime val_7 = System.DateTime.Now;
        val_12 = null;
        val_12 = null;
        GameAudio.lastPurchaseSoundPlayTime = val_7.dateData;
        val_10 = GameAudio.unpausableSound;
        CommonSoundSfx val_9 = GameAudio.commonSounds;
        val_10.PlayOneShot(clip:  val_9.purchaseSound);
    }
    public static void ResetMusicSettingsByUserData()
    {
        var val_7 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = DataStructs.UserDataDictionary.Settings.MusicEnabled;
        val_2.fakeValue = val_2.fakeValue & 4294967295;
        val_2.fakeValue = (~(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, fakeValueChanged = val_2.fakeValue, inited = val_2.fakeValue}))) & 1;
        GameAudio.music.mute = val_2.fakeValue;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_4 = DataStructs.UserDataDictionary.Settings.MusicEnabled;
        val_4.fakeValue = val_4.fakeValue & 4294967295;
        DeviceBasedData.enableMusic = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, fakeValueChanged = val_4.fakeValue, inited = val_4.fakeValue});
    }
    public static void ResetSoundSettingByUserData()
    {
        var val_10 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = DataStructs.UserDataDictionary.Settings.SoundEnabled;
        val_2.fakeValue = val_2.fakeValue & 4294967295;
        val_2.fakeValue = (~(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, fakeValueChanged = val_2.fakeValue, inited = val_2.fakeValue}))) & 1;
        GameAudio.sound.mute = val_2.fakeValue;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_5 = DataStructs.UserDataDictionary.Settings.SoundEnabled;
        val_5.fakeValue = val_5.fakeValue & 4294967295;
        val_5.fakeValue = (~(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, fakeValueChanged = val_5.fakeValue, inited = val_5.fakeValue}))) & 1;
        GameAudio.unpausableSound.mute = val_5.fakeValue;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_7 = DataStructs.UserDataDictionary.Settings.SoundEnabled;
        val_7.fakeValue = val_7.fakeValue & 4294967295;
        DeviceBasedData.enableSFX = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue, fakeValueChanged = val_7.fakeValue, inited = val_7.fakeValue});
    }
    public static void ResetAudioSettinsByDeviceData()
    {
        GameAudio.music.mute = (~DeviceBasedData.enableMusic) & 1;
        GameAudio.sound.mute = (~DeviceBasedData.enableSFX) & 1;
        GameAudio.unpausableSound.mute = (~DeviceBasedData.enableSFX) & 1;
    }
    private void Update()
    {
        if(this.enableCustomMusicLoop == false)
        {
                return;
        }
        
        if(GameAudio.music.clip != this.currentCustomLoopClip)
        {
                return;
        }
        
        if(GameAudio.music.time <= this.loopEnd)
        {
                return;
        }
        
        GameAudio.music.time = this.loopStart;
    }
    public GameAudio()
    {
    
    }
    private static GameAudio()
    {
        var val_2;
        var val_3;
        val_2 = null;
        GameAudio._sound = new GameAudio.SoundList();
        val_3 = null;
        val_3 = null;
        val_2 = null;
        float val_2 = InkWars.Model.Model_Constants.BubblePopSubsequentDelay;
        val_2 = val_2 * 0.5f;
        GameAudio.BubblePopTimeDifferential = val_2;
    }

}
