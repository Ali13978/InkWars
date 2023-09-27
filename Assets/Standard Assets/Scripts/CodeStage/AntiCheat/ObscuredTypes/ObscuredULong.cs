using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredULong : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredULong>, IFormattable
    {
        // Fields
        private static ulong cryptoKey;
        private ulong currentCryptoKey;
        private ulong hiddenValue;
        private ulong fakeValue;
        private bool inited;
        
        // Methods
        private ObscuredULong(ulong value)
        {
        
        }
        public static void SetNewCryptoKey(ulong newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.cryptoKey = newKey;
        }
        public static ulong Encrypt(ulong value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.Encrypt(value:  value, key:  0);
        }
        public static ulong Decrypt(ulong value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.Decrypt(value:  value, key:  0);
        }
        public static ulong Encrypt(ulong value, ulong key)
        {
            ulong val_2;
            var val_3;
            val_2 = key;
            if(val_2 != 0)
            {
                    return (ulong)val_2 ^ value;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.cryptoKey;
            return (ulong)val_2 ^ value;
        }
        public static ulong Decrypt(ulong value, ulong key)
        {
            ulong val_2;
            var val_3;
            val_2 = key;
            if(val_2 != 0)
            {
                    return (ulong)val_2 ^ value;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.cryptoKey;
            return (ulong)val_2 ^ value;
        }
        public void ApplyNewCryptoKey()
        {
        
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public ulong GetEncrypted()
        {
            return (ulong)this.inited;
        }
        public void SetEncrypted(ulong encrypted)
        {
        
        }
        private ulong InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredULong op_Implicit(ulong value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_0;
            ulong val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.Encrypt(value:  value);
            bool val_2 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue = 0;
            val_0.fakeValue = value;
            return val_0;
        }
        public static ulong op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredULong value)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredULong op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredULong input)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_0;
            input.hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.Encrypt(value:  1152921525988279857, key:  input.currentCryptoKey);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    input.fakeValue = 1152921525988279857;
            }
            
            val_0.fakeValue = input.fakeValue;
            val_0.inited = true;
            mem[1152921525988283929] = 83521222;
            val_0.currentCryptoKey = input.currentCryptoKey;
            return val_0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredULong op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredULong input)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_0;
            input.hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.Encrypt(value:  1152921525988407951, key:  input.currentCryptoKey);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    input.fakeValue = 1152921525988407951;
            }
            
            val_0.fakeValue = input.fakeValue;
            val_0.inited = true;
            mem[1152921525988412025] = 83521722;
            val_0.currentCryptoKey = input.currentCryptoKey;
            return val_0;
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredULong obj)
        {
            ulong val_1 = this.fakeValue;
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
        private static ObscuredULong()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.cryptoKey = 444443;
        }
    
    }

}
