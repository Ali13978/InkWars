using UnityEngine;
internal class ConnectionTestExecuter : MonoBehaviour
{
    // Methods
    private void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    public void StartTest(System.Action<bool, string> action)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.checkInternetConnection(action:  action));
    }
    private System.Collections.IEnumerator checkInternetConnection(System.Action<bool, string> action)
    {
        .<>1__state = 0;
        .action = action;
        return (System.Collections.IEnumerator)new ConnectionTestExecuter.<checkInternetConnection>d__2();
    }
    private System.Collections.IEnumerator checkInternetConnection(string[] urlList, System.Action<bool, string> action)
    {
        ConnectionTestExecuter.<checkInternetConnection>d__3 val_1 = new ConnectionTestExecuter.<checkInternetConnection>d__3();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .urlList = urlList;
        }
        else
        {
                mem[32] = urlList;
        }
        
        .action = action;
        return (System.Collections.IEnumerator)val_1;
    }
    public ConnectionTestExecuter()
    {
    
    }

}
