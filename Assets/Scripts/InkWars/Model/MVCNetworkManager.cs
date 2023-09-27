using UnityEngine;

namespace InkWars.Model
{
    public class MVCNetworkManager : MonoBehaviour
    {
        // Fields
        private static InkWars.Model.MVCNetworkManager _instance;
        private const int IDEAL_PP_DELTA = 100;
        private const int domain = 1;
        private const int MinPin = 1000;
        private const int MaxPin = 9999;
        private const int MATCH_COUNT_PER_ROOM = 100;
        private const string AttributeKey_CountdownTimer = "CountdownTimer";
        private const string AttributeKey_PP = "PP";
        private const string AttributeKey_Private = "Private";
        private const string AttributeKey_SecondAttempt = "SecondAttempt";
        public static CMS.Events.UnityEvent_Bool OnMatchButtonInteractableChange;
        public ulong thisNetworkID;
        public bool autoplayStarted;
        public bool gameStarted;
        public float privateWager;
        public string PrivateMatchPin;
        private bool <HostPrivateMatch>k__BackingField;
        public float hostMatchTimeout;
        public float joinMatchTimeout;
        private bool _isTryingToJoin;
        private bool keepCheckingRoomStatus;
        private UnityEngine.Coroutine checkRoomStatusCoroutine;
        private bool isMatchDestroyed;
        private bool AnySkill;
        private bool matchesListed;
        private bool botIsHunting;
        private string bot_lastNetworkID;
        private int bot_lastNetworkIDCount;
        private int bot_failCount;
        private float connectionStartTime;
        
        // Properties
        public static InkWars.Model.MVCNetworkManager Instance { get; }
        public bool HostPrivateMatch { get; set; }
        public bool JoinPrivateMatch { get; }
        public bool IsTryingToJoin { get; set; }
        
        // Methods
        public static InkWars.Model.MVCNetworkManager get_Instance()
        {
            var val_3;
            string val_4;
            var val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            val_4 = InkWars.Model.MVCNetworkManager.AttributeKey_SecondAttempt;
            if(val_4 == 0)
            {
                    val_5 = null;
                val_4 = UnityEngine.Object.FindObjectOfType<InkWars.Model.MVCNetworkManager>();
                val_5 = null;
                InkWars.Model.MVCNetworkManager.AttributeKey_SecondAttempt = val_4;
            }
            
            val_6 = null;
            val_6 = null;
            return (InkWars.Model.MVCNetworkManager)InkWars.Model.MVCNetworkManager.AttributeKey_SecondAttempt;
        }
        private void set_HostPrivateMatch(bool value)
        {
            this.<HostPrivateMatch>k__BackingField = value;
        }
        public bool get_HostPrivateMatch()
        {
            return (bool)this.<HostPrivateMatch>k__BackingField;
        }
        public bool get_JoinPrivateMatch()
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  this.PrivateMatchPin);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public bool get_IsTryingToJoin()
        {
            return (bool)this._isTryingToJoin;
        }
        private void set_IsTryingToJoin(bool value)
        {
            this._isTryingToJoin = value;
            this.keepCheckingRoomStatus = false;
            if(this.checkRoomStatusCoroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.checkRoomStatusCoroutine);
        }
        private void Awake()
        {
            this.connectionStartTime = UnityEngine.Time.time;
        }
        private void AttachSocketStartListener()
        {
            NFClientUser val_2 = NFUser.current.clientUser;
            val_2.OnStartMsgReceivedEvent.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void InkWars.Model.MVCNetworkManager::_start(string startMsg)));
        }
        private void OnDisable()
        {
            NFClientUser val_2 = NFUser.current.clientUser;
            val_2.OnStartMsgReceivedEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void InkWars.Model.MVCNetworkManager::_start(string startMsg)));
        }
        private void _start(string startMsg)
        {
            InkWars.Model.Controller_Network_NF.Instance.SendPlayerData(onlyUpdateData:  false);
        }
        private void OnTournamentRoomJoined(IResponse responseData)
        {
            object val_6;
            this.PrivateMatchPin = 0;
            if((System.String.op_Equality(a:  responseData.msg.ToLower().Trim(), b:  "you are host")) != false)
            {
                    InkWars.Model.Controller_Network_NF val_4 = InkWars.Model.Controller_Network_NF.Instance;
                val_4.IsHost = true;
                val_6 = "Is host";
            }
            else
            {
                    val_6 = "Is Client";
            }
            
            UnityEngine.MonoBehaviour.print(message:  val_6);
            InkWars.Model.Controller_Network_NF.Instance.SendPlayerData(onlyUpdateData:  false);
        }
        internal void StartAutoPlayGame(bool anySkill, bool hostingPrivateMatch = False, string privateMatchPin)
        {
            null = null;
            InkWars.Model.MVCNetworkManager.OnMatchButtonInteractableChange.Invoke(arg0:  false);
            if(this.autoplayStarted != false)
            {
                    UnityEngine.Debug.Log(message:  "autoplayStarted");
                InkWars.Model.MVC_Multiplayer_Manager_Base val_1 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
                val_1.ConnectionStatus = 4;
                InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.PrintState(state:  "LK.Lobby.StatusMsg1", showLog:  true);
                InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.ShutdownNetwork(forceAutoStart:  true, couldBeRageQuit:  false, reloadScene:  true, delay:  0f, notifyUser:  true);
                return;
            }
            
            this.PrivateMatchPin = privateMatchPin;
            this.AnySkill = anySkill;
            this.<HostPrivateMatch>k__BackingField = hostingPrivateMatch;
            this.autoplayStarted = true;
            UnityEngine.Debug.Log(message:  "FindMatchCoroutine");
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.FindMatchCoroutine());
        }
        public System.Collections.IEnumerator FindMatchCoroutine()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new MVCNetworkManager.<FindMatchCoroutine>d__36();
        }
        private void TryLeaveRoomThenAction(System.Action callback)
        {
            .callback = callback;
            if(NFUser.current.clientUser.currentRoom != null)
            {
                    NFUser.current.clientUser.LeaveRoom(callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  new MVCNetworkManager.<>c__DisplayClass37_0(), method:  System.Void MVCNetworkManager.<>c__DisplayClass37_0::<TryLeaveRoomThenAction>b__0(IResponse deleteRoomResponse)));
                return;
            }
            
            if(((MVCNetworkManager.<>c__DisplayClass37_0)[1152921529305630576].callback) == null)
            {
                    return;
            }
            
            (MVCNetworkManager.<>c__DisplayClass37_0)[1152921529305630576].callback.Invoke();
        }
        private System.Collections.IEnumerator CheckRoomStatus(System.Action actionOnRoomDelete)
        {
            MVCNetworkManager.<CheckRoomStatus>d__40 val_1 = new MVCNetworkManager.<CheckRoomStatus>d__40();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .actionOnRoomDelete = actionOnRoomDelete;
            return (System.Collections.IEnumerator)val_1;
        }
        public void StartCheckingRoomStatus()
        {
            this.checkRoomStatusCoroutine = this.StartCoroutine(routine:  this.CheckRoomStatus(actionOnRoomDelete:  new System.Action(object:  this, method:  System.Void InkWars.Model.MVCNetworkManager::<StartCheckingRoomStatus>b__41_0())));
            this.keepCheckingRoomStatus = true;
        }
        public void StopCheckingRoomStatus()
        {
            this.keepCheckingRoomStatus = false;
            if(this.checkRoomStatusCoroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.checkRoomStatusCoroutine);
        }
        private void JoinNFRoom(NFClientUser.Room room)
        {
            this._isTryingToJoin = true;
            this.keepCheckingRoomStatus = false;
            if(this.checkRoomStatusCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.checkRoomStatusCoroutine);
            }
            
            NFUser.current.clientUser.JoinRoom(matchID:  room.matchID, callback:  new UnityEngine.Events.UnityAction<NFResponseRoom>(object:  this, method:  System.Void InkWars.Model.MVCNetworkManager::<JoinNFRoom>b__43_0(NFClientUser.NFResponseRoom joinRoomResponse)));
        }
        private NFClientUser.Room FindBestFitRoom()
        {
            var val_5;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            int val_31;
            var val_32;
            int val_34;
            NFClientUser val_2 = NFUser.current.clientUser;
            List.Enumerator<T> val_3 = val_2.returnedRoomList.GetEnumerator();
            val_27 = 1152921505064992768;
            val_28 = 0;
            val_29 = 0;
            goto label_34;
            label_38:
            val_30 = val_5.InitialType;
            val_31 = 0;
            if((System.String.op_Equality(a:  NFUser.current.clientUser.User, b:  0)) == true)
            {
                goto label_12;
            }
            
            if(X24 == 0)
            {
                goto label_34;
            }
            
            var val_12 = ((X24 + 20) != 0) ? 1 : 0;
            val_12 = val_12 ^ (System.String.IsNullOrEmpty(value:  this.PrivateMatchPin));
            if(val_12 == false)
            {
                goto label_34;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.PrivateMatchPin)) == false)
            {
                goto label_15;
            }
            
            val_32 = null;
            val_32 = null;
            if(Character_GlobalInfo.gameMode != 6)
            {
                goto label_34;
            }
            
            var val_14 = (Character_GlobalInfo.isCryptoMMOCMode == true) ? 1 : 0;
            val_14 = val_14 ^ (((X24 + 33) != 0) ? 1 : 0);
            if((val_14 & 1) != 0)
            {
                goto label_34;
            }
            
            if(val_17.m_currency != 2)
            {
                goto label_23;
            }
            
            val_31 = mem[X24 + 36];
            val_31 = X24 + 36;
            val_34 = mem[X24 + 44];
            val_34 = X24 + 44;
            val_34 = val_34;
            val_31 = val_31;
            val_27 = 1152921505064992768;
            if((System.Decimal.op_Inequality(d1:  new System.Decimal() {flags = val_17.m_wager, hi = val_17.m_wager, lo = PublicWagerData.GetDataByLevel(level:  PublicWagerData.selectedWagerLevel), mid = PublicWagerData.GetDataByLevel(level:  PublicWagerData.selectedWagerLevel)}, d2:  new System.Decimal() {flags = val_31, hi = val_31, lo = val_34, mid = val_34})) == true)
            {
                goto label_34;
            }
            
            label_23:
            NetworkUserInfo val_19 = DataStructs.UserDataDictionary.ToNetworkUserInfo();
            int val_21 = UnityEngine.Mathf.Abs(value:  val_19.playerPoint - (X24 + 16));
            val_27 = 1152921505064992768;
            if(this.AnySkill == false)
            {
                goto label_32;
            }
            
            label_37:
            var val_22 = (val_29 == 0) ? 1 : 0;
            val_22 = val_22 | ((val_21 < val_28) ? 1 : 0);
            var val_24 = (val_22 != 0) ? (val_21) : (val_28);
            var val_25 = (val_22 != 0) ? (val_30) : (val_29);
            goto label_34;
            label_15:
            val_31 = 0;
            if((System.String.op_Equality(a:  this.PrivateMatchPin, b:  X24 + 24)) == false)
            {
                goto label_34;
            }
            
            goto label_39;
            label_32:
            if((val_21 < 101) || ((X24 + 32) != 0))
            {
                goto label_37;
            }
            
            label_34:
            if(((-1070313664) & 1) != 0)
            {
                goto label_38;
            }
            
            val_30 = val_29;
            goto label_39;
            label_12:
            UnityEngine.Debug.LogError(message:  "Find best fit room fail: User already in a room");
            val_30 = 0;
            label_39:
            val_5.Add(driver:  public System.Void List.Enumerator<Room>::Dispose(), rectTransform:  val_31, drivenProperties:  null);
            return (Room)val_30;
        }
        private void StartHostPrivateRoom()
        {
            var val_9;
            System.Collections.Generic.List<Room> val_20;
            .<>4__this = this;
            System.Collections.Generic.HashSet<System.String> val_2 = new System.Collections.Generic.HashSet<System.String>();
            do
            {
                bool val_4 = val_2.Add(item:  1.ToString());
            }
            while(2 < 10000);
            
            NFClientUser val_6 = NFUser.current.clientUser;
            val_20 = val_6.returnedRoomList;
            List.Enumerator<T> val_7 = val_20.GetEnumerator();
            label_14:
            if(((-1070099120) & 1) == 0)
            {
                goto label_9;
            }
            
            System.Type val_10 = val_9.InitialType;
            if((val_10 == null) || ((System.String.IsNullOrEmpty(value:  0)) == true))
            {
                goto label_14;
            }
            
            bool val_12 = val_2.Remove(item:  val_10);
            goto label_14;
            label_9:
            val_9.Add(driver:  public System.Void List.Enumerator<Room>::Dispose(), rectTransform:  public System.Boolean System.Collections.Generic.HashSet<System.String>::Add(System.String item), drivenProperties:  null);
            if(val_2.Count != 0)
            {
                    System.Collections.Generic.List<System.String> val_14 = null;
                val_20 = val_14;
                val_14 = new System.Collections.Generic.List<System.String>(collection:  val_2);
                .randomPin = val_14.Item[UnityEngine.Random.Range(min:  0, max:  val_14.Count)];
                System.Action val_18 = new System.Action(object:  new MVCNetworkManager.<>c__DisplayClass45_0(), method:  System.Void MVCNetworkManager.<>c__DisplayClass45_0::<StartHostPrivateRoom>b__0());
                val_18.TryLeaveRoomThenAction(callback:  val_18);
                return;
            }
            
            DialogPanel val_19 = DialogManager.Show(title:  "LK.Error", message:  "LK.CreateRoomFail", cancelButtonTitle:  0, onCancelCallback:  0);
        }
        private void CreatePublicRoom()
        {
            int val_14;
            bool val_15;
            var val_16;
            decimal val_18;
            var val_19;
            InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.PrintState(state:  "LK.Lobby.StatusMsg4", showLog:  true);
            InkWars.Model.MVC_Multiplayer_Manager_Base val_2 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            NFClientUser.RoomExtraData val_3 = new NFClientUser.RoomExtraData();
            NetworkUserInfo val_4 = DataStructs.UserDataDictionary.ToNetworkUserInfo();
            if(val_3 != null)
            {
                    val_14 = val_3;
                .PlayerPoints = val_4.playerPoint;
                mem[1152921529306815556] = 0;
                mem[1152921529306815560] = 0;
                val_15 = this.AnySkill;
            }
            else
            {
                    val_14 = 16;
                mem[16] = val_4.playerPoint;
                .IsPrivateRoom = false;
                mem[24] = 0;
                val_15 = this.AnySkill;
            }
            
            .AnySkill = val_15;
            object[] val_5 = new object[2];
            val_5[0] = (NFClientUser.RoomExtraData)[1152921529306815536].AnySkill;
            val_5[1] = val_14;
            UnityEngine.Debug.LogFormat(format:  "Create public room: AnySkill {0}, PP: {1}", args:  val_5);
            InkWars.Model.Controller_Network_NF val_6 = InkWars.Model.Controller_Network_NF.Instance;
            val_6.IsHost = true;
            val_16 = null;
            val_16 = null;
            if((Character_GlobalInfo.isCryptoMMOCMode != false) && (Character_GlobalInfo.gameMode == 6))
            {
                    val_18 = val_8.m_wager;
                int val_10 = MMOCUser.current.id;
                .MMOCBet = val_18;
                .IsMMOCMode = true;
                mem[1152921529306815580] = PublicWagerData.GetDataByLevel(level:  PublicWagerData.selectedWagerLevel);
            }
            else
            {
                    val_19 = 0;
                val_18 = 0;
            }
            
            NFUser.current.clientUser.CreateRoom(aNewBet:  new System.Decimal(), extraData:  val_3, callback:  new UnityEngine.Events.UnityAction<NFResponsCreateRoom>(object:  this, method:  System.Void InkWars.Model.MVCNetworkManager::<CreatePublicRoom>b__46_0(NFClientUser.NFResponsCreateRoom createRoomResponse)));
        }
        private void CreateNFPrivateRoom(string randomPin)
        {
            bool val_10;
            var val_11;
            var val_12;
            decimal val_13;
            var val_14;
            MVCNetworkManager.<>c__DisplayClass47_0 val_1 = new MVCNetworkManager.<>c__DisplayClass47_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .randomPin = randomPin;
            InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.PrintState(state:  "LK.Lobby.StatusMsg4", showLog:  true);
            object[] val_3 = new object[1];
            val_3[0] = (MVCNetworkManager.<>c__DisplayClass47_0)[1152921529307031136].randomPin;
            UnityEngine.Debug.LogFormat(format:  "Create private room with pin {0}", args:  val_3);
            NFClientUser.RoomExtraData val_4 = new NFClientUser.RoomExtraData();
            NetworkUserInfo val_5 = DataStructs.UserDataDictionary.ToNetworkUserInfo();
            if(val_4 != null)
            {
                    .PlayerPoints = val_5.playerPoint;
                .IsPrivateRoom = true;
                .PrivateRoomPin = (MVCNetworkManager.<>c__DisplayClass47_0)[1152921529307031136].randomPin;
                val_10 = this.AnySkill;
            }
            else
            {
                    mem[16] = val_5.playerPoint;
                .IsPrivateRoom = true;
                mem[24] = (MVCNetworkManager.<>c__DisplayClass47_0)[1152921529307031136].randomPin;
                val_10 = this.AnySkill;
            }
            
            .AnySkill = val_10;
            val_11 = null;
            val_11 = null;
            if(Character_GlobalInfo.isCryptoMMOCMode != false)
            {
                    val_12 = null;
                val_12 = null;
                val_13 = SetWager.privateWager;
            }
            else
            {
                    val_14 = 0;
                val_13 = 0;
            }
            
            InkWars.Model.Controller_Network_NF val_6 = InkWars.Model.Controller_Network_NF.Instance;
            val_6.IsHost = true;
            NFUser.current.clientUser.CreateRoom(aNewBet:  new System.Decimal(), extraData:  val_4, callback:  new UnityEngine.Events.UnityAction<NFResponsCreateRoom>(object:  val_1, method:  System.Void MVCNetworkManager.<>c__DisplayClass47_0::<CreateNFPrivateRoom>b__0(NFClientUser.NFResponsCreateRoom createRoomResponse)));
        }
        public MVCNetworkManager()
        {
            this.keepCheckingRoomStatus = true;
        }
        private static MVCNetworkManager()
        {
            InkWars.Model.MVCNetworkManager.OnMatchButtonInteractableChange = new CMS.Events.UnityEvent_Bool();
        }
        private void <FindMatchCoroutine>b__36_0(System.Collections.Generic.List<NFClientUser.Room> listRoomResp)
        {
            string val_16;
            var val_17;
            var val_18;
            if(listRoomResp == null)
            {
                goto label_1;
            }
            
            NFClientUser val_2 = NFUser.current.clientUser;
            UnityEngine.MonoBehaviour.print(message:  "Room count: "("Room count: ") + System.Linq.Enumerable.Count<Room>(source:  val_2.returnedRoomList)(System.Linq.Enumerable.Count<Room>(source:  val_2.returnedRoomList)));
            if((this.<HostPrivateMatch>k__BackingField) == false)
            {
                goto label_6;
            }
            
            this.StartHostPrivateRoom();
            goto label_23;
            label_1:
            DialogPanel val_5 = DialogManager.Show(title:  "Get room list failed", message:  "Room list is empty", cancelButtonTitle:  0, onCancelCallback:  0);
            InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.ShutdownNetwork(forceAutoStart:  false, couldBeRageQuit:  false, reloadScene:  true, delay:  0f, notifyUser:  true);
            goto label_23;
            label_6:
            Room val_7 = this.FindBestFitRoom();
            if(val_7 != null)
            {
                    object[] val_8 = new object[1];
                val_8[0] = UnityEngine.JsonUtility.ToJson(obj:  val_7);
                UnityEngine.Debug.LogFormat(format:  "Best Room: {0}", args:  val_8);
                val_17 = null;
                val_17 = null;
                MatchID.matchID = val_7.matchID;
                val_18 = null;
                val_18 = null;
                SetWager.privateWager = val_7.wager;
                SetWager.privateWager.__il2cppRuntimeField_8 = val_7.matchID;
                this.JoinNFRoom(room:  val_7);
            }
            else
            {
                    if((System.String.IsNullOrEmpty(value:  this.PrivateMatchPin)) != false)
            {
                    System.Action val_11 = new System.Action(object:  this, method:  System.Void InkWars.Model.MVCNetworkManager::CreatePublicRoom());
                val_11.TryLeaveRoomThenAction(callback:  val_11);
                return;
            }
            
                val_16 = LanguageManager.GetText(key:  "LK.Lobby.RoomPinIncorrect");
                DialogPanel val_15 = DialogManager.Show(title:  LanguageManager.GetText(key:  "LK.Error"), message:  val_16, cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close"), onCancelCallback:  0);
                DialogManager.HideLoading();
            }
            
            label_23:
            this.autoplayStarted = false;
        }
        private void <StartCheckingRoomStatus>b__41_0()
        {
            InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.ShutdownNetwork(forceAutoStart:  true, couldBeRageQuit:  false, reloadScene:  true, delay:  0f, notifyUser:  true);
            ActiveCanvasController.Instance.ShowPublicLobby();
            this.keepCheckingRoomStatus = false;
            if(this.checkRoomStatusCoroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.checkRoomStatusCoroutine);
        }
        private void <JoinNFRoom>b__43_0(NFClientUser.NFResponseRoom joinRoomResponse)
        {
            NFClientUser.NFResponseRoom val_14;
            object val_15;
            val_14 = joinRoomResponse;
            MVCNetworkManager.<>c__DisplayClass43_0 val_1 = null;
            val_15 = val_1;
            val_1 = new MVCNetworkManager.<>c__DisplayClass43_0();
            if(val_15 == null)
            {
                goto label_1;
            }
            
            .joinRoomResponse = val_14;
            mem[1152921529307885960] = this;
            if(val_14 != null)
            {
                goto label_28;
            }
            
            label_29:
            label_28:
            if(val_14.IsSuccess == false)
            {
                goto label_3;
            }
            
            UnityEngine.MonoBehaviour.print(message:  "Joined room");
            this.StartCheckingRoomStatus();
            val_14 = .joinRoomResponse;
            if(joinRoomResponse.poolID == 0)
            {
                goto label_9;
            }
            
            val_14 = .joinRoomResponse;
            if(joinRoomResponse.wager <= 0f)
            {
                goto label_9;
            }
            
            val_14 = mem[joinRoomResponse + 40];
            val_14 = joinRoomResponse.poolID;
            NFUser.current.mmocUser.JoinPool(poolId:  val_14, initGems:  joinRoomResponse.wager, onJoinPoolDone:  new UnityEngine.Events.UnityAction<JoinedPoolData>(object:  val_1, method:  System.Void MVCNetworkManager.<>c__DisplayClass43_0::<JoinNFRoom>b__1(MMOCClientUser.JoinedPoolData res)));
            goto label_27;
            label_3:
            this._isTryingToJoin = false;
            this.keepCheckingRoomStatus = false;
            if(this.checkRoomStatusCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.checkRoomStatusCoroutine);
            }
            
            UnityEngine.Debug.LogError(message:  "Join room fail: "("Join room fail: ") + mem[joinRoomResponse + 16](mem[joinRoomResponse + 16]));
            DialogPanel val_10 = DialogManager.Show(title:  LanguageManager.GetText(key:  "LK.Error"), message:  LanguageManager.GetText(key:  "LK.JoinRoomFail"), cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close"), onCancelCallback:  0);
            val_15 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            val_15.ShutdownNetwork(forceAutoStart:  false, couldBeRageQuit:  false, reloadScene:  true, delay:  0f, notifyUser:  true);
            goto label_27;
            label_1:
            mem[24] = this;
            mem[16] = val_14;
            if(mem[16] != 0)
            {
                goto label_28;
            }
            
            goto label_29;
            label_9:
            this.AttachSocketStartListener();
            val_15 = NFUser.current.clientUser;
            val_15.StartSocketIo();
            label_27:
            DialogManager.HideLoading();
        }
        private void <CreatePublicRoom>b__46_0(NFClientUser.NFResponsCreateRoom createRoomResponse)
        {
            NFClientUser.NFResponsCreateRoom val_14;
            MVCNetworkManager.<>c__DisplayClass46_0 val_1 = new MVCNetworkManager.<>c__DisplayClass46_0();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .createRoomResponse = createRoomResponse;
            mem[1152921529308109688] = this;
            if(createRoomResponse != null)
            {
                goto label_21;
            }
            
            label_22:
            label_21:
            if(createRoomResponse.IsSuccess == false)
            {
                goto label_3;
            }
            
            val_14 = .createRoomResponse;
            if(createRoomResponse.poolID == 0)
            {
                goto label_9;
            }
            
            val_14 = .createRoomResponse;
            if(createRoomResponse.wager <= 0f)
            {
                goto label_9;
            }
            
            NFUser.current.mmocUser.JoinPool(poolId:  createRoomResponse.poolID, initGems:  createRoomResponse.wager, onJoinPoolDone:  new UnityEngine.Events.UnityAction<JoinedPoolData>(object:  val_1, method:  System.Void MVCNetworkManager.<>c__DisplayClass46_0::<CreatePublicRoom>b__1(MMOCClientUser.JoinedPoolData res)));
            return;
            label_3:
            DialogPanel val_9 = DialogManager.Show(title:  LanguageManager.GetText(key:  "LK.Error"), message:  LanguageManager.GetText(key:  "LK.CreateRoomFail"), cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close"), onCancelCallback:  0);
            InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.ShutdownNetwork(forceAutoStart:  false, couldBeRageQuit:  false, reloadScene:  true, delay:  0f, notifyUser:  true);
            return;
            label_1:
            mem[24] = this;
            mem[16] = createRoomResponse;
            if(mem[16] != 0)
            {
                goto label_21;
            }
            
            goto label_22;
            label_9:
            this.AttachSocketStartListener();
            NFUser.current.clientUser.StartSocketIo();
            InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.PrintState(state:  "LK.Lobby.StatusMsg9", showLog:  true);
            DialogManager.HideLoading();
        }
    
    }

}
