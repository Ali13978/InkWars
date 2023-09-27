using UnityEngine;
public class MultiplayerConnector : MonoBehaviour
{
    // Fields
    public InkWars.Model.MVC_Multiplayer_Manager_NewLobby m_multiplayerManager;
    private static MultiplayerConnector _instance;
    
    // Properties
    public static MultiplayerConnector Instance { get; }
    
    // Methods
    public static MultiplayerConnector get_Instance()
    {
        return (MultiplayerConnector)MultiplayerConnector._instance;
    }
    private void Awake()
    {
        if(MultiplayerConnector._instance != 0)
        {
                if(MultiplayerConnector._instance != this)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
            return;
        }
        
        }
        
        MultiplayerConnector._instance = this;
    }
    public MultiplayerConnector()
    {
    
    }

}
