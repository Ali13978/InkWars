using UnityEngine;
[Serializable]
public class GameItemData
{
    // Fields
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredString name;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredString nameTxtID;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredString assetPath;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt uniqueId;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool unlockByDefault;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt iapId;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt virtualPrice;
    public Currency virtualCurrency;
    
    // Methods
    public GameItemData()
    {
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
        this.uniqueId = val_1;
        mem[1152921528391586400] = val_1.fakeValue;
        mem[1152921528391586404] = val_1.inited;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
        this.unlockByDefault = val_2;
        mem[1152921528391586416] = val_2.fakeValue;
        mem[1152921528391586417] = val_2.fakeValueChanged;
        mem[1152921528391586418] = val_2.inited;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
        this.iapId = val_3;
        mem[1152921528391586428] = val_3.fakeValue;
        mem[1152921528391586432] = val_3.inited;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
        this.virtualPrice = val_4;
        mem[1152921528391586444] = val_4.fakeValue;
        mem[1152921528391586448] = val_4.inited;
    }

}
