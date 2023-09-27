using UnityEngine;
[Serializable]
public class RewardData
{
    // Fields
    public string name;
    public eInkUnlockable item;
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt quantity;
    public CharacterNameID character;
    public string description;
    
    // Methods
    public RewardData()
    {
        this.character = 999999;
        this.character = 999999;
    }
    public void AssignRewards()
    {
        eInkUnlockable val_5 = this.item;
        val_5 = val_5 - 1;
        if(val_5 > 5)
        {
                return;
        }
        
        var val_6 = 40836424 + ((this.item - 1)) << 2;
        val_6 = val_6 + 40836424;
        goto (40836424 + ((this.item - 1)) << 2 + 40836424);
    }

}
