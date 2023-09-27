using UnityEngine;
[Serializable]
internal class BubbleEffectEventData
{
    // Fields
    public BubbleEffectEventData.TriggerType triggerType;
    public float triggerValue;
    public UnityEngine.Events.UnityEvent customEvent;
    
    // Methods
    public bool CanTriggerEvent(UnityEngine.ParticleSystem particle)
    {
        var val_8;
        float val_9;
        if(0 == particle)
        {
                val_8 = 0;
            return (bool)(val_6 >= this.triggerValue) ? 1 : 0;
        }
        
        if((this.triggerType == 0) || (this.triggerType != 1))
        {
            goto label_6;
        }
        
        if(particle == null)
        {
            goto label_7;
        }
        
        val_9 = particle.time;
        goto label_8;
        label_6:
        float val_3 = particle.time;
        return (bool)(val_6 >= this.triggerValue) ? 1 : 0;
        label_7:
        val_9 = 0.time;
        label_8:
        MainModule val_5 = particle.main;
        float val_6 = val_5.m_ParticleSystem.duration;
        val_6 = val_9 / val_6;
        return (bool)(val_6 >= this.triggerValue) ? 1 : 0;
    }
    public void TriggerEvent()
    {
        if(this.customEvent == null)
        {
                return;
        }
        
        this.customEvent.Invoke();
    }
    public BubbleEffectEventData()
    {
        this.customEvent = new UnityEngine.Events.UnityEvent();
    }

}
