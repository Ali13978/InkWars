using UnityEngine;
public class NetworkBehaviour_SelectStage : NetworkBehaviour
{
    // Fields
    public UnityEngine.GameObject textSelectStage;
    public UnityEngine.GameObject rightArrow;
    public UnityEngine.GameObject leftArrow;
    public UnityEngine.GameObject confirmMapTick;
    
    // Methods
    private void Start()
    {
        if((NetworkManager_Custom.stringRPCMessageId + 264) != 0)
        {
                return;
        }
        
        this.textSelectStage.SetActive(value:  false);
        this.rightArrow.SetActive(value:  false);
        this.leftArrow.SetActive(value:  false);
        this.confirmMapTick.SetActive(value:  false);
    }
    public NetworkBehaviour_SelectStage()
    {
    
    }
    private void UNetVersion()
    {
    
    }
    public override bool OnSerialize(UnityEngine.Networking.NetworkWriter writer, bool forceAll)
    {
        return false;
    }
    public override void OnDeserialize(UnityEngine.Networking.NetworkReader reader, bool initialState)
    {
    
    }

}
