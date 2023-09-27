using UnityEngine;
public class BallSwipeCPU : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject[] playerBalls;
    private UnityEngine.GameObject swiper;
    public static bool flag;
    private int count;
    private int ballEntry;
    private string ballTag;
    private string ballTagColor;
    private int entryFlag;
    private int rainbowFrequency;
    private int rainbowCounter;
    public int[] characterRainbowPercentageStageWise;
    private int edgeColorCounter;
    private int uniqueColorCounter;
    private int notEdgeColorCounter;
    private string[] edgeColorTag;
    private string[] uniqueColorTag;
    private string[] notEdgeColorTag;
    public float[] secondaryAttackPercentStageWise;
    private float secondaryAttackFrequency;
    private int secondaryAttackFrequencyCounter;
    private bool specialBallFlag;
    public UnityEngine.GameObject popSwipeBalls;
    public UnityEngine.AudioClip ballSwipeClip;
    public UnityEngine.UI.Image bubbleSwitcher;
    
    // Methods
    private void Awake()
    {
        var val_8;
        var val_9;
        val_8 = this;
        val_9 = null;
        val_9 = null;
        if(Character_GlobalInfo.gameMode == 3)
        {
                this.gameObject.GetComponent<BallSwipeCPU>().enabled = false;
        }
        
        UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_3.m_Handle.name, b:  "PlaySceneVs")) == false)
        {
                return;
        }
        
        val_8 = this.gameObject.GetComponent<BallSwipeCPU>();
        val_8.enabled = false;
    }
    public void Start()
    {
        var val_5;
        var val_28;
        int val_29;
        CharacterClan val_30;
        var val_31;
        this.specialBallFlag = false;
        this.ballTag = "";
        this.ballTagColor = "";
        this.edgeColorTag = new string[6];
        this.uniqueColorTag = new string[6];
        this.notEdgeColorTag = new string[6];
        val_28 = null;
        val_28 = null;
        if(Character_GlobalInfo.gameMode != 4)
        {
            goto label_3;
        }
        
        CharacterInfo val_4 = Character_GlobalInfo.GetMainPlayer();
        if(val_5 != 1)
        {
            goto label_6;
        }
        
        this.rainbowFrequency = CharacterHelper.GetRainbowPercentageLevel(cid:  CharacterHelper.GetStageCPUCharacterId(levelId0to11:  Character_GlobalInfo.stage_CurrentLevel - 1, CPUClan:  1));
        val_29 = Character_GlobalInfo.stage_CurrentLevel - 1;
        val_30 = 0;
        goto label_11;
        label_3:
        this.rainbowFrequency = this.characterRainbowPercentageStageWise[(long)Character_GlobalInfo.stage_CurrentLevel - 1];
        float val_29 = this.secondaryAttackPercentStageWise[(long)Character_GlobalInfo.stage_CurrentLevel - 1];
        goto label_18;
        label_6:
        this.rainbowFrequency = CharacterHelper.GetRainbowPercentageLevel(cid:  CharacterHelper.GetStageCPUCharacterId(levelId0to11:  Character_GlobalInfo.stage_CurrentLevel - 1, CPUClan:  0));
        val_29 = Character_GlobalInfo.stage_CurrentLevel - 1;
        val_30 = 1;
        label_11:
        label_18:
        this.secondaryAttackFrequency = CharacterHelper.GetSecondaryAttackPercent(cid:  CharacterHelper.GetStageCPUCharacterId(levelId0to11:  val_29, CPUClan:  val_30));
        if(this.rainbowFrequency == 2)
        {
            goto label_23;
        }
        
        if(this.rainbowFrequency != 1)
        {
            goto label_24;
        }
        
        UnityEngine.Debug.Log(message:  "+++++++++++++++++++++++"("+++++++++++++++++++++++") + 1);
        ballSwipeScript val_23 = this.GetComponent<ballSwipeScript>();
        if(this.bubbleSwitcher != null)
        {
            goto label_46;
        }
        
        label_47:
        label_46:
        this.bubbleSwitcher.sprite = val_23.switcherSprites[0];
        this.rainbowCounter = 0;
        BallSwipeCPU.flag = true;
        this.count = 0;
        this.ballTag = "";
        this.ballTagColor = "";
        UnityEngine.Coroutine val_25 = this.StartCoroutine(routine:  this.InstantiateOnStart());
        val_31 = null;
        val_31 = null;
        if(Character_GlobalInfo.gameMode != 4)
        {
                return;
        }
        
        this.InvokeRepeating(methodName:  "CountBalls", time:  5f, repeatRate:  2f);
        return;
        label_23:
        ballSwipeScript val_26 = this.GetComponent<ballSwipeScript>();
        UnityEngine.Sprite val_31 = val_26.switcherSprites[1];
        if(this.bubbleSwitcher != null)
        {
            goto label_46;
        }
        
        goto label_47;
        label_24:
        ballSwipeScript val_27 = this.GetComponent<ballSwipeScript>();
        if(this.rainbowFrequency != 3)
        {
            goto label_41;
        }
        
        UnityEngine.Sprite val_32 = val_27.switcherSprites[2];
        if(this.bubbleSwitcher != null)
        {
            goto label_46;
        }
        
        goto label_47;
        label_41:
        UnityEngine.Sprite val_33 = val_27.switcherSprites[3];
        if(this.bubbleSwitcher != null)
        {
            goto label_46;
        }
        
        goto label_47;
    }
    private void CountBalls()
    {
        var val_4;
        var val_5;
        var val_6;
        this.count = 0;
        var val_8 = 4;
        do
        {
            val_4 = null;
            val_4 = null;
            var val_1 = val_8 - 4;
            if((InstanceAnimator.outerRingBalls + 32) != 0)
        {
                int val_5 = this.count;
            val_5 = val_5 + 1;
            this.count = val_5;
        }
        
            if(val_1 <= 12)
        {
                val_5 = null;
            val_5 = null;
            if((InstanceAnimator.middleRingBalls + 32) != 0)
        {
                int val_6 = this.count;
            val_6 = val_6 + 1;
            this.count = val_6;
        }
        
            if(val_1 <= 8)
        {
                val_6 = null;
            val_6 = null;
            if((InstanceAnimator.innerRingBalls + 32) != 0)
        {
                int val_7 = this.count;
            val_7 = val_7 + 1;
            this.count = val_7;
        }
        
        }
        
        }
        
            val_8 = val_8 + 1;
        }
        while(val_8 != 21);
        
        if(this.count > 19)
        {
                return;
        }
        
        this.specialBallFlag = true;
        this.CancelInvoke(methodName:  "CountBalls");
    }
    public System.Collections.IEnumerator InstantiateOnStart()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new BallSwipeCPU.<InstantiateOnStart>d__27();
    }
    public void SwipeBall()
    {
        if(BallSwipeCPU.flag == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.playerBalls[0].gameObject.transform.position;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector3 val_7 = this.playerBalls[1].gameObject.transform.position;
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Vector3 val_11 = this.playerBalls[0].gameObject.transform.localScale;
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        UnityEngine.Vector3 val_15 = this.playerBalls[1].gameObject.transform.localScale;
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        UnityEngine.Coroutine val_18 = this.StartCoroutine(routine:  this.BallSwapWithNewBall(pos1:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, pos2:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, size1:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, size2:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}));
    }
    public void OnButtonDown()
    {
        GameAudio.PlayBubbleSwitchSound();
        if(BallSwipeCPU.flag == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.playerBalls[0].gameObject.transform.position;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector3 val_7 = this.playerBalls[1].gameObject.transform.position;
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Vector3 val_11 = this.playerBalls[0].gameObject.transform.localScale;
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        UnityEngine.Vector3 val_15 = this.playerBalls[1].gameObject.transform.localScale;
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        UnityEngine.Coroutine val_18 = this.StartCoroutine(routine:  this.BallSwap(pos1:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, pos2:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, size1:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, size2:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}));
    }
    private System.Collections.IEnumerator BallSwap(UnityEngine.Vector2 pos1, UnityEngine.Vector2 pos2, UnityEngine.Vector2 size1, UnityEngine.Vector2 size2)
    {
        BallSwipeCPU.<BallSwap>d__30 val_1 = new BallSwipeCPU.<BallSwap>d__30();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .pos1 = pos1;
            mem[1152921526213779132] = pos1.y;
            .pos2 = pos2;
            mem[1152921526213779140] = pos2.y;
            .size1 = size1;
            mem[1152921526213779148] = size1.y;
        }
        else
        {
                mem[32] = this;
            mem[40] = pos1.x;
            mem[1152921526213779132] = pos1.y;
            mem[48] = pos2.x;
            mem[1152921526213779140] = pos2.y;
            mem[56] = size1.x;
            mem[1152921526213779148] = size1.y;
        }
        
        .size2 = size2;
        mem[1152921526213779156] = size2.y;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator BallSwapWithNewBall(UnityEngine.Vector2 pos1, UnityEngine.Vector2 pos2, UnityEngine.Vector2 size1, UnityEngine.Vector2 size2)
    {
        BallSwipeCPU.<BallSwapWithNewBall>d__31 val_1 = new BallSwipeCPU.<BallSwapWithNewBall>d__31();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .pos1 = pos1;
            mem[1152921526213899324] = pos1.y;
            .pos2 = pos2;
            mem[1152921526213899332] = pos2.y;
            .size1 = size1;
            mem[1152921526213899340] = size1.y;
        }
        else
        {
                mem[32] = this;
            mem[40] = pos1.x;
            mem[1152921526213899324] = pos1.y;
            mem[48] = pos2.x;
            mem[1152921526213899332] = pos2.y;
            mem[56] = size1.x;
            mem[1152921526213899340] = size1.y;
        }
        
        .size2 = size2;
        mem[1152921526213899348] = size2.y;
        return (System.Collections.IEnumerator)val_1;
    }
    private void chooseBallColorTag()
    {
        var val_12;
        var val_13;
        int val_17;
        System.String[] val_18;
        System.String[] val_19;
        int val_20;
        var val_21;
        System.String[] val_22;
        string val_23;
        this.uniqueColorCounter = 0;
        val_12 = null;
        val_12 = null;
        this.CalculateUniqueColors(ringArrayOuter:  InstanceAnimator.playerOuterRingBalls, ringArrayMiddle:  InstanceAnimator.playerMiddleRingBalls, ringArrayInner:  InstanceAnimator.playerInnerRingBalls);
        this.edgeColorCounter = 0;
        val_13 = null;
        if(InstanceAnimator.isOuterRingEmpty != true)
        {
                this.CalculateEdgeColorUp(ringArray:  InstanceAnimator.playerOuterRingBalls, arrayLength:  17);
            this.CalculateEdgeColorDown(ringArray:  InstanceAnimator.playerOuterRingBalls, arrayLength:  17);
            val_13 = null;
        }
        
        val_13 = null;
        if(InstanceAnimator.isMiddleRingEmpty != true)
        {
                this.CalculateEdgeColorUp(ringArray:  InstanceAnimator.playerMiddleRingBalls, arrayLength:  13);
            this.CalculateEdgeColorDown(ringArray:  InstanceAnimator.playerMiddleRingBalls, arrayLength:  13);
            val_13 = null;
        }
        
        val_13 = null;
        if(InstanceAnimator.isInnerRingEmpty != true)
        {
                this.CalculateEdgeColorUp(ringArray:  InstanceAnimator.playerInnerRingBalls, arrayLength:  9);
            this.CalculateEdgeColorDown(ringArray:  InstanceAnimator.playerInnerRingBalls, arrayLength:  9);
        }
        
        val_17 = this.edgeColorCounter;
        this.notEdgeColorCounter = 0;
        if(val_17 == 0)
        {
                val_19 = this.edgeColorTag;
            val_18 = this.uniqueColorTag;
            if(this.uniqueColorCounter >= 1)
        {
                val_19[0] = val_18[(long)UnityEngine.Random.Range(min:  0, max:  this.uniqueColorCounter)];
        }
        else
        {
                val_18[0] = "Red";
            val_19[0] = "Red";
            int val_13 = this.uniqueColorCounter;
            val_13 = val_13 + 1;
            this.uniqueColorCounter = val_13;
        }
        
            val_17 = this.edgeColorCounter + 1;
            this.edgeColorCounter = val_17;
        }
        
        if(this.uniqueColorCounter < 1)
        {
            goto label_33;
        }
        
        goto label_34;
        label_50:
        val_17 = this.edgeColorCounter;
        label_34:
        if(val_17 < 1)
        {
            goto label_35;
        }
        
        val_20 = 0;
        label_41:
        if((System.String.op_Equality(a:  this.uniqueColorTag[val_20], b:  this.edgeColorTag[0])) == true)
        {
            goto label_40;
        }
        
        val_18 = 0 + 1;
        if(val_18 < this.edgeColorCounter)
        {
            goto label_41;
        }
        
        label_35:
        val_20 = this.notEdgeColorCounter;
        string val_16 = this.uniqueColorTag[0];
        if(this.notEdgeColorTag == null)
        {
            goto label_44;
        }
        
        if(val_16 != null)
        {
            goto label_45;
        }
        
        goto label_48;
        label_44:
        if(val_16 == null)
        {
            goto label_48;
        }
        
        label_45:
        label_48:
        this.notEdgeColorTag[val_20] = val_16;
        int val_17 = this.notEdgeColorCounter;
        val_17 = val_17 + 1;
        this.notEdgeColorCounter = val_17;
        label_40:
        val_19 = 0 + 1;
        if(val_19 < this.uniqueColorCounter)
        {
            goto label_50;
        }
        
        label_33:
        if(this.notEdgeColorCounter <= 0)
        {
                this.notEdgeColorCounter = 1;
            this.notEdgeColorTag[0] = this.uniqueColorTag[0];
        }
        
        this.secondaryAttackFrequencyCounter = UnityEngine.Random.Range(min:  1, max:  101);
        if(this.secondaryAttackFrequency < 0)
        {
                val_21 = 0;
            int val_4 = UnityEngine.Random.Range(min:  0, max:  this.notEdgeColorCounter);
            val_22 = this.notEdgeColorTag;
        }
        else
        {
                val_21 = 0;
            val_22 = this.edgeColorTag;
        }
        
        this.ballTag = null;
        if((System.String.op_Equality(a:  1152921505361394112, b:  "Blue")) != false)
        {
                val_23 = "B";
        }
        else
        {
                if((System.String.op_Equality(a:  1152921505361394112, b:  "Green")) != false)
        {
                val_23 = "G";
        }
        else
        {
                if((System.String.op_Equality(a:  1152921505361394112, b:  "Red")) != false)
        {
                val_23 = "R";
        }
        else
        {
                if((System.String.op_Equality(a:  1152921505361394112, b:  "Yellow")) != false)
        {
                val_23 = "Y";
        }
        else
        {
                if((System.String.op_Equality(a:  1152921505361394112, b:  "Orange")) != false)
        {
                val_23 = "O";
        }
        else
        {
                if((System.String.op_Equality(a:  1152921505361394112, b:  "Purple")) == false)
        {
                return;
        }
        
            val_23 = "P";
        }
        
        }
        
        }
        
        }
        
        }
        
        this.ballTagColor = val_23;
    }
    private void CalculateUniqueColors(UnityEngine.GameObject[] ringArrayOuter, UnityEngine.GameObject[] ringArrayMiddle, UnityEngine.GameObject[] ringArrayInner)
    {
        var val_52;
        UnityEngine.GameObject val_53;
        int val_54;
        System.String[] val_55;
        int val_56;
        int val_57;
        val_52 = 1152921504858337280;
        var val_58 = 0;
        label_126:
        val_53 = ringArrayOuter[val_58];
        if(val_53 == 0)
        {
            goto label_26;
        }
        
        val_53 = ringArrayOuter[0x0] + 32.gameObject;
        if((System.String.op_Inequality(a:  val_53.tag, b:  "SPD")) == false)
        {
            goto label_26;
        }
        
        val_53 = ringArrayOuter[0x0] + 32.gameObject;
        if((System.String.op_Inequality(a:  val_53.tag, b:  "SPD1")) == false)
        {
            goto label_26;
        }
        
        val_53 = ringArrayOuter[0x0] + 32.gameObject;
        if((System.String.op_Inequality(a:  val_53.tag, b:  "SPD2")) == false)
        {
            goto label_26;
        }
        
        val_54 = this.uniqueColorCounter;
        if(val_54 == 0)
        {
            goto label_18;
        }
        
        if(val_54 < 1)
        {
            goto label_19;
        }
        
        var val_52 = 0;
        do
        {
            val_53 = this.uniqueColorTag[0];
            val_54 = this.uniqueColorCounter;
            val_52 = val_52 + 1;
            val_55 = 0 | (System.String.op_Equality(a:  val_53, b:  ringArrayOuter[0x0] + 32.gameObject.tag));
        }
        while(val_52 < val_54);
        
        val_52 = 1152921504858337280;
        if(val_55 == true)
        {
            goto label_26;
        }
        
        label_19:
        val_55 = this.uniqueColorTag;
        val_53 = ringArrayOuter[0x0] + 32.gameObject.tag;
        val_55[(long)val_54] = val_53;
        goto label_34;
        label_18:
        val_53 = ringArrayOuter[0x0] + 32.gameObject.tag;
        this.uniqueColorTag[0] = val_53;
        label_34:
        int val_53 = this.uniqueColorCounter;
        val_53 = val_53 + 1;
        this.uniqueColorCounter = val_53;
        label_26:
        if(val_58 > 12)
        {
            goto label_110;
        }
        
        val_53 = ringArrayMiddle[val_58];
        if(val_53 == 0)
        {
            goto label_68;
        }
        
        val_53 = ringArrayMiddle[0x0] + 32.gameObject;
        if((System.String.op_Inequality(a:  val_53.tag, b:  "SPD")) == false)
        {
            goto label_68;
        }
        
        val_53 = ringArrayMiddle[0x0] + 32.gameObject;
        if((System.String.op_Inequality(a:  val_53.tag, b:  "SPD1")) == false)
        {
            goto label_68;
        }
        
        val_53 = ringArrayMiddle[0x0] + 32.gameObject;
        if((System.String.op_Inequality(a:  val_53.tag, b:  "SPD2")) == false)
        {
            goto label_68;
        }
        
        val_56 = this.uniqueColorCounter;
        if(val_56 == 0)
        {
            goto label_60;
        }
        
        if(val_56 < 1)
        {
            goto label_61;
        }
        
        var val_54 = 0;
        do
        {
            val_53 = this.uniqueColorTag[0];
            val_56 = this.uniqueColorCounter;
            val_54 = val_54 + 1;
            val_55 = 0 | (System.String.op_Equality(a:  val_53, b:  ringArrayMiddle[0x0] + 32.gameObject.tag));
        }
        while(val_54 < val_56);
        
        val_52 = 1152921504858337280;
        if(val_55 == true)
        {
            goto label_68;
        }
        
        label_61:
        val_55 = this.uniqueColorTag;
        val_53 = ringArrayMiddle[0x0] + 32.gameObject.tag;
        val_55[(long)val_56] = val_53;
        goto label_76;
        label_60:
        val_53 = ringArrayMiddle[0x0] + 32.gameObject.tag;
        this.uniqueColorTag[0] = val_53;
        label_76:
        int val_55 = this.uniqueColorCounter;
        val_55 = val_55 + 1;
        this.uniqueColorCounter = val_55;
        label_68:
        if(val_58 > 8)
        {
            goto label_110;
        }
        
        val_53 = ringArrayInner[val_58];
        if(val_53 == 0)
        {
            goto label_110;
        }
        
        val_53 = ringArrayInner[0x0] + 32.gameObject;
        if((System.String.op_Inequality(a:  val_53.tag, b:  "SPD")) == false)
        {
            goto label_110;
        }
        
        val_53 = ringArrayInner[0x0] + 32.gameObject;
        if((System.String.op_Inequality(a:  val_53.tag, b:  "SPD1")) == false)
        {
            goto label_110;
        }
        
        val_53 = ringArrayInner[0x0] + 32.gameObject;
        if((System.String.op_Inequality(a:  val_53.tag, b:  "SPD2")) == false)
        {
            goto label_110;
        }
        
        val_57 = this.uniqueColorCounter;
        if(val_57 == 0)
        {
            goto label_102;
        }
        
        if(val_57 < 1)
        {
            goto label_103;
        }
        
        var val_56 = 0;
        do
        {
            val_53 = this.uniqueColorTag[0];
            val_57 = this.uniqueColorCounter;
            val_56 = val_56 + 1;
            val_55 = 0 | (System.String.op_Equality(a:  val_53, b:  ringArrayInner[0x0] + 32.gameObject.tag));
        }
        while(val_56 < val_57);
        
        if(val_55 == true)
        {
            goto label_110;
        }
        
        label_103:
        val_55 = this.uniqueColorTag;
        val_53 = ringArrayInner[0x0] + 32.gameObject.tag;
        val_55[(long)val_57] = val_53;
        goto label_118;
        label_102:
        val_53 = ringArrayInner[0x0] + 32.gameObject.tag;
        this.uniqueColorTag[0] = val_53;
        label_118:
        int val_57 = this.uniqueColorCounter;
        val_57 = val_57 + 1;
        this.uniqueColorCounter = val_57;
        label_110:
        val_58 = val_58 + 1;
        if(val_58 != 17)
        {
            goto label_126;
        }
    
    }
    private void CalculateEdgeColorDown(UnityEngine.GameObject[] ringArray, int arrayLength)
    {
        UnityEngine.GameObject val_19;
        int val_20;
        val_19 = arrayLength;
        int val_1 = val_19 - 1;
        if((val_1 & 2147483648) != 0)
        {
                return;
        }
        
        var val_22 = (long)val_1;
        label_19:
        val_19 = ringArray[val_22];
        if(val_19 == 0)
        {
            goto label_14;
        }
        
        val_19 = ringArray[val_22].gameObject;
        if((System.String.op_Inequality(a:  val_19.tag, b:  "SPD")) == false)
        {
            goto label_14;
        }
        
        val_19 = ringArray[val_22].gameObject;
        if((System.String.op_Inequality(a:  val_19.tag, b:  "SPD1")) == false)
        {
            goto label_14;
        }
        
        val_19 = ringArray[val_22].gameObject;
        if((System.String.op_Inequality(a:  val_19.tag, b:  "SPD2")) == true)
        {
            goto label_18;
        }
        
        label_14:
        val_22 = val_22 - 1;
        if((val_22 & 2147483648) == 0)
        {
            goto label_19;
        }
        
        return;
        label_18:
        val_20 = this.edgeColorCounter;
        if(val_20 != 0)
        {
                if(val_20 >= 1)
        {
                var val_26 = 0;
            var val_25 = 0;
            do
        {
            val_20 = this.edgeColorCounter;
            val_25 = val_25 + 1;
            val_26 = val_26 | (System.String.op_Equality(a:  this.edgeColorTag[0], b:  ringArray[val_22].gameObject.tag));
        }
        while(val_25 < val_20);
        
            if(val_26 == true)
        {
                return;
        }
        
        }
        
            this.edgeColorTag[(long)val_20] = ringArray[val_22].gameObject.tag;
        }
        else
        {
                this.edgeColorTag[0] = ringArray[val_22].gameObject.tag;
        }
        
        int val_29 = this.edgeColorCounter;
        val_29 = val_29 + 1;
        this.edgeColorCounter = val_29;
    }
    private void CalculateEdgeColorUp(UnityEngine.GameObject[] ringArray, int arrayLength)
    {
        var val_18;
        System.String[] val_19;
        var val_20;
        int val_21;
        int val_22;
        if(arrayLength < 1)
        {
                return;
        }
        
        val_18 = "SPD";
        var val_23 = 0;
        goto label_45;
        label_28:
        val_19 = this.edgeColorTag;
        val_19[0] = X27.gameObject.tag;
        label_44:
        int val_18 = this.edgeColorCounter;
        val_18 = val_18 + 1;
        this.edgeColorCounter = val_18;
        val_20 = arrayLength;
        goto label_36;
        label_45:
        if((((ringArray[0] == 0) || ((System.String.op_Inequality(a:  ringArray[0x0] + 32.gameObject.tag, b:  "SPD")) == false)) || ((System.String.op_Inequality(a:  ringArray[0x0] + 32.gameObject.tag, b:  "SPD1")) == false)) || ((System.String.op_Inequality(a:  ringArray[0x0] + 32.gameObject.tag, b:  "SPD2")) == false))
        {
            goto label_27;
        }
        
        val_21 = this.edgeColorCounter;
        if(val_21 == 0)
        {
            goto label_28;
        }
        
        if(val_21 < 1)
        {
            goto label_29;
        }
        
        var val_22 = 0;
        var val_21 = 0;
        do
        {
            val_22 = this.edgeColorCounter;
            val_21 = val_21 + 1;
            val_22 = val_22 | (System.String.op_Equality(a:  this.edgeColorTag[0], b:  ringArray[0x0] + 32.gameObject.tag));
        }
        while(val_21 < val_22);
        
        val_18 = "SPD";
        val_20 = arrayLength;
        if(val_22 == true)
        {
            goto label_36;
        }
        
        label_29:
        this.edgeColorTag[(long)val_22] = ringArray[0x0] + 32.gameObject.tag;
        goto label_44;
        label_27:
        val_20 = val_23;
        label_36:
        val_23 = val_20 + 1;
        if(val_23 < arrayLength)
        {
            goto label_45;
        }
    
    }
    public void InkSequenceChanges()
    {
        TargetBallCPU.popTag = this.playerBalls[0].gameObject.tag;
        UnityEngine.Color val_5 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.playerBalls[0].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
        UnityEngine.Color val_8 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.playerBalls[1].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a};
        UnityEngine.Vector3 val_12 = this.playerBalls[0].gameObject.transform.position;
        UnityEngine.Vector3 val_13 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        UnityEngine.Vector3 val_17 = this.playerBalls[0].gameObject.transform.position;
        UnityEngine.Vector3 val_18 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_20 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popSwipeBalls, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w});
        TargetBallCPU.popTag = this.playerBalls[0].gameObject.tag;
        UnityEngine.Vector3 val_26 = this.playerBalls[1].gameObject.transform.position;
        UnityEngine.Vector3 val_27 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        UnityEngine.Vector3 val_31 = this.playerBalls[1].gameObject.transform.position;
        UnityEngine.Vector3 val_32 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
        UnityEngine.Quaternion val_33 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_34 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popSwipeBalls, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_33.x, y = val_33.y, z = val_33.z, w = val_33.w});
    }
    public BallSwipeCPU()
    {
    
    }

}
