using UnityEngine;
public sealed class Model_Events.OnBattleEnhancerDelegate : MulticastDelegate
{
    // Methods
    public Model_Events.OnBattleEnhancerDelegate(object object, IntPtr method)
    {
        mem[1152921529272222080] = object;
        mem[1152921529272222088] = method;
        mem[1152921529272222064] = method;
    }
    public virtual void Invoke(float timeStamp, InkWars.Model.Player playerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)
    {
        Model_Events.OnBattleEnhancerDelegate val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_10 = this;
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
        
        var val_22 = X24;
        if((X24 + 286) == 0)
        {
            goto label_16;
        }
        
        var val_7 = X24 + 176;
        var val_8 = 0;
        val_7 = val_7 + 8;
        label_15:
        if(((X24 + 176 + 8) + -8) == (X25 + 24))
        {
            goto label_14;
        }
        
        val_8 = val_8 + 1;
        val_7 = val_7 + 16;
        if(val_8 < (X24 + 286))
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
            goto label_41;
        }
        
        var val_9 = X24 + 176;
        var val_10 = 0;
        val_9 = val_9 + 8;
        label_20:
        if(((X24 + 176 + 8) + -8) == X25.TargetType)
        {
            goto label_19;
        }
        
        val_10 = val_10 + 1;
        val_9 = val_9 + 16;
        if(val_10 < (X24 + 286))
        {
            goto label_20;
        }
        
        goto label_41;
        label_35:
        var val_11 = X24;
        val_11 = val_11 + ((X25 + 72) << 4);
        val_14 = mem[(X24 + (X25 + 72) << 4) + 304];
        val_14 = (X24 + (X25 + 72) << 4) + 304;
        goto label_41;
        label_17:
        var val_12 = X24;
        val_12 = val_12 + (X25 + 72);
        goto label_41;
        label_37:
        var val_13 = val_7;
        val_13 = val_13 + type;
        val_12 = val_12 + val_13;
        InkWars.Model.BattleEnhancerType val_3 = val_12 + 296;
        goto label_41;
        label_19:
        var val_14 = val_9;
        val_14 = val_14 + (X25 + 72);
        val_14 = X24 + val_14;
        val_13 = val_14 + 296;
        goto label_41;
        label_42:
        var val_4 = X27 + 0;
        val_11 = mem[(X27 + 0) + 32 + 32 + 8];
        val_11 = (X27 + 0) + 32 + 32 + 8;
        if((val_11 & 1) == 0)
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
        
        if(mem[1152921529272366840] == 0)
        {
            goto label_40;
        }
        
        if((((X27 + 0) + 32 + 32) == 0) || ((((X27 + 0) + 32 + 32 + 265) & 1) != 0))
        {
            goto label_41;
        }
        
        if((val_11 & 1) == 0)
        {
            goto label_34;
        }
        
        if((val_11.TargetType & 1) == 0)
        {
            goto label_35;
        }
        
        if(((X27 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_41;
        }
        
        var val_15 = (X27 + 0) + 32 + 32 + 176;
        var val_16 = 0;
        val_15 = val_15 + 8;
        label_38:
        if((((X27 + 0) + 32 + 32 + 176 + 8) + -8) == ((X27 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_37;
        }
        
        val_16 = val_16 + 1;
        val_15 = val_15 + 16;
        if(val_16 < ((X27 + 0) + 32 + 32 + 286))
        {
            goto label_38;
        }
        
        goto label_41;
        label_27:
        if(((X27 + 0) + 32 + 32 + 8 + 74) != 5)
        {
            goto label_40;
        }
        
        goto label_41;
        label_40:
        label_41:
        val_10 = 0 + 1;
        if(val_10 != (X27 + 24))
        {
            goto label_42;
        }
        
        return;
        label_4:
        if((X25 + 74) != 5)
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
        
        if((X24 + 286) == 0)
        {
            goto label_52;
        }
        
        var val_17 = X24 + 176;
        var val_18 = 0;
        val_17 = val_17 + 8;
        label_47:
        if(((X24 + 176 + 8) + -8) == X25.TargetType)
        {
            goto label_46;
        }
        
        val_18 = val_18 + 1;
        val_17 = val_17 + 16;
        if(val_18 < (X24 + 286))
        {
            goto label_47;
        }
        
        goto label_52;
        label_12:
        var val_19 = X24;
        val_19 = val_19 + ((X25 + 72) << 4);
        val_16 = mem[(X24 + (X25 + 72) << 4) + 304];
        val_16 = (X24 + (X25 + 72) << 4) + 304;
        goto label_52;
        label_44:
        var val_20 = X24;
        val_20 = val_20 + (X25 + 72);
        goto label_52;
        label_14:
        var val_21 = val_7;
        val_21 = val_21 + (X25 + 72);
        val_22 = val_22 + val_21;
        val_12 = val_22 + 296;
        label_16:
        val_16 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X24, typeof(X25 + 24), slot: 0) + 8];
        val_16 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X24, typeof(X25 + 24), slot: 0) + 8;
        goto label_52;
        label_46:
        var val_23 = val_17;
        val_23 = val_23 + (X25 + 72);
        val_23 = X24 + val_23;
        val_15 = val_23 + 296;
        goto label_52;
    }
    public virtual System.IAsyncResult BeginInvoke(float timeStamp, InkWars.Model.Player playerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
