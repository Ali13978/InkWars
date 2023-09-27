using UnityEngine;
[Serializable]
public class RankingConstraints : ScriptableObject
{
    // Fields
    private DataStructs.PlayerRank m_Rank;
    public UnityEngine.Sprite SpriteDefault;
    public UnityEngine.Sprite SpriteSmall;
    private int m_PointsToRankUp;
    private int m_PointsToRankDown;
    private int m_Shells;
    private int m_Pearls;
    
    // Properties
    public DataStructs.PlayerRank Rank { get; }
    public int PointsToRankUp { get; }
    public int PointsToRankDown { get; }
    public int Shells { get; }
    public int Pearls { get; }
    
    // Methods
    public override string ToString()
    {
        object[] val_1 = new object[5];
        string val_2 = this.m_Rank.ToString();
        this.m_Rank.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(val_2 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_2 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = val_2;
        val_1[1] = this.m_PointsToRankUp;
        val_1[2] = this.m_PointsToRankDown;
        val_1[3] = this.m_Shells;
        val_1[4] = this.m_Pearls;
        return (string)System.String.Format(format:  "Rank: {0}, Points to rank up: {1}, Points to rank down: {2}, Shells: {3}, Pearls: {4}", args:  val_1);
    }
    public DataStructs.PlayerRank get_Rank()
    {
        return (DataStructs.PlayerRank)this.m_Rank;
    }
    public int get_PointsToRankUp()
    {
        return (int)this.m_PointsToRankUp;
    }
    public int get_PointsToRankDown()
    {
        return (int)this.m_PointsToRankDown;
    }
    public int get_Shells()
    {
        return (int)this.m_Shells;
    }
    public int get_Pearls()
    {
        return (int)this.m_Pearls;
    }
    public DataStructs.PlayerRank RankUp()
    {
        if(this.m_Rank >= (System.Linq.Enumerable.Last<DataStructs.PlayerRank>(source:  System.Linq.Enumerable.Cast<DataStructs.PlayerRank>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))))))
        {
                return (DataStructs.PlayerRank)this.m_Rank;
        }
        
        return GenericFunctions.NextEnum<DataStructs.PlayerRank>(src:  this.m_Rank);
    }
    public DataStructs.PlayerRank RankDown()
    {
        if(this.m_Rank <= (System.Linq.Enumerable.First<DataStructs.PlayerRank>(source:  System.Linq.Enumerable.Cast<DataStructs.PlayerRank>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))))))
        {
                return (DataStructs.PlayerRank)this.m_Rank;
        }
        
        return GenericFunctions.PrevEnum<DataStructs.PlayerRank>(src:  this.m_Rank);
    }
    public RankingConstraints()
    {
    
    }

}
