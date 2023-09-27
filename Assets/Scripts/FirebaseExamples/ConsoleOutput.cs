using UnityEngine;

namespace FirebaseExamples
{
    public class ConsoleOutput : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text text;
        private System.Collections.Concurrent.ConcurrentQueue<string> myLogQueue;
        
        // Methods
        private void Start()
        {
            if(this.text == null)
            {
                
            }
        
        }
        public void log(string s)
        {
            string val_12;
            var val_13;
            var val_14;
            val_12 = s;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.text, lockTaken: ref  val_1);
            if((this.text.Length + val_12.Length) < 65001)
            {
                goto label_4;
            }
            
            if(val_12.Length >= 500)
            {
                goto label_6;
            }
            
            val_13 = val_12.Length;
            if(val_12 != null)
            {
                goto label_10;
            }
            
            goto label_9;
            label_6:
            val_13 = 500;
            if(val_12 != null)
            {
                goto label_10;
            }
            
            label_9:
            label_10:
            val_12 = val_12.Substring(startIndex:  0, length:  244)(val_12.Substring(startIndex:  0, length:  244)) + " : [Too Long! Truncated]"(" : [Too Long! Truncated]");
            label_4:
            string val_9 = this.text + "\n" + val_12;
            val_14 = this.text;
            if(val_14.Length >= 7001)
            {
                    val_14 = this.text;
                string val_11 = val_14.Substring(startIndex:  160);
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.text);
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        private void OnEnable()
        {
            UnityEngine.Application.add_logMessageReceivedThreaded(value:  new Application.LogCallback(object:  this, method:  System.Void FirebaseExamples.ConsoleOutput::HandleLog(string logString, string stackTrace, UnityEngine.LogType type)));
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.LogRunner());
        }
        private void OnDisable()
        {
            UnityEngine.Application.remove_logMessageReceivedThreaded(value:  new Application.LogCallback(object:  this, method:  System.Void FirebaseExamples.ConsoleOutput::HandleLog(string logString, string stackTrace, UnityEngine.LogType type)));
            this.StopCoroutine(routine:  this.LogRunner());
        }
        private System.Collections.IEnumerator LogRunner()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new ConsoleOutput.<LogRunner>d__6();
        }
        private void HandleLog(string logString, string stackTrace, UnityEngine.LogType type)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(logString != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(logString == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = logString;
            val_1[1] = " : [";
            val_1[2] = type;
            val_1[3] = "]";
            this.myLogQueue.Enqueue(item:  +val_1);
            if(type != 4)
            {
                    return;
            }
            
            this = "\n" + stackTrace;
            this.myLogQueue.Enqueue(item:  this);
        }
        public ConsoleOutput()
        {
            this.myLogQueue = new System.Collections.Concurrent.ConcurrentQueue<System.String>();
        }
    
    }

}
