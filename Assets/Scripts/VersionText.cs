using UnityEngine;
public class VersionText : MonoBehaviour
{
    // Fields
    public const string BUILD_VERSION_PATH = "/Resources/b.txt";
    private static string buildVersionStr;
    public string format;
    
    // Methods
    public static void LoadBuildVersion()
    {
        VersionText.buildVersionStr = UnityEngine.Resources.Load<UnityEngine.TextAsset>(path:  "b").text;
    }
    public static string GetVersionString(string format = "{0}.{1}")
    {
        var val_6;
        var val_7;
        val_6 = null;
        val_6 = null;
        if((System.String.IsNullOrEmpty(value:  VersionText.buildVersionStr)) != false)
        {
                VersionText.LoadBuildVersion();
        }
        
        val_7 = null;
        val_7 = null;
        return (string)System.String.Format(format:  ((System.String.IsNullOrEmpty(value:  format)) != true) ? "{0}.{1}" : format, arg0:  UnityEngine.Application.version, arg1:  VersionText.buildVersionStr);
    }
    public static string GetVersionStringLocalizationSup(string format = "{0}.{1}")
    {
        var val_7;
        var val_8;
        val_7 = null;
        val_7 = null;
        if((System.String.IsNullOrEmpty(value:  VersionText.buildVersionStr)) != false)
        {
                VersionText.LoadBuildVersion();
        }
        
        object[] val_4 = new object[2];
        val_4[0] = UnityEngine.Application.version;
        val_8 = null;
        val_8 = null;
        val_4[1] = VersionText.buildVersionStr;
        return (string)LanguageManager.GetTextFormat(key:  ((System.String.IsNullOrEmpty(value:  format)) != true) ? "{0}.{1}" : format, list:  val_4);
    }
    public static bool SameOrHigherVersion(string v1, string v2)
    {
        return (bool)(((VersionText.CompareVersion(v1:  v1, v2:  v2)) | 2) == 3) ? 1 : 0;
    }
    public static bool SameVersion(string v1, string v2)
    {
        return (bool)((VersionText.CompareVersion(v1:  v1, v2:  v2)) == 3) ? 1 : 0;
    }
    public static bool HigherVersion(string v1, string v2)
    {
        return (bool)((VersionText.CompareVersion(v1:  v1, v2:  v2)) == 3) ? 1 : 0;
    }
    public static VersionText.VersionCompareResult CompareVersion(string v1, string v2)
    {
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        System.Collections.Generic.List<System.Int32> val_1 = VersionText.GetVersionNumber(v:  v1);
        System.Collections.Generic.List<System.Int32> val_2 = VersionText.GetVersionNumber(v:  v2);
        if(val_1.Count == 0)
        {
                val_19 = val_2;
            if(val_19.Count == 0)
        {
                return (VersionCompareResult)(val_1.Count >= val_2.Count) ? (2 + 1) : 2;
        }
        
        }
        
        if(val_1.Count >= val_2.Count)
        {
            goto label_9;
        }
        
        val_20 = val_1;
        if(val_1 != null)
        {
            goto label_19;
        }
        
        label_20:
        val_20 = 0;
        label_19:
        val_21 = 0;
        goto label_11;
        label_15:
        if(val_1.Item[0] != val_2.Item[0])
        {
            goto label_13;
        }
        
        val_21 = 1;
        label_11:
        if(val_21 < val_20.Count)
        {
            goto label_15;
        }
        
        val_18 = val_1.Count;
        if(val_18 != val_2.Count)
        {
                return (VersionCompareResult)(val_1.Count >= val_2.Count) ? (2 + 1) : 2;
        }
        
        val_19 = 1;
        return (VersionCompareResult)(val_1.Count >= val_2.Count) ? (2 + 1) : 2;
        label_9:
        if(val_2 != null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_13:
        var val_14 = (val_1.Item[0] > val_2.Item[0]) ? (2 + 1) : 2;
        return (VersionCompareResult)(val_1.Count >= val_2.Count) ? (2 + 1) : 2;
    }
    public static System.Collections.Generic.List<int> GetVersionNumber(string v)
    {
        var val_11;
        var val_13;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        if((System.String.IsNullOrEmpty(value:  v)) == true)
        {
                return val_1;
        }
        
        char[] val_3 = new char[1];
        val_3[0] = '.';
        val_11 = 0;
        goto label_11;
        label_18:
        string val_11 = v.Split(separator:  val_3)[0];
        if((System.String.IsNullOrEmpty(value:  val_11)) != false)
        {
                val_1.Add(item:  0);
        }
        else
        {
                val_1.Add(item:  System.Int32.Parse(s:  val_11));
        }
        
        val_11 = 1;
        label_11:
        if(val_11 < val_4.Length)
        {
            goto label_18;
        }
        
        goto label_19;
        label_23:
        if(val_1 != null)
        {
                val_13 = val_1.Count;
        }
        else
        {
                val_13 = val_1.Count;
        }
        
        val_1.Insert(index:  val_13 - 1, item:  0);
        label_19:
        if(val_1.Count < 4)
        {
            goto label_23;
        }
        
        return val_1;
    }
    private void Awake()
    {
        this.OnLanguageChanged();
    }
    private void OnEnable()
    {
        LanguageManager.add_OnLanguageChanged(value:  new LanguageManager.LanguageMgrHandler(object:  this, method:  System.Void VersionText::OnLanguageChanged()));
    }
    private void OnDisable()
    {
        LanguageManager.remove_OnLanguageChanged(value:  new LanguageManager.LanguageMgrHandler(object:  this, method:  System.Void VersionText::OnLanguageChanged()));
    }
    private void OnLanguageChanged()
    {
        var val_8;
        object[] val_1 = new object[2];
        string val_2 = UnityEngine.Application.version;
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val_2 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_2 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val_2;
        val_8 = null;
        val_8 = null;
        val_1[1] = VersionText.buildVersionStr;
        bool val_5 = UnityEngine.Object.op_Inequality(x:  0, y:  this.GetComponent<UnityEngine.UI.Text>());
        TMPro.TextMeshProUGUI val_6 = this.GetComponent<TMPro.TextMeshProUGUI>();
        if(0 == val_6)
        {
                return;
        }
        
        val_6.text = LanguageManager.GetTextFormat(key:  "LK.Option.VersionNo", list:  val_1);
    }
    public VersionText()
    {
        this.format = "v{0} ({1})";
    }
    private static VersionText()
    {
    
    }

}
