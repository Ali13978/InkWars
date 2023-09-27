using UnityEngine;
public class MusicTitlePopup : MonoBehaviour
{
    // Fields
    private static UnityEngine.Events.UnityEvent GameplayStart_FadeOut;
    private static UnityEngine.Events.UnityEvent GameSceneActivator_FadeIn;
    public UnityEngine.UI.Text musicTitleText;
    public UnityEngine.RectTransform targetTransform;
    private UnityEngine.CanvasGroup canvasGroup;
    
    // Methods
    public static void GameplayStart_FadeOutCalled()
    {
        null = null;
        MusicTitlePopup.GameplayStart_FadeOut.Invoke();
    }
    public static void GameSceneActivator_FadeInCalled()
    {
        var val_2;
        if(BattleVSGates.instance == 0)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        MusicTitlePopup.GameSceneActivator_FadeIn.Invoke();
    }
    private void Awake()
    {
        this.canvasGroup = this.GetComponent<UnityEngine.CanvasGroup>();
    }
    private void OnEnable()
    {
        null = null;
        MusicTitlePopup.GameplayStart_FadeOut.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void MusicTitlePopup::FadeOut()));
        MusicTitlePopup.GameSceneActivator_FadeIn.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void MusicTitlePopup::FadeIn()));
    }
    private void OnDisable()
    {
        null = null;
        MusicTitlePopup.GameplayStart_FadeOut.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void MusicTitlePopup::FadeOut()));
        MusicTitlePopup.GameSceneActivator_FadeIn.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void MusicTitlePopup::FadeIn()));
    }
    public void SetupMusicData(MusicData data)
    {
        UnityEngine.UI.Text val_5;
        if(data != null)
        {
                val_5 = this.musicTitleText;
            if(0 != val_5)
        {
                val_5 = this.musicTitleText;
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  data);
        }
        
            if(BattleVSGates.instance != 0)
        {
                return;
        }
        
            this.FadeIn();
            return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void FadeIn()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        if(0 != this.targetTransform)
        {
                DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.targetTransform, endValue:  0f, duration:  0.5f, snapping:  false), ease:  6));
        }
        
        if(0 == this.musicTitleText)
        {
                return;
        }
        
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOText(target:  this.musicTitleText, endValue:  "", duration:  0.8f, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0)));
    }
    private void FadeOut()
    {
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  0f, duration:  1f), delay:  0f), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void MusicTitlePopup::<FadeOut>b__12_0()));
    }
    public MusicTitlePopup()
    {
    
    }
    private static MusicTitlePopup()
    {
        MusicTitlePopup.GameplayStart_FadeOut = new UnityEngine.Events.UnityEvent();
        MusicTitlePopup.GameSceneActivator_FadeIn = new UnityEngine.Events.UnityEvent();
    }
    private void <FadeOut>b__12_0()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
