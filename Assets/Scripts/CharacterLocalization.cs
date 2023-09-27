using UnityEngine;
public class CharacterLocalization
{
    // Fields
    private CharacterNameID characterId;
    
    // Properties
    public string name { get; }
    public string clan { get; }
    public string nickName { get; }
    public string characterDescription { get; }
    public string dislike { get; }
    public string like { get; }
    public string realPersonDescription { get; }
    public string winQuote20Balls { get; }
    public string winQuote19Balls { get; }
    public string winQuote5Balls { get; }
    public string winQuoteTimeOut { get; }
    
    // Methods
    public static string GetTxtKey(CharacterNameID cid, string key)
    {
        cid.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        return (string)"LK.Character." + cid.ToString() + "." + key;
    }
    public CharacterLocalization(CharacterNameID cid)
    {
        this.characterId = cid;
    }
    private string GetCharacterLocalization(string key)
    {
        return LanguageManager.GetText(key:  CharacterLocalization.GetTxtKey(cid:  this.characterId, key:  key));
    }
    public string get_name()
    {
        return LanguageManager.GetText(key:  CharacterLocalization.GetTxtKey(cid:  this.characterId, key:  "name"));
    }
    public string get_clan()
    {
        var val_9;
        var val_10;
        val_9 = this;
        string val_2 = LanguageManager.GetText(key:  CharacterLocalization.GetTxtKey(cid:  this.characterId, key:  "customClanName"));
        val_10 = val_2;
        if((System.String.IsNullOrWhiteSpace(value:  val_2)) != true)
        {
                if((val_10.StartsWith(value:  "LK.Character.")) == false)
        {
                return (string)val_10;
        }
        
        }
        
        CharacterClan val_5 = Character_GlobalInfo.GetClan(characterId:  this.characterId);
        val_9 = val_5;
        val_5.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
        val_10 = LanguageManager.GetText(key:  "LK." + val_5.ToString());
        return (string)val_10;
    }
    public string get_nickName()
    {
        return LanguageManager.GetText(key:  CharacterLocalization.GetTxtKey(cid:  this.characterId, key:  "nickName"));
    }
    public string get_characterDescription()
    {
        return LanguageManager.GetText(key:  CharacterLocalization.GetTxtKey(cid:  this.characterId, key:  "characterDescription"));
    }
    public string get_dislike()
    {
        return LanguageManager.GetText(key:  CharacterLocalization.GetTxtKey(cid:  this.characterId, key:  "dislike"));
    }
    public string get_like()
    {
        return LanguageManager.GetText(key:  CharacterLocalization.GetTxtKey(cid:  this.characterId, key:  "like"));
    }
    public string get_realPersonDescription()
    {
        return LanguageManager.GetText(key:  CharacterLocalization.GetTxtKey(cid:  this.characterId, key:  "realPersonDescription"));
    }
    public string get_winQuote20Balls()
    {
        return LanguageManager.GetText(key:  CharacterLocalization.GetTxtKey(cid:  this.characterId, key:  "winQuote20Balls"));
    }
    public string get_winQuote19Balls()
    {
        return LanguageManager.GetText(key:  CharacterLocalization.GetTxtKey(cid:  this.characterId, key:  "winQuote19Balls"));
    }
    public string get_winQuote5Balls()
    {
        return LanguageManager.GetText(key:  CharacterLocalization.GetTxtKey(cid:  this.characterId, key:  "winQuote5Balls"));
    }
    public string get_winQuoteTimeOut()
    {
        return LanguageManager.GetText(key:  CharacterLocalization.GetTxtKey(cid:  this.characterId, key:  "winQuoteTimeOut"));
    }
    public string GetSpecialOpponentQuote(CharacterNameID opponentId)
    {
        var val_6;
        this.characterId.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        mem2[0] = null;
        opponentId.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        string val_3 = "LK.Character." + this.characterId.ToString() + ".SpecOp." + opponentId.ToString();
        val_6 = 0;
        if((LanguageManager.IsNullOrEmpty(key:  val_3)) == true)
        {
                return (string)LanguageManager.GetText(key:  val_3);
        }
        
        return (string)LanguageManager.GetText(key:  val_3);
    }

}
