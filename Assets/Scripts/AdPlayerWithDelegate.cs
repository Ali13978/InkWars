using UnityEngine;
[Serializable]
public class AdPlayerWithDelegate
{
    // Fields
    private UnityEngine.UI.Button m_AdPlayerButton;
    private UnityEngine.Events.UnityAction m_OnAdCompleted;
    private UnityEngine.Events.UnityAction m_OnAdFailed;
    private bool m_IsAdPlayingReturnWithOnPlayFail;
    private bool m_IsAdPlaying;
    
    // Properties
    public bool IsAdPlaying { get; set; }
    
    // Methods
    public bool get_IsAdPlaying()
    {
        return (bool)this.m_IsAdPlaying;
    }
    public void set_IsAdPlaying(bool value)
    {
        this.m_IsAdPlaying = value;
    }
    private void Start()
    {
        this.m_IsAdPlaying = false;
    }
    private void OnEnable()
    {
        if(0 == this.m_AdPlayerButton)
        {
                return;
        }
        
        this.m_AdPlayerButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void AdPlayerWithDelegate::PlayAd()));
    }
    private void OnDisable()
    {
        if(0 == this.m_AdPlayerButton)
        {
                return;
        }
        
        this.m_AdPlayerButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void AdPlayerWithDelegate::PlayAd()));
    }
    public void Setup(UnityEngine.Events.UnityAction _onPlayDoneAction, UnityEngine.Events.UnityAction _onPlayFailAction, bool _isAdPlayingReturnWithOnPlayFail = False)
    {
        this.m_OnAdCompleted = _onPlayDoneAction;
        this.m_OnAdFailed = _onPlayFailAction;
        this.m_IsAdPlayingReturnWithOnPlayFail = _isAdPlayingReturnWithOnPlayFail;
    }
    public void PlayAd()
    {
        T[] val_1 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogFormat(format:  "#### Processing ad ####", args:  val_1);
        if(this.m_OnAdCompleted == null)
        {
                return;
        }
        
        this.ProcessAd(_onPlayDoneAction:  val_1, _onPlayFailAction:  this.m_OnAdFailed, _isAdPlayingReturnWithOnPlayFail:  this.m_IsAdPlayingReturnWithOnPlayFail);
    }
    private void ProcessAd(UnityEngine.Events.UnityAction _onPlayDoneAction, UnityEngine.Events.UnityAction _onPlayFailAction, bool _isAdPlayingReturnWithOnPlayFail = False)
    {
        if(this.m_IsAdPlaying != false)
        {
                this = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogFormat(format:  "#### As is already playing - Exiting with  ####", args:  this);
            if(_isAdPlayingReturnWithOnPlayFail == false)
        {
                return;
        }
        
            _onPlayFailAction.Invoke();
            return;
        }
        
        this.m_IsAdPlaying = true;
    }
    private void PlayUnityAd()
    {
    
    }
    public AdPlayerWithDelegate()
    {
    
    }

}
