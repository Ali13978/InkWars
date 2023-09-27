using UnityEngine;
public class CharacterSelectScrollView : MonoBehaviour
{
    // Fields
    public CharacterSelectScrollView.OnSelectionChangedEvent OnSelectionChanged;
    public bool selectDefaultAtStart;
    private CharacterSelectScrollViewItem itemTemplate;
    private UnityEngine.UI.Button leftButton;
    private UnityEngine.UI.Button rightButton;
    private UnityEngine.UI.ScrollRect scrollView;
    private CharacterSelectScrollViewItem selectionItem;
    private System.Collections.Generic.List<CharacterSelectScrollViewItem> items;
    private UnityEngine.UI.Toggle generalButton;
    private float itemPrePage;
    private CharacterNameID[] orderList;
    
    // Properties
    public CharacterNameID selection { get; set; }
    
    // Methods
    public CharacterNameID get_selection()
    {
        CharacterSelectScrollViewItem val_2;
        CharacterNameID val_3;
        val_2 = this;
        if(0 == this.selectionItem)
        {
                val_3 = 983040;
            val_3 = 15;
            return val_3;
        }
        
        val_2 = this.selectionItem;
        val_3 = this.selectionItem.charNameId;
        return val_3;
    }
    public void set_selection(CharacterNameID value)
    {
        .value = value;
        this.ChangeSelection(item:  this.items.Find(match:  new System.Predicate<CharacterSelectScrollViewItem>(object:  new CharacterSelectScrollView.<>c__DisplayClass5_0(), method:  System.Boolean CharacterSelectScrollView.<>c__DisplayClass5_0::<set_selection>b__0(CharacterSelectScrollViewItem x))));
    }
    public void CancelSelection()
    {
        if(0 != this.generalButton)
        {
                if(this.generalButton.isOn == false)
        {
                return;
        }
        
        }
        
        if(0 != this.selectionItem)
        {
                this.selectionItem.EnableBG(enabled:  false);
            this.selectionItem = 0;
        }
        
        if(this.selection == this.selection)
        {
                return;
        }
        
        this.OnSelectionChanged.Invoke(arg0:  this.selection);
    }
    private void Awake()
    {
        var val_20;
        DG.Tweening.IDOTweenInit val_1 = DG.Tweening.DOTween.Init(recycleAllByDefault:  new System.Nullable<System.Boolean>() {HasValue = false}, useSafeMode:  new System.Nullable<System.Boolean>() {HasValue = false}, logBehaviour:  new System.Nullable<DG.Tweening.LogBehaviour>() {HasValue = false});
        this.leftButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void CharacterSelectScrollView::OnScrollLeft()));
        this.rightButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void CharacterSelectScrollView::OnScrollRight()));
        this.DetectItemPrePage();
        this.items.Clear();
        System.Collections.IEnumerator val_8 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_36:
        var val_20 = 0;
        val_20 = val_20 + 1;
        if(val_8.MoveNext() == false)
        {
            goto label_18;
        }
        
        var val_21 = 0;
        val_21 = val_21 + 1;
        object val_12 = val_8.Current;
        if((null == 999999) || ((CharacterHelper.IsHidden(cid:  1152921504628039680)) == true))
        {
            goto label_36;
        }
        
        CharacterSelectScrollViewItem val_16 = UnityEngine.Object.Instantiate<CharacterSelectScrollViewItem>(original:  this.itemTemplate, parent:  this.itemTemplate.transform.parent);
        if(val_16 != null)
        {
                val_16.charNameId = null;
            val_16.<parent>k__BackingField = this;
        }
        else
        {
                mem[24] = null;
            mem[32] = this;
        }
        
        val_16.gameObject.SetActive(value:  true);
        this.items.Add(item:  val_16);
        goto label_36;
        label_18:
        val_20 = 0;
        if(val_8 != null)
        {
                var val_22 = 0;
            val_22 = val_22 + 1;
            val_8.Dispose();
        }
        
        this.SortOrder();
        if(this.selectDefaultAtStart == false)
        {
                return;
        }
        
        this.ChangeSelection(item:  this.items.Item[0]);
    }
    private void OnEnable()
    {
        this.DetectItemPrePage();
    }
    private void DetectItemPrePage()
    {
        float val_12;
        UnityEngine.RectTransform val_1 = this.scrollView.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Rect val_2 = val_1.rect;
        if(val_1 != null)
        {
                UnityEngine.Vector3 val_3 = val_1.localScale;
            val_12 = val_3.x;
        }
        else
        {
                UnityEngine.Vector3 val_4 = val_1.localScale;
            val_12 = val_4.x;
        }
        
        UnityEngine.Rect val_5 = val_1.rect;
        float val_12 = val_5.m_XMin;
        UnityEngine.Vector3 val_6 = val_1.localScale;
        val_12 = val_12 / val_6.y;
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.one;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, d:  val_12);
        this.itemTemplate.GetComponent<UnityEngine.RectTransform>().sizeDelta = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
        this.itemPrePage = (val_2.m_XMin / val_12) / val_12;
    }
    private void SortOrder()
    {
        var val_9;
        var val_10;
        UnityEngine.RectTransform val_11;
        val_9 = this;
        System.Collections.Generic.List<CharacterSelectScrollViewItem> val_1 = new System.Collections.Generic.List<CharacterSelectScrollViewItem>();
        val_10 = 0;
        goto label_1;
        label_10:
        .cid = this.orderList[0];
        CharacterSelectScrollViewItem val_4 = this.items.Find(match:  new System.Predicate<CharacterSelectScrollViewItem>(object:  new CharacterSelectScrollView.<>c__DisplayClass18_0(), method:  System.Boolean CharacterSelectScrollView.<>c__DisplayClass18_0::<SortOrder>b__0(CharacterSelectScrollViewItem x)));
        val_11 = 0;
        if(0 != val_4)
        {
                val_11 = public System.Void System.Collections.Generic.List<CharacterSelectScrollViewItem>::Add(CharacterSelectScrollViewItem item);
            val_1.Add(item:  val_4);
        }
        
        val_10 = 1;
        label_1:
        if(val_10 < this.orderList.Length)
        {
            goto label_10;
        }
        
        this.items.Clear();
        List.Enumerator<T> val_6 = val_1.GetEnumerator();
        var val_10 = 0;
        label_17:
        if(((-1526383320) & 1) == 0)
        {
            goto label_13;
        }
        
        System.Type val_7 = 0.InitialType;
        val_7.transform.SetSiblingIndex(index:  0);
        val_10 = val_10 + 1;
        this.items.Add(item:  val_7);
        goto label_17;
        label_13:
        0.Add(driver:  public System.Void List.Enumerator<CharacterSelectScrollViewItem>::Dispose(), rectTransform:  val_11, drivenProperties:  public System.Void System.Predicate<CharacterSelectScrollViewItem>::.ctor(object object, IntPtr method));
    }
    public void ChangeSelection(CharacterSelectScrollViewItem item)
    {
        if(0 != this.selectionItem)
        {
                this.selectionItem.EnableBG(enabled:  false);
        }
        
        this.selectionItem = item;
        if(0 != item)
        {
                this.selectionItem.EnableBG(enabled:  true);
        }
        
        this.OnSelectionChanged.Invoke(arg0:  this.selection);
        if(0 == this.generalButton)
        {
                return;
        }
        
        this.generalButton.interactable = true;
        this.generalButton.isOn = false;
    }
    public void OnScrollLeft()
    {
        int val_1 = this.items.Count;
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOHorizontalNormalizedPos(target:  this.scrollView, endValue:  UnityEngine.Mathf.Max(a:  0f, b:  this.scrollView.horizontalNormalizedPosition + (-0.3f)), duration:  0.3f, snapping:  false);
    }
    public void OnScrollRight()
    {
        int val_1 = this.items.Count;
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOHorizontalNormalizedPos(target:  this.scrollView, endValue:  UnityEngine.Mathf.Min(a:  1f, b:  this.scrollView.horizontalNormalizedPosition + 0.3f), duration:  0.3f, snapping:  false);
    }
    public CharacterSelectScrollView()
    {
        this.OnSelectionChanged = new CharacterSelectScrollView.OnSelectionChangedEvent();
        this.selectDefaultAtStart = true;
        this.items = new System.Collections.Generic.List<CharacterSelectScrollViewItem>();
        this.itemPrePage = 10f;
        this.orderList = new CharacterNameID[40];
    }

}
