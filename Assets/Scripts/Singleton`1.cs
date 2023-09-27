using UnityEngine;
public class Singleton<T> : MonoBehaviour
{
    // Fields
    private static T _instance;
    private static object _lock;
    private static bool applicationIsQuitting;
    
    // Properties
    public static T Instance { get; }
    
    // Methods
    public static T get_Instance()
    {
        var val_12;
        object val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        val_12 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_12 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_12 & 1) == 0)
        {
                val_12 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_12 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        val_13 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_13 = __RuntimeMethodHiddenParam + 24 + 192;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 16) != 0)
        {
                val_14 = 0;
            return (object)val_14;
        }
        
        val_15 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_15 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_15 & 1) == 0)
        {
                val_15 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_15 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        val_13 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 184 + 8];
        val_13 = __RuntimeMethodHiddenParam + 24 + 192 + 184 + 8;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  val_13, lockTaken: ref  val_1);
        val_16 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_16 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_16 & 1) == 0)
        {
                val_16 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_16 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184) != 0)
        {
            goto label_70;
        }
        
        UnityEngine.Object val_4 = UnityEngine.Object.FindObjectOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16}));
        val_17 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_17 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_17 & 1) == 0)
        {
                val_17 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_17 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        val_18 = mem[__RuntimeMethodHiddenParam + 24];
        val_18 = __RuntimeMethodHiddenParam + 24;
        if(val_4 == null)
        {
            goto label_53;
        }
        
        val_19 = val_4;
        if(val_19 != null)
        {
            goto label_54;
        }
        
        label_53:
        val_19 = 0;
        label_54:
        mem2[0] = val_19;
        UnityEngine.Object[] val_7 = UnityEngine.Object.FindObjectsOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16}));
        if(val_7.Length >= 2)
        {
            goto label_57;
        }
        
        val_20 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_20 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_20 & 1) == 0)
        {
                val_20 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_20 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184) == 0)
        {
                new UnityEngine.GameObject() = new UnityEngine.GameObject();
            val_21 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_21 = __RuntimeMethodHiddenParam + 24 + 294;
            val_22 = __RuntimeMethodHiddenParam + 24;
            if((val_21 & 1) == 0)
        {
                val_22 = mem[__RuntimeMethodHiddenParam + 24];
            val_22 = __RuntimeMethodHiddenParam + 24;
            val_21 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_21 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
            val_23 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_23 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_23 & 1) == 0)
        {
                val_23 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_23 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
            val_18 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_18 = __RuntimeMethodHiddenParam + 24 + 192;
            mem2[0] = new UnityEngine.GameObject();
            new UnityEngine.GameObject().name = "(singleton) " + System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16})(System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16}));
            UnityEngine.Object.DontDestroyOnLoad(target:  new UnityEngine.GameObject());
        }
        
        label_70:
        val_24 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_24 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_24 & 1) == 0)
        {
                val_24 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_24 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        val_25 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_25 = __RuntimeMethodHiddenParam + 24 + 192;
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 294) & 1) != 0)
        {
            goto label_111;
        }
        
        goto label_111;
        label_57:
        val_26 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_26 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_26 & 1) == 0)
        {
                val_26 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_26 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        val_25 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_25 = __RuntimeMethodHiddenParam + 24 + 192;
        label_111:
        val_14 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 184];
        val_14 = __RuntimeMethodHiddenParam + 24 + 192 + 184;
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  val_13);
        }
        
        if(0 == 0)
        {
                return (object)val_14;
        }
        
        return (object)val_14;
    }
    public void OnDestroy()
    {
        var val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_1 & 1) == 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        mem2[0] = 1;
    }
    public Singleton<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    private static Singleton<T>()
    {
        mem2[0] = new System.Object();
        mem2[0] = 0;
    }

}
