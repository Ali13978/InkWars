using UnityEngine;
public class MatchFoundCanvas : MonoBehaviour
{
    // Fields
    private static MatchFoundCanvas _inst;
    private UnityEngine.GameObject title;
    private UnityEngine.GameObject mainPanel;
    private UnityEngine.GameObject practiceTitle;
    private UnityEngine.GameObject wageringoff;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.CanvasGroup fadeGroup;
    private UnityEngine.AudioClip m_audioClip;
    private UnityEngine.AudioClip m_newChallengerAudioClip;
    private MotionPanelsControler newChallengerPanelAnim;
    private DG.Tweening.Tweener fadeAnim;
    private const int m_waitingTime = 3;
    private System.Action m_onComple;
    private bool m_flag;
    private float waitedTime;
    
    // Properties
    private static MatchFoundCanvas instance { get; }
    
    // Methods
    private static MatchFoundCanvas get_instance()
    {
        var val_5;
        int val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = MatchFoundCanvas.m_waitingTime;
        if(0 == val_6)
        {
                val_7 = null;
            val_7 = null;
            MatchFoundCanvas.m_waitingTime = UnityEngine.Object.Instantiate<MatchFoundCanvas>(original:  UnityEngine.Resources.Load<MatchFoundCanvas>(path:  "DynamicUI/MatchFoundCanvas"));
            val_6 = MatchFoundCanvas.m_waitingTime.gameObject;
            val_6.SetActive(value:  false);
        }
        
        val_8 = null;
        val_8 = null;
        return (MatchFoundCanvas)MatchFoundCanvas.m_waitingTime;
    }
    public static void Show(NetworkUserInfo sharedPlayerData, bool isPracticeMode = False, System.Action action, bool isNewChallenger = False)
    {
        NetworkUserInfo val_30;
        var val_31;
        DG.Tweening.TweenCallback val_33;
        MatchFoundCanvas.<>c__DisplayClass3_0 val_1 = new MatchFoundCanvas.<>c__DisplayClass3_0();
        if(val_1 != null)
        {
                val_30 = val_1;
            .sharedPlayerData = sharedPlayerData;
        }
        else
        {
                val_30 = 16;
            mem[16] = sharedPlayerData;
        }
        
        .isNewChallenger = isNewChallenger;
        MatchFoundCanvas val_3 = MatchFoundCanvas.instance;
        val_3.m_flag = false;
        MatchFoundCanvas val_4 = MatchFoundCanvas.instance;
        val_4.m_onComple = action;
        MatchFoundCanvas.instance.SetPracticeMode(practiceMode:  isPracticeMode);
        MatchFoundCanvas.instance.gameObject.SetActive(value:  true);
        MatchFoundCanvas val_9 = MatchFoundCanvas.instance;
        val_9.mainPanel.gameObject.SetActive(value:  false);
        if(((MatchFoundCanvas.<>c__DisplayClass3_0)[1152921528713351584].isNewChallenger) != false)
        {
                DG.Tweening.Sequence val_11 = DG.Tweening.DOTween.Sequence();
            val_31 = null;
            val_31 = null;
            val_33 = MatchFoundCanvas.<>c.<>9__3_0;
            if(val_33 == null)
        {
                DG.Tweening.TweenCallback val_12 = null;
            val_33 = val_12;
            val_12 = new DG.Tweening.TweenCallback(object:  MatchFoundCanvas.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MatchFoundCanvas.<>c::<Show>b__3_0());
            MatchFoundCanvas.<>c.<>9__3_0 = val_33;
        }
        
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_11, callback:  val_12);
            MatchFoundCanvas val_14 = MatchFoundCanvas.instance;
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_11, t:  val_14.newChallengerPanelAnim.MovetoEnd());
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_11, interval:  3f);
            MatchFoundCanvas val_18 = MatchFoundCanvas.instance;
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_11, t:  val_18.newChallengerPanelAnim.MovetoStart());
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_11, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MatchFoundCanvas.<>c__DisplayClass3_0::<Show>b__1()));
            return;
        }
        
        MatchFoundCanvas val_23 = MatchFoundCanvas.instance;
        val_23.mainPanel.gameObject.SetActive(value:  true);
        MatchFoundCanvas.instance.GetComponentInChildren<MatchFoundPanel>().SetUp(sharedPlayerData:  val_30);
        MatchFoundCanvas val_27 = MatchFoundCanvas.instance;
        val_27.m_flag = true;
        MatchFoundCanvas.instance.Open(isNewChallenger:  (((MatchFoundCanvas.<>c__DisplayClass3_0)[1152921528713351584].isNewChallenger) == true) ? 1 : 0);
    }
    public static void Hide()
    {
        MatchFoundCanvas.instance.Close(onDone:  0, onPreClose:  0);
    }
    private void OnEnable()
    {
        var val_7;
        var val_8;
        val_7 = null;
        val_7 = null;
        if(0 == MatchFoundCanvas.m_waitingTime)
        {
                val_8 = null;
            val_8 = null;
            MatchFoundCanvas.m_waitingTime = this;
        }
        
        if(0 == this.closeButton)
        {
                return;
        }
        
        this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void MatchFoundCanvas::OnClose()));
        this.closeButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void MatchFoundCanvas::OnClose()));
    }
    private void OnDisable()
    {
        if(0 == this.closeButton)
        {
                return;
        }
        
        this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void MatchFoundCanvas::OnClose()));
    }
    private void Update()
    {
        if(this.m_flag == false)
        {
            goto label_7;
        }
        
        if(this.waitedTime < 3f)
        {
                if((UnityEngine.Input.GetKeyDown(key:  27)) == false)
        {
            goto label_3;
        }
        
        }
        
        if(this.m_onComple != null)
        {
                this.m_onComple.Invoke();
        }
        
        this.waitedTime = 0f;
        this.m_flag = false;
        MatchFoundCanvas.Hide();
        goto label_7;
        label_3:
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.waitedTime + val_2;
        this.waitedTime = val_2;
        label_7:
        ActiveCanvasController val_3 = ActiveCanvasController.Instance;
        if(val_3.isCryptoPublicLobby != false)
        {
                return;
        }
        
        this.wageringoff.SetActive(value:  false);
    }
    public void Open(bool isNewChallenger = False)
    {
        this.waitedTime = 0f;
        if(isNewChallenger != true)
        {
                UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.m_audioClip, volume:  1f);
        }
        
        if(this.fadeAnim != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.fadeAnim, complete:  false);
        }
        
        if(0 != this.fadeGroup)
        {
                this.fadeGroup.alpha = 0f;
            this.fadeAnim = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.fadeGroup, endValue:  1f, duration:  0.5f);
        }
        
        this.BlinkWageringOff();
    }
    private void OnClose()
    {
        this.Close(onDone:  0, onPreClose:  0);
    }
    public void Close(System.Action onDone, System.Action onPreClose)
    {
        var val_8;
        UnityEngine.CanvasGroup val_9;
        MatchFoundCanvas.<>c__DisplayClass24_0 val_1 = new MatchFoundCanvas.<>c__DisplayClass24_0();
        if(val_1 != null)
        {
                val_8 = val_1;
            .onDone = onDone;
        }
        else
        {
                val_8 = 16;
            mem[16] = onDone;
        }
        
        .<>4__this = this;
        if(onPreClose != null)
        {
                onPreClose.Invoke();
        }
        
        if(this.fadeAnim != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.fadeAnim, complete:  false);
        }
        
        val_9 = this.fadeGroup;
        if(0 != val_9)
        {
                val_9 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.fadeGroup, endValue:  0f, duration:  0.5f);
            this.fadeAnim = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  val_9, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MatchFoundCanvas.<>c__DisplayClass24_0::<Close>b__0()));
            return;
        }
        
        if(val_8 == 0)
        {
                return;
        }
        
        val_8.Invoke();
        this.fadeGroup.gameObject.SetActive(value:  false);
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public void SetPracticeMode(bool practiceMode)
    {
        this.title.gameObject.SetActive(value:  (~practiceMode) & 1);
        bool val_3 = practiceMode;
        this.practiceTitle.SetActive(value:  val_3);
        this.wageringoff.SetActive(value:  val_3);
        ActiveCanvasController val_4 = ActiveCanvasController.Instance;
        if(val_4.isCryptoPublicLobby != true)
        {
                this.wageringoff.SetActive(value:  false);
        }
        
        this.BlinkWageringOff();
    }
    private void BlinkWageringOff()
    {
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), loops:  0);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void MatchFoundCanvas::<BlinkWageringOff>b__26_0()));
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.3f);
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void MatchFoundCanvas::<BlinkWageringOff>b__26_1()));
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.1f);
    }
    public MatchFoundCanvas()
    {
    
    }
    private static MatchFoundCanvas()
    {
    
    }
    private void <BlinkWageringOff>b__26_0()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.wageringoff)) == false)
        {
                return;
        }
        
        this.wageringoff.gameObject.SetActive(value:  true);
    }
    private void <BlinkWageringOff>b__26_1()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.wageringoff)) == false)
        {
                return;
        }
        
        this.wageringoff.gameObject.SetActive(value:  false);
    }

}
