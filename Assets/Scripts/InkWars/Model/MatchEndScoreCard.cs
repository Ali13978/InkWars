using UnityEngine;

namespace InkWars.Model
{
    public struct MatchEndScoreCard
    {
        // Fields
        public float timePassed;
        public int bubblesFired;
        public int bubblesPopped;
        public int bubblesTrashed;
        public int bubblesMisfired;
        public int bubblesRebounded;
        public int bubblesOwnPopped;
        public float bubblesPoppedPerSecond;
        public int baseScore;
        public int TimeRemaining;
        public int BubblesRemaining;
        public System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes> BubbleTypes;
        public int WinBonus;
        
        // Properties
        public int finalScore { get; }
        
        // Methods
        public int get_finalScore()
        {
            return (int)W9 + this.BubbleTypes;
        }
    
    }

}
