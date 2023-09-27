using UnityEngine;
[Serializable]
public class CharacterData : ScriptableObject
{
    // Fields
    public CharacterNameID characterId;
    public string version;
    public CharacterStatType type;
    public CharacterData.CharacterStatus status;
    private CharacterLocalization _localizedText;
    public CharacterUnlockType unlockType;
    public IAPItemIds iapId;
    public bool realPersonCharacter;
    public CharacterNameStyleType nameStyle;
    public UnityEngine.Vector2 animationOffset;
    public float scale;
    public StageIds relatedStage;
    public UnityEngine.Vector3 revengeSuperAvatarLocation;
    public UnityEngine.Vector2 revengeSuperAvatarScale;
    public float[] AnimDurations;
    public int inStorePriority;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt virtualPrice;
    public Currency virtualCurrency;
    public float superMeterGainRateFactor;
    public InkWars.Model.BubbleTypes middleSuper;
    public int BestSuited_ReboundStopper;
    public int BestSuited_RapidRainbow;
    public int BestSuited_StunEnhancer;
    public int BestSuited_DisposalMeterGainer;
    public int BestSuited_SuperMeterSealer;
    public int BestSuited_StunBreakDisabler;
    public int WorstAgainst_ReboundStopper;
    public int WorstAgainst_RapidRainbow;
    public int WorstAgainst_StunEnhancer;
    public int WorstAgainst_DisposalMeterGainer;
    public int WorstAgainst_SuperMeterSealer;
    public int WorstAgainst_StunBreakDisabler;
    
    // Properties
    public CharacterClan clan { get; }
    public CharacterLocalization localizedText { get; }
    
    // Methods
    public CharacterClan get_clan()
    {
        return Character_GlobalInfo.GetClan(characterId:  this.characterId);
    }
    public CharacterLocalization get_localizedText()
    {
        CharacterLocalization val_2 = this._localizedText;
        if(val_2 != null)
        {
                return val_2;
        }
        
        CharacterLocalization val_1 = null;
        val_2 = val_1;
        val_1 = new CharacterLocalization();
        .characterId = this.characterId;
        this._localizedText = val_2;
        return val_2;
    }
    public CharacterData Clone()
    {
        CharacterData val_2 = UnityEngine.ScriptableObject.CreateInstance<CharacterData>();
        UnityEngine.JsonUtility.FromJsonOverwrite(json:  UnityEngine.JsonUtility.ToJson(obj:  this), objectToOverwrite:  val_2);
        return val_2;
    }
    public CharacterData()
    {
        this.characterId = 999999;
        this.type = 4;
        CharacterData.CharacterStatus val_1 = null;
        .attack = 4294967297;
        .defence = 1;
        .speed = 1;
        val_1 = new CharacterData.CharacterStatus();
        this.status = val_1;
        this.scale = 1f;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.one;
        this.revengeSuperAvatarScale = val_2;
        mem[1152921526038768240] = val_2.y;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
        this.virtualPrice = val_3;
        mem[1152921526038768268] = val_3.fakeValue;
        mem[1152921526038768272] = val_3.inited;
        this.virtualCurrency = 1;
        this.superMeterGainRateFactor = 1f;
        this.middleSuper = 9;
    }

}
