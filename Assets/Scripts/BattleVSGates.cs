using UnityEngine;
public class BattleVSGates : MonoBehaviour
{
    // Fields
    public static BattleVSGates instance;
    public UnityEngine.Canvas Canvas_BattleGates;
    public UnityEngine.GameObject VSImage;
    public UnityEngine.GameObject VSGradient;
    public UnityEngine.GameObject VSParticle;
    public BattleVSGate_Side left;
    public BattleVSGate_Side right;
    private float timerfailsafe;
    private int CrashCounter;
    private float gateCloseTime;
    private float gateOpenTime;
    private bool doingTween;
    private bool LockVsScreen;
    private bool _shutGates;
    public string nextSceneName;
    public bool BattleGatesLoaded;
    public bool ReadyToOpenGates;
    
    // Properties
    public bool shutGates { get; }
    
    // Methods
    public bool get_shutGates()
    {
        return (bool)this._shutGates;
    }
    public void Trigger(bool doNotShowGates)
    {
        bool val_2 = ~doNotShowGates;
        val_2 = val_2 & 1;
        this._shutGates = val_2;
        this.LockVsScreen = false;
        if(doNotShowGates != false)
        {
                return;
        }
        
        GameAudio.SwitchMusicOneShot(clip:  UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Sound/VS Screen (final take)"), forcePlay:  false);
    }
    private void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
        if(BattleVSGates.instance != 0)
        {
                BattleVSGates.instance.KillSwitch();
        }
        
        BattleVSGates.instance = this;
        UnityEngine.RectTransform val_2 = BattleVSGates.instance.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Vector3 val_3 = val_2.localScale;
        mem[1152921526424840964] = val_3.x;
        mem[1152921526424840968] = val_3.y;
        mem[1152921526424840972] = val_3.z;
        UnityEngine.Vector3 val_5 = val_2.GetComponent<UnityEngine.RectTransform>().localScale;
        mem[1152921526424841068] = val_5.x;
        mem[1152921526424841072] = val_5.y;
        mem[1152921526424841076] = val_5.z;
    }
    private void Start()
    {
        this.MoveGatesOutsideOfScreen(instantMove:  true);
        if(NetworkManager_Custom.IsNetwork != false)
        {
                return;
        }
        
        this.LoadCharacterSprites();
    }
    private void Update()
    {
        if(this.LockVsScreen != false)
        {
                return;
        }
        
        if(this.BattleGatesLoaded == false)
        {
                return;
        }
        
        if(this.CrashCounter == 1)
        {
            goto label_3;
        }
        
        if(this.CrashCounter != 0)
        {
                return;
        }
        
        if(this._shutGates == false)
        {
            goto label_5;
        }
        
        if(this.doingTween == true)
        {
            goto label_9;
        }
        
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.left.GetComponent<UnityEngine.RectTransform>(), endValue:  0f, duration:  this.gateCloseTime, snapping:  false), ease:  30);
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.right.GetComponent<UnityEngine.RectTransform>(), endValue:  0f, duration:  this.gateCloseTime, snapping:  false), ease:  30);
        this.doingTween = true;
        goto label_9;
        label_3:
        this.LockVsScreen = this.CrashCounter;
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.AnimateVsSplashScreen());
        return;
        label_5:
        this.CrashCounter = 1;
        label_9:
        UnityEngine.Vector3 val_10 = this.right.transform.localPosition;
        if(val_10.x < 0)
        {
                int val_12 = this.CrashCounter;
            this.doingTween = false;
            val_12 = val_12 + 1;
            this.CrashCounter = val_12;
        }
        
        if(this.timerfailsafe > 0f)
        {
                float val_11 = UnityEngine.Time.deltaTime;
            val_11 = this.timerfailsafe - val_11;
            this.timerfailsafe = val_11;
            return;
        }
        
        this.CrashCounter = 1;
    }
    public void LoadCharacterSprites()
    {
        CharacterNameID val_2;
        CharacterNameID val_6;
        CharacterInfo val_1 = Character_GlobalInfo.GetLeftPlayer();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.LoadCharacterResources(nameID:  val_2, leftSide:  true, backGround:  null, clanSymbol:  null, poseImage:  null, statsImage:  null, nameController:  null, originScale:  new UnityEngine.Vector3()));
        CharacterInfo val_5 = Character_GlobalInfo.GetRightPlayer();
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.LoadCharacterResources(nameID:  val_6, leftSide:  false, backGround:  null, clanSymbol:  null, poseImage:  null, statsImage:  null, nameController:  null, originScale:  new UnityEngine.Vector3()));
    }
    private System.Collections.IEnumerator LoadCharacterResources(CharacterNameID nameID, bool leftSide, UnityEngine.UI.Image backGround, UnityEngine.UI.Image clanSymbol, UnityEngine.UI.Image poseImage, UnityEngine.UI.Image statsImage, CharacterNameController nameController, UnityEngine.Vector3 originScale)
    {
        BattleVSGates.<LoadCharacterResources>d__24 val_1 = new BattleVSGates.<LoadCharacterResources>d__24();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .nameID = nameID;
            .nameController = nameController;
            .backGround = backGround;
            .poseImage = poseImage;
            .leftSide = leftSide;
            .clanSymbol = clanSymbol;
            .statsImage = statsImage;
        }
        else
        {
                mem[32] = this;
            mem[40] = nameID;
            mem[80] = leftSide;
            mem[56] = backGround;
            mem[64] = clanSymbol;
            mem[88] = poseImage;
            mem[72] = statsImage;
            mem[48] = nameController;
        }
        
        .originScale = originScale;
        mem[1152921526425554196] = originScale.y;
        mem[1152921526425554200] = originScale.z;
        return (System.Collections.IEnumerator)val_1;
    }
    private void SetLoaded_Gate(bool leftSide)
    {
        var val_1 = (leftSide != true) ? this.left : this.right;
        mem2[0] = 1;
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1 == 0)
        {
                return;
        }
        
        this.BattleGatesLoaded = true;
    }
    public void SetLoaded_Scene(bool leftSide)
    {
        var val_1 = (leftSide != true) ? this.left : this.right;
        mem2[0] = 1;
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1 == 0)
        {
                return;
        }
        
        this.ReadyToOpenGates = true;
    }
    public void ForceStartAnimateSplashScreen()
    {
        this._shutGates = true;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.AnimateVsSplashScreen());
    }
    private System.Collections.IEnumerator AnimateVsSplashScreen()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new BattleVSGates.<AnimateVsSplashScreen>d__28();
    }
    public void KillSwitch()
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
        this.gameObject.transform.parent = val_1.transform;
        UnityEngine.Object.Destroy(obj:  val_1);
    }
    private void MoveGatesOutsideOfScreen(bool instantMove)
    {
        UnityEngine.RectTransform val_1 = this.Canvas_BattleGates.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Vector2 val_2 = val_1.sizeDelta;
        float val_12 = val_2.x;
        UnityEngine.Vector2 val_4 = val_1.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
        val_12 = val_12 * 0.5f;
        val_12 = val_12 + val_4.x;
        UnityEngine.RectTransform val_5 = this.left.GetComponent<UnityEngine.RectTransform>();
        if(instantMove != false)
        {
                UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  -val_12, y:  0f);
            val_5.anchoredPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_12, y:  0f);
            this.right.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
            return;
        }
        
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  val_5, endValue:  -val_12, duration:  this.gateOpenTime, snapping:  false);
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.right.GetComponent<UnityEngine.RectTransform>(), endValue:  val_12, duration:  this.gateOpenTime, snapping:  false);
    }
    public BattleVSGates()
    {
        this.timerfailsafe = 5f;
        this.gateCloseTime = 1f;
        this.gateOpenTime = 0.5f;
        this.LockVsScreen = true;
    }

}
