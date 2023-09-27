using UnityEngine;
private class MVC_Bot2_Settings.EnhancerChoice
{
    // Fields
    public InkWars.Model.BattleEnhancerType Type;
    public int BaseScore;
    public float RandomValue;
    
    // Methods
    public MVC_Bot2_Settings.EnhancerChoice(InkWars.Model.BattleEnhancerType type, int score)
    {
        this.Type = type;
        this.RandomValue = UnityEngine.Random.value;
        this.BaseScore = score;
    }

}
