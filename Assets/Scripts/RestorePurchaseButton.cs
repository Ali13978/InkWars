using UnityEngine;
public class RestorePurchaseButton : MonoBehaviour
{
    // Fields
    public UnityEngine.Color successColor;
    public UnityEngine.Color failColor;
    private UnityEngine.UI.Image buttonImage;
    private DG.Tweening.Tweener imageAnimTweener;
    
    // Methods
    private void Awake()
    {
        this.buttonImage = this.GetComponent<UnityEngine.UI.Image>();
    }
    private void OnEnable()
    {
        null = null;
        GGPPurchasingManager.OnRestorePurchaseStart.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void RestorePurchaseButton::OnRestorePurchaseStart()));
        GGPPurchasingManager.OnRestorePurchaseDone.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void RestorePurchaseButton::OnRestorePurchaseDone(bool success)));
    }
    private void OnDisable()
    {
        null = null;
        GGPPurchasingManager.OnRestorePurchaseStart.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void RestorePurchaseButton::OnRestorePurchaseStart()));
        GGPPurchasingManager.OnRestorePurchaseDone.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void RestorePurchaseButton::OnRestorePurchaseDone(bool success)));
    }
    private void OnRestorePurchaseStart()
    {
        if(0 == this.buttonImage)
        {
                return;
        }
        
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.buttonImage.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        UnityEngine.Color val_3 = UnityEngine.Color.gray;
        this.imageAnimTweener = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOColor(target:  this.buttonImage, endValue:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a}, duration:  1f), loops:  0, loopType:  1);
    }
    private void OnRestorePurchaseDone(bool success)
    {
        UnityEngine.Color val_2;
        var val_3;
        var val_4;
        var val_5;
        if(success != false)
        {
                GameAudio.PlayPurchaseSound();
        }
        
        if(this.imageAnimTweener != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.imageAnimTweener, complete:  false);
            this.imageAnimTweener = 0;
        }
        
        if(0 == this.buttonImage)
        {
                return;
        }
        
        if(success != false)
        {
                val_2 = this.successColor;
            val_3 = 1152921529025706668;
            val_4 = 1152921529025706672;
            val_5 = 1152921529025706676;
        }
        else
        {
                val_2 = this.failColor;
            val_3 = 1152921529025706684;
            val_4 = 1152921529025706688;
            val_5 = 1152921529025706692;
        }
        
        this.buttonImage.color = new UnityEngine.Color() {r = this.failColor.r, g = 8.279747E-20f, b = 8.279747E-20f, a = 8.279747E-20f};
    }
    public RestorePurchaseButton()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.successColor = val_1;
        mem[1152921529025830956] = val_1.g;
        mem[1152921529025830960] = val_1.b;
        mem[1152921529025830964] = val_1.a;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.failColor = val_2;
        mem[1152921529025830972] = val_2.g;
        mem[1152921529025830976] = val_2.b;
        mem[1152921529025830980] = val_2.a;
    }

}
