using UnityEngine;

namespace CMS.Security.Cryptography
{
    public static class MD5
    {
        // Methods
        public static string Encrypt(string strToEncrypt)
        {
            var val_8;
            string val_9;
            val_8 = 0;
            val_9 = "";
            goto label_3;
            label_9:
            val_9 = val_9 + System.Convert.ToString(value:  new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(buffer:  new System.Text.UTF8Encoding().GetBytes(s:  strToEncrypt))[0], toBase:  16).PadLeft(totalWidth:  2, paddingChar:  '0')(System.Convert.ToString(value:  new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(buffer:  new System.Text.UTF8Encoding().GetBytes(s:  strToEncrypt))[0], toBase:  16).PadLeft(totalWidth:  2, paddingChar:  '0'));
            val_8 = 1;
            label_3:
            if(val_8 < val_4.Length)
            {
                goto label_9;
            }
            
            if(val_9 != null)
            {
                    return val_9.PadLeft(totalWidth:  32, paddingChar:  '0');
            }
            
            return val_9.PadLeft(totalWidth:  32, paddingChar:  '0');
        }
    
    }

}
