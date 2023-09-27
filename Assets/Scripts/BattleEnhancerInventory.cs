using UnityEngine;
public class BattleEnhancerInventory : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform panel;
    private static BattleEnhancerInventory _inst;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button showInfoButton;
    private UnityEngine.UI.Button hideInfoButton;
    private UnityEngine.GameObject InfoPanel;
    private UnityEngine.CanvasGroup fadeGroup;
    private DG.Tweening.Tweener fadeAnim;
    
    // Properties
    private static BattleEnhancerInventory instance { get; }
    
    // Methods
    private static BattleEnhancerInventory get_instance()
    {
        BattleEnhancerInventory val_5 = BattleEnhancerInventory._inst;
        if(0 != val_5)
        {
                return (BattleEnhancerInventory)BattleEnhancerInventory._inst;
        }
        
        BattleEnhancerInventory._inst = UnityEngine.Object.Instantiate<BattleEnhancerInventory>(original:  UnityEngine.Resources.Load<BattleEnhancerInventory>(path:  "DynamicUI/BattleEnhancerInventoryCanvas"));
        val_5 = BattleEnhancerInventory._inst.gameObject;
        val_5.SetActive(value:  false);
        return (BattleEnhancerInventory)BattleEnhancerInventory._inst;
    }
    public static void Show()
    {
        BattleEnhancerInventory.instance.gameObject.SetActive(value:  true);
    }
    public static void Hide()
    {
        BattleEnhancerInventory.instance.Close(onDone:  0, onPreClose:  0);
    }
    private void OnEnable()
    {
        if(0 == BattleEnhancerInventory._inst)
        {
                BattleEnhancerInventory._inst = this;
        }
        
        if(0 != this.closeButton)
        {
                this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerInventory::OnClose()));
            this.closeButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerInventory::OnClose()));
        }
        
        this.showInfoButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerInventory::ShowInfo()));
        this.hideInfoButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerInventory::HideInfo()));
        this.Open();
    }
    private void OnDisable()
    {
        if(0 != this.closeButton)
        {
                this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerInventory::OnClose()));
        }
        
        this.showInfoButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerInventory::ShowInfo()));
        this.hideInfoButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerInventory::HideInfo()));
    }
    private void ShowInfo()
    {
        var val_13;
        this.showInfoButton.GetComponent<UnityEngine.Animator>().enabled = false;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        this.showInfoButton.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        val_13 = null;
        val_13 = null;
        DataStructs.UserDataDictionary.GameSave.EnhancerInfoPlayed = true;
        this.InfoPanel.gameObject.SetActive(value:  true);
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
        this.InfoPanel.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.InfoPanel.GetComponent<UnityEngine.Transform>(), endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.5f), ease:  27);
    }
    private void HideInfo()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.InfoPanel.GetComponent<UnityEngine.Transform>(), endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  27);
    }
    public void Open()
    {
        var val_11;
        if(this.fadeAnim != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.fadeAnim, complete:  false);
        }
        
        if(0 != this.fadeGroup)
        {
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.panel.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            this.fadeAnim = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.panel.GetComponent<UnityEngine.Transform>(), endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.5f), ease:  27);
        }
        
        val_11 = null;
        val_11 = null;
        this.showInfoButton.GetComponent<UnityEngine.Animator>().enabled = (~DataStructs.UserDataDictionary.GameSave.EnhancerInfoPlayed) & 1;
    }
    private void OnClose()
    {
        GameAudio.PlayButtonSound();
        this.Close(onDone:  new System.Action(object:  this, method:  System.Void BattleEnhancerInventory::<OnClose>b__17_0()), onPreClose:  0);
    }
    public void Close(System.Action onDone, System.Action onPreClose)
    {
        var val_10;
        UnityEngine.CanvasGroup val_11;
        BattleEnhancerInventory.<>c__DisplayClass18_0 val_1 = new BattleEnhancerInventory.<>c__DisplayClass18_0();
        if(val_1 != null)
        {
                val_10 = val_1;
            .onDone = onDone;
        }
        else
        {
                val_10 = 16;
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
        
        val_11 = this.fadeGroup;
        if(0 != val_11)
        {
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            val_11 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.panel.GetComponent<UnityEngine.Transform>(), endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.5f), ease:  26);
            this.fadeAnim = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  val_11, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void BattleEnhancerInventory.<>c__DisplayClass18_0::<Close>b__0()));
            return;
        }
        
        if(val_10 == 0)
        {
                return;
        }
        
        val_10.Invoke();
        this.fadeGroup.gameObject.SetActive(value:  false);
    }
    public BattleEnhancerInventory()
    {
    
    }
    private void <OnClose>b__17_0()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
