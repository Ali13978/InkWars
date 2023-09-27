using UnityEngine;
public class MusicSelectionController : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject m_MusicLockImage;
    private UnityEngine.UI.Text m_SongNameText;
    private bool m_HideLockedSongs;
    private int m_SongIndex;
    private System.Collections.Generic.List<int> m_SongList;
    
    // Properties
    public System.Collections.Generic.List<int> SongList { get; }
    
    // Methods
    public System.Collections.Generic.List<int> get_SongList()
    {
        System.Collections.Generic.List<System.Int32> val_2;
        var val_3;
        val_2 = this.m_SongList;
        if(val_2 != null)
        {
                return val_1;
        }
        
        val_3 = null;
        val_3 = null;
        System.Collections.Generic.List<System.Int32> val_1 = GameInfo.music.GetAllUniqueIds();
        this.m_SongList = val_1;
        return val_1;
    }
    private void OnEnable()
    {
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        int val_23;
        var val_24;
        val_18 = null;
        val_18 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedMusicTrack;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})) == 0)
        {
                val_19 = null;
            val_19 = null;
            val_20 = null;
            val_20 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  GameInfo.music.GetRandomDefaultIds());
            DataStructs.UserDataDictionary.Settings.SelectedMusicTrack = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited};
        }
        
        System.Collections.Generic.List<System.Int32> val_5 = this.SongList;
        val_21 = null;
        val_21 = null;
        System.Predicate<System.Int32> val_18 = MusicSelectionController.<>c.<>9__7_0;
        if(val_18 == null)
        {
            goto label_17;
        }
        
        label_35:
        val_23 = val_5.FindIndex(match:  val_18);
        this.m_SongIndex = val_23;
        if(this.m_HideLockedSongs == false)
        {
            goto label_20;
        }
        
        goto label_23;
        label_28:
        val_18 = val_23 + 1;
        this.m_SongIndex = val_18;
        if(val_18 > (this.SongList.Count - 1))
        {
                this.m_SongIndex = 0;
        }
        
        label_23:
        val_24 = null;
        val_24 = null;
        val_23 = this.m_SongIndex;
        if((DataStructs.UserDataDictionary.Items.IsMusicUnlocked(id:  this.SongList.Item[this.m_SongIndex])) == false)
        {
            goto label_28;
        }
        
        label_20:
        this.m_SongIndex = UnityEngine.Mathf.Clamp(value:  val_23, min:  0, max:  this.SongList.Count - 1);
        this.SetMusic();
        return;
        label_17:
        MusicSelectionController.<>c.<>9__7_0 = new System.Predicate<System.Int32>(object:  MusicSelectionController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MusicSelectionController.<>c::<OnEnable>b__7_0(int x));
        if(val_5 != null)
        {
            goto label_35;
        }
        
        goto label_35;
    }
    public void MusicLeftArrowClicked()
    {
        DataStructs.Items val_7;
        var val_8;
        label_8:
        int val_7 = this.m_SongIndex;
        val_7 = val_7 - 1;
        this.m_SongIndex = val_7;
        if((val_7 & 2147483648) != 0)
        {
                val_7 = this.SongList;
            this.m_SongIndex = val_7.Count - 1;
        }
        
        if(this.m_HideLockedSongs == false)
        {
            goto label_3;
        }
        
        val_8 = null;
        val_8 = null;
        val_7 = DataStructs.UserDataDictionary.Items;
        if((val_7.IsMusicUnlocked(id:  this.SongList.Item[this.m_SongIndex])) == false)
        {
            goto label_8;
        }
        
        label_3:
        this.SetMusic();
    }
    public void MusicRightArrowClicked()
    {
        DataStructs.Items val_8;
        var val_9;
        label_7:
        int val_1 = this.m_SongIndex + 1;
        this.m_SongIndex = val_1;
        val_8 = this.SongList;
        int val_3 = val_8.Count;
        int val_4 = val_1 / val_3;
        val_4 = val_1 - (val_4 * val_3);
        this.m_SongIndex = val_4;
        if(this.m_HideLockedSongs == false)
        {
            goto label_2;
        }
        
        val_9 = null;
        val_9 = null;
        val_8 = DataStructs.UserDataDictionary.Items;
        if((val_8.IsMusicUnlocked(id:  this.SongList.Item[this.m_SongIndex])) == false)
        {
            goto label_7;
        }
        
        label_2:
        this.SetMusic();
    }
    private void SetMusic()
    {
        var val_14;
        string val_15;
        var val_16;
        var val_17;
        var val_18;
        val_14 = null;
        val_14 = null;
        System.Collections.Generic.List<System.Int32> val_1 = this.SongList;
        MusicData val_3 = GameInfo.music.GetItemDataById(uniqueId:  val_1.Item[this.m_SongIndex]);
        if((System.String.IsNullOrEmpty(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_3.subTitle))) != false)
        {
                val_15 = "";
        }
        else
        {
                val_15 = " (" + CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_3.subTitle)(CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_3.subTitle)) + ")";
        }
        
        val_16 = null;
        val_16 = null;
        GameAudio.SwitchMusic(clip:  GameInfo.music.LoadResourceById(uniqueId:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 102099184, hiddenValue = 268435461, fakeValue = "♫ " + CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_1)(CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_1)) + val_15 + " ♫", inited = "♫ " + CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_1)(CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_1)) + val_15 + " ♫"})), customLoopStartTime:  0f, customLoopEndTime:  0f, forcePlay:  false);
        val_17 = null;
        val_17 = null;
        bool val_13 = DataStructs.UserDataDictionary.Items.IsMusicUnlocked(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 544673792, hiddenValue = 268435456, inited = false}));
        if(this.m_MusicLockImage == null)
        {
            goto label_23;
        }
        
        if(val_13 == false)
        {
            goto label_24;
        }
        
        label_26:
        val_18 = 0;
        goto label_25;
        label_23:
        if(val_13 == true)
        {
            goto label_26;
        }
        
        label_24:
        val_18 = 1;
        label_25:
        this.m_MusicLockImage.SetActive(value:  true);
    }
    public void Apply()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  this.SongList.Item[this.m_SongIndex]);
        DataStructs.UserDataDictionary.Settings.SelectedMusicTrack = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
    }
    public MusicSelectionController()
    {
    
    }

}
