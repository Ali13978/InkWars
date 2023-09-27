using UnityEngine;
public class SampleInfo : MonoBehaviour
{
    // Methods
    private void OnGUI()
    {
        UnityEngine.GUILayout.Label(text:  "iTween can spin, shake, punch, move, handle audio, fade color and transparency \nand much more with each task needing only one line of code.", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Label(text:  "iTween works with C#, JavaScript and Boo. For full documentation and examples visit:", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        if((UnityEngine.GUILayout.Button(text:  "http://itween.pixelplacement.com", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
        {
                UnityEngine.Application.OpenURL(url:  "http://itween.pixelplacement.com");
        }
        
        UnityEngine.GUILayout.EndHorizontal();
    }
    public SampleInfo()
    {
    
    }

}
