using UnityEngine;
public class MVC_GameScene_Activator : MonoBehaviour
{
    // Fields
    public static MVC_GameScene_Activator instance;
    public UnityEngine.Canvas Canvas_BattleGates;
    public UnityEngine.GameObject VSImage;
    public UnityEngine.GameObject VSGradient;
    public UnityEngine.GameObject VSParticle;
    public View_BattleGates_Side left;
    public View_BattleGates_Side right;
    public UnityEngine.Sprite background_Ika;
    public UnityEngine.Sprite background_Tako;
    public UnityEngine.Sprite clanSymbol_Ika;
    public UnityEngine.Sprite clanSymbol_Tako;
    public UnityEngine.Sprite background_Special;
    public UnityEngine.Sprite clanSymbol_Special;
    public UnityEngine.Sprite background_IronShark;
    public UnityEngine.Sprite clanSymbol_IronShark;
    public UnityEngine.AudioClip musicOnGatesClose;
    public UnityEngine.AudioClip musicOnVSGraphics;
    private float delay_ExplosionFromStartToVisual;
    private float animTime_GateClose;
    private float animTime_GateOpen;
    private float animTime_VSImage;
    private float animTime_VSGradient;
    private float animTime_BottomInfo;
    private float animTime_TopInfo;
    private float animTime_BattleEnhancer;
    private float animTime_AllowViewingTime;
    private float animPos_Gates;
    private bool _ShowBattleGates;
    public bool BattleGatesLoaded;
    public bool ReadyToOpenGates;
    private System.Action onCloseDoneAction;
    private System.Action onOpenDoneAction;
    private RankingController rankingController;
    
    // Properties
    public bool ShowBattleGates { get; }
    
    // Methods
    public bool get_ShowBattleGates()
    {
        return (bool)this._ShowBattleGates;
    }
    public void TriggerLoading(bool ShowBattleGates, System.Action onCloseDone, System.Action onOpenDone)
    {
        this.onCloseDoneAction = onCloseDone;
        this._ShowBattleGates = ShowBattleGates;
        this.onOpenDoneAction = onOpenDone;
        if(ShowBattleGates != false)
        {
                System.Collections.IEnumerator val_2 = this.LoadNextScene_ShutGates();
        }
        else
        {
                this.LoadNextScene();
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.LoadNextScene_InitialiseScene());
    }
    private System.Collections.IEnumerator LoadNextScene_ShutGates()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new MVC_GameScene_Activator.<LoadNextScene_ShutGates>d__36();
    }
    private System.Collections.IEnumerator LoadNextScene_AnimateGates()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new MVC_GameScene_Activator.<LoadNextScene_AnimateGates>d__37();
    }
    private void LoadNextScene()
    {
        var val_1;
        GameMode val_2;
        val_1 = null;
        val_1 = null;
        val_2 = Character_GlobalInfo.gameMode;
        if(val_2 == 6)
        {
                return;
        }
        
        val_2 = Character_GlobalInfo.gameMode;
        if(val_2 == 10)
        {
                return;
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "MVC_GameScene");
    }
    public System.Collections.IEnumerator LoadNextScene_InitialiseScene()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new MVC_GameScene_Activator.<LoadNextScene_InitialiseScene>d__39();
    }
    private System.Collections.IEnumerator AnimateMatchBeginning()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new MVC_GameScene_Activator.<AnimateMatchBeginning>d__40();
    }
    private float CalculateTotalDefenceAnimationDuration(CharAnimationController animController)
    {
        UnityEngine.Object val_13;
        UnityEngine.Object val_14;
        float val_15;
        if(animController != null)
        {
                val_13 = animController.GetAnimation(animName:  4);
            val_14 = animController.GetAnimation(animName:  5);
        }
        else
        {
                val_13 = 0.GetAnimation(animName:  4);
            val_14 = 0.GetAnimation(animName:  5);
        }
        
        val_15 = 0f;
        if((UnityEngine.Object.op_Implicit(exists:  val_13)) != false)
        {
                val_15 = (this.CalculateAnimationDuration(animFrames:  val_3.bodyFrameData)) + 0f;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_14)) != false)
        {
                val_15 = val_15 + (this.CalculateAnimationDuration(animFrames:  val_4.bodyFrameData));
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  animController.GetAnimation(animName:  3))) == false)
        {
                return (float)val_15;
        }
        
        val_15 = val_15 + (this.CalculateAnimationDuration(animFrames:  val_5.bodyFrameData));
        return (float)val_15;
    }
    private float CalculateAnimationDuration(System.Collections.Generic.List<AnimationFrameData> animFrames)
    {
        var val_3;
        float val_4;
        val_3 = animFrames;
        List.Enumerator<T> val_1 = val_3.GetEnumerator();
        val_4 = 0f;
        goto label_2;
        label_4:
        val_3 = 0.InitialType;
        val_4 = val_4 + S0;
        label_2:
        if(((-2075697496) & 1) != 0)
        {
            goto label_4;
        }
        
        0.Add(driver:  public System.Void List.Enumerator<AnimationFrameData>::Dispose(), rectTransform:  null, drivenProperties:  null);
        return (float)val_4;
    }
    private void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
        if(MVC_GameScene_Activator.instance != 0)
        {
                MVC_GameScene_Activator.instance.KillSwitch();
        }
        
        MVC_GameScene_Activator.instance = this;
    }
    private void Start()
    {
        this.MoveGatesOutsideOfScreen(instantMove:  true);
        this.LoadCharacterSprites();
    }
    public void LoadCharacterSprites()
    {
        CharacterNameID val_4;
        CharacterNameID val_8;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_11 = null;
        val_11 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
                val_12 = null;
            val_12 = null;
            if(DataStructs.UserDataDictionary.Settings.FlipNegateX == 1)
        {
            goto label_17;
        }
        
        }
        
        label_17:
        val_13 = null;
        val_13 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
                val_14 = null;
            val_14 = null;
            if(DataStructs.UserDataDictionary.Settings.FlipNegateX == 1)
        {
            goto label_18;
        }
        
        }
        
        label_18:
        CharacterInfo val_3 = Character_GlobalInfo.GetLeftPlayer();
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.LoadCharacterResources(nameID:  val_4, leftSide:  true, battleGate:  new View_BattleGates_Side() {gateLoaded = false, readyToOpen = false}));
        CharacterInfo val_7 = Character_GlobalInfo.GetRightPlayer();
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  this.LoadCharacterResources(nameID:  val_8, leftSide:  false, battleGate:  new View_BattleGates_Side() {gateLoaded = false, readyToOpen = false}));
    }
    private System.Collections.IEnumerator LoadCharacterResources(CharacterNameID nameID, bool leftSide, View_BattleGates_Side battleGate)
    {
        MVC_GameScene_Activator.<LoadCharacterResources>d__46 val_1 = new MVC_GameScene_Activator.<LoadCharacterResources>d__46();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .nameID = nameID;
        }
        else
        {
                mem[32] = this;
            mem[40] = nameID;
        }
        
        .leftSide = leftSide;
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
    public void KillSwitch()
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
        this.gameObject.transform.parent = val_1.transform;
        UnityEngine.Object.Destroy(obj:  val_1);
    }
    private void MoveGatesOutsideOfScreen(bool instantMove)
    {
        UnityEngine.Vector2 val_2 = this.Canvas_BattleGates.GetComponent<UnityEngine.RectTransform>().sizeDelta;
        float val_12 = val_2.x;
        val_12 = val_12 * 0.5f;
        UnityEngine.RectTransform val_3 = this.left.GetComponent<UnityEngine.RectTransform>();
        if(instantMove != false)
        {
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  -val_12, y:  0f);
            val_3.anchoredPosition = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_12, y:  0f);
            this.right.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            return;
        }
        
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  val_3, endValue:  -val_12, duration:  this.animTime_GateOpen, snapping:  false);
        DG.Tweening.Tweener val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.right.GetComponent<UnityEngine.RectTransform>(), endValue:  val_12, duration:  this.animTime_GateOpen, snapping:  false), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void MVC_GameScene_Activator::<MoveGatesOutsideOfScreen>b__50_0()));
    }
    private void SetupNetworkUserInfo()
    {
        var val_10;
        var val_11;
        val_10 = null;
        val_10 = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
            goto label_3;
        }
        
        val_11 = null;
        val_11 = null;
        if(DataStructs.UserDataDictionary.Settings.FlipNegateX == 1)
        {
            goto label_7;
        }
        
        label_3:
        NetworkUserInfo val_2 = DataStructs.UserDataDictionary.ToNetworkUserInfo();
        CharacterInfo val_3 = Character_GlobalInfo.GetMainPlayer();
        label_16:
        NetworkUserInfo val_5 = CloudOpponent.current;
        CharacterInfo val_6 = Character_GlobalInfo.GetOpponentPlayer();
        return;
        label_7:
        NetworkUserInfo val_8 = DataStructs.UserDataDictionary.ToNetworkUserInfo();
        CharacterInfo val_9 = Character_GlobalInfo.GetMainPlayer();
        goto label_16;
    }
    public MVC_GameScene_Activator()
    {
        mem2[0] = ;
        mem2[0] = ;
        this.animTime_AllowViewingTime = 2f;
    }
    private void <MoveGatesOutsideOfScreen>b__50_0()
    {
        if(this.onOpenDoneAction == null)
        {
                return;
        }
        
        this.onOpenDoneAction.Invoke();
        this.onOpenDoneAction = 0;
    }

}
