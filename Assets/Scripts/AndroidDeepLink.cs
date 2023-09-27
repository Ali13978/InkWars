using UnityEngine;
public class AndroidDeepLink : MonoBehaviour
{
    // Methods
    public static string GetURL()
    {
        UnityEngine.AndroidJavaClass val_8;
        var val_9;
        var val_11;
        val_8 = new UnityEngine.AndroidJavaClass();
        val_8 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        val_9 = new UnityEngine.AndroidJavaClass().GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity").Call<UnityEngine.AndroidJavaObject>(methodName:  "getIntent", args:  System.Array.Empty<System.Object>()).Call<System.String>(methodName:  "getDataString", args:  System.Array.Empty<System.Object>());
        if(val_8 != null)
        {
                var val_8 = 0;
            val_8 = val_8 + 1;
            val_11 = public System.Void System.IDisposable::Dispose();
            new UnityEngine.AndroidJavaClass().Dispose();
        }
        
        if(0 != 0)
        {
                val_11 = 0;
        }
        
        if(0 != 1)
        {
                if(79 == 79)
        {
                return (string)val_9;
        }
        
        }
        
        val_8 = 0;
        UnityEngine.Debug.LogWarning(message:  val_8);
        val_9 = 0;
        return (string)val_9;
    }
    public static string GetValue(string url, string key)
    {
        System.Char[] val_12;
        string val_13;
        object val_14;
        var val_15;
        string val_16;
        val_13 = key;
        if((System.String.IsNullOrWhiteSpace(value:  url)) != true)
        {
                if((System.String.IsNullOrWhiteSpace(value:  val_13)) == false)
        {
            goto label_2;
        }
        
        }
        
        val_14 = "Url or parameter key cannot be empty string.";
        goto label_5;
        label_2:
        char[] val_3 = new char[1];
        val_3[0] = 63;
        val_15 = url.Split(separator:  val_3);
        if(val_4.Length <= 1)
        {
                char[] val_5 = new char[1];
            val_5[0] = '#';
            val_15 = url.Split(separator:  val_5);
        }
        
        char[] val_7 = new char[1];
        val_12 = val_7;
        val_12[0] = '&';
        var val_15 = 0;
        label_27:
        if(val_15 >= val_8.Length)
        {
            goto label_20;
        }
        
        char[] val_9 = new char[1];
        val_9[0] = '=';
        val_12 = val_15[1].Split(separator:  val_7)[0].Split(separator:  val_9);
        val_15 = val_15 + 1;
        if((System.String.op_Equality(a:  val_13, b:  val_12[0])) == false)
        {
            goto label_27;
        }
        
        val_16 = val_12[1];
        return (string)val_16;
        label_5:
        UnityEngine.Debug.LogError(message:  null);
        label_20:
        val_16 = 0;
        return (string)val_16;
    }
    public static string GetValueInString(string name)
    {
        return AndroidDeepLink.GetValue(url:  AndroidDeepLink.GetURL(), key:  name);
    }
    public static int GetValueInInt(string name)
    {
        int val_3 = 0;
        bool val_4 = System.Int32.TryParse(s:  AndroidDeepLink.GetValue(url:  AndroidDeepLink.GetURL(), key:  name), result: out  val_3);
        return val_3;
    }
    public static float GetValueInFloat(string name)
    {
        bool val_4 = System.Single.TryParse(s:  AndroidDeepLink.GetValue(url:  AndroidDeepLink.GetURL(), key:  name), result: out  float val_3 = 1.023364E-38f);
        return 0f;
    }
    public AndroidDeepLink()
    {
    
    }

}
