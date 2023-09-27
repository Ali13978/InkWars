using UnityEngine;
public class IWServerDB_Cache : MonoBehaviour
{
    // Fields
    private static IWServerDB_Cache _instance;
    public static UnityEngine.Events.UnityEvent OnHasSavedEvent;
    private static System.Collections.Generic.Dictionary<string, object> cache;
    private static System.Collections.Generic.Dictionary<string, object> cacheBackup;
    private static readonly object CacheLock;
    private static bool _enableSave;
    private static bool _enableAddToCache;
    public static bool isSaving;
    
    // Properties
    private static IWServerDB_Cache SaveExecutor { get; }
    public static bool IsSaveCacheEnabled { get; }
    
    // Methods
    private static IWServerDB_Cache get_SaveExecutor()
    {
        var val_4;
        IWServerDB_Cache val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        val_5 = IWServerDB_Cache._instance;
        if(0 != val_5)
        {
                return (IWServerDB_Cache)IWServerDB_Cache._instance;
        }
        
        val_6 = null;
        val_5 = new UnityEngine.GameObject(name:  "FirebaseDB_CacheSaver").AddComponent<IWServerDB_Cache>();
        val_6 = null;
        IWServerDB_Cache._instance = val_5;
        return (IWServerDB_Cache)IWServerDB_Cache._instance;
    }
    private void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
    }
    public static void AddToCache(string path, object data)
    {
        object val_5;
        var val_6;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        if(data == null)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  path)) == true)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(IWServerDB_Cache._enableAddToCache == false)
        {
                return;
        }
        
        val_5 = IWServerDB_Cache.CacheLock;
        bool val_2 = false;
        System.Threading.Monitor.Enter(obj:  val_5, lockTaken: ref  val_2);
        val_8 = null;
        val_8 = null;
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "Caching to update list {0}:{1}, SaveEnabled:{2}", arg0:  path, arg1:  data, arg2:  IWServerDB_Cache._enableSave));
        val_9 = null;
        if((IWServerDB_Cache.cache.ContainsKey(key:  path)) != false)
        {
                val_10 = null;
            IWServerDB_Cache.cache.set_Item(key:  path, value:  data);
        }
        else
        {
                val_11 = null;
            IWServerDB_Cache.cache.Add(key:  path, value:  data);
        }
        
        if(val_2 != 0)
        {
                System.Threading.Monitor.Exit(obj:  val_5);
        }
        
        val_12 = null;
        val_12 = null;
        if(IWServerDB_Cache._enableSave == false)
        {
                return;
        }
        
        IWServerDB_Cache.QueueSave();
    }
    public static void CleanCache()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  IWServerDB_Cache.CacheLock, lockTaken: ref  val_1);
        val_3 = null;
        val_3 = null;
        IWServerDB_Cache.cache.Clear();
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  IWServerDB_Cache.CacheLock);
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    private static void RestoreCache()
    {
        var val_5;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_10 = null;
        val_10 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  IWServerDB_Cache.CacheLock, lockTaken: ref  val_1);
        val_11 = null;
        val_11 = null;
        Dictionary.Enumerator<TKey, TValue> val_2 = IWServerDB_Cache.cacheBackup.GetEnumerator();
        label_14:
        if(((-2129935520) & 1) == 0)
        {
            goto label_6;
        }
        
        UnityEngine.Playables.PlayableHandle val_6 = val_5.GetHandle();
        val_12 = null;
        val_12 = null;
        if((IWServerDB_Cache.cache.ContainsKey(key:  val_6.m_Handle.ToInt64())) == true)
        {
            goto label_14;
        }
        
        val_13 = null;
        val_13 = null;
        IWServerDB_Cache.cache.set_Item(key:  val_6.m_Handle.ToInt64(), value:  val_6.m_Handle);
        goto label_14;
        label_6:
        val_14 = 0;
        val_5.Add(driver:  public System.Void Dictionary.Enumerator<System.String, System.Object>::Dispose(), rectTransform:  0, drivenProperties:  null);
        if( != 0)
        {
                val_14 = 0;
        }
        
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  IWServerDB_Cache.CacheLock);
        }
        
        if( == 0)
        {
                return;
        }
    
    }
    public static bool get_IsSaveCacheEnabled()
    {
        null = null;
        return (bool)IWServerDB_Cache._enableAddToCache;
    }
    public static void EnableSaveRoutine(bool enable)
    {
        null = null;
        bool val_1 = enable;
        IWServerDB_Cache._enableSave = val_1;
        if(val_1 != false)
        {
                return;
        }
        
        IWServerDB_Cache.SaveExecutor.CancelInvoke();
    }
    public static void EnableAddToCache(bool enable)
    {
        null = null;
        IWServerDB_Cache._enableAddToCache = enable;
    }
    private static void QueueSave()
    {
        IWServerDB_Cache.SaveExecutor.CancelInvoke();
        if(IWServerDB_Cache._enableSave == false)
        {
                return;
        }
        
        IWServerDB_Cache.SaveExecutor.Invoke(methodName:  "SaveCacheInternal", time:  0.5f);
    }
    public static void SaveCache(System.Action<bool, string> onResult)
    {
        object val_8;
        var val_21;
        var val_24;
        object val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_39;
        .onResult = onResult;
        val_21 = null;
        val_21 = null;
        if(IWServerDB_Cache.isSaving != false)
        {
                IWServerDB_Cache.QueueSave();
            return;
        }
        
        IWServerDB_Cache.isSaving = true;
        System.Collections.Generic.List<System.Object> val_2 = new System.Collections.Generic.List<System.Object>();
        val_24 = null;
        val_24 = null;
        val_25 = IWServerDB_Cache.CacheLock;
        bool val_3 = false;
        System.Threading.Monitor.Enter(obj:  val_25, lockTaken: ref  val_3);
        val_26 = null;
        val_26 = null;
        IWServerDB_Cache.cacheBackup.Clear();
        val_27 = null;
        if(IWServerDB_Cache.cache.Count == 0)
        {
            goto label_16;
        }
        
        val_28 = null;
        Dictionary.Enumerator<TKey, TValue> val_5 = IWServerDB_Cache.cache.GetEnumerator();
        label_26:
        val_29 = 1152921505088528384;
        if(((-2129267440) & 1) == 0)
        {
            goto label_20;
        }
        
        UnityEngine.Playables.PlayableHandle val_9 = val_8.GetHandle();
        new NFRequestUpdateRoleData() = new NFRequestUpdateRoleData();
        .path = val_9.m_Handle.ToInt64();
        .data = val_9.m_Handle;
        null.Add(item:  new NFRequestUpdateRoleData());
        val_30 = null;
        val_30 = null;
        IWServerDB_Cache.cacheBackup.Add(key:  val_9.m_Handle.ToInt64(), value:  val_9.m_Handle);
        goto label_26;
        label_16:
        val_31 = null;
        IWServerDB_Cache.isSaving = false;
        if(((IWServerDB_Cache.<>c__DisplayClass19_0)[1152921528247431552].onResult) != null)
        {
                (IWServerDB_Cache.<>c__DisplayClass19_0)[1152921528247431552].onResult.Invoke(arg1:  true, arg2:  "Cache is empty!!");
        }
        
        val_32 = 0;
        val_33 = 0;
        goto label_51;
        label_20:
        val_25 = val_25;
        val_34 = 0;
        val_35 = 0;
        val_8.Add(driver:  public System.Void Dictionary.Enumerator<System.String, System.Object>::Dispose(), rectTransform:  0, drivenProperties:  null);
        if( != 1)
        {
                var val_13 = (223 == 223) ? -1 : 0;
        }
        else
        {
                val_39 = 0;
        }
        
        IWServerDB_Cache.CleanCache();
        val_33 = 0;
        val_32 = 1;
        label_51:
        if(val_3 != 0)
        {
                System.Threading.Monitor.Exit(obj:  null);
        }
        
        if(val_32 != 1)
        {
                if(240 == 357)
        {
                return;
        }
        
        }
        
        UnityEngine.Debug.Log(message:  "trying to save...");
        val_25 = NFUser.current.clientUser;
        UnityEngine.Events.UnityAction<IResponse> val_17 = new UnityEngine.Events.UnityAction<IResponse>(object:  new IWServerDB_Cache.<>c__DisplayClass19_0(), method:  System.Void IWServerDB_Cache.<>c__DisplayClass19_0::<SaveCache>b__0(IResponse res));
        val_25.updateData(data:  null.ToArray(), callback:  null);
    }
    private void SaveCacheInternal()
    {
        var val_2;
        System.Action<System.Boolean, System.String> val_4;
        val_2 = null;
        val_2 = null;
        val_4 = IWServerDB_Cache.<>c.<>9__20_0;
        if(val_4 == null)
        {
                System.Action<System.Boolean, System.String> val_1 = null;
            val_4 = val_1;
            val_1 = new System.Action<System.Boolean, System.String>(object:  IWServerDB_Cache.<>c.__il2cppRuntimeField_static_fields, method:  System.Void IWServerDB_Cache.<>c::<SaveCacheInternal>b__20_0(bool success, string msg));
            IWServerDB_Cache.<>c.<>9__20_0 = val_4;
        }
        
        IWServerDB_Cache.SaveCache(onResult:  val_1);
    }
    private void OnApplicationPause(bool paused)
    {
        if(paused == false)
        {
                return;
        }
        
        IWServerDB_Cache.QueueSave();
    }
    private void OnApplicationFocus(bool focused)
    {
        if(focused != false)
        {
                return;
        }
        
        IWServerDB_Cache.QueueSave();
    }
    public IWServerDB_Cache()
    {
    
    }
    private static IWServerDB_Cache()
    {
        IWServerDB_Cache.OnHasSavedEvent = new UnityEngine.Events.UnityEvent();
        IWServerDB_Cache.cache = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        IWServerDB_Cache.cacheBackup = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        IWServerDB_Cache.CacheLock = new System.Object();
        IWServerDB_Cache._enableSave = true;
        IWServerDB_Cache._enableAddToCache = true;
        IWServerDB_Cache.isSaving = false;
    }

}
