using UnityEngine;
public class LoginTitleAnimationController : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform titleLogo;
    private UnityEngine.Vector3 originLogoPos;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Vector2 val_1 = this.titleLogo.anchoredPosition;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        this.originLogoPos = val_2;
        mem[1152921528251408452] = val_2.y;
        mem[1152921528251408456] = val_2.z;
    }
    public void ShowLogo(float duration, System.Action onDone)
    {
        .onDone = onDone;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.originLogoPos, y = V9.16B, z = V10.16B});
        this.titleLogo.anchoredPosition = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.titleLogo, endValue:  500f, duration:  duration, snapping:  false)), ease:  27), action:  new DG.Tweening.TweenCallback(object:  new LoginTitleAnimationController.<>c__DisplayClass3_0(), method:  System.Void LoginTitleAnimationController.<>c__DisplayClass3_0::<ShowLogo>b__0()));
    }
    public void HideLogo(float duration, System.Action onDone, float startDelay = 0)
    {
        .onDone = onDone;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.titleLogo, endValue:  500f, duration:  duration, snapping:  false), ease:  26), delay:  startDelay), action:  new DG.Tweening.TweenCallback(object:  new LoginTitleAnimationController.<>c__DisplayClass4_0(), method:  System.Void LoginTitleAnimationController.<>c__DisplayClass4_0::<HideLogo>b__0()));
    }
    public LoginTitleAnimationController()
    {
    
    }

}
