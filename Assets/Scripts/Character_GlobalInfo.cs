using UnityEngine;
public class Character_GlobalInfo : MonoBehaviour
{
    // Fields
    public static bool modelTest;
    public static bool charactersInitiated;
    private static bool leftInit;
    private static bool rightInit;
    public static bool isCryptoMMOCMode;
    public static bool isPrivateModeNonWager;
    public static bool isOfflineMode;
    public static GameMode gameMode;
    public static int hackBossStarsBeforeWin;
    public static bool hackCreditsStartMusic;
    private static int _stage_CurrentLevel;
    public static bool levelSet;
    public static bool inkProcessFull;
    public static bool firstTimePassPuzzle;
    public static int prevHighScore;
    private static CharacterInfo playerOrLeft;
    private static CharacterInfo opponentOrRight;
    public static int gameDuration;
    
    // Properties
    public static int stage_CurrentLevel { get; set; }
    
    // Methods
    public static int get_stage_CurrentLevel()
    {
        null = null;
        return (int)Character_GlobalInfo._stage_CurrentLevel;
    }
    public static void set_stage_CurrentLevel(int value)
    {
        null = null;
        Character_GlobalInfo.levelSet = true;
        Character_GlobalInfo._stage_CurrentLevel = UnityEngine.Mathf.Clamp(value:  value, min:  1, max:  12);
    }
    public static CharacterInfo GetMainPlayer()
    {
        var val_1;
        CharacterInfo val_0;
        val_1 = null;
        val_1 = null;
        val_0.jsonID = null;
        val_0.ID = Character_GlobalInfo.playerOrLeft;
        return val_0;
    }
    public static CharacterInfo GetOpponentPlayer()
    {
        var val_1;
        CharacterInfo val_0;
        val_1 = null;
        val_1 = null;
        val_0.jsonID = null;
        val_0.ID = Character_GlobalInfo.opponentOrRight;
        return val_0;
    }
    public static CharacterInfo GetLeftPlayer()
    {
        var val_1;
        CharacterInfo val_0;
        val_1 = null;
        val_1 = null;
        val_0.jsonID = null;
        val_0.ID = Character_GlobalInfo.playerOrLeft;
        return val_0;
    }
    public static CharacterInfo GetRightPlayer()
    {
        var val_1;
        CharacterInfo val_0;
        val_1 = null;
        val_1 = null;
        val_0.jsonID = null;
        val_0.ID = Character_GlobalInfo.opponentOrRight;
        return val_0;
    }
    public static void SetMainPlayer(CharacterNameID nameID)
    {
        null = null;
        Character_GlobalInfo.SetCharacterInfo(charInfo: ref  new CharacterInfo(), nameID:  nameID);
        Character_GlobalInfo.leftInit = true;
        Character_GlobalInfo.CheckCharactersInit();
    }
    public static void SetOpponentPlayer(CharacterNameID nameID)
    {
        null = null;
        Character_GlobalInfo.SetCharacterInfo(charInfo: ref  new CharacterInfo(), nameID:  nameID);
        Character_GlobalInfo.rightInit = true;
        Character_GlobalInfo.CheckCharactersInit();
    }
    public static void SetLeftPlayer(CharacterNameID nameID)
    {
        null = null;
        Character_GlobalInfo.SetCharacterInfo(charInfo: ref  new CharacterInfo(), nameID:  nameID);
        Character_GlobalInfo.leftInit = true;
        Character_GlobalInfo.CheckCharactersInit();
    }
    public static void SetRightPlayer(CharacterNameID nameID)
    {
        null = null;
        Character_GlobalInfo.SetCharacterInfo(charInfo: ref  new CharacterInfo(), nameID:  nameID);
        Character_GlobalInfo.rightInit = true;
        Character_GlobalInfo.CheckCharactersInit();
    }
    private static void SetCharacterInfo(ref CharacterInfo charInfo, CharacterNameID nameID)
    {
        charInfo.ID = nameID;
        mem[1152921526031381716] = CharNameIDConverter.GetClan(nameID:  nameID);
        charInfo.clan = CharNameIDConverter.CharNameIdToJSonId(charNameID:  nameID);
        charInfo.jsonID = CharNameIDConverter.StageOrder(charNameID:  nameID);
    }
    private void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
    }
    public static CharacterClan GetClan(CharacterNameID characterId)
    {
        var val_11;
        CharacterClan val_14;
        var val_15;
        var val_16;
        characterId.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        System.Collections.IEnumerator val_4 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_21:
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_11 = 0;
        if(val_4.MoveNext() == false)
        {
            goto label_13;
        }
        
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_11 = 1;
        object val_8 = val_4.Current;
        null.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        if((characterId.ToString().StartsWith(value:  null.ToString())) == false)
        {
            goto label_21;
        }
        
        val_14 = null;
        val_15 = 0;
        val_16 = 0;
        goto label_23;
        label_13:
        val_15 = 0;
        val_16 = 0;
        val_14 = 0;
        label_23:
        if(val_4 != null)
        {
                var val_15 = 0;
            val_15 = val_15 + 1;
            val_4.Dispose();
        }
        
        if( == 1)
        {
                return (CharacterClan)(null == 42) ? (2 + 1) : 2;
        }
        
        if(104 == 113)
        {
                return (CharacterClan)(null == 42) ? (2 + 1) : 2;
        }
        
        return (CharacterClan)(null == 42) ? (2 + 1) : 2;
    }
    public static string ToString(CharacterClan clan)
    {
        var val_1;
        if(clan <= 2)
        {
                val_1 = mem[51420864 + (clan) << 3];
            val_1 = 51420864 + (clan) << 3;
            return (string)val_1;
        }
        
        val_1 = "Unknown";
        return (string)val_1;
    }
    public static CharacterStatType GetStatType(CharacterNameID charNameID)
    {
        CharacterStatType val_3;
        if(0 == (CharacterDataManager.Get(id:  charNameID)))
        {
                val_3 = 4;
            return val_3;
        }
        
        val_3 = val_1.type;
        return val_3;
    }
    private static void CheckCharactersInit()
    {
        if(Character_GlobalInfo.leftInit == false)
        {
                return;
        }
        
        null = null;
        if(Character_GlobalInfo.rightInit == false)
        {
                return;
        }
        
        Character_GlobalInfo.charactersInitiated = true;
    }
    public static bool IsAdventureMode()
    {
        var val_2;
        GameMode val_3;
        val_2 = null;
        val_2 = null;
        val_3 = Character_GlobalInfo.gameMode;
        if(val_3 == 4)
        {
                return true;
        }
        
        val_2 = null;
        val_3 = Character_GlobalInfo.gameMode;
        if(val_3 == 1)
        {
                return true;
        }
        
        val_2 = null;
        val_3 = Character_GlobalInfo.gameMode;
        if(val_3 == 2)
        {
                return true;
        }
        
        val_3 = Character_GlobalInfo.gameMode;
        var val_1 = (val_3 == 3) ? 1 : 0;
        return true;
    }
    public static bool IsAdventureMode(GameMode checkMode)
    {
        if(checkMode == 1)
        {
                return true;
        }
        
        if(checkMode != 4)
        {
                return (bool)((checkMode | 1) == 3) ? 1 : 0;
        }
        
        return true;
    }
    public static int GetAdventurePearlRewardsCount_Normal(int score)
    {
        return UnityEngine.Mathf.Max(a:  0, b:  0);
    }
    public static int GetAdventurePearlRewardsCount_Ex(int score)
    {
        int val_1 = Character_GlobalInfo.GetAdventurePearlRewardsCount_Normal(score:  score);
        val_1 = val_1 + (val_1 << 1);
        return (int)val_1;
    }
    public static bool IsFirstBossFightMatch()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(Character_GlobalInfo.gameMode == 1)
        {
                var val_2 = (Character_GlobalInfo.stage_CurrentLevel == 12) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    public Character_GlobalInfo()
    {
    
    }
    private static Character_GlobalInfo()
    {
        Character_GlobalInfo.charactersInitiated = false;
        Character_GlobalInfo.leftInit = false;
        Character_GlobalInfo.rightInit = false;
        Character_GlobalInfo.isCryptoMMOCMode = false;
        Character_GlobalInfo.isPrivateModeNonWager = false;
        Character_GlobalInfo.isOfflineMode = false;
        Character_GlobalInfo.hackCreditsStartMusic = true;
        Character_GlobalInfo._stage_CurrentLevel = true;
        Character_GlobalInfo.levelSet = false;
        Character_GlobalInfo.inkProcessFull = false;
        Character_GlobalInfo.firstTimePassPuzzle = false;
        Character_GlobalInfo.prevHighScore = 0;
        Character_GlobalInfo.gameDuration = 99;
    }

}
