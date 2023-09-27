using UnityEngine;

namespace CMS.IO
{
    public static class AssetsFile
    {
        // Methods
        public static string GetFullPath(string path, CMS.IO.PathType type)
        {
            string val_5;
            if(type == 2)
            {
                goto label_1;
            }
            
            if(type == 1)
            {
                goto label_2;
            }
            
            if(type != 0)
            {
                    return (string)path;
            }
            
            string val_1 = UnityEngine.Application.persistentDataPath;
            goto label_4;
            label_1:
            string val_2 = UnityEngine.Application.streamingAssetsPath;
            label_4:
            val_5 = "/";
            return UnityEngine.Application.dataPath + val_5 + path;
            label_2:
            val_5 = "/Resources/";
            return UnityEngine.Application.dataPath + val_5 + path;
        }
        public static bool IsExist(string path, CMS.IO.PathType type)
        {
            return System.IO.File.Exists(path:  CMS.IO.AssetsFile.GetFullPath(path:  path, type:  type));
        }
        public static bool Save(string data, string path, CMS.IO.PathType type)
        {
            string val_8;
            string val_9;
            val_8 = CMS.IO.AssetsFile.GetFullPath(path:  path, type:  type);
            if(type == 1)
            {
                    val_8 = val_8 + ".txt";
            }
            
            string val_3 = System.IO.Path.GetDirectoryName(path:  val_8);
            val_9 = val_3;
            if((System.IO.Directory.Exists(path:  val_3)) != true)
            {
                    System.IO.DirectoryInfo val_5 = System.IO.Directory.CreateDirectory(path:  val_9);
            }
            
            if((System.IO.File.Exists(path:  val_8)) != true)
            {
                    val_9 = System.IO.File.Create(path:  val_8);
                val_9.Close();
            }
            
            System.IO.File.WriteAllText(path:  val_8, contents:  data);
            return true;
        }
        public static string Load(string path, CMS.IO.PathType type)
        {
            if(type != 1)
            {
                    return System.IO.File.ReadAllText(path:  CMS.IO.AssetsFile.GetFullPath(path:  path, type:  type));
            }
            
            UnityEngine.TextAsset val_1 = UnityEngine.Resources.Load<UnityEngine.TextAsset>(path:  path);
            if(val_1 != null)
            {
                    return val_1.text;
            }
            
            return val_1.text;
        }
        public static System.Exception SaveJson(object obj, string path, CMS.IO.PathType type)
        {
            bool val_2 = CMS.IO.AssetsFile.Save(data:  UnityEngine.JsonUtility.ToJson(obj:  obj), path:  path, type:  type);
            return 0;
        }
        public static T LoadJson<T>(string path, CMS.IO.PathType type)
        {
            return (object)CMS.IO.AssetsFile.Load(path:  path, type:  type);
        }
        public static System.Exception Delete(string path, CMS.IO.PathType type)
        {
            System.IO.File.Delete(path:  CMS.IO.AssetsFile.GetFullPath(path:  path, type:  type));
            return 0;
        }
    
    }

}
