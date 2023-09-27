using UnityEngine;
[Serializable]
public class CurrencyData
{
    // Fields
    public Currency id;
    public UnityEngine.Sprite icon;
    public string unitName;
    public string pluralName;
    
    // Properties
    public string TitleCaseUnitName { get; }
    public string TitleCasePluralName { get; }
    
    // Methods
    public string get_TitleCaseUnitName()
    {
        return this.TitleCase(txt:  this.unitName);
    }
    public string get_TitleCasePluralName()
    {
        return this.TitleCase(txt:  this.pluralName);
    }
    private string TitleCase(string txt)
    {
        if((System.String.IsNullOrEmpty(value:  txt)) != false)
        {
                return 0;
        }
        
        System.Globalization.CultureInfo val_2 = new System.Globalization.CultureInfo(name:  "en-US", useUserOverride:  false);
        if(val_2 != null)
        {
                return val_2.ToTitleCase(str:  txt);
        }
        
        return val_2.ToTitleCase(str:  txt);
    }
    public CurrencyData()
    {
    
    }

}
