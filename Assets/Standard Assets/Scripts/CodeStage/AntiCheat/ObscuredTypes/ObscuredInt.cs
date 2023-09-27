using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredInt : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>, IFormattable
    {
        // Fields
        private static int cryptoKey;
        private int currentCryptoKey;
        private int hiddenValue;
        private int fakeValue;
        private bool inited;
        
        // Methods
        private ObscuredInt(int value)
        {
        
        }
        public static void SetNewCryptoKey(int newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.cryptoKey = newKey;
        }
        public static int Encrypt(int value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.Encrypt(value:  value, key:  0);
        }
        public static int Encrypt(int value, int key)
        {
            int val_2;
            var val_3;
            val_2 = key;
            if(val_2 != 0)
            {
                    return (int)val_2 ^ value;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.cryptoKey;
            return (int)val_2 ^ value;
        }
        public static int Decrypt(int value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.Decrypt(value:  value, key:  0);
        }
        public static int Decrypt(int value, int key)
        {
            int val_2;
            var val_3;
            val_2 = key;
            if(val_2 != 0)
            {
                    return (int)val_2 ^ value;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.cryptoKey;
            return (int)val_2 ^ value;
        }
        public void ApplyNewCryptoKey()
        {
        
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public int GetEncrypted()
        {
            return (int)1152921525952017152;
        }
        public void SetEncrypted(int encrypted)
        {
        
        }
        private int InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Implicit(int value)
        {
            int val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.Encrypt(value:  value);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {fakeValue = value, inited = value};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {fakeValue = value, inited = value};
        }
        public static int op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            return (int);
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  1.152922E+18f);
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.op_Implicit(value:  1.15292150460685E+18);
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Explicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  -128730912);
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt input)
        {
            int val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.Encrypt(value:  -128618911, key:  input.currentCryptoKey);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.currentCryptoKey, inited = input.hiddenValue};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.currentCryptoKey, inited = input.hiddenValue};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt input)
        {
            int val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.Encrypt(value:  -128506913, key:  input.currentCryptoKey);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = -128506913, inited = true};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = -128506913, inited = true};
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt obj)
        {
        
        }
        public override int GetHashCode()
        {
            return (int)1152921525953532800.GetHashCode();
        }
        public override string ToString()
        {
            return (string)1152921525953648896.ToString();
        }
        public string ToString(string format)
        {
            return (string)1152921525953773184.ToString(format:  format);
        }
        public string ToString(System.IFormatProvider provider)
        {
            return (string)1152921525953901568.ToString(provider:  provider);
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return (string)1152921525954034048.ToString(format:  format, provider:  provider);
        }
        private static ObscuredInt()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.cryptoKey = 444444;
        }
    
    }

}
