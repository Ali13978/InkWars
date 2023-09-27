using UnityEngine;
[Serializable]
public class BattleEnhancerCollection.BattleEnhancerPriceData
{
    // Fields
    public InkWars.Model.BattleEnhancerType enhancerType;
    public int level;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt count;
    public Currency currency;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt price;
    
    // Methods
    public int GetPromoPrice()
    {
        float val_6 = (float)CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.price, hiddenValue = this.price, fakeValue = -1510734736, inited = true});
        val_6 = (UnityEngine.Mathf.Max(a:  0f, b:  1f - (PlayerBuff.GetLocalPlayerBuff().GetBuffValuePercent01(aNewType:  16)))) * val_6;
        return UnityEngine.Mathf.RoundToInt(f:  val_6);
    }
    public BattleEnhancerCollection.BattleEnhancerPriceData()
    {
    
    }

}
