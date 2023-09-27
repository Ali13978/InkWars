using UnityEngine;
private sealed class CharacterSelectPanel.<>c__DisplayClass41_0
{
    // Fields
    public CharacterSelectPanel <>4__this;
    public CharacterSelectPage nextPage;
    
    // Methods
    public CharacterSelectPanel.<>c__DisplayClass41_0()
    {
    
    }
    internal void <PlaySwitchPageAnimation>b__0()
    {
        this.<>4__this.<currentPage>k__BackingField = this.nextPage;
        this.<>4__this.SelectDefaultCharacter();
        this.<>4__this.OnPageChangeDone.Invoke();
    }

}
