using UnityEngine;
public class CharacterSelectUserInfoAnim : MonoBehaviour
{
    // Fields
    private CharacterSelectPanel panel;
    private UnityEngine.UI.Image nameBG;
    private UnityEngine.UI.Text nameTxt;
    private UnityEngine.CanvasGroup shell;
    private TMPro.TextMeshProUGUI shellTxt;
    private UnityEngine.Color originNameBGColor;
    
    // Methods
    private void OnEnable()
    {
        var val_11;
        UnityEngine.Color val_1 = this.nameBG.color;
        this.originNameBGColor = val_1;
        mem[1152921528923495764] = val_1.g;
        mem[1152921528923495768] = val_1.b;
        mem[1152921528923495772] = val_1.a;
        UnityEngine.Color val_2 = UnityEngine.Color.clear;
        this.nameBG.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        this.shell.alpha = 0f;
        val_11 = null;
        val_11 = null;
        string val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  DataStructs.UserDataDictionary.Settings.UserName);
        Utility.SetBoldTextWithBlackOutline(txtObj:  this.nameTxt);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Items.Shells;
        this.shellTxt.text = PlayerPrefsManager.GetShellString(shells:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited}));
        this.nameTxt.gameObject.SetActive(value:  false);
        this.shellTxt.gameObject.SetActive(value:  false);
        this.panel.OnEntryDone.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectUserInfoAnim::OnPanelEnterDone()));
    }
    private void OnDisable()
    {
        this.panel.OnEntryDone.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CharacterSelectUserInfoAnim::OnPanelEnterDone()));
    }
    private void OnPanelEnterDone()
    {
        this.nameTxt.gameObject.SetActive(value:  true);
        this.shellTxt.gameObject.SetActive(value:  true);
        DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOColor(target:  this.nameBG, endValue:  new UnityEngine.Color() {r = this.originNameBGColor}, duration:  0.8f), ease:  30));
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.shell, endValue:  1f, duration:  0.8f), ease:  30));
        float val_14 = 0.05f;
        val_14 = (float)this.nameTxt.Length * val_14;
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOText(target:  this.nameTxt, endValue:  "", duration:  val_14, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0)));
    }
    public CharacterSelectUserInfoAnim()
    {
    
    }

}
