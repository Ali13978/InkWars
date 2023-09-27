using UnityEngine;
public class DebugInGamePanel : DynamicUISingleton<DebugInGamePanel>
{
    // Fields
    private UnityEngine.UI.Button drawBtn;
    private UnityEngine.UI.Button timeOutBtn;
    private UnityEngine.UI.Button leftWinBtn;
    private UnityEngine.UI.Button leftWinNoInkBtn;
    private UnityEngine.UI.Button leftFullSuperBtn;
    private UnityEngine.UI.Button leftStunnerBtn;
    private UnityEngine.UI.Button leftCannonBtn;
    private UnityEngine.UI.Button leftEraserBtn;
    private UnityEngine.UI.Button leftRainbowBtn;
    private UnityEngine.UI.Button leftVirusbowBtn;
    private UnityEngine.UI.Button leftRainbowTransformerBtn;
    private UnityEngine.UI.Button rightWinBtn;
    private UnityEngine.UI.Button rightWinNoInkBtn;
    private UnityEngine.UI.Button rightFullSuperBtn;
    private UnityEngine.UI.Button rightStunnerBtn;
    private UnityEngine.UI.Button rightCannonBtn;
    private UnityEngine.UI.Button rightEraserBtn;
    private UnityEngine.UI.Button rightRainbowBtn;
    private UnityEngine.UI.Button rightVirusbowBtn;
    private UnityEngine.UI.Button rightRainbowTransformerBtn;
    private UnityEngine.UI.Button fullInkProcBtn;
    
    // Methods
    private void Start()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public DebugInGamePanel()
    {
    
    }

}
