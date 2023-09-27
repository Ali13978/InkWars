using UnityEngine;
public class NetworkLobby_Network_Select_Screen : MonoBehaviour
{
    // Fields
    public bool TEST_ONLINE_MODE;
    public const string RoomNamePrefix = "INKWARS_";
    private const int MaxSongIndex = 7;
    public UnityEngine.UI.InputField ipInputField;
    public UnityEngine.UI.Text PhotonThunderWarning;
    public UnityEngine.UI.Text[] YourWins;
    public UnityEngine.UI.Text[] YourDraws;
    public UnityEngine.UI.Text[] YourLosses;
    public UnityEngine.UI.Text[] TheirWins;
    public UnityEngine.UI.Text[] TheirDraws;
    public UnityEngine.UI.Text[] TheirLosses;
    public UnityEngine.GameObject hostAndJoin_Screen;
    public UnityEngine.GameObject selectionHost_Screen;
    public UnityEngine.GameObject selectionGuest_Screen;
    public UnityEngine.GameObject discovery_Screen;
    public UnityEngine.GameObject hostTimeSelectScreen;
    public UnityEngine.GameObject hostWaitForChallengerScreen;
    public UnityEngine.GameObject hostConfirmChallengeScreen;
    public UnityEngine.GameObject guestSelectHostScreen;
    public UnityEngine.GameObject guestWaitingForHostScreen;
    public UnityEngine.GameObject guestConfirmChallengeScreen;
    private UnityEngine.GameObject NetworkFunctions;
    private int lanMusicIndex;
    public UnityEngine.UI.Text lanMusicName;
    public UnityEngine.GameObject musicLockImage;
    public UnityEngine.GameObject advancedTutorialButton;
    public UnityEngine.UI.Text[] userNameTexts;
    public UnityEngine.UI.Text[] shellTexts;
    public UnityEngine.UI.Text[] challengerUserNameTexts;
    public UnityEngine.UI.Text hostIPHexText;
    public static NetworkLobby_Network_Select_Screen instance;
    public UnityEngine.GameObject AdvancedTutorialPanel;
    private System.Collections.Generic.List<int> musicList;
    
    // Methods
    public void SetScreen(NetworkLobby_Network_Select_Screen.NetworkLobbyScreens screen)
    {
        if(this.TEST_ONLINE_MODE == false)
        {
            goto label_0;
        }
        
        label_7:
        this.hostAndJoin_Screen.SetActive(value:  (screen == 1) ? 1 : 0);
        this.selectionHost_Screen.SetActive(value:  (screen == 2) ? 1 : 0);
        this.selectionGuest_Screen.SetActive(value:  (screen == 3) ? 1 : 0);
        this.discovery_Screen.SetActive(value:  (screen == 4) ? 1 : 0);
        return;
        label_0:
        if((screen == 2) || (screen == 4))
        {
            goto label_7;
        }
        
        NetworkDiscovery_Custom.SafeStopBroadcasting();
        goto label_7;
    }
    private void OnDisable()
    {
        if(this.TEST_ONLINE_MODE != false)
        {
                return;
        }
        
        NetworkDiscovery_Custom.SafeStopBroadcasting();
    }
    private void Start()
    {
        NetworkLobby_Network_Select_Screen val_23;
        string val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        val_23 = this;
        if(NetworkLobby_Network_Select_Screen.instance != 0)
        {
                UnityEngine.Object.Destroy(obj:  NetworkLobby_Network_Select_Screen.instance);
        }
        
        NetworkLobby_Network_Select_Screen.instance = val_23;
        if((UnityEngine.Object.op_Implicit(exists:  BattleVSGates.instance)) != false)
        {
                BattleVSGates.instance.KillSwitch();
        }
        
        if(this.TEST_ONLINE_MODE == false)
        {
            goto label_10;
        }
        
        this.PhotonThunderWarning.gameObject.SetActive(value:  true);
        if(NetworkDiscovery_Custom.instance == 0)
        {
            goto label_15;
        }
        
        val_25 = "You need to disable networkdiscovery custom";
        goto label_16;
        label_10:
        if(NetworkDiscovery_Custom.instance == 0)
        {
            goto label_19;
        }
        
        label_15:
        val_26 = null;
        val_26 = null;
        this.advancedTutorialButton.GetComponent<UnityEngine.Animator>().enabled = (~DataStructs.UserDataDictionary.GameSave.AdvancedTutorialPlayed) & 1;
        if(DataStructs.UserDataDictionary.GameSave.PVPTutorialPlayed != true)
        {
                this.AdvancedTutorialPanel.SetActive(value:  true);
            val_27 = null;
            val_27 = null;
            DataStructs.UserDataDictionary.GameSave.PVPTutorialPlayed = true;
        }
        
        val_28 = null;
        val_28 = null;
        this.musicList = GameInfo.music.GetAllUniqueIds();
        GameAudio.SwitchMusic(musicId:  0, forcePlay:  false);
        val_29 = null;
        val_29 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_11 = DataStructs.UserDataDictionary.Stats.TotalPVPWins;
        NetworkLobby_Network_Select_Screen.SetText(text:  this.YourWins, value:  val_11.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_13 = DataStructs.UserDataDictionary.Stats.TotalPVPDraws;
        NetworkLobby_Network_Select_Screen.SetText(text:  this.YourDraws, value:  val_13.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_15 = DataStructs.UserDataDictionary.Stats.TotalPVPLosses;
        NetworkLobby_Network_Select_Screen.SetText(text:  this.YourLosses, value:  val_15.currentCryptoKey.ToString());
        NetworkLobby_Network_Select_Screen.SetText(text:  this.TheirWins, value:  "?");
        NetworkLobby_Network_Select_Screen.SetText(text:  this.TheirDraws, value:  "?");
        NetworkLobby_Network_Select_Screen.SetText(text:  this.TheirLosses, value:  "?");
        val_30 = null;
        val_30 = null;
        Character_GlobalInfo.gameMode = 5;
        UnityEngine.MonoBehaviour.print(message:  "Started Network Select Screen Script");
        this.ipInputField.text = UnityEngine.PlayerPrefs.GetString(key:  "LastUsedIP", defaultValue:  "");
        this.NetworkFunctions = UnityEngine.GameObject.Find(name:  "NetworkFunctions");
        this.SetGameObjectsDefaultState();
        val_31 = 0;
        goto label_44;
        label_48:
        UnityEngine.UI.Text val_23 = this.userNameTexts[0];
        string val_19 = PlayerPrefsManager.PlayerName;
        val_31 = 1;
        label_44:
        if(val_31 < this.userNameTexts.Length)
        {
            goto label_48;
        }
        
        val_32 = 0;
        goto label_49;
        label_53:
        val_23 = this.shellTexts[0];
        string val_21 = PlayerPrefsManager.GetShellString(shells:  PlayerPrefsManager.Shells);
        val_32 = 1;
        label_49:
        if(val_32 < this.shellTexts.Length)
        {
            goto label_53;
        }
        
        PlayerPrefsManager.OnlinePVPTime = 99;
        return;
        label_19:
        val_25 = "You need to enable networkdiscovery custom";
        label_16:
        null = new System.Exception(message:  val_25);
    }
    public void MusicRightArrowClicked()
    {
        int val_5;
        var val_6;
        do
        {
            int val_5 = this.lanMusicIndex;
            int val_1 = val_5 + 1;
            this.lanMusicIndex = val_1;
            int val_2 = this.musicList.Count;
            val_5 = val_1 / val_2;
            val_5 = val_1 - (val_5 * val_2);
            this.lanMusicIndex = val_5;
            val_6 = null;
            val_6 = null;
            val_5 = this.lanMusicIndex;
        }
        while((DataStructs.UserDataDictionary.Items.IsMusicUnlocked(id:  this.musicList.Item[val_5])) == false);
        
        this.SetMusic();
    }
    private void SetMusic()
    {
        var val_14;
        string val_15;
        var val_16;
        var val_17;
        val_14 = null;
        val_14 = null;
        MusicData val_2 = GameInfo.music.GetItemDataById(uniqueId:  this.musicList.Item[this.lanMusicIndex]);
        if((System.String.IsNullOrEmpty(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_2.subTitle))) != false)
        {
                val_15 = "";
        }
        else
        {
                val_15 = " (" + CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_2.subTitle)(CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_2.subTitle)) + ")";
        }
        
        val_16 = null;
        val_16 = null;
        GameAudio.SwitchMusic(clip:  GameInfo.music.LoadResourceById(uniqueId:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 102099184, hiddenValue = 268435461, fakeValue = "♫ " + CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  this.lanMusicIndex)(CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  this.lanMusicIndex)) + val_15 + " ♫", inited = "♫ " + CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  this.lanMusicIndex)(CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  this.lanMusicIndex)) + val_15 + " ♫"})), customLoopStartTime:  0f, customLoopEndTime:  0f, forcePlay:  false);
        val_17 = null;
        val_17 = null;
        bool val_12 = DataStructs.UserDataDictionary.Items.IsMusicUnlocked(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 544673792, hiddenValue = 268435456, inited = false}));
        if(this.musicLockImage == null)
        {
            goto label_23;
        }
        
        if(val_12 == false)
        {
            goto label_24;
        }
        
        label_26:
        this.musicLockImage.SetActive(value:  false);
        PlayerPrefsManager.LanMusicIndex = this.musicList.Item[this.lanMusicIndex];
        return;
        label_23:
        if(val_12 == true)
        {
            goto label_26;
        }
        
        label_24:
        this.musicLockImage.SetActive(value:  true);
    }
    public void MusicLeftArrowClicked()
    {
        int val_5;
        var val_6;
        do
        {
            val_5 = this.lanMusicIndex - 1;
            this.lanMusicIndex = val_5;
            if((val_5 & 2147483648) != 0)
        {
                val_5 = this.musicList.Count - 1;
            this.lanMusicIndex = val_5;
        }
        
            val_6 = null;
            val_6 = null;
            val_5 = this.lanMusicIndex;
        }
        while((DataStructs.UserDataDictionary.Items.IsMusicUnlocked(id:  this.musicList.Item[val_5])) == false);
        
        this.SetMusic();
    }
    public void HostButtonClicked()
    {
        var val_13;
        System.Predicate<T> val_14;
        var val_15;
        NetworkLobby_Network_Select_Screen.<>c__DisplayClass40_0 val_1 = new NetworkLobby_Network_Select_Screen.<>c__DisplayClass40_0();
        GameAudio.PlayButtonSound();
        this.hostWaitForChallengerScreen.SetActive(value:  false);
        this.hostTimeSelectScreen.SetActive(value:  true);
        this.hostConfirmChallengeScreen.SetActive(value:  false);
        this.guestConfirmChallengeScreen.SetActive(value:  false);
        val_13 = this.guestWaitingForHostScreen;
        val_13.SetActive(value:  false);
        val_13 = null;
        System.Collections.Generic.List<DataType> val_2 = GameInfo.music.GetAllAvailableItemData();
        .initMusicData = val_2.Item[UnityEngine.Random.Range(min:  0, max:  val_2.Count)];
        System.Predicate<System.Int32> val_6 = null;
        val_14 = val_6;
        val_6 = new System.Predicate<System.Int32>(object:  val_1, method:  System.Boolean NetworkLobby_Network_Select_Screen.<>c__DisplayClass40_0::<HostButtonClicked>b__0(int x));
        val_15 = this.musicList;
        if((val_15.FindIndex(match:  val_6)) == this.lanMusicIndex)
        {
                do
        {
            .initMusicData = val_2.Item[UnityEngine.Random.Range(min:  0, max:  val_2.Count)];
            System.Predicate<System.Int32> val_11 = null;
            val_14 = val_11;
            val_11 = new System.Predicate<System.Int32>(object:  val_1, method:  System.Boolean NetworkLobby_Network_Select_Screen.<>c__DisplayClass40_0::<HostButtonClicked>b__1(int x));
            val_15 = this.musicList;
            int val_12 = val_15.FindIndex(match:  val_11);
        }
        while(val_12 == this.lanMusicIndex);
        
        }
        
        this.lanMusicIndex = val_12;
        this.SetMusic();
        this.SetScreen(screen:  2);
    }
    public void HideAcceptDenyUIElements()
    {
        this.hostConfirmChallengeScreen.SetActive(value:  false);
        this.guestConfirmChallengeScreen.SetActive(value:  false);
        this.guestWaitingForHostScreen.SetActive(value:  false);
    }
    public void HostAcceptChallengeClicked()
    {
        GameAudio.PlayButtonSound();
        this.hostConfirmChallengeScreen.SetActive(value:  false);
        this.hostWaitForChallengerScreen.SetActive(value:  true);
        NetworkManager_Custom.stringRPCMessageId.ClientSendMsgReady();
    }
    public void HostDenyChallengeClicked()
    {
        GameAudio.PlayButtonSound();
        this.hostConfirmChallengeScreen.SetActive(value:  false);
        this.hostWaitForChallengerScreen.SetActive(value:  true);
        NetworkManager_Custom.stringRPCMessageId.ClientSendMsgNotReady();
    }
    public void TimerButtonClicked(string time)
    {
        string val_3;
        GameAudio.PlayButtonSound();
        this.hostWaitForChallengerScreen.SetActive(value:  true);
        this.hostTimeSelectScreen.SetActive(value:  false);
        if((System.String.op_Equality(a:  time, b:  "∞")) != false)
        {
                val_3 = 0;
        }
        else
        {
                val_3 = time;
        }
        
        PlayerPrefsManager.OnlinePVPTime = System.Int32.Parse(s:  val_3);
        UnityEngine.Networking.NetworkServer.Reset();
        if(this.TEST_ONLINE_MODE != false)
        {
                return;
        }
        
        if(this.hostIPHexText == null)
        {
            
        }
    
    }
    public void JoinButtonClicked()
    {
        GameAudio.PlayButtonSound();
        this.SetScreen(screen:  4);
        if(this.TEST_ONLINE_MODE == true)
        {
                return;
        }
        
        bool val_1 = NetworkDiscovery_Custom.instance.Initialize();
        this = NetworkDiscovery_Custom.instance;
        if(this.StartAsClient() != false)
        {
                return;
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "NetworkReset");
    }
    public void GuestConfirmHostButtonClicked()
    {
        UnityEngine.PlayerPrefs.SetString(key:  "LastUsedIP", value:  this.ipInputField.text);
        NetworkManager_Custom.stringRPCMessageId.networkAddress = this.ipInputField.text;
        NetworkManager_Custom.stringRPCMessageId.JoinLocalGame();
        GameAudio.PlayButtonSound();
    }
    internal void JoinMatch(HostData data)
    {
    
    }
    public void GuestAcceptChallengeClicked()
    {
        GameAudio.PlayButtonSound();
        this.guestSelectHostScreen.SetActive(value:  false);
        this.guestConfirmChallengeScreen.SetActive(value:  false);
        this.guestWaitingForHostScreen.SetActive(value:  true);
        NetworkManager_Custom.stringRPCMessageId.ClientSendMsgReady();
    }
    public void GuestDenyChallengeClicked()
    {
        GameAudio.PlayButtonSound();
        this.guestConfirmChallengeScreen.SetActive(value:  false);
        this.SetScreen(screen:  4);
        NetworkManager_Custom.stringRPCMessageId.ClientSendMsgNotReady();
    }
    public void buttonBack()
    {
        short val_3;
        GameAudio.PlayButtonSound();
        bool val_1 = this.hostAndJoin_Screen.activeSelf;
        if(val_1 != false)
        {
                val_1.LoadMainScene();
            return;
        }
        
        if((NetworkManager_Custom.stringRPCMessageId + 216) != 0)
        {
                bool val_2 = NetworkManager_Custom.stringRPCMessageId + 216.isConnected;
        }
        
        val_3 = NetworkManager_Custom.stringRPCMessageId;
        if(val_3 == 0)
        {
            goto label_12;
        }
        
        if((NetworkManager_Custom.stringRPCMessageId + 264) == 0)
        {
            goto label_13;
        }
        
        label_17:
        val_3.StopHost();
        NetworkManager_Custom.stringRPCMessageId.StopServer();
        goto label_15;
        label_12:
        val_3 = NetworkManager_Custom.stringRPCMessageId;
        if((NetworkManager_Custom.stringRPCMessageId + 264) != 0)
        {
            goto label_17;
        }
        
        label_13:
        val_3.StopClient();
        label_15:
        this.SetGameObjectsDefaultState();
    }
    private static void SetText(UnityEngine.UI.Text[] text, string value)
    {
        UnityEngine.UI.Text val_2;
        goto label_1;
        label_8:
        val_2 = text[0];
        bool val_1 = UnityEngine.Object.op_Equality(x:  val_2, y:  0);
        0 = 1;
        label_1:
        if(0 < text.Length)
        {
            goto label_8;
        }
    
    }
    public void guestWaiting()
    {
        this.guestSelectHostScreen.SetActive(value:  false);
        this.guestConfirmChallengeScreen.SetActive(value:  false);
        this.guestWaitingForHostScreen.SetActive(value:  true);
    }
    public void queryAcceptDenyChallange(string otherPlayerName, long otherWins, int otherDraws, int otherLosses)
    {
        UnityEngine.UI.Text val_4;
        goto label_1;
        label_5:
        val_4 = this.challengerUserNameTexts[0];
        0 = 1;
        label_1:
        if(0 < this.challengerUserNameTexts.Length)
        {
            goto label_5;
        }
        
        PlayerPrefsManager.Player2Name = otherPlayerName;
        NetworkLobby_Network_Select_Screen.SetText(text:  this.TheirWins, value:  otherWins.ToString());
        NetworkLobby_Network_Select_Screen.SetText(text:  this.TheirDraws, value:  otherDraws.ToString());
        NetworkLobby_Network_Select_Screen.SetText(text:  this.TheirLosses, value:  otherLosses.ToString());
        if((NetworkManager_Custom.stringRPCMessageId + 264) == 0)
        {
            goto label_7;
        }
        
        this.hostTimeSelectScreen.SetActive(value:  false);
        this.hostWaitForChallengerScreen.SetActive(value:  false);
        if(this.hostConfirmChallengeScreen != null)
        {
            goto label_13;
        }
        
        label_14:
        label_13:
        this.hostConfirmChallengeScreen.SetActive(value:  true);
        return;
        label_7:
        this.guestWaitingForHostScreen.SetActive(value:  false);
        this.guestSelectHostScreen.SetActive(value:  false);
        if(this.guestConfirmChallengeScreen != null)
        {
            goto label_13;
        }
        
        goto label_14;
    }
    public void ButtonClicked()
    {
        GameAudio.PlayButtonSound();
    }
    private void SetGameObjectsDefaultState()
    {
        this.hostTimeSelectScreen.SetActive(value:  false);
        this.hostWaitForChallengerScreen.SetActive(value:  false);
        this.hostConfirmChallengeScreen.SetActive(value:  false);
        this.guestSelectHostScreen.SetActive(value:  false);
        this.guestWaitingForHostScreen.SetActive(value:  false);
        this.guestConfirmChallengeScreen.SetActive(value:  false);
        this.SetScreen(screen:  1);
    }
    public void LoadMainScene()
    {
        GameAudio.PlayButtonSound();
        NetworkLobby_EndGameReset.SwitchTo(nextScene:  "Menu_Title_Screen");
    }
    public void SkipToCharacterSelect()
    {
        bool val_1 = NetworkManager_Custom.stringRPCMessageId.StartCharacterSelectScreen();
    }
    public void SetNetworkIP(string s)
    {
        NetworkManager_Custom.stringRPCMessageId.setIP(ip:  s);
    }
    private void Update()
    {
        if((UnityEngine.Input.GetKeyUp(key:  30)) == false)
        {
                return;
        }
        
        this.SetScreen(screen:  4);
    }
    private void OnApplicationFocus(bool focus)
    {
        bool val_3 = focus;
        if(val_3 == false)
        {
                return;
        }
        
        val_3 = NetworkDiscovery_Custom.instance;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = NetworkDiscovery_Custom.instance;
        if(val_3.running == false)
        {
                return;
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "NetworkReset");
    }
    public void StartAdvancedTutorial()
    {
        NetworkLobby_EndGameReset.ForceShutdown();
        TutorialDataManager.LoadTutorial(advanced:  true, nextScene:  "NetworkReset", showLoadingScreen:  true, preload:  false);
    }
    public NetworkLobby_Network_Select_Screen()
    {
    
    }

}
