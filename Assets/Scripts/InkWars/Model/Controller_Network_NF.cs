using UnityEngine;

namespace InkWars.Model
{
    public class Controller_Network_NF : MonoBehaviour
    {
        // Fields
        public const int MsgType_General = 200;
        public const int MsgType_PlayerData = 201;
        public const int MsgType_MultiplayerState = 202;
        public const int MsgType_PlayerState = 203;
        public const int MsgType_TargetBubblesPopulated = 204;
        public const int MsgType_AimLine = 205;
        public const int MsgType_Shoot = 206;
        public const int MsgType_Switch = 207;
        public const int MsgType_GameResult = 208;
        public const int MsgType_InkEmUp = 209;
        public const int MsgType_StunBreak = 210;
        public const int MsgType_RevengeSuper = 211;
        public const int MsgType_BattleEnhancer = 212;
        public const int MsgType_SendMessage = 213;
        public const int MsgType_Sync = 214;
        public const int MsgType_HeartBeat = 215;
        public static InkWars.Model.PlayerState ThisPlayer;
        public static InkWars.Model.PlayerState RemotePlayer;
        private static InkWars.Model.Controller_Network_NF _instance;
        private System.Collections.Concurrent.ConcurrentQueue<string> ReceivedList;
        public bool IsHost;
        private int[][] incorrectCount;
        private float syncTime;
        private bool SubscribedToEvents;
        private bool GameReady;
        
        // Properties
        private InkWars.Model.Model_Core Model { get; }
        public static InkWars.Model.Controller_Network_NF Instance { get; }
        protected virtual bool IsConnected { get; }
        
        // Methods
        private InkWars.Model.Model_Core get_Model()
        {
            if(InkWars.Model.Model_Manager.Instance == 0)
            {
                    return 0;
            }
            
            InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
            0 = val_3.Model;
            return 0;
        }
        public static InkWars.Model.Controller_Network_NF get_Instance()
        {
            var val_3;
            InkWars.Model.Controller_Network_NF val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = InkWars.Model.Controller_Network_NF._instance;
            if(val_4 == 0)
            {
                    val_5 = null;
                val_4 = UnityEngine.Object.FindObjectOfType<InkWars.Model.Controller_Network_NF>();
                val_5 = null;
                InkWars.Model.Controller_Network_NF._instance = val_4;
            }
            else
            {
                    val_5 = null;
            }
            
            val_5 = null;
            return (InkWars.Model.Controller_Network_NF)InkWars.Model.Controller_Network_NF._instance;
        }
        private void Awake()
        {
            var val_3;
            .IsLocalPlayer = true;
            val_3 = null;
            val_3 = null;
            InkWars.Model.Controller_Network_NF.ThisPlayer = new InkWars.Model.PlayerState();
            .IsLocalPlayer = false;
            InkWars.Model.Controller_Network_NF.RemotePlayer = new InkWars.Model.PlayerState();
        }
        public static void ResetPlayerLockedState()
        {
            null = null;
            InkWars.Model.Controller_Network_NF.ThisPlayer.CharacterLocked = false;
            InkWars.Model.Controller_Network_NF.RemotePlayer.CharacterLocked = false;
        }
        internal void ModelEventSubscribe()
        {
            this.SubscribedToEvents = true;
            InkWars.Model.Model_Events.Instance.add_OnMessageSent(value:  new Model_Events.ControllerNetworkMessageDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::Send_Message(InkWars.Model.Controller_Network_Message message)));
            InkWars.Model.Model_Events.Instance.add_OnTargetBubblesPopulated(value:  new Model_Events.OnTargetBubblesPopulatedDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnTargetBubblesPopulated(InkWars.Model.Player playerId, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)));
            InkWars.Model.Model_Events.Instance.add_OnPlayerAimline(value:  new Model_Events.OnPlayerAimlineDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnPlayerAimline(InkWars.Model.Player playerId, InkWars.Model.AimTarget aimTarget)));
            InkWars.Model.Model_Events.Instance.add_OnPlayerShot(value:  new Model_Events.OnPlayerShotDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnPlayerShot(float gameTime, InkWars.Model.Player playerId, InkWars.Model.AimTarget aimTarget, InkWars.Model.BubbleTypes shotBubble, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, bool sendOverNetwork)));
            InkWars.Model.Model_Events.Instance.add_OnPlayerSwitch(value:  new Model_Events.OnPlayerSwitchDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnPlayerSwitch(InkWars.Model.Player playerId, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, bool manualSwitch)));
            InkWars.Model.Model_Events.Instance.add_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnGameResult(InkWars.Model.GameResult result, bool isFinished)));
            InkWars.Model.Model_Events.Instance.add_OnInkEmUpShot(value:  new Model_Events.OnInkEmUpShotDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnPlayerInkEmUpShot(InkWars.Model.Player playerId, float timeRemaining)));
            InkWars.Model.Model_Events.Instance.add_OnStunBreak(value:  new Model_Events.OnStunBreakDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnPlayerStunBreak(InkWars.Model.Player playerId, float revengeSuperLevel, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)));
            InkWars.Model.Model_Events.Instance.add_OnRevengeSuper(value:  new Model_Events.OnRevengeSuperDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnPlayerRevengeSuper(InkWars.Model.Player playerId, InkWars.Model.BubbleTypes bubbleType, InkWars.Model.RevengeSuperEventState state)));
            InkWars.Model.Model_Events.Instance.add_OnBattleEnhancer(value:  new Model_Events.OnBattleEnhancerDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnBattleEnhancer(float timeStamp, InkWars.Model.Player playerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)));
        }
        internal void ModelEventUnsubscribe()
        {
            InkWars.Model.Model_Events.Instance.remove_OnMessageSent(value:  new Model_Events.ControllerNetworkMessageDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::Send_Message(InkWars.Model.Controller_Network_Message message)));
            InkWars.Model.Model_Events.Instance.remove_OnTargetBubblesPopulated(value:  new Model_Events.OnTargetBubblesPopulatedDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnTargetBubblesPopulated(InkWars.Model.Player playerId, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)));
            InkWars.Model.Model_Events.Instance.remove_OnPlayerAimline(value:  new Model_Events.OnPlayerAimlineDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnPlayerAimline(InkWars.Model.Player playerId, InkWars.Model.AimTarget aimTarget)));
            InkWars.Model.Model_Events.Instance.remove_OnPlayerShot(value:  new Model_Events.OnPlayerShotDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnPlayerShot(float gameTime, InkWars.Model.Player playerId, InkWars.Model.AimTarget aimTarget, InkWars.Model.BubbleTypes shotBubble, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, bool sendOverNetwork)));
            InkWars.Model.Model_Events.Instance.remove_OnPlayerSwitch(value:  new Model_Events.OnPlayerSwitchDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnPlayerSwitch(InkWars.Model.Player playerId, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, bool manualSwitch)));
            InkWars.Model.Model_Events.Instance.remove_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnGameResult(InkWars.Model.GameResult result, bool isFinished)));
            InkWars.Model.Model_Events.Instance.remove_OnInkEmUpShot(value:  new Model_Events.OnInkEmUpShotDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnPlayerInkEmUpShot(InkWars.Model.Player playerId, float timeRemaining)));
            InkWars.Model.Model_Events.Instance.remove_OnStunBreak(value:  new Model_Events.OnStunBreakDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnPlayerStunBreak(InkWars.Model.Player playerId, float revengeSuperLevel, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)));
            InkWars.Model.Model_Events.Instance.remove_OnRevengeSuper(value:  new Model_Events.OnRevengeSuperDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnPlayerRevengeSuper(InkWars.Model.Player playerId, InkWars.Model.BubbleTypes bubbleType, InkWars.Model.RevengeSuperEventState state)));
            InkWars.Model.Model_Events.Instance.remove_OnBattleEnhancer(value:  new Model_Events.OnBattleEnhancerDelegate(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::OnBattleEnhancer(float timeStamp, InkWars.Model.Player playerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)));
            this.SubscribedToEvents = false;
        }
        internal virtual void OnEnable()
        {
            NFClientUser val_2 = NFUser.current.clientUser;
            val_2.OnMsgReceivedEvent.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::Receive(string data)));
        }
        internal virtual void OnDisable()
        {
            this.ModelEventUnsubscribe();
            NFClientUser val_2 = NFUser.current.clientUser;
            val_2.OnMsgReceivedEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void InkWars.Model.Controller_Network_NF::Receive(string data)));
        }
        private InkWars.Model.BubbleTypes[] GetBubbleTypes(InkWars.Model.Model_Bubble[] ring)
        {
            InkWars.Model.BubbleTypes[] val_1 = new InkWars.Model.BubbleTypes[0];
            if(ring.Length < 1)
            {
                    return val_1;
            }
            
            do
            {
                InkWars.Model.Model_Bubble val_3 = ring[0];
                val_1[0] = ring[0x0][0].BubbleType;
            }
            while((0 + 1) < ring.Length);
            
            return val_1;
        }
        private void SyncRing(InkWars.Model.Model_Bubble[] model_ring, InkWars.Model.BubbleTypes[] sync_ring, int index, bool forceSync)
        {
            InkWars.Model.Model_Core val_11;
            var val_12;
            var val_13;
            var val_14;
            InkWars.Model.Model_Manager val_1 = InkWars.Model.Model_Manager.Instance;
            val_11 = val_1.Model;
            if(val_1.Model._gameResult != 0)
            {
                    return;
            }
            
            val_11 = mem[1152921529294638392];
            var val_2 = val_11 + (((long)(int)(index)) << 3);
            if(((mem[1152921529294638392] + ((long)(int)(index)) << 3) + 32) != 0)
            {
                    InkWars.Model.BubbleTypes[] val_11 = sync_ring[24];
            }
            else
            {
                    val_11 = mem[1152921529294638392];
                var val_4 = val_11 + (((long)(int)(index)) << 3);
                mem2[0] = new int[0];
            }
            
            val_12 = 0;
            goto label_13;
            label_40:
            InkWars.Model.Model_Bubble val_13 = model_ring[0];
            var val_5 = mem[1152921529294638392] + (((long)(int)(index)) << 3);
            val_13 = mem[(mem[1152921529294638392] + ((long)(int)(index)) << 3) + 32];
            val_13 = (mem[1152921529294638392] + ((long)(int)(index)) << 3) + 32;
            val_14 = mem[(mem[1152921529294638392] + ((long)(int)(index)) << 3) + 32 + 24];
            val_14 = (mem[1152921529294638392] + ((long)(int)(index)) << 3) + 32 + 24;
            if(sync_ring[0] != model_ring[0x0][0].BubbleType)
            {
                    var val_6 = val_13 + 0;
                var val_14 = ((mem[1152921529294638392] + ((long)(int)(index)) << 3) + 32 + 0) + 32;
                val_14 = val_14 + 1;
                mem2[0] = val_14;
                var val_7 = mem[1152921529294638392] + (((long)(int)(index)) << 3);
                var val_8 = ((mem[1152921529294638392] + ((long)(int)(index)) << 3) + 32) + 0;
                if((((mem[1152921529294638392] + ((long)(int)(index)) << 3) + 32 + 0) + 32) <= 1)
            {
                    if(forceSync == false)
            {
                goto label_28;
            }
            
            }
            
                if(forceSync != true)
            {
                    UnityEngine.Debug.LogWarning(message:  "RINGS ARE OUT OF SYNC");
            }
            
                mem2[0] = sync_ring[0x0] + 32;
                val_11 = mem[1152921529294638392];
                var val_9 = val_11 + (((long)(int)(index)) << 3);
                val_13 = mem[(mem[1152921529294638392] + ((long)(int)(index)) << 3) + 32];
                val_13 = (mem[1152921529294638392] + ((long)(int)(index)) << 3) + 32;
                val_14 = mem[(mem[1152921529294638392] + ((long)(int)(index)) << 3) + 32 + 24];
                val_14 = (mem[1152921529294638392] + ((long)(int)(index)) << 3) + 32 + 24;
            }
            
            var val_10 = val_13 + 0;
            mem2[0] = 0;
            label_28:
            val_12 = 1;
            label_13:
            if(val_12 < model_ring.Length)
            {
                goto label_40;
            }
        
        }
        public virtual void Send(InkWars.Model.Controller_Network_NF.NFIRequest msg)
        {
            NFUser.current.clientUser.SendSocketMessage(msg:  UnityEngine.JsonUtility.ToJson(obj:  msg));
        }
        internal void Receive(string data)
        {
            if(this.SubscribedToEvents != true)
            {
                    this.ModelEventSubscribe();
            }
            
            InkWars.Model.MVC_Multiplayer_Manager_Base val_1 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            InkWars.Model.MVC_Multiplayer_Manager_Base val_2 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            val_1.LastSeen = val_2.TimeoutAfter;
            this.ReceivedList.Enqueue(item:  data);
        }
        internal void Process_Message(string data)
        {
            NFIRequest val_1 = UnityEngine.JsonUtility.FromJson<NFIRequest>(json:  data);
            if((val_1.msg_id - 201) <= 14)
            {
                    var val_5 = 40826644;
                val_5 = (40826644 + ((val_1.msg_id - 201)) << 2) + val_5;
            }
            else
            {
                    UnityEngine.MonoBehaviour.print(message:  "Action: received "("Action: received ") + val_1.msg_id);
            }
        
        }
        internal void Receive_Handler(string chatString)
        {
            this.Process_Message(data:  chatString);
        }
        internal void SendPlayerData(bool onlyUpdateData = False)
        {
            Controller_Network_NF.Msg_PlayerData val_2 = new Controller_Network_NF.Msg_PlayerData();
            .data = DataStructs.UserDataDictionary.ToNetworkUserInfo();
            mem[1152921529295462016] = 201;
            .updateDataOnly = onlyUpdateData;
            goto typeof(InkWars.Model.Controller_Network_NF).__il2cppRuntimeField_188;
        }
        private void RPC_SendPlayerData(InkWars.Model.Controller_Network_NF.Msg_PlayerData data)
        {
            if(data.updateDataOnly != false)
            {
                    CloudOpponent.current = data.data;
                return;
            }
            
            InkWars.Model.MVC_Multiplayer_Manager_Base val_1 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            val_1.ConnectionStarted = true;
            if(this.IsHost != false)
            {
                    this.SendPlayerData(onlyUpdateData:  false);
            }
            
            if(InkWars.Model.MVC_Multiplayer_Manager_Base.Instance == null)
            {
                
            }
        
        }
        internal void SetMultiplayerState(InkWars.Model.MVC_Multiplayer_Manager_Base.MVC_Multiplayer_States state)
        {
            Controller_Network_NF.Msg_Int val_1 = new Controller_Network_NF.Msg_Int();
            mem[1152921529295743360] = 202;
            .value = state;
            goto typeof(InkWars.Model.Controller_Network_NF).__il2cppRuntimeField_188;
        }
        private void RPC_SetMultiplayerState(InkWars.Model.MVC_Multiplayer_Manager_Base.MVC_Multiplayer_States value)
        {
            InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.State = value;
        }
        internal void RefreshPlayerState()
        {
            null = null;
            Controller_Network_NF.Msg_PlayerState val_1 = new Controller_Network_NF.Msg_PlayerState();
            .data = InkWars.Model.Controller_Network_NF.ThisPlayer;
            mem[1152921529295991936] = 203;
            goto typeof(InkWars.Model.Controller_Network_NF).__il2cppRuntimeField_188;
        }
        private void RPC_RefreshPlayerState(InkWars.Model.PlayerState data)
        {
            null = null;
            InkWars.Model.Controller_Network_NF.RemotePlayer.CharacterNameID = data.CharacterNameID;
            InkWars.Model.Controller_Network_NF.RemotePlayer.CharacterLocked = data.CharacterLocked;
            InkWars.Model.Controller_Network_NF.RemotePlayer.GameDuration = data.GameDuration;
            InkWars.Model.Controller_Network_NF.RemotePlayer.State = data.State;
        }
        private void OnTargetBubblesPopulated(InkWars.Model.Player playerId, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)
        {
            if(playerId == 1)
            {
                    return;
            }
            
            this.GameReady = true;
            Controller_Network_NF.Msg_SwitchState val_1 = new Controller_Network_NF.Msg_SwitchState();
            .spareBubble = spareBubble;
            .revengeSuperLevel = 0f;
            mem[1152921529296273280] = 204;
            .loadedBubble = loadedBubble;
            goto typeof(InkWars.Model.Controller_Network_NF).__il2cppRuntimeField_188;
        }
        private void RPC_BubblesPopulated(InkWars.Model.Controller_Network_NF.Msg_SwitchState message)
        {
            bool val_1 = this.ModelCheckFailed();
            if(val_1 == true)
            {
                    return;
            }
            
            InkWars.Model.Model_Core val_2 = val_1.Model;
            val_2.Player2.LoadedBubble = message.loadedBubble;
            InkWars.Model.Model_Core val_3 = this.Model;
            val_3.Player2.SpareBubble = message.spareBubble;
            InkWars.Model.Model_Core val_4 = this.Model;
            message = val_4.Player2;
            val_4.Player2.IsReady = true;
        }
        private void OnPlayerAimline(InkWars.Model.Player playerId, InkWars.Model.AimTarget aimTarget)
        {
            int val_8;
            var val_9;
            val_8 = aimTarget;
            val_9 = playerId;
            if(val_9 == 1)
            {
                    return;
            }
            
            if(this.GameReady == false)
            {
                    return;
            }
            
            Controller_Network_NF.Msg_Int val_1 = new Controller_Network_NF.Msg_Int();
            mem[1152921529296595584] = 205;
            .value = val_8;
            val_8 = ???;
            val_9 = ???;
            goto typeof(InkWars.Model.Controller_Network_NF).__il2cppRuntimeField_188;
        }
        private bool ModelCheckFailed()
        {
            var val_3;
            object val_4;
            InkWars.Model.Model_Core val_1 = this.Model;
            if(val_1 == null)
            {
                goto label_1;
            }
            
            InkWars.Model.Model_Core val_2 = val_1.Model;
            if(val_2.Player2 == null)
            {
                goto label_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
            label_1:
            val_4 = "MODEL IS NULL";
            goto label_7;
            label_3:
            val_4 = "PLAYER 2 IS NULL";
            label_7:
            UnityEngine.Debug.LogError(message:  val_4);
            val_3 = 1;
            return (bool)val_3;
        }
        private void RPC_AimLine(InkWars.Model.AimTarget aimLine)
        {
            bool val_1 = this.ModelCheckFailed();
            if(val_1 != false)
            {
                    return;
            }
            
            InkWars.Model.Model_Core val_2 = val_1.Model;
            val_2.Player2.AimTarget = aimLine;
        }
        private void OnPlayerShot(float gameTime, InkWars.Model.Player playerId, InkWars.Model.AimTarget aimTarget, InkWars.Model.BubbleTypes shotBubble, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, bool sendOverNetwork)
        {
            InkWars.Model.BubbleTypes val_13;
            InkWars.Model.BubbleTypes val_14;
            InkWars.Model.AimTarget val_15;
            var val_16;
            val_13 = spareBubble;
            val_14 = shotBubble;
            val_15 = aimTarget;
            val_16 = playerId;
            if(val_16 == 1)
            {
                    return;
            }
            
            if(sendOverNetwork == false)
            {
                    return;
            }
            
            if(this.GameReady == false)
            {
                    return;
            }
            
            Controller_Network_NF.Msg_Shoot val_1 = new Controller_Network_NF.Msg_Shoot();
            .gameTime = gameTime;
            .aimTarget = val_15;
            .shotBubble = val_14;
            .loadedBubble = loadedBubble;
            .spareBubble = val_13;
            mem[1152921529297030096] = 206;
            val_13 = ???;
            val_14 = ???;
            val_15 = ???;
            val_16 = ???;
            goto typeof(InkWars.Model.Controller_Network_NF).__il2cppRuntimeField_188;
        }
        private void RPC_Shoot(InkWars.Model.Controller_Network_NF.Msg_Shoot msg)
        {
            InkWars.Model.Model_Core val_1 = this.Model;
            val_1.Player2.AimTarget = msg.aimTarget;
            InkWars.Model.Model_Core val_2 = val_1.Player2.Model;
            val_2.Player2.SpareBubble = msg.spareBubble;
            InkWars.Model.Model_Core val_3 = this.Model;
            val_3.Player2.Shoot(type:  msg.shotBubble, nextBubble:  msg.loadedBubble, sendOverNetwork:  false, pingTime:  0f);
        }
        private void OnPlayerSwitch(InkWars.Model.Player playerId, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, bool manualSwitch)
        {
            InkWars.Model.BubbleTypes val_10;
            InkWars.Model.BubbleTypes val_11;
            var val_12;
            val_10 = spareBubble;
            val_11 = loadedBubble;
            val_12 = playerId;
            if(val_12 == 1)
            {
                    return;
            }
            
            if(manualSwitch == false)
            {
                    return;
            }
            
            if(this.GameReady == false)
            {
                    return;
            }
            
            Controller_Network_NF.Msg_SwitchState val_1 = new Controller_Network_NF.Msg_SwitchState();
            .spareBubble = val_10;
            .revengeSuperLevel = 0f;
            mem[1152921529297376976] = 207;
            .loadedBubble = val_11;
            val_11 = ???;
            val_10 = ???;
            val_12 = ???;
            goto typeof(InkWars.Model.Controller_Network_NF).__il2cppRuntimeField_188;
        }
        private void RPC_Switch(InkWars.Model.Controller_Network_NF.Msg_SwitchState msg)
        {
            InkWars.Model.Model_Core val_1 = this.Model;
            val_1.Player2.LoadedBubble = msg.spareBubble;
            InkWars.Model.Model_Core val_2 = this.Model;
            val_2.Player2.SpareBubble = msg.loadedBubble;
            InkWars.Model.Model_Core val_3 = this.Model;
            val_3.Player2.Switch(manualSwitch:  true);
        }
        private void OnGameResult(InkWars.Model.GameResult result, bool isFinished)
        {
            var val_18;
            var val_19;
            val_18 = isFinished;
            val_19 = this;
            if(val_18 == false)
            {
                    return;
            }
            
            if(this.GameReady == false)
            {
                    return;
            }
            
            InkWars.Model.Model_Core val_2 = this.Model.Model;
            InkWars.Model.BubbleTypes[] val_3 = this.GetBubbleTypes(ring:  val_2.Player1.InnerRing);
            InkWars.Model.Model_Core val_4 = val_3.Model;
            InkWars.Model.BubbleTypes[] val_5 = this.GetBubbleTypes(ring:  val_4.Player1.MiddleRing);
            InkWars.Model.Model_Core val_6 = val_5.Model;
            Controller_Network_NF.Msg_SyncData val_8 = new Controller_Network_NF.Msg_SyncData();
            .gameTime = val_1.GameTime;
            .result = result;
            .innerRing1 = val_3;
            .middleRing1 = val_5;
            .outerRing1 = this.GetBubbleTypes(ring:  val_6.Player1.OuterRing);
            mem[1152921529298190800] = 208;
            .isReady = true;
            val_19 = ???;
            val_18 = ???;
            goto typeof(InkWars.Model.Controller_Network_NF).__il2cppRuntimeField_188;
        }
        private void RPC_GameResult(InkWars.Model.Controller_Network_NF.Msg_SyncData message)
        {
            InkWars.Model.GameResult val_5;
            var val_6;
            var val_7;
            if(message != null)
            {
                    val_5 = message.result;
                val_6 = val_5;
            }
            else
            {
                    val_6 = 10260432;
                val_5 = 10260432;
            }
            
            if(10260431 <= 4)
            {
                    var val_5 = 40826704;
                val_5 = mem[81868428] + val_5;
            }
            else
            {
                    val_7 = val_6;
                InkWars.Model.Model_Core val_1 = this.Model;
                this.SyncRing(model_ring:  val_1.Player2.InnerRing, sync_ring:  message.innerRing1, index:  0, forceSync:  true);
                InkWars.Model.Model_Core val_2 = this.Model;
                this.SyncRing(model_ring:  val_2.Player2.MiddleRing, sync_ring:  message.middleRing1, index:  1, forceSync:  true);
                InkWars.Model.Model_Core val_3 = this.Model;
                this.SyncRing(model_ring:  val_3.Player2.OuterRing, sync_ring:  message.outerRing1, index:  2, forceSync:  true);
                InkWars.Model.Model_Manager val_4 = InkWars.Model.Model_Manager.Instance;
                if(val_4.Model._isGameResultForEndGameSet != false)
            {
                    return;
            }
            
                val_4.Model._isGameResultForEndGameSet = true;
                val_4.Model.GameResult = 5;
            }
        
        }
        private void RPC_Sync(InkWars.Model.Controller_Network_NF.Msg_SyncData message)
        {
            InkWars.Model.Model_Core val_1 = this.Model;
            this.SyncRing(model_ring:  val_1.Player2.InnerRing, sync_ring:  message.innerRing1, index:  0, forceSync:  false);
            InkWars.Model.Model_Core val_2 = this.Model;
            this.SyncRing(model_ring:  val_2.Player2.MiddleRing, sync_ring:  message.middleRing1, index:  1, forceSync:  false);
            InkWars.Model.Model_Core val_3 = this.Model;
            this.SyncRing(model_ring:  val_3.Player2.OuterRing, sync_ring:  message.outerRing1, index:  2, forceSync:  false);
            if(message.isReady == false)
            {
                    return;
            }
            
            InkWars.Model.Model_Core val_4 = this.Model;
            message = val_4.Player2;
            val_4.Player2.IsReady = true;
        }
        private void OnPlayerInkEmUpShot(InkWars.Model.Player playerId, float timeRemaining)
        {
            if(playerId == 1)
            {
                    return;
            }
            
            if(this.GameReady == false)
            {
                    return;
            }
            
            Controller_Network_NF.Msg_Float val_1 = new Controller_Network_NF.Msg_Float();
            .value = timeRemaining;
            mem[1152921529299583568] = 209;
            this = ???;
            goto typeof(InkWars.Model.Controller_Network_NF).__il2cppRuntimeField_188;
        }
        private void RPC_InkEmUpShot(float timeRemaining)
        {
            float val_3 = 0.02f;
            val_3 = timeRemaining + val_3;
            val_1.InkEmUp_TimeRemaining = val_3;
            InkWars.Model.Model_Core val_2 = this.Model.Model;
            val_2.Player2.ShootInkEmUp();
        }
        private void OnPlayerStunBreak(InkWars.Model.Player playerId, float revengeSuperLevel, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)
        {
            InkWars.Model.BubbleTypes val_10;
            var val_11;
            val_10 = loadedBubble;
            val_11 = this;
            if(playerId == 1)
            {
                    return;
            }
            
            if(this.GameReady == false)
            {
                    return;
            }
            
            Controller_Network_NF.Msg_SwitchState val_1 = new Controller_Network_NF.Msg_SwitchState();
            .loadedBubble = val_10;
            .spareBubble = spareBubble;
            .revengeSuperLevel = revengeSuperLevel;
            mem[1152921529299864912] = 210;
            val_10 = ???;
            val_11 = ???;
            goto typeof(InkWars.Model.Controller_Network_NF).__il2cppRuntimeField_188;
        }
        private void RPC_StunBreak(InkWars.Model.Controller_Network_NF.Msg_SwitchState msg)
        {
            float val_2;
            InkWars.Model.BubbleTypes val_3;
            InkWars.Model.Model_Core val_1 = this.Model;
            if(msg != null)
            {
                    val_2 = msg.revengeSuperLevel;
                val_3 = msg.loadedBubble;
            }
            else
            {
                    val_2 = 0f;
                val_3 = 1;
            }
            
            val_1.Player2.BreakStun(overrideRevengeSuper:  val_2, otherLoadedBubble:  val_3, otherSpareBubble:  msg.spareBubble);
        }
        private void OnPlayerRevengeSuper(InkWars.Model.Player playerId, InkWars.Model.BubbleTypes bubbleType, InkWars.Model.RevengeSuperEventState state)
        {
            InkWars.Model.RevengeSuperEventState val_10;
            var val_11;
            val_10 = state;
            val_11 = this;
            if(playerId == 1)
            {
                    return;
            }
            
            if((val_10 & 4294967294) != 2)
            {
                    return;
            }
            
            if(this.GameReady == false)
            {
                    return;
            }
            
            Controller_Network_NF.Msg_RevengeSuper val_2 = new Controller_Network_NF.Msg_RevengeSuper();
            .bubbleType = bubbleType;
            .state = val_10;
            mem[1152921529300162640] = 211;
            val_10 = ???;
            val_11 = ???;
            goto typeof(InkWars.Model.Controller_Network_NF).__il2cppRuntimeField_188;
        }
        private void RPC_RevengeSuper(InkWars.Model.Controller_Network_NF.Msg_RevengeSuper msg)
        {
            if(msg.state != 3)
            {
                    if(msg.state != 2)
            {
                    return;
            }
            
                InkWars.Model.Model_Core val_1 = this.Model;
                val_1.Player2.RevengeSuperType = msg.bubbleType;
                InkWars.Model.Model_Core val_2 = this.Model;
                val_2.Player2.RevengeSuper_Equip();
                return;
            }
            
            InkWars.Model.Model_Core val_3 = this.Model;
            val_3.Player2.RevengeSuperAnimate(type:  msg.bubbleType);
        }
        private void OnBattleEnhancer(float timeStamp, InkWars.Model.Player playerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)
        {
            int val_11;
            var val_12;
            var val_13;
            val_11 = level;
            val_12 = playerId;
            val_13 = this;
            if(val_12 == 1)
            {
                    return;
            }
            
            if(this.GameReady == false)
            {
                    return;
            }
            
            Controller_Network_NF.Msg_BattleEnhancer val_1 = new Controller_Network_NF.Msg_BattleEnhancer();
            .timeStamp = timeStamp;
            .type = type;
            .state = state;
            .level = val_11;
            mem[1152921529300501328] = 212;
            val_11 = ???;
            val_13 = ???;
            val_12 = ???;
            goto typeof(InkWars.Model.Controller_Network_NF).__il2cppRuntimeField_188;
        }
        private void RPC_BattleEnhancer(InkWars.Model.Controller_Network_NF.Msg_BattleEnhancer msg)
        {
            InkWars.Model.Model_Player val_8;
            InkWars.Model.Model_Core val_1 = this.Model;
            val_1.Player2.BattleEnhancerType = msg.type;
            InkWars.Model.Model_Core val_2 = this.Model;
            val_2.Player2.BattleEnhancerLevel = msg.level;
            InkWars.Model.Model_Core val_3 = this.Model;
            if((val_3.Player2.BattleEnhancerState == 0) && (msg.state == 1))
            {
                    InkWars.Model.Model_Core val_4 = this.Model;
                val_8 = val_4.Player2;
                val_4.Player2.TryEquipBattleEnhancer = true;
                return;
            }
            
            if(msg.state == 2)
            {
                    InkWars.Model.Model_Core val_5 = this.Model;
                if(val_5.Player2.BattleEnhancerState == 1)
            {
                    InkWars.Model.Model_Core val_6 = this.Model;
                val_8 = val_6.Player2;
                val_6.Player2.BattleEnhancerTimeLeft = 0f;
                return;
            }
            
            }
            
            InkWars.Model.Model_Core val_7 = this.Model;
            val_8 = msg.state;
            val_7.Player2.BattleEnhancerState = val_8;
        }
        private void Send_Message(InkWars.Model.Controller_Network_Message message)
        {
            Controller_Network_NF.Msg_Int val_1 = new Controller_Network_NF.Msg_Int();
            mem[1152921529300905552] = 213;
            .value = message;
            goto typeof(InkWars.Model.Controller_Network_NF).__il2cppRuntimeField_188;
        }
        private void RPC_Send_Message(InkWars.Model.Controller_Network_Message message)
        {
            InkWars.Model.Model_Events val_1 = InkWars.Model.Model_Events.Instance;
            if(val_1.OnMessageReceived == null)
            {
                    return;
            }
            
            val_1.OnMessageReceived.Invoke(message:  message);
        }
        protected virtual bool get_IsConnected()
        {
            NFClientUser val_2 = NFUser.current.clientUser;
            if(val_2 != null)
            {
                    return val_2.IsTcpConnected;
            }
            
            return val_2.IsTcpConnected;
        }
        protected virtual void Process_Received_Messages()
        {
            string val_1 = 0;
            goto label_1;
            label_3:
            this.Receive_Handler(chatString:  val_1);
            label_1:
            if((this.ReceivedList.TryDequeue(result: out  val_1)) == true)
            {
                goto label_3;
            }
        
        }
        private void FixedUpdate()
        {
            if((this & 1) == 0)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.fixedDeltaTime;
            val_1 = this.syncTime - val_1;
            this.syncTime = val_1;
            if(val_1 >= 0)
            {
                    return;
            }
            
            val_1 = val_1 + 2f;
            this.syncTime = val_1;
            Controller_Network_NF.NFIRequest val_2 = new Controller_Network_NF.NFIRequest();
            .msg_id = 215;
            InkWars.Model.Model_Core val_3 = this.Model;
            if(val_3 == null)
            {
                    return;
            }
            
            if(val_4.GameTime <= 0f)
            {
                    return;
            }
            
            if(val_5.gamePhase < 1)
            {
                    return;
            }
            
            if(val_6._gameResult != 0)
            {
                    return;
            }
            
            InkWars.Model.Model_Core val_8 = val_3.Model.Model.Model.Model.Model;
            InkWars.Model.BubbleTypes[] val_9 = this.GetBubbleTypes(ring:  val_8.Player1.InnerRing);
            InkWars.Model.Model_Core val_10 = val_9.Model;
            InkWars.Model.BubbleTypes[] val_11 = this.GetBubbleTypes(ring:  val_10.Player1.MiddleRing);
            InkWars.Model.Model_Core val_12 = val_11.Model;
            InkWars.Model.BubbleTypes[] val_13 = this.GetBubbleTypes(ring:  val_12.Player1.OuterRing);
            InkWars.Model.Model_Core val_14 = val_13.Model;
            Controller_Network_NF.Msg_SyncData val_15 = new Controller_Network_NF.Msg_SyncData();
            .gameTime = val_7.GameTime;
            .result = 0;
            .innerRing1 = val_9;
            .middleRing1 = val_11;
            .outerRing1 = val_13;
            .isReady = val_14.Player1.IsReady;
            mem[1152921529301984336] = 214;
            goto typeof(InkWars.Model.Controller_Network_NF).__il2cppRuntimeField_188;
        }
        public Controller_Network_NF()
        {
            this.ReceivedList = new System.Collections.Concurrent.ConcurrentQueue<System.String>();
            this.incorrectCount = new System.Int32[][3];
        }
        private static Controller_Network_NF()
        {
            InkWars.Model.Controller_Network_NF.ThisPlayer = new InkWars.Model.PlayerState();
            InkWars.Model.Controller_Network_NF.RemotePlayer = new InkWars.Model.PlayerState();
        }
    
    }

}
