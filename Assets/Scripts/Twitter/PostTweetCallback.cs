using UnityEngine;

namespace Twitter
{
    public sealed class PostTweetCallback : MulticastDelegate
    {
        // Methods
        public PostTweetCallback(object object, IntPtr method)
        {
            mem[1152921529152692608] = object;
            mem[1152921529152692616] = method;
            mem[1152921529152692592] = method;
        }
        public virtual void Invoke(bool success)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            if(X24 == 0)
            {
                goto label_0;
            }
            
            if((X24 + 24) == 0)
            {
                    return;
            }
            
            var val_23 = 0;
            goto label_42;
            label_0:
            if((X22 & 1) == 0)
            {
                goto label_4;
            }
            
            if((X22 + 72) == 1)
            {
                goto label_43;
            }
            
            if(X21 != 0)
            {
                    if(((X21 + 265) & 1) != 0)
            {
                goto label_43;
            }
            
            }
            
            if((X21 + 265) == 0)
            {
                goto label_43;
            }
            
            if(X21 == 0)
            {
                goto label_9;
            }
            
            if(((X21 + 265) & 1) != 0)
            {
                    return;
            }
            
            System.Type val_1 = X22.TargetType;
            if((X22 & 1) == 0)
            {
                goto label_11;
            }
            
            if((val_1 & 1) == 0)
            {
                goto label_12;
            }
            
            var val_29 = X21;
            if((X21 + 286) == 0)
            {
                goto label_16;
            }
            
            var val_13 = X21 + 176;
            var val_14 = 0;
            val_13 = val_13 + 8;
            label_15:
            if(((X21 + 176 + 8) + -8) == (X22 + 24))
            {
                goto label_14;
            }
            
            val_14 = val_14 + 1;
            val_13 = val_13 + 16;
            if(val_14 < (X21 + 286))
            {
                goto label_15;
            }
            
            goto label_16;
            label_34:
            val_18 = mem[X22 + 72];
            val_18 = X22 + 72;
            if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(X22 + 24), slot: 0)) & 1) == 0)
            {
                goto label_17;
            }
            
            if((X21 + 286) == 0)
            {
                goto label_21;
            }
            
            var val_15 = X21 + 176;
            var val_16 = 0;
            val_15 = val_15 + 8;
            label_20:
            if(((X21 + 176 + 8) + -8) == X22.TargetType)
            {
                goto label_19;
            }
            
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            if(val_16 < (X21 + 286))
            {
                goto label_20;
            }
            
            goto label_21;
            label_35:
            var val_17 = X21;
            val_17 = val_17 + ((X22 + 72) << 4);
            val_20 = mem[(X21 + (X22 + 72) << 4) + 304];
            val_20 = (X21 + (X22 + 72) << 4) + 304;
            goto label_22;
            label_17:
            var val_18 = X21;
            bool val_3 = success;
            val_18 = val_18 + val_18;
            goto label_41;
            label_37:
            var val_19 = val_13;
            val_19 = val_19 + ((X21 + X22 + 72) + 296 + 8);
            val_18 = val_18 + val_19;
            var val_4 = val_18 + 296;
            label_39:
            val_20 = mem[(((X21 + X22 + 72) + (((X21 + 176 + 8) + 16) + (X21 + X22 + 72) + 296 + 8)) + 296) + 8];
            val_20 = (((X21 + X22 + 72) + (((X21 + 176 + 8) + 16) + (X21 + X22 + 72) + 296 + 8)) + 296) + 8;
            label_22:
            bool val_5 = success;
            goto label_41;
            label_19:
            var val_20 = val_15;
            val_20 = val_20 + val_18;
            val_20 = X21 + val_20;
            val_19 = val_20 + 296;
            label_21:
            bool val_6 = success;
            goto label_41;
            label_42:
            var val_7 = X24 + 0;
            val_16 = mem[(X24 + 0) + 32 + 32];
            val_16 = (X24 + 0) + 32 + 32;
            val_18 = mem[(X24 + 0) + 32 + 16];
            val_18 = (X24 + 0) + 32 + 16;
            if((((X24 + 0) + 32 + 32 + 8) & 1) == 0)
            {
                goto label_27;
            }
            
            if(((X24 + 0) + 32 + 32 + 8 + 72) == 1)
            {
                goto label_40;
            }
            
            if(val_16 != 0)
            {
                    if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_40;
            }
            
            }
            
            if(((X24 + 0) + 32 + 32 + 265) == 0)
            {
                goto label_40;
            }
            
            if(val_16 == 0)
            {
                goto label_32;
            }
            
            if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_41;
            }
            
            if((((X24 + 0) + 32 + 32 + 8) & 1) == 0)
            {
                goto label_34;
            }
            
            if((((X24 + 0) + 32 + 32 + 8.TargetType) & 1) == 0)
            {
                goto label_35;
            }
            
            if(((X24 + 0) + 32 + 32 + 286) == 0)
            {
                goto label_39;
            }
            
            var val_21 = (X24 + 0) + 32 + 32 + 176;
            var val_22 = 0;
            val_21 = val_21 + 8;
            label_38:
            if((((X24 + 0) + 32 + 32 + 176 + 8) + -8) == ((X24 + 0) + 32 + 32 + 8 + 24))
            {
                goto label_37;
            }
            
            val_22 = val_22 + 1;
            val_21 = val_21 + 16;
            if(val_22 < ((X24 + 0) + 32 + 32 + 286))
            {
                goto label_38;
            }
            
            goto label_39;
            label_27:
            if(((X24 + 0) + 32 + 32 + 8 + 74) != 1)
            {
                goto label_40;
            }
            
            label_32:
            bool val_9 = success;
            goto label_41;
            label_40:
            success = success;
            label_41:
            val_23 = val_23 + 1;
            if(val_23 != (X24 + 24))
            {
                goto label_42;
            }
            
            return;
            label_4:
            if((X22 + 74) != 1)
            {
                goto label_43;
            }
            
            label_9:
            bool val_10 = success;
            label_43:
            success = success;
            label_52:
            label_11:
            if((val_1 & 1) == 0)
            {
                goto label_44;
            }
            
            if((X21 + 286) == 0)
            {
                goto label_48;
            }
            
            var val_24 = X21 + 176;
            var val_25 = 0;
            val_24 = val_24 + 8;
            label_47:
            if(((X21 + 176 + 8) + -8) == X22.TargetType)
            {
                goto label_46;
            }
            
            val_25 = val_25 + 1;
            val_24 = val_24 + 16;
            if(val_25 < (X21 + 286))
            {
                goto label_47;
            }
            
            goto label_48;
            label_12:
            var val_26 = X21;
            val_26 = val_26 + ((X22 + 72) << 4);
            val_22 = mem[(X21 + (X22 + 72) << 4) + 304];
            val_22 = (X21 + (X22 + 72) << 4) + 304;
            goto label_49;
            label_44:
            var val_27 = X21;
            val_27 = val_27 + (X22 + 72);
            goto label_50;
            label_14:
            var val_28 = val_13;
            val_28 = val_28 + (X22 + 72);
            val_29 = val_29 + val_28;
            val_17 = val_29 + 296;
            label_16:
            val_22 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(X22 + 24), slot: 0) + 8];
            val_22 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X21, typeof(X22 + 24), slot: 0) + 8;
            label_49:
            bool val_12 = success;
            goto label_52;
            label_46:
            var val_30 = val_24;
            val_30 = val_30 + (X22 + 72);
            val_30 = X21 + val_30;
            val_21 = val_30 + 296;
            label_48:
            label_50:
            success = success;
            goto label_52;
        }
        public virtual System.IAsyncResult BeginInvoke(bool success, System.AsyncCallback callback, object object)
        {
            bool val_1 = success;
            return (System.IAsyncResult)this;
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
