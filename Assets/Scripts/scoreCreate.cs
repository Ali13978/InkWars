using UnityEngine;
public class scoreCreate : MonoBehaviour
{
    // Fields
    public float ScoreCount;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
                return;
        }
        
        float val_8 = this.ScoreCount;
        float val_2 = UnityEngine.Time.time;
        val_2 = val_2 / 10f;
        val_8 = val_8 + val_2;
        this.ScoreCount = val_8;
        this.ScoreCount = (float)UnityEngine.Mathf.CeilToInt(f:  val_8);
        UnityEngine.UI.Text val_5 = UnityEngine.GameObject.Find(name:  "Text_ScoreCount").GetComponent<UnityEngine.UI.Text>();
        string val_6 = this.ScoreCount.ToString();
        UnityEngine.MonoBehaviour.print(message:  "timer" + this.ScoreCount);
    }
    public scoreCreate()
    {
        this.ScoreCount = 100f;
    }

}
