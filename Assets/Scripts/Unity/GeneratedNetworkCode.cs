using UnityEngine;

namespace Unity
{
    public class GeneratedNetworkCode
    {
        // Methods
        public GeneratedNetworkCode()
        {
        
        }
        public static void _WriteArrayInt32_None(UnityEngine.Networking.NetworkWriter writer, int[] value)
        {
            int val_1;
            if(value != null)
            {
                    val_1 = value.Length;
                writer.Write(value:  val_1);
                if(value.Length < 1)
            {
                    return;
            }
            
                var val_2 = 0;
                do
            {
                val_1 = value[0];
                writer.WritePackedUInt32(value:  val_1);
                val_2 = (val_2 + 1) & 65535;
            }
            while(val_2 < value.Length);
            
                return;
            }
            
            writer.Write(value:  0);
        }
        public static int[] _ReadArrayInt32_None(UnityEngine.Networking.NetworkReader reader)
        {
            var val_6;
            ushort val_2 = reader.ReadUInt16() & 65535;
            if(val_2 == 0)
            {
                goto label_2;
            }
            
            val_6 = new int[0];
            var val_6 = 0;
            goto label_9;
            label_6:
            if(reader != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_9:
            if(val_6 == null)
            {
                goto label_6;
            }
            
            label_5:
            mem2[0] = reader.ReadPackedUInt32();
            val_6 = val_6 + 1;
            if(val_2 != val_6)
            {
                goto label_9;
            }
            
            return (System.Int32[])val_6;
            label_2:
            val_6 = new int[0];
            return (System.Int32[])val_6;
        }
    
    }

}
