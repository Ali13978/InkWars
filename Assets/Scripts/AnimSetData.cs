using UnityEngine;
[Serializable]
public class VIPEffectRays.AnimSetData
{
    // Fields
    public float duration;
    public DG.Tweening.Ease ease;
    public float value1;
    public float value2;
    
    // Methods
    public VIPEffectRays.AnimSetData()
    {
        this.duration = 10f;
        this.ease = 1;
    }

}
