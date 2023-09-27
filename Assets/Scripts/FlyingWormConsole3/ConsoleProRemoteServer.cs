using UnityEngine;

namespace FlyingWormConsole3
{
    public class ConsoleProRemoteServer : MonoBehaviour
    {
        // Fields
        public bool useNATPunch;
        public int port;
        
        // Methods
        public void Awake()
        {
            UnityEngine.Debug.Log(message:  "Console Pro Remote Server is disabled in release mode, please use a Development build or define DEBUG to use it");
        }
        public ConsoleProRemoteServer()
        {
            this.port = 51000;
        }
    
    }

}
