using UnityEngine;
public class Instance_Manager : MonoBehaviour
{
    // Fields
    private static Instance_Manager _instance;
    
    // Properties
    public static Instance_Manager Instance { get; }
    
    // Methods
    public static Instance_Manager get_Instance()
    {
        Instance_Manager._instance = UnityEngine.Object.FindObjectOfType<Instance_Manager>();
        return (Instance_Manager)Instance_Manager._instance;
    }
    public static T InstantiateOn<T>(T Original)
    {
        UnityEngine.Transform val_2 = Instance_Manager.Instance.transform;
        goto __RuntimeMethodHiddenParam + 48;
    }
    public Instance_Manager()
    {
    
    }

}
