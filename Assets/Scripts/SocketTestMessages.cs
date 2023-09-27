using UnityEngine;
public class SocketTestMessages : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Text messageText;
    public UnityEngine.UI.InputField inputMessage;
    public UnityEngine.UI.Button buttonMessage;
    private BestHTTP.SocketIO.SocketManager _manager;
    
    // Methods
    private void Start()
    {
        var val_16;
        var val_18;
        var val_15 = 0;
        val_15 = val_15 + 1;
        BestHTTP.HTTPManager.Logger.Level = 0;
        BestHTTP.SocketIO.SocketManager val_4 = new BestHTTP.SocketIO.SocketManager(uri:  new System.Uri(uriString:  "http://localhost:3000/socket.io/"));
        this._manager = val_4;
        val_4.Socket.On(eventName:  "message", callback:  new BestHTTP.SocketIO.Events.SocketIOCallback(object:  this, method:  System.Void SocketTestMessages::HandleMessageReceived(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args)));
        BestHTTP.SocketIO.Socket val_7 = this._manager.Socket;
        val_16 = null;
        val_16 = null;
        if((SocketTestMessages.<>c.<>9__4_0) == null)
        {
            goto label_13;
        }
        
        label_29:
        val_7.On(type:  0, callback:  SocketTestMessages.<>c.<>9__4_0);
        BestHTTP.SocketIO.Socket val_8 = this._manager.Socket;
        val_18 = null;
        val_18 = null;
        if((SocketTestMessages.<>c.<>9__4_1) == null)
        {
            goto label_18;
        }
        
        label_33:
        val_8.On(type:  1, callback:  SocketTestMessages.<>c.<>9__4_1);
        this._manager.Socket.On(type:  4, callback:  new BestHTTP.SocketIO.Events.SocketIOCallback(object:  this, method:  System.Void SocketTestMessages::OnError(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args)));
        this.buttonMessage.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SocketTestMessages::SendMessage()));
        UnityEngine.Debug.Log(message:  "SocketIo, init done");
        return;
        label_13:
        SocketTestMessages.<>c.<>9__4_0 = new BestHTTP.SocketIO.Events.SocketIOCallback(object:  SocketTestMessages.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SocketTestMessages.<>c::<Start>b__4_0(BestHTTP.SocketIO.Socket _, BestHTTP.SocketIO.Packet __, object[] ___));
        if(val_7 != null)
        {
            goto label_29;
        }
        
        goto label_29;
        label_18:
        SocketTestMessages.<>c.<>9__4_1 = new BestHTTP.SocketIO.Events.SocketIOCallback(object:  SocketTestMessages.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SocketTestMessages.<>c::<Start>b__4_1(BestHTTP.SocketIO.Socket _, BestHTTP.SocketIO.Packet __, object[] ___));
        if(val_8 != null)
        {
            goto label_33;
        }
        
        goto label_33;
    }
    private void OnError(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args)
    {
        object val_5;
        object val_6;
        var val_7;
        object val_8;
        string val_10;
        val_5 = args[0];
        if(val_5 != null)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_6 = 0;
        val_5 = 0;
        val_7 = 1;
        goto label_5;
        label_4:
        val_7 = 0;
        val_6 = val_5;
        label_5:
        BestHTTP.SocketIO.SocketIOErrors val_1 = val_6.Code;
        if(val_1 == 5)
        {
            goto label_6;
        }
        
        if(val_1 != 6)
        {
            goto label_7;
        }
        
        val_8 = "Exception in an event handler!";
        goto label_10;
        label_6:
        string val_2 = val_6.Message;
        val_10 = "Internal error! Message: ";
        goto label_12;
        label_7:
        val_10 = "Server error! Message: ";
        label_12:
        val_8 = val_10 + val_6.Message;
        label_10:
        UnityEngine.Debug.LogError(message:  val_8);
        UnityEngine.Debug.LogError(message:  val_6);
    }
    private void SendMessage()
    {
        object[] val_2 = new object[1];
        string val_3 = this.inputMessage.text;
        if(val_2 == null)
        {
            goto label_3;
        }
        
        if(val_3 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_3 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_2[0] = val_3;
        BestHTTP.SocketIO.Socket val_4 = this._manager.Socket.Emit(eventName:  "message", args:  val_2);
        UnityEngine.Debug.Log(message:  "emitted message event $" + this.inputMessage.text);
        this.inputMessage.text = "";
    }
    private void HandleMessageReceived(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args)
    {
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "Got message event ${0}", arg0:  args[0]));
        bool val_2 = System.String.op_Equality(a:  this.messageText, b:  "clear");
        if(this.messageText == null)
        {
            goto label_6;
        }
        
        if(val_2 == false)
        {
            goto label_7;
        }
        
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5B8;
        label_6:
        if(val_2 == true)
        {
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5B8;
        }
        
        label_7:
        string val_3 = this.messageText + args[0] + "/n"("/n");
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5B8;
    }
    public SocketTestMessages()
    {
    
    }

}
