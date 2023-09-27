using UnityEngine;
public class CurrencyCollection : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<CurrencyData> items;
    private static CurrencyCollection _inst;
    
    // Properties
    private static CurrencyCollection instance { get; }
    
    // Methods
    private static CurrencyCollection get_instance()
    {
        var val_3;
        CurrencyCollection val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = CurrencyCollection._inst;
        if(0 == val_4)
        {
                val_5 = null;
            val_4 = UnityEngine.Resources.Load<CurrencyCollection>(path:  "NetworkDataCollection/CurrencyCollection");
            val_5 = null;
            CurrencyCollection._inst = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (CurrencyCollection)CurrencyCollection._inst;
    }
    public static CurrencyData Get(Currency cur)
    {
        var val_6;
        .cur = cur;
        CurrencyCollection val_2 = CurrencyCollection.instance;
        val_6 = val_2.items.Find(match:  new System.Predicate<CurrencyData>(object:  new CurrencyCollection.<>c__DisplayClass4_0(), method:  System.Boolean CurrencyCollection.<>c__DisplayClass4_0::<Get>b__0(CurrencyData x)));
        if(val_6 != null)
        {
                return (CurrencyData)val_6;
        }
        
        CurrencyData val_5 = null;
        val_6 = val_5;
        val_5 = new CurrencyData();
        return (CurrencyData)val_6;
    }
    public CurrencyCollection()
    {
        this.items = new System.Collections.Generic.List<CurrencyData>();
    }
    private static CurrencyCollection()
    {
    
    }

}
