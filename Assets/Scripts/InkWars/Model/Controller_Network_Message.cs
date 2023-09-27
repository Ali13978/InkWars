using UnityEngine;

namespace InkWars.Model
{
    public enum Controller_Network_Message
    {
        // Fields
        NA = 0
        ,ASK_FOR_REMATCH = 1
        ,ASK_FOR_CHARACTERSELECT = 2
        ,ACCEPT_REMATCH = 3
        ,ACCEPT_CHARACTERSELECT = 4
        ,REJECT_REMATCH = 5
        ,REJECT_CHARACTESRELECT = 6
        ,SHELL_TOPUP_REQUIRED = 7
        ,SHELL_TOPUP_SUCCESS = 8
        ,QUITTOLOBBY = 9
        ,PRIVATE_ACCEPTMATCH = 10
        ,PRIVATE_DECLINEMATCH = 11
        ,NEW_ACCEPTREMATCH = 12
        ,NEW_DECLINEREMATCH = 13
        
    
    }

}
