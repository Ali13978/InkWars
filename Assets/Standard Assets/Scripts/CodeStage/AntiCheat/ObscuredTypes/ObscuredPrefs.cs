using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    public static class ObscuredPrefs
    {
        // Fields
        private const byte VERSION = 2;
        private const string RAW_NOT_FOUND = "{not_found}";
        private const string DATA_SEPARATOR = "|";
        private static bool foreignSavesReported;
        private static string cryptoKey;
        private static string deviceId;
        private static uint deviceIdHash;
        public static System.Action onAlterationDetected;
        public static bool preservePlayerPrefs;
        public static System.Action onPossibleForeignSavesDetected;
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeviceLockLevel lockToDevice;
        public static bool readForeignSaves;
        public static bool emergencyMode;
        private const char DEPRECATED_RAW_SEPARATOR = '\x3a';
        private static string deprecatedDeviceId;
        
        // Properties
        public static string CryptoKey { get; set; }
        public static string DeviceId { get; set; }
        internal static string DeviceID { get; set; }
        private static uint DeviceIdHash { get; }
        private static string DeprecatedDeviceId { get; }
        
        // Methods
        public static void set_CryptoKey(string value)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.cryptoKey = value;
        }
        public static string get_CryptoKey()
        {
            null = null;
            return (string)CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.cryptoKey;
        }
        public static string get_DeviceId()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            val_4 = null;
            if((System.String.IsNullOrEmpty(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceId)) != false)
            {
                    val_4 = null;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceId = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetDeviceId();
            }
            
            val_4 = null;
            return (string)CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceId;
        }
        public static void set_DeviceId(string value)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceId = value;
        }
        internal static string get_DeviceID()
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeviceId;
        }
        internal static void set_DeviceID(string value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeviceId = value;
        }
        private static uint get_DeviceIdHash()
        {
            var val_3 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceIdHash == 0)
            {
                    val_3 = null;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceIdHash = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.CalculateChecksum(input:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeviceId);
            }
            
            val_3 = null;
            return (uint)CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceIdHash;
        }
        public static void ForceLockToDeviceInit()
        {
            null = null;
            if((System.String.IsNullOrEmpty(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceId)) != false)
            {
                    CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceId = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetDeviceId();
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceIdHash = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.CalculateChecksum(input:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceId);
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[ACTk] ObscuredPrefs.ForceLockToDeviceInit() is called, but device ID is already obtained!");
        }
        internal static void SetNewCryptoKey(string newKey)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.CryptoKey = newKey;
        }
        public static void SetInt(string key, int value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key), value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptIntValue(key:  key, value:  value));
        }
        public static int GetInt(string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetInt(key:  key, defaultValue:  0);
        }
        public static int GetInt(string key, int defaultValue)
        {
            int val_7;
            string val_8;
            var val_9;
            val_7 = defaultValue;
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key);
            val_8 = val_1;
            if((UnityEngine.PlayerPrefs.HasKey(key:  val_1)) != true)
            {
                    if((UnityEngine.PlayerPrefs.HasKey(key:  key)) != false)
            {
                    val_9 = null;
                val_7 = UnityEngine.PlayerPrefs.GetInt(key:  key, defaultValue:  val_7);
                val_9 = null;
                if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.preservePlayerPrefs == true)
            {
                    return val_7;
            }
            
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetInt(key:  key, value:  val_7);
                UnityEngine.PlayerPrefs.DeleteKey(key:  key);
                return val_7;
            }
            
            }
            
            string val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  key, encryptedKey:  val_8);
            val_8 = val_5;
            if((System.String.op_Equality(a:  val_5, b:  "{not_found}")) == false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptIntValue(key:  key, encryptedInput:  val_8, defaultValue:  val_7);
            }
            
            return val_7;
        }
        internal static string EncryptIntValue(string key, int value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  key, cleanBytes:  System.BitConverter.GetBytes(value:  value), type:  5);
        }
        internal static int DecryptIntValue(string key, string encryptedInput, int defaultValue)
        {
            var val_8;
            string val_9;
            string val_10;
            val_8 = defaultValue;
            val_9 = encryptedInput;
            val_10 = key;
            int val_4 = 0;
            if(((val_9.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_9);
                val_9 = val_2;
                if((System.String.op_Equality(a:  val_2, b:  "")) == true)
            {
                    return (int)val_8;
            }
            
                bool val_5 = System.Int32.TryParse(s:  val_9, result: out  val_4);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetInt(key:  val_10, value:  0);
                val_8 = val_4;
                return (int)val_8;
            }
            
            val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_10, encryptedInput:  val_9);
            if(val_10 == null)
            {
                    return (int)val_8;
            }
            
            val_8 = System.BitConverter.ToInt32(value:  val_10, startIndex:  0);
            return (int)val_8;
        }
        public static void SetUInt(string key, uint value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key), value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptUIntValue(key:  key, value:  value));
        }
        public static uint GetUInt(string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetUInt(key:  key, defaultValue:  0);
        }
        public static uint GetUInt(string key, uint defaultValue)
        {
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  key, encryptedKey:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key));
            if((System.String.op_Equality(a:  val_2, b:  "{not_found}")) == false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptUIntValue(key:  key, encryptedInput:  val_2, defaultValue:  defaultValue);
            }
            
            return (uint)defaultValue;
        }
        private static string EncryptUIntValue(string key, uint value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  key, cleanBytes:  System.BitConverter.GetBytes(value:  value), type:  10);
        }
        private static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
        {
            var val_8;
            string val_9;
            string val_10;
            val_8 = defaultValue;
            val_9 = encryptedInput;
            val_10 = key;
            uint val_4 = 0;
            if(((val_9.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_9);
                val_9 = val_2;
                if((System.String.op_Equality(a:  val_2, b:  "")) == true)
            {
                    return (uint)val_8;
            }
            
                bool val_5 = System.UInt32.TryParse(s:  val_9, result: out  val_4);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetUInt(key:  val_10, value:  0);
                val_8 = val_4;
                return (uint)val_8;
            }
            
            val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_10, encryptedInput:  val_9);
            if(val_10 == null)
            {
                    return (uint)val_8;
            }
            
            val_8 = System.BitConverter.ToUInt32(value:  val_10, startIndex:  0);
            return (uint)val_8;
        }
        public static void SetString(string key, string value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key), value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptStringValue(key:  key, value:  value));
        }
        public static string GetString(string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetString(key:  key, defaultValue:  "");
        }
        public static string GetString(string key, string defaultValue)
        {
            string val_7;
            string val_8;
            var val_9;
            val_7 = defaultValue;
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key);
            val_8 = val_1;
            if((UnityEngine.PlayerPrefs.HasKey(key:  val_1)) != true)
            {
                    if((UnityEngine.PlayerPrefs.HasKey(key:  key)) != false)
            {
                    val_9 = null;
                val_7 = UnityEngine.PlayerPrefs.GetString(key:  key, defaultValue:  val_7);
                val_9 = null;
                if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.preservePlayerPrefs == true)
            {
                    return val_7;
            }
            
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetString(key:  key, value:  val_7);
                UnityEngine.PlayerPrefs.DeleteKey(key:  key);
                return val_7;
            }
            
            }
            
            string val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  key, encryptedKey:  val_8);
            val_8 = val_5;
            if((System.String.op_Equality(a:  val_5, b:  "{not_found}")) == false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptStringValue(key:  key, encryptedInput:  val_8, defaultValue:  val_7);
            }
            
            return val_7;
        }
        internal static string EncryptStringValue(string key, string value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  key, cleanBytes:  System.Text.Encoding.UTF8, type:  15);
        }
        internal static string DecryptStringValue(string key, string encryptedInput, string defaultValue)
        {
            string val_12;
            string val_13;
            val_12 = defaultValue;
            val_13 = encryptedInput;
            if(((val_13.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_13);
                val_13 = val_2;
                if((System.String.op_Equality(a:  val_2, b:  "")) == true)
            {
                    return (string)val_12;
            }
            
                val_12 = val_13;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetString(key:  key, value:  val_12);
                return (string)val_12;
            }
            
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  key, encryptedInput:  val_13)) == null)
            {
                    return (string)val_12;
            }
            
            System.Text.Encoding val_5 = System.Text.Encoding.UTF8;
            val_12 = ???;
            val_13 = ???;
            goto typeof(System.Text.Encoding).__il2cppRuntimeField_378;
        }
        public static void SetFloat(string key, float value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key), value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptFloatValue(key:  key, value:  value));
        }
        public static float GetFloat(string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetFloat(key:  key, defaultValue:  0f);
        }
        public static float GetFloat(string key, float defaultValue)
        {
            float val_7;
            var val_8;
            val_7 = defaultValue;
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key);
            if((UnityEngine.PlayerPrefs.HasKey(key:  val_1)) != true)
            {
                    if((UnityEngine.PlayerPrefs.HasKey(key:  key)) != false)
            {
                    val_8 = null;
                val_7 = UnityEngine.PlayerPrefs.GetFloat(key:  key, defaultValue:  val_7);
                val_8 = null;
                if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.preservePlayerPrefs == true)
            {
                    return val_7;
            }
            
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetFloat(key:  key, value:  val_7);
                UnityEngine.PlayerPrefs.DeleteKey(key:  key);
                return val_7;
            }
            
            }
            
            string val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  key, encryptedKey:  val_1);
            if((System.String.op_Equality(a:  val_5, b:  "{not_found}")) == false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptFloatValue(key:  key, encryptedInput:  val_5, defaultValue:  val_7);
            }
            
            return val_7;
        }
        internal static string EncryptFloatValue(string key, float value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  key, cleanBytes:  System.BitConverter.GetBytes(value:  value), type:  20);
        }
        internal static float DecryptFloatValue(string key, string encryptedInput, float defaultValue)
        {
            float val_8;
            string val_9;
            val_8 = defaultValue;
            val_9 = key;
            if(((encryptedInput.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  encryptedInput);
                if((System.String.op_Equality(a:  val_2, b:  "")) == true)
            {
                    return (float)val_8;
            }
            
                bool val_5 = System.Single.TryParse(s:  val_2, result: out  float val_4 = -3.361523E+34f);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetFloat(key:  val_9, value:  0f);
                val_8 = 0f;
                return (float)val_8;
            }
            
            val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_9, encryptedInput:  encryptedInput);
            if(val_9 == null)
            {
                    return (float)val_8;
            }
            
            val_8 = System.BitConverter.ToSingle(value:  val_9, startIndex:  0);
            return (float)val_8;
        }
        public static void SetDouble(string key, double value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key), value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptDoubleValue(key:  key, value:  value));
        }
        public static double GetDouble(string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetDouble(key:  key, defaultValue:  0);
        }
        public static double GetDouble(string key, double defaultValue)
        {
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  key, encryptedKey:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key));
            if((System.String.op_Equality(a:  val_2, b:  "{not_found}")) == false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptDoubleValue(key:  key, encryptedInput:  val_2, defaultValue:  defaultValue);
            }
            
            return (double)defaultValue;
        }
        private static string EncryptDoubleValue(string key, double value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  key, cleanBytes:  System.BitConverter.GetBytes(value:  value), type:  25);
        }
        private static double DecryptDoubleValue(string key, string encryptedInput, double defaultValue)
        {
            double val_8;
            string val_9;
            val_8 = defaultValue;
            val_9 = key;
            if(((encryptedInput.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  encryptedInput);
                if((System.String.op_Equality(a:  val_2, b:  "")) == true)
            {
                    return (double)val_8;
            }
            
                bool val_5 = System.Double.TryParse(s:  val_2, result: out  double val_4 = 1.28823586239713E-231);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetDouble(key:  val_9, value:  0);
                val_8 = 0;
                return (double)val_8;
            }
            
            val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_9, encryptedInput:  encryptedInput);
            if(val_9 == null)
            {
                    return (double)val_8;
            }
            
            val_8 = System.BitConverter.ToDouble(value:  val_9, startIndex:  0);
            return (double)val_8;
        }
        public static void SetLong(string key, long value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key), value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptLongValue(key:  key, value:  value));
        }
        public static long GetLong(string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetLong(key:  key, defaultValue:  0);
        }
        public static long GetLong(string key, long defaultValue)
        {
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  key, encryptedKey:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key));
            if((System.String.op_Equality(a:  val_2, b:  "{not_found}")) == false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptLongValue(key:  key, encryptedInput:  val_2, defaultValue:  defaultValue);
            }
            
            return (long)defaultValue;
        }
        private static string EncryptLongValue(string key, long value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  key, cleanBytes:  System.BitConverter.GetBytes(value:  value), type:  30);
        }
        private static long DecryptLongValue(string key, string encryptedInput, long defaultValue)
        {
            var val_8;
            string val_9;
            string val_10;
            val_8 = defaultValue;
            val_9 = encryptedInput;
            val_10 = key;
            long val_4 = 0;
            if(((val_9.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_9);
                val_9 = val_2;
                if((System.String.op_Equality(a:  val_2, b:  "")) == true)
            {
                    return (long)val_8;
            }
            
                bool val_5 = System.Int64.TryParse(s:  val_9, result: out  val_4);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetLong(key:  val_10, value:  0);
                val_8 = val_4;
                return (long)val_8;
            }
            
            val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_10, encryptedInput:  val_9);
            if(val_10 == null)
            {
                    return (long)val_8;
            }
            
            val_8 = System.BitConverter.ToInt64(value:  val_10, startIndex:  0);
            return (long)val_8;
        }
        public static void SetBool(string key, bool value)
        {
            value = value;
            UnityEngine.PlayerPrefs.SetString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key), value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptBoolValue(key:  key, value:  value));
        }
        public static bool GetBool(string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetBool(key:  key, defaultValue:  false);
        }
        public static bool GetBool(string key, bool defaultValue)
        {
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  key, encryptedKey:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key));
            if((System.String.op_Equality(a:  val_2, b:  "{not_found}")) == false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptBoolValue(key:  key, encryptedInput:  val_2, defaultValue:  defaultValue);
            }
            
            return (bool)defaultValue;
        }
        private static string EncryptBoolValue(string key, bool value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  key, cleanBytes:  System.BitConverter.GetBytes(value:  value), type:  35);
        }
        private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
        {
            var val_10;
            string val_11;
            string val_12;
            val_10 = defaultValue;
            val_11 = encryptedInput;
            val_12 = key;
            int val_4 = 0;
            if(((val_11.IndexOf(value:  ':')) & 2147483648) != 0)
            {
                goto label_2;
            }
            
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_11);
            val_11 = val_2;
            if((System.String.op_Equality(a:  val_2, b:  "")) == true)
            {
                goto label_11;
            }
            
            bool val_5 = System.Int32.TryParse(s:  val_11, result: out  val_4);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetBool(key:  val_12, value:  (val_4 == 1) ? 1 : 0);
            var val_7 = (val_4 == 1) ? 1 : 0;
            goto label_11;
            label_2:
            val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_12, encryptedInput:  val_11);
            if(val_12 != null)
            {
                    bool val_9 = System.BitConverter.ToBoolean(value:  val_12, startIndex:  0);
                val_10 = val_9;
            }
            
            label_11:
            val_9 = val_10;
            return (bool)val_9;
        }
        public static void SetByteArray(string key, byte[] value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key), value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptByteArrayValue(key:  key, value:  value));
        }
        public static byte[] GetByteArray(string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetByteArray(key:  key, defaultValue:  0, defaultLength:  0);
        }
        public static byte[] GetByteArray(string key, byte defaultValue, int defaultLength)
        {
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  key, encryptedKey:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key));
            if((System.String.op_Equality(a:  val_2, b:  "{not_found}")) == false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptByteArrayValue(key:  key, encryptedInput:  val_2, defaultValue:  defaultValue, defaultLength:  defaultLength);
            }
            
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.ConstructByteArray(value:  defaultValue, length:  defaultLength);
        }
        private static string EncryptByteArrayValue(string key, byte[] value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  key, cleanBytes:  value, type:  40);
        }
        private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
        {
            System.Byte[] val_6;
            System.Byte[] val_7;
            val_6 = defaultLength;
            if(((encryptedInput.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    if((System.String.op_Equality(a:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  encryptedInput), b:  "")) == true)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.ConstructByteArray(value:  defaultValue, length:  val_6);
            }
            
                val_6 = System.Text.Encoding.UTF8;
                val_7 = val_6;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetByteArray(key:  key, value:  val_7);
                return (System.Byte[])val_7;
            }
            
            val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  key, encryptedInput:  encryptedInput);
            if(val_7 == null)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.ConstructByteArray(value:  defaultValue, length:  val_6);
            }
            
            return (System.Byte[])val_7;
        }
        private static byte[] ConstructByteArray(byte value, int length)
        {
            byte[] val_1 = new byte[0];
            if(length < 1)
            {
                    return (System.Byte[])val_1;
            }
            
            var val_2 = 0;
            do
            {
                mem2[0] = value;
                val_2 = val_2 + 1;
            }
            while(length != val_2);
            
            return (System.Byte[])val_1;
        }
        public static void SetVector2(string key, UnityEngine.Vector2 value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key), value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptVector2Value(key:  key, value:  new UnityEngine.Vector2() {x = value.x, y = value.y}));
        }
        public static UnityEngine.Vector2 GetVector2(string key)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetVector2(key:  key, defaultValue:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        }
        public static UnityEngine.Vector2 GetVector2(string key, UnityEngine.Vector2 defaultValue)
        {
            float val_5;
            float val_6;
            val_5 = defaultValue.y;
            val_6 = defaultValue.x;
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  key, encryptedKey:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key));
            if((System.String.op_Equality(a:  val_2, b:  "{not_found}")) == true)
            {
                    return new UnityEngine.Vector2() {x = val_6, y = val_5};
            }
            
            UnityEngine.Vector2 val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptVector2Value(key:  key, encryptedInput:  val_2, defaultValue:  new UnityEngine.Vector2() {x = val_6, y = val_5});
            val_6 = val_4.x;
            val_5 = val_4.y;
            return new UnityEngine.Vector2() {x = val_6, y = val_5};
        }
        private static string EncryptVector2Value(string key, UnityEngine.Vector2 value)
        {
            byte[] val_1 = new byte[8];
            System.Buffer.BlockCopy(src:  System.BitConverter.GetBytes(value:  value.x), srcOffset:  0, dst:  val_1, dstOffset:  0, count:  4);
            System.Buffer.BlockCopy(src:  System.BitConverter.GetBytes(value:  value.y), srcOffset:  0, dst:  val_1, dstOffset:  4, count:  4);
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  key, cleanBytes:  val_1, type:  45);
        }
        private static UnityEngine.Vector2 DecryptVector2Value(string key, string encryptedInput, UnityEngine.Vector2 defaultValue)
        {
            System.Char[] val_15;
            float val_16;
            float val_17;
            string val_18;
            var val_19;
            val_16 = defaultValue.y;
            val_17 = defaultValue.x;
            val_18 = key;
            if(((encryptedInput.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  encryptedInput);
                if((System.String.op_Equality(a:  val_2, b:  "")) == true)
            {
                    return new UnityEngine.Vector2() {x = val_17, y = val_16};
            }
            
                char[] val_4 = new char[1];
                val_15 = val_4;
                val_19 = "|";
                if(("|") == null)
            {
                    val_19 = "|";
            }
            
                val_15[0] = Chars[0];
                System.String[] val_6 = val_2.Split(separator:  val_4);
                bool val_8 = System.Single.TryParse(s:  val_6[0], result: out  float val_7 = -4.708987E+34f);
                bool val_10 = System.Single.TryParse(s:  val_6[1], result: out  float val_9 = -4.708985E+34f);
                UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  0f, y:  0f);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetVector2(key:  val_18, value:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
                val_17 = val_11.x;
                val_16 = val_11.y;
                return new UnityEngine.Vector2() {x = val_17, y = val_16};
            }
            
            val_18 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_18, encryptedInput:  encryptedInput);
            if(val_18 == null)
            {
                    return new UnityEngine.Vector2() {x = val_17, y = val_16};
            }
            
            val_17 = System.BitConverter.ToSingle(value:  val_18, startIndex:  0);
            val_16 = System.BitConverter.ToSingle(value:  val_18, startIndex:  4);
            return new UnityEngine.Vector2() {x = val_17, y = val_16};
        }
        public static void SetVector3(string key, UnityEngine.Vector3 value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key), value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptVector3Value(key:  key, value:  new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z}));
        }
        public static UnityEngine.Vector3 GetVector3(string key)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetVector3(key:  key, defaultValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public static UnityEngine.Vector3 GetVector3(string key, UnityEngine.Vector3 defaultValue)
        {
            float val_5;
            float val_6;
            float val_7;
            val_5 = defaultValue.z;
            val_6 = defaultValue.y;
            val_7 = defaultValue.x;
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  key, encryptedKey:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key));
            if((System.String.op_Equality(a:  val_2, b:  "{not_found}")) == true)
            {
                    return new UnityEngine.Vector3() {x = val_7, y = val_6, z = val_5};
            }
            
            UnityEngine.Vector3 val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptVector3Value(key:  key, encryptedInput:  val_2, defaultValue:  new UnityEngine.Vector3() {x = val_7, y = val_6, z = val_5});
            val_7 = val_4.x;
            val_6 = val_4.y;
            val_5 = val_4.z;
            return new UnityEngine.Vector3() {x = val_7, y = val_6, z = val_5};
        }
        private static string EncryptVector3Value(string key, UnityEngine.Vector3 value)
        {
            byte[] val_1 = new byte[12];
            System.Buffer.BlockCopy(src:  System.BitConverter.GetBytes(value:  value.x), srcOffset:  0, dst:  val_1, dstOffset:  0, count:  4);
            System.Buffer.BlockCopy(src:  System.BitConverter.GetBytes(value:  value.y), srcOffset:  0, dst:  val_1, dstOffset:  4, count:  4);
            System.Buffer.BlockCopy(src:  System.BitConverter.GetBytes(value:  value.z), srcOffset:  0, dst:  val_1, dstOffset:  8, count:  4);
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  key, cleanBytes:  val_1, type:  50);
        }
        private static UnityEngine.Vector3 DecryptVector3Value(string key, string encryptedInput, UnityEngine.Vector3 defaultValue)
        {
            System.Char[] val_17;
            float val_18;
            float val_19;
            float val_20;
            string val_21;
            var val_22;
            val_18 = defaultValue.z;
            val_19 = defaultValue.y;
            val_20 = defaultValue.x;
            val_21 = key;
            if(((encryptedInput.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  encryptedInput);
                if((System.String.op_Equality(a:  val_2, b:  "")) == true)
            {
                    return new UnityEngine.Vector3() {x = val_20, y = val_19, z = val_18};
            }
            
                char[] val_4 = new char[1];
                val_17 = val_4;
                val_22 = "|";
                if(("|") == null)
            {
                    val_22 = "|";
            }
            
                val_17[0] = Chars[0];
                System.String[] val_6 = val_2.Split(separator:  val_4);
                bool val_8 = System.Single.TryParse(s:  val_6[0], result: out  float val_7 = -5.231798E+34f);
                bool val_10 = System.Single.TryParse(s:  val_6[1], result: out  float val_9 = -5.231796E+34f);
                bool val_12 = System.Single.TryParse(s:  val_6[2], result: out  float val_11 = -5.231794E+34f);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetVector3(key:  val_21, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_20 = 0f;
                val_19 = 0f;
                val_18 = 0f;
                return new UnityEngine.Vector3() {x = val_20, y = val_19, z = val_18};
            }
            
            val_21 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_21, encryptedInput:  encryptedInput);
            if(val_21 == null)
            {
                    return new UnityEngine.Vector3() {x = val_20, y = val_19, z = val_18};
            }
            
            val_20 = System.BitConverter.ToSingle(value:  val_21, startIndex:  0);
            val_19 = System.BitConverter.ToSingle(value:  val_21, startIndex:  4);
            val_18 = System.BitConverter.ToSingle(value:  val_21, startIndex:  8);
            return new UnityEngine.Vector3() {x = val_20, y = val_19, z = val_18};
        }
        public static void SetQuaternion(string key, UnityEngine.Quaternion value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key), value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptQuaternionValue(key:  key, value:  new UnityEngine.Quaternion() {x = value.x, y = value.y, z = value.z, w = value.w}));
        }
        public static UnityEngine.Quaternion GetQuaternion(string key)
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetQuaternion(key:  key, defaultValue:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w});
        }
        public static UnityEngine.Quaternion GetQuaternion(string key, UnityEngine.Quaternion defaultValue)
        {
            float val_5;
            float val_6;
            float val_7;
            float val_8;
            val_5 = defaultValue.w;
            val_6 = defaultValue.z;
            val_7 = defaultValue.y;
            val_8 = defaultValue.x;
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  key, encryptedKey:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key));
            if((System.String.op_Equality(a:  val_2, b:  "{not_found}")) == true)
            {
                    return new UnityEngine.Quaternion() {x = val_8, y = val_7, z = val_6, w = val_5};
            }
            
            UnityEngine.Quaternion val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptQuaternionValue(key:  key, encryptedInput:  val_2, defaultValue:  new UnityEngine.Quaternion() {x = val_8, y = val_7, z = val_6, w = val_5});
            val_8 = val_4.x;
            val_7 = val_4.y;
            val_6 = val_4.z;
            val_5 = val_4.w;
            return new UnityEngine.Quaternion() {x = val_8, y = val_7, z = val_6, w = val_5};
        }
        private static string EncryptQuaternionValue(string key, UnityEngine.Quaternion value)
        {
            byte[] val_1 = new byte[16];
            System.Buffer.BlockCopy(src:  System.BitConverter.GetBytes(value:  value.x), srcOffset:  0, dst:  val_1, dstOffset:  0, count:  4);
            System.Buffer.BlockCopy(src:  System.BitConverter.GetBytes(value:  value.y), srcOffset:  0, dst:  val_1, dstOffset:  4, count:  4);
            System.Buffer.BlockCopy(src:  System.BitConverter.GetBytes(value:  value.z), srcOffset:  0, dst:  val_1, dstOffset:  8, count:  4);
            System.Buffer.BlockCopy(src:  System.BitConverter.GetBytes(value:  value.w), srcOffset:  0, dst:  val_1, dstOffset:  12, count:  4);
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  key, cleanBytes:  val_1, type:  55);
        }
        private static UnityEngine.Quaternion DecryptQuaternionValue(string key, string encryptedInput, UnityEngine.Quaternion defaultValue)
        {
            System.Char[] val_20;
            float val_21;
            float val_22;
            float val_23;
            float val_24;
            string val_25;
            var val_26;
            val_21 = defaultValue.w;
            val_22 = defaultValue.z;
            val_23 = defaultValue.y;
            val_24 = defaultValue.x;
            val_25 = key;
            if(((encryptedInput.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  encryptedInput);
                if((System.String.op_Equality(a:  val_2, b:  "")) == true)
            {
                    return new UnityEngine.Quaternion() {x = val_24, y = val_23, z = val_22, w = val_21};
            }
            
                char[] val_4 = new char[1];
                val_20 = val_4;
                val_26 = "|";
                if(("|") == null)
            {
                    val_26 = "|";
            }
            
                val_20[0] = Chars[0];
                System.String[] val_6 = val_2.Split(separator:  val_4);
                bool val_8 = System.Single.TryParse(s:  val_6[0], result: out  float val_7 = -5.795237E+34f);
                bool val_10 = System.Single.TryParse(s:  val_6[1], result: out  float val_9 = -5.795235E+34f);
                bool val_12 = System.Single.TryParse(s:  val_6[2], result: out  float val_11 = -5.795213E+34f);
                bool val_14 = System.Single.TryParse(s:  val_6[3], result: out  float val_13 = -5.795211E+34f);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetQuaternion(key:  val_25, value:  new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f});
                val_24 = 0f;
                val_23 = 0f;
                val_22 = 0f;
                val_21 = 0f;
                return new UnityEngine.Quaternion() {x = val_24, y = val_23, z = val_22, w = val_21};
            }
            
            val_25 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_25, encryptedInput:  encryptedInput);
            if(val_25 == null)
            {
                    return new UnityEngine.Quaternion() {x = val_24, y = val_23, z = val_22, w = val_21};
            }
            
            val_24 = System.BitConverter.ToSingle(value:  val_25, startIndex:  0);
            val_23 = System.BitConverter.ToSingle(value:  val_25, startIndex:  4);
            val_22 = System.BitConverter.ToSingle(value:  val_25, startIndex:  8);
            val_21 = System.BitConverter.ToSingle(value:  val_25, startIndex:  12);
            return new UnityEngine.Quaternion() {x = val_24, y = val_23, z = val_22, w = val_21};
        }
        public static void SetColor(string key, UnityEngine.Color32 value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key), value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptColorValue(key:  key, value:  value.r & 4278255360));
        }
        public static UnityEngine.Color32 GetColor(string key)
        {
            UnityEngine.Color32 val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetColor(key:  key, defaultValue:  new UnityEngine.Color32());
            val_1.r = val_1.r & 4294967295;
            return new UnityEngine.Color32() {r = val_1.r, g = val_1.r, b = val_1.r, a = val_1.r};
        }
        public static UnityEngine.Color32 GetColor(string key, UnityEngine.Color32 defaultValue)
        {
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  key, encryptedKey:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key));
            if((System.String.op_Equality(a:  val_2, b:  "{not_found}")) != false)
            {
                    return new UnityEngine.Color32();
            }
            
            string val_7 = val_2;
            uint val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptUIntValue(key:  key, encryptedInput:  val_7, defaultValue:  16777216);
            uint val_5 = val_4 >> 24;
            val_7 = val_4 >> 16;
            uint val_6 = val_4 >> 8;
            defaultValue.r = 0;
            return new UnityEngine.Color32();
        }
        private static string EncryptColorValue(string key, uint value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  key, cleanBytes:  System.BitConverter.GetBytes(value:  value), type:  60);
        }
        public static void SetRect(string key, UnityEngine.Rect value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key), value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptRectValue(key:  key, value:  new UnityEngine.Rect() {m_XMin = value.m_XMin, m_YMin = value.m_YMin, m_Width = value.m_Width, m_Height = value.m_Height}));
        }
        public static UnityEngine.Rect GetRect(string key)
        {
            UnityEngine.Rect val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetRect(key:  key, defaultValue:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
            return new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_Height};
        }
        public static UnityEngine.Rect GetRect(string key, UnityEngine.Rect defaultValue)
        {
            float val_5;
            float val_6;
            float val_7;
            float val_8;
            val_5 = defaultValue.m_Height;
            val_6 = defaultValue.m_Width;
            val_7 = defaultValue.m_YMin;
            val_8 = defaultValue.m_XMin;
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  key, encryptedKey:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key));
            if((System.String.op_Equality(a:  val_2, b:  "{not_found}")) == true)
            {
                    return new UnityEngine.Rect() {m_XMin = val_8, m_YMin = val_7, m_Width = val_6, m_Height = val_5};
            }
            
            UnityEngine.Rect val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptRectValue(key:  key, encryptedInput:  val_2, defaultValue:  new UnityEngine.Rect() {m_XMin = val_8, m_YMin = val_7, m_Width = val_6, m_Height = val_5});
            val_8 = val_4.m_XMin;
            val_7 = val_4.m_YMin;
            val_6 = val_4.m_Width;
            val_5 = val_4.m_Height;
            return new UnityEngine.Rect() {m_XMin = val_8, m_YMin = val_7, m_Width = val_6, m_Height = val_5};
        }
        private static string EncryptRectValue(string key, UnityEngine.Rect value)
        {
            byte[] val_1 = new byte[16];
            float val_2 = value.m_XMin.System.IConvertible.ToSingle(provider:  0);
            System.Buffer.BlockCopy(src:  System.BitConverter.GetBytes(value:  val_2), srcOffset:  0, dst:  val_1, dstOffset:  0, count:  4);
            System.Buffer.BlockCopy(src:  System.BitConverter.GetBytes(value:  val_2), srcOffset:  0, dst:  val_1, dstOffset:  4, count:  4);
            System.Buffer.BlockCopy(src:  System.BitConverter.GetBytes(value:  val_2), srcOffset:  0, dst:  val_1, dstOffset:  8, count:  4);
            System.Buffer.BlockCopy(src:  System.BitConverter.GetBytes(value:  val_2), srcOffset:  0, dst:  val_1, dstOffset:  12, count:  4);
            return (string)CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  key, cleanBytes:  val_1, type:  65);
        }
        private static UnityEngine.Rect DecryptRectValue(string key, string encryptedInput, UnityEngine.Rect defaultValue)
        {
            System.Char[] val_20;
            float val_21;
            float val_22;
            float val_23;
            float val_24;
            string val_25;
            var val_26;
            val_21 = defaultValue.m_Height;
            val_22 = defaultValue.m_Width;
            val_23 = defaultValue.m_YMin;
            val_24 = defaultValue.m_XMin;
            val_25 = key;
            if(((encryptedInput.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  encryptedInput);
                if((System.String.op_Equality(a:  val_2, b:  "")) == true)
            {
                    return new UnityEngine.Rect() {m_XMin = val_24, m_YMin = val_23, m_Width = val_22, m_Height = val_21};
            }
            
                char[] val_4 = new char[1];
                val_20 = val_4;
                val_26 = "|";
                if(("|") == null)
            {
                    val_26 = "|";
            }
            
                val_20[0] = Chars[0];
                System.String[] val_6 = val_2.Split(separator:  val_4);
                bool val_8 = System.Single.TryParse(s:  val_6[0], result: out  float val_7 = -6.655544E+34f);
                bool val_10 = System.Single.TryParse(s:  val_6[1], result: out  float val_9 = -6.655542E+34f);
                bool val_12 = System.Single.TryParse(s:  val_6[2], result: out  float val_11 = -6.655512E+34f);
                bool val_14 = System.Single.TryParse(s:  val_6[3], result: out  float val_13 = -6.65551E+34f);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetRect(key:  val_25, value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
                val_24 = 0f;
                val_23 = 0f;
                val_22 = 0f;
                val_21 = 0f;
                return new UnityEngine.Rect() {m_XMin = val_24, m_YMin = val_23, m_Width = val_22, m_Height = val_21};
            }
            
            val_25 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_25, encryptedInput:  encryptedInput);
            if(val_25 == null)
            {
                    return new UnityEngine.Rect() {m_XMin = val_24, m_YMin = val_23, m_Width = val_22, m_Height = val_21};
            }
            
            0.x = System.BitConverter.ToSingle(value:  val_25, startIndex:  0);
            float val_17 = System.BitConverter.ToSingle(value:  val_25, startIndex:  4);
            float val_18 = System.BitConverter.ToSingle(value:  val_25, startIndex:  8);
            float val_19 = System.BitConverter.ToSingle(value:  val_25, startIndex:  12);
            val_24 = 0f;
            val_23 = 0f;
            val_22 = 0f;
            val_21 = 0f;
            return new UnityEngine.Rect() {m_XMin = val_24, m_YMin = val_23, m_Width = val_22, m_Height = val_21};
        }
        public static void SetRawValue(string key, string encryptedValue)
        {
            UnityEngine.PlayerPrefs.SetString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key), value:  encryptedValue);
        }
        public static string GetRawValue(string key)
        {
            return UnityEngine.PlayerPrefs.GetString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key));
        }
        internal static CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DataType GetRawValueType(string value)
        {
            byte val_3;
            byte val_4;
            val_3 = System.Convert.FromBase64String(s:  value);
            if(val_1.Length >= 7)
            {
                    val_4 = val_3[((-30064771072) + ((val_1.Length) << 32)) >> 32];
                return (DataType)val_4;
            }
            
            val_4 = 0;
            return (DataType)val_4;
        }
        internal static string EncryptKey(string key)
        {
            null = null;
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.EncryptDecrypt(value:  key, key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.cryptoKey);
            return System.Convert.ToBase64String(inArray:  System.Text.Encoding.UTF8);
        }
        public static bool HasKey(string key)
        {
            if((UnityEngine.PlayerPrefs.HasKey(key:  key)) == false)
            {
                    return UnityEngine.PlayerPrefs.HasKey(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key));
            }
            
            return true;
        }
        public static void DeleteKey(string key)
        {
            UnityEngine.PlayerPrefs.DeleteKey(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  key));
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.preservePlayerPrefs != false)
            {
                    return;
            }
            
            UnityEngine.PlayerPrefs.DeleteKey(key:  key);
        }
        public static void DeleteAll()
        {
            UnityEngine.PlayerPrefs.DeleteAll();
        }
        public static void Save()
        {
            UnityEngine.PlayerPrefs.Save();
        }
        private static string GetEncryptedPrefsString(string key, string encryptedKey)
        {
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  encryptedKey, defaultValue:  "{not_found}");
            if((System.String.op_Equality(a:  val_1, b:  "{not_found}")) == false)
            {
                    return val_1;
            }
            
            if((UnityEngine.PlayerPrefs.HasKey(key:  key)) == false)
            {
                    return val_1;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[ACTk] Are you trying to read regular PlayerPrefs data using ObscuredPrefs (key = "("[ACTk] Are you trying to read regular PlayerPrefs data using ObscuredPrefs (key = ") + key + ")?"(")?"));
            return val_1;
        }
        private static string EncryptData(string key, byte[] cleanBytes, CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DataType type)
        {
            var val_20;
            int val_21;
            var val_22;
            System.Array val_23;
            int val_24;
            var val_25;
            var val_26;
            val_20 = null;
            val_20 = null;
            uint val_3 = CodeStage.AntiCheat.Utils.xxHash.CalculateHash(buf:  cleanBytes, len:  cleanBytes.Length, seed:  0);
            byte[] val_4 = new byte[4];
            val_21 = val_4.Length;
            if(val_21 == 0)
            {
                    val_21 = val_4.Length;
            }
            
            val_4[0] = val_3;
            if(val_21 <= 1)
            {
                    val_21 = val_4.Length;
            }
            
            val_4[0] = val_3 >> 8;
            if(val_21 <= 2)
            {
                    val_21 = val_4.Length;
            }
            
            val_4[0] = val_3 >> 16;
            val_4[0] = val_3 >> 24;
            val_22 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.lockToDevice != 0)
            {
                    uint val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeviceIdHash;
                val_23 = new byte[4];
                val_24 = val_9.Length;
                if(val_24 == 0)
            {
                    val_24 = val_9.Length;
            }
            
                val_23[0] = val_8;
                if(val_24 <= 1)
            {
                    val_24 = val_9.Length;
            }
            
                val_23[0] = val_8 >> 8;
                if(val_24 <= 2)
            {
                    val_24 = val_9.Length;
            }
            
                val_25 = cleanBytes.Length + 11;
                val_23[0] = val_8 >> 16;
                val_23[0] = val_8 >> 24;
            }
            else
            {
                    val_23 = 0;
                val_25 = cleanBytes.Length + 7;
            }
            
            byte[] val_13 = new byte[0];
            System.Buffer.BlockCopy(src:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptDecryptBytes(bytes:  cleanBytes, dataLength:  cleanBytes.Length, key:  key + CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.cryptoKey), srcOffset:  0, dst:  val_13, dstOffset:  0, count:  cleanBytes.Length);
            if(val_23 != 0)
            {
                    System.Buffer.BlockCopy(src:  val_23, srcOffset:  0, dst:  val_13, dstOffset:  cleanBytes.Length, count:  4);
            }
            
            val_13[(long)val_25 - 7] = type;
            val_13[(long)val_25 - 6] = 2;
            val_26 = null;
            val_26 = null;
            val_13[(long)val_25 - 5] = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.lockToDevice;
            System.Buffer.BlockCopy(src:  val_4, srcOffset:  0, dst:  val_13, dstOffset:  val_25 - 4, count:  4);
            return System.Convert.ToBase64String(inArray:  val_13);
        }
        internal static byte[] DecryptData(string key, string encryptedInput)
        {
            int val_15;
            var val_16;
            byte val_17;
            int val_18;
            byte val_19;
            var val_20;
            int val_21;
            var val_22;
            var val_24;
            var val_25;
            var val_27;
            System.Byte[] val_1 = System.Convert.FromBase64String(s:  encryptedInput);
            if(val_1.Length == 0)
            {
                goto label_6;
            }
            
            val_15 = val_1.Length - 5;
            val_16 = ((-25769803776) + ((val_1.Length) << 32)) >> 32;
            if(val_1[val_16] != 2)
            {
                goto label_6;
            }
            
            val_17 = val_1[(long)val_15];
            byte[] val_3 = new byte[4];
            System.Buffer.BlockCopy(src:  val_1, srcOffset:  val_1.Length - 4, dst:  val_3, dstOffset:  0, count:  4);
            val_18 = val_3.Length;
            if(val_18 == 0)
            {
                    val_18 = val_3.Length;
            }
            
            if(val_18 <= 1)
            {
                    val_18 = val_3.Length;
            }
            
            val_19 = val_3[0];
            if(val_18 <= 2)
            {
                    val_18 = val_3.Length;
            }
            
            byte val_13 = val_3[0];
            byte val_14 = val_3[0];
            if(val_17 == 0)
            {
                goto label_13;
            }
            
            val_15 = val_1.Length - 11;
            val_20 = null;
            val_20 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.lockToDevice == 0)
            {
                goto label_16;
            }
            
            byte[] val_5 = new byte[4];
            System.Buffer.BlockCopy(src:  val_1, srcOffset:  val_15, dst:  val_5, dstOffset:  0, count:  4);
            val_21 = val_5.Length;
            if(val_21 == 0)
            {
                    val_21 = val_5.Length;
            }
            
            byte val_15 = val_5[0];
            if(val_21 <= 1)
            {
                    val_21 = val_5.Length;
            }
            
            val_19 = val_5[0];
            if(val_21 <= 2)
            {
                    val_21 = val_5.Length;
            }
            
            byte val_16 = val_5[0];
            byte val_17 = val_5[0];
            goto label_23;
            label_13:
            val_15 = val_1.Length - 7;
            goto label_23;
            label_16:
            val_17 = 0;
            label_23:
            byte[] val_6 = new byte[0];
            System.Buffer.BlockCopy(src:  val_1, srcOffset:  0, dst:  val_6, dstOffset:  0, count:  val_15);
            val_22 = null;
            val_22 = null;
            System.Byte[] val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptDecryptBytes(bytes:  val_6, dataLength:  val_15, key:  key + CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.cryptoKey);
            val_24 = val_8;
            val_25 = null;
            if((CodeStage.AntiCheat.Utils.xxHash.CalculateHash(buf:  val_8, len:  val_15, seed:  0)) != val_3[0])
            {
                goto label_26;
            }
            
            val_25 = null;
            if((val_17 != 0) || (CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.lockToDevice != 2))
            {
                goto label_33;
            }
            
            val_25 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.emergencyMode == true)
            {
                goto label_33;
            }
            
            val_25 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.readForeignSaves == false)
            {
                goto label_47;
            }
            
            label_33:
            if(val_17 == 0)
            {
                    return (System.Byte[])val_24;
            }
            
            val_25 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.emergencyMode == true)
            {
                    return (System.Byte[])val_24;
            }
            
            if(val_17 == CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeviceIdHash)
            {
                    return (System.Byte[])val_24;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.PossibleForeignSavesDetected();
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.readForeignSaves == true)
            {
                    return (System.Byte[])val_24;
            }
            
            goto label_47;
            label_26:
            val_27 = val_25;
            goto label_50;
            label_6:
            val_27 = null;
            label_50:
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SavesTampered();
            label_47:
            val_24 = 0;
            return (System.Byte[])val_24;
        }
        private static uint CalculateChecksum(string input)
        {
            var val_3;
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            val_3 = null;
            val_3 = null;
            string val_2 = input + CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.cryptoKey;
            if(val_1 != null)
            {
                    return CodeStage.AntiCheat.Utils.xxHash.CalculateHash(buf:  val_1, len:  val_1.dataItem, seed:  0);
            }
            
            return CodeStage.AntiCheat.Utils.xxHash.CalculateHash(buf:  val_1, len:  val_1.dataItem, seed:  0);
        }
        private static void SavesTampered()
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.onAlterationDetected;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.onAlterationDetected;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke();
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.onAlterationDetected = 0;
        }
        private static void PossibleForeignSavesDetected()
        {
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.onPossibleForeignSavesDetected == null)
            {
                    return;
            }
            
            null = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.__il2cppRuntimeField_static_fields != 0)
            {
                    return;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DEPRECATED_RAW_SEPARATOR = 1;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.onPossibleForeignSavesDetected.Invoke();
        }
        private static string GetDeviceId()
        {
            if((System.String.IsNullOrEmpty(value:  "")) == false)
            {
                    return "";
            }
            
            return UnityEngine.SystemInfo.deviceUniqueIdentifier;
        }
        private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key)
        {
            int val_1 = key.Length;
            byte[] val_2 = new byte[0];
            if(dataLength < 1)
            {
                    return (System.Byte[])val_2;
            }
            
            var val_8 = 0;
            do
            {
                char val_7 = key.Chars[val_8 - ((val_8 / val_1) * val_1)];
                val_7 = (val_7 & 65535) ^ 1152921505160541696;
                mem2[0] = val_7;
                val_8 = val_8 + 1;
            }
            while(dataLength != val_8);
            
            return (System.Byte[])val_2;
        }
        private static string DeprecatedDecryptValue(string value)
        {
            var val_15;
            var val_16;
            string val_17;
            var val_18;
            var val_19;
            string val_22;
            string val_23;
            char[] val_1 = new char[1];
            val_1[0] = ':';
            System.String[] val_2 = value.Split(separator:  val_1);
            if(val_2.Length <= 1)
            {
                goto label_5;
            }
            
            string val_15 = val_2[0];
            string val_16 = val_2[1];
            System.Text.Encoding val_4 = System.Text.Encoding.UTF8;
            if((System.Convert.FromBase64String(s:  val_15)) == null)
            {
                goto label_9;
            }
            
            label_26:
            val_15 = null;
            val_15 = null;
            val_16 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.EncryptDecrypt(value:  val_4, key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.cryptoKey);
            if(val_2.Length != 3)
            {
                goto label_15;
            }
            
            string val_7 = val_15 + CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDeviceId;
            goto label_18;
            label_15:
            val_18 = null;
            if(val_2.Length != 2)
            {
                goto label_19;
            }
            
            val_17 = val_15;
            label_18:
            if((System.String.op_Inequality(a:  val_16, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedCalculateChecksum(input:  val_17))) == false)
            {
                goto label_22;
            }
            
            val_18 = null;
            goto label_28;
            label_9:
            if(val_4 != null)
            {
                goto label_26;
            }
            
            goto label_26;
            label_19:
            label_28:
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SavesTampered();
            label_22:
            val_19 = null;
            val_19 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.lockToDevice == 0)
            {
                    return (string)val_16;
            }
            
            val_19 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.emergencyMode == true)
            {
                    return (string)val_16;
            }
            
            if(val_2.Length >= 3)
            {
                goto label_35;
            }
            
            val_19 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.lockToDevice != 2)
            {
                goto label_38;
            }
            
            val_19 = null;
            var val_10 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.readForeignSaves == true) ? (val_16) : "";
            goto label_52;
            label_35:
            val_22 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDeviceId;
            val_23 = val_2[2];
            goto label_45;
            label_38:
            val_22 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedCalculateChecksum(input:  val_15);
            val_23 = val_16;
            label_45:
            if((System.String.op_Inequality(a:  val_23, b:  val_22)) == false)
            {
                    return (string)val_16;
            }
            
            val_19 = null;
            val_19 = null;
            var val_14 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.readForeignSaves == true) ? (val_16) : "";
            label_52:
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.PossibleForeignSavesDetected();
            return (string)val_16;
            label_5:
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SavesTampered();
            val_16 = "";
            return (string)val_16;
        }
        private static string DeprecatedCalculateChecksum(string input)
        {
            var val_9;
            System.Globalization.CodePageDataItem val_10;
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            val_9 = null;
            val_9 = null;
            string val_2 = input + CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.cryptoKey;
            val_10 = val_1.dataItem;
            if(val_10 < 1)
            {
                    return (string)val_11.ToString(format:  "X2");
            }
            
            int val_11 = 0;
            var val_9 = 0;
            val_10 = val_10 & 4294967295;
            do
            {
                var val_10 = val_1.m_deserializedFromEverett + 0;
                int val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.cryptoKey.Length ^ 64 + val_9;
                val_9 = val_9 + 1;
                val_5 = val_5 * val_10;
                var val_7 = X10 >> 32;
                val_7 = val_7 + (X10 >> 63);
                val_7 = val_7 + (val_7 << 1);
                val_10 = val_11 + val_10;
                val_5 = val_5 - val_7;
                val_11 = val_10 + val_5;
            }
            while(val_10 != val_9);
            
            return (string)val_11.ToString(format:  "X2");
        }
        private static string get_DeprecatedDeviceId()
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            val_5 = null;
            if((System.String.IsNullOrEmpty(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deprecatedDeviceId)) != false)
            {
                    val_5 = null;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deprecatedDeviceId = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedCalculateChecksum(input:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeviceId);
            }
            
            val_5 = null;
            return (string)CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deprecatedDeviceId;
        }
        private static ObscuredPrefs()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.cryptoKey = "e806f6";
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.preservePlayerPrefs = false;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.onPossibleForeignSavesDetected = 0;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.lockToDevice = 0;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.readForeignSaves = false;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.emergencyMode = false;
        }
    
    }

}
