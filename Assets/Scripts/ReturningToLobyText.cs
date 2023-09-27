using UnityEngine;
public class ReturningToLobyText : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text text;
    
    // Methods
    private void OnEnable()
    {
        string val_1 = LanguageManager.GetText(key:  "LK.PostMatch.Returning");
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), loops:  0);
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.ShortcutExtensions46.DOText(target:  this.text, endValue:  val_1 + ".", duration:  1f, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0));
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.ShortcutExtensions46.DOText(target:  this.text, endValue:  val_1 + "..", duration:  1f, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0));
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.ShortcutExtensions46.DOText(target:  this.text, endValue:  val_1 + "...", duration:  1f, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0));
    }
    public ReturningToLobyText()
    {
    
    }

}
