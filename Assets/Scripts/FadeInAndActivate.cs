using UnityEngine;
public class FadeInAndActivate : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Image ThingToFadeIn;
    public UnityEngine.GameObject[] ThingsToActivate;
    public int fadeSpeed;
    private bool FinishedFadeIn;
    private bool FinishedFadeOut;
    
    // Methods
    private void Awake()
    {
        goto label_0;
        label_4:
        this.ThingsToActivate[0].SetActive(value:  false);
        0 = 1;
        label_0:
        if(0 < this.ThingsToActivate.Length)
        {
            goto label_4;
        }
    
    }
    private void Update()
    {
        UnityEngine.GameObject val_12;
        float val_16;
        float val_17;
        float val_18;
        UnityEngine.UI.Image val_20;
        float val_21;
        var val_22;
        val_12 = this;
        if(this.FinishedFadeIn == false)
        {
            goto label_0;
        }
        
        if(this.FinishedFadeOut == true)
        {
                return;
        }
        
        UnityEngine.Color val_1 = this.ThingToFadeIn.color;
        if(val_1.a <= 1f)
        {
            goto label_4;
        }
        
        UnityEngine.Color val_2 = this.ThingToFadeIn.color;
        val_16 = val_2.r;
        val_17 = val_2.g;
        val_18 = val_2.b;
        float val_3 = UnityEngine.Time.deltaTime;
        val_20 = this.ThingToFadeIn;
        val_3 = val_3 * (float)this.fadeSpeed;
        val_21 = val_2.a - val_3;
        if(val_20 != null)
        {
            goto label_10;
        }
        
        goto label_6;
        label_0:
        UnityEngine.Color val_4 = this.ThingToFadeIn.color;
        if(val_4.a >= 0)
        {
            goto label_8;
        }
        
        UnityEngine.Color val_5 = this.ThingToFadeIn.color;
        val_16 = val_5.r;
        val_17 = val_5.g;
        val_18 = val_5.b;
        float val_6 = UnityEngine.Time.deltaTime;
        val_20 = this.ThingToFadeIn;
        val_6 = val_6 * (float)this.fadeSpeed;
        val_21 = val_5.a + val_6;
        if(val_20 != null)
        {
            goto label_10;
        }
        
        label_6:
        label_10:
        val_20.color = new UnityEngine.Color() {r = val_16, g = val_17, b = val_18, a = val_21};
        return;
        label_8:
        val_22 = 0;
        this.FinishedFadeIn = true;
        goto label_11;
        label_15:
        val_12 = this.ThingsToActivate[0];
        val_12.SetActive(value:  true);
        val_22 = 1;
        label_11:
        if(val_22 < this.ThingsToActivate.Length)
        {
            goto label_15;
        }
        
        return;
        label_4:
        this.ThingToFadeIn.gameObject.SetActive(value:  false);
        this.FinishedFadeOut = true;
        this.gameObject.transform.parent.gameObject.SetActive(value:  false);
    }
    public FadeInAndActivate()
    {
        this.fadeSpeed = 2;
    }

}
