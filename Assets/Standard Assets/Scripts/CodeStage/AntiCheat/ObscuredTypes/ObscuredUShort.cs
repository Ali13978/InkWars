using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredUShort : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort>, IFormattable
    {
        // Fields
        private static ushort cryptoKey;
        private ushort currentCryptoKey;
        private ushort hiddenValue;
        private ushort fakeValue;
        private bool inited;
        
        // Methods
        private ObscuredUShort(ushort value)
        {
        
        }
        public static void SetNewCryptoKey(ushort newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort.cryptoKey = newKey;
        }
        public static ushort EncryptDecrypt(ushort value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort.EncryptDecrypt(value:  value, key:  0);
        }
        public static ushort EncryptDecrypt(ushort value, ushort key)
        {
            ushort val_3;
            var val_4;
            val_3 = key;
            if((val_3 & 65535) != 0)
            {
                    return (ushort)val_3 ^ value;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort.cryptoKey;
            return (ushort)val_3 ^ value;
        }
        public void ApplyNewCryptoKey()
        {
        
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public ushort GetEncrypted()
        {
            return (ushort)1152921525990145840;
        }
        public void SetEncrypted(ushort encrypted)
        {
        
        }
        private ushort InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort op_Implicit(ushort value)
        {
            ushort val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort.EncryptDecrypt(value:  value);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort() {inited = false};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort() {inited = false};
        }
        public static ushort op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort value)
        {
            return -91101656;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort input)
        {
            ushort val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort.EncryptDecrypt(value:  39833, key:  input.currentCryptoKey);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort input)
        {
            ushort val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort.EncryptDecrypt(value:  20759, key:  input.currentCryptoKey);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort obj)
        {
        
        }
        public override string ToString()
        {
            return (string)1152921525991166128.ToString();
        }
        public string ToString(string format)
        {
            return (string)1152921525991290416.ToString(format:  format);
        }
        public override int GetHashCode()
        {
            return (int)1152921525991410608.Mask;
        }
        public string ToString(System.IFormatProvider provider)
        {
            return (string)1152921525991530800.ToString(provider:  provider);
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return (string)1152921525991663280.ToString(format:  format, provider:  provider);
        }
        private static ObscuredUShort()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort.cryptoKey = 224;
        }
    
    }

}
