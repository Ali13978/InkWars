using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredBool : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredBool>
    {
        // Fields
        private static byte cryptoKey;
        private byte currentCryptoKey;
        private int hiddenValue;
        private bool fakeValue;
        private bool fakeValueChanged;
        private bool inited;
        
        // Methods
        private ObscuredBool(int value)
        {
        
        }
        public static void SetNewCryptoKey(byte newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.cryptoKey = newKey;
        }
        public static int Encrypt(bool value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.Encrypt(value:  value, key:  0);
        }
        public static int Encrypt(bool value, byte key)
        {
            byte val_5;
            var val_6;
            val_5 = key;
            if((val_5 & 255) != 0)
            {
                    return (int)((value != true) ? 213 : 181) ^ (val_5 & 255);
            }
            
            val_6 = null;
            val_6 = null;
            val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.cryptoKey;
            return (int)((value != true) ? 213 : 181) ^ (val_5 & 255);
        }
        public static bool Decrypt(int value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.Decrypt(value:  value, key:  0);
        }
        public static bool Decrypt(int value, byte key)
        {
            byte val_4;
            var val_5;
            val_4 = key;
            if((val_4 & 255) == 0)
            {
                    val_5 = null;
                val_5 = null;
                val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.cryptoKey;
            }
            
            byte val_2 = val_4 & 255;
            val_2 = val_2 ^ value;
            return (bool)(val_2 != 181) ? 1 : 0;
        }
        public void ApplyNewCryptoKey()
        {
        
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public int GetEncrypted()
        {
            return (int)1152921525934716384;
        }
        public void SetEncrypted(int encrypted)
        {
        
        }
        private bool InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredBool op_Implicit(bool value)
        {
            bool val_1 = value;
            int val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.Encrypt(value:  val_1);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {fakeValue = val_1, fakeValueChanged = val_1, inited = val_1};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {fakeValue = val_1, fakeValueChanged = val_1, inited = val_1};
        }
        public static bool op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value)
        {
            return false;
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool obj)
        {
            obj.fakeValue = obj.fakeValue & 4294967295;
        }
        public override int GetHashCode()
        {
            return (int)0.GetHashCode();
        }
        public override string ToString()
        {
            return (string)0.ToString();
        }
        private static ObscuredBool()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.cryptoKey = 215;
        }
    
    }

}
