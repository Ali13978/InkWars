using UnityEngine;
private class MVC_Bot2.BotDecision
{
    // Fields
    public MVC_Bot2.BotDecision.Decision DecisionType;
    public float Score;
    public float RandomValue;
    internal bool PanicDecision;
    internal bool IsRegularShot;
    
    // Properties
    public float TotalScore { get; }
    
    // Methods
    public float get_TotalScore()
    {
        float val_1 = this.Score;
        val_1 = val_1 * this.RandomValue;
        return (float)val_1;
    }
    public MVC_Bot2.BotDecision(MVC_Bot2.BotDecision.Decision decisionType, bool isRegularShot = False)
    {
        this.DecisionType = decisionType;
        this.RandomValue = UnityEngine.Random.value;
        this.IsRegularShot = isRegularShot;
    }

}
