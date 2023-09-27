using UnityEngine;

namespace DataStructs
{
    [Serializable]
    public struct LeaderboardType
    {
        // Fields
        public DataStructs.LeaderboardScoreType scoreType;
        public DataStructs.PlayerRegion region;
        public CharacterNameID character;
        
        // Methods
        public LeaderboardType(DataStructs.LeaderboardScoreType pointType, DataStructs.PlayerRegion region, CharacterNameID character)
        {
            mem[1152921529242007536] = pointType;
            mem[1152921529242007540] = region;
            mem[1152921529242007544] = character;
        }
        public bool isVaid()
        {
            return (bool)(W8 != 999999) ? 1 : 0;
        }
    
    }

}
