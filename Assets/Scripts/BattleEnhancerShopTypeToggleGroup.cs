using UnityEngine;
public class BattleEnhancerShopTypeToggleGroup : MonoBehaviour
{
    // Fields
    public InkWars.Model.BattleEnhancerType defaultSelection;
    private InkWars.Model.BattleEnhancerType _select;
    public BattleEnhancerShopTypeToggleGroup.BattleEnhancerTypeSelectionChangeEvent OnSelectionChange;
    public System.Collections.Generic.List<BattleEnhancerShopTypeToggle> toggleList;
    private UnityEngine.UI.ToggleGroup <toggleGroup>k__BackingField;
    
    // Properties
    public InkWars.Model.BattleEnhancerType selection { get; set; }
    public UnityEngine.UI.ToggleGroup toggleGroup { get; set; }
    
    // Methods
    public InkWars.Model.BattleEnhancerType get_selection()
    {
        return (InkWars.Model.BattleEnhancerType)this._select;
    }
    public void set_selection(InkWars.Model.BattleEnhancerType value)
    {
        this._select = value;
        this.Select(type:  value);
        this.OnSelectionChange.Invoke(arg0:  value);
    }
    public UnityEngine.UI.ToggleGroup get_toggleGroup()
    {
        return (UnityEngine.UI.ToggleGroup)this.<toggleGroup>k__BackingField;
    }
    public void set_toggleGroup(UnityEngine.UI.ToggleGroup value)
    {
        this.<toggleGroup>k__BackingField = value;
    }
    private void Awake()
    {
        this.<toggleGroup>k__BackingField = this.GetComponent<UnityEngine.UI.ToggleGroup>();
    }
    private void Start()
    {
        this.selection = this.defaultSelection;
    }
    private void Select(InkWars.Model.BattleEnhancerType type)
    {
        .type = type;
        if(0 == (this.toggleList.Find(match:  new System.Predicate<BattleEnhancerShopTypeToggle>(object:  new BattleEnhancerShopTypeToggleGroup.<>c__DisplayClass14_0(), method:  System.Boolean BattleEnhancerShopTypeToggleGroup.<>c__DisplayClass14_0::<Select>b__0(BattleEnhancerShopTypeToggle x)))))
        {
                .type.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  public System.Void System.Predicate<BattleEnhancerShopTypeToggle>::.ctor(object object, IntPtr method));
            mem[1152921528883970960] = null;
            UnityEngine.Debug.LogError(message:  "Select Battle Enhancer Type Fail: cannot find toggle by type "("Select Battle Enhancer Type Fail: cannot find toggle by type ") + .type.ToString());
            return;
        }
        
        if((val_3.<targetToggle>k__BackingField.isOn) != false)
        {
                return;
        }
        
        val_3.<targetToggle>k__BackingField.isOn = true;
    }
    public BattleEnhancerShopTypeToggleGroup()
    {
        this.defaultSelection = 1;
        this.OnSelectionChange = new BattleEnhancerShopTypeToggleGroup.BattleEnhancerTypeSelectionChangeEvent();
        this.toggleList = new System.Collections.Generic.List<BattleEnhancerShopTypeToggle>();
    }

}
