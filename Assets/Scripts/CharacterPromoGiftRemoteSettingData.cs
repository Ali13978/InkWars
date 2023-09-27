using UnityEngine;
[Serializable]
public class CharacterPromoGiftRemoteSettingData
{
    // Fields
    public System.Collections.Generic.List<CharacterPromoGiftData> characterPromoSettings;
    
    // Methods
    public CharacterPromoGiftData Get(CharacterNameID characterId)
    {
        System.Predicate<T> val_6;
        var val_7;
        .characterId = characterId;
        System.Predicate<CharacterPromoGiftData> val_2 = null;
        val_6 = val_2;
        val_2 = new System.Predicate<CharacterPromoGiftData>(object:  new CharacterPromoGiftRemoteSettingData.<>c__DisplayClass1_0(), method:  System.Boolean CharacterPromoGiftRemoteSettingData.<>c__DisplayClass1_0::<Get>b__0(CharacterPromoGiftData x));
        val_7 = this.characterPromoSettings.Find(match:  val_2);
        if(val_7 != null)
        {
                return (CharacterPromoGiftData)val_7;
        }
        
        CharacterPromoGiftData val_4 = null;
        val_7 = val_4;
        val_4 = new CharacterPromoGiftData();
        val_6 = .characterId;
        .characterId.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  public CharacterPromoGiftData System.Collections.Generic.List<CharacterPromoGiftData>::Find(System.Predicate<T> match), drivenProperties:  public System.Void System.Predicate<CharacterPromoGiftData>::.ctor(object object, IntPtr method));
        mem[1152921528410208960] = null;
        .character = .characterId.ToString();
        return (CharacterPromoGiftData)val_7;
    }
    public bool HasPromo()
    {
        var val_5 = null;
        if((CharacterPromoGiftRemoteSettingData.<>c.<>9__2_0) == null)
        {
            goto label_3;
        }
        
        label_9:
        System.Collections.Generic.List<T> val_1 = this.characterPromoSettings.FindAll(match:  CharacterPromoGiftRemoteSettingData.<>c.<>9__2_0);
        if(val_1 == null)
        {
                return (bool)(val_1.Count > 0) ? 1 : 0;
        }
        
        return (bool)(val_1.Count > 0) ? 1 : 0;
        label_3:
        CharacterPromoGiftRemoteSettingData.<>c.<>9__2_0 = new System.Predicate<CharacterPromoGiftData>(object:  CharacterPromoGiftRemoteSettingData.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CharacterPromoGiftRemoteSettingData.<>c::<HasPromo>b__2_0(CharacterPromoGiftData x));
        if(this.characterPromoSettings != null)
        {
            goto label_9;
        }
        
        goto label_9;
    }
    public CharacterPromoGiftRemoteSettingData()
    {
        this.characterPromoSettings = new System.Collections.Generic.List<CharacterPromoGiftData>();
    }

}
