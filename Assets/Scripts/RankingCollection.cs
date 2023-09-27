using UnityEngine;
public class RankingCollection : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<RankingConstraints> rankings;
    public System.Collections.Generic.List<RankingCollection.ClanRaningBG> clanBgs;
    private static RankingCollection _inst;
    
    // Properties
    private static RankingCollection instance { get; }
    
    // Methods
    private static RankingCollection get_instance()
    {
        var val_3;
        RankingCollection val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = RankingCollection._inst;
        if(0 == val_4)
        {
                val_5 = null;
            val_4 = UnityEngine.Resources.Load<RankingCollection>(path:  "NetworkDataCollection/RankingCollection");
            val_5 = null;
            RankingCollection._inst = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (RankingCollection)RankingCollection._inst;
    }
    public static RankingConstraints Get(DataStructs.PlayerRank rank)
    {
        object val_8;
        RankingCollection.<>c__DisplayClass6_0 val_1 = new RankingCollection.<>c__DisplayClass6_0();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        val_8 = val_1;
        .rank = rank;
        if(rank != 0)
        {
            goto label_4;
        }
        
        goto label_3;
        label_1:
        val_8 = 16;
        mem[16] = rank;
        if(mem[16] != 0)
        {
            goto label_4;
        }
        
        label_3:
        UnityEngine.Debug.LogWarning(message:  "Try to get rank data from NARank, return Rank D instead");
        mem[16] = 1;
        label_4:
        RankingCollection val_2 = RankingCollection.instance;
        RankingConstraints val_4 = val_2.rankings.Find(match:  new System.Predicate<RankingConstraints>(object:  val_1, method:  System.Boolean RankingCollection.<>c__DisplayClass6_0::<Get>b__0(RankingConstraints x)));
        if(0 != val_4)
        {
                return val_4;
        }
        
        mem[16].Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  public System.Void System.Predicate<RankingConstraints>::.ctor(object object, IntPtr method));
        mem[16] = null;
        val_8 = "Get Rank fail: No Ranking constraints found for rank "("Get Rank fail: No Ranking constraints found for rank ") + mem[16].ToString();
        UnityEngine.Debug.LogError(message:  val_8);
        return val_4;
    }
    public static int BPtoNextRank(int currentBP)
    {
        var val_9;
        if(currentBP > 27999)
        {
            goto label_1;
        }
        
        .nextRankRank = GenericFunctions.NextEnum<DataStructs.PlayerRank>(src:  RankingCollection.GetRankByBP(bp:  currentBP));
        RankingCollection val_4 = RankingCollection.instance;
        if(0 != (val_4.rankings.Find(match:  new System.Predicate<RankingConstraints>(object:  new RankingCollection.<>c__DisplayClass7_0(), method:  System.Boolean RankingCollection.<>c__DisplayClass7_0::<BPtoNextRank>b__0(RankingConstraints x)))))
        {
            goto label_9;
        }
        
        val_9 = 0;
        return (int)val_9;
        label_1:
        val_9 = 0;
        return (int)val_9;
        label_9:
        val_9 = val_6.m_PointsToRankUp - currentBP;
        return (int)val_9;
    }
    public static DataStructs.PlayerRank GetRankByBP(int bp)
    {
        int val_6;
        object val_7;
        DataStructs.PlayerRank val_8;
        val_6 = bp;
        RankingCollection.<>c__DisplayClass8_0 val_1 = null;
        val_7 = val_1;
        val_1 = new RankingCollection.<>c__DisplayClass8_0();
        if(val_7 != null)
        {
                .bp = val_6;
        }
        else
        {
                mem[16] = val_6;
            val_6 = mem[16];
        }
        
        if(val_6 > 27999)
        {
            goto label_3;
        }
        
        RankingCollection val_2 = RankingCollection.instance;
        val_7 = val_2.rankings.Find(match:  new System.Predicate<RankingConstraints>(object:  val_1, method:  System.Boolean RankingCollection.<>c__DisplayClass8_0::<GetRankByBP>b__0(RankingConstraints x)));
        if(0 != val_7)
        {
            goto label_10;
        }
        
        val_8 = 1;
        return val_8;
        label_3:
        val_8 = 16;
        return val_8;
        label_10:
        val_8 = val_4.m_Rank;
        return val_8;
    }
    public static UnityEngine.Sprite GetRankSprite(DataStructs.PlayerRank rank)
    {
        UnityEngine.Object val_5;
        UnityEngine.Sprite val_6;
        val_5 = RankingCollection.Get(rank:  rank);
        if(0 == val_5)
        {
                rank.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
            val_5 = "GetRankSprite fail: No Ranking constraints found for rank "("GetRankSprite fail: No Ranking constraints found for rank ") + rank.ToString();
            UnityEngine.Debug.LogError(message:  val_5);
            val_6 = 0;
            return val_6;
        }
        
        val_6 = val_1.SpriteDefault;
        return val_6;
    }
    public static UnityEngine.Sprite GetRankSpriteSmall(DataStructs.PlayerRank rank)
    {
        UnityEngine.Object val_6;
        UnityEngine.Sprite val_7;
        val_6 = RankingCollection.Get(rank:  rank);
        if(0 == val_6)
        {
                rank.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
            val_6 = "GetRankSpriteSmall fail: No Ranking constraints found for rank "("GetRankSpriteSmall fail: No Ranking constraints found for rank ") + rank.ToString();
            UnityEngine.Debug.LogError(message:  val_6);
            val_7 = 0;
            return val_7;
        }
        
        if(0 == val_1.SpriteSmall)
        {
                val_7 = val_1.SpriteDefault;
            return val_7;
        }
        
        val_7 = val_1.SpriteSmall;
        return val_7;
    }
    public static UnityEngine.Sprite GetRankBGByClan(CharacterClan clan)
    {
        object val_7;
        System.Collections.Generic.List<ClanRaningBG> val_8;
        UnityEngine.Sprite val_9;
        RankingCollection.<>c__DisplayClass11_0 val_1 = new RankingCollection.<>c__DisplayClass11_0();
        val_7 = val_1;
        .clan = clan;
        RankingCollection val_2 = RankingCollection.instance;
        val_8 = val_2.clanBgs;
        if((val_8.Find(match:  new System.Predicate<ClanRaningBG>(object:  val_1, method:  System.Boolean RankingCollection.<>c__DisplayClass11_0::<GetRankBGByClan>b__0(RankingCollection.ClanRaningBG x)))) != null)
        {
                val_9 = val_4.bgSprite;
            return (UnityEngine.Sprite)val_9;
        }
        
        val_8 = .clan.ToString();
        .clan.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  public ClanRaningBG System.Collections.Generic.List<ClanRaningBG>::Find(System.Predicate<T> match), drivenProperties:  public System.Void System.Predicate<ClanRaningBG>::.ctor(object object, IntPtr method));
        mem[1152921528402640544] = null;
        val_7 = "GetRankBGByClan fail: No clan data found: "("GetRankBGByClan fail: No clan data found: ") + val_8;
        UnityEngine.Debug.LogError(message:  val_7);
        val_9 = 0;
        return (UnityEngine.Sprite)val_9;
    }
    public RankingCollection()
    {
        this.rankings = new System.Collections.Generic.List<RankingConstraints>();
        this.clanBgs = new System.Collections.Generic.List<ClanRaningBG>();
    }
    private static RankingCollection()
    {
    
    }

}
