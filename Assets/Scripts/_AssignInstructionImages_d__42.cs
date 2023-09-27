using UnityEngine;
private sealed class mainTitle.<AssignInstructionImages>d__42 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public mainTitle <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public mainTitle.<AssignInstructionImages>d__42(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_21;
        DataStructs.GameSave val_26;
        var val_27;
        int val_28;
        var val_29;
        val_26 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.UI.Text val_25 = this.<>4__this.statsText[0];
        val_27 = null;
        val_27 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Stats.PuzzlesMinimumShots;
        string val_2 = val_1.currentCryptoKey.ToString();
        UnityEngine.UI.Text val_26 = this.<>4__this.statsText[1];
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Stats.BattlesNoPower;
        string val_4 = val_3.currentCryptoKey.ToString();
        UnityEngine.UI.Text val_27 = this.<>4__this.statsText[2];
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Stats.Biggest_Combo;
        string val_6 = val_5.currentCryptoKey.ToString();
        UnityEngine.UI.Text val_28 = this.<>4__this.statsText[3];
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = DataStructs.UserDataDictionary.Stats.Maximum_Chains;
        string val_8 = val_7.currentCryptoKey.ToString();
        UnityEngine.UI.Text val_29 = this.<>4__this.statsText[4];
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = DataStructs.UserDataDictionary.Stats.FiredStunner;
        string val_10 = val_9.currentCryptoKey.ToString();
        UnityEngine.UI.Text val_30 = this.<>4__this.statsText[5];
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_11 = DataStructs.UserDataDictionary.Stats.FiredIron;
        string val_12 = val_11.currentCryptoKey.ToString();
        UnityEngine.UI.Text val_31 = this.<>4__this.statsText[6];
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_13 = DataStructs.UserDataDictionary.Stats.FiredColorEraserBall;
        string val_14 = val_13.currentCryptoKey.ToString();
        UnityEngine.UI.Text val_32 = this.<>4__this.statsText[7];
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_15 = DataStructs.UserDataDictionary.Stats.Ink_Sequences;
        string val_16 = val_15.currentCryptoKey.ToString();
        UnityEngine.UI.Text val_33 = this.<>4__this.statsText[8];
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_17 = DataStructs.UserDataDictionary.Stats.MostInkBubbles;
        string val_18 = val_17.currentCryptoKey.ToString();
        UnityEngine.UI.Text val_34 = this.<>4__this.statsText[9];
        CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_19 = DataStructs.UserDataDictionary.Stats.AverageShots;
        string val_22 = val_21.ToString();
        val_28 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_28;
        return (bool)val_28;
        label_1:
        this.<>1__state = 0;
        val_29 = null;
        val_29 = null;
        val_26 = DataStructs.UserDataDictionary.GameSave;
        bool val_24 = val_26.IsRateUsClicked;
        label_2:
        val_28 = 0;
        return (bool)val_28;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
