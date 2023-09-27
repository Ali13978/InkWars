using UnityEngine;
[Serializable]
public class MusicData : GameItemData
{
    // Fields
    public CodeStage.AntiCheat.ObscuredTypes.ObscuredString subTitle;
    public float loopStart;
    public float loopEnd;
    public bool enableForRandomBGM;
    public int displayPriority;
    
    // Methods
    public MusicData()
    {
        this.enableForRandomBGM = true;
    }

}
