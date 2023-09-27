using UnityEngine;
public class ReporterGUI : MonoBehaviour
{
    // Fields
    private Reporter reporter;
    
    // Methods
    private void Awake()
    {
        this.reporter = this.gameObject.GetComponent<Reporter>();
    }
    private void OnGUI()
    {
        this.reporter.OnGUIDraw();
    }
    public ReporterGUI()
    {
    
    }

}
