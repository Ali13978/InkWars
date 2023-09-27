using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredDecimal : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal>, IFormattable
    {
        // Fields
        private static long cryptoKey;
        private long currentCryptoKey;
        private byte[] hiddenValueOld;
        private CodeStage.AntiCheat.Common.ACTkByte16 hiddenValue;
        private decimal fakeValue;
        private bool inited;
        
        // Methods
        private ObscuredDecimal(CodeStage.AntiCheat.Common.ACTkByte16 value)
        {
        
        }
        public static void SetNewCryptoKey(long newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey = newKey;
        }
        public static decimal Encrypt(decimal value)
        {
            null = null;
            value.lo = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey ^ value.lo;
            return new System.Decimal() {flags = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey ^ value.flags, hi = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey ^ value.flags, lo = value.lo, mid = value.lo};
        }
        public static decimal Encrypt(decimal value, long key)
        {
            value.flags = value.flags ^ key;
            value.lo = value.lo ^ key;
            return new System.Decimal() {flags = value.flags, hi = value.flags, lo = value.lo, mid = value.lo};
        }
        private static CodeStage.AntiCheat.Common.ACTkByte16 InternalEncrypt(decimal value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.InternalEncrypt(value:  new System.Decimal() {flags = value.flags, hi = value.hi, lo = value.lo, mid = value.mid}, key:  0);
        }
        private static CodeStage.AntiCheat.Common.ACTkByte16 InternalEncrypt(decimal value, long key)
        {
            long val_2;
            var val_3;
            val_2 = key;
            if(val_2 == 0)
            {
                    val_3 = null;
                val_3 = null;
                val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey;
            }
            
            value.lo = val_2 ^ value.lo;
            return new CodeStage.AntiCheat.Common.ACTkByte16() {b1 = val_2 ^ value.flags, b2 = val_2 ^ value.flags, b3 = val_2 ^ value.flags, b4 = val_2 ^ value.flags, b5 = val_2 ^ value.flags, b6 = val_2 ^ value.flags, b7 = val_2 ^ value.flags, b8 = val_2 ^ value.flags, b9 = value.lo, b10 = value.lo, b11 = value.lo, b12 = value.lo, b13 = value.lo, b14 = value.lo, b15 = value.lo, b16 = value.lo};
        }
        public static decimal Decrypt(decimal value)
        {
            null = null;
            value.lo = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey ^ value.lo;
            return new System.Decimal() {flags = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey ^ value.flags, hi = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey ^ value.flags, lo = value.lo, mid = value.lo};
        }
        public static decimal Decrypt(decimal value, long key)
        {
            value.flags = value.flags ^ key;
            value.lo = value.lo ^ key;
            return new System.Decimal() {flags = value.flags, hi = value.flags, lo = value.lo, mid = value.lo};
        }
        public void ApplyNewCryptoKey()
        {
        
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public decimal GetEncrypted()
        {
            return new System.Decimal() {flags = this.fakeValue, hi = this.fakeValue};
        }
        public void SetEncrypted(decimal encrypted)
        {
        
        }
        private decimal InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Implicit(decimal value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal val_0;
            CodeStage.AntiCheat.Common.ACTkByte16 val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.InternalEncrypt(value:  new System.Decimal() {flags = value.flags, hi = value.hi, lo = value.lo, mid = value.mid});
            bool val_2 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning;
            val_0.inited = false;
            mem[1152921525941951777] = 0;
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
            val_0.hiddenValue.b9 = 0;
            val_0.fakeValue.flags = value.flags;
            val_0.fakeValue.hi = value.hi;
            return val_0;
        }
        public static decimal op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal value)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Explicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat f)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal val_0;
            decimal val_1 = System.Decimal.op_Explicit(value:  f.currentCryptoKey);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.op_Implicit(value:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid});
            return val_0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal input)
        {
            var val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal val_0;
            val_4 = null;
            val_4 = null;
            decimal val_1 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -138945104, hi = 268435460, lo = X1, mid = X1}, d2:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_20>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_20>>32&0x0});
            CodeStage.AntiCheat.Common.ACTkByte16 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.InternalEncrypt(value:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid}, key:  input.currentCryptoKey);
            input.hiddenValue.b1 = val_2.b1;
            input.hiddenValue.b2 = val_2.b2;
            input.hiddenValue.b3 = val_2.b3;
            input.hiddenValue.b4 = val_2.b4;
            input.hiddenValue.b5 = val_2.b5;
            input.hiddenValue.b6 = val_2.b6;
            input.hiddenValue.b7 = val_2.b7;
            input.hiddenValue.b8 = val_2.b8;
            input.hiddenValue.b9 = val_2.b9;
            input.hiddenValue.b10 = val_2.b10;
            input.hiddenValue.b11 = val_2.b11;
            input.hiddenValue.b12 = val_2.b12;
            input.hiddenValue.b13 = val_2.b13;
            input.hiddenValue.b14 = val_2.b14;
            input.hiddenValue.b15 = val_2.b15;
            input.hiddenValue.b16 = val_2.b16;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    input.fakeValue.flags = val_1.flags;
                input.fakeValue.hi = val_1.hi;
                input.fakeValue.lo = val_1.lo;
                input.fakeValue.mid = val_1.mid;
            }
            
            val_0.inited = input.inited;
            val_0.fakeValue.flags = input.fakeValue.flags;
            val_0.fakeValue.hi = val_1.hi;
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
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal input)
        {
            var val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal val_0;
            val_4 = null;
            val_4 = null;
            decimal val_1 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -138669264, hi = 268435460, lo = X1, mid = X1}, d2:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_20>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_20>>32&0x0});
            CodeStage.AntiCheat.Common.ACTkByte16 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.InternalEncrypt(value:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid}, key:  input.currentCryptoKey);
            input.hiddenValue.b1 = val_2.b1;
            input.hiddenValue.b2 = val_2.b2;
            input.hiddenValue.b3 = val_2.b3;
            input.hiddenValue.b4 = val_2.b4;
            input.hiddenValue.b5 = val_2.b5;
            input.hiddenValue.b6 = val_2.b6;
            input.hiddenValue.b7 = val_2.b7;
            input.hiddenValue.b8 = val_2.b8;
            input.hiddenValue.b9 = val_2.b9;
            input.hiddenValue.b10 = val_2.b10;
            input.hiddenValue.b11 = val_2.b11;
            input.hiddenValue.b12 = val_2.b12;
            input.hiddenValue.b13 = val_2.b13;
            input.hiddenValue.b14 = val_2.b14;
            input.hiddenValue.b15 = val_2.b15;
            input.hiddenValue.b16 = val_2.b16;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    input.fakeValue.flags = val_1.flags;
                input.fakeValue.hi = val_1.hi;
                input.fakeValue.lo = val_1.lo;
                input.fakeValue.mid = val_1.mid;
            }
            
            val_0.inited = input.inited;
            val_0.fakeValue.flags = input.fakeValue.flags;
            val_0.fakeValue.hi = val_1.hi;
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
            return (string)this.hiddenValue.ToString();
        }
        public string ToString(string format)
        {
            return (string)this.hiddenValue.ToString(format:  format);
        }
        public string ToString(System.IFormatProvider provider)
        {
            return (string)this.hiddenValue.ToString(provider:  provider);
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return (string)this.hiddenValue.ToString(format:  format, provider:  provider);
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal obj)
        {
            CodeStage.AntiCheat.Common.ACTkByte16 val_1 = this.hiddenValue;
            val_1 = val_1 & 1;
            return (bool)val_1;
        }
        public override int GetHashCode()
        {
            return (int);
        }
        private static ObscuredDecimal()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey = 209208;
        }
    
    }

}
