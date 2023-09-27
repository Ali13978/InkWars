using UnityEngine;
public static class DeviceBasedData
{
    // Properties
    public static bool showBasicTutorial { get; set; }
    public static bool showQuickPlay { get; set; }
    public static bool playerAtLeftForQuickPlay { get; set; }
    public static bool enableMusic { get; set; }
    public static bool enableSFX { get; set; }
    public static string lastUser { get; set; }
    public static string lastAIUser { get; set; }
    
    // Methods
    public static bool get_showBasicTutorial()
    {
        return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  "showBasicTutorial", defaultValue:  1)) == 1) ? 1 : 0;
    }
    public static void set_showBasicTutorial(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  "showBasicTutorial", value:  value);
        UnityEngine.PlayerPrefs.Save();
    }
    public static bool get_showQuickPlay()
    {
        return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  "showQuickPlay", defaultValue:  1)) == 1) ? 1 : 0;
    }
    public static void set_showQuickPlay(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  "showQuickPlay", value:  value);
        UnityEngine.PlayerPrefs.Save();
    }
    public static bool get_playerAtLeftForQuickPlay()
    {
        return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  "playerAtLeftForQuickPlay", defaultValue:  1)) == 1) ? 1 : 0;
    }
    public static void set_playerAtLeftForQuickPlay(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  "playerAtLeftForQuickPlay", value:  value);
        UnityEngine.PlayerPrefs.Save();
    }
    public static bool get_enableMusic()
    {
        return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  "enableMusic", defaultValue:  1)) == 1) ? 1 : 0;
    }
    public static void set_enableMusic(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  "enableMusic", value:  value);
        UnityEngine.PlayerPrefs.Save();
    }
    public static bool get_enableSFX()
    {
        return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  "enableSFX", defaultValue:  1)) == 1) ? 1 : 0;
    }
    public static void set_enableSFX(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  "enableSFX", value:  value);
        UnityEngine.PlayerPrefs.Save();
    }
    public static bool GetBoolFlag(string key, bool defaultFlag = False)
    {
        return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  key, defaultValue:  defaultFlag)) == 1) ? 1 : 0;
    }
    public static void SetBoolFlag(string key, bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  key, value:  value);
    }
    public static string get_lastUser()
    {
        return CMS.Security.Cryptography.AES.Decrypt(inputBase64:  UnityEngine.PlayerPrefs.GetString(key:  "lastUser", defaultValue:  ""), passphrase:  "CMS.Device.uniqueDeviceId");
    }
    public static void set_lastUser(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  "lastUser", value:  CMS.Security.Cryptography.AES.Encrypt(input:  value, passphrase:  "CMS.Device.uniqueDeviceId"));
        UnityEngine.PlayerPrefs.Save();
    }
    public static string get_lastAIUser()
    {
        return CMS.Security.Cryptography.AES.Decrypt(inputBase64:  UnityEngine.PlayerPrefs.GetString(key:  "lastAIUser", defaultValue:  ""), passphrase:  "CMS.Device.uniqueDeviceId");
    }
    public static void set_lastAIUser(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  "lastUser", value:  CMS.Security.Cryptography.AES.Encrypt(input:  value, passphrase:  "CMS.Device.uniqueDeviceId"));
        UnityEngine.PlayerPrefs.Save();
    }

}
