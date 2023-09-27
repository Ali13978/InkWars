using UnityEngine;
public class ballSwipeScript : BallSwipeParent
{
    // Fields
    public UnityEngine.Sprite[] specialBallSelectorImages;
    public UnityEngine.GameObject specialBallSelector;
    public UnityEngine.GameObject specialBallButton;
    public UnityEngine.UI.Text specialBallCounter;
    public UnityEngine.UI.Text specialBallCounterX;
    public static bool flag;
    private int count;
    public static string[] presentColors;
    private int specialBallSelectorCount;
    private int ballEntry;
    private string ballTag;
    private string ballTagColor;
    private int entryFlag;
    private int rainbowFrequency;
    private int rainbowCounter;
    private int edgeColorCounter;
    private int uniqueColorCounter;
    private int notEdgeColorCounter;
    private string[] edgeColorTag;
    private string[] uniqueColorTag;
    private string[] notEdgeColorTag;
    private float secondaryAttackFrequency;
    private int secondaryAttackFrequencyCounter;
    public UnityEngine.GameObject[] puzzleBalls;
    public UnityEngine.GameObject[] puzzleBallImages;
    public UnityEngine.GameObject puzzleBallHolder;
    public UnityEngine.GameObject ballSwapHolderPlayer;
    public UnityEngine.GameObject ballSwapHolderCpu;
    public UnityEngine.GameObject popSwipeBalls;
    private bool isSpecialHit;
    public UnityEngine.AudioClip ballSwipeClip;
    public UnityEngine.Sprite[] switcherSprites;
    public UnityEngine.UI.Image bubbleSwitcher;
    public static ballSwipeScript instance;
    private bool muteSpecialBallArrowClickSound;
    private int specialBallsLoop;
    
    // Methods
    private void Awake()
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = null;
        val_2 = null;
        if(ballSwipeScript.instance != 0)
        {
                val_3 = null;
            val_3 = null;
            UnityEngine.Object.Destroy(obj:  ballSwipeScript.instance);
        }
        
        val_4 = null;
        val_4 = null;
        ballSwipeScript.instance = this;
    }
    private void Update()
    {
    
    }
    public void Start()
    {
        CharacterNameID val_8;
        CharacterNameID val_11;
        var val_18;
        var val_20;
        var val_21;
        this.isSpecialHit = false;
        this.ballTag = "";
        this.ballTagColor = "";
        this.edgeColorTag = new string[6];
        this.uniqueColorTag = new string[6];
        this.notEdgeColorTag = new string[6];
        CharacterInfo val_4 = Character_GlobalInfo.GetMainPlayer();
        val_18 = null;
        val_18 = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
                CharacterInfo val_6 = Character_GlobalInfo.GetLeftPlayer();
        }
        else
        {
                CharacterInfo val_7 = Character_GlobalInfo.GetMainPlayer();
        }
        
        this.rainbowFrequency = CharacterHelper.GetRainbowPercentageLevel(cid:  val_8);
        CharacterInfo val_10 = Character_GlobalInfo.GetMainPlayer();
        mem[1152921526396474584] = CharacterHelper.GetSecondaryAttackPercent(cid:  val_11);
        if(this.rainbowFrequency == 2)
        {
            goto label_13;
        }
        
        if(this.rainbowFrequency != 1)
        {
            goto label_14;
        }
        
        if(this.bubbleSwitcher != null)
        {
            goto label_43;
        }
        
        label_44:
        label_43:
        this.bubbleSwitcher.sprite = this.switcherSprites[0];
        this.rainbowCounter = 0;
        this.specialBallSelectorCount = 0;
        this.muteSpecialBallArrowClickSound = true;
        this.OnSpecialBallArrowClick();
        this.muteSpecialBallArrowClickSound = false;
        val_20 = null;
        val_20 = null;
        ballSwipeScript.flag = true;
        this.count = 0;
        val_21 = null;
        val_21 = null;
        if(Character_GlobalInfo.gameMode == 3)
        {
                this.ballSwapHolderCpu.SetActive(value:  false);
            this.ballSwapHolderPlayer.SetActive(value:  false);
            this.specialBallSelector.SetActive(value:  false);
            UnityEngine.Coroutine val_13 = this.StartCoroutine(methodName:  "InstantiateInPuzzleMode");
            return;
        }
        
        if(BattleVSGates.instance != 0)
        {
                return;
        }
        
        if(NetworkManager_Custom.IsNetwork == true)
        {
                return;
        }
        
        UnityEngine.Coroutine val_17 = this.StartCoroutine(routine:  this.InstantiateOnStart());
        return;
        label_13:
        UnityEngine.Sprite val_19 = this.switcherSprites[1];
        if(this.bubbleSwitcher != null)
        {
            goto label_43;
        }
        
        goto label_44;
        label_14:
        if(this.rainbowFrequency != 3)
        {
            goto label_38;
        }
        
        UnityEngine.Sprite val_20 = this.switcherSprites[2];
        if(this.bubbleSwitcher != null)
        {
            goto label_43;
        }
        
        goto label_44;
        label_38:
        UnityEngine.Sprite val_21 = this.switcherSprites[3];
        if(this.bubbleSwitcher != null)
        {
            goto label_43;
        }
        
        goto label_44;
    }
    private System.Collections.IEnumerator InstantiateInPuzzleMode()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new ballSwipeScript.<InstantiateInPuzzleMode>d__38();
    }
    public void OnToggleClick(int i)
    {
        var val_10;
        if(UnityEngine.Application.isPlaying != false)
        {
                GameAudio.PlayButtonSound();
        }
        
        val_10 = null;
        val_10 = null;
        LineController.touchFlag = false;
        UnityEngine.UI.Image val_3 = gameObject.GetComponent<UnityEngine.UI.Image>();
        val_3.sprite = this.puzzleBalls[(long)i].gameObject.GetComponent<UnityEngine.UI.Image>().sprite;
        val_3.gameObject.tag = this.puzzleBalls[(long)i].gameObject.tag;
    }
    public System.Collections.IEnumerator InstantiateOnStart()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new ballSwipeScript.<InstantiateOnStart>d__40();
    }
    private int GetTagAsInt(string tag)
    {
        var val_8;
        if((System.String.op_Equality(a:  tag, b:  "Blue")) != false)
        {
                val_8 = 1;
            return (int)((System.String.op_Equality(a:  tag, b:  "Purple")) != true) ? 6 : (0 + 1);
        }
        
        if((System.String.op_Equality(a:  tag, b:  "Green")) != false)
        {
                val_8 = 2;
            return (int)((System.String.op_Equality(a:  tag, b:  "Purple")) != true) ? 6 : (0 + 1);
        }
        
        if((System.String.op_Equality(a:  tag, b:  "Red")) != false)
        {
                val_8 = 3;
            return (int)((System.String.op_Equality(a:  tag, b:  "Purple")) != true) ? 6 : (0 + 1);
        }
        
        if((System.String.op_Equality(a:  tag, b:  "Yellow")) != false)
        {
                val_8 = 4;
            return (int)((System.String.op_Equality(a:  tag, b:  "Purple")) != true) ? 6 : (0 + 1);
        }
        
        if((System.String.op_Equality(a:  tag, b:  "Orange")) == false)
        {
                return (int)((System.String.op_Equality(a:  tag, b:  "Purple")) != true) ? 6 : (0 + 1);
        }
        
        val_8 = 5;
        return (int)((System.String.op_Equality(a:  tag, b:  "Purple")) != true) ? 6 : (0 + 1);
    }
    private void SpecialBallCounter()
    {
        UnityEngine.UI.Text val_11;
        var val_12;
        int val_13;
        var val_14;
        var val_15;
        val_11 = this;
        if(this.specialBallSelectorCount != 3)
        {
            goto label_1;
        }
        
        this.specialBallSelectorCount = 0;
        goto label_2;
        label_1:
        if(this.specialBallSelectorCount == 2)
        {
            goto label_3;
        }
        
        if(this.specialBallSelectorCount == 1)
        {
            goto label_4;
        }
        
        label_2:
        val_12 = null;
        val_12 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.ColorEraserBall;
        label_34:
        val_13 = val_1.fakeValue;
        int val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_13, inited = val_1.inited});
        if(val_2 > 0)
        {
                this.specialBallSelector.GetComponent<UnityEngine.UI.Image>().sprite = this.specialBallSelectorImages[this.specialBallSelectorCount];
            val_13 = "   " + val_2.ToString();
            val_11 = this.specialBallCounterX;
            if(val_11 != null)
        {
                return;
        }
        
            return;
        }
        
        int val_12 = this.specialBallsLoop;
        val_12 = val_12 + 1;
        this.specialBallsLoop = val_12;
        if(val_12 > 2)
        {
                UnityEngine.Color val_7 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            this.specialBallSelector.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
            val_13 = "";
            val_11 = this.specialBallButton.GetComponent<UnityEngine.UI.Button>();
            val_11.interactable = false;
            return;
        }
        
        int val_13 = this.specialBallSelectorCount;
        val_13 = val_13 + 1;
        this.specialBallSelectorCount = val_13;
        return;
        label_3:
        val_14 = null;
        val_14 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = DataStructs.UserDataDictionary.Items.StunnerBall;
        goto label_34;
        label_4:
        val_15 = null;
        val_15 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_10 = DataStructs.UserDataDictionary.Items.IronBall;
        goto label_34;
    }
    public void SwipeBall()
    {
        var val_36;
        var val_37;
        var val_38;
        bool val_39;
        val_36 = null;
        val_36 = null;
        if(Character_GlobalInfo.gameMode == 3)
        {
                return;
        }
        
        val_37 = null;
        val_37 = null;
        if(ballSwipeScript.flag == false)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = gameObject.transform;
        UnityEngine.Vector3 val_3 = val_2.position;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Transform val_6 = val_2.gameObject.transform;
        UnityEngine.Vector3 val_7 = val_6.position;
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Transform val_10 = val_6.gameObject.transform;
        UnityEngine.Vector3 val_11 = val_10.localScale;
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        UnityEngine.Transform val_14 = val_10.gameObject.transform;
        UnityEngine.Vector3 val_15 = val_14.localScale;
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        UnityEngine.GameObject val_17 = val_14.gameObject;
        if((System.String.op_Equality(a:  val_17.tag, b:  "Color_Eraser_Ball")) == true)
        {
            goto label_38;
        }
        
        UnityEngine.GameObject val_20 = val_17.gameObject;
        if((System.String.op_Equality(a:  val_20.tag, b:  "Iron_Ball")) == true)
        {
            goto label_38;
        }
        
        UnityEngine.GameObject val_23 = val_20.gameObject;
        if((System.String.op_Equality(a:  val_23.tag, b:  "Stunner_Ball")) == false)
        {
            goto label_43;
        }
        
        label_38:
        UnityEngine.GameObject val_26 = val_23.gameObject;
        if((System.String.op_Equality(a:  val_26.tag, b:  "Color_Eraser_Ball")) != true)
        {
                if((System.String.op_Equality(a:  val_26.gameObject.tag, b:  "Iron_Ball")) == false)
        {
            goto label_53;
        }
        
        }
        
        val_38 = null;
        val_38 = null;
        var val_32 = (LineController.ballEntry != 0) ? 1 : 0;
        goto label_56;
        label_53:
        val_39 = true;
        label_56:
        this.isSpecialHit = val_39;
        label_57:
        UnityEngine.Coroutine val_34 = this.StartCoroutine(routine:  this.BallSwapSpecial(pos1:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, pos2:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, size1:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, size2:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}));
        return;
        label_43:
        System.Collections.IEnumerator val_35 = this.BallSwapWithNewBall(pos1:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, pos2:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, size1:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, size2:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
        goto label_57;
    }
    public void OnButtonDown()
    {
        var val_31;
        var val_32;
        GameAudio.PlayBubbleSwitchSound();
        val_31 = null;
        val_31 = null;
        LineController.touchFlag = false;
        val_32 = null;
        val_32 = null;
        if(ballSwipeScript.flag == false)
        {
                return;
        }
        
        if(NetworkManager_Custom.IsNetwork != false)
        {
                NetworkBehaviour_PlayScene.syncMessageId.sendFunctionRPC(functionNumber:  3, intVariables:  new int[1], string1:  "");
        }
        
        UnityEngine.Transform val_4 = NetworkBehaviour_PlayScene.syncMessageId + 32.gameObject.transform;
        UnityEngine.Vector3 val_5 = val_4.position;
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Transform val_8 = val_4.gameObject.transform;
        UnityEngine.Vector3 val_9 = val_8.position;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        UnityEngine.Transform val_12 = val_8.gameObject.transform;
        UnityEngine.Vector3 val_13 = val_12.localScale;
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        UnityEngine.Transform val_16 = val_12.gameObject.transform;
        UnityEngine.Vector3 val_17 = val_16.localScale;
        UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        UnityEngine.GameObject val_19 = val_16.gameObject;
        if((System.String.op_Equality(a:  val_19.tag, b:  "Color_Eraser_Ball")) != true)
        {
                UnityEngine.GameObject val_22 = val_19.gameObject;
            if((System.String.op_Equality(a:  val_22.tag, b:  "Iron_Ball")) != true)
        {
                if((System.String.op_Equality(a:  val_22.gameObject.tag, b:  "Stunner_Ball")) == false)
        {
            goto label_46;
        }
        
        }
        
        }
        
        this.isSpecialHit = false;
        label_47:
        UnityEngine.Coroutine val_29 = this.StartCoroutine(routine:  this.BallSwapSpecial(pos1:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, pos2:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, size1:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y}, size2:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y}));
        return;
        label_46:
        System.Collections.IEnumerator val_30 = this.BallSwap(pos1:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, pos2:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, size1:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y}, size2:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
        goto label_47;
    }
    public void OnSpecialBallArrowClick()
    {
        var val_20;
        var val_21;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_28;
        var val_30;
        var val_31;
        var val_33;
        if(this.muteSpecialBallArrowClickSound != true)
        {
                GameAudio.PlayButtonSound();
        }
        
        val_20 = null;
        val_20 = null;
        LineController.touchFlag = false;
        int val_1 = this.specialBallSelectorCount + 1;
        this.specialBallSelectorCount = val_1;
        if(val_1 != 3)
        {
            goto label_6;
        }
        
        this.specialBallSelectorCount = 0;
        goto label_7;
        label_6:
        if(this.specialBallSelectorCount == 1)
        {
            goto label_8;
        }
        
        if(this.specialBallSelectorCount == 0)
        {
            goto label_9;
        }
        
        label_7:
        val_21 = null;
        val_21 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Items.ColorEraserBall;
        label_28:
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited})) > 0)
        {
            goto label_15;
        }
        
        int val_20 = this.specialBallSelectorCount;
        val_20 = val_20 + 1;
        this.specialBallSelectorCount = val_20;
        if(val_20 > 3)
        {
            goto label_16;
        }
        
        var val_21 = 40829560 + ((this.specialBallSelectorCount + 1)) << 2;
        val_21 = val_21 + 40829560;
        goto (40829560 + ((this.specialBallSelectorCount + 1)) << 2 + 40829560);
        label_8:
        val_25 = null;
        val_25 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Items.StunnerBall;
        goto label_28;
        label_9:
        val_26 = null;
        val_26 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = DataStructs.UserDataDictionary.Items.IronBall;
        goto label_28;
        label_16:
        val_28 = null;
        val_28 = null;
        val_23 = DataStructs.UserDataDictionary.Items;
        val_24 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_8 = val_23.ColorEraserBall;
        int val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_8.currentCryptoKey, hiddenValue = val_8.hiddenValue, fakeValue = val_8.fakeValue, inited = val_8.inited});
        if(val_9 <= 0)
        {
            goto label_38;
        }
        
        label_15:
        if(this.specialBallSelectorImages != null)
        {
            goto label_61;
        }
        
        label_62:
        label_61:
        this.specialBallSelector.GetComponent<UnityEngine.UI.Image>().sprite = this.specialBallSelectorImages[this.specialBallSelectorCount];
        string val_12 = "   " + val_9.ToString();
        return;
        label_38:
        int val_23 = this.specialBallSelectorCount;
        val_23 = val_23 + 1;
        this.specialBallSelectorCount = val_23;
        if(val_23 > 3)
        {
            goto label_45;
        }
        
        var val_24 = 40829576 + ((this.specialBallSelectorCount + 1)) << 2;
        val_24 = val_24 + 40829576;
        goto (40829576 + ((this.specialBallSelectorCount + 1)) << 2 + 40829576);
        label_45:
        val_33 = null;
        val_33 = null;
        val_30 = DataStructs.UserDataDictionary.Items;
        val_31 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_15 = val_30.ColorEraserBall;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_15.currentCryptoKey, hiddenValue = val_15.hiddenValue, fakeValue = val_15.fakeValue, inited = val_15.inited})) <= 0)
        {
            goto label_60;
        }
        
        if(this.specialBallSelectorImages != null)
        {
            goto label_61;
        }
        
        goto label_62;
        label_60:
        UnityEngine.Color val_18 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.specialBallSelector.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_18.r, g = val_18.g, b = val_18.b, a = val_18.a};
        this.specialBallButton.GetComponent<UnityEngine.UI.Button>().interactable = false;
    }
    public void OnSpecialBallButtonClick()
    {
        var val_120;
        var val_121;
        var val_122;
        var val_123;
        var val_124;
        var val_125;
        string val_126;
        var val_127;
        var val_128;
        var val_129;
        GameAudio.PlayButtonSound();
        val_120 = null;
        val_120 = null;
        LineController.touchFlag = false;
        if(this.specialBallSelectorCount == 2)
        {
            goto label_5;
        }
        
        if(this.specialBallSelectorCount == 1)
        {
            goto label_6;
        }
        
        val_121 = null;
        val_121 = null;
        val_122 = DataStructs.UserDataDictionary.Items;
        val_123 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = val_122.ColorEraserBall;
        goto label_14;
        label_5:
        val_124 = null;
        val_124 = null;
        val_122 = DataStructs.UserDataDictionary.Items;
        val_123 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = val_122.StunnerBall;
        goto label_14;
        label_6:
        val_125 = null;
        val_125 = null;
        val_122 = DataStructs.UserDataDictionary.Items;
        val_123 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = val_122.IronBall;
        label_14:
        val_126 = 1152921505080434688;
        val_127 = null;
        val_127 = null;
        if((ballSwipeScript.flag == false) || ((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited})) < 1))
        {
            goto label_23;
        }
        
        UnityEngine.GameObject val_5 = val_4 + 32.gameObject;
        if((System.String.op_Equality(a:  val_5.tag, b:  "Color_Eraser_Ball")) == true)
        {
            goto label_33;
        }
        
        UnityEngine.GameObject val_8 = val_5.gameObject;
        if((System.String.op_Equality(a:  val_8.tag, b:  "Iron_Ball")) == true)
        {
            goto label_33;
        }
        
        UnityEngine.GameObject val_11 = val_8.gameObject;
        if((System.String.op_Equality(a:  val_11.tag, b:  "Stunner_Ball")) == false)
        {
            goto label_38;
        }
        
        label_33:
        var val_16 = val_126 + ((this.specialBallSelectorCount) << 3);
        val_126 = mem[(val_126 + (this.specialBallSelectorCount) << 3) + 32];
        val_126 = (val_126 + (this.specialBallSelectorCount) << 3) + 32;
        if((System.String.op_Equality(a:  val_11.gameObject.tag, b:  val_126.name)) == true)
        {
            goto label_114;
        }
        
        val_128 = null;
        val_128 = null;
        string val_21 = (val_126 + (this.specialBallSelectorCount) << 3) + 32 + 32.gameObject.tag((val_126 + (this.specialBallSelectorCount) << 3) + 32 + 32.gameObject.tag) + "_Count";
        DataStructs.UserDataDictionary.Items.AddSpecialBallCountById(id:  val_21, addition:  1);
        string val_24 = val_21.gameObject.tag + "_Count";
        int val_25 = DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  val_24);
        string val_28 = val_24.gameObject.tag + "_Used";
        DataStructs.UserDataDictionary.Stats.AddSpecialBallUsedById(id:  val_28, addition:  0);
        UnityEngine.UI.Image val_30 = gameObject.GetComponent<UnityEngine.UI.Image>();
        string val_31 = val_28 + ((this.specialBallSelectorCount) << 3);
        val_30.sprite = val_28;
        string val_33 = val_28 + ((this.specialBallSelectorCount) << 3);
        string val_34 = val_28.name;
        val_30.gameObject.tag = val_34;
        string val_37 = val_34.gameObject.tag + "_Count";
        DataStructs.UserDataDictionary.Items.AddSpecialBallCountById(id:  val_37, addition:  0);
        string val_40 = val_37.gameObject.tag + "_Count";
        int val_41 = DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  val_40);
        DataStructs.UserDataDictionary.Stats.AddSpecialBallUsedById(id:  val_40.gameObject.tag + "_Used", addition:  1);
        bool val_49 = System.String.op_Inequality(a:  this.specialBallCounterX.gameObject.tag, b:  "Iron_Ball");
        val_126 = "   " + val_41.ToString().gameObject.GetComponent<UnityEngine.Animator>();
        if(val_126 == null)
        {
            goto label_103;
        }
        
        if(val_49 == false)
        {
            goto label_104;
        }
        
        label_115:
        val_126.enabled = true;
        val_126 = val_126.gameObject.tag + "_Anim";
        val_49 + 32.gameObject.GetComponent<UnityEngine.Animator>().Play(stateName:  val_126);
        goto label_114;
        label_103:
        if(val_49 == true)
        {
            goto label_115;
        }
        
        label_104:
        val_126.enabled = false;
        label_114:
        UnityEngine.Transform val_58 = val_49 + 48.gameObject.transform;
        UnityEngine.Vector3 val_59 = val_58.position;
        UnityEngine.Vector2 val_60 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z});
        UnityEngine.Transform val_62 = val_58.gameObject.transform;
        UnityEngine.Vector3 val_63 = val_62.position;
        UnityEngine.Vector2 val_64 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_63.x, y = val_63.y, z = val_63.z});
        UnityEngine.Transform val_66 = val_62.gameObject.transform;
        UnityEngine.Vector3 val_67 = val_66.localScale;
        UnityEngine.Vector2 val_68 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_67.x, y = val_67.y, z = val_67.z});
        UnityEngine.Vector3 val_71 = val_66.gameObject.transform.localScale;
        UnityEngine.Vector2 val_72 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_71.x, y = val_71.y, z = val_71.z});
        label_214:
        UnityEngine.Coroutine val_74 = this.StartCoroutine(routine:  this.SameBallSwapSpecial(pos1:  new UnityEngine.Vector2() {x = val_60.x, y = val_60.y}, pos2:  new UnityEngine.Vector2() {x = val_64.x, y = val_64.y}, size1:  new UnityEngine.Vector2() {x = val_68.x, y = val_68.y}, size2:  new UnityEngine.Vector2() {x = val_72.x, y = val_72.y}));
        label_23:
        if(val_41 > 0)
        {
                return;
        }
        
        this.OnSpecialBallArrowClick();
        return;
        label_38:
        var val_76 = val_126 + ((this.specialBallSelectorCount) << 3);
        string val_77 = (val_126 + (this.specialBallSelectorCount) << 3) + 32.name;
        val_11.gameObject.tag = val_77;
        val_129 = null;
        val_129 = null;
        string val_80 = val_77.gameObject.tag + "_Count";
        DataStructs.UserDataDictionary.Items.AddSpecialBallCountById(id:  val_80, addition:  0);
        string val_83 = val_80.gameObject.tag + "_Count";
        string val_87 = val_83.gameObject.tag + "_Used";
        DataStructs.UserDataDictionary.Stats.AddSpecialBallUsedById(id:  val_87, addition:  1);
        UnityEngine.Animator val_92 = val_87.gameObject.GetComponent<UnityEngine.Animator>();
        if((System.String.op_Inequality(a:  gameObject.tag, b:  "Iron_Ball")) != false)
        {
                val_92.enabled = true;
            val_90 + 48.gameObject.GetComponent<UnityEngine.Animator>().Play(stateName:  val_92.gameObject.tag + "_Anim");
        }
        else
        {
                val_92.enabled = false;
        }
        
        UnityEngine.Animator val_100 = val_92 + ((this.specialBallSelectorCount) << 3);
        val_90 + 48.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = val_92;
        string val_102 = "   " + DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  val_83).ToString()(DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  val_83).ToString());
        UnityEngine.Transform val_104 = this.specialBallCounterX.gameObject.transform;
        UnityEngine.Vector3 val_105 = val_104.position;
        UnityEngine.Vector2 val_106 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_105.x, y = val_105.y, z = val_105.z});
        UnityEngine.Transform val_108 = val_104.gameObject.transform;
        UnityEngine.Vector3 val_109 = val_108.position;
        UnityEngine.Vector2 val_110 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_109.x, y = val_109.y, z = val_109.z});
        UnityEngine.Transform val_112 = val_108.gameObject.transform;
        UnityEngine.Vector3 val_113 = val_112.localScale;
        UnityEngine.Vector2 val_114 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_113.x, y = val_113.y, z = val_113.z});
        UnityEngine.Vector3 val_117 = val_112.gameObject.transform.localScale;
        UnityEngine.Vector2 val_118 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_117.x, y = val_117.y, z = val_117.z});
        this.isSpecialHit = false;
        System.Collections.IEnumerator val_119 = this.BallSwapSpecial(pos1:  new UnityEngine.Vector2() {x = val_106.x, y = val_106.y}, pos2:  new UnityEngine.Vector2() {x = val_110.x, y = val_110.y}, size1:  new UnityEngine.Vector2() {x = val_114.x, y = val_114.y}, size2:  new UnityEngine.Vector2() {x = val_118.x, y = val_118.y});
        goto label_214;
    }
    private System.Collections.IEnumerator SameBallSwapSpecial(UnityEngine.Vector2 pos1, UnityEngine.Vector2 pos2, UnityEngine.Vector2 size1, UnityEngine.Vector2 size2)
    {
        ballSwipeScript.<SameBallSwapSpecial>d__48 val_1 = new ballSwipeScript.<SameBallSwapSpecial>d__48();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .pos1 = pos1;
            mem[1152921526399617260] = pos1.y;
            .pos2 = pos2;
            mem[1152921526399617268] = pos2.y;
            .size1 = size1;
            mem[1152921526399617276] = size1.y;
        }
        else
        {
                mem[32] = this;
            mem[40] = pos1.x;
            mem[1152921526399617260] = pos1.y;
            mem[48] = pos2.x;
            mem[1152921526399617268] = pos2.y;
            mem[56] = size1.x;
            mem[1152921526399617276] = size1.y;
        }
        
        .size2 = size2;
        mem[1152921526399617284] = size2.y;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator BallSwapSpecial(UnityEngine.Vector2 pos1, UnityEngine.Vector2 pos2, UnityEngine.Vector2 size1, UnityEngine.Vector2 size2)
    {
        ballSwipeScript.<BallSwapSpecial>d__49 val_1 = new ballSwipeScript.<BallSwapSpecial>d__49();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .pos1 = pos1;
            mem[1152921526399737452] = pos1.y;
            .pos2 = pos2;
            mem[1152921526399737460] = pos2.y;
            .size1 = size1;
            mem[1152921526399737468] = size1.y;
        }
        else
        {
                mem[32] = this;
            mem[40] = pos1.x;
            mem[1152921526399737452] = pos1.y;
            mem[48] = pos2.x;
            mem[1152921526399737460] = pos2.y;
            mem[56] = size1.x;
            mem[1152921526399737468] = size1.y;
        }
        
        .size2 = size2;
        mem[1152921526399737476] = size2.y;
        return (System.Collections.IEnumerator)val_1;
    }
    public System.Collections.IEnumerator BallSwap(UnityEngine.Vector2 pos1, UnityEngine.Vector2 pos2, UnityEngine.Vector2 size1, UnityEngine.Vector2 size2)
    {
        ballSwipeScript.<BallSwap>d__50 val_1 = new ballSwipeScript.<BallSwap>d__50();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .pos1 = pos1;
            mem[1152921526399857644] = pos1.y;
            .pos2 = pos2;
            mem[1152921526399857652] = pos2.y;
            .size1 = size1;
            mem[1152921526399857660] = size1.y;
        }
        else
        {
                mem[32] = this;
            mem[40] = pos1.x;
            mem[1152921526399857644] = pos1.y;
            mem[48] = pos2.x;
            mem[1152921526399857652] = pos2.y;
            mem[56] = size1.x;
            mem[1152921526399857660] = size1.y;
        }
        
        .size2 = size2;
        mem[1152921526399857668] = size2.y;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator BallSwapWithNewBall(UnityEngine.Vector2 pos1, UnityEngine.Vector2 pos2, UnityEngine.Vector2 size1, UnityEngine.Vector2 size2)
    {
        ballSwipeScript.<BallSwapWithNewBall>d__51 val_1 = new ballSwipeScript.<BallSwapWithNewBall>d__51();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .pos1 = pos1;
            mem[1152921526399977836] = pos1.y;
            .pos2 = pos2;
            mem[1152921526399977844] = pos2.y;
            .size1 = size1;
            mem[1152921526399977852] = size1.y;
        }
        else
        {
                mem[32] = this;
            mem[40] = pos1.x;
            mem[1152921526399977836] = pos1.y;
            mem[48] = pos2.x;
            mem[1152921526399977844] = pos2.y;
            mem[56] = size1.x;
            mem[1152921526399977852] = size1.y;
        }
        
        .size2 = size2;
        mem[1152921526399977860] = size2.y;
        return (System.Collections.IEnumerator)val_1;
    }
    private void sendTag(string ballTag)
    {
        var val_9;
        if((System.String.op_Equality(a:  ballTag, b:  "Blue")) != false)
        {
                val_9 = 1;
        }
        else
        {
                if((System.String.op_Equality(a:  ballTag, b:  "Green")) != false)
        {
                val_9 = 2;
        }
        else
        {
                if((System.String.op_Equality(a:  ballTag, b:  "Red")) != false)
        {
                val_9 = 3;
        }
        else
        {
                if((System.String.op_Equality(a:  ballTag, b:  "Yellow")) != false)
        {
                val_9 = 4;
        }
        else
        {
                if((System.String.op_Equality(a:  ballTag, b:  "Orange")) != false)
        {
                val_9 = 5;
        }
        
        }
        
        }
        
        }
        
        }
        
        int[] val_8 = new int[1];
        val_8[0] = ((System.String.op_Equality(a:  ballTag, b:  "Purple")) != true) ? 6 : (0 + 1);
        NetworkBehaviour_PlayScene.syncMessageId.sendFunctionRPC(functionNumber:  2, intVariables:  val_8, string1:  "");
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
        this.CalculateUniqueColors(ringArrayOuter:  InstanceAnimator.outerRingBalls, ringArrayMiddle:  InstanceAnimator.middleRingBalls, ringArrayInner:  InstanceAnimator.innerRingBalls);
        this.edgeColorCounter = 0;
        val_13 = null;
        if(InstanceAnimator.isOuterRingEmpty != true)
        {
                this.CalculateEdgeColorUp(ringArray:  InstanceAnimator.outerRingBalls, arrayLength:  17);
            this.CalculateEdgeColorDown(ringArray:  InstanceAnimator.outerRingBalls, arrayLength:  17);
            val_13 = null;
        }
        
        val_13 = null;
        if(InstanceAnimator.isMiddleRingEmpty != true)
        {
                this.CalculateEdgeColorUp(ringArray:  InstanceAnimator.middleRingBalls, arrayLength:  13);
            this.CalculateEdgeColorDown(ringArray:  InstanceAnimator.middleRingBalls, arrayLength:  13);
            val_13 = null;
        }
        
        val_13 = null;
        if(InstanceAnimator.isInnerRingEmpty != true)
        {
                this.CalculateEdgeColorUp(ringArray:  InstanceAnimator.innerRingBalls, arrayLength:  9);
            this.CalculateEdgeColorDown(ringArray:  InstanceAnimator.innerRingBalls, arrayLength:  9);
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
        UnityEngine.GameObject val_1 = mem[53674016].gameObject;
        TargetBallScript.popTag = val_1.tag;
        UnityEngine.UI.Image val_4 = val_1.gameObject.GetComponent<UnityEngine.UI.Image>();
        UnityEngine.Color val_5 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_4.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
        UnityEngine.Color val_8 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_4.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a};
        UnityEngine.Transform val_11 = X22 + 32.gameObject.transform;
        UnityEngine.Vector3 val_12 = val_11.position;
        UnityEngine.Vector3 val_13 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        UnityEngine.Transform val_16 = val_11.gameObject.transform;
        UnityEngine.Vector3 val_17 = val_16.position;
        UnityEngine.Vector3 val_18 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_20 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popSwipeBalls, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w});
        TargetBallScript.popTag = this.popSwipeBalls.gameObject.tag;
        UnityEngine.Camera val_23 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_26 = val_16.gameObject.transform.position;
        UnityEngine.Vector3 val_27 = val_23.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        UnityEngine.Vector3 val_31 = val_23.gameObject.transform.position;
        UnityEngine.Vector3 val_32 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
        UnityEngine.Quaternion val_33 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_34 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.popSwipeBalls, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_33.x, y = val_33.y, z = val_33.z, w = val_33.w});
    }
    public ballSwipeScript()
    {
    
    }
    private static ballSwipeScript()
    {
    
    }

}
