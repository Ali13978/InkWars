using UnityEngine;

namespace CMS.IO
{
    public static class ReadOnlyDataFile
    {
        // Methods
        public static string Load(string path, CMS.IO.PathType type = 1)
        {
            int val_17;
            string val_18;
            string val_19;
            string val_1 = CMS.IO.EncryptedFile.Load(path:  path, type:  type, fileBasedKeyGenerationSteps:  0);
            if(val_1 != null)
            {
                    val_17 = val_1.IndexOf(value:  ",");
            }
            else
            {
                    val_17 = 0.IndexOf(value:  ",");
            }
            
            int val_5 = System.Int32.Parse(s:  val_1.Substring(startIndex:  0, length:  val_17));
            string val_7 = val_1.Substring(startIndex:  val_17 + 1);
            if(val_7 != null)
            {
                    val_18 = val_7.Substring(startIndex:  0, length:  val_5);
            }
            else
            {
                    val_18 = 0.Substring(startIndex:  0, length:  val_5);
            }
            
            if((System.Type.GetType(typeName:  "ReadOnlySecurityKey")) == null)
            {
                    System.Type val_12 = System.Type.GetType(typeName:  "ReadOnlySecurityKey");
            }
            
            val_19 = 0.GetProperty(name:  "DECRYPT_KEY");
            if(val_19 == null)
            {
                    return (string)CMS.Security.Cryptography.AES.Decrypt(inputBase64:  val_7.Substring(startIndex:  val_5), passphrase:  CMS.Security.Cryptography.RSA.Decrypt(content:  val_18, privatekey:  val_19 = 0));
            }
            
            return (string)CMS.Security.Cryptography.AES.Decrypt(inputBase64:  val_7.Substring(startIndex:  val_5), passphrase:  CMS.Security.Cryptography.RSA.Decrypt(content:  val_18, privatekey:  val_19));
        }
        public static string GetReadOnlyString(string source)
        {
            string val_17;
            var val_18;
            int val_19;
            string val_20;
            val_17 = source;
            val_18 = 0;
            if((System.String.IsNullOrEmpty(value:  val_17)) == true)
            {
                    return (string)CMS.Security.Cryptography.AES.Decrypt(inputBase64:  val_7.Substring(startIndex:  int val_5 = System.Int32.Parse(s:  val_17.Substring(startIndex:  0, length:  val_19 = 0.IndexOf(value:  ",")))), passphrase:  CMS.Security.Cryptography.RSA.Decrypt(content:  val_17 = 0.Substring(startIndex:  0, length:  val_5), privatekey:  val_20 = 0));
            }
            
            if(val_17 != null)
            {
                    val_19 = val_17.IndexOf(value:  ",");
            }
            else
            {
                
            }
            
            string val_7 = val_17.Substring(startIndex:  val_19 + 1);
            if(val_7 != null)
            {
                    val_17 = val_7.Substring(startIndex:  0, length:  val_5);
            }
            else
            {
                
            }
            
            if((System.Type.GetType(typeName:  "ReadOnlySecurityKey")) == null)
            {
                    System.Type val_12 = System.Type.GetType(typeName:  "ReadOnlySecurityKey");
            }
            
            val_20 = 0.GetProperty(name:  "DECRYPT_KEY");
            if(val_20 == null)
            {
                    return (string)CMS.Security.Cryptography.AES.Decrypt(inputBase64:  val_7.Substring(startIndex:  val_5), passphrase:  CMS.Security.Cryptography.RSA.Decrypt(content:  val_17, privatekey:  val_20));
            }
            
            return (string)CMS.Security.Cryptography.AES.Decrypt(inputBase64:  val_7.Substring(startIndex:  val_5), passphrase:  CMS.Security.Cryptography.RSA.Decrypt(content:  val_17, privatekey:  val_20));
        }
    
    }

}
