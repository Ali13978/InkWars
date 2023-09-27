using UnityEngine;

namespace CMS.Security.Cryptography
{
    public static class RSA
    {
        // Methods
        public static void GenerateKeyPair(ref string publicKey, ref string privateKey)
        {
            System.Security.Cryptography.RSACryptoServiceProvider val_1 = new System.Security.Cryptography.RSACryptoServiceProvider();
            publicKey = val_1.ToXmlString(includePrivateParameters:  false);
            privateKey = val_1.ToXmlString(includePrivateParameters:  true);
        }
        public static string Encrypt(string content, string publickey)
        {
            System.Security.Cryptography.RSACryptoServiceProvider val_1 = new System.Security.Cryptography.RSACryptoServiceProvider();
            val_1.FromXmlString(xmlString:  publickey);
            return System.Convert.ToBase64String(inArray:  val_1.Encrypt(rgb:  System.Text.Encoding.UTF8, fOAEP:  false));
        }
        public static string Decrypt(string content, string privatekey)
        {
            System.Security.Cryptography.RSACryptoServiceProvider val_1 = new System.Security.Cryptography.RSACryptoServiceProvider();
            val_1.FromXmlString(xmlString:  privatekey);
            System.Byte[] val_3 = val_1.Decrypt(rgb:  System.Convert.FromBase64String(s:  content), fOAEP:  false);
            if(System.Text.Encoding.UTF8 == null)
            {
                
            }
        
        }
        public static byte[] HashAndSignBytes(byte[] DataToSign, System.Security.Cryptography.RSAParameters Key)
        {
            new System.Security.Cryptography.RSACryptoServiceProvider() = new System.Security.Cryptography.RSACryptoServiceProvider();
            new System.Security.Cryptography.SHA1CryptoServiceProvider() = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            return (System.Byte[])new System.Security.Cryptography.RSACryptoServiceProvider().SignData(buffer:  DataToSign, halg:  new System.Security.Cryptography.SHA1CryptoServiceProvider());
        }
        public static bool VerifySignedHash(byte[] DataToVerify, byte[] SignedData, System.Security.Cryptography.RSAParameters Key)
        {
            new System.Security.Cryptography.RSACryptoServiceProvider() = new System.Security.Cryptography.RSACryptoServiceProvider();
            new System.Security.Cryptography.SHA1CryptoServiceProvider() = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            return (bool)new System.Security.Cryptography.RSACryptoServiceProvider().VerifyData(buffer:  DataToVerify, halg:  new System.Security.Cryptography.SHA1CryptoServiceProvider(), signature:  SignedData);
        }
    
    }

}
