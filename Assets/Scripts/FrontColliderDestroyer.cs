using UnityEngine;
public class FrontColliderDestroyer : MonoBehaviour
{
    // Methods
    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        null = null;
        if(LineController.ballEntry != 0)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  other.gameObject.name, b:  "RedPlayer(Clone)")) == false)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  other.gameObject);
    }
    public void BackButtonFunction()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "SceneLevelsMode");
    }
    public FrontColliderDestroyer()
    {
    
    }

}
