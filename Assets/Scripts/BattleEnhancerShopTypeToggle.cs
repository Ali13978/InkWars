using UnityEngine;
public class BattleEnhancerShopTypeToggle : MonoBehaviour
{
    // Fields
    public InkWars.Model.BattleEnhancerType enhancerType;
    public BattleEnhancerShopTypeToggleGroup selectionGroup;
    private UnityEngine.RectTransform activeBGTransform;
    private UnityEngine.RectTransform deactiveBGTransform;
    private UnityEngine.UI.Image iconSmall;
    private UnityEngine.UI.Image iconLarge;
    private UnityEngine.UI.Toggle <targetToggle>k__BackingField;
    private UnityEngine.RectTransform rootTransform;
    
    // Properties
    public UnityEngine.UI.Toggle targetToggle { get; set; }
    
    // Methods
    public UnityEngine.UI.Toggle get_targetToggle()
    {
        return (UnityEngine.UI.Toggle)this.<targetToggle>k__BackingField;
    }
    private void set_targetToggle(UnityEngine.UI.Toggle value)
    {
        this.<targetToggle>k__BackingField = value;
    }
    private void Awake()
    {
        this.<targetToggle>k__BackingField = this.GetComponent<UnityEngine.UI.Toggle>();
        this.rootTransform = this.GetComponent<UnityEngine.RectTransform>();
        this.OnToggleChanged(isOn:  this.<targetToggle>k__BackingField.isOn);
        UnityEngine.Sprite val_5 = BattleEnhancerCollection.GetIcon(type:  this.enhancerType, isOpponent:  false);
        this.iconSmall.sprite = val_5;
        this.iconLarge.sprite = val_5;
    }
    private void Start()
    {
        this.<targetToggle>k__BackingField.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void BattleEnhancerShopTypeToggle::OnToggleChanged(bool isOn)));
        if(0 == this.selectionGroup)
        {
                return;
        }
        
        this.selectionGroup.toggleList.Add(item:  this);
        this.<targetToggle>k__BackingField.group = this.selectionGroup.<toggleGroup>k__BackingField;
    }
    private void OnDestroy()
    {
        this.<targetToggle>k__BackingField.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void BattleEnhancerShopTypeToggle::OnToggleChanged(bool isOn)));
        if(0 == this.selectionGroup)
        {
                return;
        }
        
        bool val_3 = this.selectionGroup.toggleList.Remove(item:  this);
    }
    private void OnToggleChanged(bool isOn)
    {
        if((0 != this.selectionGroup) && (isOn != false))
        {
                this.selectionGroup.selection = this.enhancerType;
        }
        
        UnityEngine.Vector2 val_3 = (isOn != true) ? this.activeBGTransform : this.deactiveBGTransform.sizeDelta;
        this.rootTransform.sizeDelta = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        mem[this.activeBGTransform].gameObject.SetActive(value:  isOn);
        mem[this.deactiveBGTransform].gameObject.SetActive(value:  (~isOn) & 1);
    }
    public BattleEnhancerShopTypeToggle()
    {
    
    }

}
