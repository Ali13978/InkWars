using UnityEngine;
[Serializable]
internal class BubbleEffectData
{
    // Fields
    public string customAnimKey;
    public InkWars.Model.BubbleTypes bubbleType;
    public UnityEngine.ParticleSystem particle;
    public int sortOrderOffset;
    public bool onGridBubble;
    public bool onShootingBubble;
    public bool rotateByBubbleDir;
    public System.Collections.Generic.List<BubbleEffectEventData> customEvents;
    
    // Methods
    public BubbleEffectData()
    {
        this.onShootingBubble = true;
        this.customEvents = new System.Collections.Generic.List<BubbleEffectEventData>();
    }

}
