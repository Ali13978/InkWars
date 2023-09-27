using UnityEngine;
public class LineControllerAI : MonoBehaviour
{
    // Fields
    public UnityEngine.Rigidbody2D[] playerBalls;
    public static UnityEngine.Rigidbody2D CPUBall;
    public float speed;
    public static int ballEntry;
    private bool attackFlag;
    public UnityEngine.GameObject camera_Shake;
    public UnityEngine.GameObject playerChar;
    private string[] playerAnimHolderTako;
    private string[] playerAnimHolderIka;
    public UnityEngine.GameObject textDemo1;
    public UnityEngine.GameObject textDemo2;
    public UnityEngine.GameObject textDemo3;
    public UnityEngine.GameObject textDemo11;
    public UnityEngine.GameObject textDemo22;
    public UnityEngine.GameObject textAreYouReady;
    public UnityEngine.GameObject textGameOn;
    private UnityEngine.GameObject swipedBall;
    public static bool receiveDamageFlag;
    public UnityEngine.GameObject iconCPUActive;
    public UnityEngine.GameObject iconCPUInactive;
    private bool isWaiting;
    private bool stunSequenceFlag;
    public float shake;
    public static int numberOfPops;
    public float shakeAmount;
    public float decreaseFactor;
    public float[] characterSpeedInSecondsStageWise;
    private float characterReloadVariable;
    public float[] cpuAimTimeStageWise;
    private float cpuAimTime;
    private UnityEngine.Vector3 originalPos;
    private float playerStunVariable;
    private float cpuStunTime;
    public UnityEngine.AudioClip[] popClip;
    public UnityEngine.AudioClip electricShock;
    public static string CPUPopTag;
    public UnityEngine.GameObject popAnimationCPU;
    public static bool stunFlag;
    public UnityEngine.GameObject stunnerPop;
    private UnityEngine.GameObject stunnerPopHolder;
    public UnityEngine.UI.Text stunCounter;
    private int angleHandler;
    public UnityEngine.GameObject ExBattleRealDeal;
    public UnityEngine.GameObject ExBattleDoNotGiveUp;
    private int numberOfChains;
    private float angle1;
    private float angle2;
    private float angle3;
    public static int BridgeStunCPU;
    private GameMode modeName;
    private int stageNumber;
    private CharacterClan characterType;
    public CharAnimationController_Physical animController;
    private float stuntime;
    private float iconMaskTime;
    private float reloadTime;
    
    // Methods
    private void Awake()
    {
        var val_12;
        var val_13;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_12 = null;
        if((System.String.op_Equality(a:  val_1.m_Handle.name, b:  "PlaySceneVs")) != false)
        {
                val_12 = null;
            Character_GlobalInfo.gameMode = 5;
        }
        
        val_12 = null;
        this.modeName = Character_GlobalInfo.gameMode;
        if(Character_GlobalInfo.gameMode == 5)
        {
                this.GetComponent<LineControllerP2>().enabled = true;
            this.enabled = false;
        }
        
        val_13 = null;
        val_13 = null;
        if(DataStructs.UserDataDictionary.Settings.FlipNegateX == 1)
        {
                UnityEngine.SceneManagement.Scene val_6 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if((System.String.op_Inequality(a:  val_6.m_Handle.name, b:  "PlaySceneVs")) != false)
        {
                this.stunCounter.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        }
        
        this.swipedBall = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "CanvasChild");
        this.numberOfChains = 0;
    }
    private void Start()
    {
        CharacterClan val_8;
        CharacterNameID val_12;
        var val_25;
        var val_26;
        float val_29;
        UnityEngine.GameObject val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        this.stuntime = 0f;
        val_25 = null;
        val_25 = null;
        var val_1 = (InstanceAnimator.UniversalX == 4.46f) ? 1 : 0;
        this.angle2 = (InstanceAnimator.UniversalX == 4.46f) ? 18.1f : 23f;
        this.angle1 = 40830772 + InstanceAnimator.UniversalX == 4.46f ? 1 : 0;
        this.angle3 = 40830780 + InstanceAnimator.UniversalX == 4.46f ? 1 : 0;
        val_25 = null;
        this.angleHandler = (InstanceAnimator.playerNegateX == 1) ? 0 : 180;
        this.stunCounter.gameObject.SetActive(value:  false);
        this.stageNumber = Character_GlobalInfo.stage_CurrentLevel - 1;
        CharacterInfo val_7 = Character_GlobalInfo.GetOpponentPlayer();
        this.characterType = val_8;
        this.iconCPUActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        val_26 = static_value_032DD328;
        val_26 = static_value_032DD328;
        mem2[0] = 0;
        CharacterInfo val_11 = Character_GlobalInfo.GetMainPlayer();
        this.playerStunVariable = CharacterHelper.GetStunTime(cid:  val_12);
        UnityEngine.Vector3 val_15 = this.playerChar.transform.position;
        this.originalPos = val_15;
        mem[1152921526288605672] = val_15.y;
        mem[1152921526288605676] = val_15.z;
        if(this.modeName == 4)
        {
                val_29 = 0.5f;
        }
        else
        {
                val_29 = this.cpuAimTimeStageWise[this.stageNumber];
        }
        
        this.cpuAimTime = val_29;
        this.stunSequenceFlag = false;
        UnityEngine.SceneManagement.Scene val_16 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_16.m_Handle.name, b:  "DemoScene")) == false)
        {
            goto label_24;
        }
        
        this.textDemo11.SetActive(value:  true);
        this.textDemo22.SetActive(value:  true);
        goto label_36;
        label_24:
        if(this.modeName == 1)
        {
            goto label_28;
        }
        
        if(this.modeName == 4)
        {
            goto label_29;
        }
        
        if(this.modeName != 3)
        {
            goto label_36;
        }
        
        this.textDemo1.SetActive(value:  true);
        this.textDemo2.SetActive(value:  true);
        this.textDemo3.SetActive(value:  true);
        MusicTitlePopup.GameplayStart_FadeOutCalled();
        goto label_36;
        label_28:
        val_30 = this.textAreYouReady;
        if(val_30 != null)
        {
            goto label_39;
        }
        
        goto label_38;
        label_29:
        val_30 = this.ExBattleRealDeal;
        if(val_30 != null)
        {
            goto label_39;
        }
        
        label_38:
        label_39:
        val_30.SetActive(value:  true);
        this.Invoke(methodName:  "SetGameOnActive", time:  1f);
        label_36:
        val_31 = static_value_032DD328;
        val_31 = static_value_032DD328;
        if((static_value_032DD328 + 184) == 0)
        {
                val_32 = null;
            val_32 = null;
            val_12 = 0;
            float val_26 = (float)InstanceAnimator.playerNegateX;
            val_26 = InstanceAnimator.UniversalX * val_26;
            UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.identity;
            val_33 = static_value_032DD328;
            val_33 = static_value_032DD328;
            mem2[0] = UnityEngine.Object.Instantiate<UnityEngine.Rigidbody2D>(original:  this.playerBalls[0], position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w});
            static_value_032DD328 + 184.gameObject.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        
        this.camera_Shake.SetActive(value:  false);
        this.attackFlag = true;
        val_34 = static_value_032DD328;
        val_34 = static_value_032DD328;
        mem2[0] = 0;
        this.isWaiting = false;
        mem2[0] = 0;
        UnityEngine.Coroutine val_24 = this.StartCoroutine(methodName:  "startDefenceSequence");
        this.InvokeRepeating(methodName:  "CPUAI", time:  2f, repeatRate:  0.015f);
    }
    private void SetGameOnActive()
    {
        UnityEngine.GameObject val_1 = this;
        if(this.modeName == 4)
        {
            goto label_1;
        }
        
        if(this.modeName != 1)
        {
            goto label_2;
        }
        
        val_1 = this.textGameOn;
        if(val_1 != null)
        {
            goto label_5;
        }
        
        goto label_4;
        label_1:
        val_1 = this.ExBattleDoNotGiveUp;
        if(val_1 != null)
        {
            goto label_5;
        }
        
        label_4:
        label_5:
        val_1.SetActive(value:  true);
        label_2:
        MusicTitlePopup.GameplayStart_FadeOutCalled();
    }
    private void Update()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(LineController.bossRessurectFlagForCpu == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "bossResurrect");
        val_3 = null;
        val_3 = null;
        LineController.bossRessurectFlagForCpu = false;
    }
    private void CPUAI()
    {
        var val_7;
        var val_9;
        val_7 = null;
        val_7 = null;
        if(LineController.playerLose != false)
        {
                this.PlayerLoseFunction();
            return;
        }
        
        val_7 = null;
        if(LineController.playerWin != false)
        {
                this.PlayerWinFunction();
            return;
        }
        
        if(LineController.stunFlag != false)
        {
                this.StunFunction();
            return;
        }
        
        val_9 = static_value_032DD328;
        val_9 = static_value_032DD328;
        this.ReceiveDamageFunction();
    }
    private System.Collections.IEnumerator CPUAttack()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerAI.<CPUAttack>d__61(<>1__state:  0);
    }
    private bool checkForStopping()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_8 = 0;
        var val_8 = 4;
        label_22:
        if(0 <= 8)
        {
            goto label_1;
        }
        
        if(0 <= 12)
        {
            goto label_2;
        }
        
        goto label_3;
        label_1:
        val_9 = null;
        val_9 = null;
        val_10 = val_8 + (UnityEngine.Object.op_Inequality(x:  InstanceAnimator.playerInnerRingBalls + 32, y:  0));
        label_2:
        val_11 = null;
        val_11 = null;
        val_12 = val_10 + (UnityEngine.Object.op_Inequality(x:  InstanceAnimator.playerMiddleRingBalls + 32, y:  0));
        label_3:
        val_13 = null;
        val_13 = null;
        val_8 = val_8 + 1;
        val_12 = val_12 + (UnityEngine.Object.op_Inequality(x:  InstanceAnimator.playerOuterRingBalls + 32, y:  0));
        if(val_8 != 21)
        {
            goto label_22;
        }
        
        return (bool)(val_12 < true) ? 1 : 0;
    }
    private System.Collections.IEnumerator ActivateCollider()
    {
        return (System.Collections.IEnumerator)new LineControllerAI.<ActivateCollider>d__63(<>1__state:  0);
    }
    private System.Collections.IEnumerator GapTranslate()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerAI.<GapTranslate>d__64(<>1__state:  0);
    }
    private System.Collections.IEnumerator GapTranslationUpperPart(UnityEngine.GameObject[] ringBalls, int mid, float radius, float upperAngle, float angleDiff, int negateX)
    {
        LineControllerAI.<GapTranslationUpperPart>d__65 val_1 = new LineControllerAI.<GapTranslationUpperPart>d__65(<>1__state:  0);
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
        LineControllerAI.<GapTranslationLowerPart>d__66 val_1 = new LineControllerAI.<GapTranslationLowerPart>d__66(<>1__state:  0);
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
    private System.Collections.IEnumerator startDefenceSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerAI.<startDefenceSequence>d__67(<>1__state:  0);
    }
    private System.Collections.IEnumerator PostAttackSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerAI.<PostAttackSequence>d__68(<>1__state:  0);
    }
    private System.Collections.IEnumerator FinishAttack()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerAI.<FinishAttack>d__69(<>1__state:  0);
    }
    private void ShakeSequenceAnimationCPU()
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
    private void CalculateBallEntryUp(UnityEngine.GameObject[] ringArray, int arrayLength)
    {
        string val_8;
        var val_9;
        var val_10;
        var val_11;
        if(arrayLength < 1)
        {
                return;
        }
        
        var val_8 = 0;
        label_7:
        if(1152921508657404416 != 0)
        {
            goto label_6;
        }
        
        val_8 = val_8 + 1;
        if(val_8 < (long)arrayLength)
        {
            goto label_7;
        }
        
        return;
        label_6:
        val_9 = static_value_032DD328;
        val_9 = static_value_032DD328;
        val_8 = static_value_032DD328 + 184.gameObject.tag;
        if((1152921508657404416.gameObject.CompareTag(tag:  val_8)) != true)
        {
                val_10 = static_value_032DD328;
            val_10 = static_value_032DD328;
            if((static_value_032DD328 + 184.gameObject.CompareTag(tag:  "Rainbow_Bubble")) == false)
        {
                return;
        }
        
        }
        
        val_11 = static_value_032DD328;
        val_11 = static_value_032DD328;
        mem2[0] = arrayLength;
    }
    private void CalculateBallEntryDown(UnityEngine.GameObject[] ringArray, int arrayLength)
    {
        string val_9;
        var val_10;
        var val_11;
        var val_12;
        int val_9 = arrayLength;
        do
        {
            val_9 = val_9 - 1;
            if((val_9 & 2147483648) != 0)
        {
                return;
        }
        
            ringArray[arrayLength - 1][40] = (ringArray[arrayLength - 1][40]) - 8;
        }
        while(1152921508657404416 == 0);
        
        val_10 = static_value_032DD328;
        val_10 = static_value_032DD328;
        val_9 = static_value_032DD328 + 184.gameObject.tag;
        if((1152921508657404416.gameObject.CompareTag(tag:  val_9)) != true)
        {
                val_11 = static_value_032DD328;
            val_11 = static_value_032DD328;
            if((static_value_032DD328 + 184.gameObject.CompareTag(tag:  "Rainbow_Bubble")) == false)
        {
                return;
        }
        
        }
        
        val_12 = static_value_032DD328;
        val_12 = static_value_032DD328;
        mem2[0] = arrayLength;
    }
    private System.Collections.IEnumerator IconMask()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerAI.<IconMask>d__73(<>1__state:  0);
    }
    private System.Collections.IEnumerator StunSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerAI.<StunSequence>d__74(<>1__state:  0);
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
        return (System.Collections.IEnumerator)new LineControllerAI.<PopSequenceStun>d__76(<>1__state:  0);
    }
    private System.Collections.IEnumerator DestroyBall()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerAI.<DestroyBall>d__77(<>1__state:  0);
    }
    private System.Collections.IEnumerator bossResurrect()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerAI.<bossResurrect>d__78(<>1__state:  0);
    }
    private System.Collections.IEnumerator StunOpponent()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerAI.<StunOpponent>d__79(<>1__state:  0);
    }
    private void PlayerLoseFunction()
    {
        var val_8;
        int val_9;
        var val_10;
        var val_11;
        this.CancelInvoke(methodName:  "ShakeSequenceAnimationCPU");
        this.animController.PlayAnimation(newAnimName:  8, forceOverride:  true);
        this.iconCPUActive.SetActive(value:  true);
        this.CancelInvoke(methodName:  "CPUAI");
        this.CancelInvoke(methodName:  "StunSequenceAnimation");
        this.StopCoroutine(methodName:  "StunSequence");
        this.StopCoroutine(methodName:  "StunOpponent");
        this.StopCoroutine(methodName:  "PopSequenceStun");
        this.StopCoroutine(methodName:  "CPUAttack");
        this.StopCoroutine(methodName:  "IconMask");
        this.stunCounter.gameObject.SetActive(value:  false);
        UnityEngine.Color val_2 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.animController.image_Body.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        this.animController.pause = false;
        this.playerChar.transform.position = new UnityEngine.Vector3() {x = this.originalPos, y = val_2.g, z = val_2.b};
        this.animController.PlayAnimation(newAnimName:  8, forceOverride:  false);
        val_8 = null;
        val_8 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = DataStructs.UserDataDictionary.Stats.Maximum_Chains;
        val_9 = val_4.fakeValue;
        if(this.numberOfChains > (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_9, inited = val_4.inited})))
        {
                val_10 = null;
            val_10 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  this.numberOfChains);
            val_9 = val_6.currentCryptoKey;
            DataStructs.UserDataDictionary.Stats.Maximum_Chains = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_9, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited};
        }
        
        UnityEngine.Coroutine val_7 = this.StartCoroutine(methodName:  "PlayerLose");
        val_11 = null;
        val_11 = null;
        LineController.playerLose = false;
    }
    private System.Collections.IEnumerator PlayerLose()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LineControllerAI.<PlayerLose>d__81(<>1__state:  0);
    }
    private void PlayerWinFunction()
    {
        var val_16;
        var val_17;
        CharAnimationController_Physical val_18;
        var val_19;
        var val_20;
        var val_21;
        int val_22;
        var val_23;
        var val_24;
        this.CancelInvoke();
        this.iconCPUActive.SetActive(value:  true);
        this.StopAllCoroutines();
        val_16 = static_value_032DD328;
        val_16 = static_value_032DD328;
        if((static_value_032DD328 + 184) != 0)
        {
                val_17 = static_value_032DD328;
            val_17 = static_value_032DD328;
            UnityEngine.Object.Destroy(obj:  static_value_032DD328 + 184.gameObject);
        }
        
        if(this.stunnerPopHolder != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.stunnerPopHolder.gameObject);
        }
        
        this.stunCounter.gameObject.SetActive(value:  false);
        UnityEngine.Color val_6 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.animController.image_Body.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
        this.animController.pause = false;
        this.playerChar.transform.position = new UnityEngine.Vector3() {x = this.originalPos, y = val_6.g, z = val_6.b};
        this.iconCPUActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        UnityEngine.SceneManagement.Scene val_10 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_10.m_Handle.name, b:  "DemoScene")) != false)
        {
                val_18 = this.animController;
            val_19 = 8;
        }
        else
        {
                val_20 = null;
            val_20 = null;
            VoiceManager.instance.PlayAttackSound(Left:  0, SoundType:  3, modifiers:  0);
            val_18 = this.animController;
            val_19 = 9;
        }
        
        val_18.PlayAnimation(newAnimName:  9, forceOverride:  false);
        val_21 = null;
        val_21 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_13 = DataStructs.UserDataDictionary.Stats.Maximum_Chains;
        val_22 = val_13.fakeValue;
        if(this.numberOfChains > (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_13.currentCryptoKey, hiddenValue = val_13.hiddenValue, fakeValue = val_22, inited = val_13.inited})))
        {
                val_23 = null;
            val_23 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_15 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  this.numberOfChains);
            val_22 = val_15.fakeValue;
            DataStructs.UserDataDictionary.Stats.Maximum_Chains = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_15.currentCryptoKey, hiddenValue = val_15.hiddenValue, fakeValue = val_22, inited = val_15.inited};
        }
        
        val_24 = null;
        val_24 = null;
        LineController.playerWin = false;
    }
    private void ReceiveDamageFunction()
    {
        var val_9;
        float val_10;
        var val_11;
        var val_12;
        val_9 = this;
        this.StopCoroutine(methodName:  "CPUAttack");
        this.StopCoroutine(methodName:  "PostAttackSequence");
        UnityEngine.Color val_1 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_10 = val_1.b;
        this.animController.image_Body.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_10, a = val_1.a};
        val_11 = static_value_032DD328;
        val_11 = static_value_032DD328;
        val_12 = mem[static_value_032DD328 + 184];
        val_12 = static_value_032DD328 + 184;
        var val_9 = 40844988 + (static_value_032DD328 + 184 + 36) << 2;
        val_9 = val_9 + 40844988;
        goto (40844988 + (static_value_032DD328 + 184 + 36) << 2 + 40844988);
    }
    private void StunFunction()
    {
        var val_4;
        this.CancelInvoke();
        this.StopCoroutine(methodName:  "CPUAttack");
        this.StopCoroutine(methodName:  "PostAttackSequence");
        this.StopCoroutine(methodName:  "StunSequence");
        this.InvokeRepeating(methodName:  "CPUAI", time:  0f, repeatRate:  0.015f);
        UnityEngine.Color val_1 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.animController.image_Body.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        this.animController.pause = false;
        this.playerChar.transform.position = new UnityEngine.Vector3() {x = this.originalPos, y = val_1.g, z = val_1.b};
        this.stunSequenceFlag = false;
        this.shake = 0f;
        this.iconCPUActive.SetActive(value:  false);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(methodName:  "StunSequence");
        val_4 = null;
        val_4 = null;
        LineController.stunFlag = false;
    }
    internal void SetIconCPUActive(UnityEngine.Sprite sprite)
    {
        if(sprite == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "Attempt to set null sprite");
            return;
        }
        
        this.iconCPUActive.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = sprite;
        UnityEngine.Color val_6 = UnityEngine.Color.white;
        this.iconCPUActive.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
    }
    internal void SetIconCPUInactive(UnityEngine.Sprite sprite)
    {
        if(sprite == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "Attempt to set null sprite");
            return;
        }
        
        this.iconCPUInactive.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = sprite;
        UnityEngine.Color val_6 = UnityEngine.Color.white;
        this.iconCPUInactive.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
    }
    public LineControllerAI()
    {
        this.shakeAmount = 0.1f;
        this.decreaseFactor = 1f;
    }
    private static LineControllerAI()
    {
    
    }

}
