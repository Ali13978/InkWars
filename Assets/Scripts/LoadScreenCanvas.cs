using UnityEngine;
public class LoadScreenCanvas : MonoBehaviour
{
    // Fields
    private UnityEngine.CanvasGroup logoGroup;
    private UnityEngine.UI.Image inkwarsBG;
    private UnityEngine.UI.Image inkwarsChar;
    private UnityEngine.UI.Image inkwarsLogo;
    
    // Properties
    public static bool showBasicTutorial { get; set; }
    
    // Methods
    public static bool get_showBasicTutorial()
    {
        return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  "showBasicTutorial", defaultValue:  1)) == 1) ? 1 : 0;
    }
    public static void set_showBasicTutorial(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  "showBasicTutorial", value:  value);
    }
    private void Start()
    {
        DG.Tweening.IDOTweenInit val_1 = DG.Tweening.DOTween.Init(recycleAllByDefault:  new System.Nullable<System.Boolean>() {HasValue = false}, useSafeMode:  new System.Nullable<System.Boolean>() {HasValue = false}, logBehaviour:  new System.Nullable<DG.Tweening.LogBehaviour>() {HasValue = false});
        if(LoadScreenCanvas.showBasicTutorial != false)
        {
                LoadingScreenController.CreateAndInit();
            TutorialDataManager.LoadBasicTutorial(nextScene:  "Menu_Title_Screen", showLoadingScreen:  false, selectionHand:  true, preload:  false);
            LoadScreenCanvas.showBasicTutorial = false;
            return;
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu_Title_Screen");
    }
    public LoadScreenCanvas()
    {
    
    }

}
