using UnityEngine;
public sealed class Model_Events.OnTargetBubblesPopulatedDelegate : MulticastDelegate
{
    // Methods
    public Model_Events.OnTargetBubblesPopulatedDelegate(object object, IntPtr method)
    {
        mem[1152921529270484864] = object;
        mem[1152921529270484872] = method;
        mem[1152921529270484848] = method;
    }
    public virtual void Invoke(InkWars.Model.Player playerId, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        if(X26 == 0)
        {
            goto label_0;
        }
        
        if((X26 + 24) == 0)
        {
                return;
        }
        
        var val_17 = 0;
        goto label_42;
        label_0:
        if((X24 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X24 + 72) == 1)
        {
            goto label_43;
        }
        
        if(X23 != 0)
        {
                if(((X23 + 265) & 1) != 0)
        {
            goto label_43;
        }
        
        }
        
        if((X23 + 265) == 0)
        {
            goto label_43;
        }
        
        if(X23 == 0)
        {
            goto label_9;
        }
        
        if(((X23 + 265) & 1) != 0)
        {
                return;
        }
        
        System.Type val_1 = X24.TargetType;
        if((X24 & 1) == 0)
        {
            goto label_11;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_12;
        }
        
        var val_23 = X23;
        if((X23 + 286) == 0)
        {
            goto label_16;
        }
        
        var val_7 = X23 + 176;
        var val_8 = 0;
        val_7 = val_7 + 8;
        label_15:
        if(((X23 + 176 + 8) + -8) == (X24 + 24))
        {
            goto label_14;
        }
        
        val_8 = val_8 + 1;
        val_7 = val_7 + 16;
        if(val_8 < (X23 + 286))
        {
            goto label_15;
        }
        
        goto label_16;
        label_34:
        val_12 = mem[X24 + 72];
        val_12 = X24 + 72;
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X24 + 24), slot: 0)) & 1) == 0)
        {
            goto label_17;
        }
        
        if((X23 + 286) == 0)
        {
            goto label_41;
        }
        
        var val_9 = X23 + 176;
        var val_10 = 0;
        val_9 = val_9 + 8;
        label_20:
        if(((X23 + 176 + 8) + -8) == X24.TargetType)
        {
            goto label_19;
        }
        
        val_10 = val_10 + 1;
        val_9 = val_9 + 16;
        if(val_10 < (X23 + 286))
        {
            goto label_20;
        }
        
        goto label_41;
        label_35:
        var val_11 = X23;
        val_11 = val_11 + ((X24 + 72) << 4);
        val_14 = mem[(X23 + (X24 + 72) << 4) + 304];
        val_14 = (X23 + (X24 + 72) << 4) + 304;
        goto label_41;
        label_17:
        var val_12 = X23;
        val_12 = val_12 + val_12;
        goto label_41;
        label_37:
        var val_13 = val_7;
        val_13 = val_13 + loadedBubble;
        val_12 = val_12 + val_13;
        InkWars.Model.BubbleTypes val_3 = val_12 + 296;
        goto label_41;
        label_19:
        var val_14 = val_9;
        val_14 = val_14 + val_12;
        val_14 = X23 + val_14;
        val_13 = val_14 + 296;
        goto label_41;
        label_42:
        var val_4 = X26 + 0;
        val_10 = mem[(X26 + 0) + 32 + 32];
        val_10 = (X26 + 0) + 32 + 32;
        val_12 = mem[(X26 + 0) + 32 + 16];
        val_12 = (X26 + 0) + 32 + 16;
        if((((X26 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_27;
        }
        
        if(((X26 + 0) + 32 + 32 + 8 + 72) == 1)
        {
            goto label_40;
        }
        
        if(val_10 != 0)
        {
                if((((X26 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_40;
        }
        
        }
        
        if(((X26 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_40;
        }
        
        if((val_10 == 0) || ((((X26 + 0) + 32 + 32 + 265) & 1) != 0))
        {
            goto label_41;
        }
        
        if((((X26 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_34;
        }
        
        if((((X26 + 0) + 32 + 32 + 8.TargetType) & 1) == 0)
        {
            goto label_35;
        }
        
        if(((X26 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_41;
        }
        
        var val_15 = (X26 + 0) + 32 + 32 + 176;
        var val_16 = 0;
        val_15 = val_15 + 8;
        label_38:
        if((((X26 + 0) + 32 + 32 + 176 + 8) + -8) == ((X26 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_37;
        }
        
        val_16 = val_16 + 1;
        val_15 = val_15 + 16;
        if(val_16 < ((X26 + 0) + 32 + 32 + 286))
        {
            goto label_38;
        }
        
        goto label_41;
        label_27:
        if(((X26 + 0) + 32 + 32 + 8 + 74) != 3)
        {
            goto label_40;
        }
        
        goto label_41;
        label_40:
        label_41:
        val_17 = val_17 + 1;
        if(val_17 != (X26 + 24))
        {
            goto label_42;
        }
        
        return;
        label_4:
        if((X24 + 74) != 3)
        {
            goto label_43;
        }
        
        label_9:
        label_43:
        label_52:
        label_11:
        if((val_1 & 1) == 0)
        {
            goto label_44;
        }
        
        if((X23 + 286) == 0)
        {
            goto label_52;
        }
        
        var val_18 = X23 + 176;
        var val_19 = 0;
        val_18 = val_18 + 8;
        label_47:
        if(((X23 + 176 + 8) + -8) == X24.TargetType)
        {
            goto label_46;
        }
        
        val_19 = val_19 + 1;
        val_18 = val_18 + 16;
        if(val_19 < (X23 + 286))
        {
            goto label_47;
        }
        
        goto label_52;
        label_12:
        var val_20 = X23;
        val_20 = val_20 + ((X24 + 72) << 4);
        val_16 = mem[(X23 + (X24 + 72) << 4) + 304];
        val_16 = (X23 + (X24 + 72) << 4) + 304;
        goto label_52;
        label_44:
        var val_21 = X23;
        val_21 = val_21 + (X24 + 72);
        goto label_52;
        label_14:
        var val_22 = val_7;
        val_22 = val_22 + (X24 + 72);
        val_23 = val_23 + val_22;
        val_11 = val_23 + 296;
        label_16:
        val_16 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X24 + 24), slot: 0) + 8];
        val_16 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X24 + 24), slot: 0) + 8;
        goto label_52;
        label_46:
        var val_24 = val_18;
        val_24 = val_24 + (X24 + 72);
        val_24 = X23 + val_24;
        val_15 = val_24 + 296;
        goto label_52;
    }
    public virtual System.IAsyncResult BeginInvoke(InkWars.Model.Player playerId, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
