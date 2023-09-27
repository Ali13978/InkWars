using UnityEngine;
public class StoryPanelScript : MonoBehaviour
{
    // Fields
    public static string keyForStory;
    public static bool Tako_P1;
    public static bool Tako_P2;
    public static bool Tako_PB;
    public static bool Tako_End;
    public static bool Ika_P1;
    public static bool Ika_P2;
    public static bool Ika_PB;
    public static bool Ika_End;
    public UnityEngine.GameObject ikaStart;
    public UnityEngine.GameObject ikaP1;
    public UnityEngine.GameObject ikaP2;
    public UnityEngine.GameObject ikaPB;
    public UnityEngine.GameObject ikaEnding;
    public UnityEngine.GameObject takoStart;
    public UnityEngine.GameObject takoP1;
    public UnityEngine.GameObject takoP2;
    public UnityEngine.GameObject takoPB;
    public UnityEngine.GameObject takoEnding;
    public UnityEngine.AudioClip storyFlowSound;
    public UnityEngine.AudioClip gameClearedSound;
    public UnityEngine.GameObject creditsCanvas;
    public UnityEngine.GameObject canvasStoryPanel;
    
    // Methods
    private void Start()
    {
        var val_5;
        var val_6;
        var val_7;
        UnityEngine.AudioClip val_8;
        val_5 = null;
        val_5 = null;
        if((System.String.op_Equality(a:  StoryPanelScript.keyForStory, b:  "Ika_End")) == true)
        {
            goto label_3;
        }
        
        val_6 = null;
        val_6 = null;
        if((System.String.op_Equality(a:  StoryPanelScript.keyForStory, b:  "Tako_End")) == false)
        {
            goto label_6;
        }
        
        label_3:
        val_7 = 1152921505104982016;
        val_8 = this.gameClearedSound;
        goto label_7;
        label_6:
        val_7 = 1152921505104982016;
        val_8 = this.storyFlowSound;
        label_7:
        GameAudio.SwitchMusic(clip:  val_8, customLoopStartTime:  0f, customLoopEndTime:  0f, forcePlay:  false);
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.activatePanel());
    }
    private System.Collections.IEnumerator activatePanel()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new StoryPanelScript.<activatePanel>d__24();
    }
    private System.Collections.IEnumerator AnimatePanels(UnityEngine.GameObject tempPanel)
    {
        .<>1__state = 0;
        .tempPanel = tempPanel;
        return (System.Collections.IEnumerator)new StoryPanelScript.<AnimatePanels>d__25();
    }
    public void nextButton()
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        string val_7;
        val_3 = 1152921505125056512;
        val_4 = null;
        val_4 = null;
        if((System.String.op_Equality(a:  StoryPanelScript.keyForStory, b:  "Ika_End")) == true)
        {
            goto label_3;
        }
        
        val_5 = null;
        val_5 = null;
        if((System.String.op_Equality(a:  StoryPanelScript.keyForStory, b:  "Tako_End")) == false)
        {
            goto label_6;
        }
        
        label_3:
        val_3 = 1152921505090711552;
        Credits.nextScene = "";
        val_6 = null;
        val_6 = null;
        Character_GlobalInfo.hackCreditsStartMusic = false;
        Credits.nextScene = "";
        val_7 = "Credits";
        goto label_11;
        label_6:
        val_7 = "Scene_LoadLevels";
        label_11:
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  val_7);
    }
    public StoryPanelScript()
    {
    
    }
    private static StoryPanelScript()
    {
    
    }

}
