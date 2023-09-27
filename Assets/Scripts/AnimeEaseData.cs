using UnityEngine;
[Serializable]
public class AnimeEaseData
{
    // Fields
    public DG.Tweening.Ease ease;
    public float duration;
    
    // Methods
    public AnimeEaseData()
    {
        this.duration = 0.5f;
    }

}
