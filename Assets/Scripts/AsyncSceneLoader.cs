using UnityEngine;
public sealed class AsyncSceneLoader : MonoBehaviour
{
    // Fields
    private static AsyncSceneLoader _inst;
    private static UnityEngine.AsyncOperation preloadOperator;
    
    // Properties
    private static AsyncSceneLoader instance { get; }
    
    // Methods
    private static AsyncSceneLoader get_instance()
    {
        AsyncSceneLoader val_4 = AsyncSceneLoader._inst;
        if(0 != val_4)
        {
                return (AsyncSceneLoader)AsyncSceneLoader._inst;
        }
        
        UnityEngine.GameObject val_2 = null;
        val_4 = val_2;
        val_2 = new UnityEngine.GameObject(name:  "AsyncSceneLoader");
        AsyncSceneLoader._inst = val_2.AddComponent<AsyncSceneLoader>();
        UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
        return (AsyncSceneLoader)AsyncSceneLoader._inst;
    }
    public static void PreloadScene(string sceneName)
    {
        if(AsyncSceneLoader.preloadOperator != null)
        {
                UnityEngine.Debug.LogError(message:  "Preload " + sceneName + " fail: Another Scene is already in process."(" fail: Another Scene is already in process."));
            return;
        }
        
        AsyncSceneLoader.preloadOperator = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  sceneName);
        AsyncSceneLoader.preloadOperator.allowSceneActivation = false;
    }
    public static void ActivePreloadScene(bool showLoadingScene = True)
    {
        var val_3;
        if(AsyncSceneLoader.preloadOperator == null)
        {
                return;
        }
        
        if(showLoadingScene == false)
        {
            goto label_2;
        }
        
        LoadingScreenController val_1 = LoadingScreenController.instance;
        val_3 = null;
        val_3 = null;
        if((AsyncSceneLoader.<>c.<>9__5_0) == null)
        {
            goto label_7;
        }
        
        label_12:
        val_1.FlyIn(duration:  0.5f, onDone:  AsyncSceneLoader.<>c.<>9__5_0);
        return;
        label_2:
        AsyncSceneLoader.preloadOperator.allowSceneActivation = true;
        AsyncSceneLoader.preloadOperator = 0;
        return;
        label_7:
        AsyncSceneLoader.<>c.<>9__5_0 = new System.Action(object:  AsyncSceneLoader.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AsyncSceneLoader.<>c::<ActivePreloadScene>b__5_0());
        if(val_1 != null)
        {
            goto label_12;
        }
        
        goto label_12;
    }
    private System.Collections.IEnumerator WaitForPreloadSceneDone(System.Action onDone)
    {
        .onDone = onDone;
        return (System.Collections.IEnumerator)new AsyncSceneLoader.<WaitForPreloadSceneDone>d__6(<>1__state:  0);
    }
    private System.Collections.IEnumerator LoadScene(string sceneName, float minimumDelayInSeconds = 0, bool showLoadingScreen = False, bool autoHideLoadingScreen = True)
    {
        AsyncSceneLoader.<LoadScene>d__7 val_1 = new AsyncSceneLoader.<LoadScene>d__7(<>1__state:  0);
        if(val_1 != null)
        {
                .sceneName = sceneName;
            .minimumDelayInSeconds = minimumDelayInSeconds;
            .showLoadingScreen = showLoadingScreen;
        }
        else
        {
                mem[32] = sceneName;
            .minimumDelayInSeconds = minimumDelayInSeconds;
            mem[40] = showLoadingScreen;
        }
        
        .autoHideLoadingScreen = autoHideLoadingScreen;
        return (System.Collections.IEnumerator)val_1;
    }
    public static void Load(string sceneName, float minimumDelayInSeconds = 0, bool showLoadingScreen = False, bool autoHideLoadingScreen = True)
    {
        UnityEngine.Coroutine val_6 = AsyncSceneLoader.instance.StartCoroutine(routine:  AsyncSceneLoader.instance.LoadScene(sceneName:  sceneName, minimumDelayInSeconds:  minimumDelayInSeconds, showLoadingScreen:  showLoadingScreen, autoHideLoadingScreen:  autoHideLoadingScreen));
    }
    public static void LoadWithLoadingScreen(string sceneName, float minimumDelayInSeconds = 0, bool autoHideLoadingScreen = True)
    {
        UnityEngine.Coroutine val_5 = AsyncSceneLoader.instance.StartCoroutine(routine:  AsyncSceneLoader.instance.LoadScene(sceneName:  sceneName, minimumDelayInSeconds:  minimumDelayInSeconds, showLoadingScreen:  true, autoHideLoadingScreen:  autoHideLoadingScreen));
    }
    public AsyncSceneLoader()
    {
    
    }

}
