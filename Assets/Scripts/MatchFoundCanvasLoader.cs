using UnityEngine;
public class MatchFoundCanvasLoader : MonoBehaviour
{
    // Fields
    private System.Action m_onComple;
    private UnityEngine.Canvas m_returnCanvas;
    private int m_waitingTime;
    private float waitedTime;
    private bool m_flag;
    private static MatchFoundCanvasLoader _instance;
    
    // Properties
    public static MatchFoundCanvasLoader Instance { get; }
    
    // Methods
    public static MatchFoundCanvasLoader get_Instance()
    {
        return (MatchFoundCanvasLoader)MatchFoundCanvasLoader._instance;
    }
    private void Awake()
    {
        if(MatchFoundCanvasLoader._instance != 0)
        {
                if(MatchFoundCanvasLoader._instance != this)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
            return;
        }
        
        }
        
        MatchFoundCanvasLoader._instance = this;
    }
    private void Start()
    {
    
    }
    private void Update()
    {
        float val_3;
        if(this.m_flag == false)
        {
                return;
        }
        
        if(this.waitedTime < (float)this.m_waitingTime)
        {
                val_3 = this.waitedTime + UnityEngine.Time.deltaTime;
        }
        else
        {
                this.m_returnCanvas.gameObject.SetActive(value:  true);
            if(this.m_onComple != null)
        {
                this.m_onComple.Invoke();
        }
        
            MatchFoundCanvas.Hide();
            val_3 = 0f;
        }
        
        this.waitedTime = val_3;
    }
    public MatchFoundCanvasLoader()
    {
        this.m_waitingTime = 3;
    }

}
