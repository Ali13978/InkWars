using UnityEngine;
public class PlayerIndicator : MonoBehaviour
{
    // Fields
    private static UnityEngine.Events.UnityEvent OnGameStartAnimation;
    public bool isLeftSide;
    private DG.Tweening.Tweener animTw;
    
    // Methods
    public static void StartFadeAnimation()
    {
        null = null;
        PlayerIndicator.OnGameStartAnimation.Invoke();
    }
    private void OnEnable()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_7 = null;
        val_7 = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
            goto label_15;
        }
        
        if(Character_GlobalInfo.gameMode != 8)
        {
            goto label_4;
        }
        
        if(this.isLeftSide == false)
        {
            goto label_5;
        }
        
        if(DeviceBasedData.playerAtLeftForQuickPlay == true)
        {
            goto label_19;
        }
        
        if(this.isLeftSide == true)
        {
            goto label_15;
        }
        
        label_5:
        if(DeviceBasedData.playerAtLeftForQuickPlay == true)
        {
            goto label_15;
        }
        
        goto label_19;
        label_4:
        if(this.isLeftSide == false)
        {
            goto label_10;
        }
        
        val_8 = null;
        val_8 = null;
        if(DataStructs.UserDataDictionary.Settings.FlipNegateX == 1)
        {
            goto label_19;
        }
        
        if(this.isLeftSide == true)
        {
            goto label_15;
        }
        
        label_10:
        val_9 = null;
        val_9 = null;
        if(DataStructs.UserDataDictionary.Settings.FlipNegateX == 1)
        {
            goto label_19;
        }
        
        label_15:
        this.gameObject.SetActive(value:  false);
        return;
        label_19:
        this.PlayAnim(loops:  0, duration:  0.25f, disableGameObjectAfterDone:  false);
        val_10 = null;
        val_10 = null;
        PlayerIndicator.OnGameStartAnimation.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PlayerIndicator::OnGameAnimation()));
    }
    private void OnDisable()
    {
        null = null;
        PlayerIndicator.OnGameStartAnimation.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PlayerIndicator::OnGameAnimation()));
    }
    private void OnGameAnimation()
    {
        this.Invoke(methodName:  "FadeAnim", time:  2f);
    }
    private void FadeAnim()
    {
        this.PlayAnim(loops:  8, duration:  0.1f, disableGameObjectAfterDone:  true);
    }
    private void PlayAnim(int loops, float duration, bool disableGameObjectAfterDone)
    {
        PlayerIndicator.<>c__DisplayClass8_0 val_1 = new PlayerIndicator.<>c__DisplayClass8_0();
        if(val_1 != null)
        {
                .disableGameObjectAfterDone = disableGameObjectAfterDone;
        }
        else
        {
                mem[24] = disableGameObjectAfterDone;
        }
        
        .<>4__this = this;
        if(this.animTw != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.animTw, complete:  false);
        }
        
        UnityEngine.CanvasGroup val_4 = this.GetComponent<UnityEngine.CanvasGroup>();
        .cg = val_4;
        val_4.alpha = 1f;
        this.animTw = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  (PlayerIndicator.<>c__DisplayClass8_0)[1152921528451048192].cg, endValue:  0f, duration:  duration), ease:  2), loops:  loops, loopType:  1), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PlayerIndicator.<>c__DisplayClass8_0::<PlayAnim>b__0()));
    }
    public PlayerIndicator()
    {
    
    }
    private static PlayerIndicator()
    {
        PlayerIndicator.OnGameStartAnimation = new UnityEngine.Events.UnityEvent();
    }

}
