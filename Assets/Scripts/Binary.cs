using UnityEngine;
public static class Binary
{
    // Methods
    public static uint SetBinaryValueWithFlag(uint source, uint value, uint flag)
    {
        uint val_2 = Binary.AlignValueWithBinaryFlag(value:  value, flag:  flag);
        val_2 = val_2 | (source & (~flag));
        return (uint)val_2;
    }
    public static uint SetBinaryValueWithFlag(uint source, bool value, uint flag)
    {
        uint val_3 = Binary.AlignValueWithBinaryFlag(value:  value, flag:  flag);
        val_3 = val_3 | (source & (~flag));
        return (uint)val_3;
    }
    public static uint GetValueWithFlag(uint source, uint flag)
    {
        var val_7;
        uint val_10 = flag;
        uint val_12 = source;
        val_7 = 0;
        var val_7 = val_10;
        label_2:
        if((val_7 & 1) != 0)
        {
            goto label_1;
        }
        
        val_7 = val_7 + 1;
        val_7 = val_7 >> 1;
        if(val_7 < 31)
        {
            goto label_2;
        }
        
        val_7 = 0;
        label_1:
        var val_9 = 0;
        var val_8 = 32;
        do
        {
            val_8 = val_8 - 1;
            val_9 = (val_10 & 1) + val_9;
            val_10 = val_10 >> 1;
        }
        while(val_8 != 0);
        
        var val_11 = 32;
        uint val_2 = val_11 - val_9;
        val_11 = (UnityEngine.Mathf.Max(a:  val_2 - val_7, b:  0)) & 31;
        val_12 = val_12 << val_11;
        int val_5 = UnityEngine.Mathf.Max(a:  0, b:  val_2);
        val_5 = val_12 >> (val_5 & 31);
        return (uint)val_5;
    }
    private static uint AlignValueWithBinaryFlag(uint value, uint flag)
    {
        var val_5;
        uint val_8 = flag;
        uint val_9 = value;
        val_5 = 0;
        var val_5 = val_8;
        label_2:
        if((val_5 & 1) != 0)
        {
            goto label_1;
        }
        
        val_5 = val_5 + 1;
        val_5 = val_5 >> 1;
        if(val_5 < 31)
        {
            goto label_2;
        }
        
        val_5 = 0;
        label_1:
        var val_7 = 0;
        var val_6 = 32;
        do
        {
            val_6 = val_6 - 1;
            val_7 = (val_8 & 1) + val_7;
            val_8 = val_8 >> 1;
        }
        while(val_6 != 0);
        
        val_7 = 32 - val_7;
        val_7 = val_7 - val_5;
        var val_2 = (val_5 == 31) ? (val_5) : (val_7);
        val_7 = val_2 & 31;
        val_9 = val_9 << val_7;
        flag = val_2 - val_5;
        int val_3 = UnityEngine.Mathf.Max(a:  0, b:  flag);
        val_3 = val_9 >> (val_3 & 31);
        return (uint)val_3;
    }
    private static int GetFlagStartPos(uint flag)
    {
        var val_1 = 0;
        do
        {
            if((flag & 1) != 0)
        {
                return 1;
        }
        
            val_1 = val_1 + 1;
            flag = flag >> 1;
        }
        while(val_1 <= 30);
        
        return 0;
    }
    private static int GetFlagLength(uint flag)
    {
        uint val_4 = flag;
        var val_3 = 0;
        var val_2 = 32;
        do
        {
            val_2 = val_2 - 1;
            val_3 = (val_4 & 1) + val_3;
            val_4 = val_4 >> 1;
        }
        while(val_2 != 0);
        
        return (int)val_3;
    }

}
