using UnityEngine;
public static class ConnectionTester
{
    // Fields
    private static string[] urlList;
    private static ConnectionTestExecuter executer;
    
    // Methods
    public static void TestConnection(System.Action<bool, string> callback)
    {
        var val_8;
        var val_9;
        .callback = callback;
        val_8 = null;
        val_8 = null;
        if(0 != ConnectionTester.executer)
        {
                if(((ConnectionTester.<>c__DisplayClass2_0)[1152921526435640096].callback) == null)
        {
                return;
        }
        
            (ConnectionTester.<>c__DisplayClass2_0)[1152921526435640096].callback.Invoke(arg1:  false, arg2:  "An existing test is running.");
            return;
        }
        
        val_9 = null;
        val_9 = null;
        ConnectionTester.executer = new UnityEngine.GameObject(name:  "NetworkTester").AddComponent<ConnectionTestExecuter>();
        UnityEngine.Coroutine val_7 = ConnectionTester.executer.StartCoroutine(routine:  0.checkInternetConnection(action:  new System.Action<System.Boolean, System.String>(object:  new ConnectionTester.<>c__DisplayClass2_0(), method:  System.Void ConnectionTester.<>c__DisplayClass2_0::<TestConnection>b__0(bool connected, string error))));
    }
    private static ConnectionTester()
    {
        string[] val_1 = new string[2];
        val_1[0] = "http://www.google.com";
        val_1[1] = "http://www.inkwarsgame.com";
        ConnectionTester.urlList = val_1;
    }

}
