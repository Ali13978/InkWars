using UnityEngine;
public class InteractiveTutorialManager : MonoBehaviour
{
    // Fields
    private static InteractiveTutorialManager _instance;
    public UnityEngine.GameObject ballChangeButton;
    public UnityEngine.Rigidbody2D[] playerBalls;
    public UnityEngine.SpriteRenderer battleGridPlayer;
    public UnityEngine.GameObject iconPlayerActive;
    public UnityEngine.GameObject iconPlayerInactive;
    public UnityEngine.GameObject lineRenderer;
    public UnityEngine.GameObject reloadBallPlayer;
    public UnityEngine.GameObject[] playerBallsSwipe;
    public UnityEngine.UI.Text stunCounterPlayer;
    public UnityEngine.SpriteRenderer battleGridCPU;
    public UnityEngine.GameObject iconCPUActive;
    public UnityEngine.GameObject iconCPUInactive;
    public UnityEngine.GameObject lineRendererCPU;
    public UnityEngine.GameObject reloadBallCPU;
    public UnityEngine.GameObject[] cpuBallsSwipe;
    public UnityEngine.UI.Text stunCounterCPU;
    public UnityEngine.GameObject rechargingAnimObject;
    private bool winSequenceFlag;
    private bool looseSequenceFlag;
    private bool flagSwipeBall;
    public UnityEngine.GameObject popAnimationPlayer;
    private UnityEngine.Vector2 startPos;
    private UnityEngine.Vector2 endPos;
    private UnityEngine.Vector2 diff;
    public float sensitivity;
    private float distance;
    private UnityEngine.Rigidbody2D playerBall;
    private UnityEngine.Rigidbody2D _cpuBall;
    private UnityEngine.GameObject[] playerBallTemp;
    public float speed;
    public static int ballEntry;
    public static int ballEntryTemp;
    private bool forceFlag;
    public static bool touchFlag;
    public static string popTagPlayer;
    public UnityEngine.GameObject playerChar;
    private CharAnimationController _animController_Player;
    public UnityEngine.AudioClip matchConclusion;
    public UnityEngine.AudioClip winClip;
    public float shake;
    private float shakeAmount;
    private float decreaseFactor;
    private UnityEngine.Vector3 originalPos;
    private UnityEngine.Vector3 characterPos;
    private UnityEngine.AudioClip vortexClip;
    public int angleHandler;
    public UnityEngine.GameObject entryIndicators;
    private int ballTempCounter;
    private float angle1;
    private float angle2;
    private float angle3;
    private float angle11;
    private float angle22;
    private float angle33;
    public UnityEngine.GameObject playerCharCpu;
    private CharAnimationController animController_CPU;
    private bool aimingMiddle;
    private bool pauseInput;
    public UnityEngine.GameObject demoManager;
    private UnityEngine.GameObject cpuBridge;
    private UnityEngine.GameObject playerBridge;
    private TutorialDataManager.PlayerData Player_Left;
    private TutorialDataManager.PlayerData Player_Right;
    public bool trigger_CPUShoot;
    
    // Properties
    public static InteractiveTutorialManager Instance { get; }
    private UnityEngine.Rigidbody2D cpuBall { get; }
    public CharAnimationController animController_Player { get; }
    public static UnityEngine.GameObject[][] PlayerRings { get; }
    public static UnityEngine.GameObject[][] CPURings { get; }
    public string CharacterFile { get; }
    public string StageFile { get; }
    
    // Methods
    public static InteractiveTutorialManager get_Instance()
    {
        if(InteractiveTutorialManager._instance != 0)
        {
                return (InteractiveTutorialManager)InteractiveTutorialManager._instance;
        }
        
        InteractiveTutorialManager._instance = UnityEngine.Object.FindObjectOfType<InteractiveTutorialManager>();
        return (InteractiveTutorialManager)InteractiveTutorialManager._instance;
    }
    private UnityEngine.Rigidbody2D get_cpuBall()
    {
        var val_6;
        if(this._cpuBall != 0)
        {
                return (UnityEngine.Rigidbody2D)this._cpuBall;
        }
        
        val_6 = null;
        val_6 = null;
        float val_7 = (float)InstanceAnimator.playerNegateX;
        val_7 = InstanceAnimator.UniversalX * val_7;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        UnityEngine.Rigidbody2D val_3 = UnityEngine.Object.Instantiate<UnityEngine.Rigidbody2D>(original:  this.playerBalls[0], position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
        this._cpuBall = val_3;
        val_3.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        TargetBallDemo val_5 = this._cpuBall.GetComponent<TargetBallDemo>();
        val_5.isCPUBall = true;
        return (UnityEngine.Rigidbody2D)this._cpuBall;
    }
    public CharAnimationController get_animController_Player()
    {
        CharAnimationController val_3;
        if(this._animController_Player == 0)
        {
                this._animController_Player = this.playerChar.GetComponent<CharAnimationController>();
            return val_3;
        }
        
        val_3 = this._animController_Player;
        return val_3;
    }
    public static UnityEngine.GameObject[][] get_PlayerRings()
    {
        var val_2;
        UnityEngine.GameObject[][] val_1 = new UnityEngine.GameObject[][3];
        val_2 = null;
        val_2 = null;
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(InstanceAnimator.playerInnerRingBalls != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(InstanceAnimator.playerInnerRingBalls == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = InstanceAnimator.playerInnerRingBalls;
        val_1[1] = InstanceAnimator.playerMiddleRingBalls;
        val_1[2] = InstanceAnimator.playerOuterRingBalls;
        return val_1;
    }
    public static UnityEngine.GameObject[][] get_CPURings()
    {
        var val_2;
        UnityEngine.GameObject[][] val_1 = new UnityEngine.GameObject[][3];
        val_2 = null;
        val_2 = null;
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(InstanceAnimator.innerRingBalls != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(InstanceAnimator.innerRingBalls == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = InstanceAnimator.innerRingBalls;
        val_1[1] = InstanceAnimator.middleRingBalls;
        val_1[2] = InstanceAnimator.outerRingBalls;
        return val_1;
    }
    private static void SetIcons(TutorialDataManager.PlayerData data, UnityEngine.UI.Image iconActive, UnityEngine.UI.Image iconInactive, UnityEngine.UI.Image bubbleSwitcher, UnityEngine.SpriteRenderer battleGrid)
    {
        TutorialDataManager val_1 = TutorialDataManager.Instance;
        battleGrid.sprite = (data.IsTako == true) ? val_1.BattleGridTako : val_1.BattleGridIka;
        TutorialDataManager val_3 = TutorialDataManager.Instance;
        var val_4 = (data.IsTako == true) ? val_3.iconsActiveTako : val_3.iconsActiveIka;
        if(TutorialDataManager.Instance == null)
        {
            goto label_5;
        }
        
        if(data.IsTako == false)
        {
            goto label_6;
        }
        
        label_22:
        if(iconInactive != null)
        {
            goto label_23;
        }
        
        label_24:
        label_23:
        iconInactive.sprite = val_5.iconInactiveTako;
        if(data.CharacterSpeedInSeconds != 0.4f)
        {
            goto label_8;
        }
        
        if(iconActive != null)
        {
            goto label_48;
        }
        
        label_49:
        label_48:
        iconActive.sprite = data.IsTako == true ? val_3.iconsActiveTako : val_3.iconsActiveIka + 56;
        if(bubbleSwitcher == 0)
        {
                return;
        }
        
        TutorialDataManager val_7 = TutorialDataManager.Instance;
        if(data.RainbowFrequency == 3)
        {
            goto label_16;
        }
        
        if(data.RainbowFrequency == 2)
        {
            goto label_17;
        }
        
        if(data.RainbowFrequency != 1)
        {
            goto label_18;
        }
        
        if(bubbleSwitcher != null)
        {
            goto label_45;
        }
        
        label_46:
        label_45:
        bubbleSwitcher.sprite = val_7.switcherSprites[0];
        return;
        label_5:
        if(data.IsTako == true)
        {
            goto label_22;
        }
        
        label_6:
        if(iconInactive != null)
        {
            goto label_23;
        }
        
        goto label_24;
        label_8:
        if(data.CharacterSpeedInSeconds != 1f)
        {
            goto label_25;
        }
        
        if(iconActive != null)
        {
            goto label_48;
        }
        
        goto label_49;
        label_25:
        if(data.CharacterSpeedInSeconds != 1.5f)
        {
            goto label_31;
        }
        
        if(iconActive != null)
        {
            goto label_48;
        }
        
        goto label_49;
        label_16:
        UnityEngine.Sprite val_9 = val_7.switcherSprites[2];
        if(bubbleSwitcher != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_17:
        UnityEngine.Sprite val_10 = val_7.switcherSprites[1];
        if(bubbleSwitcher != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_18:
        UnityEngine.Sprite val_11 = val_7.switcherSprites[3];
        if(bubbleSwitcher != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_31:
        if(iconActive != null)
        {
            goto label_48;
        }
        
        goto label_49;
    }
    public string get_CharacterFile()
    {
        DemoManager val_1 = DemoManager.Instance;
        if(val_1.IsAdvancedTutorialMode == false)
        {
                return "Tako_0.json";
        }
        
        if(this.Player_Left != null)
        {
                return this.Player_Left.JSON;
        }
        
        return this.Player_Left.JSON;
    }
    public string get_StageFile()
    {
        DemoManager val_1 = DemoManager.Instance;
        if(val_1.IsAdvancedTutorialMode == false)
        {
                return "Stage00.json";
        }
        
        if(this.Player_Right != null)
        {
                return this.Player_Right.JSON;
        }
        
        return this.Player_Right.JSON;
    }
    public void SetPlayers(int stage, int subStage = 0)
    {
        PlayerData val_16;
        this.ResetEverything();
        if(stage <= 3)
        {
                var val_16 = 40830864 + (stage) << 2;
            val_16 = val_16 + 40830864;
        }
        else
        {
                val_16 = this.Player_Left;
            mem2[0] = this.playerChar;
            this.Player_Right.gameObject = this.playerCharCpu;
            DemoManager val_12 = DemoManager.Instance;
            if(val_12.IsAdvancedTutorialMode != false)
        {
                val_16 = this.Player_Right;
            DemoCanvas.Instance.SetTopBar(player_Left:  mem[this.Player_Left], player_Right:  val_16);
        }
        
            UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  this.startDefenceSequence());
        }
    
    }
    private void Start()
    {
        var val_24;
        float val_25;
        float val_26;
        var val_27;
        var val_28;
        float val_29;
        var val_30;
        this.flagSwipeBall = true;
        DemoManager val_1 = DemoManager.Instance;
        if(val_1.IsAdvancedTutorialMode != false)
        {
                this.EnableBallChange(enable:  true);
        }
        
        val_24 = null;
        val_24 = null;
        float val_25 = (float)InstanceAnimator.playerNegateX;
        val_25 = -(InstanceAnimator.UniversalX * val_25);
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        val_25 = val_2.x;
        val_26 = val_2.z;
        UnityEngine.Rigidbody2D val_3 = UnityEngine.Object.Instantiate<UnityEngine.Rigidbody2D>(original:  this.playerBalls[0], position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_25, y = val_2.y, z = val_26, w = val_2.w});
        this.playerBall = val_3;
        val_3.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        this.ballTempCounter = 0;
        this.pauseInput = true;
        this.winSequenceFlag = true;
        this.looseSequenceFlag = true;
        this.playerBallTemp = new UnityEngine.GameObject[2];
        InteractiveTutorialManager.popTagPlayer = "Red";
        var val_6 = (InstanceAnimator.UniversalX == 4.46f) ? 1 : 0;
        this.angle2 = (InstanceAnimator.UniversalX == 4.46f) ? 18.2f : 23f;
        this.angle11 = (InstanceAnimator.UniversalX == 4.46f) ? 11f : 14.4f;
        this.angle22 = (InstanceAnimator.UniversalX == 4.46f) ? 18f : 23f;
        this.angle33 = (InstanceAnimator.UniversalX == 4.46f) ? 25f : 31.5f;
        this.angle1 = 40830772 + InstanceAnimator.UniversalX == 4.46f ? 1 : 0;
        this.angle3 = 40830780 + InstanceAnimator.UniversalX == 4.46f ? 1 : 0;
        val_27 = null;
        val_27 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
                DemoManager val_11 = DemoManager.Instance;
            if(val_11.IsAdvancedTutorialMode != true)
        {
                this.entryIndicators.SetActive(value:  true);
        }
        
        }
        
        val_28 = null;
        val_28 = null;
        this.angleHandler = (InstanceAnimator.playerNegateX == 1) ? 0 : 180;
        val_29 = 0f;
        this.iconPlayerActive.GetComponent<UnityEngine.UI.Image>().fillAmount = val_29;
        DemoManager val_14 = DemoManager.Instance;
        if(val_14.IsAdvancedTutorialMode != false)
        {
                this.iconCPUActive.SetActive(value:  true);
            this.iconCPUInactive.SetActive(value:  true);
            val_29 = 0f;
            this.iconCPUActive.GetComponent<UnityEngine.UI.Image>().fillAmount = val_29;
        }
        
        UnityEngine.Vector3 val_17 = this.playerChar.transform.position;
        this.characterPos = val_17;
        mem[1152921526133823644] = val_17.y;
        mem[1152921526133823648] = val_17.z;
        this.originalPos = val_17;
        mem[1152921526133823632] = val_17.y;
        mem[1152921526133823636] = val_17.z;
        if(this.playerBall == 0)
        {
                val_30 = null;
            val_30 = null;
            float val_27 = (float)InstanceAnimator.playerNegateX;
            val_27 = -(InstanceAnimator.UniversalX * val_27);
            UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.identity;
            val_25 = val_19.x;
            val_26 = val_19.z;
            UnityEngine.Rigidbody2D val_20 = UnityEngine.Object.Instantiate<UnityEngine.Rigidbody2D>(original:  this.playerBalls[0], position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_25, y = val_19.y, z = val_26, w = val_19.w});
            this.playerBall = val_20;
            val_20.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        
        this.forceFlag = true;
        InteractiveTutorialManager.touchFlag = false;
        this.lineRenderer.GetComponent<UnityEngine.Animator>().Play(stateName:  "White");
        DemoManager val_23 = DemoManager.Instance;
        if(val_23.IsAdvancedTutorialMode == true)
        {
                return;
        }
        
        this.SetPlayers(stage:  0, subStage:  0);
    }
    internal void OnPoppedBubbles(bool ShotByCPU, int destroyedBubbles)
    {
        var val_2 = (ShotByCPU != true) ? this.Player_Right : this.Player_Left;
        if(destroyedBubbles < 3)
        {
                return;
        }
        
        float val_5 = ShotByCPU != true ? this.Player_Right : this.Player_Left + 24;
        ShotByCPU = (~ShotByCPU) & 1;
        val_5 = val_5 * (float)destroyedBubbles;
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.PopSequenceStun(isCPU:  ShotByCPU, targetPlayer:  (ShotByCPU != true) ? this.Player_Left : this.Player_Right, stunTime:  val_5));
    }
    private void Update()
    {
        var val_82;
        float val_83;
        PlayerData val_269;
        float val_270;
        var val_271;
        var val_272;
        var val_275;
        var val_276;
        float val_277;
        var val_278;
        float val_280;
        float val_281;
        float val_282;
        var val_283;
        var val_284;
        float val_286;
        float val_287;
        float val_289;
        float val_290;
        var val_291;
        float val_292;
        float val_293;
        float val_294;
        var val_295;
        var val_296;
        var val_300;
        var val_301;
        var val_302;
        var val_305;
        PlayerData val_306;
        var val_307;
        string val_308;
        var val_309;
        var val_310;
        var val_311;
        int val_312;
        int val_313;
        int val_314;
        int val_315;
        var val_321;
        var val_322;
        var val_323;
        var val_324;
        var val_326;
        string val_327;
        var val_328;
        int val_329;
        int val_330;
        var val_331;
        var val_332;
        var val_333;
        var val_334;
        var val_335;
        var val_336;
        var val_337;
        int val_338;
        var val_339;
        var val_340;
        var val_341;
        var val_342;
        int val_343;
        int val_344;
        var val_345;
        var val_346;
        var val_347;
        var val_353;
        int val_364;
        int val_365;
        val_269 = this;
        val_270 = 0;
        ActivateOnStart.SetOrthographicSize(mainCam:  UnityEngine.Camera.main);
        val_271 = null;
        val_271 = null;
        if((((InstanceAnimator.areBallsInstantiated == false) || (this.winSequenceFlag == false)) || (this.looseSequenceFlag == false)) || (this.playerBall != 0))
        {
            goto label_8;
        }
        
        val_272 = null;
        val_272 = null;
        float val_278 = (float)InstanceAnimator.playerNegateX;
        val_278 = -(InstanceAnimator.UniversalX * val_278);
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        UnityEngine.Rigidbody2D val_4 = UnityEngine.Object.Instantiate<UnityEngine.Rigidbody2D>(original:  this.playerBalls[0], position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        this.playerBall = val_4;
        val_4.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        System.Collections.IEnumerator val_8 = this.playerBall.gameObject.transform.GetEnumerator();
        label_40:
        var val_279 = 0;
        val_279 = val_279 + 1;
        if(val_8.MoveNext() == false)
        {
            goto label_27;
        }
        
        var val_280 = 0;
        val_280 = val_280 + 1;
        val_275 = val_8.Current;
        if(val_275 != null)
        {
                val_275 = 0;
        }
        
        val_275.gameObject.SetActive(value:  false);
        goto label_40;
        label_8:
        label_603:
        val_276 = null;
        val_276 = null;
        if(DemoManager.touchBoolForDemo != false)
        {
                if(this.pauseInput == false)
        {
            goto label_44;
        }
        
        }
        
        if(InteractiveTutorialManager.touchFlag == false)
        {
                return;
        }
        
        CharAnimationController val_18 = this.animController_Player;
        if(val_18.currentAnimationName != 8)
        {
                this.animController_Player.PlayAnimation(newAnimName:  8, forceOverride:  false);
        }
        
        this.SetLineColorsPlayer(color:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.SetLineColorsCPU(color:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.forceFlag = true;
        InteractiveTutorialManager.touchFlag = false;
        val_269 = this.Player_Left;
        this.Player_Left.isReloading = false;
        return;
        label_44:
        if((UnityEngine.Input.GetMouseButton(button:  0)) == true)
        {
            goto label_56;
        }
        
        CharAnimationController val_21 = this.animController_Player;
        if(val_21.currentAnimationName == 1)
        {
            goto label_52;
        }
        
        CharAnimationController val_22 = this.animController_Player;
        if(val_22.currentAnimationName != 2)
        {
            goto label_56;
        }
        
        label_52:
        CharAnimationController val_23 = this.animController_Player;
        if(val_23.currentAnimationName != 8)
        {
                this.animController_Player.PlayAnimation(newAnimName:  8, forceOverride:  false);
        }
        
        label_56:
        if(InteractiveTutorialManager.touchFlag != true)
        {
                this.SetLineColorsPlayer(color:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_270 = 0f;
            val_277 = 0f;
            this.SetLineColorsCPU(color:  new UnityEngine.Vector4() {x = val_270, y = 0f, z = 0f, w = val_277});
        }
        
        if((this.winSequenceFlag == false) || (this.looseSequenceFlag == false))
        {
            goto label_60;
        }
        
        if(this.playerBall == 0)
        {
            goto label_66;
        }
        
        val_278 = null;
        val_278 = null;
        if(InstanceAnimator.areBallsInstantiated == false)
        {
            goto label_66;
        }
        
        if((InteractiveTutorialManager.touchFlag != true) && (this.Player_Left.isWaiting != true))
        {
                CharAnimationController val_27 = this.animController_Player;
            if(val_27.currentAnimationName != 8)
        {
                CharAnimationController val_28 = this.animController_Player;
            if(val_28.currentAnimationName != 3)
        {
                CharAnimationController val_29 = this.animController_Player;
            if(val_29.currentAnimationName != 5)
        {
                CharAnimationController val_30 = this.animController_Player;
            if(val_30.currentAnimationName != 4)
        {
                this.animController_Player.PlayAnimation(newAnimName:  8, forceOverride:  false);
        }
        
        }
        
        }
        
        }
        
        }
        
        UnityEngine.Vector3 val_33 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_34 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
        val_280 = val_34.y;
        val_281 = val_34.z;
        UnityEngine.Vector2 val_35 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_34.x, y = val_280, z = val_281});
        val_282 = -3.5f;
        val_283 = 0;
        if(val_35.y <= val_282)
        {
            goto label_82;
        }
        
        val_282 = 3.5f;
        if(val_35.y >= 0)
        {
            goto label_288;
        }
        
        val_284 = null;
        val_284 = null;
        if(InstanceAnimator.playerNegateX != 1)
        {
            goto label_89;
        }
        
        val_284 = null;
        val_286 = InstanceAnimator.UniversalX;
        val_280 = (-3.86f) - val_286;
        if(val_35.x <= val_280)
        {
            goto label_89;
        }
        
        val_284 = null;
        val_287 = InstanceAnimator.UniversalX;
        val_280 = 0.64f;
        val_282 = val_280 - val_287;
        if(val_35.x < 0)
        {
            goto label_92;
        }
        
        label_89:
        val_284 = null;
        if(InstanceAnimator.playerNegateX != 1)
        {
            goto label_101;
        }
        
        val_284 = null;
        val_289 = InstanceAnimator.UniversalX;
        val_280 = val_289 + 3.86f;
        if(val_35.x >= 0)
        {
            goto label_101;
        }
        
        val_290 = InstanceAnimator.UniversalX;
        val_280 = -0.64f;
        val_282 = val_290 + val_280;
        if(val_35.x <= val_282)
        {
            goto label_101;
        }
        
        label_92:
        bool val_37 = UnityEngine.Input.GetMouseButton(button:  0);
        val_283 = 1;
        goto label_288;
        label_60:
        val_291 = 0;
        label_562:
        DemoManager val_38 = DemoManager.Instance;
        if(val_38.IsAdvancedTutorialMode == false)
        {
                return;
        }
        
        if((0 & 1) == 0)
        {
                if(this.animController_CPU.currentAnimationName != 1)
        {
                if(this.animController_CPU.currentAnimationName != 2)
        {
            goto label_111;
        }
        
        }
        
            this.animController_CPU.PlayAnimation(newAnimName:  8, forceOverride:  false);
        }
        
        label_111:
        UnityEngine.Vector3 val_41 = this.lineRenderer.transform.localEulerAngles;
        this.lineRendererCPU.transform.localEulerAngles = new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z};
        UnityEngine.Vector3 val_46 = this.playerBall.transform.Find(n:  "TrailRainbow").localEulerAngles;
        this.cpuBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z};
        UnityEngine.Transform val_48 = this.cpuBall.transform;
        UnityEngine.Vector3 val_49 = val_48.localEulerAngles;
        UnityEngine.Vector3 val_50 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_292 = val_50.x;
        val_293 = val_50.y;
        val_294 = val_50.z;
        val_48.localEulerAngles = new UnityEngine.Vector3() {x = val_292, y = val_293, z = val_294};
        if(this.trigger_CPUShoot != false)
        {
                this.aimingMiddle = false;
            this.Player_Right.isReloading = false;
            val_295 = null;
            val_295 = null;
            float val_281 = (float)-InstanceAnimator.playerNegateX;
            val_281 = this.angle2 * val_281;
            float val_53 = val_281 + (float)this.angleHandler;
            val_292 = 0f;
            val_293 = 0f;
            val_294 = 0f;
            this.cpuBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = val_292, y = val_293, z = val_294};
            this.trigger_CPUShoot = false;
            val_296 = null;
            val_296 = null;
            val_291 = 1;
            DemoManager.touchBoolForDemo = false;
        }
        
        if((TutorialDataManager.IsMatch(tag:  this.cpuBallsSwipe[0].tag, rings:  InteractiveTutorialManager.PlayerRings)) == true)
        {
            goto label_138;
        }
        
        this.aimingMiddle = true;
        UnityEngine.Vector3 val_58 = UnityEngine.Vector3.zero;
        this.lineRendererCPU.transform.localEulerAngles = new UnityEngine.Vector3() {x = val_58.x, y = val_58.y, z = val_58.z};
        val_300 = null;
        val_300 = null;
        if(InstanceAnimator.cpuNegateX == 1)
        {
            goto label_146;
        }
        
        val_292 = 0f;
        val_293 = 0f;
        val_294 = 0f;
        goto label_148;
        label_66:
        label_347:
        label_543:
        val_301 = null;
        val_301 = null;
        var val_61 = (0 != 0) ? 1 : 0;
        var val_62 = (0 != 0) ? 1 : 0;
        if((((InstanceAnimator.areBallsInstantiated == false) || (this.winSequenceFlag == false)) || (this.looseSequenceFlag == false)) || (this.playerBall != 0))
        {
            goto label_562;
        }
        
        val_302 = null;
        val_302 = null;
        float val_284 = (float)InstanceAnimator.playerNegateX;
        val_284 = -(InstanceAnimator.UniversalX * val_284);
        UnityEngine.Quaternion val_64 = UnityEngine.Quaternion.identity;
        UnityEngine.Rigidbody2D val_65 = UnityEngine.Object.Instantiate<UnityEngine.Rigidbody2D>(original:  this.playerBalls[0], position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_64.x, y = val_64.y, z = val_64.z, w = val_64.w});
        this.playerBall = val_65;
        val_65.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        System.Collections.IEnumerator val_69 = this.playerBall.gameObject.transform.GetEnumerator();
        label_188:
        var val_285 = 0;
        val_285 = val_285 + 1;
        if(val_69.MoveNext() == false)
        {
            goto label_175;
        }
        
        var val_286 = 0;
        val_286 = val_286 + 1;
        val_305 = val_69.Current;
        if(val_305 != null)
        {
                val_305 = 0;
        }
        
        val_305.gameObject.SetActive(value:  false);
        goto label_188;
        label_146:
        UnityEngine.Vector3 val_78 = UnityEngine.Vector3.zero;
        val_292 = val_78.x;
        val_293 = val_78.y;
        val_294 = val_78.z;
        label_148:
        this.cpuBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = val_292, y = val_293, z = val_294};
        label_138:
        if((0 & 1) == 0)
        {
            goto label_192;
        }
        
        val_306 = this.Player_Right;
        bool val_79 = this.Player_Right.isWaiting;
        if(this.aimingMiddle == false)
        {
            goto label_194;
        }
        
        UnityEngine.Animator val_80 = this.lineRendererCPU.GetComponent<UnityEngine.Animator>();
        if(val_79 == false)
        {
            goto label_197;
        }
        
        UnityEngine.AnimatorStateInfo val_81 = val_80.GetCurrentAnimatorStateInfo(layerIndex:  0);
        if((54225424 & 1) != 0)
        {
            goto label_223;
        }
        
        val_307 = this.lineRendererCPU.GetComponent<UnityEngine.Animator>();
        val_308 = "MiddleRed";
        goto label_201;
        label_192:
        val_306 = this.Player_Right;
        goto label_223;
        label_194:
        if(val_79 == false)
        {
            goto label_203;
        }
        
        val_309 = 1152921526109146016;
        UnityEngine.AnimatorStateInfo val_86 = this.lineRendererCPU.GetComponent<UnityEngine.Animator>().GetCurrentAnimatorStateInfo(layerIndex:  0);
        val_310 = val_82;
        val_311 = "Red";
        goto label_206;
        label_197:
        UnityEngine.AnimatorStateInfo val_87 = val_80.GetCurrentAnimatorStateInfo(layerIndex:  0);
        if((54225424 & 1) == 0)
        {
                this.lineRendererCPU.GetComponent<UnityEngine.Animator>().Play(stateName:  "MiddleWhite");
        }
        
        if((this.animController_CPU.currentAnimationName == 1) || (this.animController_CPU.currentAnimationName == 2))
        {
            goto label_223;
        }
        
        this.animController_CPU.PlayAnimation(newAnimName:  1, forceOverride:  false);
        goto label_223;
        label_203:
        if((this.animController_CPU.currentAnimationName != 1) && (this.animController_CPU.currentAnimationName != 2))
        {
                this.animController_CPU.PlayAnimation(newAnimName:  1, forceOverride:  false);
        }
        
        val_309 = 1152921526109146016;
        UnityEngine.AnimatorStateInfo val_90 = this.lineRendererCPU.GetComponent<UnityEngine.Animator>().GetCurrentAnimatorStateInfo(layerIndex:  0);
        val_310 = val_82;
        val_311 = "White";
        label_206:
        if((54225424 & 1) != 0)
        {
            goto label_223;
        }
        
        val_307 = this.lineRendererCPU.GetComponent<UnityEngine.Animator>();
        val_308 = "White";
        label_201:
        val_307.Play(stateName:  val_308);
        label_223:
        bool val_93 = mem[this.Player_Right].isWaiting ^ 1;
        val_93 = val_291 & val_93;
        if(val_93 != true)
        {
                return;
        }
        
        if(DemoManager.Instance != null)
        {
                val_312 = val_94.Counter_PlayerRightShot;
            val_313 = val_94.Counter_PlayerRightShot;
        }
        else
        {
                val_313 = 280;
            val_312 = 4;
        }
        
        mem[280] = 5;
        if((System.String.op_Equality(a:  this.cpuBallsSwipe[0].gameObject.tag, b:  "Rainbow_Bubble")) != false)
        {
                if(DemoManager.Instance != null)
        {
                val_314 = val_98.Counter_PlayerRightRainbow;
            val_315 = val_98.Counter_PlayerRightRainbow;
        }
        else
        {
                val_315 = 288;
            val_314 = 4;
        }
        
            mem[288] = 5;
        }
        
        UnityEngine.Coroutine val_101 = this.StartCoroutine(routine:  InteractiveTutorialManager.ReloadPlayer(PlayerData:  mem[this.Player_Right], activeIcon:  this.iconCPUActive.GetComponent<UnityEngine.UI.Image>()));
        this.animController_CPU.PlayAnimation(newAnimName:  0, forceOverride:  false);
        this.cpuBall.GetComponent<TargetBallDemo>().SetBall(otherBall:  this.cpuBallsSwipe[0]);
        if((DemoManager.Instance.SwapBubble(player:  mem[this.Player_Right], bubble:  this.cpuBallsSwipe, rings:  InteractiveTutorialManager.PlayerRings)) != false)
        {
                this.OnSwipeButtonDown(isCPU:  true, muteSFX:  false);
        }
        
        this.cpuBall.gameObject.transform.Find(n:  "TrailNormal").gameObject.SetActive(value:  true);
        UnityEngine.Vector3 val_115 = this.cpuBall.transform.right;
        UnityEngine.Vector3 val_116 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_115.x, y = val_115.y, z = val_115.z}, d:  -this.speed);
        UnityEngine.Vector2 val_117 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_116.x, y = val_116.y, z = val_116.z});
        this.cpuBall.AddRelativeForce(relativeForce:  new UnityEngine.Vector2() {x = val_117.x, y = val_117.y}, mode:  0);
        UnityEngine.Vector3 val_120 = this.cpuBall.transform.localEulerAngles;
        UnityEngine.Vector3 val_121 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_120.x, y = val_120.y, z = val_120.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        System.Collections.IEnumerator val_124 = this.cpuBall.transform.GetEnumerator();
        goto label_279;
        label_286:
        var val_289 = 0;
        val_289 = val_289 + 1;
        object val_126 = val_124.Current;
        UnityEngine.Vector3 val_128 = 0.localEulerAngles;
        UnityEngine.Vector3 val_129 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_128.x, y = val_128.y, z = val_128.z}, b:  new UnityEngine.Vector3() {x = val_121.x, y = val_121.y, z = val_121.z});
        0.localEulerAngles = new UnityEngine.Vector3() {x = val_129.x, y = val_129.y, z = val_129.z};
        label_279:
        var val_290 = 0;
        val_290 = val_290 + 1;
        if(val_124.MoveNext() == true)
        {
            goto label_286;
        }
        
        val_321 = 0;
        goto label_287;
        label_101:
        val_283 = 0;
        goto label_288;
        label_27:
        val_322 = 0;
        val_323 = 0;
        goto label_289;
        label_82:
        label_288:
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
        {
                if(val_283 != 0)
        {
                UnityEngine.Vector3 val_133 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector2 val_134 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_133.x, y = val_133.y, z = val_133.z});
            this.startPos = val_134;
            mem[1152921526135921284] = val_134.y;
            InteractiveTutorialManager.touchFlag = true;
            this.SetLineColorsPlayer(color:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_282 = 0f;
            val_280 = 0f;
            val_281 = 0f;
            val_277 = 0f;
            this.SetLineColorsCPU(color:  new UnityEngine.Vector4() {x = val_282, y = val_280, z = val_281, w = val_277});
        }
        else
        {
                InteractiveTutorialManager.touchFlag = false;
        }
        
        }
        
        if(((UnityEngine.Input.GetMouseButton(button:  0)) == false) || (InteractiveTutorialManager.touchFlag == false))
        {
            goto label_296;
        }
        
        UnityEngine.Vector3 val_136 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector2 val_137 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_136.x, y = val_136.y, z = val_136.z});
        this.endPos = val_137;
        mem[1152921526135921292] = val_137.y;
        UnityEngine.Vector2 val_138 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_137.x, y = val_137.y}, b:  new UnityEngine.Vector2() {x = this.startPos, y = val_277});
        this.diff = val_138;
        mem[1152921526135921300] = val_138.y;
        if(((val_138.y > 12f) || (val_138.y < (-12f))) || ((System.String.op_Inequality(a:  this.playerBallsSwipe[0].gameObject.tag, b:  "Stunner_Ball")) == false))
        {
            goto label_305;
        }
        
        val_324 = 1152921504858337280;
        this.aimingMiddle = true;
        UnityEngine.Animator val_143 = this.lineRenderer.GetComponent<UnityEngine.Animator>();
        if(this.Player_Left.isWaiting == false)
        {
            goto label_309;
        }
        
        UnityEngine.AnimatorStateInfo val_144 = val_143.GetCurrentAnimatorStateInfo(layerIndex:  0);
        if((54225424 & 1) != 0)
        {
            goto label_399;
        }
        
        val_326 = this.lineRenderer.GetComponent<UnityEngine.Animator>();
        val_327 = "MiddleRed";
        goto label_313;
        label_296:
        CharAnimationController val_146 = this.animController_Player;
        if(val_146.currentAnimationName == 1)
        {
            goto label_315;
        }
        
        CharAnimationController val_147 = this.animController_Player;
        if(val_147.currentAnimationName != 2)
        {
            goto label_317;
        }
        
        label_315:
        if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
            goto label_318;
        }
        
        label_317:
        if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
            goto label_543;
        }
        
        label_318:
        UnityEngine.Vector2 val_150 = UnityEngine.Vector2.zero;
        this.diff = val_150;
        mem[1152921526135921300] = val_150.y;
        this.endPos = val_150;
        mem[1152921526135921292] = val_150.y;
        this.startPos = val_150;
        mem[1152921526135921284] = val_150.y;
        this.SetLineColorsPlayer(color:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.SetLineColorsCPU(color:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_328 = null;
        val_328 = null;
        if((((System.String.op_Inequality(a:  DemoManager.currentSequence, b:  "HowToAim")) == false) || (((this.Player_Left.isWaiting == true) || (this.forceFlag == false)) || (InteractiveTutorialManager.touchFlag == false))) || ((DemoManager.Instance.CanShoot(ballTemp:  InteractiveTutorialManager.ballEntryTemp)) == false))
        {
            goto label_332;
        }
        
        InteractiveTutorialManager.ballEntry = InteractiveTutorialManager.ballEntryTemp;
        DemoManager val_155 = DemoManager.Instance;
        if(val_155.IsAdvancedTutorialMode == false)
        {
            goto label_336;
        }
        
        UnityEngine.Coroutine val_158 = this.StartCoroutine(routine:  InteractiveTutorialManager.ReloadPlayer(PlayerData:  this.Player_Left, activeIcon:  this.iconPlayerActive.GetComponent<UnityEngine.UI.Image>()));
        DemoManager val_159 = DemoManager.Instance;
        val_159.Trigger_BubbleShot = true;
        if(DemoManager.Instance == null)
        {
            goto label_341;
        }
        
        val_329 = val_160.Counter_PlayerLeftShot;
        val_330 = val_160.Counter_PlayerLeftShot;
        goto label_342;
        label_332:
        val_331 = null;
        val_331 = null;
        if((System.String.op_Equality(a:  DemoManager.currentSequence, b:  "HowToAim")) == false)
        {
            goto label_347;
        }
        
        InteractiveTutorialManager.touchFlag = false;
        this.animController_Player.PlayAnimation(newAnimName:  8, forceOverride:  false);
        goto label_347;
        label_305:
        this.aimingMiddle = false;
        if(this.Player_Left.isWaiting != false)
        {
                val_324 = 1152921504858337280;
            val_332 = 1152921526109146016;
            UnityEngine.AnimatorStateInfo val_165 = this.lineRenderer.GetComponent<UnityEngine.Animator>().GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_333 = val_82;
            val_334 = "Red";
        }
        else
        {
                CharAnimationController val_166 = this.animController_Player;
            if(val_166.currentAnimationName != 1)
        {
                CharAnimationController val_167 = this.animController_Player;
            if(val_167.currentAnimationName != 2)
        {
                this.animController_Player.PlayAnimation(newAnimName:  1, forceOverride:  false);
        }
        
        }
        
            val_324 = 1152921504858337280;
            val_332 = 1152921526109146016;
            UnityEngine.AnimatorStateInfo val_170 = this.lineRenderer.GetComponent<UnityEngine.Animator>().GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_333 = val_82;
            val_334 = "White";
        }
        
        if((54225424 & 1) != 0)
        {
            goto label_399;
        }
        
        val_326 = this.lineRenderer.GetComponent<UnityEngine.Animator>();
        val_327 = "White";
        label_313:
        val_326.Play(stateName:  val_327);
        label_399:
        this.playerBall.gameObject.transform.Find(n:  "TrailNormal").gameObject.SetActive(value:  false);
        UnityEngine.GameObject val_176 = this.playerBallsSwipe[0].gameObject;
        if((val_176.CompareTag(tag:  "Stunner_Ball")) != true)
        {
                if((val_83 > 12f) || (val_83 < (-12f)))
        {
            goto label_374;
        }
        
        }
        
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_335 = null;
        val_335 = null;
        float val_294 = 0f;
        float val_293 = (float)-InstanceAnimator.playerNegateX;
        val_293 = val_293 * val_294;
        val_294 = (float)this.angleHandler - val_293;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        InteractiveTutorialManager.ballEntryTemp = 0;
        goto label_543;
        label_374:
        if((val_83 >= 0) || (val_83 < (-36f)))
        {
            goto label_383;
        }
        
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_336 = null;
        val_336 = null;
        float val_295 = (float)-InstanceAnimator.playerNegateX;
        val_295 = this.angle1 * val_295;
        float val_182 = (float)this.angleHandler - val_295;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_337 = null;
        val_338 = 3;
        goto label_454;
        label_309:
        UnityEngine.AnimatorStateInfo val_183 = val_143.GetCurrentAnimatorStateInfo(layerIndex:  0);
        if((54225424 & 1) == 0)
        {
                this.lineRenderer.GetComponent<UnityEngine.Animator>().Play(stateName:  "MiddleWhite");
        }
        
        CharAnimationController val_185 = this.animController_Player;
        if(val_185.currentAnimationName == 1)
        {
            goto label_399;
        }
        
        CharAnimationController val_186 = this.animController_Player;
        if(val_186.currentAnimationName == 2)
        {
            goto label_399;
        }
        
        this.animController_Player.PlayAnimation(newAnimName:  1, forceOverride:  false);
        goto label_399;
        label_383:
        if((val_83 >= 0) || (val_83 < (-60f)))
        {
            goto label_401;
        }
        
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_339 = null;
        val_339 = null;
        float val_296 = (float)-InstanceAnimator.playerNegateX;
        val_296 = this.angle2 * val_296;
        float val_190 = (float)this.angleHandler - val_296;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_337 = null;
        val_338 = 2;
        goto label_454;
        label_175:
        val_340 = 0;
        goto label_409;
        label_401:
        if(val_83 >= 0)
        {
            goto label_410;
        }
        
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_341 = null;
        val_341 = null;
        float val_297 = (float)-InstanceAnimator.playerNegateX;
        val_297 = this.angle3 * val_297;
        float val_193 = (float)this.angleHandler - val_297;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_337 = null;
        val_338 = 1;
        goto label_454;
        label_410:
        if((val_83 <= 12f) || (val_83 > 36f))
        {
            goto label_419;
        }
        
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_342 = null;
        val_342 = null;
        float val_298 = (float)-InstanceAnimator.playerNegateX;
        val_298 = this.angle1 * val_298;
        float val_196 = val_298 + (float)this.angleHandler;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_337 = null;
        val_338 = 4;
        goto label_454;
        label_336:
        UnityEngine.Coroutine val_197 = this.StartCoroutine(methodName:  "IconMask");
        goto label_427;
        label_341:
        val_330 = 276;
        val_329 = 0;
        label_342:
        mem[276] = 1;
        if((System.String.op_Equality(a:  this.playerBallsSwipe[0].gameObject.tag, b:  "Rainbow_Bubble")) == false)
        {
            goto label_432;
        }
        
        if(DemoManager.Instance == null)
        {
            goto label_435;
        }
        
        val_343 = val_201.Counter_PlayerLeftRainbow;
        val_344 = val_201.Counter_PlayerLeftRainbow;
        goto label_445;
        label_432:
        if((TutorialDataManager.IsMatch(tag:  this.playerBallsSwipe[0].gameObject.tag, rings:  InteractiveTutorialManager.CPURings)) == false)
        {
            goto label_441;
        }
        
        if(DemoManager.Instance == null)
        {
            goto label_444;
        }
        
        val_343 = val_206.Counter_PlayerLeftMatch;
        val_344 = val_206.Counter_PlayerLeftMatch;
        goto label_445;
        label_419:
        if((val_83 <= 36f) || (val_83 > 60f))
        {
            goto label_447;
        }
        
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_345 = null;
        val_345 = null;
        float val_301 = (float)-InstanceAnimator.playerNegateX;
        val_301 = this.angle2 * val_301;
        float val_209 = val_301 + (float)this.angleHandler;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_337 = null;
        val_338 = 5;
        goto label_454;
        label_435:
        val_344 = 284;
        goto label_455;
        label_447:
        if(val_83 <= 60f)
        {
            goto label_543;
        }
        
        this.lineRenderer.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_346 = null;
        val_346 = null;
        float val_302 = (float)-InstanceAnimator.playerNegateX;
        val_302 = this.angle3 * val_302;
        float val_212 = val_302 + (float)this.angleHandler;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_337 = null;
        val_338 = 6;
        label_454:
        InteractiveTutorialManager.ballEntryTemp = val_338;
        goto label_543;
        label_444:
        val_344 = 292;
        label_455:
        val_343 = 4;
        label_445:
        mem[292] = val_343 + 1;
        label_441:
        label_427:
        this.animController_Player.PlayAnimation(newAnimName:  0, forceOverride:  false);
        this.playerBall.GetComponent<TargetBallDemo>().SetBall(otherBall:  this.playerBallsSwipe[0]);
        val_347 = null;
        val_347 = null;
        if((System.String.op_Equality(a:  DemoManager.currentSequence, b:  "NowPopThoseBubbles")) != false)
        {
                this.OnSwipeButtonDown(isCPU:  false, muteSFX:  true);
        }
        
        this.playerBall.gameObject.transform.Find(n:  "TrailNormal").gameObject.SetActive(value:  true);
        UnityEngine.Vector3 val_222 = this.transform.right;
        UnityEngine.Vector3 val_223 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_222.x, y = val_222.y, z = val_222.z}, d:  this.speed);
        UnityEngine.Vector2 val_224 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_223.x, y = val_223.y, z = val_223.z});
        this.playerBall.AddRelativeForce(relativeForce:  new UnityEngine.Vector2() {x = val_224.x, y = val_224.y}, mode:  0);
        UnityEngine.Vector3 val_226 = this.playerBall.transform.localEulerAngles;
        System.Collections.IEnumerator val_228 = this.playerBall.transform.GetEnumerator();
        goto label_499;
        label_506:
        var val_304 = 0;
        val_304 = val_304 + 1;
        UnityEngine.Vector3 val_230 = val_228.position;
        UnityEngine.Vector3 val_233 = 0.localEulerAngles;
        UnityEngine.Vector3 val_234 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_233.x, y = val_233.y, z = val_233.z}, b:  new UnityEngine.Vector3() {x = val_226.x, y = val_226.y, z = val_226.z});
        0.localEulerAngles = new UnityEngine.Vector3() {x = val_234.x, y = val_234.y, z = val_234.z};
        label_499:
        var val_305 = 0;
        val_305 = val_305 + 1;
        if(val_228.MoveNext() == true)
        {
            goto label_506;
        }
        
        val_353 = 0;
        if(val_176 != null)
        {
                var val_306 = 0;
            val_306 = val_306 + 1;
            val_176.Dispose();
        }
        
        var val_307 = 2;
        if(val_307 != 1)
        {
                var val_238 = (3167 == 3167) ? 1 : 0;
            val_238 = ((val_307 >= 0) ? 1 : 0) & val_238;
            val_307 = val_307 - val_238;
        }
        
        this.playerBall.transform.rotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        UnityEngine.Coroutine val_241 = this.StartCoroutine(methodName:  "PostAttackSequence", value:  null);
        InteractiveTutorialManager.popTagPlayer = this.playerBall.gameObject.tag;
        this.forceFlag = false;
        InteractiveTutorialManager.touchFlag = false;
        if(InteractiveTutorialManager.ballEntry != 0)
        {
                UnityEngine.Coroutine val_245 = this.StartCoroutine(routine:  this.ActivateCollider(isCPU:  false));
            System.Collections.IEnumerator val_246 = this.MakeBallNull(isCPU:  false);
        }
        
        UnityEngine.Coroutine val_248 = this.StartCoroutine(routine:  this.DestroyBall(isCPU:  false));
        DemoManager val_249 = DemoManager.Instance;
        if(val_249.IsAdvancedTutorialMode == false)
        {
            goto label_543;
        }
        
        DemoManager val_250 = DemoManager.Instance;
        val_250.shootHere.SetActive(value:  false);
        DemoManager val_251 = DemoManager.Instance;
        val_251.shootHereBottom.SetActive(value:  false);
        if((DemoManager.Instance.SwapBubble(player:  this.Player_Left, bubble:  this.playerBallsSwipe, rings:  InteractiveTutorialManager.CPURings)) == false)
        {
            goto label_543;
        }
        
        this.OnSwipeButtonDown(isCPU:  false, muteSFX:  false);
        goto label_543;
        label_409:
        if(this.Player_Left != null)
        {
                var val_308 = 0;
            val_308 = val_308 + 1;
            this.Player_Left.Dispose();
        }
        
        var val_309 = 0;
        if(val_309 != 1)
        {
                var val_256 = (225 == 3630) ? 1 : 0;
            val_256 = ((val_309 >= 0) ? 1 : 0) & val_256;
            val_309 = val_309 - val_256;
        }
        
        this.forceFlag = true;
        goto label_562;
        label_287:
        if(this.Player_Left != null)
        {
                var val_310 = 0;
            val_310 = val_310 + 1;
            this.Player_Left.Dispose();
        }
        
        this.cpuBall.transform.rotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        UnityEngine.Coroutine val_261 = this.StartCoroutine(methodName:  "PostAttackSequence", value:  true);
        if(this.aimingMiddle != false)
        {
                System.Collections.IEnumerator val_262 = this.DestroyBall(isCPU:  true);
        }
        else
        {
                if((TutorialDataManager.IsMatch(tag:  this.cpuBall.gameObject.tag, rings:  InteractiveTutorialManager.PlayerRings)) != false)
        {
                if(DemoManager.Instance != null)
        {
                val_364 = val_268.Counter_PlayerRightMatch;
            val_365 = val_268.Counter_PlayerRightMatch;
        }
        else
        {
                val_365 = 296;
            val_364 = 48980544;
        }
        
            mem[296] = 48980545;
        }
        
            UnityEngine.Coroutine val_270 = this.StartCoroutine(routine:  this.ActivateCollider(isCPU:  true));
        }
        
        UnityEngine.Coroutine val_272 = this.StartCoroutine(routine:  this.MakeBallNull(isCPU:  true));
        return;
        label_289:
        if(this.Player_Left != null)
        {
                var val_311 = 0;
            val_311 = val_311 + 1;
            this.Player_Left.Dispose();
        }
        
        if( != 1)
        {
                var val_274 = (225 == 225) ? 1 : 0;
            val_274 = (( >= 0) ? 1 : 0) & val_274;
            var val_276 =  - val_274;
        }
        
        this.forceFlag = true;
        goto label_603;
    }
    public void EnableBallChange(bool enable)
    {
        var val_4;
        bool val_1 = enable;
        this.ballChangeButton.SetActive(value:  val_1);
        this.reloadBallPlayer.SetActive(value:  val_1);
        DemoManager val_2 = DemoManager.Instance;
        if(this.reloadBallCPU == null)
        {
            goto label_6;
        }
        
        if(val_2.IsAdvancedTutorialMode == false)
        {
            goto label_7;
        }
        
        label_9:
        val_4 = enable;
        goto label_8;
        label_6:
        if(val_2.IsAdvancedTutorialMode == true)
        {
            goto label_9;
        }
        
        label_7:
        val_4 = 0;
        label_8:
        this.reloadBallCPU.SetActive(value:  false);
    }
    private System.Collections.IEnumerator ActivateCollider(bool isCPU)
    {
        InteractiveTutorialManager.<ActivateCollider>d__85 val_1 = new InteractiveTutorialManager.<ActivateCollider>d__85(<>1__state:  0);
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .isCPU = isCPU;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator MakeBallNull(bool isCPU)
    {
        InteractiveTutorialManager.<MakeBallNull>d__86 val_1 = new InteractiveTutorialManager.<MakeBallNull>d__86(<>1__state:  0);
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .isCPU = isCPU;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator PostAttackSequence(bool isCPU)
    {
        InteractiveTutorialManager.<PostAttackSequence>d__87 val_1 = new InteractiveTutorialManager.<PostAttackSequence>d__87(<>1__state:  0);
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .isCPU = isCPU;
        return (System.Collections.IEnumerator)val_1;
    }
    private void ShakeSequenceAnimationPlayer()
    {
        if(this.shake > 0f)
        {
                UnityEngine.Vector2 val_1 = UnityEngine.Random.insideUnitCircle;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  this.shakeAmount);
            float val_6 = val_2.x;
            float val_7 = val_2.y;
            val_6 = this.originalPos + val_6;
            val_7 = S13 + val_7;
            this.playerChar.transform.position = new UnityEngine.Vector3() {x = val_6, y = val_7, z = V8.16B};
            float val_4 = UnityEngine.Time.deltaTime;
            val_4 = val_4 * this.decreaseFactor;
            val_4 = this.shake - val_4;
            this.shake = val_4;
            return;
        }
        
        this.shake = 0f;
        this.playerChar.transform.position = new UnityEngine.Vector3() {x = this.originalPos, y = V9.16B, z = V10.16B};
    }
    private System.Collections.IEnumerator DestroyBall(bool isCPU)
    {
        InteractiveTutorialManager.<DestroyBall>d__89 val_1 = new InteractiveTutorialManager.<DestroyBall>d__89(<>1__state:  0);
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .isCPU = isCPU;
        return (System.Collections.IEnumerator)val_1;
    }
    private static System.Collections.IEnumerator ReloadPlayer(TutorialDataManager.PlayerData PlayerData, UnityEngine.UI.Image activeIcon)
    {
        InteractiveTutorialManager.<ReloadPlayer>d__90 val_1 = new InteractiveTutorialManager.<ReloadPlayer>d__90(<>1__state:  0);
        if(val_1 != null)
        {
                .PlayerData = PlayerData;
        }
        else
        {
                mem[40] = PlayerData;
        }
        
        .activeIcon = activeIcon;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator IconMask()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new InteractiveTutorialManager.<IconMask>d__91(<>1__state:  0);
    }
    private System.Collections.IEnumerator startDefenceSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new InteractiveTutorialManager.<startDefenceSequence>d__92(<>1__state:  0);
    }
    public void OnSwipeButtonDown(bool isCPU = False, bool muteSFX = False)
    {
        if((isCPU != true) && (muteSFX != true))
        {
                GameAudio.PlayBubbleSwitchSound();
        }
        
        if((this.flagSwipeBall != true) && (isCPU != true))
        {
                return;
        }
        
        var val_1 = (isCPU != true) ? this.cpuBallsSwipe : this.playerBallsSwipe;
        UnityEngine.Vector3 val_4 = isCPU != true ? this.cpuBallsSwipe : this.playerBallsSwipe + 32.gameObject.transform.position;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Vector3 val_8 = isCPU != true ? this.cpuBallsSwipe : this.playerBallsSwipe + 40.gameObject.transform.position;
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        UnityEngine.Vector3 val_12 = isCPU != true ? this.cpuBallsSwipe : this.playerBallsSwipe + 32.gameObject.transform.localScale;
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        UnityEngine.Vector3 val_16 = isCPU != true ? this.cpuBallsSwipe : this.playerBallsSwipe + 40.gameObject.transform.localScale;
        UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        UnityEngine.Coroutine val_20 = this.StartCoroutine(routine:  this.BallSwap(pos1:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, pos2:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, size1:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, size2:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y}, isCPU:  isCPU));
    }
    private System.Collections.IEnumerator BallSwap(UnityEngine.Vector2 pos1, UnityEngine.Vector2 pos2, UnityEngine.Vector2 size1, UnityEngine.Vector2 size2, bool isCPU)
    {
        InteractiveTutorialManager.<BallSwap>d__94 val_1 = new InteractiveTutorialManager.<BallSwap>d__94(<>1__state:  0);
        if(val_1 != null)
        {
                .<>4__this = this;
            .pos1 = pos1;
            mem[1152921526139111364] = pos1.y;
            .pos2 = pos2;
            mem[1152921526139111372] = pos2.y;
            .size1 = size1;
            mem[1152921526139111380] = size1.y;
            .size2 = size2;
            mem[1152921526139111388] = size2.y;
        }
        else
        {
                mem[40] = this;
            mem[48] = pos1.x;
            mem[1152921526139111364] = pos1.y;
            mem[56] = pos2.x;
            mem[1152921526139111372] = pos2.y;
            mem[64] = size1.x;
            mem[1152921526139111380] = size1.y;
            mem[72] = size2.x;
            mem[1152921526139111388] = size2.y;
        }
        
        .isCPU = isCPU;
        return (System.Collections.IEnumerator)val_1;
    }
    public void onTutorialFingerShoot()
    {
        var val_30;
        var val_36;
        val_30 = null;
        val_30 = null;
        float val_32 = (float)-InstanceAnimator.playerNegateX;
        val_32 = this.angle2 * val_32;
        float val_2 = (float)this.angleHandler - val_32;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        InteractiveTutorialManager.ballEntryTemp = 2;
        this.SetLineColorsPlayer(color:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.SetLineColorsCPU(color:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        InteractiveTutorialManager.ballEntry = InteractiveTutorialManager.ballEntryTemp;
        UnityEngine.Coroutine val_3 = this.StartCoroutine(methodName:  "IconMask");
        this.animController_Player.PlayAnimation(newAnimName:  0, forceOverride:  false);
        this.playerBall.GetComponent<TargetBallDemo>().SetBall(otherBall:  this.playerBallsSwipe[0]);
        UnityEngine.Vector3 val_7 = this.playerBall.transform.right;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  this.speed);
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        this.playerBall.AddRelativeForce(relativeForce:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, mode:  0);
        UnityEngine.Vector3 val_11 = this.playerBall.transform.localEulerAngles;
        System.Collections.IEnumerator val_13 = this.playerBall.transform.GetEnumerator();
        goto label_33;
        label_40:
        var val_34 = 0;
        val_34 = val_34 + 1;
        object val_15 = val_13.Current;
        UnityEngine.Vector3 val_17 = 0.localEulerAngles;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        0.localEulerAngles = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        label_33:
        var val_35 = 0;
        val_35 = val_35 + 1;
        if(val_13.MoveNext() == true)
        {
            goto label_40;
        }
        
        val_36 = 0;
        if(val_13 != null)
        {
                var val_36 = 0;
            val_36 = val_36 + 1;
            val_13.Dispose();
        }
        
        this.playerBall.transform.rotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        UnityEngine.Coroutine val_23 = this.StartCoroutine(methodName:  "PostAttackSequence", value:  null);
        InteractiveTutorialManager.popTagPlayer = this.playerBall.gameObject.tag;
        this.forceFlag = false;
        InteractiveTutorialManager.touchFlag = false;
        TargetBallDemo val_26 = this.playerBall.GetComponent<TargetBallDemo>();
        val_26.isForDemo = true;
        if(InteractiveTutorialManager.ballEntry != 0)
        {
                UnityEngine.Coroutine val_28 = this.StartCoroutine(routine:  this.ActivateCollider(isCPU:  false));
            System.Collections.IEnumerator val_29 = this.MakeBallNull(isCPU:  false);
        }
        
        UnityEngine.Coroutine val_31 = this.StartCoroutine(routine:  this.DestroyBall(isCPU:  false));
    }
    public void onTrashABubbleShoot()
    {
        var val_34;
        this.playerBall.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        InteractiveTutorialManager.ballEntryTemp = 0;
        this.SetLineColorsPlayer(color:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.SetLineColorsCPU(color:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        InteractiveTutorialManager.ballEntry = InteractiveTutorialManager.ballEntryTemp;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(methodName:  "IconMask");
        this.animController_Player.PlayAnimation(newAnimName:  0, forceOverride:  false);
        this.playerBall.GetComponent<TargetBallDemo>().SetBall(otherBall:  this.playerBallsSwipe[0]);
        UnityEngine.Vector3 val_6 = this.playerBall.transform.right;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  this.speed);
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        this.playerBall.AddRelativeForce(relativeForce:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, mode:  0);
        UnityEngine.Vector3 val_10 = this.playerBall.transform.localEulerAngles;
        System.Collections.IEnumerator val_12 = this.playerBall.transform.GetEnumerator();
        goto label_33;
        label_40:
        var val_32 = 0;
        val_32 = val_32 + 1;
        object val_14 = val_12.Current;
        UnityEngine.Vector3 val_16 = 0.localEulerAngles;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        0.localEulerAngles = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        label_33:
        var val_33 = 0;
        val_33 = val_33 + 1;
        if(val_12.MoveNext() == true)
        {
            goto label_40;
        }
        
        val_34 = 0;
        if(val_12 != null)
        {
                var val_34 = 0;
            val_34 = val_34 + 1;
            val_12.Dispose();
        }
        
        this.playerBall.transform.rotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        UnityEngine.Coroutine val_22 = this.StartCoroutine(methodName:  "PostAttackSequence", value:  null);
        InteractiveTutorialManager.popTagPlayer = this.playerBall.gameObject.tag;
        this.forceFlag = false;
        InteractiveTutorialManager.touchFlag = false;
        TargetBallDemo val_25 = this.playerBall.GetComponent<TargetBallDemo>();
        val_25.isForDemo = true;
        if(InteractiveTutorialManager.ballEntry != 0)
        {
                UnityEngine.Coroutine val_27 = this.StartCoroutine(routine:  this.ActivateCollider(isCPU:  false));
            System.Collections.IEnumerator val_28 = this.MakeBallNull(isCPU:  false);
        }
        
        UnityEngine.Coroutine val_30 = this.StartCoroutine(routine:  this.DestroyBall(isCPU:  false));
    }
    public void ChangesForRechargingsequence()
    {
        null = null;
        if((System.String.op_Equality(a:  DemoManager.currentSequence, b:  "SwitchingBubbles")) != false)
        {
                this.EnableBallChange(enable:  true);
        }
        
        CharAnimationController val_2 = this.animController_Player;
        val_2.pause = false;
        this.animController_Player.PlayAnimation(newAnimName:  8, forceOverride:  false);
        this.iconPlayerActive.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        this.SetLineColorsPlayer(color:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.SetLineColorsCPU(color:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.forceFlag = true;
        InteractiveTutorialManager.touchFlag = false;
        this.Player_Left.isReloading = false;
    }
    public void ResetEverything()
    {
        var val_12;
        InstanceAnimator val_1 = InstanceAnimator.Instance;
        val_1.isStarted = false;
        this.StopCoroutine(methodName:  "IconMask");
        this.StopCoroutine(methodName:  "PostAttackSequence");
        this.StopCoroutine(methodName:  "RechargingAnimSequence");
        val_12 = null;
        val_12 = null;
        if((System.String.op_Equality(a:  DemoManager.currentSequence, b:  "SwitchingBubbles")) != false)
        {
                this.EnableBallChange(enable:  true);
        }
        
        this.iconPlayerActive.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        this.SetLineColorsPlayer(color:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.SetLineColorsCPU(color:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
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
        
        this.forceFlag = true;
        InteractiveTutorialManager.touchFlag = false;
        if(this.Player_Left != null)
        {
                this.Player_Left.isReloading = false;
            this.Player_Left.isStunned = false;
        }
        
        if(this.Player_Right != null)
        {
                this.Player_Right.isReloading = false;
            this.Player_Right.isStunned = false;
        }
        
        CharAnimationController val_10 = this.animController_Player;
        val_10.pause = false;
        this.animController_Player.PlayAnimation(newAnimName:  8, forceOverride:  false);
    }
    public void ChangesForBubbleSwitching()
    {
        this.iconPlayerActive.GetComponent<UnityEngine.UI.Image>().fillAmount = 1f;
    }
    public void RechargingAnim()
    {
        this.InvokeRepeating(methodName:  "CheckForRechargingEnd", time:  5f, repeatRate:  0.02f);
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "RechargingAnimSequence");
    }
    private void CheckForRechargingEnd()
    {
        null = null;
        if((System.String.op_Inequality(a:  DemoManager.currentSequence, b:  "Recharging")) == false)
        {
                return;
        }
        
        this.StopCoroutine(methodName:  "RechargingAnimSequence");
        this.CancelInvoke(methodName:  "CheckForRechargingEnd");
    }
    private System.Collections.IEnumerator RechargingAnimSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new InteractiveTutorialManager.<RechargingAnimSequence>d__102(<>1__state:  0);
    }
    private System.Collections.IEnumerator PopSequenceStun(bool isCPU, TutorialDataManager.PlayerData targetPlayer, float stunTime)
    {
        InteractiveTutorialManager.<PopSequenceStun>d__103 val_1 = new InteractiveTutorialManager.<PopSequenceStun>d__103(<>1__state:  0);
        if(val_1 != null)
        {
                .<>4__this = this;
            .isCPU = isCPU;
            .targetPlayer = targetPlayer;
        }
        else
        {
                mem[56] = this;
            mem[48] = isCPU;
            mem[40] = targetPlayer;
        }
        
        .stunTime = stunTime;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator ShakeSequence(TutorialDataManager.PlayerData player, float shake)
    {
        InteractiveTutorialManager.<ShakeSequence>d__104 val_1 = new InteractiveTutorialManager.<ShakeSequence>d__104(<>1__state:  0);
        if(val_1 != null)
        {
                .player = player;
            .<>4__this = this;
        }
        else
        {
                mem[40] = this;
            mem[32] = player;
        }
        
        .shake = shake;
        return (System.Collections.IEnumerator)val_1;
    }
    private void SetLineColorsPlayer(UnityEngine.Vector4 color)
    {
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
        
        UnityEngine.Color val_12 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = color.x, y = color.y, z = color.z, w = color.w});
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
    private void SetLineColorsCPU(UnityEngine.Vector4 color)
    {
        var val_13;
        var val_16;
        var val_17;
        val_13 = this;
        DemoManager val_1 = DemoManager.Instance;
        if(val_1.IsAdvancedTutorialMode == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_3 = this.lineRendererCPU.transform.GetEnumerator();
        label_25:
        var val_15 = 0;
        val_15 = val_15 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_12;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_16 = val_3.Current;
        if(val_16 != null)
        {
                val_16 = 0;
        }
        
        UnityEngine.Color val_13 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = color.x, y = color.y, z = color.z, w = color.w});
        val_16.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a};
        goto label_25;
        label_12:
        val_17 = 0;
        val_13 = val_3;
        if(val_13 != null)
        {
                var val_17 = 0;
            val_17 = val_17 + 1;
            val_13.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public InteractiveTutorialManager()
    {
        this.sensitivity = 5f;
        this.playerBallTemp = new UnityEngine.GameObject[2];
        mem2[0] = 1036831949;
    }

}
