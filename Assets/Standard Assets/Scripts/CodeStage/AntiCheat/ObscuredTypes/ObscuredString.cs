using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public sealed class ObscuredString
    {
        // Fields
        private static string cryptoKey;
        private string currentCryptoKey;
        private byte[] hiddenValue;
        private string fakeValue;
        private bool inited;
        
        // Methods
        private ObscuredString()
        {
        
        }
        private ObscuredString(byte[] value)
        {
            null = null;
            this.hiddenValue = value;
            this.fakeValue = 0;
            this.inited = true;
            this.currentCryptoKey = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey;
        }
        public static void SetNewCryptoKey(string newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey = newKey;
        }
        public static string EncryptDecrypt(string value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredString.EncryptDecrypt(value:  value, key:  "");
        }
        public static string EncryptDecrypt(string value, string key)
        {
            string val_10;
            var val_11;
            val_10 = key;
            if((System.String.IsNullOrEmpty(value:  value)) != false)
            {
                    return "";
            }
            
            if((System.String.IsNullOrEmpty(value:  val_10)) != false)
            {
                    val_11 = null;
                val_11 = null;
                val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey;
            }
            
            int val_3 = val_10.Length;
            int val_4 = value.Length;
            char[] val_5 = new char[0];
            if(val_4 < 1)
            {
                    return 0.CreateString(val:  val_5);
            }
            
            var val_11 = 0;
            do
            {
                char val_10 = value.Chars[0];
                val_10 = (val_10.Chars[val_11 - ((val_11 / val_3) * val_3)]) ^ val_10;
                mem2[0] = val_10;
                val_11 = val_11 + 1;
            }
            while(val_4 != val_11);
            
            return 0.CreateString(val:  val_5);
        }
        public void ApplyNewCryptoKey()
        {
            null = null;
            if((System.String.op_Inequality(a:  this.currentCryptoKey, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey)) == false)
            {
                    return;
            }
            
            this.hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.InternalEncrypt(value:  this.InternalDecrypt());
            this.currentCryptoKey = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey;
        }
        public void RandomizeCryptoKey()
        {
            string val_3 = UnityEngine.Random.Range(min:  -2147483648, max:  2147483647).ToString();
            this.currentCryptoKey = val_3;
            this.hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.InternalEncrypt(value:  this.InternalDecrypt(), key:  val_3);
        }
        public string GetEncrypted()
        {
            this.ApplyNewCryptoKey();
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredString.GetString(bytes:  this.hiddenValue);
        }
        public void SetEncrypted(string encrypted)
        {
            this.inited = true;
            this.hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.GetBytes(str:  encrypted);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return;
            }
            
            this.fakeValue = this.InternalDecrypt();
        }
        private static byte[] InternalEncrypt(string value)
        {
            null = null;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredString.InternalEncrypt(value:  value, key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey);
        }
        private static byte[] InternalEncrypt(string value, string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredString.GetBytes(str:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.EncryptDecrypt(value:  value, key:  key));
        }
        private string InternalDecrypt()
        {
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector val_8;
            string val_9;
            var val_10;
            string val_11;
            var val_12;
            val_8 = this;
            if(this.inited != false)
            {
                    val_9 = this.currentCryptoKey;
            }
            else
            {
                    val_10 = null;
                val_10 = null;
                val_9 = val_8;
                this.currentCryptoKey = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey;
                this.inited = true;
                mem[1152921525981479464] = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.InternalEncrypt(value:  "");
                mem[1152921525981479472] = "";
            }
            
            val_11 = this.currentCryptoKey;
            val_12 = null;
            if((System.String.IsNullOrEmpty(value:  val_11)) != false)
            {
                    val_12 = null;
                val_11 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey;
            }
            
            string val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.EncryptDecrypt(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.GetString(bytes:  this.hiddenValue), key:  val_11);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return val_4;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.fakeValue)) == true)
            {
                    return val_4;
            }
            
            if((System.String.op_Inequality(a:  val_4, b:  this.fakeValue)) == false)
            {
                    return val_4;
            }
            
            val_8 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField;
            val_8.OnCheatingDetected();
            return val_4;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredString op_Implicit(string value)
        {
            var val_4;
            if(value != null)
            {
                    CodeStage.AntiCheat.ObscuredTypes.ObscuredString val_2 = null;
                val_4 = val_2;
                val_2 = new CodeStage.AntiCheat.ObscuredTypes.ObscuredString(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.InternalEncrypt(value:  value));
                if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)val_4;
            }
            
                .fakeValue = value;
                return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)val_4;
            }
            
            val_4 = 0;
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)val_4;
        }
        public static string op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Equality(a:  value, b:  0)) != false)
            {
                    return 0;
            }
            
            if(value != null)
            {
                    return value.InternalDecrypt();
            }
            
            return value.InternalDecrypt();
        }
        public override string ToString()
        {
            return this.InternalDecrypt();
        }
        public static bool op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredString a, CodeStage.AntiCheat.ObscuredTypes.ObscuredString b)
        {
            var val_4;
            if(a != b)
            {
                    val_4 = 0;
                if(a == null)
            {
                    return (bool)val_4;
            }
            
                if(b == null)
            {
                    return (bool)val_4;
            }
            
                if((System.String.op_Equality(a:  a.currentCryptoKey, b:  b.currentCryptoKey)) == false)
            {
                    return System.String.Equals(a:  a.InternalDecrypt(), b:  b.InternalDecrypt());
            }
            
                return CodeStage.AntiCheat.ObscuredTypes.ObscuredString.ArraysEquals(a1:  a.hiddenValue, a2:  b.hiddenValue);
            }
            
            val_4 = 1;
            return (bool)val_4;
        }
        public static bool op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredString a, CodeStage.AntiCheat.ObscuredTypes.ObscuredString b)
        {
            bool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Equality(a:  a, b:  b);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public override bool Equals(object obj)
        {
            var val_3;
            if(obj != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            val_3 = 0;
            return (bool)this.Equals(value:  obj);
            label_2:
            val_3 = this;
            return (bool)this.Equals(value:  obj);
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Equality(a:  value, b:  0)) != false)
            {
                    return false;
            }
            
            if((System.String.op_Equality(a:  this.currentCryptoKey, b:  value.currentCryptoKey)) == false)
            {
                    return System.String.Equals(a:  this.InternalDecrypt(), b:  value.InternalDecrypt());
            }
            
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredString.ArraysEquals(a1:  this.hiddenValue, a2:  value.hiddenValue);
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value, System.StringComparison comparisonType)
        {
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Equality(a:  value, b:  0)) == false)
            {
                    return System.String.Equals(a:  this.InternalDecrypt(), b:  value.InternalDecrypt(), comparisonType:  comparisonType);
            }
            
            return false;
        }
        public override int GetHashCode()
        {
            if(this.InternalDecrypt() == null)
            {
                
            }
        
        }
        private static byte[] GetBytes(string str)
        {
            int val_2 = str.Length << 1;
            byte[] val_3 = new byte[0];
            System.Buffer.BlockCopy(src:  str.ToCharArray(), srcOffset:  0, dst:  val_3, dstOffset:  0, count:  val_3.Length);
            return (System.Byte[])val_3;
        }
        private static string GetString(byte[] bytes)
        {
            var val_2 = ((bytes.Length < 0) ? (bytes.Length + 1) : bytes.Length) >> 1;
            char[] val_3 = new char[0];
            System.Buffer.BlockCopy(src:  bytes, srcOffset:  0, dst:  val_3, dstOffset:  0, count:  bytes.Length);
            return 0.CreateString(val:  val_3);
        }
        private static bool ArraysEquals(byte[] a1, byte[] a2)
        {
            var val_1;
            if(a1 == a2)
            {
                goto label_4;
            }
            
            val_1 = 0;
            if(a1 == null)
            {
                    return (bool)val_1;
            }
            
            if(a2 == null)
            {
                    return (bool)val_1;
            }
            
            if(a1.Length != a2.Length)
            {
                goto label_7;
            }
            
            if(a1.Length < 1)
            {
                goto label_4;
            }
            
            label_8:
            if(a1[0] != a2[0])
            {
                goto label_7;
            }
            
            if((0 + 1) < a1.Length)
            {
                goto label_8;
            }
            
            label_4:
            val_1 = 1;
            return (bool)val_1;
            label_7:
            val_1 = 0;
            return (bool)val_1;
        }
        private static ObscuredString()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey = "4441";
        }
    
    }

}
