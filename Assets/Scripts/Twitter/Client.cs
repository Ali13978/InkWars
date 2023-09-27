using UnityEngine;

namespace Twitter
{
    public class Client
    {
        // Methods
        public static System.Collections.IEnumerator Get(string APIPath, System.Collections.Generic.Dictionary<string, string> APIParams, Twitter.TwitterCallback callback)
        {
            Client.<Get>d__0 val_1 = new Client.<Get>d__0();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .APIPath = APIPath;
                .APIParams = APIParams;
            }
            else
            {
                    mem[32] = APIPath;
                mem[40] = APIParams;
            }
            
            .callback = callback;
            return (System.Collections.IEnumerator)val_1;
        }
        public static System.Collections.IEnumerator Post(string APIPath, System.Collections.Generic.Dictionary<string, string> APIParams, Twitter.TwitterCallback callback)
        {
            Client.<Post>d__1 val_1 = new Client.<Post>d__1();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .APIPath = APIPath;
                .APIParams = APIParams;
            }
            else
            {
                    mem[32] = APIPath;
                mem[40] = APIParams;
            }
            
            .callback = callback;
            return (System.Collections.IEnumerator)val_1;
        }
        private static System.Collections.IEnumerator SendRequest(UnityEngine.Networking.UnityWebRequest request, System.Collections.Generic.SortedDictionary<string, string> parameters, string method, string requestURL, Twitter.TwitterCallback callback)
        {
            Client.<SendRequest>d__2 val_1 = new Client.<SendRequest>d__2();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .request = request;
                .parameters = parameters;
                .method = method;
                .requestURL = requestURL;
            }
            else
            {
                    mem[32] = request;
                mem[40] = parameters;
                mem[48] = method;
                mem[56] = requestURL;
            }
            
            .callback = callback;
            return (System.Collections.IEnumerator)val_1;
        }
        public Client()
        {
        
        }
    
    }

}
