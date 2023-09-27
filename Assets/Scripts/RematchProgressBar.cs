using UnityEngine;
public class RematchProgressBar : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image m_progressBarImage;
    private TMPro.TextMeshProUGUI m_progressText;
    private int m_rangeMin;
    private int m_rangeMax;
    private bool m_isIncreasing;
    private bool stop;
    private System.Action m_compleationAction;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public void Stop()
    {
        this.stop = true;
    }
    public void StartProgress(System.Action _action)
    {
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        this.m_compleationAction = _action;
        this.stop = false;
        UnityEngine.Coroutine val_3 = this.StartCoroutine(methodName:  "ProgressTask");
    }
    private System.Collections.IEnumerator ProgressTask()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new RematchProgressBar.<ProgressTask>d__11();
    }
    public RematchProgressBar()
    {
        this.m_rangeMax = 5;
        this.m_isIncreasing = true;
    }

}
