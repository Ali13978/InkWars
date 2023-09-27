using UnityEngine;
public class Control_Base<T> : MonoBehaviour
{
    // Fields
    public bool IsRightSide;
    internal static Control_Base<T> LeftSide;
    internal static Control_Base<T> RightSide;
    
    // Properties
    internal static InkWars.Model.Model_Core Model { get; }
    public InkWars.Model.Model_Player PlayerModel { get; }
    
    // Methods
    internal static InkWars.Model.Model_Core get_Model()
    {
        if(InkWars.Model.Model_Manager.Instance == 0)
        {
                return 0;
        }
        
        InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
        0 = val_3.Model;
        return 0;
    }
    public InkWars.Model.Model_Player get_PlayerModel()
    {
        if(InkWars.Model.Model_Manager.Instance == 0)
        {
                return 0;
        }
        
        InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
        if(val_3.Model == null)
        {
                return 0;
        }
        
        InkWars.Model.Model_Manager val_4 = InkWars.Model.Model_Manager.Instance;
        if(val_4.Model != null)
        {
                if(val_3 == null)
        {
                return val_4.Model.LeftPlayer;
        }
        
            return val_4.Model.RightPlayer;
        }
        
        if(val_3 != null)
        {
                return val_4.Model.RightPlayer;
        }
        
        return val_4.Model.LeftPlayer;
    }
    internal virtual void Awake()
    {
        var val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 184;
        val_2 = (W21 != 0) ? (val_2 + 8) : (val_2);
        mem2[0] = this;
    }
    internal virtual void Start()
    {
    
    }
    public Control_Base<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }

}
