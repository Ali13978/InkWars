using UnityEngine;
public class TargetBallVs : TargetBall_Parent
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
    public int player2entrytrigger;
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
    private DynamicMessageUIController m_DynamicMessageUIController;
    private HitComboType m_ComboType;
    
    // Methods
    public void LogCombo(int _hitCount, HitComboType _type, Techniques _technique)
    {
        DynamicMessageUIController val_5;
        var val_6;
        var val_7;
        val_5 = this.m_DynamicMessageUIController;
        if(0 == val_5)
        {
                return;
        }
        
        val_5 = 1152921505064992768;
        val_6 = null;
        val_6 = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        this.m_DynamicMessageUIController.OnComboPop(message:  new PlayerMessage(PlayerID:  (DataStructs.UserDataDictionary.Settings.FlipNegateX != 1) ? 1 : 0, HitCount:  _hitCount, ComboType:  _type, ComboTechnique:  _technique));
    }
    private void Start()
    {
    
    }
    private void Awake()
    {
        var val_6;
        var val_7;
        this.entryTrigger = 0;
        val_6 = null;
        val_6 = null;
        this.flag = -4294967296;
        this.position = -1;
        mem[1152921526379854026] = 0;
        this.crossCounter = 0;
        this.triggerFlag = true;
        mem[1152921526379854063] = 0;
        mem[1152921526379854061] = 0;
        this.isInnerBridgeRunning = false;
        this.isMiddleBridgeRunning = false;
        this.isOuterBridgeRunning = false;
        this.player2entrytrigger = 0;
        this.playerNegateX = -InstanceAnimator.playerNegateX;
        TargetBallVs.scoreCounter = 100;
        mem[1152921526379854028] = 0;
        val_7 = null;
        val_7 = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
                return;
        }
        
        DynamicMessageUIController val_1 = UnityEngine.Object.FindObjectOfType<DynamicMessageUIController>();
        this.m_DynamicMessageUIController = val_1;
        if(0 == val_1)
        {
                return;
        }
        
        object[] val_3 = new object[1];
        val_3[0] = this.gameObject.name;
        UnityEngine.Debug.LogFormat(format:  "Loaded Dynamic Message UI Controller on {0}", args:  val_3);
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        object val_18;
        int val_20;
        UnityEngine.Collider2D val_481;
        TargetBallVs val_482;
        int val_483;
        int val_484;
        var val_485;
        var val_486;
        var val_487;
        float val_488;
        string val_489;
        var val_490;
        var val_491;
        float val_492;
        float val_493;
        int val_494;
        float val_495;
        float val_497;
        float val_498;
        float val_499;
        float val_500;
        float val_501;
        float val_502;
        var val_503;
        UnityEngine.Sprite val_504;
        UnityEngine.Sprite val_505;
        var val_506;
        var val_507;
        var val_508;
        string val_509;
        var val_510;
        float val_512;
        float val_513;
        float val_514;
        float val_515;
        var val_516;
        UnityEngine.GameObject val_517;
        float val_518;
        var val_519;
        var val_520;
        float val_521;
        float val_522;
        float val_524;
        float val_525;
        var val_526;
        var val_527;
        var val_528;
        var val_529;
        int val_530;
        var val_531;
        float val_533;
        float val_534;
        float val_535;
        float val_536;
        var val_537;
        var val_538;
        UnityEngine.GameObject val_539;
        float val_540;
        var val_541;
        var val_542;
        var val_543;
        float val_544;
        float val_546;
        float val_547;
        float val_548;
        var val_549;
        var val_550;
        var val_551;
        int val_552;
        var val_553;
        var val_554;
        var val_555;
        UnityEngine.GameObject val_556;
        float val_557;
        var val_558;
        var val_559;
        var val_560;
        var val_561;
        var val_562;
        var val_563;
        var val_564;
        var val_565;
        var val_566;
        var val_567;
        var val_568;
        var val_569;
        var val_570;
        var val_571;
        int val_572;
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
        UnityEngine.GameObject[] val_584;
        UnityEngine.GameObject[] val_585;
        UnityEngine.GameObject[] val_586;
        int val_587;
        var val_588;
        var val_589;
        var val_590;
        var val_591;
        var val_592;
        var val_593;
        var val_594;
        var val_595;
        int val_596;
        var val_597;
        var val_598;
        var val_599;
        var val_600;
        var val_601;
        var val_602;
        var val_603;
        var val_604;
        var val_605;
        var val_606;
        var val_607;
        var val_608;
        var val_609;
        var val_610;
        var val_611;
        var val_612;
        int val_613;
        var val_614;
        var val_615;
        var val_616;
        var val_617;
        var val_618;
        var val_619;
        var val_620;
        var val_621;
        var val_622;
        var val_623;
        var val_624;
        var val_625;
        var val_626;
        var val_627;
        var val_628;
        var val_629;
        int val_630;
        int val_631;
        var val_632;
        var val_633;
        var val_634;
        var val_635;
        var val_636;
        var val_640;
        val_481 = other;
        val_482 = this;
        val_483 = val_481.gameObject;
        if((val_483.CompareTag(tag:  "EntryColliders")) == false)
        {
            goto label_3;
        }
        
        int val_3 = this.entryTrigger + 1;
        this.entryTrigger = val_3;
        if(this.entryTrigger == 0)
        {
            goto label_4;
        }
        
        if(val_3 != 2)
        {
                return;
        }
        
        LineController.instance.gapTrans();
        return;
        label_3:
        val_483 = val_481.gameObject;
        if((val_483.CompareTag(tag:  "ExitColliders")) == false)
        {
            goto label_11;
        }
        
        int val_485 = this.player2entrytrigger;
        val_485 = val_485 + 1;
        this.player2entrytrigger = val_485;
        if(((this.gameObject.CompareTag(tag:  "Rainbow_Bubble")) != true) && ((this.gameObject.CompareTag(tag:  "Color_Eraser_Ball")) != true))
        {
                if((this.gameObject.CompareTag(tag:  "Iron_Ball")) != true)
        {
                if(Character_GlobalInfo.gameMode != 3)
        {
            goto label_20;
        }
        
        }
        
        }
        
        val_484 = this.player2entrytrigger;
        if(val_484 != 1)
        {
            goto label_21;
        }
        
        val_485 = 1152921504865153024;
        label_42:
        if((this.gameObject.transform.GetEnumerator() & 1) == 0)
        {
            goto label_29;
        }
        
        0.gameObject.SetActive(value:  false);
        goto label_42;
        label_11:
        val_483 = this.gameObject;
        if((val_483.CompareTag(tag:  "Color_Eraser_Ball")) == false)
        {
            goto label_44;
        }
        
        if(this.triggerFlag == false)
        {
                return;
        }
        
        TargetBallVs.scoreCounter = 200;
        this.triggerFlag = false;
        TargetBallVs.popTag = this.gameObject.tag;
        val_486 = "SPD";
        val_485 = 1152921505075376128;
        val_487 = 1152921504858337280;
        val_488 = 0.01745329f;
        val_489 = val_481.gameObject.tag;
        var val_531 = 0;
        val_490 = 458;
        val_491 = 14;
        val_492 = 1f;
        val_493 = 1.83f;
        label_748:
        if((System.String.op_Equality(a:  val_489, b:  "SPD")) != true)
        {
                if((System.String.op_Equality(a:  val_489, b:  "SPD1")) != true)
        {
                if((System.String.op_Equality(a:  val_489, b:  "SPD2")) == false)
        {
            goto label_51;
        }
        
        }
        
        }
        
        if((InstanceAnimator.outerRingBalls.Length + 32) == 0)
        {
            goto label_211;
        }
        
        val_485 = 1152921505075376128;
        if((InstanceAnimator.outerRingBalls.Length + 32.gameObject) != val_481.gameObject)
        {
            goto label_107;
        }
        
        if(val_531 == 0)
        {
            goto label_68;
        }
        
        if(val_531 != 16)
        {
            goto label_69;
        }
        
        if(this.ballEntry == 6)
        {
            goto label_70;
        }
        
        goto label_98;
        label_51:
        if(((InstanceAnimator.outerRingBalls.Length + 32) == 0) || ((System.String.op_Equality(a:  InstanceAnimator.outerRingBalls.Length + 32.tag, b:  val_489)) == false))
        {
            goto label_84;
        }
        
        if((InstanceAnimator.outerRingBalls.Length + 32.gameObject) != val_481.gameObject)
        {
            goto label_521;
        }
        
        if(val_531 == 0)
        {
            goto label_94;
        }
        
        if(val_531 != 16)
        {
            goto label_95;
        }
        
        val_494 = this.ballEntry;
        if(val_494 == 6)
        {
            goto label_96;
        }
        
        goto label_97;
        label_68:
        if(this.ballEntry != 1)
        {
            goto label_98;
        }
        
        label_70:
        LineControllerP2.popTagPlayer = this.playerBallTag;
        UnityEngine.Vector3 val_43 = this.gameObject.transform.position;
        val_495 = val_43.y;
        UnityEngine.Quaternion val_44 = UnityEngine.Quaternion.identity;
        val_497 = val_44.x;
        val_485 = 1152921505075376128;
        val_498 = val_44.z;
        val_499 = val_495;
        val_500 = val_43.z;
        val_501 = val_497;
        UnityEngine.GameObject val_45 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = val_43.x, y = val_499, z = val_500}, rotation:  new UnityEngine.Quaternion() {x = val_501, y = val_44.y, z = val_498, w = val_44.w});
        val_502 = 1f;
        goto label_107;
        label_69:
        label_98:
        if(this.ballEntry == 1)
        {
                LineControllerP2.popTagPlayer = this.playerBallTag;
            val_20 = 0;
            float val_47 = (486f * val_488) * (-3.84f);
        }
        else
        {
                LineControllerP2.popTagPlayer = this.playerBallTag;
            float val_486 = 14f;
            val_486 = val_486 * val_488;
            val_486 = 472f - val_486;
            float val_487 = 458f;
            val_487 = val_487 * val_488;
            val_20 = 0;
            float val_48 = val_486 * (-3.84f);
        }
        
        val_487 = val_487 * 3.84f;
        float val_488 = 0f;
        val_488 = val_487 + val_488;
        UnityEngine.Quaternion val_49 = UnityEngine.Quaternion.identity;
        val_495 = val_49.y;
        val_497 = val_49.w;
        val_499 = 0f;
        val_500 = 0f;
        val_501 = val_49.x;
        UnityEngine.GameObject val_50 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = 0f, y = val_499, z = val_500}, rotation:  new UnityEngine.Quaternion() {x = val_501, y = val_495, z = val_49.z, w = val_497});
        label_107:
        if((InstanceAnimator.outerRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD")) == false)
        {
            goto label_128;
        }
        
        UnityEngine.AudioSource val_54 = GameAudio.sound.PlayOneShot(clip:  this.popClip[1], volume:  val_492);
        UnityEngine.SpriteRenderer val_56 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.GetComponentInChildren<UnityEngine.SpriteRenderer>();
        System.Type val_490 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_58 = UnityEngine.Resources.Load(path:  "SPD1crack", systemTypeInstance:  val_490);
        if(val_56 == null)
        {
            goto label_142;
        }
        
        if(val_58 == null)
        {
            goto label_143;
        }
        
        label_212:
        val_490 = (null == null) ? (val_58) : 0;
        goto label_144;
        label_128:
        if((InstanceAnimator.outerRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD1")) == false)
        {
            goto label_151;
        }
        
        UnityEngine.AudioSource val_62 = GameAudio.sound.PlayOneShot(clip:  this.popClip[1], volume:  val_492);
        UnityEngine.SpriteRenderer val_64 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.GetComponentInChildren<UnityEngine.SpriteRenderer>();
        System.Type val_492 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_66 = UnityEngine.Resources.Load(path:  "SPD2crack", systemTypeInstance:  val_492);
        if(val_64 == null)
        {
            goto label_165;
        }
        
        if(val_66 == null)
        {
            goto label_166;
        }
        
        label_218:
        val_492 = (null == null) ? (val_66) : 0;
        goto label_167;
        label_151:
        if((InstanceAnimator.outerRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD2")) == false)
        {
            goto label_211;
        }
        
        UnityEngine.AudioSource val_70 = GameAudio.sound.PlayOneShot(clip:  this.popClip[2], volume:  val_492);
        UnityEngine.Vector3 val_73 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_74 = UnityEngine.Quaternion.identity;
        val_497 = val_74.x;
        val_498 = val_74.z;
        UnityEngine.GameObject val_75 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_73.x, y = val_73.y, z = val_73.z}, rotation:  new UnityEngine.Quaternion() {x = val_497, y = val_74.y, z = val_498, w = val_74.w});
        this.popText = val_75;
        val_502 = 1f;
        val_75.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
        UnityEngine.Vector3 val_82 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.transform.position;
        this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_82.x, y = val_82.y, z = val_82.z};
        object val_83 = this.popText.GetComponent<System.Object>();
        mem2[0] = TargetBallVs.scoreCounter;
        UnityEngine.Vector3 val_86 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.transform.position;
        val_495 = val_86.y;
        UnityEngine.Quaternion val_87 = UnityEngine.Quaternion.identity;
        val_499 = val_495;
        val_500 = val_86.z;
        val_501 = val_87.x;
        UnityEngine.GameObject val_88 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimation, position:  new UnityEngine.Vector3() {x = val_86.x, y = val_499, z = val_500}, rotation:  new UnityEngine.Quaternion() {x = val_501, y = val_87.y, z = val_87.z, w = val_87.w});
        val_485 = 1152921505075376128;
        UnityEngine.Object.Destroy(obj:  InstanceAnimator.outerRingBalls.Length + 32.gameObject);
        var val_494 = mem[1152921526382026476];
        val_494 = val_494 + 1;
        mem[1152921526382026476] = val_494;
        int val_495 = TargetBallVs.scoreCounter;
        val_495 = val_495 + mem[1152921526382026564];
        mem[1152921526382026564] = val_495;
        UnityEngine.PlayerPrefs.SetInt(key:  "Score2", value:  TargetBallVs.scoreCounter + (UnityEngine.PlayerPrefs.GetInt(key:  "Score2")));
        val_486 = val_486;
        val_489 = val_489;
        val_487 = val_487;
        val_491 = val_491;
        val_490 = 458;
        val_503 = val_482;
        goto label_211;
        label_142:
        if(val_58 != null)
        {
            goto label_212;
        }
        
        label_143:
        label_144:
        val_56.sprite = 0;
        val_485 = 1152921505075376128;
        if((InstanceAnimator.outerRingBalls.Length + 32.gameObject) != null)
        {
            goto label_217;
        }
        
        goto label_217;
        label_165:
        if(val_66 != null)
        {
            goto label_218;
        }
        
        label_166:
        label_167:
        val_64.sprite = 0;
        val_485 = 1152921505075376128;
        label_217:
        InstanceAnimator.outerRingBalls.Length + 32.gameObject.tag = "SPD2";
        label_211:
        if(val_531 > 12)
        {
            goto label_674;
        }
        
        if((InstanceAnimator.middleRingBalls.Length + 32) == 0)
        {
            goto label_357;
        }
        
        val_485 = 1152921505075376128;
        if((InstanceAnimator.middleRingBalls.Length + 32.gameObject) != val_481.gameObject)
        {
            goto label_253;
        }
        
        if(val_531 == 0)
        {
            goto label_240;
        }
        
        if(val_531 != 12)
        {
            goto label_241;
        }
        
        if(this.ballEntry == 5)
        {
            goto label_242;
        }
        
        goto label_244;
        label_240:
        if(this.ballEntry != 2)
        {
            goto label_244;
        }
        
        label_242:
        LineControllerP2.popTagPlayer = this.playerBallTag;
        UnityEngine.Vector3 val_100 = this.gameObject.transform.position;
        val_495 = val_100.y;
        UnityEngine.Quaternion val_101 = UnityEngine.Quaternion.identity;
        val_497 = val_101.x;
        val_485 = 1152921505075376128;
        val_498 = val_101.z;
        val_499 = val_495;
        val_500 = val_100.z;
        val_501 = val_497;
        UnityEngine.GameObject val_102 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = val_100.x, y = val_499, z = val_500}, rotation:  new UnityEngine.Quaternion() {x = val_501, y = val_101.y, z = val_498, w = val_101.w});
        val_502 = 1f;
        goto label_253;
        label_241:
        label_244:
        if(this.ballEntry == 2)
        {
                LineControllerP2.popTagPlayer = this.playerBallTag;
        }
        else
        {
                LineControllerP2.popTagPlayer = this.playerBallTag;
        }
        
        float val_496 = 1f;
        val_496 = val_496 * (-19f);
        val_496 = val_496 + 474f;
        float val_103 = val_496 * val_488;
        float val_497 = val_103;
        float val_104 = val_103 * (-2.84f);
        val_20 = 0;
        val_497 = val_497 * 2.84f;
        float val_498 = 0f;
        val_498 = val_497 + val_498;
        UnityEngine.Quaternion val_105 = UnityEngine.Quaternion.identity;
        val_495 = val_105.y;
        val_497 = val_105.w;
        val_499 = 0f;
        val_500 = 0f;
        val_501 = val_105.x;
        UnityEngine.GameObject val_106 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = 0f, y = val_499, z = val_500}, rotation:  new UnityEngine.Quaternion() {x = val_501, y = val_495, z = val_105.z, w = val_497});
        label_253:
        if((InstanceAnimator.middleRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD")) == false)
        {
            goto label_274;
        }
        
        UnityEngine.AudioSource val_110 = GameAudio.sound.PlayOneShot(clip:  this.popClip[1], volume:  val_492);
        UnityEngine.SpriteRenderer val_112 = InstanceAnimator.middleRingBalls.Length + 32.gameObject.GetComponentInChildren<UnityEngine.SpriteRenderer>();
        System.Type val_500 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_114 = UnityEngine.Resources.Load(path:  "SPD1crack", systemTypeInstance:  val_500);
        if(val_112 == null)
        {
            goto label_288;
        }
        
        if(val_114 == null)
        {
            goto label_289;
        }
        
        label_358:
        val_500 = (null == null) ? (val_114) : 0;
        goto label_290;
        label_274:
        if((InstanceAnimator.middleRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD1")) == false)
        {
            goto label_297;
        }
        
        UnityEngine.AudioSource val_118 = GameAudio.sound.PlayOneShot(clip:  this.popClip[1], volume:  val_492);
        UnityEngine.SpriteRenderer val_120 = InstanceAnimator.middleRingBalls.Length + 32.gameObject.GetComponentInChildren<UnityEngine.SpriteRenderer>();
        System.Type val_502 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_122 = UnityEngine.Resources.Load(path:  "SPD2crack", systemTypeInstance:  val_502);
        if(val_120 == null)
        {
            goto label_311;
        }
        
        if(val_122 == null)
        {
            goto label_312;
        }
        
        label_364:
        val_502 = (null == null) ? (val_122) : 0;
        goto label_313;
        label_297:
        if((InstanceAnimator.middleRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD2")) == false)
        {
            goto label_357;
        }
        
        UnityEngine.AudioSource val_126 = GameAudio.sound.PlayOneShot(clip:  this.popClip[2], volume:  val_492);
        UnityEngine.Vector3 val_129 = InstanceAnimator.middleRingBalls.Length + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_130 = UnityEngine.Quaternion.identity;
        val_497 = val_130.x;
        val_498 = val_130.z;
        UnityEngine.GameObject val_131 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_129.x, y = val_129.y, z = val_129.z}, rotation:  new UnityEngine.Quaternion() {x = val_497, y = val_130.y, z = val_498, w = val_130.w});
        this.popText = val_131;
        val_502 = 1f;
        val_131.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
        UnityEngine.Vector3 val_138 = InstanceAnimator.middleRingBalls.Length + 32.gameObject.transform.position;
        this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_138.x, y = val_138.y, z = val_138.z};
        popScoreScript val_139 = this.popText.GetComponent<popScoreScript>();
        val_139.scoreCounter = TargetBallVs.scoreCounter;
        UnityEngine.Vector3 val_142 = InstanceAnimator.middleRingBalls.Length + 32.gameObject.transform.position;
        val_495 = val_142.y;
        UnityEngine.Quaternion val_143 = UnityEngine.Quaternion.identity;
        val_499 = val_495;
        val_500 = val_142.z;
        val_501 = val_143.x;
        UnityEngine.GameObject val_144 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimation, position:  new UnityEngine.Vector3() {x = val_142.x, y = val_499, z = val_500}, rotation:  new UnityEngine.Quaternion() {x = val_501, y = val_143.y, z = val_143.z, w = val_143.w});
        val_485 = 1152921505075376128;
        UnityEngine.Object.Destroy(obj:  InstanceAnimator.middleRingBalls.Length + 32.gameObject);
        var val_504 = mem[1152921526382026476];
        val_504 = val_504 + 1;
        mem[1152921526382026476] = val_504;
        int val_505 = TargetBallVs.scoreCounter;
        val_505 = val_505 + mem[1152921526382026564];
        mem[1152921526382026564] = val_505;
        UnityEngine.PlayerPrefs.SetInt(key:  "Score2", value:  TargetBallVs.scoreCounter + (UnityEngine.PlayerPrefs.GetInt(key:  "Score2")));
        val_486 = val_486;
        val_489 = val_489;
        val_487 = val_487;
        val_491 = val_491;
        val_490 = 458;
        val_503 = val_482;
        goto label_357;
        label_288:
        if(val_114 != null)
        {
            goto label_358;
        }
        
        label_289:
        label_290:
        val_112.sprite = 0;
        val_485 = 1152921505075376128;
        if((InstanceAnimator.middleRingBalls.Length + 32.gameObject) != null)
        {
            goto label_363;
        }
        
        goto label_363;
        label_311:
        if(val_122 != null)
        {
            goto label_364;
        }
        
        label_312:
        label_313:
        val_120.sprite = 0;
        val_485 = 1152921505075376128;
        label_363:
        InstanceAnimator.middleRingBalls.Length + 32.gameObject.tag = "SPD2";
        label_357:
        if((val_531 > 8) || ((InstanceAnimator.innerRingBalls.Length + 32) == 0))
        {
            goto label_674;
        }
        
        val_485 = 1152921505075376128;
        if((InstanceAnimator.innerRingBalls.Length + 32.gameObject) != val_481.gameObject)
        {
            goto label_399;
        }
        
        if(val_531 == 0)
        {
            goto label_386;
        }
        
        if(val_531 != 8)
        {
            goto label_387;
        }
        
        if(this.ballEntry == 4)
        {
            goto label_388;
        }
        
        goto label_390;
        label_386:
        if(this.ballEntry != 3)
        {
            goto label_390;
        }
        
        label_388:
        LineControllerP2.popTagPlayer = this.playerBallTag;
        UnityEngine.Vector3 val_156 = this.gameObject.transform.position;
        val_495 = val_156.y;
        UnityEngine.Quaternion val_157 = UnityEngine.Quaternion.identity;
        val_497 = val_157.x;
        val_485 = 1152921505075376128;
        val_498 = val_157.z;
        val_499 = val_495;
        val_500 = val_156.z;
        val_501 = val_497;
        UnityEngine.GameObject val_158 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = val_156.x, y = val_499, z = val_500}, rotation:  new UnityEngine.Quaternion() {x = val_501, y = val_157.y, z = val_498, w = val_157.w});
        val_502 = 1f;
        goto label_399;
        label_387:
        label_390:
        if(this.ballEntry == 3)
        {
                LineControllerP2.popTagPlayer = this.playerBallTag;
        }
        else
        {
                LineControllerP2.popTagPlayer = this.playerBallTag;
        }
        
        float val_506 = 1f;
        val_506 = val_506 * (-29f);
        val_506 = val_506 + 476f;
        float val_159 = val_506 * val_488;
        float val_507 = val_159;
        float val_160 = val_159 * (-1.83f);
        val_20 = 0;
        val_507 = val_507 * val_493;
        float val_508 = 0f;
        val_508 = val_507 + val_508;
        UnityEngine.Quaternion val_161 = UnityEngine.Quaternion.identity;
        val_495 = val_161.y;
        val_497 = val_161.w;
        val_499 = 0f;
        val_500 = 0f;
        val_501 = val_161.x;
        UnityEngine.GameObject val_162 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = 0f, y = val_499, z = val_500}, rotation:  new UnityEngine.Quaternion() {x = val_501, y = val_495, z = val_161.z, w = val_497});
        label_399:
        if((InstanceAnimator.innerRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD")) == false)
        {
            goto label_420;
        }
        
        UnityEngine.AudioSource val_166 = GameAudio.sound.PlayOneShot(clip:  this.popClip[1], volume:  val_492);
        UnityEngine.SpriteRenderer val_168 = InstanceAnimator.innerRingBalls.Length + 32.gameObject.GetComponentInChildren<UnityEngine.SpriteRenderer>();
        System.Type val_510 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_170 = UnityEngine.Resources.Load(path:  "SPD1crack", systemTypeInstance:  val_510);
        if(val_168 == null)
        {
            goto label_434;
        }
        
        if(val_170 == null)
        {
            goto label_435;
        }
        
        label_501:
        val_510 = (null == null) ? (val_170) : 0;
        goto label_436;
        label_420:
        if((InstanceAnimator.innerRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD1")) == false)
        {
            goto label_443;
        }
        
        UnityEngine.AudioSource val_174 = GameAudio.sound.PlayOneShot(clip:  this.popClip[1], volume:  val_492);
        System.Type val_512 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_178 = UnityEngine.Resources.Load(path:  "SPD2crack", systemTypeInstance:  val_512);
        if(val_178 == null)
        {
            goto label_458;
        }
        
        val_512 = (null == null) ? (val_178) : 0;
        goto label_459;
        label_443:
        if((InstanceAnimator.innerRingBalls.Length + 32.gameObject.CompareTag(tag:  "SPD2")) == false)
        {
            goto label_674;
        }
        
        UnityEngine.AudioSource val_182 = GameAudio.sound.PlayOneShot(clip:  this.popClip[2], volume:  val_492);
        val_506 = null;
        val_506 = null;
        UnityEngine.Vector3 val_185 = InstanceAnimator.innerRingBalls.Length + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_186 = UnityEngine.Quaternion.identity;
        val_497 = val_186.x;
        val_498 = val_186.z;
        UnityEngine.GameObject val_187 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimation, position:  new UnityEngine.Vector3() {x = val_185.x, y = val_185.y, z = val_185.z}, rotation:  new UnityEngine.Quaternion() {x = val_497, y = val_186.y, z = val_498, w = val_186.w});
        UnityEngine.Vector3 val_190 = InstanceAnimator.innerRingBalls.Length + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_191 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_192 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_190.x, y = val_190.y, z = val_190.z}, rotation:  new UnityEngine.Quaternion() {x = val_191.x, y = val_191.y, z = val_191.z, w = val_191.w});
        this.popText = val_192;
        val_192.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
        UnityEngine.Vector3 val_199 = InstanceAnimator.innerRingBalls.Length + 32.gameObject.transform.position;
        val_495 = val_199.y;
        this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_199.x, y = val_495, z = val_199.z};
        popScoreScript val_200 = this.popText.GetComponent<popScoreScript>();
        val_507 = val_487;
        val_200.scoreCounter = TargetBallVs.scoreCounter;
        goto label_500;
        label_434:
        if(val_170 != null)
        {
            goto label_501;
        }
        
        label_435:
        val_504 = 0;
        label_436:
        val_168.sprite = val_504;
        val_485 = 1152921505075376128;
        val_508 = InstanceAnimator.innerRingBalls.Length + 32.gameObject;
        val_509 = "SPD1";
        goto label_506;
        label_458:
        val_505 = 0;
        label_459:
        InstanceAnimator.innerRingBalls.Length + 32.gameObject.GetComponentInChildren<UnityEngine.SpriteRenderer>().sprite = val_505;
        val_485 = 1152921505075376128;
        val_508 = InstanceAnimator.innerRingBalls.Length + 32.gameObject;
        val_509 = "SPD2";
        label_506:
        val_508.tag = val_509;
        goto label_674;
        label_94:
        if(this.ballEntry != 1)
        {
            goto label_522;
        }
        
        label_96:
        val_510 = null;
        val_510 = null;
        LineControllerP2.popTagPlayer = this.playerBallTag;
        UnityEngine.Vector3 val_205 = this.gameObject.transform.position;
        UnityEngine.Quaternion val_206 = UnityEngine.Quaternion.identity;
        val_512 = val_205.y;
        val_513 = val_205.z;
        val_514 = val_206.x;
        UnityEngine.GameObject val_207 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = val_205.x, y = val_512, z = val_513}, rotation:  new UnityEngine.Quaternion() {x = val_514, y = val_206.y, z = val_206.z, w = val_206.w});
        val_515 = 1f;
        goto label_521;
        label_95:
        val_494 = this.ballEntry;
        label_97:
        if(val_494 != 1)
        {
            goto label_522;
        }
        
        val_18 = 1;
        UnityEngine.Debug.Log(message:  "Hello  3 " + val_18);
        val_516 = null;
        val_516 = null;
        LineControllerP2.popTagPlayer = this.playerBallTag;
        val_517 = this.popAnimationPlayer;
        val_518 = (float)458 + 28;
        goto label_529;
        label_522:
        val_519 = null;
        val_519 = null;
        LineControllerP2.popTagPlayer = this.playerBallTag;
        val_517 = this.popAnimationPlayer;
        val_518 = 458f;
        label_529:
        float val_210 = val_518 * val_488;
        float val_514 = val_210;
        float val_211 = val_210 * (-3.84f);
        val_20 = 0;
        val_514 = val_514 * 3.84f;
        float val_515 = 0f;
        val_515 = val_514 + val_515;
        UnityEngine.Quaternion val_212 = UnityEngine.Quaternion.identity;
        val_512 = 0f;
        val_513 = 0f;
        val_514 = val_212.x;
        UnityEngine.GameObject val_213 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_517, position:  new UnityEngine.Vector3() {x = 0f, y = val_512, z = val_513}, rotation:  new UnityEngine.Quaternion() {x = val_514, y = val_212.y, z = val_212.z, w = val_212.w});
        label_521:
        UnityEngine.AudioSource val_215 = GameAudio.sound.PlayOneShot(clip:  this.popClip[0], volume:  val_492);
        val_520 = null;
        val_520 = null;
        UnityEngine.Vector3 val_218 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_219 = UnityEngine.Quaternion.identity;
        val_497 = val_219.x;
        val_498 = val_219.z;
        UnityEngine.GameObject val_220 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimation, position:  new UnityEngine.Vector3() {x = val_218.x, y = val_218.y, z = val_218.z}, rotation:  new UnityEngine.Quaternion() {x = val_497, y = val_219.y, z = val_498, w = val_219.w});
        int val_517 = InstanceAnimator.outerRingBalls.Length;
        val_521 = 1f;
        UnityEngine.Object.Destroy(obj:  InstanceAnimator.outerRingBalls.Length + 32.gameObject);
        val_517 = val_517 + 1;
        mem[1152921526382026476] = val_517;
        UnityEngine.Vector3 val_224 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_225 = UnityEngine.Quaternion.identity;
        val_522 = val_225.x;
        UnityEngine.GameObject val_226 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_224.x, y = val_224.y, z = val_224.z}, rotation:  new UnityEngine.Quaternion() {x = val_522, y = val_225.y, z = val_225.z, w = val_225.w});
        this.popText = val_226;
        val_226.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
        UnityEngine.Vector3 val_233 = InstanceAnimator.outerRingBalls.Length + 32.gameObject.transform.position;
        val_495 = val_233.y;
        val_493 = val_233.x;
        val_524 = val_495;
        val_525 = val_233.z;
        this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_493, y = val_524, z = val_525};
        val_526 = null;
        if((this.popText.GetComponent<popScoreScript>()) == null)
        {
                val_526 = null;
        }
        
        val_234.scoreCounter = TargetBallVs.scoreCounter;
        int val_518 = TargetBallVs.scoreCounter;
        val_518 = val_518 + this.chainScore;
        this.chainScore = val_518;
        UnityEngine.PlayerPrefs.SetInt(key:  "Score2", value:  TargetBallVs.scoreCounter + (UnityEngine.PlayerPrefs.GetInt(key:  "Score2")));
        val_487 = val_487;
        val_489 = val_489;
        val_486 = val_486;
        val_481 = val_481;
        val_485 = 1152921505075376128;
        label_84:
        if(val_531 > 12)
        {
            goto label_674;
        }
        
        val_527 = null;
        if((InstanceAnimator.middleRingBalls.Length + 32) == 0)
        {
            goto label_587;
        }
        
        val_528 = null;
        val_528 = null;
        if((System.String.op_Equality(a:  InstanceAnimator.middleRingBalls.Length + 32.tag, b:  val_489)) == false)
        {
            goto label_587;
        }
        
        val_529 = null;
        val_529 = null;
        if((InstanceAnimator.middleRingBalls.Length + 32.gameObject) != val_481.gameObject)
        {
            goto label_610;
        }
        
        if(val_531 == 0)
        {
            goto label_597;
        }
        
        if(val_531 != 12)
        {
            goto label_598;
        }
        
        val_530 = this.ballEntry;
        if(val_530 == 5)
        {
            goto label_599;
        }
        
        goto label_601;
        label_597:
        val_530 = this.ballEntry;
        if(val_530 != 2)
        {
            goto label_601;
        }
        
        label_599:
        val_531 = null;
        val_531 = null;
        LineControllerP2.popTagPlayer = this.playerBallTag;
        UnityEngine.Vector3 val_245 = this.gameObject.transform.position;
        UnityEngine.Quaternion val_246 = UnityEngine.Quaternion.identity;
        val_533 = val_245.y;
        val_534 = val_245.z;
        val_535 = val_246.x;
        UnityEngine.GameObject val_247 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = val_245.x, y = val_533, z = val_534}, rotation:  new UnityEngine.Quaternion() {x = val_535, y = val_246.y, z = val_246.z, w = val_246.w});
        val_536 = 1f;
        goto label_610;
        label_598:
        val_530 = this.ballEntry;
        label_601:
        val_537 = null;
        if(val_530 == 2)
        {
                val_538 = null;
            LineControllerP2.popTagPlayer = this.playerBallTag;
            val_539 = this.popAnimationPlayer;
            float val_519 = (float)val_531 - 1;
            val_519 = val_519 * (-19f);
            val_519 = val_519 + 474f;
            float val_249 = val_519 * val_488;
            val_540 = val_249;
            val_20 = 0;
            val_541 = val_249 * (-2.84f);
        }
        else
        {
                val_542 = null;
            LineControllerP2.popTagPlayer = this.playerBallTag;
            val_539 = this.popAnimationPlayer;
            float val_520 = (float)val_531 + 1;
            float val_251 = val_520 * 19f;
            val_520 = val_251 * val_488;
            val_520 = 474f - val_520;
            val_540 = (474f - val_251) * val_488;
            val_20 = 0;
            val_541 = val_520 * (-2.84f);
        }
        
        val_540 = val_540 * 2.84f;
        float val_521 = 0f;
        val_521 = val_540 + val_521;
        UnityEngine.Quaternion val_253 = UnityEngine.Quaternion.identity;
        val_533 = 0f;
        val_534 = 0f;
        val_535 = val_253.x;
        UnityEngine.GameObject val_254 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_539, position:  new UnityEngine.Vector3() {x = 0f, y = val_533, z = val_534}, rotation:  new UnityEngine.Quaternion() {x = val_535, y = val_253.y, z = val_253.z, w = val_253.w});
        label_610:
        UnityEngine.AudioSource val_256 = GameAudio.sound.PlayOneShot(clip:  this.popClip[0], volume:  val_521);
        val_543 = null;
        val_543 = null;
        UnityEngine.Vector3 val_259 = InstanceAnimator.middleRingBalls.Length + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_260 = UnityEngine.Quaternion.identity;
        val_497 = val_260.x;
        val_498 = val_260.z;
        UnityEngine.GameObject val_261 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_259.x, y = val_259.y, z = val_259.z}, rotation:  new UnityEngine.Quaternion() {x = val_497, y = val_260.y, z = val_498, w = val_260.w});
        this.popText = val_261;
        val_544 = 1f;
        val_261.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
        UnityEngine.Vector3 val_268 = InstanceAnimator.middleRingBalls.Length + 32.gameObject.transform.position;
        this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_268.x, y = val_268.y, z = val_268.z};
        popScoreScript val_269 = this.popText.GetComponent<popScoreScript>();
        val_269.scoreCounter = TargetBallVs.scoreCounter;
        UnityEngine.Vector3 val_272 = InstanceAnimator.middleRingBalls.Length + 32.gameObject.transform.position;
        val_495 = val_272.y;
        UnityEngine.Quaternion val_273 = UnityEngine.Quaternion.identity;
        val_493 = val_272.x;
        val_546 = val_495;
        val_547 = val_272.z;
        val_548 = val_273.x;
        UnityEngine.GameObject val_274 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimation, position:  new UnityEngine.Vector3() {x = val_493, y = val_546, z = val_547}, rotation:  new UnityEngine.Quaternion() {x = val_548, y = val_273.y, z = val_273.z, w = val_273.w});
        val_485 = 1152921505075376128;
        UnityEngine.Object.Destroy(obj:  InstanceAnimator.middleRingBalls.Length + 32.gameObject);
        int val_523 = mem[1152921526382026476];
        val_523 = val_523 + 1;
        mem[1152921526382026476] = val_523;
        int val_524 = TargetBallVs.scoreCounter;
        val_524 = val_524 + this.chainScore;
        this.chainScore = val_524;
        UnityEngine.PlayerPrefs.SetInt(key:  "Score2", value:  TargetBallVs.scoreCounter + (UnityEngine.PlayerPrefs.GetInt(key:  "Score2")));
        val_486 = val_486;
        val_489 = val_489;
        val_487 = val_487;
        val_481 = val_481;
        val_491 = val_491;
        val_490 = 458;
        val_503 = val_482;
        label_587:
        if(val_531 > 8)
        {
            goto label_674;
        }
        
        val_549 = null;
        if((InstanceAnimator.innerRingBalls.Length + 32) == 0)
        {
            goto label_674;
        }
        
        val_550 = null;
        val_550 = null;
        if((System.String.op_Equality(a:  InstanceAnimator.innerRingBalls.Length + 32.tag, b:  val_489)) == false)
        {
            goto label_674;
        }
        
        val_551 = null;
        val_551 = null;
        if((InstanceAnimator.innerRingBalls.Length + 32.gameObject) != val_481.gameObject)
        {
            goto label_697;
        }
        
        if(val_531 == 0)
        {
            goto label_684;
        }
        
        if(val_531 != 8)
        {
            goto label_685;
        }
        
        val_552 = this.ballEntry;
        if(val_552 == 4)
        {
            goto label_686;
        }
        
        goto label_688;
        label_684:
        val_552 = this.ballEntry;
        if(val_552 != 3)
        {
            goto label_688;
        }
        
        label_686:
        val_553 = null;
        val_553 = null;
        LineControllerP2.popTagPlayer = this.playerBallTag;
        UnityEngine.Vector3 val_286 = this.gameObject.transform.position;
        UnityEngine.Quaternion val_287 = UnityEngine.Quaternion.identity;
        val_546 = val_286.y;
        val_547 = val_286.z;
        val_548 = val_287.x;
        UnityEngine.GameObject val_288 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = val_286.x, y = val_546, z = val_547}, rotation:  new UnityEngine.Quaternion() {x = val_548, y = val_287.y, z = val_287.z, w = val_287.w});
        val_544 = 1f;
        goto label_697;
        label_685:
        val_552 = this.ballEntry;
        label_688:
        val_554 = null;
        if(val_552 == 3)
        {
                val_555 = null;
            LineControllerP2.popTagPlayer = this.playerBallTag;
            val_556 = this.popAnimationPlayer;
            float val_525 = (float)val_531 - 1;
            val_525 = val_525 * (-29f);
            val_525 = val_525 + 476f;
            float val_290 = val_525 * val_488;
            val_557 = val_290;
            val_20 = 0;
            val_558 = val_290 * (-1.83f);
        }
        else
        {
                val_559 = null;
            LineControllerP2.popTagPlayer = this.playerBallTag;
            val_556 = this.popAnimationPlayer;
            float val_526 = (float)val_531 + 1;
            float val_292 = val_526 * 29f;
            val_526 = val_292 * val_488;
            val_526 = 476f - val_526;
            val_557 = (476f - val_292) * val_488;
            val_20 = 0;
            val_558 = val_526 * (-1.83f);
        }
        
        val_557 = val_557 * val_493;
        float val_527 = 0f;
        val_527 = val_557 + val_527;
        UnityEngine.Quaternion val_294 = UnityEngine.Quaternion.identity;
        val_546 = 0f;
        val_547 = 0f;
        val_548 = val_294.x;
        UnityEngine.GameObject val_295 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_556, position:  new UnityEngine.Vector3() {x = 0f, y = val_546, z = val_547}, rotation:  new UnityEngine.Quaternion() {x = val_548, y = val_294.y, z = val_294.z, w = val_294.w});
        label_697:
        UnityEngine.AudioSource val_297 = GameAudio.sound.PlayOneShot(clip:  this.popClip[0], volume:  val_544);
        val_560 = null;
        val_560 = null;
        UnityEngine.Vector3 val_300 = InstanceAnimator.innerRingBalls.Length + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_301 = UnityEngine.Quaternion.identity;
        val_497 = val_301.x;
        val_498 = val_301.z;
        UnityEngine.GameObject val_302 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.individualScoreAnimation, position:  new UnityEngine.Vector3() {x = val_300.x, y = val_300.y, z = val_300.z}, rotation:  new UnityEngine.Quaternion() {x = val_497, y = val_301.y, z = val_498, w = val_301.w});
        this.popText = val_302;
        val_302.transform.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
        UnityEngine.Vector3 val_309 = InstanceAnimator.innerRingBalls.Length + 32.gameObject.transform.position;
        this.popText.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_309.x, y = val_309.y, z = val_309.z};
        popScoreScript val_310 = this.popText.GetComponent<popScoreScript>();
        val_310.scoreCounter = TargetBallVs.scoreCounter;
        val_507 = val_487;
        UnityEngine.Vector3 val_313 = InstanceAnimator.innerRingBalls.Length + 32.gameObject.transform.position;
        val_495 = val_313.y;
        UnityEngine.Quaternion val_314 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_315 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimation, position:  new UnityEngine.Vector3() {x = val_313.x, y = val_495, z = val_313.z}, rotation:  new UnityEngine.Quaternion() {x = val_314.x, y = val_314.y, z = val_314.z, w = val_314.w});
        label_500:
        val_485 = 1152921505075376128;
        UnityEngine.Object.Destroy(obj:  InstanceAnimator.innerRingBalls.Length + 32.gameObject);
        int val_529 = mem[1152921526382026476];
        val_529 = val_529 + 1;
        mem[1152921526382026476] = val_529;
        int val_530 = TargetBallVs.scoreCounter;
        val_530 = val_530 + this.chainScore;
        this.chainScore = val_530;
        UnityEngine.PlayerPrefs.SetInt(key:  "Score2", value:  TargetBallVs.scoreCounter + (UnityEngine.PlayerPrefs.GetInt(key:  "Score2")));
        val_486 = val_486;
        val_487 = val_507;
        val_491 = val_491;
        val_490 = val_490;
        val_503 = val_482;
        label_674:
        val_531 = val_531 + 1;
        val_561 = val_490 - 14;
        val_491 = val_491 + 14;
        if(val_531 != 17)
        {
            goto label_748;
        }
        
        val_483 = mem[1152921526382026476];
        val_562 = null;
        val_562 = null;
        LineController.numberOfPops = val_483;
        if(LineController.numberOfPops >= 3)
        {
                val_483 = 1152921505064992768;
            val_563 = null;
            val_563 = null;
            if(Character_GlobalInfo.gameMode != 3)
        {
                val_564 = null;
            val_564 = null;
            this.LogCombo(_hitCount:  LineController.numberOfPops, _type:  0, _technique:  0);
        }
        
            val_565 = null;
            val_565 = null;
            LineController.receiveDamageFlag = true;
        }
        
        val_566 = this.gameObject;
        val_567 = val_566;
        goto label_761;
        label_4:
        val_568 = null;
        val_568 = null;
        this.ballEntry = LineControllerP2.ballEntry;
        this.playerBallTag = this.gameObject.tag;
        return;
        label_44:
        if(this.triggerFlag == false)
        {
                return;
        }
        
        this.gameObject.transform.Find(n:  "TrailNormal").gameObject.SetActive(value:  false);
        this.player2entrytrigger = 0;
        this.triggerFlag = false;
        string val_327 = val_481.gameObject.tag;
        this.popBallTag = val_327;
        TargetBallVs.popTag = val_327;
        val_483 = this.gameObject;
        if((System.String.op_Inequality(a:  val_483.tag, b:  "Iron_Ball")) != false)
        {
                val_20 = 0;
            this.gameObject.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            val_483 = this.gameObject.GetComponent<UnityEngine.CircleCollider2D>();
            val_483.enabled = false;
        }
        
        val_561 = 1152921504858337280;
        val_485 = "Rainbow_Bubble";
        var val_532 = 0;
        goto label_1191;
        label_1174:
        val_569 = null;
        val_569 = null;
        val_483 = mem[InstanceAnimator.innerRingBalls.Length + 96];
        val_483 = InstanceAnimator.innerRingBalls.Length + 96;
        if(val_483 == 0)
        {
            goto label_1158;
        }
        
        val_570 = null;
        val_483 = val_481.gameObject;
        val_570 = null;
        val_571 = mem[InstanceAnimator.innerRingBalls.Length + 96];
        val_571 = InstanceAnimator.innerRingBalls.Length + 96;
        if(val_571 != 0)
        {
            goto label_1062;
        }
        
        goto label_1063;
        label_1191:
        val_572 = this.ballEntry;
        if(val_572 != 1)
        {
            goto label_794;
        }
        
        val_573 = null;
        val_573 = null;
        if((InstanceAnimator.playerOuterRingBalls.Length + 32) == 0)
        {
            goto label_801;
        }
        
        val_574 = null;
        val_574 = null;
        if(val_481.gameObject == (InstanceAnimator.playerOuterRingBalls.Length + 32.gameObject))
        {
            goto label_810;
        }
        
        label_801:
        val_575 = null;
        val_575 = null;
        val_483 = mem[InstanceAnimator.outerRingBalls.Length + 32];
        val_483 = InstanceAnimator.outerRingBalls.Length + 32;
        if(val_483 == 0)
        {
            goto label_826;
        }
        
        val_576 = null;
        val_483 = val_481.gameObject;
        val_576 = null;
        if(val_483 != (InstanceAnimator.outerRingBalls.Length + 32.gameObject))
        {
            goto label_826;
        }
        
        label_810:
        this.flag = 1;
        this.position = 0;
        val_577 = null;
        val_577 = null;
        if((InstanceAnimator.playerOuterRingBalls.Length + 32) == 0)
        {
            goto label_833;
        }
        
        val_578 = null;
        val_578 = null;
        if(val_481.gameObject == (InstanceAnimator.playerOuterRingBalls.Length + 32.gameObject))
        {
            goto label_1113;
        }
        
        label_833:
        val_579 = null;
        val_579 = null;
        val_483 = mem[InstanceAnimator.outerRingBalls.Length + 32];
        val_483 = InstanceAnimator.outerRingBalls.Length + 32;
        if(val_483 == 0)
        {
            goto label_1158;
        }
        
        val_580 = null;
        val_483 = val_481.gameObject;
        val_580 = null;
        if(InstanceAnimator.outerRingBalls != null)
        {
            goto label_1124;
        }
        
        label_1125:
        label_1124:
        val_571 = mem[InstanceAnimator.outerRingBalls.Length + 32];
        val_571 = InstanceAnimator.outerRingBalls.Length + 32;
        if(val_571 != 0)
        {
            goto label_1062;
        }
        
        label_1063:
        label_1062:
        if(val_483 != val_571.gameObject)
        {
            goto label_1158;
        }
        
        val_483 = this.gameObject;
        val_581 = 0;
        if((val_483.CompareTag(tag:  "Rainbow_Bubble")) != false)
        {
                val_483 = val_481.gameObject;
            val_581 = 0;
            if((System.String.op_Inequality(a:  val_483.tag, b:  "SPD")) != false)
        {
                val_483 = val_481.gameObject;
            val_581 = 0;
            if((System.String.op_Inequality(a:  val_483.tag, b:  "SPD1")) != false)
        {
                val_483 = val_481.gameObject;
            val_581 = 0;
            if((System.String.op_Inequality(a:  val_483.tag, b:  "SPD2")) != false)
        {
                val_483 = this.gameObject;
            val_581 = 0;
            val_483.tag = val_481.gameObject.tag;
        }
        
        }
        
        }
        
        }
        
        TargetBallVs.scoreCounter = 99;
        val_582 = null;
        val_582 = null;
        val_583 = 0;
        val_584 = InstanceAnimator.outerRingBalls;
        val_585 = InstanceAnimator.middleRingBalls;
        val_586 = InstanceAnimator.innerRingBalls;
        val_587 = -this.playerNegateX;
        goto label_875;
        label_826:
        val_572 = this.ballEntry;
        label_794:
        if(val_572 != 6)
        {
            goto label_908;
        }
        
        val_588 = null;
        val_588 = null;
        var val_367 = val_532 + 16;
        if((InstanceAnimator.playerOuterRingBalls.Length + 160) == 0)
        {
            goto label_883;
        }
        
        val_589 = null;
        val_589 = null;
        if(val_481.gameObject == (InstanceAnimator.playerOuterRingBalls.Length + 160.gameObject))
        {
            goto label_892;
        }
        
        label_883:
        val_590 = null;
        val_590 = null;
        val_483 = mem[InstanceAnimator.outerRingBalls.Length + 160];
        val_483 = InstanceAnimator.outerRingBalls.Length + 160;
        if(val_483 == 0)
        {
            goto label_908;
        }
        
        val_591 = null;
        val_483 = val_481.gameObject;
        val_591 = null;
        if(val_483 != (InstanceAnimator.outerRingBalls.Length + 160.gameObject))
        {
            goto label_908;
        }
        
        label_892:
        this.flag = 2;
        this.position = val_532 + 16;
        val_592 = null;
        val_592 = null;
        if((InstanceAnimator.playerOuterRingBalls.Length + 160) == 0)
        {
            goto label_915;
        }
        
        val_593 = null;
        val_593 = null;
        if(val_481.gameObject == (InstanceAnimator.playerOuterRingBalls.Length + 160.gameObject))
        {
            goto label_1113;
        }
        
        label_915:
        val_594 = null;
        val_594 = null;
        val_483 = mem[InstanceAnimator.outerRingBalls.Length + 160];
        val_483 = InstanceAnimator.outerRingBalls.Length + 160;
        if(val_483 == 0)
        {
            goto label_1158;
        }
        
        UnityEngine.GameObject val_382 = val_481.gameObject;
        val_595 = null;
        val_595 = null;
        if((InstanceAnimator.outerRingBalls.Length + 160) != 0)
        {
            goto label_1062;
        }
        
        goto label_1063;
        label_908:
        if(0 > 12)
        {
            goto label_1158;
        }
        
        val_596 = this.ballEntry;
        if(val_596 != 2)
        {
            goto label_940;
        }
        
        val_597 = null;
        val_597 = null;
        if((InstanceAnimator.playerMiddleRingBalls.Length + 32) == 0)
        {
            goto label_947;
        }
        
        val_598 = null;
        val_598 = null;
        if(val_481.gameObject == (InstanceAnimator.playerMiddleRingBalls.Length + 32.gameObject))
        {
            goto label_956;
        }
        
        label_947:
        val_599 = null;
        val_599 = null;
        val_483 = mem[InstanceAnimator.middleRingBalls.Length + 32];
        val_483 = InstanceAnimator.middleRingBalls.Length + 32;
        if(val_483 == 0)
        {
            goto label_972;
        }
        
        val_600 = null;
        val_483 = val_481.gameObject;
        val_600 = null;
        if(val_483 != (InstanceAnimator.middleRingBalls.Length + 32.gameObject))
        {
            goto label_972;
        }
        
        label_956:
        this.flag = 3;
        this.position = 0;
        val_601 = null;
        val_601 = null;
        if((InstanceAnimator.playerMiddleRingBalls.Length + 32) == 0)
        {
            goto label_979;
        }
        
        val_602 = null;
        val_602 = null;
        if(val_481.gameObject == (InstanceAnimator.playerMiddleRingBalls.Length + 32.gameObject))
        {
            goto label_1113;
        }
        
        label_979:
        val_603 = null;
        val_603 = null;
        val_483 = mem[InstanceAnimator.middleRingBalls.Length + 32];
        val_483 = InstanceAnimator.middleRingBalls.Length + 32;
        if(val_483 == 0)
        {
            goto label_1158;
        }
        
        UnityEngine.GameObject val_396 = val_481.gameObject;
        val_604 = null;
        val_604 = null;
        if(InstanceAnimator.middleRingBalls != null)
        {
            goto label_1124;
        }
        
        goto label_1125;
        label_972:
        val_596 = this.ballEntry;
        label_940:
        if(val_596 != 5)
        {
            goto label_1033;
        }
        
        val_605 = null;
        val_605 = null;
        if((InstanceAnimator.playerMiddleRingBalls.Length + 128) == 0)
        {
            goto label_1008;
        }
        
        val_606 = null;
        val_606 = null;
        if(val_481.gameObject == (InstanceAnimator.playerMiddleRingBalls.Length + 128.gameObject))
        {
            goto label_1017;
        }
        
        label_1008:
        val_607 = null;
        val_607 = null;
        val_483 = mem[InstanceAnimator.middleRingBalls.Length + 128];
        val_483 = InstanceAnimator.middleRingBalls.Length + 128;
        if(val_483 == 0)
        {
            goto label_1033;
        }
        
        val_608 = null;
        val_483 = val_481.gameObject;
        val_608 = null;
        if(val_483 != (InstanceAnimator.middleRingBalls.Length + 128.gameObject))
        {
            goto label_1033;
        }
        
        label_1017:
        this.flag = 4;
        this.position = val_532 + 12;
        val_609 = null;
        val_609 = null;
        if((InstanceAnimator.playerMiddleRingBalls.Length + 128) == 0)
        {
            goto label_1040;
        }
        
        val_610 = null;
        val_610 = null;
        if(val_481.gameObject == (InstanceAnimator.playerMiddleRingBalls.Length + 128.gameObject))
        {
            goto label_1113;
        }
        
        label_1040:
        val_611 = null;
        val_611 = null;
        val_483 = mem[InstanceAnimator.middleRingBalls.Length + 128];
        val_483 = InstanceAnimator.middleRingBalls.Length + 128;
        if(val_483 == 0)
        {
            goto label_1158;
        }
        
        UnityEngine.GameObject val_411 = val_481.gameObject;
        val_612 = null;
        val_612 = null;
        if((InstanceAnimator.middleRingBalls.Length + 128) != 0)
        {
            goto label_1062;
        }
        
        goto label_1063;
        label_1033:
        if(0 > 8)
        {
            goto label_1158;
        }
        
        val_613 = this.ballEntry;
        if(val_613 != 3)
        {
            goto label_1065;
        }
        
        val_614 = null;
        val_614 = null;
        if((InstanceAnimator.playerInnerRingBalls.Length + 32) == 0)
        {
            goto label_1072;
        }
        
        val_615 = null;
        val_615 = null;
        if(val_481.gameObject == (InstanceAnimator.playerInnerRingBalls.Length + 32.gameObject))
        {
            goto label_1081;
        }
        
        label_1072:
        val_616 = null;
        val_616 = null;
        val_483 = mem[InstanceAnimator.innerRingBalls.Length + 32];
        val_483 = InstanceAnimator.innerRingBalls.Length + 32;
        if(val_483 == 0)
        {
            goto label_1097;
        }
        
        val_617 = null;
        val_483 = val_481.gameObject;
        val_617 = null;
        if(val_483 != (InstanceAnimator.innerRingBalls.Length + 32.gameObject))
        {
            goto label_1097;
        }
        
        label_1081:
        this.flag = 5;
        this.position = 0;
        val_618 = null;
        val_618 = null;
        if((InstanceAnimator.playerInnerRingBalls.Length + 32) == 0)
        {
            goto label_1104;
        }
        
        val_619 = null;
        val_619 = null;
        if(val_481.gameObject == (InstanceAnimator.playerInnerRingBalls.Length + 32.gameObject))
        {
            goto label_1113;
        }
        
        label_1104:
        val_620 = null;
        val_620 = null;
        val_483 = mem[InstanceAnimator.innerRingBalls.Length + 32];
        val_483 = InstanceAnimator.innerRingBalls.Length + 32;
        if(val_483 == 0)
        {
            goto label_1158;
        }
        
        UnityEngine.GameObject val_425 = val_481.gameObject;
        val_621 = null;
        val_621 = null;
        if(InstanceAnimator.innerRingBalls != null)
        {
            goto label_1124;
        }
        
        goto label_1125;
        label_1097:
        val_613 = this.ballEntry;
        label_1065:
        if(val_613 != 4)
        {
            goto label_1158;
        }
        
        val_622 = null;
        val_622 = null;
        if((InstanceAnimator.playerInnerRingBalls.Length + 96) == 0)
        {
            goto label_1133;
        }
        
        val_623 = null;
        val_623 = null;
        if(val_481.gameObject == (InstanceAnimator.playerInnerRingBalls.Length + 96.gameObject))
        {
            goto label_1142;
        }
        
        label_1133:
        val_624 = null;
        val_624 = null;
        val_483 = mem[InstanceAnimator.innerRingBalls.Length + 96];
        val_483 = InstanceAnimator.innerRingBalls.Length + 96;
        if(val_483 == 0)
        {
            goto label_1158;
        }
        
        val_625 = null;
        val_483 = val_481.gameObject;
        val_625 = null;
        if(val_483 != (InstanceAnimator.innerRingBalls.Length + 96.gameObject))
        {
            goto label_1158;
        }
        
        label_1142:
        this.flag = 6;
        this.position = val_532 + 8;
        val_626 = null;
        val_626 = null;
        if((InstanceAnimator.playerInnerRingBalls.Length + 96) == 0)
        {
            goto label_1174;
        }
        
        val_627 = null;
        val_627 = null;
        if(val_481.gameObject != (InstanceAnimator.playerInnerRingBalls.Length + 96.gameObject))
        {
            goto label_1174;
        }
        
        label_1113:
        val_483 = this.gameObject;
        val_628 = 0;
        if((val_483.CompareTag(tag:  "Rainbow_Bubble")) != false)
        {
                val_483 = val_481.gameObject;
            val_628 = 0;
            if((System.String.op_Inequality(a:  val_483.tag, b:  "SPD")) != false)
        {
                val_483 = val_481.gameObject;
            val_628 = 0;
            if((System.String.op_Inequality(a:  val_483.tag, b:  "SPD1")) != false)
        {
                val_483 = val_481.gameObject;
            val_628 = 0;
            if((System.String.op_Inequality(a:  val_483.tag, b:  "SPD2")) != false)
        {
                val_483 = this.gameObject;
            val_628 = 0;
            val_483.tag = val_481.gameObject.tag;
        }
        
        }
        
        }
        
        }
        
        val_629 = null;
        val_629 = null;
        val_587 = this.playerNegateX;
        val_583 = 50;
        val_584 = InstanceAnimator.playerOuterRingBalls;
        val_585 = InstanceAnimator.playerMiddleRingBalls;
        val_586 = InstanceAnimator.playerInnerRingBalls;
        label_875:
        UnityEngine.Coroutine val_454 = this.StartCoroutine(routine:  this.DestroyTarget(outerRingBalls:  val_584, middleRingBalls:  val_585, innerRingBalls:  val_586, negateX:  val_587, incrementCounter:  50));
        label_1158:
        val_532 = val_532 - 1;
        val_486 = 0 + 1;
        if(val_532 != 17)
        {
            goto label_1191;
        }
        
        return;
        label_20:
        val_630 = this.player2entrytrigger;
        if(val_630 != 2)
        {
            goto label_1193;
        }
        
        val_631 = this.ballEntry;
        if(val_631 != 6)
        {
                if(val_631 != 1)
        {
            goto label_1195;
        }
        
        }
        
        val_632 = null;
        val_632 = null;
        if(InstanceAnimator.isOuterRingEmpty == true)
        {
            goto label_1203;
        }
        
        val_631 = this.ballEntry;
        label_1195:
        if(val_631 != 5)
        {
                if(val_631 != 2)
        {
            goto label_1200;
        }
        
        }
        
        val_633 = null;
        val_633 = null;
        if(InstanceAnimator.isMiddleRingEmpty == true)
        {
            goto label_1203;
        }
        
        val_631 = this.ballEntry;
        label_1200:
        val_631 = val_631 - 3;
        if(val_631 > 1)
        {
            goto label_1207;
        }
        
        val_634 = null;
        val_634 = null;
        if(InstanceAnimator.isInnerRingEmpty == false)
        {
            goto label_1207;
        }
        
        label_1203:
        UnityEngine.AudioSource val_456 = GameAudio.sound.PlayOneShot(clip:  this.popClip[0], volume:  1f);
        TargetBallVs.popTag = this.gameObject.tag;
        val_635 = null;
        val_635 = null;
        LineControllerP2.popTagPlayer = this.playerBallTag;
        UnityEngine.Vector3 val_461 = this.gameObject.transform.position;
        UnityEngine.Quaternion val_462 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_463 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = val_461.x, y = val_461.y, z = val_461.z}, rotation:  new UnityEngine.Quaternion() {x = val_462.x, y = val_462.y, z = val_462.z, w = val_462.w});
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        return;
        label_29:
        val_483 = 0;
        goto label_1222;
        label_1207:
        val_630 = this.player2entrytrigger;
        label_1193:
        if(val_630 != 4)
        {
                return;
        }
        
        UnityEngine.AudioSource val_466 = GameAudio.sound.PlayOneShot(clip:  this.popClip[0], volume:  1f);
        TargetBallVs.popTag = this.gameObject.tag;
        val_636 = null;
        val_636 = null;
        LineControllerP2.popTagPlayer = this.playerBallTag;
        val_483 = this.gameObject.transform;
        UnityEngine.Vector3 val_471 = val_483.position;
        val_488 = val_471.x;
        val_495 = val_471.z;
        UnityEngine.Quaternion val_472 = UnityEngine.Quaternion.identity;
        val_497 = val_472.y;
        val_498 = val_472.w;
        UnityEngine.GameObject val_473 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = val_488, y = val_471.y, z = val_495}, rotation:  new UnityEngine.Quaternion() {x = val_472.x, y = val_497, z = val_472.z, w = val_498});
        val_20 = this.player2entrytrigger;
        UnityEngine.Debug.Log(message:  val_20);
        goto label_1240;
        label_1222:
        if(val_20 != 0)
        {
                var val_535 = 0;
            val_535 = val_535 + 1;
            val_20.Dispose();
        }
        
        val_484 = this.player2entrytrigger;
        label_21:
        if(val_484 != 2)
        {
                return;
        }
        
        UnityEngine.AudioSource val_476 = GameAudio.sound.PlayOneShot(clip:  this.popClip[0], volume:  1f);
        TargetBallVs.popTag = this.gameObject.tag;
        val_640 = null;
        val_640 = null;
        LineControllerP2.popTagPlayer = this.playerBallTag;
        val_483 = this.gameObject.transform;
        UnityEngine.Vector3 val_481 = val_483.position;
        val_488 = val_481.x;
        val_495 = val_481.z;
        UnityEngine.Quaternion val_482 = UnityEngine.Quaternion.identity;
        val_497 = val_482.y;
        val_498 = val_482.w;
        UnityEngine.GameObject val_483 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = val_488, y = val_481.y, z = val_495}, rotation:  new UnityEngine.Quaternion() {x = val_482.x, y = val_497, z = val_482.z, w = val_498});
        label_1240:
        label_761:
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private System.Collections.IEnumerator DestroyTarget(UnityEngine.GameObject[] outerRingBalls, UnityEngine.GameObject[] middleRingBalls, UnityEngine.GameObject[] innerRingBalls, int negateX, int incrementCounter)
    {
        TargetBallVs.<DestroyTarget>d__29 val_1 = new TargetBallVs.<DestroyTarget>d__29();
        .<>1__state = 0;
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
            mem[56] = middleRingBalls;
            mem[64] = innerRingBalls;
            mem[48] = negateX;
        }
        
        .incrementCounter = incrementCounter;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator BridgeThroughMiddleRing(UnityEngine.GameObject[] middleRingBalls, int negateX, int incrementCounter)
    {
        TargetBallVs.<BridgeThroughMiddleRing>d__30 val_1 = new TargetBallVs.<BridgeThroughMiddleRing>d__30();
        .<>1__state = 0;
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
        TargetBallVs.<BridgeThroughInnerRing>d__31 val_1 = new TargetBallVs.<BridgeThroughInnerRing>d__31();
        .<>1__state = 0;
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
        TargetBallVs.<BridgeThroughOuterRing>d__32 val_1 = new TargetBallVs.<BridgeThroughOuterRing>d__32();
        .<>1__state = 0;
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
    public TargetBallVs()
    {
    
    }

}
