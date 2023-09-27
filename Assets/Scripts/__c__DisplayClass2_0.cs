using UnityEngine;
private sealed class UnityIAPHandler.<>c__DisplayClass2_0
{
    // Fields
    public IAPItemIds aNewId;
    
    // Methods
    public UnityIAPHandler.<>c__DisplayClass2_0()
    {
    
    }
    internal bool <UnlockCharacterByIapId>b__0(CharacterData x)
    {
        return (bool)(x.iapId == this.aNewId) ? 1 : 0;
    }

}
