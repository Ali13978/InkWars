using UnityEngine;

namespace Twitter
{
    public class Oauth
    {
        // Fields
        private static string <consumerKey>k__BackingField;
        private static string <consumerSecret>k__BackingField;
        private static string <accessToken>k__BackingField;
        private static string <accessTokenSecret>k__BackingField;
        
        // Properties
        public static string consumerKey { get; set; }
        public static string consumerSecret { get; set; }
        public static string accessToken { get; set; }
        public static string accessTokenSecret { get; set; }
        
        // Methods
        public static string get_consumerKey()
        {
            return (string)Twitter.Oauth.<consumerKey>k__BackingField;
        }
        public static void set_consumerKey(string value)
        {
            Twitter.Oauth.<consumerKey>k__BackingField = value;
        }
        public static string get_consumerSecret()
        {
            return (string)Twitter.Oauth.<consumerSecret>k__BackingField;
        }
        public static void set_consumerSecret(string value)
        {
            Twitter.Oauth.<consumerSecret>k__BackingField = value;
        }
        public static string get_accessToken()
        {
            return (string)Twitter.Oauth.<accessToken>k__BackingField;
        }
        public static void set_accessToken(string value)
        {
            Twitter.Oauth.<accessToken>k__BackingField = value;
        }
        public static string get_accessTokenSecret()
        {
            return (string)Twitter.Oauth.<accessTokenSecret>k__BackingField;
        }
        public static void set_accessTokenSecret(string value)
        {
            Twitter.Oauth.<accessTokenSecret>k__BackingField = value;
        }
        public static string GenerateHeaderWithAccessToken(System.Collections.Generic.SortedDictionary<string, string> parameters, string requestMethod, string requestURL)
        {
            System.Text.StringBuilder val_2 = new System.Text.StringBuilder();
            SortedDictionary.Enumerator<TKey, TValue> val_3 = parameters.GetEnumerator();
            label_4:
            if(((-1209795008) & 1) == 0)
            {
                    return (string)"OAuth realm=\"Twitter API\","("OAuth realm=\"Twitter API\",") + val_2 + System.String.Format(format:  "oauth_signature=\"{0}\"", arg0:  Twitter.Helper.UrlEncode(value:  Twitter.Oauth.GenerateSignatureWithAccessToken(parameters:  parameters = parameters, requestMethod:  requestMethod, requestURL:  requestURL)))(System.String.Format(format:  "oauth_signature=\"{0}\"", arg0:  Twitter.Helper.UrlEncode(value:  Twitter.Oauth.GenerateSignatureWithAccessToken(parameters:  parameters = parameters, requestMethod:  requestMethod, requestURL:  requestURL))));
            }
            
            System.Text.StringBuilder val_8 = val_2.Append(value:  System.String.Format(format:  "{0}=\"{1}\",", arg0:  Twitter.Helper.UrlEncode(value:  0.InitialType), arg1:  Twitter.Helper.UrlEncode(value:  0)));
            goto label_4;
        }
        private static string GenerateSignatureWithAccessToken(System.Collections.Generic.SortedDictionary<string, string> parameters, string requestMethod, string requestURL)
        {
            string val_5;
            var val_27;
            Twitter.Oauth.AddDefaultOauthParams(parameters:  parameters, consumerKey:  Twitter.Oauth.<consumerKey>k__BackingField);
            parameters.Add(key:  "oauth_token", value:  Twitter.Oauth.<accessToken>k__BackingField);
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            SortedDictionary.Enumerator<TKey, TValue> val_2 = parameters.GetEnumerator();
            label_7:
            if(((-1209506896) & 1) == 0)
            {
                goto label_5;
            }
            
            System.Text.StringBuilder val_10 = val_1.Append(value:  Twitter.Helper.UrlEncode(value:  val_5.InitialType)(Twitter.Helper.UrlEncode(value:  val_5.InitialType)) + "="("=") + Twitter.Helper.UrlEncode(value:  val_5)(Twitter.Helper.UrlEncode(value:  val_5)) + "&"("&"));
            goto label_7;
            label_5:
            if(val_1 != null)
            {
                goto label_8;
            }
            
            goto label_18;
            label_8:
            val_27 = val_1.Length;
            goto label_19;
            label_18:
            val_27 = val_1.Length;
            label_19:
            val_1.Length = val_27 - 1;
            string val_18 = Twitter.Helper.UrlEncode(value:  requestMethod)(Twitter.Helper.UrlEncode(value:  requestMethod)) + "&"("&") + Twitter.Helper.UrlEncode(value:  requestURL)(Twitter.Helper.UrlEncode(value:  requestURL))(Twitter.Helper.UrlEncode(value:  requestMethod)(Twitter.Helper.UrlEncode(value:  requestMethod)) + "&"("&") + Twitter.Helper.UrlEncode(value:  requestURL)(Twitter.Helper.UrlEncode(value:  requestURL))) + "&"("&") + Twitter.Helper.UrlEncode(value:  val_1)(Twitter.Helper.UrlEncode(value:  val_1));
            string val_21 = Twitter.Helper.UrlEncode(value:  Twitter.Oauth.<consumerSecret>k__BackingField)(Twitter.Helper.UrlEncode(value:  Twitter.Oauth.<consumerSecret>k__BackingField)) + "&"("&") + Twitter.Helper.UrlEncode(value:  Twitter.Oauth.<accessTokenSecret>k__BackingField)(Twitter.Helper.UrlEncode(value:  Twitter.Oauth.<accessTokenSecret>k__BackingField));
            return (string)System.Convert.ToBase64String(inArray:  new System.Security.Cryptography.HMACSHA1(key:  System.Text.Encoding.ASCII).ComputeHash(buffer:  System.Text.Encoding.ASCII));
        }
        private static void AddDefaultOauthParams(System.Collections.Generic.SortedDictionary<string, string> parameters, string consumerKey)
        {
            parameters.Add(key:  "oauth_consumer_key", value:  consumerKey);
            parameters.Add(key:  "oauth_signature_method", value:  "HMAC-SHA1");
            parameters.Add(key:  "oauth_timestamp", value:  Twitter.Oauth.GenerateTimeStamp());
            string val_2 = Twitter.Oauth.GenerateNonce();
            if(parameters != null)
            {
                    parameters.Add(key:  "oauth_nonce", value:  val_2);
            }
            else
            {
                    parameters.Add(key:  "oauth_nonce", value:  val_2);
            }
            
            parameters.Add(key:  "oauth_version", value:  "1.0");
        }
        private static string GenerateTimeStamp()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime());
            return (string)System.Convert.ToInt64(value:  val_2._ticks.TotalSeconds).ToString();
        }
        private static string GenerateNonce()
        {
            return (string)new System.Random().ToString(format:  "X");
        }
        public Oauth()
        {
        
        }
    
    }

}
