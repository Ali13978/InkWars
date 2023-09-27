using UnityEngine;

namespace Twitter
{
    [Serializable]
    public class List
    {
        // Fields
        public string slug;
        public string name;
        public string created_at;
        public string uri;
        public int subscriber_count;
        public long id;
        public string id_str;
        public int member_count;
        public string mode;
        public string full_name;
        public string description;
        public Twitter.TweetUser user;
        public bool following;
        
        // Methods
        public List()
        {
        
        }
    
    }

}
