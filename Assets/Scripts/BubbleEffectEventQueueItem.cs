using UnityEngine;
internal class BubbleEffectEventQueueItem
{
    // Fields
    public UnityEngine.ParticleSystem particle;
    public BubbleEffectEventData eventData;
    
    // Properties
    public bool valid { get; }
    public bool canTrigger { get; }
    
    // Methods
    public bool get_valid()
    {
        var val_3;
        if(0 != this.particle)
        {
                var val_2 = (this.eventData != 0) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    public bool get_canTrigger()
    {
        if(this.valid == false)
        {
                return false;
        }
        
        if(this.eventData != null)
        {
                return this.eventData.CanTriggerEvent(particle:  this.particle);
        }
        
        return this.eventData.CanTriggerEvent(particle:  this.particle);
    }
    public void TriggerEvent()
    {
        if(this.eventData == null)
        {
                return;
        }
        
        if(this.eventData.customEvent == null)
        {
                return;
        }
        
        this.eventData.customEvent.Invoke();
    }
    public BubbleEffectEventQueueItem()
    {
    
    }

}
