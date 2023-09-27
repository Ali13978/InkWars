using UnityEngine;
public class MaxCountDialog : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button closeButton;
    private TMPro.TextMeshProUGUI msg1Txt;
    private TMPro.TextMeshProUGUI msg2Txt;
    
    // Methods
    public static void Show(string msg1, string msg2)
    {
        MaxCountDialog val_2 = UnityEngine.Object.Instantiate<MaxCountDialog>(original:  UnityEngine.Resources.Load<MaxCountDialog>(path:  "DynamicUI/MaxCountDialog"));
        if(val_2 != null)
        {
                val_2.Setup(message1:  msg1, message2:  msg2);
        }
        else
        {
                val_2.Setup(message1:  msg1, message2:  msg2);
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        DialogManager.ShowCustomDialog(dialog:  val_2.GetComponent<UnityEngine.RectTransform>(), scale:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    public void Setup(string message1, string message2)
    {
        this.msg1Txt.text = message1;
        this.msg2Txt.text = message2;
    }
    private void OnEnable()
    {
        this.closeButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void MaxCountDialog::Close()));
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.5f), ease:  27);
    }
    private void OnDisable()
    {
        this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void MaxCountDialog::Close()));
    }
    private void Close()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  26), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void MaxCountDialog::<Close>b__7_0()));
    }
    public MaxCountDialog()
    {
    
    }
    private void <Close>b__7_0()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
