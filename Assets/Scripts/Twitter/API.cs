using UnityEngine;

namespace Twitter
{
    public class API
    {
        // Fields
        private static readonly string RequestTokenURL;
        private static readonly string AuthorizationURL;
        private static readonly string AccessTokenURL;
        private const string PostTweetURL = "https://api.twitter.com/1.1/friends/ids.json";
        private static readonly string[] OAuthParametersToIncludeInHeader;
        private static readonly string[] SecretParameters;
        
        // Methods
        public static System.Collections.IEnumerator GetRequestToken(string consumerKey, string consumerSecret, Twitter.RequestTokenCallback callback)
        {
            API.<GetRequestToken>d__3 val_1 = new API.<GetRequestToken>d__3();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .consumerKey = consumerKey;
                .consumerSecret = consumerSecret;
            }
            else
            {
                    mem[32] = consumerKey;
                mem[40] = consumerSecret;
            }
            
            .callback = callback;
            return (System.Collections.IEnumerator)val_1;
        }
        public static void OpenAuthorizationPage(string requestToken)
        {
            null = null;
            UnityEngine.Application.OpenURL(url:  System.String.Format(format:  Twitter.API.AuthorizationURL, arg0:  requestToken));
        }
        public static System.Collections.IEnumerator GetAccessToken(string consumerKey, string consumerSecret, string requestToken, string pin, Twitter.AccessTokenCallback callback)
        {
            API.<GetAccessToken>d__5 val_1 = new API.<GetAccessToken>d__5();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .consumerKey = consumerKey;
                .consumerSecret = consumerSecret;
                .requestToken = requestToken;
                .pin = pin;
            }
            else
            {
                    mem[32] = consumerKey;
                mem[40] = consumerSecret;
                mem[48] = requestToken;
                mem[56] = pin;
            }
            
            .callback = callback;
            return (System.Collections.IEnumerator)val_1;
        }
        private static UnityEngine.WWW WWWRequestToken(string consumerKey, string consumerSecret)
        {
            UnityEngine.WWWForm val_1 = new UnityEngine.WWWForm();
            val_1.AddField(fieldName:  "oauth_callback", value:  "oob");
            System.Collections.Generic.Dictionary<System.String, System.String> val_2 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            Twitter.API.AddDefaultOAuthParams(parameters:  val_2, consumerKey:  consumerKey, consumerSecret:  consumerSecret);
            val_2.Add(key:  "oauth_callback", value:  "oob");
            System.Collections.Generic.Dictionary<System.String, System.String> val_3 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            val_3.Add(key:  "Authorization", value:  Twitter.API.GetFinalOAuthHeader(HTTPRequestType:  "POST", URL:  Twitter.API.PostTweetURL, parameters:  val_2));
            return (UnityEngine.WWW)new UnityEngine.WWW(url:  Twitter.API.PostTweetURL, postData:  val_1.data, headers:  val_3);
        }
        private static UnityEngine.WWW WWWAccessToken(string consumerKey, string consumerSecret, string requestToken, string pin)
        {
            byte[] val_1 = new byte[1];
            val_1[0] = 0;
            System.Collections.Generic.Dictionary<System.String, System.String> val_2 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            System.Collections.Generic.Dictionary<System.String, System.String> val_3 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            Twitter.API.AddDefaultOAuthParams(parameters:  val_3, consumerKey:  consumerKey, consumerSecret:  consumerSecret);
            if(val_3 != null)
            {
                    val_3.Add(key:  "oauth_token", value:  requestToken);
            }
            else
            {
                    val_3.Add(key:  "oauth_token", value:  requestToken);
            }
            
            val_3.Add(key:  "oauth_verifier", value:  pin);
            val_2.Add(key:  "Authorization", value:  Twitter.API.GetFinalOAuthHeader(HTTPRequestType:  "POST", URL:  Twitter.API.AccessTokenURL, parameters:  val_3));
            return (UnityEngine.WWW)new UnityEngine.WWW(url:  Twitter.API.AccessTokenURL, postData:  val_1, headers:  val_2);
        }
        private static string GetHeaderWithAccessToken(string httpRequestType, string apiURL, string consumerKey, string consumerSecret, Twitter.AccessTokenResponse response, System.Collections.Generic.Dictionary<string, string> parameters)
        {
            Twitter.API.AddDefaultOAuthParams(parameters:  parameters, consumerKey:  consumerKey, consumerSecret:  consumerSecret);
            parameters.Add(key:  "oauth_token", value:  response.<Token>k__BackingField);
            parameters.Add(key:  "oauth_token_secret", value:  response.<TokenSecret>k__BackingField);
            return Twitter.API.GetFinalOAuthHeader(HTTPRequestType:  httpRequestType, URL:  apiURL, parameters:  parameters);
        }
        public static System.Collections.IEnumerator PostTweet(string text, string consumerKey, string consumerSecret, Twitter.AccessTokenResponse response, Twitter.PostTweetCallback callback)
        {
            API.<PostTweet>d__10 val_1 = new API.<PostTweet>d__10();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .text = text;
                .consumerKey = consumerKey;
                .consumerSecret = consumerSecret;
                .response = response;
            }
            else
            {
                    mem[32] = text;
                mem[48] = consumerKey;
                mem[56] = consumerSecret;
                mem[64] = response;
            }
            
            .callback = callback;
            return (System.Collections.IEnumerator)val_1;
        }
        private static void AddDefaultOAuthParams(System.Collections.Generic.Dictionary<string, string> parameters, string consumerKey, string consumerSecret)
        {
            parameters.Add(key:  "oauth_version", value:  "1.0");
            parameters.Add(key:  "oauth_nonce", value:  Twitter.API.GenerateNonce());
            string val_2 = Twitter.API.GenerateTimeStamp();
            if(parameters != null)
            {
                    parameters.Add(key:  "oauth_timestamp", value:  val_2);
            }
            else
            {
                    parameters.Add(key:  "oauth_timestamp", value:  val_2);
            }
            
            parameters.Add(key:  "oauth_signature_method", value:  "HMAC-SHA1");
            if(parameters != null)
            {
                    parameters.Add(key:  "oauth_consumer_key", value:  consumerKey);
            }
            else
            {
                    parameters.Add(key:  "oauth_consumer_key", value:  consumerKey);
            }
            
            parameters.Add(key:  "oauth_consumer_secret", value:  consumerSecret);
        }
        private static string GetFinalOAuthHeader(string HTTPRequestType, string URL, System.Collections.Generic.Dictionary<string, string> parameters)
        {
            var val_22;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.Boolean> val_24;
            var val_25;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_27;
            var val_29;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_31;
            var val_35;
            string val_37;
            parameters.Add(key:  "oauth_signature", value:  Twitter.API.GenerateSignature(httpMethod:  HTTPRequestType, url:  URL, parameters:  parameters));
            System.Text.StringBuilder val_2 = new System.Text.StringBuilder();
            System.Text.StringBuilder val_3 = val_2.AppendFormat(format:  "OAuth realm=\"{0}\"", arg0:  "Twitter API");
            val_22 = null;
            val_22 = null;
            val_24 = API.<>c.<>9__14_0;
            if(val_24 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.Boolean> val_4 = null;
                val_24 = val_4;
                val_4 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.Boolean>(object:  API.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean API.<>c::<GetFinalOAuthHeader>b__14_0(System.Collections.Generic.KeyValuePair<string, string> p));
                API.<>c.<>9__14_0 = val_24;
            }
            
            val_25 = null;
            val_25 = null;
            val_27 = API.<>c.<>9__14_1;
            if(val_27 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_6 = null;
                val_27 = val_6;
                val_6 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(object:  API.<>c.__il2cppRuntimeField_static_fields, method:  System.String API.<>c::<GetFinalOAuthHeader>b__14_1(System.Collections.Generic.KeyValuePair<string, string> p));
                API.<>c.<>9__14_1 = val_27;
            }
            
            val_29 = null;
            val_29 = null;
            val_31 = API.<>c.<>9__14_2;
            if(val_31 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_8 = null;
                val_31 = val_8;
                val_8 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(object:  API.<>c.__il2cppRuntimeField_static_fields, method:  System.String API.<>c::<GetFinalOAuthHeader>b__14_2(System.Collections.Generic.KeyValuePair<string, string> p));
                API.<>c.<>9__14_2 = val_31;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            System.Collections.Generic.IEnumerator<T> val_11 = System.Linq.Enumerable.ThenBy<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(source:  System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, System.String>>(source:  parameters, predicate:  val_4), keySelector:  val_6), keySelector:  val_8).GetEnumerator();
            label_39:
            var val_26 = 0;
            val_26 = val_26 + 1;
            if(val_11.MoveNext() == false)
            {
                goto label_30;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            T val_15 = val_11.Current;
            System.Text.StringBuilder val_19 = val_2.AppendFormat(format:  ",{0}=\"{1}\"", arg0:  Twitter.API.UrlEncode(value:  val_15.InitialType), arg1:  Twitter.API.UrlEncode(value:  val_15));
            goto label_39;
            label_30:
            val_35 = 0;
            if(val_11 == null)
            {
                
            }
            else
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_11.Dispose();
            }
            
            string val_22 = Twitter.API.UrlEncode(value:  parameters.Item["oauth_signature"]);
            if(val_2 != null)
            {
                    val_37 = ",oauth_signature=\"{0}\"";
                System.Text.StringBuilder val_23 = val_2.AppendFormat(format:  val_37, arg0:  val_22);
                return (string)val_2;
            }
            
            val_37 = ",oauth_signature=\"{0}\"";
            System.Text.StringBuilder val_24 = val_2.AppendFormat(format:  val_37, arg0:  val_22);
            return (string)val_2;
        }
        private static string GenerateSignature(string httpMethod, string url, System.Collections.Generic.Dictionary<string, string> parameters)
        {
            var val_20;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.Boolean> val_22;
            object val_23;
            val_20 = null;
            val_20 = null;
            val_22 = API.<>c.<>9__15_0;
            if(val_22 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.Boolean> val_1 = null;
                val_22 = val_1;
                val_1 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.Boolean>(object:  API.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean API.<>c::<GenerateSignature>b__15_0(System.Collections.Generic.KeyValuePair<string, string> p));
                API.<>c.<>9__15_0 = val_22;
            }
            
            string val_8 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0}&{1}&{2}", arg0:  httpMethod, arg1:  Twitter.API.UrlEncode(value:  Twitter.API.NormalizeUrl(url:  new System.Uri(uriString:  url))), arg2:  Twitter.API.UrlEncode(parameters:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, System.String>>(source:  parameters, predicate:  val_1)));
            if((parameters.ContainsKey(key:  "oauth_token_secret")) != false)
            {
                    val_23 = Twitter.API.UrlEncode(value:  parameters.Item["oauth_token_secret"]);
            }
            else
            {
                    val_23 = mem[static_value_032D1378 + 184];
                val_23 = static_value_032D1378 + 184;
            }
            
            string val_15 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0}&{1}", arg0:  Twitter.API.UrlEncode(value:  parameters.Item["oauth_consumer_secret"]), arg1:  val_23);
            return System.Convert.ToBase64String(inArray:  new System.Security.Cryptography.HMACSHA1(key:  System.Text.Encoding.ASCII).ComputeHash(buffer:  System.Text.Encoding.ASCII));
        }
        private static string GenerateTimeStamp()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime());
            return (string)System.Convert.ToInt64(value:  val_2._ticks.TotalSeconds, provider:  System.Globalization.CultureInfo.CurrentCulture).ToString(provider:  System.Globalization.CultureInfo.CurrentCulture);
        }
        private static string GenerateNonce()
        {
            return (string)new System.Random().ToString(format:  "X", provider:  System.Globalization.CultureInfo.InvariantCulture);
        }
        private static string NormalizeUrl(System.Uri url)
        {
            object val_16;
            object val_17;
            if(url != null)
            {
                    val_16 = url.Scheme;
            }
            else
            {
                    val_16 = 0.Scheme;
            }
            
            val_17 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0}://{1}", arg0:  val_16, arg1:  url.Host);
            if((System.String.op_Equality(a:  url.Scheme, b:  "http")) != false)
            {
                    if(url.Port == 80)
            {
                    return (string)val_17 + url.AbsolutePath;
            }
            
            }
            
            if((System.String.op_Equality(a:  url.Scheme, b:  "https")) != false)
            {
                    if(url.Port == 443)
            {
                    return (string)val_17 + url.AbsolutePath;
            }
            
            }
            
            val_17 = val_17 + ":"(":") + url.Port;
            return (string)val_17 + url.AbsolutePath;
        }
        private static string UrlEncode(string value)
        {
            var val_11;
            System.Text.RegularExpressions.MatchEvaluator val_13;
            if((System.String.IsNullOrEmpty(value:  value)) != false)
            {
                    return (string)static_value_032D1378 + 184;
            }
            
            val_11 = null;
            val_11 = null;
            val_13 = API.<>c.<>9__19_0;
            if(val_13 == null)
            {
                    System.Text.RegularExpressions.MatchEvaluator val_3 = null;
                val_13 = val_3;
                val_3 = new System.Text.RegularExpressions.MatchEvaluator(object:  API.<>c.__il2cppRuntimeField_static_fields, method:  System.String API.<>c::<UrlEncode>b__19_0(System.Text.RegularExpressions.Match c));
                API.<>c.<>9__19_0 = val_13;
            }
            
            string val_10 = System.Text.RegularExpressions.Regex.Replace(input:  System.Uri.EscapeDataString(stringToEscape:  value), pattern:  "(%[0-9a-f][0-9a-f])", evaluator:  val_3).Replace(oldValue:  "(", newValue:  "%28").Replace(oldValue:  ")", newValue:  "%29").Replace(oldValue:  "$", newValue:  "%24").Replace(oldValue:  "!", newValue:  "%21").Replace(oldValue:  "*", newValue:  "%2A").Replace(oldValue:  "\'", newValue:  "%27");
            if(val_10 != null)
            {
                    return val_10.Replace(oldValue:  "%7E", newValue:  "~");
            }
            
            return val_10.Replace(oldValue:  "%7E", newValue:  "~");
        }
        private static string UrlEncode(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> parameters)
        {
            var val_19;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_21;
            var val_22;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_24;
            var val_28;
            var val_30;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            val_19 = null;
            val_19 = null;
            val_21 = API.<>c.<>9__20_0;
            if(val_21 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_2 = null;
                val_21 = val_2;
                val_2 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(object:  API.<>c.__il2cppRuntimeField_static_fields, method:  System.String API.<>c::<UrlEncode>b__20_0(System.Collections.Generic.KeyValuePair<string, string> p));
                API.<>c.<>9__20_0 = val_21;
            }
            
            val_22 = null;
            val_22 = null;
            val_24 = API.<>c.<>9__20_1;
            if(val_24 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_4 = null;
                val_24 = val_4;
                val_4 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(object:  API.<>c.__il2cppRuntimeField_static_fields, method:  System.String API.<>c::<UrlEncode>b__20_1(System.Collections.Generic.KeyValuePair<string, string> p));
                API.<>c.<>9__20_1 = val_24;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            System.Collections.Generic.IEnumerator<T> val_7 = System.Linq.Enumerable.ThenBy<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(source:  System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(source:  parameters, keySelector:  val_2), keySelector:  val_4).GetEnumerator();
            label_35:
            var val_23 = 0;
            val_23 = val_23 + 1;
            if(val_7.MoveNext() == false)
            {
                goto label_21;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            T val_11 = val_7.Current;
            if(val_1.Length >= 1)
            {
                    System.Text.StringBuilder val_13 = val_1.Append(value:  "&");
            }
            
            System.Text.StringBuilder val_19 = val_1.Append(value:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0}={1}", arg0:  Twitter.API.UrlEncode(value:  val_11.InitialType), arg1:  Twitter.API.UrlEncode(value:  val_11)));
            goto label_35;
            label_21:
            val_28 = 0;
            if(val_7 == null)
            {
                
            }
            else
            {
                    var val_25 = 0;
                val_25 = val_25 + 1;
                val_30 = public System.Void System.IDisposable::Dispose();
                val_7.Dispose();
            }
            
            if( == false)
            {
                    return (string)Twitter.API.UrlEncode(value:  val_1);
            }
            
            val_30 = 0;
            return (string)Twitter.API.UrlEncode(value:  val_1);
        }
        public API()
        {
        
        }
        private static API()
        {
            Twitter.API.PostTweetURL = "https://api.twitter.com/oauth/request_token";
            Twitter.API.AuthorizationURL = "https://api.twitter.com/oauth/authorize?oauth_token={0}";
            Twitter.API.AccessTokenURL = "https://api.twitter.com/oauth/access_token";
            string[] val_1 = new string[7];
            val_1[0] = "oauth_version";
            val_1[1] = "oauth_nonce";
            val_1[2] = "oauth_timestamp";
            val_1[3] = "oauth_signature_method";
            val_1[4] = "oauth_consumer_key";
            val_1[5] = "oauth_token";
            val_1[6] = "oauth_verifier";
            Twitter.API.OAuthParametersToIncludeInHeader = val_1;
            string[] val_2 = new string[3];
            val_2[0] = "oauth_consumer_secret";
            val_2[1] = "oauth_token_secret";
            val_2[2] = "oauth_signature";
            Twitter.API.SecretParameters = val_2;
        }
    
    }

}
