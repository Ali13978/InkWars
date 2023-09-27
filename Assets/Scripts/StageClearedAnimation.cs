using UnityEngine;
public class StageClearedAnimation : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject preEffect;
    public UnityEngine.GameObject postEffect;
    public UnityEngine.AudioClip preClip;
    public UnityEngine.AudioClip postClip;
    
    // Methods
    private void Start()
    {
        if(this.preClip != 0)
        {
                UnityEngine.Color val_4 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            this.gameObject.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
            SeventyOneSquared.PDUnity val_5 = this.preEffect.GetComponent<SeventyOneSquared.PDUnity>();
            val_5.Running = true;
            UnityEngine.AudioSource val_7 = GameAudio.sound.PlayOneShot(clip:  this.preClip, volume:  1f);
            this.Invoke(methodName:  "turnAnimatorOn", time:  0.6f);
            return;
        }
        
        this.Invoke(methodName:  "PostEffect", time:  0.2f);
    }
    private void turnAnimatorOn()
    {
        UnityEngine.Color val_3 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.gameObject.GetComponent<UnityEngine.SpriteRenderer>().color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        this.gameObject.GetComponent<UnityEngine.Animator>().enabled = true;
        this.Invoke(methodName:  "PostEffect", time:  0.2f);
    }
    private void PostEffect()
    {
        SeventyOneSquared.PDUnity val_1 = this.postEffect.GetComponent<SeventyOneSquared.PDUnity>();
        val_1.Running = true;
        if(this.preClip != 0)
        {
                this.Invoke(methodName:  "PlayPostClip", time:  0.1f);
            return;
        }
        
        this.PlayPostClip();
    }
    private void PlayPostClip()
    {
        UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.postClip, volume:  1f);
    }
    public StageClearedAnimation()
    {
    
    }

}
