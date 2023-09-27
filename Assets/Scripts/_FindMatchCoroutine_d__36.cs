using UnityEngine;
private sealed class MVCNetworkManager.<FindMatchCoroutine>d__36 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public InkWars.Model.MVCNetworkManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MVCNetworkManager.<FindMatchCoroutine>d__36(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) != 0)
        {
                return false;
        }
        
        this.<>1__state = 0;
        this = this.<>4__this;
        UnityEngine.Debug.Log(message:  "Fetch room list now");
        this.<>4__this._isTryingToJoin = false;
        this.<>4__this.keepCheckingRoomStatus = false;
        if((this.<>4__this.checkRoomStatusCoroutine) != null)
        {
                this.StopCoroutine(routine:  this.<>4__this.checkRoomStatusCoroutine);
        }
        
        InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.PrintState(state:  "LK.Lobby.StatusMsg3", showLog:  true);
        NFUser.current.clientUser.ListRoom(callback:  new UnityEngine.Events.UnityAction<System.Collections.Generic.List<Room>>(object:  this, method:  System.Void InkWars.Model.MVCNetworkManager::<FindMatchCoroutine>b__36_0(System.Collections.Generic.List<NFClientUser.Room> listRoomResp)));
        return false;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        39857 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
