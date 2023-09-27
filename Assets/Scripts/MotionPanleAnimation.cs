using UnityEngine;
public class MotionPanleAnimation : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector3 beginPos;
    public UnityEngine.Vector3 endPos;
    public float duration;
    public DG.Tweening.Ease ease;
    public UnityEngine.GameObject panel;
    
    // Methods
    public MotionPanleAnimation()
    {
        this.duration = 0.5f;
    }

}
