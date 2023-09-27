using UnityEngine;

namespace Twitter
{
    public class RequestTokenResponse
    {
        // Fields
        private string <Token>k__BackingField;
        private string <TokenSecret>k__BackingField;
        
        // Properties
        public string Token { get; set; }
        public string TokenSecret { get; set; }
        
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
        public RequestTokenResponse()
        {
        
        }
    
    }

}
