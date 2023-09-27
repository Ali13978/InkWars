using UnityEngine;
public class ActiveCanvasSetter : MonoBehaviour
{
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    private void OnEnable()
    {
        ActiveCanvasController.ActiveCanvas = this.GetComponent<UnityEngine.Canvas>().name;
    }
    public ActiveCanvasSetter()
    {
    
    }

}
