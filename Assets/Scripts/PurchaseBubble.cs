using UnityEngine;
public class PurchaseBubble : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI m_price;
    private UnityEngine.UI.Image m_pearl;
    private UnityEngine.UI.Image m_shell;
    private UnityEngine.UI.Button m_purchaseButton;
    private UnityEngine.UI.Button m_closeButton;
    private UnityEngine.RectTransform panel;
    private UnityEngine.GameObject currentImage;
    private UnityEngine.GameObject InternalItems;
    private System.Action m_onClick;
    
    // Methods
    private void OnEnable()
    {
        this.m_purchaseButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PurchaseBubble::OnClickButton()));
        this.m_closeButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PurchaseBubble::Close()));
    }
    private void OnDisable()
    {
        this.m_purchaseButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PurchaseBubble::OnClickButton()));
        this.m_closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PurchaseBubble::Close()));
    }
    private void Close()
    {
        this.gameObject.SetActive(value:  false);
    }
    private void OnClickButton()
    {
        if(this.m_onClick == null)
        {
                return;
        }
        
        this.m_onClick.Invoke();
    }
    public void Setup(UnityEngine.Vector3 pos, string price, Currency currency, int positionIndex = 0, System.Action onClick)
    {
        var val_34;
        float val_35;
        float val_36;
        object val_38;
        DG.Tweening.Sequence val_39;
        var val_41;
        var val_42;
        this.GetComponent<UnityEngine.CanvasGroup>().alpha = 0f;
        this.gameObject.SetActive(value:  true);
        this.m_price.text = price;
        var val_4 = (positionIndex < 0) ? (positionIndex + 3) : positionIndex;
        val_4 = val_4 & 4294967292;
        int val_5 = positionIndex - val_4;
        UnityEngine.Transform val_6 = this.currentImage.transform;
        if(val_5 <= 1)
        {
                val_6.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.InternalItems.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_34 = this.GetComponent<UnityEngine.RectTransform>();
            val_35 = 0.5f;
        }
        else
        {
                val_6.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.InternalItems.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_34 = this.GetComponent<UnityEngine.RectTransform>();
            val_35 = 0.5f;
        }
        
        UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  1f, y:  val_35);
        val_34.pivot = new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
        this.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
        float val_34 = (float)UnityEngine.Screen.width;
        val_34 = val_34 / (float)UnityEngine.Screen.height;
        if(val_34 >= 2f)
        {
            goto label_15;
        }
        
        if((double)val_34 >= 1.69)
        {
            goto label_16;
        }
        
        if((double)val_34 >= 1.59)
        {
            goto label_17;
        }
        
        UnityEngine.Debug.Log(message:  "4:3 -> "("4:3 -> ") + val_34);
        val_36 = 25f;
        goto label_23;
        label_15:
        UnityEngine.Debug.Log(message:  "18.5:9 -> "("18.5:9 -> ") + val_34);
        val_36 = 120f;
        goto label_23;
        label_16:
        val_38 = "16:9 -> ";
        goto label_24;
        label_17:
        val_38 = "16:10 -> ";
        label_24:
        UnityEngine.Debug.Log(message:  val_38 + val_34);
        val_36 = 80f;
        label_23:
        if(val_5 <= 1)
        {
                val_39 = DG.Tweening.DOTween.Sequence();
            UnityEngine.RectTransform val_19 = this.GetComponent<UnityEngine.RectTransform>();
            float val_20 = pos.x + val_36;
        }
        else
        {
                val_39 = DG.Tweening.DOTween.Sequence();
        }
        
        DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_39, t:  DG.Tweening.ShortcutExtensions.DOMoveX(target:  this.GetComponent<UnityEngine.RectTransform>(), endValue:  pos.x - val_36, duration:  0.25f, snapping:  false)), isIndependentUpdate:  true);
        DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Join(s:  val_39, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.GetComponent<UnityEngine.CanvasGroup>(), endValue:  1f, duration:  0.25f)), isIndependentUpdate:  true);
        UnityEngine.GameObject val_31 = this.m_pearl.gameObject;
        if(val_31 == null)
        {
            goto label_34;
        }
        
        if(currency == 0)
        {
            goto label_35;
        }
        
        label_39:
        val_31.SetActive(value:  false);
        val_41 = this.m_shell.gameObject;
        val_42 = 1;
        goto label_38;
        label_34:
        if(currency != 0)
        {
            goto label_39;
        }
        
        label_35:
        val_31.SetActive(value:  true);
        val_41 = this.m_shell.gameObject;
        val_42 = 0;
        label_38:
        val_41.SetActive(value:  false);
        this.m_onClick = onClick;
    }
    public void Remove()
    {
        this.gameObject.SetActive(value:  false);
    }
    public PurchaseBubble()
    {
    
    }

}
