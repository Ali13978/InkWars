using UnityEngine;
public class AdventureLevelDataCollection : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<AdventureLevelData> levels;
    public System.Collections.Generic.List<AdventureLevelDataCollection.RewardSprite> rewardSpriteList;
    private static AdventureLevelDataCollection _inst;
    
    // Properties
    private static AdventureLevelDataCollection instance { get; }
    
    // Methods
    private static AdventureLevelDataCollection get_instance()
    {
        var val_3;
        AdventureLevelDataCollection val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = AdventureLevelDataCollection._inst;
        if(0 == val_4)
        {
                val_5 = null;
            val_4 = UnityEngine.Resources.Load<AdventureLevelDataCollection>(path:  "NetworkDataCollection/AdventureLevelDataCollection");
            val_5 = null;
            AdventureLevelDataCollection._inst = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (AdventureLevelDataCollection)AdventureLevelDataCollection._inst;
    }
    public static AdventureModeSettings GetCurrentModeSetting()
    {
        AdventureCharacterBasedLevelSettings val_3 = AdventureLevelDataCollection.Get(level:  Character_GlobalInfo.stage_CurrentLevel).GetSettingByCurrentCharacter();
        if(val_3 != null)
        {
                return val_3.current;
        }
        
        return val_3.current;
    }
    public static int GetCurrentStarsByScore(int score)
    {
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6;
        var val_7;
        AdventureModeSettings val_1 = AdventureLevelDataCollection.GetCurrentModeSetting();
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.starMapping.scoreFor3Stars, hiddenValue = val_1.starMapping.scoreFor3Stars, fakeValue = val_1.starMapping, inited = val_1.starMapping})) < score)
        {
                val_7 = 3;
            return (int)((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6, hiddenValue = val_6, fakeValue = val_1.starMapping, inited = val_1.starMapping})) < score) ? 1 : 0;
        }
        
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.starMapping.scoreFor2Stars, hiddenValue = val_1.starMapping.scoreFor2Stars, fakeValue = val_1.starMapping, inited = val_1.starMapping})) < score)
        {
                val_7 = 2;
            return (int)((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6, hiddenValue = val_6, fakeValue = val_1.starMapping, inited = val_1.starMapping})) < score) ? 1 : 0;
        }
        
        val_6 = val_1.starMapping.scoreFor1Star;
        return (int)((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6, hiddenValue = val_6, fakeValue = val_1.starMapping, inited = val_1.starMapping})) < score) ? 1 : 0;
    }
    public static AdventureLevelData Get(int level)
    {
        .level = level;
        AdventureLevelDataCollection val_2 = AdventureLevelDataCollection.instance;
        AdventureLevelData val_4 = val_2.levels.Find(match:  new System.Predicate<AdventureLevelData>(object:  new AdventureLevelDataCollection.<>c__DisplayClass8_0(), method:  System.Boolean AdventureLevelDataCollection.<>c__DisplayClass8_0::<Get>b__0(AdventureLevelData x)));
        if(val_4 != null)
        {
                return val_4;
        }
        
        object[] val_5 = new object[1];
        val_5[0] = (AdventureLevelDataCollection.<>c__DisplayClass8_0)[1152921528523301696].level;
        UnityEngine.Debug.LogErrorFormat(format:  "Cannot find level data by level {0}", args:  val_5);
        return val_4;
    }
    public static AdventureLevelData GetCurrent()
    {
        return AdventureLevelDataCollection.Get(level:  Character_GlobalInfo.stage_CurrentLevel);
    }
    public static UnityEngine.Sprite GetRewardItemSprite(eInkUnlockable type)
    {
        object val_6;
        UnityEngine.Sprite val_7;
        AdventureLevelDataCollection.<>c__DisplayClass10_0 val_1 = null;
        val_6 = val_1;
        val_1 = new AdventureLevelDataCollection.<>c__DisplayClass10_0();
        .type = type;
        AdventureLevelDataCollection val_2 = AdventureLevelDataCollection.instance;
        if((val_2.rewardSpriteList.Find(match:  new System.Predicate<RewardSprite>(object:  val_1, method:  System.Boolean AdventureLevelDataCollection.<>c__DisplayClass10_0::<GetRewardItemSprite>b__0(AdventureLevelDataCollection.RewardSprite x)))) != null)
        {
                val_7 = val_4.sprite;
            return (UnityEngine.Sprite)val_7;
        }
        
        object[] val_5 = new object[1];
        val_6 = (AdventureLevelDataCollection.<>c__DisplayClass10_0)[1152921528523602672].type;
        val_5[0] = val_6;
        UnityEngine.Debug.LogErrorFormat(format:  "Cannot find reward sprite by type {0}", args:  val_5);
        val_7 = 0;
        return (UnityEngine.Sprite)val_7;
    }
    public static string GetRewardItemName(eInkUnlockable type)
    {
        object val_6;
        string val_7;
        AdventureLevelDataCollection.<>c__DisplayClass11_0 val_1 = null;
        val_6 = val_1;
        val_1 = new AdventureLevelDataCollection.<>c__DisplayClass11_0();
        .type = type;
        AdventureLevelDataCollection val_2 = AdventureLevelDataCollection.instance;
        if((val_2.rewardSpriteList.Find(match:  new System.Predicate<RewardSprite>(object:  val_1, method:  System.Boolean AdventureLevelDataCollection.<>c__DisplayClass11_0::<GetRewardItemName>b__0(AdventureLevelDataCollection.RewardSprite x)))) != null)
        {
                val_7 = val_4.name;
            return (string)val_7;
        }
        
        object[] val_5 = new object[1];
        val_6 = (AdventureLevelDataCollection.<>c__DisplayClass11_0)[1152921528523797792].type;
        val_5[0] = val_6;
        UnityEngine.Debug.LogErrorFormat(format:  "Cannot find reward name by type {0}", args:  val_5);
        val_7 = "";
        return (string)val_7;
    }
    public AdventureLevelDataCollection()
    {
        this.levels = new System.Collections.Generic.List<AdventureLevelData>();
        this.rewardSpriteList = new System.Collections.Generic.List<RewardSprite>();
    }
    private static AdventureLevelDataCollection()
    {
    
    }

}
