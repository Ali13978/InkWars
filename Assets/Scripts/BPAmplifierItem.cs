using UnityEngine;
public class BPAmplifierItem
{
    // Fields
    private const int TYPE_FACTOR = 1000000;
    private const int PRECENTAGE_FACTOR = 1000;
    public const int MAX_HOLD_COUNT = 8;
    private const int BIT_MASK_999999 = 1048575;
    private const int BIT_MASK_99 = 127;
    public InkWars.Model.BPAmplifierType amplifierType;
    public int precentage;
    
    // Methods
    public static int ToInt(BPAmplifierItem item)
    {
        if(item == null)
        {
                return (int)val_2 << 20;
        }
        
        InkWars.Model.BPAmplifierType val_2 = item.amplifierType;
        val_2 = item.precentage | (val_2 << 7);
        return (int)val_2 << 20;
    }
    public static int ToInt(InkWars.Model.BPAmplifierType type, int precentage)
    {
        type = (precentage | (type << 7)) << 20;
        return (int)type;
    }
    public static BPAmplifierItem FromInt(int number)
    {
        int val_1 = number >> 27;
        BPAmplifierItem val_2 = new BPAmplifierItem();
        if(val_2 != null)
        {
                .amplifierType = val_1;
        }
        else
        {
                mem[16] = val_1;
        }
        
        .precentage = (uint)(number >> 20) & 127;
        return val_2;
    }
    public int ToInt()
    {
        if(this == null)
        {
                return (int)val_2 << 20;
        }
        
        InkWars.Model.BPAmplifierType val_2 = this.amplifierType;
        val_2 = this.precentage | (val_2 << 7);
        return (int)val_2 << 20;
    }
    public void Setup(int number)
    {
        this.Clone(aNewItemSource:  BPAmplifierItem.FromInt(number:  number));
    }
    public void Clone(BPAmplifierItem aNewItemSource)
    {
        if(aNewItemSource != null)
        {
                this.amplifierType = aNewItemSource.amplifierType;
        }
        else
        {
                this.amplifierType = 11993091;
        }
        
        this.precentage = aNewItemSource.precentage;
    }
    public override string ToString()
    {
        return (string)System.String.Format(format:  "[BPAmplifierItem: Precentage{1} {0}]", arg0:  this.amplifierType, arg1:  this.precentage);
    }
    public override bool Equals(object other)
    {
        var val_3;
        if(other != null)
        {
                var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (BPAmplifierItem.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? other : 0;
            var val_2 = (this.amplifierType == ((System.Object.__il2cppRuntimeField_typeHierarchy + (BPAmplifierItem.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? other : 0 + 16)) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    public override int GetHashCode()
    {
        int val_1 = this.precentage.GetHashCode();
        int val_2 = this.amplifierType.GetHashCode();
        val_2 = val_2 + (val_1 + (val_1 << 4));
        return (int)val_2;
    }
    public BPAmplifierItem()
    {
    
    }

}
