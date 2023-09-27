using UnityEngine;

namespace CMS.Security.Cryptography
{
    public static class AES
    {
        // Methods
        public static string Encrypt(string input, string passphrase)
        {
            System.Byte[] val_2 = 0;
            System.Byte[] val_3 = 0;
            CMS.Security.Cryptography.AES.DeriveKeyAndIV(data:  CMS.Security.Cryptography.AES.RawBytesFromString(input:  passphrase), salt:  0, count:  1, key: out  val_2, iv: out  val_3);
            return (string)System.Convert.ToBase64String(inArray:  CMS.Security.Cryptography.AES.EncryptStringToBytes(plainText:  input, Key:  val_2, IV:  val_3));
        }
        public static string Decrypt(string inputBase64, string passphrase)
        {
            System.Byte[] val_2 = 0;
            System.Byte[] val_3 = 0;
            CMS.Security.Cryptography.AES.DeriveKeyAndIV(data:  CMS.Security.Cryptography.AES.RawBytesFromString(input:  passphrase), salt:  0, count:  1, key: out  val_2, iv: out  val_3);
            return (string)CMS.Security.Cryptography.AES.DecryptStringFromBytes(cipherText:  System.Convert.FromBase64String(s:  inputBase64), Key:  val_2, IV:  val_3);
        }
        private static byte[] RawBytesFromString(string input)
        {
            var val_4;
            System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>();
            val_4 = 0;
            goto label_1;
            label_5:
            val_1.Add(item:  input.Chars[0]);
            val_4 = 1;
            label_1:
            if(val_4 < input.Length)
            {
                goto label_5;
            }
            
            if(val_1 != null)
            {
                    return val_1.ToArray();
            }
            
            return val_1.ToArray();
        }
        private static void DeriveKeyAndIV(byte[] data, byte[] salt, int count, out byte[] key, out byte[] iv)
        {
            int val_18;
            System.Byte[] val_19;
            int val_20;
            System.Array val_21;
            System.Byte[] val_22;
            T[] val_23;
            System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>();
            byte[] val_2 = new byte[0];
            if(salt != null)
            {
                    val_18 = salt.Length;
            }
            else
            {
                    val_18 = 0;
            }
            
            int val_3 = val_18 + data.Length;
            byte[] val_4 = new byte[0];
            System.Buffer.BlockCopy(src:  data, srcOffset:  0, dst:  val_4, dstOffset:  0, count:  data.Length);
            if(salt != null)
            {
                    System.Buffer.BlockCopy(src:  salt, srcOffset:  0, dst:  val_4, dstOffset:  data.Length, count:  salt.Length);
            }
            
            System.Security.Cryptography.MD5 val_5 = System.Security.Cryptography.MD5.Create();
            val_19 = val_5.ComputeHash(buffer:  val_4);
            if(count >= 2)
            {
                    int val_7 = count - 1;
                do
            {
                val_7 = val_7 - 1;
                val_19 = val_5.ComputeHash(buffer:  val_19);
            }
            while(val_7 != 0);
            
            }
            
            val_1.AddRange(collection:  val_19);
            goto label_10;
            label_24:
            if(val_19 == null)
            {
                goto label_11;
            }
            
            label_16:
            int val_18 = val_8.Length;
            val_18 = data.Length + val_18;
            if(salt == null)
            {
                goto label_13;
            }
            
            val_20 = salt.Length;
            goto label_14;
            label_11:
            if(data != null)
            {
                goto label_16;
            }
            
            goto label_16;
            label_13:
            val_20 = 0;
            label_14:
            int val_10 = val_18 + val_20;
            byte[] val_11 = new byte[0];
            val_21 = val_11;
            System.Buffer.BlockCopy(src:  val_19, srcOffset:  0, dst:  val_11, dstOffset:  0, count:  val_8.Length);
            System.Buffer.BlockCopy(src:  data, srcOffset:  0, dst:  val_11, dstOffset:  val_8.Length, count:  data.Length);
            if(salt != null)
            {
                    System.Buffer.BlockCopy(src:  salt, srcOffset:  0, dst:  val_11, dstOffset:  data.Length + val_8.Length, count:  salt.Length);
            }
            
            val_22 = val_5.ComputeHash(buffer:  val_11);
            if(count >= 2)
            {
                    do
            {
                val_21 = (count - 1) - 1;
                val_22 = val_5.ComputeHash(buffer:  val_22);
            }
            while(val_21 != 0);
            
            }
            
            val_1.AddRange(collection:  val_22);
            label_10:
            if(val_1.Count < 48)
            {
                goto label_24;
            }
            
            val_5.Clear();
            mem2[0] = new byte[32];
            mem2[0] = new byte[16];
            if(val_1 != null)
            {
                    val_1.CopyTo(index:  0, array:  key, arrayIndex:  0, count:  32);
                val_23 = mem[iv];
                val_23 = iv;
            }
            else
            {
                    val_1.CopyTo(index:  0, array:  key, arrayIndex:  0, count:  32);
                val_23 = mem[iv];
                val_23 = iv;
            }
            
            val_1.CopyTo(index:  32, array:  val_23, arrayIndex:  0, count:  16);
        }
        private static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            var val_14;
            string val_20;
            var val_21;
            var val_22;
            if((plainText == null) || (plainText.Length <= 0))
            {
                goto label_2;
            }
            
            if((((Key == null) || (Key.Length == 0)) || (IV == null)) || (IV.Length == 0))
            {
                goto label_6;
            }
            
            System.Security.Cryptography.RijndaelManaged val_2 = new System.Security.Cryptography.RijndaelManaged();
            new System.IO.MemoryStream() = new System.IO.MemoryStream();
            new System.Security.Cryptography.CryptoStream() = new System.Security.Cryptography.CryptoStream(stream:  new System.IO.MemoryStream(), transform:  val_2, mode:  1);
            new System.IO.StreamWriter() = new System.IO.StreamWriter(stream:  new System.Security.Cryptography.CryptoStream());
            val_14 = 0;
            var val_14 = 0;
            val_14 = val_14 + 1;
            new System.IO.StreamWriter().Dispose();
            if(val_14 != 1)
            {
                    var val_7 = (145 == 145) ? 1 : 0;
                val_7 = ((val_14 >= 0) ? 1 : 0) & val_7;
                val_14 = val_14 - val_7;
            }
            
            var val_9 = 1152921529369201040 + (val_14 << 2);
            mem2[0] = 186;
            if(new System.Security.Cryptography.CryptoStream() == null)
            {
                goto label_58;
            }
            
            label_57:
            var val_15 = 0;
            val_15 = val_15 + 1;
            new System.Security.Cryptography.CryptoStream().Dispose();
            label_58:
            label_60:
            if(new System.IO.MemoryStream() != null)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                new System.IO.MemoryStream().Dispose();
            }
            
            if(val_2 == null)
            {
                goto label_63;
            }
            
            label_62:
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_2.Dispose();
            label_63:
            if(0 == 0)
            {
                    return (System.Byte[])new System.IO.MemoryStream();
            }
            
            return (System.Byte[])new System.IO.MemoryStream();
            label_6:
            val_20 = "Key";
            goto label_34;
            label_2:
            System.ArgumentNullException val_13 = null;
            val_20 = "plainText";
            label_34:
            val_13 = new System.ArgumentNullException(paramName:  val_20);
            goto label_54;
            label_64:
            val_21 = 0;
            val_22 = val_13;
            goto label_56;
            label_54:
            val_21 = 0;
            val_22 = val_13;
            if(val_21 != 1)
            {
                goto label_56;
            }
            
            if(Key != null)
            {
                goto label_57;
            }
            
            goto label_58;
            label_56:
            if(val_21 != 1)
            {
                goto label_59;
            }
            
            goto label_60;
            label_59:
            if( != 1)
            {
                goto label_64;
            }
            
            if(val_13 != null)
            {
                goto label_62;
            }
            
            goto label_63;
        }
        private static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string val_15;
            var val_16;
            var val_17;
            if((cipherText == null) || (cipherText.Length == 0))
            {
                goto label_2;
            }
            
            if((((Key == null) || (Key.Length == 0)) || (IV == null)) || (IV.Length == 0))
            {
                goto label_6;
            }
            
            System.Security.Cryptography.RijndaelManaged val_1 = new System.Security.Cryptography.RijndaelManaged();
            new System.IO.MemoryStream() = new System.IO.MemoryStream(buffer:  cipherText);
            new System.Security.Cryptography.CryptoStream() = new System.Security.Cryptography.CryptoStream(stream:  new System.IO.MemoryStream(), transform:  val_1, mode:  0);
            new System.IO.StreamReader() = new System.IO.StreamReader(stream:  new System.Security.Cryptography.CryptoStream());
            var val_10 = 0;
            val_10 = val_10 + 1;
            new System.IO.StreamReader().Dispose();
            label_55:
            if(new System.Security.Cryptography.CryptoStream() != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                new System.Security.Cryptography.CryptoStream().Dispose();
            }
            
            label_57:
            if(new System.IO.MemoryStream() != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                new System.IO.MemoryStream().Dispose();
            }
            
            if(val_1 == null)
            {
                goto label_60;
            }
            
            label_59:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_1.Dispose();
            label_60:
            if(0 == 0)
            {
                    return (string)new System.IO.StreamReader();
            }
            
            return (string)new System.IO.StreamReader();
            label_6:
            val_15 = "Key";
            goto label_32;
            label_2:
            System.ArgumentNullException val_9 = null;
            val_15 = "cipherText";
            label_32:
            val_9 = new System.ArgumentNullException(paramName:  val_15);
            goto label_33;
            label_61:
            val_16 = 0;
            val_17 = val_9;
            goto label_54;
            label_33:
            val_16 = 0;
            val_17 = val_9;
            if(val_16 != 1)
            {
                goto label_54;
            }
            
            goto label_55;
            label_54:
            if( != 1)
            {
                goto label_56;
            }
            
            goto label_57;
            label_56:
            if( != 1)
            {
                goto label_61;
            }
            
            if(val_9 != null)
            {
                goto label_59;
            }
            
            goto label_60;
        }
    
    }

}
