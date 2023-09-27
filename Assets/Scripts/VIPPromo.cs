using UnityEngine;
[Serializable]
public class VIPPromo
{
    // Fields
    public int normalDurationInDays;
    public int eventDaysBeforeVIPFinish;
    public int eventDaysAfterVIPStart;
    public int freeDaysForAfterVIPStartPromo;
    public int freeDaysForNormal;
    public int freeDaysForBeforeVIPEndPromo;
    public int freeDaysForNewUserGiftVIP;
    public int levelForNewUserGiftVIP;
    
    // Methods
    public VIPPromo()
    {
        this.freeDaysForNormal = 5;
        this.normalDurationInDays = ;
        this.eventDaysBeforeVIPFinish = ;
        this.eventDaysAfterVIPStart = 12884901891;
        this.freeDaysForAfterVIPStartPromo = 3;
        this.freeDaysForNewUserGiftVIP = 3;
        this.levelForNewUserGiftVIP = 2;
    }

}
