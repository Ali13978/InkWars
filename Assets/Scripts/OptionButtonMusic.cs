using UnityEngine;
public class OptionButtonMusic : OptionButton
{
    // Methods
    protected override float GetBindingDataValue()
    {
        byte val_5;
        var val_6;
        byte val_7;
        var val_8;
        val_5 = 1152921505064992768;
        val_6 = null;
        val_6 = null;
        if(Character_GlobalInfo.isOfflineMode != false)
        {
                val_7 = 0;
            bool val_1 = DeviceBasedData.enableMusic;
            return (float)((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_7, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, fakeValueChanged = val_2.fakeValue, inited = val_2.fakeValue})) != true) ? 1f : 0f;
        }
        
        val_8 = null;
        val_8 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = DataStructs.UserDataDictionary.Settings.MusicEnabled;
        val_5 = val_2.currentCryptoKey;
        val_2.fakeValue = val_2.fakeValue & 4294967295;
        val_7 = val_5;
        return (float)((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_7, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, fakeValueChanged = val_2.fakeValue, inited = val_2.fakeValue})) != true) ? 1f : 0f;
    }
    protected override void SetBindingDataValue(float value)
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  (value > 0.002f) ? 1 : 0);
        DataStructs.UserDataDictionary.Settings.MusicEnabled = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295};
    }
    public OptionButtonMusic()
    {
    
    }

}
