using UnityEngine;

namespace Twitter
{
    public sealed class TwitterStreamCallback : MulticastDelegate
    {
        // Methods
        public TwitterStreamCallback(object object, IntPtr method)
        {
            mem[1152921529171726880] = object;
            mem[1152921529171726888] = method;
            mem[1152921529171726864] = method;
        }
        public virtual void Invoke(string response, Twitter.StreamMessageType messageType)
        {
            var val_22;
            var val_23;
            var val_25;
            var val_26;
            var val_27;
            var val_30;
            var val_31;
            var val_32;
            if(X25 == 0)
            {
                goto label_0;
            }
            
            if((X25 + 24) == 0)
            {
                    return;
            }
            
            var val_33 = 0;
            goto label_65;
            label_0:
            if((X22 & 1) == 0)
            {
                goto label_4;
            }
            
            if((X22 + 74) != 2)
            {
                goto label_5;
            }
            
            if((X22 + 72) == 65535)
            {
                goto label_9;
            }
            
            if(X23 != 0)
            {
                    if(((X23 + 265) & 1) != 0)
            {
                goto label_9;
            }
            
            }
            
            if((X23 + 265) == 0)
            {
                goto label_9;
            }
            
            if(X23 == 0)
            {
                goto label_70;
            }
            
            if(((X23 + 265) & 1) != 0)
            {
                    return;
            }
            
            System.Type val_1 = X22.TargetType;
            if((X22 & 1) == 0)
            {
                goto label_12;
            }
            
            if((val_1 & 1) == 0)
            {
                goto label_13;
            }
            
            var val_41 = X23;
            if((X23 + 286) == 0)
            {
                goto label_17;
            }
            
            var val_19 = X23 + 176;
            var val_20 = 0;
            val_19 = val_19 + 8;
            label_16:
            if(((X23 + 176 + 8) + -8) == (X22 + 24))
            {
                goto label_15;
            }
            
            val_20 = val_20 + 1;
            val_19 = val_19 + 16;
            if(val_20 < (X23 + 286))
            {
                goto label_16;
            }
            
            goto label_17;
            label_59:
            val_22 = mem[X22 + 72];
            val_22 = X22 + 72;
            if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0)) & 1) == 0)
            {
                goto label_18;
            }
            
            System.Type val_2 = X22.TargetType;
            var val_21 = 0;
            val_21 = val_21 + 1;
            goto label_22;
            label_60:
            string val_3 = 1152921504623673344 + ((X22 + 72) << 4);
            val_25 = mem[(1152921504623673344 + (X22 + 72) << 4) + 304];
            goto label_58;
            label_18:
            string val_4 = 1152921504623673344 + val_22;
            goto label_58;
            label_45:
            if((response & 1) == 0)
            {
                goto label_25;
            }
            
            if((X22 + 72 + 286) == 0)
            {
                goto label_58;
            }
            
            var val_22 = X22 + 72 + 176;
            var val_23 = 0;
            val_22 = val_22 + 8;
            label_28:
            if(((X22 + 72 + 176 + 8) + -8) == X22.TargetType)
            {
                goto label_27;
            }
            
            val_23 = val_23 + 1;
            val_22 = val_22 + 16;
            if(val_23 < (X22 + 72 + 286))
            {
                goto label_28;
            }
            
            goto label_58;
            label_46:
            var val_24 = val_22;
            val_24 = val_24 + ((X22 + 72) << 4);
            val_27 = mem[(X22 + 72 + (X22 + 72) << 4) + 304];
            val_27 = (X22 + 72 + (X22 + 72) << 4) + 304;
            goto label_58;
            label_25:
            var val_25 = val_22;
            val_25 = val_25 + (X22 + 72);
            goto label_58;
            label_22:
            var val_28 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(response, typeof(val_2), slot: 0);
            goto label_58;
            label_48:
            var val_27 = 1179403647;
            val_27 = val_27 + ((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(response, typeof(val_2), slot: 0) + 8);
            val_28 = val_28 + val_27;
            var val_8 = val_28 + 296;
            label_50:
            val_27 = mem[(((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(response, typeof(val_2), slot: 0) + (1179403647 + (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(response, typeof(val_2), slot: 0) + 8)) +  + 8];
            val_27 = (((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(response, typeof(val_2), slot: 0) + (1179403647 + (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(response, typeof(val_2), slot: 0) + 8)) +  + 8;
            goto label_58;
            label_27:
            var val_29 = val_22;
            val_29 = val_29 + (X22 + 72);
            val_29 = val_22 + val_29;
            val_26 = val_29 + 296;
            goto label_58;
            label_65:
            var val_9 = X25 + 0;
            val_22 = mem[(X25 + 0) + 32 + 32];
            val_22 = (X25 + 0) + 32 + 32;
            if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
            {
                goto label_37;
            }
            
            if(((X25 + 0) + 32 + 32 + 8 + 74) != 2)
            {
                goto label_38;
            }
            
            if(((X25 + 0) + 32 + 32 + 8 + 72) == 65535)
            {
                goto label_58;
            }
            
            if(val_22 != 0)
            {
                    if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_58;
            }
            
            }
            
            if(((X25 + 0) + 32 + 32 + 265) == 0)
            {
                goto label_58;
            }
            
            if(val_22 == 0)
            {
                goto label_56;
            }
            
            if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_58;
            }
            
            if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
            {
                goto label_45;
            }
            
            if((((X25 + 0) + 32 + 32 + 8.TargetType) & 1) == 0)
            {
                goto label_46;
            }
            
            if(((X25 + 0) + 32 + 32 + 286) == 0)
            {
                goto label_50;
            }
            
            var val_30 = (X25 + 0) + 32 + 32 + 176;
            var val_31 = 0;
            val_30 = val_30 + 8;
            label_49:
            if((((X25 + 0) + 32 + 32 + 176 + 8) + -8) == ((X25 + 0) + 32 + 32 + 8 + 24))
            {
                goto label_48;
            }
            
            val_31 = val_31 + 1;
            val_30 = val_30 + 16;
            if(val_31 < ((X25 + 0) + 32 + 32 + 286))
            {
                goto label_49;
            }
            
            goto label_50;
            label_37:
            if(((X25 + 0) + 32 + 32 + 8 + 74) == 2)
            {
                goto label_56;
            }
            
            goto label_58;
            label_38:
            if(((X25 + 0) + 32 + 32 + 8 + 72) == 65535)
            {
                goto label_56;
            }
            
            if(val_22 != 0)
            {
                    if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_56;
            }
            
            }
            
            if(((X25 + 0) + 32 + 32 + 265) == 0)
            {
                goto label_56;
            }
            
            if(val_22 != 0)
            {
                    if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_58;
            }
            
            }
            
            if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
            {
                goto label_59;
            }
            
            if((((X25 + 0) + 32 + 32 + 8.TargetType) & 1) == 0)
            {
                goto label_60;
            }
            
            var val_32 = 0;
            val_32 = val_32 + 1;
            goto label_58;
            label_56:
            label_58:
            val_33 = val_33 + 1;
            if(val_33 != (X25 + 24))
            {
                goto label_65;
            }
            
            return;
            label_4:
            if((X22 + 74) == 2)
            {
                goto label_70;
            }
            
            label_9:
            label_96:
            label_5:
            if((X22 + 72) == 65535)
            {
                goto label_70;
            }
            
            if(X23 != 0)
            {
                    if(((X23 + 265) & 1) != 0)
            {
                goto label_70;
            }
            
            }
            
            if((X23 + 265) == 0)
            {
                goto label_70;
            }
            
            if(X23 != 0)
            {
                    if(((X23 + 265) & 1) != 0)
            {
                    return;
            }
            
            }
            
            System.Type val_12 = X22.TargetType;
            if((X22 & 1) == 0)
            {
                goto label_73;
            }
            
            if((val_12 & 1) == 0)
            {
                goto label_74;
            }
            
            var val_34 = 0;
            val_34 = val_34 + 1;
            goto label_78;
            label_70:
            label_94:
            label_73:
            if((val_12 & 1) == 0)
            {
                goto label_79;
            }
            
            System.Type val_13 = X22.TargetType;
            var val_35 = 0;
            val_35 = val_35 + 1;
            goto label_94;
            label_74:
            string val_14 = 1152921504623673344 + ((X22 + 72) << 4);
            val_30 = mem[(1152921504623673344 + (X22 + 72) << 4) + 304];
            goto label_94;
            label_79:
            string val_15 = 1152921504623673344 + (X22 + 72);
            goto label_94;
            label_12:
            if((val_1 & 1) == 0)
            {
                goto label_86;
            }
            
            if((X23 + 286) == 0)
            {
                goto label_96;
            }
            
            var val_36 = X23 + 176;
            var val_37 = 0;
            val_36 = val_36 + 8;
            label_89:
            if(((X23 + 176 + 8) + -8) == X22.TargetType)
            {
                goto label_88;
            }
            
            val_37 = val_37 + 1;
            val_36 = val_36 + 16;
            if(val_37 < (X23 + 286))
            {
                goto label_89;
            }
            
            goto label_96;
            label_13:
            var val_38 = X23;
            val_38 = val_38 + ((X22 + 72) << 4);
            val_32 = mem[(X23 + (X22 + 72) << 4) + 304];
            val_32 = (X23 + (X22 + 72) << 4) + 304;
            goto label_96;
            label_86:
            var val_39 = X23;
            val_39 = val_39 + (X22 + 72);
            goto label_96;
            label_78:
            val_30 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(response, typeof(X22 + 24), slot: 0) + 8];
            val_30 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(response, typeof(X22 + 24), slot: 0) + 8;
            goto label_94;
            label_15:
            var val_40 = val_19;
            val_40 = val_40 + (X22 + 72);
            val_41 = val_41 + val_40;
            val_23 = val_41 + 296;
            label_17:
            val_32 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0) + 8];
            val_32 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0) + 8;
            goto label_96;
            label_88:
            var val_42 = val_36;
            val_42 = val_42 + (X22 + 72);
            val_42 = X23 + val_42;
            val_31 = val_42 + 296;
            goto label_96;
        }
        public virtual System.IAsyncResult BeginInvoke(string response, Twitter.StreamMessageType messageType, System.AsyncCallback callback, object object)
        {
            return (System.IAsyncResult)this;
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
