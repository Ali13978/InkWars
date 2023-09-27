using UnityEngine;
public class Model_BP_PP_Library : MonoBehaviour
{
    // Fields
    public static MatchOutcomePoints LastCalculated_PlayerPoints;
    public static MatchOutcomePoints LastCalculated_BattlePoints;
    private const int PlayerPoints_MaxGain = 128;
    private const int PlayerPoints_MinGain = 1;
    private const int PlayerPoints_MaxLoss = 128;
    private const int PlayerPoints_MinLoss = 1;
    private const int PlayerPoints_DefaultGain = 64;
    private const int PlayerPoints_DefaultLoss = 64;
    private const int PlayerPoints_GapThreshold = 32;
    private const int PlayerPoints_GapDifference = 1;
    private const int BattlePoints_MaxGain = 70;
    private const int BattlePoints_MinGain = 10;
    private const int BattlePoints_MaxLoss = 50;
    private const int BattlePoints_MinLoss = 10;
    private const int BattlePoints_DefaultGain = 40;
    private const int BattlePoints_DefaultLoss = 30;
    private const int BattlePoints_GapThreshold = 400;
    private const int BattlePoints_GapDifference = 1;
    private const int BattlePoints_RankModifier = 1;
    private const float BattlePoints_DeductionMultiplier_D = 0;
    private const float BattlePoints_DeductionMultiplier_Dp = 0.25;
    private const float BattlePoints_DeductionMultiplier_C = 0.5;
    private const float BattlePoints_DeductionMultiplier_Cp = 0.75;
    private const float BattlePoints_DeductionMultiplier_Normal = 1;
    
    // Methods
    public static MatchOutcomePoints CalculatePlayerPoints(int playerPoints_Self, int playerPoints_Opponent)
    {
        float val_13;
        var val_14;
        int val_13 = playerPoints_Opponent;
        val_13 = val_13 - playerPoints_Self;
        if(val_13 != 0)
        {
                int val_2 = (val_13 >> 31) | 1;
            float val_14 = 0.03125f;
            val_14 = ((float)UnityEngine.Mathf.Abs(value:  val_13)) * val_14;
            int val_4 = UnityEngine.Mathf.CeilToInt(f:  val_14);
            val_2 = val_4 * val_2;
            val_4 = val_2 + 64;
            var val_15 = 64;
            val_13 = UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.Min(a:  val_4, b:  128), b:  1);
            int val_9 = UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.Min(a:  val_15 - val_2, b:  128), b:  1);
            val_15 = playerPoints_Self - val_9;
            var val_10 = (val_15 >= 0) ? (val_9) : playerPoints_Self;
        }
        else
        {
                val_13 = 8.96831E-44f;
            val_14 = 64;
        }
        
        int val_11 = val_13 + playerPoints_Self;
        int val_12 = playerPoints_Self - val_14;
        Model_BP_PP_Library.BattlePoints_DeductionMultiplier_Normal = val_13;
        Model_BP_PP_Library.BattlePoints_DeductionMultiplier_Normal.__il2cppRuntimeField_3 = 64;
        Model_BP_PP_Library.BattlePoints_DeductionMultiplier_Normal.__il2cppRuntimeField_8 = val_11;
        Model_BP_PP_Library.BattlePoints_DeductionMultiplier_Normal.__il2cppRuntimeField_C = val_12;
        return new MatchOutcomePoints() {Points_Gain = 64, Points_Loss = 64, TotalPoints_AfterMatchWon = val_11, TotalPoints_AfterMatchLoss = val_12};
    }
    public static MatchOutcomePoints CalculateBattlePoints(int battlePoints_Self, DataStructs.PlayerRank rank_Self, int battlePoints_Opponent, DataStructs.PlayerRank rank_Opponent)
    {
        float val_39;
        var val_40;
        var val_41;
        float val_42;
        float val_43;
        int val_44;
        var val_45;
        DataStructs.GameSave val_46;
        var val_47;
        DataStructs.PlayerRank val_41 = rank_Opponent;
        int val_38 = battlePoints_Opponent;
        val_38 = val_38 - battlePoints_Self;
        if(val_38 == 0)
        {
            goto label_1;
        }
        
        float val_39 = 400f;
        val_39 = ((float)UnityEngine.Mathf.Abs(value:  val_38)) / val_39;
        int val_40 = UnityEngine.Mathf.Max(a:  0, b:  UnityEngine.Mathf.FloorToInt(f:  val_39));
        int val_6 = UnityEngine.Mathf.Max(a:  rank_Self, b:  val_41);
        int val_7 = UnityEngine.Mathf.Min(a:  rank_Self, b:  val_41);
        val_39 = 0f;
        if(val_7 >= val_6)
        {
            goto label_4;
        }
        
        val_39 = 0f;
        goto label_9;
        label_8:
        val_39 = val_39 + 1f;
        goto label_6;
        label_9:
        if(val_7 > 7)
        {
            goto label_8;
        }
        
        int val_8 = 1 << val_7;
        val_8 = val_8 & 170;
        if(val_8 == 0)
        {
            goto label_8;
        }
        
        label_6:
        val_7 = val_7 + 1;
        if(val_6 != val_7)
        {
            goto label_9;
        }
        
        label_4:
        val_40 = val_40 * ((val_38 >> 31) | 1);
        int val_9 = UnityEngine.Mathf.FloorToInt(f:  val_39);
        val_40 = (((val_41 - rank_Self) <= 0) ? (-val_9) : (val_9)) + val_40;
        val_41 = val_40 + 40;
        val_40 = UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.Min(a:  val_41, b:  70), b:  10);
        val_41 = UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.Min(a:  30 - val_40, b:  50), b:  10);
        goto label_14;
        label_1:
        val_41 = 30;
        val_40 = 40;
        label_14:
        if((rank_Self - 1) <= 3)
        {
                val_42 = mem[40826352 + ((rank_Self - 1)) << 2];
            val_42 = 40826352 + ((rank_Self - 1)) << 2;
        }
        else
        {
                val_42 = 1f;
        }
        
        val_43 = val_42 * 30f;
        val_44 = UnityEngine.Mathf.CeilToInt(f:  val_43);
        System.DateTime val_19 = System.DateTime.Now;
        val_45 = null;
        val_45 = null;
        val_46 = DataStructs.UserDataDictionary.GameSave;
        System.DateTime val_20 = val_46.BPAmplifierExpireDate;
        if( >= (-2094304424))
        {
            goto label_35;
        }
        
        val_47 = null;
        val_47 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_21 = DataStructs.UserDataDictionary.Settings.SelectedBPAmplifier;
        val_46 = val_21.fakeValue;
        BPAmplifierItem val_23 = BPAmplifierItem.FromInt(number:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_21.currentCryptoKey, hiddenValue = val_21.hiddenValue, fakeValue = val_46, inited = val_21.inited}));
        if(val_23.amplifierType == 2)
        {
            goto label_31;
        }
        
        if(val_23.amplifierType != 1)
        {
            goto label_35;
        }
        
        val_43 = ((float)val_23.precentage / 100f) * 40f;
        val_40 = (UnityEngine.Mathf.RoundToInt(f:  val_43)) + 40;
        goto label_35;
        label_31:
        val_43 = ((float)val_23.precentage / 100f) * (float)val_44;
        val_44 = val_44 - (UnityEngine.Mathf.RoundToInt(f:  val_43));
        label_35:
        float val_30 = PlayerBuff.GetLocalPlayerBuff().GetBuffValuePercent01(aNewType:  6);
        val_30 = val_30 + 1f;
        val_30 = val_30 * ((float)UnityEngine.Mathf.Abs(value:  40));
        int val_31 = UnityEngine.Mathf.RoundToInt(f:  val_30);
        float val_34 = PlayerBuff.GetLocalPlayerBuff().GetBuffValuePercent01(aNewType:  7);
        val_34 = 1f - val_34;
        val_34 = val_34 * ((float)UnityEngine.Mathf.Abs(value:  val_44));
        int val_35 = UnityEngine.Mathf.RoundToInt(f:  val_34);
        int val_36 = val_31 + battlePoints_Self;
        int val_37 = battlePoints_Self - val_35;
        Model_BP_PP_Library.LastCalculated_BattlePoints = val_31;
        Model_BP_PP_Library.BattlePoints_DeductionMultiplier_Normal.__il2cppRuntimeField_14 = val_35;
        Model_BP_PP_Library.BattlePoints_DeductionMultiplier_Normal.__il2cppRuntimeField_18 = val_36;
        Model_BP_PP_Library.BattlePoints_DeductionMultiplier_Normal.__il2cppRuntimeField_1C = val_37;
        return new MatchOutcomePoints() {Points_Gain = val_31, Points_Loss = val_35, TotalPoints_AfterMatchWon = val_36, TotalPoints_AfterMatchLoss = val_37};
    }
    public Model_BP_PP_Library()
    {
    
    }

}
