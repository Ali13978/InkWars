using UnityEngine;
[Serializable]
public class HostData
{
    // Fields
    public string IPAddress;
    public float TimeSinceRefresh;
    public UnityEngine.Networking.Types.NetworkID NetworkID;
    public string PlayerName;
    public int Timer;
    public long Wins;
    public int Draws;
    public int Losses;
    public int Shells;
    public string version;
    
    // Methods
    public HostData()
    {
    
    }

}
