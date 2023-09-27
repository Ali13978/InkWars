using UnityEngine;
public class LoadingAvatarSizeFitter : MonoBehaviour
{
    // Methods
    private void OnEnable()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.AdjustSize());
    }
    private System.Collections.IEnumerator AdjustSize()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LoadingAvatarSizeFitter.<AdjustSize>d__1();
    }
    public LoadingAvatarSizeFitter()
    {
    
    }

}
