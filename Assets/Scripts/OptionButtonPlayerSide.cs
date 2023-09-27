using UnityEngine;
public class OptionButtonPlayerSide : OptionButton
{
    // Methods
    protected override float GetBindingDataValue()
    {
        null = null;
        return (float)(float)DataStructs.UserDataDictionary.Settings.FlipNegateX;
    }
    protected override void SetBindingDataValue(float value)
    {
        null = null;
        DataStructs.UserDataDictionary.Settings.FlipNegateX = (int)value;
        DeviceBasedData.playerAtLeftForQuickPlay = (value == 1f) ? 1 : 0;
    }
    public OptionButtonPlayerSide()
    {
    
    }

}
