using UnityEngine;

namespace InkWars.Model
{
    public class MVC_Multiplayer_Manager : MVC_Multiplayer_Manager_Base
    {
        // Fields
        public UnityEngine.GameObject State_Rematch;
        public UnityEngine.GameObject ChallengeDialog;
        public TMPro.TextMeshProUGUI ChallengeDialogUsername;
        public TMPro.TextMeshProUGUI ChallengeDialogPlayerPoints;
        public TMPro.TextMeshProUGUI ChallengeDialogPlayerWins;
        public TMPro.TextMeshProUGUI ChallengeDialogPlayerLosses;
        public TMPro.TextMeshProUGUI ChallengeDialogPlayerDraws;
        public UnityEngine.UI.Image ChallengeDialogFlag;
        public UnityEngine.UI.Image ChallengeDialogAvatar;
        public CustomTitle ChallengeDialogueTitle;
        public InkWars.Model.CharacterSelectObjects CharacterSelect_Player1;
        public InkWars.Model.CharacterSelectObjects CharacterSelect_Player2;
        public static bool usingPrevAutoStartFlag;
        
        // Methods
        public override void SetState(InkWars.Model.MVC_Multiplayer_Manager_Base.MVC_Multiplayer_States value)
        {
            var val_26;
            var val_27;
            UnityEngine.Transform val_30;
            UnityEngine.GameObject val_31;
            var val_33;
            var val_34;
            InkWars.Model.Controller_Network_PlayerState val_35;
            var val_36;
            var val_37;
            InkWars.Model.PlayerState val_38;
            var val_39;
            System.Collections.IEnumerator val_2 = transform.GetEnumerator();
            label_22:
            var val_26 = 0;
            val_26 = val_26 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_26 = val_2.Current;
            if(val_26 != null)
            {
                    val_26 = 0;
            }
            
            UnityEngine.Object.Destroy(obj:  val_26.gameObject);
            goto label_22;
            label_8:
            val_27 = 0;
            val_30 = 1152921504621170688;
            val_31 = val_2;
            if(val_31 != null)
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_31.Dispose();
            }
            
            if(value == 1)
            {
                goto label_38;
            }
            
            if(value == 2)
            {
                goto label_39;
            }
            
            if(value != 3)
            {
                goto label_44;
            }
            
            UnityEngine.Coroutine val_14 = this.StartCoroutine(routine:  this.BeginRematch());
            return;
            label_38:
            val_33 = null;
            val_33 = null;
            InkWars.Model.MVC_Multiplayer_Manager_Base.fightAnyLevel = false;
            mem[1152921529312103980] = 0;
            goto label_44;
            label_39:
            val_34 = null;
            val_34 = null;
            if(Character_GlobalInfo.gameMode == 6)
            {
                    InkWars.Model.MVC_Multiplayer_Manager_Base.MatchState = 1;
            }
            
            UnityEngine.GameObject val_15 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  1152921505064992768);
            goto label_52;
            label_59:
            val_30 = transform;
            val_15.transform.GetChild(index:  0).SetParent(p:  val_30);
            label_52:
            UnityEngine.Transform val_19 = val_15.transform;
            if(val_19.childCount > 0)
            {
                goto label_59;
            }
            
            UnityEngine.Object.Destroy(obj:  val_15);
            InkWars.Model.Model_Manager val_21 = InkWars.Model.Model_Manager.Instance;
            val_21.leftPlayerID = val_19;
            InkWars.Model.Model_Manager val_22 = InkWars.Model.Model_Manager.Instance;
            val_22.rightPlayerID = val_19;
            label_44:
            val_22.SetActive(value:  (value == 0) ? 1 : 0);
            val_22.SetActive(value:  (value == 1) ? 1 : 0);
            val_22.SetActive(value:  (value == 2) ? 1 : 0);
            val_31 = this.State_Rematch;
            val_35 = 0;
            val_31.SetActive(value:  false);
            if(value == 2)
            {
                goto label_68;
            }
            
            if(value == 1)
            {
                goto label_69;
            }
            
            if(value != 0)
            {
                    return;
            }
            
            val_36 = null;
            val_36 = null;
            val_35 = 0;
            goto label_74;
            label_68:
            val_37 = null;
            val_37 = null;
            val_38 = InkWars.Model.Controller_Network_NF.ThisPlayer;
            val_35 = 5;
            goto label_78;
            label_69:
            val_39 = null;
            val_39 = null;
            val_38 = InkWars.Model.Controller_Network_NF.ThisPlayer;
            val_35 = 2;
            label_78:
            label_74:
            val_38.State = val_35;
        }
        private System.Collections.IEnumerator BeginRematch()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new MVC_Multiplayer_Manager.<BeginRematch>d__13();
        }
        public override System.Collections.IEnumerator Start()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new MVC_Multiplayer_Manager.<Start>d__15();
        }
        public override void Update()
        {
            UnityEngine.Events.UnityAction val_13;
            var val_14;
            var val_15;
            float val_16;
            float val_17;
            val_13 = 1152921505155833856;
            InkWars.Model.MVCNetworkManager val_1 = InkWars.Model.MVCNetworkManager.Instance;
            if((val_1.hostMatchTimeout > 0f) && (MVC_Bot_Base.NetworkControlMode == 0))
            {
                    val_14 = null;
                val_14 = null;
                val_13 = InkWars.Model.MVCNetworkManager.Instance;
                this.PrintState(state:  (InkWars.Model.MVC_Multiplayer_Manager_Base.fightAnyLevel == true) ? "Waiting for an opponent of<br><color=#FFE300FF>ANY skill level</color>..." : "Waiting for an opponent of<br>a <color=#FFE300FF>SIMILAR skill level</color>..."((InkWars.Model.MVC_Multiplayer_Manager_Base.fightAnyLevel == true) ? "Waiting for an opponent of<br><color=#FFE300FF>ANY skill level</color>..." : "Waiting for an opponent of<br>a <color=#FFE300FF>SIMILAR skill level</color>...") + UnityEngine.Mathf.FloorToInt(f:  val_3.hostMatchTimeout)(UnityEngine.Mathf.FloorToInt(f:  val_3.hostMatchTimeout)), showLog:  false);
                val_15 = InkWars.Model.MVCNetworkManager.Instance;
                if(val_15 != null)
            {
                    val_16 = val_6.hostMatchTimeout;
                val_17 = UnityEngine.Time.deltaTime;
            }
            else
            {
                    val_15 = 52;
                val_16 = 5.142877E-39f;
                float val_8 = UnityEngine.Time.deltaTime;
                val_17 = val_8;
            }
            
                val_8 = val_16 - val_17;
                mem[52] = val_8;
                InkWars.Model.MVCNetworkManager val_9 = InkWars.Model.MVCNetworkManager.Instance;
                if(val_9.hostMatchTimeout <= 0f)
            {
                    mem[1152921529312557816] = 4;
                UnityEngine.Events.UnityAction val_11 = null;
                val_13 = val_11;
                val_11 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void InkWars.Model.MVC_Multiplayer_Manager::<Update>b__16_1());
                mem[1152921529312557752] = DialogManager.ShowConfirmDialog(title:  "No opponent with similar skill level currently available", message:  "Do you wish to play against ANY skill levelled opponent?", confirmButtonTitle:  "Yes", cancelButtonTitle:  "Keep Waiting", onConfirmCallback:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void InkWars.Model.MVC_Multiplayer_Manager::<Update>b__16_0()), onCancelCallback:  val_11);
            }
            
            }
            
            this.Update();
        }
        public override void OnReceivedPlayerData(NetworkUserInfo sharedPlayerData)
        {
            this.ChallengeDialogUsername.text = sharedPlayerData.userName;
            this.ChallengeDialogPlayerPoints.text = sharedPlayerData.playerPoint.ToString();
            this.ChallengeDialogPlayerWins.text = "W: "("W: ") + sharedPlayerData.win.ToString();
            this.ChallengeDialogPlayerLosses.text = "L: "("L: ") + sharedPlayerData.lose.ToString();
            this.ChallengeDialogPlayerDraws.text = "D: "("D: ") + sharedPlayerData.draw.ToString();
            this.ChallengeDialogFlag.sprite = NetworkUtils.GetCountry(_flag:  sharedPlayerData.flag);
            this.ChallengeDialogAvatar.sprite = AvatarCollection.GetAvatarSpriteFromIntId(id:  sharedPlayerData.avatarID);
            this.ChallengeDialogueTitle.Setup(title:  TitleCollection.GetTitleFromIntId(id:  sharedPlayerData.titleID));
            this.ChallengeDialog.SetActive(value:  true);
            CommonSoundSfx val_12 = GameAudio.commonSounds;
            UnityEngine.AudioSource val_13 = GameAudio.sound.PlayOneShot(clip:  val_12.correctSound, volume:  1f);
            UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  this.TransitionToGame());
        }
        private System.Collections.IEnumerator TransitionToGame()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new MVC_Multiplayer_Manager.<TransitionToGame>d__18();
        }
        public void CharacterNext(int playerID)
        {
            CharacterNameID val_3;
            var val_4;
            GameMode val_5;
            var val_6;
            if(playerID != 0)
            {
                    val_3 = public static CharacterNameID GenericFunctions::NextEnum<CharacterNameID>(CharacterNameID src);
                mem[1152921529313177448] = GenericFunctions.NextEnum<CharacterNameID>(src:  23139);
            }
            else
            {
                    val_3 = public static CharacterNameID GenericFunctions::NextEnum<CharacterNameID>(CharacterNameID src);
                mem[1152921529313177444] = GenericFunctions.NextEnum<CharacterNameID>(src:  23139);
                val_4 = null;
                val_4 = null;
                val_5 = Character_GlobalInfo.gameMode;
                if(val_5 != 6)
            {
                    val_5 = Character_GlobalInfo.gameMode;
                if(val_5 != 10)
            {
                goto typeof(InkWars.Model.MVC_Multiplayer_Manager).__il2cppRuntimeField_1F8;
            }
            
            }
            
                val_6 = null;
                val_6 = null;
                val_3 = 53673984;
                InkWars.Model.Controller_Network_NF.ThisPlayer.CharacterNameID = static_value_03330000;
            }
        
        }
        public void CharacterPrevious(int playerID)
        {
            CharacterNameID val_3;
            var val_4;
            GameMode val_5;
            var val_6;
            if(playerID != 0)
            {
                    val_3 = public static CharacterNameID GenericFunctions::PrevEnum<CharacterNameID>(CharacterNameID src);
                mem[1152921529313306856] = GenericFunctions.PrevEnum<CharacterNameID>(src:  23140);
            }
            else
            {
                    val_3 = public static CharacterNameID GenericFunctions::PrevEnum<CharacterNameID>(CharacterNameID src);
                mem[1152921529313306852] = GenericFunctions.PrevEnum<CharacterNameID>(src:  23140);
                val_4 = null;
                val_4 = null;
                val_5 = Character_GlobalInfo.gameMode;
                if(val_5 != 6)
            {
                    val_5 = Character_GlobalInfo.gameMode;
                if(val_5 != 10)
            {
                goto typeof(InkWars.Model.MVC_Multiplayer_Manager).__il2cppRuntimeField_1F8;
            }
            
            }
            
                val_6 = null;
                val_6 = null;
                val_3 = 53673984;
                InkWars.Model.Controller_Network_NF.ThisPlayer.CharacterNameID = static_value_03330000;
            }
        
        }
        public void ClickedCharacterLocked(int playerId)
        {
            var val_1;
            GameMode val_2;
            var val_3;
            val_1 = null;
            val_1 = null;
            val_2 = Character_GlobalInfo.gameMode;
            if(val_2 == 6)
            {
                goto label_3;
            }
            
            val_2 = Character_GlobalInfo.gameMode;
            if(val_2 != 10)
            {
                goto label_6;
            }
            
            label_3:
            val_3 = null;
            val_3 = null;
            InkWars.Model.Controller_Network_NF.ThisPlayer.CharacterLocked = true;
            goto typeof(InkWars.Model.MVC_Multiplayer_Manager).__il2cppRuntimeField_1F8;
            label_6:
            mem[1152921529313427036] = 257;
            goto typeof(InkWars.Model.MVC_Multiplayer_Manager).__il2cppRuntimeField_1F8;
        }
        public override void RefreshCharacterData()
        {
            if(W8 != 1)
            {
                    return;
            }
            
            if(W8 == 0)
            {
                    return;
            }
            
            if(W8 == 0)
            {
                    return;
            }
            
            this.ShutVSGateAndStartGame();
        }
        internal override void OnCreatePrivateRoom(string randomPin)
        {
        
        }
        public MVC_Multiplayer_Manager()
        {
            mem[1152921529313771216] = 1084227584;
            mem[1152921529313771224] = 1084227584;
            mem[1152921529313771232] = 0;
            this = new UnityEngine.MonoBehaviour();
        }
        private static MVC_Multiplayer_Manager()
        {
        
        }
        private System.Collections.IEnumerator <>n__0()
        {
            return this.Start();
        }
        private void <Update>b__16_0()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            InkWars.Model.MVC_Multiplayer_Manager_Base.fightAnyLevel = true;
            val_2 = null;
            val_2 = null;
            InkWars.Model.MVC_Multiplayer_Manager.usingPrevAutoStartFlag = true;
            this.ShutdownNetwork(forceAutoStart:  true, couldBeRageQuit:  false, reloadScene:  true, delay:  0f, notifyUser:  true);
        }
        private void <Update>b__16_1()
        {
            InkWars.Model.MVCNetworkManager val_1 = InkWars.Model.MVCNetworkManager.Instance;
            val_1.hostMatchTimeout = 5.260337E-37f;
        }
    
    }

}
