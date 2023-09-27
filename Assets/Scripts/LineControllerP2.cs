using UnityEngine;
public class LineControllerP2 : MonoBehaviour
{
    // Fields
    public static LineControllerP2 instance;
    private UnityEngine.Touch[] myTouch;
    public UnityEngine.Touch touchp2;
    private bool setTouchPos;
    private bool isForDemo;
    private UnityEngine.Vector2 startPos;
    private UnityEngine.Vector2 endPos;
    private UnityEngine.Vector2 diff;
    private float distance;
    public UnityEngine.GameObject lineRenderer;
    public UnityEngine.Rigidbody2D[] playerBalls;
    private UnityEngine.Rigidbody2D playerBall;
    private UnityEngine.GameObject[] playerBallTemp;
    public float speed;
    public static int ballEntry;
    private int ballEntryTemp;
    private bool forceFlag;
    public static bool touchFlagP2;
    private UnityEngine.GameObject swipedBall;
    public UnityEngine.GameObject camera_Shake;
    public UnityEngine.GameObject playerChar;
    private bool winSequenceFlag;
    private bool looseSequenceFlag;
    public static bool flagForDestroyBallsAnim;
    public UnityEngine.GameObject KnockOut;
    public UnityEngine.GameObject losePose;
    public UnityEngine.GameObject popAnimation;
    public static bool player2Lose;
    public static bool player2Win;
    public UnityEngine.GameObject iconPlayerActive;
    public UnityEngine.GameObject iconPlayerInactive;
    private bool isWaiting;
    public UnityEngine.Sprite[] linerendererSprites;
    public static bool stunFlag;
    public UnityEngine.GameObject stunnerPop;
    private UnityEngine.GameObject stunnerPopHolder;
    private float characterReloadVariable;
    public UnityEngine.AudioClip[] popClip;
    public UnityEngine.GameObject popAnimationPlayer;
    public static string popTagPlayer;
    public static int remainingBallsCountP2;
    public static bool InkingSequence;
    public static UnityEngine.GameObject[] inkBubbles;
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
    public UnityEngine.GameObject individualScoreAnimation;
    private UnityEngine.GameObject inkMeter;
    private UnityEngine.GameObject inkMeterFullGlow;
    private UnityEngine.GameObject VS_char_Image_CPU;
    public UnityEngine.UI.Text stunCounter;
    public static bool shallHitInkP2;
    public UnityEngine.GameObject playerMiddle;
    private UnityEngine.UI.Button specialBallButton;
    private UnityEngine.UI.Button specialBallButtonArrow;
    private UnityEngine.GameObject popText;
    private int stageNumber;
    public int angleHandler;
    private int ballTempCounter;
    private GameMode modeName;
    private CharacterClan tempCharType;
    private bool PlayedLose;
    private UnityEngine.GameObject cpuBridge;
    private UnityEngine.GameObject playerBridge;
    private bool GameLost;
    private bool GameWon;
    public static int BridgeStunP2;
    public static float inkpos;
    public UnityEngine.GameObject textAreYouReady;
    public UnityEngine.GameObject textGameOn;
    private bool setup;
    public CharAnimationController_Physical animController;
    private float stuntime;
    private float iconMaskTime;
    private float reloadTime;
    public int touchInt;
    private float lastMoveAimLine;
    
    // Methods
    private void Awake()
    {
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        val_21 = null;
        val_21 = null;
        if((UnityEngine.Object.op_Implicit(exists:  LineControllerP2.instance)) != false)
        {
                val_22 = null;
            val_22 = null;
            UnityEngine.Object.Destroy(obj:  LineControllerP2.instance);
        }
        
        val_23 = null;
        val_23 = null;
        LineControllerP2.instance = this;
        this.touchp2.fingerId = 0;
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Inequality(a:  val_2.m_Handle.name, b:  "PlaySceneVs")) != false)
        {
                this.enabled = false;
            this.GetComponent<LineControllerAI>().enabled = true;
        }
        
        val_24 = null;
        val_24 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
                this.enabled = false;
            this.GetComponent<LineControllerAI>().enabled = true;
        }
        
        this.ballTempCounter = 0;
        this.playerBallTemp = new UnityEngine.GameObject[2];
        val_25 = null;
        val_25 = null;
        if(DataStructs.UserDataDictionary.Settings.FlipNegateX == 1)
        {
                UnityEngine.SceneManagement.Scene val_9 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if((System.String.op_Inequality(a:  val_9.m_Handle.name, b:  "PlaySceneVs")) != false)
        {
                this.stunCounter.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        }
        
        this.swipedBall = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "CanvasChild");
        this.VS_char_Image_CPU = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "AvatarCpu");
        this.specialBallButton = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "SpecialBallButton").GetComponent<UnityEngine.UI.Button>();
        this.specialBallButtonArrow = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "SpecialBallArrow").GetComponent<UnityEngine.UI.Button>();
        this.losePose = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "LosePose");
    }
    private void Start()
    {
        CharacterClan val_11;
        var val_26;
        var val_27;
        var val_30;
        var val_31;
        this.stuntime = 0f;
        val_26 = null;
        val_26 = null;
        this.angleHandler = (InstanceAnimator.playerNegateX == 1) ? 0 : 180;
        this.stunCounter.gameObject.SetActive(value:  false);
        this.stageNumber = Character_GlobalInfo.stage_CurrentLevel - 1;
        this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        UnityEngine.Vector3 val_8 = this.playerChar.transform.position;
        this.characterPos = val_8;
        mem[1152921526310885556] = val_8.y;
        mem[1152921526310885560] = val_8.z;
        this.originalPos = val_8;
        mem[1152921526310885544] = val_8.y;
        mem[1152921526310885548] = val_8.z;
        val_27 = null;
        val_27 = null;
        LineControllerP2.stunFlag = false;
        LineControllerP2.player2Lose = false;
        LineControllerP2.player2Win = false;
        this.CheckPlayerBall();
        this.forceFlag = true;
        LineControllerP2.touchFlagP2 = false;
        this.winSequenceFlag = true;
        this.looseSequenceFlag = true;
        this.isWaiting = false;
        LineControllerP2.BridgeStunP2 = 0;
        this.lineRenderer.GetComponent<UnityEngine.Animator>().Play(stateName:  "White");
        this.modeName = Character_GlobalInfo.gameMode;
        CharacterInfo val_10 = Character_GlobalInfo.GetOpponentPlayer();
        this.tempCharType = val_11;
        UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  this.LoadResources());
        System.Collections.IEnumerator val_15 = this.lineRenderer.transform.GetEnumerator();
        label_38:
        var val_28 = 0;
        val_28 = val_28 + 1;
        if(val_15.MoveNext() == false)
        {
            goto label_23;
        }
        
        var val_29 = 0;
        val_29 = val_29 + 1;
        val_30 = val_15.Current;
        if(val_30 != null)
        {
            
        }
        
        if(val_30 != null)
        {
                val_30 = 0;
        }
        
        bool val_26 = UnityEngine.Object.op_Implicit(exists:  val_30.gameObject.GetComponent<UnityEngine.SpriteRenderer>());
        goto label_38;
        label_23:
        val_31 = 0;
        if(val_15 != null)
        {
                var val_30 = 0;
            val_30 = val_30 + 1;
            val_15.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    private System.Collections.IEnumerator showStartText()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerP2.<showStartText>d__84();
    }
    private void Update()
    {
        var val_33;
        float val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_40;
        var val_41;
        var val_42;
        var val_44;
        var val_45;
        var val_46;
        UnityEngine.Touch[] val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        bool val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        val_33 = this;
        if((NetworkManager_Custom.IsNetwork != false) && (this.lastMoveAimLine > 0f))
        {
                val_35 = this.lastMoveAimLine - UnityEngine.Time.deltaTime;
            this.lastMoveAimLine = val_35;
            if(val_35 <= 0f)
        {
                UnityEngine.Debug.LogWarning(message:  "Aim line timed out");
            this.HideLineRenderer();
        }
        
        }
        
        if(this.GameWon != true)
        {
                if(this.GameLost == false)
        {
            goto label_7;
        }
        
        }
        
        label_20:
        val_36 = null;
        val_36 = null;
        if((InstanceAnimator.areBallsInstantiated != false) && (this.animController.currentAnimationName == 13))
        {
                UnityEngine.Debug.Log(message:  "herp");
        }
        
        label_178:
        if(this.touchp2.Seconds != 3)
        {
                return;
        }
        
        this.setTouchPos = false;
        val_33 = 1152921505077932032;
        val_37 = null;
        val_37 = null;
        LineControllerP2.touchFlagP2 = false;
        return;
        label_7:
        val_38 = null;
        val_38 = null;
        if(InstanceAnimator.areBallsInstantiated == false)
        {
            goto label_20;
        }
        
        if(this.winSequenceFlag == false)
        {
            goto label_30;
        }
        
        val_38 = null;
        if(InstanceAnimator.isInnerRingEmpty == false)
        {
            goto label_30;
        }
        
        val_38 = null;
        if((InstanceAnimator.isMiddleRingEmpty == false) || (InstanceAnimator.isOuterRingEmpty == false))
        {
            goto label_30;
        }
        
        this.PlayerLoseFunction();
        goto label_31;
        label_30:
        if(this.looseSequenceFlag == false)
        {
            goto label_45;
        }
        
        val_40 = null;
        val_40 = null;
        if(LineControllerP2.player2Win == false)
        {
            goto label_35;
        }
        
        label_45:
        val_41 = 0;
        goto label_36;
        label_35:
        val_42 = null;
        val_42 = null;
        if(InstanceAnimator.isPlayerInnerRingEmpty == false)
        {
            goto label_45;
        }
        
        val_42 = null;
        if((InstanceAnimator.isPlayerMiddleRingEmpty == false) || (InstanceAnimator.isPlayerOuterRingEmpty == false))
        {
            goto label_45;
        }
        
        this.PlayerWinFunction();
        label_31:
        val_41 = 1;
        label_36:
        val_44 = null;
        val_44 = null;
        if(LineController.stunFlag != false)
        {
                this.StunFunction();
        }
        
        val_45 = null;
        val_45 = null;
        if(LineControllerP2.receiveDamageFlag != false)
        {
                this.ReceiveDamageFunction();
        }
        
        if(NetworkManager_Custom.IsNetwork == true)
        {
                return;
        }
        
        if((this.touchp2.fingerId & 2147483648) != 0)
        {
            goto label_60;
        }
        
        val_46 = null;
        val_46 = null;
        if(LineControllerP2.touchFlagP2 == false)
        {
            goto label_56;
        }
        
        if((this.modeName == 4) || (this.stunSequenceFlag == true))
        {
            goto label_60;
        }
        
        goto label_59;
        label_56:
        if(this.modeName == 4)
        {
            goto label_60;
        }
        
        label_59:
        this.HideLineRenderer();
        label_60:
        val_47 = ControlKludges.Touches;
        this.myTouch = val_47;
        val_48 = 0;
        goto label_61;
        label_76:
        if(this.touchp2.fingerId == (0 + 32.fingerId))
        {
            goto label_74;
        }
        
        var val_12 = (this.myTouch + (0 * 68)) + 32;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_35, y = V1.16B});
        val_35 = val_13.x;
        UnityEngine.Vector3 val_14 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_35, y = val_13.y, z = val_13.z});
        if((val_14.x > 3.86f) && (this.setTouchPos != true))
        {
                if(((this.myTouch + (0 * 68)) + 32.Seconds) == 0)
        {
            goto label_74;
        }
        
        }
        
        val_47 = this.myTouch;
        val_48 = 1;
        label_61:
        if(val_48 < this.myTouch.Length)
        {
            goto label_76;
        }
        
        goto label_77;
        label_74:
        var val_19 = (this.myTouch + (0 * 68)) + 32;
        label_77:
        if(this.touchp2.Seconds == 3)
        {
                this.touchp2.fingerId = 0;
            this.HideLineRenderer();
        }
        
        val_49 = null;
        val_49 = null;
        if(((((((LineControllerP2.touchFlagP2 != true) && (this.stunSequenceFlag != true)) && (this.isWaiting != true)) && (this.animController.currentAnimationName != 8)) && (this.animController.currentAnimationName != 4)) && (this.animController.currentAnimationName != 5)) && (this.animController.currentAnimationName != 3))
        {
                if(this.playerBall != 0)
        {
                this.animController.PlayAnimation(newAnimName:  8, forceOverride:  false);
        }
        
        }
        
        if(this.playerBall == 0)
        {
            goto label_150;
        }
        
        val_50 = null;
        val_50 = null;
        if(InstanceAnimator.areBallsInstantiated == false)
        {
            goto label_150;
        }
        
        UnityEngine.Vector3 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_35, y = V1.16B});
        UnityEngine.Vector3 val_25 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        if(this.touchp2.Seconds == 1)
        {
                if(this.setTouchPos != true)
        {
                this.startPos = val_26;
            mem[1152921526311605132] = val_26.y;
        }
        
            if(val_26.x > 3.86f)
        {
                val_51 = null;
            val_51 = null;
            LineControllerP2.touchFlagP2 = true;
            this.setTouchPos = true;
            this.ShowLineRenderer();
        }
        else
        {
                this.setTouchPos = false;
            val_52 = null;
            val_52 = null;
            LineControllerP2.touchFlagP2 = false;
            if(this.animController.currentAnimationName != 2)
        {
                if(this.animController.currentAnimationName != 1)
        {
            goto label_118;
        }
        
        }
        
            this.animController.PlayAnimation(newAnimName:  8, forceOverride:  true);
        }
        
        }
        
        label_118:
        if(this.touchp2.Seconds == 3)
        {
            goto label_124;
        }
        
        val_53 = null;
        val_53 = null;
        if((LineControllerP2.touchFlagP2 == false) || (this.setTouchPos == false))
        {
            goto label_124;
        }
        
        this.endPos = val_26;
        mem[1152921526311605140] = val_26.y;
        UnityEngine.Vector2 val_29 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y}, b:  new UnityEngine.Vector2() {x = this.startPos, y = val_24.z});
        this.diff = val_29;
        mem[1152921526311605148] = val_29.y;
        val_54 = null;
        val_54 = null;
        if(InstanceAnimator.areBallsInstantiated == false)
        {
            goto label_129;
        }
        
        if(this.setup == false)
        {
            goto label_130;
        }
        
        val_55 = 0;
        this.setup = false;
        goto label_131;
        label_124:
        if(this.animController.currentAnimationName != 1)
        {
                if(this.animController.currentAnimationName != 2)
        {
            goto label_150;
        }
        
        }
        
        UnityEngine.Vector2 val_30 = UnityEngine.Vector2.zero;
        this.diff = val_30;
        mem[1152921526311605148] = val_30.y;
        this.endPos = val_30;
        mem[1152921526311605140] = val_30.y;
        this.startPos = val_30;
        mem[1152921526311605132] = val_30.y;
        this.HideLineRenderer();
        if((((this.setTouchPos == false) || (this.isWaiting == true)) || (this.stunSequenceFlag == true)) || (this.forceFlag == false))
        {
            goto label_150;
        }
        
        val_56 = null;
        val_56 = null;
        if(LineControllerP2.touchFlagP2 == false)
        {
            goto label_150;
        }
        
        val_57 = null;
        val_57 = null;
        if(InstanceAnimator.areBallsInstantiated == false)
        {
            goto label_150;
        }
        
        val_58 = null;
        val_58 = null;
        LineControllerP2.ballEntry = this.ballEntryTemp;
        this.ShootBubble(grid:  LineControllerP2.ballEntry, networkBubble:  new System.Nullable<System.Int32>() {HasValue = false});
        goto label_150;
        label_129:
        val_55 = true;
        label_131:
        this.isWaiting = val_55;
        label_130:
        this.ShowLineRenderer();
        this.MoveAimLine(differenceY:  val_29.x, network:  false);
        label_150:
        val_59 = null;
        val_60 = val_41;
        if((((InstanceAnimator.areBallsInstantiated != false) && (this.winSequenceFlag != false)) && (this.looseSequenceFlag != false)) && (this.stunSequenceFlag != true))
        {
                if(this.playerBall == 0)
        {
                val_61 = null;
            val_61 = null;
            float val_41 = (float)InstanceAnimator.playerNegateX;
            val_41 = InstanceAnimator.UniversalX * val_41;
            UnityEngine.Quaternion val_32 = UnityEngine.Quaternion.identity;
            UnityEngine.Rigidbody2D val_33 = UnityEngine.Object.Instantiate<UnityEngine.Rigidbody2D>(original:  this.playerBalls[0], position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_32.x, y = val_32.y, z = val_32.z, w = val_32.w});
            this.playerBall = val_33;
            val_33.gameObject.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.playerBall.gameObject.transform.GetChild(index:  0).gameObject.SetActive(value:  false);
            this.forceFlag = true;
        }
        
        }
        
        if( == 0)
        {
            goto label_178;
        }
        
        this.HideLineRenderer();
        goto label_178;
    }
    public void ReceiveAttackChargeAnimation()
    {
        var val_1;
        if(this.GameWon == true)
        {
                return;
        }
        
        if(this.GameLost == true)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        LineControllerP2.touchFlagP2 = true;
        if(this.animController.currentAnimationName == 1)
        {
                return;
        }
        
        if(this.animController.currentAnimationName == 2)
        {
                return;
        }
        
        this.animController.PlayAnimation(newAnimName:  1, forceOverride:  false);
    }
    public void MoveAimLine(float differenceY, bool network)
    {
        var val_14;
        var val_16;
        var val_63;
        float val_64;
        var val_65;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        float val_71;
        float val_72;
        var val_73;
        var val_74;
        val_64 = 0;
        if(network != false)
        {
                this.lastMoveAimLine = 0.5f;
        }
        
        val_65 = null;
        val_65 = null;
        if(LineController.instance.IsGameOnHold() == true)
        {
                return;
        }
        
        this.CheckPlayerBall();
        this.playerBall.gameObject.transform.Find(n:  "TrailNormal").gameObject.SetActive(value:  false);
        this.ShowLineRenderer();
        if(GlobalInfo.innerAimDifference < differenceY)
        {
            goto label_19;
        }
        
        val_64 = -GlobalInfo.innerAimDifference;
        if((val_64 > differenceY) || ((System.String.op_Inequality(a:  this.swipedBall.GetComponent<BallSwipeVs>().gameObject.tag, b:  "Stunner_Ball")) == false))
        {
            goto label_19;
        }
        
        if(this.isWaiting != true)
        {
                if(this.stunSequenceFlag == false)
        {
            goto label_21;
        }
        
        }
        
        val_63 = 1152921526109146016;
        UnityEngine.AnimatorStateInfo val_13 = this.lineRenderer.GetComponent<UnityEngine.Animator>().GetCurrentAnimatorStateInfo(layerIndex:  0);
        val_67 = val_14;
        val_68 = "MiddleRed";
        goto label_79;
        label_19:
        if(this.isWaiting != true)
        {
                if(this.stunSequenceFlag == false)
        {
            goto label_26;
        }
        
        }
        
        val_63 = 1152921526109146016;
        UnityEngine.AnimatorStateInfo val_18 = this.lineRenderer.GetComponent<UnityEngine.Animator>().GetCurrentAnimatorStateInfo(layerIndex:  0);
        val_67 = val_14;
        val_68 = "Red";
        label_79:
        if((230862480 & 1) == 0)
        {
                this.lineRenderer.GetComponent<UnityEngine.Animator>().Play(stateName:  "Red");
        }
        
        label_113:
        if((this.swipedBall.GetComponent<BallSwipeVs>().gameObject.CompareTag(tag:  "Stunner_Ball")) == false)
        {
            goto label_38;
        }
        
        val_16 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_69 = this.playerBall.transform;
        val_70 = 0f;
        goto label_42;
        label_38:
        if(GlobalInfo.innerAimDifference < differenceY)
        {
            goto label_43;
        }
        
        val_64 = -GlobalInfo.innerAimDifference;
        if(val_64 <= differenceY)
        {
            goto label_44;
        }
        
        label_43:
        if((-GlobalInfo.outerAimDifference) <= differenceY)
        {
            goto label_45;
        }
        
        val_63 = 1152921505069412352;
        val_16 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        float val_30 = (float)this.angleHandler - GlobalInfo.ballOuterEntryAngle;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_99:
        this.ballEntryTemp = 1;
        return;
        label_45:
        val_71 = -GlobalInfo.middleAimDifference;
        if(val_71 <= differenceY)
        {
            goto label_51;
        }
        
        val_71 = -GlobalInfo.outerAimDifference;
        if(val_71 <= differenceY)
        {
            goto label_52;
        }
        
        label_51:
        val_72 = -GlobalInfo.innerAimDifference;
        if(val_72 <= differenceY)
        {
            goto label_53;
        }
        
        val_72 = -GlobalInfo.middleAimDifference;
        if(val_72 <= differenceY)
        {
            goto label_54;
        }
        
        label_53:
        if(GlobalInfo.innerAimDifference < 0)
        {
                if(GlobalInfo.middleAimDifference >= differenceY)
        {
            goto label_56;
        }
        
        }
        
        if(GlobalInfo.middleAimDifference < 0)
        {
                if(GlobalInfo.outerAimDifference >= differenceY)
        {
            goto label_58;
        }
        
        }
        
        if(GlobalInfo.outerAimDifference >= 0)
        {
                return;
        }
        
        val_16 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        float val_42 = GlobalInfo.ballOuterEntryAngle + (float)this.angleHandler;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_99;
        label_44:
        val_16 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_69 = this.playerBall.transform;
        val_70 = 180f;
        label_42:
        val_69.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.ballEntryTemp = 0;
        return;
        label_26:
        if((this.animController.currentAnimationName != 1) && (this.animController.currentAnimationName != 2))
        {
                val_73 = null;
            val_73 = null;
            VoiceManager.instance.PlayAttackSound(Left:  0, SoundType:  5, modifiers:  0);
            this.animController.PlayAnimation(newAnimName:  1, forceOverride:  false);
        }
        
        UnityEngine.AnimatorStateInfo val_46 = this.lineRenderer.GetComponent<UnityEngine.Animator>().GetCurrentAnimatorStateInfo(layerIndex:  0);
        goto label_79;
        label_52:
        val_16 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        float val_49 = (float)this.angleHandler - GlobalInfo.ballMiddleEntryAngle;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_99;
        label_54:
        val_16 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        float val_52 = (float)this.angleHandler - GlobalInfo.MIN_CONTROL_SENSITIVE;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_99;
        label_56:
        val_16 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        float val_55 = GlobalInfo.MIN_CONTROL_SENSITIVE + (float)this.angleHandler;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_99;
        label_58:
        val_16 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        float val_58 = GlobalInfo.ballMiddleEntryAngle + (float)this.angleHandler;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_99;
        label_21:
        UnityEngine.AnimatorStateInfo val_60 = this.lineRenderer.GetComponent<UnityEngine.Animator>().GetCurrentAnimatorStateInfo(layerIndex:  0);
        if((230862480 & 1) == 0)
        {
                this.lineRenderer.GetComponent<UnityEngine.Animator>().Play(stateName:  "MiddleWhite");
        }
        
        if((this.animController.currentAnimationName == 1) || (this.animController.currentAnimationName == 2))
        {
            goto label_113;
        }
        
        val_74 = null;
        val_74 = null;
        VoiceManager.instance.PlayAttackSound(Left:  0, SoundType:  5, modifiers:  0);
        this.animController.PlayAnimation(newAnimName:  1, forceOverride:  false);
        goto label_113;
    }
    private void ShowLineRenderer()
    {
        var val_10;
        var val_14;
        var val_15;
        System.Collections.IEnumerator val_2 = this.lineRenderer.transform.GetEnumerator();
        label_21:
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_8;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_14 = val_2.Current;
        if(val_14 != null)
        {
                val_14 = 0;
        }
        
        val_10 = 0;
        UnityEngine.Color val_12 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_14.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a};
        goto label_21;
        label_8:
        val_15 = 0;
        if(val_2 != null)
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_2.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public void HideLineRenderer()
    {
        var val_9;
        var val_15;
        var val_16;
        if((((((this.stunSequenceFlag != true) && (this.isWaiting != true)) && (this.animController.currentAnimationName != 8)) && (this.animController.currentAnimationName != 4)) && (this.animController.currentAnimationName != 5)) && (this.animController.currentAnimationName != 3))
        {
                bool val_1 = UnityEngine.Object.op_Inequality(x:  this.playerBall, y:  0);
        }
        
        System.Collections.IEnumerator val_3 = this.lineRenderer.transform.GetEnumerator();
        label_33:
        var val_15 = 0;
        val_15 = val_15 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_20;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_15 = val_3.Current;
        if(val_15 != null)
        {
                val_15 = 0;
        }
        
        val_9 = 0;
        UnityEngine.Color val_13 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_15.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a};
        goto label_33;
        label_20:
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
    private void CheckPlayerBall()
    {
        var val_6;
        var val_7;
        val_6 = this;
        if(this.playerBall != 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        float val_7 = (float)InstanceAnimator.playerNegateX;
        val_7 = InstanceAnimator.UniversalX * val_7;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        UnityEngine.Rigidbody2D val_3 = UnityEngine.Object.Instantiate<UnityEngine.Rigidbody2D>(original:  this.playerBalls[0], position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
        this.playerBall = val_3;
        val_6 = val_3.gameObject.GetComponent<UnityEngine.SpriteRenderer>();
        val_6.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    private void rotateShootBubble(int entry)
    {
        this.CheckPlayerBall();
        if(entry > 6)
        {
                return;
        }
        
        var val_10 = 40840464 + (entry) << 2;
        val_10 = val_10 + 40840464;
        goto (40840464 + (entry) << 2 + 40840464);
    }
    public void ShootBubble(int grid, System.Nullable<int> networkBubble)
    {
        var val_133;
        var val_134;
        var val_135;
        string val_138;
        string val_139;
        UnityEngine.Sprite val_140;
        var val_141;
        var val_147;
        var val_148;
        var val_149;
        var val_150;
        float val_151;
        var val_152;
        float val_153;
        var val_157;
        string val_158;
        var val_159;
        var val_160;
        this.HideLineRenderer();
        this.ballEntryTemp = grid;
        val_133 = null;
        val_133 = null;
        LineControllerP2.ballEntry = grid;
        if(NetworkManager_Custom.IsNetwork != false)
        {
                val_134 = null;
            val_134 = null;
            this.rotateShootBubble(entry:  LineControllerP2.ballEntry);
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(methodName:  "IconMask");
        this.animController.PlayAnimation(newAnimName:  0, forceOverride:  false);
        val_135 = null;
        val_135 = null;
        VoiceManager.instance.PlayAttackSound(Left:  0, SoundType:  0, modifiers:  0);
        this.playerBall.gameObject.tag = this.swipedBall.GetComponent<BallSwipeVs>().gameObject.tag;
        this.playerBall.GetComponent<UnityEngine.SpriteRenderer>().sprite = this.swipedBall.GetComponent<BallSwipeVs>().GetComponent<UnityEngine.UI.Image>().sprite;
        if(NetworkManager_Custom.IsNetwork != true)
        {
                this.swipedBall.GetComponent<BallSwipeVs>().SwipeBall(networkTag:  0);
        }
        
        this.playerBall.gameObject.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        if((232864424 & 1) == 0)
        {
            goto label_32;
        }
        
        if(232864424 > 6)
        {
            goto label_33;
        }
        
        var val_135 = mem[4611686105299031956];
        val_135 = val_135 + 40840436;
        goto (mem[4611686105299031956] + 40840436);
        label_33:
        val_138 = "Blue";
        val_139 = "B";
        this.playerBall.gameObject.tag = ;
        UnityEngine.SpriteRenderer val_16 = this.playerBall.GetComponent<UnityEngine.SpriteRenderer>();
        System.Type val_136 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_18 = UnityEngine.Resources.Load(path:  null, systemTypeInstance:  val_136);
        if(val_16 == null)
        {
            goto label_45;
        }
        
        if(val_18 == null)
        {
            goto label_46;
        }
        
        label_48:
        val_136 = (null == null) ? (val_18) : 0;
        goto label_47;
        label_45:
        if(val_18 != null)
        {
            goto label_48;
        }
        
        label_46:
        val_140 = 0;
        label_47:
        val_16.sprite = val_140;
        label_32:
        UnityEngine.Transform val_21 = this.playerBall.gameObject.transform.GetChild(index:  0);
        if(((this.playerBall.gameObject.CompareTag(tag:  "Color_Eraser_Ball")) != true) && ((this.playerBall.gameObject.CompareTag(tag:  "Iron_Ball")) != true))
        {
                if((this.playerBall.gameObject.CompareTag(tag:  "Stunner_Ball")) != true)
        {
                if((this.playerBall.gameObject.CompareTag(tag:  "Rainbow_Bubble")) == false)
        {
            goto label_63;
        }
        
        }
        
        }
        
        this.playerBall.gameObject.transform.Find(n:  "TrailNormal").gameObject.SetActive(value:  false);
        bool val_35 = this.playerBall.gameObject.CompareTag(tag:  "Color_Eraser_Ball");
        UnityEngine.GameObject val_36 = this.playerBall.gameObject;
        if(val_36 == null)
        {
            goto label_72;
        }
        
        if(val_35 == false)
        {
            goto label_73;
        }
        
        label_121:
        val_36.transform.GetChild(index:  3).gameObject.SetActive(value:  true);
        val_141 = null;
        val_141 = null;
        UnityEngine.AudioSource val_40 = VoiceManager.instance.Source;
        if(val_40 != null)
        {
            goto label_161;
        }
        
        label_162:
        label_161:
        val_40.PlayOneShot(clip:  this.popClip[2], volumeScale:  1f);
        label_150:
        val_21.gameObject.SetActive(value:  true);
        val_21.gameObject.GetComponent<UnityEngine.Animator>().Play(stateName:  this.playerBall.gameObject.tag);
        label_198:
        UnityEngine.Vector3 val_47 = this.transform.right;
        UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z}, d:  this.speed);
        UnityEngine.Vector2 val_49 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z});
        this.playerBall.AddRelativeForce(relativeForce:  new UnityEngine.Vector2() {x = val_49.x, y = val_49.y}, mode:  0);
        UnityEngine.Vector3 val_51 = this.playerBall.transform.localEulerAngles;
        System.Collections.IEnumerator val_53 = this.playerBall.transform.GetEnumerator();
        goto label_112;
        label_119:
        var val_138 = 0;
        val_138 = val_138 + 1;
        object val_55 = val_53.Current;
        UnityEngine.Vector3 val_57 = 0.localEulerAngles;
        UnityEngine.Vector3 val_58 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z}, b:  new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z});
        0.localEulerAngles = new UnityEngine.Vector3() {x = val_58.x, y = val_58.y, z = val_58.z};
        label_112:
        var val_139 = 0;
        val_139 = val_139 + 1;
        if(val_53.MoveNext() == true)
        {
            goto label_119;
        }
        
        val_147 = 0;
        goto label_120;
        label_72:
        if(val_35 == true)
        {
            goto label_121;
        }
        
        label_73:
        bool val_61 = val_36.CompareTag(tag:  "Iron_Ball");
        UnityEngine.GameObject val_62 = this.playerBall.gameObject;
        if(val_62 == null)
        {
            goto label_123;
        }
        
        if(val_61 == false)
        {
            goto label_124;
        }
        
        label_135:
        val_62.transform.GetChild(index:  4).gameObject.SetActive(value:  true);
        val_148 = null;
        val_148 = null;
        UnityEngine.AudioClip val_140 = this.popClip[3];
        if(VoiceManager.instance.Source != null)
        {
            goto label_161;
        }
        
        goto label_162;
        label_123:
        if(val_61 == true)
        {
            goto label_135;
        }
        
        label_124:
        bool val_67 = val_62.CompareTag(tag:  "Stunner_Ball");
        UnityEngine.GameObject val_68 = this.playerBall.gameObject;
        if(val_68 == null)
        {
            goto label_137;
        }
        
        if(val_67 == false)
        {
            goto label_138;
        }
        
        label_149:
        val_68.transform.GetChild(index:  5).gameObject.SetActive(value:  true);
        val_149 = null;
        val_149 = null;
        UnityEngine.AudioClip val_141 = this.popClip[4];
        if(VoiceManager.instance.Source != null)
        {
            goto label_161;
        }
        
        goto label_162;
        label_137:
        if(val_67 == true)
        {
            goto label_149;
        }
        
        label_138:
        if((val_68.CompareTag(tag:  "Rainbow_Bubble")) == false)
        {
            goto label_150;
        }
        
        this.playerBall.gameObject.transform.GetChild(index:  2).gameObject.SetActive(value:  true);
        val_150 = null;
        val_150 = null;
        UnityEngine.AudioClip val_142 = this.popClip[1];
        if(VoiceManager.instance.Source != null)
        {
            goto label_161;
        }
        
        goto label_162;
        label_63:
        this.playerBall.gameObject.transform.Find(n:  "TrailNormal").gameObject.SetActive(value:  true);
        UnityEngine.GameObject val_85 = this.playerBall.gameObject;
        if((this.playerBall.gameObject.CompareTag(tag:  "Red")) == false)
        {
            goto label_172;
        }
        
        val_151 = 0.6f;
        val_152 = val_85.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        val_153 = 0f;
        goto label_219;
        label_172:
        UnityEngine.GameObject val_91 = this.playerBall.gameObject;
        if((val_85.CompareTag(tag:  "Yellow")) == false)
        {
            goto label_179;
        }
        
        val_153 = 0.92f;
        val_151 = 0.6f;
        val_152 = val_91.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_219;
        label_179:
        UnityEngine.GameObject val_97 = this.playerBall.gameObject;
        if((val_91.CompareTag(tag:  "Blue")) == false)
        {
            goto label_186;
        }
        
        val_151 = 0.6f;
        val_152 = val_97.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        val_153 = 0f;
        label_219:
        UnityEngine.Color val_102 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_152.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_102.r, g = val_102.g, b = val_102.b, a = val_102.a});
        label_213:
        UnityEngine.AudioSource val_104 = GameAudio.sound.PlayOneShot(clip:  this.popClip[0], volume:  1f);
        val_21.gameObject.SetActive(value:  false);
        goto label_198;
        label_186:
        UnityEngine.GameObject val_107 = this.playerBall.gameObject;
        if((val_97.CompareTag(tag:  "Green")) == false)
        {
            goto label_201;
        }
        
        UnityEngine.Material val_111 = val_107.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_219;
        label_201:
        UnityEngine.GameObject val_113 = this.playerBall.gameObject;
        if((val_107.CompareTag(tag:  "Orange")) == false)
        {
            goto label_208;
        }
        
        UnityEngine.Material val_117 = val_113.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_219;
        label_208:
        if((val_113.CompareTag(tag:  "Purple")) == false)
        {
            goto label_213;
        }
        
        UnityEngine.Material val_123 = this.playerBall.gameObject.transform.Find(n:  "TrailNormal").GetComponent<UnityEngine.TrailRenderer>().material;
        goto label_219;
        label_120:
        if(val_21 != null)
        {
                var val_144 = 0;
            val_144 = val_144 + 1;
            val_21.Dispose();
        }
        
        this.playerBall.transform.rotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        UnityEngine.Coroutine val_126 = this.StartCoroutine(methodName:  "PostAttackSequence");
        val_157 = null;
        val_157 = null;
        LineControllerP2.popTagPlayer = this.playerBall.gameObject.tag;
        this.forceFlag = false;
        LineControllerP2.touchFlagP2 = false;
        this.setTouchPos = false;
        UnityEngine.Coroutine val_129 = this.StartCoroutine(methodName:  "GapTranslate");
        if(LineControllerP2.ballEntry != 0)
        {
                UnityEngine.Coroutine val_130 = this.StartCoroutine(methodName:  "ActivateCollider");
            val_158 = "MakeBallNull";
        }
        else
        {
                if((this.playerBall.gameObject.CompareTag(tag:  "Stunner_Ball")) != false)
        {
                val_158 = "StunOpponent";
        }
        else
        {
                val_158 = "DestroyBall";
        }
        
        }
        
        UnityEngine.Coroutine val_133 = this.StartCoroutine(methodName:  val_158);
        val_159 = null;
        val_159 = null;
        val_160 = null;
        val_160 = null;
        this.playerBall.GetComponent<TargetBall_Parent>().SetPredictions(theirRingOuter:  InstanceAnimator.playerOuterRingBalls, theirRingMiddle:  InstanceAnimator.playerMiddleRingBalls, theirRingInner:  InstanceAnimator.playerInnerRingBalls, ourRingOuter:  InstanceAnimator.outerRingBalls, ourRingMiddle:  InstanceAnimator.middleRingBalls, ourRingInner:  InstanceAnimator.innerRingBalls, ballEntry:  LineControllerP2.ballEntry);
    }
    public void gapTransp2()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "GapTranslate");
    }
    private System.Collections.IEnumerator ActivateCollider()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerP2.<ActivateCollider>d__96();
    }
    private System.Collections.IEnumerator MakeBallNull()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerP2.<MakeBallNull>d__97();
    }
    public static float Getinkpos()
    {
        null = null;
        return (float)LineControllerP2.inkpos;
    }
    private System.Collections.IEnumerator GapTranslate()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerP2.<GapTranslate>d__99();
    }
    private System.Collections.IEnumerator GapTranslationUpperPart(UnityEngine.GameObject[] ringBalls, int mid, float radius, float upperAngle, float angleDiff, int negateX)
    {
        LineControllerP2.<GapTranslationUpperPart>d__100 val_1 = new LineControllerP2.<GapTranslationUpperPart>d__100();
        .<>1__state = 0;
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
        LineControllerP2.<GapTranslationLowerPart>d__101 val_1 = new LineControllerP2.<GapTranslationLowerPart>d__101();
        .<>1__state = 0;
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
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerP2.<StunSequence>d__102();
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
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerP2.<PopSequenceStun>d__104();
    }
    private System.Collections.IEnumerator LooseSequence()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerP2.<LooseSequence>d__105();
    }
    private System.Collections.IEnumerator WinSequence()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerP2.<WinSequence>d__106();
    }
    private System.Collections.IEnumerator DestroyPlayerBalls(UnityEngine.GameObject[] ringArray, int length, bool ifWin)
    {
        LineControllerP2.<DestroyPlayerBalls>d__107 val_1 = new LineControllerP2.<DestroyPlayerBalls>d__107();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .ringArray = ringArray;
            .length = length;
        }
        else
        {
                mem[48] = this;
            mem[32] = ringArray;
            mem[40] = length;
        }
        
        .ifWin = ifWin;
        return (System.Collections.IEnumerator)val_1;
    }
    private void CountPlayerBalls(UnityEngine.GameObject[] ringArray, int length)
    {
        var val_2;
        var val_3;
        if(length < 1)
        {
                return;
        }
        
        do
        {
            if(1152921508657404416 != 0)
        {
                val_3 = null;
            val_3 = null;
            int val_2 = LineControllerP2.remainingBallsCountP2;
            val_2 = val_2 + 1;
            LineControllerP2.remainingBallsCountP2 = val_2;
        }
        
            val_2 = 0 + 1;
        }
        while(length != val_2);
    
    }
    public System.Collections.IEnumerator LoadResources()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerP2.<LoadResources>d__109();
    }
    public System.Collections.IEnumerator startDefenceSequence()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerP2.<startDefenceSequence>d__110();
    }
    public void SetIconActive_GameBegin()
    {
        this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = 1f;
        this.specialBallButton.interactable = true;
        this.specialBallButtonArrow.interactable = true;
    }
    private System.Collections.IEnumerator PostAttackSequence()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerP2.<PostAttackSequence>d__112();
    }
    private System.Collections.IEnumerator FinishAttack()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerP2.<FinishAttack>d__113();
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
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerP2.<DestroyBall>d__115();
    }
    private System.Collections.IEnumerator IconMask()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerP2.<IconMask>d__116();
    }
    private System.Collections.IEnumerator StunOpponent()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerP2.<StunOpponent>d__117();
    }
    public void PlayerLoseFunction()
    {
        var val_7;
        var val_8;
        this.CancelInvoke();
        this.StopCoroutine(methodName:  "StunOpponent");
        this.StopCoroutine(methodName:  "PostAttackSequence");
        this.StopCoroutine(methodName:  "StunSequence");
        this.StopCoroutine(methodName:  "PopSequenceStun");
        this.StopCoroutine(methodName:  "IconMask");
        if(this.PlayedLose != true)
        {
                val_7 = null;
            val_7 = null;
            VoiceManager.instance.PlayAttackSound(Left:  0, SoundType:  3, modifiers:  0);
            this.PlayedLose = true;
        }
        
        this.looseSequenceFlag = false;
        this.GameLost = true;
        val_8 = null;
        val_8 = null;
        LineControllerP2.player2Lose = true;
        this.stunCounter.gameObject.SetActive(value:  false);
        this.HideLineRenderer();
        this.iconPlayerActive.SetActive(value:  true);
        UnityEngine.Color val_2 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.animController.image_Body.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        this.animController.pause = false;
        this.playerChar.transform.position = new UnityEngine.Vector3() {x = this.characterPos, y = val_2.g, z = val_2.b};
        this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        UnityEngine.Coroutine val_6 = this.StartCoroutine(methodName:  "LooseSequence");
    }
    public void PlayerWinFunction()
    {
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
        
        this.HideLineRenderer();
        this.iconPlayerActive.SetActive(value:  true);
        UnityEngine.Color val_9 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.animController.image_Body.color = new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a};
        this.animController.pause = false;
        this.playerChar.transform.position = new UnityEngine.Vector3() {x = this.characterPos, y = val_9.g, z = val_9.b};
        this.stunCounter.gameObject.SetActive(value:  false);
        this.animController.PlayAnimation(newAnimName:  8, forceOverride:  true);
        UnityEngine.Coroutine val_12 = this.StartCoroutine(methodName:  "WinSequence");
    }
    private void ReceiveDamageFunction()
    {
        var val_6;
        float val_7;
        float val_9;
        float val_13;
        var val_14;
        var val_15;
        this.forceFlag = false;
        val_6 = null;
        val_6 = null;
        LineControllerP2.touchFlagP2 = false;
        this.setTouchPos = false;
        this.StopCoroutine(methodName:  "PostAttackSequence");
        UnityEngine.Color val_1 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_7 = val_1.b;
        this.animController.image_Body.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_7, a = val_1.a};
        if(LineControllerP2.BridgeStunP2 <= 3)
        {
                var val_6 = 40840420 + (LineControllerP2.BridgeStunP2) << 2;
            val_6 = val_6 + 40840420;
        }
        else
        {
                val_9 = this.cpuStunVariable * (float)LineControllerP2.numberOfPops;
            this.playerStunTime = ;
            val_13 = this.reloadTime;
            float val_2 = UnityEngine.Mathf.Max(a:  val_13, b:  0f);
            val_2 = val_2 + this.playerStunTime;
            this.playerStunTime = val_2;
            mem2[0] = 1084227584;
            this.iconPlayerActive.GetComponent<UnityEngine.UI.Image>().fillAmount = 1f;
            val_14 = null;
            val_14 = null;
            LineControllerP2.BridgeStunP2 = 0;
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
            this.CancelInvoke();
            this.animController.pause = false;
            val_13 = this.characterPos;
            this.playerChar.transform.position = new UnityEngine.Vector3() {x = val_13, y = val_1.g, z = val_7};
            UnityEngine.Coroutine val_5 = this.StartCoroutine(methodName:  "PopSequenceStun");
        }
        
            val_15 = null;
            val_15 = null;
            LineControllerP2.receiveDamageFlag = false;
        }
    
    }
    private void StunFunction()
    {
        var val_4;
        var val_5;
        this.CancelInvoke();
        this.forceFlag = false;
        this.stunSequenceFlag = true;
        val_4 = null;
        val_4 = null;
        LineControllerP2.touchFlagP2 = false;
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
        this.shake = 0f;
        this.iconPlayerActive.SetActive(value:  false);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(methodName:  "StunSequence");
        val_5 = static_value_032DD328;
        val_5 = static_value_032DD328;
        mem2[0] = 0;
    }
    private void ExBattleStunLine()
    {
        var val_10;
        float val_11;
        var val_12;
        var val_38;
        float val_39;
        float val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        int val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        val_38 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = V1.16B});
        val_39 = val_2.z;
        UnityEngine.Vector3 val_3 = val_38.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_39});
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        val_40 = val_4.y;
        if(this.touchp2.Seconds == 1)
        {
                if(this.setTouchPos == false)
        {
            goto label_5;
        }
        
        }
        
        if((this.touchp2.Seconds == 3) || (this.setTouchPos == false))
        {
            goto label_89;
        }
        
        this.endPos = val_4;
        mem[1152921526319903892] = val_4.y;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = this.startPos, y = val_39});
        this.diff = val_7;
        mem[1152921526319903900] = val_7.y;
        this.ShowLineRenderer();
        val_40 = 12f;
        if((val_7.x > val_40) || (val_7.x < (-12f)))
        {
            goto label_11;
        }
        
        val_41 = 1152921526109146016;
        val_38 = this.lineRenderer.GetComponent<UnityEngine.Animator>();
        UnityEngine.AnimatorStateInfo val_9 = val_38.GetCurrentAnimatorStateInfo(layerIndex:  0);
        val_42 = val_10;
        val_43 = "MiddleRed";
        goto label_14;
        label_5:
        if(((val_4.x <= 3.86f) || (val_40 <= (-3.5f))) || (val_40 >= 0))
        {
            goto label_89;
        }
        
        this.startPos = 3.5f;
        mem[1152921526319903884] = val_4.y;
        this.setTouchPos = true;
        goto label_89;
        label_11:
        val_41 = 1152921526109146016;
        val_38 = this.lineRenderer.GetComponent<UnityEngine.Animator>();
        UnityEngine.AnimatorStateInfo val_14 = val_38.GetCurrentAnimatorStateInfo(layerIndex:  0);
        val_42 = val_10;
        val_43 = "Red";
        label_14:
        if((238208176 & 1) == 0)
        {
                val_38 = this.lineRenderer.GetComponent<UnityEngine.Animator>();
            val_38.Play(stateName:  "Red");
        }
        
        if((val_11 > val_40) || (val_11 < (-12f)))
        {
            goto label_25;
        }
        
        val_12 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_44 = null;
        val_44 = null;
        float val_38 = 0f;
        float val_37 = (float)-InstanceAnimator.playerNegateX;
        val_37 = val_37 * val_38;
        val_38 = (float)this.angleHandler - val_37;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_38 = 1152921505077932032;
        val_45 = null;
        val_45 = null;
        LineControllerP2.ballEntry = 0;
        goto label_89;
        label_25:
        if((val_11 >= 0) || (val_11 < (-36f)))
        {
            goto label_36;
        }
        
        val_12 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_46 = null;
        val_40 = GlobalInfo.MIN_CONTROL_SENSITIVE;
        val_46 = null;
        float val_39 = (float)-InstanceAnimator.playerNegateX;
        val_39 = val_40 * val_39;
        float val_20 = (float)this.angleHandler - val_39;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_38 = 1152921505077932032;
        val_47 = null;
        val_47 = null;
        val_49 = 3;
        goto label_88;
        label_36:
        if((val_11 >= 0) || (val_11 < (-60f)))
        {
            goto label_47;
        }
        
        val_12 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_50 = null;
        val_40 = GlobalInfo.ballMiddleEntryAngle;
        val_50 = null;
        float val_40 = (float)-InstanceAnimator.playerNegateX;
        val_40 = val_40 * val_40;
        float val_23 = (float)this.angleHandler - val_40;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_38 = 1152921505077932032;
        val_51 = null;
        val_51 = null;
        val_49 = 2;
        goto label_88;
        label_47:
        if(val_11 >= 0)
        {
            goto label_57;
        }
        
        val_12 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_52 = null;
        val_40 = GlobalInfo.ballOuterEntryAngle;
        val_52 = null;
        float val_41 = (float)-InstanceAnimator.playerNegateX;
        val_41 = val_40 * val_41;
        float val_26 = (float)this.angleHandler - val_41;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_38 = 1152921505077932032;
        val_53 = null;
        val_53 = null;
        val_49 = 1;
        goto label_88;
        label_57:
        if((val_11 <= val_40) || (val_11 > 36f))
        {
            goto label_68;
        }
        
        val_12 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_54 = null;
        val_40 = GlobalInfo.MIN_CONTROL_SENSITIVE;
        val_54 = null;
        float val_42 = (float)-InstanceAnimator.playerNegateX;
        val_42 = val_40 * val_42;
        float val_29 = val_42 + (float)this.angleHandler;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_38 = 1152921505077932032;
        val_55 = null;
        val_55 = null;
        val_49 = 4;
        goto label_88;
        label_68:
        if((val_11 <= 36f) || (val_11 > 60f))
        {
            goto label_79;
        }
        
        val_12 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_56 = null;
        val_40 = GlobalInfo.ballMiddleEntryAngle;
        val_56 = null;
        float val_43 = (float)-InstanceAnimator.playerNegateX;
        val_43 = val_40 * val_43;
        float val_32 = val_43 + (float)this.angleHandler;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_38 = 1152921505077932032;
        val_57 = null;
        val_57 = null;
        val_49 = 5;
        goto label_88;
        label_79:
        if(val_11 <= 60f)
        {
            goto label_89;
        }
        
        val_12 = 0;
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_58 = null;
        val_40 = GlobalInfo.ballOuterEntryAngle;
        val_58 = null;
        float val_44 = (float)-InstanceAnimator.playerNegateX;
        val_44 = val_40 * val_44;
        float val_35 = val_44 + (float)this.angleHandler;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_38 = 1152921505077932032;
        val_59 = null;
        val_59 = null;
        val_49 = 6;
        label_88:
        LineControllerP2.ballEntry = val_49;
        label_89:
        if(this.touchp2.Seconds != 3)
        {
                return;
        }
        
        this.HideLineRenderer();
    }
    private void ShootInTutorial()
    {
        this.animController.PlayAnimation(newAnimName:  0, forceOverride:  false);
    }
    internal void SetIconPlayerActive(UnityEngine.Sprite sprite)
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
    public LineControllerP2()
    {
        mem2[0] = 1036831949;
        this.setup = true;
    }
    private static LineControllerP2()
    {
    
    }

}
