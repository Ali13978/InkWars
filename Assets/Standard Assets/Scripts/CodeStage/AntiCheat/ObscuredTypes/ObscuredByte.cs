using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredByte : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredByte>, IFormattable
    {
        // Fields
        private static byte cryptoKey;
        private byte currentCryptoKey;
        private byte hiddenValue;
        private byte fakeValue;
        private bool inited;
        
        // Methods
        private ObscuredByte(byte value)
        {
        
        }
        public static void SetNewCryptoKey(byte newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredByte.cryptoKey = newKey;
        }
        public static byte EncryptDecrypt(byte value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredByte.EncryptDecrypt(value:  value, key:  0);
        }
        public static byte EncryptDecrypt(byte value, byte key)
        {
            byte val_3;
            var val_4;
            val_3 = key;
            if((val_3 & 255) != 0)
            {
                    return (byte)val_3 ^ value;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredByte.cryptoKey;
            return (byte)val_3 ^ value;
        }
        public void ApplyNewCryptoKey()
        {
        
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public byte GetEncrypted()
        {
            return (byte)1152921525936524768;
        }
        public void SetEncrypted(byte encrypted)
        {
        
        }
        private byte InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredByte op_Implicit(byte value)
        {
            byte val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredByte.EncryptDecrypt(value:  value);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredByte() {inited = false};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredByte() {inited = false};
        }
        public static byte op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte value)
        {
            return -144722724;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredByte op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte input)
        {
            byte val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredByte.EncryptDecrypt(value:  77, key:  input.currentCryptoKey);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredByte() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredByte() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredByte op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte input)
        {
            byte val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredByte.EncryptDecrypt(value:  203, key:  input.currentCryptoKey);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredByte() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredByte() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte obj)
        {
            obj.currentCryptoKey = obj.currentCryptoKey & 4294967295;
        }
        public override string ToString()
        {
            return (string)1152921525937545056.ToString();
        }
        public string ToString(string format)
        {
            return (string)1152921525937669344.ToString(format:  format);
        }
        public override int GetHashCode()
        {
            return (int)1152921525937789536.Header;
        }
        public string ToString(System.IFormatProvider provider)
        {
            return (string)1152921525937909728.ToString(provider:  provider);
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return (string)1152921525938042208.ToString(format:  format, provider:  provider);
        }
        private static ObscuredByte()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredByte.cryptoKey = 244;
        }
    
    }

}
