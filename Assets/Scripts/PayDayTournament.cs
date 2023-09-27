using UnityEngine;
public class PayDayTournament
{
    // Fields
    private const string TournamentKey = "PayDayTournament20181006";
    
    // Methods
    private static string GetEnhancerInitKey(InkWars.Model.BattleEnhancerType type, int level)
    {
        null = null;
        return "PayDayTournament20181006_" + DataStructs.UserDataDictionary.Items.GenerateEnhancerKey(type:  type, level:  level)(DataStructs.UserDataDictionary.Items.GenerateEnhancerKey(type:  type, level:  level)) + "_init";
    }
    public static int GetTournamentEnhancerCount(InkWars.Model.BattleEnhancerType type, int level, int defaultValue = 0)
    {
        var val_9;
        string val_10;
        var val_11;
        var val_12;
        var val_13;
        val_9 = null;
        val_9 = null;
        val_10 = PayDayTournament.GetEnhancerInitKey(type:  type, level:  level);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
        val_11 = val_2.fakeValue;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_4 = DataStructs.UserDataDictionary.GameSave.GetGameSaveFlags(key:  val_10, defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_11 & 4294967295, fakeValueChanged = val_11 & 4294967295, inited = val_11 & 4294967295});
        val_4.fakeValue = val_4.fakeValue & 4294967295;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, fakeValueChanged = val_4.fakeValue, inited = val_4.fakeValue})) != true)
        {
                val_12 = null;
            val_12 = null;
            DataStructs.UserDataDictionary.Items.SetTournamentEnhancerCount(tournamentKey:  "PayDayTournament20181006", type:  type, level:  level, count:  8);
            val_10 = PayDayTournament.GetEnhancerInitKey(type:  type, level:  level);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
            val_11 = val_7.fakeValue;
            DataStructs.UserDataDictionary.GameSave.SetGameSaveFlags(key:  val_10, aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_11 & 4294967295, fakeValueChanged = val_11 & 4294967295, inited = val_11 & 4294967295});
        }
        
        val_13 = null;
        val_13 = null;
        if(DataStructs.UserDataDictionary.Items != null)
        {
                return DataStructs.UserDataDictionary.Items.GetTournamentEnhancerCount(tournamentKey:  "PayDayTournament20181006", type:  type, level:  level, defaultValue:  defaultValue);
        }
        
        return DataStructs.UserDataDictionary.Items.GetTournamentEnhancerCount(tournamentKey:  "PayDayTournament20181006", type:  type, level:  level, defaultValue:  defaultValue);
    }
    public static void SetTournamentEnhancerCount(InkWars.Model.BattleEnhancerType type, int level, int count)
    {
        var val_2;
        if((PayDayTournament.GetTournamentEnhancerCount(type:  type, level:  level, defaultValue:  0)) <= count)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        DataStructs.UserDataDictionary.Items.SetTournamentEnhancerCount(tournamentKey:  "PayDayTournament20181006", type:  type, level:  level, count:  count);
    }
    public PayDayTournament()
    {
    
    }

}
