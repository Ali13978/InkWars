using UnityEngine;

namespace InkWars.Model
{
    public class Model_Manager : MonoBehaviour
    {
        // Fields
        public const bool UseMVCForAdventure = True;
        private static InkWars.Model.Model_Manager _instance;
        public UnityEngine.GameObject template_GameSceneActivator;
        private GameMode gameMode;
        private int adventureModeStage;
        public CharacterNameID leftPlayerID;
        public CharacterNameID rightPlayerID;
        public InkWars.Model.Model_Core Model;
        
        // Properties
        public static InkWars.Model.Model_Manager Instance { get; }
        
        // Methods
        public static InkWars.Model.Model_Manager get_Instance()
        {
            var val_15;
            InkWars.Model.Model_Manager val_16;
            if(InkWars.Model.Model_Manager._instance == 0)
            {
                    InkWars.Model.Model_Manager._instance = UnityEngine.Object.FindObjectOfType<InkWars.Model.Model_Manager>();
            }
            
            if(InkWars.Model.Model_Manager._instance != 0)
            {
                goto label_21;
            }
            
            val_15 = 0;
            goto label_11;
            label_23:
            T val_15 = UnityEngine.Object.FindObjectsOfType<UnityEngine.GameObject>()[0];
            if((UnityEngine.Object.op_Implicit(exists:  val_15.transform.parent)) == true)
            {
                goto label_17;
            }
            
            InkWars.Model.Model_Manager._instance = val_15.GetComponentInChildren<InkWars.Model.Model_Manager>(includeInactive:  true);
            if((UnityEngine.Object.op_Implicit(exists:  InkWars.Model.Model_Manager._instance)) == true)
            {
                goto label_21;
            }
            
            label_17:
            val_15 = 1;
            label_11:
            if(val_15 < val_4.Length)
            {
                goto label_23;
            }
            
            label_21:
            val_16 = InkWars.Model.Model_Manager._instance;
            if(val_16 != 0)
            {
                    return (InkWars.Model.Model_Manager)InkWars.Model.Model_Manager._instance;
            }
            
            val_16 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            if(0 == val_16)
            {
                    return (InkWars.Model.Model_Manager)InkWars.Model.Model_Manager._instance;
            }
            
            InkWars.Model.MVC_Multiplayer_Manager_Base val_13 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            val_16 = val_13.State_Game;
            InkWars.Model.Model_Manager._instance = val_16.GetComponentInChildren<InkWars.Model.Model_Manager>(includeInactive:  true);
            return (InkWars.Model.Model_Manager)InkWars.Model.Model_Manager._instance;
        }
        private int[] RefreshArray(float[] originalData, float[] newData)
        {
            int[] val_1 = new int[0];
            if(originalData.Length < 1)
            {
                    return (System.Int32[])val_1;
            }
            
            do
            {
                val_1[0] = System.Array.IndexOf<System.Single>(array:  newData, value:  originalData[0]);
            }
            while((0 + 1) < originalData.Length);
            
            return (System.Int32[])val_1;
        }
        public void Awake()
        {
            CharacterNameID val_12;
            CharacterClan val_13;
            string val_14;
            var val_18;
            int val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_56;
            string val_57;
            string val_58;
            MVC_Bot2_Settings val_59;
            var val_60;
            var val_61;
            var val_63;
            JSONGridData val_64;
            var val_65;
            InkWars.Model.Model_Core val_66;
            var val_67;
            var val_68;
            GameMode val_69;
            InkWars.Model.Model_Core val_70;
            var val_71;
            var val_72;
            var val_73;
            var val_74;
            val_51 = this;
            UnityEngine.AsyncOperation val_1 = UnityEngine.Resources.UnloadUnusedAssets();
            val_52 = null;
            val_52 = null;
            DataStructs.UserDataDictionary.Stats.ResetAdventureStats();
            val_53 = null;
            val_53 = null;
            .CountdownTime = Character_GlobalInfo.gameDuration;
            this.Model = new InkWars.Model.Model_Core();
            mem[1152921529274824432] = this.Model;
            mem[1152921529274824440] = public System.Void InkWars.Model.Model_Core::OnBeforePostMatch();
            mem[1152921529274824416] = public System.Void InkWars.Model.Model_Core::OnBeforePostMatch();
            InkWars.Model.Model_Events.Instance.remove_OnBeforePostMatch(value:  new Model_Events.OnBeforePostMatchDelegate());
            mem[1152921529274836720] = this.Model;
            mem[1152921529274836728] = public System.Void InkWars.Model.Model_Core::OnBeforePostMatch();
            mem[1152921529274836704] = public System.Void InkWars.Model.Model_Core::OnBeforePostMatch();
            InkWars.Model.Model_Events.Instance.add_OnBeforePostMatch(value:  new Model_Events.OnBeforePostMatchDelegate());
            if((MVC_GameScene_Activator.instance == 0) && ((UnityEngine.Object.op_Implicit(exists:  this.template_GameSceneActivator)) != false))
            {
                    UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.template_GameSceneActivator).GetComponent<MVC_GameScene_Activator>().LoadNextScene_InitialiseScene());
                val_54 = null;
                val_54 = null;
                if(Character_GlobalInfo.gameMode == 0)
            {
                    Character_GlobalInfo.gameMode = this.gameMode;
            }
            
            }
            
            this.Model.SetupFlip();
            val_56 = null;
            val_56 = null;
            if(Character_GlobalInfo.charactersInitiated != true)
            {
                    Character_GlobalInfo.SetLeftPlayer(nameID:  this.leftPlayerID);
                Character_GlobalInfo.SetRightPlayer(nameID:  this.rightPlayerID);
                val_56 = null;
            }
            
            CharacterInfo val_11 = Character_GlobalInfo.GetLeftPlayer();
            CharacterInfo val_16 = Character_GlobalInfo.GetRightPlayer();
            val_57 = val_18;
            val_58 = "GameData/";
            val_59 = 0;
            if(InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch != false)
            {
                    val_60 = null;
                val_60 = null;
                val_59 = mem[InkWars.Model.MVC_Multiplayer_Manager_Base.BotProfile + 88];
                val_59 = InkWars.Model.MVC_Multiplayer_Manager_Base.BotProfile.SkillSettings;
            }
            
            val_61 = null;
            val_61 = null;
            Character_GlobalInfo.inkProcessFull = false;
            Character_GlobalInfo.firstTimePassPuzzle = false;
            GameMode val_51 = Character_GlobalInfo.gameMode;
            val_51 = val_51 - 1;
            if(val_51 > 3)
            {
                goto label_40;
            }
            
            var val_52 = 40830504 + ((this.gameMode - 1)) << 2;
            val_52 = val_52 + 40830504;
            goto (40830504 + ((this.gameMode - 1)) << 2 + 40830504);
            label_40:
            val_63 = 1152921505064992768;
            val_64 = UnityEngine.JsonUtility.FromJson<JSONGridData>(json:  CMS.IO.ReadOnlyDataFile.Load(path:   +  + null, type:  1));
            if( != null)
            {
                    MVC_Bot2 val_37 = UnityEngine.Object.FindObjectOfType<MVC_Bot2>();
                val_58 = val_37;
                if(val_37 == 0)
            {
                    UnityEngine.GameObject val_39 = new UnityEngine.GameObject();
                if(val_39 != null)
            {
                    val_39.SetActive(value:  false);
            }
            else
            {
                    val_39.SetActive(value:  false);
            }
            
                val_58 = val_39.AddComponent<MVC_Bot2>();
            }
            
                if(val_58 != null)
            {
                    val_40.Settings = ;
                val_58.ControlsPlayer2 = true;
            }
            else
            {
                    mem[80] = ;
                0.ControlsPlayer2 = true;
            }
            
                val_58.gameObject.SetActive(value:  true);
            }
            
            this.Model.Player1.Name = val_12;
            this.Model.Player1.Clan = val_13;
            this.Model.Player1.<buff>k__BackingField.LoadFromLocalPlayer();
            NetworkUserInfo val_42 = CloudOpponent.current;
            this.Model.Player2.<buff>k__BackingField = val_42.buff;
            val_65 = null;
            this.PopulateGrid(GridData:  UnityEngine.JsonUtility.FromJson<JSONGridData>(json:  CMS.IO.ReadOnlyDataFile.Load(path:  val_58 + val_14 + ".json", type:  1)), player:  this.Model.Player1, forceEmpty:  (Character_GlobalInfo.gameMode == 3) ? 1 : 0);
            this.PopulateGrid(GridData:  val_64, player:  this.Model.Player2, forceEmpty:  false);
            if(Character_GlobalInfo.gameMode == 3)
            {
                    InkWars.Model.Model_Manager.ShuffleGrid(player:  this.Model.Player2);
            }
            
            this.SetSpeedAndAttack(player:  this.Model.Player1, isOpponent:  false);
            this.SetSpeedAndAttack(player:  this.Model.Player2, isOpponent:  true);
            val_66 = this.Model;
            if(this.Model != null)
            {
                goto label_86;
            }
            
            val_66 = this.Model;
            if(val_66 == null)
            {
                goto label_101;
            }
            
            label_86:
            this.PopulateTargetBubbles(player:  this.Model.Player1, otherPlayer:  this.Model.Player2);
            val_67 = null;
            val_67 = null;
            if((InkWars.Model.MVC_Multiplayer_Manager_Base.IsOfflineGame == true) || (InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch == true))
            {
                goto label_93;
            }
            
            val_68 = null;
            val_68 = null;
            val_69 = Character_GlobalInfo.gameMode;
            if(val_69 == 6)
            {
                goto label_99;
            }
            
            val_69 = Character_GlobalInfo.gameMode;
            if(val_69 == 10)
            {
                goto label_99;
            }
            
            label_93:
            val_70 = this.Model;
            if(this.Model != null)
            {
                goto label_100;
            }
            
            val_70 = this.Model;
            if(val_70 == null)
            {
                goto label_101;
            }
            
            label_100:
            this.PopulateTargetBubbles(player:  this.Model.Player2, otherPlayer:  this.Model.Player1);
            label_99:
            this.SubscribeToFeatures();
            val_71 = null;
            val_71 = null;
            if(Character_GlobalInfo.gameMode == 1)
            {
                    if(Character_GlobalInfo.stage_CurrentLevel == 12)
            {
                    UnityEngine.MonoBehaviour.print(message:  "Disabling ink em up for boss battle");
                this.Model.Feature_InkEmUp = false;
            }
            
            }
            
            val_72 = null;
            val_72 = null;
            GameMode val_53 = Character_GlobalInfo.gameMode;
            if(val_53 > 10)
            {
                    return;
            }
            
            val_53 = 1 << val_53;
            if((val_53 & 26) != 0)
            {
                    bool val_47 = MVC_MusselTracker.UseMussels(number:  1);
                return;
            }
            
            val_53 = val_53 & 1088;
            if(val_53 == 0)
            {
                    return;
            }
            
            val_73 = null;
            val_73 = null;
            DataStructs.UserDataDictionary.GameSave.LastPlayedPVPCharacter = this.Model.Player1.Name;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_48 = DataStructs.UserDataDictionary.Stats.AllTimeHighScore;
            val_74 = null;
            val_51 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_48.currentCryptoKey, hiddenValue = val_48.hiddenValue, fakeValue = val_48.fakeValue, inited = val_48.inited});
            val_74 = null;
            Character_GlobalInfo.prevHighScore = val_51;
            if(Character_GlobalInfo.isCryptoMMOCMode == false)
            {
                    return;
            }
            
            bool val_50 = InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch;
            return;
            label_101:
        }
        private void OnDestroy()
        {
            mem[1152921529275341648] = this.Model;
            mem[1152921529275341656] = public System.Void InkWars.Model.Model_Core::OnBeforePostMatch();
            mem[1152921529275341632] = public System.Void InkWars.Model.Model_Core::OnBeforePostMatch();
            InkWars.Model.Model_Events.Instance.remove_OnBeforePostMatch(value:  new Model_Events.OnBeforePostMatchDelegate());
        }
        public void RestartForBossRessurection()
        {
            null = null;
            Character_GlobalInfo.gameMode = 2;
            this.OnDestroy();
            this.Awake();
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            this.Model.Player1.ScoreCard = this.Model.Player1.ScoreCard;
            mem2[0] = this.Model.Player1.ScoreCard;
            mem2[0] = this.Model.Player1.ScoreCard;
            mem2[0] = this.Model.Player1.ScoreCard;
            this.Model.Player2.ScoreCard = this.Model.Player2.ScoreCard;
        }
        private static void ShuffleGrid(InkWars.Model.Model_Player player)
        {
            var val_10;
            InkWars.Model.BubbleTypes val_19;
            var val_20;
            var val_21;
            var val_22;
            InkWars.Model.Model_Bubble val_23;
            var val_24;
            var val_25;
            var val_26;
            val_19 = player;
            System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes> val_1 = new System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes>();
            val_20 = 0;
            goto label_2;
            label_7:
            InkWars.Model.Model_Bubble val_19 = player.OuterRing[0];
            bool val_2 = val_1.Add(item:  player.OuterRing[0x0][0].BubbleType);
            val_20 = 1;
            label_2:
            if(val_20 < player.OuterRing.Length)
            {
                goto label_7;
            }
            
            val_21 = 0;
            goto label_9;
            label_14:
            InkWars.Model.Model_Bubble val_20 = player.MiddleRing[0];
            bool val_3 = val_1.Add(item:  player.MiddleRing[0x0][0].BubbleType);
            val_21 = 1;
            label_9:
            if(val_21 < player.MiddleRing.Length)
            {
                goto label_14;
            }
            
            val_22 = 0;
            goto label_16;
            label_21:
            InkWars.Model.Model_Bubble val_21 = player.InnerRing[0];
            bool val_4 = val_1.Add(item:  player.InnerRing[0x0][0].BubbleType);
            val_22 = 1;
            label_16:
            if(val_22 < player.InnerRing.Length)
            {
                goto label_21;
            }
            
            System.Collections.Generic.List<InkWars.Model.BubbleTypes> val_6 = new System.Collections.Generic.List<InkWars.Model.BubbleTypes>(collection:  val_1);
            System.Collections.Generic.Dictionary<InkWars.Model.BubbleTypes, InkWars.Model.BubbleTypes> val_7 = new System.Collections.Generic.Dictionary<InkWars.Model.BubbleTypes, InkWars.Model.BubbleTypes>();
            List.Enumerator<T> val_8 = new System.Collections.Generic.List<InkWars.Model.BubbleTypes>(collection:  val_1).GetEnumerator();
            val_23 = 1152921529275737968;
            label_28:
            if(((-1100744240) & 1) == 0)
            {
                goto label_23;
            }
            
            InkWars.Model.BubbleTypes val_14 = val_6.Item[UnityEngine.Random.Range(min:  0, max:  val_6.Count)];
            bool val_15 = val_6.Remove(item:  val_14);
            val_7.set_Item(key:  val_10.GetHashCode(), value:  val_14);
            goto label_28;
            label_23:
            val_10.Add(driver:  public System.Void List.Enumerator<InkWars.Model.BubbleTypes>::Dispose(), rectTransform:  public System.Void System.Collections.Generic.List<InkWars.Model.BubbleTypes>::.ctor(System.Collections.Generic.IEnumerable<T> collection), drivenProperties:  null);
            val_24 = 0;
            goto label_39;
            label_44:
            val_23 = player.OuterRing[0];
            val_24 = 1;
            player.OuterRing[0x0][0].BubbleType = val_7.Item[player.OuterRing[0x0][0].BubbleType];
            label_39:
            if(val_24 < player.OuterRing.Length)
            {
                goto label_44;
            }
            
            val_25 = 0;
            goto label_46;
            label_51:
            val_23 = player.MiddleRing[0];
            val_25 = 1;
            player.MiddleRing[0x0][0].BubbleType = val_7.Item[player.MiddleRing[0x0][0].BubbleType];
            label_46:
            if(val_25 < player.MiddleRing.Length)
            {
                goto label_51;
            }
            
            val_26 = 0;
            goto label_53;
            label_58:
            InkWars.Model.Model_Bubble val_22 = player.InnerRing[0];
            val_19 = player.InnerRing[0x0][0].BubbleType;
            val_26 = 1;
            player.InnerRing[0x0][0].BubbleType = val_7.Item[val_19];
            label_53:
            if(val_26 < player.InnerRing.Length)
            {
                goto label_58;
            }
        
        }
        private InkWars.Model.Model_Manager.JSONGridData LoadStageData(string gameModeExtension)
        {
            object[] val_1 = new object[5];
            val_1[0] = "Level";
            val_1[1] = Character_GlobalInfo.stage_CurrentLevel;
            val_1[2] = "_";
            val_1[3] = gameModeExtension;
            val_1[4] = ".json";
            return (JSONGridData)UnityEngine.JsonUtility.FromJson<JSONGridData>(json:  CMS.IO.ReadOnlyDataFile.Load(path:  "GameData/"("GameData/") + +val_1(+val_1), type:  1));
        }
        private CharacterInfo SetAdventureModeOpponent(CharacterInfo leftPlayer)
        {
            Character_GlobalInfo.SetOpponentPlayer(nameID:  CharacterHelper.GetStageCPUCharacterId(levelId0to11:  Character_GlobalInfo.stage_CurrentLevel - 1, CPUClan:  (268435461 == 0) ? 1 : 0));
            return Character_GlobalInfo.GetRightPlayer();
        }
        private void PopulateGrid(InkWars.Model.Model_Manager.JSONGridData GridData, InkWars.Model.Model_Player player, bool forceEmpty)
        {
            bool val_1 = forceEmpty;
            this.PopulateRing(player:  player, strings:  GridData.ring_1, ring:  player.InnerRing, forceEmpty:  val_1);
            this.PopulateRing(player:  player, strings:  GridData.ring_2, ring:  player.MiddleRing, forceEmpty:  val_1);
            this.PopulateRing(player:  player, strings:  GridData.ring_3, ring:  player.OuterRing, forceEmpty:  forceEmpty);
        }
        private void PopulateRing(InkWars.Model.Model_Player player, string[] strings, InkWars.Model.Model_Bubble[] ring, bool forceEmpty)
        {
            goto label_1;
            label_11:
            InkWars.Model.Model_Bubble val_1 = new InkWars.Model.Model_Bubble(model_Player:  player, offset:  0, strType:  strings[0]);
            if(forceEmpty == false)
            {
                goto label_4;
            }
            
            .BubbleType = 0;
            goto label_6;
            label_4:
            if(val_1 == null)
            {
                goto label_8;
            }
            
            label_6:
            label_8:
            0 = 1;
            ring[0] = val_1;
            label_1:
            if(0 < ring.Length)
            {
                goto label_11;
            }
        
        }
        private void SetSpeedAndAttack(InkWars.Model.Model_Player player, bool isOpponent)
        {
            var val_9;
            GameMode val_10;
            var val_11;
            int val_12;
            var val_13;
            CharacterData val_1 = CharacterDataManager.Get(id:  player.Name);
            player.MiddleSuper = val_1.middleSuper;
            if(isOpponent == false)
            {
                goto label_11;
            }
            
            val_9 = null;
            val_9 = null;
            val_10 = Character_GlobalInfo.gameMode;
            if(val_10 == 1)
            {
                goto label_8;
            }
            
            val_9 = null;
            val_10 = Character_GlobalInfo.gameMode;
            if(val_10 != 2)
            {
                goto label_11;
            }
            
            label_8:
            int val_4 = UnityEngine.Mathf.Clamp(value:  Character_GlobalInfo.stage_CurrentLevel - 1, min:  0, max:  11);
            val_11 = null;
            val_11 = null;
            System.Int32[] val_5 = InkWars.Model.Model_Constants.AdventureModeSpeedRatings + (((long)(int)(val_4)) << 2);
            int val_9 = (InkWars.Model.Model_Constants.AdventureModeSpeedRatings + ((long)(int)(val_4)) << 2) + 32;
            val_9 = val_9 - 1;
            player.SpeedLevel = val_9;
            System.Int32[] val_6 = InkWars.Model.Model_Constants.AdventureModeAttackRatings + (((long)(int)(val_4)) << 2);
            goto label_22;
            label_11:
            int val_10 = val_1.status.speed;
            val_10 = val_10 - 1;
            player.SpeedLevel = val_10;
            val_12 = val_1.status.attack;
            label_22:
            int val_11 = val_12;
            val_11 = val_11 - 1;
            player.AttackLevel = val_11;
            val_13 = null;
            val_13 = null;
            System.Single[] val_7 = InkWars.Model.Model_Constants.CharacterReload_AttackShakeTime + ((player.SpeedLevel) << 2);
            System.Single[] val_8 = InkWars.Model.Model_Constants.CharacterReload_MaxPostAttackDuration + ((player.SpeedLevel) << 2);
            float val_12 = (InkWars.Model.Model_Constants.CharacterReload_MaxPostAttackDuration + (player.SpeedLevel) << 2) + 32;
            val_12 = ((InkWars.Model.Model_Constants.CharacterReload_AttackShakeTime + (player.SpeedLevel) << 2) + 32) + val_12;
            player.FullReloadTime = val_12;
        }
        private void PopulateTargetBubbles(InkWars.Model.Model_Player player, InkWars.Model.Model_Player otherPlayer)
        {
            InkWars.Model.BubbleTypes val_6;
            InkWars.Model.Player val_7;
            InkWars.Model.BubbleTypes val_8;
            var val_9;
            InkWars.Model.BubbleTypes val_1 = this.CreateSwitcherBubble(player:  player, otherPlayer:  otherPlayer);
            if(player != null)
            {
                    player.LoadedBubble = val_1;
                player.SpareBubble = val_1.CreateSwitcherBubble(player:  player, otherPlayer:  otherPlayer);
                val_6 = player.SpareBubble;
                player.IsReady = true;
                val_7 = player.ID;
                val_8 = player.LoadedBubble;
                val_9 = InkWars.Model.Model_Events.Instance;
            }
            else
            {
                    mem[52] = val_1;
                val_6 = 56;
                mem[56] = this.CreateSwitcherBubble(player:  0, otherPlayer:  otherPlayer);
                mem[24] = 1;
                val_9 = InkWars.Model.Model_Events.Instance;
                val_7 = 0;
                val_8 = mem[52];
            }
            
            val_9.Event_TargetBubblesPopulated(iD:  val_7, loadedBubble:  val_8, spareBubble:  val_6);
        }
        private InkWars.Model.BubbleTypes CreateSwitcherBubble(InkWars.Model.Model_Player player, InkWars.Model.Model_Player otherPlayer)
        {
            do
            {
                InkWars.Model.BubbleTypes val_1 = player.GetNextBubble(otherPlayer:  otherPlayer);
            }
            while(val_1 == 7);
            
            return val_1;
        }
        public void FixedUpdate()
        {
            this.Model.Update(deltaTime:  UnityEngine.Time.fixedDeltaTime);
        }
        private void SubscribeToFeatures()
        {
            InkWars.Model.Model_Core val_1;
            var val_2;
            val_1 = this;
            this.Model.Feature_Powerup = 0;
            this.Model.Feature_PlayerNamePlates = true;
            val_2 = null;
            val_2 = null;
            GameMode val_1 = Character_GlobalInfo.gameMode;
            val_1 = val_1 - 1;
            if(val_1 > 9)
            {
                    return;
            }
            
            var val_2 = 40830520 + ((Character_GlobalInfo.gameMode - 1)) << 2;
            val_2 = val_2 + 40830520;
            goto (40830520 + ((Character_GlobalInfo.gameMode - 1)) << 2 + 40830520);
        }
        public Model_Manager()
        {
            this.adventureModeStage = 1;
        }
    
    }

}
