using UnityEngine;

namespace Twitter
{
    [Serializable]
    public class StatusWithheld
    {
        // Fields
        public long id;
        public long user_id;
        public string[] withheld_in_countries;
        
        // Methods
        public StatusWithheld()
        {
        
        }
    
    }

}
