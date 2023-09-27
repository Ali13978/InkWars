using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredSByte : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte>, IFormattable
    {
        // Fields
        private static sbyte cryptoKey;
        private sbyte currentCryptoKey;
        private sbyte hiddenValue;
        private sbyte fakeValue;
        private bool inited;
        
        // Methods
        private ObscuredSByte(sbyte value)
        {
        
        }
        public static void SetNewCryptoKey(sbyte newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte.cryptoKey = newKey;
        }
        public static sbyte EncryptDecrypt(sbyte value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte.EncryptDecrypt(value:  value, key:  0);
        }
        public static sbyte EncryptDecrypt(sbyte value, sbyte key)
        {
            sbyte val_3;
            var val_4;
            val_3 = key;
            if((val_3 & 255) != 0)
            {
                    return (sbyte)val_3 ^ value;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte.cryptoKey;
            return (sbyte)val_3 ^ value;
        }
        public void ApplyNewCryptoKey()
        {
        
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public sbyte GetEncrypted()
        {
            return (sbyte)1152921525975519136;
        }
        public void SetEncrypted(sbyte encrypted)
        {
        
        }
        private sbyte InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte op_Implicit(sbyte value)
        {
            sbyte val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte.EncryptDecrypt(value:  value);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte() {inited = false};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte() {inited = false};
        }
        public static sbyte op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte value)
        {
            return -105728356;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte input)
        {
            sbyte val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte.EncryptDecrypt(value:  13, key:  input.currentCryptoKey);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte input)
        {
            sbyte val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte.EncryptDecrypt(value:  139, key:  input.currentCryptoKey);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte obj)
        {
            obj.currentCryptoKey = obj.currentCryptoKey & 4294967295;
        }
        public override string ToString()
        {
            return (string)1152921525976539424.ToString();
        }
        public string ToString(string format)
        {
            return -105035876;
        }
        public override int GetHashCode()
        {
            return (int)1152921525976775712.GetHashCode();
        }
        public string ToString(System.IFormatProvider provider)
        {
            return (string)1152921525976895904.ToString(provider:  provider);
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return -104671220;
        }
        private static ObscuredSByte()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte.cryptoKey = 112;
        }
    
    }

}
