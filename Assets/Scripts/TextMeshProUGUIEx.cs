using UnityEngine;
public static class TextMeshProUGUIEx
{
    // Methods
    public static DG.Tweening.Tweener DOText(TMPro.TMP_Text target, string endValue, float duration, bool richTextEnabled = True, DG.Tweening.ScrambleMode scrambleMode = 0, string scrambleChars)
    {
        var val_12;
        UnityEngine.UI.Text val_13;
        UnityEngine.UI.Text val_14;
        TextMeshProUGUIEx.<>c__DisplayClass0_0 val_1 = new TextMeshProUGUIEx.<>c__DisplayClass0_0();
        .target = target;
        UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "TMP_DOText");
        if(val_1 != null)
        {
                val_12 = val_1;
            .obj = val_2;
        }
        else
        {
                val_12 = 32;
            mem[32] = val_2;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        val_2.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        val_13 = val_2.AddComponent<UnityEngine.UI.Text>();
        if(val_1 != null)
        {
                val_14 = val_1;
            .txt = val_13;
        }
        else
        {
                val_14 = 24;
            mem[24] = val_13;
            val_13 = mem[24];
        }
        
        string val_6 = (TextMeshProUGUIEx.<>c__DisplayClass0_0)[1152921529069954432].target.text;
        return DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOText(target:  val_14, endValue:  endValue, duration:  duration, richTextEnabled:  richTextEnabled, scrambleMode:  scrambleMode, scrambleChars:  scrambleChars), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void TextMeshProUGUIEx.<>c__DisplayClass0_0::<DOText>b__0())), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void TextMeshProUGUIEx.<>c__DisplayClass0_0::<DOText>b__1()));
    }

}
