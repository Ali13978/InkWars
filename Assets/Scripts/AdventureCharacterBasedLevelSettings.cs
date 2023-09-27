using UnityEngine;
[Serializable]
public class AdventureCharacterBasedLevelSettings
{
    // Fields
    public string name;
    public CharacterNameID AICharacter;
    public RewardData fullyInkedRewards;
    public System.Collections.Generic.List<AdventureModeSettings> modeSettings;
    
    // Properties
    public CharacterClan AIClan { get; }
    public AdventureModeSettings normal { get; }
    public AdventureModeSettings puzzle { get; }
    public AdventureModeSettings extreme { get; }
    public AdventureModeSettings current { get; }
    
    // Methods
    public CharacterClan get_AIClan()
    {
        return Character_GlobalInfo.GetClan(characterId:  this.AICharacter);
    }
    public AdventureModeSettings GetModeSetting(GameMode mode, bool returnEmptyAsDefault = False)
    {
        GameMode val_6;
        GameMode val_7;
        var val_8;
        var val_9;
        val_6 = mode;
        AdventureCharacterBasedLevelSettings.<>c__DisplayClass6_0 val_1 = new AdventureCharacterBasedLevelSettings.<>c__DisplayClass6_0();
        if(val_1 != null)
        {
                val_7 = val_1;
            .mode = val_6;
        }
        else
        {
                val_7 = 16;
            mem[16] = val_6;
            val_6 = mem[16];
        }
        
        if(val_6 != 2)
        {
            goto label_3;
        }
        
        val_8 = 1;
        if(val_1 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_3:
        if(val_1 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        .mode = val_7;
        val_9 = this.modeSettings.Find(match:  new System.Predicate<AdventureModeSettings>(object:  val_1, method:  System.Boolean AdventureCharacterBasedLevelSettings.<>c__DisplayClass6_0::<GetModeSetting>b__0(AdventureModeSettings x)));
        if(val_9 != null)
        {
                return (AdventureModeSettings)val_9;
        }
        
        object[] val_4 = new object[2];
        val_4[0] = mem[16];
        val_4[1] = this.name;
        UnityEngine.Debug.LogErrorFormat(format:  "Cannot find mode setting by GameMode {0} in level {1}", args:  val_4);
        val_9 = 0;
        if(returnEmptyAsDefault == false)
        {
                return (AdventureModeSettings)val_9;
        }
        
        AdventureModeSettings val_5 = null;
        val_9 = val_5;
        val_5 = new AdventureModeSettings();
        return (AdventureModeSettings)val_9;
    }
    public AdventureModeSettings get_normal()
    {
        return this.GetModeSetting(mode:  1, returnEmptyAsDefault:  false);
    }
    public AdventureModeSettings get_puzzle()
    {
        return this.GetModeSetting(mode:  3, returnEmptyAsDefault:  false);
    }
    public AdventureModeSettings get_extreme()
    {
        return this.GetModeSetting(mode:  4, returnEmptyAsDefault:  false);
    }
    public AdventureModeSettings get_current()
    {
        null = null;
        return this.GetModeSetting(mode:  Character_GlobalInfo.gameMode, returnEmptyAsDefault:  true);
    }
    public AdventureCharacterBasedLevelSettings()
    {
        this.AICharacter = 999999;
        this.fullyInkedRewards = new RewardData();
        this.modeSettings = new System.Collections.Generic.List<AdventureModeSettings>();
    }

}
