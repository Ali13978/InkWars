using UnityEngine;
private sealed class View_Whirlpool.<TriggerWhirlEffect>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View_Whirlpool <>4__this;
    private float <timeRemaining>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public View_Whirlpool.<TriggerWhirlEffect>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SeventyOneSquared.PDUnity val_13;
        int val_14;
        var val_15;
        float val_16;
        UnityEngine.Vector3 val_17;
        float val_18;
        val_13 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.RingEmpty) == false)
        {
            goto label_4;
        }
        
        label_2:
        val_14 = 0;
        return (bool)val_14;
        label_1:
        val_15 = val_13;
        val_16 = this.<timeRemaining>5__2;
        this.<>1__state = 0;
        goto label_6;
        label_4:
        View_Core val_1 = View_Core.Instance;
        this.<>4__this.SpriteImage.sprite = val_1.Whirlpool_Active;
        View_Core val_3 = View_Core.Instance;
        UnityEngine.AudioSource val_4 = GameAudio.sound.PlayOneShot(clip:  val_3.audio_WhirlpoolVortex, volume:  1f);
        this.<>4__this.Particle_Whirl.emitterConfig.duration = this.<>4__this.WhirlEffectDuration;
        this.<>4__this.Particle_Whirl.emitterConfig.elapsedTime = 0f;
        this.<>4__this.Particle_Whirl.Running = true;
        val_15 = val_13;
        this.<timeRemaining>5__2 = this.<>4__this.WhirlEffectDuration;
        val_16 = this.<>4__this.WhirlEffectDuration;
        label_6:
        if(val_16 <= 0f)
        {
                if((this.<>4__this.RingEmpty) != true)
        {
                View_Core val_5 = View_Core.Instance;
            this.<>4__this.SpriteImage.sprite = val_5.Whirlpool_Inactive;
        }
        
            val_17 = this.<>4__this.OriginalRotation;
            this.<>4__this.SpriteImage.transform.localEulerAngles = new UnityEngine.Vector3() {x = val_17, y = V9.16B, z = V10.16B};
            val_13 = this.<>4__this.Particle_Whirl;
            val_14 = 0;
            this.<>4__this.Particle_Whirl.Running = false;
            return (bool)val_14;
        }
        
        float val_7 = UnityEngine.Time.deltaTime;
        val_7 = val_16 - val_7;
        this.<timeRemaining>5__2 = val_7;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(d:  UnityEngine.Time.deltaTime, a:  new UnityEngine.Vector3() {x = this.<>4__this.rotationPerSecond, y = V9.16B, z = V10.16B});
        UnityEngine.Transform val_10 = this.<>4__this.SpriteImage.transform;
        UnityEngine.Vector3 val_11 = val_10.localEulerAngles;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        val_17 = val_12.x;
        val_18 = val_12.z;
        val_10.localEulerAngles = new UnityEngine.Vector3() {x = val_17, y = val_12.y, z = val_18};
        val_14 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_14;
        return (bool)val_14;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
