using UnityEngine;
public class FontViewerController : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI txt1;
    private TMPro.TextMeshProUGUI txt2;
    private TMPro.TextMeshProUGUI txt3;
    public UnityEngine.SystemLanguage txt1Language;
    public UnityEngine.SystemLanguage txt2Language;
    public UnityEngine.SystemLanguage txt3Language;
    public FontSubStyle subStyle;
    
    // Methods
    private void Start()
    {
        this.Refresh();
    }
    private void SetTxt(TMPro.TextMeshProUGUI txt, UnityEngine.SystemLanguage language)
    {
        UnityEngine.SystemLanguage val_13;
        var val_14;
        System.Predicate<LanguageTextKeyValueData> val_16;
        var val_17;
        System.Predicate<LanguageTextKeyValueData> val_19;
        val_13 = language;
        .language = val_13;
        if(0 == txt)
        {
                return;
        }
        
        System.Predicate<LanguageInfo> val_4 = new System.Predicate<LanguageInfo>(object:  new FontViewerController.<>c__DisplayClass8_0(), method:  System.Boolean FontViewerController.<>c__DisplayClass8_0::<SetTxt>b__0(LanguageInfo x));
        LanguageInfo val_5 = LanguageManager.GetAllLanguageInfo().Find(match:  null);
        LanguageTextData val_6 = val_5.textData;
        val_14 = null;
        val_14 = null;
        val_16 = FontViewerController.<>c.<>9__8_1;
        if(val_16 == null)
        {
            goto label_10;
        }
        
        if(val_6.textData != null)
        {
            goto label_15;
        }
        
        goto label_12;
        label_10:
        val_16 = null;
        val_16 = new System.Predicate<LanguageTextKeyValueData>(object:  FontViewerController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FontViewerController.<>c::<SetTxt>b__8_1(LanguageTextData.LanguageTextKeyValueData x));
        FontViewerController.<>c.<>9__8_1 = val_16;
        if(val_6.textData != null)
        {
            goto label_15;
        }
        
        label_12:
        label_15:
        LanguageTextKeyValueData val_8 = val_6.textData.Find(match:  null);
        val_13 = val_8.text;
        LanguageTextData val_9 = val_5.textData;
        val_17 = null;
        val_17 = null;
        val_19 = FontViewerController.<>c.<>9__8_2;
        if(val_19 == null)
        {
            goto label_21;
        }
        
        if(val_9.textData != null)
        {
            goto label_26;
        }
        
        goto label_23;
        label_21:
        val_19 = null;
        val_19 = new System.Predicate<LanguageTextKeyValueData>(object:  FontViewerController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FontViewerController.<>c::<SetTxt>b__8_2(LanguageTextData.LanguageTextKeyValueData x));
        FontViewerController.<>c.<>9__8_2 = val_19;
        if(val_9.textData != null)
        {
            goto label_26;
        }
        
        label_23:
        label_26:
        LanguageTextKeyValueData val_11 = val_9.textData.Find(match:  null);
        txt.text = System.String.Format(format:  "{0}\r\n{1} Bbq\r\n{2} Bbq\r\n<b>{1} Bbq\r\n{2} Bbq</b>", arg0:  val_5.localizedLanguageName, arg1:  val_13, arg2:  val_11.text);
    }
    private void RefreshTxt(TMPro.TextMeshProUGUI txt, UnityEngine.SystemLanguage language)
    {
        this.SetTxt(txt:  txt, language:  language);
        if(0 == (txt.GetComponent<FontResponser>()))
        {
                return;
        }
        
        txt.GetComponent<FontResponser>().ReloadFontAsset(language:  language);
        txt.GetComponent<FontResponser>().ReloadFontMaterial(subStyle:  this.subStyle);
    }
    public void Refresh()
    {
        this.RefreshTxt(txt:  this.txt1, language:  this.txt1Language);
        this.RefreshTxt(txt:  this.txt2, language:  this.txt2Language);
        this.RefreshTxt(txt:  this.txt3, language:  this.txt3Language);
    }
    public FontViewerController()
    {
        this.txt1Language = 10;
        this.txt3Language = 22;
    }

}
