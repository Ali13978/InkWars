using UnityEngine;

namespace Twitter
{
    [Serializable]
    public class Media
    {
        // Fields
        public int id;
        public int id_str;
        public string media_url;
        public string media_url_https;
        public string type;
        public Twitter.Video_Info video_info;
        
        // Methods
        public Media()
        {
        
        }
    
    }

}
