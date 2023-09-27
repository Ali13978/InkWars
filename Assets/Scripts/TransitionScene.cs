using UnityEngine;
public class TransitionScene : MonoBehaviour
{
    // Fields
    private bool loadScene;
    
    // Methods
    private void Start()
    {
        this.loadScene = true;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.LoadNewScene());
    }
    private System.Collections.IEnumerator LoadNewScene()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new TransitionScene.<LoadNewScene>d__2();
    }
    public TransitionScene()
    {
    
    }

}
