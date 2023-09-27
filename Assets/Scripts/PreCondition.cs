using UnityEngine;
public sealed class MotionPanelsControler.PreCondition : MulticastDelegate
{
    // Methods
    public MotionPanelsControler.PreCondition(object object, IntPtr method)
    {
        mem[1152921528627496784] = object;
        mem[1152921528627496792] = method;
        mem[1152921528627496768] = method;
    }
    public virtual bool Invoke()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        if(X23 == 0)
        {
            goto label_0;
        }
        
        if((X23 + 24) == 0)
        {
            goto label_1;
        }
        
        val_11 = 0;
        var val_16 = 0;
        label_27:
        var val_1 = X23 + 0;
        if((((X23 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_3;
        }
        
        if(((X23 + 0) + 32 + 32 + 8 + 72) == 1)
        {
            goto label_7;
        }
        
        if(((X23 + 0) + 32 + 32) != 0)
        {
                if((((X23 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_7;
        }
        
        }
        
        if(((X23 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_7;
        }
        
        if(((X23 + 0) + 32 + 32) != 0)
        {
                if((((X23 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_9;
        }
        
        }
        
        System.Type val_2 = (X23 + 0) + 32 + 32 + 8.TargetType;
        if((((X23 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_10;
        }
        
        if((val_2 & 1) == 0)
        {
            goto label_11;
        }
        
        var val_14 = (X23 + 0) + 32 + 32;
        if(((X23 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_15;
        }
        
        var val_7 = (X23 + 0) + 32 + 32 + 176;
        var val_8 = 0;
        val_7 = val_7 + 8;
        label_14:
        if((((X23 + 0) + 32 + 32 + 176 + 8) + -8) == ((X23 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_13;
        }
        
        val_8 = val_8 + 1;
        val_7 = val_7 + 16;
        if(val_8 < ((X23 + 0) + 32 + 32 + 286))
        {
            goto label_14;
        }
        
        goto label_15;
        label_3:
        if(((X23 + 0) + 32 + 32 + 8 + 74) == 0)
        {
            goto label_16;
        }
        
        label_7:
        val_13 = (X23 + 0) + 32 + 32;
        goto label_26;
        label_16:
        val_13 = (X23 + 0) + 32 + 32 + 8;
        goto label_26;
        label_10:
        if((val_2 & 1) == 0)
        {
            goto label_19;
        }
        
        if(((X23 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_23;
        }
        
        var val_9 = (X23 + 0) + 32 + 32 + 176;
        var val_10 = 0;
        val_9 = val_9 + 8;
        label_22:
        if((((X23 + 0) + 32 + 32 + 176 + 8) + -8) == ((X23 + 0) + 32 + 32 + 8.TargetType))
        {
            goto label_21;
        }
        
        val_10 = val_10 + 1;
        val_9 = val_9 + 16;
        if(val_10 < ((X23 + 0) + 32 + 32 + 286))
        {
            goto label_22;
        }
        
        goto label_23;
        label_11:
        var val_11 = (X23 + 0) + 32 + 32;
        val_11 = val_11 + (((X23 + 0) + 32 + 32 + 8 + 72) << 4);
        val_15 = mem[((X23 + 0) + 32 + 32 + ((X23 + 0) + 32 + 32 + 8 + 72) << 4) + 304];
        val_15 = ((X23 + 0) + 32 + 32 + ((X23 + 0) + 32 + 32 + 8 + 72) << 4) + 304;
        goto label_24;
        label_19:
        var val_12 = (X23 + 0) + 32 + 32;
        val_13 = (X23 + 0) + 32 + 32;
        val_12 = val_12 + ((X23 + 0) + 32 + 32 + 8 + 72);
        goto label_26;
        label_13:
        var val_13 = val_7;
        val_13 = val_13 + ((X23 + 0) + 32 + 32 + 8 + 72);
        val_14 = val_14 + val_13;
        val_12 = val_14 + 296;
        label_15:
        val_15 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable((X23 + 0) + 32 + 32, typeof((X23 + 0) + 32 + 32 + 8 + 24), slot: 0) + 8];
        val_15 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable((X23 + 0) + 32 + 32, typeof((X23 + 0) + 32 + 32 + 8 + 24), slot: 0) + 8;
        label_24:
        val_13 = (X23 + 0) + 32 + 32;
        goto label_26;
        label_21:
        var val_15 = val_9;
        val_15 = val_15 + ((X23 + 0) + 32 + 32 + 8 + 72);
        val_15 = ((X23 + 0) + 32 + 32) + val_15;
        val_14 = val_15 + 296;
        label_23:
        val_13 = (X23 + 0) + 32 + 32;
        label_26:
        val_11 = val_13 & 1;
        label_9:
        val_16 = val_16 + 1;
        if(val_16 != (X23 + 24))
        {
            goto label_27;
        }
        
        return (bool)val_11 & 1;
        label_0:
        if((X21 & 1) == 0)
        {
            goto label_30;
        }
        
        if((X21 + 72) == 1)
        {
            goto label_34;
        }
        
        if(X20 != 0)
        {
                if(((X20 + 265) & 1) != 0)
        {
            goto label_34;
        }
        
        }
        
        if((X20 + 265) == 0)
        {
            goto label_34;
        }
        
        if(X20 != 0)
        {
                if(((X20 + 265) & 1) != 0)
        {
                return (bool)val_11 & 1;
        }
        
        }
        
        System.Type val_4 = X21.TargetType;
        if((X21 & 1) == 0)
        {
            goto label_37;
        }
        
        if((val_4 & 1) == 0)
        {
            goto label_38;
        }
        
        var val_24 = X20;
        if((X20 + 286) == 0)
        {
            goto label_42;
        }
        
        var val_17 = X20 + 176;
        var val_18 = 0;
        val_17 = val_17 + 8;
        label_41:
        if(((X20 + 176 + 8) + -8) == (X21 + 24))
        {
            goto label_40;
        }
        
        val_18 = val_18 + 1;
        val_17 = val_17 + 16;
        if(val_18 < (X20 + 286))
        {
            goto label_41;
        }
        
        goto label_42;
        label_1:
        val_11 = 0;
        return (bool)val_11 & 1;
        label_30:
        if((X21 + 74) == 0)
        {
            goto label_43;
        }
        
        label_34:
        label_53:
        label_43:
        label_37:
        if((val_4 & 1) == 0)
        {
            goto label_44;
        }
        
        if((X20 + 286) == 0)
        {
            goto label_53;
        }
        
        var val_19 = X20 + 176;
        var val_20 = 0;
        val_19 = val_19 + 8;
        label_47:
        if(((X20 + 176 + 8) + -8) == X21.TargetType)
        {
            goto label_46;
        }
        
        val_20 = val_20 + 1;
        val_19 = val_19 + 16;
        if(val_20 < (X20 + 286))
        {
            goto label_47;
        }
        
        goto label_53;
        label_38:
        var val_21 = X20;
        val_21 = val_21 + ((X21 + 72) << 4);
        val_18 = mem[(X20 + (X21 + 72) << 4) + 304];
        val_18 = (X20 + (X21 + 72) << 4) + 304;
        goto label_53;
        label_44:
        var val_22 = X20;
        val_22 = val_22 + (X21 + 72);
        goto label_53;
        label_40:
        var val_23 = val_17;
        val_23 = val_23 + (X21 + 72);
        val_24 = val_24 + val_23;
        val_16 = val_24 + 296;
        label_42:
        val_18 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(X21 + 24), slot: 0) + 8];
        val_18 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(X21 + 24), slot: 0) + 8;
        goto label_53;
        label_46:
        var val_25 = val_19;
        val_25 = val_25 + (X21 + 72);
        val_25 = X20 + val_25;
        val_17 = val_25 + 296;
        goto label_53;
    }
    public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual bool EndInvoke(System.IAsyncResult result)
    {
        result.Add(driver:  0, rectTransform:  null, drivenProperties:  null);
        return (bool)null;
    }

}
