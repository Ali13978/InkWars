using UnityEngine;
private sealed class NFClientUser.<>c__DisplayClass72_0
{
    // Fields
    public NFClientUser <>4__this;
    public UnityEngine.Events.UnityAction<System.Collections.Generic.List<NFClientUser.Room>> callback;
    
    // Methods
    public NFClientUser.<>c__DisplayClass72_0()
    {
    
    }
    internal void <ListRoom>b__0(IResponse response)
    {
        System.Collections.Generic.List<Room> val_1 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Collections.Generic.List<Room>>(value:  response.msg);
        if(val_1 != null)
        {
                if(response.IsSuccess != false)
        {
                this.<>4__this.returnedRoomList = val_1;
        }
        
        }
        
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke(arg0:  val_1);
    }

}
