using UnityEngine;
public class RechargingAnimationScript : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject demoLineController;
    
    // Methods
    private void Start()
    {
        this.Invoke(methodName:  "RechargingAnimFunction", time:  0.2f);
    }
    private void RechargingAnimFunction()
    {
        this.demoLineController.GetComponent<InteractiveTutorialManager>().RechargingAnim();
    }
    public RechargingAnimationScript()
    {
    
    }

}
