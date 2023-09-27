using UnityEngine;
public class CharacterNameController : MonoBehaviour
{
    // Fields
    private CharacterNameID _charId;
    private CharacterNameStyleType <style>k__BackingField;
    private TMPro.TextMeshProUGUI nameText;
    private TMPro.TextMeshProUGUI raceText;
    private MiddleSuperCanvas middleSuper;
    
    // Properties
    public CharacterNameID characterId { get; set; }
    public CharacterNameStyleType style { get; set; }
    public string characterName { get; set; }
    public string characterRace { get; set; }
    
    // Methods
    public CharacterNameID get_characterId()
    {
        return (CharacterNameID)this._charId;
    }
    public void set_characterId(CharacterNameID value)
    {
        this._charId = value;
        if(value == 999999)
        {
                this.characterName = 0;
            this.characterRace = 0;
            return;
        }
        
        CharacterData val_1 = CharacterDataManager.Get(id:  value);
        this.<style>k__BackingField = val_1.nameStyle;
        this.UpdateNameTxt();
        if(0 != this.middleSuper)
        {
                this.middleSuper.OnSelectionChanged(selection:  this._charId);
        }
        
        this.UpdateFontMaterialBold();
        this.SetMinWidth();
    }
    public CharacterNameStyleType get_style()
    {
        return (CharacterNameStyleType)this.<style>k__BackingField;
    }
    private void set_style(CharacterNameStyleType value)
    {
        this.<style>k__BackingField = value;
    }
    public string get_characterName()
    {
        if(this.nameText != null)
        {
                return this.nameText.text;
        }
        
        return this.nameText.text;
    }
    private void set_characterName(string value)
    {
        this.nameText.text = value;
    }
    public string get_characterRace()
    {
        if(this.raceText != null)
        {
                return this.raceText.text;
        }
        
        return this.raceText.text;
    }
    private void set_characterRace(string value)
    {
        this.raceText.text = value;
    }
    private void UpdateNameTxt()
    {
        string val_11;
        CharacterData val_1 = CharacterDataManager.Get(id:  this._charId);
        if(this._charId == 999999)
        {
                this.characterName = 0;
            val_11 = 0;
        }
        else
        {
                this.characterName = val_1.localizedText.name.ToUpper();
            this.characterRace = val_1.localizedText.clan;
            if((System.String.IsNullOrEmpty(value:  this.characterRace)) != false)
        {
                return;
        }
        
            val_11 = this.characterRace.ToUpper();
        }
        
        this.characterRace = val_11;
    }
    private void UpdateFontMaterialBold()
    {
        UnityEngine.Object val_11;
        var val_12;
        TMPro.TMP_FontAsset val_2 = LanguageManager.GetBoldFont(language:  LanguageManager.currentLanguage);
        this.nameText.font = val_2;
        this.raceText.font = val_2;
        UnityEngine.Material val_3 = FontSubStyleCollection.GetMaterial(style:  13);
        val_11 = CharacterDataManager.Get(id:  this._charId);
        if(0 == val_11)
        {
                return;
        }
        
        if(val_4.nameStyle <= 5)
        {
                var val_11 = 40837480 + (val_4.nameStyle) << 2;
            val_11 = val_11 + 40837480;
        }
        else
        {
                val_12 = 11;
            val_11 = FontSubStyleCollection.GetMaterial(style:  25);
            this.nameText.fontMaterial = val_11;
            this.raceText.fontMaterial = val_11;
            if(0 == val_11)
        {
                return;
        }
        
            if(0 == val_2)
        {
                return;
        }
        
            if(val_11.mainTexture == val_2.atlas)
        {
                return;
        }
        
            val_11.mainTexture = val_2.atlas;
        }
    
    }
    private void SetMinWidth()
    {
        UnityEngine.Vector2 val_2 = this.GetComponent<UnityEngine.RectTransform>().sizeDelta;
        this.GetComponent<UnityEngine.RectTransform>().sizeDelta = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        float val_5 = 1.3f;
        val_5 = this.raceText.fontSize * val_5;
        this.nameText.fontSize = val_5;
    }
    private void Awake()
    {
        this.characterId = this._charId;
    }
    private void OnEnable()
    {
        this.UpdateNameTxt();
        this.UpdateFontMaterialBold();
        LanguageManager.add_OnLanguageChanged(value:  new LanguageManager.LanguageMgrHandler(object:  this, method:  System.Void CharacterNameController::OnLanguageChanged()));
    }
    private void OnDisable()
    {
        LanguageManager.remove_OnLanguageChanged(value:  new LanguageManager.LanguageMgrHandler(object:  this, method:  System.Void CharacterNameController::OnLanguageChanged()));
    }
    private void OnLanguageChanged()
    {
        this.UpdateNameTxt();
        this.UpdateFontMaterialBold();
    }
    public CharacterNameController()
    {
        this._charId = 999999;
    }

}
