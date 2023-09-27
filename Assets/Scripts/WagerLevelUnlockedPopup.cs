using UnityEngine;
public class WagerLevelUnlockedPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject m_blueBackground;
    private UnityEngine.GameObject m_redBackground;
    private TMPro.TextMeshProUGUI m_wagerCount;
    private TMPro.TextMeshProUGUI m_prizeCount;
    private TMPro.TextMeshProUGUI m_levelCount;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.AudioClip sfx;
    protected static WagerLevelUnlockedPopup _inst;
    
    // Properties
    protected static WagerLevelUnlockedPopup instance { get; }
    
    // Methods
    protected static WagerLevelUnlockedPopup get_instance()
    {
        var val_7;
        WagerLevelUnlockedPopup val_8;
        var val_9;
        var val_10;
        val_7 = null;
        val_7 = null;
        val_8 = WagerLevelUnlockedPopup._inst;
        if(0 == val_8)
        {
                val_9 = null;
            val_9 = null;
            WagerLevelUnlockedPopup._inst = UnityEngine.Object.Instantiate<WagerLevelUnlockedPopup>(original:  UnityEngine.Resources.Load<WagerLevelUnlockedPopup>(path:  "DynamicUI/"("DynamicUI/") + System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())(System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))));
            val_8 = WagerLevelUnlockedPopup._inst.gameObject;
            val_8.SetActive(value:  false);
        }
        
        val_10 = null;
        val_10 = null;
        return (WagerLevelUnlockedPopup)WagerLevelUnlockedPopup._inst;
    }
    public static void Show(int unlockedLevel, decimal wagerCount, decimal prizeCount)
    {
        var val_19;
        var val_20;
        var val_21;
        DG.Tweening.TweenCallback val_23;
        val_19 = 1152921505122234368;
        WagerLevelUnlockedPopup val_1 = WagerLevelUnlockedPopup.instance;
        val_1.m_wagerCount.text = wagerCount.flags.ToString();
        WagerLevelUnlockedPopup val_3 = WagerLevelUnlockedPopup.instance;
        val_3.m_prizeCount.text = prizeCount.flags.ToString();
        WagerLevelUnlockedPopup val_5 = WagerLevelUnlockedPopup.instance;
        val_5.m_levelCount.text = unlockedLevel.ToString();
        if(unlockedLevel < 6)
        {
                WagerLevelUnlockedPopup val_7 = WagerLevelUnlockedPopup.instance;
            val_7.m_redBackground.gameObject.SetActive(value:  false);
            WagerLevelUnlockedPopup val_9 = WagerLevelUnlockedPopup.instance;
            UnityEngine.GameObject val_10 = val_9.m_blueBackground.gameObject;
            val_20 = 1;
        }
        else
        {
                WagerLevelUnlockedPopup val_11 = WagerLevelUnlockedPopup.instance;
            val_11.m_redBackground.gameObject.SetActive(value:  true);
            WagerLevelUnlockedPopup val_13 = WagerLevelUnlockedPopup.instance;
            val_20 = 0;
        }
        
        val_13.m_blueBackground.gameObject.SetActive(value:  false);
        DG.Tweening.Sequence val_15 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_15, interval:  0.5f);
        val_21 = null;
        val_21 = null;
        val_23 = WagerLevelUnlockedPopup.<>c.<>9__10_0;
        if(val_23 == null)
        {
                DG.Tweening.TweenCallback val_17 = null;
            val_23 = val_17;
            val_17 = new DG.Tweening.TweenCallback(object:  WagerLevelUnlockedPopup.<>c.__il2cppRuntimeField_static_fields, method:  System.Void WagerLevelUnlockedPopup.<>c::<Show>b__10_0());
            WagerLevelUnlockedPopup.<>c.<>9__10_0 = val_23;
        }
        
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_15, callback:  val_17);
    }
    protected virtual void OnEnable()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.5f), ease:  27), isIndependentUpdate:  true);
        this.closeButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void WagerLevelUnlockedPopup::ClosePopup()));
    }
    protected virtual void OnDisable()
    {
        this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void WagerLevelUnlockedPopup::ClosePopup()));
    }
    public void ClosePopup()
    {
        DG.Tweening.Sequence val_1 = this.Close();
    }
    public DG.Tweening.Sequence Close()
    {
        GameAudio.PlayButtonSound();
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.5f), ease:  26)), isIndependentUpdate:  true);
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void WagerLevelUnlockedPopup::<Close>b__14_0()));
        return val_1;
    }
    public WagerLevelUnlockedPopup()
    {
    
    }
    private static WagerLevelUnlockedPopup()
    {
    
    }
    private void <Close>b__14_0()
    {
        UnityEngine.Time.timeScale = 1f;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
