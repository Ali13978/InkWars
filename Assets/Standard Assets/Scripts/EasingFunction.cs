using UnityEngine;
private sealed class iTween.EasingFunction : MulticastDelegate
{
    // Methods
    public iTween.EasingFunction(object object, IntPtr method)
    {
        mem[1152921525904121392] = object;
        mem[1152921525904121400] = method;
        mem[1152921525904121376] = method;
    }
    public virtual float Invoke(float start, float end, float Value)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        if(X23 == 0)
        {
            goto label_0;
        }
        
        if((X23 + 24) == 0)
        {
            goto label_1;
        }
        
        var val_17 = 0;
        val_10 = 0f;
        goto label_42;
        label_0:
        if((X21 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X21 + 72) == 1)
        {
            goto label_44;
        }
        
        if(X20 != 0)
        {
                if(((X20 + 265) & 1) != 0)
        {
            goto label_44;
        }
        
        }
        
        if((X20 + 265) == 0)
        {
            goto label_44;
        }
        
        if(X20 == 0)
        {
            goto label_9;
        }
        
        val_10 = 0f;
        if(((X20 + 265) & 1) != 0)
        {
                return (float)val_10;
        }
        
        System.Type val_1 = X21.TargetType;
        if((X21 & 1) == 0)
        {
            goto label_11;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_12;
        }
        
        var val_23 = X20;
        if((X20 + 286) == 0)
        {
            goto label_16;
        }
        
        var val_7 = X20 + 176;
        var val_8 = 0;
        val_7 = val_7 + 8;
        label_15:
        if(((X20 + 176 + 8) + -8) == (X21 + 24))
        {
            goto label_14;
        }
        
        val_8 = val_8 + 1;
        val_7 = val_7 + 16;
        if(val_8 < (X20 + 286))
        {
            goto label_15;
        }
        
        goto label_16;
        label_34:
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(X21 + 24), slot: 0)) & 1) == 0)
        {
            goto label_17;
        }
        
        if((X20 + 286) == 0)
        {
            goto label_21;
        }
        
        var val_9 = X20 + 176;
        var val_10 = 0;
        val_9 = val_9 + 8;
        label_20:
        if(((X20 + 176 + 8) + -8) == X21.TargetType)
        {
            goto label_19;
        }
        
        val_10 = val_10 + 1;
        val_9 = val_9 + 16;
        if(val_10 < (X20 + 286))
        {
            goto label_20;
        }
        
        goto label_21;
        label_35:
        var val_11 = X20;
        val_11 = val_11 + ((X21 + 72) << 4);
        val_14 = mem[(X20 + (X21 + 72) << 4) + 304];
        val_14 = (X20 + (X21 + 72) << 4) + 304;
        goto label_22;
        label_17:
        var val_12 = X20;
        val_15 = start;
        val_12 = val_12 + (X21 + 72);
        goto label_41;
        label_37:
        var val_13 = val_7;
        val_13 = val_13 + (X21 + 72);
        val_12 = val_12 + val_13;
        var val_3 = val_12 + 296;
        label_39:
        val_14 = mem[(((X20 + X21 + 72) + (((X20 + 176 + 8) + 16) + X21 + 72)) + 296) + 8];
        val_14 = (((X20 + X21 + 72) + (((X20 + 176 + 8) + 16) + X21 + 72)) + 296) + 8;
        label_22:
        val_15 = start;
        goto label_41;
        label_19:
        var val_14 = val_9;
        val_14 = val_14 + (X21 + 72);
        val_14 = X20 + val_14;
        val_13 = val_14 + 296;
        label_21:
        val_15 = start;
        goto label_41;
        label_42:
        var val_4 = X23 + 0;
        val_11 = mem[(X23 + 0) + 32 + 32 + 8];
        val_11 = (X23 + 0) + 32 + 32 + 8;
        if((val_11 & 1) == 0)
        {
            goto label_27;
        }
        
        if(((X23 + 0) + 32 + 32 + 8 + 72) == 1)
        {
            goto label_40;
        }
        
        if(((X23 + 0) + 32 + 32) != 0)
        {
                if((((X23 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_40;
        }
        
        }
        
        if(((X23 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_40;
        }
        
        if(((X23 + 0) + 32 + 32) == 0)
        {
            goto label_32;
        }
        
        if((((X23 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_33;
        }
        
        if((val_11 & 1) == 0)
        {
            goto label_34;
        }
        
        if((val_11.TargetType & 1) == 0)
        {
            goto label_35;
        }
        
        if(((X23 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_39;
        }
        
        var val_15 = (X23 + 0) + 32 + 32 + 176;
        var val_16 = 0;
        val_15 = val_15 + 8;
        label_38:
        if((((X23 + 0) + 32 + 32 + 176 + 8) + -8) == ((X23 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_37;
        }
        
        val_16 = val_16 + 1;
        val_15 = val_15 + 16;
        if(val_16 < ((X23 + 0) + 32 + 32 + 286))
        {
            goto label_38;
        }
        
        goto label_39;
        label_27:
        if(((X23 + 0) + 32 + 32 + 8 + 74) != 3)
        {
            goto label_40;
        }
        
        label_32:
        val_15 = start;
        goto label_41;
        label_40:
        val_15 = start;
        label_41:
        val_10 = val_15;
        label_33:
        val_17 = val_17 + 1;
        if(val_17 != (X23 + 24))
        {
            goto label_42;
        }
        
        return (float)val_10;
        label_1:
        val_10 = 0f;
        return (float)val_10;
        label_4:
        if((X21 + 74) != 3)
        {
            goto label_44;
        }
        
        label_9:
        label_44:
        label_53:
        label_11:
        if((val_1 & 1) == 0)
        {
            goto label_45;
        }
        
        if((X20 + 286) == 0)
        {
            goto label_53;
        }
        
        var val_18 = X20 + 176;
        var val_19 = 0;
        val_18 = val_18 + 8;
        label_48:
        if(((X20 + 176 + 8) + -8) == X21.TargetType)
        {
            goto label_47;
        }
        
        val_19 = val_19 + 1;
        val_18 = val_18 + 16;
        if(val_19 < (X20 + 286))
        {
            goto label_48;
        }
        
        goto label_53;
        label_12:
        var val_20 = X20;
        val_20 = val_20 + ((X21 + 72) << 4);
        val_17 = mem[(X20 + (X21 + 72) << 4) + 304];
        val_17 = (X20 + (X21 + 72) << 4) + 304;
        goto label_53;
        label_45:
        var val_21 = X20;
        val_21 = val_21 + (X21 + 72);
        goto label_53;
        label_14:
        var val_22 = val_7;
        val_22 = val_22 + (X21 + 72);
        val_23 = val_23 + val_22;
        val_12 = val_23 + 296;
        label_16:
        val_17 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(X21 + 24), slot: 0) + 8];
        val_17 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(X21 + 24), slot: 0) + 8;
        goto label_53;
        label_47:
        var val_24 = val_18;
        val_24 = val_24 + (X21 + 72);
        val_24 = X20 + val_24;
        val_16 = val_24 + 296;
        goto label_53;
    }
    public virtual System.IAsyncResult BeginInvoke(float start, float end, float Value, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual float EndInvoke(System.IAsyncResult result)
    {
        result.Add(driver:  0, rectTransform:  null, drivenProperties:  null);
        return (float)null;
    }

}
