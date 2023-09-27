using UnityEngine;
[Serializable]
private sealed class MVC_Multiplayer_Manager_Base.<>c
{
    // Fields
    public static readonly InkWars.Model.MVC_Multiplayer_Manager_Base.<>c <>9;
    public static System.Action <>9__81_1;
    
    // Methods
    private static MVC_Multiplayer_Manager_Base.<>c()
    {
        MVC_Multiplayer_Manager_Base.<>c.<>9 = new MVC_Multiplayer_Manager_Base.<>c();
    }
    public MVC_Multiplayer_Manager_Base.<>c()
    {
    
    }
    internal void <ShutVSGateAndStartGame>b__81_1()
    {
        UnityEngine.Debug.Log(message:  "==== On Open done");
        InGameBGMController.SetupBGM();
    }

}
