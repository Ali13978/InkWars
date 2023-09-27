using UnityEngine;

namespace CodeStage.AntiCheat.Utils
{
    internal class xxHash
    {
        // Fields
        private const uint PRIME32_1 = 2654435761;
        private const uint PRIME32_2 = 2246822519;
        private const uint PRIME32_3 = 3266489917;
        private const uint PRIME32_4 = 668265263;
        private const uint PRIME32_5 = 374761393;
        
        // Methods
        public static uint CalculateHash(byte[] buf, int len, uint seed)
        {
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            int val_27;
            var val_28;
            var val_29;
            byte val_30;
            var val_31;
            byte val_32;
            int val_33;
            var val_34;
            int val_35;
            var val_36;
            val_23 = 2654404608;
            val_23 = 40503;
            val_24 = 2246770688;
            val_24 = 34283;
            if()
            {
                    val_25 = 0;
                val_26 = seed + 374761393;
            }
            else
            {
                    uint val_4 = seed + 1640531535;
                var val_57 = 15;
                do
            {
                val_27 = buf.Length;
                if(0 >= val_27)
            {
                    val_27 = buf.Length;
            }
            
                var val_6 = 0 + 1;
                if(val_6 >= val_27)
            {
                    val_27 = buf.Length;
            }
            
                byte val_43 = buf[(long)val_57 - 14];
                var val_8 = val_6 + 1;
                if(val_8 >= val_27)
            {
                    val_27 = buf.Length;
            }
            
                byte val_44 = buf[(long)val_57 - 13];
                val_8 = val_8 + 1;
                if(val_8 >= val_27)
            {
                    val_27 = buf.Length;
            }
            
                byte val_45 = buf[(long)val_57 - 12];
                val_8 = val_8 + 1;
                if(val_8 >= val_27)
            {
                    val_27 = buf.Length;
            }
            
                val_6 = val_8 + 1;
                if(val_6 >= val_27)
            {
                    val_27 = buf.Length;
            }
            
                byte val_47 = buf[(long)val_57 - 10];
                val_6 = val_6 + 1;
                if(val_6 >= val_27)
            {
                    val_27 = buf.Length;
            }
            
                byte val_48 = buf[(long)val_57 - 9];
                val_6 = val_6 + 1;
                if(val_6 >= val_27)
            {
                    val_27 = buf.Length;
            }
            
                byte val_49 = buf[(long)val_57 - 8];
                var val_15 = val_6 + 1;
                if(val_15 >= val_27)
            {
                    val_27 = buf.Length;
            }
            
                val_15 = val_15 + 1;
                if(val_15 >= val_27)
            {
                    val_27 = buf.Length;
            }
            
                var val_18 = val_15 + 1;
                byte val_51 = buf[(long)val_57 - 6];
                if(val_18 >= val_27)
            {
                    val_27 = buf.Length;
            }
            
                val_18 = val_18 + 1;
                byte val_52 = buf[(long)val_57 - 5];
                if(val_18 >= val_27)
            {
                    val_27 = buf.Length;
            }
            
                val_18 = val_18 + 1;
                byte val_53 = buf[(long)val_57 - 4];
                if(val_18 >= val_27)
            {
                    val_27 = buf.Length;
            }
            
                val_18 = val_18 + 1;
                if(val_18 >= val_27)
            {
                    val_27 = buf.Length;
            }
            
                val_28 = ((seed + 606290984) + (buf[0] * 2246822519)) >> 19;
                val_29 = ((seed + 2246822519) + ((buf[(long)val_57 - 11]) * 2246822519)) >> 19;
                val_30 = buf[(long)val_57 - 2];
                val_31 = (seed + ((buf[(long)val_57 - 7]) * 2246822519)) >> 19;
                var val_26 = val_18 + 1;
                if(val_26 >= val_27)
            {
                    val_27 = buf.Length;
                val_31 = val_31;
            }
            
                val_23 = 2654404608;
                val_23 = 40503;
                byte val_27 = val_28 * 2654435761;
                byte val_28 = val_29 * 2654435761;
                byte val_29 = val_31 * 2654435761;
                byte val_55 = buf[(long)val_57 - 1];
                val_32 = val_26 + 1;
                if(val_32 >= val_27)
            {
                    val_31 = val_31;
                val_29 = val_29;
                val_28 = val_28;
                val_30 = val_30;
            }
            
                byte val_56 = buf[15];
                byte val_31 = val_4 + ((buf[(long)val_57 - 3]) * 2246822519);
                val_31 = val_31 >> 19;
                val_24 = 2246770688;
                val_24 = 34283;
                val_4 = val_31 * 2654435761;
                val_57 = val_57 + 16;
            }
            while((val_32 + 1) <= (len - 16));
            
                val_31 = val_31 * 3871604736;
                byte val_33 = val_28 * 1013904226;
                val_33 = len;
                val_33 = (val_29 * 465361024) + val_33;
                val_33 = val_33 + (val_31 * 2006650880);
                val_26 = val_33 + val_31;
                val_25 = val_57 - 15;
            }
            
            int val_35 = val_33 - 4;
            val_34 = val_26 + val_33;
            if(val_25 <= val_35)
            {
                    val_28 = 668205056;
                val_28 = 10196;
                do
            {
                val_35 = buf.Length;
                val_25 = val_25 + 1;
                if(val_25 >= val_35)
            {
                    val_35 = buf.Length;
            }
            
                var val_36 = val_25 + 1;
                if(val_36 >= val_35)
            {
                    val_35 = buf.Length;
            }
            
                byte val_59 = buf[(long)val_25];
                val_36 = val_36 + 1;
                if(val_36 >= val_35)
            {
                    val_35 = buf.Length;
            }
            
                val_32 = buf[(long)val_25 + 2];
                val_36 = val_36 + 1;
                byte val_60 = buf[(long)val_25 + 3];
                byte val_40 = val_34 + (buf[(long)val_25] * 3266489917);
                val_40 = val_40 >> 15;
                val_34 = val_40 * 668265263;
                val_23 = 2654404608;
                val_23 = 40503;
            }
            while((val_36 + 1) <= val_35);
            
                val_33 = len;
                val_25 = val_25 + 4;
                val_24 = 2246770688;
                val_24 = 34283;
            }
            
            if(val_25 < val_33)
            {
                    val_36 = 374734848;
                val_36 = 5718;
                do
            {
                if(buf == null)
            {
                    val_36 = 374734848;
                val_36 = 5718;
            }
            
                int val_61 = buf.Length;
                if(val_25 >= val_61)
            {
                    val_36 = 374734848;
                val_36 = 5718;
            }
            
                val_28 = ((long)val_33 - (val_25 << )) - 1;
                val_25 = val_25 + 1;
                val_61 = val_34 + (val_61 * 374761393);
                val_61 = val_61 >> 21;
                val_34 = val_61 * 2654435761;
            }
            while(val_28 != 0);
            
            }
            
            var val_62 = 0;
            val_62 = val_62 * 2246822519;
            return 0;
        }
        public xxHash()
        {
        
        }
    
    }

}
