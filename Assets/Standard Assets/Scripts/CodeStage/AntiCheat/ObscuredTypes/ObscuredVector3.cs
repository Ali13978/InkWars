using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredVector3
    {
        // Fields
        private static int cryptoKey;
        private static readonly UnityEngine.Vector3 initialFakeValue;
        private int currentCryptoKey;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 hiddenValue;
        private UnityEngine.Vector3 fakeValue;
        private bool inited;
        
        // Properties
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
        public float Item { get; set; }
        
        // Methods
        private ObscuredVector3(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 encrypted)
        {
            encrypted.z = encrypted.z & 4294967295;
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
        public float get_z()
        {
        
        }
        public void set_z(float value)
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
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.cryptoKey = newKey;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 Encrypt(UnityEngine.Vector3 value)
        {
            RawEncryptedVector3 val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.Encrypt(value:  new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z}, key:  0);
            val_1.z = val_1.z & 4294967295;
            return new RawEncryptedVector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 Encrypt(UnityEngine.Vector3 value, int key)
        {
            int val_3;
            var val_4;
            val_3 = key;
            if(val_3 == 0)
            {
                    val_4 = null;
                val_4 = null;
                val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.cryptoKey;
            }
            
            float val_3 = value.y;
            val_3 = val_3 ^ val_3;
            return new RawEncryptedVector3() {x = val_3 ^ value.x, y = val_3, z = val_3 ^ value.z};
        }
        public static UnityEngine.Vector3 Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 value)
        {
            value.z = value.z & 4294967295;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.Decrypt(value:  new RawEncryptedVector3() {x = value.x, y = value.y, z = value.z}, key:  0);
        }
        public static UnityEngine.Vector3 Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 value, int key)
        {
            int val_4;
            var val_5;
            val_4 = key;
            val_5 = 26751;
            if(val_4 == 0)
            {
                    val_5 = null;
                val_5 = null;
                val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.cryptoKey;
            }
            
            int val_1 = value.x >> 32;
            val_1 = val_4 ^ val_1;
            return new UnityEngine.Vector3() {x = val_4 ^ value.x, y = val_1, z = val_4 ^ value.z};
        }
        public void ApplyNewCryptoKey()
        {
        
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 GetEncrypted()
        {
            return new RawEncryptedVector3() {x = this.fakeValue, y = this.fakeValue, z = this.inited};
        }
        public void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 encrypted)
        {
            encrypted.z = encrypted.z & 4294967295;
        }
        private UnityEngine.Vector3 InternalDecrypt()
        {
        
        }
        private bool CompareVectorsWithTolerance(UnityEngine.Vector3 vector1, UnityEngine.Vector3 vector2)
        {
        
        }
        private float InternalDecryptField(int encrypted)
        {
        
        }
        private int InternalEncryptField(float encrypted)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Implicit(UnityEngine.Vector3 value)
        {
            var val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 val_0;
            val_4 = null;
            val_4 = null;
            RawEncryptedVector3 val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.Encrypt(value:  new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z}, key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.cryptoKey);
            int val_2 = val_1.z & 4294967295;
            bool val_3 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.x = 0;
            val_0.hiddenValue.y = 0;
            val_0.hiddenValue.z = 0;
            val_0.fakeValue.x = value.x;
            return val_0;
        }
        public static UnityEngine.Vector3 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 value)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Addition(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.op_Implicit(value:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Addition(UnityEngine.Vector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z}, b:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z});
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.op_Implicit(value:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Addition(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, UnityEngine.Vector3 b)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = b.x, y = b.y, z = b.z}, b:  new UnityEngine.Vector3() {x = b.x, y = b.y, z = b.z});
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.op_Implicit(value:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Subtraction(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.op_Implicit(value:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Subtraction(UnityEngine.Vector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z}, b:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z});
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.op_Implicit(value:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Subtraction(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, UnityEngine.Vector3 b)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = b.x, y = b.y, z = b.z}, b:  new UnityEngine.Vector3() {x = b.x, y = b.y, z = b.z});
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.op_Implicit(value:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_UnaryNegation(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.op_Implicit(value:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Multiply(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, float d)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = d, y = V1.16B, z = V2.16B}, d:  d);
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.op_Implicit(value:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Multiply(float d, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(d:  d, a:  new UnityEngine.Vector3() {x = d, y = V1.16B, z = V2.16B});
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.op_Implicit(value:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Division(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, float d)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = d, y = V1.16B, z = V2.16B}, d:  d);
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.op_Implicit(value:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public static bool op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs)
        {
            return UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, rhs:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
        }
        public static bool op_Equality(UnityEngine.Vector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs)
        {
            return UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = lhs.x, y = lhs.y, z = lhs.z}, rhs:  new UnityEngine.Vector3() {x = lhs.x, y = lhs.y, z = lhs.z});
        }
        public static bool op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, UnityEngine.Vector3 rhs)
        {
            return UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = rhs.x, y = rhs.y, z = rhs.z}, rhs:  new UnityEngine.Vector3() {x = rhs.x, y = rhs.y, z = rhs.z});
        }
        public static bool op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs)
        {
            return UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, rhs:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
        }
        public static bool op_Inequality(UnityEngine.Vector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs)
        {
            return UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = lhs.x, y = lhs.y, z = lhs.z}, rhs:  new UnityEngine.Vector3() {x = lhs.x, y = lhs.y, z = lhs.z});
        }
        public static bool op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, UnityEngine.Vector3 rhs)
        {
            return UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = rhs.x, y = rhs.y, z = rhs.z}, rhs:  new UnityEngine.Vector3() {x = rhs.x, y = rhs.y, z = rhs.z});
        }
        public override bool Equals(object other)
        {
        
        }
        public override int GetHashCode()
        {
        
        }
        public override string ToString()
        {
        
        }
        public string ToString(string format)
        {
        
        }
        private static ObscuredVector3()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.cryptoKey = 120207;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.initialFakeValue = val_1.x;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.cryptoKey.__il2cppRuntimeField_8 = val_1.y;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.cryptoKey.__il2cppRuntimeField_C = val_1.z;
        }
    
    }

}
