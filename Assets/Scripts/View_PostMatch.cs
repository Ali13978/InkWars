using UnityEngine;
public class View_PostMatch : MonoBehaviour
{
    // Fields
    private static View_PostMatch _instance;
    public UnityEngine.GameObject WinPanel;
    public UnityEngine.UI.Image WinPanel_Dynamic;
    public UnityEngine.UI.Text WinPanel_Score;
    public UnityEngine.UI.Text WinPanel_YouveCrackedThePuzzle;
    public UnityEngine.UI.Image[] WinPanel_Stars;
    public UnityEngine.GameObject LosePanel;
    public UnityEngine.UI.Image LosePose;
    private CharacterAssetLoader assetLoader;
    
    // Properties
    public static View_PostMatch Instance { get; }
    
    // Methods
    public static View_PostMatch get_Instance()
    {
        View_PostMatch._instance = UnityEngine.Object.FindObjectOfType<View_PostMatch>();
        return (View_PostMatch)View_PostMatch._instance;
    }
    private void Awake()
    {
        this.assetLoader = this.gameObject.AddComponent<CharacterAssetLoader>();
    }
    private void OnEnable()
    {
        this.WinPanel.gameObject.SetActive(value:  false);
        this.LosePanel.gameObject.SetActive(value:  false);
    }
    public System.Collections.IEnumerator WinSequence(int finalScore)
    {
        View_PostMatch.<WinSequence>d__13 val_1 = new View_PostMatch.<WinSequence>d__13();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .finalScore = finalScore;
        return (System.Collections.IEnumerator)val_1;
    }
    public System.Collections.IEnumerator LoseSequence()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new View_PostMatch.<LoseSequence>d__14();
    }
    public void PlayAgain()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  val_1.m_Handle.name, minimumDelayInSeconds:  2f, autoHideLoadingScreen:  true);
    }
    public void Quit()
    {
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "Scene_LoadLevels", minimumDelayInSeconds:  2f, autoHideLoadingScreen:  true);
    }
    public View_PostMatch()
    {
    
    }

}
