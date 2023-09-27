using UnityEngine;

namespace Twitter
{
    [Serializable]
    public class DirectMessage
    {
        // Fields
        public string created_at;
        public Twitter.Entities entities;
        public long id;
        public string id_str;
        public Twitter.TweetUser recipient;
        public long recipient_id;
        public string recipient_screen_name;
        public Twitter.TweetUser sender;
        public long sender_id;
        public string sender_screen_name;
        public string text;
        
        // Methods
        public DirectMessage()
        {
        
        }
    
    }

}
