using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredLong : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredLong>, IFormattable
    {
        // Fields
        private static long cryptoKey;
        private long currentCryptoKey;
        private long hiddenValue;
        private long fakeValue;
        private bool inited;
        
        // Methods
        private ObscuredLong(long value)
        {
        
        }
        public static void SetNewCryptoKey(long newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.cryptoKey = newKey;
        }
        public static long Encrypt(long value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.Encrypt(value:  value, key:  0);
        }
        public static long Decrypt(long value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.Decrypt(value:  value, key:  0);
        }
        public static long Encrypt(long value, long key)
        {
            long val_2;
            var val_3;
            val_2 = key;
            if(val_2 != 0)
            {
                    return (long)val_2 ^ value;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.cryptoKey;
            return (long)val_2 ^ value;
        }
        public static long Decrypt(long value, long key)
        {
            long val_2;
            var val_3;
            val_2 = key;
            if(val_2 != 0)
            {
                    return (long)val_2 ^ value;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.cryptoKey;
            return (long)val_2 ^ value;
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
        private long InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredLong op_Implicit(long value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredLong val_0;
            long val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.Encrypt(value:  value);
            bool val_2 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue = 0;
            val_0.fakeValue = value;
            return val_0;
        }
        public static long op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredLong value)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredLong op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredLong input)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredLong val_0;
            input.hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.Encrypt(value:  1152921525955782465, key:  input.currentCryptoKey);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    input.fakeValue = 1152921525955782465;
            }
            
            val_0.fakeValue = input.fakeValue;
            val_0.inited = true;
            mem[1152921525955786537] = 83394279;
            val_0.currentCryptoKey = input.currentCryptoKey;
            return val_0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredLong op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredLong input)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredLong val_0;
            input.hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.Encrypt(value:  1152921525955910559, key:  input.currentCryptoKey);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    input.fakeValue = 1152921525955910559;
            }
            
            val_0.fakeValue = input.fakeValue;
            val_0.inited = true;
            mem[1152921525955914633] = 83394779;
            val_0.currentCryptoKey = input.currentCryptoKey;
            return val_0;
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredLong obj)
        {
            long val_1 = this.fakeValue;
            val_1 = val_1 & 1;
            return (bool)val_1;
        }
        public override int GetHashCode()
        {
            return (int)this.fakeValue.GetHashCode();
        }
        public override string ToString()
        {
            return (string)this.fakeValue.ToString();
        }
        public string ToString(string format)
        {
            return (string)this.fakeValue.ToString(format:  format);
        }
        public string ToString(System.IFormatProvider provider)
        {
            return (string)this.fakeValue.ToString(provider:  provider);
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return (string)this.fakeValue.ToString(format:  format, provider:  provider);
        }
        private static ObscuredLong()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.cryptoKey = 444442;
        }
    
    }

}
