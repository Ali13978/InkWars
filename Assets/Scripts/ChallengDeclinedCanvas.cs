using UnityEngine;
public class ChallengDeclinedCanvas : MonoBehaviour
{
    // Fields
    private UnityEngine.Canvas m_returnCanvas;
    private int m_waitingTime;
    private float waitedTime;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        float val_5;
        if(this.waitedTime < (float)this.m_waitingTime)
        {
                val_5 = this.waitedTime + UnityEngine.Time.deltaTime;
        }
        else
        {
                this.m_returnCanvas.gameObject.SetActive(value:  true);
            this.GetComponent<UnityEngine.Canvas>().gameObject.SetActive(value:  false);
            val_5 = 0f;
        }
        
        this.waitedTime = val_5;
    }
    public ChallengDeclinedCanvas()
    {
        this.m_waitingTime = 3;
    }

}
