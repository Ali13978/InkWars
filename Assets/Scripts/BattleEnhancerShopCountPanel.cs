using UnityEngine;
public class BattleEnhancerShopCountPanel : MonoBehaviour
{
    // Fields
    private InkWars.Model.BattleEnhancerType _curr;
    private System.Collections.Generic.List<TMPro.TextMeshProUGUI> textList;
    private BattleEnhancerShopTypeToggleGroup toggleGroup;
    
    // Properties
    public InkWars.Model.BattleEnhancerType currentType { get; set; }
    
    // Methods
    public InkWars.Model.BattleEnhancerType get_currentType()
    {
        return (InkWars.Model.BattleEnhancerType)this._curr;
    }
    public void set_currentType(InkWars.Model.BattleEnhancerType value)
    {
        this._curr = value;
        this.Refresh();
    }
    private void OnEnable()
    {
        if(0 == this.toggleGroup)
        {
                return;
        }
        
        this.toggleGroup.OnSelectionChange.AddListener(call:  new UnityEngine.Events.UnityAction<InkWars.Model.BattleEnhancerType>(object:  this, method:  public System.Void BattleEnhancerShopCountPanel::OnEnhancerTypeChange(InkWars.Model.BattleEnhancerType aNewType)));
    }
    private void OnDisable()
    {
        if(0 == this.toggleGroup)
        {
                return;
        }
        
        this.toggleGroup.OnSelectionChange.RemoveListener(call:  new UnityEngine.Events.UnityAction<InkWars.Model.BattleEnhancerType>(object:  this, method:  public System.Void BattleEnhancerShopCountPanel::OnEnhancerTypeChange(InkWars.Model.BattleEnhancerType aNewType)));
    }
    public void OnEnhancerTypeChange(InkWars.Model.BattleEnhancerType aNewType)
    {
        this._curr = aNewType;
        this.Refresh();
    }
    public void Refresh()
    {
        int val_7;
        var val_8;
        object val_7 = 1;
        do
        {
            val_7 = val_7 - 1;
            if(this.textList.Count > val_7)
        {
                if(0 != this.textList.Item[val_7])
        {
                val_8 = null;
            val_8 = null;
            val_7 = this.textList.Item[val_7];
            val_7.text = System.String.Format(format:  "Lv {0}\r\n<size=120%>x{1}</size>", arg0:  val_7, arg1:  DataStructs.UserDataDictionary.Items.GetEnhancerCount(type:  this._curr, level:  1, defaultValue:  0));
        }
        
        }
        
            val_7 = val_7 + 1;
        }
        while(val_7 != 7);
    
    }
    public BattleEnhancerShopCountPanel()
    {
        this.textList = new System.Collections.Generic.List<TMPro.TextMeshProUGUI>();
    }

}
