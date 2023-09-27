using UnityEngine;
[Serializable]
public class BattleEnhancerList
{
    // Fields
    public System.Collections.Generic.List<BattleEnhancerItem> items;
    
    // Methods
    public static BattleEnhancerList FromIntArray(int[] source)
    {
        var val_4;
        if(source != null)
        {
                BattleEnhancerList val_1 = null;
            val_4 = val_1;
            val_1 = new BattleEnhancerList();
            if(source.Length < 1)
        {
                return (BattleEnhancerList)val_4;
        }
        
            do
        {
            (BattleEnhancerList)[1152921528873528560].items.Add(item:  BattleEnhancerItem.FromInt(number:  source[0]));
        }
        while((0 + 1) < source.Length);
        
            return (BattleEnhancerList)val_4;
        }
        
        UnityEngine.Debug.LogError(message:  "Cannot convert int[] to BattleEnhancerList: data source cannot be null");
        BattleEnhancerList val_4 = null;
        val_4 = val_4;
        val_4 = new BattleEnhancerList();
        return (BattleEnhancerList)val_4;
    }
    public static int[] ToIntArray(BattleEnhancerList source)
    {
        var val_7;
        if(source == null)
        {
            goto label_1;
        }
        
        System.Collections.Generic.List<System.Int32> val_1 = null;
        val_7 = val_1;
        val_1 = new System.Collections.Generic.List<System.Int32>();
        List.Enumerator<T> val_2 = source.items.GetEnumerator();
        label_7:
        if(((-1502976232) & 1) == 0)
        {
            goto label_3;
        }
        
        if(val_3._impl == 0)
        {
            goto label_7;
        }
        
        val_1.Add(item:  BattleEnhancerItem.ToInt(item:  0.InitialType));
        goto label_7;
        label_1:
        UnityEngine.Debug.LogError(message:  "Cannot convert BattleEnhancerList to int[]: data source cannot be null");
        int[] val_5 = new int[1];
        return (System.Int32[])val_1.ToArray();
        label_3:
        0.Add(driver:  public System.Void List.Enumerator<BattleEnhancerItem>::Dispose(), rectTransform:  null, drivenProperties:  null);
        if(val_7 != null)
        {
                return (System.Int32[])val_1.ToArray();
        }
        
        return (System.Int32[])val_1.ToArray();
    }
    public int[] ToIntArray()
    {
        return BattleEnhancerList.ToIntArray(source:  this);
    }
    public void SetFromIntArray(int[] source)
    {
        if((BattleEnhancerList.FromIntArray(source:  source)) == null)
        {
                return;
        }
        
        this.items = val_1.items;
    }
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetCount(InkWars.Model.BattleEnhancerType type, int level, int defaultValue = 0)
    {
        BattleEnhancerList.<>c__DisplayClass5_0 val_1 = new BattleEnhancerList.<>c__DisplayClass5_0();
        if(val_1 != null)
        {
                .type = type;
        }
        else
        {
                mem[16] = type;
        }
        
        .level = level;
        if((this.items.Find(match:  new System.Predicate<BattleEnhancerItem>(object:  val_1, method:  System.Boolean BattleEnhancerList.<>c__DisplayClass5_0::<GetCount>b__0(BattleEnhancerItem x)))) == null)
        {
                return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  defaultValue);
        }
        
        return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.count, hiddenValue = val_3.count, fakeValue = -1502412832, inited = true};
    }
    public void SetCount(InkWars.Model.BattleEnhancerType type, int level, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt count)
    {
        System.Collections.Generic.List<BattleEnhancerItem> val_8;
        object val_9;
        InkWars.Model.BattleEnhancerType val_10;
        BattleEnhancerItem val_11;
        val_8 = this;
        BattleEnhancerList.<>c__DisplayClass6_0 val_1 = null;
        val_9 = val_1;
        val_1 = new BattleEnhancerList.<>c__DisplayClass6_0();
        if(val_9 != null)
        {
                val_10 = val_9;
            .type = type;
        }
        else
        {
                val_10 = 16;
            mem[16] = type;
        }
        
        .level = level;
        val_11 = this.items.Find(match:  new System.Predicate<BattleEnhancerItem>(object:  val_1, method:  System.Boolean BattleEnhancerList.<>c__DisplayClass6_0::<SetCount>b__0(BattleEnhancerItem x)));
        if(val_11 == null)
        {
                BattleEnhancerItem val_4 = null;
            val_11 = val_4;
            val_4 = new BattleEnhancerItem();
            if(val_11 != null)
        {
                .enhancerType = val_10;
            val_9 = (BattleEnhancerList.<>c__DisplayClass6_0)[1152921528874391904].level;
        }
        else
        {
                mem[16] = val_10;
            val_9 = (BattleEnhancerList.<>c__DisplayClass6_0)[1152921528874391904].level;
        }
        
            .level = val_9;
            val_8 = this.items;
            val_8.Add(item:  val_4);
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Clamp(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = count.currentCryptoKey, hiddenValue = count.hiddenValue, fakeValue = count.fakeValue, inited = count.inited}), min:  0, max:  15));
        .count = val_7;
        mem[1152921528874408320] = val_7.fakeValue;
        mem[1152921528874408324] = val_7.inited;
    }
    public void AddToCount(InkWars.Model.BattleEnhancerType type, int level, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt diff)
    {
        System.Collections.Generic.List<BattleEnhancerItem> val_10;
        InkWars.Model.BattleEnhancerType val_11;
        BattleEnhancerItem val_12;
        int val_13;
        val_10 = this;
        BattleEnhancerList.<>c__DisplayClass7_0 val_1 = new BattleEnhancerList.<>c__DisplayClass7_0();
        if(val_1 != null)
        {
                val_11 = val_1;
            .type = type;
        }
        else
        {
                val_11 = 16;
            mem[16] = type;
        }
        
        .level = level;
        val_12 = this.items.Find(match:  new System.Predicate<BattleEnhancerItem>(object:  val_1, method:  System.Boolean BattleEnhancerList.<>c__DisplayClass7_0::<AddToCount>b__0(BattleEnhancerItem x)));
        if(val_12 == null)
        {
                BattleEnhancerItem val_4 = null;
            val_12 = val_4;
            val_4 = new BattleEnhancerItem();
            if(val_12 != null)
        {
                .enhancerType = val_11;
            val_13 = (BattleEnhancerList.<>c__DisplayClass7_0)[1152921528874562272].level;
        }
        else
        {
                mem[16] = val_11;
            val_13 = (BattleEnhancerList.<>c__DisplayClass7_0)[1152921528874562272].level;
        }
        
            .level = val_13;
            val_10 = this.items;
            val_10.Add(item:  val_4);
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Clamp(value:  (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = diff.currentCryptoKey, hiddenValue = diff.hiddenValue, fakeValue = diff.fakeValue, inited = diff.inited})) + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = (BattleEnhancerItem)[1152921528874578656].count, hiddenValue = (BattleEnhancerItem)[1152921528874578656].count, fakeValue = val_10, inited = val_10})), min:  0, max:  15));
        .count = val_9;
        mem[1152921528874578688] = val_9.fakeValue;
        mem[1152921528874578692] = val_9.inited;
    }
    public override string ToString()
    {
        List.Enumerator<T> val_1 = this.items.GetEnumerator();
        label_4:
        if(((-1501979608) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_3 = "" + "\r\n  " + 0.InitialType + ", ";
        goto label_4;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<BattleEnhancerItem>::Dispose(), rectTransform:  null, drivenProperties:  null);
        return (string)System.String.Format(format:  "[BattleEnhancerList {0}]", arg0:  "");
    }
    public BattleEnhancerList()
    {
        this.items = new System.Collections.Generic.List<BattleEnhancerItem>();
    }

}
