using UnityEngine;

namespace Twitter
{
    [Serializable]
    public class Entities
    {
        // Fields
        public Twitter.Media[] media;
        public Twitter.UserMention[] user_mentions;
        public Twitter.HashTag[] hashtags;
        
        // Methods
        public Entities()
        {
        
        }
    
    }

}
