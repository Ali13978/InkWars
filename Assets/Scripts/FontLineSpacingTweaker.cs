using UnityEngine;
public class FontLineSpacingTweaker : MonoBehaviour
{
    // Fields
    public int defaultLine;
    public System.Collections.Generic.List<FontLineSpacingTweaker.LanguageLineSpacePair> languageSpecialCases;
    
    // Methods
    private void OnEnable()
    {
        this.OnLanguageChanged();
        LanguageManager.add_OnLanguageChanged(value:  new LanguageManager.LanguageMgrHandler(object:  this, method:  System.Void FontLineSpacingTweaker::OnLanguageChanged()));
    }
    private void OnDisable()
    {
        LanguageManager.remove_OnLanguageChanged(value:  new LanguageManager.LanguageMgrHandler(object:  this, method:  System.Void FontLineSpacingTweaker::OnLanguageChanged()));
    }
    private void OnLanguageChanged()
    {
        int val_5;
        var val_6;
        TMPro.TextMeshProUGUI val_1 = this.GetComponent<TMPro.TextMeshProUGUI>();
        if(0 == val_1)
        {
                return;
        }
        
        val_5 = this.defaultLine;
        val_1.lineSpacing = (float)val_5;
        if(this.languageSpecialCases == null)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = FontLineSpacingTweaker.<>c.<>9__5_0;
        if(val_5 == null)
        {
                System.Predicate<LanguageLineSpacePair> val_3 = null;
            val_5 = val_3;
            val_3 = new System.Predicate<LanguageLineSpacePair>(object:  FontLineSpacingTweaker.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FontLineSpacingTweaker.<>c::<OnLanguageChanged>b__5_0(FontLineSpacingTweaker.LanguageLineSpacePair x));
            FontLineSpacingTweaker.<>c.<>9__5_0 = val_5;
        }
        
        if((this.languageSpecialCases.Find(match:  val_3)) == null)
        {
                return;
        }
        
        val_1.lineSpacing = (float)val_4.lineSpacing;
    }
    public FontLineSpacingTweaker()
    {
        this.languageSpecialCases = new System.Collections.Generic.List<LanguageLineSpacePair>();
    }

}
