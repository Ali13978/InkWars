using UnityEngine;
public class LanguageTextData : ScriptableObject
{
    // Fields
    public UnityEngine.SystemLanguage languageCode;
    public System.Collections.Generic.List<LanguageTextData.LanguageTextKeyValueData> textData;
    
    // Methods
    public static string GetTextDataFileName(UnityEngine.SystemLanguage language)
    {
        return (string)System.String.Format(format:  "{0}TextData.asset", arg0:  language);
    }
    public static string GetResourcePath(UnityEngine.SystemLanguage language)
    {
        return System.String.Format(format:  "{0}/{1}", arg0:  LanguageInfo.GetResourceDir(language:  language), arg1:  LanguageTextData.GetTextDataFileName(language:  language).Replace(oldValue:  ".asset", newValue:  ""));
    }
    public static LanguageTextData Load(UnityEngine.SystemLanguage language)
    {
        return UnityEngine.Resources.Load<LanguageTextData>(path:  LanguageTextData.GetResourcePath(language:  language));
    }
    public System.Collections.Generic.Dictionary<string, string> ToDictionary()
    {
        object val_5;
        System.Collections.Generic.List<LanguageTextKeyValueData> val_15;
        var val_16;
        string val_17;
        UnityEngine.DrivenTransformProperties val_18;
        System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        val_15 = this.textData;
        if(val_15 == null)
        {
                System.Collections.Generic.List<LanguageTextKeyValueData> val_2 = null;
            val_15 = val_2;
            val_2 = new System.Collections.Generic.List<LanguageTextKeyValueData>();
            this.textData = val_15;
        }
        
        List.Enumerator<T> val_3 = val_2.GetEnumerator();
        val_16 = 1152921504621490176;
        goto label_3;
        label_58:
        val_15 = val_5.InitialType;
        if(val_15 == null)
        {
            goto label_4;
        }
        
        bool val_7 = System.String.IsNullOrWhiteSpace(value:  val_6._impl);
        if(val_7 == false)
        {
            goto label_5;
        }
        
        object[] val_8 = new object[2];
        val_15 = val_8;
        val_5 = 1;
        val_15[0] = val_5;
        val_15[1] = this.languageCode;
        val_17 = 0;
        UnityEngine.Debug.LogErrorFormat(format:  "Found empty {1} text key at line {0}", args:  val_8);
        goto label_56;
        label_4:
        object[] val_9 = new object[2];
        val_15 = val_9;
        val_5 = 1;
        val_15[0] = val_5;
        val_15[1] = this.languageCode;
        val_17 = 0;
        UnityEngine.Debug.LogErrorFormat(format:  "Found empty {1} text key value pair at line {0}", args:  val_9);
        goto label_56;
        label_5:
        if((System.String.IsNullOrWhiteSpace(value:  val_7)) != true)
        {
                if((val_1.ContainsKey(key:  val_6._impl)) != false)
        {
                object[] val_12 = new object[3];
            val_5 = 1;
            val_12[0] = val_5;
            val_12[1] = val_6._impl;
            val_12[2] = this.languageCode;
            UnityEngine.Debug.LogErrorFormat(format:  "Duplicated key {1} for {2} text at line {0}", args:  val_12);
            object[] val_13 = new object[4];
            val_13[0] = val_6._impl;
            val_13[1] = this.languageCode;
            val_13[2] = this.languageCode;
            val_13[3] = val_1.Item[val_6._impl];
            UnityEngine.Debug.LogErrorFormat(format:  "Override {1} text: key - {0}, new - {2}, old - {3}", args:  val_13);
            val_18 = public System.Void System.Collections.Generic.Dictionary<System.String, System.String>::set_Item(System.String key, System.String value);
            val_17 = val_15;
            val_1.set_Item(key:  val_6._impl, value:  val_17);
            val_16 = 1152921504621490176;
        }
        else
        {
                val_18 = public System.Void System.Collections.Generic.Dictionary<System.String, System.String>::Add(System.String key, System.String value);
            val_17 = val_15;
            val_1.Add(key:  val_6._impl, value:  val_17);
        }
        
        }
        
        label_56:
        label_3:
        if((81443840 & 1) != 0)
        {
            goto label_58;
        }
        
        val_5.Add(driver:  public System.Void List.Enumerator<LanguageTextKeyValueData>::Dispose(), rectTransform:  val_17, drivenProperties:  val_18);
        return val_1;
    }
    public LanguageTextData()
    {
        this.textData = new System.Collections.Generic.List<LanguageTextKeyValueData>();
    }

}
