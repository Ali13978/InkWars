using UnityEngine;
public class ReporterMessageReceiver : MonoBehaviour
{
    // Fields
    private Reporter reporter;
    
    // Methods
    private void Start()
    {
        this.reporter = this.gameObject.GetComponent<Reporter>();
    }
    private void OnPreStart()
    {
        float val_6;
        if(this.reporter == 0)
        {
                this.reporter = this.gameObject.GetComponent<Reporter>();
        }
        
        if(UnityEngine.Screen.width <= 999)
        {
                val_6 = 32f;
        }
        else
        {
                val_6 = 48f;
        }
        
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_6, y:  val_6);
        this.reporter.size = val_5.x;
        mem2[0] = val_5.y;
        this.reporter.UserData = "Put user date here like his account to know which user is playing on this device";
    }
    private void OnHideReporter()
    {
    
    }
    private void OnShowReporter()
    {
    
    }
    private void OnLog(Reporter.Log log)
    {
    
    }
    public ReporterMessageReceiver()
    {
    
    }

}
