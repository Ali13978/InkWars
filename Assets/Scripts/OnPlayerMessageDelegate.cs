using UnityEngine;
public sealed class Model_Events.OnPlayerMessageDelegate : MulticastDelegate
{
    // Methods
    public Model_Events.OnPlayerMessageDelegate(object object, IntPtr method)
    {
        mem[1152921529267075968] = object;
        mem[1152921529267075976] = method;
        mem[1152921529267075952] = method;
    }
    public virtual void Invoke(PlayerMessage message)
    {
        var val_23;
        var val_24;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_32;
        var val_33;
        var val_34;
        if(X24 == 0)
        {
            goto label_0;
        }
        
        if((X24 + 24) == 0)
        {
                return;
        }
        
        var val_34 = 0;
        goto label_65;
        label_0:
        if((X21 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X21 + 74) != 1)
        {
            goto label_5;
        }
        
        if((X21 + 72) == 65535)
        {
            goto label_9;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 265) & 1) != 0)
        {
            goto label_9;
        }
        
        }
        
        if((X22 + 265) == 0)
        {
            goto label_9;
        }
        
        if(X22 == 0)
        {
            goto label_70;
        }
        
        if(((X22 + 265) & 1) != 0)
        {
                return;
        }
        
        System.Type val_1 = X21.TargetType;
        if((X21 & 1) == 0)
        {
            goto label_12;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_13;
        }
        
        var val_42 = X22;
        if((X22 + 286) == 0)
        {
            goto label_17;
        }
        
        var val_20 = X22 + 176;
        var val_21 = 0;
        val_20 = val_20 + 8;
        label_16:
        if(((X22 + 176 + 8) + -8) == (X21 + 24))
        {
            goto label_15;
        }
        
        val_21 = val_21 + 1;
        val_20 = val_20 + 16;
        if(val_21 < (X22 + 286))
        {
            goto label_16;
        }
        
        goto label_17;
        label_59:
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X21 + 24), slot: 0)) & 1) == 0)
        {
            goto label_18;
        }
        
        System.Type val_2 = X21.TargetType;
        var val_22 = 0;
        val_22 = val_22 + 1;
        goto label_22;
        label_60:
        PlayerMessage val_3 = 1152921505103650816 + ((X21 + 72) << 4);
        val_26 = mem[(1152921505103650816 + (X21 + 72) << 4) + 304];
        goto label_58;
        label_18:
        PlayerMessage val_4 = 1152921505103650816 + (X21 + 72);
        goto label_58;
        label_45:
        val_27 = mem[X21 + 72];
        val_27 = X21 + 72;
        if((message.Equals(obj:  mem[(1152921505103650816 + X21 + 72) + 296 + 8])) == false)
        {
            goto label_25;
        }
        
        if((X21 + 72 + 286) == 0)
        {
            goto label_58;
        }
        
        var val_23 = X21 + 72 + 176;
        var val_24 = 0;
        val_23 = val_23 + 8;
        label_28:
        if(((X21 + 72 + 176 + 8) + -8) == X21.TargetType)
        {
            goto label_27;
        }
        
        val_24 = val_24 + 1;
        val_23 = val_23 + 16;
        if(val_24 < (X21 + 72 + 286))
        {
            goto label_28;
        }
        
        goto label_58;
        label_46:
        var val_25 = X21 + 72;
        val_25 = val_25 + ((X21 + 72) << 4);
        val_29 = mem[(X21 + 72 + (X21 + 72) << 4) + 304];
        val_29 = (X21 + 72 + (X21 + 72) << 4) + 304;
        goto label_58;
        label_25:
        var val_26 = X21 + 72;
        val_26 = val_26 + val_27;
        goto label_58;
        label_64:
        val_26 = mem[(((X21 + 72 + X21 + 72) + (((X22 + 176 + 8) + 16) + (X21 + 72 + X21 + 72) + 296 + 8)) + 296) + 8];
        val_26 = (((X21 + 72 + X21 + 72) + (((X22 + 176 + 8) + 16) + (X21 + 72 + X21 + 72) + 296 + 8)) + 296) + 8;
        goto label_58;
        label_22:
        var val_29 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(message, typeof(val_2), slot: 0);
        goto label_58;
        label_48:
        var val_28 = 1179403647;
        val_28 = val_28 + (X21 + 72);
        val_29 = val_29 + val_28;
        var val_9 = val_29 + 296;
        label_50:
        val_29 = mem[(((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(message, typeof(val_2), slot: 0) + (1179403647 + X21 + 72)) + 296) + 8];
        val_29 = (((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(message, typeof(val_2), slot: 0) + (1179403647 + X21 + 72)) + 296) + 8;
        goto label_58;
        label_27:
        var val_30 = val_23;
        val_30 = val_30 + val_27;
        val_30 = (X21 + 72) + val_30;
        val_28 = val_30 + 296;
        goto label_58;
        label_65:
        var val_10 = X24 + 0;
        val_23 = mem[(X24 + 0) + 32 + 32 + 8];
        val_23 = (X24 + 0) + 32 + 32 + 8;
        val_27 = mem[(X24 + 0) + 32 + 16];
        val_27 = (X24 + 0) + 32 + 16;
        if((val_23 & 1) == 0)
        {
            goto label_37;
        }
        
        if(((X24 + 0) + 32 + 32 + 8 + 74) != 1)
        {
            goto label_38;
        }
        
        if(((X24 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_58;
        }
        
        if(((X24 + 0) + 32 + 32) != 0)
        {
                if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        }
        
        if(((X24 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_58;
        }
        
        if(((X24 + 0) + 32 + 32) == 0)
        {
            goto label_56;
        }
        
        if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        if((val_23 & 1) == 0)
        {
            goto label_45;
        }
        
        if((val_23.TargetType & 1) == 0)
        {
            goto label_46;
        }
        
        if(((X24 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_50;
        }
        
        var val_31 = (X24 + 0) + 32 + 32 + 176;
        var val_32 = 0;
        val_31 = val_31 + 8;
        label_49:
        if((((X24 + 0) + 32 + 32 + 176 + 8) + -8) == ((X24 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_48;
        }
        
        val_32 = val_32 + 1;
        val_31 = val_31 + 16;
        if(val_32 < ((X24 + 0) + 32 + 32 + 286))
        {
            goto label_49;
        }
        
        goto label_50;
        label_37:
        if(((X24 + 0) + 32 + 32 + 8 + 74) == 1)
        {
            goto label_56;
        }
        
        goto label_58;
        label_38:
        if(((X24 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_56;
        }
        
        if(((X24 + 0) + 32 + 32) != 0)
        {
                if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_56;
        }
        
        }
        
        if(((X24 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_56;
        }
        
        if(((X24 + 0) + 32 + 32) != 0)
        {
                if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        }
        
        if((val_23 & 1) == 0)
        {
            goto label_59;
        }
        
        if((val_23.TargetType & 1) == 0)
        {
            goto label_60;
        }
        
        var val_33 = 0;
        val_33 = val_33 + 1;
        goto label_64;
        label_56:
        label_58:
        val_34 = val_34 + 1;
        if(val_34 != (X24 + 24))
        {
            goto label_65;
        }
        
        return;
        label_4:
        if((X21 + 74) == 1)
        {
            goto label_70;
        }
        
        label_9:
        label_96:
        label_5:
        if((X21 + 72) == 65535)
        {
            goto label_70;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 265) & 1) != 0)
        {
            goto label_70;
        }
        
        }
        
        if((X22 + 265) == 0)
        {
            goto label_70;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 265) & 1) != 0)
        {
                return;
        }
        
        }
        
        System.Type val_13 = X21.TargetType;
        if((X21 & 1) == 0)
        {
            goto label_73;
        }
        
        if((val_13 & 1) == 0)
        {
            goto label_74;
        }
        
        var val_35 = 0;
        val_35 = val_35 + 1;
        goto label_78;
        label_70:
        label_94:
        label_73:
        if((val_13 & 1) == 0)
        {
            goto label_79;
        }
        
        System.Type val_14 = X21.TargetType;
        var val_36 = 0;
        val_36 = val_36 + 1;
        goto label_94;
        label_74:
        PlayerMessage val_15 = 1152921505103650816 + ((X21 + 72) << 4);
        val_32 = mem[(1152921505103650816 + (X21 + 72) << 4) + 304];
        goto label_94;
        label_79:
        PlayerMessage val_16 = 1152921505103650816 + (X21 + 72);
        goto label_94;
        label_12:
        if((val_1 & 1) == 0)
        {
            goto label_86;
        }
        
        if((X22 + 286) == 0)
        {
            goto label_96;
        }
        
        var val_37 = X22 + 176;
        var val_38 = 0;
        val_37 = val_37 + 8;
        label_89:
        if(((X22 + 176 + 8) + -8) == X21.TargetType)
        {
            goto label_88;
        }
        
        val_38 = val_38 + 1;
        val_37 = val_37 + 16;
        if(val_38 < (X22 + 286))
        {
            goto label_89;
        }
        
        goto label_96;
        label_13:
        var val_39 = X22;
        val_39 = val_39 + ((X21 + 72) << 4);
        val_34 = mem[(X22 + (X21 + 72) << 4) + 304];
        val_34 = (X22 + (X21 + 72) << 4) + 304;
        goto label_96;
        label_86:
        var val_40 = X22;
        val_40 = val_40 + (X21 + 72);
        goto label_96;
        label_78:
        val_32 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(message, typeof(X21 + 24), slot: 0) + 8];
        val_32 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(message, typeof(X21 + 24), slot: 0) + 8;
        goto label_94;
        label_15:
        var val_41 = val_20;
        val_41 = val_41 + (X21 + 72);
        val_42 = val_42 + val_41;
        val_24 = val_42 + 296;
        label_17:
        val_34 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X21 + 24), slot: 0) + 8];
        val_34 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X21 + 24), slot: 0) + 8;
        goto label_96;
        label_88:
        var val_43 = val_37;
        val_43 = val_43 + (X21 + 72);
        val_43 = X22 + val_43;
        val_33 = val_43 + 296;
        goto label_96;
    }
    public virtual System.IAsyncResult BeginInvoke(PlayerMessage message, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
