using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredDouble : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble>, IFormattable
    {
        // Fields
        private static long cryptoKey;
        private long currentCryptoKey;
        private byte[] hiddenValueOld;
        private CodeStage.AntiCheat.Common.ACTkByte8 hiddenValue;
        private double fakeValue;
        private bool inited;
        
        // Methods
        private ObscuredDouble(CodeStage.AntiCheat.Common.ACTkByte8 value)
        {
        
        }
        public static void SetNewCryptoKey(long newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.cryptoKey = newKey;
        }
        public static long Encrypt(double value)
        {
            null = null;
            return (long)CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.cryptoKey ^ value;
        }
        public static long Encrypt(double value, long key)
        {
            key = value ^ key;
            return (long)key;
        }
        private static CodeStage.AntiCheat.Common.ACTkByte8 InternalEncrypt(double value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.InternalEncrypt(value:  value, key:  0);
        }
        private static CodeStage.AntiCheat.Common.ACTkByte8 InternalEncrypt(double value, long key)
        {
            long val_2;
            var val_3;
            val_2 = key;
            if(val_2 != 0)
            {
                    return new CodeStage.AntiCheat.Common.ACTkByte8() {b1 = val_2 ^ value, b2 = val_2 ^ value, b3 = val_2 ^ value, b4 = val_2 ^ value, b5 = val_2 ^ value, b6 = val_2 ^ value, b7 = val_2 ^ value, b8 = val_2 ^ value};
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.cryptoKey;
            return new CodeStage.AntiCheat.Common.ACTkByte8() {b1 = val_2 ^ value, b2 = val_2 ^ value, b3 = val_2 ^ value, b4 = val_2 ^ value, b5 = val_2 ^ value, b6 = val_2 ^ value, b7 = val_2 ^ value, b8 = val_2 ^ value};
        }
        public static double Decrypt(long value)
        {
            null = null;
            long val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.cryptoKey;
            val_1 = val_1 ^ value;
            return (double)val_1;
        }
        public static double Decrypt(long value, long key)
        {
            return (double)key ^ value;
        }
        public void ApplyNewCryptoKey()
        {
        
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public long GetEncrypted()
        {
            return (long)this.inited;
        }
        public void SetEncrypted(long encrypted)
        {
        
        }
        private double InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Implicit(double value)
        {
            var val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble val_0;
            val_3 = null;
            CodeStage.AntiCheat.Common.ACTkByte8 val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.InternalEncrypt(value:  value);
            bool val_2 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning;
            val_0.inited = false;
            mem[1152921525945756849] = 0;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValueOld = null;
            val_0.hiddenValue.b1 = 0;
            val_0.hiddenValue.b2 = 0;
            val_0.hiddenValue.b3 = 0;
            val_0.hiddenValue.b4 = 0;
            val_0.hiddenValue.b5 = 0;
            val_0.hiddenValue.b6 = 0;
            val_0.hiddenValue.b7 = 0;
            val_0.hiddenValue.b8 = 0;
            val_0.fakeValue = 0;
            return val_0;
        }
        public static double op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble value)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble input)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble val_0;
            double val_1 = D0 + 1;
            CodeStage.AntiCheat.Common.ACTkByte8 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.InternalEncrypt(value:  val_1, key:  input.currentCryptoKey);
            input.hiddenValue.b1 = val_2.b1;
            input.hiddenValue.b2 = val_2.b2;
            input.hiddenValue.b3 = val_2.b3;
            input.hiddenValue.b4 = val_2.b4;
            input.hiddenValue.b5 = val_2.b5;
            input.hiddenValue.b6 = val_2.b6;
            input.hiddenValue.b7 = val_2.b7;
            input.hiddenValue.b8 = val_2.b8;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    input.fakeValue = val_1;
            }
            
            val_0.inited = input.inited;
            val_0.hiddenValue.b1 = input.hiddenValue.b1;
            val_0.hiddenValue.b2 = val_2.b2;
            val_0.hiddenValue.b3 = val_2.b3;
            val_0.hiddenValue.b4 = val_2.b4;
            val_0.hiddenValue.b5 = val_2.b5;
            val_0.hiddenValue.b6 = val_2.b6;
            val_0.hiddenValue.b7 = val_2.b7;
            val_0.hiddenValue.b8 = val_2.b8;
            val_0.currentCryptoKey = input.currentCryptoKey;
            return val_0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble input)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble val_0;
            double val_1 = D0 + (-1);
            CodeStage.AntiCheat.Common.ACTkByte8 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.InternalEncrypt(value:  val_1, key:  input.currentCryptoKey);
            input.hiddenValue.b1 = val_2.b1;
            input.hiddenValue.b2 = val_2.b2;
            input.hiddenValue.b3 = val_2.b3;
            input.hiddenValue.b4 = val_2.b4;
            input.hiddenValue.b5 = val_2.b5;
            input.hiddenValue.b6 = val_2.b6;
            input.hiddenValue.b7 = val_2.b7;
            input.hiddenValue.b8 = val_2.b8;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    input.fakeValue = val_1;
            }
            
            val_0.inited = input.inited;
            val_0.hiddenValue.b1 = input.hiddenValue.b1;
            val_0.hiddenValue.b2 = val_2.b2;
            val_0.hiddenValue.b3 = val_2.b3;
            val_0.hiddenValue.b4 = val_2.b4;
            val_0.hiddenValue.b5 = val_2.b5;
            val_0.hiddenValue.b6 = val_2.b6;
            val_0.hiddenValue.b7 = val_2.b7;
            val_0.hiddenValue.b8 = val_2.b8;
            val_0.currentCryptoKey = input.currentCryptoKey;
            return val_0;
        }
        public override string ToString()
        {
            return (string)???.ToString();
        }
        public string ToString(string format)
        {
            return (string)???.ToString(format:  format);
        }
        public string ToString(System.IFormatProvider provider)
        {
            return (string)???.ToString(provider:  provider);
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return (string)???.ToString(format:  format, provider:  provider);
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble obj)
        {
            CodeStage.AntiCheat.Common.ACTkByte8 val_1 = this.hiddenValue;
            val_1 = val_1 & 1;
            return (bool)val_1;
        }
        public override int GetHashCode()
        {
            return (int)???.GetHashCode();
        }
        private static ObscuredDouble()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.cryptoKey = 210987;
        }
    
    }

}
