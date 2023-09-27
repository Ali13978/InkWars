using UnityEngine;
public class JsonHelper
{
    // Methods
    public static string ArrayToObject(string arrayString)
    {
        if((arrayString.StartsWith(value:  "[")) == false)
        {
                return (string)arrayString;
        }
        
        return "{\"items\":"("{\"items\":") + arrayString + "}";
    }
    public JsonHelper()
    {
    
    }

}
