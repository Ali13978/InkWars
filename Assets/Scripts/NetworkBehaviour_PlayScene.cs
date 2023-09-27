using UnityEngine;
public class NetworkBehaviour_PlayScene : NetworkBehaviour
{
    // Fields
    public static NetworkBehaviour_PlayScene instance;
    public bool localPlayerSceneReady;
    public bool otherPlayerSceneReady;
    private const short startTimeMessageId = 901;
    private const short functionRPCMessageId = 903;
    private const short sceneLoadedMessageId = 904;
    private const short allReadyMessageId = 905;
    private const short syncMessageId = 906;
    private UnityEngine.Networking.NetworkClient m_client;
    public float sourceOfTruthTime;
    public NetworkBehaviour_PlayScene.PlayerStruct otherPlayer;
    public NetworkBehaviour_PlayScene.PlayerStruct localPlayer;
    private bool pausedTurnedOff;
    
    // Methods
    public override void OnStartClient()
    {
        this.gameObject.SetActive(value:  true);
    }
    private void Awake()
    {
        var val_4;
        if(NetworkManager_Custom.IsNetwork != false)
        {
                if(NetworkBehaviour_PlayScene.syncMessageId != this)
        {
                UnityEngine.Object.DestroyImmediate(obj:  NetworkBehaviour_PlayScene.syncMessageId);
        }
        
            NetworkBehaviour_PlayScene.syncMessageId = this;
            NetworkBehaviour_PlayScene.syncMessageId.GuiPrint(s:  "Started PlaySceneVS Messaging Prefab");
            val_4 = null;
            val_4 = null;
            Character_GlobalInfo.gameMode = 5;
            NetworkManager_Custom.stringRPCMessageId.clearDebugGui();
            return;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  this.gameObject);
    }
    public void ServerSendSyncMessage()
    {
        if((NetworkManager_Custom.stringRPCMessageId + 264) == 0)
        {
                return;
        }
        
        bool val_3 = UnityEngine.Networking.NetworkServer.SendToAll(msgType:  906, msg:  new UnityEngine.Networking.NetworkSystem.StringMessage(v:  SyncState.SendStringState()));
    }
    private void OnClientReceiveSyncMessage(UnityEngine.Networking.NetworkMessage netMsg)
    {
        if(this.isServer != false)
        {
                return;
        }
        
        UnityEngine.Networking.NetworkSystem.StringMessage val_2 = netMsg.ReadMessage<UnityEngine.Networking.NetworkSystem.StringMessage>();
        SyncState.ReceiveStringState(json:  val_2.value);
    }
    private void Update()
    {
        if(this.pausedTurnedOff == true)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = UnityEngine.GameObject.Find(name:  "Button_Pause");
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.SetActive(value:  false);
        this.pausedTurnedOff = true;
    }
    private void OnServerRecieveMessageForwardToOtherPlayer(UnityEngine.Networking.NetworkMessage netMsg)
    {
        UnityEngine.Networking.MessageBase val_3;
        if(netMsg != null)
        {
                val_3 = netMsg.ReadMessage<UnityEngine.Networking.NetworkSystem.StringMessage>();
        }
        else
        {
                val_3 = 0.ReadMessage<UnityEngine.Networking.NetworkSystem.StringMessage>();
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
    private void OnServerRecieveFunctionMessageForwardToOtherPlayer(UnityEngine.Networking.NetworkMessage netMsg)
    {
        UnityEngine.Networking.MessageBase val_3;
        if(netMsg != null)
        {
                val_3 = netMsg.ReadMessage<RPCFunctionsMessage>();
        }
        else
        {
                val_3 = 0.ReadMessage<RPCFunctionsMessage>();
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
    private void OnClientRecieveStartTime(UnityEngine.Networking.NetworkMessage netMsg)
    {
        UnityEngine.Networking.NetworkSystem.StringMessage val_1 = netMsg.ReadMessage<UnityEngine.Networking.NetworkSystem.StringMessage>();
        string val_2 = "Got Start Time:"("Got Start Time:") + val_1.value;
        val_2.GuiPrint(s:  val_2);
    }
    private void OnClientRecieveFunctionRPCMessage(UnityEngine.Networking.NetworkMessage netMsg)
    {
        var val_2 = null;
        LanPlaySceneManager.instance.revieveFunctionRPC(functionsMessage:  netMsg.ReadMessage<RPCFunctionsMessage>());
    }
    public void sendFunctionRPC(LanPlaySceneManager.function functionNumber)
    {
        if(this.gameObject.activeSelf != false)
        {
                .functionNumber = functionNumber;
            bool val_4 = this.m_client.Send(msgType:  903, msg:  new RPCFunctionsMessage());
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Not active, ignoring message");
    }
    public void sendFunctionRPC(LanPlaySceneManager.function functionNumber, int[] intVariables)
    {
        if(this.gameObject.activeSelf == false)
        {
            goto label_2;
        }
        
        RPCFunctionsMessage val_3 = new RPCFunctionsMessage();
        if(val_3 == null)
        {
            goto label_3;
        }
        
        .functionNumber = functionNumber;
        .intVariables = intVariables;
        goto label_4;
        label_2:
        UnityEngine.Debug.LogWarning(message:  "Not active, ignoring message");
        return;
        label_3:
        mem[16] = functionNumber;
        mem[24] = intVariables;
        label_4:
        .string1 = "";
        bool val_4 = this.m_client.Send(msgType:  903, msg:  val_3);
    }
    public void sendFunctionRPC(LanPlaySceneManager.function functionNumber, int[] intVariables, string string1)
    {
        if(this.gameObject.activeSelf == false)
        {
            goto label_2;
        }
        
        RPCFunctionsMessage val_3 = new RPCFunctionsMessage();
        if(val_3 == null)
        {
            goto label_3;
        }
        
        .functionNumber = functionNumber;
        .intVariables = intVariables;
        goto label_4;
        label_2:
        UnityEngine.Debug.LogWarning(message:  "Not active, ignoring message");
        return;
        label_3:
        mem[16] = functionNumber;
        mem[24] = intVariables;
        label_4:
        .string1 = string1;
        bool val_4 = this.m_client.Send(msgType:  903, msg:  val_3);
    }
    private void GuiPrint(string s = "")
    {
        NetworkManager_Custom.stringRPCMessageId.GuiPrint(s:  s);
    }
    public void OnDisable()
    {
        UnityEngine.Debug.LogWarning(message:  "Disabling network behaviour");
    }
    public void OnEnable()
    {
        UnityEngine.Debug.LogWarning(message:  "Enable network behaviour");
        this.m_client = NetworkManager_Custom.stringRPCMessageId + 216;
        NetworkManager_Custom.stringRPCMessageId + 216.RegisterHandler(msgType:  903, handler:  new UnityEngine.Networking.NetworkMessageDelegate(object:  this, method:  System.Void NetworkBehaviour_PlayScene::OnClientRecieveFunctionRPCMessage(UnityEngine.Networking.NetworkMessage netMsg)));
        this.m_client.RegisterHandler(msgType:  906, handler:  new UnityEngine.Networking.NetworkMessageDelegate(object:  this, method:  System.Void NetworkBehaviour_PlayScene::OnClientReceiveSyncMessage(UnityEngine.Networking.NetworkMessage netMsg)));
        UnityEngine.Networking.NetworkServer.RegisterHandler(msgType:  903, handler:  new UnityEngine.Networking.NetworkMessageDelegate(object:  this, method:  System.Void NetworkBehaviour_PlayScene::OnServerRecieveFunctionMessageForwardToOtherPlayer(UnityEngine.Networking.NetworkMessage netMsg)));
    }
    public NetworkBehaviour_PlayScene()
    {
        mem[1152921526179059254] = 0;
        this.otherPlayer = 0;
        mem[1152921526179059257] = 0;
        this.localPlayer = 0;
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
