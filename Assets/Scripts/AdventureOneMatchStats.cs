using UnityEngine;
private class Stats.AdventureOneMatchStats
{
    // Fields
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt firedStunner;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt firedIron;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt firedColorEraserBall;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt maximum_Chains;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt firedTotalShots;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt biggest_Combo;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt mostInkBubbles;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool usePower;
    
    // Methods
    public void Apply(bool playerWins)
    {
        DataStructs.Stats val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        int val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        val_33 = playerWins;
        val_34 = null;
        val_34 = null;
        val_35 = null;
        val_35 = null;
        int val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.Stats.currAdvStats + 16 + 8, inited = DataStructs.Stats.currAdvStats + 16 + 8});
        val_2 = val_2 + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 152 + 8, inited = DataStructs.UserDataDictionary.Stats + 152 + 8}));
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_2);
        DataStructs.UserDataDictionary.Stats.FiredStunner = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited};
        int val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.Stats.currAdvStats + 32 + 8, inited = DataStructs.Stats.currAdvStats + 32 + 8});
        val_5 = val_5 + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 168 + 8, inited = DataStructs.UserDataDictionary.Stats + 168 + 8}));
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_5);
        DataStructs.UserDataDictionary.Stats.FiredIron = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited};
        int val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.Stats.currAdvStats + 48 + 8, inited = DataStructs.Stats.currAdvStats + 48 + 8});
        val_8 = val_8 + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 184 + 8, inited = DataStructs.UserDataDictionary.Stats + 184 + 8}));
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_8);
        DataStructs.UserDataDictionary.Stats.FiredColorEraserBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_9.currentCryptoKey, hiddenValue = val_9.hiddenValue, fakeValue = val_9.fakeValue, inited = val_9.inited};
        val_36 = null;
        val_36 = null;
        if(Character_GlobalInfo.gameMode != 3)
        {
                val_37 = null;
            val_37 = null;
            val_38 = null;
            val_38 = null;
            int val_11 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.Stats.currAdvStats + 80 + 8, inited = DataStructs.Stats.currAdvStats + 80 + 8});
            val_11 = val_11 + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 200 + 8, inited = DataStructs.UserDataDictionary.Stats + 200 + 8}));
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_11);
            DataStructs.UserDataDictionary.Stats.FiredTotalShots = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_12.currentCryptoKey, hiddenValue = val_12.hiddenValue, fakeValue = val_12.fakeValue, inited = val_12.inited};
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_16 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Max(a:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.Stats.currAdvStats + 64 + 8, inited = DataStructs.Stats.currAdvStats + 64 + 8}), b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 232 + 8, inited = DataStructs.UserDataDictionary.Stats + 232 + 8})));
            DataStructs.UserDataDictionary.Stats.Maximum_Chains = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_16.currentCryptoKey, hiddenValue = val_16.hiddenValue, fakeValue = val_16.fakeValue, inited = val_16.inited};
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_20 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Max(a:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.Stats.currAdvStats + 96 + 8, inited = DataStructs.Stats.currAdvStats + 96 + 8}), b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 248 + 8, inited = DataStructs.UserDataDictionary.Stats + 248 + 8})));
            DataStructs.UserDataDictionary.Stats.Biggest_Combo = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_20.currentCryptoKey, hiddenValue = val_20.hiddenValue, fakeValue = val_20.fakeValue, inited = val_20.inited};
        }
        
        val_39 = null;
        val_39 = null;
        val_40 = null;
        val_40 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_24 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Max(a:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.Stats.currAdvStats + 112 + 8, inited = DataStructs.Stats.currAdvStats + 112 + 8}), b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 264 + 8, inited = DataStructs.UserDataDictionary.Stats + 264 + 8})));
        val_41 = val_24.currentCryptoKey;
        DataStructs.UserDataDictionary.Stats.MostInkBubbles = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_41, hiddenValue = val_24.hiddenValue, fakeValue = val_24.fakeValue, inited = val_24.inited};
        if(val_33 == false)
        {
                return;
        }
        
        val_42 = null;
        val_42 = null;
        val_43 = null;
        val_33 = DataStructs.UserDataDictionary.Stats;
        val_43 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_28 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Min(a:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.Stats.currAdvStats + 80 + 8, inited = DataStructs.Stats.currAdvStats + 80 + 8}), b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 280 + 8, inited = DataStructs.UserDataDictionary.Stats + 280 + 8})));
        val_41 = val_28.fakeValue;
        val_33.PuzzlesMinimumShots = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_28.currentCryptoKey, hiddenValue = val_28.hiddenValue, fakeValue = val_41, inited = val_28.inited};
        val_44 = null;
        val_44 = null;
        if(Character_GlobalInfo.gameMode == 3)
        {
                return;
        }
        
        val_45 = null;
        val_45 = null;
        val_46 = null;
        val_46 = null;
        bool val_33 = DataStructs.Stats.currAdvStats + 136;
        val_33 = (~(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {hiddenValue = 268435456, fakeValue = val_33, fakeValueChanged = val_33, inited = val_33}))) & 1;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_32 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 296 + 8, inited = DataStructs.UserDataDictionary.Stats + 296 + 8})) + val_33);
        DataStructs.UserDataDictionary.Stats.BattlesNoPower = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_32.currentCryptoKey, hiddenValue = val_32.hiddenValue, fakeValue = val_32.fakeValue, inited = val_32.inited};
    }
    public Stats.AdventureOneMatchStats()
    {
    
    }

}
