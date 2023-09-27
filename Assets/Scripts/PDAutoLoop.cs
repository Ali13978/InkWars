using UnityEngine;
public class PDAutoLoop : MonoBehaviour
{
    // Methods
    private void Start()
    {
        this.Invoke(methodName:  "EnableLoop", time:  2f);
    }
    private void EnableLoop()
    {
        UnityEngine.Debug.Log(message:  "Emmitter found: "("Emmitter found: ") + UnityEngine.Object.op_Inequality(x:  this.GetComponentInChildren<SeventyOneSquared.PDUnity>(), y:  0).ToString()(UnityEngine.Object.op_Inequality(x:  this.GetComponentInChildren<SeventyOneSquared.PDUnity>(), y:  0).ToString()));
        SeventyOneSquared.PDUnity val_6 = this.GetComponentInChildren<SeventyOneSquared.PDUnity>();
        val_6.AutoLoop = true;
    }
    public PDAutoLoop()
    {
    
    }

}
