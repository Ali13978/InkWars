using UnityEngine;
public class NetworkManager_Custom.PlayerInformation
{
    // Fields
    public string playerName;
    public long wins;
    public int losses;
    public int draws;
    public bool isReady;
    public int shells;
    
    // Methods
    public NetworkManager_Custom.PlayerInformation(string playerName, long wins, int losses, int draws, bool isReady)
    {
        this.playerName = playerName;
        this.wins = wins;
        this.losses = losses;
        this.draws = draws;
        this.isReady = isReady;
    }

}
