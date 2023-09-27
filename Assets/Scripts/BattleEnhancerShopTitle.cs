using UnityEngine;
public class BattleEnhancerShopTitle : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI title;
    private TMPro.TextMeshProUGUI info;
    private BattleEnhancerShopTypeToggleGroup typeSelector;
    
    // Methods
    private void OnEnable()
    {
        if(0 == this.typeSelector)
        {
                return;
        }
        
        this.typeSelector.OnSelectionChange.AddListener(call:  new UnityEngine.Events.UnityAction<InkWars.Model.BattleEnhancerType>(object:  this, method:  public System.Void BattleEnhancerShopTitle::OnEnhancerTypeChange(InkWars.Model.BattleEnhancerType aNewType)));
    }
    private void OnDisable()
    {
        if(0 == this.typeSelector)
        {
                return;
        }
        
        this.typeSelector.OnSelectionChange.RemoveListener(call:  new UnityEngine.Events.UnityAction<InkWars.Model.BattleEnhancerType>(object:  this, method:  public System.Void BattleEnhancerShopTitle::OnEnhancerTypeChange(InkWars.Model.BattleEnhancerType aNewType)));
    }
    public void OnEnhancerTypeChange(InkWars.Model.BattleEnhancerType aNewType)
    {
        this.title.text = LanguageManager.GetText(key:  "Lk.BattleEnhancer." + aNewType);
        this.info.text = LanguageManager.GetText(key:  "Lk.BattleEnhancer." + aNewType + ".dec");
    }
    public BattleEnhancerShopTitle()
    {
    
    }

}
