using UnityEngine;
[Serializable]
public class AnimationFrameData
{
    // Fields
    public UnityEngine.Sprite sprite;
    public float duration;
    public float timeFromStart;
    
    // Methods
    public override string ToString()
    {
        object val_4;
        if(0 == this.sprite)
        {
                val_4 = "null";
            return (string)System.String.Format(format:  "timeFromStart {0}, duration {1}, spriteFile {2}", arg0:  this.timeFromStart, arg1:  this.duration, arg2:  val_4 = this.sprite.name);
        }
        
        return (string)System.String.Format(format:  "timeFromStart {0}, duration {1}, spriteFile {2}", arg0:  this.timeFromStart, arg1:  this.duration, arg2:  val_4);
    }
    public AnimationFrameData()
    {
        this.duration = 0.1f;
    }

}
