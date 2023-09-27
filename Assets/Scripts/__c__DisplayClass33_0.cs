using UnityEngine;
private sealed class sceneCharacters.<>c__DisplayClass33_0
{
    // Fields
    public CharacterNameID defaultSelect;
    
    // Methods
    public sceneCharacters.<>c__DisplayClass33_0()
    {
    
    }
    internal bool <SpecialButtonClickWithSelection>b__0(CharacterStore_Controller x)
    {
        return (bool)(x.charNameID == this.defaultSelect) ? 1 : 0;
    }

}
