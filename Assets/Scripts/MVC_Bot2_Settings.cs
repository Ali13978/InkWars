using UnityEngine;
[Serializable]
public class MVC_Bot2_Settings
{
    // Fields
    public int ReactionSpeed;
    public int Intelligence_Factor;
    public int Pop_Ability;
    public int Bridge_Combo_Ability;
    public int Rebound_Ability;
    public int Rebound_Bias;
    public int Rebound_Counter_Ability;
    public MVC_Bot2.RevengeSuperOffensiveOrientations RevengeSuperOffensiveOrientation;
    public int RevengeSuperDefensiveOrientation;
    
    // Properties
    public float MinReactionTime { get; }
    public float MaxReactionTime { get; }
    
    // Methods
    public float get_MinReactionTime()
    {
        null = null;
        int val_1 = this.ReactionSpeed - 1;
        System.Single[] val_2 = InkWars.Model.Model_Constants.AdventureModeAIReactionTimes + (((long)(int)((this.ReactionSpeed - 1))) << 2);
        float val_3 = (InkWars.Model.Model_Constants.AdventureModeAIReactionTimes + ((long)(int)((this.ReactionSpeed - 1))) << 2) + 32;
        val_3 = val_3 * 0.75f;
        val_3 = val_3 * 0.5f;
        return (float)val_3;
    }
    public float get_MaxReactionTime()
    {
        null = null;
        int val_1 = this.ReactionSpeed - 1;
        System.Single[] val_2 = InkWars.Model.Model_Constants.AdventureModeAIReactionTimes + (((long)(int)((this.ReactionSpeed - 1))) << 2);
        float val_3 = (InkWars.Model.Model_Constants.AdventureModeAIReactionTimes + ((long)(int)((this.ReactionSpeed - 1))) << 2) + 32;
        val_3 = val_3 * 1.25f;
        val_3 = val_3 * 0.5f;
        return (float)val_3;
    }
    internal int PickEnhancer(CharacterNameID forCharacter)
    {
        InkWars.Model.BattleEnhancerType val_30;
        int val_31;
        var val_32;
        object val_33;
        InkWars.Model.BattleEnhancerType val_34;
        var val_35;
        System.Func<EnhancerChoice, System.Int32> val_37;
        var val_38;
        System.Func<EnhancerChoice, System.Single> val_40;
        object val_41;
        val_31 = this;
        if((UnityEngine.Random.Range(min:  0, max:  5)) == 0)
        {
            goto label_1;
        }
        
        System.Collections.Generic.List<EnhancerChoice> val_2 = new System.Collections.Generic.List<EnhancerChoice>();
        float val_3 = UnityEngine.Random.value;
        val_3 = val_3 * 10f;
        if(val_3 <= (float)this.Intelligence_Factor)
        {
            goto label_2;
        }
        
        val_32 = 1152921528290778432;
        val_31 = 1;
        InkWars.Model.BattleEnhancerType val_30 = 1;
        do
        {
            .Type = val_30;
            .RandomValue = UnityEngine.Random.value;
            .BaseScore = val_31;
            val_2.Add(item:  new MVC_Bot2_Settings.EnhancerChoice());
            val_30 = val_30 + 1;
        }
        while(val_30 != 7);
        
        val_33 = "Failed intelligence test, choosing random enhancer";
        goto label_5;
        label_1:
        UnityEngine.MonoBehaviour.print(message:  "No enhancer");
        val_34 = 0;
        return (int)BattleEnhancerItem.ToInt(type:  val_34 = val_30, level:  6, count:  1);
        label_2:
        CharacterData val_6 = CharacterDataManager.Get(id:  forCharacter);
        .Type = 1;
        .RandomValue = UnityEngine.Random.value;
        .BaseScore = val_6.BestSuited_ReboundStopper;
        val_32 = 1152921528290778432;
        val_2.Add(item:  new MVC_Bot2_Settings.EnhancerChoice());
        .Type = 2;
        .RandomValue = UnityEngine.Random.value;
        .BaseScore = val_6.BestSuited_RapidRainbow;
        val_2.Add(item:  new MVC_Bot2_Settings.EnhancerChoice());
        .Type = 3;
        .RandomValue = UnityEngine.Random.value;
        .BaseScore = val_6.BestSuited_StunEnhancer;
        val_2.Add(item:  new MVC_Bot2_Settings.EnhancerChoice());
        .Type = 2;
        .RandomValue = UnityEngine.Random.value;
        .BaseScore = val_6.BestSuited_DisposalMeterGainer;
        val_2.Add(item:  new MVC_Bot2_Settings.EnhancerChoice());
        .Type = 2;
        .RandomValue = UnityEngine.Random.value;
        .BaseScore = val_6.BestSuited_SuperMeterSealer;
        val_2.Add(item:  new MVC_Bot2_Settings.EnhancerChoice());
        val_31 = val_6.BestSuited_StunBreakDisabler;
        .Type = 2;
        .RandomValue = UnityEngine.Random.value;
        .BaseScore = val_31;
        val_2.Add(item:  new MVC_Bot2_Settings.EnhancerChoice());
        val_33 = "Passed intelligence test, choosing best enhancer";
        label_5:
        UnityEngine.MonoBehaviour.print(message:  val_33);
        val_35 = null;
        val_35 = null;
        val_37 = MVC_Bot2_Settings.<>c.<>9__13_0;
        if(val_37 == null)
        {
                System.Func<EnhancerChoice, System.Int32> val_19 = null;
            val_37 = val_19;
            val_19 = new System.Func<EnhancerChoice, System.Int32>(object:  MVC_Bot2_Settings.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 MVC_Bot2_Settings.<>c::<PickEnhancer>b__13_0(MVC_Bot2_Settings.EnhancerChoice p));
            MVC_Bot2_Settings.<>c.<>9__13_0 = val_37;
        }
        
        val_38 = null;
        val_38 = null;
        val_40 = MVC_Bot2_Settings.<>c.<>9__13_1;
        if(val_40 == null)
        {
                System.Func<EnhancerChoice, System.Single> val_21 = null;
            val_40 = val_21;
            val_21 = new System.Func<EnhancerChoice, System.Single>(object:  MVC_Bot2_Settings.<>c.__il2cppRuntimeField_static_fields, method:  System.Single MVC_Bot2_Settings.<>c::<PickEnhancer>b__13_1(MVC_Bot2_Settings.EnhancerChoice p));
            MVC_Bot2_Settings.<>c.<>9__13_1 = val_40;
        }
        
        EnhancerChoice val_23 = System.Linq.Enumerable.Last<EnhancerChoice>(source:  System.Linq.Enumerable.ThenBy<EnhancerChoice, System.Single>(source:  System.Linq.Enumerable.OrderBy<EnhancerChoice, System.Int32>(source:  val_2, keySelector:  val_19), keySelector:  val_21));
        val_30 = val_23.Type;
        var val_25 = ((double)UnityEngine.Random.value < 0) ? 0 : (val_30);
        if((double)UnityEngine.Random.value < 0)
        {
                val_41 = 1;
        }
        else
        {
                var val_26 = ((double)UnityEngine.Random.value < 0) ? 0 : (val_25);
            if((double)UnityEngine.Random.value < 0)
        {
                val_41 = 2;
        }
        else
        {
                if((double)UnityEngine.Random.value < 0)
        {
                val_41 = 3;
        }
        else
        {
                if((double)UnityEngine.Random.value < 0)
        {
                val_41 = 4;
            val_30 = val_25;
        }
        else
        {
                if((double)UnityEngine.Random.value < 0)
        {
                val_41 = 5;
            val_30 = val_26;
        }
        else
        {
                val_41 = 6;
            val_30 = ((double)UnityEngine.Random.value < 0) ? 0 : (val_26);
        }
        
        }
        
        }
        
        }
        
        }
        
        UnityEngine.MonoBehaviour.print(message:  "Enhancer level: "("Enhancer level: ") + val_41);
        return (int)BattleEnhancerItem.ToInt(type:  val_34, level:  6, count:  1);
    }
    public MVC_Bot2_Settings()
    {
        this.ReactionSpeed = 1;
        this.Intelligence_Factor = 0;
        this.Pop_Ability = 1;
        this.Bridge_Combo_Ability = 0;
        this.Rebound_Ability = 4294967297;
        this.Rebound_Bias = 1;
        this.Rebound_Counter_Ability = 1;
    }

}
