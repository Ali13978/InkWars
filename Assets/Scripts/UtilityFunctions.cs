using UnityEngine;
public class UtilityFunctions : MonoBehaviour
{
    // Methods
    public static void DeleteAllPlayerPrefs()
    {
        UnityEngine.PlayerPrefs.DeleteAll();
        UnityEngine.Debug.Log(message:  "Deleted All Player Prefs");
    }
    public UtilityFunctions()
    {
    
    }

}
