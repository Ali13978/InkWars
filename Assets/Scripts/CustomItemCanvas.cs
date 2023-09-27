using UnityEngine;
public class CustomItemCanvas : MonoBehaviour
{
    // Fields
    private static CustomItemCanvas <instance>k__BackingField;
    private CustomItemSelectGrid selectGrid;
    private CustomItemInfoPanel itemInfoPanel;
    private bool savedVIPState;
    private static CustomItemGroupBase <itemGroup>k__BackingField;
    
    // Properties
    public static CustomItemCanvas instance { get; set; }
    public static CustomItemSelectGrid selectionGrid { get; }
    public static CustomItemInfoPanel infoPanel { get; }
    public static CustomItemGroupBase itemGroup { get; set; }
    
    // Methods
    public static CustomItemCanvas get_instance()
    {
        return (CustomItemCanvas)CustomItemCanvas.<instance>k__BackingField;
    }
    protected static void set_instance(CustomItemCanvas value)
    {
        CustomItemCanvas.<instance>k__BackingField = value;
    }
    public static CustomItemSelectGrid get_selectionGrid()
    {
        if((CustomItemCanvas.<instance>k__BackingField) != null)
        {
                return (CustomItemSelectGrid)CustomItemCanvas.<instance>k__BackingField.selectGrid;
        }
        
        return (CustomItemSelectGrid)CustomItemCanvas.<instance>k__BackingField.selectGrid;
    }
    public static CustomItemInfoPanel get_infoPanel()
    {
        if((CustomItemCanvas.<instance>k__BackingField) != null)
        {
                return (CustomItemInfoPanel)CustomItemCanvas.<instance>k__BackingField.itemInfoPanel;
        }
        
        return (CustomItemInfoPanel)CustomItemCanvas.<instance>k__BackingField.itemInfoPanel;
    }
    private void Awake()
    {
    
    }
    private void OnEnable()
    {
        CustomItemCanvas.<instance>k__BackingField = this;
        if((CustomItemCanvas.<itemGroup>k__BackingField) != null)
        {
                this.Refresh();
        }
        
        this.savedVIPState = VIP.isVipActived;
    }
    private void Start()
    {
        this.Setup(type:  1);
    }
    private void Update()
    {
        var val_2 = (this.savedVIPState == true) ? 1 : 0;
        val_2 = VIP.isVipActived ^ val_2;
        if(val_2 == false)
        {
                return;
        }
        
        this.Refresh();
        this.savedVIPState = VIP.isVipActived;
    }
    private void OnDestroy()
    {
        UnityEngine.Object val_2 = this;
        if((CustomItemCanvas.<instance>k__BackingField) != this)
        {
                return;
        }
        
        CustomItemCanvas.<instance>k__BackingField = 0;
    }
    public static CustomItemGroupBase get_itemGroup()
    {
        return (CustomItemGroupBase)CustomItemCanvas.<itemGroup>k__BackingField;
    }
    protected static void set_itemGroup(CustomItemGroupBase value)
    {
        CustomItemCanvas.<itemGroup>k__BackingField = value;
    }
    public void SetupBattleGrid(bool toggleIsOn)
    {
        if(toggleIsOn == false)
        {
                return;
        }
        
        this.Setup(type:  1);
    }
    public void SetupSwitcher(bool toggleIsOn)
    {
        if(toggleIsOn == false)
        {
                return;
        }
        
        this.Setup(type:  3);
    }
    public void SetupBubble(bool toggleIsOn)
    {
        if(toggleIsOn == false)
        {
                return;
        }
        
        this.Setup(type:  4);
    }
    public void Setup(CustomizationButtonGroupCtrl.CustomizationGroup type)
    {
        var val_2;
        CustomItemGroupBase val_3;
        if(type == 4)
        {
            goto label_1;
        }
        
        if(type == 3)
        {
            goto label_2;
        }
        
        if(type != 1)
        {
            goto label_3;
        }
        
        val_2 = 1152921505084960768;
        goto label_5;
        label_1:
        val_2 = 1152921505085014016;
        goto label_5;
        label_2:
        val_2 = 1152921505085067264;
        label_5:
        CustomItemGroupSwitcher val_1 = null;
        val_3 = val_1;
        val_1 = new CustomItemGroupSwitcher();
        goto label_7;
        label_3:
        val_3 = 0;
        goto label_9;
        label_7:
        label_9:
        CustomItemCanvas.<itemGroup>k__BackingField = ;
        this.Refresh();
        this.selectGrid.SelectFirstItem();
    }
    public void Refresh()
    {
        this.selectGrid.Refresh();
        this.itemInfoPanel.Refresh();
    }
    public CustomItemCanvas()
    {
    
    }

}
