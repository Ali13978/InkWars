using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredShort : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredShort>, IFormattable
    {
        // Fields
        private static short cryptoKey;
        private short currentCryptoKey;
        private short hiddenValue;
        private short fakeValue;
        private bool inited;
        
        // Methods
        private ObscuredShort(short value)
        {
        
        }
        public static void SetNewCryptoKey(short newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredShort.cryptoKey = newKey;
        }
        public static short EncryptDecrypt(short value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredShort.EncryptDecrypt(value:  value, key:  0);
        }
        public static short EncryptDecrypt(short value, short key)
        {
            short val_3;
            var val_4;
            val_3 = key;
            if((val_3 & 65535) != 0)
            {
                    return (short)val_3 ^ value;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredShort.cryptoKey;
            return (short)val_3 ^ value;
        }
        public void ApplyNewCryptoKey()
        {
        
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public short GetEncrypted()
        {
            return (short)1152921525977928480;
        }
        public void SetEncrypted(short encrypted)
        {
        
        }
        private short InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredShort op_Implicit(short value)
        {
            short val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredShort.EncryptDecrypt(value:  value);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredShort() {inited = false};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredShort() {inited = false};
        }
        public static short op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort value)
        {
            return -103319016;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredShort op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort input)
        {
            short val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredShort.EncryptDecrypt(value:  12185);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredShort() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredShort() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredShort op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort input)
        {
            short val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredShort.EncryptDecrypt(value:  58647);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredShort() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredShort() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort obj)
        {
        
        }
        public override string ToString()
        {
            return (string)1152921525978948768.ToString();
        }
        public string ToString(string format)
        {
            return -102626532;
        }
        public override int GetHashCode()
        {
            return (int)1152921525979185056.GetHashCode();
        }
        public string ToString(System.IFormatProvider provider)
        {
            return (string)1152921525979305248.ToString(provider:  provider);
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return -102261876;
        }
        private static ObscuredShort()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredShort.cryptoKey = 214;
        }
    
    }

}
