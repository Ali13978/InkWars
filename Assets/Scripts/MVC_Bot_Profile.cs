using UnityEngine;
public class MVC_Bot_Profile : ScriptableObject
{
    // Fields
    public string name;
    public bool IsMultiplayerBot;
    public int MinimumWinsForPlay;
    public DataStructs.Flag Country;
    public int PlayerPoints;
    public int BattlePoints;
    public int Wins;
    public int Losses;
    public int Draws;
    public int highScore;
    public CharacterNameID FavoriteCharacter;
    public bool IsAdventureModeBot;
    public int AdventureModeLevel;
    public bool IsXtremeModeBot;
    public CharacterNameID XtremeModeCharacter;
    public MVC_Bot2_Settings SkillSettings;
    private static System.Collections.Generic.List<MVC_Bot_Profile> _allBots;
    
    // Methods
    public static MVC_Bot2_Settings GetXtremeModeBot(CharacterNameID character)
    {
        var val_8;
        System.Func<MVC_Bot_Profile, System.Boolean> val_10;
        System.Collections.Generic.IEnumerable<T> val_11;
        MVC_Bot2_Settings val_12;
        val_8 = null;
        val_8 = null;
        val_10 = MVC_Bot_Profile.<>c.<>9__17_0;
        if(val_10 == null)
        {
                System.Func<MVC_Bot_Profile, System.Boolean> val_2 = null;
            val_10 = val_2;
            val_2 = new System.Func<MVC_Bot_Profile, System.Boolean>(object:  MVC_Bot_Profile.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MVC_Bot_Profile.<>c::<GetXtremeModeBot>b__17_0(MVC_Bot_Profile p));
            MVC_Bot_Profile.<>c.<>9__17_0 = val_10;
        }
        
        val_11 = System.Linq.Enumerable.Where<MVC_Bot_Profile>(source:  UnityEngine.Resources.LoadAll<MVC_Bot_Profile>(path:  "GameData/Bot/Xtreme"), predicate:  val_2);
        System.Collections.Generic.List<MVC_Bot_Profile> val_4 = new System.Collections.Generic.List<MVC_Bot_Profile>(collection:  val_11);
        List.Enumerator<T> val_5 = val_4.GetEnumerator();
        label_9:
        if(((-2089091784) & 1) == 0)
        {
            goto label_7;
        }
        
        val_11 = 0.InitialType;
        if((-2089091784) != character)
        {
            goto label_9;
        }
        
        0.Add(driver:  public System.Void List.Enumerator<MVC_Bot_Profile>::Dispose(), rectTransform:  public System.Void System.Collections.Generic.List<MVC_Bot_Profile>::.ctor(System.Collections.Generic.IEnumerable<T> collection), drivenProperties:  public System.Void System.Func<MVC_Bot_Profile, System.Boolean>::.ctor(object object, IntPtr method));
        return val_12;
        label_7:
        0.Add(driver:  public System.Void List.Enumerator<MVC_Bot_Profile>::Dispose(), rectTransform:  public System.Void System.Collections.Generic.List<MVC_Bot_Profile>::.ctor(System.Collections.Generic.IEnumerable<T> collection), drivenProperties:  public System.Void System.Func<MVC_Bot_Profile, System.Boolean>::.ctor(object object, IntPtr method));
        MVC_Bot_Profile val_7 = val_4.Item[0];
        val_12 = val_7.SkillSettings;
        return val_12;
    }
    public static MVC_Bot2_Settings GetAdventureModeBot(int level)
    {
        var val_8;
        System.Func<MVC_Bot_Profile, System.Boolean> val_10;
        System.Collections.Generic.IEnumerable<T> val_11;
        MVC_Bot2_Settings val_12;
        val_8 = null;
        val_8 = null;
        val_10 = MVC_Bot_Profile.<>c.<>9__18_0;
        if(val_10 == null)
        {
                System.Func<MVC_Bot_Profile, System.Boolean> val_2 = null;
            val_10 = val_2;
            val_2 = new System.Func<MVC_Bot_Profile, System.Boolean>(object:  MVC_Bot_Profile.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MVC_Bot_Profile.<>c::<GetAdventureModeBot>b__18_0(MVC_Bot_Profile p));
            MVC_Bot_Profile.<>c.<>9__18_0 = val_10;
        }
        
        val_11 = System.Linq.Enumerable.Where<MVC_Bot_Profile>(source:  UnityEngine.Resources.LoadAll<MVC_Bot_Profile>(path:  "GameData/Bot/Adventure"), predicate:  val_2);
        System.Collections.Generic.List<MVC_Bot_Profile> val_4 = new System.Collections.Generic.List<MVC_Bot_Profile>(collection:  val_11);
        List.Enumerator<T> val_5 = val_4.GetEnumerator();
        label_9:
        if(((-2088851672) & 1) == 0)
        {
            goto label_7;
        }
        
        val_11 = 0.InitialType;
        if((-2088851672) != level)
        {
            goto label_9;
        }
        
        0.Add(driver:  public System.Void List.Enumerator<MVC_Bot_Profile>::Dispose(), rectTransform:  public System.Void System.Collections.Generic.List<MVC_Bot_Profile>::.ctor(System.Collections.Generic.IEnumerable<T> collection), drivenProperties:  public System.Void System.Func<MVC_Bot_Profile, System.Boolean>::.ctor(object object, IntPtr method));
        return val_12;
        label_7:
        0.Add(driver:  public System.Void List.Enumerator<MVC_Bot_Profile>::Dispose(), rectTransform:  public System.Void System.Collections.Generic.List<MVC_Bot_Profile>::.ctor(System.Collections.Generic.IEnumerable<T> collection), drivenProperties:  public System.Void System.Func<MVC_Bot_Profile, System.Boolean>::.ctor(object object, IntPtr method));
        MVC_Bot_Profile val_7 = val_4.Item[0];
        val_12 = val_7.SkillSettings;
        return val_12;
    }
    public static System.Collections.Generic.List<MVC_Bot_Profile> GetBotQueue(int wins)
    {
        var val_10;
        MVC_Bot_Profile.<>c__DisplayClass19_0 val_25;
        var val_26;
        System.Func<MVC_Bot_Profile, System.Boolean> val_28;
        System.Collections.Generic.List<MVC_Bot_Profile> val_29;
        UnityEngine.Object val_30;
        MVC_Bot_Profile.<>c__DisplayClass19_0 val_1 = null;
        val_25 = val_1;
        val_1 = new MVC_Bot_Profile.<>c__DisplayClass19_0();
        .wins = wins;
        if(MVC_Bot_Profile._allBots == null)
        {
                val_26 = null;
            val_26 = null;
            val_28 = MVC_Bot_Profile.<>c.<>9__19_0;
            if(val_28 == null)
        {
                System.Func<MVC_Bot_Profile, System.Boolean> val_3 = null;
            val_28 = val_3;
            val_3 = new System.Func<MVC_Bot_Profile, System.Boolean>(object:  MVC_Bot_Profile.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MVC_Bot_Profile.<>c::<GetBotQueue>b__19_0(MVC_Bot_Profile p));
            MVC_Bot_Profile.<>c.<>9__19_0 = val_28;
        }
        
            System.Collections.Generic.List<MVC_Bot_Profile> val_5 = new System.Collections.Generic.List<MVC_Bot_Profile>(collection:  System.Linq.Enumerable.Where<MVC_Bot_Profile>(source:  UnityEngine.Resources.LoadAll<MVC_Bot_Profile>(path:  "GameData/Bot"), predicate:  val_3));
            MVC_Bot_Profile._allBots = val_5;
        }
        
        System.Collections.Generic.List<MVC_Bot_Profile> val_6 = null;
        val_29 = val_6;
        val_6 = new System.Collections.Generic.List<MVC_Bot_Profile>();
        List.Enumerator<T> val_8 = MVC_Bot_Profile.GetBotNames().GetEnumerator();
        label_15:
        if(((-2088574752) & 1) == 0)
        {
            goto label_9;
        }
        
        new MVC_Bot_Profile.<>c__DisplayClass19_1() = new System.Object();
        .CS$<>8__locals1 = val_25;
        .name = val_10.InitialType;
        System.Func<MVC_Bot_Profile, System.Boolean> val_13 = new System.Func<MVC_Bot_Profile, System.Boolean>(object:  new MVC_Bot_Profile.<>c__DisplayClass19_1(), method:  System.Boolean MVC_Bot_Profile.<>c__DisplayClass19_1::<GetBotQueue>b__1(MVC_Bot_Profile p));
        MVC_Bot_Profile val_14 = System.Linq.Enumerable.FirstOrDefault<MVC_Bot_Profile>(source:  val_5, predicate:  null);
        if(val_14 == 0)
        {
            goto label_15;
        }
        
        val_6.Add(item:  val_14);
        goto label_15;
        label_9:
        val_10.Add(driver:  public System.Void List.Enumerator<System.String>::Dispose(), rectTransform:  public System.Void System.Collections.Generic.List<MVC_Bot_Profile>::.ctor(System.Collections.Generic.IEnumerable<T> collection), drivenProperties:  public System.Void System.Func<MVC_Bot_Profile, System.Boolean>::.ctor(object object, IntPtr method));
        val_30 = 1152921528288043648;
        if(val_6.Count > 1)
        {
                return val_29;
        }
        
        if(val_6.Count == 1)
        {
                val_30 = val_6.Item[0];
        }
        else
        {
                val_30 = 0;
        }
        
        val_25 = System.Linq.Enumerable.Where<MVC_Bot_Profile>(source:  val_5, predicate:  new System.Func<MVC_Bot_Profile, System.Boolean>(object:  val_1, method:  System.Boolean MVC_Bot_Profile.<>c__DisplayClass19_0::<GetBotQueue>b__2(MVC_Bot_Profile p)));
        System.Collections.Generic.List<MVC_Bot_Profile> val_21 = null;
        val_29 = val_21;
        val_21 = new System.Collections.Generic.List<MVC_Bot_Profile>(collection:  val_25);
        MVC_Bot_Profile.ShuffleBots(result:  val_21);
        if(val_30 == 0)
        {
                return val_29;
        }
        
        if(val_29 != null)
        {
                bool val_23 = val_21.Remove(item:  val_30);
        }
        else
        {
                bool val_24 = val_21.Remove(item:  val_30);
        }
        
        val_21.Insert(index:  0, item:  val_30);
        return val_29;
    }
    private static void ShuffleBots(System.Collections.Generic.List<MVC_Bot_Profile> result)
    {
        MVC_Bot_Profile val_8;
        int val_8 = result.Count;
        if(val_8 < 2)
        {
                return;
        }
        
        do
        {
            val_8 = val_8 - 1;
            int val_2 = UnityEngine.Random.Range(min:  0, max:  val_8);
            if(result != null)
        {
                val_8 = result.Item[val_2];
            result.set_Item(index:  val_2, value:  result.Item[val_8]);
        }
        else
        {
                val_8 = result.Item[val_2];
            result.set_Item(index:  val_2, value:  result.Item[val_8]);
        }
        
            result.set_Item(index:  val_8, value:  val_8);
        }
        while((val_8 + 1) > 2);
    
    }
    private static System.Collections.Generic.List<string> GetBotNames()
    {
        System.Collections.Generic.List<System.String> val_4;
        if((UnityEngine.JsonUtility.FromJson<BotNameStore>(json:  UnityEngine.PlayerPrefs.GetString(key:  "BotNames"))) != null)
        {
                val_4 = val_2.BotNames;
            return (System.Collections.Generic.List<System.String>)val_4;
        }
        
        System.Collections.Generic.List<System.String> val_3 = null;
        val_4 = val_3;
        val_3 = new System.Collections.Generic.List<System.String>();
        return (System.Collections.Generic.List<System.String>)val_4;
    }
    private static void SetBotNames(System.Collections.Generic.List<MVC_Bot_Profile> Bots)
    {
        List.Enumerator<T> val_2 = Bots.GetEnumerator();
        label_6:
        if(((-2088048152) & 1) == 0)
        {
            goto label_2;
        }
        
        (MVC_Bot_Profile.BotNameStore)[1152921528288650784].BotNames.Add(item:  0.InitialType);
        goto label_6;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<MVC_Bot_Profile>::Dispose(), rectTransform:  null, drivenProperties:  null);
        UnityEngine.PlayerPrefs.SetString(key:  "BotNames", value:  UnityEngine.JsonUtility.ToJson(obj:  new MVC_Bot_Profile.BotNameStore()));
        UnityEngine.PlayerPrefs.Save();
    }
    internal NetworkUserInfo ToSharedPlayerData()
    {
        int val_12;
        NetworkUserInfo val_1 = new NetworkUserInfo();
        if(val_1 != null)
        {
                .flag = this.Country;
            .playerPoint = this.PlayerPoints;
            .userName = this.name;
            .win = this.Wins;
            .draw = this.Draws;
            val_12 = this.Losses;
        }
        else
        {
                .flag = this.Country;
            mem[24] = this.PlayerPoints;
            mem[16] = this.name;
            mem[72] = this.Wins;
            mem[80] = this.Draws;
            val_12 = this.Losses;
        }
        
        .lose = val_12;
        .avatarID = AvatarCollection.GetRandom().GetIntId();
        .titleID = TitleCollection.GetRandom().GetIntId();
        .currentCharacterBP = this.BattlePoints;
        .currentCharacterRank = RankingCollection.GetRankByBP(bp:  this.BattlePoints);
        .allTimeHighScore = this.highScore;
        .enhancerID = this.SkillSettings.PickEnhancer(forCharacter:  this.FavoriteCharacter);
        .battleGridID = BattleGridCollection.instance.GetRandomBattleGridID();
        .switcherID = SwitcherCollection.instance.GetRandomSwitcherID();
        return val_1;
    }
    public static MVC_Bot_Profile GetNextBot(int wins)
    {
        var val_4;
        System.Collections.Generic.List<MVC_Bot_Profile> val_1 = MVC_Bot_Profile.GetBotQueue(wins:  wins);
        if(val_1 != null)
        {
                val_4 = val_1.Item[0];
        }
        else
        {
                val_4 = 0.Item[0];
        }
        
        0.RemoveAt(index:  0);
        MVC_Bot_Profile.SetBotNames(Bots:  val_1);
        return (MVC_Bot_Profile)val_4;
    }
    public CharacterNameID SelectCharacter()
    {
        CharacterNameID val_14;
        var val_15;
        var val_18;
        val_14 = this.FavoriteCharacter;
        if(UnityEngine.Random.value >= 0)
        {
                return (CharacterNameID)val_14;
        }
        
        System.Collections.Generic.List<CharacterNameID> val_2 = new System.Collections.Generic.List<CharacterNameID>();
        System.Collections.IEnumerator val_5 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_25:
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_15 = 0;
        if(val_5.MoveNext() == false)
        {
            goto label_12;
        }
        
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_15 = 1;
        val_5.Current.Add(driver:  public System.Object System.Collections.IEnumerator::get_Current(), rectTransform:  null, drivenProperties:  null);
        if((null == 999999) || ((CharacterHelper.IsHidden(cid:  1152921504628039680)) == true))
        {
            goto label_25;
        }
        
        val_2.Add(item:  1152921504628039680);
        goto label_25;
        label_12:
        val_18 = 0;
        if(val_5 != null)
        {
                var val_18 = 0;
            val_18 = val_18 + 1;
            val_5.Dispose();
        }
        
        val_14 = val_2.Item[UnityEngine.Random.Range(min:  0, max:  val_2.Count)];
        return (CharacterNameID)val_14;
    }
    public MVC_Bot_Profile()
    {
        this.AdventureModeLevel = 1;
    }

}
