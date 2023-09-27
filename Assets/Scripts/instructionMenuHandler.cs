using UnityEngine;
public class instructionMenuHandler : MonoBehaviour
{
    // Fields
    private static instructionMenuHandler _instance;
    public InkUpTutorialScript Panel_Ink_Up_Tutorial;
    public PanelSorryInkUpScript Panel_Sorry_Ink_Up;
    public UnityEngine.Sprite ikaStrip;
    public UnityEngine.Sprite takoStrip;
    public UnityEngine.Sprite mermaidStrip;
    public UnityEngine.Sprite[] characterTypeSprites;
    public UnityEngine.UI.Text Player1Name;
    public UnityEngine.UI.Image Player1Bar;
    public UnityEngine.UI.Text Player2Name;
    public UnityEngine.UI.Image Player2Bar;
    public UnityEngine.UI.Text shellCount;
    public UnityEngine.UI.Text lifeTimer;
    public UnityEngine.UI.Text livesRemaining;
    public UnityEngine.UI.Text lifeTimer1;
    public UnityEngine.UI.Text livesRemaining1;
    public UnityEngine.UI.Text pearlCount;
    public UnityEngine.UI.Image leftCharacterType;
    public UnityEngine.UI.Image rightCharacterType;
    public UnityEngine.GameObject canvasHandler;
    public UnityEngine.GameObject outOfLives;
    public UnityEngine.GameObject outOfShells;
    public UnityEngine.GameObject icon_Puzzle;
    public UnityEngine.GameObject icon_Battle;
    public UnityEngine.GameObject icon_Ex_Battle;
    public UnityEngine.GameObject icon_Demo;
    public UnityEngine.GameObject VS_char_Image_Player_Dynamic;
    public UnityEngine.GameObject scoreText;
    public UnityEngine.GameObject ballCounterText;
    public UnityEngine.GameObject canvasFlipper;
    public UnityEngine.GameObject textAttackCounter;
    public UnityEngine.GameObject ballCounter;
    public UnityEngine.GameObject blobPanel;
    public UnityEngine.GameObject specialBallCounterText;
    public UnityEngine.GameObject specialBallCounterXText;
    public UnityEngine.GameObject characterUnlockPanel;
    public UnityEngine.GameObject notEnoughPearlsPanel;
    public UnityEngine.GameObject TimerHolder;
    public UnityEngine.GameObject puzzleSwitcherText;
    public UnityEngine.GameObject specialBall;
    public UnityEngine.GameObject stageNumberText;
    private UnityEngine.GameObject canvasHandle;
    public static UnityEngine.UI.Text gameTimer;
    public static UnityEngine.UI.Text infinityTimer;
    
    // Properties
    public static instructionMenuHandler instance { get; }
    
    // Methods
    public static instructionMenuHandler get_instance()
    {
        if(instructionMenuHandler._instance != 0)
        {
                return (instructionMenuHandler)instructionMenuHandler._instance;
        }
        
        instructionMenuHandler._instance = UnityEngine.Object.FindObjectOfType<instructionMenuHandler>();
        return (instructionMenuHandler)instructionMenuHandler._instance;
    }
    private void Start()
    {
        var val_91;
        var val_92;
        float val_95;
        float val_96;
        var val_97;
        var val_98;
        GameMode val_99;
        UnityEngine.GameObject val_100;
        val_91 = null;
        val_91 = null;
        if(DataStructs.UserDataDictionary.Settings.FlipNegateX == 1)
        {
                UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if((System.String.op_Inequality(a:  val_2.m_Handle.name, b:  "PlaySceneVs")) != false)
        {
                val_92 = 1152921526078016624;
            this.canvasFlipper.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_9 = this.icon_Battle.gameObject.GetComponent<UnityEngine.Transform>().localScale;
            this.icon_Puzzle.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = -val_9.x, y = val_9.y, z = val_9.z};
            this.icon_Battle.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = -val_9.x, y = val_9.y, z = val_9.z};
            this.icon_Ex_Battle.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = -val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Vector3 val_18 = this.textAttackCounter.gameObject.GetComponent<UnityEngine.Transform>().localScale;
            this.textAttackCounter.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = -val_18.x, y = val_18.y, z = val_18.z};
            UnityEngine.Vector3 val_23 = this.stageNumberText.gameObject.GetComponent<UnityEngine.Transform>().localScale;
            this.stageNumberText.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = -val_23.x, y = val_23.y, z = val_23.z};
            this.stageNumberText.GetComponent<UnityEngine.UI.Text>().alignment = 3;
            UnityEngine.Vector3 val_29 = this.specialBallCounterText.gameObject.GetComponent<UnityEngine.Transform>().localScale;
            this.specialBallCounterText.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = -val_29.x, y = val_29.y, z = val_29.z};
            UnityEngine.Vector3 val_34 = this.specialBallCounterXText.gameObject.GetComponent<UnityEngine.Transform>().localScale;
            this.specialBallCounterXText.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = -val_34.x, y = val_34.y, z = val_34.z};
            UnityEngine.Vector3 val_39 = this.scoreText.gameObject.GetComponent<UnityEngine.Transform>().localScale;
            this.scoreText.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = -val_39.x, y = val_39.y, z = val_39.z};
            UnityEngine.Vector3 val_44 = this.ballCounter.gameObject.GetComponent<UnityEngine.Transform>().localScale;
            this.ballCounter.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = -val_44.x, y = val_44.y, z = val_44.z};
            UnityEngine.Vector3 val_49 = this.blobPanel.gameObject.GetComponent<UnityEngine.Transform>().localScale;
            this.blobPanel.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = -val_49.x, y = val_49.y, z = val_49.z};
            UnityEngine.Vector3 val_54 = this.puzzleSwitcherText.gameObject.GetComponent<UnityEngine.Transform>().localScale;
            this.puzzleSwitcherText.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = -val_54.x, y = val_54.y, z = val_54.z};
            UnityEngine.Vector3 val_59 = this.specialBall.gameObject.GetComponent<UnityEngine.Transform>().localScale;
            val_95 = val_59.y;
            val_96 = -val_59.x;
            this.specialBall.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = val_96, y = val_95, z = val_59.z};
        }
        
        }
        
        UnityEngine.SceneManagement.Scene val_62 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_62.m_Handle.name, b:  "DemoScene")) == false)
        {
            goto label_81;
        }
        
        this.textAttackCounter.SetActive(value:  false);
        this.ballCounterText.SetActive(value:  true);
        this.scoreText.SetActive(value:  false);
        if(this.icon_Demo != null)
        {
            goto label_93;
        }
        
        label_94:
        label_93:
        val_97 = 1;
        goto label_86;
        label_81:
        val_92 = 1152921505064992768;
        val_98 = null;
        val_98 = null;
        val_99 = Character_GlobalInfo.gameMode;
        if(val_99 != 3)
        {
            goto label_89;
        }
        
        this.textAttackCounter.SetActive(value:  true);
        this.icon_Puzzle.SetActive(value:  true);
        this.scoreText.SetActive(value:  false);
        if(this.ballCounterText != null)
        {
            goto label_93;
        }
        
        goto label_94;
        label_89:
        val_99 = Character_GlobalInfo.gameMode;
        if(val_99 != 1)
        {
            goto label_97;
        }
        
        this.stageNumberText.SetActive(value:  true);
        if((Character_GlobalInfo.stage_CurrentLevel - 1) <= 10)
        {
            goto label_102;
        }
        
        if((this.stageNumberText.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_104;
        }
        
        goto label_104;
        label_97:
        UnityEngine.SceneManagement.Scene val_68 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Inequality(a:  val_68.m_Handle.name, b:  "PlaySceneVs")) == false)
        {
            goto label_107;
        }
        
        this.stageNumberText.SetActive(value:  true);
        val_92 = 1152921526128259760;
        UnityEngine.UI.Text val_71 = this.stageNumberText.GetComponent<UnityEngine.UI.Text>();
        UnityEngine.Color val_73 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_95 = val_73.r;
        val_96 = val_73.b;
        this.stageNumberText.GetComponent<UnityEngine.UI.Text>().color = new UnityEngine.Color() {r = val_95, g = val_73.g, b = val_96, a = val_73.a};
        val_100 = this.icon_Ex_Battle;
        if(val_100 != null)
        {
            goto label_118;
        }
        
        goto label_114;
        label_102:
        val_92 = "STAGE " + Character_GlobalInfo.stage_CurrentLevel.ToString(format:  "D2")(Character_GlobalInfo.stage_CurrentLevel.ToString(format:  "D2"));
        label_104:
        val_100 = this.icon_Battle;
        if(val_100 != null)
        {
            goto label_118;
        }
        
        label_114:
        label_118:
        val_100.SetActive(value:  true);
        label_107:
        val_97 = 0;
        label_86:
        this.textAttackCounter.SetActive(value:  false);
        UnityEngine.SceneManagement.Scene val_77 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_77.m_Handle.name, b:  "PlaySceneVs")) != false)
        {
                this.TimerHolder.SetActive(value:  true);
            if(NetworkManager_Custom.IsNetwork != true)
        {
                this.Player1Bar.gameObject.SetActive(value:  false);
            this.Player2Bar.gameObject.SetActive(value:  false);
        }
        
            val_92 = 1152921525341438352;
            instructionMenuHandler.gameTimer = this.TimerHolder.transform.GetChild(index:  2).GetComponent<UnityEngine.UI.Text>();
            instructionMenuHandler.infinityTimer = this.TimerHolder.transform.GetChild(index:  3).GetComponent<UnityEngine.UI.Text>();
        }
        
        UnityEngine.Coroutine val_90 = this.StartCoroutine(routine:  this.instantiateObjects());
        this.InvokeRepeating(methodName:  "LifeTimer", time:  0f, repeatRate:  0.1f);
    }
    private void LifeTimer()
    {
        UnityEngine.UI.Text val_1 = this.lifeTimer.GetComponent<UnityEngine.UI.Text>();
        string val_2 = MVC_MusselTracker.GetTimeTilNextMussel();
        UnityEngine.UI.Text val_3 = this.lifeTimer1.GetComponent<UnityEngine.UI.Text>();
        string val_4 = MVC_MusselTracker.GetTimeTilNextMussel();
        UnityEngine.UI.Text val_5 = this.livesRemaining.GetComponent<UnityEngine.UI.Text>();
        string val_7 = MVC_MusselTracker.GetMusselCount().ToString();
        string val_10 = MVC_MusselTracker.GetMusselCount().ToString();
        if((this.livesRemaining1.GetComponent<UnityEngine.UI.Text>()) != null)
        {
                return;
        }
    
    }
    public void outOfLivesExit()
    {
        UnityEngine.GameObject val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        GameAudio.PlayButtonSound();
        val_4 = this.outOfLives;
        val_4.SetActive(value:  false);
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_1.m_Handle.name, b:  "PlayScene")) == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = WinScreenParticleManager.instance;
        if(WinScreenParticleManager.instance.isWinScreenShown == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(WinScreenParticleManager.instance.starsEarned >= 1)
        {
                val_7 = null;
            val_7 = null;
            UnityEngine.GameObject[].__il2cppRuntimeField_byval_arg.SetActive(value:  true);
        }
        
        val_8 = null;
        val_8 = null;
        if(WinScreenParticleManager.instance.starsEarned >= 2)
        {
                val_9 = null;
            val_9 = null;
            typeof(UnityEngine.GameObject[]).__il2cppRuntimeField_28.SetActive(value:  true);
        }
        
        val_10 = null;
        val_10 = null;
        val_4 = WinScreenParticleManager.instance;
        if(WinScreenParticleManager.instance.starsEarned < 3)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        UnityEngine.GameObject[].__il2cppRuntimeField_this_arg.SetActive(value:  true);
    }
    public void getOneLife()
    {
        GameAudio.PlayButtonSound();
        if(MVC_MusselTracker.GetMusselCount() > 7)
        {
                return;
        }
        
        if(PlayerPrefsManager.Pearls >= 300)
        {
                int val_3 = PlayerPrefsManager.Pearls;
            val_3 = val_3 - 300;
            PlayerPrefsManager.Pearls = val_3;
            MVC_MusselTracker.AddMussels(number:  1);
            GameAudio.PlayPurchaseSound();
            return;
        }
        
        this.notEnoughPearlsPanel.SetActive(value:  true);
    }
    public void getFiveLives()
    {
        GameAudio.PlayButtonSound();
        if(MVC_MusselTracker.GetMusselCount() > 4)
        {
                return;
        }
        
        if(PlayerPrefsManager.Pearls >= 1000)
        {
                int val_3 = PlayerPrefsManager.Pearls;
            val_3 = val_3 - 1000;
            PlayerPrefsManager.Pearls = val_3;
            MVC_MusselTracker.AddMussels(number:  4);
            GameAudio.PlayPurchaseSound();
            return;
        }
        
        this.notEnoughPearlsPanel.SetActive(value:  true);
    }
    public void OnNotEnoughPearlsPanelOkButton()
    {
        GameAudio.PlayButtonSound();
        this.notEnoughPearlsPanel.SetActive(value:  false);
    }
    private System.Collections.IEnumerator instantiateObjects()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new instructionMenuHandler.<instantiateObjects>d__52();
    }
    private UnityEngine.Sprite GetCharacterNameStripByClan(CharacterClan clan)
    {
        UnityEngine.Sprite val_1;
        if(clan == 2)
        {
            goto label_2;
        }
        
        if(clan == 1)
        {
            goto label_1;
        }
        
        if(clan == 0)
        {
                val_1 = this.ikaStrip;
            return (UnityEngine.Sprite)mem[this.takoStrip];
        }
        
        label_2:
        val_1 = this.mermaidStrip;
        return (UnityEngine.Sprite)mem[this.takoStrip];
        label_1:
        val_1 = this.takoStrip;
        return (UnityEngine.Sprite)mem[this.takoStrip];
    }
    public void nextStageButton()
    {
        var val_3;
        var val_10;
        var val_11;
        GameMode val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        UnityEngine.Time.timeScale = 1f;
        GameAudio.PlayButtonSound();
        val_10 = 1152921505064992768;
        val_11 = null;
        val_11 = null;
        val_12 = Character_GlobalInfo.gameMode;
        if(val_12 == 1)
        {
            goto label_5;
        }
        
        val_11 = null;
        val_12 = Character_GlobalInfo.gameMode;
        if(val_12 != 2)
        {
            goto label_71;
        }
        
        label_5:
        if(Character_GlobalInfo.stage_CurrentLevel != 4)
        {
            goto label_11;
        }
        
        CharacterInfo val_2 = Character_GlobalInfo.GetMainPlayer();
        val_10 = 1152921505125056512;
        val_13 = null;
        if(val_3 != 1)
        {
            goto label_14;
        }
        
        val_14 = null;
        if(StoryPanelScript.Tako_P1 == true)
        {
            goto label_71;
        }
        
        val_14 = null;
        StoryPanelScript.keyForStory = "Tako_P1";
        StoryPanelScript.Tako_P1 = true;
        goto label_56;
        label_11:
        if(Character_GlobalInfo.stage_CurrentLevel != 8)
        {
            goto label_23;
        }
        
        CharacterInfo val_5 = Character_GlobalInfo.GetMainPlayer();
        val_10 = 1152921505125056512;
        val_15 = null;
        if(val_3 != 1)
        {
            goto label_26;
        }
        
        val_16 = null;
        if(StoryPanelScript.Tako_P2 == true)
        {
            goto label_71;
        }
        
        val_16 = null;
        StoryPanelScript.keyForStory = "Tako_P2";
        StoryPanelScript.Tako_P2 = true;
        goto label_56;
        label_14:
        val_17 = null;
        if(StoryPanelScript.Ika_P1 == true)
        {
            goto label_71;
        }
        
        val_17 = null;
        StoryPanelScript.keyForStory = "Ika_P1";
        StoryPanelScript.Ika_P1 = true;
        goto label_56;
        label_23:
        if(Character_GlobalInfo.stage_CurrentLevel != 11)
        {
            goto label_41;
        }
        
        CharacterInfo val_7 = Character_GlobalInfo.GetMainPlayer();
        val_10 = 1152921505125056512;
        val_18 = null;
        if(val_3 != 1)
        {
            goto label_44;
        }
        
        val_19 = null;
        if(StoryPanelScript.Tako_PB == true)
        {
            goto label_71;
        }
        
        val_19 = null;
        StoryPanelScript.keyForStory = "Tako_PB";
        StoryPanelScript.Tako_PB = true;
        goto label_56;
        label_26:
        val_20 = null;
        if(StoryPanelScript.Ika_P2 == true)
        {
            goto label_71;
        }
        
        val_20 = null;
        StoryPanelScript.keyForStory = "Ika_P2";
        StoryPanelScript.Ika_P2 = true;
        goto label_56;
        label_41:
        if(Character_GlobalInfo.stage_CurrentLevel != 12)
        {
            goto label_71;
        }
        
        CharacterInfo val_9 = Character_GlobalInfo.GetMainPlayer();
        val_21 = null;
        if(val_3 != 1)
        {
            goto label_62;
        }
        
        val_22 = null;
        if(StoryPanelScript.Tako_End == true)
        {
            goto label_65;
        }
        
        val_22 = null;
        StoryPanelScript.keyForStory = "Tako_End";
        StoryPanelScript.Tako_End = true;
        goto label_68;
        label_44:
        val_23 = null;
        if(StoryPanelScript.Ika_PB == true)
        {
            goto label_71;
        }
        
        val_23 = null;
        StoryPanelScript.keyForStory = "Ika_PB";
        StoryPanelScript.Ika_PB = true;
        label_56:
        label_85:
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_LoadLevels");
        return;
        label_62:
        val_24 = null;
        if(StoryPanelScript.Ika_End == false)
        {
            goto label_79;
        }
        
        label_65:
        if(Character_GlobalInfo.hackBossStarsBeforeWin == 0)
        {
            goto label_82;
        }
        
        label_71:
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "Scene_LoadLevels", minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
        return;
        label_82:
        Credits.nextScene = "";
        goto label_85;
        label_79:
        val_24 = null;
        StoryPanelScript.keyForStory = "Ika_End";
        StoryPanelScript.Ika_End = true;
        label_68:
        StoryMovieCtrl.PlayED();
    }
    public void pressYes()
    {
        UnityEngine.Time.timeScale = 1f;
        GameAudio.PlayButtonSound();
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "Scene_LoadLevels", minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
    }
    public void restartpressedYes()
    {
        UnityEngine.GameObject val_6;
        var val_7;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        GameAudio.PlayButtonSound();
        if(MVC_MusselTracker.GetMusselCount() > 0)
        {
                bool val_2 = MVC_MusselTracker.UseMussels(number:  1);
            UnityEngine.Time.timeScale = 1f;
            val_6 = 1152921505064992768;
            val_7 = null;
            val_7 = null;
            if(Character_GlobalInfo.gameMode == 2)
        {
                Character_GlobalInfo.gameMode = 1;
        }
        
            AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "PlayScene", minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
            return;
        }
        
        this.notEnoughPearlsPanel.SetActive(value:  false);
        val_6 = this.outOfLives;
        val_6.SetActive(value:  true);
        UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_3.m_Handle.name, b:  "PlayScene")) == false)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        val_6 = WinScreenParticleManager.instance;
        if(WinScreenParticleManager.instance.isWinScreenShown == false)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        if(WinScreenParticleManager.instance.starsEarned >= 1)
        {
                val_11 = null;
            val_11 = null;
            UnityEngine.GameObject[].__il2cppRuntimeField_byval_arg.SetActive(value:  false);
        }
        
        val_12 = null;
        val_12 = null;
        if(WinScreenParticleManager.instance.starsEarned >= 2)
        {
                val_13 = null;
            val_13 = null;
            typeof(UnityEngine.GameObject[]).__il2cppRuntimeField_28.SetActive(value:  false);
        }
        
        val_14 = null;
        val_14 = null;
        val_6 = WinScreenParticleManager.instance;
        if(WinScreenParticleManager.instance.starsEarned < 3)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        UnityEngine.GameObject[].__il2cppRuntimeField_this_arg.SetActive(value:  false);
    }
    private void Update()
    {
        UnityEngine.UI.Text val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        val_24 = this;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_25 = 1152921505092788224;
        if((System.String.op_Equality(a:  val_1.m_Handle.name, b:  "PlaySceneVs")) == false)
        {
            goto label_3;
        }
        
        if((MVC_MusselTracker.GetMusselCount() < 2) || (this.outOfLives.activeInHierarchy == false))
        {
            goto label_23;
        }
        
        label_66:
        this.outOfLives.SetActive(value:  false);
        goto label_23;
        label_3:
        if((MVC_MusselTracker.GetMusselCount() < 1) || (this.outOfLives.activeInHierarchy == false))
        {
            goto label_23;
        }
        
        this.outOfLives.SetActive(value:  false);
        UnityEngine.SceneManagement.Scene val_8 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_8.m_Handle.name, b:  "PlayScene")) == false)
        {
            goto label_23;
        }
        
        val_26 = null;
        val_26 = null;
        if(WinScreenParticleManager.instance.isWinScreenShown == false)
        {
            goto label_23;
        }
        
        val_27 = null;
        val_27 = null;
        if(WinScreenParticleManager.instance.starsEarned >= 1)
        {
                val_28 = null;
            val_28 = null;
            UnityEngine.GameObject[].__il2cppRuntimeField_byval_arg.SetActive(value:  true);
        }
        
        val_29 = null;
        val_29 = null;
        if(WinScreenParticleManager.instance.starsEarned >= 2)
        {
                val_30 = null;
            val_30 = null;
            typeof(UnityEngine.GameObject[]).__il2cppRuntimeField_28.SetActive(value:  true);
        }
        
        val_31 = null;
        val_31 = null;
        if(WinScreenParticleManager.instance.starsEarned >= 3)
        {
            goto label_47;
        }
        
        label_23:
        if(UnityEngine.Time.timeScale != 0f)
        {
                return;
        }
        
        UnityEngine.UI.Text val_12 = this.lifeTimer.GetComponent<UnityEngine.UI.Text>();
        string val_13 = MVC_MusselTracker.GetTimeTilNextMussel();
        UnityEngine.UI.Text val_14 = this.lifeTimer1.GetComponent<UnityEngine.UI.Text>();
        string val_15 = MVC_MusselTracker.GetTimeTilNextMussel();
        UnityEngine.UI.Text val_16 = this.livesRemaining.GetComponent<UnityEngine.UI.Text>();
        string val_18 = MVC_MusselTracker.GetMusselCount().ToString();
        UnityEngine.UI.Text val_19 = this.livesRemaining1.GetComponent<UnityEngine.UI.Text>();
        val_25 = MVC_MusselTracker.GetMusselCount().ToString();
        val_24 = this.pearlCount;
        string val_23 = PlayerPrefsManager.Pearls.ToString();
        return;
        label_47:
        val_32 = null;
        val_32 = null;
        goto label_66;
    }
    public void buttonInapp()
    {
        GameAudio.PlayButtonSound();
    }
    public void unlockedPanelTickClick()
    {
        UnityEngine.Time.timeScale = 1f;
        GameAudio.PlayButtonSound();
        this.characterUnlockPanel.SetActive(value:  false);
    }
    public instructionMenuHandler()
    {
    
    }
    private void <instantiateObjects>b__52_0(CharacterAssetLoader loader)
    {
        this.VS_char_Image_Player_Dynamic.GetComponent<UnityEngine.UI.Image>().sprite = loader.LoadPose_Dynamic();
    }

}
