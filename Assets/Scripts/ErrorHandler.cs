using UnityEngine;
public class ErrorHandler : MonoBehaviour
{
    // Fields
    public string PostURL;
    public bool ReportException;
    public bool ReportError;
    public bool ReportAssert;
    public bool ReportWarning;
    public static ErrorHandler instance;
    public static bool LogInProgress;
    
    // Methods
    private void Start()
    {
        if(ErrorHandler.instance != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
            return;
        }
        
        ErrorHandler.instance = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    private void OnEnable()
    {
        UnityEngine.Application.add_logMessageReceived(value:  new Application.LogCallback(object:  this, method:  System.Void ErrorHandler::Application_logMessageReceived(string logMessage, string stackTrace, UnityEngine.LogType type)));
    }
    private void OnDisable()
    {
        UnityEngine.Application.remove_logMessageReceived(value:  new Application.LogCallback(object:  this, method:  System.Void ErrorHandler::Application_logMessageReceived(string logMessage, string stackTrace, UnityEngine.LogType type)));
    }
    private void Application_logMessageReceived(string logMessage, string stackTrace, UnityEngine.LogType type)
    {
        if(type <= 4)
        {
                var val_4 = 40827768 + (type) << 2;
            val_4 = val_4 + 40827768;
        }
        else
        {
                System.Byte[] val_1 = ErrorHandlerMessage.Generate(logMessage:  logMessage, stackTrace:  stackTrace, logType:  type);
            if(val_1 == null)
        {
                return;
        }
        
            if(ErrorHandler.LogInProgress != false)
        {
                return;
        }
        
            ErrorHandler.LogInProgress = true;
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.PostBytes(data:  val_1));
        }
    
    }
    private System.Collections.IEnumerator PostBytes(byte[] data)
    {
        ErrorHandler.<PostBytes>d__11 val_1 = new ErrorHandler.<PostBytes>d__11();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .data = data;
        return (System.Collections.IEnumerator)val_1;
    }
    public ErrorHandler()
    {
    
    }

}
