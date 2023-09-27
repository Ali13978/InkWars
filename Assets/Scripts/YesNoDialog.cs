using UnityEngine;
public class YesNoDialog : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button yesButton;
    private UnityEngine.UI.Button noButton;
    private TMPro.TextMeshProUGUI title;
    private TMPro.TextMeshProUGUI message;
    private System.Action m_yesAction;
    private System.Action m_noAction;
    
    // Methods
    public static YesNoDialog Show(string title, string msg, System.Action yesAction, System.Action noAction)
    {
        YesNoDialog val_2 = UnityEngine.Object.Instantiate<YesNoDialog>(original:  UnityEngine.Resources.Load<YesNoDialog>(path:  "DynamicUI/YesNoDialog"));
        val_2.title.text = title;
        val_2.message.text = msg;
        val_2.m_yesAction = yesAction;
        val_2.m_noAction = noAction;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        DialogManager.ShowCustomDialog(dialog:  val_2.GetComponent<UnityEngine.RectTransform>(), scale:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        return val_2;
    }
    private void OnEnable()
    {
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        this.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.one;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
        DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.5f), ease:  27), isIndependentUpdate:  true);
        this.noButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void YesNoDialog::Close()));
        this.yesButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void YesNoDialog::OnClickedYes()));
    }
    private void OnDisable()
    {
        this.noButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void YesNoDialog::Close()));
        this.yesButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void YesNoDialog::OnClickedYes()));
    }
    public void Close()
    {
        if(this.m_noAction != null)
        {
                this.m_noAction.Invoke();
        }
        
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.5f), ease:  26), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void YesNoDialog::<Close>b__9_0())), isIndependentUpdate:  true);
    }
    public void OnClickedYes()
    {
        if(this.m_yesAction != null)
        {
                this.m_yesAction.Invoke();
        }
        
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.5f), ease:  26), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void YesNoDialog::<OnClickedYes>b__10_0())), isIndependentUpdate:  true);
    }
    public YesNoDialog()
    {
    
    }
    private void <Close>b__9_0()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void <OnClickedYes>b__10_0()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
