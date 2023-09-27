using UnityEngine;
public class Reporter.Sample
{
    // Fields
    public float time;
    public byte loadedScene;
    public float memory;
    public float fps;
    public string fpsText;
    
    // Methods
    public static float MemSize()
    {
        return 13f;
    }
    public string GetSceneName()
    {
        System.String[] val_2;
        byte val_3;
        var val_4;
        var val_5;
        val_2 = this;
        val_3 = this.loadedScene;
        if(val_3 != 255)
        {
                val_4 = null;
            val_4 = null;
            val_3 = this.loadedScene;
            val_2 = Reporter.scenes;
            System.String[] val_1 = val_2 + ((this.loadedScene) << 3);
            return (string)val_5;
        }
        
        val_5 = "AssetBundleScene";
        return (string)val_5;
    }
    public Reporter.Sample()
    {
    
    }

}
