using UnityEngine;
public class SerializableDictionary<TKey, TValue, TValueStorage> : SerializableDictionaryBase<TKey, TValue, TValueStorage>
{
    // Methods
    public SerializableDictionary<TKey, TValue, TValueStorage>()
    {
        if(this == null)
        {
            
        }
    
    }
    public SerializableDictionary<TKey, TValue, TValueStorage>(System.Collections.Generic.IDictionary<TKey, TValue> dict)
    {
        if(this == null)
        {
            
        }
    
    }
    protected SerializableDictionary<TKey, TValue, TValueStorage>(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
    {
        if(this == null)
        {
            
        }
    
    }
    protected override TValue GetValue(TValueStorage[] storage, int i)
    {
        if(storage[(long)i] != 0)
        {
                return (object)storage[(long)(int)(i)][0] + 16;
        }
        
        return (object)storage[(long)(int)(i)][0] + 16;
    }
    protected override void SetValue(TValueStorage[] storage, int i, TValue value)
    {
        TValueStorage val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 40;
        storage[(long)i] = val_1;
        if(storage.Length <= i)
        {
                val_1 = mem[storage[(long)(int)(i)] + 32];
            val_1 = storage[(long)(int)(i)] + 32;
        }
        
        mem2[0] = value;
    }

}
