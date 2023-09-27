using UnityEngine;
public sealed class Model_Events.OnBubblePopDelegate : MulticastDelegate
{
    // Methods
    public Model_Events.OnBubblePopDelegate(object object, IntPtr method)
    {
        mem[1152921529271072128] = object;
        mem[1152921529271072136] = method;
        mem[1152921529271072112] = method;
    }
    public virtual void Invoke(InkWars.Model.BubbleStates state, InkWars.Model.Player responsiblePlayer, InkWars.Model.Player targetPlayer, int ring, int index, bool isCrossBubbleHit)
    {
        Model_Events.OnBubblePopDelegate val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        int val_33;
        var val_34;
        var val_35;
        val_17 = this;
        val_18 = isCrossBubbleHit;
        val_19 = targetPlayer;
        val_20 = responsiblePlayer;
        val_21 = state;
        if(X25 == 0)
        {
            goto label_0;
        }
        
        val_17 = mem[X25 + 24];
        val_17 = X25 + 24;
        if(val_17 == 0)
        {
                return;
        }
        
        var val_23 = 0;
        goto label_42;
        label_0:
        if((X27 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X27 + 72) == 1)
        {
            goto label_43;
        }
        
        if(X26 != 0)
        {
                if(((X26 + 265) & 1) != 0)
        {
            goto label_43;
        }
        
        }
        
        if((X26 + 265) == 0)
        {
            goto label_43;
        }
        
        if(X26 == 0)
        {
            goto label_9;
        }
        
        if(((X26 + 265) & 1) != 0)
        {
                return;
        }
        
        val_24 = X27;
        System.Type val_1 = X27.TargetType;
        if((val_24 & 1) == 0)
        {
            goto label_11;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_12;
        }
        
        var val_28 = X26;
        if((X26 + 286) == 0)
        {
            goto label_16;
        }
        
        var val_13 = X26 + 176;
        var val_14 = 0;
        val_13 = val_13 + 8;
        label_15:
        val_25 = (X26 + 176 + 8) + -8;
        if(val_25 == (X27 + 24))
        {
            goto label_14;
        }
        
        val_14 = val_14 + 1;
        val_13 = val_13 + 16;
        if(val_14 < (X26 + 286))
        {
            goto label_15;
        }
        
        goto label_16;
        label_34:
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X26, typeof(X27 + 24), slot: 0)) & 1) == 0)
        {
            goto label_17;
        }
        
        if((X26 + 286) == 0)
        {
            goto label_21;
        }
        
        var val_15 = X26 + 176;
        var val_16 = 0;
        val_15 = val_15 + 8;
        label_20:
        if(((X26 + 176 + 8) + -8) == X27.TargetType)
        {
            goto label_19;
        }
        
        val_16 = val_16 + 1;
        val_15 = val_15 + 16;
        if(val_16 < (X26 + 286))
        {
            goto label_20;
        }
        
        goto label_21;
        label_35:
        var val_17 = X26;
        val_17 = val_17 + ((X27 + 72) << 4);
        val_28 = mem[(X26 + (X27 + 72) << 4) + 304];
        val_28 = (X26 + (X27 + 72) << 4) + 304;
        goto label_22;
        label_17:
        var val_18 = X26;
        isCrossBubbleHit = val_18;
        val_18 = val_18 + (X27 + 72);
        goto label_41;
        label_37:
        var val_19 = val_13;
        val_19 = val_19 + val_20;
        val_18 = val_18 + val_19;
        InkWars.Model.Player val_3 = val_18 + 296;
        label_39:
        label_22:
        bool val_4 = val_18;
        goto label_41;
        label_19:
        var val_20 = val_15;
        val_20 = val_20 + (X27 + 72);
        val_20 = X26 + val_20;
        val_27 = val_20 + 296;
        label_21:
        isCrossBubbleHit = val_18;
        goto label_41;
        label_42:
        var val_5 = X25 + 0;
        val_22 = mem[(X25 + 0) + 32 + 32 + 8];
        val_22 = (X25 + 0) + 32 + 32 + 8;
        if((val_22 & 1) == 0)
        {
            goto label_27;
        }
        
        if(((X25 + 0) + 32 + 32 + 8 + 72) == 1)
        {
            goto label_40;
        }
        
        if(((X25 + 0) + 32 + 32) != 0)
        {
                if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_40;
        }
        
        }
        
        if(mem[1152921529271216888] == 0)
        {
            goto label_40;
        }
        
        if(((X25 + 0) + 32 + 32) == 0)
        {
            goto label_32;
        }
        
        if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_41;
        }
        
        if((val_22 & 1) == 0)
        {
            goto label_34;
        }
        
        if((val_22.TargetType & 1) == 0)
        {
            goto label_35;
        }
        
        if(((X25 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_39;
        }
        
        var val_21 = (X25 + 0) + 32 + 32 + 176;
        var val_22 = 0;
        val_21 = val_21 + 8;
        label_38:
        if((((X25 + 0) + 32 + 32 + 176 + 8) + -8) == ((X25 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_37;
        }
        
        val_22 = val_22 + 1;
        val_21 = val_21 + 16;
        if(val_22 < ((X25 + 0) + 32 + 32 + 286))
        {
            goto label_38;
        }
        
        goto label_39;
        label_27:
        if(((X25 + 0) + 32 + 32 + 8 + 74) != 6)
        {
            goto label_40;
        }
        
        label_32:
        bool val_7 = val_18;
        goto label_41;
        label_40:
        isCrossBubbleHit = val_18;
        label_41:
        val_23 = val_23 + 1;
        if(val_23 != val_17)
        {
            goto label_42;
        }
        
        return;
        label_4:
        if((X27 + 74) != 6)
        {
            goto label_43;
        }
        
        label_9:
        bool val_8 = val_18;
        label_43:
        isCrossBubbleHit = val_18;
        label_51:
        label_11:
        val_29 = mem[X27 + 72];
        val_29 = X27 + 72;
        if((val_1 & 1) == 0)
        {
            goto label_44;
        }
        
        val_30 = mem[X26];
        val_30 = X26;
        if((X26 + 286) == 0)
        {
            goto label_48;
        }
        
        var val_24 = 0;
        val_25 = (X26 + 176) + 8;
        label_47:
        if(((X26 + 176 + 8) + -8) == X27.TargetType)
        {
            goto label_46;
        }
        
        val_24 = val_24 + 1;
        val_25 = val_25 + 16;
        if(val_24 < (X26 + 286))
        {
            goto label_47;
        }
        
        goto label_48;
        label_12:
        var val_25 = X26;
        val_25 = val_25 + ((X27 + 72) << 4);
        val_32 = mem[(X26 + (X27 + 72) << 4) + 304];
        val_32 = (X26 + (X27 + 72) << 4) + 304;
        goto label_49;
        label_44:
        var val_26 = X26;
        val_33 = index;
        isCrossBubbleHit = val_18;
        val_26 = val_26 + val_29;
        val_30 = mem[(X26 + X27 + 72) + 296];
        val_30 = (X26 + X27 + 72) + 296;
        val_34 = mem[(X26 + X27 + 72) + 296 + 8];
        val_34 = (X26 + X27 + 72) + 296 + 8;
        goto label_50;
        label_14:
        var val_27 = val_13;
        val_27 = val_27 + (X27 + 72);
        val_28 = val_28 + val_27;
        val_26 = val_28 + 296;
        label_16:
        val_32 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X26, typeof(X27 + 24), slot: 0) + 8];
        val_32 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X26, typeof(X27 + 24), slot: 0) + 8;
        label_49:
        val_30 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X26, typeof(X27 + 24), slot: 0) + 8];
        val_30 = val_32;
        val_33 = index;
        isCrossBubbleHit = val_18;
        val_34 = val_32;
        label_50:
        val_20 = ???;
        val_19 = ???;
        val_18 = ???;
        val_21 = ???;
        val_23 = ???;
        val_35 = ???;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X26, typeof(X27 + 24), slot: 0) + 8;
        label_46:
        var val_29 = val_25;
        val_29 = val_29 + val_35;
        val_29 = val_30 + val_29;
        val_31 = val_29 + 296;
        label_48:
        var val_12 = val_18 & 1;
        goto label_51;
    }
    public virtual System.IAsyncResult BeginInvoke(InkWars.Model.BubbleStates state, InkWars.Model.Player responsiblePlayer, InkWars.Model.Player targetPlayer, int ring, int index, bool isCrossBubbleHit, System.AsyncCallback callback, object object)
    {
        bool val_1 = isCrossBubbleHit;
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
