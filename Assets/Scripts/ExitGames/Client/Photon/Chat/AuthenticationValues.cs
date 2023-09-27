using UnityEngine;

namespace ExitGames.Client.Photon.Chat
{
    public class AuthenticationValues
    {
        // Fields
        private ExitGames.Client.Photon.Chat.CustomAuthenticationType authType;
        private string <AuthGetParameters>k__BackingField;
        private object <AuthPostData>k__BackingField;
        private string <Token>k__BackingField;
        private string <UserId>k__BackingField;
        
        // Properties
        public ExitGames.Client.Photon.Chat.CustomAuthenticationType AuthType { get; set; }
        public string AuthGetParameters { get; set; }
        public object AuthPostData { get; set; }
        public string Token { get; set; }
        public string UserId { get; set; }
        
        // Methods
        public ExitGames.Client.Photon.Chat.CustomAuthenticationType get_AuthType()
        {
            return (ExitGames.Client.Photon.Chat.CustomAuthenticationType)this.authType;
        }
        public void set_AuthType(ExitGames.Client.Photon.Chat.CustomAuthenticationType value)
        {
            this.authType = value;
        }
        public string get_AuthGetParameters()
        {
            return (string)this.<AuthGetParameters>k__BackingField;
        }
        public void set_AuthGetParameters(string value)
        {
            this.<AuthGetParameters>k__BackingField = value;
        }
        public object get_AuthPostData()
        {
            return (object)this.<AuthPostData>k__BackingField;
        }
        private void set_AuthPostData(object value)
        {
            this.<AuthPostData>k__BackingField = value;
        }
        public string get_Token()
        {
            return (string)this.<Token>k__BackingField;
        }
        public void set_Token(string value)
        {
            this.<Token>k__BackingField = value;
        }
        public string get_UserId()
        {
            return (string)this.<UserId>k__BackingField;
        }
        public void set_UserId(string value)
        {
            this.<UserId>k__BackingField = value;
        }
        public AuthenticationValues()
        {
            this.authType = 255;
        }
        public AuthenticationValues(string userId)
        {
            this.authType = 255;
            this.<UserId>k__BackingField = userId;
        }
        public virtual void SetAuthPostData(string stringData)
        {
            this.<AuthPostData>k__BackingField = ((System.String.IsNullOrEmpty(value:  stringData)) != true) ? 0 : stringData;
        }
        public virtual void SetAuthPostData(byte[] byteData)
        {
            this.<AuthPostData>k__BackingField = byteData;
        }
        public virtual void AddAuthParameter(string key, string value)
        {
            object[] val_3 = new object[4];
            if(val_3 == null)
            {
                goto label_1;
            }
            
            if((this.<AuthGetParameters>k__BackingField) != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if((this.<AuthGetParameters>k__BackingField) == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_3[0] = this.<AuthGetParameters>k__BackingField;
            val_3[1] = ((System.String.IsNullOrEmpty(value:  this.<AuthGetParameters>k__BackingField)) != true) ? "" : "&";
            val_3[2] = System.Uri.EscapeDataString(stringToEscape:  key);
            val_3[3] = System.Uri.EscapeDataString(stringToEscape:  value);
            this.<AuthGetParameters>k__BackingField = System.String.Format(format:  "{0}{1}{2}={3}", args:  val_3);
        }
        public override string ToString()
        {
            return (string)System.String.Format(format:  "AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}", arg0:  this.<UserId>k__BackingField, arg1:  this.<AuthGetParameters>k__BackingField, arg2:  ((this.<Token>k__BackingField) != null) ? 1 : 0);
        }
    
    }

}
