using UnityEngine;
public class LocalizationExample : MonoBehaviour
{
    // Methods
    private void Start()
    {
        bool val_1 = LanguageManager.SetLanguage(language:  10);
    }
    public void ToEn()
    {
        bool val_1 = LanguageManager.SetLanguage(language:  10);
    }
    public void ToKo()
    {
        bool val_1 = LanguageManager.SetLanguage(language:  23);
    }
    public LocalizationExample()
    {
    
    }

}
