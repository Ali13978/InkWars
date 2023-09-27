using UnityEngine;
public class DemoStageTextAnimations : MonoBehaviour
{
    // Fields
    public bool dontZoomOutAtEnd;
    public UnityEngine.GameObject preEffect;
    public UnityEngine.GameObject postEffect;
    public bool isEffectNeeded;
    public UnityEngine.AudioClip preClip;
    public UnityEngine.AudioClip postClip;
    
    // Methods
    private void Start()
    {
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  0f, y:  0f);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        this.gameObject.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        if(this.isEffectNeeded != false)
        {
                SeventyOneSquared.PDUnity val_5 = this.preEffect.GetComponentInChildren<SeventyOneSquared.PDUnity>();
            val_5.Running = true;
            UnityEngine.AudioSource val_7 = GameAudio.sound.PlayOneShot(clip:  this.preClip, volume:  1f);
            this.Invoke(methodName:  "scaleInStart", time:  0.6f);
            return;
        }
        
        this.scaleInStart();
    }
    private void scaleInStart()
    {
        object[] val_2 = new object[12];
        val_2[0] = "x";
        val_2[1] = 1f;
        val_2[2] = "y";
        val_2[3] = 1f;
        val_2[4] = "time";
        val_2[5] = 0.5f;
        val_2[6] = "easeType";
        val_2[7] = 24;
        val_2[8] = "oncompletetarget";
        val_2[9] = this.gameObject;
        val_2[10] = "oncomplete";
        val_2[11] = "shakeText";
        iTween.ScaleTo(target:  this.gameObject, args:  iTween.Hash(args:  val_2));
        if(this.isEffectNeeded == false)
        {
                return;
        }
        
        this.Invoke(methodName:  "PostEffect", time:  0.5f);
    }
    private void shakeText()
    {
        System.Object[] val_7;
        if(this.dontZoomOutAtEnd != false)
        {
                val_7 = new object[8];
            val_7[0] = "x";
            val_7[1] = 0.2f;
            val_7[2] = "y";
            val_7[3] = 0.2f;
            val_7[4] = "time";
            val_7[5] = 1.5f;
            val_7[6] = "oncompletetarget";
            val_7[7] = this.gameObject;
        }
        else
        {
                object[] val_4 = new object[10];
            val_7 = val_4;
            val_7[0] = "x";
            val_7[1] = 0.2f;
            val_7[2] = "y";
            val_7[3] = 0.2f;
            val_7[4] = "time";
            val_7[5] = 1.5f;
            val_7[6] = "oncompletetarget";
            val_7[7] = this.gameObject;
            val_7[8] = "oncomplete";
            val_7[9] = "scaleTextToZero";
        }
        
        iTween.ShakePosition(target:  this.gameObject, args:  iTween.Hash(args:  val_4));
    }
    private void scaleTextToZero()
    {
        object[] val_2 = new object[8];
        val_2[0] = "x";
        val_2[1] = 0f;
        val_2[2] = "y";
        val_2[3] = 0f;
        val_2[4] = "time";
        val_2[5] = 0.5f;
        val_2[6] = "delay";
        val_2[7] = 1.5f;
        iTween.ScaleTo(target:  this.gameObject, args:  iTween.Hash(args:  val_2));
    }
    private void PostEffect()
    {
        SeventyOneSquared.PDUnity val_1 = this.postEffect.GetComponentInChildren<SeventyOneSquared.PDUnity>();
        val_1.Running = true;
        this.Invoke(methodName:  "PlayPostClip", time:  0.1f);
    }
    private void PlayPostClip()
    {
        UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.postClip, volume:  1f);
    }
    public DemoStageTextAnimations()
    {
    
    }

}
