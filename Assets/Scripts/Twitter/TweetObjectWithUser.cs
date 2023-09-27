using UnityEngine;

namespace Twitter
{
    [Serializable]
    public class TweetObjectWithUser : TweetObject
    {
        // Fields
        public Twitter.TweetUser user;
        
        // Methods
        public TweetObjectWithUser()
        {
            val_1 = new System.Object();
        }
    
    }

}
