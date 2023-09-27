using UnityEngine;

namespace Twitter
{
    public class Stream
    {
        // Fields
        private string REQUEST_URL;
        private UnityEngine.Networking.UnityWebRequest request;
        
        // Methods
        public Stream(Twitter.StreamType type)
        {
            string val_3;
            string[] val_1 = new string[4];
            val_1[0] = "statuses/filter";
            val_1[1] = "statuses/sample";
            val_1[2] = "user";
            val_1[3] = "site";
            if(type < 2)
            {
                goto label_14;
            }
            
            if(type == 2)
            {
                goto label_15;
            }
            
            if(type != 3)
            {
                    return;
            }
            
            val_3 = "https://sitestream.twitter.com/1.1/site.json";
            goto label_17;
            label_14:
            string val_2 = "https://stream.twitter.com/1.1/"("https://stream.twitter.com/1.1/") + val_1[(long)type] + ".json";
            goto label_19;
            label_15:
            val_3 = "https://userstream.twitter.com/1.1/user.json";
            label_17:
            label_19:
            this.REQUEST_URL = val_3;
        }
        public System.Collections.IEnumerator On(System.Collections.Generic.Dictionary<string, string> APIParams, Twitter.TwitterStreamCallback callback)
        {
            Stream.<On>d__3 val_1 = new Stream.<On>d__3();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .APIParams = APIParams;
                .<>4__this = this;
            }
            else
            {
                    mem[40] = this;
                mem[32] = APIParams;
            }
            
            .callback = callback;
            return (System.Collections.IEnumerator)val_1;
        }
        public void Off()
        {
            UnityEngine.Debug.Log(message:  "Connection Aborted");
            this.request.Abort();
        }
    
    }

}
