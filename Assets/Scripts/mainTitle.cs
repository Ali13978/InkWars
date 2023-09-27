using UnityEngine;
public class mainTitle : MonoBehaviour
{
    // Fields
    public static bool isGameStarted;
    public static bool ShowModeSelectImmediately;
    public UnityEngine.GameObject panelInfo;
    public UnityEngine.GameObject PanelOption;
    public UnityEngine.GameObject PanelStat;
    public UnityEngine.GameObject rateUsPanel;
    public UnityEngine.GameObject panelPearlReward;
    public UnityEngine.GameObject panelMusselReward;
    public UnityEngine.GameObject panelShellReward;
    public string[] instructionImageNames;
    public UnityEngine.UI.Image defaultImage;
    public int imageCounter;
    public UnityEngine.GameObject instructionScreen;
    public Fading FaderScreen;
    public UnityEngine.UI.Text[] statsText;
    public UnityEngine.UI.Text videoText;
    public UnityEngine.GameObject videoPanel;
    public UnityEngine.GameObject instructionMenuBackButton;
    public UnityEngine.GameObject videoNotAvailablePanel;
    public bool doMusselVideoReward;
    public UnityEngine.GameObject ModeButtons;
    public UnityEngine.GameObject ModeBackground;
    public UnityEngine.GameObject MenuButtons;
    public UnityEngine.GameObject MenuBackground;
    public UnityEngine.GameObject Logo;
    public UnityEngine.GameObject outOfLives;
    public UnityEngine.GameObject iOSLeaderboard;
    private UnityEngine.GameObject[] AdButtons;
    private static bool forceOptionAds;
    private static bool forceStatusAds;
    private bool doShellReward;
    
    // Methods
    private void OnEnable()
    {
        null = null;
        Character_GlobalInfo.isOfflineMode = false;
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
    public void videoNotAvailableExitButton()
    {
        this.videoNotAvailablePanel.SetActive(value:  false);
        this.doMusselVideoReward = false;
    }
    public void videoExitButton()
    {
        this.panelPearlReward.SetActive(value:  false);
        this.panelMusselReward.SetActive(value:  false);
        this.panelShellReward.SetActive(value:  false);
    }
    private void OnVideoFinished(bool ad_was_shown)
    {
        bool val_3;
        var val_4;
        if(this.doShellReward != false)
        {
                this.panelShellReward.SetActive(value:  true);
            int val_1 = PlayerPrefsManager.Shells;
            val_1 = val_1 + 1;
            PlayerPrefsManager.Shells = val_1;
            val_3 = this.doMusselVideoReward;
        }
        else
        {
                val_3 = this;
            if(this.doMusselVideoReward != false)
        {
                this.panelMusselReward.SetActive(value:  true);
            val_4 = null;
            val_4 = null;
            MVC_MusselTracker.AddMussels(number:  MVC_MusselTracker.MAX_MUSSELS);
        }
        else
        {
                this.panelPearlReward.SetActive(value:  true);
            int val_2 = PlayerPrefsManager.Pearls;
            val_2 = val_2 + 150;
            PlayerPrefsManager.Pearls = val_2;
        }
        
        }
        
        this.doMusselVideoReward = false;
        this.doShellReward = false;
        this.HideAdButtons();
    }
    private void OnV4VCResult(bool success, string name, int amount)
    {
        if(success != false)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "V4VC FAILED!");
    }
    private void Awake()
    {
        if((this.gameObject.name.Contains(value:  "CanvasChild")) != false)
        {
                return;
        }
        
        UnityEngine.Application.targetFrameRate = 100;
    }
    private void Start()
    {
        var val_7;
        var val_9;
        var val_10;
        MMOCClientUser val_1 = MMOCUser.current;
        val_7 = null;
        val_7 = null;
        if((mainTitle.<>c.<>9__40_0) == null)
        {
            goto label_3;
        }
        
        label_23:
        val_1.GetUserProfile(onGetUserProfileDone:  mainTitle.<>c.<>9__40_0);
        MainTitleBackMusicHandler.Play();
        if((this.gameObject.name.Contains(value:  "CanvasChild")) == true)
        {
                return;
        }
        
        UnityEngine.Screen.sleepTimeout = 0;
        this.panelInfo.SetActive(value:  false);
        this.instructionScreen.SetActive(value:  false);
        this.PanelOption.SetActive(value:  false);
        this.PanelStat.SetActive(value:  false);
        UnityEngine.Coroutine val_5 = this.StartCoroutine(methodName:  "AssignInstructionImages");
        this.HideAdButtons();
        val_9 = null;
        val_9 = null;
        if(mainTitle.ShowModeSelectImmediately == false)
        {
                return;
        }
        
        this.buttonPlaySFX(playButtonSound:  false);
        val_10 = null;
        val_10 = null;
        mainTitle.ShowModeSelectImmediately = false;
        this.ModeBackground.SetActive(value:  true);
        return;
        label_3:
        mainTitle.<>c.<>9__40_0 = new UnityEngine.Events.UnityAction<MMOCUserProfile>(object:  mainTitle.<>c.__il2cppRuntimeField_static_fields, method:  System.Void mainTitle.<>c::<Start>b__40_0(MMOCClientUser.MMOCUserProfile res));
        if(val_1 != null)
        {
            goto label_23;
        }
        
        goto label_23;
    }
    private void HideAdButtons()
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
    private System.Collections.IEnumerator AssignInstructionImages()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new mainTitle.<AssignInstructionImages>d__42();
    }
    public void buttonFacebook()
    {
        UnityEngine.Application.OpenURL(url:  "https://www.facebook.com/InkWarsGame/");
        GameAudio.PlayButtonSound();
    }
    public void buttonTwitter()
    {
        UnityEngine.Application.OpenURL(url:  "https://twitter.com/Inkwarsgame");
        GameAudio.PlayButtonSound();
    }
    public void buttonMonkeywithin()
    {
        UnityEngine.Application.OpenURL(url:  "http://inkwarsgame.com/learn");
        GameAudio.PlayButtonSound();
    }
    public void buttonRateUs()
    {
        null = null;
        DataStructs.UserDataDictionary.GameSave.IsRateUsClicked = true;
        UnityEngine.Application.OpenURL(url:  "https://play.google.com/store/apps/details?id=com.mediahive.inkwars&hl=en");
        GameAudio.PlayButtonSound();
    }
    public void buttonMayBeLater()
    {
        GameAudio.PlayButtonSound();
        this.rateUsPanel.SetActive(value:  false);
    }
    public void buttonPlay()
    {
        this.buttonPlaySFX(playButtonSound:  true);
    }
    public void buttonPlaySFX(bool playButtonSound = True)
    {
        this.FaderScreen.alpha = 1f;
        if(playButtonSound != false)
        {
                GameAudio.PlayButtonSound();
        }
        
        this.FaderScreen.alpha = 1f;
        this.ModeBackground.SetActive(value:  true);
    }
    public void getOneLife()
    {
        if(MVC_MusselTracker.GetMusselCount() >= MVC_MusselTracker.MAX_MUSSELS)
        {
                return;
        }
        
        if(PlayerPrefsManager.Pearls < 300)
        {
                UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            UnityEngine.PlayerPrefs.SetString(key:  "LastLevel", value:  val_3.m_Handle.name);
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_GetPearl");
            return;
        }
        
        int val_5 = PlayerPrefsManager.Pearls;
        val_5 = val_5 - 300;
        PlayerPrefsManager.Pearls = val_5;
        MVC_MusselTracker.AddMussels(number:  1);
        GameAudio.PlayPurchaseSound();
    }
    public void getFourLives()
    {
        if(MVC_MusselTracker.GetMusselCount() > 4)
        {
                return;
        }
        
        if(PlayerPrefsManager.Pearls < 1000)
        {
                UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            UnityEngine.PlayerPrefs.SetString(key:  "LastLevel", value:  val_3.m_Handle.name);
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_GetPearl");
            return;
        }
        
        int val_5 = PlayerPrefsManager.Pearls;
        val_5 = val_5 - 1000;
        PlayerPrefsManager.Pearls = val_5;
        MVC_MusselTracker.AddMussels(number:  4);
        GameAudio.PlayPurchaseSound();
    }
    private void CheckForRateUs()
    {
        var val_8;
        DataStructs.GameSave val_9;
        var val_10;
        var val_11;
        DataStructs.GameSave val_12;
        var val_13;
        var val_14;
        val_8 = null;
        val_8 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Stats.DayPassedSinceSignUp;
        int val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
        val_9 = DataStructs.UserDataDictionary.GameSave;
        if(val_9.IsRateUsShown != false)
        {
                val_10 = null;
            val_10 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = DataStructs.UserDataDictionary.GameSave.LastRateUpDaySinceSignUp;
            val_9 = val_4.currentCryptoKey;
            if((val_2 - (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_9, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited}))) < 2)
        {
                return;
        }
        
            val_11 = null;
            val_11 = null;
            val_12 = DataStructs.UserDataDictionary.GameSave;
            val_13 = null;
        }
        else
        {
                if(val_2 < 5)
        {
                return;
        }
        
            val_14 = null;
            val_14 = null;
            DataStructs.UserDataDictionary.GameSave.IsRateUsShown = true;
            val_13 = null;
            val_12 = DataStructs.UserDataDictionary.GameSave;
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_2);
        val_12.LastRateUpDaySinceSignUp = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue, inited = val_7.inited};
        this.rateUsPanel.SetActive(value:  true);
    }
    public void buttonOption()
    {
        GameAudio.PlayButtonSound();
        this.PanelOption.SetActive(value:  true);
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
    public void panelExit()
    {
        GameAudio.PlayButtonSound();
        this.PanelOption.SetActive(value:  false);
    }
    public void optionInfo()
    {
        GameAudio.PlayButtonSound();
        this.panelInfo.SetActive(value:  true);
    }
    public void infoExit()
    {
        GameAudio.PlayButtonSound();
        this.panelInfo.SetActive(value:  false);
    }
    public void privacyLink()
    {
        GameAudio.PlayButtonSound();
        UnityEngine.Application.OpenURL(url:  "http://inkwarsgame.com/privacy-policy/");
    }
    public void buttonCart()
    {
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Shop_scene");
    }
    public void buttonGallery()
    {
        var val_2;
        GameAudio.PlayButtonSound();
        val_2 = null;
        val_2 = null;
        UnityEngine.Object.Destroy(obj:  MainTitleBackMusicHandler.instance.gameObject);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Main_Gallery");
    }
    public void buttonStats()
    {
        var val_1;
        GameAudio.PlayButtonSound();
        this.PanelStat.SetActive(value:  true);
        val_1 = null;
        val_1 = null;
        mainTitle.forceStatusAds = false;
    }
    public void buttonLeaderboard()
    {
        GameAudio.PlayButtonSound();
        LeaderboardPanel val_1 = LeaderboardPanel.Show();
    }
    public void statExit()
    {
        GameAudio.PlayButtonSound();
        this.PanelStat.SetActive(value:  false);
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
    public void buttonInapp()
    {
        var val_3;
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        UnityEngine.PlayerPrefs.SetString(key:  "LastLevel", value:  val_1.m_Handle.name);
        val_3 = null;
        val_3 = null;
        sceneGetPearl.showShellPanelAsDefault = true;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_GetPearl");
    }
    public void loginButton(UnityEngine.UI.Text txt)
    {
        IntPtr val_5;
        .txt = txt;
        System.Action<System.Boolean> val_3 = null;
        val_5 = System.Void mainTitle.<>c__DisplayClass68_0::<loginButton>b__0(bool success);
        val_3 = new System.Action<System.Boolean>(object:  new mainTitle.<>c__DisplayClass68_0(), method:  val_5);
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_5 = 0;
        UnityEngine.Social.localUser.Authenticate(callback:  val_3);
    }
    public void AdButtonShells()
    {
        GameAudio.PlayButtonSound();
        this.doMusselVideoReward = false;
        this.doShellReward = true;
    }
    public void AdButtonMussel()
    {
        GameAudio.PlayButtonSound();
        this.doMusselVideoReward = true;
        this.doShellReward = false;
    }
    public void AdButton()
    {
        GameAudio.PlayButtonSound();
        this.doMusselVideoReward = false;
        this.doShellReward = false;
    }
    public void creditsButton()
    {
        var val_2;
        GameAudio.PlayButtonSound();
        val_2 = null;
        val_2 = null;
        UnityEngine.Object.Destroy(obj:  MainTitleBackMusicHandler.instance.gameObject);
        Credits.nextScene = "Menu_Title_Screen";
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Credits");
    }
    private System.Collections.IEnumerator GoToCharacterSelect()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new mainTitle.<GoToCharacterSelect>d__74();
    }
    public void SocialMediaToggleClick(UnityEngine.Animator anim)
    {
        GameAudio.PlayButtonSound();
        anim.Play(stateName:  "Expand");
    }
    public void NewsExpandButtonClicked(UnityEngine.Animator anim)
    {
        GameAudio.PlayButtonSound();
        anim.Play(stateName:  "NewsExpand");
    }
    public void NewsShrinkButtonClicked(UnityEngine.Animator anim)
    {
        GameAudio.PlayButtonSound();
        anim.Play(stateName:  "NewsShrink");
    }
    public void AdventureClicked()
    {
        var val_2;
        var val_3;
        GameAudio.PlayButtonSound();
        val_2 = null;
        val_2 = null;
        UnityEngine.Object.Destroy(obj:  MainTitleBackMusicHandler.instance.gameObject);
        val_3 = null;
        val_3 = null;
        Character_GlobalInfo.gameMode = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_PlayerChoose");
    }
    public void RankingVsClicked()
    {
        var val_3;
        UnityEngine.Debug.LogFormat(format:  "Rinking VS CLICKED", args:  System.Array.Empty<System.Object>());
        GameAudio.PlayButtonSound();
        val_3 = null;
        val_3 = null;
        UnityEngine.Object.Destroy(obj:  MainTitleBackMusicHandler.instance.gameObject);
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "NetworkLobbyNew", minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
    }
    public void LocalVsClicked()
    {
        var val_2;
        GameAudio.PlayButtonSound();
        PlayerPrefsManager.OnlinePVPTime = PlayerPrefsManager.LocalPVPTime;
        val_2 = null;
        val_2 = null;
        Character_GlobalInfo.gameMode = 5;
        AsyncSceneLoader.Load(sceneName:  "CharacterSelect", minimumDelayInSeconds:  0f, showLoadingScreen:  false, autoHideLoadingScreen:  true);
    }
    public mainTitle()
    {
        this.imageCounter = 15;
    }
    private static mainTitle()
    {
        mainTitle.isGameStarted = true;
        mainTitle.ShowModeSelectImmediately = false;
        mainTitle.forceOptionAds = true;
        mainTitle.forceStatusAds = true;
    }

}
