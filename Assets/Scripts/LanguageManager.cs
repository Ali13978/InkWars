using UnityEngine;
public class LanguageManager
{
    // Fields
    private static LanguageManager _inst;
    private static LanguageManager.LanguageMgrHandler OnLanguageChanged;
    private static UnityEngine.SystemLanguage _currentLanguage;
    private System.Collections.Generic.Dictionary<string, string> languageMap;
    
    // Properties
    private static LanguageManager inst { get; }
    public static UnityEngine.SystemLanguage currentLanguage { get; set; }
    
    // Methods
    private static LanguageManager get_inst()
    {
        LanguageManager val_3;
        LanguageManager val_4 = LanguageManager._inst;
        if(val_4 != null)
        {
                return val_4;
        }
        
        LanguageManager val_1 = new LanguageManager();
        LanguageManager._inst = val_1;
        val_3 = LanguageManager._inst;
        bool val_2 = val_1.InitLanguage(language:  10);
        val_4 = LanguageManager._inst;
        return val_4;
    }
    public static void add_OnLanguageChanged(LanguageManager.LanguageMgrHandler value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  LanguageManager.OnLanguageChanged, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(LanguageManager.OnLanguageChanged != 1152921505071706120);
    
    }
    public static void remove_OnLanguageChanged(LanguageManager.LanguageMgrHandler value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  LanguageManager.OnLanguageChanged, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(LanguageManager.OnLanguageChanged != 1152921505071706120);
    
    }
    public static UnityEngine.SystemLanguage get_currentLanguage()
    {
        LanguageManager val_1 = LanguageManager.inst;
        return (UnityEngine.SystemLanguage)LanguageManager._currentLanguage;
    }
    private static void set_currentLanguage(UnityEngine.SystemLanguage value)
    {
        LanguageManager._currentLanguage = value;
    }
    public static bool IsNullOrEmpty(string key)
    {
        string val_8;
        if((System.String.IsNullOrWhiteSpace(value:  key)) == true)
        {
            goto label_4;
        }
        
        LanguageManager val_2 = LanguageManager.inst;
        if((val_2.languageMap.ContainsKey(key:  key)) == false)
        {
            goto label_4;
        }
        
        string val_5 = 0;
        LanguageManager val_4 = LanguageManager.inst;
        bool val_6 = val_4.languageMap.TryGetValue(key:  key, value: out  val_5);
        val_8 = val_5;
        bool val_7 = System.String.IsNullOrWhiteSpace(value:  val_8);
        goto label_7;
        label_4:
        val_8 = 1;
        label_7:
        val_8 = val_8 & 1;
        return (bool)val_8;
    }
    public static string GetText(string key)
    {
        var val_6;
        if((System.String.IsNullOrWhiteSpace(value:  key)) != false)
        {
                val_6 = "";
            return (string)key;
        }
        
        string val_3 = 0;
        LanguageManager val_2 = LanguageManager.inst;
        bool val_4 = val_2.languageMap.TryGetValue(key:  key, value: out  val_3);
        if(val_3 != 0)
        {
                if((System.String.op_Equality(a:  "#VALUE!", b:  val_3)) == false)
        {
                return (string)key;
        }
        
        }
        
        return (string)key;
    }
    public static string GetTextFormat(string key, object[] list)
    {
        string val_1 = LanguageManager.GetText(key:  key);
        if((list != null) && (list.Length != 0))
        {
                return (string)System.String.Format(format:  val_1, args:  list).Replace(oldValue:  "<br>", newValue:  "\r\n");
        }
        
        if(val_1 != null)
        {
                return val_1.Replace(oldValue:  "<br>", newValue:  "\r\n");
        }
        
        return val_1.Replace(oldValue:  "<br>", newValue:  "\r\n");
    }
    public static string TryGetTextWithFormat(string key, object[] list)
    {
        string val_4 = key;
        if((System.String.IsNullOrEmpty(value:  val_4 = key)) == true)
        {
                return val_4;
        }
        
        val_4 = LanguageManager.GetText(key:  val_4);
        if((val_4.Contains(value:  "{0}")) == false)
        {
                return val_4;
        }
        
        return System.String.Format(format:  val_4, args:  list);
    }
    public static bool SetLanguage(UnityEngine.SystemLanguage language)
    {
        UnityEngine.SystemLanguage val_1 = LanguageManager.currentLanguage;
        bool val_3 = LanguageManager.inst.InitLanguage(language:  language);
        if(val_3 == false)
        {
                return val_3;
        }
        
        if(LanguageManager.OnLanguageChanged != null)
        {
                LanguageManager.OnLanguageChanged.Invoke();
        }
        
        if(val_1 == LanguageManager.currentLanguage)
        {
                return val_3;
        }
        
        LanguageInfo val_5 = LanguageInfo.Get(language:  val_1);
        if(val_5 == null)
        {
                return val_3;
        }
        
        val_5.UnloadAssets();
        return val_3;
    }
    public static void InvokeLanguageChage()
    {
        if(LanguageManager.OnLanguageChanged == null)
        {
                return;
        }
        
        LanguageManager.OnLanguageChanged.Invoke();
    }
    public static TMPro.TMP_FontAsset GetBoldFont(UnityEngine.SystemLanguage language)
    {
        if(0 == (LanguageInfo.Get(language:  language)))
        {
                language.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
            UnityEngine.Debug.LogError(message:  "Cannot get bold font for language: "("Cannot get bold font for language: ") + language.ToString());
            return 0;
        }
        
        LanguageInfo val_5 = LanguageInfo.Get(language:  language);
        if(val_5 != null)
        {
                return val_5.font;
        }
        
        return val_5.font;
    }
    private static LanguageTextData GetTextData(UnityEngine.SystemLanguage language)
    {
        if(0 == (LanguageInfo.Get(language:  language)))
        {
                return 0;
        }
        
        LanguageInfo val_3 = LanguageInfo.Get(language:  language);
        if(val_3 != null)
        {
                return val_3.textData;
        }
        
        return val_3.textData;
    }
    public static string GetResourceFolder(UnityEngine.SystemLanguage language)
    {
        language.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        return (string)System.String.Format(format:  "Languages/{0}/", arg0:  language.ToString());
    }
    private bool InitLanguage(UnityEngine.SystemLanguage language)
    {
        var val_4;
        LanguageTextData val_1 = LanguageTextData.Load(language:  language);
        if(0 == val_1)
        {
                val_4 = 0;
            return (bool)val_4;
        }
        
        this.languageMap = val_1.ToDictionary();
        val_4 = 1;
        LanguageManager._currentLanguage = language;
        return (bool)val_4;
    }
    public static System.Collections.Generic.List<LanguageInfo> GetAllLanguageInfo()
    {
        var val_17;
        var val_20;
        var val_23;
        var val_25;
        System.Func<LanguageInfo, System.Int32> val_27;
        System.Collections.Generic.List<LanguageInfo> val_1 = new System.Collections.Generic.List<LanguageInfo>();
        System.Collections.IEnumerator val_4 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_23:
        var val_19 = 0;
        val_19 = val_19 + 1;
        val_17 = 0;
        if(val_4.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_20 = 0;
        val_20 = val_20 + 1;
        val_17 = 1;
        val_4.Current.Add(driver:  public System.Object System.Collections.IEnumerator::get_Current(), rectTransform:  null, drivenProperties:  null);
        if(0 == (LanguageInfo.Get(language:  1152921504628039680)))
        {
            goto label_23;
        }
        
        val_1.Add(item:  LanguageInfo.Get(language:  1152921504628039680));
        goto label_23;
        label_11:
        val_20 = 0;
        if(val_4 != null)
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_4.Dispose();
        }
        
        val_23 = null;
        val_23 = null;
        if((LanguageManager.<>c.<>9__22_0) == null)
        {
            goto label_43;
        }
        
        label_53:
        int val_14 = val_1.RemoveAll(match:  LanguageManager.<>c.<>9__22_0);
        val_25 = null;
        val_25 = null;
        val_27 = LanguageManager.<>c.<>9__22_1;
        if(val_27 != null)
        {
                return (System.Collections.Generic.List<LanguageInfo>)System.Linq.Enumerable.ToList<LanguageInfo>(source:  System.Linq.Enumerable.OrderBy<LanguageInfo, System.Int32>(source:  val_1, keySelector:  System.Func<LanguageInfo, System.Int32> val_15 = null));
        }
        
        val_27 = val_15;
        val_15 = new System.Func<LanguageInfo, System.Int32>(object:  LanguageManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 LanguageManager.<>c::<GetAllLanguageInfo>b__22_1(LanguageInfo x));
        LanguageManager.<>c.<>9__22_1 = val_27;
        return (System.Collections.Generic.List<LanguageInfo>)System.Linq.Enumerable.ToList<LanguageInfo>(source:  System.Linq.Enumerable.OrderBy<LanguageInfo, System.Int32>(source:  val_1, keySelector:  val_15));
        label_43:
        LanguageManager.<>c.<>9__22_0 = new System.Predicate<LanguageInfo>(object:  LanguageManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LanguageManager.<>c::<GetAllLanguageInfo>b__22_0(LanguageInfo x));
        if(val_1 != null)
        {
            goto label_53;
        }
        
        goto label_53;
    }
    public LanguageManager()
    {
        this.languageMap = new System.Collections.Generic.Dictionary<System.String, System.String>();
    }

}
