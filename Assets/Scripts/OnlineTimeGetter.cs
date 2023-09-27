using UnityEngine;
public class OnlineTimeGetter : MonoBehaviour
{
    // Methods
    private void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    public void GetOnlineTime(IOnlineTimeParser[] parserList, UnityEngine.Events.UnityAction<string> callback)
    {
        if(callback == null)
        {
                return;
        }
        
        if(parserList == null)
        {
                callback.Invoke(arg0:  0);
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  callback.GetTime(parserList:  parserList, callback:  callback));
    }
    private System.Collections.IEnumerator GetTime(IOnlineTimeParser[] parserList, UnityEngine.Events.UnityAction<string> callback)
    {
        OnlineTimeGetter.<GetTime>d__2 val_1 = new OnlineTimeGetter.<GetTime>d__2();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .parserList = parserList;
        }
        else
        {
                mem[32] = parserList;
        }
        
        .callback = callback;
        return (System.Collections.IEnumerator)val_1;
    }
    public void DestroyGameObject()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public OnlineTimeGetter()
    {
    
    }

}
