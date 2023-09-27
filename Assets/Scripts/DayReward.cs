using UnityEngine;
[Serializable]
public class DayReward
{
    // Fields
    public UnityEngine.Sprite icon;
    public UnityEngine.Sprite iconMini;
    public UnityEngine.Sprite text;
    public InkWars.ExpressStore.Unlockable unlockable;
    
    // Methods
    public DayReward()
    {
        this.iconMini = 0;
        this.text = 0;
        this.icon = 0;
    }

}
