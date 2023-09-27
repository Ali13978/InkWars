using UnityEngine;
public class DisplayScore : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text score;
    
    // Methods
    private void Start()
    {
        null = null;
        if(Character_GlobalInfo.gameMode == 4)
        {
                UnityEngine.Color val_3 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            this.gameObject.GetComponent<UnityEngine.UI.Text>().color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        }
        
        this.score = this.gameObject.GetComponent<UnityEngine.UI.Text>();
        this.InvokeRepeating(methodName:  "UpdateScore", time:  0f, repeatRate:  0.2f);
    }
    private void UpdateScore()
    {
        null = null;
        string val_1 = ToString(format:  "D6");
        if(this.score == null)
        {
            
        }
    
    }
    public DisplayScore()
    {
    
    }

}
