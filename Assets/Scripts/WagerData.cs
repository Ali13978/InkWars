using UnityEngine;
public class WagerData
{
    // Fields
    public UnityEngine.UI.Toggle m_button;
    public int m_Level;
    public int m_minWins;
    public decimal m_wager;
    public decimal m_price;
    public Currency m_currency;
    
    // Methods
    public bool HasUserGotEnoughCurrency()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        decimal val_10;
        int val_11;
        var val_12;
        decimal val_13;
        var val_14;
        var val_15;
        val_6 = this;
        if(this.m_currency == 2)
        {
            goto label_1;
        }
        
        if(this.m_currency == 1)
        {
            goto label_2;
        }
        
        if(this.m_currency != 0)
        {
                return false;
        }
        
        val_7 = null;
        val_7 = null;
        val_8 = DataStructs.UserDataDictionary.Items;
        val_9 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = val_8.Pearls;
        goto label_7;
        label_1:
        decimal val_2 = CryptoCurrency.CryptoCurency;
        val_10 = this.m_wager;
        val_11 = val_2.flags;
        val_12 = val_2.lo;
        val_13 = val_10;
        val_14 = val_6;
        return System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid}, d2:  new System.Decimal() {flags = val_13, hi = val_13});
        label_2:
        val_15 = null;
        val_15 = null;
        val_8 = DataStructs.UserDataDictionary.Items;
        val_9 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = val_8.Shells;
        label_7:
        val_10 = val_3.fakeValue;
        val_11 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_10, inited = val_3.inited});
        val_12 = 0;
        decimal val_5 = System.Decimal.op_Implicit(value:  val_11);
        val_13 = this.m_wager;
        return System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid}, d2:  new System.Decimal() {flags = val_13, hi = val_13});
    }
    public WagerData()
    {
    
    }

}
