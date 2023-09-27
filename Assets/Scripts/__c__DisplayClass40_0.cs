using UnityEngine;
private sealed class MVCNetworkManager.<>c__DisplayClass40_0
{
    // Fields
    public System.Action actionOnRoomDelete;
    
    // Methods
    public MVCNetworkManager.<>c__DisplayClass40_0()
    {
    
    }
    internal void <CheckRoomStatus>b__0(NFClientUser.NFResponseRoom roomStatusResponse)
    {
        if(roomStatusResponse.IsSuccess != false)
        {
                return;
        }
        
        this.actionOnRoomDelete.Invoke();
    }

}
