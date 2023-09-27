using UnityEngine;
public class SerializableDictionary<TKey, TValue> : SerializableDictionaryBase<TKey, TValue, TValue>
{
    // Methods
    public SerializableDictionary<TKey, TValue>()
    {
        if(this == null)
        {
            
        }
    
    }
    public SerializableDictionary<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> dict)
    {
        if(this == null)
        {
            
        }
    
    }
    protected SerializableDictionary<TKey, TValue>(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
    {
        if(this == null)
        {
            
        }
    
    }
    protected override TValue GetValue(TValue[] storage, int i)
    {
        return (InkWars.Model.SortingLayerOrder)storage[((long)(int)(i)) << 2];
    }
    protected override void SetValue(TValue[] storage, int i, TValue value)
    {
        storage[((long)(int)(i)) << 2] = value;
    }

}
