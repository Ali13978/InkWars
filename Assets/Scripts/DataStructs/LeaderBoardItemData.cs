using UnityEngine;

namespace DataStructs
{
    [Serializable]
    public class LeaderBoardItemData
    {
        // Fields
        public int leaderboardPlacing;
        public DataStructs.PlayerRank rank;
        public string username;
        public CharacterNameID character;
        public DataStructs.Flag flag;
        public long score;
        public string UID;
        
        // Methods
        public LeaderBoardItemData()
        {
            this.leaderboardPlacing = 4294967296;
            this.rank = 1;
            this.username = "NA";
            this.score = 0;
            this.UID = "";
            this.character = 999999;
        }
        public DataStructs.LeaderBoardItemData ConvertToItemClass()
        {
            string val_2;
            DataStructs.LeaderBoardItemData val_1 = new DataStructs.LeaderBoardItemData();
            if(val_1 != null)
            {
                    .score = (long)this.score;
                .character = this.character;
                .rank = this.rank;
                .leaderboardPlacing = 0;
                .flag = this.flag;
                val_2 = this.username;
            }
            else
            {
                    mem[40] = (long)this.score;
                mem[32] = this.character;
                .rank = this.rank;
                .flag = this.flag;
                mem[16] = 0;
                val_2 = this.username;
            }
            
            .username = val_2;
            return val_1;
        }
        public override string ToString()
        {
            object[] val_1 = new object[6];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.UID != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.UID == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.UID;
            val_1[1] = this.username;
            val_1[2] = this.rank;
            val_1[3] = this.score;
            val_1[4] = this.flag;
            val_1[5] = this.character;
            return (string)System.String.Format(format:  "UID {0}, username {1}, rank {2}, score {3}, flag {4}, character {5} ", args:  val_1);
        }
    
    }

}
