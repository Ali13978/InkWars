using UnityEngine;

namespace CMS.IO
{
    public static class EncryptedFile
    {
        // Fields
        public static System.Func<string> customGlobalKeyGenerationSteps;
        private static string prefix;
        
        // Methods
        private static string GenerateKey()
        {
            string val_1 = CMS.Security.Cryptography.MD5.Encrypt(strToEncrypt:  ";LKSJDF;oikljfalisoh+vklsnhdglq*3br5hv298Ul-okCNAJKSGLRKWJHDkjludsbgqwj239sz");
            return CMS.Security.Cryptography.AES.Encrypt(input:  val_1, passphrase:  val_1);
        }
        public static bool Save(string data, string path, CMS.IO.PathType type, System.Func<string> fileBasedKeyGenerationSteps)
        {
            string val_12;
            if(fileBasedKeyGenerationSteps != null)
            {
                    val_12 = fileBasedKeyGenerationSteps.Invoke();
            }
            else
            {
                    val_12 = "";
            }
            
            string val_4 = CMS.Security.Cryptography.MD5.Encrypt(strToEncrypt:  data);
            bool val_11 = CMS.IO.AssetsFile.Save(data:  CMS.IO.EncryptedFile.CreatePrefix(number:  val_4.Length)(CMS.IO.EncryptedFile.CreatePrefix(number:  val_4.Length)) + val_4 + CMS.Security.Cryptography.AES.Encrypt(input:  data, passphrase:  CMS.IO.EncryptedFile.GenerateKey() + val_12 + CMS.Security.Cryptography.MD5.Encrypt(strToEncrypt:  path)(CMS.Security.Cryptography.MD5.Encrypt(strToEncrypt:  path))(val_12 + CMS.Security.Cryptography.MD5.Encrypt(strToEncrypt:  path)(CMS.Security.Cryptography.MD5.Encrypt(strToEncrypt:  path))))(CMS.Security.Cryptography.AES.Encrypt(input:  data, passphrase:  CMS.IO.EncryptedFile.GenerateKey() + val_12 + CMS.Security.Cryptography.MD5.Encrypt(strToEncrypt:  path)(CMS.Security.Cryptography.MD5.Encrypt(strToEncrypt:  path))(val_12 + CMS.Security.Cryptography.MD5.Encrypt(strToEncrypt:  path)(CMS.Security.Cryptography.MD5.Encrypt(strToEncrypt:  path))))), path:  path, type:  type);
            return true;
        }
        public static string Load(string path, CMS.IO.PathType type, System.Func<string> fileBasedKeyGenerationSteps)
        {
            string val_19;
            string val_20;
            string val_21;
            var val_22;
            var val_23;
            if(fileBasedKeyGenerationSteps != null)
            {
                    val_19 = fileBasedKeyGenerationSteps.Invoke();
            }
            else
            {
                    val_19 = "";
            }
            
            val_20 = val_19 + CMS.Security.Cryptography.MD5.Encrypt(strToEncrypt:  path)(CMS.Security.Cryptography.MD5.Encrypt(strToEncrypt:  path));
            val_21 = CMS.IO.AssetsFile.Load(path:  path, type:  type);
            int val_5 = CMS.IO.EncryptedFile.GetPrefixNumber(data:  val_21);
            if((val_5 & 2147483648) != 0)
            {
                goto label_5;
            }
            
            if(val_21 == null)
            {
                goto label_6;
            }
            
            val_22 = val_21.IndexOf(value:  '+');
            goto label_7;
            label_5:
            val_23 = 0;
            return (string)((System.String.op_Inequality(a:  CMS.Security.Cryptography.MD5.Encrypt(strToEncrypt:  string val_15 = CMS.Security.Cryptography.AES.Decrypt(inputBase64:  val_9.Substring(startIndex:  val_5), passphrase:  CMS.IO.EncryptedFile.GenerateKey() + val_20)), b:  val_21 = 0.Substring(startIndex:  0, length:  val_5))) != true) ? 0 : (val_20);
            label_6:
            val_22 = 0.IndexOf(value:  '+');
            label_7:
            string val_9 = val_21.Substring(startIndex:  val_22 + 1);
            if(val_9 != null)
            {
                    val_21 = val_9.Substring(startIndex:  0, length:  val_5);
            }
            else
            {
                
            }
            
            val_20 = val_15;
            return (string)((System.String.op_Inequality(a:  CMS.Security.Cryptography.MD5.Encrypt(strToEncrypt:  val_15), b:  val_21)) != true) ? 0 : (val_20);
        }
        private static string CreatePrefix(int number)
        {
            char val_21;
            var val_22;
            var val_23;
            var val_24;
            System.Collections.Generic.List<System.Char> val_2 = null;
            val_21 = 1152921511236735520;
            val_2 = new System.Collections.Generic.List<System.Char>();
            val_2.AddRange(collection:  number.ToString().ToCharArray());
            System.Collections.Generic.List<System.Char> val_4 = new System.Collections.Generic.List<System.Char>();
            val_22 = null;
            val_22 = null;
            val_4.AddRange(collection:  CMS.IO.EncryptedFile.prefix.ToCharArray());
            int val_21 = UnityEngine.Random.Range(min:  5, max:  12);
            if(val_21 >= 1)
            {
                    val_23 = 1152921511236205024;
                do
            {
                val_21 = val_4.Item[UnityEngine.Random.Range(min:  0, max:  val_4.Count - 1)];
                val_2.Insert(index:  UnityEngine.Random.Range(min:  0, max:  val_2.Count - 1), item:  val_21);
                val_21 = val_21 - 1;
            }
            while(val_21 != 0);
            
            }
            
            val_24 = UnityEngine.Random.Range(min:  2, max:  5);
            if(val_24 >= 1)
            {
                    val_21 = 1152921511236156672;
                val_23 = 1152921511236151552;
                do
            {
                val_2.Add(item:  val_4.Item[UnityEngine.Random.Range(min:  0, max:  val_4.Count - 1)]);
                val_24 = val_24 - 1;
            }
            while(val_24 != 0);
            
            }
            
            if(val_2 != null)
            {
                    val_2.Add(item:  '+');
                return (string)0.CreateString(val:  val_2.ToArray());
            }
            
            val_2.Add(item:  '+');
            return (string)0.CreateString(val:  val_2.ToArray());
        }
        private static int GetPrefixNumber(string data)
        {
            var val_8;
            string val_9;
            char[] val_1 = new char[1];
            val_1[0] = '+';
            string val_8 = data.Split(separator:  val_1)[0];
            val_8 = 0;
            val_9 = mem[static_value_032D1378 + 184];
            val_9 = static_value_032D1378 + 184;
            goto label_6;
            label_12:
            char val_3 = val_8.Chars[0];
            if((System.Char.IsDigit(c:  val_3)) != false)
            {
                    val_9 = val_9 + val_3;
            }
            
            val_8 = 1;
            label_6:
            if(val_8 < val_8.Length)
            {
                goto label_12;
            }
            
            return (int)System.Int32.Parse(s:  val_9);
        }
        private static EncryptedFile()
        {
            CMS.IO.EncryptedFile.customGlobalKeyGenerationSteps = 0;
            CMS.IO.EncryptedFile.prefix = "QPWOIEUqwebgvszdRTYASLKDJHszdxcvbFGBVZXM.,MNhgdfB";
        }
    
    }

}
