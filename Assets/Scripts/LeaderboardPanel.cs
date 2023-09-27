using UnityEngine;
public class LeaderboardPanel : MonoBehaviour
{
    // Fields
    private static LeaderboardPanel inst;
    public static LeaderboardPanel temp;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.CanvasGroup alphaGroup;
    
    // Methods
    public static LeaderboardPanel Show()
    {
        LeaderboardPanel val_7;
        var val_8;
        if(0 != LeaderboardPanel.inst)
        {
                LeaderboardPanel.inst.gameObject.SetActive(value:  false);
            val_7 = LeaderboardPanel.inst.gameObject;
            val_7.SetActive(value:  true);
            return (LeaderboardPanel)LeaderboardPanel.inst;
        }
        
        if(0 == LeaderboardPanel.temp)
        {
                val_8 = null;
            LeaderboardPanel.temp = UnityEngine.Resources.Load<LeaderboardPanel>(path:  "DynamicUI/LeaderBoardCanvas");
        }
        else
        {
                val_8 = null;
        }
        
        val_7 = LeaderboardPanel.temp;
        LeaderboardPanel.inst = UnityEngine.Object.Instantiate<LeaderboardPanel>(original:  val_7);
        return (LeaderboardPanel)LeaderboardPanel.inst;
    }
    private void Awake()
    {
        if(0 == LeaderboardPanel.inst)
        {
                LeaderboardPanel.inst = this;
        }
        
        this.alphaGroup = this.GetComponent<UnityEngine.CanvasGroup>();
    }
    private void OnEnable()
    {
        if(0 != this.closeButton)
        {
                this.closeButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void LeaderboardPanel::Close()));
        }
        
        this.Open();
    }
    private void OnDisable()
    {
        if(0 == this.closeButton)
        {
                return;
        }
        
        this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void LeaderboardPanel::Close()));
    }
    public void Open()
    {
        this.alphaGroup.alpha = 0f;
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.alphaGroup, endValue:  1f, duration:  0.5f);
    }
    public void Close()
    {
        GameAudio.PlayButtonSound();
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.alphaGroup, endValue:  0f, duration:  0.5f), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void LeaderboardPanel::<Close>b__9_0()));
    }
    public LeaderboardPanel()
    {
    
    }
    private void <Close>b__9_0()
    {
        this.gameObject.SetActive(value:  false);
    }

}
