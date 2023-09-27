using UnityEngine;
public class InkMeterScript : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject inkMeterFull;
    public UnityEngine.GameObject inkMeterMiddleFull;
    private bool fullInStarting;
    public UnityEngine.AudioClip largeBlobClip;
    public UnityEngine.GameObject redArrow;
    private int inksHit;
    public UnityEngine.AudioClip rightActionClip;
    public UnityEngine.GameObject child;
    
    // Methods
    private void Start()
    {
        var val_1;
        var val_2;
        GameMode val_3;
        this.child.SetActive(value:  false);
        val_1 = null;
        val_1 = null;
        this.fullInStarting = true;
        this.inksHit = LineController.inkBubblesHitOnCurrentCharacter;
        this.inkMeterFull.SetActive(value:  false);
        val_2 = null;
        val_2 = null;
        val_3 = Character_GlobalInfo.gameMode;
        if(val_3 != 1)
        {
                val_3 = Character_GlobalInfo.gameMode;
            if(val_3 != 2)
        {
                return;
        }
        
        }
        
        this.InvokeRepeating(methodName:  "inkMeterFillFunction", time:  0f, repeatRate:  0.1f);
    }
    public void inkSplatter()
    {
        this.child.SetActive(value:  true);
        this.Invoke(methodName:  "TurnChildOff", time:  2f);
    }
    private void TurnChildOff()
    {
        this.child.SetActive(value:  false);
    }
    public void playBlobClip()
    {
        UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.largeBlobClip, volume:  1f);
    }
    private void inkMeterFillFunction()
    {
        var val_25;
        int val_26;
        var val_27;
        float val_28;
        float val_29;
        var val_30;
        var val_31;
        val_25 = null;
        val_25 = null;
        if(LineController.inkBubblesHitOnCurrentCharacter <= 99)
        {
            goto label_3;
        }
        
        if(this.redArrow == null)
        {
            goto label_4;
        }
        
        if(this.fullInStarting == false)
        {
            goto label_5;
        }
        
        label_33:
        val_26 = 1152921525089773456;
        UnityEngine.Vector2 val_2 = this.redArrow.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        val_27 = null;
        val_27 = null;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = UnityEngine.Mathf.Lerp(a:  55f, b:  175f, t:  (float)LineController.inkBubblesHitOnCurrentCharacter / 100f), z = val_3.z});
        this.redArrow.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
        this.inkMeterFull.SetActive(value:  true);
        this.inkMeterMiddleFull.SetActive(value:  false);
        UnityEngine.Color val_9 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_28 = val_9.r;
        val_29 = val_9.b;
        this.redArrow.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_28, g = val_9.g, b = val_29, a = val_9.a};
        goto label_19;
        label_3:
        this.fullInStarting = false;
        val_30 = null;
        val_30 = null;
        float val_25 = (float)LineController.inkBubblesHitOnCurrentCharacter;
        val_25 = val_25 / 100f;
        this.inkMeterMiddleFull.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = val_25;
        UnityEngine.Vector2 val_13 = this.redArrow.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
        UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.x, y = UnityEngine.Mathf.Lerp(a:  55f, b:  175f, t:  (float)LineController.inkBubblesHitOnCurrentCharacter / 100f), z = val_14.z});
        this.redArrow.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_18.x, y = val_18.y};
        return;
        label_4:
        if(this.fullInStarting == true)
        {
            goto label_33;
        }
        
        label_5:
        UnityEngine.Color val_20 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_28 = val_20.r;
        val_29 = val_20.b;
        this.redArrow.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_28, g = val_20.g, b = val_29, a = val_20.a};
        UnityEngine.AudioSource val_22 = GameAudio.sound.PlayOneShot(clip:  this.rightActionClip, volume:  1f);
        val_31 = null;
        val_31 = null;
        val_26 = LineController.inkBubblesHitOnCurrentCharacter;
        float val_26 = 100f;
        val_26 = (float)val_26 / val_26;
        this.inkMeterMiddleFull.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = val_26;
        label_19:
        this.CancelInvoke(methodName:  "inkMeterFillFunction");
    }
    public void animForRedArrow()
    {
        object[] val_1 = new object[6];
        val_1[0] = "x";
        val_1[1] = 1.2f;
        val_1[2] = "y";
        val_1[3] = 1.2f;
        val_1[4] = "time";
        val_1[5] = 0.05f;
        iTween.ScaleTo(target:  this.redArrow, args:  iTween.Hash(args:  val_1));
        object[] val_3 = new object[8];
        val_3[0] = "x";
        val_3[1] = 1f;
        val_3[2] = "y";
        val_3[3] = 1f;
        val_3[4] = "time";
        val_3[5] = 0.05f;
        val_3[6] = "delay";
        val_3[7] = 0.05f;
        iTween.ScaleTo(target:  this.redArrow, args:  iTween.Hash(args:  val_3));
    }
    public InkMeterScript()
    {
    
    }

}
