using UnityEngine;
public class GlobalInfo : MonoBehaviour
{
    // Fields
    public static float ballInnerEntryAngle;
    public static float ballMiddleEntryAngle;
    public static float ballOuterEntryAngle;
    public static float aimInnerAngle;
    public static float aimMiddleAngle;
    public static float aimOuterAngle;
    public const float MAX_CONTROL_SENSITIVE = 1;
    public const float MIN_CONTROL_SENSITIVE = -0.5;
    
    // Properties
    public static float innerAimDifference { get; }
    public static float middleAimDifference { get; }
    public static float outerAimDifference { get; }
    
    // Methods
    public static float get_innerAimDifference()
    {
        float val_3;
        int val_4;
        var val_6 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_2 = DataStructs.UserDataDictionary.Settings.ControllerSensitivity;
        float val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {currentCryptoKey = val_4, hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4() {b1 = val_4, b2 = val_4, b3 = val_4, b4 = val_4}, hiddenValueOld = val_4, fakeValue = val_3, inited = val_3});
        float val_6 = 0.04f;
        val_6 = (float)UnityEngine.Screen.height * val_6;
        val_5 = val_5 + 1f;
        val_5 = val_6 * val_5;
        return (float)val_5;
    }
    public static float get_middleAimDifference()
    {
        float val_3;
        int val_4;
        var val_6 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_2 = DataStructs.UserDataDictionary.Settings.ControllerSensitivity;
        float val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {currentCryptoKey = val_4, hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4() {b1 = val_4, b2 = val_4, b3 = val_4, b4 = val_4}, hiddenValueOld = val_4, fakeValue = val_3, inited = val_3});
        float val_6 = 0.08f;
        val_6 = (float)UnityEngine.Screen.height * val_6;
        val_5 = val_5 + 1f;
        val_5 = val_6 * val_5;
        return (float)val_5;
    }
    public static float get_outerAimDifference()
    {
        float val_3;
        int val_4;
        var val_6 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_2 = DataStructs.UserDataDictionary.Settings.ControllerSensitivity;
        float val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {currentCryptoKey = val_4, hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4() {b1 = val_4, b2 = val_4, b3 = val_4, b4 = val_4}, hiddenValueOld = val_4, fakeValue = val_3, inited = val_3});
        float val_6 = 0.12f;
        val_6 = (float)UnityEngine.Screen.height * val_6;
        val_5 = val_5 + 1f;
        val_5 = val_6 * val_5;
        return (float)val_5;
    }
    public static float BallEntryIdToAimLineMoveDifferentY(int entry)
    {
        if(((UnityEngine.Mathf.Clamp(value:  entry, min:  0, max:  6)) - 1) > 5)
        {
                return (float);
        }
        
        var val_19 = 40825816 + ((val_1 - 1)) << 2;
        val_19 = val_19 + 40825816;
        goto (40825816 + ((val_1 - 1)) << 2 + 40825816);
    }
    private void Start()
    {
        GlobalInfo.Refresh();
    }
    public static void Refresh()
    {
        var val_1;
        UnityEngine.Debug.Log(message:  "Refreshing Global Info for phone");
        val_1 = null;
        val_1 = null;
        InstanceAnimator.UniversalX = 4.46f;
        GlobalInfo.MIN_CONTROL_SENSITIVE = 11.2f;
        GlobalInfo.ballMiddleEntryAngle = 18.1f;
        GlobalInfo.ballOuterEntryAngle = 25.4f;
        GlobalInfo.aimInnerAngle = 11f;
        GlobalInfo.aimMiddleAngle = 18f;
        GlobalInfo.aimOuterAngle = 25f;
    }
    public GlobalInfo()
    {
    
    }

}
