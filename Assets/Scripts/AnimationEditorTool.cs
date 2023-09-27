using UnityEngine;
public class AnimationEditorTool : MonoBehaviour
{
    // Fields
    public AnimationPreviewer animPreview;
    public UnityEngine.UI.Text animationHeaderBody;
    public UnityEngine.UI.Dropdown DD_FrameEnd;
    public System.Collections.Generic.List<UnityEngine.UI.InputField> IF_TimeBody;
    public UnityEngine.UI.Text animationHeaderFX;
    public UnityEngine.UI.Dropdown DD_StartIndexFX;
    public System.Collections.Generic.List<UnityEngine.UI.InputField> IF_TimeFX;
    public UnityEngine.UI.Text invalidFloatError;
    public UnityEngine.UI.Text noAnimationFile;
    
    // Methods
    public AnimationEditorTool()
    {
    
    }

}
