using UnityEngine;
public class LanPlaySceneRematch : MonoBehaviour
{
    // Fields
    private static LanPlaySceneRematch _instance;
    public UnityEngine.GameObject RematchPanel;
    public UnityEngine.GameObject[] Rematch_OtherPlayer;
    public LanPlaySceneRematchStateObjects[] States;
    private LanPlaySceneRematch.rematch_state _currentState;
    
    // Properties
    public static LanPlaySceneRematch instance { get; }
    public LanPlaySceneRematch.rematch_state CurrentState { get; set; }
    
    // Methods
    public static LanPlaySceneRematch get_instance()
    {
        if(LanPlaySceneRematch._instance != 0)
        {
                return (LanPlaySceneRematch)LanPlaySceneRematch._instance;
        }
        
        LanPlaySceneRematch._instance = UnityEngine.Object.FindObjectOfType<LanPlaySceneRematch>();
        return (LanPlaySceneRematch)LanPlaySceneRematch._instance;
    }
    private void Awake()
    {
        this.CurrentState = 0;
        UnityEngine.UI.Text val_1 = this.Rematch_OtherPlayer[0].GetComponentInChildren<UnityEngine.UI.Text>();
        string val_2 = PlayerPrefsManager.Player2Name;
        string val_4 = PlayerPrefsManager.Player2Name;
        if((this.Rematch_OtherPlayer[1].GetComponentInChildren<UnityEngine.UI.Text>()) == null)
        {
            
        }
    
    }
    public LanPlaySceneRematch.rematch_state get_CurrentState()
    {
        return (rematch_state)this._currentState;
    }
    public void set_CurrentState(LanPlaySceneRematch.rematch_state value)
    {
        var val_14;
        var val_15;
        var val_18;
        LanPlaySceneRematchStateObjects[] val_20;
        this.RematchPanel.SetActive(value:  (value != 0) ? 1 : 0);
        System.Collections.IEnumerator val_3 = this.RematchPanel.transform.GetEnumerator();
        label_22:
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_9;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_14 = val_3.Current;
        if(val_14 != null)
        {
            
        }
        
        if(val_14 != null)
        {
                val_14 = 0;
        }
        
        val_14.gameObject.SetActive(value:  false);
        goto label_22;
        label_9:
        val_15 = 0;
        val_18 = 1152921504621170688;
        if(val_3 != null)
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_3.Dispose();
        }
        
        val_20 = this.States;
        var val_18 = 0;
        label_42:
        if(val_18 >= this.States.Length)
        {
            goto label_39;
        }
        
        LanPlaySceneRematchStateObjects val_17 = val_20[0];
        val_18 = val_18 + 1;
        if(this.States[0x0][0].ObjectsForThisStage != value)
        {
            goto label_42;
        }
        
        val_18 = 0;
        goto label_43;
        label_47:
        val_20 = this.States[0x0][0].Objects[0];
        val_20.SetActive(value:  true);
        val_18 = 1;
        label_43:
        if(val_18 < this.States[0x0][0].Objects.Length)
        {
            goto label_47;
        }
        
        label_39:
        this._currentState = value;
    }
    public void button_accept()
    {
        var val_2;
        var val_3;
        if((this._currentState - 2) < 2)
        {
                val_2 = null;
            val_2 = null;
            LanPlaySceneManager.instance.GotoCharacterSelect();
            return;
        }
        
        if(this._currentState != 1)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        LanPlaySceneManager.instance.GotoRematch();
    }
    public void button_deny()
    {
        var val_1;
        if(this._currentState == 1)
        {
                this.CurrentState = 2;
            return;
        }
        
        val_1 = null;
        val_1 = null;
        0.GotoLobby();
    }
    public void button_lobby()
    {
        string val_6;
        var val_7;
        var val_8;
        GameAudio.PlayButtonSound();
        GameAudio.sound.UnPause();
        UnityEngine.Time.timeScale = 1f;
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_2.m_Handle.name, b:  "PlaySceneVs")) == false)
        {
            goto label_6;
        }
        
        if(NetworkManager_Custom.IsNetwork == false)
        {
            goto label_7;
        }
        
        val_6 = "NetworkReset";
        goto label_17;
        label_6:
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "Scene_LoadLevels", minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
        return;
        label_7:
        val_7 = null;
        val_7 = null;
        if(Character_GlobalInfo.isOfflineMode != false)
        {
                val_6 = "OfflineTitleScreen";
        }
        else
        {
                val_8 = null;
            val_8 = null;
            mainTitle.ShowModeSelectImmediately = false;
            val_6 = "Menu_Title_Screen";
        }
        
        label_17:
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  val_6);
    }
    public void button_rematch()
    {
        playSceneCanvas val_8;
        var val_9;
        GameAudio.PlayButtonSound();
        GameAudio.sound.UnPause();
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_2.m_Handle.name, b:  "PlaySceneVs")) != false)
        {
                if(MVC_MusselTracker.GetMusselCount() <= 1)
        {
                if(NetworkManager_Custom.IsNetwork == false)
        {
            goto label_10;
        }
        
        }
        
            UnityEngine.Time.timeScale = 1f;
            val_8 = playSceneCanvas.Instance;
            val_8.Rematch();
            return;
        }
        
        UnityEngine.Time.timeScale = 1f;
        val_8 = 1152921505064992768;
        if(Character_GlobalInfo.stage_CurrentLevel == 12)
        {
                val_9 = null;
            val_9 = null;
            if(Character_GlobalInfo.gameMode == 2)
        {
                Character_GlobalInfo.gameMode = 1;
        }
        
        }
        
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "PlayScene", minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
        return;
        label_10:
        GameAudio.PlayButtonSound();
        playSceneCanvas.Instance.HideAdButtons();
        SetActive(value:  true);
    }
    public void button_characterSelect()
    {
        playSceneCanvas.Instance.CharacterSelect();
    }
    public void button_buyShells()
    {
        instructionMenuHandler val_1 = instructionMenuHandler.instance;
        val_1.outOfShells.SetActive(value:  true);
    }
    public void GotAskForRematch()
    {
        this.CurrentState = 1;
    }
    public void GotAskForCharacterScreen()
    {
        this.CurrentState = 3;
    }
    public void OtherPlayerIsToppingUp()
    {
    
    }
    public void OtherPlayerDoneToppingUp()
    {
    
    }
    public LanPlaySceneRematch()
    {
    
    }

}
