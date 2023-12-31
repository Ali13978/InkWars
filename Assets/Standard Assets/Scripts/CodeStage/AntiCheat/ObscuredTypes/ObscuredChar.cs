using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredChar : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredChar>
    {
        // Fields
        private static char cryptoKey;
        private char currentCryptoKey;
        private char hiddenValue;
        private char fakeValue;
        private bool inited;
        
        // Methods
        private ObscuredChar(char value)
        {
        
        }
        public static void SetNewCryptoKey(char newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredChar.cryptoKey = newKey;
        }
        public static char EncryptDecrypt(char value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredChar.EncryptDecrypt(value:  value, key:  ' ');
        }
        public static char EncryptDecrypt(char value, char key)
        {
            char val_3;
            var val_4;
            val_3 = key;
            if((val_3 & 65535) != 0)
            {
                    return (char)val_3 ^ value;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredChar.cryptoKey;
            return (char)val_3 ^ value;
        }
        public void ApplyNewCryptoKey()
        {
        
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public char GetEncrypted()
        {
            return (char)1152921525938950496;
        }
        public void SetEncrypted(char encrypted)
        {
        
        }
        private char InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredChar op_Implicit(char value)
        {
            char val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredChar.EncryptDecrypt(value:  value);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredChar() {currentCryptoKey = ' ', hiddenValue = ' ', fakeValue = ' ', inited = false};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredChar() {currentCryptoKey = ' ', hiddenValue = ' ', fakeValue = ' ', inited = false};
        }
        public static char op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar value)
        {
            return -142297000;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredChar op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar input)
        {
            char val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredChar.EncryptDecrypt(value:  '淉', key:  input.currentCryptoKey);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredChar() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredChar() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredChar op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar input)
        {
            char val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredChar.EncryptDecrypt(value:  '⍇', key:  input.currentCryptoKey);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return new CodeStage.AntiCheat.ObscuredTypes.ObscuredChar() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
            }
            
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredChar() {currentCryptoKey = input.currentCryptoKey, hiddenValue = input.hiddenValue, fakeValue = input.fakeValue, inited = input.inited};
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar obj)
        {
        
        }
        public override string ToString()
        {
            return -141728804;
        }
        public string ToString(System.IFormatProvider provider)
        {
            return -141612708;
        }
        public override int GetHashCode()
        {
            return (int)1152921525940198880.GetHashCode();
        }
        private static ObscuredChar()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredChar.cryptoKey = '—';
        }
    
    }

}
