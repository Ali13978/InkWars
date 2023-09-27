using UnityEngine;

namespace Twitter
{
    [Serializable]
    public class Video_Info
    {
        // Fields
        public long id;
        public string id_str;
        public string media_url;
        public string type;
        public Twitter.Variant[] variants;
        
        // Methods
        public Video_Info()
        {
        
        }
    
    }

}
