using UnityEngine;
private sealed class MVCNetworkManager.<CheckRoomStatus>d__40 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action actionOnRoomDelete;
    public InkWars.Model.MVCNetworkManager <>4__this;
    private InkWars.Model.MVCNetworkManager.<>c__DisplayClass40_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MVCNetworkManager.<CheckRoomStatus>d__40(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_6;
        int val_7;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_14;
        }
        
        this.<>1__state = 0;
        val_6 = this.actionOnRoomDelete;
        this.<>8__1 = new MVCNetworkManager.<>c__DisplayClass40_0();
        .actionOnRoomDelete = val_6;
        if((this.<>4__this) != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_1:
        this.<>1__state = 0;
        if(((this.<>4__this.keepCheckingRoomStatus) != false) && ((this.<>4__this._isTryingToJoin) != false))
        {
                UnityEngine.Events.UnityAction<NFResponseRoom> val_4 = null;
            val_6 = val_4;
            val_4 = new UnityEngine.Events.UnityAction<NFResponseRoom>(object:  this.<>8__1, method:  System.Void MVCNetworkManager.<>c__DisplayClass40_0::<CheckRoomStatus>b__0(NFClientUser.NFResponseRoom roomStatusResponse));
            NFUser.current.clientUser.RoomStatus(callback:  val_4);
        }
        
        label_8:
        if(((this.<>4__this.keepCheckingRoomStatus) != false) && ((this.<>4__this._isTryingToJoin) != false))
        {
                val_7 = 1;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  15f);
            this.<>1__state = val_7;
            return (bool)val_7;
        }
        
        label_14:
        val_7 = 0;
        return (bool)val_7;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
