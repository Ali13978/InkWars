using UnityEngine;
public class MVCTutorialManager : MonoBehaviour
{
    // Fields
    public static MVCTutorialManager Instance;
    public UnityEngine.GameObject DemoText;
    public UnityEngine.GameObject NowYouTry;
    public Fading FadeEffect;
    public MVCTutorialStage[] BasicTutorial;
    
    // Methods
    private void Awake()
    {
        MVCTutorialManager.Instance = this;
    }
    private void Start()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.DoTutorial(tutorial:  this.BasicTutorial));
    }
    private System.Collections.IEnumerator DoTutorial(MVCTutorialStage[] tutorial)
    {
        MVCTutorialManager.<DoTutorial>d__7 val_1 = new MVCTutorialManager.<DoTutorial>d__7();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .tutorial = tutorial;
        return (System.Collections.IEnumerator)val_1;
    }
    public void ClickedNowYouTry()
    {
        MVCTutorialPart.CurrentTutorialPart.isFinished = true;
        this.NowYouTry.SetActive(value:  false);
    }
    public MVCTutorialManager()
    {
    
    }

}
