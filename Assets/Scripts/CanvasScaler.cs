using UnityEngine;
public class CanvasScaler : MonoBehaviour
{
    // Methods
    private void OnEnable()
    {
        if(UnityEngine.Camera.main.aspect < 2f)
        {
                return;
        }
        
        this.GetComponent<UnityEngine.RectTransform>().localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this = this.transform;
        this.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public CanvasScaler()
    {
    
    }

}
