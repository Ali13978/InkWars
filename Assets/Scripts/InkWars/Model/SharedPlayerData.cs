using UnityEngine;

namespace InkWars.Model
{
    [Serializable]
    public class SharedPlayerData
    {
        // Fields
        public string UserName;
        public int PP;
        public int Wins;
        public int Draws;
        public int Losses;
        public DataStructs.Flag Flag;
        public int Avatar;
        public int Title;
        
        // Methods
        public static InkWars.Model.SharedPlayerData FromJSON(string source)
        {
            return UnityEngine.JsonUtility.FromJson<InkWars.Model.SharedPlayerData>(json:  source);
        }
        public string ToJSON()
        {
            return UnityEngine.JsonUtility.ToJson(obj:  this);
        }
        public SharedPlayerData()
        {
        
        }
    
    }

}
