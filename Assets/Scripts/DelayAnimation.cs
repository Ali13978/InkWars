using UnityEngine;
public class DelayAnimation : MonoBehaviour
{
    // Fields
    public float Delay;
    public bool EnableChildrenAfterDelay;
    private bool animationPlayed;
    private UnityEngine.Animation animation;
    
    // Methods
    private void Start()
    {
        UnityEngine.Animation val_1 = this.GetComponent<UnityEngine.Animation>();
        this.animation = val_1;
        val_1.playAutomatically = false;
        bool val_2 = this.animation.Play();
        this.animation.Sample();
        this.animation.Stop();
    }
    private void Update()
    {
        var val_14;
        var val_17;
        var val_18;
        val_14 = this;
        if(this.animationPlayed == true)
        {
                return;
        }
        
        if(this.Delay > 0f)
        {
                float val_1 = UnityEngine.Time.unscaledDeltaTime;
            val_1 = this.Delay - val_1;
            this.Delay = val_1;
            return;
        }
        
        this.animationPlayed = true;
        bool val_3 = this.GetComponent<UnityEngine.Animation>().Play();
        if(this.EnableChildrenAfterDelay == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_5 = this.transform.GetEnumerator();
        label_25:
        var val_16 = 0;
        val_16 = val_16 + 1;
        if(val_5.MoveNext() == false)
        {
            goto label_12;
        }
        
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_17 = val_5.Current;
        if(val_17 != null)
        {
                val_17 = 0;
        }
        
        val_17.gameObject.SetActive(value:  true);
        goto label_25;
        label_12:
        val_18 = 0;
        val_14 = val_5;
        if(val_14 != null)
        {
                var val_18 = 0;
            val_18 = val_18 + 1;
            val_14.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    private System.Collections.IEnumerator AnimationDelay()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DelayAnimation.<AnimationDelay>d__6();
    }
    public DelayAnimation()
    {
        this.Delay = 1f;
    }

}
