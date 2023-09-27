using UnityEngine;
private sealed class MVCNetworkManager.<>c__DisplayClass37_0
{
    // Fields
    public System.Action callback;
    
    // Methods
    public MVCNetworkManager.<>c__DisplayClass37_0()
    {
    
    }
    internal void <TryLeaveRoomThenAction>b__0(IResponse deleteRoomResponse)
    {
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke();
    }

}
