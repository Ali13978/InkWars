using UnityEngine;
public class MultiKeyDictionary<T1, T2, T3> : Dictionary<T1, System.Collections.Generic.Dictionary<T2, T3>>
{
    // Properties
    public System.Collections.Generic.Dictionary<T2, T3> Item { get; }
    
    // Methods
    public System.Collections.Generic.Dictionary<T2, T3> get_Item(T1 key)
    {
        if(this != null)
        {
                return 0;
        }
        
        return 0;
    }
    public bool ContainsKey(T1 key1, T2 key2)
    {
        var val_1 = 0;
        val_1 = val_1 & 1;
        return (bool)val_1;
    }
    public MultiKeyDictionary<T1, T2, T3>()
    {
        if(this == null)
        {
            
        }
    
    }

}
