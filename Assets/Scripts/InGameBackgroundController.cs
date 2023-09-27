using UnityEngine;
public class InGameBackgroundController : MonoBehaviour
{
    // Fields
    private static InGameBackgroundController _inst;
    public float scrollSpeed;
    public UnityEngine.RectTransform loopTransform;
    public UnityEngine.Color puzzleColor;
    public UnityEngine.Color extremeColor;
    public UnityEngine.Color inkColor;
    private System.Collections.Generic.List<UnityEngine.UI.Image> images;
    private UnityEngine.Canvas canvas;
    private UnityEngine.Color currentBGColor;
    
    // Properties
    public static InGameBackgroundController instance { get; set; }
    
    // Methods
    public static InGameBackgroundController get_instance()
    {
        InGameBackgroundController val_4 = InGameBackgroundController._inst;
        if(0 != val_4)
        {
                return (InGameBackgroundController)InGameBackgroundController._inst;
        }
        
        UnityEngine.GameObject val_2 = null;
        val_4 = val_2;
        val_2 = new UnityEngine.GameObject(name:  "InGameBackgroundController");
        InGameBackgroundController._inst = val_2.AddComponent<InGameBackgroundController>();
        return (InGameBackgroundController)InGameBackgroundController._inst;
    }
    private static void set_instance(InGameBackgroundController value)
    {
        InGameBackgroundController._inst = value;
    }
    private void Awake()
    {
        if(0 == InGameBackgroundController._inst)
        {
                InGameBackgroundController._inst = this;
            this.canvas = this.GetComponent<UnityEngine.Canvas>();
            return;
        }
        
        UnityEngine.Object.Destroy(obj:  this);
    }
    private void Start()
    {
        this.InitializeStage();
    }
    public void InitializeStage()
    {
        this.InitImages();
        this.SetupByMode();
        this.StartLoopAnimation();
    }
    private void Update()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.canvas)) == false)
        {
                return;
        }
        
        if(this.canvas.worldCamera != 0)
        {
                return;
        }
        
        this.canvas.worldCamera = UnityEngine.Camera.main;
    }
    private void OnDestroy()
    {
        if(this != InGameBackgroundController._inst)
        {
                return;
        }
        
        InGameBackgroundController._inst = 0;
    }
    public void SetBackgroundImageColor(UnityEngine.Color aNewColor, float duration, DG.Tweening.Ease ease = 1)
    {
        List.Enumerator<T> val_1 = this.images.GetEnumerator();
        label_6:
        if(((-1895152168) & 1) == 0)
        {
            goto label_2;
        }
        
        System.Type val_2 = 0.InitialType;
        if(0 == val_2)
        {
            goto label_6;
        }
        
        DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOColor(target:  val_2, endValue:  new UnityEngine.Color() {r = aNewColor.r, g = aNewColor.g, b = aNewColor.b, a = aNewColor.a}, duration:  duration), ease:  ease = ease);
        goto label_6;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Image>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    public DG.Tweening.Tweener PlayPureColorFlash(UnityEngine.Color fromColor, UnityEngine.Color toColor, float duration, int loop, DG.Tweening.LoopType loopType)
    {
        UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "ColorFlash");
        .img = val_2.AddComponent<UnityEngine.UI.Image>();
        val_2.transform.SetParent(p:  this.transform);
        val_2.transform.SetAsLastSibling();
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        (InGameBackgroundController.<>c__DisplayClass18_0)[1152921528481770528].img.rectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.one;
        (InGameBackgroundController.<>c__DisplayClass18_0)[1152921528481770528].img.rectTransform.anchorMax = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
        (InGameBackgroundController.<>c__DisplayClass18_0)[1152921528481770528].img.rectTransform.anchorMin = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.zero;
        (InGameBackgroundController.<>c__DisplayClass18_0)[1152921528481770528].img.rectTransform.offsetMax = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.zero;
        (InGameBackgroundController.<>c__DisplayClass18_0)[1152921528481770528].img.rectTransform.offsetMin = new UnityEngine.Vector2() {x = val_16.x, y = val_16.y};
        (InGameBackgroundController.<>c__DisplayClass18_0)[1152921528481770528].img.color = new UnityEngine.Color() {r = fromColor.r, g = fromColor.g, b = fromColor.b, a = fromColor.a};
        return DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOColor(target:  (InGameBackgroundController.<>c__DisplayClass18_0)[1152921528481770528].img, endValue:  new UnityEngine.Color() {r = toColor.r, g = toColor.g, b = toColor.b, a = toColor.a}, duration:  duration), loops:  loop, loopType:  loopType), action:  new DG.Tweening.TweenCallback(object:  new InGameBackgroundController.<>c__DisplayClass18_0(), method:  System.Void InGameBackgroundController.<>c__DisplayClass18_0::<PlayPureColorFlash>b__0()));
    }
    public void EnableInkSequenceDark(bool enable)
    {
        UnityEngine.Color val_1;
        var val_2;
        var val_3;
        var val_4;
        if(enable != false)
        {
                val_1 = this.inkColor;
            val_2 = 1152921528481936620;
            val_3 = 1152921528481936624;
            val_4 = 1152921528481936628;
        }
        else
        {
                val_1 = this.currentBGColor;
            val_2 = 1152921528481936652;
            val_3 = 1152921528481936656;
            val_4 = 1152921528481936660;
        }
        
        this.SetBackgroundImageColor(aNewColor:  new UnityEngine.Color() {r = this.currentBGColor.r, g = 4.79103E-21f, b = 4.79103E-21f, a = 4.79103E-21f}, duration:  0.5f, ease:  1);
    }
    private void InitImages()
    {
        UnityEngine.Sprite val_45;
        System.Collections.Generic.IEnumerable<T> val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        int val_51;
        var val_52;
        var val_54;
        UnityEngine.RectTransform val_55;
        var val_57;
        StageInfo val_58;
        int val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        int val_68;
        val_45 = this;
        if(0 == this.loopTransform)
        {
                return;
        }
        
        val_46 = this.loopTransform.GetComponentsInChildren<UnityEngine.UI.Image>();
        this.images.AddRange(collection:  val_46);
        if(0 == this.images.Item[0])
        {
                return;
        }
        
        val_47 = null;
        val_47 = null;
        if((Character_GlobalInfo.gameMode - 1) < 4)
        {
            goto label_14;
        }
        
        if(Character_GlobalInfo.gameMode != 10)
        {
                if(Character_GlobalInfo.gameMode != 6)
        {
            goto label_14;
        }
        
        }
        
        val_48 = null;
        val_48 = null;
        val_49 = null;
        val_49 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = DataStructs.UserDataDictionary.Settings.SelectedBackgroundImage;
        val_50 = 1152921528273625936;
        StageData val_9 = GameInfo.stage.GetItemDataById(uniqueId:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue, inited = val_7.inited}));
        NetworkUserInfo val_10 = CloudOpponent.current;
        val_51 = val_10.stageID;
        StageData val_11 = GameInfo.stage.GetItemDataById(uniqueId:  val_51);
        var val_12 = (val_9 == 0) ? 1 : 0;
        if((val_11 == null) || ((val_12 & 1) != 0))
        {
            goto label_26;
        }
        
        object[] val_13 = new object[4];
        val_13[0] = 1152921505099071488;
        val_13[1] = val_13.Length;
        val_13[2] = val_13.Length;
        val_13[3] = val_13.Length;
        UnityEngine.Debug.LogFormat(format:  ">>>> BACKGROUND - {0}({1})::{2}({3})", args:  val_13);
        int val_14 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = -1894349136, hiddenValue = 268435461, fakeValue = -1894340912, inited = true});
        int val_16 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.__il2cppRuntimeField_cctor_finished, hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.__il2cppRuntimeField_cctor_finished, fakeValue = -1894340912, inited = true});
        object[] val_18 = new object[2];
        val_18[0] = (val_14 != 0) ? 1 : 0;
        val_18[1] = (val_16 != 0) ? 1 : 0;
        UnityEngine.Debug.LogFormat(format:  "Player 1 Priority: {0} - Player 2 Priority: {1}", args:  val_18);
        if(((val_16 | val_14) == 0) || ((((val_14 != 0) ? 1 : 0) & ((val_16 != 0) ? 1 : 0)) != 0))
        {
            goto label_53;
        }
        
        if((val_16 != 0) || (val_14 == 0))
        {
            goto label_55;
        }
        
        val_52 = 1152921505062117376;
        goto label_56;
        label_14:
        val_54 = null;
        val_54 = null;
        val_47 = null;
        val_55 = 0;
        StageData val_25 = GameInfo.stage.GetStageDataByLevelId(levelId:  Character_GlobalInfo.stage_CurrentLevel - 1);
        goto label_62;
        label_26:
        val_12 = ((val_11 == 0) ? 1 : 0) & val_12;
        if((val_12 & 1) == 0)
        {
            goto label_63;
        }
        
        val_57 = null;
        val_57 = null;
        val_58 = GameInfo.stage;
        if(val_58 == null)
        {
            goto label_66;
        }
        
        val_59 = val_58.GetRandomDefaultIds();
        goto label_105;
        label_53:
        val_50 = 1152921528273625936;
        val_60 = 1152921505160353216;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_16, hiddenValue = val_16, fakeValue = val_14, inited = val_14})) <= (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.__il2cppRuntimeField_cctor_finished, hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.__il2cppRuntimeField_cctor_finished, fakeValue = val_14, inited = val_14})))
        {
            goto label_70;
        }
        
        val_61 = null;
        goto label_71;
        label_63:
        var val_30 = (val_9 != 0) ? (val_9) : (val_11);
        int val_31 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_9 != null ? val_9 : val_11 + 40, hiddenValue = val_9 != null ? val_9 : val_11 + 40, fakeValue = val_9 != null ? val_9 : val_11 + 40 + 8, inited = val_9 != null ? val_9 : val_11 + 40 + 8});
        val_62 = null;
        val_62 = null;
        val_63 = GameInfo.stage.GetItemDataById(uniqueId:  val_31);
        object[] val_33 = new object[2];
        val_33[0] = (val_9 != 0) ? "Player 1" : "Player 2";
        val_51 = val_31;
        val_33[1] = val_51;
        val_55 = 0;
        UnityEngine.Debug.LogFormat(format:  "Only find background image data for {0}, play {1}", args:  val_33);
        if(val_63 != null)
        {
            goto label_114;
        }
        
        goto label_88;
        label_55:
        val_52 = 1152921505062117376;
        label_56:
        val_50 = 1152921528273625936;
        val_60 = 1152921505160353216;
        val_64 = 1152921504844599296;
        val_65 = 1152921505099071488;
        goto label_107;
        label_70:
        val_61 = null;
        label_71:
        val_65 = 1152921505099071488;
        val_64 = 1152921504844599296;
        label_107:
        val_59 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_14, hiddenValue = val_14, fakeValue = val_9, inited = val_9});
        object[] val_36 = new object[2];
        val_36[0] = new StageData();
        val_36[1] = val_59;
        UnityEngine.Debug.LogFormat(format:  "Game Stage - Data: {0} - ID: {1}", args:  val_36);
        val_66 = null;
        val_58 = GameInfo.stage;
        if(val_58 != null)
        {
            goto label_105;
        }
        
        goto label_106;
        label_66:
        val_59 = 0.GetRandomDefaultIds();
        label_106:
        label_105:
        label_62:
        val_63 = val_58.GetItemDataById(uniqueId:  val_59);
        if(val_63 != null)
        {
            goto label_114;
        }
        
        label_88:
        val_67 = null;
        val_67 = null;
        if(GameInfo.stage != null)
        {
                val_68 = GameInfo.stage.GetRandomDefaultIds();
        }
        else
        {
                val_68 = 0.GetRandomDefaultIds();
        }
        
        val_55 = public StageData GameItemInfo<StageData, UnityEngine.Sprite>::GetItemDataById(int uniqueId);
        val_63 = GameInfo.stage.GetItemDataById(uniqueId:  val_68);
        label_114:
        val_45 = val_63.LoadStageSprite();
        List.Enumerator<T> val_43 = this.images.GetEnumerator();
        val_46 = 1152921528181818592;
        label_118:
        if(((-1894466984) & 1) == 0)
        {
            goto label_116;
        }
        
        0.InitialType.sprite = val_45;
        goto label_118;
        label_116:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Image>::Dispose(), rectTransform:  val_55, drivenProperties:  null);
    }
    private void SetupByMode()
    {
        var val_2;
        GameMode val_3;
        UnityEngine.Color val_4;
        var val_5;
        var val_6;
        var val_7;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.currentBGColor = val_1;
        mem[1152921528482451436] = val_1.g;
        mem[1152921528482451440] = val_1.b;
        mem[1152921528482451444] = val_1.a;
        val_2 = null;
        val_2 = null;
        val_3 = Character_GlobalInfo.gameMode;
        if(val_3 != 4)
        {
            goto label_3;
        }
        
        float val_2 = this.scrollSpeed;
        val_4 = this.extremeColor;
        val_5 = 1152921528482451388;
        val_2 = val_2 * 0.5f;
        val_6 = 1152921528482451392;
        this.scrollSpeed = val_2;
        val_7 = 1152921528482451396;
        goto label_4;
        label_3:
        val_3 = Character_GlobalInfo.gameMode;
        if(val_3 != 3)
        {
            goto label_7;
        }
        
        val_4 = this.puzzleColor;
        val_5 = 1152921528482451372;
        val_6 = 1152921528482451376;
        val_7 = 1152921528482451380;
        label_4:
        this.currentBGColor = this.puzzleColor.r;
        mem[1152921528482451436] = null;
        mem[1152921528482451440] = null;
        mem[1152921528482451444] = null;
        goto label_8;
        label_7:
        label_8:
        this.SetBackgroundImageColor(aNewColor:  new UnityEngine.Color() {r = this.currentBGColor, g = val_1.g, b = val_1.b, a = val_1.a}, duration:  0f, ease:  1);
    }
    private void StartLoopAnimation()
    {
        float val_9;
        UnityEngine.Vector2 val_3 = this.images.Item[0].GetComponent<UnityEngine.RectTransform>().sizeDelta;
        val_9 = this.scrollSpeed;
        if(val_9 < 0)
        {
                DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOLocalMoveX(target:  this.loopTransform, endValue:  -val_3.x, duration:  0f, snapping:  false);
            val_9 = this.scrollSpeed;
        }
        
        float val_10 = 0f;
        val_10 = val_3.x * ((val_9 > 0f) ? -1f : (val_10));
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveX(target:  this.loopTransform, endValue:  val_10, duration:  System.Math.Abs(val_9), snapping:  false), loops:  0, loopType:  0), ease:  1);
    }
    public InGameBackgroundController()
    {
        this.scrollSpeed = 60f;
        this.images = new System.Collections.Generic.List<UnityEngine.UI.Image>();
    }

}
