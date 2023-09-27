using UnityEngine;

namespace InkWars.Model
{
    public abstract class MVC_Multiplayer_Manager_Base : MonoBehaviour
    {
        // Fields
        private static InkWars.Model.MVC_Multiplayer_Manager_Base _instance;
        private InkWars.Model.MVC_Multiplayer_Manager_Base.MVC_Multiplayer_States _state;
        private static bool <ForceAutoStart>k__BackingField;
        public static bool fightAnyLevel;
        internal static bool HasClickedYes;
        internal static bool OtherPlayerHasClickedYes;
        internal static bool OtherPlayerHasClickedNo;
        public TMPro.TextMeshProUGUI Text_NetworkState;
        public DialogPanel DialogueManager_Hosting_Timeout;
        public MVC_GameScene_Activator template_GameSceneActivator;
        public CharacterSelectPanel selectPanel;
        public float MaximumFocusLostTime;
        public float MaximumHostTime;
        public float TimeoutAfter;
        public bool Player1Locked;
        public bool Player2Locked;
        public int CountDownTime;
        public CharacterNameID Player1;
        public CharacterNameID Player2;
        public bool ConnectionStarted;
        public float LastSeen;
        public GameMode GameMode;
        public MatchConnectivityBehaviour.Status ConnectionStatus;
        public bool IsDisconnected;
        public InkWars.Model.GameResult GameResult;
        private bool <isShuttingDown>k__BackingField;
        public UnityEngine.GameObject State_Lobby;
        public UnityEngine.GameObject State_CharacterSelect;
        public UnityEngine.GameObject State_Game;
        public UnityEngine.GameObject State_PostMatch;
        public UnityEngine.GameObject Base_Game;
        private float LastPauseTime;
        public static bool IsOfflineGame;
        private bool _isBotMatch;
        private bool _playingBotMatch;
        public static MVC_Bot_Profile BotProfile;
        public System.Action<string> OnCreatePrivateRoomAction;
        
        // Properties
        public static InkWars.Model.MVC_Multiplayer_Manager_Base Instance { get; }
        public InkWars.Model.MVC_Multiplayer_Manager_Base.MVC_Multiplayer_States State { get; set; }
        public static InkWars.Model.MVC_Multiplayer_Manager_Base.MatchStates MatchState { get; set; }
        public static bool ForceAutoStart { get; set; }
        public bool isShuttingDown { get; set; }
        public static bool IsBotMatch { get; set; }
        public static bool IsPlayingBotMatch { get; set; }
        
        // Methods
        public static InkWars.Model.MVC_Multiplayer_Manager_Base get_Instance()
        {
            var val_3;
            InkWars.Model.MVC_Multiplayer_Manager_Base val_4;
            var val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            val_4 = InkWars.Model.MVC_Multiplayer_Manager_Base._instance;
            if(val_4 == 0)
            {
                    val_5 = null;
                val_4 = UnityEngine.Object.FindObjectOfType<InkWars.Model.MVC_Multiplayer_Manager_Base>();
                val_5 = null;
                InkWars.Model.MVC_Multiplayer_Manager_Base._instance = val_4;
            }
            
            val_6 = null;
            val_6 = null;
            return (InkWars.Model.MVC_Multiplayer_Manager_Base)InkWars.Model.MVC_Multiplayer_Manager_Base._instance;
        }
        public InkWars.Model.MVC_Multiplayer_Manager_Base.MVC_Multiplayer_States get_State()
        {
            return (MVC_Multiplayer_States)this._state;
        }
        public void set_State(InkWars.Model.MVC_Multiplayer_Manager_Base.MVC_Multiplayer_States value)
        {
            string val_1 = value.ToString();
            value.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            if(this._state == value)
            {
                    UnityEngine.MonoBehaviour.print(message:  "Already " + val_1);
                return;
            }
            
            UnityEngine.MonoBehaviour.print(message:  "Setting state: "("Setting state: ") + val_1);
            this._state = null;
        }
        public static InkWars.Model.MVC_Multiplayer_Manager_Base.MatchStates get_MatchState()
        {
            return UnityEngine.PlayerPrefs.GetInt(key:  "MATCHSTATEKEY", defaultValue:  0);
        }
        public static void set_MatchState(InkWars.Model.MVC_Multiplayer_Manager_Base.MatchStates value)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  "MATCHSTATEKEY", value:  value);
            UnityEngine.PlayerPrefs.Save();
        }
        public static bool get_ForceAutoStart()
        {
            null = null;
            return (bool)InkWars.Model.MVC_Multiplayer_Manager_Base.<ForceAutoStart>k__BackingField;
        }
        public static void set_ForceAutoStart(bool value)
        {
            null = null;
            InkWars.Model.MVC_Multiplayer_Manager_Base.<ForceAutoStart>k__BackingField = value;
        }
        public bool get_isShuttingDown()
        {
            return (bool)this.<isShuttingDown>k__BackingField;
        }
        protected void set_isShuttingDown(bool value)
        {
            this.<isShuttingDown>k__BackingField = value;
        }
        public abstract void OnReceivedPlayerData(NetworkUserInfo sharedPlayerData); // 0
        public abstract void SetState(InkWars.Model.MVC_Multiplayer_Manager_Base.MVC_Multiplayer_States state); // 0
        public static bool get_IsBotMatch()
        {
            var val_3;
            InkWars.Model.MVC_Multiplayer_Manager_Base val_4;
            var val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            val_4 = InkWars.Model.MVC_Multiplayer_Manager_Base._instance;
            if(val_4 == 0)
            {
                    val_5 = 0;
                return (bool)(InkWars.Model.MVC_Multiplayer_Manager_Base._instance._isBotMatch == true) ? 1 : 0;
            }
            
            val_6 = null;
            val_6 = null;
            val_4 = InkWars.Model.MVC_Multiplayer_Manager_Base._instance;
            return (bool)(InkWars.Model.MVC_Multiplayer_Manager_Base._instance._isBotMatch == true) ? 1 : 0;
        }
        public static void set_IsBotMatch(bool value)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(InkWars.Model.MVC_Multiplayer_Manager_Base._instance == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            InkWars.Model.MVC_Multiplayer_Manager_Base._instance._isBotMatch = value;
        }
        public static bool get_IsPlayingBotMatch()
        {
            var val_3;
            InkWars.Model.MVC_Multiplayer_Manager_Base val_4;
            var val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            val_4 = InkWars.Model.MVC_Multiplayer_Manager_Base._instance;
            if(val_4 == 0)
            {
                    val_5 = 0;
                return (bool)(InkWars.Model.MVC_Multiplayer_Manager_Base._instance._playingBotMatch == true) ? 1 : 0;
            }
            
            val_6 = null;
            val_6 = null;
            val_4 = InkWars.Model.MVC_Multiplayer_Manager_Base._instance;
            return (bool)(InkWars.Model.MVC_Multiplayer_Manager_Base._instance._playingBotMatch == true) ? 1 : 0;
        }
        public static void set_IsPlayingBotMatch(bool value)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(InkWars.Model.MVC_Multiplayer_Manager_Base._instance == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            InkWars.Model.MVC_Multiplayer_Manager_Base._instance._playingBotMatch = value;
        }
        public void StartLocalGame()
        {
            var val_3 = null;
            if(InkWars.Model.MVC_Multiplayer_Manager_Base.IsOfflineGame != false)
            {
                    return;
            }
            
            InkWars.Model.MVC_Multiplayer_Manager_Base.IsOfflineGame = true;
            InkWars.Model.MVCNetworkManager.Instance.gameObject.SetActive(value:  false);
            this.State = 1;
        }
        protected virtual void Awake()
        {
            var val_1;
            var val_2;
            this.State = 0;
            val_1 = null;
            val_1 = null;
            InkWars.Model.MVC_Multiplayer_Manager_Base.IsOfflineGame = false;
            InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch = false;
            InkWars.Model.MVC_Multiplayer_Manager_Base.IsPlayingBotMatch = false;
            val_2 = null;
            val_2 = null;
            this.GameMode = Character_GlobalInfo.gameMode;
        }
        internal void ShutdownNetwork(bool forceAutoStart, bool couldBeRageQuit, bool reloadScene = True, float delay = 0, bool notifyUser = True)
        {
            InkWars.Model.MVC_Multiplayer_Manager_Base.ForceAutoStart = forceAutoStart;
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.ShutdownNetworkCoroutine(couldBeRageQuit:  couldBeRageQuit, reloadScene:  reloadScene, delay:  delay, notifyUser:  notifyUser));
        }
        internal abstract void OnCreatePrivateRoom(string randomPin); // 0
        internal System.Collections.IEnumerator ShutdownNetworkCoroutine(bool couldBeRageQuit, bool reloadScene, float delay = 0, bool notifyUser = True)
        {
            MVC_Multiplayer_Manager_Base.<ShutdownNetworkCoroutine>d__65 val_1 = new MVC_Multiplayer_Manager_Base.<ShutdownNetworkCoroutine>d__65();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .<>4__this = this;
                .couldBeRageQuit = couldBeRageQuit;
                .reloadScene = reloadScene;
                .delay = delay;
            }
            else
            {
                    mem[32] = this;
                mem[48] = couldBeRageQuit;
                .reloadScene = reloadScene;
                .delay = delay;
            }
            
            .notifyUser = notifyUser;
            return (System.Collections.IEnumerator)val_1;
        }
        internal virtual void PrepareBot()
        {
        
        }
        public void ReloadNetworkLobbyScene(int rounds = 0)
        {
            MVC_Multiplayer_Manager_Base.<>c__DisplayClass67_0 val_1 = new MVC_Multiplayer_Manager_Base.<>c__DisplayClass67_0();
            if(val_1 != null)
            {
                    .rounds = rounds;
            }
            else
            {
                    mem[16] = rounds;
            }
            
            .<>4__this = this;
            MMOCUser.current.GetUserProfile(onGetUserProfileDone:  new UnityEngine.Events.UnityAction<MMOCUserProfile>(object:  val_1, method:  System.Void MVC_Multiplayer_Manager_Base.<>c__DisplayClass67_0::<ReloadNetworkLobbyScene>b__0(MMOCClientUser.MMOCUserProfile profile)));
        }
        public void PrintState(string state, bool showLog = True)
        {
            string val_1 = LanguageManager.GetText(key:  state);
            LobbyStatus.Status = val_1;
            if((UnityEngine.Object.op_Implicit(exists:  this.Text_NetworkState)) == true)
            {
                goto label_3;
            }
            
            if(showLog == false)
            {
                    return;
            }
            
            label_6:
            UnityEngine.MonoBehaviour.print(message:  val_1);
            return;
            label_3:
            this = this.Text_NetworkState;
            this.text = val_1;
            if(showLog == true)
            {
                goto label_6;
            }
        
        }
        public void StartAutoPlayGame(bool SecondAttempt)
        {
            var val_4;
            if(ExpressShellPurchaseCanvas.IsNoShellAndShowExpressPurchase() != false)
            {
                    return;
            }
            
            InkWars.Model.MVCNetworkManager val_2 = InkWars.Model.MVCNetworkManager.Instance;
            if(SecondAttempt == false)
            {
                goto label_4;
            }
            
            val_4 = 1;
            if(val_2 != null)
            {
                goto label_7;
            }
            
            goto label_6;
            label_4:
            if(val_2 != null)
            {
                goto label_7;
            }
            
            label_6:
            label_7:
            val_2.StartAutoPlayGame(anySkill:  (MVC_Bot_Base.NetworkControlMode != 0) ? 1 : 0, hostingPrivateMatch:  false, privateMatchPin:  0);
        }
        public void BackToLobby()
        {
            null = null;
            InkWars.Model.MVC_Multiplayer_Manager_Base.fightAnyLevel = false;
            this.ShutdownNetwork(forceAutoStart:  false, couldBeRageQuit:  false, reloadScene:  false, delay:  0f, notifyUser:  true);
            this.ConnectionStatus = 0;
        }
        private void OnApplicationPause(bool paused)
        {
            var val_7;
            if(paused != false)
            {
                    this.LastPauseTime = UnityEngine.Time.realtimeSinceStartup;
                return;
            }
            
            if(InkWars.Model.MVC_Multiplayer_Manager_Base.MatchState != 1)
            {
                    val_7 = null;
                if(InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch == false)
            {
                    return;
            }
            
                if(this._state != 1)
            {
                    return;
            }
            
            }
            
            float val_4 = UnityEngine.Time.realtimeSinceStartup;
            val_4 = val_4 - this.LastPauseTime;
            if(val_4 < this.MaximumFocusLostTime)
            {
                    return;
            }
            
            NFUser.current.clientUser.StopSocketIo();
            this.<isShuttingDown>k__BackingField = false;
            this.ShutdownNetwork(forceAutoStart:  false, couldBeRageQuit:  true, reloadScene:  true, delay:  0f, notifyUser:  true);
        }
        public virtual System.Collections.IEnumerator Start()
        {
            .<>1__state = 0;
            return (System.Collections.IEnumerator)new MVC_Multiplayer_Manager_Base.<Start>d__72();
        }
        public virtual void Update()
        {
            var val_11;
            float val_12;
            var val_13;
            float val_14;
            float val_16;
            var val_17;
            var val_18;
            val_11 = this;
            InkWars.Model.MVCNetworkManager val_1 = InkWars.Model.MVCNetworkManager.Instance;
            val_12 = val_1.joinMatchTimeout;
            if(val_12 > 0f)
            {
                    object[] val_2 = new object[1];
                InkWars.Model.MVCNetworkManager val_3 = InkWars.Model.MVCNetworkManager.Instance;
                val_2[0] = UnityEngine.Mathf.FloorToInt(f:  val_3.joinMatchTimeout);
                this.PrintState(state:  LanguageManager.GetTextFormat(key:  "LK.Lobby.StatusMsg3", list:  val_2), showLog:  true);
                val_13 = InkWars.Model.MVCNetworkManager.Instance;
                if(val_13 != null)
            {
                    val_14 = val_6.joinMatchTimeout;
                val_16 = UnityEngine.Time.deltaTime;
            }
            else
            {
                    val_13 = 56;
                val_14 = 5.877482E-39f;
                float val_8 = UnityEngine.Time.deltaTime;
                val_16 = val_8;
            }
            
                val_8 = val_14 - val_16;
                mem[56] = val_8;
                InkWars.Model.MVCNetworkManager val_9 = InkWars.Model.MVCNetworkManager.Instance;
                val_12 = val_9.joinMatchTimeout;
                if(val_12 <= 0f)
            {
                    val_12 = 0f;
                this.ConnectionStatus = 4;
                this.ShutdownNetwork(forceAutoStart:  true, couldBeRageQuit:  false, reloadScene:  true, delay:  val_12, notifyUser:  true);
            }
            
            }
            
            if(this.ConnectionStarted == false)
            {
                    return;
            }
            
            val_16 = this.LastSeen;
            float val_10 = UnityEngine.Time.deltaTime;
            val_10 = val_16 - val_10;
            this.LastSeen = val_10;
            if(val_10 >= 0)
            {
                    return;
            }
            
            if(this.ConnectionStatus == 1)
            {
                    return;
            }
            
            this.ConnectionStatus = 1;
            if(this.GameResult != 0)
            {
                    val_11 = 1152921505064992768;
                val_17 = null;
                val_17 = null;
                if(Character_GlobalInfo.gameMode == 10)
            {
                    return;
            }
            
                val_11 = 1152921505156632576;
                val_18 = null;
                val_18 = null;
                InkWars.Model.MVC_Multiplayer_Manager_Base.OtherPlayerHasClickedNo = true;
                return;
            }
            
            MatchConnectivityBehaviour.Setup(_status:  1, _duration:  -1f);
            this.ShutdownNetwork(forceAutoStart:  false, couldBeRageQuit:  false, reloadScene:  true, delay:  10f, notifyUser:  true);
        }
        protected virtual void OnEnable()
        {
            this.LastSeen = this.TimeoutAfter;
            this.selectPanel.OnCharacterChanged.AddListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  System.Void InkWars.Model.MVC_Multiplayer_Manager_Base::OnLocalPlayerSelected(CharacterNameID cid)));
            InkWars.Model.Model_Events.Instance.add_OnMessageReceived(value:  new Model_Events.ControllerNetworkMessageDelegate(object:  this, method:  System.Void InkWars.Model.MVC_Multiplayer_Manager_Base::OnMessageReceived(InkWars.Model.Controller_Network_Message message)));
            InkWars.Model.Model_Events.Instance.add_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void InkWars.Model.MVC_Multiplayer_Manager_Base::OnGameResult(InkWars.Model.GameResult result, bool afterFinished)));
        }
        protected virtual void OnDisable()
        {
            this.selectPanel.OnCharacterChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  System.Void InkWars.Model.MVC_Multiplayer_Manager_Base::OnLocalPlayerSelected(CharacterNameID cid)));
            if(InkWars.Model.Model_Events.Instance == 0)
            {
                    return;
            }
            
            InkWars.Model.Model_Events.Instance.remove_OnMessageReceived(value:  new Model_Events.ControllerNetworkMessageDelegate(object:  this, method:  System.Void InkWars.Model.MVC_Multiplayer_Manager_Base::OnMessageReceived(InkWars.Model.Controller_Network_Message message)));
        }
        private void OnMessageReceived(InkWars.Model.Controller_Network_Message message)
        {
            if(message != 9)
            {
                    return;
            }
            
            GameOverPanel.BackToTitle_Finish();
        }
        private void OnGameResult(InkWars.Model.GameResult result, bool afterFinished)
        {
            if(afterFinished != false)
            {
                    return;
            }
            
            this.GameResult = result;
            InkWars.Model.MVC_Multiplayer_Manager_Base.MatchState = 0;
        }
        private void OnLocalPlayerSelected(CharacterNameID cid)
        {
            var val_2;
            GameMode val_3;
            var val_4;
            var val_5;
            this.Player1 = cid;
            val_2 = null;
            val_2 = null;
            val_3 = Character_GlobalInfo.gameMode;
            if(val_3 != 6)
            {
                    val_3 = Character_GlobalInfo.gameMode;
                if(val_3 != 10)
            {
                    return;
            }
            
            }
            
            val_4 = null;
            if(InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch != false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            InkWars.Model.Controller_Network_NF.ThisPlayer.CharacterNameID = this.Player1;
        }
        public void OnLocalPlayerLocked()
        {
            var val_10;
            GameMode val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_10 = null;
            val_10 = null;
            val_11 = Character_GlobalInfo.gameMode;
            if(val_11 == 6)
            {
                goto label_3;
            }
            
            val_11 = Character_GlobalInfo.gameMode;
            if(val_11 != 10)
            {
                goto label_6;
            }
            
            label_3:
            val_12 = null;
            if(InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch == false)
            {
                goto label_9;
            }
            
            label_6:
            val_13 = null;
            if(InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch != false)
            {
                    val_14 = null;
                val_14 = null;
                CharacterNameID val_3 = InkWars.Model.MVC_Multiplayer_Manager_Base.BotProfile.SelectCharacter();
                Character_GlobalInfo.SetRightPlayer(nameID:  val_3);
                InkWars.Model.MVC_Multiplayer_Manager_Base val_4 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
                val_4.Player2 = val_3;
            }
            
            this.Player1Locked = true;
            this.Player2Locked = true;
            goto typeof(InkWars.Model.MVC_Multiplayer_Manager_Base).__il2cppRuntimeField_1F8;
            label_9:
            val_15 = null;
            val_15 = null;
            InkWars.Model.Controller_Network_NF.ThisPlayer.CharacterLocked = true;
        }
        public virtual void RefreshCharacterData()
        {
            if(this.Player1Locked == false)
            {
                    return;
            }
            
            if(this.Player2Locked == false)
            {
                    return;
            }
            
            this.ShutVSGateAndStartGame();
        }
        public void ShutVSGateAndStartGame()
        {
            var val_4;
            MVC_GameScene_Activator val_1 = UnityEngine.Object.Instantiate<MVC_GameScene_Activator>(original:  this.template_GameSceneActivator);
            val_4 = null;
            val_4 = null;
            if((MVC_Multiplayer_Manager_Base.<>c.<>9__81_1) == null)
            {
                goto label_5;
            }
            
            label_10:
            val_1.TriggerLoading(ShowBattleGates:  true, onCloseDone:  new System.Action(object:  this, method:  System.Void InkWars.Model.MVC_Multiplayer_Manager_Base::<ShutVSGateAndStartGame>b__81_0()), onOpenDone:  MVC_Multiplayer_Manager_Base.<>c.<>9__81_1);
            return;
            label_5:
            MVC_Multiplayer_Manager_Base.<>c.<>9__81_1 = new System.Action(object:  MVC_Multiplayer_Manager_Base.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MVC_Multiplayer_Manager_Base.<>c::<ShutVSGateAndStartGame>b__81_1());
            if(val_1 != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        protected void SetRandomGameDuration()
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            int val_1 = UnityEngine.Random.Range(min:  1, max:  InkWars.Model.Model_Constants.GameDurationOptions.Length);
            System.Int32[] val_2 = InkWars.Model.Model_Constants.GameDurationOptions + (((long)(int)(val_1)) << 2);
            InkWars.Model.Controller_Network_NF val_3 = InkWars.Model.Controller_Network_NF.Instance;
            if(val_3.IsHost == false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            InkWars.Model.Controller_Network_NF.ThisPlayer.GameDuration = (InkWars.Model.Model_Constants.GameDurationOptions + ((long)(int)(val_1)) << 2) + 32;
        }
        protected MVC_Multiplayer_Manager_Base()
        {
            this.MaximumFocusLostTime = 5f;
            this.MaximumHostTime = 10f;
            this.TimeoutAfter = 5f;
            this.CountDownTime = 0;
        }
        private static MVC_Multiplayer_Manager_Base()
        {
        
        }
        private void <ShutdownNetworkCoroutine>b__65_0(IResponse res)
        {
            CryptoCurrency.RemoveUserCurrencyChangeEvent();
            this.ReloadNetworkLobbyScene(rounds:  0);
        }
        private void <ShutVSGateAndStartGame>b__81_0()
        {
            UnityEngine.Debug.Log(message:  "==== On Close done");
            this.State = 2;
        }
    
    }

}
