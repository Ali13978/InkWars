using UnityEngine;

namespace ExitGames.Client.Photon.Chat
{
    public class ChatClient : IPhotonPeerListener
    {
        // Fields
        private const int FriendRequestListMax = 1024;
        private string <NameServerAddress>k__BackingField;
        private string <FrontendAddress>k__BackingField;
        private string chatRegion;
        private ExitGames.Client.Photon.Chat.ChatState <State>k__BackingField;
        private ExitGames.Client.Photon.Chat.ChatDisconnectCause <DisconnectedCause>k__BackingField;
        private string <AppVersion>k__BackingField;
        private string <AppId>k__BackingField;
        private ExitGames.Client.Photon.Chat.AuthenticationValues <AuthValues>k__BackingField;
        public int MessageLimit;
        public readonly System.Collections.Generic.Dictionary<string, ExitGames.Client.Photon.Chat.ChatChannel> PublicChannels;
        public readonly System.Collections.Generic.Dictionary<string, ExitGames.Client.Photon.Chat.ChatChannel> PrivateChannels;
        private readonly System.Collections.Generic.HashSet<string> PublicChannelsUnsubscribing;
        private readonly ExitGames.Client.Photon.Chat.IChatClientListener listener;
        public ExitGames.Client.Photon.Chat.ChatPeer chatPeer;
        private const string ChatAppName = "chat";
        private bool didAuthenticate;
        private int msDeltaForServiceCalls;
        private int msTimestampOfLastServiceCall;
        private bool <UseBackgroundWorkerForSending>k__BackingField;
        
        // Properties
        public string NameServerAddress { get; set; }
        public string FrontendAddress { get; set; }
        public string ChatRegion { get; set; }
        public ExitGames.Client.Photon.Chat.ChatState State { get; set; }
        public ExitGames.Client.Photon.Chat.ChatDisconnectCause DisconnectedCause { get; set; }
        public bool CanChat { get; }
        private bool HasPeer { get; }
        public string AppVersion { get; set; }
        public string AppId { get; set; }
        public ExitGames.Client.Photon.Chat.AuthenticationValues AuthValues { get; set; }
        public string UserId { get; set; }
        public bool UseBackgroundWorkerForSending { get; set; }
        public ExitGames.Client.Photon.ConnectionProtocol TransportProtocol { get; set; }
        public System.Collections.Generic.Dictionary<ExitGames.Client.Photon.ConnectionProtocol, System.Type> SocketImplementationConfig { get; }
        public ExitGames.Client.Photon.DebugLevel DebugOut { get; set; }
        
        // Methods
        public string get_NameServerAddress()
        {
            return (string)this.<NameServerAddress>k__BackingField;
        }
        private void set_NameServerAddress(string value)
        {
            this.<NameServerAddress>k__BackingField = value;
        }
        public string get_FrontendAddress()
        {
            return (string)this.<FrontendAddress>k__BackingField;
        }
        private void set_FrontendAddress(string value)
        {
            this.<FrontendAddress>k__BackingField = value;
        }
        public string get_ChatRegion()
        {
            return (string)this.chatRegion;
        }
        public void set_ChatRegion(string value)
        {
            this.chatRegion = value;
        }
        public ExitGames.Client.Photon.Chat.ChatState get_State()
        {
            return (ExitGames.Client.Photon.Chat.ChatState)this.<State>k__BackingField;
        }
        private void set_State(ExitGames.Client.Photon.Chat.ChatState value)
        {
            this.<State>k__BackingField = value;
        }
        public ExitGames.Client.Photon.Chat.ChatDisconnectCause get_DisconnectedCause()
        {
            return (ExitGames.Client.Photon.Chat.ChatDisconnectCause)this.<DisconnectedCause>k__BackingField;
        }
        private void set_DisconnectedCause(ExitGames.Client.Photon.Chat.ChatDisconnectCause value)
        {
            this.<DisconnectedCause>k__BackingField = value;
        }
        public bool get_CanChat()
        {
            if((this.<State>k__BackingField) != 7)
            {
                    return false;
            }
            
            return (bool)(this.chatPeer != 0) ? 1 : 0;
        }
        public bool CanChatInChannel(string channelName)
        {
            ExitGames.Client.Photon.Chat.ChatPeer val_4;
            if((this.<State>k__BackingField) == 7)
            {
                    val_4 = this.chatPeer;
                if(val_4 == null)
            {
                    return (bool)val_4 & 1;
            }
            
                if((this.PublicChannels.ContainsKey(key:  channelName)) != false)
            {
                    val_4 = (this.PublicChannelsUnsubscribing.Contains(item:  channelName)) ^ 1;
                return (bool)val_4 & 1;
            }
            
            }
            
            val_4 = 0;
            return (bool)val_4 & 1;
        }
        private bool get_HasPeer()
        {
            return (bool)(this.chatPeer != 0) ? 1 : 0;
        }
        public string get_AppVersion()
        {
            return (string)this.<AppVersion>k__BackingField;
        }
        private void set_AppVersion(string value)
        {
            this.<AppVersion>k__BackingField = value;
        }
        public string get_AppId()
        {
            return (string)this.<AppId>k__BackingField;
        }
        private void set_AppId(string value)
        {
            this.<AppId>k__BackingField = value;
        }
        public ExitGames.Client.Photon.Chat.AuthenticationValues get_AuthValues()
        {
            return (ExitGames.Client.Photon.Chat.AuthenticationValues)this.<AuthValues>k__BackingField;
        }
        public void set_AuthValues(ExitGames.Client.Photon.Chat.AuthenticationValues value)
        {
            this.<AuthValues>k__BackingField = value;
        }
        public string get_UserId()
        {
            if((this.<AuthValues>k__BackingField) == null)
            {
                    return 0;
            }
            
            return (string)this.<AuthValues>k__BackingField.<UserId>k__BackingField;
        }
        private void set_UserId(string value)
        {
            ExitGames.Client.Photon.Chat.AuthenticationValues val_2 = this.<AuthValues>k__BackingField;
            if(val_2 != null)
            {
                goto label_1;
            }
            
            ExitGames.Client.Photon.Chat.AuthenticationValues val_1 = null;
            val_2 = val_1;
            .authType = 255;
            val_1 = new ExitGames.Client.Photon.Chat.AuthenticationValues();
            this.<AuthValues>k__BackingField = val_2;
            if(val_2 == null)
            {
                goto label_2;
            }
            
            label_1:
            .<UserId>k__BackingField = value;
            return;
            label_2:
        }
        public bool get_UseBackgroundWorkerForSending()
        {
            return (bool)this.<UseBackgroundWorkerForSending>k__BackingField;
        }
        public void set_UseBackgroundWorkerForSending(bool value)
        {
            this.<UseBackgroundWorkerForSending>k__BackingField = value;
        }
        public ExitGames.Client.Photon.ConnectionProtocol get_TransportProtocol()
        {
            if(this.chatPeer != null)
            {
                    return this.chatPeer.TransportProtocol;
            }
            
            return this.chatPeer.TransportProtocol;
        }
        public void set_TransportProtocol(ExitGames.Client.Photon.ConnectionProtocol value)
        {
            ExitGames.Client.Photon.Chat.IChatClientListener val_7;
            string val_8;
            string val_9;
            if(this.chatPeer == null)
            {
                goto label_1;
            }
            
            if((this.chatPeer.PeerState & 255) == 0)
            {
                goto label_2;
            }
            
            val_7 = this.listener;
            val_8 = "Can\'t set TransportProtocol. Disconnect first! ";
            if(this.chatPeer == null)
            {
                goto label_3;
            }
            
            val_9 = "PeerState: "("PeerState: ") + this.chatPeer.PeerState;
            goto label_4;
            label_1:
            val_7 = this.listener;
            val_8 = "Can\'t set TransportProtocol. Disconnect first! ";
            label_3:
            val_9 = "The chatPeer is null.";
            label_4:
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7.DebugReturn(level:  2, message:  val_8 + val_9);
            return;
            label_2:
            this.chatPeer.TransportProtocol = value;
        }
        public System.Collections.Generic.Dictionary<ExitGames.Client.Photon.ConnectionProtocol, System.Type> get_SocketImplementationConfig()
        {
            if(this.chatPeer != null)
            {
                    return 0;
            }
            
            return 0;
        }
        public ChatClient(ExitGames.Client.Photon.Chat.IChatClientListener listener, ExitGames.Client.Photon.ConnectionProtocol protocol = 0)
        {
            this.msDeltaForServiceCalls = 50;
            this.chatRegion = "EU";
            this.listener = listener;
            this.<State>k__BackingField = 0;
            this.chatPeer = new ExitGames.Client.Photon.Chat.ChatPeer(listener:  this, protocol:  protocol);
            this.PublicChannels = new System.Collections.Generic.Dictionary<System.String, ExitGames.Client.Photon.Chat.ChatChannel>();
            this.PrivateChannels = new System.Collections.Generic.Dictionary<System.String, ExitGames.Client.Photon.Chat.ChatChannel>();
            this.PublicChannelsUnsubscribing = new System.Collections.Generic.HashSet<System.String>();
        }
        public bool Connect(string appId, string appVersion, ExitGames.Client.Photon.Chat.AuthenticationValues authValues)
        {
            string val_7;
            ExitGames.Client.Photon.Chat.IChatClientListener val_8;
            var val_10;
            string val_11;
            var val_12;
            ExitGames.Client.Photon.Chat.ChatState val_14;
            val_7 = appId;
            val_8 = this;
            mem2[0] = 3000;
            this.<DisconnectedCause>k__BackingField = 0;
            if(authValues == null)
            {
                goto label_2;
            }
            
            this.<AuthValues>k__BackingField = authValues;
            if((System.String.IsNullOrEmpty(value:  authValues.<UserId>k__BackingField)) == false)
            {
                goto label_3;
            }
            
            if(3000 == 0)
            {
                goto label_12;
            }
            
            val_8 = this.listener;
            val_10 = null;
            val_11 = "Connect failed: no UserId specified in authentication values.";
            var val_7 = 0;
            val_12 = 1152921505157947400;
            val_7 = val_7 + 1;
            goto label_17;
            label_2:
            if(3000 == 0)
            {
                goto label_12;
            }
            
            val_8 = this.listener;
            val_10 = null;
            val_11 = "Connect failed: no authentication values specified";
            var val_8 = 0;
            val_12 = 1152921505157947400;
            val_8 = val_8 + 1;
            goto label_17;
            label_3:
            this.<AppVersion>k__BackingField = appVersion;
            this.<AppId>k__BackingField = val_7;
            this.didAuthenticate = false;
            this.chatPeer.QuickResendAttempts = 2;
            mem2[0] = 7;
            val_7 = 1152921529332355632;
            this.PublicChannels.Clear();
            this.PrivateChannels.Clear();
            this.PublicChannelsUnsubscribing.Clear();
            this.<NameServerAddress>k__BackingField = this.chatPeer.GetNameServerAddress();
            if(this.chatPeer.Connect() != false)
            {
                    val_14 = 1;
                this.<State>k__BackingField = val_14;
            }
            else
            {
                    val_14 = 0;
            }
            
            if((this.<UseBackgroundWorkerForSending>k__BackingField) == false)
            {
                    return (bool)val_14;
            }
            
            System.Func<System.Boolean> val_4 = null;
            val_7 = val_4;
            val_4 = new System.Func<System.Boolean>(object:  this, method:  System.Boolean ExitGames.Client.Photon.Chat.ChatClient::SendOutgoingInBackground());
            val_8 = this.msDeltaForServiceCalls;
            byte val_5 = ExitGames.Client.Photon.SupportClass.StartBackgroundCalls(myThread:  val_4, millisecondsInterval:  val_8, taskName:  "ChatClient Service Thread");
            return (bool)val_14;
            label_17:
            val_8.DebugReturn(level:  1, message:  val_11);
            label_12:
            val_14 = 0;
            return (bool)val_14;
        }
        public void Service()
        {
            label_1:
            if(this.chatPeer != null)
            {
                    if(this.chatPeer.DispatchIncomingCommands() == true)
            {
                goto label_1;
            }
            
            }
            
            if((this.<UseBackgroundWorkerForSending>k__BackingField) == true)
            {
                    return;
            }
            
            int val_5 = this.msTimestampOfLastServiceCall;
            if(val_5 != 0)
            {
                    val_5 = System.Environment.TickCount - val_5;
                if(val_5 <= this.msDeltaForServiceCalls)
            {
                    return;
            }
            
            }
            
            this.msTimestampOfLastServiceCall = System.Environment.TickCount;
            do
            {
                if(this.chatPeer == null)
            {
                    return;
            }
            
            }
            while(this.chatPeer.SendOutgoingCommands() == true);
        
        }
        private bool SendOutgoingInBackground()
        {
            do
            {
                if(this.chatPeer == null)
            {
                    return (bool)((this.<State>k__BackingField) != 11) ? 1 : 0;
            }
            
            }
            while(this.chatPeer.SendOutgoingCommands() == true);
            
            return (bool)((this.<State>k__BackingField) != 11) ? 1 : 0;
        }
        public void SendAcksOnly()
        {
            if(this.chatPeer == null)
            {
                    return;
            }
            
            bool val_1 = this.chatPeer.SendAcksOnly();
        }
        public void Disconnect()
        {
            if(this.chatPeer == null)
            {
                    return;
            }
            
            if((this.chatPeer.PeerState & 255) == 0)
            {
                    return;
            }
            
            this.chatPeer.Disconnect();
        }
        public void StopThread()
        {
            if(this.chatPeer == null)
            {
                    return;
            }
            
            this.chatPeer.StopThread();
        }
        public bool Subscribe(string[] channels)
        {
            return this.Subscribe(channels:  channels, messagesFromHistory:  0);
        }
        public bool Subscribe(string[] channels, int messagesFromHistory)
        {
            ExitGames.Client.Photon.Chat.IChatClientListener val_3;
            string val_4;
            val_3 = this;
            if((this.<State>k__BackingField) != 7)
            {
                goto label_1;
            }
            
            if(this.chatPeer == null)
            {
                goto label_5;
            }
            
            if((channels == null) || (channels.Length == 0))
            {
                goto label_4;
            }
            
            return this.SendChannelOperation(channels:  channels, operation:  0, historyLength:  messagesFromHistory);
            label_1:
            if(this.chatPeer == null)
            {
                goto label_5;
            }
            
            if(this.chatPeer == null)
            {
                    return false;
            }
            
            val_3 = this.listener;
            val_4 = "Subscribe called while not connected to front end server.";
            var val_3 = 0;
            val_3 = val_3 + 1;
            goto label_18;
            label_4:
            if(this.chatPeer < 2)
            {
                    return false;
            }
            
            val_3 = this.listener;
            val_4 = "Subscribe can\'t be called for empty or null channels-list.";
            var val_4 = 0;
            val_4 = val_4 + 1;
            label_18:
            val_3.DebugReturn(level:  2, message:  val_4);
            return false;
            label_5:
        }
        public bool Unsubscribe(string[] channels)
        {
            string val_4;
            ExitGames.Client.Photon.Chat.IChatClientListener val_5;
            string val_6;
            val_5 = this;
            if((this.<State>k__BackingField) != 7)
            {
                goto label_1;
            }
            
            if(this.chatPeer == null)
            {
                goto label_9;
            }
            
            if((channels == null) || (channels.Length == 0))
            {
                goto label_4;
            }
            
            if(channels.Length < 1)
            {
                    return this.SendChannelOperation(channels:  channels, operation:  1, historyLength:  0);
            }
            
            do
            {
                val_4 = channels[0];
                bool val_1 = this.PublicChannelsUnsubscribing.Add(item:  val_4);
            }
            while((0 + 1) < channels.Length);
            
            return this.SendChannelOperation(channels:  channels, operation:  1, historyLength:  0);
            label_1:
            if(this.chatPeer == null)
            {
                goto label_9;
            }
            
            if((this.<State>k__BackingField) == 0)
            {
                    return false;
            }
            
            val_5 = this.listener;
            val_6 = "Unsubscribe called while not connected to front end server.";
            var val_5 = 0;
            val_5 = val_5 + 1;
            goto label_22;
            label_4:
            if((this.<State>k__BackingField) < 2)
            {
                    return false;
            }
            
            val_5 = this.listener;
            val_6 = "Unsubscribe can\'t be called for empty or null channels-list.";
            var val_6 = 0;
            val_6 = val_6 + 1;
            label_22:
            val_5.DebugReturn(level:  2, message:  val_6);
            return false;
            label_9:
        }
        public bool PublishMessage(string channelName, object message, bool forwardAsWebhook = False)
        {
            return this.publishMessage(channelName:  channelName, message:  message, reliable:  true, forwardAsWebhook:  forwardAsWebhook);
        }
        internal bool PublishMessageUnreliable(string channelName, object message, bool forwardAsWebhook = False)
        {
            return this.publishMessage(channelName:  channelName, message:  message, reliable:  false, forwardAsWebhook:  forwardAsWebhook);
        }
        private bool publishMessage(string channelName, object message, bool reliable, bool forwardAsWebhook = False)
        {
            object val_7;
            ExitGames.Client.Photon.Chat.IChatClientListener val_8;
            string val_9;
            var val_12;
            val_7 = forwardAsWebhook;
            val_8 = this;
            if((this.<State>k__BackingField) != 7)
            {
                goto label_1;
            }
            
            if(this.chatPeer == null)
            {
                goto label_7;
            }
            
            if((message == null) || ((System.String.IsNullOrEmpty(value:  channelName)) == true))
            {
                goto label_4;
            }
            
            System.Collections.Generic.Dictionary<System.Byte, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
            if(val_2 == null)
            {
                goto label_5;
            }
            
            val_2.Add(key:  1, value:  channelName);
            goto label_6;
            label_1:
            if(this.chatPeer == null)
            {
                goto label_7;
            }
            
            if(this.chatPeer == null)
            {
                goto label_15;
            }
            
            val_8 = this.listener;
            val_9 = "PublishMessage called while not connected to front end server.";
            var val_7 = 0;
            val_7 = val_7 + 1;
            goto label_21;
            label_4:
            if(this.chatPeer < 2)
            {
                goto label_15;
            }
            
            val_8 = this.listener;
            val_9 = "PublishMessage parameters must be non-null and not empty.";
            var val_8 = 0;
            val_8 = val_8 + 1;
            goto label_20;
            label_5:
            val_2.Add(key:  1, value:  channelName);
            label_6:
            val_2.Add(key:  3, value:  message);
            if(val_7 != false)
            {
                    val_7 = 1;
                val_2.Add(key:  21, value:  1);
            }
            
            val_8 = this.chatPeer;
            val_12 = val_8;
            bool val_5 = val_12.OpCustom(customOpCode:  2, customOpParameters:  val_2, sendReliable:  reliable);
            goto label_25;
            label_20:
            label_21:
            val_8.DebugReturn(level:  2, message:  val_9);
            label_15:
            val_12 = 0;
            label_25:
            val_12 = val_12 & 1;
            return (bool)val_12;
            label_7:
        }
        public bool SendPrivateMessage(string target, object message, bool forwardAsWebhook = False)
        {
            return this.sendPrivateMessage(target:  target, message:  message, encrypt:  false, reliable:  true, forwardAsWebhook:  forwardAsWebhook);
        }
        public bool SendPrivateMessage(string target, object message, bool encrypt, bool forwardAsWebhook)
        {
            return this.sendPrivateMessage(target:  target, message:  message, encrypt:  encrypt, reliable:  true, forwardAsWebhook:  forwardAsWebhook);
        }
        internal bool SendPrivateMessageUnreliable(string target, object message, bool encrypt, bool forwardAsWebhook = False)
        {
            return this.sendPrivateMessage(target:  target, message:  message, encrypt:  encrypt, reliable:  false, forwardAsWebhook:  forwardAsWebhook);
        }
        private bool sendPrivateMessage(string target, object message, bool encrypt, bool reliable, bool forwardAsWebhook = False)
        {
            object val_8;
            ExitGames.Client.Photon.Chat.IChatClientListener val_9;
            string val_10;
            var val_13;
            val_8 = forwardAsWebhook;
            val_9 = this;
            if((this.<State>k__BackingField) != 7)
            {
                goto label_1;
            }
            
            if(this.chatPeer == null)
            {
                goto label_7;
            }
            
            if((message == null) || ((System.String.IsNullOrEmpty(value:  target)) == true))
            {
                goto label_4;
            }
            
            System.Collections.Generic.Dictionary<System.Byte, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
            if(val_2 == null)
            {
                goto label_5;
            }
            
            val_2.Add(key:  225, value:  target);
            goto label_6;
            label_1:
            if(this.chatPeer == null)
            {
                goto label_7;
            }
            
            if(this.chatPeer == null)
            {
                goto label_15;
            }
            
            val_9 = this.listener;
            val_10 = "SendPrivateMessage called while not connected to front end server.";
            var val_8 = 0;
            val_8 = val_8 + 1;
            goto label_21;
            label_4:
            if(this.chatPeer < 2)
            {
                goto label_15;
            }
            
            val_9 = this.listener;
            val_10 = "SendPrivateMessage parameters must be non-null and not empty.";
            var val_9 = 0;
            val_9 = val_9 + 1;
            goto label_20;
            label_5:
            val_2.Add(key:  225, value:  target);
            label_6:
            val_2.Add(key:  3, value:  message);
            if(val_8 != false)
            {
                    val_8 = 1;
                val_2.Add(key:  21, value:  1);
            }
            
            val_9 = this.chatPeer;
            val_13 = val_9;
            bool val_6 = val_13.OpCustom(customOpCode:  3, customOpParameters:  val_2, sendReliable:  reliable, channelId:  0, encrypt:  encrypt);
            goto label_25;
            label_20:
            label_21:
            val_9.DebugReturn(level:  2, message:  val_10);
            label_15:
            val_13 = 0;
            label_25:
            val_13 = val_13 & 1;
            return (bool)val_13;
            label_7:
        }
        private bool SetOnlineStatus(int status, object message, bool skipMessage)
        {
            object val_4;
            ExitGames.Client.Photon.Chat.IChatClientListener val_5;
            var val_6;
            var val_7;
            var val_9;
            val_4 = message;
            val_5 = this;
            if((this.<State>k__BackingField) != 7)
            {
                goto label_1;
            }
            
            if(this.chatPeer == null)
            {
                goto label_7;
            }
            
            System.Collections.Generic.Dictionary<System.Byte, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
            val_1.Add(key:  10, value:  status);
            if(skipMessage == false)
            {
                goto label_4;
            }
            
            val_4 = true;
            val_6 = 1152921525004534832;
            val_7 = 12;
            goto label_6;
            label_1:
            if(this.chatPeer == null)
            {
                goto label_7;
            }
            
            if(this.chatPeer == null)
            {
                goto label_8;
            }
            
            val_5 = this.listener;
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_13;
            label_4:
            val_6 = 1152921525004534832;
            val_7 = 3;
            label_6:
            val_1.set_Item(key:  3, value:  val_4);
            val_5 = this.chatPeer;
            val_9 = val_5;
            bool val_2 = val_9.OpCustom(customOpCode:  5, customOpParameters:  val_1, sendReliable:  true);
            goto label_16;
            label_13:
            val_5.DebugReturn(level:  1, message:  "SetOnlineStatus called while not connected to front end server.");
            label_8:
            val_9 = 0;
            label_16:
            val_9 = val_9 & 1;
            return (bool)val_9;
            label_7:
        }
        public bool SetOnlineStatus(int status)
        {
            return this.SetOnlineStatus(status:  status, message:  0, skipMessage:  true);
        }
        public bool SetOnlineStatus(int status, object message)
        {
            return this.SetOnlineStatus(status:  status, message:  message, skipMessage:  false);
        }
        public bool AddFriends(string[] friends)
        {
            object val_6;
            ExitGames.Client.Photon.Chat.IChatClientListener val_7;
            string val_8;
            var val_11;
            var val_12;
            val_6 = friends;
            val_7 = this;
            if((this.<State>k__BackingField) != 7)
            {
                goto label_1;
            }
            
            if(this.chatPeer == null)
            {
                goto label_8;
            }
            
            if((val_6 == null) || (friends.Length == 0))
            {
                goto label_4;
            }
            
            if(friends.Length >= 1025)
            {
                goto label_5;
            }
            
            System.Collections.Generic.Dictionary<System.Byte, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
            val_1.Add(key:  11, value:  val_6);
            if(this.chatPeer != null)
            {
                    return this.chatPeer.OpCustom(customOpCode:  6, customOpParameters:  val_1, sendReliable:  true);
            }
            
            return this.chatPeer.OpCustom(customOpCode:  6, customOpParameters:  val_1, sendReliable:  true);
            label_1:
            if(this.chatPeer == null)
            {
                goto label_8;
            }
            
            if(this.chatPeer == null)
            {
                    return false;
            }
            
            val_7 = this.listener;
            val_8 = "AddFriends called while not connected to front end server.";
            var val_6 = 0;
            val_6 = val_6 + 1;
            goto label_21;
            label_4:
            if(this.chatPeer < 2)
            {
                    return false;
            }
            
            val_7 = this.listener;
            val_11 = null;
            val_8 = "AddFriends can\'t be called for empty or null list.";
            var val_7 = 0;
            val_12 = 1152921505157947400;
            val_7 = val_7 + 1;
            goto label_40;
            label_5:
            if(this.chatPeer < 2)
            {
                    return false;
            }
            
            val_7 = this.listener;
            object[] val_3 = new object[4];
            val_3[0] = "AddFriends max list size exceeded: ";
            val_3[1] = friends.Length;
            val_3[2] = " > ";
            val_6 = 1024;
            val_3[3] = val_6;
            val_8 = +val_3;
            val_11 = null;
            var val_8 = 0;
            val_12 = 1152921505157947400;
            val_8 = val_8 + 1;
            label_40:
            label_21:
            val_7.DebugReturn(level:  2, message:  val_8);
            return false;
            label_8:
        }
        public bool RemoveFriends(string[] friends)
        {
            object val_6;
            ExitGames.Client.Photon.Chat.IChatClientListener val_7;
            string val_8;
            var val_11;
            var val_12;
            val_6 = friends;
            val_7 = this;
            if((this.<State>k__BackingField) != 7)
            {
                goto label_1;
            }
            
            if(this.chatPeer == null)
            {
                goto label_8;
            }
            
            if((val_6 == null) || (friends.Length == 0))
            {
                goto label_4;
            }
            
            if(friends.Length >= 1025)
            {
                goto label_5;
            }
            
            System.Collections.Generic.Dictionary<System.Byte, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
            val_1.Add(key:  11, value:  val_6);
            if(this.chatPeer != null)
            {
                    return this.chatPeer.OpCustom(customOpCode:  7, customOpParameters:  val_1, sendReliable:  true);
            }
            
            return this.chatPeer.OpCustom(customOpCode:  7, customOpParameters:  val_1, sendReliable:  true);
            label_1:
            if(this.chatPeer == null)
            {
                goto label_8;
            }
            
            if(this.chatPeer == null)
            {
                    return false;
            }
            
            val_7 = this.listener;
            val_8 = "RemoveFriends called while not connected to front end server.";
            var val_6 = 0;
            val_6 = val_6 + 1;
            goto label_21;
            label_4:
            if(this.chatPeer < 2)
            {
                    return false;
            }
            
            val_7 = this.listener;
            val_11 = null;
            val_8 = "RemoveFriends can\'t be called for empty or null list.";
            var val_7 = 0;
            val_12 = 1152921505157947400;
            val_7 = val_7 + 1;
            goto label_40;
            label_5:
            if(this.chatPeer < 2)
            {
                    return false;
            }
            
            val_7 = this.listener;
            object[] val_3 = new object[4];
            val_3[0] = "RemoveFriends max list size exceeded: ";
            val_3[1] = friends.Length;
            val_3[2] = " > ";
            val_6 = 1024;
            val_3[3] = val_6;
            val_8 = +val_3;
            val_11 = null;
            var val_8 = 0;
            val_12 = 1152921505157947400;
            val_8 = val_8 + 1;
            label_40:
            label_21:
            val_7.DebugReturn(level:  2, message:  val_8);
            return false;
            label_8:
        }
        public string GetPrivateChannelNameByUser(string userName)
        {
            string val_1;
            if((this.<AuthValues>k__BackingField) != null)
            {
                    val_1 = this.<AuthValues>k__BackingField.<UserId>k__BackingField;
                return System.String.Format(format:  "{0}:{1}", arg0:  val_1 = 0, arg1:  userName);
            }
            
            return System.String.Format(format:  "{0}:{1}", arg0:  val_1, arg1:  userName);
        }
        public bool TryGetChannel(string channelName, bool isPrivate, out ExitGames.Client.Photon.Chat.ChatChannel channel)
        {
            if(isPrivate != false)
            {
                    if(this.PrivateChannels != null)
            {
                    return 0.TryGetValue(key:  channelName, value: out  ExitGames.Client.Photon.Chat.ChatChannel val_1 = channel);
            }
            
                return 0.TryGetValue(key:  channelName, value: out  val_1);
            }
            
            if(this.PublicChannels != null)
            {
                    return 0.TryGetValue(key:  channelName, value: out  val_1);
            }
            
            return 0.TryGetValue(key:  channelName, value: out  val_1);
        }
        public bool TryGetChannel(string channelName, out ExitGames.Client.Photon.Chat.ChatChannel channel)
        {
            if((this.PublicChannels.TryGetValue(key:  channelName, value: out  ExitGames.Client.Photon.Chat.ChatChannel val_1 = channel)) != false)
            {
                    return true;
            }
            
            if(this.PrivateChannels != null)
            {
                    return this.PrivateChannels.TryGetValue(key:  channelName, value: out  val_1);
            }
            
            return this.PrivateChannels.TryGetValue(key:  channelName, value: out  val_1);
        }
        public void set_DebugOut(ExitGames.Client.Photon.DebugLevel value)
        {
            mem2[0] = value;
        }
        public ExitGames.Client.Photon.DebugLevel get_DebugOut()
        {
            if(this.chatPeer != null)
            {
                    return 0;
            }
            
            return 0;
        }
        private void ExitGames.Client.Photon.IPhotonPeerListener.DebugReturn(ExitGames.Client.Photon.DebugLevel level, string message)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.listener.DebugReturn(level:  level, message:  message);
        }
        private void ExitGames.Client.Photon.IPhotonPeerListener.OnEvent(ExitGames.Client.Photon.EventData eventData)
        {
            if(eventData.Code > 6)
            {
                    return;
            }
            
            var val_1 = 40827788 + (eventData.Code) << 2;
            val_1 = val_1 + 40827788;
            goto (40827788 + (eventData.Code) << 2 + 40827788);
        }
        private void ExitGames.Client.Photon.IPhotonPeerListener.OnOperationResponse(ExitGames.Client.Photon.OperationResponse operationResponse)
        {
            ExitGames.Client.Photon.Chat.IChatClientListener val_4;
            string val_5;
            var val_7;
            var val_8;
            val_4 = this;
            if(operationResponse.OperationCode == 230)
            {
                    this.HandleAuthResponse(operationResponse:  operationResponse);
                return;
            }
            
            if(operationResponse.ReturnCode == 0)
            {
                    return;
            }
            
            if(operationResponse.ReturnCode == 0)
            {
                    return;
            }
            
            val_4 = this.listener;
            if(operationResponse.ReturnCode == 2)
            {
                    val_5 = System.String.Format(format:  "Chat Operation {0} unknown on server. Check your AppId and make sure it\'s for a Chat application.", arg0:  operationResponse.OperationCode);
                val_7 = null;
                var val_4 = 0;
                val_8 = 1152921505157947400;
                val_4 = val_4 + 1;
            }
            else
            {
                    val_5 = System.String.Format(format:  "Chat Operation {0} failed (Code: {1}). Debug Message: {2}", arg0:  operationResponse.OperationCode, arg1:  operationResponse.ReturnCode, arg2:  operationResponse.DebugMessage);
                val_7 = null;
                var val_5 = 0;
                val_8 = 1152921505157947400;
                val_5 = val_5 + 1;
            }
            
            val_4.DebugReturn(level:  1, message:  val_5);
        }
        private void ExitGames.Client.Photon.IPhotonPeerListener.OnStatusChanged(ExitGames.Client.Photon.StatusCode statusCode)
        {
            var val_16;
            string val_18;
            string val_19;
            string val_20;
            var val_23;
            var val_24;
            ExitGames.Client.Photon.Chat.IChatClientListener val_26;
            ExitGames.Client.Photon.Chat.IChatClientListener val_28;
            var val_30;
            val_16 = this;
            if(statusCode > 1025)
            {
                goto label_1;
            }
            
            if(statusCode == 1024)
            {
                goto label_2;
            }
            
            if(statusCode != 1025)
            {
                    return;
            }
            
            if((this.<State>k__BackingField) != 4)
            {
                goto label_4;
            }
            
            this.ConnectToFrontEnd();
            return;
            label_1:
            if(statusCode == 1048)
            {
                goto label_5;
            }
            
            if(statusCode != 1049)
            {
                    return;
            }
            
            this.<State>k__BackingField = 10;
            val_18 = public System.Void ExitGames.Client.Photon.PhotonPeer::Disconnect();
            goto label_8;
            label_2:
            if((this.chatPeer & 1) == 0)
            {
                goto label_10;
            }
            
            if(this.didAuthenticate == true)
            {
                goto label_49;
            }
            
            val_19 = this.<AppVersion>k__BackingField;
            val_20 = this.<AppId>k__BackingField;
            val_18 = val_19;
            bool val_2 = this.chatPeer.AuthenticateOnNameServer(appId:  val_20, appVersion:  val_18, region:  this.chatRegion, authValues:  this.<AuthValues>k__BackingField);
            this.didAuthenticate = val_2;
            if((val_2 == true) || (val_2 == false))
            {
                goto label_49;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            goto label_19;
            label_5:
            if(this.didAuthenticate == true)
            {
                    return;
            }
            
            val_19 = this.<AppVersion>k__BackingField;
            val_20 = this.<AppId>k__BackingField;
            bool val_5 = this.chatPeer.AuthenticateOnNameServer(appId:  val_20, appVersion:  val_19, region:  this.chatRegion, authValues:  this.<AuthValues>k__BackingField);
            this.didAuthenticate = val_5;
            if(val_5 == true)
            {
                    return;
            }
            
            if(val_5 == false)
            {
                    return;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            goto label_28;
            label_4:
            this.<State>k__BackingField = 11;
            val_23 = 1152921505157910528;
            var val_15 = 0;
            val_24 = 1152921505157947400;
            val_15 = val_15 + 1;
            val_24 = 1152921505157947416;
            goto label_33;
            label_10:
            bool val_7 = this.chatPeer.EstablishEncryption();
            label_49:
            if((this.<State>k__BackingField) == 6)
            {
                goto label_35;
            }
            
            if((this.<State>k__BackingField) != 1)
            {
                    return;
            }
            
            val_26 = this.listener;
            this.<State>k__BackingField = 2;
            var val_16 = 0;
            val_24 = 1152921505157947400;
            val_16 = val_16 + 1;
            val_18 = 3;
            goto label_41;
            label_35:
            bool val_8 = this.AuthenticateOnFrontEnd();
            return;
            label_33:
            this.listener.OnChatStateChange(state:  11);
            val_28 = this.listener;
            var val_17 = 0;
            val_24 = 1152921505157947400;
            val_17 = val_17 + 1;
            val_24 = 1152921505157947416;
            val_18 = public System.Void ExitGames.Client.Photon.Chat.IChatClientListener::OnDisconnected();
            label_8:
            val_26 = ???;
            val_30 = ???;
            val_19 = ???;
            val_20 = ???;
            val_28.OnDisconnected();
            return;
            label_41:
            val_26.OnChatStateChange(state:  2);
            return;
            label_28:
            this.DebugReturn(level:  1, message:  "Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you\'re connected. State: "("Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you\'re connected. State: ") + this.<State>k__BackingField(this.<State>k__BackingField));
            return;
            label_19:
            this.DebugReturn(level:  1, message:  "Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you\'re connected. State: "("Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you\'re connected. State: ") + this.<State>k__BackingField(this.<State>k__BackingField));
            goto label_49;
        }
        private bool SendChannelOperation(string[] channels, byte operation, int historyLength)
        {
            System.Collections.Generic.Dictionary<System.Byte, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
            val_1.Add(key:  0, value:  channels);
            if(historyLength == 0)
            {
                    return (bool)this.chatPeer.OpCustom(customOpCode:  operation, customOpParameters:  val_1, sendReliable:  true);
            }
            
            val_1.Add(key:  14, value:  historyLength);
            return (bool)this.chatPeer.OpCustom(customOpCode:  operation, customOpParameters:  val_1, sendReliable:  true);
        }
        private void HandlePrivateMessageEvent(ExitGames.Client.Photon.EventData eventData)
        {
            string val_11;
            string val_12;
            ExitGames.Client.Photon.Chat.ChatChannel val_13;
            ExitGames.Client.Photon.Chat.ChatChannel val_14;
            ExitGames.Client.Photon.Chat.ChatChannel val_15;
            object val_1 = eventData.Parameters.Item[3];
            val_11 = eventData.Parameters.Item[5];
            if(val_11 != null)
            {
                    val_11 = 0;
            }
            
            if(((this.<AuthValues>k__BackingField) == null) || ((this.<AuthValues>k__BackingField.<UserId>k__BackingField) == null))
            {
                goto label_7;
            }
            
            val_12 = val_11;
            if((this.<AuthValues>k__BackingField.<UserId>k__BackingField.Equals(value:  val_11)) == false)
            {
                goto label_12;
            }
            
            val_12 = eventData.Parameters.Item[225];
            if(val_12 == null)
            {
                goto label_12;
            }
            
            val_12 = 0;
            goto label_12;
            label_7:
            val_12 = val_11;
            label_12:
            string val_6 = this.GetPrivateChannelNameByUser(userName:  val_12);
            if((this.PrivateChannels.TryGetValue(key:  val_6, value: out  0)) != true)
            {
                    ExitGames.Client.Photon.Chat.ChatChannel val_9 = new ExitGames.Client.Photon.Chat.ChatChannel(name:  val_6);
                val_13 = val_9;
                if(val_9 == null)
            {
                    val_13 = val_9;
            }
            
                .<IsPrivate>k__BackingField = true;
                val_14 = val_13;
                if(val_13 == 0)
            {
                    val_14 = val_9;
            }
            
                mem[1152921529337660392] = this.MessageLimit;
                val_15 = val_14;
                if(val_14 == 0)
            {
                    val_15 = val_9;
            }
            
                this.PrivateChannels.Add(key:  mem[1152921529337660368], value:  val_9);
            }
            
            val_9.Add(sender:  val_11, message:  val_1);
            var val_11 = 0;
            val_11 = val_11 + 1;
            this.listener.OnPrivateMessage(sender:  val_11, message:  val_1, channelName:  val_6);
        }
        private void HandleChatMessagesEvent(ExitGames.Client.Photon.EventData eventData)
        {
            ExitGames.Client.Photon.Chat.IChatClientListener val_10;
            System.Object[] val_11;
            System.String[] val_12;
            string val_13;
            System.Collections.Generic.Dictionary<System.String, ExitGames.Client.Photon.Chat.ChatChannel> val_14;
            val_10 = this;
            ExitGames.Client.Photon.Chat.ChatChannel val_5 = 0;
            object val_1 = eventData.Parameters.Item[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            val_11 = val_1;
            if(val_11 != null)
            {
                goto label_4;
            }
            
            label_3:
            val_11 = 0;
            label_4:
            object val_3 = eventData.Parameters.Item[4];
            if(val_3 == null)
            {
                goto label_6;
            }
            
            val_12 = val_3;
            if(val_12 != null)
            {
                goto label_7;
            }
            
            label_6:
            val_12 = 0;
            label_7:
            val_13 = eventData.Parameters.Item[1];
            if(val_13 != null)
            {
                    val_13 = 0;
            }
            
            val_14 = this.PublicChannels;
            if((val_14.TryGetValue(key:  val_13, value: out  val_5)) == false)
            {
                goto label_12;
            }
            
            val_14 = val_5;
            val_14.Add(senders:  val_12, messages:  val_11);
            val_10 = this.listener;
            var val_10 = 0;
            val_10 = val_10 + 1;
            goto label_18;
            label_12:
            if(1152921529335987328 < 2)
            {
                    return;
            }
            
            val_10 = this.listener;
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_25;
            label_18:
            val_10.OnGetMessages(channelName:  val_13, senders:  val_12, messages:  val_11);
            return;
            label_25:
            val_10.DebugReturn(level:  2, message:  "Channel " + val_13 + " for incoming message event not found.");
        }
        private void HandleSubscribeEvent(ExitGames.Client.Photon.EventData eventData)
        {
            System.String[] val_7;
            string val_8;
            System.Boolean[] val_9;
            var val_10;
            object val_1 = eventData.Parameters.Item[0];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            val_7 = val_1;
            if(val_7 != null)
            {
                goto label_4;
            }
            
            label_3:
            val_7 = 0;
            label_4:
            val_8 = eventData.Parameters.Item[15];
            if(val_8 == null)
            {
                goto label_6;
            }
            
            val_9 = val_8;
            if(val_9 != null)
            {
                goto label_7;
            }
            
            label_6:
            val_9 = 0;
            label_7:
            val_10 = 0;
            goto label_8;
            label_19:
            if(64 != 0)
            {
                    var val_4 = val_7 + 0;
                val_8 = mem[(val_7 + 0) + 32];
                val_8 = (val_7 + 0) + 32;
                if((this.PublicChannels.ContainsKey(key:  val_8)) != true)
            {
                    ExitGames.Client.Photon.Chat.ChatChannel val_6 = new ExitGames.Client.Photon.Chat.ChatChannel(name:  val_8);
                if(val_6 != null)
            {
                    .MessageLimit = this.MessageLimit;
                val_8 = this.PublicChannels;
            }
            else
            {
                    mem[40] = this.MessageLimit;
                val_8 = this.PublicChannels;
            }
            
                val_8.Add(key:  (ExitGames.Client.Photon.Chat.ChatChannel)[1152921529338064912].Name, value:  val_6);
            }
            
            }
            
            val_10 = 1;
            label_8:
            if(val_10 < 10260432)
            {
                goto label_19;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            this.listener.OnSubscribed(channels:  val_7, results:  val_9);
        }
        private void HandleUnsubscribeEvent(ExitGames.Client.Photon.EventData eventData)
        {
            string val_6;
            var val_7;
            System.String[] val_8;
            var val_9;
            val_7 = 0;
            object val_1 = eventData.Item[0];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            val_6 = null;
            val_8 = val_1;
            if(val_8 != null)
            {
                goto label_3;
            }
            
            val_7 = 0;
            label_2:
            val_8 = 0;
            label_3:
            val_9 = 0;
            goto label_4;
            label_9:
            val_6 = 64;
            bool val_3 = this.PublicChannels.Remove(key:  val_6);
            val_7 = public System.Boolean System.Collections.Generic.HashSet<System.String>::Remove(System.String item);
            bool val_4 = this.PublicChannelsUnsubscribing.Remove(item:  val_6);
            val_9 = 1;
            label_4:
            if(val_9 < 10260432)
            {
                goto label_9;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = 7;
            this.listener.OnUnsubscribed(channels:  val_8);
        }
        private void HandleAuthResponse(ExitGames.Client.Photon.OperationResponse operationResponse)
        {
            var val_19;
            var val_20;
            ExitGames.Client.Photon.Chat.ChatPeer val_21;
            ExitGames.Client.Photon.DebugLevel val_23;
            string val_24;
            var val_25;
            ExitGames.Client.Photon.Chat.ChatDisconnectCause val_27;
            var val_29;
            ExitGames.Client.Photon.Chat.AuthenticationValues val_31;
            var val_32;
            string val_35;
            string val_36;
            val_19 = operationResponse;
            val_20 = this;
            val_21 = this.chatPeer;
            if(true >= 3)
            {
                    val_21 = this.listener;
                var val_18 = 0;
                val_18 = val_18 + 1;
                val_23 = 3;
                val_24 = val_19.ToStringFull() + " on: "(" on: ") + this.chatPeer.GetNameServerAddress();
                val_21.DebugReturn(level:  val_23, message:  val_24);
            }
            
            if(operationResponse.ReturnCode == (-3))
            {
                goto label_11;
            }
            
            if(operationResponse.ReturnCode != 0)
            {
                goto label_12;
            }
            
            if((this.<State>k__BackingField) == 6)
            {
                goto label_13;
            }
            
            if((this.<State>k__BackingField) != 2)
            {
                    return;
            }
            
            this.<State>k__BackingField = 4;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_25 = 3;
            goto label_19;
            label_11:
            val_27 = 9;
            goto label_22;
            label_12:
            var val_20 = 32754;
            val_20 = ((int)operationResponse.ReturnCode & 65535) + val_20;
            if(val_20 >= 3)
            {
                goto label_21;
            }
            
            val_27 = mem[40827816 + (((int)(short)((operationResponse.ReturnCode) & 0xFFFF) + 32754)) << 2];
            val_27 = 40827816 + (((int)(short)((operationResponse.ReturnCode) & 0xFFFF) + 32754)) << 2;
            goto label_22;
            label_21:
            if(((int)operationResponse.ReturnCode & 65535) != 32767)
            {
                goto label_23;
            }
            
            val_27 = 6;
            label_22:
            this.<DisconnectedCause>k__BackingField = val_27;
            label_23:
            val_21 = this.chatPeer;
            if(val_27 != 0)
            {
                    val_21 = this.listener;
                var val_21 = 0;
                val_21 = val_21 + 1;
                val_23 = 1;
                val_21.DebugReturn(level:  val_23, message:  "Authentication request error: "("Authentication request error: ") + operationResponse.ReturnCode + ". Disconnecting.");
            }
            
            this.<State>k__BackingField = 10;
            if(this.chatPeer != null)
            {
                goto label_60;
            }
            
            label_61:
            label_60:
            this.chatPeer.Disconnect();
            return;
            label_13:
            this.<State>k__BackingField = 7;
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_29 = 3;
            goto label_36;
            label_19:
            this.listener.OnChatStateChange(state:  4);
            if((operationResponse.Parameters.ContainsKey(key:  221)) == false)
            {
                goto label_39;
            }
            
            val_31 = this.<AuthValues>k__BackingField;
            if(val_31 == null)
            {
                goto label_40;
            }
            
            val_32 = val_19.Item[221];
            if(val_32 != null)
            {
                goto label_41;
            }
            
            goto label_56;
            label_39:
            if((public System.Boolean System.Collections.Generic.Dictionary<System.Byte, System.Object>::ContainsKey(System.Byte key)) == 0)
            {
                    return;
            }
            
            var val_23 = 0;
            val_23 = val_23 + 1;
            goto label_49;
            label_36:
            this.listener.OnChatStateChange(state:  7);
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_19 = ???;
            val_20 = ???;
            this.listener.OnConnected();
            return;
            label_40:
            ExitGames.Client.Photon.Chat.AuthenticationValues val_12 = null;
            val_31 = val_12;
            .authType = 255;
            val_12 = new ExitGames.Client.Photon.Chat.AuthenticationValues();
            this.<AuthValues>k__BackingField = val_31;
            val_32 = val_19.Item[221];
            if(val_32 == null)
            {
                goto label_56;
            }
            
            label_41:
            var val_14 = (null == static_value_032D1378) ? (val_32) : 0;
            goto label_57;
            label_56:
            val_35 = 0;
            label_57:
            this.<AuthValues>k__BackingField.<Token>k__BackingField = val_35;
            if(val_19.Item[230] != null)
            {
                    val_36 = 0;
            }
            
            this.<FrontendAddress>k__BackingField = val_36;
            if(this.chatPeer != null)
            {
                goto label_60;
            }
            
            goto label_61;
            label_49:
            this.listener.DebugReturn(level:  1, message:  "No secret in authentication response.");
        }
        private void HandleStatusUpdate(ExitGames.Client.Photon.EventData eventData)
        {
            string val_8;
            object val_9;
            val_8 = eventData.Parameters.Item[5];
            if(val_8 != null)
            {
                    val_8 = 0;
            }
            
            eventData.Parameters.Item[10].Add(driver:  10, rectTransform:  public System.Object System.Collections.Generic.Dictionary<System.Byte, System.Object>::get_Item(System.Byte key), drivenProperties:  null);
            bool val_4 = eventData.Parameters.ContainsKey(key:  3);
            if(val_4 != false)
            {
                    val_9 = eventData.Parameters.Item[3];
            }
            else
            {
                    val_9 = 0;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            this.listener.OnStatusUpdate(user:  val_8, status:  21192704, gotMessage:  val_4, message:  val_9);
        }
        private void ConnectToFrontEnd()
        {
            this.<State>k__BackingField = 6;
            if(6 > 2)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                this.listener.DebugReturn(level:  3, message:  "Connecting to frontend " + this.<FrontendAddress>k__BackingField(this.<FrontendAddress>k__BackingField));
            }
            
            bool val_3 = this.chatPeer.Connect(serverAddress:  this.<FrontendAddress>k__BackingField, applicationName:  "chat");
        }
        private bool AuthenticateOnFrontEnd()
        {
            ExitGames.Client.Photon.Chat.IChatClientListener val_4;
            var val_6;
            string val_7;
            var val_8;
            val_4 = this;
            if((this.<AuthValues>k__BackingField) == null)
            {
                goto label_1;
            }
            
            if((this.<AuthValues>k__BackingField.<Token>k__BackingField) != null)
            {
                    if((System.String.op_Equality(a:  this.<AuthValues>k__BackingField.<Token>k__BackingField, b:  "")) == false)
            {
                goto label_3;
            }
            
            }
            
            val_4 = this.listener;
            val_6 = null;
            val_7 = "Can\'t authenticate on front end server. Secret is not set";
            var val_4 = 0;
            val_8 = 1152921505157947400;
            val_4 = val_4 + 1;
            goto label_17;
            label_1:
            if((this.<AuthValues>k__BackingField) == null)
            {
                    return false;
            }
            
            val_4 = this.listener;
            val_6 = null;
            val_7 = "Can\'t authenticate on front end server. Authentication Values are not set";
            var val_5 = 0;
            val_8 = 1152921505157947400;
            val_5 = val_5 + 1;
            goto label_17;
            label_3:
            System.Collections.Generic.Dictionary<System.Byte, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
            val_2.Add(key:  221, value:  this.<AuthValues>k__BackingField.<Token>k__BackingField);
            if(this.chatPeer != null)
            {
                    return this.chatPeer.OpCustom(customOpCode:  230, customOpParameters:  val_2, sendReliable:  true);
            }
            
            return this.chatPeer.OpCustom(customOpCode:  230, customOpParameters:  val_2, sendReliable:  true);
            label_17:
            val_4.DebugReturn(level:  1, message:  val_7);
            return false;
        }
    
    }

}
