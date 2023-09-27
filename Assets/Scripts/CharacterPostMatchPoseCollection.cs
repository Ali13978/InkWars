using UnityEngine;
public class CharacterPostMatchPoseCollection : ScriptableObject
{
    // Fields
    public UnityEngine.Sprite winPose;
    public UnityEngine.Sprite losePose;
    public UnityEngine.Sprite drawPose;
    
    // Methods
    public UnityEngine.Sprite GetPose(InkWars.Model.GameResult result, bool isLocalPlayer, bool isDraw2KoSame = False)
    {
        UnityEngine.Sprite val_2;
        if((result - 1) <= 5)
        {
                var val_2 = 40837504 + ((result - 1)) << 2;
            val_2 = val_2 + 40837504;
        }
        else
        {
                val_2 = this.drawPose;
            return (UnityEngine.Sprite)mem[this.losePose];
        }
    
    }
    public CharacterPostMatchPoseCollection()
    {
    
    }

}
