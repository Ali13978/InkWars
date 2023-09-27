using UnityEngine;

namespace InkWars.Model
{
    public class MVC_Multiplayer_Manager_NewLobby : MVC_Multiplayer_Manager_Base
    {
        // Fields
        private const float PublicMatchTimeout_UseBot = 10;
        private float PublicMatchTimeout;
        public TMPro.TextMeshProUGUI Txt_PrivateMatchPin;
        private ChallengingAcceptCanvas m_challengeAcceptCanvas;
        private ChallengingAcceptCanvas m_challengeWaitingCanvas;
        private ChallengingAcceptCanvas m_challengeDeclineCanvas;
        private UnityEngine.GameObject m_waitingForOpponentCanvas;
        private UnityEngine.GameObject m_joinRoomCanvas;
        private MatchFoundCanvasLoader m_MatchFoundCanvas;
        private SkillType m_skillType;
        private float waitingForPublicMatch_Timeout;
        
        // Methods
        public void ClickSkillType(int type)
        {
            this.m_skillType = type;
        }
        protected override void Awake()
        {
            this.Awake();
            DialogManager.HideLoading();
            if(0 != MVC_GameScene_Activator.instance)
            {
                    UnityEngine.Object.Destroy(obj:  MVC_GameScene_Activator.instance.gameObject);
            }
            
            this.m_skillType = 1;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            InkWars.Model.Model_Events.Instance.add_OnMessageReceived(value:  new Model_Events.ControllerNetworkMessageDelegate(object:  this, method:  System.Void InkWars.Model.MVC_Multiplayer_Manager_NewLobby::OnMessageReceived(InkWars.Model.Controller_Network_Message message)));
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            InkWars.Model.Model_Events.Instance.remove_OnMessageReceived(value:  new Model_Events.ControllerNetworkMessageDelegate(object:  this, method:  System.Void InkWars.Model.MVC_Multiplayer_Manager_NewLobby::OnMessageReceived(InkWars.Model.Controller_Network_Message message)));
        }
        private void OnMessageReceived(InkWars.Model.Controller_Network_Message message)
        {
            var val_12 = this;
            if((message - 10) > 3)
            {
                    return;
            }
            
            var val_12 = 40826744 + ((message - 10)) << 2;
            val_12 = val_12 + 40826744;
            goto (40826744 + ((message - 10)) << 2 + 40826744);
        }
        public override void Update()
        {
            var val_6;
            this.Update();
            if(this.waitingForPublicMatch_Timeout <= 0f)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.waitingForPublicMatch_Timeout - val_1;
            this.waitingForPublicMatch_Timeout = val_1;
            if(val_1 > 0f)
            {
                    return;
            }
            
            InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch = true;
            val_6 = null;
            val_6 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Stats.TotalPVPWins;
            InkWars.Model.MVC_Multiplayer_Manager_Base.BotProfile = MVC_Bot_Profile.GetNextBot(wins:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited}));
            NetworkUserInfo val_5 = InkWars.Model.MVC_Multiplayer_Manager_Base.BotProfile.ToSharedPlayerData();
            goto typeof(InkWars.Model.MVC_Multiplayer_Manager_NewLobby).__il2cppRuntimeField_168;
        }
        internal override void PrepareBot()
        {
            this.waitingForPublicMatch_Timeout = 10f;
        }
        public void Click_FindMatch()
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_4 = null;
            val_4 = null;
            PostMatchCanvas.IsPublicMatch = true;
            PostMatchCanvas.IsPrivateWagerMatch = false;
            val_5 = null;
            val_5 = null;
            Character_GlobalInfo.gameMode = 6;
            decimal val_1 = CryptoCurrency.CryptoCurency;
            val_6 = null;
            val_6 = null;
            PrizesPanel.lastGGPAmount = val_1.flags;
            PrizesPanel.lastGGPAmount.__il2cppRuntimeField_3 = val_1.hi;
            PrizesPanel.lastGGPAmount.__il2cppRuntimeField_8 = val_1.lo;
            PrizesPanel.lastGGPAmount.__il2cppRuntimeField_C = val_1.mid;
            if(this.m_skillType != 0)
            {
                    val_7 = InkWars.Model.MVCNetworkManager.Instance;
                val_8 = 0;
            }
            else
            {
                    val_7 = InkWars.Model.MVCNetworkManager.Instance;
                val_8 = 1;
            }
            
            val_7.StartAutoPlayGame(anySkill:  true, hostingPrivateMatch:  false, privateMatchPin:  0);
        }
        public void Click_HostPrivateMatch()
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
            PostMatchCanvas.IsPublicMatch = Character_GlobalInfo.isCryptoMMOCMode;
            PostMatchCanvas.IsPrivateWagerMatch = Character_GlobalInfo.isCryptoMMOCMode;
            Character_GlobalInfo.gameMode = 10;
            this.Txt_PrivateMatchPin.text = LanguageManager.GetText(key:  "LK.Lobby.Status1");
            InkWars.Model.MVCNetworkManager.Instance.StartAutoPlayGame(anySkill:  false, hostingPrivateMatch:  true, privateMatchPin:  0);
            this.m_waitingForOpponentCanvas.gameObject.SetActive(value:  true);
        }
        public void Input_EnterPin(string pin)
        {
            var val_6;
            var val_7;
            val_6 = null;
            val_6 = null;
            val_7 = null;
            val_7 = null;
            PostMatchCanvas.IsPublicMatch = Character_GlobalInfo.isCryptoMMOCMode;
            PostMatchCanvas.IsPrivateWagerMatch = Character_GlobalInfo.isCryptoMMOCMode;
            Character_GlobalInfo.gameMode = 10;
            UnityEngine.Debug.Log(message:  "Entered pin : "("Entered pin : ") + pin);
            DialogManager.ShowLoading();
            InkWars.Model.MVCNetworkManager.Instance.StartAutoPlayGame(anySkill:  false, hostingPrivateMatch:  false, privateMatchPin:  ((System.String.IsNullOrWhiteSpace(value:  pin)) != true) ? "invalidPinnnnnnnn" : pin);
            this.m_waitingForOpponentCanvas.gameObject.SetActive(value:  true);
        }
        private void OnChallengeAccept()
        {
            this.State = 1;
            InkWars.Model.Model_Events val_1 = InkWars.Model.Model_Events.Instance;
            if(val_1.OnMessageSent == null)
            {
                    return;
            }
            
            val_1.OnMessageSent.Invoke(message:  10);
        }
        private void OnChallengeDecline()
        {
            InkWars.Model.Model_Events val_1 = InkWars.Model.Model_Events.Instance;
            if(val_1.OnMessageSent != null)
            {
                    val_1.OnMessageSent.Invoke(message:  11);
            }
            
            mem[1152921529324895084] = 0;
            this.ShutdownNetwork(forceAutoStart:  false, couldBeRageQuit:  false, reloadScene:  true, delay:  2f, notifyUser:  true);
        }
        public override void OnReceivedPlayerData(NetworkUserInfo sharedPlayerData)
        {
            string val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            UnityEngine.MonoBehaviour.print(message:  "Received player data");
            DialogManager.HideLoading();
            CloudOpponent.current = sharedPlayerData;
            this.waitingForPublicMatch_Timeout = 0f;
            sharedPlayerData.SetRandomGameDuration();
            this.m_waitingForOpponentCanvas.gameObject.SetActive(value:  false);
            InkWars.Model.MVCNetworkManager val_2 = InkWars.Model.MVCNetworkManager.Instance;
            if((System.String.IsNullOrEmpty(value:  val_2.PrivateMatchPin)) == false)
            {
                goto label_6;
            }
            
            InkWars.Model.MVCNetworkManager val_4 = InkWars.Model.MVCNetworkManager.Instance;
            if((val_4.<HostPrivateMatch>k__BackingField) == false)
            {
                goto label_10;
            }
            
            this.OnChallengeAccept();
            return;
            label_6:
            if(sharedPlayerData == null)
            {
                goto label_11;
            }
            
            val_16 = sharedPlayerData.userName;
            goto label_12;
            label_10:
            val_17 = null;
            if(InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch == false)
            {
                goto label_18;
            }
            
            val_18 = null;
            if(InkWars.Model.MVC_Multiplayer_Manager_Base.IsPlayingBotMatch == false)
            {
                goto label_18;
            }
            
            UnityEngine.MonoBehaviour.print(message:  "HANDLING NEW CHALLENGER");
            MVC_Bot2 val_7 = UnityEngine.Object.FindObjectOfType<MVC_Bot2>();
            if(0 != val_7)
            {
                    UnityEngine.Object.Destroy(obj:  val_7.gameObject);
            }
            
            this.State = 0;
            val_19 = null;
            val_19 = null;
            InkWars.Model.MVC_Multiplayer_Manager_Base.IsOfflineGame = false;
            InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch = false;
            val_20 = null;
            val_20 = null;
            val_21 = 1;
            mem[1152921529325065700] = Character_GlobalInfo.gameMode;
            goto label_29;
            label_11:
            val_16 = 11993091;
            label_12:
            this.Set_PrivateState(state:  this.m_challengeWaitingCanvas, userName:  val_16, playerPoints:  sharedPlayerData.playerPoint.ToString(), accept:  0, decline:  0);
            return;
            label_18:
            val_21 = 0;
            label_29:
            val_22 = null;
            InkWars.Model.MVC_Multiplayer_Manager_Base.IsPlayingBotMatch = InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch;
            MatchFoundCanvas.Show(sharedPlayerData:  sharedPlayerData, isPracticeMode:  InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch, action:  new System.Action(object:  this, method:  System.Void InkWars.Model.MVC_Multiplayer_Manager_NewLobby::<OnReceivedPlayerData>b__23_0()), isNewChallenger:  false);
        }
        private void Set_PrivateState(ChallengingAcceptCanvas state, string userName, string playerPoints, System.Action accept, System.Action decline)
        {
            var val_10;
            ChallengingAcceptCanvas val_10 = state;
            val_10 = UnityEngine.Object.op_Equality(x:  this.m_challengeAcceptCanvas, y:  val_10);
            this.m_challengeAcceptCanvas.gameObject.SetActive(value:  val_10);
            ChallengingAcceptCanvas val_11 = state;
            val_11 = UnityEngine.Object.op_Equality(x:  this.m_challengeDeclineCanvas, y:  val_11);
            this.m_challengeDeclineCanvas.gameObject.SetActive(value:  val_11);
            val_10 = this.m_challengeWaitingCanvas.gameObject;
            ChallengingAcceptCanvas val_12 = state;
            val_12 = UnityEngine.Object.op_Equality(x:  this.m_challengeWaitingCanvas, y:  val_12);
            val_10.SetActive(value:  val_12);
            if((UnityEngine.Object.op_Implicit(exists:  state)) != false)
            {
                    val_10 = InkWars.Model.MVCNetworkManager.Instance;
                state.OnUserFound(userName:  userName, ppCount:  playerPoints, OnAccept:  accept, onDecline:  decline, wager:  val_8.privateWager);
            }
            
            UnityEngine.Object val_13 = 0;
            val_13 = UnityEngine.Object.op_Equality(x:  state, y:  val_13);
            this.m_joinRoomCanvas.SetActive(value:  val_13);
            NetworkLobbySuponic.Hide();
            PrivateLobbyGGP.Hide();
        }
        public override void SetState(InkWars.Model.MVC_Multiplayer_Manager_Base.MVC_Multiplayer_States state)
        {
            InkWars.Model.PlayerState val_27;
            var val_33;
            var val_35;
            UnityEngine.Transform val_38;
            var val_40;
            InkWars.Model.Controller_Network_PlayerState val_41;
            var val_42;
            var val_43;
            val_27 = state;
            LobbyStatus.Status = "";
            SetActive(value:  false);
            SetActive(value:  false);
            SetActive(value:  false);
            SetActive(value:  false);
            if(val_27 > 3)
            {
                goto label_44;
            }
            
            var val_29 = 40826760 + (state) << 2;
            val_29 = val_29 + 40826760;
            goto (40826760 + (state) << 2 + 40826760);
            label_35:
            var val_30 = 0;
            val_30 = val_30 + 1;
            if(MoveNext() == false)
            {
                goto label_21;
            }
            
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_33 = Current;
            if(val_33 != null)
            {
                    val_33 = 0;
            }
            
            UnityEngine.Object.Destroy(obj:  val_33.gameObject);
            goto label_35;
            label_21:
            val_35 = 0;
            val_38 = 1152921504621170688;
            if( != null)
            {
                    var val_32 = 0;
                val_32 = val_32 + 1;
                Dispose();
            }
            
            UnityEngine.GameObject val_18 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  null);
            goto label_62;
            label_69:
            val_38 = transform;
            val_18.transform.GetChild(index:  0).SetParent(p:  val_38);
            label_62:
            if(val_18.transform.childCount > 0)
            {
                goto label_69;
            }
            
            UnityEngine.Object.Destroy(obj:  val_18);
            label_44:
            val_18.SetActive(value:  (val_27 == 0) ? 1 : 0);
            val_18.SetActive(value:  (val_27 == 1) ? 1 : 0);
            val_18.SetActive(value:  (val_27 == 2) ? 1 : 0);
            val_18.SetActive(value:  (val_27 == 4) ? 1 : 0);
            if(val_27 == 4)
            {
                    val_27 = val_27.GetComponentInChildren<PostMatchCanvas>();
                val_27.DoAnimations();
                return;
            }
            
            if(val_27 == 2)
            {
                goto label_80;
            }
            
            if(val_27 == 1)
            {
                goto label_81;
            }
            
            if(val_27 != 0)
            {
                    return;
            }
            
            val_40 = null;
            val_40 = null;
            val_27 = InkWars.Model.Controller_Network_NF.ThisPlayer;
            val_41 = 0;
            goto label_86;
            label_80:
            val_42 = null;
            val_42 = null;
            val_27 = InkWars.Model.Controller_Network_NF.ThisPlayer;
            val_41 = 5;
            goto label_90;
            label_81:
            val_43 = null;
            val_43 = null;
            val_27 = InkWars.Model.Controller_Network_NF.ThisPlayer;
            val_41 = 2;
            label_90:
            label_86:
            val_27.State = val_41;
        }
        private System.Collections.IEnumerator BeginRematch()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new MVC_Multiplayer_Manager_NewLobby.<BeginRematch>d__26();
        }
        internal override void OnCreatePrivateRoom(string randomPin)
        {
            this.Txt_PrivateMatchPin.text = randomPin;
        }
        public MVC_Multiplayer_Manager_NewLobby()
        {
            mem[1152921529325950368] = 1084227584;
            mem[1152921529325950376] = 1084227584;
            mem[1152921529325950384] = 0;
            this = new UnityEngine.MonoBehaviour();
        }
        private void <OnReceivedPlayerData>b__23_0()
        {
            if(0 != MVC_GameScene_Activator.instance)
            {
                    UnityEngine.Object.Destroy(obj:  MVC_GameScene_Activator.instance.gameObject);
            }
            
            this.State = 1;
        }
    
    }

}
