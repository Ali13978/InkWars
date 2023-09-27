using UnityEngine;
public class StageSelectionController : MonoBehaviour
{
    // Fields
    private StageItem template;
    public float swipeAnimationDuration;
    public DG.Tweening.Ease swipeInEase;
    public DG.Tweening.Ease swipeOutEase;
    private System.Collections.Generic.List<int> _allStageIds;
    private System.Collections.Generic.List<StageItem> items;
    private bool <isPlayingAnim>k__BackingField;
    private int _selectionId;
    private UnityEngine.RectTransform stageImageRoot;
    public StageSelectionController.StageSelectionEvents events;
    
    // Properties
    private System.Collections.Generic.List<int> allStageIds { get; }
    private UnityEngine.Vector2 centerImageScale { get; }
    private UnityEngine.Vector2 sideImageScale { get; }
    private float sideImageAlpha { get; }
    public bool isPlayingAnim { get; set; }
    public int selectedStageId { get; }
    public bool isSelectionOwned { get; }
    public StageData selectedStageData { get; }
    private int selectionId { get; set; }
    
    // Methods
    private void OnEnable()
    {
        var val_4;
        System.Action<Lean.Touch.LeanFinger> val_5;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Combine(a:  Lean.Touch.LeanTouch.OnFingerSwipe, b:  new System.Action<Lean.Touch.LeanFinger>(object:  this, method:  public System.Void StageSelectionController::OnFingerSwipe(Lean.Touch.LeanFinger finger)))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        Lean.Touch.LeanTouch.OnFingerSwipe = val_5;
    }
    private void OnDisable()
    {
        var val_4;
        System.Action<Lean.Touch.LeanFinger> val_5;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Remove(source:  Lean.Touch.LeanTouch.OnFingerSwipe, value:  new System.Action<Lean.Touch.LeanFinger>(object:  this, method:  public System.Void StageSelectionController::OnFingerSwipe(Lean.Touch.LeanFinger finger)))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        Lean.Touch.LeanTouch.OnFingerSwipe = val_5;
    }
    private System.Collections.Generic.List<int> get_allStageIds()
    {
        System.Collections.Generic.List<System.Int32> val_2;
        var val_3;
        val_2 = this._allStageIds;
        if(val_2 != null)
        {
                return val_1;
        }
        
        val_3 = null;
        val_3 = null;
        System.Collections.Generic.List<System.Int32> val_1 = GameInfo.stage.GetAllUniqueIds();
        this._allStageIds = val_1;
        return val_1;
    }
    private UnityEngine.Vector2 get_centerImageScale()
    {
        UnityEngine.Vector3 val_2 = this.template.GetComponent<UnityEngine.RectTransform>().localScale;
        return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
    }
    private UnityEngine.Vector2 get_sideImageScale()
    {
        UnityEngine.Vector2 val_1 = this.centerImageScale;
        return UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  0.733f);
    }
    private float get_sideImageAlpha()
    {
        return 0.8f;
    }
    public bool get_isPlayingAnim()
    {
        return (bool)this.<isPlayingAnim>k__BackingField;
    }
    protected void set_isPlayingAnim(bool value)
    {
        this.<isPlayingAnim>k__BackingField = value;
    }
    public int get_selectedStageId()
    {
        System.Collections.Generic.List<System.Int32> val_1 = this.allStageIds;
        if(val_1 != null)
        {
                return val_1.Item[this._selectionId];
        }
        
        return val_1.Item[this._selectionId];
    }
    public bool get_isSelectionOwned()
    {
        null = null;
        int val_2 = this.allStageIds.Item[this._selectionId];
        if(GameInfo.stage == null)
        {
            
        }
    
    }
    public StageData get_selectedStageData()
    {
        null = null;
        if(GameInfo.stage != null)
        {
                return GameInfo.stage.GetItemDataById(uniqueId:  this.selectedStageId);
        }
        
        return GameInfo.stage.GetItemDataById(uniqueId:  this.selectedStageId);
    }
    private int get_selectionId()
    {
        return (int)this._selectionId;
    }
    private void set_selectionId(int value)
    {
        int val_9;
        System.Collections.Generic.List<System.Int32> val_1 = this.allStageIds;
        this._selectionId = value;
        int val_3 = this.allStageIds.Count;
        val_9 = value - ((value / val_3) * val_3);
        this._selectionId = val_9;
        if((val_9 & 2147483648) != 0)
        {
                val_9 = this.allStageIds.Count + val_9;
            this._selectionId = val_9;
        }
        
        if(this.events == null)
        {
                val_9 = this._selectionId;
        }
        
        this.events.OnSelectionChanged.Invoke(arg0:  val_9);
        this.events.OnSelectionOwnedChanged.Invoke(arg0:  this.isSelectionOwned);
    }
    private void Awake()
    {
        var val_23;
        var val_24;
        this.items = new System.Collections.Generic.List<StageItem>();
        UnityEngine.RectTransform val_2 = this.template.GetComponent<UnityEngine.RectTransform>();
        val_23 = 0;
        goto label_2;
        label_28:
        StageItem val_3 = UnityEngine.Object.Instantiate<StageItem>(original:  this.template);
        val_3.transform.SetParent(p:  this.stageImageRoot.transform);
        UnityEngine.Vector2 val_7 = val_2.anchoredPosition;
        val_3.rectTrasform.anchoredPosition = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
        UnityEngine.Vector2 val_9 = val_2.sizeDelta;
        val_3.rectTrasform.sizeDelta = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        UnityEngine.Vector2 val_11 = this.sideImageScale;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
        val_3.rectTrasform.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        val_3.gameObject.SetActive(value:  true);
        val_3.SetupStage(stageId:  this.allStageIds.Item[0]);
        this.items.Add(item:  val_3);
        val_3.gameObject.name = System.String.Format(format:  "Stage_{0}-{1}", arg0:  0.ToString(), arg1:  val_3.stageNameText.text);
        val_23 = 1;
        label_2:
        if(val_23 < this.allStageIds.Count)
        {
            goto label_28;
        }
        
        val_24 = 0;
        goto label_29;
        label_31:
        this.SetHideStyleImageById(id:  0);
        val_24 = 1;
        label_29:
        if(val_24 < this.items.Count)
        {
            goto label_31;
        }
        
        this.SelectById(id:  this._selectionId);
    }
    public void OnFingerSwipe(Lean.Touch.LeanFinger finger)
    {
        if((this.<isPlayingAnim>k__BackingField) == true)
        {
                return;
        }
        
        UnityEngine.Vector2 val_1 = finger.SwipeScreenDelta;
        if(val_1.x < 0)
        {
                this.SelectById(id:  this._selectionId + 1);
            this.PlaySwipeAnimation(direction:  0);
        }
        
        if(val_1.x <= System.Math.Abs(val_1.y))
        {
                return;
        }
        
        this.SelectById(id:  this._selectionId - 1);
        this.PlaySwipeAnimation(direction:  1);
    }
    public void SetActive(bool active)
    {
        this.gameObject.SetActive(value:  active);
    }
    private void SwipeStage(StageSelectionController.SwipeStageDirection direction)
    {
        int val_1 = this._selectionId;
        if(direction == 1)
        {
            goto label_0;
        }
        
        if(direction != 0)
        {
            goto label_2;
        }
        
        val_1 = val_1 + 1;
        goto label_2;
        label_0:
        val_1 = val_1 - 1;
        label_2:
        this.SelectById(id:  val_1);
        this.PlaySwipeAnimation(direction:  direction);
    }
    private void SetHideStyleImageById(int id)
    {
        int val_16 = id;
        int val_1 = this.items.Count;
        int val_2 = val_16 / val_1;
        val_2 = val_16 - (val_2 * val_1);
        val_16 = (val_1 & (val_2 >> 31)) + val_2;
        UnityEngine.Vector2 val_6 = this.sideImageScale;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        this.items.Item[val_16].rectTrasform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        this.items.Item[val_16].rectTrasform.SetAsFirstSibling();
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
        this.items.Item[val_16].rectTrasform.anchoredPosition = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
        this.items.Item[val_16].SetAlpha(alpha:  0f);
        StageItem val_14 = this.items.Item[val_16];
        val_14.stageNameText.gameObject.SetActive(value:  false);
    }
    private void SelectById(int id)
    {
        this.SetHideStyleImageById(id:  this._selectionId);
        this.selectionId = id;
        UnityEngine.Vector2 val_3 = this.centerImageScale;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        this.items.Item[this._selectionId].rectTrasform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        this.items.Item[this._selectionId].rectTrasform.SetAsLastSibling();
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
        this.items.Item[this._selectionId].rectTrasform.anchoredPosition = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        this.items.Item[this._selectionId].SetAlpha(alpha:  1f);
        StageItem val_11 = this.items.Item[this._selectionId];
        val_11.stageNameText.gameObject.SetActive(value:  true);
        int val_55 = this._selectionId;
        int val_58 = this.items.Item[this._selectionId].rectTrasform.GetSiblingIndex();
        int val_16 = this.items.Count;
        int val_17 = val_55 - 1;
        int val_18 = val_17 / val_16;
        val_17 = val_17 - (val_18 * val_16);
        val_18 = val_16 & (val_17 >> 31);
        val_55 = val_18 + val_17;
        int val_19 = val_58 - 1;
        this.items.Item[val_55].rectTrasform.SetSiblingIndex(index:  val_19);
        UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  -400f, y:  0f);
        this.items.Item[val_55].rectTrasform.anchoredPosition = new UnityEngine.Vector2() {x = val_24.x, y = val_24.y};
        this.items.Item[val_55].SetAlpha(alpha:  0.8f);
        System.Collections.Generic.List<StageItem> val_56 = this.items;
        int val_26 = val_56.Count;
        int val_27 = this._selectionId + 1;
        int val_28 = val_27 / val_26;
        val_27 = val_27 - (val_28 * val_26);
        val_28 = val_26 & (val_27 >> 31);
        val_56 = val_28 + val_27;
        this.items.Item[val_56].rectTrasform.SetSiblingIndex(index:  val_19);
        UnityEngine.Vector2 val_33 = new UnityEngine.Vector2(x:  400f, y:  0f);
        this.items.Item[val_56].rectTrasform.anchoredPosition = new UnityEngine.Vector2() {x = val_33.x, y = val_33.y};
        this.items.Item[val_56].SetAlpha(alpha:  0.8f);
        System.Collections.Generic.List<StageItem> val_57 = this.items;
        int val_35 = val_57.Count;
        int val_36 = this._selectionId - 2;
        int val_37 = val_36 / val_35;
        val_36 = val_36 - (val_37 * val_35);
        val_37 = val_35 & (val_36 >> 31);
        val_57 = val_37 + val_36;
        this.SetHideStyleImageById(id:  val_57);
        UnityEngine.Vector2 val_42 = this.items.Item[val_55].rectTrasform.anchoredPosition;
        this.items.Item[val_57].rectTrasform.anchoredPosition = new UnityEngine.Vector2() {x = val_42.x, y = val_42.y};
        val_58 = val_58 - 3;
        this.items.Item[val_57].rectTrasform.SetSiblingIndex(index:  val_58);
        System.Collections.Generic.List<StageItem> val_59 = this.items;
        int val_45 = val_59.Count;
        int val_46 = this._selectionId + 2;
        int val_47 = val_46 / val_45;
        val_46 = val_46 - (val_47 * val_45);
        val_47 = val_45 & (val_46 >> 31);
        val_59 = val_47 + val_46;
        this.SetHideStyleImageById(id:  val_59);
        UnityEngine.Vector2 val_52 = this.items.Item[val_56].rectTrasform.anchoredPosition;
        this.items.Item[val_59].rectTrasform.anchoredPosition = new UnityEngine.Vector2() {x = val_52.x, y = val_52.y};
        this.items.Item[val_59].rectTrasform.SetSiblingIndex(index:  val_58);
    }
    private void PlaySwipeAnimation(StageSelectionController.SwipeStageDirection direction)
    {
        this.<isPlayingAnim>k__BackingField = true;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector2 val_4 = this.sideImageScale;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.items.Item[this._selectionId].rectTrasform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  this.swipeAnimationDuration)), ease:  this.swipeInEase));
        var val_10 = (direction == 1) ? 1 : 0;
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.items.Item[this._selectionId].rectTrasform, endValue:  40828456 + direction == 0x1 ? 1 : 0, duration:  this.swipeAnimationDuration, snapping:  false)), ease:  this.swipeInEase));
        System.Collections.Generic.List<StageItem> val_60 = this.items;
        var val_17 = (direction == 0) ? (-1) : 1;
        int val_18 = this._selectionId + val_17;
        int val_19 = val_60.Count;
        int val_20 = val_18 / val_19;
        val_20 = val_18 - (val_20 * val_19);
        val_17 = val_19 & (val_20 >> 31);
        val_60 = val_17 + val_20;
        UnityEngine.Vector2 val_23 = this.centerImageScale;
        UnityEngine.Vector3 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y});
        DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.items.Item[val_60].rectTrasform, endValue:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, duration:  this.swipeAnimationDuration)), ease:  30));
        DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.items.Item[val_60].rectTrasform, endValue:  0f, duration:  this.swipeAnimationDuration, snapping:  false)), ease:  this.swipeOutEase));
        StageItem val_35 = this.items.Item[val_60];
        DG.Tweening.Sequence val_39 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  val_35.stageImage, endValue:  1f, duration:  this.swipeAnimationDuration)), ease:  this.swipeOutEase));
        StageItem val_40 = this.items.Item[val_60];
        val_40.stageNameText.gameObject.SetActive(value:  false);
        System.Collections.Generic.List<StageItem> val_61 = this.items;
        var val_42 = (direction == 0) ? (-2) : 2;
        int val_43 = this._selectionId + val_42;
        int val_44 = val_61.Count;
        int val_45 = val_43 / val_44;
        val_45 = val_43 - (val_45 * val_44);
        val_42 = val_44 & (val_45 >> 31);
        val_61 = val_42 + val_45;
        DG.Tweening.Sequence val_50 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.items.Item[val_61].canvasGroup, endValue:  0.8f, duration:  this.swipeAnimationDuration)));
        StageItem val_51 = this.items.Item[this._selectionId];
        val_51.stageNameText.gameObject.SetActive(value:  true);
        StageItem val_53 = this.items.Item[this._selectionId];
        DG.Tweening.Sequence val_57 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  TextMeshProUGUIEx.DOText(target:  val_53.stageNameText, endValue:  "", duration:  this.swipeAnimationDuration, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0)), ease:  this.swipeInEase));
        DG.Tweening.Sequence val_59 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void StageSelectionController::<PlaySwipeAnimation>b__40_0()));
    }
    private int GetRangedId(int id, int listCount)
    {
        int val_1 = id / listCount;
        val_1 = id - (val_1 * listCount);
        return (int)(listCount & (val_1 >> 31)) + val_1;
    }
    public StageSelectionController()
    {
        this.swipeAnimationDuration = 0.5f;
        this.swipeInEase = 3;
        this.swipeOutEase = 3;
        this.events = new StageSelectionController.StageSelectionEvents();
    }
    private void <PlaySwipeAnimation>b__40_0()
    {
        this.<isPlayingAnim>k__BackingField = false;
    }

}
