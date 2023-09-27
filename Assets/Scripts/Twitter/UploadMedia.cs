using UnityEngine;

namespace Twitter
{
    [Serializable]
    public class UploadMedia
    {
        // Fields
        public long media_id;
        public string media_id_string;
        public int size;
        public int expires_after_secs;
        public Twitter.UploadMediaImage image;
        
        // Methods
        public UploadMedia()
        {
        
        }
    
    }

}
