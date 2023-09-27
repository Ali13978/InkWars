using UnityEngine;
public class NetworkLobby_EndGameReset : MonoBehaviour
{
    // Fields
    public static bool firstTimeLoaded;
    private static string NextScene;
    
    // Methods
    public static void SwitchTo(string nextScene)
    {
        null = null;
        NetworkLobby_EndGameReset.NextScene = nextScene;
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "NetworkReset", minimumDelayInSeconds:  0f, autoHideLoadingScreen:  false);
    }
    private System.Collections.IEnumerator Start()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new NetworkLobby_EndGameReset.<Start>d__3();
    }
    public static void ForceShutdown()
    {
        UnityEngine.GameObject val_1 = UnityEngine.GameObject.Find(name:  "NetworkFunctions");
        if(val_1 != 0)
        {
                val_1.SetActive(value:  false);
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  val_1);
        NetworkManager_Custom.stringRPCMessageId.StopHost();
        NetworkManager_Custom.stringRPCMessageId.StopClient();
        NetworkManager_Custom.stringRPCMessageId.StopServer();
        UnityEngine.Networking.NetworkManager.Shutdown();
        UnityEngine.Object.DestroyImmediate(obj:  NetworkManager_Custom.stringRPCMessageId);
        NetworkManager_Custom.stringRPCMessageId = 0;
        NetworkManager_Custom.stringRPCMessageId.__il2cppRuntimeField_1 = 0;
        NetworkDelayOverlay.StopWaiting();
        UnityEngine.MonoBehaviour.print(message:  "SHUT DOWN NETWORK");
    }
    public NetworkLobby_EndGameReset()
    {
    
    }
    private static NetworkLobby_EndGameReset()
    {
    
    }

}
