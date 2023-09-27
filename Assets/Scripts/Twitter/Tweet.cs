using UnityEngine;

namespace Twitter
{
    [Serializable]
    public class Tweet : TweetObjectWithUser
    {
        // Fields
        public Twitter.TweetObjectWithUser retweeted_status;
        
        // Methods
        public Tweet()
        {
            val_1 = new System.Object();
        }
    
    }

}
