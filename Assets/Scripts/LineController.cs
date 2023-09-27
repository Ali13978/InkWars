using UnityEngine;
public class LineController : MonoBehaviour
{
    // Fields
    public static int userScore;
    private UnityEngine.Touch[] myTouch;
    private UnityEngine.Touch touch;
    private bool setTouchPos;
    private bool isForDemo;
    public UnityEngine.Rigidbody2D blackDemoPrefab;
    private UnityEngine.Rigidbody2D blackDemo;
    private UnityEngine.Vector2 startPos;
    private UnityEngine.Vector2 endPos;
    private UnityEngine.Vector2 diff;
    public float sensitivity;
    private float distance;
    private bool inkball;
    public int inkstack;
    public UnityEngine.GameObject lineRenderer;
    public UnityEngine.Rigidbody2D[] playerBalls;
    private UnityEngine.Rigidbody2D playerBall;
    private UnityEngine.GameObject[] playerBallTemp;
    public float speed;
    public static int ballEntry;
    private int ballEntryTemp;
    private bool forceFlag;
    public static bool touchFlag;
    private UnityEngine.GameObject swipedBall;
    private UnityEngine.GameObject win_Panel;
    private UnityEngine.GameObject pvpWinnerText;
    private UnityEngine.GameObject pvpScoreText;
    public UnityEngine.GameObject camera_Shake;
    public UnityEngine.GameObject playerChar;
    public string[] playerAnimHolderTako;
    public string[] playerAnimHolderIka;
    private bool winSequenceFlag;
    private bool looseSequenceFlag;
    public static bool flagForDestroyBallsAnim;
    public UnityEngine.GameObject outOfBubbles;
    public UnityEngine.GameObject KnockOut;
    public UnityEngine.GameObject Great;
    public UnityEngine.GameObject TimeUp;
    public UnityEngine.GameObject GameDraw;
    public UnityEngine.GameObject YouWin;
    public UnityEngine.GameObject YouLose;
    private UnityEngine.GameObject losePanel;
    private UnityEngine.GameObject losePose;
    public UnityEngine.GameObject popAnimation;
    public static bool playerLose;
    public static bool playerWin;
    private UnityEngine.GameObject star1;
    private UnityEngine.GameObject star2;
    private UnityEngine.GameObject star3;
    public UnityEngine.GameObject iconPlayerActive;
    public UnityEngine.GameObject iconPlayerInactive;
    private bool isWaiting;
    public UnityEngine.Sprite[] linerendererSprites;
    public static bool stunFlag;
    public UnityEngine.GameObject stunnerPop;
    private UnityEngine.GameObject stunnerPopHolder;
    private float characterReloadVariable;
    public UnityEngine.AudioClip[] popClip;
    public UnityEngine.AudioClip matchConclusion;
    public UnityEngine.AudioClip winClip;
    public UnityEngine.AudioClip loseClip;
    public UnityEngine.GameObject popAnimationPlayer;
    public static string popTagPlayer;
    private int pearlsEarned;
    private UnityEngine.UI.Text pearlsEarnedText;
    private UnityEngine.UI.Text winPanelScoreText;
    private UnityEngine.UI.Text highScoreStageText;
    public static bool bossStageFlag;
    private int bossBattleCount;
    public UnityEngine.GameObject pingPongImage;
    public UnityEngine.GameObject particleEffect;
    public static bool bossRessurectFlag;
    public static bool bossRessurectFlagForCpu;
    public static bool bossRessurectionReload;
    public static int remainingBallsCount;
    public static bool InkingSequence;
    public static UnityEngine.GameObject[] inkBubbles;
    private UnityEngine.GameObject InkTimer;
    private UnityEngine.UI.Text inkTimerText;
    internal float inkCountdown;
    public UnityEngine.GameObject notOverYet;
    public UnityEngine.GameObject inkHimUp;
    public UnityEngine.GameObject splat;
    public float shake;
    private float shakeAmount;
    private float decreaseFactor;
    private UnityEngine.Vector3 originalPos;
    private UnityEngine.Vector3 characterPos;
    public static bool receiveDamageFlag;
    public static int numberOfPops;
    private float playerStunTime;
    private float cpuStunVariable;
    private bool stunSequenceFlag;
    public UnityEngine.AudioClip electricShock;
    public UnityEngine.GameObject crackedPuzzleText;
    public UnityEngine.GameObject stageClearedText;
    private UnityEngine.UI.Text winPanelCrackedPuzzleText;
    private UnityEngine.UI.Text winPanelStageClearedText;
    private UnityEngine.UI.Text winPanelShotCountText;
    private UnityEngine.GameObject winPanelImagePearls;
    private UnityEngine.GameObject winPanelImageHighScore;
    private UnityEngine.GameObject winPanelPowerUpsEarned;
    private UnityEngine.GameObject winPanelShellsEarned;
    private UnityEngine.UI.Text winPanelSpecialBallName;
    private UnityEngine.UI.Text winPanelSpecialBallCount;
    private UnityEngine.GameObject winPanelSpecialBallImage;
    public UnityEngine.GameObject individualScoreAnimation;
    private UnityEngine.GameObject inkMeter;
    private UnityEngine.GameObject inkMeterFullGlow;
    private UnityEngine.GameObject inkMetervs;
    private UnityEngine.GameObject inkMeterFullGlowvs;
    private UnityEngine.AudioClip vortexClip;
    private UnityEngine.AudioClip bossResurrectClip;
    public UnityEngine.AudioClip characterUnlockedClip;
    private bool battleNoPowerCounter;
    private bool powerUpUsed;
    public UnityEngine.UI.Text stunCounter;
    private bool shallHitInk;
    public UnityEngine.GameObject playerMiddle;
    public UnityEngine.GameObject cpuMiddle;
    private UnityEngine.UI.Button specialBallButton;
    private UnityEngine.UI.Button specialBallButtonArrow;
    private UnityEngine.GameObject lifeHandler;
    public static int inkBubblesHitOnCurrentCharacter;
    public static bool inkMeterAnimationFlag;
    private UnityEngine.GameObject popText;
    public static bool bigText;
    private bool inkHitting;
    private int stageNumber;
    public int angleHandler;
    public UnityEngine.GameObject entryIndicators;
    private UnityEngine.GameObject <characterUnlockPanel>k__BackingField;
    public UnityEngine.GameObject ExBattleDefeated;
    public UnityEngine.GameObject ExBattleVictory;
    public UnityEngine.Sprite inkBubbleSprite;
    private int shotsFired;
    private int ballTempCounter;
    private GameMode modeName;
    private CharacterClan tempCharType;
    public UnityEngine.GameObject tutorialPanel;
    private UnityEngine.GameObject unlockedPanelChild;
    private UnityEngine.GameObject cpuBridge;
    private UnityEngine.GameObject playerBridge;
    private bool PlayedLose;
    private bool playedWin;
    public static int BridgeStunP1;
    public static float inkposP1;
    private bool setup;
    public UnityEngine.Sprite[] iconsActiveTako;
    public UnityEngine.Sprite[] iconsActiveIka;
    public UnityEngine.Sprite[] iconsActiveMermaid;
    public float gameTime;
    public UnityEngine.AudioClip timerCountdownFinal10clip;
    private int prevTimeInt;
    private bool isTimeOver;
    public int ballsUsed;
    public bool gamePaused;
    public static LineController instance;
    public CharAnimationController_Physical animController;
    public UnityEngine.Canvas canvasCharacterBases;
    public UnityEngine.Canvas canvasCharacterAnims;
    private float stuntime;
    private float iconMaskTime;
    private float reloadTime;
    private bool time_FirstRun;
    private int timeUpFlag;
    private float syncTime;
    
    // Properties
    public UnityEngine.GameObject characterUnlockPanel { get; set; }
    private UnityEngine.GameObject panelInkUpTutorial { get; }
    private UnityEngine.GameObject sorryPanel { get; }
    private bool IsInkSequence { get; }
    private bool IsInkSequenceP2 { get; }
    
    // Methods
    public UnityEngine.GameObject get_characterUnlockPanel()
    {
        return (UnityEngine.GameObject)this.<characterUnlockPanel>k__BackingField;
    }
    private void set_characterUnlockPanel(UnityEngine.GameObject value)
    {
        this.<characterUnlockPanel>k__BackingField = value;
    }
    private UnityEngine.GameObject get_panelInkUpTutorial()
    {
        instructionMenuHandler val_1 = instructionMenuHandler.instance;
        if(val_1.Panel_Ink_Up_Tutorial != null)
        {
                return val_1.Panel_Ink_Up_Tutorial.gameObject;
        }
        
        return val_1.Panel_Ink_Up_Tutorial.gameObject;
    }
    private UnityEngine.GameObject get_sorryPanel()
    {
        instructionMenuHandler val_1 = instructionMenuHandler.instance;
        if(val_1.Panel_Sorry_Ink_Up != null)
        {
                return val_1.Panel_Sorry_Ink_Up.gameObject;
        }
        
        return val_1.Panel_Sorry_Ink_Up.gameObject;
    }
    private void Awake()
    {
        CharacterClan val_3;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        var val_77;
        var val_78;
        var val_82;
        var val_83;
        val_71 = null;
        val_71 = null;
        if((UnityEngine.Object.op_Implicit(exists:  LineController.instance)) != false)
        {
                val_72 = null;
            val_72 = null;
            UnityEngine.Object.Destroy(obj:  LineController.instance);
        }
        
        val_73 = null;
        val_73 = null;
        LineController.instance = this;
        UnityEngine.Input.multiTouchEnabled = true;
        this.touch.fingerId = 0;
        val_74 = null;
        val_74 = null;
        this.modeName = Character_GlobalInfo.gameMode;
        CharacterInfo val_2 = Character_GlobalInfo.GetMainPlayer();
        this.tempCharType = val_3;
        this.stageNumber = Character_GlobalInfo.stage_CurrentLevel - 1;
        if(this.modeName != 5)
        {
                this.isWaiting = true;
        }
        
        this.ballTempCounter = 0;
        this.playerBallTemp = new UnityEngine.GameObject[2];
        this.battleNoPowerCounter = false;
        this.powerUpUsed = false;
        this.shotsFired = 0;
        UnityEngine.GameObject val_7 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "CharacterUnlockedPanel");
        this.<characterUnlockPanel>k__BackingField = val_7;
        System.Collections.IEnumerator val_9 = val_7.transform.GetEnumerator();
        label_35:
        var val_73 = 0;
        val_73 = val_73 + 1;
        if(val_9.MoveNext() == false)
        {
            goto label_22;
        }
        
        var val_74 = 0;
        val_74 = val_74 + 1;
        val_77 = val_9.Current;
        if(val_77 != null)
        {
                val_77 = 0;
        }
        
        val_77.gameObject.SetActive(value:  true);
        goto label_35;
        label_22:
        val_78 = 0;
        if(val_9 != null)
        {
                var val_75 = 0;
            val_75 = val_75 + 1;
            val_9.Dispose();
        }
        
        UnityEngine.GameObject val_20 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "UnlockedPanelChild");
        this.unlockedPanelChild = val_20;
        val_20.transform.GetChild(index:  2).gameObject.SetActive(value:  false);
        val_82 = null;
        val_82 = null;
        if(DataStructs.UserDataDictionary.Settings.FlipNegateX == 1)
        {
                if((System.String.op_Inequality(a:  UnityEngine.Application.loadedLevelName, b:  "PlaySceneVs")) != false)
        {
                this.stunCounter.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        }
        
        this.swipedBall = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "CanvasChild");
        UnityEngine.GameObject val_30 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "LifeHandler");
        this.lifeHandler = val_30;
        val_30.SetActive(value:  false);
        this.specialBallButton = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "SpecialBallButton").GetComponent<UnityEngine.UI.Button>();
        this.specialBallButtonArrow = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "SpecialBallArrow").GetComponent<UnityEngine.UI.Button>();
        this.inkTimerText = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "InkTimerText").GetComponent<UnityEngine.UI.Text>();
        UnityEngine.GameObject val_37 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "InkTimer");
        this.InkTimer = val_37;
        val_37.SetActive(value:  false);
        UnityEngine.GameObject val_38 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "InkMeterFullGlow");
        this.inkMeterFullGlow = val_38;
        val_38.SetActive(value:  false);
        UnityEngine.GameObject val_39 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "InkMeter");
        this.inkMeter = val_39;
        val_39.SetActive(value:  false);
        this.winPanelCrackedPuzzleText = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "WinCrackedPuzzleText").GetComponent<UnityEngine.UI.Text>();
        this.winPanelStageClearedText = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "WinStageClearedText").GetComponent<UnityEngine.UI.Text>();
        this.winPanelShotCountText = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "WinShotCountText").GetComponent<UnityEngine.UI.Text>();
        this.winPanelImagePearls = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "WinImagePearls");
        this.winPanelImageHighScore = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "WinImageHighScore");
        this.winPanelSpecialBallName = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "WinSpecialBallName").GetComponent<UnityEngine.UI.Text>();
        this.winPanelSpecialBallCount = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "WinSpecialBallCount").GetComponent<UnityEngine.UI.Text>();
        this.winPanelSpecialBallImage = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "WinSpecialBallImage");
        UnityEngine.GameObject val_53 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "WinPowerUpEarned");
        this.winPanelPowerUpsEarned = val_53;
        val_53.SetActive(value:  false);
        UnityEngine.GameObject val_54 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "WinShellsEarned");
        this.winPanelShellsEarned = val_54;
        val_54.SetActive(value:  false);
        this.star1 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "Star1");
        this.star2 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "Star2");
        this.star3 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "Star3");
        this.star1.SetActive(value:  false);
        this.star2.SetActive(value:  false);
        this.star3.SetActive(value:  false);
        this.pearlsEarnedText = UnityEngine.GameObject.FindWithTag(tag:  "PearlsEarned").gameObject.GetComponent<UnityEngine.UI.Text>();
        this.winPanelScoreText = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "WinPanelScore").GetComponent<UnityEngine.UI.Text>();
        this.highScoreStageText = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "WinPanelHighScore").GetComponent<UnityEngine.UI.Text>();
        UnityEngine.GameObject val_65 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "WinPanel");
        this.win_Panel = val_65;
        val_65.SetActive(value:  false);
        this.pvpWinnerText = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "PVPWinText");
        this.pvpScoreText = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "PVPScoreText");
        UnityEngine.GameObject val_68 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "LosePose");
        this.losePose = val_68;
        val_68.panelInkUpTutorial.SetActive(value:  false);
        UnityEngine.GameObject val_70 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "PanelTutorial");
        this.tutorialPanel = val_70;
        val_70.SetActive(value:  false);
        UnityEngine.GameObject val_71 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "LosePanel");
        this.losePanel = val_71;
        val_71.SetActive(value:  false);
        val_71.sorryPanel.SetActive(value:  false);
        val_83 = null;
        val_83 = null;
        LineController.bossRessurectionReload = false;
    }
    public void Start()
    {
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_61;
        var val_62;
        var val_63;
        var val_67;
        var val_70;
        var val_71;
        this.stuntime = 0f;
        SyncState.ResetMismatchCounts();
        GlobalInfo.Refresh();
        val_52 = null;
        val_52 = null;
        LineControllerAI.numberOfPops = 0;
        val_53 = null;
        val_53 = null;
        LineControllerP2.numberOfPops = 0;
        val_54 = null;
        val_54 = null;
        LineController.numberOfPops = 0;
        if(this.modeName != 5)
        {
                this.entryIndicators.SetActive(value:  true);
        }
        
        val_55 = null;
        val_55 = null;
        this.angleHandler = (InstanceAnimator.playerNegateX == 1) ? 0 : 180;
        this.stunCounter.gameObject.SetActive(value:  false);
        this.inkHitting = true;
        val_56 = null;
        val_56 = null;
        LineController.bigText = false;
        LineController.inkMeterAnimationFlag = false;
        this.lifeHandler.SetActive(value:  false);
        this.specialBallButton.interactable = false;
        this.specialBallButtonArrow.interactable = false;
        this.<characterUnlockPanel>k__BackingField.SetActive(value:  false);
        LineController.flagForDestroyBallsAnim = false;
        this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        UnityEngine.Vector3 val_6 = this.playerChar.transform.position;
        this.characterPos = val_6;
        mem[1152921526240412308] = val_6.y;
        mem[1152921526240412312] = val_6.z;
        this.originalPos = val_6;
        mem[1152921526240412296] = val_6.y;
        mem[1152921526240412300] = val_6.z;
        this.shallHitInk = false;
        this.inkMeter.SetActive(value:  false);
        this.crackedPuzzleText.SetActive(value:  false);
        this.stageClearedText.SetActive(value:  false);
        LineController.bossRessurectFlag = false;
        LineController.bossRessurectFlagForCpu = false;
        this.ExBattleDefeated.SetActive(value:  false);
        this.ExBattleVictory.SetActive(value:  false);
        this.stunSequenceFlag = false;
        LineController.numberOfPops = 0;
        LineController.receiveDamageFlag = false;
        LineController.inkBubbles = new UnityEngine.GameObject[39];
        LineController.InkingSequence = false;
        this.ballsUsed = 0;
        this.gamePaused = false;
        LineController.stunFlag = false;
        LineController.playerLose = false;
        LineController.playerWin = false;
        if(this.playerBall == 0)
        {
                val_57 = null;
            val_57 = null;
            float val_57 = (float)InstanceAnimator.playerNegateX;
            val_57 = -(InstanceAnimator.UniversalX * val_57);
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.identity;
            UnityEngine.Rigidbody2D val_10 = UnityEngine.Object.Instantiate<UnityEngine.Rigidbody2D>(original:  this.playerBalls[0], position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w});
            this.playerBall = val_10;
            val_10.gameObject.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        
        this.forceFlag = true;
        val_58 = null;
        val_58 = null;
        LineController.touchFlag = false;
        this.setTouchPos = false;
        this.win_Panel.SetActive(value:  false);
        this.camera_Shake.SetActive(value:  false);
        this.winSequenceFlag = true;
        this.looseSequenceFlag = true;
        this.isWaiting = false;
        LineController.BridgeStunP1 = 0;
        LineController.remainingBallsCount = 0;
        this.lineRenderer.GetComponent<UnityEngine.Animator>().Play(stateName:  "White");
        UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  this.LoadResources());
        UnityEngine.GameObject val_16 = UnityEngine.GameObject.Find(name:  "SceneHolder(Clone)");
        this.canvasCharacterBases = val_16.transform.Find(n:  "Flipper/Phone/Canvas_CharacterBases").gameObject.GetComponent<UnityEngine.Canvas>();
        this.canvasCharacterAnims = val_16.transform.Find(n:  "Flipper/Phone/Canvas_CharacterAnimations").gameObject.GetComponent<UnityEngine.Canvas>();
        System.Collections.IEnumerator val_26 = this.lineRenderer.transform.GetEnumerator();
        label_81:
        var val_58 = 0;
        val_58 = val_58 + 1;
        if(val_26.MoveNext() == false)
        {
            goto label_66;
        }
        
        var val_59 = 0;
        val_59 = val_59 + 1;
        val_61 = val_26.Current;
        if(val_61 != null)
        {
                val_61 = 0;
        }
        
        bool val_35 = UnityEngine.Object.op_Implicit(exists:  val_61.gameObject.GetComponent<UnityEngine.SpriteRenderer>());
        goto label_81;
        label_66:
        val_62 = 0;
        val_63 = 0;
        if(val_26 != null)
        {
                var val_60 = 0;
            val_60 = val_60 + 1;
            val_26.Dispose();
        }
        
        if( == 1)
        {
            goto label_98;
        }
        
        var val_37 = (759 == 759) ? 1 : 0;
        val_37 = (( >= 0) ? 1 : 0) & val_37;
        val_37 =  - val_37;
        val_37 = val_37 + 1;
        val_67 = (long)val_37;
        if(val_16 != null)
        {
            goto label_125;
        }
        
        label_126:
        label_125:
        System.Collections.IEnumerator val_43 = val_16.transform.Find(n:  "AnimatedTextSprites").gameObject.transform.GetEnumerator();
        label_124:
        var val_61 = 0;
        val_61 = val_61 + 1;
        if(val_43.MoveNext() == false)
        {
            goto label_109;
        }
        
        var val_62 = 0;
        val_62 = val_62 + 1;
        val_70 = val_43.Current;
        if(val_70 != null)
        {
                val_70 = 0;
        }
        
        bool val_54 = UnityEngine.Object.op_Implicit(exists:  val_70.gameObject.GetComponent<UnityEngine.SpriteRenderer>());
        goto label_124;
        label_98:
        if(val_16 != null)
        {
            goto label_125;
        }
        
        goto label_126;
        label_109:
        val_71 = 0;
        mem2[0] = 847;
        if(val_43 != null)
        {
                var val_63 = 0;
            val_63 = val_63 + 1;
            val_43.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    private void Update()
    {
        UnityEngine.Touch[] val_133;
        var val_134;
        float val_135;
        float val_136;
        float val_137;
        float val_138;
        float val_139;
        var val_143;
        var val_145;
        float val_146;
        var val_147;
        var val_150;
        var val_152;
        var val_153;
        var val_154;
        var val_155;
        var val_156;
        var val_157;
        var val_158;
        float val_160;
        var val_161;
        int val_162;
        var val_163;
        var val_164;
        var val_166;
        var val_167;
        var val_170;
        var val_171;
        var val_174;
        var val_175;
        var val_176;
        bool val_177;
        var val_178;
        var val_181;
        var val_182;
        var val_183;
        var val_184;
        var val_187;
        var val_188;
        var val_192;
        var val_193;
        var val_194;
        ActivateOnStart.SetOrthographicSize(mainCam:  ActivateOnStart.Instance.mainCam);
        if(NetworkDelayOverlay.IsWaiting == true)
        {
                return;
        }
        
        val_133 = ControlKludges.Touches;
        this.myTouch = val_133;
        if(this.modeName != 5)
        {
            goto label_3;
        }
        
        goto label_4;
        label_19:
        val_134 = 0;
        if(this.touch.fingerId == 32.fingerId)
        {
            goto label_17;
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B});
        val_135 = val_6.x;
        val_136 = val_6.z;
        val_137 = val_135;
        val_138 = val_6.y;
        val_139 = val_136;
        UnityEngine.Vector3 val_7 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_137, y = val_138, z = val_139});
        if((val_7.x < 0) && (this.setTouchPos != true))
        {
                if(32.Seconds == 0)
        {
            goto label_17;
        }
        
        }
        
        val_133 = this.myTouch;
        label_4:
        if(1 < this.myTouch.Length)
        {
            goto label_19;
        }
        
        goto label_53;
        label_3:
        val_143 = 1152921505075376128;
        val_134 = 0;
        goto label_21;
        label_52:
        if(this.touch.fingerId == 32.fingerId)
        {
            goto label_50;
        }
        
        if(InstanceAnimator.playerNegateX != 1)
        {
            goto label_27;
        }
        
        UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B});
        val_135 = val_12.x;
        val_136 = val_12.z;
        val_137 = val_135;
        val_138 = val_12.y;
        val_139 = val_136;
        UnityEngine.Vector3 val_13 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_137, y = val_138, z = val_139});
        if(val_13.x < 0)
        {
            goto label_33;
        }
        
        label_27:
        if(InstanceAnimator.playerNegateX != 1)
        {
            goto label_47;
        }
        
        UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
        val_135 = val_15.x;
        val_136 = val_15.z;
        val_137 = val_135;
        val_138 = val_15.y;
        val_139 = val_136;
        UnityEngine.Vector3 val_16 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_137, y = val_138, z = val_139});
        if(val_16.x <= 3.86f)
        {
            goto label_47;
        }
        
        label_33:
        if(((UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject(pointerId:  this.touch.fingerId)) != true) && (this.setTouchPos != true))
        {
                if(32.Seconds == 0)
        {
            goto label_50;
        }
        
        }
        
        label_47:
        val_133 = this.myTouch;
        val_134 = 1;
        label_21:
        if(val_134 < this.myTouch.Length)
        {
            goto label_52;
        }
        
        goto label_53;
        label_17:
        val_133 = this.myTouch;
        if(0 < this.myTouch.Length)
        {
            goto label_56;
        }
        
        goto label_56;
        label_50:
        val_133 = this.myTouch;
        label_56:
        label_53:
        int val_138 = this.inkstack;
        val_138 = val_138 - 1;
        if((val_134 >= this.myTouch.Length) && (this.inkball != true))
        {
                this.inkstack = val_138;
            this.inkball = true;
        }
        
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
            goto label_123;
        }
        
        val_133 = 1152921505075642368;
        if(LineController.InkingSequence == false)
        {
            goto label_123;
        }
        
        UnityEngine.Vector3 val_23 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_24 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        val_136 = val_24.z;
        val_137 = val_24.x;
        val_138 = val_24.y;
        UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_137, y = val_138, z = val_136});
        val_139 = -3.5f;
        val_135 = val_25.x;
        if(val_25.y <= val_139)
        {
            goto label_69;
        }
        
        val_137 = 3.5f;
        if(val_25.y >= 0)
        {
            goto label_69;
        }
        
        if(InstanceAnimator.playerNegateX != 1)
        {
            goto label_75;
        }
        
        float val_139 = -3.86f;
        val_139 = val_139 - InstanceAnimator.UniversalX;
        if(val_135 <= val_139)
        {
            goto label_75;
        }
        
        float val_140 = InstanceAnimator.UniversalX;
        val_140 = 0.64f - val_140;
        if(val_135 >= 0)
        {
            goto label_78;
        }
        
        goto label_119;
        label_69:
        val_134 = 1;
        label_131:
        val_133 = 0.ToString() + "Inside Inking Sequence";
        UnityEngine.Debug.Log(message:  val_133);
        if(this.modeName != 5)
        {
            goto label_82;
        }
        
        val_133 = 1152921505077932032;
        var val_141 = 0;
        val_141 = val_141 & LineControllerP2.player2Win;
        if(val_141 == false)
        {
            goto label_85;
        }
        
        if(NetworkManager_Custom.IsNetwork == false)
        {
            goto label_122;
        }
        
        goto label_123;
        label_82:
        if((val_134 & 1) != 0)
        {
            goto label_123;
        }
        
        label_122:
        this.inkball = true;
        label_123:
        if(this.touch.Seconds != 3)
        {
            goto label_148;
        }
        
        this.touch.fingerId = 0;
        System.Collections.IEnumerator val_32 = this.lineRenderer.transform.GetEnumerator();
        val_135 = 255f;
        label_110:
        if((val_32 & 1) == 0)
        {
            goto label_97;
        }
        
        UnityEngine.Color val_40 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        0.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_40.r, g = val_40.g, b = val_40.b, a = val_40.a};
        goto label_110;
        label_75:
        label_78:
        if(InstanceAnimator.playerNegateX != 1)
        {
            goto label_116;
        }
        
        float val_142 = 3.86f;
        val_142 = InstanceAnimator.UniversalX + val_142;
        if(val_135 >= 0)
        {
            goto label_116;
        }
        
        float val_143 = InstanceAnimator.UniversalX;
        val_143 = val_143 + (-0.64f);
        var val_41 = (val_135 > val_143) ? 1 : 0;
        goto label_119;
        label_85:
        bool val_144 = LineControllerP2.player2Win;
        val_144 = val_144 ^ 1;
        val_144 = 0 & val_144;
        if(val_144 == true)
        {
            goto label_122;
        }
        
        goto label_123;
        label_116:
        label_119:
        var val_42 = (0 == 0) ? 1 : 0;
        if(((val_25.y < 0) ? 1 : 0) == 0)
        {
            goto label_131;
        }
        
        float val_145 = 3.86f;
        val_145 = InstanceAnimator.UniversalX + val_145;
        if(val_135 >= 0)
        {
            goto label_131;
        }
        
        float val_146 = InstanceAnimator.UniversalX;
        val_146 = val_146 + (-0.64f);
        var val_43 = (val_135 > val_146) ? 1 : 0;
        goto label_131;
        label_97:
        val_134 = 0;
        val_133 = val_32;
        if( == 1)
        {
            goto label_148;
        }
        
        var val_45 = (980 == 980) ? 1 : 0;
        val_45 = (( >= 0) ? 1 : 0) & val_45;
        val_145 =  - val_45;
        goto label_149;
        label_148:
        val_145 = 0;
        label_149:
        if(this.isForDemo == false)
        {
            goto label_170;
        }
        
        val_133 = this.blackDemo.transform;
        UnityEngine.Vector3 val_48 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_50 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z}, d:  UnityEngine.Time.unscaledDeltaTime);
        val_146 = 30f;
        UnityEngine.Vector3 val_51 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z}, d:  val_146);
        val_135 = val_51.x;
        val_136 = val_51.z;
        val_137 = val_135;
        val_138 = val_51.y;
        val_139 = val_136;
        val_133.Translate(translation:  new UnityEngine.Vector3() {x = val_137, y = val_138, z = val_139});
        if(InstanceAnimator.playerNegateX != 1)
        {
            goto label_157;
        }
        
        val_133 = this.blackDemo.transform;
        UnityEngine.Vector3 val_53 = val_133.position;
        val_135 = val_53.x;
        val_138 = InstanceAnimator.UniversalX;
        val_137 = val_138 * (float)InstanceAnimator.playerNegateX;
        if(val_135 >= val_137)
        {
            goto label_162;
        }
        
        label_157:
        if(InstanceAnimator.playerNegateX != 1)
        {
            goto label_170;
        }
        
        val_133 = this.blackDemo.transform;
        UnityEngine.Vector3 val_55 = val_133.position;
        val_135 = val_55.x;
        val_138 = InstanceAnimator.UniversalX;
        val_137 = val_138 * (float)InstanceAnimator.playerNegateX;
        if(val_135 > val_137)
        {
            goto label_170;
        }
        
        label_162:
        val_133 = this.blackDemo.transform;
        float val_147 = (float)InstanceAnimator.playerNegateX;
        val_147 = -(InstanceAnimator.UniversalX * val_147);
        val_137 = 0f;
        val_138 = 0f;
        val_139 = 0f;
        val_133.position = new UnityEngine.Vector3() {x = val_137, y = val_138, z = val_139};
        this.ShootInTutorial();
        label_170:
        if((InstanceAnimator.areBallsInstantiated != false) && (NetworkManager_Custom.IsNetwork != false))
        {
                val_133 = NetworkManager_Custom.stringRPCMessageId;
            if((NetworkManager_Custom.stringRPCMessageId + 264) != 0)
        {
                val_133 = 1152921505075642368;
            if(LineController.InkingSequence != true)
        {
                val_135 = this.syncTime;
            val_137 = val_135 - UnityEngine.Time.deltaTime;
            this.syncTime = val_137;
            if(val_137 <= 0f)
        {
                val_138 = 1f;
            val_137 = val_137 + val_138;
            this.syncTime = val_137;
            val_133 = NetworkBehaviour_PlayScene.syncMessageId;
            val_133.ServerSendSyncMessage();
        }
        
        }
        
        }
        
        }
        
        if(this.IsGameOnHold() == true)
        {
                return;
        }
        
        if(this.modeName == 5)
        {
                val_133 = 1152921505077932032;
            if(LineControllerP2.stunFlag != false)
        {
                this.StunFunction();
        }
        else
        {
                val_133 = 1152921505075642368;
            if(LineController.receiveDamageFlag != false)
        {
                this.ReceiveDamageFunction();
        }
        
        }
        
        }
        
        if(this.touch.Seconds != 3)
        {
            goto label_199;
        }
        
        if(this.animController.currentAnimationName == 1)
        {
            goto label_197;
        }
        
        val_133 = this.animController;
        if(this.animController.currentAnimationName != 2)
        {
            goto label_199;
        }
        
        label_197:
        val_133 = this.animController;
        val_133.PlayAnimation(newAnimName:  8, forceOverride:  false);
        label_199:
        if((this.touch.fingerId & 2147483648) != 0)
        {
            goto label_249;
        }
        
        val_133 = 1152921505075642368;
        if(LineController.touchFlag != true)
        {
                if(this.modeName != 1)
        {
            goto label_205;
        }
        
        }
        
        if(((LineController.touchFlag == true) || (this.modeName != 1)) || (this.stunSequenceFlag == true))
        {
            goto label_249;
        }
        
        label_205:
        System.Collections.IEnumerator val_63 = this.lineRenderer.transform.GetEnumerator();
        val_135 = 255f;
        val_143 = 1152921526024376896;
        label_231:
        if((val_63 & 1) == 0)
        {
            goto label_218;
        }
        
        UnityEngine.Color val_71 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        0.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_71.r, g = val_71.g, b = val_71.b, a = val_71.a};
        goto label_231;
        label_218:
        val_147 = 0;
        val_134 = 1152921504621170688;
        val_133 = val_63;
        if(val_133 != null)
        {
                var val_148 = 0;
            val_148 = val_148 + 1;
            val_133.Dispose();
        }
        
        if(1 != 1)
        {
                var val_73 = (1522 == 1522) ? 1 : 0;
            val_73 = ((1 >= 0) ? 1 : 0) & val_73;
            val_145 = 1 - val_73;
        }
        else
        {
                val_145 = 0;
        }
        
        label_249:
        if(this.winSequenceFlag == false)
        {
            goto label_259;
        }
        
        val_150 = null;
        val_150 = null;
        if(InstanceAnimator.isInnerRingEmpty == false)
        {
            goto label_259;
        }
        
        val_150 = null;
        if((InstanceAnimator.isMiddleRingEmpty == false) || (InstanceAnimator.isOuterRingEmpty == false))
        {
            goto label_259;
        }
        
        this.winSequenceFlag = false;
        this.PlayerWinFunction();
        goto label_260;
        label_259:
        if(this.looseSequenceFlag == false)
        {
            goto label_327;
        }
        
        val_133 = 1152921505075642368;
        val_152 = null;
        val_152 = null;
        if((LineController.playerWin == true) || (this.modeName != 3))
        {
            goto label_266;
        }
        
        int val_149 = this.stageNumber;
        val_149 = val_149 + 3;
        if(this.ballsUsed != val_149)
        {
            goto label_266;
        }
        
        UnityEngine.SceneManagement.Scene val_75 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if(((System.String.op_Inequality(a:  val_75.m_Handle.name, b:  "DemoScene")) == true) || (this.ballsUsed == 100))
        {
            goto label_270;
        }
        
        label_266:
        if(this.looseSequenceFlag == false)
        {
            goto label_327;
        }
        
        val_153 = null;
        val_153 = null;
        if(LineController.playerWin == false)
        {
            goto label_274;
        }
        
        label_327:
        if(this.winSequenceFlag == false)
        {
                return;
        }
        
        if(this.looseSequenceFlag == false)
        {
                return;
        }
        
        val_154 = null;
        val_154 = null;
        if(LineControllerAI.stunFlag == true)
        {
            goto label_279;
        }
        
        val_155 = null;
        val_155 = null;
        if(LineControllerP2.stunFlag == false)
        {
            goto label_282;
        }
        
        label_279:
        this.StunFunction();
        label_282:
        val_156 = null;
        val_156 = null;
        if(LineController.receiveDamageFlag != false)
        {
                this.ReceiveDamageFunction();
        }
        
        val_143 = 1152921504858337280;
        val_133 = this.playerBall;
        if(val_133 == 0)
        {
            goto label_509;
        }
        
        val_157 = null;
        val_157 = null;
        if(InstanceAnimator.areBallsInstantiated == false)
        {
            goto label_509;
        }
        
        val_158 = null;
        val_158 = null;
        if((((((((LineController.touchFlag != true) && (LineController.receiveDamageFlag != true)) && (this.stunSequenceFlag != true)) && (this.isWaiting != true)) && (this.animController.currentAnimationName != 8)) && (this.animController.currentAnimationName != 4)) && (this.animController.currentAnimationName != 5)) && (this.animController.currentAnimationName != 3))
        {
                this.animController.PlayAnimation(newAnimName:  8, forceOverride:  false);
        }
        
        val_133 = UnityEngine.Camera.main;
        val_134 = 1152921504859828224;
        UnityEngine.Vector3 val_80 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_137, y = val_138});
        val_136 = val_80.z;
        val_160 = val_80.x;
        UnityEngine.Vector3 val_81 = val_133.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_160, y = val_80.y, z = val_136});
        UnityEngine.Vector2 val_82 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_81.x, y = val_81.y, z = val_81.z});
        val_135 = val_82.y;
        if(this.touch.Seconds != 1)
        {
            goto label_383;
        }
        
        if(this.setTouchPos != true)
        {
                this.startPos = val_82;
            mem[1152921526241556780] = val_82.y;
        }
        
        val_161 = null;
        val_161 = null;
        val_162 = InstanceAnimator.playerNegateX;
        if((val_82.x >= 0) || (val_162 != 1))
        {
            goto label_317;
        }
        
        val_163 = 1;
        goto label_332;
        label_274:
        val_164 = null;
        val_164 = null;
        if(InstanceAnimator.isPlayerInnerRingEmpty == false)
        {
            goto label_327;
        }
        
        val_164 = null;
        if((InstanceAnimator.isPlayerMiddleRingEmpty == false) || (InstanceAnimator.isPlayerOuterRingEmpty == false))
        {
            goto label_327;
        }
        
        label_270:
        this.looseSequenceFlag = false;
        this.PlayerLoseFunction();
        label_260:
        this.ShowAimLine(show:  false);
        return;
        label_317:
        val_162 = InstanceAnimator.playerNegateX;
        if(val_162 != 1)
        {
                val_163 = 0;
        }
        
        label_332:
        val_166 = null;
        val_166 = null;
        val_160 = -4f;
        var val_85 = (Character_GlobalInfo.gameMode != 3) ? 1 : 0;
        val_85 = ((val_135 > val_160) ? 1 : 0) | val_85;
        val_85 = ((val_82.x > 3.86f) ? 1 : 0) & val_85;
        if(val_85 == 0)
        {
            goto label_376;
        }
        
        val_167 = null;
        val_167 = null;
        LineController.touchFlag = true;
        this.setTouchPos = true;
        System.Collections.IEnumerator val_88 = this.lineRenderer.transform.GetEnumerator();
        val_135 = 255f;
        label_358:
        var val_150 = 0;
        val_150 = val_150 + 1;
        if(val_88.MoveNext() == false)
        {
            goto label_345;
        }
        
        var val_151 = 0;
        val_151 = val_151 + 1;
        val_170 = val_88.Current;
        if(val_170 != null)
        {
                val_170 = 0;
        }
        
        UnityEngine.Color val_98 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_170.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_98.r, g = val_98.g, b = val_98.b, a = val_98.a};
        goto label_358;
        label_345:
        val_171 = 0;
        val_145 = val_145 + 1;
        mem2[0] = 2236;
        val_133 = val_88;
        if(val_133 != null)
        {
                var val_152 = 0;
            val_152 = val_152 + 1;
            val_133.Dispose();
        }
        
        val_134 = 1152921504859828224;
        if(val_145 == 1)
        {
            goto label_375;
        }
        
        if((159860912 + ((val_145 + 1)) << 2) != 2236)
        {
            goto label_376;
        }
        
        var val_153 = 0;
        val_153 = val_153 ^ (val_145 >> 31);
        val_145 = val_145 + val_153;
        goto label_383;
        label_375:
        val_145 = 0;
        label_376:
        val_174 = null;
        val_174 = null;
        LineController.touchFlag = false;
        this.setTouchPos = false;
        if(this.animController.currentAnimationName == 2)
        {
            goto label_381;
        }
        
        val_133 = this.animController;
        if(this.animController.currentAnimationName != 1)
        {
            goto label_383;
        }
        
        label_381:
        val_133 = this.animController;
        val_133.PlayAnimation(newAnimName:  8, forceOverride:  true);
        label_383:
        if(this.touch.Seconds == 3)
        {
            goto label_389;
        }
        
        val_175 = null;
        val_175 = null;
        if((LineController.touchFlag == false) || (this.setTouchPos == false))
        {
            goto label_389;
        }
        
        val_135 = val_160;
        this.endPos = val_135;
        mem[1152921526241556788] = val_82.y;
        val_146 = val_136;
        UnityEngine.Vector2 val_101 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_135, y = val_82.y}, b:  new UnityEngine.Vector2() {x = this.startPos, y = val_146});
        this.diff = val_101;
        mem[1152921526241556796] = val_101.y;
        val_176 = null;
        val_176 = null;
        if(InstanceAnimator.areBallsInstantiated == false)
        {
            goto label_394;
        }
        
        if(this.setup == false)
        {
            goto label_395;
        }
        
        val_177 = 0;
        this.setup = false;
        goto label_396;
        label_389:
        val_133 = this.animController;
        if(this.animController.currentAnimationName == 1)
        {
            goto label_398;
        }
        
        val_133 = this.animController;
        if(this.animController.currentAnimationName != 2)
        {
            goto label_509;
        }
        
        label_398:
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) != true)
        {
                if(this.touch.Seconds != 3)
        {
            goto label_509;
        }
        
        }
        
        if(this.stunSequenceFlag == true)
        {
            goto label_509;
        }
        
        val_178 = null;
        val_178 = null;
        if(LineController.receiveDamageFlag == true)
        {
            goto label_509;
        }
        
        UnityEngine.Vector2 val_104 = UnityEngine.Vector2.zero;
        this.diff = val_104;
        mem[1152921526241556796] = val_104.y;
        this.endPos = val_104;
        mem[1152921526241556788] = val_104.y;
        this.startPos = val_104;
        mem[1152921526241556780] = val_104.y;
        System.Collections.IEnumerator val_106 = this.lineRenderer.transform.GetEnumerator();
        label_429:
        var val_154 = 0;
        val_154 = val_154 + 1;
        if(val_106.MoveNext() == false)
        {
            goto label_416;
        }
        
        var val_155 = 0;
        val_155 = val_155 + 1;
        val_181 = val_106.Current;
        if(val_181 != null)
        {
                val_181 = 0;
        }
        
        UnityEngine.Color val_116 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_181.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_116.r, g = val_116.g, b = val_116.b, a = val_116.a};
        goto label_429;
        label_394:
        val_177 = true;
        label_396:
        this.isWaiting = val_177;
        label_395:
        this.MoveAimLine(differenceY:  val_101.x, ballEntryVariable: ref  this.ballEntryTemp);
        label_509:
        if(this.touch.Seconds == 3)
        {
                val_182 = null;
            val_182 = null;
            LineController.touchFlag = false;
            this.setTouchPos = false;
        }
        
        val_183 = null;
        val_183 = null;
        if(InstanceAnimator.areBallsInstantiated == false)
        {
                return;
        }
        
        if(this.winSequenceFlag == false)
        {
                return;
        }
        
        if(this.looseSequenceFlag == false)
        {
                return;
        }
        
        if(this.stunSequenceFlag == true)
        {
                return;
        }
        
        if(this.playerBall != 0)
        {
                return;
        }
        
        val_184 = null;
        val_184 = null;
        float val_157 = (float)InstanceAnimator.playerNegateX;
        val_157 = -(InstanceAnimator.UniversalX * val_157);
        UnityEngine.Quaternion val_120 = UnityEngine.Quaternion.identity;
        val_135 = val_120.x;
        val_136 = val_120.z;
        UnityEngine.Rigidbody2D val_121 = UnityEngine.Object.Instantiate<UnityEngine.Rigidbody2D>(original:  this.playerBalls[0], position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_135, y = val_120.y, z = val_136, w = val_120.w});
        this.playerBall = val_121;
        val_121.gameObject.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        System.Collections.IEnumerator val_126 = this.playerBall.gameObject.transform.GetEnumerator();
        val_134 = 1152921504865153024;
        label_474:
        var val_158 = 0;
        val_158 = val_158 + 1;
        if(val_126.MoveNext() == false)
        {
            goto label_461;
        }
        
        var val_159 = 0;
        val_159 = val_159 + 1;
        val_187 = val_126.Current;
        if(val_187 != null)
        {
                val_187 = 0;
        }
        
        val_187.gameObject.SetActive(value:  false);
        goto label_474;
        label_461:
        val_133 = 0;
        var val_134 = val_145 + 1;
        mem2[0] = 2912;
        goto label_475;
        label_416:
        val_188 = 0;
        val_145 = val_145 + 1;
        mem2[0] = 2595;
        if(val_106 != null)
        {
                var val_160 = 0;
            val_160 = val_160 + 1;
            val_106.Dispose();
        }
        
        if(val_145 != 1)
        {
                var val_136 = ((159860912 + ((val_145 + 1)) << 2) == 2595) ? 1 : 0;
            val_136 = ((val_145 >= 0) ? 1 : 0) & val_136;
            val_145 = val_145 - val_136;
        }
        
        if((((this.setTouchPos == false) || (this.isWaiting == true)) || (this.stunSequenceFlag == true)) || (this.forceFlag == false))
        {
            goto label_509;
        }
        
        val_192 = null;
        val_192 = null;
        if(LineController.touchFlag == false)
        {
            goto label_509;
        }
        
        val_193 = null;
        val_193 = null;
        if(InstanceAnimator.areBallsInstantiated == false)
        {
            goto label_509;
        }
        
        this.ShootBubble();
        goto label_509;
        label_475:
        if(this.touch == 0)
        {
            goto label_513;
        }
        
        int val_163 = this.touch.m_FingerId;
        if((this.touch.m_FingerId + 286) == 0)
        {
            goto label_517;
        }
        
        var val_161 = this.touch.m_FingerId + 176;
        var val_162 = 0;
        val_161 = val_161 + 8;
        label_516:
        if(((this.touch.m_FingerId + 176 + 8) + -8) == null)
        {
            goto label_515;
        }
        
        val_162 = val_162 + 1;
        val_161 = val_161 + 16;
        if(val_162 < (this.touch.m_FingerId + 286))
        {
            goto label_516;
        }
        
        goto label_517;
        label_515:
        val_163 = val_163 + (((this.touch.m_FingerId + 176 + 8)) << 4);
        val_194 = val_163 + 296;
        label_517:
        this.touch.Dispose();
        label_513:
        this.forceFlag = true;
    }
    public void MoveAimLine(float differenceY, ref int ballEntryVariable)
    {
        var val_16;
        var val_18;
        System.Int32[] val_68;
        float val_69;
        var val_71;
        var val_72;
        var val_74;
        int val_75;
        var val_76;
        var val_77;
        float val_78;
        float val_79;
        var val_80;
        var val_81;
        var val_82;
        var val_83;
        var val_84;
        var val_85;
        var val_86;
        val_68 = 1152921526242795424;
        val_69 = 0;
        this.playerBall.gameObject.transform.Find(n:  "TrailNormal").gameObject.SetActive(value:  false);
        if(GlobalInfo.innerAimDifference < differenceY)
        {
            goto label_14;
        }
        
        val_69 = -GlobalInfo.innerAimDifference;
        if((val_69 > differenceY) || ((System.String.op_Inequality(a:  this.swipedBall.GetComponent<ballSwipeScript>().gameObject.tag, b:  "Stunner_Ball")) == false))
        {
            goto label_14;
        }
        
        if((this.isWaiting != true) && (this.stunSequenceFlag != true))
        {
                if((this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount) >= 1f)
        {
            goto label_20;
        }
        
        }
        
        val_71 = 1152921526109146016;
        UnityEngine.AnimatorStateInfo val_15 = this.lineRenderer.GetComponent<UnityEngine.Animator>().GetCurrentAnimatorStateInfo(layerIndex:  0);
        val_72 = val_16;
        val_74 = "MiddleRed";
        goto label_91;
        label_14:
        if((this.isWaiting != true) && (this.stunSequenceFlag != true))
        {
                if((this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount) >= 1f)
        {
            goto label_29;
        }
        
        }
        
        val_71 = 1152921526109146016;
        UnityEngine.AnimatorStateInfo val_23 = this.lineRenderer.GetComponent<UnityEngine.Animator>().GetCurrentAnimatorStateInfo(layerIndex:  0);
        val_72 = val_16;
        val_74 = "Red";
        label_91:
        if((161067856 & 1) == 0)
        {
                this.lineRenderer.GetComponent<UnityEngine.Animator>().Play(stateName:  "Red");
        }
        
        label_133:
        if((this.swipedBall.GetComponent<ballSwipeScript>().gameObject.CompareTag(tag:  "Stunner_Ball")) == true)
        {
            goto label_43;
        }
        
        if(GlobalInfo.innerAimDifference < differenceY)
        {
            goto label_42;
        }
        
        val_69 = -GlobalInfo.innerAimDifference;
        if(val_69 <= differenceY)
        {
            goto label_43;
        }
        
        label_42:
        if((-GlobalInfo.outerAimDifference) <= differenceY)
        {
            goto label_44;
        }
        
        val_18 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_75 = this.angleHandler;
        val_76 = null;
        val_76 = null;
        float val_68 = (float)-InstanceAnimator.playerNegateX;
        val_68 = GlobalInfo.ballOuterEntryAngle * val_68;
        float val_33 = (float)val_75 - val_68;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_119:
        ballEntryVariable = 1;
        goto label_73;
        label_43:
        val_18 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_75 = this.angleHandler;
        val_77 = null;
        val_77 = null;
        float val_70 = 0f;
        float val_69 = (float)-InstanceAnimator.playerNegateX;
        val_69 = val_69 * val_70;
        val_70 = (float)val_75 - val_69;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        ballEntryVariable = 0;
        label_73:
        if(NetworkManager_Custom.IsNetwork == false)
        {
                return;
        }
        
        val_75 = 1152921505072660480;
        if(NetworkBehaviour_PlayScene.syncMessageId == 0)
        {
                return;
        }
        
        int[] val_38 = new int[1];
        val_68 = val_38;
        val_68[0] = ballEntryVariable;
        NetworkBehaviour_PlayScene.syncMessageId.sendFunctionRPC(functionNumber:  0, intVariables:  val_38, string1:  "");
        return;
        label_44:
        val_78 = -GlobalInfo.middleAimDifference;
        if(val_78 <= differenceY)
        {
            goto label_65;
        }
        
        val_78 = -GlobalInfo.outerAimDifference;
        if(val_78 <= differenceY)
        {
            goto label_66;
        }
        
        label_65:
        val_79 = -GlobalInfo.innerAimDifference;
        if(val_79 <= differenceY)
        {
            goto label_67;
        }
        
        val_79 = -GlobalInfo.middleAimDifference;
        if(val_79 <= differenceY)
        {
            goto label_68;
        }
        
        label_67:
        if(GlobalInfo.innerAimDifference < 0)
        {
                if(GlobalInfo.middleAimDifference >= differenceY)
        {
            goto label_70;
        }
        
        }
        
        if(GlobalInfo.middleAimDifference < 0)
        {
                if(GlobalInfo.outerAimDifference >= differenceY)
        {
            goto label_72;
        }
        
        }
        
        if(GlobalInfo.outerAimDifference >= 0)
        {
            goto label_73;
        }
        
        val_18 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_80 = null;
        val_80 = null;
        float val_71 = (float)-InstanceAnimator.playerNegateX;
        val_71 = GlobalInfo.ballOuterEntryAngle * val_71;
        float val_50 = val_71 + (float)this.angleHandler;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_119;
        label_29:
        if((this.animController.currentAnimationName != 1) && (this.animController.currentAnimationName != 2))
        {
                val_81 = null;
            val_81 = null;
            VoiceManager.instance.PlayAttackSound(Left:  1, SoundType:  5, modifiers:  0);
            VoiceManager.instance.SendAttackChargeAnimation();
            this.animController.PlayAnimation(newAnimName:  1, forceOverride:  false);
        }
        
        UnityEngine.AnimatorStateInfo val_52 = this.lineRenderer.GetComponent<UnityEngine.Animator>().GetCurrentAnimatorStateInfo(layerIndex:  0);
        goto label_91;
        label_66:
        val_18 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_82 = null;
        val_82 = null;
        float val_72 = (float)-InstanceAnimator.playerNegateX;
        val_72 = GlobalInfo.ballMiddleEntryAngle * val_72;
        float val_55 = (float)this.angleHandler - val_72;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_119;
        label_68:
        val_18 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_83 = null;
        val_83 = null;
        float val_73 = (float)-InstanceAnimator.playerNegateX;
        val_73 = GlobalInfo.MIN_CONTROL_SENSITIVE * val_73;
        float val_58 = (float)this.angleHandler - val_73;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_119;
        label_70:
        val_18 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_84 = null;
        val_84 = null;
        float val_74 = (float)-InstanceAnimator.playerNegateX;
        val_74 = GlobalInfo.MIN_CONTROL_SENSITIVE * val_74;
        float val_61 = val_74 + (float)this.angleHandler;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_119;
        label_72:
        val_18 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_85 = null;
        val_85 = null;
        float val_75 = (float)-InstanceAnimator.playerNegateX;
        val_75 = GlobalInfo.ballMiddleEntryAngle * val_75;
        float val_64 = val_75 + (float)this.angleHandler;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_119;
        label_20:
        UnityEngine.AnimatorStateInfo val_66 = this.lineRenderer.GetComponent<UnityEngine.Animator>().GetCurrentAnimatorStateInfo(layerIndex:  0);
        if((161067856 & 1) == 0)
        {
                this.lineRenderer.GetComponent<UnityEngine.Animator>().Play(stateName:  "MiddleWhite");
        }
        
        if((this.animController.currentAnimationName == 1) || (this.animController.currentAnimationName == 2))
        {
            goto label_133;
        }
        
        val_86 = null;
        val_86 = null;
        VoiceManager.instance.PlayAttackSound(Left:  1, SoundType:  5, modifiers:  0);
        VoiceManager.instance.SendAttackChargeAnimation();
        this.animController.PlayAnimation(newAnimName:  1, forceOverride:  false);
        goto label_133;
    }
    private void SendAttackChargeAnimation()
    {
        if(NetworkManager_Custom.IsNetwork == false)
        {
                return;
        }
        
        NetworkBehaviour_PlayScene.syncMessageId.sendFunctionRPC(functionNumber:  5, intVariables:  new int[1], string1:  "");
    }
    public void ShootBubble()
    {
        int val_152;
        int val_153;
        int val_154;
        var val_155;
        var val_156;
        var val_157;
        var val_163;
        var val_164;
        var val_165;
        var val_166;
        float val_167;
        var val_168;
        float val_169;
        var val_173;
        string val_174;
        var val_175;
        var val_176;
        if(NetworkManager_Custom.IsNetwork == false)
        {
            goto label_1;
        }
        
        string val_4 = this.swipedBall.GetComponent<ballSwipeScript>().gameObject.tag;
        uint val_5 = _PrivateImplementationDetails_.ComputeStringHash(s:  val_4);
        if(val_5 > (-1551951748))
        {
            goto label_8;
        }
        
        if(val_5 == (-2049731628))
        {
            goto label_9;
        }
        
        if(val_5 == (-1551951748))
        {
            goto label_10;
        }
        
        if((val_5 != 1920678155) || ((System.String.op_Equality(a:  val_4, b:  "Orange")) == false))
        {
            goto label_29;
        }
        
        val_152 = 5;
        goto label_30;
        label_1:
        val_153 = this.ballEntryTemp;
        goto label_14;
        label_8:
        if(val_5 > (-1232946657))
        {
            goto label_15;
        }
        
        if(val_5 == (-1454127268))
        {
            goto label_16;
        }
        
        if((val_5 != (-1232946657)) || ((System.String.op_Equality(a:  val_4, b:  "Purple")) == false))
        {
            goto label_29;
        }
        
        val_152 = 6;
        goto label_30;
        label_15:
        if(val_5 == (-640816023))
        {
            goto label_20;
        }
        
        if(val_5 != (-371384339))
        {
            goto label_29;
        }
        
        bool val_8 = System.String.op_Equality(a:  val_4, b:  "Blue");
        goto label_29;
        label_9:
        if((System.String.op_Equality(a:  val_4, b:  "Rainbow_Bubble")) == false)
        {
            goto label_29;
        }
        
        val_152 = 0;
        goto label_30;
        label_10:
        if((System.String.op_Equality(a:  val_4, b:  "Red")) == false)
        {
            goto label_29;
        }
        
        val_152 = 3;
        goto label_30;
        label_16:
        if((System.String.op_Equality(a:  val_4, b:  "Green")) == false)
        {
            goto label_29;
        }
        
        val_152 = 2;
        goto label_30;
        label_20:
        if((System.String.op_Equality(a:  val_4, b:  "Yellow")) == false)
        {
            goto label_29;
        }
        
        val_152 = 4;
        goto label_30;
        label_29:
        val_152 = 1;
        label_30:
        int[] val_13 = new int[2];
        val_153 = this;
        val_154 = val_13.Length;
        if(val_154 == 0)
        {
                val_154 = val_13.Length;
        }
        
        val_13[0] = this.ballEntryTemp;
        val_13[0] = val_152;
        NetworkBehaviour_PlayScene.syncMessageId.sendFunctionRPC(functionNumber:  1, intVariables:  val_13, string1:  "");
        label_14:
        val_155 = null;
        val_155 = null;
        LineController.ballEntry = this.ballEntryTemp;
        UnityEngine.Coroutine val_14 = this.StartCoroutine(methodName:  "IconMask");
        this.animController.PlayAnimation(newAnimName:  0, forceOverride:  false);
        val_156 = null;
        val_156 = null;
        VoiceManager.instance.PlayAttackSound(Left:  1, SoundType:  0, modifiers:  0);
        this.playerBall.gameObject.tag = this.swipedBall.GetComponent<ballSwipeScript>().gameObject.tag;
        this.playerBall.GetComponent<UnityEngine.SpriteRenderer>().sprite = this.swipedBall.GetComponent<ballSwipeScript>().GetComponent<UnityEngine.UI.Image>().sprite;
        this.swipedBall.GetComponent<ballSwipeScript>().SwipeBall();
        this.playerBall.gameObject.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        UnityEngine.Transform val_28 = this.playerBall.gameObject.transform.GetChild(index:  0);
        if(((this.playerBall.gameObject.CompareTag(tag:  "Color_Eraser_Ball")) != true) && ((this.playerBall.gameObject.CompareTag(tag:  "Iron_Ball")) != true))
        {
                if((this.playerBall.gameObject.CompareTag(tag:  "Stunner_Ball")) != true)
        {
                if((this.playerBall.gameObject.CompareTag(tag:  "Rainbow_Bubble")) == false)
        {
            goto label_76;
        }
        
        }
        
        }
        
        this.playerBall.gameObject.transform.Find(n:  "TrailNormal").gameObject.SetActive(value:  false);
        bool val_42 = this.playerBall.gameObject.CompareTag(tag:  "Color_Eraser_Ball");
        UnityEngine.GameObject val_43 = this.playerBall.gameObject;
        if(val_43 == null)
        {
            goto label_85;
        }
        
        if(val_42 == false)
        {
            goto label_86;
        }
        
        label_139:
        val_43.transform.GetChild(index:  3).gameObject.SetActive(value:  true);
        val_157 = null;
        val_157 = null;
        UnityEngine.AudioSource val_47 = VoiceManager.instance.Source;
        if(val_47 != null)
        {
            goto label_179;
        }
        
        label_180:
        label_179:
        val_47.PlayOneShot(clip:  this.popClip[2], volumeScale:  1f);
        label_168:
        val_28.gameObject.SetActive(value:  true);
        val_28.gameObject.GetComponent<UnityEngine.Animator>().Play(stateName:  this.playerBall.gameObject.tag);
        label_216:
        string val_57 = this.playerBall.gameObject.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().sortingLayerName;
        UnityEngine.Vector3 val_59 = this.transform.right;
        UnityEngine.Vector3 val_60 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z}, d:  this.speed);
        UnityEngine.Vector2 val_61 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z});
        this.playerBall.AddRelativeForce(relativeForce:  new UnityEngine.Vector2() {x = val_61.x, y = val_61.y}, mode:  0);
        UnityEngine.Vector3 val_63 = this.playerBall.transform.localEulerAngles;
        System.Collections.IEnumerator val_65 = this.playerBall.transform.GetEnumerator();
        goto label_130;
        label_137:
        var val_155 = 0;
        val_155 = val_155 + 1;
        object val_67 = val_65.Current;
        UnityEngine.Vector3 val_69 = 0.localEulerAngles;
        UnityEngine.Vector3 val_70 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_69.x, y = val_69.y, z = val_69.z}, b:  new UnityEngine.Vector3() {x = val_63.x, y = val_63.y, z = val_63.z});
        0.localEulerAngles = new UnityEngine.Vector3() {x = val_70.x, y = val_70.y, z = val_70.z};
        label_130:
        var val_156 = 0;
        val_156 = val_156 + 1;
        if(val_65.MoveNext() == true)
        {
            goto label_137;
        }
        
        val_163 = 0;
        goto label_138;
        label_85:
        if(val_42 == true)
        {
            goto label_139;
        }
        
        label_86:
        bool val_73 = val_43.CompareTag(tag:  "Iron_Ball");
        UnityEngine.GameObject val_74 = this.playerBall.gameObject;
        if(val_74 == null)
        {
            goto label_141;
        }
        
        if(val_73 == false)
        {
            goto label_142;
        }
        
        label_153:
        val_74.transform.GetChild(index:  4).gameObject.SetActive(value:  true);
        val_164 = null;
        val_164 = null;
        UnityEngine.AudioClip val_157 = this.popClip[3];
        if(VoiceManager.instance.Source != null)
        {
            goto label_179;
        }
        
        goto label_180;
        label_141:
        if(val_73 == true)
        {
            goto label_153;
        }
        
        label_142:
        bool val_79 = val_74.CompareTag(tag:  "Stunner_Ball");
        UnityEngine.GameObject val_80 = this.playerBall.gameObject;
        if(val_80 == null)
        {
            goto label_155;
        }
        
        if(val_79 == false)
        {
            goto label_156;
        }
        
        label_167:
        val_80.transform.GetChild(index:  5).gameObject.SetActive(value:  true);
        val_165 = null;
        val_165 = null;
        UnityEngine.AudioClip val_158 = this.popClip[4];
        if(VoiceManager.instance.Source != null)
        {
            goto label_179;
        }
        
        goto label_180;
        label_155:
        if(val_79 == true)
        {
            goto label_167;
        }
        
        label_156:
        if((val_80.CompareTag(tag:  "Rainbow_Bubble")) == false)
        {
            goto label_168;
        }
        
        this.playerBall.gameObject.transform.GetChild(index:  2).gameObject.SetActive(value:  true);
        val_166 = null;
        val_166 = null;
        UnityEngine.AudioClip val_159 = this.popClip[1];
        if(VoiceManager.instance.Source != null)
        {
            goto label_179;
        }
        
        goto label_180;
        label_76:
        this.playerBall.gameObject.transform.Find(n:  "TrailNormal").gameObject.SetActive(value:  true);
        UnityEngine.GameObject val_97 = this.playerBall.gameObject;
        if((this.playerBall.gameObject.CompareTag(tag:  "Red")) == false)
        {
            goto label_190;
        }
        
        val_167 = 0.4f;
        val_168 = val_97.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        val_169 = 0f;
        goto label_237;
        label_190:
        UnityEngine.GameObject val_103 = this.playerBall.gameObject;
        if((val_97.CompareTag(tag:  "Yellow")) == false)
        {
            goto label_197;
        }
        
        val_169 = 0.92f;
        val_167 = 0.4f;
        val_168 = val_103.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_237;
        label_197:
        UnityEngine.GameObject val_109 = this.playerBall.gameObject;
        if((val_103.CompareTag(tag:  "Blue")) == false)
        {
            goto label_204;
        }
        
        val_167 = 0.4f;
        val_168 = val_109.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        val_169 = 0f;
        label_237:
        UnityEngine.Color val_114 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_168.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_114.r, g = val_114.g, b = val_114.b, a = val_114.a});
        label_231:
        UnityEngine.AudioSource val_116 = GameAudio.sound.PlayOneShot(clip:  this.popClip[0], volume:  1f);
        val_28.gameObject.SetActive(value:  false);
        goto label_216;
        label_204:
        UnityEngine.GameObject val_119 = this.playerBall.gameObject;
        if((val_109.CompareTag(tag:  "Green")) == false)
        {
            goto label_219;
        }
        
        UnityEngine.Material val_123 = val_119.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_237;
        label_219:
        UnityEngine.GameObject val_125 = this.playerBall.gameObject;
        if((val_119.CompareTag(tag:  "Orange")) == false)
        {
            goto label_226;
        }
        
        UnityEngine.Material val_129 = val_125.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_237;
        label_226:
        if((val_125.CompareTag(tag:  "Purple")) == false)
        {
            goto label_231;
        }
        
        UnityEngine.Material val_135 = this.playerBall.gameObject.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_237;
        label_138:
        if(val_28 != null)
        {
                var val_161 = 0;
            val_161 = val_161 + 1;
            val_28.Dispose();
        }
        
        this.playerBall.transform.rotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        TargetBallScript val_138 = this.playerBall.GetComponent<TargetBallScript>();
        val_138.OTime = UnityEngine.Time.time;
        UnityEngine.Coroutine val_140 = this.StartCoroutine(methodName:  "PostAttackSequence");
        val_173 = null;
        val_173 = null;
        LineController.popTagPlayer = this.playerBall.gameObject.tag;
        this.forceFlag = false;
        LineController.touchFlag = false;
        this.setTouchPos = false;
        UnityEngine.Coroutine val_143 = this.StartCoroutine(methodName:  "GapTranslate");
        UnityEngine.GameObject val_144 = this.playerBall.gameObject;
        if(val_144 == null)
        {
            goto label_261;
        }
        
        if(LineController.ballEntry == 0)
        {
            goto label_262;
        }
        
        label_271:
        if((val_144.CompareTag(tag:  "Iron_Ball")) != true)
        {
                if((this.playerBall.gameObject.CompareTag(tag:  "Color_Eraser_Ball")) == false)
        {
            goto label_266;
        }
        
        }
        
        this.powerUpUsed = true;
        label_266:
        int val_162 = this.shotsFired;
        val_162 = val_162 + 1;
        this.shotsFired = val_162;
        if(this.modeName == 3)
        {
                int val_163 = this.ballsUsed;
            val_163 = val_163 + 1;
            this.ballsUsed = val_163;
            UnityEngine.GameObject.FindGameObjectWithTag(tag:  "PuzzleBallCounter").GetComponent<BallCounterScript>().BallCountUpdate();
        }
        
        UnityEngine.Coroutine val_150 = this.StartCoroutine(methodName:  "ActivateCollider");
        val_174 = "MakeBallNull";
        goto label_273;
        label_261:
        if(LineController.ballEntry != 0)
        {
            goto label_271;
        }
        
        label_262:
        if((val_144.CompareTag(tag:  "Stunner_Ball")) != false)
        {
                int val_164 = this.shotsFired;
            this.powerUpUsed = true;
            val_164 = val_164 + 1;
            this.shotsFired = val_164;
            val_174 = "StunOpponent";
        }
        else
        {
                val_174 = "DestroyBall";
        }
        
        label_273:
        UnityEngine.Coroutine val_152 = this.StartCoroutine(methodName:  val_174);
        val_175 = null;
        val_175 = null;
        val_176 = null;
        val_176 = null;
        this.playerBall.GetComponent<TargetBall_Parent>().SetPredictions(theirRingOuter:  InstanceAnimator.outerRingBalls, theirRingMiddle:  InstanceAnimator.middleRingBalls, theirRingInner:  InstanceAnimator.innerRingBalls, ourRingOuter:  InstanceAnimator.playerOuterRingBalls, ourRingMiddle:  InstanceAnimator.playerMiddleRingBalls, ourRingInner:  InstanceAnimator.playerInnerRingBalls, ballEntry:  LineController.ballEntry);
    }
    private System.Collections.IEnumerator ActivateCollider()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<ActivateCollider>d__177(<>1__state:  0);
    }
    private System.Collections.IEnumerator MakeBallNull()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<MakeBallNull>d__178(<>1__state:  0);
    }
    public void WhirlpoolPanelTrigger()
    {
        var val_1;
        if(this.modeName == 5)
        {
                return;
        }
        
        TipsCanvas.Show(tip:  2);
        UnityEngine.Time.timeScale = 0f;
        val_1 = null;
        val_1 = null;
        DataStructs.UserDataDictionary.GameSave.IsTutorialTwoPlayed = true;
    }
    public void ReboundPanelTrigger()
    {
        var val_1;
        var val_2;
        int val_3;
        var val_4;
        int val_5;
        var val_6;
        int val_7;
        var val_8;
        if(this.modeName == 5)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        if(InstanceAnimator.isOuterRingEmpty == false)
        {
            goto label_4;
        }
        
        val_2 = null;
        val_2 = null;
        val_3 = LineController.ballEntry;
        if(val_3 == 1)
        {
            goto label_25;
        }
        
        val_3 = LineController.ballEntry;
        if(val_3 == 6)
        {
            goto label_25;
        }
        
        val_1 = null;
        label_4:
        val_1 = null;
        if(InstanceAnimator.isMiddleRingEmpty == false)
        {
            goto label_13;
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = LineController.ballEntry;
        if(val_5 == 2)
        {
            goto label_25;
        }
        
        val_5 = LineController.ballEntry;
        if(val_5 == 5)
        {
            goto label_25;
        }
        
        val_1 = null;
        label_13:
        val_1 = null;
        if(InstanceAnimator.isInnerRingEmpty == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_7 = LineController.ballEntry;
        if(val_7 != 3)
        {
                val_7 = LineController.ballEntry;
            if(val_7 != 4)
        {
                return;
        }
        
        }
        
        label_25:
        UnityEngine.Time.timeScale = 0f;
        TipsCanvas.Show(tip:  5);
        val_8 = null;
        val_8 = null;
        DataStructs.UserDataDictionary.GameSave.IsTutorialSixPlayed = true;
    }
    public void gapTrans()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "GapTranslate");
    }
    private System.Collections.IEnumerator GapTranslate()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<GapTranslate>d__182(<>1__state:  0);
    }
    private System.Collections.IEnumerator GapTranslationUpperPart(UnityEngine.GameObject[] ringBalls, int mid, float radius, float upperAngle, float angleDiff, int negateX)
    {
        LineController.<GapTranslationUpperPart>d__183 val_1 = new LineController.<GapTranslationUpperPart>d__183(<>1__state:  0);
        if(val_1 != null)
        {
                .ringBalls = ringBalls;
            .mid = mid;
            .radius = radius;
            .upperAngle = upperAngle;
            .angleDiff = angleDiff;
        }
        else
        {
                mem[40] = ringBalls;
            mem[32] = mid;
            .radius = radius;
            mem[56] = upperAngle;
            .angleDiff = angleDiff;
        }
        
        .negateX = negateX;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator GapTranslationLowerPart(UnityEngine.GameObject[] ringBalls, int mid, float radius, float upperAngle, float angleDiff, int negateX)
    {
        LineController.<GapTranslationLowerPart>d__184 val_1 = new LineController.<GapTranslationLowerPart>d__184(<>1__state:  0);
        if(val_1 != null)
        {
                .ringBalls = ringBalls;
            .mid = mid;
            .radius = radius;
            .upperAngle = upperAngle;
            .angleDiff = angleDiff;
        }
        else
        {
                mem[40] = ringBalls;
            mem[32] = mid;
            .radius = radius;
            mem[56] = upperAngle;
            .angleDiff = angleDiff;
        }
        
        .negateX = negateX;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator StunSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<StunSequence>d__185(<>1__state:  0);
    }
    private void StunSequenceAnimation()
    {
        var val_13;
        float val_14;
        float val_15;
        float val_16;
        val_13 = this;
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 * 1.5f;
        float val_2 = UnityEngine.Mathf.PingPong(t:  val_1, length:  1f);
        float val_3 = UnityEngine.Time.time;
        val_3 = val_3 * 1.5f;
        float val_4 = UnityEngine.Mathf.PingPong(t:  val_3, length:  1f);
        UnityEngine.Color val_5 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.animController.image_Body.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
        if(this.shake > 0f)
        {
                UnityEngine.Vector3 val_7 = UnityEngine.Random.insideUnitSphere;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  this.shakeAmount);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.originalPos, y = val_5.g, z = val_5.b}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_14 = val_9.z;
            val_15 = val_9.x;
            this.playerChar.transform.position = new UnityEngine.Vector3() {x = val_15, y = val_9.y, z = val_14};
            if(this.shakeAmount > 0f)
        {
                float val_10 = UnityEngine.Time.deltaTime;
            val_10 = val_10 * this.shakeAmount;
            val_10 = val_10 * (-0.1f);
            val_15 = this.shakeAmount + val_10;
            this.shakeAmount = val_15;
        }
        
            val_16 = this.shake;
            float val_11 = UnityEngine.Time.deltaTime;
            val_11 = val_11 * this.decreaseFactor;
            val_11 = val_16 - val_11;
            this.shake = val_11;
            return;
        }
        
        this.shake = 0f;
        val_16 = this.originalPos;
        val_13 = this.playerChar.transform;
        val_13.position = new UnityEngine.Vector3() {x = val_16, y = val_5.g, z = val_5.b};
    }
    private System.Collections.IEnumerator PopSequenceStun()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<PopSequenceStun>d__187(<>1__state:  0);
    }
    private System.Collections.IEnumerator LooseSequence()
    {
        LineController.<LooseSequence>d__188 val_1 = 22003;
        val_1 = new LineController.<LooseSequence>d__188(<>1__state:  0);
        if(val_1 != 0)
        {
                return (System.Collections.IEnumerator)val_1;
        }
        
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator WinSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<WinSequence>d__189(<>1__state:  0);
    }
    private void PopPVPWinPanel(GameResult gameResult)
    {
        GameOverPanel.instance.gameObject.SetActive(value:  true);
    }
    private System.Collections.IEnumerator DestroyPlayerBalls(UnityEngine.GameObject[] ringArray, int length, bool ifWin, bool isForTimeOver)
    {
        LineController.<DestroyPlayerBalls>d__191 val_1 = new LineController.<DestroyPlayerBalls>d__191(<>1__state:  0);
        if(val_1 != null)
        {
                .<>4__this = this;
            .ringArray = ringArray;
            .length = length;
            .ifWin = ifWin;
        }
        else
        {
                mem[48] = this;
            mem[32] = ringArray;
            .length = length;
            mem[56] = ifWin;
        }
        
        .isForTimeOver = isForTimeOver;
        return (System.Collections.IEnumerator)val_1;
    }
    public System.Collections.IEnumerator LoadResources()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<LoadResources>d__192(<>1__state:  0);
    }
    public System.Collections.IEnumerator startDefenceSequenceNetwork()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<startDefenceSequenceNetwork>d__193(<>1__state:  0);
    }
    public System.Collections.IEnumerator startDefenceSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<startDefenceSequence>d__194(<>1__state:  0);
    }
    public void SetIconActive_GameBegin()
    {
        this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = 1f;
        this.specialBallButton.interactable = true;
        this.specialBallButtonArrow.interactable = true;
    }
    public void StartTimerPVP()
    {
        if(this.modeName != 5)
        {
                return;
        }
        
        if(PlayerPrefsManager.OnlinePVPTime == 1)
        {
                return;
        }
        
        this.gameTime = (float)PlayerPrefsManager.OnlinePVPTime;
        this.InvokeRepeating(methodName:  "GameTimeControl", time:  0f, repeatRate:  0.15f);
    }
    private void GameTimeControl()
    {
        float val_12;
        InGameInfo val_13;
        float val_14;
        float val_15;
        var val_16;
        var val_17;
        GameResultInfo val_18;
        GameResult val_19;
        var val_20;
        var val_21;
        val_12 = this.gameTime + (-0.1f);
        this.gameTime = val_12;
        int val_1 = UnityEngine.Mathf.FloorToInt(f:  val_12);
        val_13 = val_1.ToString(format:  "D3");
        if((val_1 <= 10) && (val_1 != this.prevTimeInt))
        {
                this.prevTimeInt = val_1;
            val_13 = GameAudio.sound;
            UnityEngine.AudioSource val_4 = val_13.PlayOneShot(clip:  this.timerCountdownFinal10clip, volume:  1f);
        }
        
        val_14 = this.gameTime;
        if((val_14 <= 10f) && (val_14 > 9.9f))
        {
                UnityEngine.Color val_5 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_12 = val_5.r;
            val_15 = val_5.b;
            instructionMenuHandler.gameTimer.color = new UnityEngine.Color() {r = val_12, g = val_5.g, b = val_15, a = val_5.a};
            this.InvokeRepeating(methodName:  "BlinkTimer", time:  0f, repeatRate:  UnityEngine.Time.deltaTime);
            val_14 = this.gameTime;
        }
        
        if(val_14 > 0f)
        {
                return;
        }
        
        this.CancelInvoke(methodName:  "BlinkTimer");
        UnityEngine.Color val_7 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_12 = val_7.r;
        val_15 = val_7.b;
        instructionMenuHandler.gameTimer.color = new UnityEngine.Color() {r = val_12, g = val_7.g, b = val_15, a = val_7.a};
        this.isTimeOver = true;
        val_16 = null;
        val_16 = null;
        int val_8 = GameInfo.inGame.GetPlayerBallCount(pid:  0);
        val_13 = GameInfo.inGame;
        int val_9 = val_13.GetPlayerBallCount(pid:  1);
        if(val_8 != val_9)
        {
            goto label_19;
        }
        
        this.timeUpFlag = 0;
        val_17 = null;
        val_17 = null;
        val_18 = GameInfo.afterGame;
        val_19 = 2;
        goto label_23;
        label_19:
        if(val_8 <= val_9)
        {
            goto label_24;
        }
        
        this.timeUpFlag = 1;
        val_20 = null;
        val_20 = null;
        val_19 = 0;
        goto label_28;
        label_24:
        this.timeUpFlag = 2;
        val_21 = null;
        val_21 = null;
        val_18 = GameInfo.afterGame;
        val_19 = 1;
        label_23:
        label_28:
        val_18.OnGameResult(aNewResult:  val_19);
        this.TimeUpFunction();
        this.GetComponent<LineControllerP2>().PlayerWinFunction();
        this.CancelInvoke(methodName:  "GameTimeControl");
    }
    private void BlinkTimer()
    {
        float val_4 = 5f;
        val_4 = UnityEngine.Time.time * val_4;
        float val_2 = UnityEngine.Mathf.PingPong(t:  val_4, length:  1f);
        UnityEngine.Color val_3 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        instructionMenuHandler.gameTimer.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
    }
    private void TimeUpFunction()
    {
        var val_27;
        var val_28;
        this.CancelInvoke();
        this.StopCoroutine(methodName:  "StunOpponent");
        this.StopCoroutine(methodName:  "PostAttackSequence");
        this.StopCoroutine(methodName:  "StunSequence");
        this.StopCoroutine(methodName:  "PopSequenceStun");
        if(this.playerBall != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.playerBall.gameObject);
        }
        
        if(this.playerBallTemp[0] != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.playerBallTemp[0].gameObject);
        }
        
        if(this.playerBallTemp[1] != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.playerBallTemp[1].gameObject);
        }
        
        if(this.stunnerPopHolder != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.stunnerPopHolder.gameObject);
        }
        
        System.Collections.IEnumerator val_10 = this.lineRenderer.transform.GetEnumerator();
        label_53:
        var val_31 = 0;
        val_31 = val_31 + 1;
        if(val_10.MoveNext() == false)
        {
            goto label_40;
        }
        
        var val_32 = 0;
        val_32 = val_32 + 1;
        val_27 = val_10.Current;
        if(val_27 != null)
        {
                val_27 = 0;
        }
        
        UnityEngine.Color val_20 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_27.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_20.r, g = val_20.g, b = val_20.b, a = val_20.a};
        goto label_53;
        label_40:
        val_28 = 0;
        if(val_10 != null)
        {
                var val_33 = 0;
            val_33 = val_33 + 1;
            val_10.Dispose();
        }
        
        this.iconPlayerActive.SetActive(value:  true);
        LineControllerP2 val_22 = this.GetComponent<LineControllerP2>();
        val_22.iconPlayerActive.SetActive(value:  true);
        UnityEngine.Color val_23 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.animController.image_Body.color = new UnityEngine.Color() {r = val_23.r, g = val_23.g, b = val_23.b, a = val_23.a};
        this.animController.pause = false;
        this.playerChar.transform.position = new UnityEngine.Vector3() {x = this.characterPos, y = val_23.g, z = val_23.b};
        this.stunCounter.gameObject.SetActive(value:  false);
        this.animController.PlayAnimation(newAnimName:  8, forceOverride:  true);
        UnityEngine.Coroutine val_26 = this.StartCoroutine(methodName:  "TimeUpCommonSequence");
    }
    private System.Collections.IEnumerator TimeUpCommonSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<TimeUpCommonSequence>d__203(<>1__state:  0);
    }
    private System.Collections.IEnumerator TimeUpLoseSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<TimeUpLoseSequence>d__204(<>1__state:  0);
    }
    private System.Collections.IEnumerator TimeUpWinSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<TimeUpWinSequence>d__205(<>1__state:  0);
    }
    private System.Collections.IEnumerator TimeUpDrawSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<TimeUpDrawSequence>d__206(<>1__state:  0);
    }
    private System.Collections.IEnumerator TimeUpCommonWinPanelSequence(GameResult gameResult)
    {
        LineController.<TimeUpCommonWinPanelSequence>d__207 val_1 = new LineController.<TimeUpCommonWinPanelSequence>d__207(<>1__state:  0);
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .gameResult = gameResult;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator PostAttackSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<PostAttackSequence>d__208(<>1__state:  0);
    }
    private System.Collections.IEnumerator FinishAttack()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<FinishAttack>d__209(<>1__state:  0);
    }
    private void ShakeSequenceAnimationPlayer()
    {
        float val_8;
        if(this.shake > 0f)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Random.insideUnitSphere;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  this.shakeAmount);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.originalPos, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            val_8 = val_4.x;
            this.playerChar.transform.position = new UnityEngine.Vector3() {x = val_8, y = val_4.y, z = val_4.z};
            if(this.shakeAmount > 0f)
        {
                float val_5 = UnityEngine.Time.deltaTime;
            val_5 = val_5 * this.shakeAmount;
            val_5 = val_5 * (-0.1f);
            val_8 = this.shakeAmount + val_5;
            this.shakeAmount = val_8;
        }
        
            float val_6 = UnityEngine.Time.deltaTime;
            val_6 = val_6 * this.decreaseFactor;
            val_6 = this.shake - val_6;
            this.shake = val_6;
            return;
        }
        
        this.shake = 0f;
        this.playerChar.transform.position = new UnityEngine.Vector3() {x = this.originalPos, y = V9.16B, z = V10.16B};
    }
    private System.Collections.IEnumerator DestroyBall()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<DestroyBall>d__211(<>1__state:  0);
    }
    private System.Collections.IEnumerator IconMask()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<IconMask>d__212(<>1__state:  0);
    }
    private System.Collections.IEnumerator StunOpponent()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<StunOpponent>d__213(<>1__state:  0);
    }
    private System.Collections.IEnumerator BossResurrect()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<BossResurrect>d__214(<>1__state:  0);
    }
    private System.Collections.IEnumerator InkThemUpSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<InkThemUpSequence>d__215(<>1__state:  0);
    }
    private void LeaderboardUpdate(int index)
    {
        DataStructs.GameSave val_6;
        var val_7;
        var val_8;
        DataStructs.GameSave val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_6 = index;
        if(NetworkManager_Custom.IsNetwork == false)
        {
            goto label_1;
        }
        
        if(val_6 == 1)
        {
            goto label_2;
        }
        
        if(val_6 != 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        val_6 = DataStructs.UserDataDictionary.GameSave;
        if((val_6.IsAchievementUnlocked(id:  31)) == true)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = DataStructs.UserDataDictionary.GameSave;
        val_10 = 31;
        goto label_11;
        label_1:
        if(val_6 != 4)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Stats.LocalPvPMatches;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited});
        DataStructs.UserDataDictionary.Stats.LocalPvPMatches = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited};
        return;
        label_2:
        val_12 = null;
        val_12 = null;
        val_6 = DataStructs.UserDataDictionary.GameSave;
        if((val_6.IsAchievementUnlocked(id:  35)) != false)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        val_9 = DataStructs.UserDataDictionary.GameSave;
        val_10 = 35;
        label_11:
        val_9.UnlockAchievement(id:  35);
    }
    public static float Getinkposp1()
    {
        null = null;
        return (float)LineController.inkposP1;
    }
    private System.Collections.IEnumerator InkThemUpSequenceP2()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineController.<InkThemUpSequenceP2>d__218(<>1__state:  0);
    }
    private void CountDown()
    {
        var val_3;
        var val_4;
        var val_5;
        float val_3 = this.inkCountdown;
        if(val_3 <= 0f)
        {
            goto label_1;
        }
        
        val_3 = val_3 + (-0.01f);
        mem2[0] = val_3;
        val_3 = null;
        val_3 = null;
        if((LineControllerP2.player2Win == true) || (NetworkManager_Custom.IsNetwork == false))
        {
            goto label_9;
        }
        
        val_4 = null;
        val_4 = null;
        0.SyncInkTimer(inktimer:  this.inkCountdown);
        goto label_9;
        label_1:
        this.shallHitInk = false;
        val_5 = null;
        val_5 = null;
        LineControllerP2.shallHitInkP2 = false;
        label_9:
        string val_2 = this.inkCountdown.ToString(format:  "F2");
        if(this.inkTimerText == null)
        {
            
        }
    
    }
    private void FixedUpdate()
    {
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        int val_43;
        var val_44;
        var val_45;
        UnityEngine.AudioClip val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        if(this.shallHitInk == false)
        {
                return;
        }
        
        val_38 = null;
        val_38 = null;
        if(LineControllerP2.player2Win == false)
        {
            goto label_4;
        }
        
        val_39 = null;
        val_39 = null;
        if((LineController.remainingBallsCount < 1) || (this.inkball == false))
        {
            goto label_71;
        }
        
        this.inkball = false;
        val_39 = null;
        int val_1 = LineController.remainingBallsCount - 1;
        UnityEngine.GameObject[] val_2 = LineController.inkBubbles + (((long)(int)((LineController.remainingBallsCount - 1))) << 3);
        (LineController.inkBubbles + ((long)(int)((LineController.remainingBallsCount - 1))) << 3) + 32.gameObject.GetComponent<InkingSequenceBubbleAnim>().HitInk();
        int val_5 = LineController.remainingBallsCount - 1;
        UnityEngine.GameObject[] val_6 = LineController.inkBubbles + (((long)(int)((LineController.remainingBallsCount - 1))) << 3);
        UnityEngine.GameObject val_10 = (LineController.inkBubbles + ((long)(int)((LineController.remainingBallsCount - 1))) << 3) + 32.gameObject.transform.GetChild(index:  0).gameObject;
        if(val_10 == null)
        {
            goto label_22;
        }
        
        val_10.SetActive(value:  true);
        goto label_23;
        label_4:
        if(this.inkball == false)
        {
            goto label_71;
        }
        
        this.inkball = false;
        if(NetworkManager_Custom.IsNetwork != false)
        {
                val_40 = null;
            val_40 = null;
            0.sendFunctionRPC(functionNumber:  11);
        }
        
        this.inkHitting = false;
        this.setTouchPos = true;
        val_41 = null;
        val_41 = null;
        val_43 = LineController.remainingBallsCount;
        if(val_43 < 1)
        {
            goto label_71;
        }
        
        val_43 = LineController.remainingBallsCount;
        int val_12 = val_43 - 1;
        UnityEngine.GameObject[] val_13 = LineController.inkBubbles + (((long)(int)((LineController.remainingBallsCount - 1))) << 3);
        (LineController.inkBubbles + ((long)(int)((LineController.remainingBallsCount - 1))) << 3) + 32.gameObject.GetComponent<InkingSequenceBubbleAnim>().HitInk();
        int val_16 = LineController.remainingBallsCount - 1;
        UnityEngine.GameObject[] val_17 = LineController.inkBubbles + (((long)(int)((LineController.remainingBallsCount - 1))) << 3);
        UnityEngine.GameObject val_21 = (LineController.inkBubbles + ((long)(int)((LineController.remainingBallsCount - 1))) << 3) + 32.gameObject.transform.GetChild(index:  0).gameObject;
        if(val_21 == null)
        {
            goto label_45;
        }
        
        val_21.SetActive(value:  true);
        goto label_46;
        label_22:
        0.SetActive(value:  true);
        label_23:
        val_10.GetComponent<UnityEngine.TrailRenderer>().enabled = true;
        val_10.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        LineControllerP2 val_24 = this.GetComponent<LineControllerP2>();
        val_24.animController.PlayAnimation(newAnimName:  0, forceOverride:  false);
        val_44 = null;
        val_44 = null;
        VoiceManager.instance.PlayAttackSound(Left:  0, SoundType:  0, modifiers:  0);
        int val_38 = LineController.inkBubblesHitOnCurrentCharacter;
        val_38 = val_38 + 1;
        LineController.inkBubblesHitOnCurrentCharacter = val_38;
        if(LineController.remainingBallsCount < 2)
        {
            goto label_55;
        }
        
        val_45 = GameAudio.sound;
        val_46 = this.popClip[7];
        if(val_45 != null)
        {
            goto label_66;
        }
        
        goto label_61;
        label_55:
        val_45 = GameAudio.sound;
        val_46 = this.popClip[8];
        if(val_45 != null)
        {
            goto label_66;
        }
        
        label_61:
        label_66:
        UnityEngine.AudioSource val_27 = val_45.PlayOneShot(clip:  val_46, volume:  1f);
        this.inkMeter.GetComponent<InkMeterScript>().animForRedArrow();
        val_47 = null;
        val_47 = null;
        int val_39 = LineController.remainingBallsCount;
        val_39 = val_39 - 1;
        LineController.remainingBallsCount = val_39;
        goto label_71;
        label_45:
        0.SetActive(value:  true);
        label_46:
        val_21.GetComponent<UnityEngine.TrailRenderer>().enabled = true;
        val_21.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.animController.PlayAnimation(newAnimName:  0, forceOverride:  false);
        val_48 = null;
        val_48 = null;
        VoiceManager.instance.PlayAttackSound(Left:  1, SoundType:  0, modifiers:  0);
        int val_40 = LineController.inkBubblesHitOnCurrentCharacter;
        val_40 = val_40 + 1;
        LineController.inkBubblesHitOnCurrentCharacter = val_40;
        if(LineController.remainingBallsCount < 2)
        {
            goto label_79;
        }
        
        val_49 = GameAudio.sound;
        val_46 = this.popClip[7];
        if(val_49 != null)
        {
            goto label_90;
        }
        
        goto label_85;
        label_79:
        val_49 = GameAudio.sound;
        val_46 = this.popClip[8];
        if(val_49 != null)
        {
            goto label_90;
        }
        
        label_85:
        label_90:
        UnityEngine.AudioSource val_33 = val_49.PlayOneShot(clip:  val_46, volume:  1f);
        this.inkMeter.GetComponent<InkMeterScript>().animForRedArrow();
        val_50 = null;
        val_50 = null;
        int val_41 = LineController.remainingBallsCount;
        val_41 = val_41 - 1;
        LineController.remainingBallsCount = val_41;
        this.setTouchPos = false;
        label_71:
        if(this.touch.Seconds == 3)
        {
                label_98:
            this.inkHitting = true;
        }
        else
        {
                if(UnityEngine.Application.platform == 7)
        {
                if((UnityEngine.Input.GetMouseButton(button:  0)) == true)
        {
            goto label_98;
        }
        
        }
        
        }
        
        val_51 = null;
        val_51 = null;
        if(LineController.remainingBallsCount > 0)
        {
                return;
        }
        
        this.shallHitInk = false;
        this.CancelInvoke(methodName:  "CountDown");
    }
    private void ShakeSequenceAnimationInkMeter()
    {
        if(this.shake > 0f)
        {
                float val_12 = 2.5f;
            val_12 = UnityEngine.Time.time * val_12;
            float val_4 = UnityEngine.Mathf.PingPong(t:  val_12, length:  1f);
            UnityEngine.Color val_5 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            this.inkMeterFullGlow.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
            UnityEngine.Vector3 val_7 = UnityEngine.Random.insideUnitSphere;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.1f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.originalPos, y = val_5.g, z = val_5.b}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            this.inkMeter.transform.position = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            float val_10 = UnityEngine.Time.deltaTime;
            val_10 = val_10 * this.decreaseFactor;
            val_10 = this.shake - val_10;
            this.shake = val_10;
            return;
        }
        
        this.shake = 0f;
        this.inkMeter.transform.position = new UnityEngine.Vector3() {x = this.originalPos, y = V9.16B, z = V10.16B};
    }
    private void PlayerLoseFunction()
    {
        var val_20;
        var val_21;
        this.CancelInvoke();
        this.StopCoroutine(methodName:  "StunOpponent");
        this.StopCoroutine(methodName:  "PostAttackSequence");
        this.StopCoroutine(methodName:  "StunSequence");
        this.StopCoroutine(methodName:  "PopSequenceStun");
        this.StopCoroutine(methodName:  "IconMask");
        this.iconPlayerActive.SetActive(value:  false);
        this.stunCounter.gameObject.SetActive(value:  false);
        System.Collections.IEnumerator val_3 = this.lineRenderer.transform.GetEnumerator();
        label_24:
        var val_20 = 0;
        val_20 = val_20 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_21 = 0;
        val_21 = val_21 + 1;
        val_20 = val_3.Current;
        if(val_20 != null)
        {
                val_20 = 0;
        }
        
        UnityEngine.Color val_13 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_20.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a};
        goto label_24;
        label_11:
        val_21 = 0;
        if(val_3 != null)
        {
                var val_22 = 0;
            val_22 = val_22 + 1;
            val_3.Dispose();
        }
        
        UnityEngine.Color val_15 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.animController.image_Body.color = new UnityEngine.Color() {r = val_15.r, g = val_15.g, b = val_15.b, a = val_15.a};
        this.animController.pause = false;
        this.playerChar.transform.position = new UnityEngine.Vector3() {x = this.characterPos, y = val_15.g, z = val_15.b};
        this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        UnityEngine.Coroutine val_19 = this.StartCoroutine(methodName:  "LooseSequence");
    }
    private void PlayerWinFunction()
    {
        var val_26;
        var val_27;
        this.CancelInvoke();
        this.StopCoroutine(methodName:  "StunOpponent");
        this.StopCoroutine(methodName:  "PostAttackSequence");
        this.StopCoroutine(methodName:  "StunSequence");
        this.StopCoroutine(methodName:  "PopSequenceStun");
        this.iconPlayerActive.SetActive(value:  true);
        if(this.playerBall != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.playerBall.gameObject);
        }
        
        if(this.playerBallTemp[0] != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.playerBallTemp[0].gameObject);
        }
        
        if(this.playerBallTemp[1] != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.playerBallTemp[1].gameObject);
        }
        
        if(this.stunnerPopHolder != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.stunnerPopHolder.gameObject);
        }
        
        System.Collections.IEnumerator val_10 = this.lineRenderer.transform.GetEnumerator();
        label_54:
        var val_30 = 0;
        val_30 = val_30 + 1;
        if(val_10.MoveNext() == false)
        {
            goto label_41;
        }
        
        var val_31 = 0;
        val_31 = val_31 + 1;
        val_26 = val_10.Current;
        if(val_26 != null)
        {
                val_26 = 0;
        }
        
        UnityEngine.Color val_20 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_26.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_20.r, g = val_20.g, b = val_20.b, a = val_20.a};
        goto label_54;
        label_41:
        val_27 = 0;
        if(val_10 != null)
        {
                var val_32 = 0;
            val_32 = val_32 + 1;
            val_10.Dispose();
        }
        
        UnityEngine.Color val_22 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.animController.image_Body.color = new UnityEngine.Color() {r = val_22.r, g = val_22.g, b = val_22.b, a = val_22.a};
        this.animController.pause = false;
        this.playerChar.transform.position = new UnityEngine.Vector3() {x = this.characterPos, y = val_22.g, z = val_22.b};
        this.stunCounter.gameObject.SetActive(value:  false);
        UnityEngine.Coroutine val_25 = this.StartCoroutine(methodName:  "WinSequence");
    }
    private void ReceiveDamageFunction()
    {
        var val_6;
        var val_7;
        float val_8;
        float val_10;
        float val_14;
        var val_15;
        var val_16;
        val_6 = this;
        this.forceFlag = false;
        val_7 = null;
        val_7 = null;
        LineController.touchFlag = false;
        this.setTouchPos = false;
        this.StopCoroutine(methodName:  "PostAttackSequence");
        UnityEngine.Color val_1 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_8 = val_1.b;
        this.animController.image_Body.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_8, a = val_1.a};
        if(LineController.BridgeStunP1 <= 3)
        {
                var val_6 = 40824184 + (LineController.BridgeStunP1) << 2;
            val_6 = val_6 + 40824184;
        }
        else
        {
                val_10 = this.cpuStunVariable * (float)LineController.numberOfPops;
            this.playerStunTime = ;
            val_14 = this.reloadTime;
            float val_2 = UnityEngine.Mathf.Max(a:  val_14, b:  0f);
            val_2 = val_2 + this.playerStunTime;
            this.playerStunTime = val_2;
            mem2[0] = 1084227584;
            this.iconPlayerActive.GetComponent<UnityEngine.UI.Image>().fillAmount = 1f;
            val_15 = null;
            val_15 = null;
            LineController.BridgeStunP1 = 0;
            this.iconPlayerActive.SetActive(value:  false);
            if(this.stunSequenceFlag != false)
        {
                float val_8 = this.shake;
            float val_9 = this.playerStunTime;
            val_8 = val_8 + val_9;
            val_9 = val_9 + this.stuntime;
            this.shake = val_8;
            this.stuntime = val_9;
        }
        else
        {
                this.stunSequenceFlag = true;
            this.CancelInvoke(methodName:  "StunSequenceAnimation");
            this.CancelInvoke(methodName:  "ExBattleStunLine");
            this.CancelInvoke(methodName:  "ShakeSequenceAnimationPlayer");
            this.animController.pause = false;
            UnityEngine.Coroutine val_4 = this.StartCoroutine(methodName:  "PopSequenceStun");
            val_14 = this.characterPos;
            val_6 = this.playerChar.transform;
            val_6.position = new UnityEngine.Vector3() {x = val_14, y = val_1.g, z = val_8};
        }
        
            val_16 = null;
            val_16 = null;
            LineController.receiveDamageFlag = false;
        }
    
    }
    private void StunFunction()
    {
        var val_4;
        var val_5;
        var val_6;
        this.CancelInvoke(methodName:  "StunSequenceAnimation");
        this.CancelInvoke(methodName:  "ExBattleStunLine");
        this.CancelInvoke(methodName:  "ShakeSequenceAnimationPlayer");
        this.forceFlag = false;
        this.stunSequenceFlag = true;
        val_4 = null;
        val_4 = null;
        LineController.touchFlag = false;
        this.setTouchPos = false;
        this.StopCoroutine(methodName:  "PostAttackSequence");
        this.StopCoroutine(methodName:  "StunSequence");
        if(this.modeName == 4)
        {
                this.InvokeRepeating(methodName:  "ExBattleStunLine", time:  0f, repeatRate:  0.015f);
        }
        
        UnityEngine.Color val_1 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.animController.image_Body.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        this.animController.pause = false;
        this.playerChar.transform.position = new UnityEngine.Vector3() {x = this.characterPos, y = val_1.g, z = val_1.b};
        this.iconPlayerActive.SetActive(value:  false);
        this.shake = 0f;
        UnityEngine.Coroutine val_3 = this.StartCoroutine(methodName:  "StunSequence");
        val_5 = null;
        val_5 = null;
        LineControllerAI.stunFlag = false;
        val_6 = null;
        val_6 = null;
        LineControllerP2.stunFlag = false;
    }
    private void ExBattleStunLine()
    {
        var val_27;
        var val_44;
        var val_45;
        float val_46;
        float val_49;
        var val_52;
        var val_53;
        var val_54;
        float val_56;
        float val_57;
        float val_58;
        float val_60;
        var val_61;
        var val_62;
        var val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_72;
        var val_73;
        val_44 = this;
        val_45 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = V1.16B});
        val_46 = val_2.z;
        UnityEngine.Vector3 val_3 = val_45.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_46});
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        val_49 = val_4.x;
        if(this.touch.Seconds == 1)
        {
                if(this.setTouchPos == false)
        {
            goto label_5;
        }
        
        }
        
        if((this.touch.Seconds == 3) || (this.setTouchPos == false))
        {
            goto label_50;
        }
        
        this.endPos = val_4;
        mem[1152921526252909908] = val_4.y;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = this.startPos, y = val_46});
        this.diff = val_7;
        mem[1152921526252909916] = val_7.y;
        System.Collections.IEnumerator val_9 = this.lineRenderer.transform.GetEnumerator();
        label_30:
        var val_47 = 0;
        val_47 = val_47 + 1;
        if(val_9.MoveNext() == false)
        {
            goto label_17;
        }
        
        var val_48 = 0;
        val_48 = val_48 + 1;
        val_52 = val_9.Current;
        if(val_52 != null)
        {
                val_52 = 0;
        }
        
        UnityEngine.Color val_19 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_52.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_19.r, g = val_19.g, b = val_19.b, a = val_19.a};
        goto label_30;
        label_5:
        val_53 = 0;
        if((val_4.y <= (-3.5f)) || (val_4.y >= 0))
        {
            goto label_51;
        }
        
        val_45 = 1152921505075376128;
        val_54 = null;
        val_54 = null;
        if(InstanceAnimator.playerNegateX != 1)
        {
            goto label_38;
        }
        
        val_54 = null;
        val_56 = InstanceAnimator.UniversalX;
        float val_49 = -3.86f;
        val_49 = val_49 - val_56;
        if(val_49 <= val_49)
        {
            goto label_38;
        }
        
        val_54 = null;
        val_56 = InstanceAnimator.UniversalX;
        val_57 = 0.64f;
        val_58 = val_57 - val_56;
        if(val_49 < 0)
        {
            goto label_41;
        }
        
        label_38:
        val_54 = null;
        if(InstanceAnimator.playerNegateX != 1)
        {
            goto label_50;
        }
        
        val_54 = null;
        val_60 = InstanceAnimator.UniversalX;
        float val_50 = 3.86f;
        val_50 = val_60 + val_50;
        if(val_49 >= 0)
        {
            goto label_50;
        }
        
        val_60 = InstanceAnimator.UniversalX;
        val_57 = -0.64f;
        val_58 = val_60 + val_57;
        if(val_49 <= val_58)
        {
            goto label_50;
        }
        
        label_41:
        this.startPos = val_58;
        mem[1152921526252909900] = val_57;
        this.setTouchPos = true;
        label_50:
        val_53 = 0;
        goto label_51;
        label_17:
        val_61 = 0;
        val_62 = 0;
        if(val_9 != null)
        {
                var val_51 = 0;
            val_51 = val_51 + 1;
            val_9.Dispose();
        }
        
        if( != 1)
        {
                var val_21 = (399 == 399) ? 1 : 0;
            val_21 = (( >= 0) ? 1 : 0) & val_21;
            val_53 =  - val_21;
        }
        else
        {
                val_53 = 0;
        }
        
        if(255f <= GlobalInfo.innerAimDifference)
        {
                if(255f >= (-GlobalInfo.innerAimDifference))
        {
            goto label_71;
        }
        
        }
        
        val_66 = 1152921526109146016;
        UnityEngine.AnimatorStateInfo val_26 = this.lineRenderer.GetComponent<UnityEngine.Animator>().GetCurrentAnimatorStateInfo(layerIndex:  0);
        val_67 = val_27;
        val_68 = "Red";
        goto label_74;
        label_71:
        val_66 = 1152921526109146016;
        UnityEngine.AnimatorStateInfo val_30 = this.lineRenderer.GetComponent<UnityEngine.Animator>().GetCurrentAnimatorStateInfo(layerIndex:  0);
        val_67 = val_27;
        val_68 = "MiddleRed";
        label_74:
        if((171214128 & 1) == 0)
        {
                this.lineRenderer.GetComponent<UnityEngine.Animator>().Play(stateName:  "MiddleRed");
        }
        
        val_45 = 1152921505075642368;
        val_69 = null;
        val_69 = null;
        this.MoveAimLine(differenceY:  255f, ballEntryVariable: ref  1152921505075646468);
        label_51:
        if(this.touch.Seconds != 3)
        {
                return;
        }
        
        System.Collections.IEnumerator val_35 = this.lineRenderer.transform.GetEnumerator();
        val_49 = 255f;
        val_66 = 1152921504865153024;
        val_68 = 1152921526024376896;
        label_103:
        var val_52 = 0;
        val_52 = val_52 + 1;
        if(val_35.MoveNext() == false)
        {
            goto label_90;
        }
        
        var val_53 = 0;
        val_53 = val_53 + 1;
        val_72 = val_35.Current;
        if(val_72 != null)
        {
                val_72 = 0;
        }
        
        UnityEngine.Color val_44 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_72.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_44.r, g = val_44.g, b = val_44.b, a = val_44.a};
        goto label_103;
        label_90:
        val_73 = 0;
        var val_45 = val_53 + 1;
        mem2[0] = 677;
        val_45 = 1152921504621170688;
        val_44 = val_35;
        if(val_44 != null)
        {
                var val_54 = 0;
            val_54 = val_54 + 1;
            val_44.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    private void ShootInTutorial()
    {
        this.animController.PlayAnimation(newAnimName:  0, forceOverride:  false);
    }
    private bool get_IsInkSequence()
    {
        CharacterNameID val_2;
        CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
        return (bool)this.CheckInkSequence(winnerId:  val_2);
    }
    private bool get_IsInkSequenceP2()
    {
        CharacterNameID val_2;
        CharacterInfo val_1 = Character_GlobalInfo.GetOpponentPlayer();
        return (bool)this.CheckInkSequence(winnerId:  val_2);
    }
    private bool CheckInkSequence(CharacterNameID winnerId)
    {
        var val_3 = null;
        return (bool)((CharacterHelper.GetMinBubbleCountForInkSequence(winnerId:  winnerId)) <= LineController.remainingBallsCount) ? 1 : 0;
    }
    private void SetIconPlayerActive(UnityEngine.Sprite sprite)
    {
        if(sprite == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "Attempt to set null sprite");
            return;
        }
        
        this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = sprite;
        UnityEngine.Color val_6 = UnityEngine.Color.white;
        this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
    }
    private void SetIconPlayerInactive(UnityEngine.Sprite sprite)
    {
        if(sprite == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "Attempt to set null sprite");
            return;
        }
        
        this.iconPlayerInactive.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = sprite;
        UnityEngine.Color val_6 = UnityEngine.Color.white;
        this.iconPlayerInactive.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
    }
    public bool IsGameOnHold()
    {
        var val_3;
        var val_4;
        if((this.gamePaused == true) || (this.isTimeOver == true))
        {
                return true;
        }
        
        val_3 = null;
        val_3 = null;
        if(LineController.bossRessurectFlag != false)
        {
                return true;
        }
        
        if((this.looseSequenceFlag == false) || (this.winSequenceFlag == false))
        {
                return true;
        }
        
        val_4 = null;
        val_4 = null;
        if(InstanceAnimator.areBallsInstantiated == false)
        {
                return true;
        }
        
        var val_2 = (UnityEngine.Time.timeScale == 0f) ? 1 : 0;
        return true;
    }
    public void SetupCharacterUnlockPanel(CharacterNameID cid, bool showPanel = False)
    {
        var val_19;
        var val_20;
        var val_21;
        val_19 = null;
        val_19 = null;
        if((DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  cid)) != true)
        {
                val_20 = null;
            val_20 = null;
            LineController.inkMeterAnimationFlag = false;
        }
        
        val_21 = null;
        val_21 = null;
        DataStructs.UserDataDictionary.Items.SetCharacterUnlock(id:  cid, unlocked:  true, displayAvatarUnlockPopup:  true);
        CharacterAssetLoader.Get(id:  cid, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  this, method:  System.Void LineController::<SetupCharacterUnlockPanel>b__236_0(CharacterAssetLoader loader)));
        this.unlockedPanelChild.transform.GetChild(index:  1).GetComponent<UnityEngine.UI.Image>().sprite = CharacterAssetLoader.LoadResource_CharacterStatType(charNameID:  cid, left:  true);
        if(showPanel == false)
        {
                return;
        }
        
        this.<characterUnlockPanel>k__BackingField.transform.GetChild(index:  0).gameObject.SetActive(value:  true);
        this.<characterUnlockPanel>k__BackingField.transform.GetChild(index:  1).gameObject.SetActive(value:  false);
        this.<characterUnlockPanel>k__BackingField.transform.GetChild(index:  2).gameObject.SetActive(value:  false);
        this.unlockedPanelChild.transform.GetChild(index:  4).gameObject.SetActive(value:  false);
    }
    private void ShowAimLine(bool show)
    {
        var val_11;
        var val_15;
        var val_16;
        var val_1 = (show != true) ? 255f : 0f;
        System.Collections.IEnumerator val_3 = this.lineRenderer.transform.GetEnumerator();
        label_21:
        var val_15 = 0;
        val_15 = val_15 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_8;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_15 = val_3.Current;
        if(val_15 != null)
        {
                val_15 = 0;
        }
        
        val_11 = 0;
        UnityEngine.Color val_13 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_15.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a};
        goto label_21;
        label_8:
        val_16 = 0;
        if(val_3 != null)
        {
                var val_17 = 0;
            val_17 = val_17 + 1;
            val_3.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public LineController()
    {
        this.sensitivity = 5f;
        this.inkCountdown = 10f;
        this.shakeAmount = 0.1f;
        this.decreaseFactor = 1f;
        this.setup = true;
        this.gameTime = 10f;
    }
    private static LineController()
    {
    
    }
    private void <SetupCharacterUnlockPanel>b__236_0(CharacterAssetLoader loader)
    {
        this.unlockedPanelChild.transform.GetChild(index:  0).GetComponent<UnityEngine.UI.Image>().sprite = loader.LoadAvatar_Unlocked();
    }

}
