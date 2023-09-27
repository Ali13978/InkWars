using UnityEngine;
public class UserNameDialog : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button cancelButton;
    private UnityEngine.UI.Button nextButton;
    private TMPro.TMP_InputField nameInput;
    
    // Methods
    public static UserNameDialog Show(UnityEngine.Events.UnityAction<string> OnNext, UnityEngine.Events.UnityAction OnCancel)
    {
        UserNameDialog val_2 = UnityEngine.Object.Instantiate<UserNameDialog>(original:  UnityEngine.Resources.Load<UserNameDialog>(path:  "DynamicUI/UserNameDialog"));
        if(val_2 != null)
        {
                val_2.Setup(OnNext:  OnNext, OnCancel:  OnCancel);
        }
        else
        {
                val_2.Setup(OnNext:  OnNext, OnCancel:  OnCancel);
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        DialogManager.ShowCustomDialog(dialog:  val_2.GetComponent<UnityEngine.RectTransform>(), scale:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        return val_2;
    }
    private void OnEnable()
    {
        this.Open();
    }
    private void Open()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  27);
    }
    private void Close()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  26), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void UserNameDialog::<Close>b__6_0()));
    }
    private void Setup(UnityEngine.Events.UnityAction<string> OnNext, UnityEngine.Events.UnityAction OnCancel)
    {
        UserNameDialog.<>c__DisplayClass7_0 val_1 = new UserNameDialog.<>c__DisplayClass7_0();
        if(val_1 != null)
        {
                .OnNext = OnNext;
        }
        else
        {
                mem[16] = OnNext;
        }
        
        .<>4__this = this;
        this.cancelButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UserNameDialog::Close()));
        this.nextButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UserNameDialog::Close()));
        this.cancelButton.onClick.AddListener(call:  OnCancel);
        this.nextButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void UserNameDialog.<>c__DisplayClass7_0::<Setup>b__0()));
    }
    public UserNameDialog()
    {
    
    }
    private void <Close>b__6_0()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
