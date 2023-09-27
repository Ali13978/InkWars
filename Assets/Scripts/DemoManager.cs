using UnityEngine;
public class DemoManager : MonoBehaviour
{
    // Fields
    public static DemoManager _instance;
    public static bool enableShowHandSection;
    public bool IsAdvancedTutorialMode;
    public int StartFromStage;
    public float SpeedSegmentTimer;
    public DemoCanvas demoCanvas;
    public InteractiveTutorialManager demoLineController;
    public UnityEngine.GameObject aimHereTop;
    public UnityEngine.GameObject aimHereBottom;
    public UnityEngine.GameObject shootHere;
    public UnityEngine.GameObject shootHereBottom;
    public UnityEngine.GameObject shootHereTrash;
    public UnityEngine.GameObject DemoSceneHolder;
    public UnityEngine.GameObject fadeEffect;
    public UnityEngine.GameObject rechargeSequenceAnim;
    public UnityEngine.GameObject fingerBubbleSwitching;
    public UnityEngine.GameObject fingerTrashABubble;
    public UnityEngine.GameObject tapHere;
    public UnityEngine.GameObject fingerHowToAim;
    public UnityEngine.GameObject fingerHowToShoot;
    public UnityEngine.GameObject nowYouTryButton;
    public UnityEngine.GameObject nowYouTryText;
    public UnityEngine.GameObject flipper;
    public UnityEngine.GameObject demoText;
    public UnityEngine.GameObject cameraShake;
    private UnityEngine.GameObject skipButton;
    public UnityEngine.AudioClip tapToTryClip;
    public UnityEngine.AudioClip correctActionClip;
    public UnityEngine.AudioClip tickButtonClip;
    public UnityEngine.AudioClip incorrectActionClip;
    public UnityEngine.AudioClip matchConclusionClip;
    public UnityEngine.AudioClip popClip;
    public UnityEngine.AudioClip WinClip;
    public static bool touchBoolForDemo;
    public static bool flagForSwipeTouch;
    public static bool flagForDestroyAnim;
    public static string currentSequence;
    private int counterForTapToTry;
    private int counterForTickButton;
    public bool Trigger_BubbleShot;
    public bool Trigger_Stunned_Start;
    public bool Trigger_Stunned;
    internal int Counter_PlayerLeftShot;
    internal int Counter_PlayerRightShot;
    internal int Counter_PlayerLeftRainbow;
    internal int Counter_PlayerRightRainbow;
    internal int Counter_PlayerLeftMatch;
    internal int Counter_PlayerRightMatch;
    private bool isTopAimRight;
    private bool isBottomAimRight;
    private int swipeCounter;
    private int tempSwipeCounter;
    public int counterForTrash;
    private int tempCounterForTrash;
    private int currentStage;
    private int numberSkipped;
    
    // Properties
    public static DemoManager Instance { get; }
    
    // Methods
    public static DemoManager get_Instance()
    {
        var val_3;
        DemoManager val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = DemoManager._instance;
        if(val_4 == 0)
        {
                val_5 = null;
            val_4 = UnityEngine.Object.FindObjectOfType<DemoManager>();
            val_5 = null;
            DemoManager._instance = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (DemoManager)DemoManager._instance;
    }
    private void Awake()
    {
        this.SetLeftText(text:  "");
        this.SetRightText(text:  "");
        this.SetAdvancedTutorialStage(index:  0);
        if(TutorialDataManager.ForceBasicTutorial != false)
        {
                TutorialDataManager.ForceBasicTutorial = false;
            this.IsAdvancedTutorialMode = false;
        }
        
        if(TutorialDataManager.ForceAdvancedTutorial == false)
        {
                return;
        }
        
        TutorialDataManager.ForceAdvancedTutorial = false;
        this.IsAdvancedTutorialMode = true;
        this.StartFromStage = 0;
        this.SpeedSegmentTimer = 20f;
    }
    private void SetLeftText(string text)
    {
        var val_1;
        DemoCanvas val_2;
        val_1 = null;
        val_1 = null;
        val_2 = this.demoCanvas;
        if(InstanceAnimator.playerNegateX != 1)
        {
            goto label_4;
        }
        
        if(this.demoCanvas.Counter_Left != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        val_2 = ???;
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5B8;
        label_4:
        if((val_2 + 136) != 0)
        {
            goto label_6;
        }
        
        goto label_7;
    }
    private void SetRightText(string text)
    {
        var val_1;
        DemoCanvas val_2;
        val_1 = null;
        val_1 = null;
        val_2 = this.demoCanvas;
        if(InstanceAnimator.playerNegateX != 1)
        {
            goto label_4;
        }
        
        if(this.demoCanvas.Counter_Right != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        val_2 = ???;
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5B8;
        label_4:
        if((val_2 + 128) != 0)
        {
            goto label_6;
        }
        
        goto label_7;
    }
    private void Start()
    {
        var val_9;
        bool val_10;
        var val_11;
        var val_12;
        bool val_13;
        var val_14;
        var val_15;
        var val_16;
        val_9 = null;
        val_9 = null;
        GameAudio.SwitchMusic(clip:  GameInfo.music.LoadResourceById(uniqueId:  573899129), customLoopStartTime:  0f, customLoopEndTime:  0f, forcePlay:  false);
        if(this.IsAdvancedTutorialMode != false)
        {
                val_10 = 1;
        }
        else
        {
                this.demoCanvas.AdvancedTutorialTopBar.SetActive(value:  false);
            val_10 = this.IsAdvancedTutorialMode;
        }
        
        val_11 = null;
        val_11 = null;
        DemoManager.flagForSwipeTouch = val_10;
        DemoManager.flagForDestroyAnim = false;
        this.demoText.SetActive(value:  false);
        this.aimHereTop.SetActive(value:  false);
        this.aimHereBottom.SetActive(value:  false);
        DemoManager.currentSequence = "";
        this.counterForTapToTry = 4294967296;
        this.counterForTickButton = 1;
        DemoManager.touchBoolForDemo = false;
        if((System.String.IsNullOrEmpty(value:  TutorialDataManager.NextSceneForInteractiveTutorial)) != false)
        {
                TutorialDataManager.NextSceneForInteractiveTutorial = "Menu_Title_Screen";
        }
        
        AsyncSceneLoader.PreloadScene(sceneName:  TutorialDataManager.NextSceneForInteractiveTutorial);
        val_12 = null;
        val_12 = null;
        val_13 = DemoManager.enableShowHandSection;
        if(val_13 != false)
        {
                if(this.IsAdvancedTutorialMode == false)
        {
            goto label_19;
        }
        
        }
        
        val_13 = DemoManager.enableShowHandSection;
        if(val_13 == false)
        {
            goto label_22;
        }
        
        if((this.IsAdvancedTutorialMode == true) || (DeviceBasedData.playerAtLeftForQuickPlay == false))
        {
            goto label_24;
        }
        
        goto label_25;
        label_22:
        if(this.IsAdvancedTutorialMode == false)
        {
            goto label_26;
        }
        
        label_24:
        this.flipper.GetComponent<TogglerForInteractiveTutorial>().onFlip();
        label_25:
        this.demoCanvas.panelChooseHands.SetActive(value:  false);
        this.demoCanvas.panelDemoScene.SetActive(value:  true);
        if(this.IsAdvancedTutorialMode != false)
        {
                this.SetAdvancedTutorialStage(index:  0);
            this.DemoSceneHolder.SetActive(value:  false);
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.AdvancedTutorial());
        }
        else
        {
                this.DemoSceneHolder.SetActive(value:  true);
            UnityEngine.Coroutine val_7 = this.StartCoroutine(methodName:  "HowToAimSequence");
        }
        
        this.demoCanvas.AdvancedTutorialTopBar.SetActive(value:  false);
        return;
        label_19:
        this.demoCanvas.panelChooseHands.SetActive(value:  true);
        this.demoCanvas.panelDemoScene.SetActive(value:  false);
        this.DemoSceneHolder.SetActive(value:  false);
        val_14 = null;
        val_14 = null;
        DemoManager.enableShowHandSection = false;
        val_15 = null;
        val_15 = null;
        InstanceAnimator.deviceBasedFlipDataSource = true;
        return;
        label_26:
        val_16 = null;
        val_16 = null;
        InstanceAnimator.deviceBasedFlipDataSource = true;
        if(DeviceBasedData.playerAtLeftForQuickPlay != false)
        {
                this.LeftHandButtonClick(playSFX:  false);
            return;
        }
        
        this.RightHandButtonClick(playSFX:  false);
    }
    private System.Collections.IEnumerator RestartStage()
    {
        return (System.Collections.IEnumerator)new DemoManager.<RestartStage>d__54(<>1__state:  0);
    }
    private System.Collections.IEnumerator AdvancedTutorial()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoManager.<AdvancedTutorial>d__55(<>1__state:  0);
    }
    public bool SwapBubble(TutorialDataManager.PlayerData player, UnityEngine.GameObject[] bubble, UnityEngine.GameObject[][] rings)
    {
        UnityEngine.GameObject val_5;
        var val_6;
        var val_7;
        System.Collections.Generic.HashSet<BallColors> val_8;
        val_5 = bubble;
        val_6 = player;
        if(this.currentStage == 31)
        {
                if(val_6.NextRainbow != false)
        {
                TutorialDataManager.SetBall(gameObject:  val_5[0], color:  6);
            UnityEngine.MonoBehaviour.print(message:  "Don\'t swap, rainbow");
            val_7 = 0;
            return (bool)val_7;
        }
        
        }
        
        System.Collections.Generic.HashSet<BallColors>[] val_2 = TutorialDataManager.GetMatches(rings:  rings);
        val_6 = val_6.NextMatch;
        val_5 = val_5[0];
        if(val_6 != false)
        {
                val_8 = val_2[0];
        }
        else
        {
                val_8 = val_2[1];
        }
        
        TutorialDataManager.SetBall(gameObject:  val_5, color:  TutorialDataManager.GetRandomBall(options:  val_8));
        UnityEngine.MonoBehaviour.print(message:  "swapping");
        val_7 = 1;
        return (bool)val_7;
    }
    private void SetAdvancedTutorialStage(int index)
    {
        var val_2 = 0;
        this.currentStage = index;
        goto label_0;
        label_7:
        this.demoCanvas.Stages[0].SetActive(value:  (index == val_2) ? 1 : 0);
        val_2 = 1;
        label_0:
        if(val_2 < this.demoCanvas.Stages.Length)
        {
            goto label_7;
        }
    
    }
    public bool CanShoot(int ballTemp)
    {
        if(this.currentStage != 23)
        {
                return (bool)((ballTemp == 2) ? 1 : 0) | ((this.currentStage != 26) ? 1 : 0);
        }
        
        return (bool)(ballTemp == 5) ? 1 : 0;
    }
    private void TapToTryAnim(bool playSFX = True)
    {
        if(playSFX != false)
        {
                UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.tapToTryClip, volume:  1f);
        }
        
        object[] val_3 = new object[12];
        val_3[0] = "from";
        val_3[1] = 0f;
        val_3[2] = "to";
        val_3[3] = 1f;
        val_3[4] = "time";
        val_3[5] = 0.5f;
        val_3[6] = "onupdatetarget";
        val_3[7] = this.gameObject;
        val_3[8] = "onupdate";
        val_3[9] = "changeFill";
        val_3[10] = "easetype";
        val_3[11] = 26;
        iTween.ValueTo(target:  this.nowYouTryButton, args:  iTween.Hash(args:  val_3));
        object[] val_6 = new object[10];
        val_6[0] = "x";
        val_6[1] = 1f;
        val_6[2] = "y";
        val_6[3] = 1f;
        val_6[4] = "time";
        val_6[5] = 0.5f;
        val_6[6] = "delay";
        val_6[7] = 0.5f;
        val_6[8] = "easetype";
        val_6[9] = 24;
        iTween.ScaleTo(target:  this.nowYouTryText, args:  iTween.Hash(args:  val_6));
    }
    private void resetTapToTry()
    {
        this.nowYouTryButton.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  0f, y:  0f);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        this.nowYouTryText.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        this.nowYouTryButton.SetActive(value:  false);
    }
    private void changeFill(float fillAmountButton)
    {
        this.nowYouTryButton.GetComponent<UnityEngine.UI.Image>().fillAmount = fillAmountButton;
    }
    public void LeftHandButtonClick()
    {
        this.LeftHandButtonClick(playSFX:  true);
    }
    public void LeftHandButtonClick(bool playSFX)
    {
        if(playSFX != false)
        {
                GameAudio.PlayButtonSound();
        }
        
        DeviceBasedData.playerAtLeftForQuickPlay = true;
        this.flipper.GetComponent<TogglerForInteractiveTutorial>().onFlip();
        this.BeginFade();
        this.demoCanvas.panelChooseHands.SetActive(value:  false);
        this.demoCanvas.panelDemoScene.SetActive(value:  true);
        this.DemoSceneHolder.SetActive(value:  true);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(methodName:  "HowToAimSequence");
    }
    public void RightHandButtonClick()
    {
        this.RightHandButtonClick(playSFX:  true);
    }
    public void RightHandButtonClick(bool playSFX)
    {
        if(playSFX != false)
        {
                GameAudio.PlayButtonSound();
        }
        
        DeviceBasedData.playerAtLeftForQuickPlay = false;
        this.BeginFade();
        this.demoCanvas.panelChooseHands.SetActive(value:  false);
        this.demoCanvas.panelDemoScene.SetActive(value:  true);
        this.DemoSceneHolder.SetActive(value:  true);
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "HowToAimSequence");
    }
    private System.Collections.IEnumerator HowToAimSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoManager.<HowToAimSequence>d__66(<>1__state:  0);
    }
    public void OnTapToTryButtonClick()
    {
        this.demoLineController.animController_Player.PlayAnimation(newAnimName:  8, forceOverride:  true);
        GameAudio.PlayButtonSound();
        this.resetTapToTry();
        if(this.counterForTapToTry <= 3)
        {
                var val_7 = 40831560 + (this.counterForTapToTry) << 2;
            val_7 = val_7 + 40831560;
        }
        else
        {
                AsyncSceneLoader.ActivePreloadScene(showLoadingScene:  true);
        }
    
    }
    public void GoToNextTutorial()
    {
        this.demoLineController.animController_Player.PlayAnimation(newAnimName:  8, forceOverride:  true);
        int val_7 = this.counterForTickButton;
        val_7 = val_7 - 1;
        if(val_7 <= 4)
        {
                var val_8 = 40831576 + ((this.counterForTickButton - 1)) << 2;
            val_8 = val_8 + 40831576;
        }
        else
        {
                AsyncSceneLoader.ActivePreloadScene(showLoadingScene:  true);
        }
    
    }
    public void OnSkipButtonClick()
    {
        int val_2 = this.numberSkipped;
        val_2 = val_2 + 1;
        this.numberSkipped = val_2;
        GameAudio.PlayButtonSound();
        if(this.skipButton != 0)
        {
                this.skipButton.SetActive(value:  false);
        }
        
        int val_3 = this.counterForTickButton;
        val_3 = val_3 - 1;
        if(val_3 <= 5)
        {
                var val_4 = 40831536 + ((this.counterForTickButton - 1)) << 2;
            val_4 = val_4 + 40831536;
        }
        else
        {
                AsyncSceneLoader.ActivePreloadScene(showLoadingScene:  true);
        }
    
    }
    private System.Collections.IEnumerator HowToAimPlayerSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoManager.<HowToAimPlayerSequence>d__70(<>1__state:  0);
    }
    private void checkForHowToAimCompletion()
    {
        if(this.isTopAimRight == false)
        {
            goto label_1;
        }
        
        if(this.isBottomAimRight == false)
        {
            goto label_3;
        }
        
        this.CancelInvoke(methodName:  "checkForHowToAimCompletion");
        return;
        label_1:
        if(InteractiveTutorialManager.ballEntryTemp == 1)
        {
                this.isTopAimRight = InteractiveTutorialManager.ballEntryTemp;
            UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "makeTopAimArrowGreen");
        }
        
        label_3:
        if(this.isBottomAimRight == true)
        {
                return;
        }
        
        if(InteractiveTutorialManager.ballEntryTemp != 6)
        {
                return;
        }
        
        this.isBottomAimRight = true;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(methodName:  "makeBottomAimArrowGreen");
    }
    private System.Collections.IEnumerator makeTopAimArrowGreen()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoManager.<makeTopAimArrowGreen>d__74(<>1__state:  0);
    }
    private System.Collections.IEnumerator makeBottomAimArrowGreen()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoManager.<makeBottomAimArrowGreen>d__75(<>1__state:  0);
    }
    private void skipHowToAimSequence()
    {
        var val_2;
        this.StopCoroutine(methodName:  "HowToAimSequence");
        this.StopCoroutine(methodName:  "HowToAimPlayerSequence");
        this.CancelInvoke(methodName:  "checkForHowToAimCompletion");
        this.StopCoroutine(methodName:  "makeTopAimArrowGreen");
        this.StopCoroutine(methodName:  "makeBottomAimArrowGreen");
        this.fingerHowToAim.SetActive(value:  false);
        this.demoCanvas.textNailTheBasics.SetActive(value:  false);
        this.demoCanvas.textHowToAimLarge.SetActive(value:  false);
        this.demoCanvas.textHowToAimSmall.SetActive(value:  false);
        this.demoText.SetActive(value:  false);
        this.resetTapToTry();
        this.demoLineController.ResetEverything();
        val_2 = null;
        val_2 = null;
        DemoManager.currentSequence = "HowToAim";
        this.counterForTapToTry = 4294967297;
        this.counterForTickButton = 1;
        this.aimHereTop.SetActive(value:  false);
        this.aimHereBottom.SetActive(value:  false);
        DemoManager.touchBoolForDemo = false;
        this.demoCanvas.textGreat.SetActive(value:  false);
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "HowToShootSequence");
    }
    private System.Collections.IEnumerator HowToShootSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoManager.<HowToShootSequence>d__77(<>1__state:  0);
    }
    private System.Collections.IEnumerator HowToShootPlayerSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoManager.<HowToShootPlayerSequence>d__78(<>1__state:  0);
    }
    private void BeginFade()
    {
        Fading val_1 = this.fadeEffect.GetComponent<Fading>();
        val_1.fadeSpeed = 0.4f;
        Fading val_2 = this.fadeEffect.GetComponent<Fading>();
        val_2.alpha = 1f;
        float val_4 = this.fadeEffect.GetComponent<Fading>().BeginFade(direction:  0);
    }
    private void checkForHowToShootCompletion()
    {
        null = null;
        if(InstanceAnimator.isMiddleRingEmpty == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "makeShootHereGreen");
        this.CancelInvoke(methodName:  "checkForHowToShootCompletion");
    }
    private System.Collections.IEnumerator makeShootHereGreen()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoManager.<makeShootHereGreen>d__81(<>1__state:  0);
    }
    private void skipHowToShootSequence()
    {
        var val_4;
        var val_5;
        var val_6;
        this.StopCoroutine(methodName:  "HowToShootSequence");
        this.StopCoroutine(methodName:  "HowToShootPlayerSequence");
        this.CancelInvoke(methodName:  "checkForHowToShootCompletion");
        this.StopCoroutine(methodName:  "makeShootHereGreen");
        var val_5 = 4;
        do
        {
            val_4 = null;
            val_4 = null;
            var val_1 = val_5 - 4;
            if((InstanceAnimator.middleRingBalls + 32) != 0)
        {
                val_5 = null;
            val_5 = null;
            UnityEngine.Object.Destroy(obj:  InstanceAnimator.middleRingBalls + 32.gameObject);
        }
        
            val_5 = val_5 + 1;
        }
        while(val_5 != 17);
        
        this.counterForTickButton = 2;
        this.demoCanvas.textHowToShoot.SetActive(value:  false);
        this.demoCanvas.textHowToShootSmall.SetActive(value:  false);
        this.fingerHowToShoot.SetActive(value:  false);
        this.demoText.SetActive(value:  false);
        this.resetTapToTry();
        this.demoLineController.ResetEverything();
        this.counterForTapToTry = 2;
        this.shootHere.SetActive(value:  false);
        val_6 = null;
        val_6 = null;
        DemoManager.touchBoolForDemo = false;
        this.demoCanvas.textWellDone.SetActive(value:  false);
        this.demoLineController.ResetEverything();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(methodName:  "SwitchingBubbleSequence");
    }
    private System.Collections.IEnumerator RechargingSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoManager.<RechargingSequence>d__83(<>1__state:  0);
    }
    private void skipRechargingSequence()
    {
        this.StopCoroutine(methodName:  "RechargingSequence");
        this.counterForTickButton = 3;
        this.demoCanvas.textRecharging.SetActive(value:  false);
        this.demoText.SetActive(value:  false);
        this.demoCanvas.textRechargingSmall.SetActive(value:  false);
        this.rechargeSequenceAnim.SetActive(value:  false);
        this.demoCanvas.textGotThat.SetActive(value:  false);
        this.demoLineController.ResetEverything();
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "SwitchingBubbleSequence");
    }
    private System.Collections.IEnumerator SwitchingBubbleSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoManager.<SwitchingBubbleSequence>d__85(<>1__state:  0);
    }
    private System.Collections.IEnumerator SwitchingBubblePlayerSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoManager.<SwitchingBubblePlayerSequence>d__86(<>1__state:  0);
    }
    private void skipSwitchingBubbleSequence()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "skipSwitchingBubbleSequenceCoroutine");
    }
    private System.Collections.IEnumerator skipSwitchingBubbleSequenceCoroutine()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoManager.<skipSwitchingBubbleSequenceCoroutine>d__88(<>1__state:  0);
    }
    private void checkForSwipingCompletion()
    {
        if(this.swipeCounter != 2)
        {
                if(this.swipeCounter != 1)
        {
                return;
        }
        
            if(this.tempSwipeCounter == 1)
        {
                return;
        }
        
            UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.correctActionClip, volume:  1f);
            this.tempSwipeCounter = this.swipeCounter;
            return;
        }
        
        if(this.tempSwipeCounter == 2)
        {
                return;
        }
        
        UnityEngine.AudioSource val_4 = GameAudio.sound.PlayOneShot(clip:  this.correctActionClip, volume:  1f);
        this.tempSwipeCounter = this.swipeCounter;
        this.CancelInvoke(methodName:  "checkForSwipingCompletion");
    }
    public void OnSwipeButtonDown()
    {
        var val_17;
        var val_18;
        var val_19;
        val_17 = null;
        val_17 = null;
        if(DemoManager.flagForSwipeTouch == false)
        {
                return;
        }
        
        this.demoLineController.OnSwipeButtonDown(isCPU:  false, muteSFX:  false);
        UnityEngine.Color val_2 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.tapHere.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        UnityEngine.Color val_6 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.tapHere.transform.GetChild(index:  0).GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
        if(this.swipeCounter == 1)
        {
            goto label_11;
        }
        
        if(this.swipeCounter != 0)
        {
            goto label_12;
        }
        
        this.tapHere.transform.GetChild(index:  1).gameObject.SetActive(value:  false);
        val_18 = this.tapHere.transform;
        val_19 = 2;
        goto label_19;
        label_11:
        this.tapHere.transform.GetChild(index:  2).gameObject.SetActive(value:  false);
        val_18 = this.tapHere.transform;
        val_19 = 3;
        label_19:
        val_18.GetChild(index:  3).gameObject.SetActive(value:  true);
        label_12:
        int val_17 = this.swipeCounter;
        val_17 = val_17 + 1;
        this.swipeCounter = val_17;
    }
    private System.Collections.IEnumerator BallSwap(UnityEngine.Vector2 pos1, UnityEngine.Vector2 pos2, UnityEngine.Vector2 size1, UnityEngine.Vector2 size2)
    {
        DemoManager.<BallSwap>d__93 val_1 = new DemoManager.<BallSwap>d__93(<>1__state:  0);
        if(val_1 != null)
        {
                .<>4__this = this;
            .pos1 = pos1;
            mem[1152921526097418700] = pos1.y;
            .pos2 = pos2;
            mem[1152921526097418708] = pos2.y;
            .size1 = size1;
            mem[1152921526097418716] = size1.y;
        }
        else
        {
                mem[32] = this;
            mem[40] = pos1.x;
            mem[1152921526097418700] = pos1.y;
            mem[48] = pos2.x;
            mem[1152921526097418708] = pos2.y;
            mem[56] = size1.x;
            mem[1152921526097418716] = size1.y;
        }
        
        .size2 = size2;
        mem[1152921526097418724] = size2.y;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator TrashABubbleSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoManager.<TrashABubbleSequence>d__94(<>1__state:  0);
    }
    private System.Collections.IEnumerator TrashABubblePlayerSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoManager.<TrashABubblePlayerSequence>d__95(<>1__state:  0);
    }
    private void checkForTrashABubbleCompletion()
    {
        if(this.counterForTrash != 2)
        {
                if(this.counterForTrash != 1)
        {
                return;
        }
        
            if(this.tempCounterForTrash == 1)
        {
                return;
        }
        
            UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.correctActionClip, volume:  1f);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(methodName:  "makeShootHereTrashGreen");
            this.tempCounterForTrash = this.counterForTrash;
            return;
        }
        
        if(this.tempCounterForTrash == 2)
        {
                return;
        }
        
        UnityEngine.AudioSource val_5 = GameAudio.sound.PlayOneShot(clip:  this.correctActionClip, volume:  1f);
        this.tempCounterForTrash = this.counterForTrash;
        this.shootHereTrash.transform.GetChild(index:  2).gameObject.SetActive(value:  false);
        this.shootHereTrash.transform.GetChild(index:  3).gameObject.SetActive(value:  true);
        this.CancelInvoke(methodName:  "checkForTrashABubbleCompletion");
    }
    private System.Collections.IEnumerator makeShootHereTrashGreen()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoManager.<makeShootHereTrashGreen>d__101(<>1__state:  0);
    }
    private void skipTrashABubbleSequence()
    {
        var val_2;
        this.StopCoroutine(methodName:  "TrashABubbleSequence");
        this.StopCoroutine(methodName:  "TrashABubblePlayerSequence");
        this.CancelInvoke(methodName:  "checkForTrashABubbleCompletion");
        this.StopCoroutine(methodName:  "makeShootHereTrashGreen");
        this.counterForTickButton = 5;
        this.demoCanvas.textTrashABubble.SetActive(value:  false);
        this.demoText.SetActive(value:  false);
        this.demoCanvas.textTrashaBubbleSmall.SetActive(value:  false);
        this.fingerTrashABubble.SetActive(value:  false);
        this.resetTapToTry();
        this.counterForTapToTry = 4;
        this.shootHereTrash.SetActive(value:  false);
        val_2 = null;
        val_2 = null;
        DemoManager.touchBoolForDemo = false;
        this.demoCanvas.textGoodStuff.SetActive(value:  false);
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "NowPopThoseBubblesPlayerSequence");
    }
    private System.Collections.IEnumerator NowPopThoseBubblesPlayerSequence()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DemoManager.<NowPopThoseBubblesPlayerSequence>d__103(<>1__state:  0);
    }
    public void finishTutorial()
    {
        AsyncSceneLoader.ActivePreloadScene(showLoadingScene:  true);
    }
    private void checkForNowPopThoseBubblesCompletion()
    {
        if(InstanceAnimator.isMiddleRingEmpty == false)
        {
                return;
        }
        
        null = null;
        if(InstanceAnimator.isOuterRingEmpty == false)
        {
                return;
        }
        
        if(InstanceAnimator.isInnerRingEmpty == false)
        {
                return;
        }
        
        this.CancelInvoke(methodName:  "checkForNowPopThoseBubblesCompletion");
    }
    private System.Collections.IEnumerator DestroyPlayerBalls(UnityEngine.GameObject[] ringArray, int length, bool ifWin)
    {
        DemoManager.<DestroyPlayerBalls>d__106 val_1 = new DemoManager.<DestroyPlayerBalls>d__106(<>1__state:  0);
        if(val_1 != null)
        {
                .<>4__this = this;
            .ringArray = ringArray;
        }
        else
        {
                mem[48] = this;
            mem[32] = ringArray;
        }
        
        .length = length;
        return (System.Collections.IEnumerator)val_1;
    }
    public DemoManager()
    {
        this.SpeedSegmentTimer = 20f;
        this.tempSwipeCounter = 0;
        this.tempCounterForTrash = 0;
    }
    private static DemoManager()
    {
    
    }

}
