using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredUInt : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt>, IFormattable
    {
        // Fields
        private static uint cryptoKey;
        private uint currentCryptoKey;
        private uint hiddenValue;
        private uint fakeValue;
        private bool inited;
        
        // Methods
        private ObscuredUInt(uint value)
        {
        
        }
        public static void SetNewCryptoKey(uint newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.cryptoKey = newKey;
        }
        public static uint Encrypt(uint value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.Encrypt(value:  value, key:  0);
        }
        public static uint Decrypt(uint value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.Decrypt(value:  value, key:  0);
        }
        public static uint Encrypt(uint value, uint key)
        {
            uint val_2;
            var val_3;
            val_2 = key;
            if(val_2 != 0)
            {
                    return (uint)val_2 ^ value;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.cryptoKey;
            return (uint)val_2 ^ value;
        }
        public static uint Decrypt(uint value, uint key)
        {
            uint val_2;
            var val_3;
            val_2 = key;
            if(val_2 != 0)
            {
                    return (uint)val_2 ^ value;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.cryptoKey;
            return (uint)val_2 ^ value;
        }
        public void ApplyNewCryptoKey()
        {
        
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public uint GetEncrypted()
        {
            return (uint)1152921525984902000;
        }
        public void SetEncrypted(uint encrypted)
        {
        
        }
        private uint InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Implicit(uint value)
        {
            uint val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.Encrypt(value:  value);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {fakeValue = value, inited = value};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {fakeValue = value, inited = value};
        }
        public static uint op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt value)
        {
            return (uint);
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Explicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  -96233520);
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt input)
        {
            uint val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.Encrypt(value:  -96121519, key:  input.currentCryptoKey);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.currentCryptoKey, inited = input.hiddenValue};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.currentCryptoKey, inited = input.hiddenValue};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt input)
        {
            uint val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.Encrypt(value:  -96009521, key:  input.currentCryptoKey);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = -96009521, inited = true};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = -96009521, inited = true};
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt obj)
        {
        
        }
        public override string ToString()
        {
            return (string)1152921525986034288.ToString();
        }
        public string ToString(string format)
        {
            return (string)1152921525986158576.ToString(format:  format);
        }
        public override int GetHashCode()
        {
            return (int)1152921525986278768.GetHashCode();
        }
        public string ToString(System.IFormatProvider provider)
        {
            return (string)1152921525986398960.ToString(provider:  provider);
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return (string)1152921525986531440.ToString(format:  format, provider:  provider);
        }
        private static ObscuredUInt()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.cryptoKey = 240513;
        }
    
    }

}
