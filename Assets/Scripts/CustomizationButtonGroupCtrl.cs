using UnityEngine;
public class CustomizationButtonGroupCtrl : MonoBehaviour
{
    // Fields
    private CustomizationButtonGroupCtrl.CustomizationGroup _curr;
    public UnityEngine.CanvasGroup AvatarPanel;
    public UnityEngine.CanvasGroup BattleGridPanel;
    public UnityEngine.CanvasGroup HomebasePanel;
    public UnityEngine.CanvasGroup SwitcherPanel;
    public UnityEngine.CanvasGroup BubblePanel;
    public UnityEngine.CanvasGroup TitlePanel;
    private System.Collections.Generic.List<UnityEngine.CanvasGroup> panelList;
    
    // Properties
    public CustomizationButtonGroupCtrl.CustomizationGroup currentGroup { get; set; }
    
    // Methods
    public CustomizationButtonGroupCtrl.CustomizationGroup get_currentGroup()
    {
        return (CustomizationGroup)this._curr;
    }
    public void set_currentGroup(CustomizationButtonGroupCtrl.CustomizationGroup value)
    {
        this._curr = value;
        this.FadeToGroup(groupType:  value);
    }
    private void Start()
    {
        var val_5;
        System.Collections.Generic.List<UnityEngine.CanvasGroup> val_7;
        this.panelList.Add(item:  this.AvatarPanel);
        this.panelList.Add(item:  this.BattleGridPanel);
        this.panelList.Add(item:  this.HomebasePanel);
        this.panelList.Add(item:  this.SwitcherPanel);
        this.panelList.Add(item:  this.BubblePanel);
        this.panelList.Add(item:  this.TitlePanel);
        val_5 = null;
        val_5 = null;
        if((CustomizationButtonGroupCtrl.<>c.<>9__12_0) == null)
        {
            goto label_9;
        }
        
        label_18:
        int val_1 = this.panelList.RemoveAll(match:  CustomizationButtonGroupCtrl.<>c.<>9__12_0);
        val_7 = this.panelList;
        List.Enumerator<T> val_2 = val_7.GetEnumerator();
        label_14:
        if(((-1876528360) & 1) == 0)
        {
            goto label_12;
        }
        
        0.InitialType.alpha = 0f;
        goto label_14;
        label_9:
        CustomizationButtonGroupCtrl.<>c.<>9__12_0 = new System.Predicate<UnityEngine.CanvasGroup>(object:  CustomizationButtonGroupCtrl.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CustomizationButtonGroupCtrl.<>c::<Start>b__12_0(UnityEngine.CanvasGroup x));
        if(this.panelList != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_12:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.CanvasGroup>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<UnityEngine.CanvasGroup>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
    }
    private void FadeToGroup(CustomizationButtonGroupCtrl.CustomizationGroup groupType)
    {
        var val_8;
        var val_10;
        var val_12;
        val_8 = null;
        val_8 = null;
        if((CustomizationButtonGroupCtrl.<>c.<>9__13_0) == null)
        {
            goto label_3;
        }
        
        label_11:
        List.Enumerator<T> val_2 = this.panelList.FindAll(match:  CustomizationButtonGroupCtrl.<>c.<>9__13_0).GetEnumerator();
        val_10 = 1152921528500097168;
        label_7:
        if(((-1876320120) & 1) == 0)
        {
            goto label_6;
        }
        
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  0.InitialType, endValue:  0f, duration:  0.5f);
        goto label_7;
        label_3:
        CustomizationButtonGroupCtrl.<>c.<>9__13_0 = new System.Predicate<UnityEngine.CanvasGroup>(object:  CustomizationButtonGroupCtrl.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CustomizationButtonGroupCtrl.<>c::<FadeToGroup>b__13_0(UnityEngine.CanvasGroup x));
        if(this.panelList != null)
        {
            goto label_11;
        }
        
        goto label_11;
        label_6:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.CanvasGroup>::Dispose(), rectTransform:  public System.Collections.Generic.List<T> System.Collections.Generic.List<UnityEngine.CanvasGroup>::FindAll(System.Predicate<T> match), drivenProperties:  null);
        if(groupType <= 5)
        {
                var val_8 = 40827008 + (groupType) << 2;
            val_8 = val_8 + 40827008;
        }
        else
        {
                val_12 = 0;
            if(0 == )
        {
                return;
        }
        
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOFade(target:  null, endValue:  1f, duration:  0.5f);
        }
    
    }
    private UnityEngine.CanvasGroup GetCanvasGroup(CustomizationButtonGroupCtrl.CustomizationGroup groupType)
    {
        if(groupType > 5)
        {
                return 0;
        }
        
        var val_1 = 40827032 + (groupType) << 2;
        val_1 = val_1 + 40827032;
        goto (40827032 + (groupType) << 2 + 40827032);
    }
    public void OnBtnAvatarClick()
    {
        this._curr = 0;
        this.FadeToGroup(groupType:  0);
    }
    public void OnBtnBattleGridClick()
    {
        this._curr = 1;
        this.FadeToGroup(groupType:  1);
    }
    public void OnBtnHomebaseClick()
    {
        this._curr = 2;
        this.FadeToGroup(groupType:  2);
    }
    public void OnBtnSwitcherClick()
    {
        this._curr = 3;
        this.FadeToGroup(groupType:  3);
    }
    public void OnBtnBubbleClick()
    {
        this._curr = 4;
        this.FadeToGroup(groupType:  4);
    }
    public void OnBtnTittleClick()
    {
        this._curr = 5;
        this.FadeToGroup(groupType:  5);
    }
    public CustomizationButtonGroupCtrl()
    {
        this.panelList = new System.Collections.Generic.List<UnityEngine.CanvasGroup>();
    }

}
