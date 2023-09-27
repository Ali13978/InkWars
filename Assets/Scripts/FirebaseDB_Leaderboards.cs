using UnityEngine;
public static class FirebaseDB_Leaderboards
{
    // Fields
    private static int active_workers_count;
    private static bool retrieval_lock;
    public const int ITEM_PRE_PAGE = 100;
    private const string ALL_PATH = "ALL";
    private const string LEADERBOARD_ROOT_PATH = "Leaderboards";
    private const string NAME_PATH = "UserName";
    private const string SCORE_PATH = "Score";
    private const string CHARACTER_PATH = "Character";
    private const string COUNTRY_PATH = "Country";
    private const string RANK_PATH = "Rank";
    
    // Methods
    public static void GetLeaderboardFromServer(DataStructs.LeaderboardType type, int maxScore, System.Action<System.Collections.Generic.List<DataStructs.LeaderBoardItemData>> onDateFetched)
    {
        CharacterNameID val_10;
        var val_11;
        var val_12;
        System.Collections.Generic.List<DataStructs.LeaderBoardItemData> val_1 = new System.Collections.Generic.List<DataStructs.LeaderBoardItemData>();
        int val_13 = 0;
        var val_2 = (0 == 0) ? 0 : 33;
        do
        {
            val_10 = maxScore;
            if(maxScore == 999999)
        {
                do
        {
            val_10 = 0;
        }
        while((CharacterHelper.IsHidden(cid:  val_10)) == true);
        
        }
        
            DataStructs.LeaderBoardItemData val_4 = new DataStructs.LeaderBoardItemData();
            var val_5 = 30000 + (val_13 * 299);
            if(val_4 != null)
        {
                var val_11 = val_2;
            val_11 = val_5 - val_11;
            .score = (long)val_11;
        }
        else
        {
                var val_12 = val_2;
            val_12 = val_5 - val_12;
            .score = (long)val_12;
        }
        
            val_13 = val_13 + 1;
            .leaderboardPlacing = val_13;
            string val_7 = "Ink Wars Player " + val_13.ToString();
            if(val_4 != null)
        {
                .username = val_7;
        }
        else
        {
                mem[24] = val_7;
        }
        
            .character = val_10;
            if(==0)
        {
                val_11 = 1;
            int val_8 = UnityEngine.Random.Range(min:  1, max:  195);
        }
        else
        {
                val_12 = null;
            val_12 = null;
        }
        
            .flag = DataStructs.UserDataDictionary.Settings.UserFlag;
            .rank = RankingCollection.GetRankByBP(bp:  (DataStructs.LeaderBoardItemData)[1152921528250270432].score);
            val_1.Add(item:  val_4);
        }
        while(val_13 != 300);
        
        ???.Invoke(obj:  val_1);
    }
    public static System.Threading.Tasks.Task<Tuple_Workaround.TaskResult<System.Collections.Generic.List<DataStructs.LeaderBoardItemData>>> GetLeaderboardFromServer(DataStructs.LeaderboardType type, int maxScore)
    {
        System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> val_1 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Tuple_Workaround.TaskResult<System.Collections.Generic.List<DataStructs.LeaderBoardItemData>>>.Create();
        return (System.Threading.Tasks.Task<Tuple_Workaround.TaskResult<System.Collections.Generic.List<DataStructs.LeaderBoardItemData>>>);
    }
    public static void SubmitScore(DataStructs.LeaderboardScoreType scoreType, CharacterNameID character, int score, System.Action<bool, string> onFinish)
    {
        var val_26;
        UnityEngine.DrivenTransformProperties val_27;
        var val_28;
        UnityEngine.RectTransform val_29;
        var val_30;
        var val_31;
        val_26 = null;
        val_26 = null;
        DataStructs.PlayerRegion val_1 = DataStructs.UserDataDictionary.Settings.Region;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        null.Add(key:  "Score", value:  score);
        string val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  DataStructs.UserDataDictionary.Settings.UserName);
        null.Add(key:  "UserName", value:  val_4);
        DataStructs.Flag val_5 = DataStructs.UserDataDictionary.Settings.UserFlag;
        string val_6 = val_5.ToString();
        val_5.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_4, drivenProperties:  public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value));
        null.Add(key:  "Country", value:  val_6);
        character.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_6, drivenProperties:  public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value));
        null.Add(key:  "Character", value:  character.ToString());
        DataStructs.PlayerRank val_9 = DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  null).BPRank;
        val_9.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value));
        val_27 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
        null.Add(key:  "Rank", value:  val_9.ToString());
        System.Collections.Generic.Dictionary<System.String, System.Object> val_11 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(DataStructs.UserDataDictionary.Stats.AllTimeBestCharacter == null)
        {
            goto label_25;
        }
        
        val_28 = null;
        val_28 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_13 = DataStructs.UserDataDictionary.Stats.AllTimeHighBP;
        val_29 = 0;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_13.currentCryptoKey, hiddenValue = val_13.hiddenValue, fakeValue = val_13.fakeValue, inited = val_13.inited})) < score)
        {
            goto label_25;
        }
        
        val_30 = null;
        val_30 = null;
        if(DataStructs.UserDataDictionary.Stats.AllTimeBestCharacter != 999999)
        {
            goto label_29;
        }
        
        label_25:
        val_31 = null;
        val_31 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_16 = DataStructs.UserDataDictionary.Stats.AllTimeHighBP;
        UnityEngine.Debug.Log(message:  "Highscore or same character.." + val_16.currentCryptoKey.ToString() + " < "(" < ") + score.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_20 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  score);
        val_27 = 0;
        DataStructs.UserDataDictionary.Stats.AllTimeHighBP = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_20.currentCryptoKey, hiddenValue = val_20.hiddenValue, fakeValue = val_20.fakeValue, inited = val_20.inited};
        val_29 = 0;
        DataStructs.UserDataDictionary.Stats.AllTimeBestCharacter = null;
        label_29:
        string[] val_21 = new string[6];
        if(("Attempting save score...: ") == null)
        {
                val_29 = 0;
        }
        
        if(val_21.Length == 0)
        {
                val_29 = 0;
        }
        
        val_21[0] = "Attempting save score...: ";
        string val_22 = val_1.ToString();
        val_1.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_29, drivenProperties:  val_27);
        if((val_22 != null) && (val_22 == null))
        {
                val_29 = 0;
        }
        
        if(val_21.Length <= 1)
        {
                val_29 = 0;
        }
        
        val_21[1] = val_22;
        if(" " == null)
        {
                val_29 = 0;
        }
        
        if(val_21.Length <= 2)
        {
                val_29 = 0;
        }
        
        val_21[2] = " ";
        string val_23 = score.ToString();
        if((val_23 != null) && (val_23 == null))
        {
                val_29 = 0;
        }
        
        if(val_21.Length <= 3)
        {
                val_29 = 0;
        }
        
        val_21[3] = val_23;
        if(" " == null)
        {
                val_29 = 0;
        }
        
        if(val_21.Length <= 4)
        {
                val_29 = 0;
        }
        
        val_21[4] = " ";
        null.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_29, drivenProperties:  val_27);
        val_21[5] = null.ToString();
        UnityEngine.Debug.Log(message:  +val_21);
    }
    private static void HandleSaveResult(System.Threading.Tasks.Task task, System.Action<bool, string> onFinish)
    {
        var val_12;
        var val_15;
        string val_16;
        var val_17;
        var val_18;
        if((task.IsFaulted == false) || (task.Exception == null))
        {
            goto label_4;
        }
        
        val_12 = task.Exception.Flatten().InnerExceptions.GetEnumerator();
        label_21:
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(val_12.MoveNext() == false)
        {
            goto label_14;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        string val_11 = "" + val_12.Current + "\r\n";
        goto label_21;
        label_4:
        if(onFinish == null)
        {
                return;
        }
        
        if(task.IsCompleted == false)
        {
                return;
        }
        
        val_15 = 1;
        val_16 = "Achievements recognized by bubble kingdom";
        val_17 = public System.Void System.Action<System.Boolean, System.String>::Invoke(System.Boolean arg1, System.String arg2);
        goto label_25;
        label_14:
        val_18 = 0;
        if(val_12 == null)
        {
            
        }
        else
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_12.Dispose();
        }
        
        UnityEngine.Debug.Log(message:  "");
        if(onFinish == null)
        {
                return;
        }
        
        val_15 = 0;
        val_16 = "";
        val_17 = public System.Void System.Action<System.Boolean, System.String>::Invoke(System.Boolean arg1, System.String arg2);
        label_25:
        onFinish.Invoke(arg1:  false, arg2:  val_16);
    }
    private static FirebaseDB_Leaderboards()
    {
    
    }

}
