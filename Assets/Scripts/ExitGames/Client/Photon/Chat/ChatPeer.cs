using UnityEngine;

namespace ExitGames.Client.Photon.Chat
{
    public class ChatPeer : PhotonPeer
    {
        // Fields
        public const string NameServerHost = "ns.exitgames.com";
        public const string NameServerHttp = "http://ns.exitgamescloud.com:80/photon/n";
        private static readonly System.Collections.Generic.Dictionary<ExitGames.Client.Photon.ConnectionProtocol, int> ProtocolToNameServerPort;
        
        // Properties
        public string NameServerAddress { get; }
        internal virtual bool IsProtocolSecure { get; }
        
        // Methods
        public string get_NameServerAddress()
        {
            return this.GetNameServerAddress();
        }
        internal virtual bool get_IsProtocolSecure()
        {
            return (bool)((this.UsedProtocol & 255) == 5) ? 1 : 0;
        }
        public ChatPeer(ExitGames.Client.Photon.IPhotonPeerListener listener, ExitGames.Client.Photon.ConnectionProtocol protocol)
        {
        
        }
        private void ConfigUnitySockets()
        {
            string val_10;
            System.Type val_11;
            val_10 = "ExitGames.Client.Photon.SocketWebTcpThread, Assembly-CSharp";
            val_11 = System.Type.GetType(typeName:  val_10, throwOnError:  false);
            if(val_11 == null)
            {
                    val_11 = System.Type.GetType(typeName:  val_10, throwOnError:  false);
                if(val_11 == null)
            {
                    val_10 = "ExitGames.Client.Photon.SocketWebTcpThread, Assembly-CSharp-firstpass";
                val_11 = System.Type.GetType(typeName:  val_10, throwOnError:  false);
                if(val_11 == null)
            {
                    val_11 = System.Type.GetType(typeName:  val_10, throwOnError:  false);
                if(val_11 == null)
            {
                    val_10 = "ExitGames.Client.Photon.SocketWebTcpCoroutine, Assembly-CSharp";
                val_11 = System.Type.GetType(typeName:  val_10, throwOnError:  false);
                if(val_11 == null)
            {
                    val_11 = System.Type.GetType(typeName:  val_10, throwOnError:  false);
                if(val_11 == null)
            {
                    val_10 = "ExitGames.Client.Photon.SocketWebTcpCoroutine, Assembly-CSharp-firstpass";
                val_11 = System.Type.GetType(typeName:  val_10, throwOnError:  false);
                if(val_11 == null)
            {
                    val_11 = System.Type.GetType(typeName:  val_10, throwOnError:  false);
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            if((System.Type.op_Inequality(left:  val_11, right:  0)) == false)
            {
                    return;
            }
            
            set_Item(key:  4, value:  val_11);
            this.set_Item(key:  5, value:  val_11);
        }
        private string GetNameServerAddress()
        {
            var val_8;
            string val_10;
            val_8 = null;
            val_8 = null;
            bool val_3 = ExitGames.Client.Photon.Chat.ChatPeer.ProtocolToNameServerPort.TryGetValue(key:  this.TransportProtocol, value: out  0);
            ExitGames.Client.Photon.ConnectionProtocol val_5 = this.TransportProtocol & 255;
            if(val_5 < 2)
            {
                goto label_4;
            }
            
            if(val_5 == 4)
            {
                goto label_5;
            }
            
            if(val_5 != 5)
            {
                goto label_6;
            }
            
            val_10 = "wss://{0}:{1}";
            return (string)System.String.Format(format:  val_10 = "ws://{0}:{1}", arg0:  "ns.exitgames.com", arg1:  0);
            label_4:
            val_10 = "{0}:{1}";
            return (string)System.String.Format(format:  val_10, arg0:  "ns.exitgames.com", arg1:  0);
            label_5:
            return (string)System.String.Format(format:  val_10, arg0:  "ns.exitgames.com", arg1:  0);
            label_6:
            System.ArgumentOutOfRangeException val_7 = new System.ArgumentOutOfRangeException();
        }
        public bool Connect()
        {
            if(true < 3)
            {
                    return this.Connect(serverAddress:  this.GetNameServerAddress(), applicationName:  "NameServer");
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            this.Listener.DebugReturn(level:  3, message:  "Connecting to nameserver " + this.GetNameServerAddress());
            return this.Connect(serverAddress:  this.GetNameServerAddress(), applicationName:  "NameServer");
        }
        public bool AuthenticateOnNameServer(string appId, string appVersion, string region, ExitGames.Client.Photon.Chat.AuthenticationValues authValues)
        {
            object val_12;
            var val_13;
            var val_14;
            if(true >= 3)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                this.Listener.DebugReturn(level:  3, message:  "OpAuthenticate()");
            }
            
            System.Collections.Generic.Dictionary<System.Byte, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
            if(val_3 != null)
            {
                    val_3.set_Item(key:  220, value:  appVersion);
                val_3.set_Item(key:  224, value:  appId);
            }
            else
            {
                    val_3.set_Item(key:  220, value:  appVersion);
                val_3.set_Item(key:  224, value:  appId);
            }
            
            val_3.set_Item(key:  210, value:  region);
            if(authValues == null)
            {
                    return (bool)this.OpCustom(customOpCode:  230, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  this.IsEncryptionAvailable);
            }
            
            if((System.String.IsNullOrEmpty(value:  authValues.<UserId>k__BackingField)) != true)
            {
                    val_3.set_Item(key:  225, value:  authValues.<UserId>k__BackingField);
            }
            
            if(authValues.authType == 255)
            {
                    return (bool)this.OpCustom(customOpCode:  230, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  this.IsEncryptionAvailable);
            }
            
            val_3.set_Item(key:  217, value:  authValues.authType);
            if((System.String.IsNullOrEmpty(value:  authValues.<Token>k__BackingField)) != false)
            {
                    if((System.String.IsNullOrEmpty(value:  authValues.<AuthGetParameters>k__BackingField)) != true)
            {
                    val_3.set_Item(key:  216, value:  authValues.<AuthGetParameters>k__BackingField);
            }
            
                val_12 = authValues.<AuthPostData>k__BackingField;
                if(val_12 == null)
            {
                    return (bool)this.OpCustom(customOpCode:  230, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  this.IsEncryptionAvailable);
            }
            
                val_13 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
                val_14 = 214;
            }
            else
            {
                    val_12 = authValues.<Token>k__BackingField;
                val_13 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
                val_14 = 221;
            }
            
            val_3.set_Item(key:  221, value:  val_12);
            return (bool)this.OpCustom(customOpCode:  230, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  this.IsEncryptionAvailable);
        }
        private static ChatPeer()
        {
            System.Collections.Generic.Dictionary<ExitGames.Client.Photon.ConnectionProtocol, System.Int32> val_1 = new System.Collections.Generic.Dictionary<ExitGames.Client.Photon.ConnectionProtocol, System.Int32>();
            if(val_1 != null)
            {
                    val_1.Add(key:  0, value:  194);
                val_1.Add(key:  1, value:  181);
                val_1.Add(key:  4, value:  133);
            }
            else
            {
                    val_1.Add(key:  0, value:  194);
                val_1.Add(key:  1, value:  181);
                val_1.Add(key:  4, value:  133);
            }
            
            val_1.Add(key:  5, value:  149);
            ExitGames.Client.Photon.Chat.ChatPeer.ProtocolToNameServerPort = val_1;
        }
    
    }

}
