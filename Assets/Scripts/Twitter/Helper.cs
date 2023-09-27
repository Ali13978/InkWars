using UnityEngine;

namespace Twitter
{
    public class Helper
    {
        // Methods
        public static System.Collections.Generic.SortedDictionary<string, string> ConvertToSortedDictionary(System.Collections.Generic.Dictionary<string, string> APIParams)
        {
            System.Collections.Generic.SortedDictionary<System.String, System.String> val_1 = new System.Collections.Generic.SortedDictionary<System.String, System.String>();
            Dictionary.Enumerator<TKey, TValue> val_2 = APIParams.GetEnumerator();
            label_4:
            if(((-1216330520) & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Playables.PlayableHandle val_3 = 0.GetHandle();
            val_1.Add(key:  val_3.m_Handle.ToInt64(), value:  val_3.m_Handle);
            goto label_4;
            label_2:
            0.Add(driver:  public System.Void Dictionary.Enumerator<System.String, System.String>::Dispose(), rectTransform:  null, drivenProperties:  null);
            return val_1;
        }
        public static string GenerateRequestparams(System.Collections.Generic.SortedDictionary<string, string> parameters)
        {
            int val_12;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            SortedDictionary.Enumerator<TKey, TValue> val_2 = parameters.GetEnumerator();
            label_4:
            if(((-1216177568) & 1) == 0)
            {
                goto label_2;
            }
            
            System.Text.StringBuilder val_7 = val_1.Append(value:  Twitter.Helper.UrlEncode(value:  0.InitialType)(Twitter.Helper.UrlEncode(value:  0.InitialType)) + "="("=") + Twitter.Helper.UrlEncode(value:  0)(Twitter.Helper.UrlEncode(value:  0)) + "&"("&"));
            goto label_4;
            label_2:
            if(val_1 == null)
            {
                
            }
            else
            {
                    val_12 = val_1.Length - 1;
                val_1.Length = val_12;
                return (string)val_1;
            }
            
            val_12 = val_1.Length - 1;
            val_1.Length = val_12;
            return (string)val_1;
        }
        public static string UrlEncode(string value)
        {
            var val_11;
            System.Text.RegularExpressions.MatchEvaluator val_13;
            if((System.String.IsNullOrEmpty(value:  value)) != false)
            {
                    return (string)static_value_032D1378 + 184;
            }
            
            val_11 = null;
            val_11 = null;
            val_13 = Helper.<>c.<>9__2_0;
            if(val_13 == null)
            {
                    System.Text.RegularExpressions.MatchEvaluator val_3 = null;
                val_13 = val_3;
                val_3 = new System.Text.RegularExpressions.MatchEvaluator(object:  Helper.<>c.__il2cppRuntimeField_static_fields, method:  System.String Helper.<>c::<UrlEncode>b__2_0(System.Text.RegularExpressions.Match c));
                Helper.<>c.<>9__2_0 = val_13;
            }
            
            string val_10 = System.Text.RegularExpressions.Regex.Replace(input:  System.Uri.EscapeDataString(stringToEscape:  value), pattern:  "(%[0-9a-f][0-9a-f])", evaluator:  val_3).Replace(oldValue:  "(", newValue:  "%28").Replace(oldValue:  ")", newValue:  "%29").Replace(oldValue:  "$", newValue:  "%24").Replace(oldValue:  "!", newValue:  "%21").Replace(oldValue:  "*", newValue:  "%2A").Replace(oldValue:  "\'", newValue:  "%27");
            if(val_10 != null)
            {
                    return val_10.Replace(oldValue:  "%7E", newValue:  "~");
            }
            
            return val_10.Replace(oldValue:  "%7E", newValue:  "~");
        }
        public Helper()
        {
        
        }
    
    }

}
