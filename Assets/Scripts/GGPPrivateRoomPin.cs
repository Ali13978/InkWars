using UnityEngine;
public class GGPPrivateRoomPin : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI pinTxt;
    
    // Methods
    private void OnEnable()
    {
        InkWars.Model.MVC_Multiplayer_Manager_Base val_1 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
        val_1.OnCreatePrivateRoomAction = new System.Action<System.String>(object:  this, method:  System.Void GGPPrivateRoomPin::<OnEnable>b__1_0(string pin));
    }
    private void OnDisable()
    {
        InkWars.Model.MVC_Multiplayer_Manager_Base val_1 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
        val_1.OnCreatePrivateRoomAction = 0;
    }
    public GGPPrivateRoomPin()
    {
    
    }
    private void <OnEnable>b__1_0(string pin)
    {
        this.pinTxt.text = pin;
    }

}
