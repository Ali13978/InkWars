using UnityEngine;
[Serializable]
public class AdventureModeSettings
{
    // Fields
    public string name;
    public GameMode mode;
    public RewardData reward;
    public AdventureLevelStarMapping starMapping;
    public RewardData watchAdsRewards;
    
    // Methods
    public AdventureModeSettings()
    {
        this.reward = new RewardData();
        this.starMapping = new AdventureLevelStarMapping();
        this.watchAdsRewards = new RewardData();
    }

}
