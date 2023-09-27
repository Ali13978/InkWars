using UnityEngine;
public class LanguageInfo : ScriptableObject
{
    // Fields
    public UnityEngine.SystemLanguage language;
    public DataStructs.Flag flag;
    public int sortOrder;
    public string localizedLanguageName;
    public bool enabled;
    private LanguageTextData _txtDat;
    private TMPro.TMP_FontAsset _font;
    
    // Properties
    public LanguageTextData textData { get; }
    public TMPro.TMP_FontAsset font { get; }
    
    // Methods
    public LanguageTextData get_textData()
    {
        LanguageTextData val_3;
        if(0 == this._txtDat)
        {
                this._txtDat = LanguageTextData.Load(language:  this.language);
            return val_3;
        }
        
        val_3 = this._txtDat;
        return val_3;
    }
    public TMPro.TMP_FontAsset get_font()
    {
        TMPro.TMP_FontAsset val_4;
        if(0 == this._font)
        {
                this._font = UnityEngine.Resources.Load<TMPro.TMP_FontAsset>(path:  LanguageInfo.GetFontFileResourcesPath(language:  this.language));
            return val_4;
        }
        
        val_4 = this._font;
        return val_4;
    }
    public override string ToString()
    {
        return (string)System.String.Format(format:  "[LanguageInfo: language - {0}, flag - {1}, order - {2}]", arg0:  this.language, arg1:  this.flag, arg2:  this.sortOrder);
    }
    public void UnloadAssets()
    {
        if(0 != this._font)
        {
                UnityEngine.Resources.UnloadAsset(assetToUnload:  this._font);
            this._font = 0;
        }
        
        if(0 == this._txtDat)
        {
                return;
        }
        
        UnityEngine.Resources.UnloadAsset(assetToUnload:  this._txtDat);
        this._txtDat = 0;
    }
    public static System.Collections.Generic.List<LanguageInfo> GetAll()
    {
        var val_12;
        var val_15;
        System.Collections.Generic.List<LanguageInfo> val_1 = new System.Collections.Generic.List<LanguageInfo>();
        System.Collections.IEnumerator val_4 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_23:
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_12 = 0;
        if(val_4.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_12 = 1;
        val_4.Current.Add(driver:  public System.Object System.Collections.IEnumerator::get_Current(), rectTransform:  null, drivenProperties:  null);
        if(0 == (LanguageInfo.Get(language:  1152921504628039680)))
        {
            goto label_23;
        }
        
        val_1.Add(item:  LanguageInfo.Get(language:  1152921504628039680));
        goto label_23;
        label_11:
        val_15 = 0;
        if(val_4 != null)
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_4.Dispose();
        }
        
        if( == false)
        {
                return val_1;
        }
        
        return val_1;
    }
    public static string GetResourceDir(UnityEngine.SystemLanguage language)
    {
        return (string)System.String.Format(format:  "Languages/{0}", arg0:  language);
    }
    public static string GetInfoFileName(UnityEngine.SystemLanguage language)
    {
        return (string)System.String.Format(format:  "{0}LanguageInfo.asset", arg0:  language);
    }
    public static string GetInfoFileResourcesPath(UnityEngine.SystemLanguage language)
    {
        return System.String.Format(format:  "{0}/{1}", arg0:  LanguageInfo.GetResourceDir(language:  language), arg1:  LanguageInfo.GetInfoFileName(language:  language).Replace(oldValue:  ".asset", newValue:  ""));
    }
    public static string GetFontFileName(UnityEngine.SystemLanguage language)
    {
        return (string)System.String.Format(format:  "{0}BoldFont.asset", arg0:  language);
    }
    public static string GetFontFileResourcesPath(UnityEngine.SystemLanguage language)
    {
        return System.String.Format(format:  "LanguageFonts/{0}", arg0:  LanguageInfo.GetFontFileName(language:  language).Replace(oldValue:  ".asset", newValue:  ""));
    }
    public static LanguageInfo Get(UnityEngine.SystemLanguage language)
    {
        return UnityEngine.Resources.Load<LanguageInfo>(path:  LanguageInfo.GetInfoFileResourcesPath(language:  language));
    }
    public LanguageInfo()
    {
    
    }

}
