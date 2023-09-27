using UnityEngine;
[Serializable]
public class AdventureLevelData
{
    // Fields
    public string name;
    public int levelId;
    public StageIds stageId;
    public bool enablePuzzleMode;
    public System.Collections.Generic.List<AdventureCharacterBasedLevelSettings> AICharacterBasedSettings;
    
    // Methods
    public AdventureCharacterBasedLevelSettings GetSettingByAIClan(CharacterClan clan)
    {
        string val_5;
        System.Predicate<T> val_6;
        val_5 = this;
        .clan = clan;
        System.Predicate<AdventureCharacterBasedLevelSettings> val_2 = null;
        val_6 = val_2;
        val_2 = new System.Predicate<AdventureCharacterBasedLevelSettings>(object:  new AdventureLevelData.<>c__DisplayClass5_0(), method:  System.Boolean AdventureLevelData.<>c__DisplayClass5_0::<GetSettingByAIClan>b__0(AdventureCharacterBasedLevelSettings x));
        AdventureCharacterBasedLevelSettings val_3 = this.AICharacterBasedSettings.Find(match:  val_2);
        if(val_3 != null)
        {
                return val_3;
        }
        
        object[] val_4 = new object[2];
        val_6 = val_4;
        val_6[0] = (AdventureLevelData.<>c__DisplayClass5_0)[1152921528520027968].clan;
        val_5 = this.name;
        val_6[1] = val_5;
        UnityEngine.Debug.LogErrorFormat(format:  "Cannot find level data by clan {0} in {1}", args:  val_4);
        return val_3;
    }
    public AdventureCharacterBasedLevelSettings GetSettingByAICharacter(CharacterNameID character)
    {
        string val_5;
        System.Predicate<T> val_6;
        val_5 = this;
        .character = character;
        System.Predicate<AdventureCharacterBasedLevelSettings> val_2 = null;
        val_6 = val_2;
        val_2 = new System.Predicate<AdventureCharacterBasedLevelSettings>(object:  new AdventureLevelData.<>c__DisplayClass6_0(), method:  System.Boolean AdventureLevelData.<>c__DisplayClass6_0::<GetSettingByAICharacter>b__0(AdventureCharacterBasedLevelSettings x));
        AdventureCharacterBasedLevelSettings val_3 = this.AICharacterBasedSettings.Find(match:  val_2);
        if(val_3 != null)
        {
                return val_3;
        }
        
        object[] val_4 = new object[2];
        val_6 = val_4;
        val_6[0] = (AdventureLevelData.<>c__DisplayClass6_0)[1152921528520214896].character;
        val_5 = this.name;
        val_6[1] = val_5;
        UnityEngine.Debug.LogErrorFormat(format:  "Cannot find level data by {0} in {1}", args:  val_4);
        return val_3;
    }
    public AdventureCharacterBasedLevelSettings GetSettingByPlayerCharacter(CharacterNameID character)
    {
        CharacterClan val_3;
        CharacterClan val_1 = Character_GlobalInfo.GetClan(characterId:  character);
        if(val_1 == 0)
        {
            goto label_3;
        }
        
        if(val_1 != 2)
        {
            goto label_4;
        }
        
        val_3 = (~this.levelId) & 1;
        return this.GetSettingByAIClan(clan:  val_3 = 0);
        label_3:
        val_3 = 1;
        return this.GetSettingByAIClan(clan:  val_3);
        label_4:
        return this.GetSettingByAIClan(clan:  val_3);
    }
    public AdventureCharacterBasedLevelSettings GetSettingByCurrentCharacter()
    {
        CharacterNameID val_2;
        CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
        return (AdventureCharacterBasedLevelSettings)this.GetSettingByPlayerCharacter(character:  val_2);
    }
    public AdventureLevelData()
    {
        this.enablePuzzleMode = true;
        this.AICharacterBasedSettings = new System.Collections.Generic.List<AdventureCharacterBasedLevelSettings>();
    }

}
