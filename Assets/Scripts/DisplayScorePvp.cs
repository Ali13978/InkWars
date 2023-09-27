using UnityEngine;
public class DisplayScorePvp : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text score;
    
    // Methods
    private void Start()
    {
        var val_3;
        UnityEngine.PlayerPrefs.SetInt(key:  "Score2", value:  0);
        val_3 = null;
        val_3 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
                return;
        }
        
        this.score = this.gameObject.GetComponent<UnityEngine.UI.Text>();
        this.InvokeRepeating(methodName:  "UpdateScore", time:  0f, repeatRate:  0.2f);
    }
    private void UpdateScore()
    {
        UnityEngine.UI.Text val_3;
        var val_4;
        val_3 = this;
        val_4 = null;
        val_4 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
                return;
        }
        
        val_3 = this.score;
        string val_2 = UnityEngine.PlayerPrefs.GetInt(key:  "Score2").ToString(format:  "D6");
    }
    public DisplayScorePvp()
    {
    
    }

}
