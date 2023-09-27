using UnityEngine;

namespace Twitter
{
    public class AccessTokenResponse
    {
        // Fields
        private string <Token>k__BackingField;
        private string <TokenSecret>k__BackingField;
        private string <UserId>k__BackingField;
        private string <ScreenName>k__BackingField;
        
        // Properties
        public string Token { get; set; }
        public string TokenSecret { get; set; }
        public string UserId { get; set; }
        public string ScreenName { get; set; }
        
        // Methods
        public string get_Token()
        {
            return (string)this.<Token>k__BackingField;
        }
        public void set_Token(string value)
        {
            this.<Token>k__BackingField = value;
        }
        public string get_TokenSecret()
        {
            return (string)this.<TokenSecret>k__BackingField;
        }
        public void set_TokenSecret(string value)
        {
            this.<TokenSecret>k__BackingField = value;
        }
        public string get_UserId()
        {
            return (string)this.<UserId>k__BackingField;
        }
        public void set_UserId(string value)
        {
            this.<UserId>k__BackingField = value;
        }
        public string get_ScreenName()
        {
            return (string)this.<ScreenName>k__BackingField;
        }
        public void set_ScreenName(string value)
        {
            this.<ScreenName>k__BackingField = value;
        }
        public AccessTokenResponse()
        {
        
        }
    
    }

}
