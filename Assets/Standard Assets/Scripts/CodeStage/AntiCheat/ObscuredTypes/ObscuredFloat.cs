using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredFloat : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat>, IFormattable
    {
        // Fields
        private static int cryptoKey;
        private int currentCryptoKey;
        private CodeStage.AntiCheat.Common.ACTkByte4 hiddenValue;
        private byte[] hiddenValueOld;
        private float fakeValue;
        private bool inited;
        
        // Methods
        private ObscuredFloat(CodeStage.AntiCheat.Common.ACTkByte4 value)
        {
            value.b1 = value.b1 & 4294967295;
        }
        public static void SetNewCryptoKey(int newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.cryptoKey = newKey;
        }
        public static int Encrypt(float value)
        {
            null = null;
            return (int)CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.cryptoKey ^ value;
        }
        public static int Encrypt(float value, int key)
        {
            key = value ^ key;
            return (int)key;
        }
        private static CodeStage.AntiCheat.Common.ACTkByte4 InternalEncrypt(float value)
        {
            CodeStage.AntiCheat.Common.ACTkByte4 val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.InternalEncrypt(value:  value, key:  0);
            val_1.b1 = val_1.b1 & 4294967295;
            return new CodeStage.AntiCheat.Common.ACTkByte4() {b1 = val_1.b1, b2 = val_1.b1, b3 = val_1.b1, b4 = val_1.b1};
        }
        private static CodeStage.AntiCheat.Common.ACTkByte4 InternalEncrypt(float value, int key)
        {
            int val_2;
            var val_3;
            val_2 = key;
            if(val_2 != 0)
            {
                    return new CodeStage.AntiCheat.Common.ACTkByte4() {b1 = val_2 ^ value, b2 = val_2 ^ value, b3 = val_2 ^ value, b4 = val_2 ^ value};
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.cryptoKey;
            return new CodeStage.AntiCheat.Common.ACTkByte4() {b1 = val_2 ^ value, b2 = val_2 ^ value, b3 = val_2 ^ value, b4 = val_2 ^ value};
        }
        public static float Decrypt(int value)
        {
            null = null;
            int val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.cryptoKey;
            val_1 = val_1 ^ value;
            return (float)val_1;
        }
        public static float Decrypt(int value, int key)
        {
            return (float)key ^ value;
        }
        public void ApplyNewCryptoKey()
        {
        
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public int GetEncrypted()
        {
            return (int)this.inited;
        }
        public void SetEncrypted(int encrypted)
        {
        
        }
        private float InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Implicit(float value)
        {
            var val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_0;
            val_4 = null;
            CodeStage.AntiCheat.Common.ACTkByte4 val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.InternalEncrypt(value:  value);
            byte val_2 = val_1.b1 & 4294967295;
            bool val_3 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning;
            val_0.fakeValue = value;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.b1 = 0;
            val_0.hiddenValue.b2 = 0;
            val_0.hiddenValue.b3 = 0;
            val_0.hiddenValue.b4 = 0;
            val_0.hiddenValueOld = null;
            return val_0;
        }
        public static float op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat value)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat input)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_0;
            float val_1 = S0 + 1f;
            CodeStage.AntiCheat.Common.ACTkByte4 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.InternalEncrypt(value:  val_1, key:  input.currentCryptoKey);
            input.hiddenValue.b1 = val_2.b1;
            input.hiddenValue.b2 = val_2.b2;
            input.hiddenValue.b3 = val_2.b3;
            input.hiddenValue.b4 = val_2.b4;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    input.fakeValue = val_1;
            }
            
            val_0.fakeValue = input.fakeValue;
            val_0.currentCryptoKey = input.currentCryptoKey;
            return val_0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat input)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_0;
            float val_1 = S0 + (-1f);
            CodeStage.AntiCheat.Common.ACTkByte4 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.InternalEncrypt(value:  val_1, key:  input.currentCryptoKey);
            input.hiddenValue.b1 = val_2.b1;
            input.hiddenValue.b2 = val_2.b2;
            input.hiddenValue.b3 = val_2.b3;
            input.hiddenValue.b4 = val_2.b4;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    input.fakeValue = val_1;
            }
            
            val_0.fakeValue = input.fakeValue;
            val_0.currentCryptoKey = input.currentCryptoKey;
            return val_0;
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat obj)
        {
            float val_1 = this.fakeValue;
            val_1 = val_1 & 1;
            return (bool)val_1;
        }
        public override int GetHashCode()
        {
            return (int)???.GetHashCode();
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
        private static ObscuredFloat()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.cryptoKey = 230887;
        }
    
    }

}
