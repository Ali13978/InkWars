using UnityEngine;
[Serializable]
public class ProfileUnlockables_Title : ProfileUnlockables_Base
{
    // Fields
    public Titles_Common_Key CommonKey;
    public Titles_Common_Order CommonOrder;
    public Titles_Specific_Key SpecificKey;
    public Titles_Specific_Order SpecificOrder;
    public string Title;
    public Titles_BG_Type BGType;
    
    // Properties
    public override bool isCommon { get; }
    
    // Methods
    public ProfileUnlockables_Title SetCommonKey(Titles_Common_Key key)
    {
        this.SpecificKey = 0;
        this.CommonKey = key;
        mem[1152921528319780296] = 999999;
        key.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        object val_3 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  key.ToString());
        this.CommonOrder = null;
        null.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
        mem[1152921528319780288] = null.ToString();
        return (ProfileUnlockables_Title)this;
    }
    public ProfileUnlockables_Title SetSpecificKey(CharacterNameID cid, Titles_Specific_Key key)
    {
        this.CommonKey = 0;
        this.SpecificKey = key;
        mem[1152921528319966024] = cid;
        key.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  key, drivenProperties:  null);
        object val_3 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  key.ToString());
        this.SpecificOrder = null;
        cid.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
        null.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
        mem[1152921528319966016] = cid.ToString() + "_" + null.ToString();
        return (ProfileUnlockables_Title)this;
    }
    public override bool get_isCommon()
    {
        return (bool)(this.CommonKey != 0) ? 1 : 0;
    }
    public override bool IsUnlocked()
    {
        var val_4;
        var val_5;
        var val_6;
        if("VIP_EXPIRE_CHECKER" != 999999)
        {
                val_4 = null;
            val_4 = null;
            if((DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  53669888)) != false)
        {
                val_5 = 0;
            return (bool)val_5;
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  28854)) != false)
        {
                val_5 = 1;
            return (bool)val_5;
        }
        
        val_6 = null;
        val_6 = null;
        if(DataStructs.UserDataDictionary.Items != null)
        {
                return DataStructs.UserDataDictionary.Items.GetTitleUnlocked(title:  this);
        }
        
        return DataStructs.UserDataDictionary.Items.GetTitleUnlocked(title:  this);
    }
    public int GetIntId()
    {
        if((this & 1) == 0)
        {
                return TitleCollection.GetTitleIntId(key:  this.SpecificKey, cid:  this);
        }
        
        return TitleCollection.GetTitleIntId(key:  this.CommonKey, cid:  this);
    }
    public ProfileUnlockables_Title()
    {
        val_1 = new System.Object();
    }

}
