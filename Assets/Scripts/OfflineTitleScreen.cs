using UnityEngine;
public class OfflineTitleScreen : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button m_practice;
    private UnityEngine.UI.Button m_locakVS;
    private NetworkUICharacterAnimation characterAnimController;
    private System.Collections.Generic.List<UnityEngine.UI.Image> gameModeButtons;
    private MotionPanelsControler internetConnectionObject;
    private MotionPanelsControler loginButtonObject;
    
    // Methods
    private void Awake()
    {
        DataStructs.UserDataDictionary.ResetAndEnableSave();
        IWServerDB_Cache.EnableAddToCache(enable:  false);
        IWServerDB_Cache.EnableSaveRoutine(enable:  false);
        CharacterAnimationData val_1 = this.characterAnimController.Character1;
        val_1.Image.gameObject.SetActive(value:  false);
        CharacterAnimationData val_3 = this.characterAnimController.Character2;
        val_3.Image.gameObject.SetActive(value:  false);
    }
    private System.Collections.IEnumerator DelayStartAnimation()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new OfflineTitleScreen.<DelayStartAnimation>d__7();
    }
    private void OnEnable()
    {
        null = null;
        Character_GlobalInfo.isOfflineMode = true;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.DelayStartAnimation());
        this.m_practice.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void OfflineTitleScreen::PracticeModeCliked()));
        this.m_locakVS.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void OfflineTitleScreen::LocalVsClicked()));
        QuickPlayAiSettings.RemoveQuickPlayBot();
    }
    private void OnDisable()
    {
        this.m_practice.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void OfflineTitleScreen::PracticeModeCliked()));
        this.m_locakVS.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void OfflineTitleScreen::LocalVsClicked()));
    }
    public void PracticeModeCliked()
    {
        var val_1;
        GameAudio.PlayButtonSound();
        val_1 = null;
        val_1 = null;
        Character_GlobalInfo.gameMode = 8;
        QuickPlayAiSettings.SetupAndPlayPracticeMode();
    }
    public void LocalVsClicked()
    {
        var val_2;
        GameAudio.PlayButtonSound();
        PlayerPrefsManager.OnlinePVPTime = PlayerPrefsManager.LocalPVPTime;
        val_2 = null;
        val_2 = null;
        Character_GlobalInfo.gameMode = 5;
        AsyncSceneLoader.Load(sceneName:  "CharacterSelect", minimumDelayInSeconds:  0f, showLoadingScreen:  false, autoHideLoadingScreen:  true);
    }
    public OfflineTitleScreen()
    {
        this.gameModeButtons = new System.Collections.Generic.List<UnityEngine.UI.Image>();
    }
    private void <DelayStartAnimation>b__7_0()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
        List.Enumerator<T> val_3 = this.gameModeButtons.GetEnumerator();
        label_6:
        if(((-1726399320) & 1) == 0)
        {
            goto label_4;
        }
        
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  0.InitialType.GetComponent<UnityEngine.CanvasGroup>(), endValue:  1f, duration:  0.6f), delay:  0.2f));
        goto label_6;
        label_4:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Image>::Dispose(), rectTransform:  null, drivenProperties:  null);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.internetConnectionObject.MoveTo(toEnd:  true));
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.loginButtonObject.MoveTo(toEnd:  true));
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void OfflineTitleScreen::<DelayStartAnimation>b__7_1()));
    }
    private void <DelayStartAnimation>b__7_1()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.2f);
        DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.loginButtonObject.GetComponent<UnityEngine.RectTransform>(), punch:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.5f, vibrato:  1, elasticity:  1f), loops:  0, loopType:  1);
    }

}
