using UnityEngine;
public class PostMatchEnhancerData : MonoBehaviour
{
    // Fields
    public InkWars.Model.BattleEnhancerType PlayerType;
    public InkWars.Model.BattleEnhancerType OpponentType;
    public int PlayerLevel;
    public int OpponentLevel;
    
    // Methods
    private void OnEnable()
    {
        InkWars.Model.Model_Events.Instance.add_OnBattleEnhancer(value:  new Model_Events.OnBattleEnhancerDelegate(object:  this, method:  System.Void PostMatchEnhancerData::OnBattleEnhancer(float timeStamp, InkWars.Model.Player aNePlayerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)));
    }
    private void OnDisable()
    {
        InkWars.Model.Model_Events.Instance.remove_OnBattleEnhancer(value:  new Model_Events.OnBattleEnhancerDelegate(object:  this, method:  System.Void PostMatchEnhancerData::OnBattleEnhancer(float timeStamp, InkWars.Model.Player aNePlayerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)));
    }
    private void OnBattleEnhancer(float timeStamp, InkWars.Model.Player aNePlayerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)
    {
        if(state != 1)
        {
                return;
        }
        
        if(aNePlayerId != 0)
        {
                this.OpponentType = type;
            this.OpponentLevel = level;
            return;
        }
        
        this.PlayerType = type;
        this.PlayerLevel = level;
    }
    public PostMatchEnhancerData()
    {
    
    }

}
