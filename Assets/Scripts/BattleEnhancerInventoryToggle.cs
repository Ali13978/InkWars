using UnityEngine;
public class BattleEnhancerInventoryToggle : MonoBehaviour
{
    // Fields
    public InkWars.Model.BattleEnhancerType enhancerType;
    public UnityEngine.UI.Toggle toggleButton;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.UI.Image val_1 = this.toggleButton.GetComponent<UnityEngine.UI.Image>();
        if(0 == val_1)
        {
                return;
        }
        
        val_1.sprite = BattleEnhancerCollection.GetIcon(type:  this.enhancerType, isOpponent:  false);
    }
    public BattleEnhancerInventoryToggle()
    {
    
    }

}
