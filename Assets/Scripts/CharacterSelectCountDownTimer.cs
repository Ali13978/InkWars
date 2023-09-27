using UnityEngine;
public class CharacterSelectCountDownTimer : MonoBehaviour
{
    // Fields
    private const int CHARACTER_SELECT_TIME = 20;
    public UnityEngine.Events.UnityEvent OnTimeOut;
    private CharacterSelectPanel panel;
    private UnityEngine.RectTransform group;
    private UnityEngine.UI.Text timerText;
    private UnityEngine.UI.Button confirmButton;
    private UnityEngine.Vector3 originScale;
    private int time;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Vector3 val_1 = this.group.localScale;
        this.originScale = val_1;
        mem[1152921528910218292] = val_1.y;
        mem[1152921528910218296] = val_1.z;
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.group.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        this.time = 20;
        string val_2 = this.time.ToString();
        this.panel.OnEntryDone.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectCountDownTimer::OnPanelEnterDone()));
        this.confirmButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectCountDownTimer::OnConfirmClicked()));
    }
    private void OnDisable()
    {
        this.CancelInvoke();
        this.panel.OnEntryDone.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectCountDownTimer::OnPanelEnterDone()));
        this.confirmButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectCountDownTimer::OnConfirmClicked()));
    }
    private void OnConfirmClicked()
    {
        this.CancelInvoke(methodName:  "OnTimeChanged");
        DG.Tweening.Tweener val_2 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScaleX(target:  this.group, endValue:  0f, duration:  0.4f), ease:  26);
    }
    private void OnPanelEnterDone()
    {
        this.group.localScale = new UnityEngine.Vector3() {x = this.originScale, y = V9.16B, z = V10.16B};
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScaleX(target:  this.group, endValue:  0f, duration:  0.4f)), delay:  0.5f), ease:  27), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void CharacterSelectCountDownTimer::<OnPanelEnterDone>b__12_0()));
    }
    private void OnTimeChanged()
    {
        int val_3 = this.time;
        val_3 = val_3 - 1;
        this.time = val_3;
        string val_1 = this.time.ToString();
        if(this.time != 0)
        {
                return;
        }
        
        this.CancelInvoke(methodName:  "OnTimeChanged");
        this.OnTimeOut.Invoke();
        this.confirmButton.onClick.Invoke();
    }
    public CharacterSelectCountDownTimer()
    {
        this.OnTimeOut = new UnityEngine.Events.UnityEvent();
        this.time = 20;
    }
    private void <OnPanelEnterDone>b__12_0()
    {
        this.InvokeRepeating(methodName:  "OnTimeChanged", time:  0f, repeatRate:  1f);
    }

}
