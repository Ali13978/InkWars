using UnityEngine;
private sealed class LevelSelection.<>c__DisplayClass28_0
{
    // Fields
    public LevelSelection <>4__this;
    public WagerData wagerdata;
    
    // Methods
    public LevelSelection.<>c__DisplayClass28_0()
    {
    
    }
    internal void <SetupToggleLockStyle>b__0()
    {
        0.OnLockedWagerButtonClick(wagerdata:  this.wagerdata);
    }
    internal void <SetupToggleLockStyle>b__1()
    {
        this.<>4__this.OnNoEnoughCurrencyWagerButtonClick(wagerdata:  this.wagerdata);
    }
    internal void <SetupToggleLockStyle>b__2(bool isOn)
    {
        this.<>4__this.OnClickLevelButton(data:  this.wagerdata);
    }

}
