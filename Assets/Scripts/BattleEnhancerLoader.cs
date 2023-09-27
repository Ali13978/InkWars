using UnityEngine;
public class BattleEnhancerLoader : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button m_battleEnhancerButton;
    
    // Methods
    private void OnEnable()
    {
        this.m_battleEnhancerButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerLoader::LoadbattleEnhancer()));
    }
    private void OnDisable()
    {
        this.m_battleEnhancerButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerLoader::LoadbattleEnhancer()));
    }
    private void LoadbattleEnhancer()
    {
        BattleEnhancerInventory.Show();
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public BattleEnhancerLoader()
    {
    
    }

}
