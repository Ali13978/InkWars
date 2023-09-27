using UnityEngine;
public class AchievementInfo
{
    // Fields
    public const int UNLOCK_PROCESS = 100;
    
    // Methods
    public static string GetSocialAchievementId(AchievementIds aid)
    {
        if(aid > 39)
        {
                return "";
        }
        
        var val_1 = 40827828 + (aid) << 2;
        val_1 = val_1 + 40827828;
        goto (40827828 + (aid) << 2 + 40827828);
    }
    public AchievementInfo()
    {
    
    }

}
