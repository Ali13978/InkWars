using UnityEngine;

namespace Twitter
{
    [Serializable]
    public class Disconnect
    {
        // Fields
        public int code;
        public string stream_name;
        public string reason;
        
        // Methods
        public Disconnect()
        {
        
        }
    
    }

}
