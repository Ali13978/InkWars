using UnityEngine;
[Serializable]
public abstract class ProfileUnlockables_Base
{
    // Fields
    public string name;
    public CharacterNameID CharID;
    public string UnlockConditionDescription;
    public string secondaryUnlockConditionDescription;
    public UnlockLogicFor2ndConditionType logicFor2ndCondition;
    public Currency currency;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt cost;
    
    // Properties
    public abstract bool isCommon { get; }
    public string localizedLogicText { get; }
    
    // Methods
    public abstract bool IsUnlocked(); // 0
    public abstract bool get_isCommon(); // 0
    public string get_localizedLogicText()
    {
        var val_1;
        string val_2;
        if(this.logicFor2ndCondition == 2)
        {
            goto label_1;
        }
        
        if(this.logicFor2ndCondition != 1)
        {
            goto label_2;
        }
        
        val_1 = "LK.Logic.Then";
        return LanguageManager.GetText(key:  val_2 = 0);
        label_1:
        val_1 = "LK.Logic.Or";
        return LanguageManager.GetText(key:  val_2);
        label_2:
        return LanguageManager.GetText(key:  val_2);
    }
    protected ProfileUnlockables_Base()
    {
    
    }

}
