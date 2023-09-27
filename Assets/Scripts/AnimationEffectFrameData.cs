using UnityEngine;
[Serializable]
public class AnimationEffectFrameData : AnimationFrameData
{
    // Fields
    public int baseFrameIndex;
    
    // Methods
    public override string ToString()
    {
        return (string)this.ToString() + System.String.Format(format:  ", baseFrameIndex {0}", arg0:  this.baseFrameIndex)(System.String.Format(format:  ", baseFrameIndex {0}", arg0:  this.baseFrameIndex));
    }
    public AnimationEffectFrameData()
    {
        this.baseFrameIndex = 0;
        mem[1152921526029431976] = 1036831949;
        val_1 = new System.Object();
    }

}
