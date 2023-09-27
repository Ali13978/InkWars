using UnityEngine;
[Serializable]
public class BattleEnhancerItem
{
    // Fields
    private const int TYPE_FACTOR = 1000000;
    private const int LEVEL_FACTOR = 10000;
    public const int MAX_HOLD_COUNT = 9999;
    public InkWars.Model.BattleEnhancerType enhancerType;
    public int level;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt count;
    
    // Properties
    public bool isValid { get; }
    
    // Methods
    public static int ToInt(BattleEnhancerItem item)
    {
        int val_5;
        var val_6;
        val_5 = item;
        if(val_5 != null)
        {
                val_6 = ((item.level * 10000) + (item.enhancerType * 1000000)) + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = item.count, hiddenValue = item.count, fakeValue = val_5, inited = val_5}));
            return (int)val_6;
        }
        
        val_6 = 0;
        return (int)val_6;
    }
    public static int ToInt(InkWars.Model.BattleEnhancerType type, int level, int count = 0)
    {
        InkWars.Model.BattleEnhancerType val_1 = type * 1000000;
        val_1 = val_1 + (level * 10000);
        type = val_1 + count;
        return (int)type;
    }
    public static BattleEnhancerItem FromInt(int number)
    {
        BattleEnhancerItem val_1 = new BattleEnhancerItem();
        if(val_1 != null)
        {
                .enhancerType = 0;
        }
        else
        {
                mem[16] = 0;
        }
        
        .level = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
        .count = val_2;
        mem[1152921528872455088] = val_2.fakeValue;
        mem[1152921528872455092] = val_2.inited;
        return val_1;
    }
    public static bool IsValid(InkWars.Model.BattleEnhancerType checkedType, int checkedLevel)
    {
        if(checkedType == 0)
        {
                return (bool)((checkedLevel - 1) < 6) ? 1 : 0;
        }
        
        return (bool)((checkedLevel - 1) < 6) ? 1 : 0;
    }
    public bool get_isValid()
    {
        return (bool)((this.enhancerType != 0) ? 1 : 0) & (((this.level - 1) < 6) ? 1 : 0);
    }
    public int ToInt()
    {
        return BattleEnhancerItem.ToInt(item:  this);
    }
    public void Setup(int number)
    {
        this.Clone(aNewItemSource:  BattleEnhancerItem.FromInt(number:  number));
    }
    public void Clone(BattleEnhancerItem aNewItemSource)
    {
        if(aNewItemSource != null)
        {
                this.enhancerType = aNewItemSource.enhancerType;
            this.level = aNewItemSource.level;
        }
        else
        {
                this.enhancerType = 11993091;
            this.level = 1;
        }
        
        this.count = aNewItemSource.count;
        mem[1152921528873019952] = ???;
    }
    public override string ToString()
    {
        return (string)System.String.Format(format:  "[BattleEnhancerItem: lv{1} {0} x{2}]", arg0:  this.enhancerType, arg1:  this.level, arg2:  this.count);
    }
    public BattleEnhancerItem()
    {
    
    }

}
