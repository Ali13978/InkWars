using UnityEngine;
public class ActivateOnStart : MonoBehaviour
{
    // Fields
    public static ActivateOnStart Instance;
    public bool sceneHolderReady;
    public UnityEngine.GameObject CanvasChild;
    public UnityEngine.GameObject SceneHolder;
    public UnityEngine.GameObject blackImage;
    public UnityEngine.Camera mainCam;
    
    // Methods
    private void Awake()
    {
        ActivateOnStart val_5;
        var val_6;
        var val_7;
        val_5 = this;
        ActivateOnStart.Instance = val_5;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_1.m_Handle.name, b:  "DemoScene")) != false)
        {
                val_6 = null;
            val_6 = null;
            DataStructs.UserDataDictionary.GameSave.IsDemoPlayed = true;
            val_7 = null;
            val_7 = null;
            Character_GlobalInfo.gameMode = 3;
        }
        
        if(BattleVSGates.instance != 0)
        {
                return;
        }
        
        val_5 = this.blackImage;
        val_5.SetActive(value:  true);
    }
    private void Start()
    {
        ActivateOnStart.SetOrthographicSize(mainCam:  this.mainCam);
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "activating");
    }
    public static void SetOrthographicSize(UnityEngine.Camera mainCam)
    {
        float val_8;
        float val_9;
        val_8 = (float)UnityEngine.Screen.width;
        val_9 = (float)UnityEngine.Screen.height;
        if(val_9 > val_8)
        {
                val_9 = (float)UnityEngine.Screen.width;
            val_8 = (float)UnityEngine.Screen.height;
        }
        
        mainCam.orthographicSize = UnityEngine.Mathf.Lerp(a:  5f, b:  6.7f, t:  UnityEngine.Mathf.InverseLerp(a:  1.777778f, b:  1.333333f, value:  val_8 / val_9));
    }
    private System.Collections.IEnumerator activating()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new ActivateOnStart.<activating>d__9();
    }
    public ActivateOnStart()
    {
    
    }

}
