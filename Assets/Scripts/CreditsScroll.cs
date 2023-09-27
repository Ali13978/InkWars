using UnityEngine;
public class CreditsScroll : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Scrollbar scrollbarCredit;
    public UnityEngine.GameObject panelText;
    public UnityEngine.GameObject inkwarImage;
    public UnityEngine.AudioClip mainTitleSound;
    public UnityEngine.GameObject nextButton;
    
    // Methods
    private void Start()
    {
        var val_4;
        var val_5;
        if((System.String.op_Inequality(a:  Credits.nextScene, b:  "Menu_Title_Screen")) != false)
        {
                this.nextButton.SetActive(value:  false);
        }
        
        val_4 = null;
        val_4 = null;
        if(Character_GlobalInfo.hackCreditsStartMusic != false)
        {
                GameAudio.SwitchMusic(clip:  this.mainTitleSound, customLoopStartTime:  0f, customLoopEndTime:  0f, forcePlay:  false);
            val_5 = null;
            val_5 = null;
            Character_GlobalInfo.hackCreditsStartMusic = true;
        }
        
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.scrollRect());
    }
    private System.Collections.IEnumerator scrollRect()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new CreditsScroll.<scrollRect>d__6();
    }
    public void arrowButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu_Title_Screen");
    }
    public CreditsScroll()
    {
    
    }

}
