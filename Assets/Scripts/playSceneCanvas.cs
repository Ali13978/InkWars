using UnityEngine;
public class playSceneCanvas : MonoBehaviour
{
    // Fields
    public static playSceneCanvas Instance;
    public UnityEngine.GameObject shellBox;
    public UnityEngine.GameObject PanelOption;
    public UnityEngine.GameObject SinglePlayerPause;
    public UnityEngine.GameObject MultiPlayerPause;
    public UnityEngine.GameObject[] VsPlayerObjectsToActivate;
    public string[] instructionImageNames;
    public UnityEngine.UI.Image defaultImage;
    public int imageCounter;
    public UnityEngine.GameObject instructionScreen;
    public UnityEngine.GameObject panelOptionBack;
    public UnityEngine.GameObject restartPanel;
    public UnityEngine.AudioClip vaccumSound;
    public UnityEngine.GameObject outOfLives;
    public UnityEngine.UI.Text[] shellText;
    public UnityEngine.UI.Text[] lifeTimers;
    public UnityEngine.UI.Text[] livesRemainings;
    public UnityEngine.UI.Text lifeTimer;
    public UnityEngine.UI.Text livesRemaining;
    public UnityEngine.UI.Text lifeTimer1;
    public UnityEngine.UI.Text livesRemaining1;
    public UnityEngine.UI.Text pearlCount;
    public UnityEngine.UI.Text[] pearlCounters;
    private bool resurrectFlag;
    public UnityEngine.GameObject LifeBox;
    public UnityEngine.GameObject instructionMenuBackButton;
    public UnityEngine.GameObject notEnoughPearlsPanel;
    private UnityEngine.GameObject[] AdButtons;
    public UnityEngine.GameObject panelMusselReward;
    public UnityEngine.UI.Text rewardText;
    
    // Properties
    public static int Shells { get; set; }
    
    // Methods
    private void Awake()
    {
        playSceneCanvas.Instance = this;
    }
    private System.Collections.IEnumerator Start()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new playSceneCanvas.<Start>d__31();
    }
    private void OnEnable()
    {
    
    }
    private void OnDisable()
    {
    
    }
    private void OnAdDone()
    {
        this.OnVideoFinished(ad_was_shown:  false);
    }
    private void PlayAd()
    {
    
    }
    public void ShowUnityRewardedAd()
    {
    
    }
    private System.Collections.IEnumerator HideEffect()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new playSceneCanvas.<HideEffect>d__37();
    }
    public void AdButtonMussel()
    {
    
    }
    public void MusselEarnedPanelExit(UnityEngine.GameObject panel)
    {
        GameAudio.PlayButtonSound();
        panel.SetActive(value:  false);
        this.HideAdButtons();
    }
    private void OnVideoFinished(bool ad_was_shown)
    {
        var val_8;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if(((System.String.op_Equality(a:  val_1.m_Handle.name, b:  "PlaySceneVs")) == false) || (NetworkManager_Custom.IsNetwork == false))
        {
            goto label_4;
        }
        
        int val_5 = PlayerPrefsManager.Shells;
        val_5 = val_5 + 1;
        playSceneCanvas.Shells = val_5;
        if(this.rewardText != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_4:
        val_8 = null;
        val_8 = null;
        MVC_MusselTracker.AddMussels(number:  MVC_MusselTracker.MAX_MUSSELS);
        label_6:
        DialogPanel val_6 = DialogManager.Show(title:  "CONGRATULATIONS!", message:  "YOU HAVE EARNED THE MAXIMUM AMOUNT OF MUSSELS", cancelButtonTitle:  "OK", onCancelCallback:  0);
        UnityEngine.Coroutine val_7 = this.StartCoroutine(methodName:  "HideEffect");
        this.HideAdButtons();
    }
    public void videoExitButton()
    {
        UnityEngine.GameObject val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        UnityEngine.Time.timeScale = 1f;
        val_4 = this.panelMusselReward;
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
    public void HideAdButtons()
    {
        goto label_0;
        label_4:
        this.AdButtons[0].SetActive(value:  false);
        0 = 1;
        label_0:
        if(0 < this.AdButtons.Length)
        {
            goto label_4;
        }
    
    }
    private void LifeTimer()
    {
        UnityEngine.UI.Text val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = this;
        val_7 = 0;
        goto label_1;
        label_7:
        UnityEngine.UI.Text val_6 = this.lifeTimers[0];
        string val_1 = MVC_MusselTracker.GetTimeTilNextMussel();
        val_7 = 1;
        label_1:
        if(val_7 < this.lifeTimers.Length)
        {
            goto label_7;
        }
        
        val_8 = 0;
        goto label_8;
        label_14:
        UnityEngine.UI.Text val_7 = this.livesRemainings[0];
        string val_3 = MVC_MusselTracker.GetMusselCount().ToString();
        val_8 = 1;
        label_8:
        if(val_8 < this.livesRemainings.Length)
        {
            goto label_14;
        }
        
        val_9 = 0;
        goto label_15;
        label_19:
        val_6 = this.pearlCounters[0];
        string val_5 = PlayerPrefsManager.Pearls.ToString();
        val_9 = 1;
        label_15:
        if(val_9 < this.pearlCounters.Length)
        {
            goto label_19;
        }
    
    }
    public void outOfLivesExit()
    {
        UnityEngine.GameObject val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_5 = this;
        this.outOfLives.SetActive(value:  false);
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_1.m_Handle.name, b:  "PlayScene")) == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(WinScreenParticleManager.instance.isWinScreenShown == false)
        {
                return;
        }
        
        val_5 = this.panelMusselReward;
        if(val_5.activeInHierarchy == true)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(WinScreenParticleManager.instance.starsEarned >= 1)
        {
                val_8 = null;
            val_8 = null;
            UnityEngine.GameObject[].__il2cppRuntimeField_byval_arg.SetActive(value:  true);
        }
        
        val_9 = null;
        val_9 = null;
        if(WinScreenParticleManager.instance.starsEarned >= 2)
        {
                val_10 = null;
            val_10 = null;
            typeof(UnityEngine.GameObject[]).__il2cppRuntimeField_28.SetActive(value:  true);
        }
        
        val_11 = null;
        val_11 = null;
        val_5 = WinScreenParticleManager.instance;
        if(WinScreenParticleManager.instance.starsEarned < 3)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        UnityEngine.GameObject[].__il2cppRuntimeField_this_arg.SetActive(value:  true);
    }
    public void getOneLife()
    {
        GameAudio.PlayButtonSound();
        if(MVC_MusselTracker.GetMusselCount() >= MVC_MusselTracker.MAX_MUSSELS)
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
    public void getFourLives()
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
    public void buttonPlay()
    {
        var val_2;
        GameAudio.sound.UnPause();
        val_2 = null;
        val_2 = null;
        LineController.instance.gamePaused = false;
        UnityEngine.Time.timeScale = 1f;
        GameAudio.PlayButtonSound();
        this.LifeBox.SetActive(value:  false);
        this.shellBox.SetActive(value:  false);
        this.PanelOption.SetActive(value:  false);
    }
    public void buttonOption()
    {
        var val_6;
        var val_7;
        UnityEngine.GameObject val_8;
        GameAudio.sound.Pause();
        this.HideAdButtons();
        val_6 = null;
        val_6 = null;
        LineController.instance.gamePaused = true;
        GameAudio.PlayButtonSound();
        this.PanelOption.SetActive(value:  true);
        this.SinglePlayerPause.SetActive(value:  false);
        this.MultiPlayerPause.SetActive(value:  false);
        val_7 = null;
        val_7 = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
            goto label_15;
        }
        
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Inequality(a:  val_2.m_Handle.name, b:  "PlaySceneVs")) == false)
        {
            goto label_15;
        }
        
        this.SinglePlayerPause.SetActive(value:  true);
        goto label_19;
        label_15:
        this.MultiPlayerPause.SetActive(value:  true);
        if(NetworkManager_Custom.IsNetwork == false)
        {
            goto label_19;
        }
        
        val_8 = this.shellBox;
        if(val_8 != null)
        {
            goto label_22;
        }
        
        goto label_21;
        label_19:
        val_8 = this.LifeBox;
        if(val_8 != null)
        {
            goto label_22;
        }
        
        label_21:
        label_22:
        val_8.SetActive(value:  true);
        UnityEngine.Time.timeScale = 0f;
    }
    public void optionTutorial()
    {
        GameAudio.PlayButtonSound();
        this.imageCounter = 0;
        this.defaultImage.GetComponent<UnityEngine.UI.Image>().sprite = InstructionCollection.GetById(id:  this.imageCounter);
        this.instructionScreen.SetActive(value:  true);
        this.PanelOption.SetActive(value:  true);
    }
    public void optionTutorialExit()
    {
        GameAudio.PlayButtonSound();
        this.instructionScreen.SetActive(value:  false);
        this.PanelOption.SetActive(value:  true);
    }
    public void panelMenu()
    {
        GameAudio.PlayButtonSound();
        this.panelOptionBack.SetActive(value:  true);
    }
    public void pressYes()
    {
        UnityEngine.Time.timeScale = 1f;
        GameAudio.PlayButtonSound();
        GameAudio.sound.UnPause();
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        bool val_4 = System.String.op_Equality(a:  val_2.m_Handle.name, b:  "PlaySceneVs");
        if(val_4 != false)
        {
                val_4.Rematch();
            return;
        }
        
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "Scene_LoadLevels", minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
    }
    public void pressNo()
    {
        GameAudio.PlayButtonSound();
        this.panelOptionBack.SetActive(value:  false);
    }
    public void restartButton()
    {
        object val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_15 = this;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_1.m_Handle.name, b:  "PlaySceneVs")) != false)
        {
                if(PlayerPrefsManager.Shells <= 0)
        {
                if(NetworkManager_Custom.IsNetwork == true)
        {
            goto label_9;
        }
        
        }
        
            if(MVC_MusselTracker.GetMusselCount() <= 1)
        {
                if(NetworkManager_Custom.IsNetwork == false)
        {
            goto label_9;
        }
        
        }
        
            UnityEngine.Time.timeScale = 1f;
            GameAudio.PlayButtonSound();
            this.Rematch();
            return;
        }
        
        if(MVC_MusselTracker.GetMusselCount() <= 0)
        {
            goto label_15;
        }
        
        GameAudio.PlayButtonSound();
        YesNoDialog val_11 = YesNoDialog.Show(title:  "RESTART", msg:  "ARE YOU SURE?", yesAction:  new System.Action(object:  this, method:  public System.Void playSceneCanvas::restartpressedYes()), noAction:  new System.Action(object:  this, method:  public System.Void playSceneCanvas::restartpressedNo()));
        return;
        label_9:
        GameAudio.PlayButtonSound();
        this.HideAdButtons();
        val_15 = this.outOfLives;
        label_63:
        val_15.SetActive(value:  true);
        return;
        label_15:
        GameAudio.PlayButtonSound();
        this.HideAdButtons();
        val_15 = this.outOfLives;
        val_15.SetActive(value:  true);
        UnityEngine.SceneManagement.Scene val_12 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_12.m_Handle.name, b:  "PlayScene")) == false)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_15 = WinScreenParticleManager.instance;
        if(WinScreenParticleManager.instance.isWinScreenShown == false)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        if(WinScreenParticleManager.instance.starsEarned >= 1)
        {
                val_18 = null;
            val_18 = null;
            UnityEngine.GameObject[].__il2cppRuntimeField_byval_arg.SetActive(value:  false);
        }
        
        val_19 = null;
        val_19 = null;
        if(WinScreenParticleManager.instance.starsEarned >= 2)
        {
                val_20 = null;
            val_20 = null;
            typeof(UnityEngine.GameObject[]).__il2cppRuntimeField_28.SetActive(value:  false);
        }
        
        val_21 = null;
        val_21 = null;
        val_15 = WinScreenParticleManager.instance;
        if(WinScreenParticleManager.instance.starsEarned < 3)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        goto label_63;
    }
    public void Rematch()
    {
        var val_5;
        var val_6;
        UnityEngine.Time.timeScale = 1f;
        if(NetworkManager_Custom.IsNetwork != false)
        {
                val_5 = null;
            val_5 = null;
            LanPlaySceneManager.instance.AskForRematch();
            return;
        }
        
        UnityEngine.Object val_4 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  "BattleVSGates", systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())));
        val_6 = null;
        if(BattleVSGates.instance == null)
        {
                val_6 = null;
        }
        
        BattleVSGates.instance.nextSceneName = "PlaySceneVS";
        BattleVSGates.instance.Trigger(doNotShowGates:  true);
    }
    public void CharacterSelect()
    {
        var val_7;
        GameAudio.PlayButtonSound();
        if(MVC_MusselTracker.GetMusselCount() <= 1)
        {
                if(NetworkManager_Custom.IsNetwork == false)
        {
            goto label_6;
        }
        
        }
        
        GameAudio.sound.UnPause();
        UnityEngine.Time.timeScale = 1f;
        if(NetworkManager_Custom.IsNetwork != false)
        {
                val_7 = null;
            val_7 = null;
            LanPlaySceneManager.instance.AskForCharacterScreen();
            return;
        }
        
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  playSceneCanvas.WaitForFourFrames(levelName:  "Scene_PlayerChoose"));
        return;
        label_6:
        GameAudio.PlayButtonSound();
        playSceneCanvas.Instance.HideAdButtons();
        SetActive(value:  true);
    }
    public static System.Collections.IEnumerator WaitForFourFrames(string levelName)
    {
        .<>1__state = 0;
        .levelName = levelName;
        return (System.Collections.IEnumerator)new playSceneCanvas.<WaitForFourFrames>d__58();
    }
    public void restartpressedYes()
    {
        UnityEngine.GameObject val_10;
        var val_11;
        val_10 = this;
        GameAudio.PlayButtonSound();
        GameAudio.sound.UnPause();
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_2.m_Handle.name, b:  "PlaySceneVs")) == false)
        {
            goto label_6;
        }
        
        if(PlayerPrefsManager.Shells <= 0)
        {
            goto label_7;
        }
        
        if(MVC_MusselTracker.GetMusselCount() <= 1)
        {
                if(NetworkManager_Custom.IsNetwork == false)
        {
            goto label_11;
        }
        
        }
        
        UnityEngine.Time.timeScale = 1f;
        this.Rematch();
        return;
        label_6:
        bool val_8 = MVC_MusselTracker.UseMussels(number:  1);
        UnityEngine.Time.timeScale = 1f;
        val_10 = 1152921505064992768;
        if(Character_GlobalInfo.stage_CurrentLevel == 12)
        {
                val_11 = null;
            val_11 = null;
            if(Character_GlobalInfo.gameMode == 2)
        {
                Character_GlobalInfo.gameMode = 1;
        }
        
        }
        
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "PlayScene", minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
        return;
        label_7:
        this.notEnoughPearlsPanel.SetActive(value:  false);
        goto label_25;
        label_11:
        GameAudio.PlayButtonSound();
        label_25:
        this.HideAdButtons();
        val_10 = this.outOfLives;
        val_10.SetActive(value:  true);
    }
    public void restartpressedNo()
    {
        GameAudio.PlayButtonSound();
        this.restartPanel.SetActive(value:  false);
    }
    public void nextButton()
    {
        int val_5;
        GameAudio.PlayButtonSound();
        int val_5 = this.imageCounter;
        val_5 = ((val_5 + 1) == 3) ? (val_5 + 2) : (val_5 + 1);
        this.imageCounter = val_5;
        if(val_5 == 0)
        {
                this.instructionMenuBackButton.SetActive(value:  false);
            val_5 = this.imageCounter;
        }
        
        if(val_5 == 1)
        {
                this.instructionMenuBackButton.SetActive(value:  true);
            val_5 = this.imageCounter;
        }
        
        if(val_5 == 13)
        {
                this.instructionScreen.SetActive(value:  false);
            this.PanelOption.SetActive(value:  true);
            return;
        }
        
        this.defaultImage.GetComponent<UnityEngine.UI.Image>().sprite = InstructionCollection.GetById(id:  this.imageCounter);
    }
    public void instructionBackButton()
    {
        int val_5;
        GameAudio.PlayButtonSound();
        int val_5 = this.imageCounter;
        int val_1 = val_5 - 1;
        val_5 = val_5 - 2;
        int val_2 = (val_1 == 3) ? (val_5) : (val_1);
        this.imageCounter = val_2;
        if(val_2 == 0)
        {
                this.instructionMenuBackButton.SetActive(value:  false);
            val_5 = this.imageCounter;
        }
        
        if(val_5 != 1)
        {
                this.defaultImage.GetComponent<UnityEngine.UI.Image>().sprite = InstructionCollection.GetById(id:  this.imageCounter);
            return;
        }
        
        this.instructionScreen.SetActive(value:  false);
        this.PanelOption.SetActive(value:  true);
    }
    private void Update()
    {
        int val_22;
        var val_23;
        UnityEngine.UI.Text[] val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        val_22 = this;
        val_23 = null;
        val_23 = null;
        if((LineController.bossStageFlag != false) && (this.resurrectFlag != false))
        {
                this.resurrectFlag = false;
            UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "instantiateObjects");
        }
        
        val_24 = 1152921504864088064;
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_2.m_Handle.name, b:  "PlaySceneVs")) == false)
        {
            goto label_7;
        }
        
        if((MVC_MusselTracker.GetMusselCount() < 2) || (this.outOfLives.activeInHierarchy == false))
        {
            goto label_29;
        }
        
        label_81:
        this.outOfLives.SetActive(value:  false);
        goto label_29;
        label_7:
        if((MVC_MusselTracker.GetMusselCount() < 1) || (this.outOfLives.activeInHierarchy == false))
        {
            goto label_29;
        }
        
        this.outOfLives.SetActive(value:  false);
        UnityEngine.SceneManagement.Scene val_9 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_9.m_Handle.name, b:  "PlayScene")) == false)
        {
            goto label_29;
        }
        
        val_24 = 1152921505145663488;
        val_25 = null;
        val_25 = null;
        if((WinScreenParticleManager.instance.isWinScreenShown == false) || (this.panelMusselReward.activeInHierarchy == true))
        {
            goto label_29;
        }
        
        val_26 = null;
        val_26 = null;
        if(WinScreenParticleManager.instance.starsEarned >= 1)
        {
                val_27 = null;
            val_27 = null;
            UnityEngine.GameObject[].__il2cppRuntimeField_byval_arg.SetActive(value:  true);
        }
        
        val_28 = null;
        val_28 = null;
        if(WinScreenParticleManager.instance.starsEarned >= 2)
        {
                val_29 = null;
            val_29 = null;
            typeof(UnityEngine.GameObject[]).__il2cppRuntimeField_28.SetActive(value:  true);
        }
        
        val_30 = null;
        val_30 = null;
        if(WinScreenParticleManager.instance.starsEarned >= 3)
        {
            goto label_53;
        }
        
        label_29:
        if(UnityEngine.Time.timeScale != 0f)
        {
                return;
        }
        
        val_31 = 0;
        goto label_55;
        label_61:
        UnityEngine.UI.Text val_21 = this.lifeTimers[0];
        string val_14 = MVC_MusselTracker.GetTimeTilNextMussel();
        val_31 = 1;
        label_55:
        if(val_31 < this.lifeTimers.Length)
        {
            goto label_61;
        }
        
        val_32 = 0;
        goto label_62;
        label_68:
        UnityEngine.UI.Text val_22 = this.livesRemainings[val_31];
        string val_16 = MVC_MusselTracker.GetMusselCount().ToString();
        val_32 = 2;
        label_62:
        if(val_32 < this.livesRemainings.Length)
        {
            goto label_68;
        }
        
        int val_17 = PlayerPrefsManager.Pearls;
        string val_18 = val_17.ToString();
        val_24 = this.pearlCounters;
        val_22 = 0;
        goto label_70;
        label_74:
        UnityEngine.UI.Text val_23 = val_24[val_17];
        string val_20 = PlayerPrefsManager.Pearls.ToString();
        val_22 = val_17 + 1;
        label_70:
        if(val_22 < this.pearlCounters.Length)
        {
            goto label_74;
        }
        
        return;
        label_53:
        val_33 = null;
        val_33 = null;
        goto label_81;
    }
    private System.Collections.IEnumerator instantiateObjects()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new playSceneCanvas.<instantiateObjects>d__64();
    }
    public void buttonInapp()
    {
        GameAudio.PlayButtonSound();
    }
    public void onPurchaseButtonClick(string sku)
    {
    
    }
    public static int get_Shells()
    {
        return PlayerPrefsManager.Shells;
    }
    public static void set_Shells(int value)
    {
        PlayerPrefsManager.Shells = value;
        string val_1 = value.ToString();
        string val_2 = value.ToString();
        instructionMenuHandler val_3 = instructionMenuHandler.instance;
        string val_4 = value.ToString();
        GameOverPanel.instance.InitUserData();
    }
    public playSceneCanvas()
    {
        this.imageCounter = 15;
        this.resurrectFlag = true;
    }

}
