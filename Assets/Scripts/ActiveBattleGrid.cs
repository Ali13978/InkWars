using UnityEngine;
public class ActiveBattleGrid : MonoBehaviour
{
    // Fields
    private BattleGridCollection m_battleGridCollection;
    
    // Methods
    private void Awake()
    {
        var val_5 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Settings.SelectedBattleGrid;
        this.GetComponent<UnityEngine.UI.Image>().sprite = this.m_battleGridCollection.GetBattleGridSpriteByID(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited}));
    }
    public ActiveBattleGrid()
    {
    
    }

}
