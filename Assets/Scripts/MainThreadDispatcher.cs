using UnityEngine;
public class MainThreadDispatcher : MonoBehaviour
{
    // Fields
    private static MainThreadDispatcher _inst;
    private System.Collections.Generic.List<MainThreadDispatcher.TimerTask> taskList;
    
    // Properties
    private static MainThreadDispatcher inst { get; }
    
    // Methods
    private static MainThreadDispatcher get_inst()
    {
        MainThreadDispatcher val_4 = MainThreadDispatcher._inst;
        if(0 != val_4)
        {
                return (MainThreadDispatcher)MainThreadDispatcher._inst;
        }
        
        UnityEngine.GameObject val_2 = null;
        val_4 = val_2;
        val_2 = new UnityEngine.GameObject(name:  "MainThreadDispather");
        MainThreadDispatcher._inst = val_2.AddComponent<MainThreadDispatcher>();
        UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
        return (MainThreadDispatcher)MainThreadDispatcher._inst;
    }
    public static void Init()
    {
        MainThreadDispatcher val_1 = MainThreadDispatcher.inst;
    }
    public static void Invoke(System.Action action, float delay = 0)
    {
        if(action == null)
        {
                return;
        }
        
        MainThreadDispatcher val_1 = MainThreadDispatcher.inst;
        MainThreadDispatcher.TimerTask val_2 = null;
        .interval = 9999f;
        val_2 = new MainThreadDispatcher.TimerTask();
        .delay = delay;
        .action = action;
        val_1.taskList.Add(item:  val_2);
    }
    public static void InvokeRepeat(string key, System.Action action, float interval, float delay = 0)
    {
        if(action == null)
        {
                return;
        }
        
        MainThreadDispatcher val_1 = MainThreadDispatcher.inst;
        MainThreadDispatcher.TimerTask val_2 = null;
        .interval = 9999f;
        val_2 = new MainThreadDispatcher.TimerTask();
        .delay = delay;
        .action = action;
        .key = key;
        .repeat = true;
        .interval = interval;
        val_1.taskList.Add(item:  val_2);
    }
    public static void StopRepeat(string key)
    {
        .key = key;
        MainThreadDispatcher val_2 = MainThreadDispatcher.inst;
        int val_4 = val_2.taskList.RemoveAll(match:  new System.Predicate<TimerTask>(object:  new MainThreadDispatcher.<>c__DisplayClass6_0(), method:  System.Boolean MainThreadDispatcher.<>c__DisplayClass6_0::<StopRepeat>b__0(MainThreadDispatcher.TimerTask x)));
    }
    private void Update()
    {
        var val_5;
        System.RuntimeTypeHandle val_10;
        var val_11;
        UnityEngine.RectTransform val_15;
        System.Collections.Generic.List<TimerTask> val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        bool val_1 = false;
        val_15 = 0;
        System.Threading.Monitor.Enter(obj:  this.taskList, lockTaken: ref  val_1);
        val_16 = null;
        val_16 = new System.Collections.Generic.List<TimerTask>();
        List.Enumerator<T> val_3 = this.taskList.GetEnumerator();
        label_6:
        if((363427056 & 1) == 0)
        {
            goto label_2;
        }
        
        float val_7 = UnityEngine.Time.deltaTime;
        val_7 = val_6._impl - val_7;
        val_6._impl = val_7;
        if(val_7 > 0f)
        {
            goto label_6;
        }
        
        null.Add(item:  val_5.InitialType);
        goto label_6;
        label_2:
        val_17 = 0;
        val_18 = 0;
        val_5.Add(driver:  public System.Void List.Enumerator<TimerTask>::Dispose(), rectTransform:  val_15, drivenProperties:  null);
        if( != 0)
        {
                val_15 = 0;
        }
        
        if( == 1)
        {
            goto label_16;
        }
        
        val_19 = 1 - ((112 == 112) ? 1 : 0);
        if(val_16 != null)
        {
            goto label_19;
        }
        
        goto label_18;
        label_16:
        val_19 = 0;
        if(val_16 != null)
        {
            goto label_19;
        }
        
        label_18:
        label_19:
        List.Enumerator<T> val_9 = null.GetEnumerator();
        label_27:
        if((363427056 & 1) == 0)
        {
            goto label_20;
        }
        
        Invoke();
        if(val_10 == 0)
        {
            goto label_24;
        }
        
        val_12._impl = val_10;
        goto label_27;
        label_24:
        bool val_13 = this.taskList.Remove(item:  val_11.InitialType);
        goto label_27;
        label_20:
        val_20 = 0;
        val_11.Add(driver:  public System.Void List.Enumerator<TimerTask>::Dispose(), rectTransform:  public System.Boolean System.Collections.Generic.List<TimerTask>::Remove(TimerTask item), drivenProperties:  null);
        if( != false)
        {
                val_20 = 0;
        }
        
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  this.taskList);
        }
        
        if( == 0)
        {
                return;
        }
    
    }
    public MainThreadDispatcher()
    {
        this.taskList = new System.Collections.Generic.List<TimerTask>();
    }

}
