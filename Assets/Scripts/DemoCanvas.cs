using UnityEngine;
public class DemoCanvas : MonoBehaviour
{
    // Fields
    public static DemoCanvas _instance;
    public UnityEngine.GameObject AdvancedTutorialTopBar;
    public CharacterAvatarController AvatarLeft;
    public CharacterAvatarController AvatarRight;
    public UnityEngine.UI.Image TypeLeft;
    public UnityEngine.UI.Image TypeRight;
    public UnityEngine.UI.Image BarLeft;
    public UnityEngine.UI.Image BarRight;
    public UnityEngine.GameObject[] Stages;
    public UnityEngine.GameObject TrashIt;
    public UnityEngine.GameObject ShootAnywhere;
    public UnityEngine.Animation[] StunsEmLonger;
    public UnityEngine.UI.Text CountdownTimer;
    public UnityEngine.UI.Text CountdownTimer_Infinite;
    public UnityEngine.UI.Text Counter_Left;
    public UnityEngine.UI.Text Counter_Right;
    public UnityEngine.UI.Text SpeedStageDebrief;
    public UnityEngine.UI.Text RainbowStageDebrief;
    public UnityEngine.UI.Text MatchStageDebrief;
    public UnityEngine.GameObject textHowToAimSmall;
    public UnityEngine.GameObject textHowToShootSmall;
    public UnityEngine.GameObject textRechargingSmall;
    public UnityEngine.GameObject textSwitchingBubblesSmall;
    public UnityEngine.GameObject textTrashaBubbleSmall;
    public UnityEngine.GameObject textNailTheBasics;
    public UnityEngine.GameObject textHowToAimLarge;
    public UnityEngine.GameObject textGreat;
    public UnityEngine.GameObject textHowToShoot;
    public UnityEngine.GameObject textWellDone;
    public UnityEngine.GameObject textRecharging;
    public UnityEngine.GameObject textGotThat;
    public UnityEngine.GameObject textSwitchingBubbles;
    public UnityEngine.GameObject textAlright;
    public UnityEngine.GameObject textTrashABubble;
    public UnityEngine.GameObject textGoodStuff;
    public UnityEngine.GameObject textNowPopThoseBubbles;
    public UnityEngine.GameObject textYouDidIt;
    public UnityEngine.GameObject textDemo;
    public UnityEngine.GameObject panelChooseHands;
    public UnityEngine.GameObject panelDemoScene;
    public UnityEngine.GameObject skipButtonLeft;
    public UnityEngine.GameObject skipButtonRight;
    public UnityEngine.GameObject demoManager;
    public UnityEngine.GameObject AdvancedSkipButton;
    
    // Properties
    public static DemoCanvas Instance { get; }
    
    // Methods
    public static DemoCanvas get_Instance()
    {
        if(DemoCanvas._instance != 0)
        {
                return (DemoCanvas)DemoCanvas._instance;
        }
        
        DemoCanvas._instance = UnityEngine.Object.FindObjectOfType<DemoCanvas>();
        return (DemoCanvas)DemoCanvas._instance;
    }
    private void Start()
    {
        this.skipButtonLeft.SetActive(value:  false);
        this.skipButtonRight.SetActive(value:  false);
        DemoManager val_1 = DemoManager.Instance;
        if(val_1.IsAdvancedTutorialMode != false)
        {
                return;
        }
        
        this.AdvancedSkipButton.SetActive(value:  false);
    }
    public void AdvancedSkipButtonClick()
    {
        AsyncSceneLoader.ActivePreloadScene(showLoadingScene:  true);
    }
    public void onSkipButtonClick()
    {
        if(this.demoManager != 0)
        {
                this.demoManager.GetComponent<DemoManager>().OnSkipButtonClick();
            return;
        }
        
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "Scene_LoadLevels", minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
    }
    internal void SetTopBar(TutorialDataManager.PlayerData player_Left, TutorialDataManager.PlayerData player_Right)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.LoadCharacterResources(nameID:  player_Left.charNameID, avatar:  this.AvatarLeft, typeIcon:  this.TypeLeft));
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.LoadCharacterResources(nameID:  player_Right.charNameID, avatar:  this.AvatarRight, typeIcon:  this.TypeRight));
        TutorialDataManager val_5 = TutorialDataManager.Instance;
        this.BarLeft.sprite = (player_Left.IsTako == true) ? val_5.TakoBar : val_5.IkaBar;
        TutorialDataManager val_7 = TutorialDataManager.Instance;
        this.BarRight.sprite = (player_Right.IsTako == true) ? val_7.TakoBar : val_7.IkaBar;
    }
    private System.Collections.IEnumerator LoadCharacterResources(CharacterNameID nameID, CharacterAvatarController avatar, UnityEngine.UI.Image typeIcon)
    {
        DemoCanvas.<LoadCharacterResources>d__50 val_1 = new DemoCanvas.<LoadCharacterResources>d__50();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .nameID = nameID;
            .avatar = avatar;
        }
        else
        {
                mem[32] = this;
            mem[40] = nameID;
            mem[48] = avatar;
        }
        
        .typeIcon = typeIcon;
        return (System.Collections.IEnumerator)val_1;
    }
    public DemoCanvas()
    {
    
    }

}
