using UnityEngine;

namespace CMS.IO
{
    public static class DeviceBasedFile
    {
        // Fields
        public static System.Func<string> customGlobalKeyGenerationSteps;
        
        // Methods
        private static string GenerateKey()
        {
            var val_9;
            System.Func<System.String> val_10;
            string val_11;
            val_9 = null;
            val_9 = null;
            val_10 = CMS.IO.DeviceBasedFile.customGlobalKeyGenerationSteps;
            if(val_10 != null)
            {
                    val_10 = CMS.IO.DeviceBasedFile.customGlobalKeyGenerationSteps;
                if(val_10 == null)
            {
                    val_10 = 0;
            }
            
                val_11 = val_10.Invoke();
            }
            else
            {
                    val_11 = "";
            }
            
            string val_8 = val_11 + AndroidNativeFunctions.GetAndroidID() + CMS.Security.Cryptography.AES.Encrypt(input:  AndroidNativeFunctions.GetAndroidID(), passphrase:  "Device Based File Key")(CMS.Security.Cryptography.AES.Encrypt(input:  AndroidNativeFunctions.GetAndroidID(), passphrase:  "Device Based File Key")) + CMS.Security.Cryptography.MD5.Encrypt(strToEncrypt:  AndroidNativeFunctions.GetAndroidID() + val_11)(CMS.Security.Cryptography.MD5.Encrypt(strToEncrypt:  AndroidNativeFunctions.GetAndroidID() + val_11));
            return CMS.Security.Cryptography.AES.Encrypt(input:  val_8, passphrase:  val_8);
        }
        public static bool Save(string data, string path, CMS.IO.PathType type = 0)
        {
            bool val_2 = CMS.IO.EncryptedFile.Save(data:  data, path:  path, type:  type, fileBasedKeyGenerationSteps:  new System.Func<System.String>(object:  0, method:  static System.String CMS.IO.DeviceBasedFile::GenerateKey()));
            return true;
        }
        public static string Load(string path, CMS.IO.PathType type = 0)
        {
            return CMS.IO.EncryptedFile.Load(path:  path, type:  type, fileBasedKeyGenerationSteps:  new System.Func<System.String>(object:  0, method:  static System.String CMS.IO.DeviceBasedFile::GenerateKey()));
        }
        private static DeviceBasedFile()
        {
        
        }
    
    }

}
