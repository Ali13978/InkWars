using UnityEngine;
public class CharacterSelect : MonoBehaviour
{
    // Fields
    public bool PlayModelScene;
    public static CharacterSelect instance;
    public UnityEngine.GameObject lanObjectsHolder;
    public UnityEngine.UI.Text userName;
    public UnityEngine.GameObject backButtonLocal;
    public string[] animPath;
    public UnityEngine.UI.Image leftDetailedStats;
    public UnityEngine.UI.Image rightDetailedStats;
    public UnityEngine.Sprite[] leftDetailedStatsArray;
    public UnityEngine.Sprite[] rightDetailedStatsArray;
    private int selectionTime;
    public UnityEngine.UI.Text selectionTimer;
    public UnityEngine.AudioClip backgroundMusic;
    public bool canSelect;
    public bool canSelectRight;
    public bool canSelectLeft;
    public UnityEngine.GameObject LeftConfirm;
    public UnityEngine.GameObject RightConfirm;
    public UnityEngine.GameObject Title;
    public UnityEngine.CanvasGroup LeftMiddleSuper;
    public UnityEngine.CanvasGroup RightMiddleSuper;
    public UnityEngine.GameObject VS;
    public UnityEngine.GameObject LeftRollIn;
    public UnityEngine.GameObject RightRollIn;
    public UnityEngine.GameObject LeftRollInTarget;
    public UnityEngine.GameObject RightRollInTarget;
    public UnityEngine.GameObject LeftCharacters;
    public UnityEngine.GameObject RightCharacters;
    public UnityEngine.GameObject VSImage;
    public UnityEngine.GameObject ConfirmButtonGroup;
    public UnityEngine.GameObject BlueScrollUp;
    public System.Collections.Generic.List<ChainBounce> bounceList;
    public UnityEngine.UI.Text RightShells;
    public UnityEngine.UI.Text[] RightCharacterNickname;
    public UnityEngine.UI.Text RightWins;
    public UnityEngine.UI.Text RightDraws;
    public UnityEngine.UI.Text RightLoses;
    public UnityEngine.Sprite[] RightCharacterStats;
    public System.Collections.Generic.List<UnityEngine.RuntimeAnimatorController> animClips;
    public UnityEngine.Animator RightCurrentSelectionIdleAnimation;
    public UnityEngine.UI.Image RightCurrentSelectionStats;
    public CharacterNameController RightCurrentSelectionName;
    public UnityEngine.GameObject RightNameSlider;
    public UnityEngine.GameObject RightCharGlow;
    public UnityEngine.UI.Image RightClanSymbol;
    public UnityEngine.SpriteRenderer RightCurrentSelectionIdle;
    public CharacterNameID RightCurrentSelection;
    public bool rightLocked;
    public UnityEngine.UI.Text LeftShells;
    public UnityEngine.UI.Text[] LeftCharacterNickname;
    public UnityEngine.UI.Text LeftWins;
    public UnityEngine.UI.Text LeftDraws;
    public UnityEngine.UI.Text LeftLoses;
    public UnityEngine.Sprite[] LeftCharacterStats;
    public UnityEngine.UI.Image LeftCurrentSelectionStats;
    public CharacterNameController LeftCurrentSelectionName;
    public UnityEngine.GameObject LeftNameSlider;
    public UnityEngine.GameObject LeftCharGlow;
    public UnityEngine.UI.Image LeftClanSymbol;
    public UnityEngine.Animator LeftCurrentSelectionIdleAnimation;
    public UnityEngine.SpriteRenderer LeftCurrentSelectionIdle;
    public CharacterNameID LeftCurrentSelection;
    public bool leftLocked;
    private bool setUp;
    private bool bDisableUpdate;
    public bool networkBothPlayersSceneLoaded;
    public string[] CharacterNamesStrings;
    private UnityEngine.Vector3 scaleToBeL;
    private UnityEngine.Vector3 scaleToBeR;
    public UnityEngine.GameObject leftBuyButtons;
    public UnityEngine.GameObject rightBuyButtons;
    public TwitterFollowButton twitterController;
    public CharAnimationController animControllerLeft;
    public CharAnimationController animControllerRight;
    public CharacterSelect_CharacterController startingLeftCharacter;
    public CharacterSelect_CharacterController startingRightCharacter;
    public CharacterSelect_CharacterController startingRightCharacter_Networked;
    public CharacterSelect_CharacterController leftSelectedCharacterController;
    public CharacterSelect_CharacterController rightSelectedCharacterController;
    private UnityEngine.GameObject unlockButtonLeft;
    private UnityEngine.GameObject unlockButtonRight;
    private UnityEngine.Vector3 animScaleLeft;
    private UnityEngine.Vector3 animScaleRight;
    private bool doNotTweenAnims;
    private bool hasSetUpScreen;
    private float statSize;
    internal bool ImagesTransferred;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Time.timeScale = 1f;
        if((UnityEngine.Object.op_Implicit(exists:  CharacterSelect.instance)) != false)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
            return;
        }
        
        CharacterSelect.instance = this;
    }
    private void OnEnable()
    {
        null = null;
        GGPPurchasingManager.OnPurchaseSuccess.AddListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void CharacterSelect::OnPurchaseSuccess(IAPItemIds id)));
    }
    private void OnDisable()
    {
        null = null;
        GGPPurchasingManager.OnPurchaseSuccess.RemoveListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void CharacterSelect::OnPurchaseSuccess(IAPItemIds id)));
    }
    public void OnCharacterUnlocked()
    {
    
    }
    private void OnPurchaseSuccess(IAPItemIds id)
    {
    
    }
    private void Start()
    {
        var val_35;
        UnityEngine.UI.Text[] val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        UnityEngine.AudioClip val_41;
        val_35 = 1152921526025788224;
        this.LeftConfirm.GetComponent<UnityEngine.UI.Button>().interactable = false;
        if((UnityEngine.Object.op_Implicit(exists:  this.RightConfirm)) != false)
        {
                this.RightConfirm.GetComponent<UnityEngine.UI.Button>().interactable = false;
        }
        
        if(NetworkManager_Custom.IsNetwork == false)
        {
            goto label_58;
        }
        
        if(this.LeftCharacterNickname == null)
        {
            goto label_10;
        }
        
        val_36 = this.RightCharacterNickname;
        if(val_36 == null)
        {
            goto label_10;
        }
        
        if(this.LeftCharacterNickname.Length >= 1)
        {
                do
        {
            UnityEngine.UI.Text val_36 = this.LeftCharacterNickname[0];
            val_35 = PlayerPrefsManager.PlayerName;
        }
        while((0 + 1) < this.LeftCharacterNickname.Length);
        
            val_36 = this.RightCharacterNickname;
        }
        
        val_37 = 0;
        goto label_15;
        label_19:
        UnityEngine.UI.Text val_37 = val_36[0];
        val_35 = PlayerPrefsManager.Player2Name;
        val_37 = 1;
        label_15:
        if(val_37 < this.RightCharacterNickname.Length)
        {
            goto label_19;
        }
        
        label_10:
        if((UnityEngine.Object.op_Implicit(exists:  this.LeftWins)) != false)
        {
                val_38 = null;
            val_38 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = DataStructs.UserDataDictionary.Stats.TotalPVPWins;
            val_35 = val_9.currentCryptoKey.ToString();
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.LeftDraws)) != false)
        {
                val_39 = null;
            val_39 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_12 = DataStructs.UserDataDictionary.Stats.TotalPVPDraws;
            val_35 = val_12.currentCryptoKey.ToString();
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.LeftLoses)) != false)
        {
                val_40 = null;
            val_40 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_15 = DataStructs.UserDataDictionary.Stats.TotalPVPLosses;
            val_35 = val_15.currentCryptoKey.ToString();
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.RightWins)) != false)
        {
                val_35 = PlayerPrefsManager.Player2Wins.ToString();
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.RightDraws)) != false)
        {
                val_35 = PlayerPrefsManager.Player2Draws.ToString();
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.RightLoses)) != false)
        {
                val_35 = PlayerPrefsManager.Player2Loses.ToString();
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.LeftShells)) != false)
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.RightShells)) != false)
        {
                string val_29 = PlayerPrefsManager.GetShellString(shells:  PlayerPrefsManager.Shells);
            val_35 = PlayerPrefsManager.GetShellString(shells:  PlayerPrefsManager.Player2Shells);
        }
        
        }
        
        label_58:
        val_41 = this.backgroundMusic;
        GameAudio.SwitchMusic(clip:  val_41, customLoopStartTime:  0f, customLoopEndTime:  0f, forcePlay:  false);
        if(NetworkManager_Custom.IsNetwork == false)
        {
                return;
        }
        
        val_41 = UnityEngine.Resources.Load(path:  "BattleVSGates", systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        UnityEngine.Object val_35 = UnityEngine.Object.Instantiate(original:  val_41);
    }
    public void StartSceneNetwork()
    {
        this.networkBothPlayersSceneLoaded = true;
    }
    private System.Collections.IEnumerator LoadSelectStage()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new CharacterSelect.<LoadSelectStage>d__91();
    }
    public void StartTransferToSceneSelect()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.TransferImagesToSceneSelect());
    }
    private System.Collections.IEnumerator TransferImagesToSceneSelect()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new CharacterSelect.<TransferImagesToSceneSelect>d__93();
    }
    private void Update()
    {
        var val_7;
        if(this.setUp != true)
        {
                if(NetworkManager_Custom.IsNetwork != false)
        {
                if(this.networkBothPlayersSceneLoaded == false)
        {
            goto label_3;
        }
        
        }
        
            this.setUp = true;
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.SetUpScreen());
        }
        
        label_3:
        if(this.leftLocked == false)
        {
                return;
        }
        
        if(this.rightLocked == false)
        {
                return;
        }
        
        if(this.bDisableUpdate == true)
        {
                return;
        }
        
        if(NetworkManager_Custom.IsNetwork != true)
        {
                this.backButtonLocal.SetActive(value:  false);
            val_7 = null;
            val_7 = null;
            Character_GlobalInfo.gameMode = 5;
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.LoadSelectStage());
        }
        
        this.bDisableUpdate = true;
    }
    private void TimeControl()
    {
        int val_2 = this.selectionTime;
        val_2 = val_2 - 1;
        this.selectionTime = val_2;
        string val_1 = this.selectionTime.ToString(format:  "D2");
        if(this.selectionTime > 0)
        {
                return;
        }
        
        this.SideTickedSFX(leftSide:  true, playButtonSfx:  false);
        this.CancelInvoke(methodName:  "TimeControl");
    }
    private void RollIn()
    {
        float val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        UnityEngine.GameObject val_60;
        System.Object[] val_61;
        object val_62;
        var val_64;
        object val_66;
        UnityEngine.Quaternion val_2 = this.LeftRollIn.GetComponent<UnityEngine.RectTransform>().localRotation;
        this.LeftRollIn.GetComponent<UnityEngine.RectTransform>().localRotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = 180f, w = val_2.w};
        UnityEngine.Quaternion val_5 = this.RightRollIn.GetComponent<UnityEngine.RectTransform>().localRotation;
        val_54 = val_5.x;
        this.RightRollIn.GetComponent<UnityEngine.RectTransform>().localRotation = new UnityEngine.Quaternion() {x = val_54, y = val_5.y, z = -180f, w = val_5.w};
        if(UnityEngine.Camera.main.aspect >= 2f)
        {
            goto label_10;
        }
        
        if((double)UnityEngine.Camera.main.aspect >= 1.69)
        {
            goto label_12;
        }
        
        if((double)UnityEngine.Camera.main.aspect >= 1.59)
        {
            goto label_14;
        }
        
        UnityEngine.Debug.Log(message:  "4:3");
        object[] val_13 = new object[8];
        val_13[0] = "position";
        val_13[1] = 0;
        val_55 = "islocal";
        val_13[2] = "islocal";
        val_13[3] = true;
        val_56 = "time";
        val_13[4] = "time";
        val_57 = 1152921504621490176;
        val_13[5] = 1;
        val_58 = "easetype";
        val_13[6] = "easetype";
        val_59 = 1152921505059934208;
        val_13[7] = 24;
        iTween.MoveTo(target:  this.LeftRollIn, args:  iTween.Hash(args:  val_13));
        val_60 = this.RightRollIn;
        val_61 = new object[8];
        val_62 = "position";
        if(val_15.Length != 0)
        {
            goto label_48;
        }
        
        goto label_48;
        label_10:
        UnityEngine.Debug.Log(message:  "18.5:9");
        this.LeftRollIn.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.RightRollIn.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.LeftCharacters.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.RightCharacters.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  -133f, y:  58f);
        this.LeftCharacters.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_21.x, y = val_21.y};
        UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  133f, y:  58f);
        this.RightCharacters.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_23.x, y = val_23.y};
        UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  0f, y:  40f);
        this.ConfirmButtonGroup.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_25.x, y = val_25.y};
        UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  0f, y:  35f);
        this.VSImage.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_27.x, y = val_27.y};
        object[] val_28 = new object[8];
        val_54 = 36f;
        val_28[0] = "position";
        val_28[1] = 0;
        val_28[2] = "islocal";
        val_28[3] = true;
        val_28[4] = "time";
        val_28[5] = 1;
        val_28[6] = "easetype";
        val_28[7] = 24;
        iTween.MoveTo(target:  this.LeftRollIn, args:  iTween.Hash(args:  val_28));
        val_60 = this.RightRollIn;
        val_61 = new object[8];
        val_61[0] = "position";
        val_61[1] = 0;
        val_61[2] = "islocal";
        val_61[3] = true;
        val_61[4] = "time";
        val_61[5] = 1;
        val_61[6] = "easetype";
        val_64 = null;
        goto label_116;
        label_12:
        UnityEngine.Debug.Log(message:  "16:9");
        this.LeftRollIn.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.RightRollIn.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.LeftCharacters.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.RightCharacters.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_54 = 40f;
        UnityEngine.Vector2 val_36 = new UnityEngine.Vector2(x:  -22f, y:  val_54);
        this.LeftCharacters.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_36.x, y = val_36.y};
        UnityEngine.Vector2 val_38 = new UnityEngine.Vector2(x:  22f, y:  val_54);
        this.RightCharacters.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_38.x, y = val_38.y};
        UnityEngine.Vector2 val_40 = new UnityEngine.Vector2(x:  0f, y:  val_54);
        this.ConfirmButtonGroup.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_40.x, y = val_40.y};
        UnityEngine.Vector2 val_42 = new UnityEngine.Vector2(x:  0f, y:  35f);
        this.VSImage.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_42.x, y = val_42.y};
        object[] val_43 = new object[8];
        val_43[0] = "position";
        val_43[1] = 0;
        val_43[2] = "islocal";
        val_43[3] = true;
        val_43[4] = "time";
        val_43[5] = 1;
        val_43[6] = "easetype";
        val_43[7] = 24;
        iTween.MoveTo(target:  this.LeftRollIn, args:  iTween.Hash(args:  val_43));
        val_60 = this.RightRollIn;
        val_61 = new object[8];
        val_61[0] = "position";
        val_61[1] = 0;
        val_61[2] = "islocal";
        val_61[3] = true;
        val_61[4] = "time";
        val_61[5] = 1;
        val_61[6] = "easetype";
        val_66 = 24;
        if(val_45.Length <= 7)
        {
            goto label_186;
        }
        
        goto label_241;
        label_14:
        UnityEngine.Debug.Log(message:  "16:10");
        object[] val_46 = new object[8];
        val_46[0] = "position";
        val_46[1] = 0;
        val_55 = "islocal";
        val_46[2] = "islocal";
        val_46[3] = true;
        val_56 = "time";
        val_46[4] = "time";
        val_57 = 1152921504621490176;
        val_46[5] = 1;
        val_58 = "easetype";
        val_46[6] = "easetype";
        val_59 = 1152921505059934208;
        val_46[7] = 24;
        iTween.MoveTo(target:  this.LeftRollIn, args:  iTween.Hash(args:  val_46));
        val_60 = this.RightRollIn;
        object[] val_48 = new object[8];
        val_61 = val_48;
        val_62 = "position";
        label_48:
        val_61[0] = val_62;
        val_61[1] = 0;
        val_61[2] = "islocal";
        val_61[3] = true;
        val_61[4] = "time";
        val_61[5] = 1;
        val_61[6] = "easetype";
        label_116:
        val_66 = 24;
        if(val_48.Length > 7)
        {
            goto label_241;
        }
        
        label_186:
        label_241:
        val_61[7] = val_66;
        iTween.MoveTo(target:  val_60, args:  iTween.Hash(args:  val_48));
        object[] val_50 = new object[8];
        val_50[0] = "rotation";
        val_50[1] = 0;
        val_50[2] = "islocal";
        val_50[3] = null;
        val_50[4] = "time";
        val_50[5] = 1;
        val_50[6] = "easetype";
        val_50[7] = 24;
        iTween.RotateTo(target:  this.LeftRollIn, args:  iTween.Hash(args:  val_50));
        object[] val_52 = new object[8];
        val_52[0] = "rotation";
        val_52[1] = 0;
        val_52[2] = "islocal";
        val_52[3] = null;
        val_52[4] = "time";
        val_52[5] = 1;
        val_52[6] = "easetype";
        val_52[7] = 24;
        iTween.RotateTo(target:  this.RightRollIn, args:  iTween.Hash(args:  val_52));
    }
    private void ScrollUp()
    {
        object[] val_1 = new object[6];
        val_1[0] = "position";
        val_1[1] = 0;
        val_1[2] = "islocal";
        val_1[3] = true;
        val_1[4] = "time";
        val_1[5] = 1;
        iTween.MoveTo(target:  this.BlueScrollUp, args:  iTween.Hash(args:  val_1));
    }
    private void IconShow()
    {
        var val_6;
        System.Collections.Generic.List<ChainBounce> val_8;
        val_6 = null;
        val_6 = null;
        if((CharacterSelect.<>c.<>9__98_0) == null)
        {
            goto label_3;
        }
        
        label_12:
        int val_1 = this.bounceList.RemoveAll(match:  CharacterSelect.<>c.<>9__98_0);
        val_8 = this.bounceList;
        List.Enumerator<T> val_2 = val_8.GetEnumerator();
        label_8:
        if(((-2578584) & 1) == 0)
        {
            goto label_6;
        }
        
        DG.Tweening.Sequence val_4 = 0.InitialType.PlayAnimationAlpha(fromScale:  null, toScale:  1f, duration:  0.5f, delay:  0.08f);
        goto label_8;
        label_3:
        CharacterSelect.<>c.<>9__98_0 = new System.Predicate<ChainBounce>(object:  CharacterSelect.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CharacterSelect.<>c::<IconShow>b__98_0(ChainBounce x));
        if(this.bounceList != null)
        {
            goto label_12;
        }
        
        goto label_12;
        label_6:
        0.Add(driver:  public System.Void List.Enumerator<ChainBounce>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<ChainBounce>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
    }
    private void BotBar()
    {
        this.Title.SetActive(value:  true);
        this.VS.SetActive(value:  true);
        object[] val_1 = new object[6];
        val_1[0] = "scale";
        val_1[1] = 0;
        val_1[2] = "time";
        val_1[3] = 2f;
        val_1[4] = "easetype";
        val_1[5] = 30;
        iTween.ScaleTo(target:  this.VS, args:  iTween.Hash(args:  val_1));
    }
    private void BounceInConfirmButton()
    {
        this.LeftConfirm.GetComponent<ButtonBounce>().StartBounce();
        if((UnityEngine.Object.op_Implicit(exists:  this.RightConfirm)) == false)
        {
                return;
        }
        
        this.RightConfirm.GetComponent<ButtonBounce>().StartBounce();
    }
    public void SetITweenCharacterLeft()
    {
        UnityEngine.GameObject val_6;
        if(this.doNotTweenAnims == true)
        {
                return;
        }
        
        this.animControllerLeft.gameObject.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_6 = this.animControllerLeft.gameObject;
        object[] val_4 = new object[8];
        val_4[0] = "x";
        val_4[1] = this.animScaleLeft;
        val_4[2] = "y";
        val_4[3] = val_4.Length;
        val_4[4] = "easeType";
        val_4[5] = 30;
        val_4[6] = "time";
        this = 0.8f;
        val_4[7] = this;
        iTween.ScaleTo(target:  val_6, args:  iTween.Hash(args:  val_4));
    }
    public void SetITweenCharacterRight()
    {
        UnityEngine.GameObject val_6;
        if(this.doNotTweenAnims == true)
        {
                return;
        }
        
        this.animControllerRight.gameObject.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_6 = this.animControllerRight.gameObject;
        object[] val_4 = new object[8];
        val_4[0] = "x";
        val_4[1] = this.animScaleRight;
        val_4[2] = "y";
        val_4[3] = val_4.Length;
        val_4[4] = "easeType";
        val_4[5] = 30;
        val_4[6] = "time";
        this = 0.8f;
        val_4[7] = this;
        iTween.ScaleTo(target:  val_6, args:  iTween.Hash(args:  val_4));
    }
    private void CharactersShow()
    {
        this.animControllerLeft.gameObject.SetActive(value:  true);
        this.animControllerRight.gameObject.SetActive(value:  true);
        this.SetITweenCharacterLeft();
        this.SetITweenCharacterRight();
        this.LeftClanSymbol.gameObject.SetActive(value:  true);
        this.RightClanSymbol.gameObject.SetActive(value:  true);
        this.LeftCurrentSelectionStats.gameObject.SetActive(value:  true);
        this.RightCurrentSelectionStats.gameObject.SetActive(value:  true);
        this.LeftCurrentSelectionName.gameObject.SetActive(value:  true);
        this.RightCurrentSelectionName.gameObject.SetActive(value:  true);
        object[] val_9 = new object[6];
        val_9[0] = "scale";
        val_9[1] = 0;
        val_9[2] = "time";
        val_9[3] = 2f;
        val_9[4] = "easetype";
        val_9[5] = 30;
        iTween.ScaleTo(target:  this.LeftCharGlow, args:  iTween.Hash(args:  val_9));
        object[] val_11 = new object[6];
        val_11[0] = "scale";
        val_11[1] = 0;
        val_11[2] = "time";
        val_11[3] = 2f;
        val_11[4] = "easetype";
        val_11[5] = 30;
        iTween.ScaleTo(target:  this.RightCharGlow, args:  iTween.Hash(args:  val_11));
    }
    public void MoveGlow(bool leftSide, UnityEngine.GameObject ga)
    {
        if(leftSide == false)
        {
            goto label_0;
        }
        
        if(this.LeftCharGlow != null)
        {
            goto label_5;
        }
        
        label_6:
        label_5:
        UnityEngine.Vector3 val_3 = ga.transform.position;
        this.LeftCharGlow.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        return;
        label_0:
        if(this.RightCharGlow != null)
        {
            goto label_5;
        }
        
        goto label_6;
    }
    public void SetGlowEnable(bool leftSide, bool enable)
    {
        if(leftSide == false)
        {
            goto label_0;
        }
        
        if(this.LeftCharGlow != null)
        {
            goto label_3;
        }
        
        label_4:
        label_3:
        this.LeftCharGlow.gameObject.SetActive(value:  enable);
        return;
        label_0:
        if(this.RightCharGlow != null)
        {
            goto label_3;
        }
        
        goto label_4;
    }
    public void SideTicked(bool leftSide)
    {
        this.SideTickedSFX(leftSide:  leftSide, playButtonSfx:  true);
    }
    private void SideTickedSFX(bool leftSide, bool playButtonSfx)
    {
        if(playButtonSfx == true)
        {
            goto label_1;
        }
        
        if(leftSide == false)
        {
            goto label_2;
        }
        
        label_13:
        if(this.leftSelectedCharacterController.ConfirmCharacter() == false)
        {
                return;
        }
        
        this.LeftConfirm.gameObject.GetComponent<UnityEngine.UI.Button>().interactable = false;
        this.CancelInvoke(methodName:  "leftStatPingPong");
        if(NetworkManager_Custom.IsNetwork == false)
        {
                return;
        }
        
        NetworkBehaviour_CharacterSelect.instance.SendCharacterReadyMessage(LeftCurrentSelection:  this.LeftCurrentSelection);
        return;
        label_1:
        GameAudio.PlayButtonSound();
        if(leftSide == true)
        {
            goto label_13;
        }
        
        label_2:
        if(this.rightSelectedCharacterController.ConfirmCharacter() == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.RightConfirm)) != false)
        {
                this.RightConfirm.gameObject.GetComponent<UnityEngine.UI.Button>().interactable = false;
        }
        
        this.CancelInvoke(methodName:  "rightStatPingPong");
    }
    private System.Collections.IEnumerator SetUpScreen()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new CharacterSelect.<SetUpScreen>d__109();
    }
    private void leftStatPingPong()
    {
        float val_8;
        float val_8 = UnityEngine.Time.time;
        val_8 = 2.9f;
        if(this.statSize > val_8)
        {
                float val_2 = this.statSize + (-2.9f);
        }
        else
        {
                val_8 = this.statSize;
        }
        
        val_8 = val_8 + (UnityEngine.Mathf.PingPong(t:  val_8, length:  val_8 - this.statSize));
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_8, y:  val_8);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        this.LeftCurrentSelectionStats.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    private void rightStatPingPong()
    {
        float val_8;
        float val_8 = UnityEngine.Time.time;
        val_8 = 2.9f;
        if(this.statSize > val_8)
        {
                float val_2 = this.statSize + (-2.9f);
        }
        else
        {
                val_8 = this.statSize;
        }
        
        val_8 = val_8 + (UnityEngine.Mathf.PingPong(t:  val_8, length:  val_8 - this.statSize));
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_8, y:  val_8);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        this.RightCurrentSelectionStats.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    private System.Collections.IEnumerator LoadAnimations()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new CharacterSelect.<LoadAnimations>d__114();
    }
    public void leftStatButtonClicked()
    {
        this.leftDetailedStats.sprite = CharacterAssetLoader.LoadResource_CharacterStatTypeDetailed(charNameID:  this.leftSelectedCharacterController.charNameID);
        this.leftDetailedStats.gameObject.SetActive(value:  true);
    }
    public void rightStatButtonClicked()
    {
        this.rightDetailedStats.sprite = CharacterAssetLoader.LoadResource_CharacterStatTypeDetailed(charNameID:  this.rightSelectedCharacterController.charNameID);
        this.rightDetailedStats.gameObject.SetActive(value:  true);
    }
    public void leftStatsCrossButton()
    {
        this.leftDetailedStats.gameObject.SetActive(value:  false);
    }
    public void rightStatsCrossButton()
    {
        this.rightDetailedStats.gameObject.SetActive(value:  false);
    }
    public void BackToModeSelect()
    {
        var val_1;
        var val_2;
        string val_3;
        var val_4;
        GameAudio.PlayButtonSound();
        val_1 = null;
        val_1 = null;
        mainTitle.ShowModeSelectImmediately = false;
        val_2 = null;
        val_2 = null;
        if(Character_GlobalInfo.isOfflineMode != false)
        {
                val_3 = "OfflineTitleScreen";
        }
        else
        {
                val_4 = null;
            val_4 = null;
            mainTitle.ShowModeSelectImmediately = false;
            val_3 = "Menu_Title_Screen";
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  val_3);
    }
    public void SetupBuyButton(bool isLeft, CharacterNameID cid, CharacterSelect_CharacterController selectController)
    {
        UnityEngine.GameObject val_11;
        if(isLeft != false)
        {
                if(0 != this.unlockButtonLeft)
        {
                UnityEngine.Object.Destroy(obj:  this.unlockButtonLeft);
            this.unlockButtonLeft = 0;
        }
        
            val_11 = this.leftBuyButtons;
        }
        else
        {
                if(0 != this.unlockButtonRight)
        {
                UnityEngine.Object.Destroy(obj:  this.unlockButtonRight);
            this.unlockButtonRight = 0;
        }
        
            val_11 = this.rightBuyButtons;
        }
        
        UnityEngine.GameObject val_5 = CharacterSelectBuyButton.SetupBuyButton(cid:  cid, root:  mem[this.rightBuyButtons].transform, OnPurchaseDone:  new UnityEngine.Events.UnityAction(object:  selectController, method:  public System.Void CharacterSelect_CharacterController::SelectCharacter()));
        if(0 == val_5)
        {
                return;
        }
        
        var val_7 = (isLeft != true) ? this.unlockButtonLeft : this.unlockButtonRight;
        mem2[0] = val_5;
        if(0 == (val_5.GetComponent<TwitterFollowButton>()))
        {
                return;
        }
        
        this.twitterController.twitterButtons.Add(item:  val_5.GetComponent<UnityEngine.UI.Button>());
        this.twitterController.RefreshButtonCallbacks();
    }
    public void SetConfirmButtonInteractable(bool isLeftSide, bool enable)
    {
        UnityEngine.Object val_1 = (isLeftSide != true) ? this.LeftConfirm : this.RightConfirm;
        if(0 == val_1)
        {
                return;
        }
        
        UnityEngine.UI.Button val_3 = val_1.GetComponent<UnityEngine.UI.Button>();
        if(0 == val_3)
        {
                return;
        }
        
        val_3.interactable = enable;
    }
    public CharacterSelect()
    {
        this.selectionTime = 20;
        this.canSelectRight = true;
        this.canSelectLeft = true;
        this.bounceList = new System.Collections.Generic.List<ChainBounce>();
        this.animClips = new System.Collections.Generic.List<UnityEngine.RuntimeAnimatorController>();
        this.statSize = 2.9f;
    }

}
