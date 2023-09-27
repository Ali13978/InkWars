using UnityEngine;

namespace Twitter
{
    [Serializable]
    public class StreamEvent
    {
        // Fields
        public string event_name;
        public string created_at;
        public Twitter.TweetUser target;
        public Twitter.TweetUser source;
        public string target_object;
        
        // Methods
        public StreamEvent()
        {
        
        }
    
    }

}
