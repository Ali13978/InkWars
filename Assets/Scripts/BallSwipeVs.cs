using UnityEngine;
public class BallSwipeVs : BallSwipeParent
{
    // Fields
    public UnityEngine.Sprite[] specialBallSelectorImages;
    public UnityEngine.GameObject specialBallSelector;
    public UnityEngine.GameObject specialBallButton;
    public UnityEngine.UI.Text specialBallCounter;
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
    public UnityEngine.UI.Image bubbleSwitcher;
    public static BallSwipeVs instance;
    private bool muteSpecialBallArrowClickSound;
    
    // Methods
    private void Awake()
    {
        var val_7;
        var val_8;
        var val_9;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_1.m_Handle.name, b:  "PlayScene")) != false)
        {
                this.gameObject.GetComponent<BallSwipeVs>().enabled = false;
        }
        
        val_7 = null;
        val_7 = null;
        if(BallSwipeVs.instance != 0)
        {
                val_8 = null;
            val_8 = null;
            UnityEngine.Object.Destroy(obj:  BallSwipeVs.instance);
        }
        
        val_9 = null;
        val_9 = null;
        BallSwipeVs.instance = this;
    }
    public void Start()
    {
        CharacterNameID val_7;
        CharacterNameID val_10;
        var val_20;
        var val_21;
        this.isSpecialHit = false;
        this.ballTag = "";
        this.ballTagColor = "";
        this.edgeColorTag = new string[6];
        this.uniqueColorTag = new string[6];
        this.notEdgeColorTag = new string[6];
        CharacterInfo val_4 = Character_GlobalInfo.GetOpponentPlayer();
        CharacterInfo val_6 = Character_GlobalInfo.GetRightPlayer();
        this.rainbowFrequency = CharacterHelper.GetRainbowPercentageLevel(cid:  val_7);
        CharacterInfo val_9 = Character_GlobalInfo.GetRightPlayer();
        mem[1152921526410168048] = CharacterHelper.GetSecondaryAttackPercent(cid:  val_10);
        if(this.rainbowFrequency == 2)
        {
            goto label_7;
        }
        
        if(this.rainbowFrequency != 1)
        {
            goto label_8;
        }
        
        ballSwipeScript val_12 = this.GetComponent<ballSwipeScript>();
        if(this.bubbleSwitcher != null)
        {
            goto label_39;
        }
        
        label_40:
        label_39:
        this.bubbleSwitcher.sprite = val_12.switcherSprites[0];
        this.rainbowCounter = 0;
        this.specialBallSelectorCount = 0;
        this.muteSpecialBallArrowClickSound = true;
        this.OnSpecialBallArrowClick();
        this.muteSpecialBallArrowClickSound = false;
        val_20 = null;
        val_20 = null;
        BallSwipeVs.flag = true;
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
        label_7:
        ballSwipeScript val_18 = this.GetComponent<ballSwipeScript>();
        UnityEngine.Sprite val_21 = val_18.switcherSprites[1];
        if(this.bubbleSwitcher != null)
        {
            goto label_39;
        }
        
        goto label_40;
        label_8:
        ballSwipeScript val_19 = this.GetComponent<ballSwipeScript>();
        if(this.rainbowFrequency != 3)
        {
            goto label_34;
        }
        
        UnityEngine.Sprite val_22 = val_19.switcherSprites[2];
        if(this.bubbleSwitcher != null)
        {
            goto label_39;
        }
        
        goto label_40;
        label_34:
        UnityEngine.Sprite val_23 = val_19.switcherSprites[3];
        if(this.bubbleSwitcher != null)
        {
            goto label_39;
        }
        
        goto label_40;
    }
    private System.Collections.IEnumerator InstantiateInPuzzleMode()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new BallSwipeVs.<InstantiateInPuzzleMode>d__35();
    }
    public void SetInitialSwipeBalls(int firstball, int secondball)
    {
        UnityEngine.Sprite val_17;
        UnityEngine.Sprite val_18;
        UnityEngine.UI.Image val_2 = static_value_03331020.gameObject.GetComponent<UnityEngine.UI.Image>();
        UnityEngine.Color val_3 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_2.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        UnityEngine.Color val_6 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_2.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
        this.receiveTag(tag:  firstball);
        UnityEngine.UI.Image val_8 = firstball + 32.gameObject.GetComponent<UnityEngine.UI.Image>();
        System.Type val_17 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_10 = UnityEngine.Resources.Load(path:  this.ballTagColor, systemTypeInstance:  val_17);
        if(val_8 == null)
        {
            goto label_17;
        }
        
        if(val_10 == null)
        {
            goto label_18;
        }
        
        label_20:
        val_17 = (null == null) ? (val_10) : 0;
        goto label_19;
        label_17:
        if(val_10 != null)
        {
            goto label_20;
        }
        
        label_18:
        val_17 = 0;
        label_19:
        val_8.sprite = val_17;
        val_8.gameObject.tag = this.ballTag;
        this.receiveTag(tag:  secondball);
        UnityEngine.UI.Image val_13 = secondball + 40.gameObject.GetComponent<UnityEngine.UI.Image>();
        System.Type val_18 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_15 = UnityEngine.Resources.Load(path:  this.ballTagColor, systemTypeInstance:  val_18);
        if(val_13 == null)
        {
            goto label_29;
        }
        
        if(val_15 == null)
        {
            goto label_30;
        }
        
        label_32:
        val_18 = (null == null) ? (val_15) : 0;
        goto label_31;
        label_29:
        if(val_15 != null)
        {
            goto label_32;
        }
        
        label_30:
        val_18 = 0;
        label_31:
        val_13.sprite = val_18;
        val_13.gameObject.tag = this.ballTag;
    }
    public void OnToggleClick(int i)
    {
        var val_9;
        UnityEngine.Debug.Log(message:  "hello1");
        GameAudio.PlayButtonSound();
        val_9 = null;
        val_9 = null;
        LineControllerP2.touchFlagP2 = false;
        UnityEngine.UI.Image val_2 = gameObject.GetComponent<UnityEngine.UI.Image>();
        val_2.sprite = this.puzzleBalls[(long)i].gameObject.GetComponent<UnityEngine.UI.Image>().sprite;
        val_2.gameObject.tag = this.puzzleBalls[(long)i].gameObject.tag;
    }
    public System.Collections.IEnumerator InstantiateOnStart()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new BallSwipeVs.<InstantiateOnStart>d__38();
    }
    private void SpecialBallCounter()
    {
        int val_27;
        var val_28;
        int val_29;
        var val_30;
        var val_31;
        int val_32;
        var val_33;
        val_27 = this.specialBallSelectorCount;
        if(val_27 == 3)
        {
                val_27 = 0;
            this.specialBallSelectorCount = 0;
        }
        
        val_28 = null;
        val_28 = null;
        val_27 = this.specialBallSelectorCount;
        var val_1 = X22 + (((long)(int)(this.specialBallSelectorCount)) << 3);
        if((DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  (X22 + ((long)(int)(this.specialBallSelectorCount)) << 3) + 32.name((X22 + ((long)(int)(this.specialBallSelectorCount)) << 3) + 32.name) + "_Count")) > 0)
        {
            goto label_8;
        }
        
        this.specialBallSelectorCount = ((this.specialBallSelectorCount + 1) == 3) ? 0 : (this.specialBallSelectorCount + 1);
        val_30 = null;
        val_30 = null;
        val_29 = this.specialBallSelectorCount;
        var val_7 = X24 + (((long)(int)(this.specialBallSelectorCount)) << 3);
        if((DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  (X24 + ((long)(int)(this.specialBallSelectorCount)) << 3) + 32.name((X24 + ((long)(int)(this.specialBallSelectorCount)) << 3) + 32.name) + "_Count")) <= 0)
        {
            goto label_15;
        }
        
        label_8:
        if(this.specialBallSelectorImages != null)
        {
            goto label_35;
        }
        
        label_36:
        label_35:
        this.specialBallSelector.GetComponent<UnityEngine.UI.Image>().sprite = this.specialBallSelectorImages[this.specialBallSelectorCount];
        val_31 = null;
        val_31 = null;
        var val_12 = 1152921505151520768 + ((this.specialBallSelectorCount) << 3);
        string val_17 = "x" + DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  (1152921505151520768 + (this.specialBallSelectorCount) << 3) + 32.name((1152921505151520768 + (this.specialBallSelectorCount) << 3) + 32.name) + "_Count").ToString()(DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  (1152921505151520768 + (this.specialBallSelectorCount) << 3) + 32.name((1152921505151520768 + (this.specialBallSelectorCount) << 3) + 32.name) + "_Count").ToString());
        return;
        label_15:
        this.specialBallSelectorCount = ((this.specialBallSelectorCount + 1) == 3) ? 0 : (this.specialBallSelectorCount + 1);
        val_33 = null;
        val_33 = null;
        val_32 = this.specialBallSelectorCount;
        var val_20 = X24 + (((long)(int)(this.specialBallSelectorCount)) << 3);
        if((DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  (X24 + ((long)(int)(this.specialBallSelectorCount)) << 3) + 32.name((X24 + ((long)(int)(this.specialBallSelectorCount)) << 3) + 32.name) + "_Count")) <= 0)
        {
            goto label_34;
        }
        
        if(this.specialBallSelectorImages != null)
        {
            goto label_35;
        }
        
        goto label_36;
        label_34:
        UnityEngine.Color val_25 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.specialBallSelector.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_25.r, g = val_25.g, b = val_25.b, a = val_25.a};
        this.specialBallButton.GetComponent<UnityEngine.UI.Button>().interactable = false;
    }
    public void SwipeBall(int networkTag)
    {
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        bool val_41;
        val_36 = 1152921505064992768;
        val_37 = null;
        val_37 = null;
        if(Character_GlobalInfo.gameMode == 3)
        {
                return;
        }
        
        val_36 = 1152921505080807424;
        val_38 = null;
        val_38 = null;
        if(BallSwipeVs.flag == false)
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
        val_39 = val_14.gameObject;
        if((System.String.op_Equality(a:  val_39.tag, b:  "Color_Eraser_Ball")) == true)
        {
            goto label_38;
        }
        
        val_39 = val_39.gameObject;
        if((System.String.op_Equality(a:  val_39.tag, b:  "Iron_Ball")) == true)
        {
            goto label_38;
        }
        
        val_39 = val_39.gameObject;
        if((System.String.op_Equality(a:  val_39.tag, b:  "Stunner_Ball")) == false)
        {
            goto label_43;
        }
        
        label_38:
        UnityEngine.GameObject val_26 = networkTag + 32.gameObject;
        if((System.String.op_Equality(a:  val_26.tag, b:  "Color_Eraser_Ball")) != true)
        {
                if((System.String.op_Equality(a:  val_26.gameObject.tag, b:  "Iron_Ball")) == false)
        {
            goto label_53;
        }
        
        }
        
        val_40 = null;
        val_40 = null;
        var val_32 = (LineControllerP2.ballEntry != 0) ? 1 : 0;
        goto label_56;
        label_53:
        val_41 = true;
        label_56:
        this.isSpecialHit = val_41;
        label_57:
        UnityEngine.Coroutine val_34 = this.StartCoroutine(routine:  this.BallSwapSpecial(pos1:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, pos2:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, size1:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, size2:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}));
        return;
        label_43:
        System.Collections.IEnumerator val_35 = this.BallSwapWithNewBall(pos1:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, pos2:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, size1:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, size2:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}, networkTag:  networkTag);
        goto label_57;
    }
    public void SwitchBall()
    {
        var val_31;
        var val_32;
        var val_34;
        GameAudio.PlayBubbleSwitchSound();
        val_31 = null;
        val_31 = null;
        LineControllerP2.touchFlagP2 = false;
        val_32 = null;
        val_32 = null;
        if(BallSwipeVs.flag == false)
        {
            goto label_7;
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
        if((System.String.op_Equality(a:  val_17.tag, b:  "Color_Eraser_Ball")) != true)
        {
                UnityEngine.GameObject val_20 = val_17.gameObject;
            if((System.String.op_Equality(a:  val_20.tag, b:  "Iron_Ball")) != true)
        {
                if((System.String.op_Equality(a:  val_20.gameObject.tag, b:  "Stunner_Ball")) == false)
        {
            goto label_44;
        }
        
        }
        
        }
        
        this.isSpecialHit = false;
        System.Collections.IEnumerator val_26 = this.BallSwapSpecial(pos1:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, pos2:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, size1:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, size2:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
        goto label_50;
        label_7:
        if(NetworkManager_Custom.IsNetwork == false)
        {
                return;
        }
        
        val_34 = null;
        val_34 = null;
        LineControllerP2.instance.HideLineRenderer();
        System.Collections.IEnumerator val_28 = this.DelayBallSwap();
        goto label_50;
        label_44:
        label_50:
        UnityEngine.Coroutine val_30 = this.StartCoroutine(routine:  this.BallSwap(pos1:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, pos2:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, size1:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, size2:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}));
    }
    private System.Collections.IEnumerator DelayBallSwap()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new BallSwipeVs.<DelayBallSwap>d__42();
    }
    public void OnButtonDown()
    {
        if(NetworkManager_Custom.IsNetwork != false)
        {
                return;
        }
        
        this.SwitchBall();
    }
    public void OnSpecialBallArrowClick()
    {
        int val_29;
        var val_30;
        int val_31;
        var val_32;
        var val_33;
        int val_34;
        var val_35;
        if(this.muteSpecialBallArrowClickSound != true)
        {
                GameAudio.PlayButtonSound();
        }
        
        this.specialBallSelectorCount = ((this.specialBallSelectorCount + 1) == 3) ? 0 : (this.specialBallSelectorCount + 1);
        val_30 = null;
        val_30 = null;
        val_29 = this.specialBallSelectorCount;
        var val_3 = X22 + (((long)(int)(this.specialBallSelectorCount)) << 3);
        if((DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  (X22 + ((long)(int)(this.specialBallSelectorCount)) << 3) + 32.name((X22 + ((long)(int)(this.specialBallSelectorCount)) << 3) + 32.name) + "_Count")) > 0)
        {
            goto label_10;
        }
        
        this.specialBallSelectorCount = ((this.specialBallSelectorCount + 1) == 3) ? 0 : (this.specialBallSelectorCount + 1);
        val_32 = null;
        val_32 = null;
        val_31 = this.specialBallSelectorCount;
        var val_9 = X24 + (((long)(int)(this.specialBallSelectorCount)) << 3);
        if((DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  (X24 + ((long)(int)(this.specialBallSelectorCount)) << 3) + 32.name((X24 + ((long)(int)(this.specialBallSelectorCount)) << 3) + 32.name) + "_Count")) <= 0)
        {
            goto label_17;
        }
        
        label_10:
        if(this.specialBallSelectorImages != null)
        {
            goto label_37;
        }
        
        label_38:
        label_37:
        this.specialBallSelector.GetComponent<UnityEngine.UI.Image>().sprite = this.specialBallSelectorImages[this.specialBallSelectorCount];
        val_33 = null;
        val_33 = null;
        var val_14 = 1152921505151520768 + ((this.specialBallSelectorCount) << 3);
        string val_19 = "x" + DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  (1152921505151520768 + (this.specialBallSelectorCount) << 3) + 32.name((1152921505151520768 + (this.specialBallSelectorCount) << 3) + 32.name) + "_Count").ToString()(DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  (1152921505151520768 + (this.specialBallSelectorCount) << 3) + 32.name((1152921505151520768 + (this.specialBallSelectorCount) << 3) + 32.name) + "_Count").ToString());
        return;
        label_17:
        this.specialBallSelectorCount = ((this.specialBallSelectorCount + 1) == 3) ? 0 : (this.specialBallSelectorCount + 1);
        val_35 = null;
        val_35 = null;
        val_34 = this.specialBallSelectorCount;
        var val_22 = X24 + (((long)(int)(this.specialBallSelectorCount)) << 3);
        if((DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  (X24 + ((long)(int)(this.specialBallSelectorCount)) << 3) + 32.name((X24 + ((long)(int)(this.specialBallSelectorCount)) << 3) + 32.name) + "_Count")) <= 0)
        {
            goto label_36;
        }
        
        if(this.specialBallSelectorImages != null)
        {
            goto label_37;
        }
        
        goto label_38;
        label_36:
        UnityEngine.Color val_27 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.specialBallSelector.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_27.r, g = val_27.g, b = val_27.b, a = val_27.a};
        this.specialBallButton.GetComponent<UnityEngine.UI.Button>().interactable = false;
    }
    public void OnSpecialBallButtonClick()
    {
        var val_116;
        var val_117;
        var val_118;
        var val_119;
        var val_120;
        GameAudio.PlayButtonSound();
        val_116 = null;
        val_116 = null;
        if(BallSwipeVs.flag == false)
        {
            goto label_5;
        }
        
        UnityEngine.GameObject val_1 = gameObject;
        if((System.String.op_Equality(a:  val_1.tag, b:  "Color_Eraser_Ball")) == true)
        {
            goto label_15;
        }
        
        UnityEngine.GameObject val_4 = val_1.gameObject;
        if((System.String.op_Equality(a:  val_4.tag, b:  "Iron_Ball")) == true)
        {
            goto label_15;
        }
        
        UnityEngine.GameObject val_7 = val_4.gameObject;
        if((System.String.op_Equality(a:  val_7.tag, b:  "Stunner_Ball")) == false)
        {
            goto label_20;
        }
        
        label_15:
        var val_12 = X21 + ((this.specialBallSelectorCount) << 3);
        if((System.String.op_Equality(a:  val_7.gameObject.tag, b:  (X21 + (this.specialBallSelectorCount) << 3) + 32.name)) == true)
        {
            goto label_89;
        }
        
        val_117 = null;
        val_117 = null;
        string val_17 = (X21 + (this.specialBallSelectorCount) << 3) + 32 + 32.gameObject.tag((X21 + (this.specialBallSelectorCount) << 3) + 32 + 32.gameObject.tag) + "_Count";
        DataStructs.UserDataDictionary.Items.AddSpecialBallCountById(id:  val_17, addition:  1);
        string val_20 = val_17.gameObject.tag + "_Used";
        DataStructs.UserDataDictionary.Stats.AddSpecialBallUsedById(id:  val_20, addition:  0);
        UnityEngine.UI.Image val_22 = gameObject.GetComponent<UnityEngine.UI.Image>();
        string val_23 = val_20 + ((this.specialBallSelectorCount) << 3);
        val_22.sprite = val_20;
        string val_25 = val_20 + ((this.specialBallSelectorCount) << 3);
        string val_26 = val_20.name;
        val_22.gameObject.tag = val_26;
        string val_29 = val_26.gameObject.tag + "_Count";
        DataStructs.UserDataDictionary.Items.AddSpecialBallCountById(id:  val_29, addition:  0);
        DataStructs.UserDataDictionary.Stats.AddSpecialBallUsedById(id:  val_29.gameObject.tag + "_Used", addition:  1);
        var val_33 = 1152921505151520768 + ((this.specialBallSelectorCount) << 3);
        bool val_41 = System.String.op_Inequality(a:  this.specialBallCounter.gameObject.tag, b:  "Iron_Ball");
        UnityEngine.Animator val_43 = "x" + DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  (1152921505151520768 + (this.specialBallSelectorCount) << 3) + 32.name((1152921505151520768 + (this.specialBallSelectorCount) << 3) + 32.name) + "_Count").ToString()(DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  (1152921505151520768 + (this.specialBallSelectorCount) << 3) + 32.name((1152921505151520768 + (this.specialBallSelectorCount) << 3) + 32.name) + "_Count").ToString()).gameObject.GetComponent<UnityEngine.Animator>();
        if(val_43 == null)
        {
            goto label_78;
        }
        
        if(val_41 == false)
        {
            goto label_79;
        }
        
        label_90:
        val_43.enabled = true;
        val_41 + 32.gameObject.GetComponent<UnityEngine.Animator>().Play(stateName:  val_43.gameObject.tag + "_Anim");
        goto label_89;
        label_78:
        if(val_41 == true)
        {
            goto label_90;
        }
        
        label_79:
        val_43.enabled = false;
        label_89:
        UnityEngine.Transform val_50 = val_41 + 40.gameObject.transform;
        UnityEngine.Vector3 val_51 = val_50.position;
        UnityEngine.Vector2 val_52 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z});
        UnityEngine.Transform val_54 = val_50.gameObject.transform;
        UnityEngine.Vector3 val_55 = val_54.position;
        UnityEngine.Vector2 val_56 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z});
        UnityEngine.Transform val_58 = val_54.gameObject.transform;
        UnityEngine.Vector3 val_59 = val_58.localScale;
        UnityEngine.Vector2 val_60 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z});
        UnityEngine.Vector3 val_63 = val_58.gameObject.transform.localScale;
        UnityEngine.Vector2 val_64 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_63.x, y = val_63.y, z = val_63.z});
        label_196:
        UnityEngine.Coroutine val_66 = this.StartCoroutine(routine:  this.SameBallSwapSpecial(pos1:  new UnityEngine.Vector2() {x = val_52.x, y = val_52.y}, pos2:  new UnityEngine.Vector2() {x = val_56.x, y = val_56.y}, size1:  new UnityEngine.Vector2() {x = val_60.x, y = val_60.y}, size2:  new UnityEngine.Vector2() {x = val_64.x, y = val_64.y}));
        label_5:
        val_118 = null;
        val_118 = null;
        UnityEngine.Animator val_67 = val_43 + ((this.specialBallSelectorCount) << 3);
        if((DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  val_43.name + "_Count")) > 0)
        {
                return;
        }
        
        this.OnSpecialBallArrowClick();
        return;
        label_20:
        var val_72 = X21 + ((this.specialBallSelectorCount) << 3);
        string val_73 = (X21 + (this.specialBallSelectorCount) << 3) + 32.name;
        val_7.gameObject.tag = val_73;
        val_119 = null;
        val_119 = null;
        string val_76 = val_73.gameObject.tag + "_Count";
        DataStructs.UserDataDictionary.Items.AddSpecialBallCountById(id:  val_76, addition:  0);
        string val_79 = val_76.gameObject.tag + "_Used";
        DataStructs.UserDataDictionary.Stats.AddSpecialBallUsedById(id:  val_79, addition:  1);
        bool val_82 = System.String.op_Inequality(a:  gameObject.tag, b:  "Iron_Ball");
        UnityEngine.Animator val_84 = val_79.gameObject.GetComponent<UnityEngine.Animator>();
        if(val_84 == null)
        {
            goto label_147;
        }
        
        if(val_82 == false)
        {
            goto label_148;
        }
        
        label_159:
        val_84.enabled = true;
        val_82 + 40.gameObject.GetComponent<UnityEngine.Animator>().Play(stateName:  val_84.gameObject.tag + "_Anim");
        goto label_158;
        label_147:
        if(val_82 == true)
        {
            goto label_159;
        }
        
        label_148:
        val_84.enabled = false;
        label_158:
        UnityEngine.Animator val_92 = val_84 + ((this.specialBallSelectorCount) << 3);
        val_82 + 40.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = val_84;
        val_120 = null;
        val_120 = null;
        var val_93 = 1152921505151520768 + ((this.specialBallSelectorCount) << 3);
        string val_98 = "x" + DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  (1152921505151520768 + (this.specialBallSelectorCount) << 3) + 32.name((1152921505151520768 + (this.specialBallSelectorCount) << 3) + 32.name) + "_Count").ToString()(DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  (1152921505151520768 + (this.specialBallSelectorCount) << 3) + 32.name((1152921505151520768 + (this.specialBallSelectorCount) << 3) + 32.name) + "_Count").ToString());
        UnityEngine.Transform val_100 = this.specialBallCounter.gameObject.transform;
        UnityEngine.Vector3 val_101 = val_100.position;
        UnityEngine.Vector2 val_102 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_101.x, y = val_101.y, z = val_101.z});
        UnityEngine.Transform val_104 = val_100.gameObject.transform;
        UnityEngine.Vector3 val_105 = val_104.position;
        UnityEngine.Vector2 val_106 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_105.x, y = val_105.y, z = val_105.z});
        UnityEngine.Transform val_108 = val_104.gameObject.transform;
        UnityEngine.Vector3 val_109 = val_108.localScale;
        UnityEngine.Vector2 val_110 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_109.x, y = val_109.y, z = val_109.z});
        UnityEngine.Vector3 val_113 = val_108.gameObject.transform.localScale;
        UnityEngine.Vector2 val_114 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_113.x, y = val_113.y, z = val_113.z});
        this.isSpecialHit = false;
        System.Collections.IEnumerator val_115 = this.BallSwapSpecial(pos1:  new UnityEngine.Vector2() {x = val_102.x, y = val_102.y}, pos2:  new UnityEngine.Vector2() {x = val_106.x, y = val_106.y}, size1:  new UnityEngine.Vector2() {x = val_110.x, y = val_110.y}, size2:  new UnityEngine.Vector2() {x = val_114.x, y = val_114.y});
        goto label_196;
    }
    private System.Collections.IEnumerator SameBallSwapSpecial(UnityEngine.Vector2 pos1, UnityEngine.Vector2 pos2, UnityEngine.Vector2 size1, UnityEngine.Vector2 size2)
    {
        BallSwipeVs.<SameBallSwapSpecial>d__46 val_1 = new BallSwipeVs.<SameBallSwapSpecial>d__46();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .pos1 = pos1;
            mem[1152921526413805148] = pos1.y;
            .pos2 = pos2;
            mem[1152921526413805156] = pos2.y;
            .size1 = size1;
            mem[1152921526413805164] = size1.y;
        }
        else
        {
                mem[32] = this;
            mem[40] = pos1.x;
            mem[1152921526413805148] = pos1.y;
            mem[48] = pos2.x;
            mem[1152921526413805156] = pos2.y;
            mem[56] = size1.x;
            mem[1152921526413805164] = size1.y;
        }
        
        .size2 = size2;
        mem[1152921526413805172] = size2.y;
        return (System.Collections.IEnumerator)val_1;
    }
    public System.Collections.IEnumerator BallSwapSpecial(UnityEngine.Vector2 pos1, UnityEngine.Vector2 pos2, UnityEngine.Vector2 size1, UnityEngine.Vector2 size2)
    {
        BallSwipeVs.<BallSwapSpecial>d__47 val_1 = new BallSwipeVs.<BallSwapSpecial>d__47();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .pos1 = pos1;
            mem[1152921526413925340] = pos1.y;
            .pos2 = pos2;
            mem[1152921526413925348] = pos2.y;
            .size1 = size1;
            mem[1152921526413925356] = size1.y;
        }
        else
        {
                mem[32] = this;
            mem[40] = pos1.x;
            mem[1152921526413925340] = pos1.y;
            mem[48] = pos2.x;
            mem[1152921526413925348] = pos2.y;
            mem[56] = size1.x;
            mem[1152921526413925356] = size1.y;
        }
        
        .size2 = size2;
        mem[1152921526413925364] = size2.y;
        return (System.Collections.IEnumerator)val_1;
    }
    public System.Collections.IEnumerator BallSwap(UnityEngine.Vector2 pos1, UnityEngine.Vector2 pos2, UnityEngine.Vector2 size1, UnityEngine.Vector2 size2)
    {
        BallSwipeVs.<BallSwap>d__48 val_1 = new BallSwipeVs.<BallSwap>d__48();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .pos1 = pos1;
            mem[1152921526414045532] = pos1.y;
            .pos2 = pos2;
            mem[1152921526414045540] = pos2.y;
            .size1 = size1;
            mem[1152921526414045548] = size1.y;
        }
        else
        {
                mem[32] = this;
            mem[40] = pos1.x;
            mem[1152921526414045532] = pos1.y;
            mem[48] = pos2.x;
            mem[1152921526414045540] = pos2.y;
            mem[56] = size1.x;
            mem[1152921526414045548] = size1.y;
        }
        
        .size2 = size2;
        mem[1152921526414045556] = size2.y;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator BallSwapWithNewBall(UnityEngine.Vector2 pos1, UnityEngine.Vector2 pos2, UnityEngine.Vector2 size1, UnityEngine.Vector2 size2, int networkTag)
    {
        BallSwipeVs.<BallSwapWithNewBall>d__49 val_1 = new BallSwipeVs.<BallSwapWithNewBall>d__49();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .pos1 = pos1;
            mem[1152921526414165728] = pos1.y;
            .pos2 = pos2;
            mem[1152921526414165736] = pos2.y;
            .size1 = size1;
            mem[1152921526414165744] = size1.y;
            .size2 = size2;
            mem[1152921526414165752] = size2.y;
        }
        else
        {
                mem[32] = this;
            .pos1 = pos1;
            mem[48] = pos1.y;
            .pos2 = pos2;
            mem[56] = pos2.y;
            .size1 = size1;
            mem[64] = size1.y;
            .size2 = size2;
            mem[72] = size2.y;
        }
        
        .networkTag = networkTag;
        return (System.Collections.IEnumerator)val_1;
    }
    private void receiveTag(int tag)
    {
        string val_2;
        string val_3;
        if((tag - 1) <= 5)
        {
                var val_2 = 40829712 + ((tag - 1)) << 2;
            val_2 = val_2 + 40829712;
        }
        else
        {
                val_2 = "B";
            val_3 = "Blue";
            this.ballTag = ;
            this.ballTagColor = ;
        }
    
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
        UnityEngine.GameObject val_1 = static_value_03331020.gameObject;
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
    public BallSwipeVs()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }
    private static BallSwipeVs()
    {
    
    }

}
