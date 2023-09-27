using UnityEngine;
public static class ConsoleProDebug
{
    // Methods
    public static void Clear()
    {
    
    }
    public static void LogToFilter(string inLog, string inFilterName)
    {
        UnityEngine.Debug.Log(message:  inLog + "\nCPAPI:{\"cmd\":\"Filter\" \"name\":\""("\nCPAPI:{\"cmd\":\"Filter\" \"name\":\"") + inFilterName + "\"}");
    }
    public static void Watch(string inName, string inValue)
    {
        string[] val_1 = new string[6];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(inName != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(inName == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = inName;
        val_1[1] = " : ";
        val_1[2] = inValue;
        val_1[3] = "\nCPAPI:{\"cmd\":\"Watch\" \"name\":\"";
        val_1[4] = inName;
        val_1[5] = "\"}";
        UnityEngine.Debug.Log(message:  +val_1);
    }
    public static void Search(string inText)
    {
        UnityEngine.Debug.Log(message:  "\nCPAPI:{\"cmd\":\"Search\" \"text\":\""("\nCPAPI:{\"cmd\":\"Search\" \"text\":\"") + inText + "\"}");
    }

}
