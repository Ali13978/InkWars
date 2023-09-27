using UnityEngine;
public static class GamePath
{
    // Methods
    public static string AssetPathToResourcePath(string assetPath)
    {
        var val_8;
        var val_9;
        val_8 = "Resources/";
        if(("Resources/") == null)
        {
                val_8 = "Resources/";
        }
        
        string val_4 = assetPath.Substring(startIndex:  Length + (assetPath.IndexOf(value:  "Resources/")));
        if(val_4 != null)
        {
                val_9 = val_4.Length;
            return val_4.Substring(startIndex:  0, length:  val_9 - 4);
        }
        
        val_9 = 0.Length;
        return val_4.Substring(startIndex:  0, length:  val_9 - 4);
    }

}
