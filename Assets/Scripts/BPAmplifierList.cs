using UnityEngine;
[Serializable]
public class BPAmplifierList
{
    // Fields
    public System.Collections.Generic.List<BPAmplifierItem> items;
    
    // Properties
    public int Count { get; }
    
    // Methods
    public int get_Count()
    {
        if(this.items != null)
        {
                return this.items.Count;
        }
        
        return this.items.Count;
    }
    public static BPAmplifierList FromIntArray(int[] source)
    {
        var val_4;
        if(source != null)
        {
                BPAmplifierList val_1 = null;
            val_4 = val_1;
            val_1 = new BPAmplifierList();
            if(source.Length < 1)
        {
                return (BPAmplifierList)val_4;
        }
        
            do
        {
            (BPAmplifierList)[1152921528637685808].items.Add(item:  BPAmplifierItem.FromInt(number:  source[0]));
        }
        while((0 + 1) < source.Length);
        
            return (BPAmplifierList)val_4;
        }
        
        UnityEngine.Debug.LogError(message:  "Cannot convert int[] to BPAmplifierList: data source cannot be null");
        BPAmplifierList val_4 = null;
        val_4 = val_4;
        val_4 = new BPAmplifierList();
        return (BPAmplifierList)val_4;
    }
    public static int[] ToIntArray(BPAmplifierList source)
    {
        var val_8;
        if(source == null)
        {
            goto label_1;
        }
        
        System.Collections.Generic.List<System.Int32> val_1 = null;
        val_8 = val_1;
        val_1 = new System.Collections.Generic.List<System.Int32>();
        List.Enumerator<T> val_2 = source.items.GetEnumerator();
        label_7:
        if(((-1738817960) & 1) == 0)
        {
            goto label_3;
        }
        
        if(val_3._impl == 0)
        {
            goto label_7;
        }
        
        val_1.Add(item:  (0.InitialType | (val_3._impl << 7)) << 20);
        goto label_7;
        label_1:
        UnityEngine.Debug.LogError(message:  "Cannot convert BPAmplifierList to int[]: data source cannot be null");
        int[] val_6 = new int[1];
        return (System.Int32[])val_1.ToArray();
        label_3:
        0.Add(driver:  public System.Void List.Enumerator<BPAmplifierItem>::Dispose(), rectTransform:  null, drivenProperties:  null);
        if(val_8 != null)
        {
                return (System.Int32[])val_1.ToArray();
        }
        
        return (System.Int32[])val_1.ToArray();
    }
    public int[] ToIntArray()
    {
        return BPAmplifierList.ToIntArray(source:  this);
    }
    public void SetFromIntArray(int[] source)
    {
        if((BPAmplifierList.FromIntArray(source:  source)) == null)
        {
                return;
        }
        
        this.items = val_1.items;
    }
    public void AddToList(InkWars.Model.BPAmplifierType type, int precentage)
    {
        BPAmplifierItem val_1 = new BPAmplifierItem();
        if(val_1 != null)
        {
                .precentage = precentage;
        }
        else
        {
                .precentage = precentage;
        }
        
        .amplifierType = type;
        this.items.Add(item:  val_1);
    }
    public override string ToString()
    {
        List.Enumerator<T> val_1 = this.items.GetEnumerator();
        label_4:
        if(((-1738181320) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_3 = "" + "\r\n  " + 0.InitialType + ", ";
        goto label_4;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<BPAmplifierItem>::Dispose(), rectTransform:  null, drivenProperties:  null);
        return (string)System.String.Format(format:  "[BattleEnhancerList {0}]", arg0:  "");
    }
    public BPAmplifierList()
    {
        this.items = new System.Collections.Generic.List<BPAmplifierItem>();
    }

}
