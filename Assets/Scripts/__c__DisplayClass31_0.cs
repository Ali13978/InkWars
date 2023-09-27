using UnityEngine;
private sealed class PrizesPanel.<>c__DisplayClass31_0
{
    // Fields
    public PrizesPanel <>4__this;
    public decimal prize;
    
    // Methods
    public PrizesPanel.<>c__DisplayClass31_0()
    {
    
    }
    internal void <ShowPrizes>b__5()
    {
        decimal val_1 = CryptoCurrency.CryptoCurency;
        decimal val_2 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid}, d2:  new System.Decimal() {flags = this.prize, hi = this.prize, lo = -1683005808, mid = 268435461});
        this.<>4__this.m_tockenGranter.SetEndNumber(aNewCount:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid});
    }
    internal void <ShowPrizes>b__6()
    {
        this.<>4__this.m_shellsCount.gameObject.SetActive(value:  false);
    }
    internal void <ShowPrizes>b__7()
    {
        this.<>4__this.m_pearlsCount.gameObject.SetActive(value:  false);
    }
    internal void <ShowPrizes>b__8()
    {
        this.<>4__this.m_tockensCount.gameObject.SetActive(value:  false);
    }
    internal void <ShowPrizes>b__3()
    {
        this.<>4__this.TitlePrize.gameObject.SetActive(value:  true);
        this.<>4__this.titleUnclokedText.gameObject.SetActive(value:  true);
        this.<>4__this.unclokedBottomText.gameObject.SetActive(value:  true);
    }
    internal void <ShowPrizes>b__4()
    {
        this.<>4__this.AvatarPrize.gameObject.SetActive(value:  true);
        this.<>4__this.avatarUnclokedText.gameObject.SetActive(value:  true);
        this.<>4__this.unclokedBottomText.gameObject.SetActive(value:  true);
    }

}
