using UnityEngine;
public class CharacterSelectTitleAnim : MonoBehaviour
{
    // Fields
    private CharacterSelectPanel panel;
    private TMPro.TextMeshProUGUI titleLine1;
    private TMPro.TextMeshProUGUI titleLine2;
    private UnityEngine.UI.Button confirmButton;
    private UnityEngine.Vector3 originScale1;
    private UnityEngine.Vector3 originScale2;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Vector3 val_2 = this.titleLine1.transform.localScale;
        this.originScale1 = val_2;
        mem[1152921528922385964] = val_2.y;
        mem[1152921528922385968] = val_2.z;
        UnityEngine.Vector3 val_4 = this.titleLine2.transform.localScale;
        this.originScale2 = val_4;
        mem[1152921528922385976] = val_4.y;
        mem[1152921528922385980] = val_4.z;
    }
    private void OnEnable()
    {
        this.titleLine1.text = LanguageManager.GetText(key:  "LK.ScenePlayerChoose.Title1");
        this.titleLine2.text = LanguageManager.GetText(key:  "LK.ScenePlayerChoose.Title2");
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.titleLine1.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        this.titleLine2.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        this.panel.OnEntryDone.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectTitleAnim::OnPanelEnterDone()));
        if(0 == this.confirmButton)
        {
                return;
        }
        
        this.confirmButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectTitleAnim::OnConfirmClicked()));
    }
    private void OnDisable()
    {
        this.panel.OnEntryDone.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectTitleAnim::OnPanelEnterDone()));
        if(0 == this.confirmButton)
        {
                return;
        }
        
        this.confirmButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectTitleAnim::OnConfirmClicked()));
    }
    private void OnConfirmClicked()
    {
        this.titleLine1.text = LanguageManager.GetText(key:  "LK.CharacterSelect.WaitingForOpp1");
        this.titleLine2.text = LanguageManager.GetText(key:  "LK.CharacterSelect.WaitingForOpp2");
        this.OnPanelEnterDone();
    }
    private void OnPanelEnterDone()
    {
        this.titleLine1.transform.localScale = new UnityEngine.Vector3() {x = this.originScale1, y = V9.16B, z = V10.16B};
        this.titleLine2.transform.localScale = new UnityEngine.Vector3() {x = this.originScale2, y = V9.16B, z = V10.16B};
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.DOTween.Sequence(), t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScaleX(target:  this.titleLine1.transform, endValue:  0f, duration:  0.4f)), ease:  27)), atPosition:  0.1f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScaleX(target:  this.titleLine2.transform, endValue:  0f, duration:  0.4f)), ease:  27));
    }
    public CharacterSelectTitleAnim()
    {
    
    }

}
