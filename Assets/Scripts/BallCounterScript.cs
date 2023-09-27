using UnityEngine;
public class BallCounterScript : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject ballsUsed;
    public UnityEngine.GameObject maximumBalls;
    
    // Methods
    private void Start()
    {
        var val_10;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_10 = System.String.op_Equality(a:  val_1.m_Handle.name, b:  "DemoScene");
        if(val_10 != false)
        {
                if((this.maximumBalls.GetComponent<UnityEngine.UI.Text>()) != null)
        {
            goto label_6;
        }
        
        }
        else
        {
                val_10 = Character_GlobalInfo.stage_CurrentLevel + 2.ToString(format:  "D2");
        }
        
        label_6:
        string val_9 = 0.ToString(format:  "D2");
        if((this.ballsUsed.GetComponent<UnityEngine.UI.Text>()) != null)
        {
                return;
        }
    
    }
    public void BallCountUpdate()
    {
        var val_3 = null;
        LineController.instance.ballsUsed
        string val_2 = LineController.instance.ballsUsed.ToString(format:  "D2");
        if((this.ballsUsed.GetComponent<UnityEngine.UI.Text>()) == null)
        {
            
        }
    
    }
    public BallCounterScript()
    {
    
    }

}
