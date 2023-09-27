using UnityEngine;
public class InstanceAnimator : MonoBehaviour
{
    // Fields
    private static InstanceAnimator _instance;
    public static string[] presentColors;
    public float centerX;
    public float centerY;
    public float outerRingRadius;
    public float middleRingRadius;
    public float innerRingRadius;
    public float outerStartAngle;
    public float middleStartAngle;
    public float innerStartAngle;
    public float outerAngleDiff;
    public float middleAngleDiff;
    public float innerAngleDiff;
    private UnityEngine.GameObject specialBallHolderAnimator;
    public UnityEngine.GameObject[] balls;
    public static bool deviceBasedFlipDataSource;
    public static UnityEngine.GameObject[] outerRingBalls;
    public static UnityEngine.GameObject[] middleRingBalls;
    public static UnityEngine.GameObject[] innerRingBalls;
    public static UnityEngine.GameObject[] playerOuterRingBalls;
    public static UnityEngine.GameObject[] playerMiddleRingBalls;
    public static UnityEngine.GameObject[] playerInnerRingBalls;
    private SimpleJSON.JSONNode stageData;
    private string stageSetup;
    private string stageFile;
    private SimpleJSON.JSONNode stageDataPlayer;
    private string stageSetupPlayer;
    private string characterFile;
    public float speed;
    public static bool areBallsInstantiated;
    public static bool isOuterRingEmpty;
    public static bool isMiddleRingEmpty;
    public static bool isInnerRingEmpty;
    public static bool isPlayerOuterRingEmpty;
    public static bool isPlayerMiddleRingEmpty;
    public static bool isPlayerInnerRingEmpty;
    public static int playerNegateX;
    public static int cpuNegateX;
    public static float UniversalX;
    private UnityEngine.GameObject outerRingSink;
    private UnityEngine.GameObject middleRingSink;
    private UnityEngine.GameObject innerRingSink;
    private UnityEngine.GameObject playerOuterRingSink;
    private UnityEngine.GameObject playerMiddleRingSink;
    private UnityEngine.GameObject playerInnerRingSink;
    public UnityEngine.GameObject outerRingWhirlpool;
    public UnityEngine.GameObject middleRingWhirlpool;
    public UnityEngine.GameObject innerRingWhirlpool;
    public UnityEngine.GameObject playerOuterRingWhirlpool;
    public UnityEngine.GameObject playerMiddleRingWhirlpool;
    public UnityEngine.GameObject playerInnerRingWhirlpool;
    public UnityEngine.GameObject colliders;
    public UnityEngine.GameObject whirlpoolsPlayerInactive;
    public UnityEngine.GameObject colliderHolder;
    public UnityEngine.GameObject flipper;
    private UnityEngine.GameObject cpuBridge;
    private UnityEngine.GameObject playerBridge;
    public static InstanceAnimator instance;
    public bool isStarted;
    
    // Properties
    public static InstanceAnimator Instance { get; }
    public static bool IsTutorialLevel { get; }
    
    // Methods
    public static InstanceAnimator get_Instance()
    {
        var val_3;
        InstanceAnimator val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = InstanceAnimator._instance;
        if(val_4 == 0)
        {
                val_5 = null;
            val_4 = UnityEngine.Object.FindObjectOfType<InstanceAnimator>();
            val_5 = null;
            InstanceAnimator._instance = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (InstanceAnimator)InstanceAnimator._instance;
    }
    public static bool get_IsTutorialLevel()
    {
        return System.String.op_Equality(a:  UnityEngine.Application.loadedLevelName, b:  "InteractiveTutorialAdvanced");
    }
    public static void RefreshUniversalX()
    {
        GlobalInfo.Refresh();
    }
    private void Awake()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        int val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_12 = null;
        val_12 = null;
        if(InstanceAnimator.instance != 0)
        {
                val_13 = null;
            val_13 = null;
            UnityEngine.Object.Destroy(obj:  InstanceAnimator.instance);
        }
        
        val_14 = null;
        val_14 = null;
        InstanceAnimator.instance = this;
        GlobalInfo.Refresh();
        this.centerX = InstanceAnimator.UniversalX;
        if(InstanceAnimator.deviceBasedFlipDataSource != false)
        {
                val_15 = null;
            var val_3 = ((DeviceBasedData.playerAtLeftForQuickPlay & true) != 0) ? (-1) : 1;
            val_15 = null;
            InstanceAnimator.deviceBasedFlipDataSource = false;
        }
        else
        {
                val_17 = null;
            val_17 = null;
            val_15 = null;
            val_16 = DataStructs.UserDataDictionary.Settings.FlipNegateX;
        }
        
        val_15 = null;
        InstanceAnimator.playerNegateX = val_16;
        InstanceAnimator.cpuNegateX = -InstanceAnimator.playerNegateX;
        UnityEngine.Debug.Log(message:  InstanceAnimator.playerNegateX + "/////////////////"("/////////////////"));
        val_18 = null;
        val_18 = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
                val_19 = null;
            if(InstanceAnimator.IsTutorialLevel != true)
        {
                val_20 = null;
            val_20 = null;
            InstanceAnimator.playerNegateX = 1;
            InstanceAnimator.cpuNegateX = 0;
        }
        
        }
        
        val_21 = null;
        val_21 = null;
        if(InstanceAnimator.playerNegateX == 1)
        {
                if((System.String.op_Equality(a:  UnityEngine.Application.loadedLevelName, b:  "PlayScene")) != false)
        {
                this.flipper.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        }
        
        UnityEngine.Coroutine val_11 = this.StartCoroutine(methodName:  "instantiateObjects");
        val_22 = null;
        val_22 = null;
        LineController.userScore = 0;
    }
    public void Start()
    {
        CharacterClan val_35;
        object val_41;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_68;
        var val_69;
        GameMode val_71;
        object val_73;
        var val_74;
        GameMode val_75;
        var val_77;
        var val_78;
        var val_79;
        object val_80;
        if(this.isStarted == true)
        {
                return;
        }
        
        this.isStarted = true;
        val_53 = null;
        val_53 = null;
        if(InstanceAnimator.outerRingBalls != null)
        {
                do
        {
            val_53 = null;
            var val_1 = 4 - 4;
            if((InstanceAnimator.outerRingBalls + 32) != 0)
        {
                val_54 = null;
            val_54 = null;
            UnityEngine.Object.Destroy(obj:  InstanceAnimator.outerRingBalls + 32.gameObject);
        }
        
            val_55 = null;
            val_56 = 4 + 1;
        }
        while(val_56 != 21);
        
        }
        else
        {
                val_55 = null;
            val_55 = null;
            InstanceAnimator.outerRingBalls = new UnityEngine.GameObject[17];
        }
        
        val_55 = null;
        if(InstanceAnimator.middleRingBalls != null)
        {
                do
        {
            val_55 = null;
            var val_5 = 4 - 4;
            if((InstanceAnimator.middleRingBalls + 32) != 0)
        {
                val_57 = null;
            val_57 = null;
            UnityEngine.Object.Destroy(obj:  InstanceAnimator.middleRingBalls + 32.gameObject);
        }
        
            val_58 = null;
            val_56 = 4 + 1;
        }
        while(val_56 != 17);
        
        }
        else
        {
                val_58 = null;
            val_58 = null;
            InstanceAnimator.middleRingBalls = new UnityEngine.GameObject[13];
        }
        
        val_58 = null;
        if(InstanceAnimator.innerRingBalls != null)
        {
                do
        {
            val_58 = null;
            var val_9 = 4 - 4;
            if((InstanceAnimator.innerRingBalls + 32) != 0)
        {
                val_59 = null;
            val_59 = null;
            UnityEngine.Object.Destroy(obj:  InstanceAnimator.innerRingBalls + 32.gameObject);
        }
        
            val_60 = null;
            val_56 = 4 + 1;
        }
        while(val_56 != 13);
        
        }
        else
        {
                val_60 = null;
            val_60 = null;
            InstanceAnimator.innerRingBalls = new UnityEngine.GameObject[9];
        }
        
        val_60 = null;
        if(InstanceAnimator.playerOuterRingBalls != null)
        {
                do
        {
            val_60 = null;
            var val_13 = 4 - 4;
            if((InstanceAnimator.playerOuterRingBalls + 32) != 0)
        {
                val_61 = null;
            val_61 = null;
            UnityEngine.Object.Destroy(obj:  InstanceAnimator.playerOuterRingBalls + 32.gameObject);
        }
        
            val_62 = null;
            val_56 = 4 + 1;
        }
        while(val_56 != 21);
        
        }
        else
        {
                val_62 = null;
            val_62 = null;
            InstanceAnimator.playerOuterRingBalls = new UnityEngine.GameObject[17];
        }
        
        val_62 = null;
        if(InstanceAnimator.playerMiddleRingBalls != null)
        {
                do
        {
            val_62 = null;
            var val_17 = 4 - 4;
            if((InstanceAnimator.playerMiddleRingBalls + 32) != 0)
        {
                val_63 = null;
            val_63 = null;
            UnityEngine.Object.Destroy(obj:  InstanceAnimator.playerMiddleRingBalls + 32.gameObject);
        }
        
            val_64 = null;
            val_56 = 4 + 1;
        }
        while(val_56 != 17);
        
        }
        else
        {
                val_64 = null;
            val_64 = null;
            InstanceAnimator.playerMiddleRingBalls = new UnityEngine.GameObject[13];
        }
        
        val_64 = null;
        if(InstanceAnimator.playerInnerRingBalls == null)
        {
            goto label_109;
        }
        
        val_56 = 4;
        goto label_110;
        label_125:
        val_64 = null;
        val_56 = 5;
        label_110:
        val_64 = null;
        var val_21 = val_56 - 4;
        if((InstanceAnimator.playerInnerRingBalls + 40) != 0)
        {
                val_65 = null;
            val_65 = null;
            UnityEngine.Object.Destroy(obj:  InstanceAnimator.playerInnerRingBalls + 40.gameObject);
        }
        
        if(val_56 != 12)
        {
            goto label_125;
        }
        
        goto label_126;
        label_109:
        val_66 = null;
        val_66 = null;
        InstanceAnimator.playerInnerRingBalls = new UnityEngine.GameObject[9];
        label_126:
        val_68 = null;
        val_68 = null;
        InstanceAnimator.presentColors = new string[7];
        if(InstanceAnimator.IsTutorialLevel == false)
        {
            goto label_131;
        }
        
        this.stageFile = InteractiveTutorialManager.Instance.StageFile;
        this.characterFile = InteractiveTutorialManager.Instance.CharacterFile;
        goto label_134;
        label_131:
        this.specialBallHolderAnimator = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "SpecialBallArrowHolder");
        val_69 = null;
        val_69 = null;
        if(Character_GlobalInfo.gameMode == 3)
        {
                this.specialBallHolderAnimator.gameObject.GetComponent<UnityEngine.Animator>().enabled = true;
            val_69 = null;
        }
        
        val_69 = null;
        val_71 = Character_GlobalInfo.gameMode;
        if(val_71 != 4)
        {
            goto label_143;
        }
        
        CharacterInfo val_34 = Character_GlobalInfo.GetMainPlayer();
        if(val_35 != 1)
        {
            goto label_146;
        }
        
        int val_36 = Character_GlobalInfo.stage_CurrentLevel;
        val_73 = "Ika_";
        goto label_149;
        label_143:
        val_69 = null;
        val_71 = Character_GlobalInfo.gameMode;
        if(val_71 == 5)
        {
            goto label_152;
        }
        
        if(NetworkManager_Custom.IsNetwork == false)
        {
            goto label_153;
        }
        
        val_69 = null;
        label_152:
        CharacterInfo val_38 = Character_GlobalInfo.GetOpponentPlayer();
        CharacterInfo val_40 = Character_GlobalInfo.GetOpponentPlayer();
        string val_42 = Character_GlobalInfo.ToString(clan:  val_35)(Character_GlobalInfo.ToString(clan:  val_35)) + val_41 + ".json";
        this.stageFile = val_42;
        UnityEngine.Debug.Log(message:  "button_pvp " + val_42);
        this.specialBallHolderAnimator.SetActive(value:  false);
        goto label_159;
        label_146:
        val_73 = "Tako_";
        label_149:
        label_206:
        this.stageFile = val_73 + Character_GlobalInfo.stage_CurrentLevel + ".json";
        label_159:
        val_74 = null;
        val_74 = null;
        val_75 = Character_GlobalInfo.gameMode;
        if(val_75 == 3)
        {
            goto label_164;
        }
        
        val_74 = null;
        val_75 = Character_GlobalInfo.gameMode;
        CharacterInfo val_46 = Character_GlobalInfo.GetMainPlayer();
        CharacterInfo val_48 = Character_GlobalInfo.GetMainPlayer();
        string val_49 = Character_GlobalInfo.ToString(clan:  val_35)(Character_GlobalInfo.ToString(clan:  val_35)) + val_41 + ".json";
        this.characterFile = val_49;
        UnityEngine.Debug.Log(message:  "!=puzzle "("!=puzzle ") + val_49);
        label_134:
        this.ReadJsonPlayer();
        label_164:
        this.ReadStageData();
        val_77 = null;
        val_77 = null;
        InstanceAnimator.areBallsInstantiated = false;
        InstanceAnimator.isOuterRingEmpty = false;
        InstanceAnimator.isMiddleRingEmpty = false;
        InstanceAnimator.isInnerRingEmpty = false;
        InstanceAnimator.isPlayerOuterRingEmpty = false;
        InstanceAnimator.isPlayerMiddleRingEmpty = false;
        InstanceAnimator.isPlayerInnerRingEmpty = false;
        UnityEngine.SceneManagement.Scene val_51 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((val_51.m_Handle.name.Contains(value:  "Tutorial")) != true)
        {
                if(NetworkManager_Custom.IsNetwork == true)
        {
                return;
        }
        
            if(BattleVSGates.instance != 0)
        {
                return;
        }
        
        }
        
        this.InstantiateInStart();
        return;
        label_153:
        val_78 = null;
        val_79 = "";
        val_78 = null;
        if(Character_GlobalInfo.gameMode == 3)
        {
            goto label_183;
        }
        
        if(Character_GlobalInfo.gameMode == 2)
        {
            goto label_184;
        }
        
        if(Character_GlobalInfo.gameMode != 1)
        {
            goto label_185;
        }
        
        val_80 = "Button_vsCpuLevel";
        goto label_187;
        label_184:
        val_80 = "Button_vsCpuLevel1";
        goto label_187;
        label_183:
        val_80 = "Button_PuzzleLevel";
        label_187:
        label_185:
        object[] val_56 = new object[5];
        val_56[0] = "Level";
        val_56[1] = Character_GlobalInfo.stage_CurrentLevel;
        val_56[2] = "_";
        val_56[3] = val_80;
        val_56[4] = ".json";
        string val_58 = +val_56;
        goto label_206;
    }
    public void InstantiateInStart()
    {
        var val_49;
        var val_50;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        if(NetworkManager_Custom.IsNetwork != false)
        {
                this.Start();
        }
        
        val_49 = null;
        val_49 = null;
        InstanceAnimator.areBallsInstantiated = false;
        InstanceAnimator.isOuterRingEmpty = false;
        InstanceAnimator.isMiddleRingEmpty = false;
        InstanceAnimator.isInnerRingEmpty = false;
        InstanceAnimator.isPlayerOuterRingEmpty = false;
        InstanceAnimator.isPlayerMiddleRingEmpty = false;
        InstanceAnimator.isPlayerInnerRingEmpty = false;
        UnityEngine.Transform val_3 = new UnityEngine.GameObject(name:  "Player1 Balls").transform;
        if(val_3 != null)
        {
                UnityEngine.Vector3 val_4 = val_3.position;
            val_50 = val_4.x;
        }
        else
        {
                UnityEngine.Vector3 val_5 = 0.position;
            val_50 = val_5.x;
        }
        
        UnityEngine.Vector3 val_6 = val_3.position;
        val_3.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.SpawnOuterRingBalls(outerRingBallsRef:  InstanceAnimator.outerRingBalls, negateX:  InstanceAnimator.playerNegateX, parent:  val_3));
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  this.SpawnMiddleRingBalls(middleRingBallsRef:  InstanceAnimator.middleRingBalls, negateX:  InstanceAnimator.playerNegateX, parent:  val_3));
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this.SpawnInnerRingBalls(innerRingBallsRef:  InstanceAnimator.innerRingBalls, negateX:  InstanceAnimator.playerNegateX, parent:  val_3));
        val_53 = null;
        val_53 = null;
        if(Character_GlobalInfo.gameMode != 3)
        {
            goto label_10;
        }
        
        val_54 = null;
        if(InstanceAnimator.IsTutorialLevel == false)
        {
            goto label_13;
        }
        
        label_10:
        UnityEngine.Transform val_15 = new UnityEngine.GameObject(name:  "Player2 Balls").transform;
        if(val_15 != null)
        {
                UnityEngine.Vector3 val_16 = val_15.position;
            val_55 = val_16.x;
        }
        else
        {
                UnityEngine.Vector3 val_17 = 0.position;
            val_55 = val_17.x;
        }
        
        UnityEngine.Vector3 val_18 = val_15.position;
        val_15.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_56 = null;
        val_56 = null;
        UnityEngine.Coroutine val_20 = this.StartCoroutine(routine:  this.SpawnOuterRingBalls(outerRingBallsRef:  InstanceAnimator.playerOuterRingBalls, negateX:  InstanceAnimator.cpuNegateX, parent:  val_15));
        UnityEngine.Coroutine val_22 = this.StartCoroutine(routine:  this.SpawnMiddleRingBalls(middleRingBallsRef:  InstanceAnimator.playerMiddleRingBalls, negateX:  InstanceAnimator.cpuNegateX, parent:  val_15));
        UnityEngine.Coroutine val_24 = this.StartCoroutine(routine:  this.SpawnInnerRingBalls(innerRingBallsRef:  InstanceAnimator.playerInnerRingBalls, negateX:  InstanceAnimator.cpuNegateX, parent:  val_15));
        this.playerOuterRingWhirlpool.SetActive(value:  true);
        this.playerMiddleRingWhirlpool.SetActive(value:  true);
        this.playerInnerRingWhirlpool.SetActive(value:  true);
        SeventyOneSquared.PDUnity val_28 = this.playerOuterRingWhirlpool.transform.GetChild(index:  0).gameObject.GetComponent<SeventyOneSquared.PDUnity>();
        val_28.blendSource = 6;
        SeventyOneSquared.PDUnity val_32 = this.playerMiddleRingWhirlpool.transform.GetChild(index:  0).gameObject.GetComponent<SeventyOneSquared.PDUnity>();
        val_32.blendSource = 6;
        SeventyOneSquared.PDUnity val_36 = this.playerInnerRingWhirlpool.transform.GetChild(index:  0).gameObject.GetComponent<SeventyOneSquared.PDUnity>();
        val_36.blendSource = 6;
        label_13:
        this.outerRingWhirlpool.SetActive(value:  true);
        this.middleRingWhirlpool.SetActive(value:  true);
        this.innerRingWhirlpool.SetActive(value:  true);
        SeventyOneSquared.PDUnity val_40 = this.outerRingWhirlpool.transform.GetChild(index:  0).gameObject.GetComponent<SeventyOneSquared.PDUnity>();
        val_40.blendSource = 6;
        SeventyOneSquared.PDUnity val_44 = this.middleRingWhirlpool.transform.GetChild(index:  0).gameObject.GetComponent<SeventyOneSquared.PDUnity>();
        val_44.blendSource = 6;
        SeventyOneSquared.PDUnity val_48 = this.innerRingWhirlpool.transform.GetChild(index:  0).gameObject.GetComponent<SeventyOneSquared.PDUnity>();
        val_48.blendSource = 6;
        this.InvokeRepeating(methodName:  "SinkUpdate", time:  5f, repeatRate:  0.05f);
    }
    private void ReadStageData()
    {
        var val_17;
        var val_18;
        System.String[] val_19;
        var val_20;
        SimpleJSON.JSONNode val_22;
        SimpleJSON.JSONNode val_24;
        var val_25;
        System.String[] val_26;
        string val_27;
        var val_28;
        var val_29;
        System.String[] val_30;
        int val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        SimpleJSON.JSONNode val_39;
        var val_41;
        this.stageData = SimpleJSON.JSON.Parse(aJSON:  CMS.IO.ReadOnlyDataFile.Load(path:  "GameData/"("GameData/") + this.stageFile, type:  1));
        val_17 = null;
        val_17 = null;
        if(Character_GlobalInfo.gameMode != 3)
        {
                return;
        }
        
        val_18 = null;
        if(InstanceAnimator.IsTutorialLevel == true)
        {
                return;
        }
        
        string[] val_5 = new string[7];
        var val_22 = 0;
        val_20 = 0;
        label_33:
        if(val_22 <= 16)
        {
            goto label_7;
        }
        
        if(val_22 <= 29)
        {
            goto label_8;
        }
        
        val_22 = this.stageData;
        var val_6 = val_22 - 30;
        goto label_11;
        label_7:
        val_24 = this.stageData;
        goto label_14;
        label_8:
        val_22 = this.stageData;
        var val_7 = val_22 - 17;
        label_11:
        val_24 = val_22;
        label_14:
        string val_8 = SimpleJSON.JSONNode.op_Implicit(d:  val_24);
        if(val_5.Length == 0)
        {
                val_25 = 0;
        }
        
        if(null == null)
        {
            goto label_19;
        }
        
        if((val_20 & 2147483648) != 0)
        {
            goto label_22;
        }
        
        label_25:
        if(0 >= val_5.Length)
        {
                val_25 = 0;
        }
        
        val_27 = val_5[0];
        if(val_27 == null)
        {
            goto label_22;
        }
        
        if(0 >= val_5.Length)
        {
                val_27 = mem[val_5[0x0] + 32];
            val_27 = val_5[0x0] + 32;
        }
        
        val_25 = 0;
        if((System.String.op_Equality(a:  val_8, b:  val_27)) == true)
        {
            goto label_24;
        }
        
        if((0 + 1) <= val_20)
        {
            goto label_25;
        }
        
        label_22:
        val_20 = val_20 + 1;
        if((val_8 != null) && (val_8 == null))
        {
                val_25 = 0;
        }
        
        if(val_20 >= val_5.Length)
        {
                val_25 = 0;
        }
        
        goto label_29;
        label_19:
        if((val_8 != null) && (val_8 == null))
        {
                val_25 = 0;
        }
        
        if(val_5.Length == 0)
        {
                val_25 = 0;
        }
        
        val_20 = 0;
        val_28 = val_5[32];
        label_29:
        mem2[0] = val_8;
        label_24:
        val_22 = val_22 + 1;
        if(val_22 != 39)
        {
            goto label_33;
        }
        
        if((val_20 & 2147483648) != 0)
        {
            goto label_49;
        }
        
        label_46:
        if(0 >= val_5.Length)
        {
                val_25 = 0;
        }
        
        if(val_5[0] == null)
        {
            goto label_36;
        }
        
        val_29 = null;
        val_29 = null;
        val_19 = InstanceAnimator.presentColors;
        if(0 >= val_5.Length)
        {
                val_25 = 0;
        }
        
        if(val_19 == null)
        {
            goto label_40;
        }
        
        if((val_5[0x0] + 32) != 0)
        {
            goto label_41;
        }
        
        goto label_44;
        label_40:
        if((val_5[0x0] + 32) == 0)
        {
            goto label_44;
        }
        
        label_41:
        if((val_5[0x0] + 32) == 0)
        {
                val_25 = 0;
        }
        
        label_44:
        if(0 >= InstanceAnimator.presentColors.Length)
        {
                val_25 = 0;
        }
        
        mem2[0] = val_5[0x0] + 32;
        if((0 + 1) <= val_20)
        {
            goto label_46;
        }
        
        label_36:
        if((val_20 & 2147483648) != 0)
        {
            goto label_49;
        }
        
        val_30 = 0;
        int val_12 = val_20 + 1;
        label_58:
        if(val_30 >= val_5.Length)
        {
                val_25 = 0;
        }
        
        if(val_5[val_30] == null)
        {
            goto label_49;
        }
        
        val_25 = 0;
        int val_13 = UnityEngine.Random.Range(min:  0, max:  val_12);
        val_31 = val_5.Length;
        if(val_30 >= val_31)
        {
                val_25 = 0;
            val_31 = val_5.Length;
        }
        
        val_19 = val_5[val_30];
        if(val_13 >= val_31)
        {
                val_25 = 0;
        }
        
        string val_25 = val_5[(long)val_13];
        if((val_25 != null) && (val_25 == null))
        {
                val_25 = 0;
        }
        
        if(val_30 >= val_5.Length)
        {
                val_25 = 0;
        }
        
        val_5[val_30] = val_25;
        if((val_19 != null) && (val_19 == null))
        {
                val_25 = 0;
        }
        
        if(val_13 >= val_5.Length)
        {
                val_25 = 0;
        }
        
        val_30 = val_30 - 1;
        val_12 = val_12 - 1;
        mem2[0] = val_19;
        if(val_13 >= val_5.Length)
        {
            goto label_58;
        }
        
        label_49:
        var val_28 = 0;
        label_102:
        if(val_28 <= 16)
        {
            goto label_59;
        }
        
        if(val_28 <= 29)
        {
            goto label_60;
        }
        
        if((val_20 & 2147483648) != 0)
        {
            goto label_90;
        }
        
        val_32 = 0;
        val_33 = val_28 - 30;
        label_69:
        val_34 = null;
        val_19 = SimpleJSON.JSONNode.op_Implicit(d:  this.stageData);
        val_34 = null;
        val_30 = InstanceAnimator.presentColors;
        val_26 = 0;
        val_35 = 0;
        if((System.String.op_Equality(a:  val_19, b:  InstanceAnimator.presentColors.Length + 32)) == true)
        {
            goto label_68;
        }
        
        val_32 = val_32 + 1;
        if(val_32 <= val_20)
        {
            goto label_69;
        }
        
        goto label_90;
        label_59:
        if((val_20 & 2147483648) != 0)
        {
            goto label_90;
        }
        
        label_79:
        val_36 = null;
        val_36 = null;
        val_26 = InstanceAnimator.presentColors;
        if((System.String.op_Equality(a:  SimpleJSON.JSONNode.op_Implicit(d:  this.stageData), b:  InstanceAnimator.presentColors.Length + 32)) == true)
        {
            goto label_78;
        }
        
        val_19 = 0 + 1;
        if(val_19 <= val_20)
        {
            goto label_79;
        }
        
        goto label_90;
        label_60:
        if((val_20 & 2147483648) != 0)
        {
            goto label_90;
        }
        
        val_32 = 0;
        val_33 = val_28 - 17;
        label_89:
        val_37 = null;
        val_19 = SimpleJSON.JSONNode.op_Implicit(d:  this.stageData);
        val_37 = null;
        val_30 = InstanceAnimator.presentColors;
        val_26 = 0;
        val_35 = 0;
        if((System.String.op_Equality(a:  val_19, b:  InstanceAnimator.presentColors.Length + 32)) == true)
        {
            goto label_88;
        }
        
        val_32 = val_32 + 1;
        if(val_32 <= val_20)
        {
            goto label_89;
        }
        
        goto label_90;
        label_78:
        val_19 = SimpleJSON.JSONNode.op_Implicit(s:  val_5[0]);
        if(this.stageData != null)
        {
            goto label_95;
        }
        
        goto label_95;
        label_68:
        val_39 = this.stageData;
        val_41 = "ring_1";
        goto label_97;
        label_88:
        val_39 = this.stageData;
        val_41 = "ring_2";
        label_97:
        val_19 = val_39;
        SimpleJSON.JSONNode val_21 = SimpleJSON.JSONNode.op_Implicit(s:  val_5[val_26]);
        label_95:
        label_90:
        val_28 = val_28 + 1;
        if(val_28 != 39)
        {
            goto label_102;
        }
    
    }
    private void ReadJsonPlayer()
    {
        this.stageDataPlayer = SimpleJSON.JSON.Parse(aJSON:  CMS.IO.ReadOnlyDataFile.Load(path:  "GameData/"("GameData/") + this.characterFile, type:  1));
    }
    private System.Collections.IEnumerator SpawnOuterRingBalls(UnityEngine.GameObject[] outerRingBallsRef, int negateX, UnityEngine.Transform parent)
    {
        InstanceAnimator.<SpawnOuterRingBalls>d__69 val_1 = new InstanceAnimator.<SpawnOuterRingBalls>d__69();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .outerRingBallsRef = outerRingBallsRef;
            .negateX = negateX;
        }
        else
        {
                mem[32] = this;
            mem[48] = outerRingBallsRef;
            mem[40] = negateX;
        }
        
        .parent = parent;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator SpawnMiddleRingBalls(UnityEngine.GameObject[] middleRingBallsRef, int negateX, UnityEngine.Transform parent)
    {
        InstanceAnimator.<SpawnMiddleRingBalls>d__70 val_1 = new InstanceAnimator.<SpawnMiddleRingBalls>d__70();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .middleRingBallsRef = middleRingBallsRef;
            .negateX = negateX;
        }
        else
        {
                mem[32] = this;
            mem[48] = middleRingBallsRef;
            mem[40] = negateX;
        }
        
        .parent = parent;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator SpawnInnerRingBalls(UnityEngine.GameObject[] innerRingBallsRef, int negateX, UnityEngine.Transform parent)
    {
        InstanceAnimator.<SpawnInnerRingBalls>d__71 val_1 = new InstanceAnimator.<SpawnInnerRingBalls>d__71();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .innerRingBallsRef = innerRingBallsRef;
            .negateX = negateX;
        }
        else
        {
                mem[32] = this;
            mem[48] = innerRingBallsRef;
            mem[40] = negateX;
        }
        
        .parent = parent;
        return (System.Collections.IEnumerator)val_1;
    }
    private void SinkUpdate()
    {
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_36;
        var val_37;
        var val_38;
        val_29 = null;
        val_29 = null;
        if(LineController.bossStageFlag != false)
        {
                UnityEngine.Object.Destroy(obj:  this.outerRingSink.gameObject);
            UnityEngine.Object.Destroy(obj:  this.middleRingSink.gameObject);
            UnityEngine.Object.Destroy(obj:  this.innerRingSink.gameObject);
            if(this.playerOuterRingSink != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.playerOuterRingSink.gameObject);
        }
        
            if(this.playerMiddleRingSink != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.playerMiddleRingSink.gameObject);
        }
        
            if(this.playerInnerRingSink != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.playerInnerRingSink.gameObject);
        }
        
            val_30 = null;
            val_30 = null;
            Character_GlobalInfo.gameMode = 2;
            this.Start();
            val_31 = null;
            val_31 = null;
            LineController.bossStageFlag = false;
            return;
        }
        
        val_32 = null;
        val_32 = null;
        if(InstanceAnimator.areBallsInstantiated == false)
        {
                return;
        }
        
        val_32 = null;
        if(InstanceAnimator.isOuterRingEmpty != true)
        {
                this.SinkInstantiator(ringArray:  InstanceAnimator.outerRingBalls, arrayLength:  17, radius:  3.84f, negateX:  InstanceAnimator.playerNegateX, isEmpty: ref  1152921505075380297, ringSink: ref  this.outerRingSink, ringWhirlpool: ref  this.outerRingWhirlpool);
            val_32 = null;
        }
        
        val_32 = null;
        if(InstanceAnimator.isMiddleRingEmpty != true)
        {
                this.SinkInstantiator(ringArray:  InstanceAnimator.middleRingBalls, arrayLength:  13, radius:  2.84f, negateX:  InstanceAnimator.playerNegateX, isEmpty: ref  1152921505075380298, ringSink: ref  this.middleRingSink, ringWhirlpool: ref  this.middleRingWhirlpool);
            val_32 = null;
        }
        
        val_32 = null;
        if(InstanceAnimator.isInnerRingEmpty != true)
        {
                this.SinkInstantiator(ringArray:  InstanceAnimator.innerRingBalls, arrayLength:  9, radius:  1.83f, negateX:  InstanceAnimator.playerNegateX, isEmpty: ref  1152921505075380299, ringSink: ref  this.innerRingSink, ringWhirlpool: ref  this.innerRingWhirlpool);
        }
        
        val_36 = null;
        val_36 = null;
        if(Character_GlobalInfo.gameMode == 3)
        {
                val_37 = null;
            if(InstanceAnimator.IsTutorialLevel == false)
        {
                return;
        }
        
        }
        
        val_38 = null;
        val_38 = null;
        if(InstanceAnimator.isPlayerOuterRingEmpty != true)
        {
                this.SinkInstantiator(ringArray:  InstanceAnimator.playerOuterRingBalls, arrayLength:  17, radius:  3.84f, negateX:  InstanceAnimator.cpuNegateX, isEmpty: ref  1152921505075380300, ringSink: ref  this.playerOuterRingSink, ringWhirlpool: ref  this.playerOuterRingWhirlpool);
            val_38 = null;
        }
        
        val_38 = null;
        if(InstanceAnimator.isPlayerMiddleRingEmpty != true)
        {
                this.SinkInstantiator(ringArray:  InstanceAnimator.playerMiddleRingBalls, arrayLength:  13, radius:  2.84f, negateX:  InstanceAnimator.cpuNegateX, isEmpty: ref  1152921505075380301, ringSink: ref  this.playerMiddleRingSink, ringWhirlpool: ref  this.playerMiddleRingWhirlpool);
            val_38 = null;
        }
        
        val_38 = null;
        if(InstanceAnimator.isPlayerInnerRingEmpty == true)
        {
                return;
        }
        
        this.SinkInstantiator(ringArray:  InstanceAnimator.playerInnerRingBalls, arrayLength:  9, radius:  1.83f, negateX:  InstanceAnimator.cpuNegateX, isEmpty: ref  1152921505075380302, ringSink: ref  this.playerInnerRingSink, ringWhirlpool: ref  this.playerInnerRingWhirlpool);
    }
    private void SinkInstantiator(UnityEngine.GameObject[] ringArray, int arrayLength, float radius, int negateX, ref bool isEmpty, ref UnityEngine.GameObject ringSink, ref UnityEngine.GameObject ringWhirlpool)
    {
        var val_20;
        var val_21;
        var val_22;
        float val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_28;
        var val_29;
        var val_30;
        var val_34;
        val_21 = 1152921526230675248;
        val_22 = negateX;
        val_23 = radius;
        val_24 = ringArray;
        if(arrayLength >= 1)
        {
                val_25 = 0;
            do
        {
            if(1152921508657404416 != 0)
        {
                return;
        }
        
            val_25 = val_25 + 1;
        }
        while(val_25 < (long)arrayLength);
        
        }
        else
        {
                val_25 = 0;
        }
        
        if(val_25 != arrayLength)
        {
                return;
        }
        
        isEmpty = true;
        val_24 = 1152921504858337280;
        bool val_4 = UnityEngine.Object.op_Implicit(exists:  ringWhirlpool.gameObject.GetComponent<WhirlpoolPlayer>());
        UnityEngine.GameObject val_5 = ringWhirlpool.gameObject;
        if(val_5 == null)
        {
            goto label_15;
        }
        
        if(val_4 == false)
        {
            goto label_16;
        }
        
        label_19:
        val_21 = val_5.GetComponent<WhirlpoolPlayer>();
        val_21.Start();
        goto label_18;
        label_15:
        if(val_4 == true)
        {
            goto label_19;
        }
        
        label_16:
        val_21 = val_5.GetComponent<WhirlpoolScript>();
        val_21.Start();
        label_18:
        ringWhirlpool.SetActive(value:  false);
        val_20 = 1152921505075642368;
        val_26 = null;
        val_26 = null;
        if((LineController.flagForDestroyBallsAnim != true) && (LineController.InkingSequence != true))
        {
                val_20 = 1152921505077932032;
            val_28 = null;
            val_28 = null;
            if(LineControllerP2.InkingSequence != true)
        {
                float val_20 = (float)val_22;
            val_20 = (mem[1152921526230606408] + val_23) * val_20;
            float val_10 = val_23 * 0f;
            val_10 = val_10 + 0f;
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
            val_23 = val_11.x;
            UnityEngine.Object val_12 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  "Sink_Plug"), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_23, y = val_11.y, z = val_11.z, w = val_11.w});
            if(val_12 != null)
        {
                var val_13 = (null == null) ? (val_12) : 0;
        }
        else
        {
                val_29 = 0;
        }
        
            mem2[0] = val_29;
        }
        
        }
        
        val_22 = 1152921505075376128;
        val_30 = null;
        val_30 = null;
        if(InstanceAnimator.isInnerRingEmpty == true)
        {
            goto label_44;
        }
        
        val_30 = null;
        if(InstanceAnimator.isMiddleRingEmpty == true)
        {
            goto label_44;
        }
        
        val_30 = null;
        if(InstanceAnimator.isOuterRingEmpty == false)
        {
            goto label_47;
        }
        
        label_44:
        val_30 = null;
        if(InstanceAnimator.isInnerRingEmpty == false)
        {
            goto label_53;
        }
        
        val_30 = null;
        if(InstanceAnimator.isMiddleRingEmpty == true)
        {
            goto label_53;
        }
        
        val_30 = null;
        if(InstanceAnimator.isOuterRingEmpty == false)
        {
            goto label_56;
        }
        
        label_53:
        val_30 = null;
        if(InstanceAnimator.isInnerRingEmpty == true)
        {
            goto label_93;
        }
        
        val_30 = null;
        if(InstanceAnimator.isMiddleRingEmpty == false)
        {
            goto label_62;
        }
        
        label_93:
        label_105:
        label_96:
        mem[1152921526230606656].GetComponent<CpuBridgeScript>().changeAlienSign(i:  2);
        label_47:
        val_34 = null;
        val_34 = null;
        if(InstanceAnimator.isPlayerInnerRingEmpty != true)
        {
                val_34 = null;
            if(InstanceAnimator.isPlayerMiddleRingEmpty != true)
        {
                val_34 = null;
            if(InstanceAnimator.isPlayerOuterRingEmpty == false)
        {
                return;
        }
        
        }
        
        }
        
        val_34 = null;
        if(InstanceAnimator.isPlayerInnerRingEmpty == false)
        {
            goto label_79;
        }
        
        val_34 = null;
        if(InstanceAnimator.isPlayerMiddleRingEmpty == true)
        {
            goto label_79;
        }
        
        val_34 = null;
        if(InstanceAnimator.isPlayerOuterRingEmpty == false)
        {
            goto label_82;
        }
        
        label_79:
        val_34 = null;
        if(InstanceAnimator.isPlayerInnerRingEmpty == true)
        {
            goto label_99;
        }
        
        val_34 = null;
        if(InstanceAnimator.isPlayerMiddleRingEmpty == false)
        {
            goto label_88;
        }
        
        label_99:
        val_20 = mem[1152921526230606664].GetComponent<CpuBridgeScript>();
        label_108:
        label_102:
        val_20.changeAlienSign(i:  2);
        return;
        label_62:
        if(InstanceAnimator.isOuterRingEmpty == false)
        {
            goto label_93;
        }
        
        if((mem[1152921526230606656].GetComponent<CpuBridgeScript>()) != null)
        {
            goto label_96;
        }
        
        goto label_96;
        label_88:
        if(InstanceAnimator.isPlayerOuterRingEmpty == false)
        {
            goto label_99;
        }
        
        if((mem[1152921526230606664].GetComponent<CpuBridgeScript>()) != null)
        {
            goto label_102;
        }
        
        goto label_102;
        label_56:
        if((mem[1152921526230606656].GetComponent<CpuBridgeScript>()) != null)
        {
            goto label_105;
        }
        
        goto label_105;
        label_82:
        if((mem[1152921526230606664].GetComponent<CpuBridgeScript>()) != null)
        {
            goto label_108;
        }
        
        goto label_108;
    }
    private System.Collections.IEnumerator instantiateObjects()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new InstanceAnimator.<instantiateObjects>d__74();
    }
    public InstanceAnimator()
    {
        this.stageFile = "";
        this.characterFile = "";
    }
    private static InstanceAnimator()
    {
    
    }

}
