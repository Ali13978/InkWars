using UnityEngine;
public class BattleEnhancerToggleGroupCtrl : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.ToggleGroup toggleGroup;
    private System.Collections.Generic.List<BattleEnhancerLevelPanel> levelPanelList;
    private System.Collections.Generic.List<BattleEnhancerInventoryToggle> toggleList;
    private BattleEnhancerInventoryToggle defaultToggle;
    private TMPro.TextMeshProUGUI nameTxt;
    private TMPro.TextMeshProUGUI descTxt;
    
    // Methods
    private void Start()
    {
        var val_5;
        object val_14;
        var val_15;
        var val_17;
        BattleEnhancerInventoryToggle val_19;
        val_14 = this;
        val_15 = null;
        val_15 = null;
        if((BattleEnhancerToggleGroupCtrl.<>c.<>9__6_0) == null)
        {
            goto label_3;
        }
        
        label_21:
        int val_1 = this.levelPanelList.RemoveAll(match:  BattleEnhancerToggleGroupCtrl.<>c.<>9__6_0);
        val_17 = null;
        val_17 = null;
        if((BattleEnhancerToggleGroupCtrl.<>c.<>9__6_1) == null)
        {
            goto label_7;
        }
        
        label_25:
        int val_2 = this.toggleList.RemoveAll(match:  BattleEnhancerToggleGroupCtrl.<>c.<>9__6_1);
        List.Enumerator<T> val_3 = this.toggleList.GetEnumerator();
        label_17:
        if(((-1498965712) & 1) == 0)
        {
            goto label_10;
        }
        
        UnityEngine.Events.UnityAction<System.Boolean> val_7 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void BattleEnhancerToggleGroupCtrl::OnToggleChanged(bool isOn));
        BattleEnhancerToggleGroupCtrl.<>c.<>9__6_1 + 240.RemoveListener(call:  null);
        UnityEngine.Events.UnityAction<System.Boolean> val_8 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void BattleEnhancerToggleGroupCtrl::OnToggleChanged(bool isOn));
        BattleEnhancerToggleGroupCtrl.<>c.<>9__6_1 + 240 + 240.AddListener(call:  null);
        val_5.InitialType.group = this.toggleGroup;
        goto label_17;
        label_3:
        BattleEnhancerToggleGroupCtrl.<>c.<>9__6_0 = new System.Predicate<BattleEnhancerLevelPanel>(object:  BattleEnhancerToggleGroupCtrl.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattleEnhancerToggleGroupCtrl.<>c::<Start>b__6_0(BattleEnhancerLevelPanel x));
        if(this.levelPanelList != null)
        {
            goto label_21;
        }
        
        goto label_21;
        label_7:
        BattleEnhancerToggleGroupCtrl.<>c.<>9__6_1 = new System.Predicate<BattleEnhancerInventoryToggle>(object:  BattleEnhancerToggleGroupCtrl.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattleEnhancerToggleGroupCtrl.<>c::<Start>b__6_1(BattleEnhancerInventoryToggle x));
        if(this.toggleList != null)
        {
            goto label_25;
        }
        
        goto label_25;
        label_10:
        val_5.Add(driver:  public System.Void List.Enumerator<BattleEnhancerInventoryToggle>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<BattleEnhancerInventoryToggle>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
        if(0 != this.defaultToggle)
        {
            goto label_39;
        }
        
        if(this.toggleList.Count < 1)
        {
                return;
        }
        
        val_19 = this.toggleList.Item[0];
        if(val_19 != null)
        {
            goto label_45;
        }
        
        goto label_44;
        label_39:
        val_19 = this.defaultToggle;
        if(val_19 != null)
        {
            goto label_45;
        }
        
        label_44:
        label_45:
        val_14 = this.defaultToggle.toggleButton;
        val_14.isOn = true;
    }
    private void OnToggleChanged(bool isOn)
    {
        TMPro.TextMeshProUGUI val_16;
        TMPro.TextMeshProUGUI val_17;
        var val_18;
        val_16 = isOn;
        val_17 = this;
        if(val_16 == false)
        {
                return;
        }
        
        .activedToggle = System.Linq.Enumerable.ElementAt<UnityEngine.UI.Toggle>(source:  this.toggleGroup.ActiveToggles(), index:  0);
        if(0 == (this.toggleList.Find(match:  new System.Predicate<BattleEnhancerInventoryToggle>(object:  new BattleEnhancerToggleGroupCtrl.<>c__DisplayClass7_0(), method:  System.Boolean BattleEnhancerToggleGroupCtrl.<>c__DisplayClass7_0::<OnToggleChanged>b__0(BattleEnhancerInventoryToggle x)))))
        {
                UnityEngine.Debug.LogError(message:  "Cannot find active toggle for battle enhancer");
            return;
        }
        
        val_18 = 1;
        goto label_10;
        label_15:
        this.levelPanelList.Item[-1498619984].Setup(aNewType:  val_5.enhancerType, aNewLevelStartFrom1:  1);
        val_18 = 2;
        label_10:
        if((val_18 - 1) < this.levelPanelList.Count)
        {
            goto label_15;
        }
        
        BattleEnhancerAssets val_10 = BattleEnhancerCollection.Get(type:  val_5.enhancerType);
        if(0 != this.nameTxt)
        {
                this.nameTxt.text = LanguageManager.GetText(key:  "Lk.BattleEnhancer." + val_5.enhancerType);
        }
        
        val_16 = this.descTxt;
        if(0 == val_16)
        {
                return;
        }
        
        val_17 = this.descTxt;
        val_17.text = LanguageManager.GetText(key:  "Lk.BattleEnhancer." + val_5.enhancerType + ".dec");
    }
    public BattleEnhancerToggleGroupCtrl()
    {
        this.levelPanelList = new System.Collections.Generic.List<BattleEnhancerLevelPanel>();
        this.toggleList = new System.Collections.Generic.List<BattleEnhancerInventoryToggle>();
    }

}
