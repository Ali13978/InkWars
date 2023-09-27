using UnityEngine;
public sealed class Model_Events.OnPlayerSwitchDelegate : MulticastDelegate
{
    // Methods
    public Model_Events.OnPlayerSwitchDelegate(object object, IntPtr method)
    {
        mem[1152921529265917824] = object;
        mem[1152921529265917832] = method;
        mem[1152921529265917808] = method;
    }
    public virtual void Invoke(InkWars.Model.Player playerId, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, bool manualSwitch)
    {
        Model_Events.OnPlayerSwitchDelegate val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_13 = this;
        if(X27 == 0)
        {
            goto label_0;
        }
        
        if((X27 + 24) == 0)
        {
                return;
        }
        
        goto label_42;
        label_0:
        if((X25 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X25 + 72) == 1)
        {
            goto label_43;
        }
        
        if(X24 != 0)
        {
                if(((X24 + 265) & 1) != 0)
        {
            goto label_43;
        }
        
        }
        
        if((X24 + 265) == 0)
        {
            goto label_43;
        }
        
        if(X24 == 0)
        {
            goto label_9;
        }
        
        if(((X24 + 265) & 1) != 0)
        {
                return;
        }
        
        System.Type val_1 = X25.TargetType;
        if((X25 & 1) == 0)
        {
            goto label_11;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_12;
        }
        
        var val_25 = X24;
        if((X24 + 286) == 0)
        {
            goto label_16;
        }
        
        var val_10 = X24 + 176;
        var val_11 = 0;
        val_10 = val_10 + 8;
        label_15:
        if(((X24 + 176 + 8) + -8) == (X25 + 24))
        {
            goto label_14;
        }
        
        val_11 = val_11 + 1;
        val_10 = val_10 + 16;
        if(val_11 < (X24 + 286))
        {
            goto label_15;
        }
        
        goto label_16;
        label_34:
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X24, typeof(X25 + 24), slot: 0)) & 1) == 0)
        {
            goto label_17;
        }
        
        if((X24 + 286) == 0)
        {
            goto label_21;
        }
        
        var val_12 = X24 + 176;
        var val_13 = 0;
        val_12 = val_12 + 8;
        label_20:
        if(((X24 + 176 + 8) + -8) == X25.TargetType)
        {
            goto label_19;
        }
        
        val_13 = val_13 + 1;
        val_12 = val_12 + 16;
        if(val_13 < (X24 + 286))
        {
            goto label_20;
        }
        
        goto label_21;
        label_35:
        var val_14 = X24;
        val_14 = val_14 + ((X25 + 72) << 4);
        val_17 = mem[(X24 + (X25 + 72) << 4) + 304];
        val_17 = (X24 + (X25 + 72) << 4) + 304;
        goto label_22;
        label_17:
        var val_15 = X24;
        manualSwitch = manualSwitch;
        val_15 = val_15 + (X25 + 72);
        goto label_41;
        label_37:
        var val_16 = val_10;
        val_16 = val_16 + loadedBubble;
        val_15 = val_15 + val_16;
        InkWars.Model.BubbleTypes val_3 = val_15 + 296;
        label_39:
        label_22:
        bool val_4 = manualSwitch;
        goto label_41;
        label_19:
        var val_17 = val_12;
        val_17 = val_17 + (X25 + 72);
        val_17 = X24 + val_17;
        val_16 = val_17 + 296;
        label_21:
        manualSwitch = manualSwitch;
        goto label_41;
        label_42:
        var val_5 = X27 + 0;
        val_14 = mem[(X27 + 0) + 32 + 32 + 8];
        val_14 = (X27 + 0) + 32 + 32 + 8;
        if((val_14 & 1) == 0)
        {
            goto label_27;
        }
        
        if(((X27 + 0) + 32 + 32 + 8 + 72) == 1)
        {
            goto label_40;
        }
        
        if(((X27 + 0) + 32 + 32) != 0)
        {
                if((((X27 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_40;
        }
        
        }
        
        if(mem[1152921529266062584] == 0)
        {
            goto label_40;
        }
        
        if(((X27 + 0) + 32 + 32) == 0)
        {
            goto label_32;
        }
        
        if((((X27 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_41;
        }
        
        if((val_14 & 1) == 0)
        {
            goto label_34;
        }
        
        if((val_14.TargetType & 1) == 0)
        {
            goto label_35;
        }
        
        if(((X27 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_39;
        }
        
        var val_18 = (X27 + 0) + 32 + 32 + 176;
        var val_19 = 0;
        val_18 = val_18 + 8;
        label_38:
        if((((X27 + 0) + 32 + 32 + 176 + 8) + -8) == ((X27 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_37;
        }
        
        val_19 = val_19 + 1;
        val_18 = val_18 + 16;
        if(val_19 < ((X27 + 0) + 32 + 32 + 286))
        {
            goto label_38;
        }
        
        goto label_39;
        label_27:
        if(((X27 + 0) + 32 + 32 + 8 + 74) != 4)
        {
            goto label_40;
        }
        
        label_32:
        bool val_7 = manualSwitch;
        goto label_41;
        label_40:
        manualSwitch = manualSwitch;
        label_41:
        val_13 = 0 + 1;
        if(val_13 != (X27 + 24))
        {
            goto label_42;
        }
        
        return;
        label_4:
        if((X25 + 74) != 4)
        {
            goto label_43;
        }
        
        label_9:
        bool val_8 = manualSwitch;
        label_43:
        manualSwitch = manualSwitch;
        label_52:
        label_11:
        if((val_1 & 1) == 0)
        {
            goto label_44;
        }
        
        if((X24 + 286) == 0)
        {
            goto label_48;
        }
        
        var val_20 = X24 + 176;
        var val_21 = 0;
        val_20 = val_20 + 8;
        label_47:
        if(((X24 + 176 + 8) + -8) == X25.TargetType)
        {
            goto label_46;
        }
        
        val_21 = val_21 + 1;
        val_20 = val_20 + 16;
        if(val_21 < (X24 + 286))
        {
            goto label_47;
        }
        
        goto label_48;
        label_12:
        var val_22 = X24;
        val_22 = val_22 + ((X25 + 72) << 4);
        val_19 = mem[(X24 + (X25 + 72) << 4) + 304];
        val_19 = (X24 + (X25 + 72) << 4) + 304;
        goto label_49;
        label_44:
        var val_23 = X24;
        val_23 = val_23 + (X25 + 72);
        goto label_50;
        label_14:
        var val_24 = val_10;
        val_24 = val_24 + (X25 + 72);
        val_25 = val_25 + val_24;
        val_15 = val_25 + 296;
        label_16:
        val_19 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X24, typeof(X25 + 24), slot: 0) + 8];
        val_19 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X24, typeof(X25 + 24), slot: 0) + 8;
        label_49:
        manualSwitch = manualSwitch;
        goto label_52;
        label_46:
        var val_26 = val_20;
        val_26 = val_26 + (X25 + 72);
        val_26 = X24 + val_26;
        val_18 = val_26 + 296;
        label_48:
        label_50:
        manualSwitch = manualSwitch;
        goto label_52;
    }
    public virtual System.IAsyncResult BeginInvoke(InkWars.Model.Player playerId, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, bool manualSwitch, System.AsyncCallback callback, object object)
    {
        bool val_1 = manualSwitch;
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
