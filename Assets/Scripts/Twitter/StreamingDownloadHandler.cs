using UnityEngine;

namespace Twitter
{
    public class StreamingDownloadHandler : DownloadHandlerScript
    {
        // Fields
        private Twitter.TwitterStreamCallback callback;
        private Twitter.StreamMessageType messageType;
        
        // Methods
        public StreamingDownloadHandler(Twitter.TwitterStreamCallback callback)
        {
            this.callback = callback;
        }
        protected override bool ReceiveData(byte[] data, int dataLength)
        {
            Twitter.StreamMessageType val_4;
            var val_5;
            val_4 = this;
            if((data != null) && (data.Length > 0))
            {
                    string val_2 = System.Text.Encoding.ASCII.Replace(oldValue:  "\"event\":", newValue:  "\"event_name\":");
                this.messageType = 11;
                this.CheckMessageType(data:  val_2);
                val_4 = this.messageType;
                this.callback.Invoke(response:  JsonHelper.ArrayToObject(arrayString:  val_2), messageType:  val_4);
                val_5 = 1;
                return (bool)val_5;
            }
            
            UnityEngine.Debug.Log(message:  "LoggingDownloadHandler :: ReceiveData - received a null/empty buffer");
            val_5 = 0;
            return (bool)val_5;
        }
        private void CheckMessageType(string data)
        {
            Twitter.StreamMessageType val_13;
            Twitter.Tweet val_1 = UnityEngine.JsonUtility.FromJson<Twitter.Tweet>(json:  data);
            if(((public static Twitter.Tweet UnityEngine.JsonUtility::FromJson<Twitter.Tweet>(string json)) != 0) && ((public static Twitter.Tweet UnityEngine.JsonUtility::FromJson<Twitter.Tweet>(string json)) != 0))
            {
                    val_13 = 0;
            }
            else
            {
                    Twitter.StreamEvent val_2 = UnityEngine.JsonUtility.FromJson<Twitter.StreamEvent>(json:  data);
                if(val_2.event_name != null)
            {
                    val_13 = 10;
            }
            else
            {
                    Twitter.FriendsList val_3 = UnityEngine.JsonUtility.FromJson<Twitter.FriendsList>(json:  data);
                if(val_3.friends != null)
            {
                    val_13 = 7;
            }
            else
            {
                    Twitter.DirectMessage val_4 = UnityEngine.JsonUtility.FromJson<Twitter.DirectMessage>(json:  data);
                if(val_4.recipient_screen_name != null)
            {
                    val_13 = 9;
            }
            else
            {
                    Twitter.StatusDeletionNotice val_5 = UnityEngine.JsonUtility.FromJson<Twitter.StatusDeletionNotice>(json:  data);
                if(val_5.delete != null)
            {
                    val_13 = 1;
            }
            else
            {
                    Twitter.LocationDeletionNotice val_6 = UnityEngine.JsonUtility.FromJson<Twitter.LocationDeletionNotice>(json:  data);
                if(val_6.scrub_geo != null)
            {
                    val_13 = 2;
            }
            else
            {
                    Twitter.LimitNotice val_7 = UnityEngine.JsonUtility.FromJson<Twitter.LimitNotice>(json:  data);
                if(val_7.limit != null)
            {
                    val_13 = 3;
            }
            else
            {
                    Twitter.WithheldContentNotice val_8 = UnityEngine.JsonUtility.FromJson<Twitter.WithheldContentNotice>(json:  data);
                if(val_8.status_withheld == null)
            {
                    if(val_8.user_withheld == null)
            {
                goto label_25;
            }
            
            }
            
                val_13 = 4;
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            label_55:
            this.messageType = val_13;
            return;
            label_25:
            Twitter.DisconnectMessage val_9 = UnityEngine.JsonUtility.FromJson<Twitter.DisconnectMessage>(json:  data);
            if(val_9.disconnect == null)
            {
                goto label_27;
            }
            
            goto label_55;
            label_27:
            Twitter.StallWarning val_10 = UnityEngine.JsonUtility.FromJson<Twitter.StallWarning>(json:  data);
            var val_11 = (val_10.warning == 0) ? 11 : 6;
            goto label_55;
        }
    
    }

}
