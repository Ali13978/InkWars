using UnityEngine;
[Serializable]
public class ProfileUnlockables_Avatar : ProfileUnlockables_Base
{
    // Fields
    public Avatars_Common_Key CommonKey;
    public Avatars_Common_Order CommonOrder;
    public Avatars_Specific_Key SpecificKey;
    public Avatars_Specific_Order SpecificOrder;
    public UnityEngine.Sprite Sprite_Avatar;
    
    // Properties
    public override bool isCommon { get; }
    
    // Methods
    public override bool get_isCommon()
    {
        return (bool)(this.CommonKey != 0) ? 1 : 0;
    }
    public ProfileUnlockables_Avatar SetCommonKey(Avatars_Common_Key key)
    {
        this.SpecificKey = 0;
        this.CommonKey = key;
        mem[1152921528318335112] = 999999;
        key.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        object val_3 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  key.ToString());
        this.CommonOrder = null;
        null.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
        mem[1152921528318335104] = null.ToString();
        return (ProfileUnlockables_Avatar)this;
    }
    public ProfileUnlockables_Avatar SetSpecificKey(CharacterNameID cid, Avatars_Specific_Key key)
    {
        this.CommonKey = 0;
        this.SpecificKey = key;
        mem[1152921528318520840] = cid;
        key.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  key, drivenProperties:  null);
        object val_3 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  key.ToString());
        this.SpecificOrder = null;
        cid.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
        null.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
        mem[1152921528318520832] = cid.ToString() + "_" + null.ToString();
        return (ProfileUnlockables_Avatar)this;
    }
    public ProfileUnlockables_Avatar SetData(UnityEngine.Sprite sprite, Currency aNewCurrency, int aNewCost)
    {
        this.Sprite_Avatar = sprite;
        mem[1152921528318686116] = aNewCurrency;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  aNewCost);
        mem[1152921528318686120] = val_1.currentCryptoKey;
        mem[1152921528318686124] = val_1.hiddenValue;
        mem[1152921528318686128] = val_1.fakeValue;
        mem[1152921528318686132] = val_1.inited;
        return (ProfileUnlockables_Avatar)this;
    }
    public ProfileUnlockables_Avatar SetUnlockDesc(string unlockConditionText, UnlockLogicFor2ndConditionType aNewConditionLogical, string secondaryConditionText)
    {
        mem[1152921528318818592] = aNewConditionLogical;
        mem[1152921528318818576] = unlockConditionText;
        mem[1152921528318818584] = secondaryConditionText;
        return (ProfileUnlockables_Avatar)this;
    }
    public override bool IsUnlocked()
    {
        var val_5;
        var val_6;
        var val_7;
        if("VIP_EXPIRE_CHECKER" != 999999)
        {
                val_5 = null;
            val_5 = null;
            if((DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  53669888)) != false)
        {
                val_6 = 0;
            return (bool)val_6;
        }
        
        }
        
        bool val_2 = System.String.IsNullOrEmpty(value:  28847);
        if(val_2 != false)
        {
                if((System.String.IsNullOrEmpty(value:  val_2)) != false)
        {
                val_6 = 1;
            return (bool)val_6;
        }
        
        }
        
        val_7 = null;
        val_7 = null;
        if(DataStructs.UserDataDictionary.Items != null)
        {
                return DataStructs.UserDataDictionary.Items.GetAvatarUnlocked(avatar:  this);
        }
        
        return DataStructs.UserDataDictionary.Items.GetAvatarUnlocked(avatar:  this);
    }
    public void SetUnlocked(bool unlocked)
    {
        null = null;
        DataStructs.UserDataDictionary.Items.SetAvatarUnlocked(avatar:  this, isUnlock:  unlocked);
    }
    public bool IsEligibleForPurchase()
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
        
        if((System.String.IsNullOrEmpty(value:  28846)) != false)
        {
                val_5 = 1;
            return (bool)val_5;
        }
        
        val_6 = null;
        val_6 = null;
        if(DataStructs.UserDataDictionary.Items != null)
        {
                return DataStructs.UserDataDictionary.Items.IsAvatarEligibleForPurchase(avatar:  this);
        }
        
        return DataStructs.UserDataDictionary.Items.IsAvatarEligibleForPurchase(avatar:  this);
    }
    public int GetIntId()
    {
        if((this & 1) == 0)
        {
                return AvatarCollection.GetAvatarIntId(key:  this.SpecificKey, cid:  this);
        }
        
        return AvatarCollection.GetAvatarIntId(key:  this.CommonKey, cid:  this);
    }
    public ProfileUnlockables_Avatar()
    {
        val_1 = new System.Object();
    }

}
