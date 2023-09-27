using UnityEngine;
public class NetworkManager_Custom : NetworkManager
{
    // Fields
    public static NetworkManager_Custom instance;
    public int intPort;
    public string defaultIP;
    public bool isServer;
    public UnityEngine.GameObject gameObjectDebugOutput;
    private UnityEngine.UI.Text textDebugOutput;
    private const short playerInformationMessageId = 800;
    private const short readyMessageId = 801;
    private const short stringRPCMessageId = 802;
    public UnityEngine.Networking.NetworkConnection localPlayer_Connection;
    public UnityEngine.Networking.NetworkConnection guestPlayer_Connection;
    public NetworkDiscovery_Custom networkDiscovery;
    internal NetworkManager_Custom.PlayerInformation localPlayer;
    internal NetworkManager_Custom.PlayerInformation otherPlayer;
    
    // Properties
    public static bool IsNetwork { get; }
    public bool IsNetworkStartScene { get; }
    
    // Methods
    private void Start()
    {
        UnityEngine.Object val_18;
        var val_19;
        var val_20;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_1.m_Handle.name, b:  "Menu_Title_Screen")) == true)
        {
            goto label_3;
        }
        
        UnityEngine.SceneManagement.Scene val_4 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_4.m_Handle.name, b:  "InteractiveTutorialAdvanced")) == false)
        {
            goto label_6;
        }
        
        label_3:
        val_18 = this.gameObject;
        UnityEngine.Object.DestroyImmediate(obj:  val_18);
        return;
        label_6:
        if(NetworkManager_Custom.stringRPCMessageId != 0)
        {
                UnityEngine.Object.Destroy(obj:  NetworkManager_Custom.stringRPCMessageId);
        }
        
        NetworkManager_Custom.stringRPCMessageId = this;
        this.gameObjectDebugOutput.SetActive(value:  false);
        UnityEngine.PlayerPrefs.SetString(key:  "isServer", value:  "null");
        this.localPlayer.playerName = PlayerPrefsManager.PlayerName;
        val_19 = null;
        val_19 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_10 = DataStructs.UserDataDictionary.Stats.TotalPVPWins;
        this.localPlayer.wins = (long)CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_10.currentCryptoKey, hiddenValue = val_10.hiddenValue, fakeValue = val_10.fakeValue, inited = val_10.inited});
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_12 = DataStructs.UserDataDictionary.Stats.TotalPVPLosses;
        this.localPlayer.losses = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_12.currentCryptoKey, hiddenValue = val_12.hiddenValue, fakeValue = val_12.fakeValue, inited = val_12.inited});
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_14 = DataStructs.UserDataDictionary.Stats.TotalPVPDraws;
        this.localPlayer.draws = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_14.currentCryptoKey, hiddenValue = val_14.hiddenValue, fakeValue = val_14.fakeValue, inited = val_14.inited});
        this.GuiPrint(s:  "NetworkManager Started");
        UnityEngine.Networking.NetworkConnection val_17 = this.GetComponent<UnityEngine.Networking.NetworkIdentity>().connectionToClient;
        this.defaultIP = val_17.address;
        val_20 = null;
        val_20 = null;
        val_18 = this.intPort;
        UnityEngine.Networking.NetworkManager.singleton.networkPort = val_18;
    }
    public override void OnStartHost()
    {
        var val_5;
        NetworkLobby_Network_Select_Screen val_6;
        val_5 = null;
        val_5 = null;
        this.GuiPrint(s:  "Host was Started: "("Host was Started: ") + UnityEngine.Networking.NetworkManager.singleton.networkAddress);
        this.isServer = true;
        val_6 = NetworkLobby_Network_Select_Screen.instance;
        if(NetworkLobby_Network_Select_Screen.instance.TEST_ONLINE_MODE == true)
        {
                return;
        }
        
        bool val_3 = NetworkDiscovery_Custom.instance.Initialize();
        NetworkDiscovery_Custom.instance.SetHostData();
        val_6 = NetworkDiscovery_Custom.instance;
        if(val_6.StartAsServer() != false)
        {
                return;
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "NetworkReset");
    }
    public override void OnStopHost()
    {
        this.GuiPrint(s:  "Host was Stopped");
        this.resetNetworkManagerVariables();
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Inequality(a:  val_1.m_Handle.name, b:  "NetworkLobby")) == false)
        {
                return;
        }
        
        UnityEngine.SceneManagement.Scene val_4 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Inequality(a:  val_4.m_Handle.name, b:  "NetworkReset")) == false)
        {
                return;
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "NetworkReset");
    }
    public override void OnServerConnect(UnityEngine.Networking.NetworkConnection conn)
    {
        UnityEngine.Networking.NetworkMessageDelegate val_5;
        string val_6;
        string val_7;
        if(this.localPlayer_Connection == null)
        {
            goto label_1;
        }
        
        if(this.guestPlayer_Connection == null)
        {
            goto label_2;
        }
        
        UnityEngine.Debug.LogError(message:  "Error localplayer and guestplayer already joined, third player?");
        return;
        label_1:
        UnityEngine.Networking.NetworkServer.RegisterHandler(msgType:  800, handler:  new UnityEngine.Networking.NetworkMessageDelegate(object:  this, method:  public System.Void NetworkManager_Custom::OnServerRecievePlayerInformation(UnityEngine.Networking.NetworkMessage netMsg)));
        UnityEngine.Networking.NetworkServer.RegisterHandler(msgType:  801, handler:  new UnityEngine.Networking.NetworkMessageDelegate(object:  this, method:  public System.Void NetworkManager_Custom::OnServerRecieveChallengerResponse(UnityEngine.Networking.NetworkMessage netMsg)));
        UnityEngine.Networking.NetworkMessageDelegate val_3 = null;
        val_5 = val_3;
        val_3 = new UnityEngine.Networking.NetworkMessageDelegate(object:  this, method:  System.Void NetworkManager_Custom::OnServerRecieveMessageForwardToOtherPlayer(UnityEngine.Networking.NetworkMessage netMsg));
        UnityEngine.Networking.NetworkServer.RegisterHandler(msgType:  802, handler:  val_3);
        this.localPlayer_Connection = conn;
        val_6 = conn.address;
        val_7 = "Local/Host Client1 has Connected from: ";
        goto label_8;
        label_2:
        this.guestPlayer_Connection = conn;
        val_6 = conn.address;
        val_7 = "Other/Guest Client2 has Connected from:";
        label_8:
        this.GuiPrint(s:  val_7 + val_6);
    }
    public override void OnServerDisconnect(UnityEngine.Networking.NetworkConnection conn)
    {
        UnityEngine.Networking.NetworkManager val_6;
        string val_7;
        string val_8;
        var val_9;
        val_6 = this;
        val_7 = conn.address;
        this.GuiPrint(s:  "Client has Disconnected " + val_7 + " | Number of Connections: "(" | Number of Connections: ") + UnityEngine.Networking.NetworkServer.connections.Count.ToString());
        if(this.IsNetworkStartScene == false)
        {
            goto label_5;
        }
        
        this.GuiPrint(s:  "Disconnecting Client in preperation for new one");
        if(this.guestPlayer_Connection == conn)
        {
            goto label_6;
        }
        
        if(this.localPlayer_Connection == conn)
        {
            goto label_7;
        }
        
        val_8 = "WARNING NON AUTHORIZED PLAYER DISCONNECTED";
        goto label_8;
        label_5:
        val_7 = this.guestPlayer_Connection;
        if(val_7 != conn)
        {
                if(this.localPlayer_Connection != conn)
        {
                return;
        }
        
        }
        
        val_7.Disconnect();
        this.guestPlayer_Connection.Dispose();
        this.guestPlayer_Connection = 0;
        this.localPlayer_Connection.Disconnect();
        this.localPlayer_Connection.Dispose();
        this.localPlayer_Connection = 0;
        this.GuiPrint(s:  "Stopping server kicking to Lobby");
        if(this.isServer != false)
        {
                val_9 = null;
            val_9 = null;
            val_6 = UnityEngine.Networking.NetworkManager.singleton;
            val_6.StopServer();
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "NetworkReset");
        return;
        label_6:
        val_7 = this.localPlayer;
        this.guestPlayer_Connection = 0;
        this.localPlayer.isReady = false;
        val_6 = this.otherPlayer;
        this.otherPlayer.isReady = false;
        goto label_24;
        label_7:
        this.localPlayer_Connection = 0;
        this.localPlayer.isReady = false;
        val_7 = this.otherPlayer;
        this.otherPlayer.isReady = false;
        val_8 = "WARNING LOCAL PLAYER (HOST) Disconnected??";
        label_8:
        this.GuiPrint(s:  val_8);
        label_24:
        conn.Disconnect();
        conn.Dispose();
    }
    public void JoinLocalGame()
    {
        var val_4;
        string val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        if((System.String.op_Equality(a:  UnityEngine.Networking.NetworkManager.singleton.networkAddress, b:  this.defaultIP)) == false)
        {
            goto label_4;
        }
        
        val_5 = "Connection to own ip is not allowed";
        goto label_5;
        label_4:
        if(this.isServer == false)
        {
            goto label_6;
        }
        
        val_5 = "Stop Hosting Server First";
        label_5:
        this.GuiPrint(s:  val_5);
        return;
        label_6:
        val_6 = null;
        val_6 = null;
        UnityEngine.Networking.NetworkClient val_3 = UnityEngine.Networking.NetworkManager.singleton.StartClient();
    }
    public override void OnStartClient(UnityEngine.Networking.NetworkClient client)
    {
        NetworkLobby_Network_Select_Screen.instance.guestWaiting();
    }
    public override void OnClientDisconnect(UnityEngine.Networking.NetworkConnection conn)
    {
        var val_2;
        this.GuiPrint(s:  "I Disconnected from a Server");
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "NetworkReset");
        this.resetNetworkManagerVariables();
        val_2 = null;
        val_2 = null;
        UnityEngine.Networking.NetworkManager.singleton.StopClient();
        if(UnityEngine.Networking.NetworkManager.singleton.IsNetworkStartScene != false)
        {
                return;
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "NetworkReset");
    }
    public override void OnClientConnect(UnityEngine.Networking.NetworkConnection conn)
    {
        var val_17;
        var val_18;
        int val_19;
        this.GuiPrint(s:  "I Connected to a Server");
        this.localPlayer.playerName = PlayerPrefsManager.PlayerName;
        this.GuiPrint(s:  "Sending Name: "("Sending Name: ") + this.localPlayer.playerName);
        val_17 = null;
        val_17 = null;
        RegisterHandler(msgType:  800, handler:  new UnityEngine.Networking.NetworkMessageDelegate(object:  this, method:  System.Void NetworkManager_Custom::OnClientRecievePlayerInformation(UnityEngine.Networking.NetworkMessage netMsg)));
        this.localPlayer.playerName = PlayerPrefsManager.PlayerName;
        val_18 = null;
        val_18 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Stats.TotalPVPWins;
        this.localPlayer.wins = (long)CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited});
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = DataStructs.UserDataDictionary.Stats.TotalPVPLosses;
        this.localPlayer.losses = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue, inited = val_7.inited});
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = DataStructs.UserDataDictionary.Stats.TotalPVPDraws;
        this.localPlayer.draws = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_9.currentCryptoKey, hiddenValue = val_9.hiddenValue, fakeValue = val_9.fakeValue, inited = val_9.inited});
        RPCPlayerInformationMessage val_11 = new RPCPlayerInformationMessage();
        if(val_11 != null)
        {
                .playerName = this.localPlayer.playerName;
            val_19 = PlayerPrefsManager.OnlinePVPTime;
        }
        else
        {
                mem[16] = this.localPlayer.playerName;
            val_19 = PlayerPrefsManager.OnlinePVPTime;
        }
        
        .onlinePVPTime = val_19;
        .wins = this.localPlayer.wins;
        .losses = this.localPlayer.losses;
        .draws = this.localPlayer.draws;
        .shells = PlayerPrefsManager.Shells;
        .musicIndex = PlayerPrefsManager.LanMusicIndex;
        bool val_16 = Send(msgType:  800, msg:  val_11);
    }
    private void OnClientRecievePlayerInformation(UnityEngine.Networking.NetworkMessage netMsg)
    {
        PlayerInformation val_3;
        string val_4;
        RPCPlayerInformationMessage val_1 = netMsg.ReadMessage<RPCPlayerInformationMessage>();
        this.GuiPrint(s:  "OtherParty UserName:"("OtherParty UserName:") + val_1.playerName);
        this.otherPlayer.playerName = val_1.playerName;
        this.otherPlayer.wins = val_1.wins;
        PlayerPrefsManager.Player2Wins = val_1.wins;
        this.otherPlayer.losses = val_1.losses;
        PlayerPrefsManager.Player2Loses = val_1.losses;
        this.otherPlayer.draws = val_1.draws;
        PlayerPrefsManager.Player2Draws = val_1.draws;
        this.otherPlayer.shells = val_1.shells;
        PlayerPrefsManager.Player2Shells = val_1.shells;
        if(this.isServer != true)
        {
                PlayerPrefsManager.OnlinePVPTime = val_1.onlinePVPTime;
            PlayerPrefsManager.LanMusicIndex = val_1.musicIndex;
        }
        
        val_3 = this.otherPlayer;
        if(val_3 == null)
        {
            goto label_10;
        }
        
        val_4 = this.otherPlayer.playerName;
        goto label_11;
        label_10:
        val_4 = this.otherPlayer.playerName;
        if(this.otherPlayer == null)
        {
            goto label_12;
        }
        
        val_3 = this.otherPlayer;
        label_11:
        label_14:
        label_15:
        NetworkLobby_Network_Select_Screen.instance.queryAcceptDenyChallange(otherPlayerName:  val_4, otherWins:  this.otherPlayer.wins, otherDraws:  this.otherPlayer.draws, otherLosses:  this.otherPlayer.losses);
        return;
        label_12:
        if(this.otherPlayer != null)
        {
            goto label_14;
        }
        
        if(this.otherPlayer != null)
        {
            goto label_15;
        }
    
    }
    public void OnServerRecievePlayerInformation(UnityEngine.Networking.NetworkMessage netMsg)
    {
        PlayerInformation val_7;
        PlayerInformation val_8;
        val_7 = this;
        RPCPlayerInformationMessage val_1 = netMsg.ReadMessage<RPCPlayerInformationMessage>();
        this.GuiPrint(s:  "Server got Username: "("Server got Username: ") + val_1.playerName);
        if(this.localPlayer_Connection.connectionId == netMsg.conn.connectionId)
        {
                this.localPlayer.playerName = val_1.playerName;
            this.localPlayer.wins = val_1.wins;
            val_8 = this.localPlayer;
            this.localPlayer.losses = val_1.losses;
            val_7 = this.localPlayer;
            this.localPlayer.draws = val_1.draws;
            return;
        }
        
        val_8 = this.guestPlayer_Connection.connectionId;
        if(val_8 != netMsg.conn.connectionId)
        {
                return;
        }
        
        this.otherPlayer.playerName = val_1.playerName;
        this.otherPlayer.wins = val_1.wins;
        PlayerPrefsManager.Player2Wins = val_1.wins;
        this.otherPlayer.losses = val_1.losses;
        PlayerPrefsManager.Player2Loses = val_1.losses;
        this.otherPlayer.draws = val_1.draws;
        PlayerPrefsManager.Player2Draws = val_1.draws;
        this.otherPlayer.shells = val_1.shells;
        PlayerPrefsManager.Player2Shells = val_1.shells;
        this.localPlayer.isReady = false;
        this.otherPlayer.isReady = false;
        .playerName = this.localPlayer.playerName;
        .wins = this.localPlayer.wins;
        .losses = this.localPlayer.losses;
        .draws = this.localPlayer.draws;
        .musicIndex = PlayerPrefsManager.LanMusicIndex;
        .onlinePVPTime = PlayerPrefsManager.OnlinePVPTime;
        .shells = PlayerPrefsManager.Shells;
        UnityEngine.Networking.NetworkServer.SendToClient(connectionId:  this.guestPlayer_Connection.connectionId, msgType:  800, msg:  new RPCPlayerInformationMessage());
    }
    public void OnServerRecieveChallengerResponse(UnityEngine.Networking.NetworkMessage netMsg)
    {
        UnityEngine.Networking.NetworkConnection val_10;
        PlayerInformation val_11;
        int val_12;
        val_10 = netMsg;
        val_11 = val_10.ReadMessage<UnityEngine.Networking.NetworkSystem.StringMessage>();
        this.GuiPrint(s:  "Server got Client " + val_1.value + " from: "(" from: ") + netMsg.conn.address);
        if((System.String.op_Equality(a:  val_1.value, b:  "ready")) == false)
        {
            goto label_5;
        }
        
        if(this.localPlayer_Connection.connectionId != netMsg.conn.connectionId)
        {
            goto label_8;
        }
        
        this.localPlayer.isReady = true;
        goto label_19;
        label_5:
        if((System.String.op_Equality(a:  val_1.value, b:  "notready")) == false)
        {
                return;
        }
        
        val_12 = this.localPlayer_Connection.connectionId;
        if(val_12 != netMsg.conn.connectionId)
        {
            goto label_14;
        }
        
        if(this.localPlayer == null)
        {
            goto label_15;
        }
        
        label_39:
        val_10 = this.guestPlayer_Connection;
        this.localPlayer.isReady = false;
        goto label_38;
        label_8:
        if(this.guestPlayer_Connection.connectionId == netMsg.conn.connectionId)
        {
                this.otherPlayer.isReady = true;
            .playerName = this.otherPlayer.playerName;
            .wins = this.otherPlayer.wins;
            .losses = this.otherPlayer.losses;
            .draws = this.otherPlayer.draws;
            .shells = this.otherPlayer.shells;
            UnityEngine.Networking.NetworkServer.SendToClient(connectionId:  this.localPlayer_Connection.connectionId, msgType:  800, msg:  new RPCPlayerInformationMessage());
        }
        
        label_19:
        val_11 = this.otherPlayer;
        this.GuiPrint(s:  "Local Connection Ready is: "("Local Connection Ready is: ") + this.localPlayer.isReady.ToString() + " Guest is: "(" Guest is: ") + this.otherPlayer.isReady.ToString());
        if(this.localPlayer.isReady == false)
        {
                return;
        }
        
        if(this.otherPlayer.isReady == false)
        {
                return;
        }
        
        bool val_9 = this.StartCharacterSelectScreen();
        return;
        label_14:
        val_12 = this.guestPlayer_Connection.connectionId;
        val_10 = this.guestPlayer_Connection;
        if(val_12 != netMsg.conn.connectionId)
        {
            goto label_38;
        }
        
        if(this.otherPlayer != null)
        {
            goto label_39;
        }
        
        label_15:
        label_38:
        mem[this.guestPlayer_Connection].Disconnect();
        mem[this.guestPlayer_Connection].Dispose();
        NetworkLobby_Network_Select_Screen.instance.HideAcceptDenyUIElements();
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
    public void OnClientReciveOtherPlayerStringRPC(UnityEngine.Networking.NetworkMessage netMsg)
    {
        if((netMsg.ReadMessage<UnityEngine.Networking.NetworkSystem.StringMessage>()) != null)
        {
                return;
        }
    
    }
    public void ClientSendMsgReady()
    {
        var val_3;
        this.GuiPrint(s:  "Sent Message Ready");
        val_3 = null;
        val_3 = null;
        bool val_2 = Send(msgType:  801, msg:  new UnityEngine.Networking.NetworkSystem.StringMessage(v:  "ready"));
    }
    public void ClientSendMsgNotReady()
    {
        var val_3;
        this.GuiPrint(s:  "Sent Message Not Ready");
        val_3 = null;
        val_3 = null;
        bool val_2 = Send(msgType:  801, msg:  new UnityEngine.Networking.NetworkSystem.StringMessage(v:  "notready"));
    }
    public void GuiPrint(string s = "")
    {
        UnityEngine.MonoBehaviour.print(message:  s);
        if(this.textDebugOutput == 0)
        {
                return;
        }
        
        string val_2 = this.textDebugOutput + "\n" + s;
        if(this.textDebugOutput == null)
        {
            
        }
    
    }
    public void clearDebugGui()
    {
        if(this.textDebugOutput == 0)
        {
                return;
        }
        
        if(this.textDebugOutput == null)
        {
            
        }
    
    }
    public void setIP(string ip)
    {
        null = null;
        UnityEngine.Networking.NetworkManager.singleton.networkAddress = ip;
        this.GuiPrint(s:  "SetIP: "("SetIP: ") + ip);
    }
    public bool StartCharacterSelectScreen()
    {
        UnityEngine.Networking.NetworkManager val_1;
        var val_2;
        var val_3;
        val_1 = this;
        if(this.isServer != false)
        {
                val_2 = null;
            val_2 = null;
            val_1 = UnityEngine.Networking.NetworkManager.singleton;
            val_3 = 1;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    public void StartTransistionScene()
    {
        var val_5;
        var val_6;
        val_5 = this;
        if(this.isServer == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = ???;
        goto typeof(UnityEngine.Networking.NetworkManager).__il2cppRuntimeField_198;
    }
    public bool StartPlayScene()
    {
        UnityEngine.Networking.NetworkManager val_1;
        var val_2;
        var val_3;
        var val_4;
        var val_6;
        var val_7;
        var val_8;
        val_1 = this;
        if(this.isServer == false)
        {
            goto label_1;
        }
        
        val_2 = null;
        val_2 = null;
        val_3 = null;
        if(Character_GlobalInfo.modelTest == false)
        {
            goto label_4;
        }
        
        val_4 = null;
        val_1 = UnityEngine.Networking.NetworkManager.singleton;
        val_6 = "MVC_GameScene";
        goto label_8;
        label_1:
        val_7 = 0;
        return (bool)val_7;
        label_4:
        val_8 = null;
        val_1 = UnityEngine.Networking.NetworkManager.singleton;
        val_6 = "PlaySceneVs";
        label_8:
        val_7 = 1;
        return (bool)val_7;
    }
    public override void OnServerSceneChanged(string sceneName)
    {
        UnityEngine.MonoBehaviour.print(message:  "Spawning objects on server");
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  spawnObjects());
    }
    private System.Collections.IEnumerator spawnObjects()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new NetworkManager_Custom.<spawnObjects>d__38();
    }
    public void resetNetworkManagerVariables()
    {
        this.isServer = false;
        this.localPlayer.isReady = false;
        this.otherPlayer.isReady = false;
        this.localPlayer_Connection = 0;
        this.guestPlayer_Connection = 0;
    }
    public static bool get_IsNetwork()
    {
        return UnityEngine.Object.op_Inequality(x:  NetworkManager_Custom.stringRPCMessageId, y:  0);
    }
    public bool get_IsNetworkStartScene()
    {
        var val_8;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_1.m_Handle.name, b:  "NetworkLobby")) != false)
        {
                val_8 = 1;
            return (bool)System.String.op_Equality(a:  val_4.m_Handle.name, b:  "NetworkReset");
        }
        
        UnityEngine.SceneManagement.Scene val_4 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        return (bool)System.String.op_Equality(a:  val_4.m_Handle.name, b:  "NetworkReset");
    }
    public override void OnMatchCreate(bool success, string extendedInfo, UnityEngine.Networking.Match.MatchInfo matchInfo)
    {
        bool val_1 = success;
        this.OnMatchCreate(success:  val_1, extendedInfo:  extendedInfo, matchInfo:  matchInfo);
        UnityEngine.MonoBehaviour.print(message:  System.String.Format(format:  "Match creation info? Success: {0} Extended: {1}", arg0:  val_1, arg1:  extendedInfo));
    }
    public override void OnMatchJoined(bool success, string extendedInfo, UnityEngine.Networking.Match.MatchInfo matchInfo)
    {
        bool val_1 = success;
        this.OnMatchJoined(success:  val_1, extendedInfo:  extendedInfo, matchInfo:  matchInfo);
        UnityEngine.MonoBehaviour.print(message:  System.String.Format(format:  "Match Join info? Success: {0} Extended: {1}", arg0:  val_1, arg1:  extendedInfo));
        UnityEngine.MonoBehaviour.print(message:  "Address:"("Address:") + matchInfo.address);
    }
    private void OnConnected(UnityEngine.Networking.NetworkMessage netMsg)
    {
        goto typeof(NetworkManager_Custom).__il2cppRuntimeField_228;
    }
    public void MatchInfoReceived(bool success, string extendedInfo, System.Collections.Generic.List<UnityEngine.Networking.Match.MatchInfoSnapshot> responseData)
    {
        int val_2 = responseData.Count;
        UnityEngine.MonoBehaviour.print(message:  System.String.Format(format:  "Match Info receive data: success: {0} extendedInfo: {1} responses: {2}", arg0:  success, arg1:  extendedInfo, arg2:  val_2));
        List.Enumerator<T> val_4 = responseData.GetEnumerator();
        label_7:
        if((111076648 & 1) == 0)
        {
            goto label_3;
        }
        
        HostManager.instance.MatchHostRefreshed(response:  0.InitialType);
        goto label_7;
        label_3:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.Networking.Match.MatchInfoSnapshot>::Dispose(), rectTransform:  extendedInfo, drivenProperties:  val_2);
    }
    public NetworkManager_Custom()
    {
        this.intPort = 8452;
        this.defaultIP = "localhost";
        .playerName = "Unknownhost";
        .wins = 0;
        .losses = 0;
        .draws = 0;
        .isReady = false;
        this.localPlayer = new NetworkManager_Custom.PlayerInformation();
        .playerName = "Unknownguest";
        .wins = 0;
        .losses = 0;
        .draws = 0;
        .isReady = false;
        this.otherPlayer = new NetworkManager_Custom.PlayerInformation();
    }

}
