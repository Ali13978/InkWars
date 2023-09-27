using UnityEngine;
[Serializable]
public class NFClientUser.NFResponseRankData : IResponse
{
    // Fields
    public string id;
    public int index;
    public int score;
    public string data;
    private System.Collections.Generic.List<NFClientUser.NFResponseRankData.RoleData> rank_list;
    
    // Methods
    public NFClientUser.NFResponseRankData()
    {
    
    }

}
