using UnityEngine;
public static class GenericFunctions
{
    // Methods
    public static bool IsMiddleSuper(InkWars.Model.BubbleTypes bubbleType)
    {
        if(bubbleType != 9)
        {
                return (bool)((bubbleType - 15) < 2) ? 1 : 0;
        }
        
        return true;
    }
    public static bool IsSuperType(InkWars.Model.BubbleTypes bubbleType)
    {
        bubbleType = (((bubbleType - 8) < 3) ? 1 : 0) | (((bubbleType - 15) < 2) ? 1 : 0);
        return (bool)bubbleType;
    }
    public static T NextEnum<T>(T src)
    {
        var val_10;
        var val_11;
        var val_12;
        if(((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48})) & 1) == 0)
        {
            goto label_4;
        }
        
        System.Array val_3 = System.Enum.GetValues(enumType:  __RuntimeMethodHiddenParam + 48 + 8.GetType());
        if(val_3 == null)
        {
            goto label_9;
        }
        
        val_10 = val_3;
        if(val_10 != null)
        {
            goto label_10;
        }
        
        label_9:
        val_10 = 0;
        label_10:
        if(val_10 != 0)
        {
                val_11 = 10260432;
            val_12 = val_11;
        }
        else
        {
                val_12 = 10260432;
            val_11 = 10260432;
        }
        
        var val_5 = (1 == val_12) ? 0 : 1;
        var val_6 = val_10 + ((1 == val_12 ? 0 : 1) << 2);
        return (CharacterNameID)(val_10 + (1 == val_12 ? 0 : 1) << 2) + 32;
        label_4:
        System.ArgumentException val_9 = new System.ArgumentException(message:  System.String.Format(format:  "Argumnent {0} is not an Enum", arg0:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48})));
    }
    public static T PrevEnum<T>(T src)
    {
        var val_8;
        var val_9;
        var val_10;
        if(((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48})) & 1) == 0)
        {
            goto label_4;
        }
        
        System.Array val_3 = System.Enum.GetValues(enumType:  __RuntimeMethodHiddenParam + 48 + 8.GetType());
        if(val_3 == null)
        {
            goto label_9;
        }
        
        val_8 = val_3;
        if(val_8 != null)
        {
            goto label_10;
        }
        
        label_9:
        val_8 = 0;
        label_10:
        val_9 = -1;
        if(val_8 == 0)
        {
            goto label_11;
        }
        
        if((val_9 & 2147483648) != 0)
        {
            goto label_12;
        }
        
        label_14:
        val_10 = 10260432;
        goto label_13;
        label_11:
        if((val_9 & 2147483648) == 0)
        {
            goto label_14;
        }
        
        label_12:
        val_10 = 10260432;
        val_9 = val_10 - 1;
        label_13:
        var val_5 = val_8 + (((long)(int)((val_10 - 1))) << 2);
        return (CharacterNameID)(val_8 + ((long)(int)((val_10 - 1))) << 2) + 32;
        label_4:
        System.ArgumentException val_8 = new System.ArgumentException(message:  System.String.Format(format:  "Argumnent {0} is not an Enum", arg0:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48})));
    }
    internal static UnityEngine.Vector3 SplineLerp(UnityEngine.Vector3[] spline, float i)
    {
        int val_4;
        float val_1 = UnityEngine.Mathf.Clamp01(value:  i);
        if(val_1 == 1f)
        {
                var val_4 = -4294967296;
            val_4 = val_4 + ((spline.Length) << 32);
            var val_5 = 12;
            val_5 = spline + ((val_4 >> 32) * val_5);
            return new UnityEngine.Vector3() {x = (((-4294967296 + (spline.Length) << 32) >> 32) * 12) + spline + 32, y = (((-4294967296 + (spline.Length) << 32) >> 32) * 12) + spline + 32 + 4, z = (((-4294967296 + (spline.Length) << 32) >> 32) * 12) + spline + 40};
        }
        
        int val_6 = spline.Length;
        val_6 = val_6 - 1;
        float val_7 = (float)val_6;
        val_7 = val_1 * val_7;
        val_4 = spline.Length;
        if((int)val_7 >= val_4)
        {
                val_4 = spline.Length;
        }
        
        var val_8 = 12;
        val_8 = spline + ((long)(int)val_7 * val_8);
        var val_9 = 12;
        val_9 = spline + (((long)(int)val_7 + 1) * val_9);
        return UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = ((long)(int)((val_1 * (spline.Length - 1))) * 12) + spline + 32, y = ((long)(int)((val_1 * (spline.Length - 1))) * 12) + spline + 32 + 4, z = ((long)(int)((val_1 * (spline.Length - 1))) * 12) + spline + 40}, b:  new UnityEngine.Vector3() {x = ((long)(int)(((val_1 * (spline.Length - 1)) + 1)) * 12) + spline + 32, y = ((long)(int)(((val_1 * (spline.Length - 1)) + 1)) * 12) + spline + 32 + 4, z = ((long)(int)(((val_1 * (spline.Length - 1)) + 1)) * 12) + spline + 40}, t:  val_7);
    }

}
