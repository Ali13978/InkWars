using UnityEngine;
public class BattleEnhancerCharBubbleUI : Control_Base<BattleEnhancerCharBubbleUI>
{
    // Fields
    public System.Collections.Generic.List<InkWars.Model.BattleEnhancerType> trackedType;
    private UnityEngine.CanvasGroup bubbleUI;
    private UnityEngine.UI.Image icon;
    private UnityEngine.UI.Image block;
    private UnityEngine.UI.Image bubbleBG;
    private DG.Tweening.Sequence flashAnim;
    
    // Methods
    internal override void Start()
    {
        this.Start();
        this.bubbleUI.alpha = 0f;
        if(UnityEngine.Application.isEditor == true)
        {
                return;
        }
        
        InkWars.Model.Model_Manager val_2 = InkWars.Model.Model_Manager.Instance;
        if(val_2.Model.Feature_BattleEnhancer != false)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    private void OnEnable()
    {
        InkWars.Model.Model_Events.Instance.add_OnBattleEnhancer(value:  new Model_Events.OnBattleEnhancerDelegate(object:  this, method:  System.Void BattleEnhancerCharBubbleUI::OnBattleEnhancer(float timeStamp, InkWars.Model.Player aNePlayerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)));
        InkWars.Model.Model_Events.Instance.add_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void BattleEnhancerCharBubbleUI::OnGameResult(InkWars.Model.GameResult result, bool afterFinished)));
    }
    private void OnDisable()
    {
        InkWars.Model.Model_Events.Instance.remove_OnBattleEnhancer(value:  new Model_Events.OnBattleEnhancerDelegate(object:  this, method:  System.Void BattleEnhancerCharBubbleUI::OnBattleEnhancer(float timeStamp, InkWars.Model.Player aNePlayerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)));
        InkWars.Model.Model_Events.Instance.remove_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void BattleEnhancerCharBubbleUI::OnGameResult(InkWars.Model.GameResult result, bool afterFinished)));
    }
    private void OnGameResult(InkWars.Model.GameResult result, bool afterFinished)
    {
        if(afterFinished != false)
        {
                return;
        }
        
        this.Stop();
    }
    private void OnBattleEnhancer(float timeStamp, InkWars.Model.Player aNePlayerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)
    {
        InkWars.Model.Model_Player val_1 = this.PlayerModel;
        if(val_1.ID != aNePlayerId)
        {
                return;
        }
        
        if(state != 2)
        {
                if(state != 1)
        {
                return;
        }
        
            this.Play();
            return;
        }
        
        this.Stop();
    }
    public void Play()
    {
        var val_29;
        var val_31;
        InkWars.Model.Model_Player val_1 = this.PlayerModel;
        if(this.PlayerModel == null)
        {
            goto label_2;
        }
        
        if(val_1.BattleEnhancerType != 0)
        {
            goto label_3;
        }
        
        return;
        label_2:
        if(val_1.BattleEnhancerType == 0)
        {
                return;
        }
        
        label_3:
        int val_29 = val_2.BattleEnhancerLevel;
        if((val_29 - 1) > 5)
        {
                return;
        }
        
        val_29 = null;
        val_29 = null;
        if((BattleEnhancerCharBubbleUI.<>c.<>9__11_0) == null)
        {
            goto label_9;
        }
        
        label_24:
        int val_4 = this.trackedType.RemoveAll(match:  BattleEnhancerCharBubbleUI.<>c.<>9__11_0);
        if((this.trackedType.Contains(item:  val_1.BattleEnhancerType)) == false)
        {
                return;
        }
        
        this.icon.sprite = BattleEnhancerCollection.GetIcon(type:  val_1.BattleEnhancerType, isOpponent:  true);
        this.bubbleBG.sprite = BattleEnhancerCollection.GetChatBubbleBG(enhancerType:  val_1.BattleEnhancerType);
        this.block.gameObject.SetActive(value:  BattleEnhancerCollection.GetIsDebuffType(type:  val_1.BattleEnhancerType));
        if((val_1.BattleEnhancerType - 1) > 4)
        {
            goto label_19;
        }
        
        val_31 = mem[40826176 + ((val_1.BattleEnhancerType - 1)) << 2];
        val_31 = 40826176 + ((val_1.BattleEnhancerType - 1)) << 2;
        goto label_20;
        label_9:
        BattleEnhancerCharBubbleUI.<>c.<>9__11_0 = new System.Predicate<InkWars.Model.BattleEnhancerType>(object:  BattleEnhancerCharBubbleUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattleEnhancerCharBubbleUI.<>c::<Play>b__11_0(InkWars.Model.BattleEnhancerType x));
        if(this.trackedType != null)
        {
            goto label_24;
        }
        
        goto label_24;
        label_19:
        val_31 = 10;
        label_20:
        val_29 = (UnityEngine.Mathf.Clamp(value:  val_29, min:  1, max:  6)) * 10;
        if(this.flashAnim != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.flashAnim, complete:  false);
        }
        
        float val_30 = (float)val_29;
        val_30 = val_30 * 1.5f;
        float val_31 = -4.5f;
        this.flashAnim = DG.Tweening.DOTween.Sequence();
        val_31 = val_30 + val_31;
        this.bubbleUI.alpha = 1f;
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.flashAnim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.bubbleUI, endValue:  0.4f, duration:  0.8f), loops:  UnityEngine.Mathf.RoundToInt(f:  val_31 / 0.8f), loopType:  1), ease:  2));
        DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.flashAnim, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void BattleEnhancerCharBubbleUI::<Play>b__11_1()));
        DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.flashAnim, t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.bubbleUI, endValue:  0.2f, duration:  0.1f), loops:  UnityEngine.Mathf.RoundToInt(f:  45f), loopType:  1));
        DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.flashAnim, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.bubbleUI, endValue:  0f, duration:  0.1f));
    }
    public void Stop()
    {
        if(this.flashAnim != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.flashAnim, complete:  false);
        }
        
        this.bubbleUI.alpha = 0f;
    }
    public BattleEnhancerCharBubbleUI()
    {
        this.trackedType = new System.Collections.Generic.List<InkWars.Model.BattleEnhancerType>();
    }
    private void <Play>b__11_1()
    {
        this.bubbleUI.alpha = 1f;
    }

}
