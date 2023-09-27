using UnityEngine;
[Serializable]
public class AmplifierCollection.AmplifierPriceData
{
    // Fields
    public InkWars.Model.BPAmplifierType amplifierType;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt percent;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt price;
    public Currency currency;
    
    // Methods
    public int GetPromoPrice()
    {
        float val_6 = (float)CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.price, hiddenValue = this.price, fakeValue = -1746028320, inited = true});
        val_6 = (UnityEngine.Mathf.Max(a:  0f, b:  1f - (PlayerBuff.GetLocalPlayerBuff().GetBuffValuePercent01(aNewType:  17)))) * val_6;
        return UnityEngine.Mathf.RoundToInt(f:  val_6);
    }
    public AmplifierCollection.AmplifierPriceData()
    {
    
    }

}
