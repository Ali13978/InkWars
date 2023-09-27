using UnityEngine;

namespace AppStoresSupport
{
    [Serializable]
    public class AppStoreSetting
    {
        // Fields
        public string AppID;
        public string AppKey;
        public bool IsTestMode;
        
        // Methods
        public AppStoreSetting()
        {
            this.AppID = "";
            this.AppKey = "";
        }
    
    }

}
