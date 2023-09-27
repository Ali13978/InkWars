using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredVector2
    {
        // Fields
        private static int cryptoKey;
        private static readonly UnityEngine.Vector2 initialFakeValue;
        private int currentCryptoKey;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 hiddenValue;
        private UnityEngine.Vector2 fakeValue;
        private bool inited;
        
        // Properties
        public float x { get; set; }
        public float y { get; set; }
        public float Item { get; set; }
        
        // Methods
        private ObscuredVector2(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 value)
        {
        
        }
        public float get_x()
        {
        
        }
        public void set_x(float value)
        {
        
        }
        public float get_y()
        {
        
        }
        public void set_y(float value)
        {
        
        }
        public float get_Item(int index)
        {
        
        }
        public void set_Item(int index, float value)
        {
        
        }
        public static void SetNewCryptoKey(int newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.cryptoKey = newKey;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 Encrypt(UnityEngine.Vector2 value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.Encrypt(value:  new UnityEngine.Vector2() {x = value.x, y = value.y}, key:  0);
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 Encrypt(UnityEngine.Vector2 value, int key)
        {
            int val_2;
            var val_3;
            val_2 = key;
            if(val_2 == 0)
            {
                    val_3 = null;
                val_3 = null;
                val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.cryptoKey;
            }
            
            float val_2 = value.y;
            val_2 = val_2 ^ val_2;
            return new RawEncryptedVector2() {x = val_2 ^ value.x, y = val_2};
        }
        public static UnityEngine.Vector2 Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.Decrypt(value:  new RawEncryptedVector2() {x = value.x, y = value.y}, key:  0);
        }
        public static UnityEngine.Vector2 Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 value, int key)
        {
            int val_3;
            var val_4;
            val_3 = key;
            if(val_3 == 0)
            {
                    val_4 = null;
                val_4 = null;
                val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.cryptoKey;
            }
            
            int val_1 = value.x >> 32;
            val_1 = val_3 ^ val_1;
            return new UnityEngine.Vector2() {x = val_3 ^ value.x, y = val_1};
        }
        public void ApplyNewCryptoKey()
        {
        
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 GetEncrypted()
        {
            return new RawEncryptedVector2() {x = this.inited, y = this.inited};
        }
        public void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 encrypted)
        {
        
        }
        private UnityEngine.Vector2 InternalDecrypt()
        {
        
        }
        private bool CompareVectorsWithTolerance(UnityEngine.Vector2 vector1, UnityEngine.Vector2 vector2)
        {
        
        }
        private float InternalDecryptField(int encrypted)
        {
        
        }
        private int InternalEncryptField(float encrypted)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 op_Implicit(UnityEngine.Vector2 value)
        {
            var val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 val_0;
            val_3 = null;
            RawEncryptedVector2 val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.Encrypt(value:  new UnityEngine.Vector2() {x = value.x, y = value.y});
            bool val_2 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning;
            val_0.fakeValue.y = value.y;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.x = 0;
            val_0.hiddenValue.y = 0;
            val_0.fakeValue.x = 0f;
            return val_0;
        }
        public static UnityEngine.Vector2 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 value)
        {
        
        }
        public static UnityEngine.Vector3 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 value)
        {
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public override int GetHashCode()
        {
            return -87195672;
        }
        public override string ToString()
        {
            return -87083672;
        }
        public string ToString(string format)
        {
            return -86967576;
        }
        private static ObscuredVector2()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.cryptoKey = 120206;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.initialFakeValue = val_1.x;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.cryptoKey.__il2cppRuntimeField_8 = val_1.y;
        }
    
    }

}
