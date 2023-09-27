using UnityEngine;
[Serializable]
public abstract class SerializableDictionaryBase<TKey, TValue, TValueStorage> : SerializableDictionaryBase, IDictionary<TKey, TValue>, ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, ISerializationCallbackReceiver, IDeserializationCallback, ISerializable
{
    // Fields
    private SerializableDictionaryBase.Dictionary<TKey, TValue> m_dict;
    private TKey[] m_keys;
    private TValueStorage[] m_values;
    
    // Properties
    public System.Collections.Generic.ICollection<TKey> Keys { get; }
    public System.Collections.Generic.ICollection<TValue> Values { get; }
    public int Count { get; }
    public bool IsReadOnly { get; }
    public TValue Item { get; set; }
    public bool IsFixedSize { get; }
    private System.Collections.ICollection System.Collections.IDictionary.Keys { get; }
    private System.Collections.ICollection System.Collections.IDictionary.Values { get; }
    public bool IsSynchronized { get; }
    public object SyncRoot { get; }
    public object Item { get; set; }
    
    // Methods
    public SerializableDictionaryBase<TKey, TValue, TValueStorage>()
    {
        mem[1152921526447535728] = __RuntimeMethodHiddenParam + 24 + 192;
    }
    public SerializableDictionaryBase<TKey, TValue, TValueStorage>(System.Collections.Generic.IDictionary<TKey, TValue> dict)
    {
        mem[1152921526447651824] = __RuntimeMethodHiddenParam + 24 + 192;
    }
    protected abstract void SetValue(TValueStorage[] storage, int i, TValue value); // 0
    protected abstract TValue GetValue(TValueStorage[] storage, int i); // 0
    public void CopyFrom(System.Collections.Generic.IDictionary<TKey, TValue> dict)
    {
        var val_6;
        var val_9;
        var val_11;
        val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 24];
        val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 32;
        label_21:
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_9 = public System.Boolean System.Collections.IEnumerator::MoveNext();
        if(dict.MoveNext() == false)
        {
            goto label_13;
        }
        
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_9 = __RuntimeMethodHiddenParam + 24 + 192 + 40;
        int val_5 = dict.GetHashCode();
        if((__RuntimeMethodHiddenParam + 24 + 192 + 40) != 0)
        {
            goto label_21;
        }
        
        goto label_21;
        label_13:
        val_11 = 0;
        if(dict == null)
        {
            
        }
        else
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            dict.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public void OnAfterDeserialize()
    {
        var val_3;
        if(X8 == 0)
        {
                return;
        }
        
        if(X9 == 0)
        {
                return;
        }
        
        if((X8 + 24) != (X9 + 24))
        {
                return;
        }
        
        if((X21 + 24) >= 1)
        {
                do
        {
            var val_2 = X23 + 0;
            val_3 = 0 + 1;
        }
        while(((X21 + 24) & 4294967295) != val_3);
        
        }
        
        mem[1152921526447892280] = 0;
        mem[1152921526447892288] = 0;
    }
    public void OnBeforeSerialize()
    {
        var val_1;
        var val_2;
        var val_8;
        var val_9;
        mem[1152921527307128008] = __RuntimeMethodHiddenParam + 24 + 192 + 88;
        mem[1152921527307128016] = __RuntimeMethodHiddenParam + 24 + 192 + 96;
        goto label_5;
        label_8:
        var val_5 = X23 + 0;
        mem2[0] = val_1.InitialType.GetHashCode();
        label_5:
        if((1225432432 & 1) != 0)
        {
            goto label_8;
        }
        
        val_8 = 0;
        val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 136;
        val_2 = val_1;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 136 + 286) == 0)
        {
            goto label_16;
        }
        
        var val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 136 + 176;
        var val_8 = 0;
        val_7 = val_7 + 8;
        label_18:
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 136 + 176 + 8) + -8) == null)
        {
            goto label_17;
        }
        
        val_8 = val_8 + 1;
        val_7 = val_7 + 16;
        if(val_8 < (__RuntimeMethodHiddenParam + 24 + 192 + 136 + 286))
        {
            goto label_18;
        }
        
        label_16:
        goto label_19;
        label_17:
        val_9 = ((__RuntimeMethodHiddenParam + 24 + 192 + 136) + (((__RuntimeMethodHiddenParam + 24 + 192 + 136 + 176 + 8)) << 4)) + 296;
        label_19:
        val_1.Dispose();
        if( == 0)
        {
                return;
        }
    
    }
    public System.Collections.Generic.ICollection<TKey> get_Keys()
    {
        var val_2;
        var val_4 = X19;
        if((X19 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 2);
        }
        
        var val_1 = X19 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X19 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 144))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X19 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 2);
        label_3:
        var val_3 = val_1;
        val_3 = val_3 + 2;
        val_4 = val_4 + val_3;
        val_2 = val_4 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 2);
    }
    public System.Collections.Generic.ICollection<TValue> get_Values()
    {
        var val_2;
        var val_4 = X19;
        if((X19 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 3);
        }
        
        var val_1 = X19 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X19 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 144))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X19 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 3);
        label_3:
        var val_3 = val_1;
        val_3 = val_3 + 3;
        val_4 = val_4 + val_3;
        val_2 = val_4 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 3);
    }
    public int get_Count()
    {
        var val_2;
        var val_3 = X19;
        if((X19 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 0);
        }
        
        var val_1 = X19 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X19 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 152))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X19 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 0);
        label_3:
        val_3 = val_3 + (((X19 + 176 + 8)) << 4);
        val_2 = val_3 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 0);
    }
    public bool get_IsReadOnly()
    {
        var val_2;
        var val_4 = X19;
        if((X19 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 1);
        }
        
        var val_1 = X19 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X19 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 152))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X19 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 1);
        label_3:
        var val_3 = val_1;
        val_3 = val_3 + 1;
        val_4 = val_4 + val_3;
        val_2 = val_4 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 1);
    }
    public TValue get_Item(TKey key)
    {
        var val_2;
        var val_3 = X20;
        if((X20 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 0);
        }
        
        var val_1 = X20 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X20 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 144))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X20 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 0);
        label_3:
        val_3 = val_3 + (((X20 + 176 + 8)) << 4);
        val_2 = val_3 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 0);
    }
    public void set_Item(TKey key, TValue value)
    {
        var val_2;
        var val_4 = X21;
        if((X21 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 1);
        }
        
        var val_1 = X21 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X21 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 144))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X21 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 1);
        label_3:
        var val_3 = val_1;
        val_3 = val_3 + 1;
        val_4 = val_4 + val_3;
        val_2 = val_4 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 1);
    }
    public void Add(TKey key, TValue value)
    {
        var val_2;
        var val_4 = X21;
        if((X21 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 5);
        }
        
        var val_1 = X21 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X21 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 144))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X21 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 5);
        label_3:
        var val_3 = val_1;
        val_3 = val_3 + 5;
        val_4 = val_4 + val_3;
        val_2 = val_4 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 5);
    }
    public bool ContainsKey(TKey key)
    {
        var val_2;
        var val_4 = X20;
        if((X20 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 4);
        }
        
        var val_1 = X20 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X20 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 144))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X20 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 4);
        label_3:
        var val_3 = val_1;
        val_3 = val_3 + 4;
        val_4 = val_4 + val_3;
        val_2 = val_4 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 4);
    }
    public bool Remove(TKey key)
    {
        var val_2;
        var val_4 = X20;
        if((X20 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 6);
        }
        
        var val_1 = X20 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X20 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 144))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X20 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 6);
        label_3:
        var val_3 = val_1;
        val_3 = val_3 + 6;
        val_4 = val_4 + val_3;
        val_2 = val_4 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 6);
    }
    public bool TryGetValue(TKey key, out TValue value)
    {
        var val_2;
        var val_4 = X21;
        if((X21 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 7);
        }
        
        var val_1 = X21 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X21 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 144))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X21 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 7);
        label_3:
        var val_3 = val_1;
        val_3 = val_3 + 7;
        val_4 = val_4 + val_3;
        val_2 = val_4 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 144), slot: 7);
    }
    public void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
    {
        var val_2;
        var val_4 = X20;
        if((X20 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 2);
        }
        
        var val_1 = X20 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X20 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 152))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X20 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 2);
        label_3:
        var val_3 = val_1;
        val_3 = val_3 + 2;
        val_4 = val_4 + val_3;
        val_2 = val_4 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 2);
    }
    public void Clear()
    {
        var val_2;
        var val_4 = X19;
        if((X19 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 3);
        }
        
        var val_1 = X19 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X19 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 152))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X19 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 3);
        label_3:
        var val_3 = val_1;
        val_3 = val_3 + 3;
        val_4 = val_4 + val_3;
        val_2 = val_4 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 3);
    }
    public bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
    {
        var val_2;
        var val_4 = X20;
        if((X20 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 4);
        }
        
        var val_1 = X20 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X20 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 152))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X20 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 4);
        label_3:
        var val_3 = val_1;
        val_3 = val_3 + 4;
        val_4 = val_4 + val_3;
        val_2 = val_4 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 4);
    }
    public void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex)
    {
        var val_2;
        var val_4 = X21;
        if((X21 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 5);
        }
        
        var val_1 = X21 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X21 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 152))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X21 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 5);
        label_3:
        var val_3 = val_1;
        val_3 = val_3 + 5;
        val_4 = val_4 + val_3;
        val_2 = val_4 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 5);
    }
    public bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
    {
        var val_2;
        var val_4 = X20;
        if((X20 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 6);
        }
        
        var val_1 = X20 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X20 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 152))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X20 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 6);
        label_3:
        var val_3 = val_1;
        val_3 = val_3 + 6;
        val_4 = val_4 + val_3;
        val_2 = val_4 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 152), slot: 6);
    }
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        var val_2;
        var val_3 = X19;
        if((X19 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 32), slot: 0);
        }
        
        var val_1 = X19 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X19 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 32))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X19 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 32), slot: 0);
        label_3:
        val_3 = val_3 + (((X19 + 176 + 8)) << 4);
        val_2 = val_3 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 32), slot: 0);
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        var val_2;
        var val_3 = X19;
        if((X19 + 286) == 0)
        {
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 32), slot: 0);
        }
        
        var val_1 = X19 + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((X19 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 32))
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (X19 + 286))
        {
            goto label_4;
        }
        
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 32), slot: 0);
        label_3:
        val_3 = val_3 + (((X19 + 176 + 8)) << 4);
        val_2 = val_3 + 296;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X19, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 32), slot: 0);
    }
    public bool get_IsFixedSize()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.IsFixedSize;
    }
    private System.Collections.ICollection System.Collections.IDictionary.get_Keys()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.Keys;
    }
    private System.Collections.ICollection System.Collections.IDictionary.get_Values()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.Values;
    }
    public bool get_IsSynchronized()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.IsSynchronized;
    }
    public object get_SyncRoot()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.SyncRoot;
    }
    public object get_Item(object key)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.Item[key];
    }
    public void set_Item(object key, object value)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.set_Item(key:  key, value:  value);
    }
    public void Add(object key, object value)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.Add(key:  key, value:  value);
    }
    public bool Contains(object key)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.Contains(key:  key);
    }
    private System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.GetEnumerator();
    }
    public void Remove(object key)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.Remove(key:  key);
    }
    public void CopyTo(System.Array array, int index)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.CopyTo(array:  array, index:  index);
    }
    public void OnDeserialization(object sender)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.OnDeserialization(sender:  sender);
    }
    protected SerializableDictionaryBase<TKey, TValue, TValueStorage>(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
    {
        mem[1152921528169949296] = __RuntimeMethodHiddenParam + 24 + 192;
    }
    public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.GetObjectData(info:  info, context:  new System.Runtime.Serialization.StreamingContext() {m_additionalContext = context.m_additionalContext, m_state = context.m_state});
    }

}
