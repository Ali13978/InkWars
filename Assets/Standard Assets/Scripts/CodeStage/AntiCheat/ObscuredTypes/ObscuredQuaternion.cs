using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredQuaternion
    {
        // Fields
        private static int cryptoKey;
        private static readonly UnityEngine.Quaternion initialFakeValue;
        private int currentCryptoKey;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion hiddenValue;
        private UnityEngine.Quaternion fakeValue;
        private bool inited;
        
        // Methods
        private ObscuredQuaternion(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion value)
        {
        
        }
        public static void SetNewCryptoKey(int newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.cryptoKey = newKey;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion Encrypt(UnityEngine.Quaternion value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.Encrypt(value:  new UnityEngine.Quaternion() {x = value.x, y = value.y, z = value.z, w = value.w}, key:  0);
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion Encrypt(UnityEngine.Quaternion value, int key)
        {
            int val_3;
            var val_4;
            val_3 = key;
            if(val_3 == 0)
            {
                    val_4 = null;
                val_4 = null;
                val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.cryptoKey;
            }
            
            float val_3 = value.y;
            float val_4 = value.w;
            val_3 = val_3 ^ val_3;
            val_4 = val_3 ^ val_4;
            return new RawEncryptedQuaternion() {x = val_3 ^ value.x, y = val_3, z = val_3 ^ value.z, w = val_4};
        }
        public static UnityEngine.Quaternion Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.Decrypt(value:  new RawEncryptedQuaternion() {x = value.x, y = value.y, z = value.z, w = value.w}, key:  0);
        }
        public static UnityEngine.Quaternion Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion value, int key)
        {
            int val_5;
            var val_6;
            val_5 = key;
            if(val_5 == 0)
            {
                    val_6 = null;
                val_6 = null;
                val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.cryptoKey;
            }
            
            int val_1 = value.x >> 32;
            int val_4 = value.z >> 32;
            val_1 = val_5 ^ val_1;
            val_4 = val_5 ^ val_4;
            return new UnityEngine.Quaternion() {x = val_5 ^ value.x, y = val_1, z = val_5 ^ value.z, w = val_4};
        }
        public void ApplyNewCryptoKey()
        {
        
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion GetEncrypted()
        {
            return new RawEncryptedQuaternion() {x = this.fakeValue, y = this.fakeValue};
        }
        public void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion encrypted)
        {
        
        }
        private UnityEngine.Quaternion InternalDecrypt()
        {
        
        }
        private bool CompareQuaternionsWithTolerance(UnityEngine.Quaternion q1, UnityEngine.Quaternion q2)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion op_Implicit(UnityEngine.Quaternion value)
        {
            var val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion val_0;
            val_3 = null;
            RawEncryptedQuaternion val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.Encrypt(value:  new UnityEngine.Quaternion() {x = value.x, y = value.y, z = value.z, w = value.w});
            bool val_2 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning;
            val_0.fakeValue.w = value.w;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.x = 0;
            val_0.hiddenValue.y = 0;
            val_0.hiddenValue.z = 0;
            val_0.hiddenValue.w = 0;
            val_0.fakeValue.x = 0f;
            val_0.fakeValue.y = 0f;
            val_0.fakeValue.z = 0f;
            return val_0;
        }
        public static UnityEngine.Quaternion op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion value)
        {
            return new UnityEngine.Quaternion();
        }
        public override int GetHashCode()
        {
        
        }
        public override string ToString()
        {
        
        }
        public string ToString(string format)
        {
            mem2[0] = null;
            mem2[0] = null;
            mem2[0] = null;
            mem2[0] = null;
            return (string)1152921525974619040;
        }
        private static ObscuredQuaternion()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.cryptoKey = 120205;
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.initialFakeValue = val_1.x;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.cryptoKey.__il2cppRuntimeField_8 = val_1.y;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.cryptoKey.__il2cppRuntimeField_C = val_1.z;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.cryptoKey.__il2cppRuntimeField_10 = val_1.w;
        }
    
    }

}
