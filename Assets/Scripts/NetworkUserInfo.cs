using UnityEngine;
[Serializable]
public class NetworkUserInfo
{
    // Fields
    public string userName;
    public int playerPoint;
    public DataStructs.Flag flag;
    public DataStructs.PlayerRank currentCharacterRank;
    public int currentCharacterBP;
    public int avatarID;
    public int titleID;
    public int battleGridID;
    public int switcherID;
    public int musicID;
    public int stageID;
    public int bubbleID;
    public int enhancerID;
    public int win;
    public int lose;
    public int draw;
    public int allTimeHighScore;
    public PlayerBuff buff;
    
    // Methods
    public static NetworkUserInfo FromJSON(string source)
    {
        return UnityEngine.JsonUtility.FromJson<NetworkUserInfo>(json:  source);
    }
    public string ToJSON()
    {
        return UnityEngine.JsonUtility.ToJson(obj:  this);
    }
    public NetworkUserInfo()
    {
        this.buff = new PlayerBuff();
    }

}
