using UnityEngine;

namespace InkWars.Model
{
    [Serializable]
    public class PlayerState
    {
        // Fields
        internal bool IsLocalPlayer;
        public bool _characterLocked;
        public InkWars.Model.Controller_Network_PlayerState _state;
        public CharacterNameID _characterNameID;
        public int _gameDuration;
        
        // Properties
        public bool CharacterLocked { get; set; }
        public InkWars.Model.Controller_Network_PlayerState State { get; set; }
        public CharacterNameID CharacterNameID { get; set; }
        public int GameDuration { get; set; }
        
        // Methods
        public bool get_CharacterLocked()
        {
            return (bool)this._characterLocked;
        }
        public void set_CharacterLocked(bool value)
        {
            var val_22;
            bool val_23;
            bool val_24;
            var val_25;
            var val_27;
            var val_28;
            val_23 = value;
            val_24 = val_23;
            this._characterLocked = val_24;
            val_25 = null;
            if(this.IsLocalPlayer == false)
            {
                goto label_1;
            }
            
            InkWars.Model.MVC_Multiplayer_Manager_Base val_1 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            InkWars.Model.MVC_Multiplayer_Manager_Base val_3 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            val_3.Player1Locked = val_24;
            val_22 = InkWars.Model.Controller_Network_NF.Instance;
            val_27 = 0;
            val_24 = ((val_1.Player1Locked == true) ? 1 : 0) ^ val_23;
            val_22.RefreshPlayerState();
            if(this._characterLocked != false)
            {
                    val_28 = InkWars.Model.Controller_Network_NF.Instance;
                val_27 = 1;
                val_28.SendPlayerData(onlyUpdateData:  true);
            }
            
            if(val_24 == false)
            {
                    return;
            }
            
            label_21:
            val_25 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            val_23 = ???;
            val_22 = ???;
            val_24 = ???;
            goto typeof(InkWars.Model.MVC_Multiplayer_Manager_Base).__il2cppRuntimeField_1F8;
            label_1:
            InkWars.Model.MVC_Multiplayer_Manager_Base val_7 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            val_28 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            val_10.Player2Locked = val_24;
            if(((((val_7.Player2Locked == true) ? 1 : 0) ^ val_23) & 1) != 0)
            {
                goto label_21;
            }
        
        }
        public InkWars.Model.Controller_Network_PlayerState get_State()
        {
            return (InkWars.Model.Controller_Network_PlayerState)this._state;
        }
        public void set_State(InkWars.Model.Controller_Network_PlayerState value)
        {
            this._state = value;
            if(this.IsLocalPlayer == false)
            {
                    return;
            }
            
            InkWars.Model.Controller_Network_NF.Instance.RefreshPlayerState();
        }
        public CharacterNameID get_CharacterNameID()
        {
            return (CharacterNameID)this._characterNameID;
        }
        public void set_CharacterNameID(CharacterNameID value)
        {
            this._characterNameID = value;
            if(this.IsLocalPlayer != false)
            {
                    InkWars.Model.MVC_Multiplayer_Manager_Base val_1 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
                val_1.Player1 = value;
                Character_GlobalInfo.SetLeftPlayer(nameID:  value);
                InkWars.Model.Controller_Network_NF.Instance.RefreshPlayerState();
                return;
            }
            
            Character_GlobalInfo.SetRightPlayer(nameID:  value);
            InkWars.Model.MVC_Multiplayer_Manager_Base val_3 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            val_3.Player2 = value;
        }
        public int get_GameDuration()
        {
            return (int)this._gameDuration;
        }
        public void set_GameDuration(int value)
        {
            var val_3;
            var val_4;
            if(value == 0)
            {
                    return;
            }
            
            if(this.IsLocalPlayer != false)
            {
                    val_3 = null;
                val_3 = null;
                Character_GlobalInfo.gameDuration = value;
                this._gameDuration = value;
                InkWars.Model.Controller_Network_NF.Instance.RefreshPlayerState();
                return;
            }
            
            InkWars.Model.Controller_Network_NF val_2 = InkWars.Model.Controller_Network_NF.Instance;
            if(val_2.IsHost == true)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            Character_GlobalInfo.gameDuration = value;
            this._gameDuration = value;
        }
        public PlayerState()
        {
        
        }
    
    }

}
