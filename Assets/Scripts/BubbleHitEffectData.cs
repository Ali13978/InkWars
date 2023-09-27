using UnityEngine;
[Serializable]
private class View_PopAnimations.BubbleHitEffectData
{
    // Fields
    public string animationKey;
    public InkWars.Model.BubbleTypes bubbleType;
    public UnityEngine.ParticleSystem particle;
    public int offsetLayer;
    public UnityEngine.TextAsset emitterFile;
    public float customDuration;
    public SeventyOneSquared.PDUnity pdPlayer;
    
    // Methods
    public void PlayAnimation(int basedLayer)
    {
        SeventyOneSquared.PDUnity val_10;
        UnityEngine.ParticleSystem val_11;
        val_10 = this;
        val_11 = this.particle;
        if(0 != val_11)
        {
                this.particle.gameObject.SetActive(value:  true);
            val_11 = this.particle.GetComponent<UnityEngine.ParticleSystemRenderer>();
            if(0 != val_11)
        {
                val_11 = this.particle.GetComponent<UnityEngine.ParticleSystemRenderer>();
            val_11.sortingOrder = this.offsetLayer + basedLayer;
        }
        
            if(this.particle.isPlaying != true)
        {
                this.particle.Play();
        }
        
        }
        
        if(0 == this.emitterFile)
        {
                return;
        }
        
        this.pdPlayer.gameObject.SetActive(value:  true);
        val_11 = this.emitterFile;
        this.pdPlayer.EmitterFile = val_11;
        val_10 = this.pdPlayer;
        this.pdPlayer.Running = true;
    }
    public bool IsPlaying()
    {
        SeventyOneSquared.PDUnity val_9;
        var val_10;
        val_9 = this;
        if((0 != this.particle) && (this.particle.gameObject.activeInHierarchy != false))
        {
                if(this.particle.isPlaying != false)
        {
                val_10 = 1;
            return (bool)val_10;
        }
        
        }
        
        if(0 != this.pdPlayer)
        {
                if(this.pdPlayer.gameObject.activeInHierarchy != false)
        {
                val_9 = this.pdPlayer;
            var val_8 = (this.pdPlayer.Running == true) ? 1 : 0;
            return (bool)val_10;
        }
        
        }
        
        val_10 = 0;
        return (bool)val_10;
    }
    public View_PopAnimations.BubbleHitEffectData()
    {
    
    }

}
