using UnityEngine;
public class CustomizationCanvasLoader : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button executer;
    
    // Methods
    private void LoadCustomizationCanvas()
    {
        CustomizationCanvas.Show();
    }
    private void OnEnable()
    {
        this.executer.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CustomizationCanvasLoader::LoadCustomizationCanvas()));
    }
    private void OnDisable()
    {
        this.executer.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CustomizationCanvasLoader::LoadCustomizationCanvas()));
    }
    public CustomizationCanvasLoader()
    {
    
    }

}
