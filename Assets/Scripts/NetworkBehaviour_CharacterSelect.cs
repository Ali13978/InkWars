using UnityEngine;
public class NetworkBehaviour_CharacterSelect : NetworkBehaviour
{
    // Fields
    private float otherLastSeen;
    public int otherPlayerState;
    private float otherWaitingTimer;
    private float sendNextPingTime;
    private int _thisPlayerState;
    public int displayThisPlayerState;
    public bool localPlayerReady;
    public bool otherPlayerReady;
    private bool startedEndSequence;
    public bool localPlayerSceneReady;
    public bool otherPlayerSceneReady;
    private const short characterMessageId = 806;
    private const short readyMessageId = 807;
    private const short sceneLoadedMessageId = 808;
    private const short pingMessageId = 809;
    private UnityEngine.Networking.NetworkClient m_client;
    public static NetworkBehaviour_CharacterSelect instance;
    
    // Properties
    public int thisPlayerState { get; set; }
    
    // Methods
    public int get_thisPlayerState()
    {
        return (int)this._thisPlayerState;
    }
    public void set_thisPlayerState(int value)
    {
        if(this._thisPlayerState > value)
        {
                UnityEngine.Debug.LogWarning(message:  "Attempt to set an old player state, this should never happen");
            return;
        }
        
        this.sendNextPingTime = 0f;
        this._thisPlayerState = value;
        this.displayThisPlayerState = value;
    }
    public override void OnStartClient()
    {
        this.gameObject.SetActive(value:  true);
    }
    private void Update()
    {
        string val_10;
        float val_11;
        float val_10 = this.otherLastSeen;
        val_10 = 0;
        val_10 = val_10 - UnityEngine.Time.unscaledDeltaTime;
        val_11 = -10f;
        this.otherLastSeen = val_10;
        if(val_10 < 0)
        {
                val_10 = "NetworkReset";
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  val_10);
        }
        
        if(this.otherPlayerState >= this._thisPlayerState)
        {
            goto label_4;
        }
        
        val_10 = 0;
        val_11 = this.otherWaitingTimer - UnityEngine.Time.unscaledDeltaTime;
        this.otherWaitingTimer = val_11;
        if(val_11 >= 0)
        {
            goto label_5;
        }
        
        if(NetworkDelayOverlay.IsWaiting == false)
        {
            goto label_6;
        }
        
        goto label_11;
        label_4:
        this.otherWaitingTimer = 0.5f;
        label_5:
        if((((val_10 < 0) ? 1 : 0) ^ NetworkDelayOverlay.IsWaiting) == false)
        {
            goto label_11;
        }
        
        if(val_10 >= 0)
        {
            goto label_9;
        }
        
        label_6:
        if(this.startedEndSequence == false)
        {
            goto label_10;
        }
        
        label_9:
        NetworkDelayOverlay.StopWaiting();
        goto label_11;
        label_10:
        NetworkDelayOverlay.StartWaiting(message:  "WAITING FOR OPPONENT");
        label_11:
        float val_7 = UnityEngine.Time.unscaledDeltaTime;
        val_7 = this.sendNextPingTime - val_7;
        this.sendNextPingTime = val_7;
        if(val_7 < 0)
        {
                val_7 = val_7 + 1f;
            this.sendNextPingTime = val_7;
            this.sendFunctionRPC(functionNumber:  809, intVariable:  this._thisPlayerState);
            if(this.localPlayerReady != false)
        {
                this.sendFunctionRPC(functionNumber:  809, intVariable:  0);
        }
        
        }
        
        if(this._thisPlayerState >= 1)
        {
                CharacterSelect.instance.networkBothPlayersSceneLoaded = true;
        }
        
        if(this.localPlayerReady == false)
        {
                return;
        }
        
        if(this.otherPlayerReady == false)
        {
                return;
        }
        
        if(this.startedEndSequence != false)
        {
                return;
        }
        
        this.startedEndSequence = true;
        UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.startPlayScene());
    }
    private void Awake()
    {
        if(NetworkManager_Custom.stringRPCMessageId == 0)
        {
                return;
        }
        
        if(NetworkBehaviour_CharacterSelect.instance != 0)
        {
                UnityEngine.Object.Destroy(obj:  NetworkBehaviour_CharacterSelect.instance);
        }
        
        NetworkBehaviour_CharacterSelect.instance = this;
        NetworkDelayOverlay.StartWaiting(message:  "WAITING FOR OPPONENT");
        Character_GlobalInfo.stage_CurrentLevel = 2;
        this.GuiPrint(s:  "Started Character Select Network Messaging Prefab");
        this.m_client = NetworkManager_Custom.stringRPCMessageId + 216;
        NetworkManager_Custom.stringRPCMessageId + 216.RegisterHandler(msgType:  806, handler:  new UnityEngine.Networking.NetworkMessageDelegate(object:  this, method:  System.Void NetworkBehaviour_CharacterSelect::OnClientCharacterSelectMessage(UnityEngine.Networking.NetworkMessage netMsg)));
        this.m_client.RegisterHandler(msgType:  807, handler:  new UnityEngine.Networking.NetworkMessageDelegate(object:  this, method:  System.Void NetworkBehaviour_CharacterSelect::OnClientCharacterReadyMessage(UnityEngine.Networking.NetworkMessage netMsg)));
        this.m_client.RegisterHandler(msgType:  808, handler:  new UnityEngine.Networking.NetworkMessageDelegate(object:  this, method:  System.Void NetworkBehaviour_CharacterSelect::OnClientRecieveSceneLoadedMessage(UnityEngine.Networking.NetworkMessage netMsg)));
        this.m_client.RegisterHandler(msgType:  809, handler:  new UnityEngine.Networking.NetworkMessageDelegate(object:  this, method:  System.Void NetworkBehaviour_CharacterSelect::OnClientRecieveFunctionRPC(UnityEngine.Networking.NetworkMessage netMsg)));
        UnityEngine.Networking.NetworkMessageDelegate val_7 = null;
        1152921505073139712 = 1152921526172659696;
        val_7 = new UnityEngine.Networking.NetworkMessageDelegate(object:  this, method:  System.Void NetworkBehaviour_CharacterSelect::OnServerRecieveIntMessage(UnityEngine.Networking.NetworkMessage netMsg));
        UnityEngine.Networking.NetworkServer.RegisterHandler(msgType:  806, handler:  val_7);
        UnityEngine.Networking.NetworkServer.RegisterHandler(msgType:  807, handler:  new UnityEngine.Networking.NetworkMessageDelegate(object:  this, method:  System.Void NetworkBehaviour_CharacterSelect::OnServerRecieveIntMessage(UnityEngine.Networking.NetworkMessage netMsg)));
        UnityEngine.Networking.NetworkServer.RegisterHandler(msgType:  808, handler:  new UnityEngine.Networking.NetworkMessageDelegate(object:  this, method:  System.Void NetworkBehaviour_CharacterSelect::OnServerRecieveSceneLoadedMessage(UnityEngine.Networking.NetworkMessage netMsg)));
        UnityEngine.Networking.NetworkServer.RegisterHandler(msgType:  809, handler:  new UnityEngine.Networking.NetworkMessageDelegate(object:  this, method:  System.Void NetworkBehaviour_CharacterSelect::OnServerReceiveMessageToForward(UnityEngine.Networking.NetworkMessage netMsg)));
        Character_GlobalInfo.gameMode = 5;
    }
    private void OnServerReceiveMessageToForward(UnityEngine.Networking.NetworkMessage netMsg)
    {
        UnityEngine.Networking.MessageBase val_3;
        if(netMsg != null)
        {
                val_3 = netMsg.ReadMessage<UnityEngine.Networking.NetworkSystem.IntegerMessage>();
        }
        else
        {
                val_3 = 0.ReadMessage<UnityEngine.Networking.NetworkSystem.IntegerMessage>();
        }
        
        if(netMsg.conn.connectionId != (NetworkManager_Custom.stringRPCMessageId + 288 + 96))
        {
            goto label_6;
        }
        
        if((NetworkManager_Custom.stringRPCMessageId + 296) != 0)
        {
            goto label_16;
        }
        
        label_17:
        label_16:
        UnityEngine.Networking.NetworkServer.SendToClient(connectionId:  NetworkManager_Custom.stringRPCMessageId + 296 + 96, msgType:  netMsg.msgType, msg:  val_3);
        return;
        label_6:
        if(netMsg.conn.connectionId != (NetworkManager_Custom.stringRPCMessageId + 296 + 96))
        {
                return;
        }
        
        if((NetworkManager_Custom.stringRPCMessageId + 288) != 0)
        {
            goto label_16;
        }
        
        goto label_17;
    }
    private void OnClientRecieveFunctionRPC(UnityEngine.Networking.NetworkMessage netMsg)
    {
        UnityEngine.Networking.NetworkSystem.IntegerMessage val_1 = netMsg.ReadMessage<UnityEngine.Networking.NetworkSystem.IntegerMessage>();
        this.otherLastSeen = 2f;
        if(val_1.value != 1)
        {
                this.otherPlayerState = val_1.value;
            return;
        }
        
        this.otherPlayerReady = true;
    }
    private System.Collections.IEnumerator Start()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new NetworkBehaviour_CharacterSelect.<Start>d__25();
    }
    public void sendFunctionRPC(short functionNumber, int intVariable)
    {
        if(this.gameObject.activeSelf != false)
        {
                bool val_4 = this.m_client.Send(msgType:  functionNumber, msg:  new UnityEngine.Networking.NetworkSystem.IntegerMessage(v:  intVariable));
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Not active, ignoring");
    }
    public void SendCharacterSelectMessage(CharacterNameID selection)
    {
        if(this.gameObject.activeSelf != false)
        {
                UnityEngine.Networking.NetworkSystem.IntegerMessage val_3 = new UnityEngine.Networking.NetworkSystem.IntegerMessage(v:  selection);
            bool val_4 = this.m_client.Send(msgType:  806, msg:  val_3);
            selection.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_3, drivenProperties:  0);
            string val_6 = "Sent Character:"("Sent Character:") + selection.ToString();
            val_6.GuiPrint(s:  val_6);
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Not active, ignoring");
    }
    public void SendCharacterReadyMessage(CharacterNameID LeftCurrentSelection)
    {
        if(this.gameObject.activeSelf != false)
        {
                this.localPlayerReady = true;
            this.sendNextPingTime = 0f;
            this.m_client.Send(msgType:  807, msg:  new UnityEngine.Networking.NetworkSystem.IntegerMessage(v:  LeftCurrentSelection)).GuiPrint(s:  "Sent Tick");
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Not active, ignoring");
    }
    public void SendSceneLoadedMessage()
    {
        this.m_client.Send(msgType:  808, msg:  new UnityEngine.Networking.NetworkSystem.EmptyMessage()).GuiPrint(s:  "Sent Scene Loaded");
    }
    private void OnServerRecieveIntMessage(UnityEngine.Networking.NetworkMessage netMsg)
    {
        UnityEngine.Networking.MessageBase val_3;
        if(netMsg != null)
        {
                val_3 = netMsg.ReadMessage<UnityEngine.Networking.NetworkSystem.IntegerMessage>();
        }
        else
        {
                val_3 = 0.ReadMessage<UnityEngine.Networking.NetworkSystem.IntegerMessage>();
        }
        
        if(netMsg.conn.connectionId != (NetworkManager_Custom.stringRPCMessageId + 288 + 96))
        {
            goto label_6;
        }
        
        if((NetworkManager_Custom.stringRPCMessageId + 296) != 0)
        {
            goto label_16;
        }
        
        label_17:
        label_16:
        UnityEngine.Networking.NetworkServer.SendToClient(connectionId:  NetworkManager_Custom.stringRPCMessageId + 296 + 96, msgType:  netMsg.msgType, msg:  val_3);
        return;
        label_6:
        if(netMsg.conn.connectionId != (NetworkManager_Custom.stringRPCMessageId + 296 + 96))
        {
                return;
        }
        
        if((NetworkManager_Custom.stringRPCMessageId + 288) != 0)
        {
            goto label_16;
        }
        
        goto label_17;
    }
    private System.Collections.IEnumerator startPlayScene()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new NetworkBehaviour_CharacterSelect.<startPlayScene>d__31();
    }
    private void OnServerRecieveSceneLoadedMessage(UnityEngine.Networking.NetworkMessage netMsg)
    {
        UnityEngine.Networking.MessageBase val_3;
        if(netMsg != null)
        {
                val_3 = netMsg.ReadMessage<UnityEngine.Networking.NetworkSystem.IntegerMessage>();
        }
        else
        {
                val_3 = 0.ReadMessage<UnityEngine.Networking.NetworkSystem.IntegerMessage>();
        }
        
        if(netMsg.conn.connectionId != (NetworkManager_Custom.stringRPCMessageId + 288 + 96))
        {
            goto label_6;
        }
        
        this.localPlayerSceneReady = true;
        if((NetworkManager_Custom.stringRPCMessageId + 296) != 0)
        {
            goto label_16;
        }
        
        label_17:
        label_16:
        UnityEngine.Networking.NetworkServer.SendToClient(connectionId:  NetworkManager_Custom.stringRPCMessageId + 296 + 96, msgType:  netMsg.msgType, msg:  val_3);
        return;
        label_6:
        if(netMsg.conn.connectionId != (NetworkManager_Custom.stringRPCMessageId + 296 + 96))
        {
                return;
        }
        
        this.otherPlayerSceneReady = true;
        if((NetworkManager_Custom.stringRPCMessageId + 288) != 0)
        {
            goto label_16;
        }
        
        goto label_17;
    }
    private void OnClientCharacterSelectMessage(UnityEngine.Networking.NetworkMessage netMsg)
    {
        netMsg.ReadMessage<UnityEngine.Networking.NetworkSystem.IntegerMessage>().ReceivedCharacter(nameID:  val_1.value);
    }
    private void ReceivedCharacter(CharacterNameID nameID)
    {
        var val_4;
        nameID.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        string val_2 = "Recieved Character:"("Recieved Character:") + nameID.ToString();
        val_2.GuiPrint(s:  val_2);
        val_4 = 0;
        goto label_5;
        label_11:
        if(((val_3[0x0][0] + 24) == null) && ((val_3[0x0][0] + 28) == 0))
        {
                UnityEngine.Object.FindObjectsOfType<CharacterSelect_CharacterController>()[0].SelectCharacter();
        }
        
        val_4 = 1;
        label_5:
        if(val_4 < val_3.Length)
        {
            goto label_11;
        }
    
    }
    private void OnClientCharacterReadyMessage(UnityEngine.Networking.NetworkMessage netMsg)
    {
        netMsg.ReadMessage<UnityEngine.Networking.NetworkSystem.IntegerMessage>().ReceivedCharacter(nameID:  val_1.value);
        CharacterSelect.instance.SideTicked(leftSide:  false);
        string val_3 = "Side Ticked:"("Side Ticked:") + val_1 + 16.ToString()(val_1 + 16.ToString());
        val_3.GuiPrint(s:  val_3);
    }
    private void OnClientRecieveSceneLoadedMessage(UnityEngine.Networking.NetworkMessage netMsg)
    {
        this.otherPlayerSceneReady = true;
    }
    private void GuiPrint(string s = "")
    {
        if(NetworkManager_Custom.stringRPCMessageId == 0)
        {
                return;
        }
        
        NetworkManager_Custom.stringRPCMessageId.GuiPrint(s:  s);
    }
    public NetworkBehaviour_CharacterSelect()
    {
        this.otherWaitingTimer = 0.5f;
    }
    private void UNetVersion()
    {
    
    }
    public override bool OnSerialize(UnityEngine.Networking.NetworkWriter writer, bool forceAll)
    {
        return false;
    }
    public override void OnDeserialize(UnityEngine.Networking.NetworkReader reader, bool initialState)
    {
    
    }

}
