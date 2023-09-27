using UnityEngine;
public class NetworkDelayOverlay
{
    // Fields
    private static UnityEngine.GameObject _instance;
    private static bool _isWaiting;
    
    // Properties
    public static bool IsWaiting { get; set; }
    
    // Methods
    public static void StartWaiting(string message = "WAITING FOR OPPONENT")
    {
        NetworkDelayOverlay._isWaiting = true;
        UnityEngine.Object.Destroy(obj:  NetworkDelayOverlay._instance);
        NetworkDelayOverlay._instance = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NetworkDelayOverlay"));
        NetworkDelayOverlay._instance.gameObject.transform.SetAsLastSibling();
        if((NetworkDelayOverlay._instance.GetComponentInChildren<UnityEngine.UI.Text>(includeInactive:  true)) == null)
        {
            
        }
    
    }
    public static void StopWaiting()
    {
        NetworkDelayOverlay._isWaiting = false;
        UnityEngine.Object.Destroy(obj:  NetworkDelayOverlay._instance);
    }
    public static bool get_IsWaiting()
    {
        if(NetworkManager_Custom.IsNetwork == true)
        {
                return (bool)NetworkDelayOverlay._isWaiting;
        }
        
        NetworkDelayOverlay.StopWaiting();
        return (bool)NetworkDelayOverlay._isWaiting;
    }
    public static void set_IsWaiting(bool value)
    {
        NetworkDelayOverlay._isWaiting = value;
    }
    public NetworkDelayOverlay()
    {
    
    }

}
