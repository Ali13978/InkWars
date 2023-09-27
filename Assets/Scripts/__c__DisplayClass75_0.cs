using UnityEngine;
private sealed class GameSave.<>c__DisplayClass75_0
{
    // Fields
    public CharacterClan clan;
    
    // Methods
    public GameSave.<>c__DisplayClass75_0()
    {
    
    }
    internal bool <GetUniqueGameModePlayed>b__0(CharacterData x)
    {
        return (bool)(x.clan == this.clan) ? 1 : 0;
    }

}
