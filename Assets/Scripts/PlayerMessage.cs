using UnityEngine;
[Serializable]
public class PlayerMessage
{
    // Fields
    public InkWars.Model.Player PlayerID;
    public int HitCount;
    public HitComboType ComboType;
    public Techniques ComboTechnique;
    public string customInfo;
    
    // Methods
    public PlayerMessage()
    {
    
    }
    public PlayerMessage(InkWars.Model.Player PlayerID, int HitCount, HitComboType ComboType, Techniques ComboTechnique)
    {
        this.PlayerID = PlayerID;
        this.HitCount = HitCount;
        this.ComboType = ComboType;
        this.ComboTechnique = ComboTechnique;
    }
    public void LogMessage()
    {
    
    }

}
