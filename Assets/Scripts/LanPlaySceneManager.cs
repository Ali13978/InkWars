using UnityEngine;
public class LanPlaySceneManager : MonoBehaviour
{
    // Fields
    private System.Nullable<int> nextSceneId;
    private float otherLastSeen;
    public int otherPlayerState;
    private float otherWaitingTimer;
    private bool hasSeenOtherPlayer;
    public float sendNextPingTime;
    private bool forceWait;
    private bool hasAskedForRematch;
    private bool hasAskedForCharacterSelect;
    private int _thisPlayerState;
    public static LanPlaySceneManager instance;
    
    // Properties
    public int thisPlayerState { get; set; }
    
    // Methods
    public int get_thisPlayerState()
    {
        return (int)this._thisPlayerState;
    }
    public void set_thisPlayerState(int value)
    {
        this.sendNextPingTime = 0f;
        this._thisPlayerState = value;
    }
    private void Awake()
    {
        var val_6;
        var val_7;
        var val_8;
        UnityEngine.Time.timeScale = 1f;
        NetworkBehaviour_PlayScene.syncMessageId = this.transform.GetComponentInChildren<NetworkBehaviour_PlayScene>(includeInactive:  true);
        if(NetworkManager_Custom.IsNetwork != false)
        {
                val_6 = null;
            val_6 = null;
            if(LanPlaySceneManager.instance != 0)
        {
                val_7 = null;
            val_7 = null;
            UnityEngine.Object.DestroyImmediate(obj:  LanPlaySceneManager.instance);
        }
        
            val_8 = null;
            val_8 = null;
            LanPlaySceneManager.instance = this;
            return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void Update()
    {
        float val_11;
        object val_12;
        bool val_13;
        float val_11 = this.otherLastSeen;
        val_11 = val_11 - UnityEngine.Time.unscaledDeltaTime;
        val_11 = -20f;
        this.otherLastSeen = val_11;
        if(val_11 < 0)
        {
                if(this.hasSeenOtherPlayer != false)
        {
                val_12 = "Haven\'t seen other player in 20 seconds, aborting";
        }
        else
        {
                val_12 = "Did not successfully initialise gamescene, aborting";
        }
        
            UnityEngine.Debug.LogWarning(message:  val_12);
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "NetworkReset");
        }
        
        if(this.otherPlayerState >= this._thisPlayerState)
        {
            goto label_10;
        }
        
        val_11 = this.otherWaitingTimer - UnityEngine.Time.unscaledDeltaTime;
        val_13 = 1;
        this.otherWaitingTimer = val_11;
        if(val_11 < 0)
        {
            goto label_15;
        }
        
        if(val_11 >= 0)
        {
            goto label_14;
        }
        
        goto label_15;
        label_10:
        this.otherWaitingTimer = 0.5f;
        if(val_11 >= 0)
        {
            goto label_14;
        }
        
        val_13 = 1;
        goto label_15;
        label_14:
        val_13 = this.forceWait;
        label_15:
        if(val_13 != NetworkDelayOverlay.IsWaiting)
        {
                if((val_13 != false) && (BattleVSGates.instance == 0))
        {
                NetworkDelayOverlay.StartWaiting(message:  "WAITING FOR OPPONENT");
        }
        else
        {
                NetworkDelayOverlay.StopWaiting();
        }
        
        }
        
        float val_6 = UnityEngine.Time.unscaledDeltaTime;
        val_6 = this.sendNextPingTime - val_6;
        this.sendNextPingTime = val_6;
        if(val_6 < 0)
        {
                val_6 = val_6 + 1f;
            this.sendNextPingTime = val_6;
            int[] val_7 = new int[2];
            val_7[0] = this._thisPlayerState;
            int val_8 = PlayerPrefsManager.Shells;
            val_7[0] = val_8;
            val_8.sendFunctionRPC(functionNumber:  9, intVariables:  val_7, string1:  "");
        }
        
        if((this.nextSceneId & 1) == 0)
        {
                return;
        }
        
        if((NetworkManager_Custom.stringRPCMessageId + 264) == 0)
        {
                return;
        }
        
        UnityEngine.Time.timeScale = 1f;
        if(this.nextSceneId == 1)
        {
            goto label_29;
        }
        
        if(this.nextSceneId != 0)
        {
            goto label_32;
        }
        
        bool val_9 = NetworkManager_Custom.stringRPCMessageId.StartCharacterSelectScreen();
        goto label_32;
        label_29:
        bool val_10 = NetworkManager_Custom.stringRPCMessageId.StartPlayScene();
        label_32:
        mem2[0] = 0;
    }
    public void sendFunctionRPC(LanPlaySceneManager.function functionNumber)
    {
        NetworkBehaviour_PlayScene.syncMessageId.sendFunctionRPC(functionNumber:  functionNumber);
    }
    public void sendFunctionRPC(LanPlaySceneManager.function functionNumber, int[] intVariables, string string1)
    {
        NetworkBehaviour_PlayScene.syncMessageId.sendFunctionRPC(functionNumber:  functionNumber, intVariables:  intVariables, string1:  string1);
    }
    public void revieveFunctionRPC(RPCFunctionsMessage functionsMessage)
    {
        this.otherLastSeen = 2f;
        this.hasSeenOtherPlayer = true;
        if(functionsMessage.functionNumber <= 30)
        {
                var val_55 = 40824060 + (functionsMessage.functionNumber) << 2;
            val_55 = val_55 + 40824060;
        }
        else
        {
                NetworkManager_Custom.stringRPCMessageId.GuiPrint(s:  "Error: Got Unknown Function Number");
        }
    
    }
    private System.Collections.IEnumerator shootBubbleBuffer(int ballEntry, int balltype)
    {
        LanPlaySceneManager.<shootBubbleBuffer>d__20 val_1 = new LanPlaySceneManager.<shootBubbleBuffer>d__20();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .ballEntry = ballEntry;
        }
        else
        {
                mem[32] = ballEntry;
        }
        
        .balltype = balltype;
        return (System.Collections.IEnumerator)val_1;
    }
    public void SendAimLine(float differenceY)
    {
        this.ReceiveAimLine(differenceY:  differenceY);
    }
    public void SendAimLineInt(int differenceY)
    {
    
    }
    public void ReceiveAimLine(float differenceY)
    {
        null = null;
        LineControllerP2.instance.MoveAimLine(differenceY:  differenceY, network:  true);
    }
    internal void GotoCharacterSelect()
    {
        UnityEngine.Time.timeScale = 1f;
        if((this.shellCheck(promptOtherSide:  true)) == false)
        {
                return;
        }
        
        this = NetworkManager_Custom.stringRPCMessageId;
        if(this.StartCharacterSelectScreen() != false)
        {
                return;
        }
        
        int[] val_3 = new int[1];
        val_3.sendFunctionRPC(functionNumber:  10, intVariables:  val_3, string1:  "");
    }
    internal void GotoRematch()
    {
        UnityEngine.Time.timeScale = 1f;
        if((this.shellCheck(promptOtherSide:  true)) == false)
        {
                return;
        }
        
        this = NetworkManager_Custom.stringRPCMessageId;
        if(this.StartPlayScene() != false)
        {
                return;
        }
        
        int[] val_3 = new int[1];
        val_3[0] = 1;
        val_3.sendFunctionRPC(functionNumber:  10, intVariables:  val_3, string1:  "");
    }
    internal void GotoLobby()
    {
        UnityEngine.Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "NetworkReset");
    }
    internal void SyncInkTimer(float inktimer)
    {
        string val_2 = inktimer.ToString();
        val_2.sendFunctionRPC(functionNumber:  18, intVariables:  new int[0], string1:  val_2);
    }
    internal void SendInkBall()
    {
        this.sendFunctionRPC(functionNumber:  11);
    }
    public void AskForCharacterScreen()
    {
        this.hasAskedForCharacterSelect = true;
        this.forceWait = true;
        this.sendFunctionRPC(functionNumber:  21);
    }
    public void AskForRematch()
    {
        this.forceWait = true;
        this.hasAskedForRematch = true;
        this.sendFunctionRPC(functionNumber:  20);
    }
    private bool shellCheck(bool promptOtherSide)
    {
        var val_5;
        var val_6;
        var val_7;
        this.forceWait = false;
        if(PlayerPrefsManager.Shells <= 0)
        {
            goto label_1;
        }
        
        if(PlayerPrefsManager.Player2Shells <= 0)
        {
            goto label_2;
        }
        
        val_5 = 1;
        return (bool)val_5;
        label_1:
        UnityEngine.MonoBehaviour.print(message:  "I do not have shells");
        val_6 = LanPlaySceneRematch.instance;
        val_7 = 4;
        goto label_5;
        label_2:
        UnityEngine.MonoBehaviour.print(message:  "They do not have shells");
        val_6 = LanPlaySceneRematch.instance;
        val_7 = 5;
        label_5:
        val_6.CurrentState = 5;
        if(promptOtherSide != false)
        {
                val_6.sendFunctionRPC(functionNumber:  28);
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    public LanPlaySceneManager()
    {
        this.otherWaitingTimer = 0.5f;
    }
    private static LanPlaySceneManager()
    {
    
    }

}
