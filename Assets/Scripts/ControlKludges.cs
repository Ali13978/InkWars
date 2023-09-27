using UnityEngine;
public class ControlKludges : MonoBehaviour
{
    // Fields
    public bool VsScene;
    private UnityEngine.UI.Button BallChanger;
    private UnityEngine.UI.Button BallChanger2;
    
    // Properties
    public static UnityEngine.Touch[] Touches { get; }
    
    // Methods
    public static UnityEngine.Touch[] get_Touches()
    {
        return UnityEngine.Input.touches;
    }
    public void Update()
    {
        bool val_1 = UnityEngine.Object.op_Equality(x:  this.BallChanger, y:  0);
        if(val_1 != false)
        {
                UnityEngine.UI.Button val_2 = val_1.findButton(name:  "Ball_Change_Button");
            this.BallChanger = val_2;
            if(val_2 == 0)
        {
                return;
        }
        
        }
        
        if((UnityEngine.Input.GetMouseButtonDown(button:  1)) == false)
        {
                return;
        }
        
        this.BallChanger.onClick.Invoke();
    }
    private UnityEngine.UI.Button findButton(string name)
    {
        var val_4;
        UnityEngine.GameObject val_1 = UnityEngine.GameObject.Find(name:  name);
        val_4 = 0;
        if(val_1 == 0)
        {
                return (UnityEngine.UI.Button)val_1.GetComponent<UnityEngine.UI.Button>();
        }
        
        return (UnityEngine.UI.Button)val_1.GetComponent<UnityEngine.UI.Button>();
    }
    public ControlKludges()
    {
    
    }

}
