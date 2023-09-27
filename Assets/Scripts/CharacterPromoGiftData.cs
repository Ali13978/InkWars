using UnityEngine;
[Serializable]
public class CharacterPromoGiftData
{
    // Fields
    public string character;
    public int pearl;
    public int shell;
    
    // Properties
    public bool HasShell { get; }
    public bool HasPearl { get; }
    public bool HasBoth { get; }
    public string ShortPearlString { get; }
    public string ShortShellString { get; }
    public bool IsActive { get; }
    
    // Methods
    public bool get_HasShell()
    {
        return (bool)(this.shell > 0) ? 1 : 0;
    }
    public bool get_HasPearl()
    {
        return (bool)(this.pearl > 0) ? 1 : 0;
    }
    public bool get_HasBoth()
    {
        if(this.pearl < 1)
        {
                return false;
        }
        
        return (bool)(this.shell > 0) ? 1 : 0;
    }
    public string get_ShortPearlString()
    {
        return CharacterPromoGiftData.ShortNumString(num:  this.pearl);
    }
    public string get_ShortShellString()
    {
        return CharacterPromoGiftData.ShortNumString(num:  this.shell);
    }
    private static string ShortNumString(int num)
    {
        int val_5 = num;
        if(val_5 < 1000)
        {
                string val_1 = val_5.ToString();
            return (string)val_5.Replace(oldValue:  ".0", newValue:  "")(val_5.Replace(oldValue:  ".0", newValue:  "")) + "K";
        }
        
        float val_5 = 1000f;
        val_5 = (float)val_5 / val_5;
        val_5 = val_5.ToString(format:  "n1");
        return (string)val_5.Replace(oldValue:  ".0", newValue:  "")(val_5.Replace(oldValue:  ".0", newValue:  "")) + "K";
    }
    public bool get_IsActive()
    {
        if(this.shell <= 0)
        {
                return (bool)(this.pearl > 0) ? 1 : 0;
        }
        
        return true;
    }
    public void ApplyGift()
    {
        var val_7;
        var val_8;
        if(this.pearl >= 1)
        {
                val_7 = null;
            val_7 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.Pearls;
            int val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
            val_2 = this.pearl + val_2;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_2);
            DataStructs.UserDataDictionary.Items.Pearls = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
        }
        
        if(this.shell < 1)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = DataStructs.UserDataDictionary.Items.Shells;
        int val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited});
        val_5 = this.shell + val_5;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_5);
        DataStructs.UserDataDictionary.Items.Shells = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited};
    }
    public CharacterPromoGiftData()
    {
    
    }

}
