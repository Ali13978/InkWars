using UnityEngine;
public static class iTween.Defaults
{
    // Fields
    public static float time;
    public static float delay;
    public static iTween.NamedValueColor namedColorValue;
    public static iTween.LoopType loopType;
    public static iTween.EaseType easeType;
    public static float lookSpeed;
    public static bool isLocal;
    public static UnityEngine.Space space;
    public static bool orientToPath;
    public static UnityEngine.Color color;
    public static float updateTimePercentage;
    public static float updateTime;
    public static int cameraFadeDepth;
    public static float lookAhead;
    public static bool useRealTime;
    public static UnityEngine.Vector3 up;
    
    // Methods
    private static iTween.Defaults()
    {
        iTween.Defaults.time = 1f;
        iTween.Defaults.delay = 0f;
        iTween.Defaults.namedColorValue = 0;
        iTween.Defaults.loopType = 0;
        iTween.Defaults.easeType = 16;
        iTween.Defaults.lookSpeed = 3f;
        iTween.Defaults.isLocal = false;
        iTween.Defaults.space = 1;
        iTween.Defaults.orientToPath = false;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        iTween.Defaults.color = val_1.r;
        iTween.Defaults.time.__il2cppRuntimeField_28 = val_1.g;
        iTween.Defaults.time.__il2cppRuntimeField_2C = val_1.b;
        iTween.Defaults.time.__il2cppRuntimeField_30 = val_1.a;
        iTween.Defaults.updateTimePercentage = 0.05f;
        iTween.Defaults.updateTime = iTween.Defaults.updateTimePercentage;
        iTween.Defaults.cameraFadeDepth = 999999;
        iTween.Defaults.lookAhead = 0.05f;
        iTween.Defaults.useRealTime = false;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        iTween.Defaults.up = val_2.x;
        iTween.Defaults.time.__il2cppRuntimeField_4C = val_2.y;
        iTween.Defaults.time.__il2cppRuntimeField_50 = val_2.z;
    }

}
