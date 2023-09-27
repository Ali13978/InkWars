using UnityEngine;
[Serializable]
public class AdventureLevelStarMapping
{
    // Fields
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt scoreFor1Star;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt scoreFor2Stars;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt scoreFor3Stars;
    
    // Methods
    public AdventureLevelStarMapping()
    {
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
        this.scoreFor1Star = val_1;
        mem[1152921528522731272] = val_1.fakeValue;
        mem[1152921528522731276] = val_1.inited;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
        this.scoreFor2Stars = val_2;
        mem[1152921528522731288] = val_2.fakeValue;
        mem[1152921528522731292] = val_2.inited;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
        this.scoreFor3Stars = val_3;
        mem[1152921528522731304] = val_3.fakeValue;
        mem[1152921528522731308] = val_3.inited;
    }

}
