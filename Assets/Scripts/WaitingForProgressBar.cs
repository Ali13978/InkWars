using UnityEngine;
public class WaitingForProgressBar : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Image m_waitingForProgress;
    private float m_deltaTime;
    public float TIME_GAP;
    private bool isFillRight;
    private float waitTime;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        float val_5;
        float val_7;
        val_5 = this.TIME_GAP;
        if(this.waitTime < val_5)
        {
                float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.waitTime + val_1;
            this.waitTime = val_1;
            return;
        }
        
        this.waitTime = 0f;
        if(this.m_waitingForProgress.fillAmount >= 1f)
        {
                val_5 = 0f;
            this.m_waitingForProgress.fillAmount = val_5;
        }
        
        if(this.m_waitingForProgress != null)
        {
                val_7 = this.m_waitingForProgress.fillAmount;
        }
        else
        {
                val_7 = 0.fillAmount;
        }
        
        float val_5 = 0.2f;
        val_5 = val_7 + val_5;
        this.m_waitingForProgress.fillAmount = val_5;
    }
    public WaitingForProgressBar()
    {
        this.TIME_GAP = 0.1f;
    }

}
