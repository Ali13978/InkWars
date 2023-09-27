using UnityEngine;
public class View_Whirlpool : MonoBehaviour
{
    // Fields
    public UnityEngine.SpriteRenderer SpriteImage;
    public UnityEngine.GameObject GO_Particle_Whirl;
    public bool RingEmpty;
    private SeventyOneSquared.PDUnity Particle_Whirl;
    private float WhirlEffectDuration;
    private UnityEngine.Vector3 OriginalRotation;
    private UnityEngine.Vector3 rotationPerSecond;
    
    // Methods
    private void Awake()
    {
        this.RingEmpty = false;
        this.SpriteImage.sortingOrder = 3;
        View_Core val_1 = View_Core.Instance;
        this.SpriteImage.sprite = val_1.Whirlpool_Inactive;
        this.Particle_Whirl = this.GO_Particle_Whirl.GetComponent<SeventyOneSquared.PDUnity>();
        UnityEngine.Vector3 val_4 = this.SpriteImage.transform.localEulerAngles;
        this.OriginalRotation = val_4;
        mem[1152921528387994480] = val_4.y;
        mem[1152921528387994484] = val_4.z;
    }
    public System.Collections.IEnumerator TriggerWhirlEffect()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new View_Whirlpool.<TriggerWhirlEffect>d__8();
    }
    public void TriggerPlug()
    {
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.TriggerPlugCoroutine());
    }
    private System.Collections.IEnumerator TriggerPlugCoroutine()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new View_Whirlpool.<TriggerPlugCoroutine>d__10();
    }
    public View_Whirlpool()
    {
        this.WhirlEffectDuration = 1f;
        this.rotationPerSecond = 0;
        mem[1152921528388516224] = 0;
    }

}
