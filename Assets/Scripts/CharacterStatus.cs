using UnityEngine;
[Serializable]
public class CharacterData.CharacterStatus
{
    // Fields
    public int attack;
    public int defence;
    public int speed;
    
    // Methods
    public CharacterData.CharacterStatus()
    {
        this.attack = 4294967297;
        this.defence = 1;
        this.speed = 1;
    }

}
