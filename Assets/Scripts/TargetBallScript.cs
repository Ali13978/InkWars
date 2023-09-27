using UnityEngine;
public class TargetBallScript : TargetBall_Parent
{
    // Fields
    private int flag;
    private int position;
    public float destroyLag;
    public UnityEngine.AudioClip[] popClip;
    private bool triggerFlag;
    private bool isInnerBridgeRunning;
    private bool isMiddleBridgeRunning;
    private bool isOuterBridgeRunning;
    private int entryTriggerDestroyer;
    public UnityEngine.GameObject popAnimation;
    public UnityEngine.GameObject popAnimationPlayer;
    public UnityEngine.GameObject individualScoreAnimation;
    private UnityEngine.GameObject popText;
    public static string popTag;
    private string playerBallTag;
    private string popBallTag;
    public static int scoreCounter;
    private int crossCounter;
    private int chainScore;
    private float bonusScore;
    private int playerNegateX;
    private int ballEntry;
    private int entryTrigger;
    private bool PVP;
    internal float OTime;
    private UnityEngine.GameObject createdBubble;
    
    // Methods
    private System.Collections.IEnumerator Start()
    {
        return (System.Collections.IEnumerator)new TargetBallScript.<Start>d__26(<>1__state:  0);
    }
    private void Awake()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        this.entryTrigger = 0;
        this.PVP = (Character_GlobalInfo.gameMode == 5) ? 1 : 0;
        val_3 = null;
        val_3 = null;
        this.flag = -4294967296;
        this.position = -1;
        this.triggerFlag = true;
        mem[1152921526364954250] = 0;
        this.crossCounter = 0;
        mem[1152921526364954287] = 0;
        mem[1152921526364954285] = 0;
        this.isInnerBridgeRunning = false;
        this.isMiddleBridgeRunning = false;
        this.isOuterBridgeRunning = false;
        this.entryTriggerDestroyer = 0;
        this.playerNegateX = InstanceAnimator.playerNegateX;
        TargetBallScript.scoreCounter = 100;
        mem[1152921526364954252] = 0;
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        DataStructs.GameSave val_445;
        float val_447;
        UnityEngine.Object val_448;
        int val_449;
        UnityEngine.Object val_450;
        var val_451;
        float val_452;
        float val_453;
        int val_454;
        float val_455;
        float val_456;
        float val_457;
        UnityEngine.Sprite val_458;
        var val_459;
        string val_460;
        var val_461;
        UnityEngine.GameObject val_466;
        float val_467;
        var val_468;
        float val_469;
        float val_470;
        var val_471;
        var val_472;
        var val_473;
        UnityEngine.GameObject val_474;
        int val_475;
        float val_476;
        float val_477;
        var val_478;
        var val_479;
        var val_480;
        float val_481;
        float val_483;
        float val_484;
        var val_485;
        var val_486;
        var val_487;
        var val_488;
        var val_489;
        int val_490;
        var val_491;
        UnityEngine.GameObject val_496;
        float val_497;
        var val_498;
        float val_499;
        float val_500;
        var val_501;
        var val_502;
        var val_503;
        UnityEngine.GameObject val_504;
        int val_505;
        float val_506;
        var val_507;
        var val_508;
        var val_509;
        var val_510;
        float val_512;
        float val_513;
        float val_514;
        var val_515;
        var val_516;
        var val_517;
        var val_518;
        var val_519;
        int val_520;
        var val_521;
        UnityEngine.GameObject val_525;
        var val_526;
        var val_527;
        var val_528;
        var val_529;
        UnityEngine.GameObject val_530;
        int val_531;
        float val_532;
        var val_533;
        var val_534;
        var val_535;
        var val_536;
        var val_537;
        var val_538;
        var val_539;
        var val_540;
        var val_541;
        var val_542;
        var val_543;
        int val_544;
        var val_545;
        var val_546;
        var val_547;
        var val_548;
        var val_549;
        var val_550;
        var val_551;
        var val_552;
        var val_553;
        var val_554;
        var val_555;
        UnityEngine.GameObject[] val_556;
        UnityEngine.GameObject[] val_557;
        UnityEngine.GameObject[] val_558;
        int val_559;
        var val_560;
        var val_561;
        var val_562;
        var val_563;
        var val_564;
        var val_565;
        var val_566;
        var val_567;
        int val_568;
        var val_569;
        var val_570;
        var val_571;
        var val_572;
        var val_573;
        var val_574;
        var val_575;
        var val_576;
        var val_577;
        var val_578;
        var val_579;
        var val_580;
        var val_581;
        var val_582;
        var val_583;
        var val_584;
        int val_585;
        var val_586;
        var val_587;
        var val_588;
        var val_589;
        var val_590;
        var val_591;
        var val_592;
        var val_593;
        var val_594;
        var val_595;
        var val_596;
        var val_597;
        var val_598;
        var val_599;
        var val_600;
        var val_601;
        var val_602;
        var val_603;
        var val_604;
        int val_605;
        int val_606;
        var val_607;
        var val_608;
        var val_609;
        var val_610;
        var val_611;
        var val_615;
        val_445 = this;
        float val_1 = UnityEngine.Time.time;
        val_447 = this.OTime;
        val_1 = val_1 - val_447;
        UnityEngine.MonoBehaviour.print(message:  "Trigger enter time:"("Trigger enter time:") + val_1);
        val_448 = other.gameObject;
        if((val_448.CompareTag(tag:  "EntryColliders")) != false)
        {
                int val_450 = this.entryTrigger;
            val_450 = val_450 + 1;
            this.entryTrigger = val_450;
            if(val_450 == 2)
        {
                if(Character_GlobalInfo.gameMode == 5)
        {
                LineControllerP2.instance.gapTransp2();
        }
        
        }
        
            if(this.entryTrigger != 1)
        {
                return;
        }
        
            val_448 = 1152921505075642368;
            this.ballEntry = LineController.ballEntry;
            this.playerBallTag = this.gameObject.tag;
            if(DataStructs.UserDataDictionary.GameSave.IsTutorialTwoPlayed != true)
        {
                LineController.instance.WhirlpoolPanelTrigger();
        }
        
            val_445 = DataStructs.UserDataDictionary.GameSave;
            if(val_445.IsTutorialSixPlayed == true)
        {
                return;
        }
        
            val_445 = LineController.instance;
            val_445.ReboundPanelTrigger();
            return;
        }
        
        val_448 = other.gameObject;
        if((val_448.CompareTag(tag:  "ExitColliders")) == false)
        {
            goto label_32;
        }
        
        int val_451 = this.entryTriggerDestroyer;
        val_451 = val_451 + 1;
        this.entryTriggerDestroyer = val_451;
        if(((this.gameObject.CompareTag(tag:  "Rainbow_Bubble")) != true) && ((this.gameObject.CompareTag(tag:  "Color_Eraser_Ball")) != true))
        {
                if((this.gameObject.CompareTag(tag:  "Iron_Ball")) != true)
        {
                if(Character_GlobalInfo.gameMode != 3)
        {
            goto label_41;
        }
        
        }
        
        }
        
        val_449 = this.entryTriggerDestroyer;
        if(val_449 != 1)
        {
            goto label_42;
        }
        
        System.Collections.IEnumerator val_19 = this.gameObject.transform.GetEnumerator();
        val_450 = 1152921504865153024;
        label_63:
        if((val_19 & 1) == 0)
        {
            goto label_50;
        }
        
        0.gameObject.SetActive(value:  false);
        goto label_63;
        label_32:
        val_448 = this.gameObject;
        if((val_448.CompareTag(tag:  "Color_Eraser_Ball")) == false)
        {
            goto label_65;
        }
        
        if(this.triggerFlag == false)
        {
                return;
        }
        
        TargetBallScript.scoreCounter = 200;
        this.triggerFlag = false;
        TargetBallScript.popTag = this.gameObject.tag;
        string val_31 = other.gameObject.tag;
        val_451 = 1152921505075376128;
        var val_501 = 0;
        val_452 = 1f;
        val_453 = 1.83f;
        label_801:
        if((System.String.op_Equality(a:  val_31, b:  "SPD")) != true)
        {
                if((System.String.op_Equality(a:  val_31, b:  "SPD1")) != true)
        {
                if((System.String.op_Equality(a:  val_31, b:  "SPD2")) == false)
        {
            goto label_72;
        }
        
        }
        
        }
        
        if((InstanceAnimator.outerRingBalls.Length + 32) == 0)
        {
            goto label_238;
        }
        
        val_450 = other.gameObject;
        if((InstanceAnimator.outerRingBalls.Length + 32.gameObject) != val_450)
        {
            goto label_88;
        }
        
        if(val_501 == 0)
        {
            goto label_89;
        }
        
        if(val_501 != 16)
        {
            goto label_90;
        }
        
        if(this.ballEntry == 6)
        {
            goto label_91;
        }
        
        goto label_119;
        label_72:
        if(((InstanceAnimator.outerRingBalls.Length + 32) == 0) || ((System.String.op_Equality(a:  InstanceAnimator.outerRingBalls.Length + 32.tag, b:  val_31)) == false))
        {
            goto label_105;
        }
        
        if((InstanceAnimator.outerRingBalls.Length + 32.gameObject) != other.gameObject)
        {
            goto label_114;
        }
        
        if(val_501 == 0)
        {
            goto label_115;
        }
        
        if(val_501 != 16)
        {
            goto label_116;
        }
        
        val_454 = this.ballEntry;
        if(val_454 == 6)
        {
            goto label_117;
        }
        
        goto label_549;
        label_89:
        if(this.ballEntry != 1)
        {
            goto label_119;
        }
        
        label_91:
        LineController.popTagPlayer = this.playerBallTag;
        val_450 = this.gameObject.transform;
        UnityEngine.Vector3 val_47 = val_450.position;
        val_455 = val_47.y;
        UnityEngine.Quaternion val_48 = UnityEngine.Quaternion.identity;
        val_456 = val_48.x;
        val_457 = val_48.z;
        goto label_128;
        label_90:
        label_119:
        if(this.ballEntry == 1)
        {
                LineController.popTagPlayer = this.playerBallTag;
            val_450 = this.playerNegateX;
        }
        else
        {
                LineController.popTagPlayer = this.playerBallTag;
            val_450 = this.playerNegateX;
        }
        
        float val_49 = 458f * 0.01745329f;
        float val_452 = 3.84f;
        val_452 = val_49 * val_452;
        float val_51 = InstanceAnimator.UniversalX + (val_49 * val_452);
        val_51 = val_51 * (float)val_450;
        float val_453 = 0f;
        val_453 = val_452 + val_453;
        UnityEngine.Quaternion val_52 = UnityEngine.Quaternion.identity;
        val_455 = val_52.y;
        val_456 = val_52.w;
        label_128:
        UnityEngine.GameObject val_53 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_52.x, y = val_455, z = val_52.z, w = val_456});
        label_88:
        if((InstanceAnimator.outerRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD")) == false)
        {
            goto label_153;
        }
        
        UnityEngine.AudioSource val_57 = GameAudio.sound.PlayOneShot(clip:  this.popClip[1], volume:  val_452);
        UnityEngine.SpriteRenderer val_59 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.GetComponentInChildren<UnityEngine.SpriteRenderer>();
        System.Type val_455 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        val_450 = UnityEngine.Resources.Load(path:  "SPD1crack", systemTypeInstance:  val_455);
        if(val_59 == null)
        {
            goto label_167;
        }
        
        if(val_450 == null)
        {
            goto label_168;
        }
        
        label_239:
        val_455 = (null == null) ? (val_450) : 0;
        goto label_169;
        label_153:
        if((InstanceAnimator.outerRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD1")) == false)
        {
            goto label_176;
        }
        
        UnityEngine.AudioSource val_65 = GameAudio.sound.PlayOneShot(clip:  this.popClip[1], volume:  val_452);
        UnityEngine.SpriteRenderer val_67 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.GetComponentInChildren<UnityEngine.SpriteRenderer>();
        System.Type val_457 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        val_450 = UnityEngine.Resources.Load(path:  "SPD2crack", systemTypeInstance:  val_457);
        if(val_67 == null)
        {
            goto label_190;
        }
        
        if(val_450 == null)
        {
            goto label_191;
        }
        
        label_245:
        val_457 = (null == null) ? (val_450) : 0;
        goto label_192;
        label_176:
        if((InstanceAnimator.outerRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD2")) == false)
        {
            goto label_238;
        }
        
        UnityEngine.AudioSource val_73 = GameAudio.sound.PlayOneShot(clip:  this.popClip[2], volume:  val_452);
        UnityEngine.Vector3 val_76 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_77 = UnityEngine.Quaternion.identity;
        val_456 = val_77.x;
        val_457 = val_77.z;
        UnityEngine.GameObject val_78 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_76.x, y = val_76.y, z = val_76.z}, rotation:  new UnityEngine.Quaternion() {x = val_456, y = val_77.y, z = val_457, w = val_77.w});
        this.popText = val_78;
        val_78.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
        UnityEngine.Vector3 val_85 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.transform.position;
        this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_85.x, y = val_85.y, z = val_85.z};
        popScoreScript val_86 = this.popText.GetComponent<popScoreScript>();
        val_86.scoreCounter = TargetBallScript.scoreCounter;
        val_450 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.transform;
        UnityEngine.Vector3 val_89 = val_450.position;
        val_455 = val_89.y;
        UnityEngine.Quaternion val_90 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_91 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimation, position:  new UnityEngine.Vector3() {x = val_89.x, y = val_455, z = val_89.z}, rotation:  new UnityEngine.Quaternion() {x = val_90.x, y = val_90.y, z = val_90.z, w = val_90.w});
        int val_459 = InstanceAnimator.outerRingBalls.Length;
        UnityEngine.Object.Destroy(obj:  InstanceAnimator.outerRingBalls.Length + 32.gameObject);
        val_459 = val_459 + 1;
        mem[1152921526366992748] = val_459;
        int val_460 = TargetBallScript.scoreCounter;
        val_460 = val_460 + this.chainScore;
        this.chainScore = val_460;
        int val_461 = TargetBallScript.scoreCounter;
        val_461 = val_461 + LineController.userScore;
        LineController.userScore = val_461;
        goto label_238;
        label_167:
        if(val_450 != null)
        {
            goto label_239;
        }
        
        label_168:
        label_169:
        val_59.sprite = 0;
        if((InstanceAnimator.outerRingBalls.Length + 32.gameObject) != null)
        {
            goto label_244;
        }
        
        goto label_244;
        label_190:
        if(val_450 != null)
        {
            goto label_245;
        }
        
        label_191:
        label_192:
        val_67.sprite = 0;
        label_244:
        InstanceAnimator.outerRingBalls.Length + 32.gameObject.tag = "SPD2";
        label_238:
        if(val_501 > 12)
        {
            goto label_721;
        }
        
        if((InstanceAnimator.middleRingBalls.Length + 32) == 0)
        {
            goto label_390;
        }
        
        val_450 = other.gameObject;
        if((InstanceAnimator.middleRingBalls.Length + 32.gameObject) != val_450)
        {
            goto label_266;
        }
        
        if(val_501 == 0)
        {
            goto label_267;
        }
        
        if(val_501 != 12)
        {
            goto label_268;
        }
        
        if(this.ballEntry == 5)
        {
            goto label_269;
        }
        
        goto label_271;
        label_267:
        if(this.ballEntry != 2)
        {
            goto label_271;
        }
        
        label_269:
        LineController.popTagPlayer = this.playerBallTag;
        val_450 = this.gameObject.transform;
        UnityEngine.Vector3 val_101 = val_450.position;
        val_455 = val_101.y;
        UnityEngine.Quaternion val_102 = UnityEngine.Quaternion.identity;
        val_456 = val_102.x;
        val_457 = val_102.z;
        goto label_280;
        label_268:
        label_271:
        if(this.ballEntry == 2)
        {
                LineController.popTagPlayer = this.playerBallTag;
            val_450 = this.playerNegateX;
        }
        else
        {
                LineController.popTagPlayer = this.playerBallTag;
            val_450 = this.playerNegateX;
        }
        
        float val_462 = 1f;
        val_462 = val_462 * (-19f);
        val_462 = val_462 + 474f;
        float val_103 = val_462 * 0.01745329f;
        float val_463 = 2.84f;
        val_463 = val_103 * val_463;
        float val_105 = InstanceAnimator.UniversalX + (val_103 * val_463);
        val_105 = val_105 * (float)val_450;
        float val_464 = 0f;
        val_464 = val_463 + val_464;
        UnityEngine.Quaternion val_106 = UnityEngine.Quaternion.identity;
        val_455 = val_106.y;
        val_456 = val_106.w;
        label_280:
        UnityEngine.GameObject val_107 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_106.x, y = val_455, z = val_106.z, w = val_456});
        label_266:
        if((InstanceAnimator.middleRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD")) == false)
        {
            goto label_305;
        }
        
        UnityEngine.AudioSource val_111 = GameAudio.sound.PlayOneShot(clip:  this.popClip[1], volume:  val_452);
        UnityEngine.SpriteRenderer val_113 = InstanceAnimator.middleRingBalls.Length + 32.gameObject.GetComponentInChildren<UnityEngine.SpriteRenderer>();
        System.Type val_466 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        val_450 = UnityEngine.Resources.Load(path:  "SPD1crack", systemTypeInstance:  val_466);
        if(val_113 == null)
        {
            goto label_319;
        }
        
        if(val_450 == null)
        {
            goto label_320;
        }
        
        label_391:
        val_466 = (null == null) ? (val_450) : 0;
        goto label_321;
        label_305:
        if((InstanceAnimator.middleRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD1")) == false)
        {
            goto label_328;
        }
        
        UnityEngine.AudioSource val_119 = GameAudio.sound.PlayOneShot(clip:  this.popClip[1], volume:  val_452);
        UnityEngine.SpriteRenderer val_121 = InstanceAnimator.middleRingBalls.Length + 32.gameObject.GetComponentInChildren<UnityEngine.SpriteRenderer>();
        System.Type val_468 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        val_450 = UnityEngine.Resources.Load(path:  "SPD2crack", systemTypeInstance:  val_468);
        if(val_121 == null)
        {
            goto label_342;
        }
        
        if(val_450 == null)
        {
            goto label_343;
        }
        
        label_397:
        val_468 = (null == null) ? (val_450) : 0;
        goto label_344;
        label_328:
        if((InstanceAnimator.middleRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD2")) == false)
        {
            goto label_390;
        }
        
        UnityEngine.AudioSource val_127 = GameAudio.sound.PlayOneShot(clip:  this.popClip[2], volume:  val_452);
        UnityEngine.Vector3 val_130 = InstanceAnimator.middleRingBalls.Length + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_131 = UnityEngine.Quaternion.identity;
        val_456 = val_131.x;
        val_457 = val_131.z;
        UnityEngine.GameObject val_132 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_130.x, y = val_130.y, z = val_130.z}, rotation:  new UnityEngine.Quaternion() {x = val_456, y = val_131.y, z = val_457, w = val_131.w});
        this.popText = val_132;
        val_132.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
        UnityEngine.Vector3 val_139 = InstanceAnimator.middleRingBalls.Length + 32.gameObject.transform.position;
        this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_139.x, y = val_139.y, z = val_139.z};
        popScoreScript val_140 = this.popText.GetComponent<popScoreScript>();
        val_140.scoreCounter = TargetBallScript.scoreCounter;
        val_450 = InstanceAnimator.middleRingBalls.Length + 32.gameObject.transform;
        UnityEngine.Vector3 val_143 = val_450.position;
        val_455 = val_143.y;
        UnityEngine.Quaternion val_144 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_145 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimation, position:  new UnityEngine.Vector3() {x = val_143.x, y = val_455, z = val_143.z}, rotation:  new UnityEngine.Quaternion() {x = val_144.x, y = val_144.y, z = val_144.z, w = val_144.w});
        int val_470 = InstanceAnimator.middleRingBalls.Length;
        UnityEngine.Object.Destroy(obj:  InstanceAnimator.middleRingBalls.Length + 32.gameObject);
        val_470 = val_470 + 1;
        mem[1152921526366992748] = val_470;
        int val_471 = TargetBallScript.scoreCounter;
        val_471 = val_471 + this.chainScore;
        this.chainScore = val_471;
        int val_472 = TargetBallScript.scoreCounter;
        val_472 = val_472 + LineController.userScore;
        LineController.userScore = val_472;
        goto label_390;
        label_319:
        if(val_450 != null)
        {
            goto label_391;
        }
        
        label_320:
        label_321:
        val_113.sprite = 0;
        if((InstanceAnimator.middleRingBalls.Length + 32.gameObject) != null)
        {
            goto label_396;
        }
        
        goto label_396;
        label_342:
        if(val_450 != null)
        {
            goto label_397;
        }
        
        label_343:
        label_344:
        val_121.sprite = 0;
        label_396:
        InstanceAnimator.middleRingBalls.Length + 32.gameObject.tag = "SPD2";
        label_390:
        if((val_501 > 8) || ((InstanceAnimator.innerRingBalls.Length + 32) == 0))
        {
            goto label_721;
        }
        
        val_450 = other.gameObject;
        if((InstanceAnimator.innerRingBalls.Length + 32.gameObject) != val_450)
        {
            goto label_418;
        }
        
        if(val_501 == 0)
        {
            goto label_419;
        }
        
        if(val_501 != 8)
        {
            goto label_420;
        }
        
        if(this.ballEntry == 4)
        {
            goto label_421;
        }
        
        goto label_423;
        label_419:
        if(this.ballEntry != 3)
        {
            goto label_423;
        }
        
        label_421:
        LineController.popTagPlayer = this.playerBallTag;
        val_450 = this.gameObject.transform;
        UnityEngine.Vector3 val_155 = val_450.position;
        val_455 = val_155.y;
        UnityEngine.Quaternion val_156 = UnityEngine.Quaternion.identity;
        val_456 = val_156.x;
        val_457 = val_156.z;
        goto label_432;
        label_420:
        label_423:
        if(this.ballEntry == 3)
        {
                LineController.popTagPlayer = this.playerBallTag;
            val_450 = this.playerNegateX;
        }
        else
        {
                LineController.popTagPlayer = this.playerBallTag;
            val_450 = this.playerNegateX;
        }
        
        float val_473 = 1f;
        val_473 = val_473 * (-29f);
        val_473 = val_473 + 476f;
        float val_157 = val_473 * 0.01745329f;
        float val_474 = val_453;
        val_474 = val_157 * val_474;
        float val_159 = InstanceAnimator.UniversalX + (val_157 * val_474);
        val_159 = val_159 * (float)val_450;
        float val_475 = 0f;
        val_475 = val_474 + val_475;
        UnityEngine.Quaternion val_160 = UnityEngine.Quaternion.identity;
        val_455 = val_160.y;
        val_456 = val_160.w;
        label_432:
        UnityEngine.GameObject val_161 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_160.x, y = val_455, z = val_160.z, w = val_456});
        label_418:
        if((InstanceAnimator.innerRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD")) == false)
        {
            goto label_457;
        }
        
        UnityEngine.AudioSource val_165 = GameAudio.sound.PlayOneShot(clip:  this.popClip[1], volume:  val_452);
        UnityEngine.SpriteRenderer val_167 = InstanceAnimator.innerRingBalls.Length + 32.gameObject.GetComponentInChildren<UnityEngine.SpriteRenderer>();
        System.Type val_477 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        val_450 = UnityEngine.Resources.Load(path:  "SPD1crack", systemTypeInstance:  val_477);
        if(val_167 == null)
        {
            goto label_471;
        }
        
        if(val_450 == null)
        {
            goto label_472;
        }
        
        label_538:
        val_477 = (null == null) ? (val_450) : 0;
        goto label_473;
        label_457:
        if((InstanceAnimator.innerRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD1")) == false)
        {
            goto label_480;
        }
        
        UnityEngine.AudioSource val_173 = GameAudio.sound.PlayOneShot(clip:  this.popClip[1], volume:  val_452);
        System.Type val_479 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        val_450 = UnityEngine.Resources.Load(path:  "SPD2crack", systemTypeInstance:  val_479);
        if(val_450 == null)
        {
            goto label_495;
        }
        
        val_479 = (null == null) ? (val_450) : 0;
        goto label_496;
        label_480:
        if((InstanceAnimator.innerRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD2")) == false)
        {
            goto label_721;
        }
        
        UnityEngine.AudioSource val_181 = GameAudio.sound.PlayOneShot(clip:  this.popClip[2], volume:  val_452);
        UnityEngine.Vector3 val_184 = InstanceAnimator.innerRingBalls.Length + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_185 = UnityEngine.Quaternion.identity;
        val_456 = val_185.x;
        val_457 = val_185.z;
        UnityEngine.GameObject val_186 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimation, position:  new UnityEngine.Vector3() {x = val_184.x, y = val_184.y, z = val_184.z}, rotation:  new UnityEngine.Quaternion() {x = val_456, y = val_185.y, z = val_457, w = val_185.w});
        UnityEngine.Vector3 val_189 = InstanceAnimator.innerRingBalls.Length + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_190 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_191 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_189.x, y = val_189.y, z = val_189.z}, rotation:  new UnityEngine.Quaternion() {x = val_190.x, y = val_190.y, z = val_190.z, w = val_190.w});
        this.popText = val_191;
        val_191.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
        UnityEngine.Vector3 val_198 = InstanceAnimator.innerRingBalls.Length + 32.gameObject.transform.position;
        val_455 = val_198.y;
        this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_198.x, y = val_455, z = val_198.z};
        popScoreScript val_199 = this.popText.GetComponent<popScoreScript>();
        val_450 = TargetBallScript.scoreCounter;
        val_199.scoreCounter = val_450;
        goto label_537;
        label_471:
        if(val_450 != null)
        {
            goto label_538;
        }
        
        label_472:
        label_473:
        val_167.sprite = 0;
        val_459 = InstanceAnimator.innerRingBalls.Length + 32.gameObject;
        val_460 = "SPD1";
        goto label_543;
        label_495:
        val_458 = 0;
        label_496:
        InstanceAnimator.innerRingBalls.Length + 32.gameObject.GetComponentInChildren<UnityEngine.SpriteRenderer>().sprite = val_458;
        val_459 = InstanceAnimator.innerRingBalls.Length + 32.gameObject;
        val_460 = "SPD2";
        label_543:
        val_459.tag = val_460;
        goto label_721;
        label_115:
        val_454 = this.ballEntry;
        if(val_454 != 1)
        {
            goto label_549;
        }
        
        label_117:
        val_461 = null;
        val_461 = null;
        LineController.popTagPlayer = this.playerBallTag;
        UnityEngine.Vector3 val_204 = this.gameObject.transform.position;
        UnityEngine.Quaternion val_205 = UnityEngine.Quaternion.identity;
        val_466 = this.popAnimationPlayer;
        val_467 = val_204.y;
        val_468 = public static UnityEngine.GameObject UnityEngine.Object::Instantiate<UnityEngine.GameObject>(UnityEngine.GameObject original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        val_469 = val_204.z;
        val_470 = val_205.x;
        goto label_558;
        label_116:
        val_454 = this.ballEntry;
        label_549:
        val_471 = null;
        if(val_454 == 1)
        {
                val_472 = null;
            LineController.popTagPlayer = this.playerBallTag;
            val_473 = null;
            val_474 = this.popAnimationPlayer;
            val_475 = this.playerNegateX;
            val_473 = null;
            val_476 = InstanceAnimator.UniversalX;
            val_477 = (float)458 + 28;
        }
        else
        {
                val_478 = null;
            LineController.popTagPlayer = this.playerBallTag;
            val_479 = null;
            val_474 = this.popAnimationPlayer;
            val_475 = this.playerNegateX;
            val_479 = null;
            val_476 = InstanceAnimator.UniversalX;
            val_477 = 458f;
        }
        
        float val_207 = val_477 * 0.01745329f;
        float val_481 = 3.84f;
        val_481 = val_207 * val_481;
        float val_209 = val_476 + (val_207 * val_481);
        val_209 = val_209 * (float)val_475;
        float val_482 = 0f;
        val_482 = val_481 + val_482;
        UnityEngine.Quaternion val_210 = UnityEngine.Quaternion.identity;
        val_467 = 0f;
        val_469 = 0f;
        val_466 = val_474;
        val_470 = val_210.x;
        val_468 = public static UnityEngine.GameObject UnityEngine.Object::Instantiate<UnityEngine.GameObject>(UnityEngine.GameObject original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        label_558:
        UnityEngine.GameObject val_211 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_466, position:  new UnityEngine.Vector3() {x = 0f, y = val_467, z = val_469}, rotation:  new UnityEngine.Quaternion() {x = val_470, y = val_210.y, z = val_210.z, w = val_210.w});
        label_114:
        UnityEngine.AudioSource val_213 = GameAudio.sound.PlayOneShot(clip:  this.popClip[0], volume:  val_452);
        val_480 = null;
        val_480 = null;
        UnityEngine.Vector3 val_216 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_217 = UnityEngine.Quaternion.identity;
        val_456 = val_217.x;
        val_457 = val_217.z;
        UnityEngine.GameObject val_218 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimation, position:  new UnityEngine.Vector3() {x = val_216.x, y = val_216.y, z = val_216.z}, rotation:  new UnityEngine.Quaternion() {x = val_456, y = val_217.y, z = val_457, w = val_217.w});
        int val_484 = InstanceAnimator.outerRingBalls.Length;
        UnityEngine.Object.Destroy(obj:  InstanceAnimator.outerRingBalls.Length + 32.gameObject);
        val_484 = val_484 + 1;
        mem[1152921526366992748] = val_484;
        UnityEngine.Vector3 val_222 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_223 = UnityEngine.Quaternion.identity;
        val_481 = val_223.x;
        UnityEngine.GameObject val_224 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_222.x, y = val_222.y, z = val_222.z}, rotation:  new UnityEngine.Quaternion() {x = val_481, y = val_223.y, z = val_223.z, w = val_223.w});
        this.popText = val_224;
        val_224.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
        UnityEngine.Vector3 val_231 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.transform.position;
        val_455 = val_231.y;
        val_453 = val_231.x;
        val_483 = val_455;
        val_484 = val_231.z;
        this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_453, y = val_483, z = val_484};
        val_485 = null;
        val_450 = TargetBallScript.scoreCounter;
        if((this.popText.GetComponent<popScoreScript>()) == null)
        {
                val_485 = null;
        }
        
        val_232.scoreCounter = val_450;
        int val_485 = TargetBallScript.scoreCounter;
        val_485 = val_485 + this.chainScore;
        this.chainScore = val_485;
        val_486 = null;
        val_486 = null;
        val_485 = null;
        int val_486 = TargetBallScript.scoreCounter;
        val_486 = val_486 + LineController.userScore;
        LineController.userScore = val_486;
        label_105:
        if(val_501 > 12)
        {
            goto label_721;
        }
        
        val_487 = null;
        val_487 = null;
        if((InstanceAnimator.middleRingBalls.Length + 32) == 0)
        {
            goto label_628;
        }
        
        val_488 = null;
        val_488 = null;
        if((System.String.op_Equality(a:  InstanceAnimator.middleRingBalls.Length + 32.tag, b:  val_31)) == false)
        {
            goto label_628;
        }
        
        val_489 = null;
        val_489 = null;
        if((InstanceAnimator.middleRingBalls.Length + 32.gameObject) != other.gameObject)
        {
            goto label_637;
        }
        
        if(val_501 == 0)
        {
            goto label_638;
        }
        
        if(val_501 != 12)
        {
            goto label_639;
        }
        
        val_490 = this.ballEntry;
        if(val_490 == 5)
        {
            goto label_640;
        }
        
        goto label_642;
        label_638:
        val_490 = this.ballEntry;
        if(val_490 != 2)
        {
            goto label_642;
        }
        
        label_640:
        val_491 = null;
        val_491 = null;
        LineController.popTagPlayer = this.playerBallTag;
        UnityEngine.Vector3 val_241 = this.gameObject.transform.position;
        UnityEngine.Quaternion val_242 = UnityEngine.Quaternion.identity;
        val_496 = this.popAnimationPlayer;
        val_497 = val_241.y;
        val_498 = public static UnityEngine.GameObject UnityEngine.Object::Instantiate<UnityEngine.GameObject>(UnityEngine.GameObject original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        val_499 = val_241.z;
        val_500 = val_242.x;
        goto label_651;
        label_639:
        val_490 = this.ballEntry;
        label_642:
        val_501 = null;
        if(val_490 == 2)
        {
                val_502 = null;
            LineController.popTagPlayer = this.playerBallTag;
            val_503 = null;
            val_504 = this.popAnimationPlayer;
            val_505 = this.playerNegateX;
            val_503 = null;
            val_506 = InstanceAnimator.UniversalX;
            val_507 = val_501 - 1;
        }
        else
        {
                val_508 = null;
            LineController.popTagPlayer = this.playerBallTag;
            val_509 = null;
            val_504 = this.popAnimationPlayer;
            val_505 = this.playerNegateX;
            val_509 = null;
            val_506 = InstanceAnimator.UniversalX;
            val_507 = val_501 + 1;
        }
        
        float val_487 = (float)val_507;
        val_487 = val_487 * (-19f);
        val_487 = val_487 + 474f;
        float val_243 = val_487 * 0.01745329f;
        float val_488 = 2.84f;
        val_488 = val_243 * val_488;
        float val_245 = val_506 + (val_243 * val_488);
        val_245 = val_245 * (float)val_505;
        float val_489 = 0f;
        val_489 = val_488 + val_489;
        UnityEngine.Quaternion val_246 = UnityEngine.Quaternion.identity;
        val_497 = 0f;
        val_499 = 0f;
        val_496 = val_504;
        val_500 = val_246.x;
        val_498 = public static UnityEngine.GameObject UnityEngine.Object::Instantiate<UnityEngine.GameObject>(UnityEngine.GameObject original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        label_651:
        UnityEngine.GameObject val_247 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_496, position:  new UnityEngine.Vector3() {x = 0f, y = val_497, z = val_499}, rotation:  new UnityEngine.Quaternion() {x = val_500, y = val_246.y, z = val_246.z, w = val_246.w});
        label_637:
        UnityEngine.AudioSource val_249 = GameAudio.sound.PlayOneShot(clip:  this.popClip[0], volume:  val_452);
        val_510 = null;
        val_510 = null;
        UnityEngine.Vector3 val_252 = InstanceAnimator.middleRingBalls.Length + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_253 = UnityEngine.Quaternion.identity;
        val_456 = val_253.x;
        val_457 = val_253.z;
        UnityEngine.GameObject val_254 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_252.x, y = val_252.y, z = val_252.z}, rotation:  new UnityEngine.Quaternion() {x = val_456, y = val_253.y, z = val_457, w = val_253.w});
        this.popText = val_254;
        val_254.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
        UnityEngine.Vector3 val_261 = InstanceAnimator.middleRingBalls.Length + 32.gameObject.transform.position;
        this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_261.x, y = val_261.y, z = val_261.z};
        popScoreScript val_262 = this.popText.GetComponent<popScoreScript>();
        val_262.scoreCounter = TargetBallScript.scoreCounter;
        val_450 = InstanceAnimator.middleRingBalls.Length + 32.gameObject.transform;
        UnityEngine.Vector3 val_265 = val_450.position;
        val_455 = val_265.y;
        UnityEngine.Quaternion val_266 = UnityEngine.Quaternion.identity;
        val_453 = val_265.x;
        val_512 = val_455;
        val_513 = val_265.z;
        val_514 = val_266.x;
        UnityEngine.GameObject val_267 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimation, position:  new UnityEngine.Vector3() {x = val_453, y = val_512, z = val_513}, rotation:  new UnityEngine.Quaternion() {x = val_514, y = val_266.y, z = val_266.z, w = val_266.w});
        int val_491 = InstanceAnimator.middleRingBalls.Length;
        UnityEngine.Object.Destroy(obj:  InstanceAnimator.middleRingBalls.Length + 32.gameObject);
        val_491 = val_491 + 1;
        mem[1152921526366992748] = val_491;
        val_515 = null;
        int val_492 = TargetBallScript.scoreCounter;
        val_492 = val_492 + this.chainScore;
        this.chainScore = val_492;
        val_516 = null;
        val_516 = null;
        val_515 = null;
        int val_493 = TargetBallScript.scoreCounter;
        val_493 = val_493 + LineController.userScore;
        LineController.userScore = val_493;
        label_628:
        if(val_501 > 8)
        {
            goto label_721;
        }
        
        val_517 = null;
        val_517 = null;
        if((InstanceAnimator.innerRingBalls.Length + 32) == 0)
        {
            goto label_721;
        }
        
        val_518 = null;
        val_518 = null;
        if((System.String.op_Equality(a:  InstanceAnimator.innerRingBalls.Length + 32.tag, b:  val_31)) == false)
        {
            goto label_721;
        }
        
        val_519 = null;
        val_519 = null;
        if((InstanceAnimator.innerRingBalls.Length + 32.gameObject) != other.gameObject)
        {
            goto label_730;
        }
        
        if(val_501 == 0)
        {
            goto label_731;
        }
        
        if(val_501 != 8)
        {
            goto label_732;
        }
        
        val_520 = this.ballEntry;
        if(val_520 == 4)
        {
            goto label_733;
        }
        
        goto label_735;
        label_731:
        val_520 = this.ballEntry;
        if(val_520 != 3)
        {
            goto label_735;
        }
        
        label_733:
        val_521 = null;
        val_521 = null;
        LineController.popTagPlayer = this.playerBallTag;
        UnityEngine.Vector3 val_277 = this.gameObject.transform.position;
        UnityEngine.Quaternion val_278 = UnityEngine.Quaternion.identity;
        val_525 = this.popAnimationPlayer;
        val_512 = val_277.y;
        val_526 = public static UnityEngine.GameObject UnityEngine.Object::Instantiate<UnityEngine.GameObject>(UnityEngine.GameObject original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        val_513 = val_277.z;
        val_514 = val_278.x;
        goto label_744;
        label_732:
        val_520 = this.ballEntry;
        label_735:
        val_527 = null;
        if(val_520 == 3)
        {
                val_528 = null;
            LineController.popTagPlayer = this.playerBallTag;
            val_529 = null;
            val_530 = this.popAnimationPlayer;
            val_531 = this.playerNegateX;
            val_529 = null;
            val_532 = InstanceAnimator.UniversalX;
            val_533 = val_501 - 1;
        }
        else
        {
                val_534 = null;
            LineController.popTagPlayer = this.playerBallTag;
            val_535 = null;
            val_530 = this.popAnimationPlayer;
            val_531 = this.playerNegateX;
            val_535 = null;
            val_532 = InstanceAnimator.UniversalX;
            val_533 = val_501 + 1;
        }
        
        float val_494 = (float)val_533;
        val_494 = val_494 * (-29f);
        val_494 = val_494 + 476f;
        float val_279 = val_494 * 0.01745329f;
        float val_495 = val_453;
        val_495 = val_279 * val_495;
        float val_281 = val_532 + (val_279 * val_495);
        val_281 = val_281 * (float)val_531;
        float val_496 = 0f;
        val_496 = val_495 + val_496;
        UnityEngine.Quaternion val_282 = UnityEngine.Quaternion.identity;
        val_512 = 0f;
        val_513 = 0f;
        val_525 = val_530;
        val_514 = val_282.x;
        val_526 = public static UnityEngine.GameObject UnityEngine.Object::Instantiate<UnityEngine.GameObject>(UnityEngine.GameObject original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        label_744:
        UnityEngine.GameObject val_283 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_525, position:  new UnityEngine.Vector3() {x = 0f, y = val_512, z = val_513}, rotation:  new UnityEngine.Quaternion() {x = val_514, y = val_282.y, z = val_282.z, w = val_282.w});
        label_730:
        UnityEngine.AudioSource val_285 = GameAudio.sound.PlayOneShot(clip:  this.popClip[0], volume:  val_452);
        val_536 = null;
        val_536 = null;
        UnityEngine.Vector3 val_288 = InstanceAnimator.innerRingBalls.Length + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_289 = UnityEngine.Quaternion.identity;
        val_456 = val_289.x;
        val_457 = val_289.z;
        UnityEngine.GameObject val_290 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_288.x, y = val_288.y, z = val_288.z}, rotation:  new UnityEngine.Quaternion() {x = val_456, y = val_289.y, z = val_457, w = val_289.w});
        this.popText = val_290;
        val_290.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
        UnityEngine.Vector3 val_297 = InstanceAnimator.innerRingBalls.Length + 32.gameObject.transform.position;
        this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_297.x, y = val_297.y, z = val_297.z};
        popScoreScript val_298 = this.popText.GetComponent<popScoreScript>();
        val_298.scoreCounter = TargetBallScript.scoreCounter;
        val_450 = InstanceAnimator.innerRingBalls.Length + 32.gameObject.transform;
        UnityEngine.Vector3 val_301 = val_450.position;
        val_455 = val_301.y;
        UnityEngine.Quaternion val_302 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_303 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimation, position:  new UnityEngine.Vector3() {x = val_301.x, y = val_455, z = val_301.z}, rotation:  new UnityEngine.Quaternion() {x = val_302.x, y = val_302.y, z = val_302.z, w = val_302.w});
        label_537:
        int val_498 = InstanceAnimator.innerRingBalls.Length;
        UnityEngine.Object.Destroy(obj:  InstanceAnimator.innerRingBalls.Length + 32.gameObject);
        val_498 = val_498 + 1;
        mem[1152921526366992748] = val_498;
        val_537 = null;
        int val_499 = TargetBallScript.scoreCounter;
        val_499 = val_499 + this.chainScore;
        this.chainScore = val_499;
        val_538 = null;
        val_538 = null;
        val_537 = null;
        int val_500 = TargetBallScript.scoreCounter;
        val_500 = val_500 + LineController.userScore;
        LineController.userScore = val_500;
        label_721:
        val_501 = val_501 + 1;
        val_539 = 458 - 14;
        if(val_501 != 17)
        {
            goto label_801;
        }
        
        if(this.PVP == false)
        {
            goto label_802;
        }
        
        val_448 = 1152921505077932032;
        val_540 = null;
        val_540 = null;
        LineControllerP2.numberOfPops = other;
        val_540 = null;
        LineControllerP2.receiveDamageFlag = true;
        goto label_808;
        label_65:
        if(this.triggerFlag == false)
        {
                return;
        }
        
        this.entryTriggerDestroyer = 0;
        this.triggerFlag = false;
        string val_306 = other.gameObject.tag;
        this.popBallTag = val_306;
        TargetBallScript.popTag = val_306;
        this.gameObject.transform.Find(n:  "TrailNormal").gameObject.SetActive(value:  false);
        val_448 = this.gameObject;
        if((System.String.op_Inequality(a:  val_448.tag, b:  "Iron_Ball")) != false)
        {
                this.gameObject.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            val_448 = this.gameObject.GetComponent<UnityEngine.CircleCollider2D>();
            val_448.enabled = false;
        }
        
        val_539 = 1152921504858337280;
        val_450 = "Rainbow_Bubble";
        var val_502 = 0;
        goto label_1234;
        label_1217:
        val_541 = null;
        val_541 = null;
        val_448 = mem[InstanceAnimator.playerInnerRingBalls.Length + 96];
        val_448 = InstanceAnimator.playerInnerRingBalls.Length + 96;
        if(val_448 == 0)
        {
            goto label_1201;
        }
        
        val_542 = null;
        val_448 = other.gameObject;
        val_542 = null;
        val_543 = mem[InstanceAnimator.playerInnerRingBalls.Length + 96];
        val_543 = InstanceAnimator.playerInnerRingBalls.Length + 96;
        if(val_543 != 0)
        {
            goto label_1105;
        }
        
        goto label_1106;
        label_1234:
        val_544 = this.ballEntry;
        if(val_544 != 1)
        {
            goto label_837;
        }
        
        val_545 = null;
        val_545 = null;
        if((InstanceAnimator.outerRingBalls.Length + 32) == 0)
        {
            goto label_844;
        }
        
        val_546 = null;
        val_546 = null;
        if(other.gameObject == (InstanceAnimator.outerRingBalls.Length + 32.gameObject))
        {
            goto label_853;
        }
        
        label_844:
        val_547 = null;
        val_547 = null;
        val_448 = mem[InstanceAnimator.playerOuterRingBalls.Length + 32];
        val_448 = InstanceAnimator.playerOuterRingBalls.Length + 32;
        if(val_448 == 0)
        {
            goto label_869;
        }
        
        val_548 = null;
        val_448 = other.gameObject;
        val_548 = null;
        if(val_448 != (InstanceAnimator.playerOuterRingBalls.Length + 32.gameObject))
        {
            goto label_869;
        }
        
        label_853:
        this.flag = 1;
        this.position = 0;
        val_549 = null;
        val_549 = null;
        if((InstanceAnimator.outerRingBalls.Length + 32) == 0)
        {
            goto label_876;
        }
        
        val_550 = null;
        val_550 = null;
        if(other.gameObject == (InstanceAnimator.outerRingBalls.Length + 32.gameObject))
        {
            goto label_1156;
        }
        
        label_876:
        val_551 = null;
        val_551 = null;
        val_448 = mem[InstanceAnimator.playerOuterRingBalls.Length + 32];
        val_448 = InstanceAnimator.playerOuterRingBalls.Length + 32;
        if(val_448 == 0)
        {
            goto label_1201;
        }
        
        val_552 = null;
        val_448 = other.gameObject;
        val_552 = null;
        if(InstanceAnimator.playerOuterRingBalls != null)
        {
            goto label_1167;
        }
        
        label_1168:
        label_1167:
        val_543 = mem[InstanceAnimator.playerOuterRingBalls.Length + 32];
        val_543 = InstanceAnimator.playerOuterRingBalls.Length + 32;
        if(val_543 != 0)
        {
            goto label_1105;
        }
        
        label_1106:
        label_1105:
        if(val_448 != val_543.gameObject)
        {
            goto label_1201;
        }
        
        val_448 = this.gameObject;
        val_553 = 0;
        if((val_448.CompareTag(tag:  "Rainbow_Bubble")) != false)
        {
                val_448 = other.gameObject;
            val_553 = 0;
            if((System.String.op_Inequality(a:  val_448.tag, b:  "SPD")) != false)
        {
                val_448 = other.gameObject;
            val_553 = 0;
            if((System.String.op_Inequality(a:  val_448.tag, b:  "SPD1")) != false)
        {
                val_448 = other.gameObject;
            val_553 = 0;
            if((System.String.op_Inequality(a:  val_448.tag, b:  "SPD2")) != false)
        {
                val_448 = this.gameObject;
            val_553 = 0;
            val_448.tag = other.gameObject.tag;
        }
        
        }
        
        }
        
        }
        
        TargetBallScript.scoreCounter = 99;
        val_554 = null;
        val_554 = null;
        val_555 = 0;
        val_556 = InstanceAnimator.playerOuterRingBalls;
        val_557 = InstanceAnimator.playerMiddleRingBalls;
        val_558 = InstanceAnimator.playerInnerRingBalls;
        val_559 = -this.playerNegateX;
        goto label_918;
        label_869:
        val_544 = this.ballEntry;
        label_837:
        if(val_544 != 6)
        {
            goto label_951;
        }
        
        val_560 = null;
        val_560 = null;
        var val_350 = val_502 + 16;
        if((InstanceAnimator.outerRingBalls.Length + 160) == 0)
        {
            goto label_926;
        }
        
        val_561 = null;
        val_561 = null;
        if(other.gameObject == (InstanceAnimator.outerRingBalls.Length + 160.gameObject))
        {
            goto label_935;
        }
        
        label_926:
        val_562 = null;
        val_562 = null;
        val_448 = mem[InstanceAnimator.playerOuterRingBalls.Length + 160];
        val_448 = InstanceAnimator.playerOuterRingBalls.Length + 160;
        if(val_448 == 0)
        {
            goto label_951;
        }
        
        val_563 = null;
        val_448 = other.gameObject;
        val_563 = null;
        if(val_448 != (InstanceAnimator.playerOuterRingBalls.Length + 160.gameObject))
        {
            goto label_951;
        }
        
        label_935:
        this.flag = 2;
        this.position = val_502 + 16;
        val_564 = null;
        val_564 = null;
        if((InstanceAnimator.outerRingBalls.Length + 160) == 0)
        {
            goto label_958;
        }
        
        val_565 = null;
        val_565 = null;
        if(other.gameObject == (InstanceAnimator.outerRingBalls.Length + 160.gameObject))
        {
            goto label_1156;
        }
        
        label_958:
        val_566 = null;
        val_566 = null;
        val_448 = mem[InstanceAnimator.playerOuterRingBalls.Length + 160];
        val_448 = InstanceAnimator.playerOuterRingBalls.Length + 160;
        if(val_448 == 0)
        {
            goto label_1201;
        }
        
        UnityEngine.GameObject val_365 = other.gameObject;
        val_567 = null;
        val_567 = null;
        if((InstanceAnimator.playerOuterRingBalls.Length + 160) != 0)
        {
            goto label_1105;
        }
        
        goto label_1106;
        label_951:
        if(0 > 12)
        {
            goto label_1201;
        }
        
        val_568 = this.ballEntry;
        if(val_568 != 2)
        {
            goto label_983;
        }
        
        val_569 = null;
        val_569 = null;
        if((InstanceAnimator.middleRingBalls.Length + 32) == 0)
        {
            goto label_990;
        }
        
        val_570 = null;
        val_570 = null;
        if(other.gameObject == (InstanceAnimator.middleRingBalls.Length + 32.gameObject))
        {
            goto label_999;
        }
        
        label_990:
        val_571 = null;
        val_571 = null;
        val_448 = mem[InstanceAnimator.playerMiddleRingBalls.Length + 32];
        val_448 = InstanceAnimator.playerMiddleRingBalls.Length + 32;
        if(val_448 == 0)
        {
            goto label_1015;
        }
        
        val_572 = null;
        val_448 = other.gameObject;
        val_572 = null;
        if(val_448 != (InstanceAnimator.playerMiddleRingBalls.Length + 32.gameObject))
        {
            goto label_1015;
        }
        
        label_999:
        this.flag = 3;
        this.position = 0;
        val_573 = null;
        val_573 = null;
        if((InstanceAnimator.middleRingBalls.Length + 32) == 0)
        {
            goto label_1022;
        }
        
        val_574 = null;
        val_574 = null;
        if(other.gameObject == (InstanceAnimator.middleRingBalls.Length + 32.gameObject))
        {
            goto label_1156;
        }
        
        label_1022:
        val_575 = null;
        val_575 = null;
        val_448 = mem[InstanceAnimator.playerMiddleRingBalls.Length + 32];
        val_448 = InstanceAnimator.playerMiddleRingBalls.Length + 32;
        if(val_448 == 0)
        {
            goto label_1201;
        }
        
        UnityEngine.GameObject val_379 = other.gameObject;
        val_576 = null;
        val_576 = null;
        if(InstanceAnimator.playerMiddleRingBalls != null)
        {
            goto label_1167;
        }
        
        goto label_1168;
        label_1015:
        val_568 = this.ballEntry;
        label_983:
        if(val_568 != 5)
        {
            goto label_1076;
        }
        
        val_577 = null;
        val_577 = null;
        if((InstanceAnimator.middleRingBalls.Length + 128) == 0)
        {
            goto label_1051;
        }
        
        val_578 = null;
        val_578 = null;
        if(other.gameObject == (InstanceAnimator.middleRingBalls.Length + 128.gameObject))
        {
            goto label_1060;
        }
        
        label_1051:
        val_579 = null;
        val_579 = null;
        val_448 = mem[InstanceAnimator.playerMiddleRingBalls.Length + 128];
        val_448 = InstanceAnimator.playerMiddleRingBalls.Length + 128;
        if(val_448 == 0)
        {
            goto label_1076;
        }
        
        val_580 = null;
        val_448 = other.gameObject;
        val_580 = null;
        if(val_448 != (InstanceAnimator.playerMiddleRingBalls.Length + 128.gameObject))
        {
            goto label_1076;
        }
        
        label_1060:
        this.flag = 4;
        this.position = val_502 + 12;
        val_581 = null;
        val_581 = null;
        if((InstanceAnimator.middleRingBalls.Length + 128) == 0)
        {
            goto label_1083;
        }
        
        val_582 = null;
        val_582 = null;
        if(other.gameObject == (InstanceAnimator.middleRingBalls.Length + 128.gameObject))
        {
            goto label_1156;
        }
        
        label_1083:
        val_583 = null;
        val_583 = null;
        val_448 = mem[InstanceAnimator.playerMiddleRingBalls.Length + 128];
        val_448 = InstanceAnimator.playerMiddleRingBalls.Length + 128;
        if(val_448 == 0)
        {
            goto label_1201;
        }
        
        UnityEngine.GameObject val_394 = other.gameObject;
        val_584 = null;
        val_584 = null;
        if((InstanceAnimator.playerMiddleRingBalls.Length + 128) != 0)
        {
            goto label_1105;
        }
        
        goto label_1106;
        label_1076:
        if(0 > 8)
        {
            goto label_1201;
        }
        
        val_585 = this.ballEntry;
        if(val_585 != 3)
        {
            goto label_1108;
        }
        
        val_586 = null;
        val_586 = null;
        if((InstanceAnimator.innerRingBalls.Length + 32) == 0)
        {
            goto label_1115;
        }
        
        val_587 = null;
        val_587 = null;
        if(other.gameObject == (InstanceAnimator.innerRingBalls.Length + 32.gameObject))
        {
            goto label_1124;
        }
        
        label_1115:
        val_588 = null;
        val_588 = null;
        val_448 = mem[InstanceAnimator.playerInnerRingBalls.Length + 32];
        val_448 = InstanceAnimator.playerInnerRingBalls.Length + 32;
        if(val_448 == 0)
        {
            goto label_1140;
        }
        
        val_589 = null;
        val_448 = other.gameObject;
        val_589 = null;
        if(val_448 != (InstanceAnimator.playerInnerRingBalls.Length + 32.gameObject))
        {
            goto label_1140;
        }
        
        label_1124:
        this.flag = 5;
        this.position = 0;
        val_590 = null;
        val_590 = null;
        if((InstanceAnimator.innerRingBalls.Length + 32) == 0)
        {
            goto label_1147;
        }
        
        val_591 = null;
        val_591 = null;
        if(other.gameObject == (InstanceAnimator.innerRingBalls.Length + 32.gameObject))
        {
            goto label_1156;
        }
        
        label_1147:
        val_592 = null;
        val_592 = null;
        val_448 = mem[InstanceAnimator.playerInnerRingBalls.Length + 32];
        val_448 = InstanceAnimator.playerInnerRingBalls.Length + 32;
        if(val_448 == 0)
        {
            goto label_1201;
        }
        
        UnityEngine.GameObject val_408 = other.gameObject;
        val_593 = null;
        val_593 = null;
        if(InstanceAnimator.playerInnerRingBalls != null)
        {
            goto label_1167;
        }
        
        goto label_1168;
        label_1140:
        val_585 = this.ballEntry;
        label_1108:
        if(val_585 != 4)
        {
            goto label_1201;
        }
        
        val_594 = null;
        val_594 = null;
        if((InstanceAnimator.innerRingBalls.Length + 96) == 0)
        {
            goto label_1176;
        }
        
        val_595 = null;
        val_595 = null;
        if(other.gameObject == (InstanceAnimator.innerRingBalls.Length + 96.gameObject))
        {
            goto label_1185;
        }
        
        label_1176:
        val_596 = null;
        val_596 = null;
        val_448 = mem[InstanceAnimator.playerInnerRingBalls.Length + 96];
        val_448 = InstanceAnimator.playerInnerRingBalls.Length + 96;
        if(val_448 == 0)
        {
            goto label_1201;
        }
        
        val_597 = null;
        val_448 = other.gameObject;
        val_597 = null;
        if(val_448 != (InstanceAnimator.playerInnerRingBalls.Length + 96.gameObject))
        {
            goto label_1201;
        }
        
        label_1185:
        this.flag = 6;
        this.position = val_502 + 8;
        val_598 = null;
        val_598 = null;
        if((InstanceAnimator.innerRingBalls.Length + 96) == 0)
        {
            goto label_1217;
        }
        
        val_599 = null;
        val_599 = null;
        if(other.gameObject != (InstanceAnimator.innerRingBalls.Length + 96.gameObject))
        {
            goto label_1217;
        }
        
        label_1156:
        val_448 = this.gameObject;
        val_600 = 0;
        if((val_448.CompareTag(tag:  "Rainbow_Bubble")) != false)
        {
                val_448 = other.gameObject;
            val_600 = 0;
            if((System.String.op_Inequality(a:  val_448.tag, b:  "SPD")) != false)
        {
                val_448 = other.gameObject;
            val_600 = 0;
            if((System.String.op_Inequality(a:  val_448.tag, b:  "SPD1")) != false)
        {
                val_448 = other.gameObject;
            val_600 = 0;
            if((System.String.op_Inequality(a:  val_448.tag, b:  "SPD2")) != false)
        {
                val_448 = this.gameObject;
            val_600 = 0;
            val_448.tag = other.gameObject.tag;
        }
        
        }
        
        }
        
        }
        
        val_601 = null;
        val_601 = null;
        val_559 = this.playerNegateX;
        val_555 = 50;
        val_556 = InstanceAnimator.outerRingBalls;
        val_557 = InstanceAnimator.middleRingBalls;
        val_558 = InstanceAnimator.innerRingBalls;
        label_918:
        UnityEngine.Coroutine val_437 = this.StartCoroutine(routine:  this.DestroyTarget(outerRingBalls:  val_556, middleRingBalls:  val_557, innerRingBalls:  val_558, negateX:  val_559, incrementCounter:  50));
        label_1201:
        val_502 = val_502 - 1;
        val_451 = 0 + 1;
        if(val_502 != 17)
        {
            goto label_1234;
        }
        
        return;
        label_802:
        val_448 = 1152921505077080064;
        val_602 = static_value_032DD328;
        val_602 = static_value_032DD328;
        mem2[0] = other;
        label_808:
        val_603 = static_value_032DD328;
        val_603 = static_value_032DD328;
        if(this.PVP == false)
        {
            goto label_1243;
        }
        
        val_604 = null;
        val_604 = null;
        LineControllerP2.receiveDamageFlag = true;
        goto label_1246;
        label_41:
        val_605 = this.entryTriggerDestroyer;
        if(val_605 != 2)
        {
            goto label_1247;
        }
        
        val_606 = this.ballEntry;
        if(val_606 != 6)
        {
                if(val_606 != 1)
        {
            goto label_1249;
        }
        
        }
        
        val_607 = null;
        val_607 = null;
        if(InstanceAnimator.isPlayerOuterRingEmpty == true)
        {
            goto label_1262;
        }
        
        val_606 = this.ballEntry;
        label_1249:
        if(val_606 != 5)
        {
                if(val_606 != 2)
        {
            goto label_1254;
        }
        
        }
        
        val_608 = null;
        val_608 = null;
        if(InstanceAnimator.isPlayerMiddleRingEmpty == true)
        {
            goto label_1262;
        }
        
        val_606 = this.ballEntry;
        label_1254:
        val_606 = val_606 - 3;
        if(val_606 > 1)
        {
            goto label_1258;
        }
        
        val_609 = null;
        val_609 = null;
        if(InstanceAnimator.isPlayerInnerRingEmpty == true)
        {
            goto label_1262;
        }
        
        label_1258:
        val_605 = this.entryTriggerDestroyer;
        label_1247:
        if(val_605 == 4)
        {
            goto label_1262;
        }
        
        return;
        label_1243:
        val_610 = static_value_032DD328;
        val_610 = static_value_032DD328;
        mem2[0] = 1;
        label_1246:
        val_445 = this.gameObject;
        val_611 = val_445;
        goto label_1268;
        label_50:
        val_448 = 0;
        if(val_19 != null)
        {
                var val_503 = 0;
            val_503 = val_503 + 1;
            val_19.Dispose();
        }
        
        val_449 = this.entryTriggerDestroyer;
        label_42:
        if(val_449 != 2)
        {
                return;
        }
        
        label_1262:
        UnityEngine.AudioSource val_441 = GameAudio.sound.PlayOneShot(clip:  this.popClip[0], volume:  1f);
        TargetBallScript.popTag = this.gameObject.tag;
        val_615 = null;
        val_615 = null;
        LineController.popTagPlayer = this.playerBallTag;
        val_448 = this.gameObject.transform;
        UnityEngine.Vector3 val_446 = val_448.position;
        val_452 = val_446.x;
        val_455 = val_446.z;
        UnityEngine.Quaternion val_447 = UnityEngine.Quaternion.identity;
        val_456 = val_447.y;
        val_457 = val_447.w;
        UnityEngine.GameObject val_448 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = val_452, y = val_446.y, z = val_455}, rotation:  new UnityEngine.Quaternion() {x = val_447.x, y = val_456, z = val_447.z, w = val_457});
        label_1268:
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private System.Collections.IEnumerator DestroyTarget(UnityEngine.GameObject[] outerRingBalls, UnityEngine.GameObject[] middleRingBalls, UnityEngine.GameObject[] innerRingBalls, int negateX, int incrementCounter)
    {
        TargetBallScript.<DestroyTarget>d__29 val_1 = new TargetBallScript.<DestroyTarget>d__29(<>1__state:  0);
        if(val_1 != null)
        {
                .<>4__this = this;
            .outerRingBalls = outerRingBalls;
            .middleRingBalls = middleRingBalls;
            .innerRingBalls = innerRingBalls;
            .negateX = negateX;
        }
        else
        {
                mem[32] = this;
            mem[40] = outerRingBalls;
            mem[72] = middleRingBalls;
            mem[56] = innerRingBalls;
            mem[48] = negateX;
        }
        
        .incrementCounter = incrementCounter;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator BridgeThroughMiddleRing(UnityEngine.GameObject[] middleRingBalls, int negateX, int incrementCounter)
    {
        TargetBallScript.<BridgeThroughMiddleRing>d__30 val_1 = new TargetBallScript.<BridgeThroughMiddleRing>d__30(<>1__state:  0);
        if(val_1 != null)
        {
                .<>4__this = this;
            .middleRingBalls = middleRingBalls;
        }
        else
        {
                mem[32] = this;
            mem[40] = middleRingBalls;
        }
        
        .incrementCounter = incrementCounter;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator BridgeThroughInnerRing(UnityEngine.GameObject[] innerRingBalls, int negateX, int incrementCounter)
    {
        TargetBallScript.<BridgeThroughInnerRing>d__31 val_1 = new TargetBallScript.<BridgeThroughInnerRing>d__31(<>1__state:  0);
        if(val_1 != null)
        {
                .<>4__this = this;
            .innerRingBalls = innerRingBalls;
        }
        else
        {
                mem[32] = this;
            mem[40] = innerRingBalls;
        }
        
        .incrementCounter = incrementCounter;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator BridgeThroughOuterRing(UnityEngine.GameObject[] outerRingBalls, int negateX, int incrementCounter)
    {
        TargetBallScript.<BridgeThroughOuterRing>d__32 val_1 = new TargetBallScript.<BridgeThroughOuterRing>d__32(<>1__state:  0);
        if(val_1 != null)
        {
                .<>4__this = this;
            .outerRingBalls = outerRingBalls;
        }
        else
        {
                mem[32] = this;
            mem[40] = outerRingBalls;
        }
        
        .incrementCounter = incrementCounter;
        return (System.Collections.IEnumerator)val_1;
    }
    public void camShake()
    {
        UnityEngine.GameObject.Find(name:  "-camerashake").GetComponent<CameraShake>().enabled = true;
    }
    public TargetBallScript()
    {
    
    }

}
