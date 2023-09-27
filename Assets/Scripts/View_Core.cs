using UnityEngine;
public class View_Core : MonoBehaviour
{
    // Fields
    private static View_Core _instance;
    public float DeltaTime;
    public View_Objects LeftPlayer;
    public View_Objects RightPlayer;
    public UnityEngine.SpriteRenderer TargetBubbleTemplate;
    public UnityEngine.UI.Text CountdownTime;
    public UnityEngine.UI.Text CountdownTime_Infinite;
    public UnityEngine.Animator PuzzleModeHolder;
    public UnityEngine.UI.Image[] PuzzleModeBubblesUnselected;
    public UnityEngine.UI.Image[] PuzzleModeBubblesSelected;
    public UnityEngine.GameObject templateBubble;
    public UnityEngine.GameObject templateScorePoints;
    public UnityEngine.GameObject Template_Plug;
    public UnityEngine.Sprite[] BattleGridColors;
    public UnityEngine.Sprite[] PuzzleGridColors;
    public UnityEngine.Sprite[] BubbleSprites;
    public UnityEngine.Sprite[] SwitcherSprites;
    public UnityEngine.Sprite IkaInactiveBase;
    public UnityEngine.Sprite TakoInactiveBase;
    public UnityEngine.Sprite SpecialInactiveBase;
    public UnityEngine.Sprite SharkInactiveBase;
    public UnityEngine.Sprite[] IkaActiveBase;
    public UnityEngine.Sprite[] TakoActiveBase;
    public UnityEngine.Sprite[] SpecialActiveBase;
    public UnityEngine.Sprite[] SharkActiveBase;
    public UnityEngine.Sprite Whirlpool_Inactive;
    public UnityEngine.Sprite Whirlpool_Active;
    public View_CameraShake CameraShake;
    public UnityEngine.GameObject animText_AreYouReady;
    public UnityEngine.GameObject animText_GameOn;
    public UnityEngine.GameObject animText_MatchConclusionPartOne;
    public UnityEngine.GameObject animText_MatchConclusionPartTwo;
    public UnityEngine.GameObject animTextPuzzleThisIsAPuzzle;
    public UnityEngine.GameObject animTextPuzzleTryAndSolveIt;
    public UnityEngine.GameObject animTextPuzzleOutofBubbles;
    public UnityEngine.GameObject animTextPuzzleYouCracked;
    public UnityEngine.GameObject animTextAttackCounter;
    public UnityEngine.GameObject animExBattleRealDeal;
    public UnityEngine.GameObject animExBattleDoNotBackDown;
    public UnityEngine.GameObject animExBattleDefeated;
    public UnityEngine.GameObject animExBattleVictory;
    public UnityEngine.RectTransform[] FlipperObjects;
    public UnityEngine.Sprite AnimTextSprite_KO;
    public UnityEngine.Sprite AnimTextSprite_DoubleKO;
    public UnityEngine.Sprite AnimTextSprite_TimesUp;
    public UnityEngine.Sprite AnimTextSprite_PlayerOneWins;
    public UnityEngine.Sprite AnimTextSprite_PlayerTwoWins;
    public UnityEngine.Sprite AnimTextSprite_YouWin;
    public UnityEngine.Sprite AnimTextSprite_YouLose;
    public UnityEngine.Sprite AnimTextSprite_Draw;
    public UnityEngine.AudioClip audio_TimerFinal10;
    public UnityEngine.AudioClip audio_MatchEnd;
    public UnityEngine.AudioClip audio_WhirlpoolVortex;
    public UnityEngine.AudioClip audio_MatchOutcomeWin;
    public UnityEngine.AudioClip audio_MatchOutcomeDraw;
    public UnityEngine.AudioClip audio_MatchOutcomeLose;
    public UnityEngine.AudioClip audio_AdventureGameCleared;
    public UnityEngine.GameObject PVP_PostMatch;
    public UnityEngine.Canvas canvas_CharacterBase;
    public UnityEngine.Canvas canvas_ParticleEffects;
    public UnityEngine.Canvas canvas_DynamicMessages;
    public UnityEngine.Canvas canvas_UI;
    public UnityEngine.Canvas canvas_MenuOverlay;
    public UnityEngine.Canvas canvas_ControlImages;
    public UnityEngine.GameObject Container_AnimatedText;
    public BubblesCollection m_bubblesCollection;
    public SwitcherCollection m_switcherCollection;
    public BattleGridCollection m_battleGridCollection;
    public MainGameStartUpAnim m_startupAnim;
    public View_Objects PlayerWinner;
    public bool SyncPlayerRings;
    private bool triggered_GameOver;
    private bool RevertToPreviousAnimatorPauseStates;
    private bool LeftPlayerAnimatorPauseState;
    private bool RightPlayerAnimatorPauseState;
    public bool enableBubbleDisplay;
    private int prevTimeInt;
    public UnityEngine.Sprite InkEmUp_Sprite_HomeBase_Ika;
    public UnityEngine.Sprite InkEmUp_Sprite_HomeBase_Tako;
    public UnityEngine.Sprite InkEmUp_Sprite_HomeBase_Mermaid;
    public UnityEngine.Sprite InkEmUp_Sprite_HomeBase_Shark;
    public UnityEngine.GameObject InkEmUp_AnimText_NotOverYet;
    public UnityEngine.GameObject InkEmUp_AnimText_InkEmUp;
    public UnityEngine.GameObject InkEmUp_AnimText_Go;
    public UnityEngine.GameObject InkEmUp_AnimText_Destroyed;
    public UnityEngine.GameObject InkEmUp_Timer;
    public TMPro.TextMeshProUGUI InkEmUp_Timer_Text;
    public UnityEngine.AudioClip InkEmUp_Audio_BGMusic;
    public UnityEngine.AudioClip InkEmUp_Audio_Vortex;
    public UnityEngine.AudioClip InkEmUp_Audio_Destroyed;
    public View_InkBar InkEmUpBar;
    public View_Objects InkEmUp_Player_Winner;
    public View_Objects InkEmUp_Player_Loser;
    private InkWars.Model.Model_Core.InkEmUp_Phase InkEmUp_CurrentPhase;
    private View_Bubble[] InkEmUp_InkBubbles;
    private int InkEmUp_InkIndex;
    public bool InkEmUp_ModelTrigger_ConvertToInk;
    public bool InkEmUp_ModelTrigger_ReadyToShoot;
    public UnityEngine.Sprite[] PlayerNameBackingStrips;
    private System.Collections.Generic.List<InkWars.Model.BubbleTypes> PuzzleBubbleList;
    
    // Properties
    public static View_Core Instance { get; }
    public static InkWars.Model.Model_Core Model { get; }
    public static int InkEmUp_BubblesTotal { get; }
    
    // Methods
    public static View_Core get_Instance()
    {
        if(View_Core._instance != 0)
        {
                return (View_Core)View_Core._instance;
        }
        
        View_Core._instance = UnityEngine.Object.FindObjectOfType<View_Core>();
        return (View_Core)View_Core._instance;
    }
    public static InkWars.Model.Model_Core get_Model()
    {
        if(InkWars.Model.Model_Manager.Instance == 0)
        {
                return 0;
        }
        
        InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
        0 = val_3.Model;
        return 0;
    }
    private void OnEnable()
    {
        this.InkEmUpBar.gameObject.SetActive(value:  false);
        InkWars.Model.Model_Events.Instance.add_OnBubbleSuction(value:  new Model_Events.OnBubbleSuctionDelegate(object:  this, method:  public System.Void View_Core::OnBubbleSuction(InkWars.Model.Player playerID, int ringID, int ringIndex, int amount)));
        InkWars.Model.Model_Events.Instance.add_OnPlayerShot(value:  new Model_Events.OnPlayerShotDelegate(object:  this, method:  public System.Void View_Core::OnPlayerShot(float gameTime, InkWars.Model.Player playerID, InkWars.Model.AimTarget aimTarget, InkWars.Model.BubbleTypes shotBubble, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, bool sendOverNetwork)));
        InkWars.Model.Model_Events.Instance.add_OnComboPop(value:  new Model_Events.OnPlayerMessageDelegate(object:  this, method:  System.Void View_Core::OnPlayerMessage(PlayerMessage message)));
        InkWars.Model.Model_Events.Instance.add_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void View_Core::OnGameResult(InkWars.Model.GameResult result, bool isFinished)));
        InkWars.Model.Model_Events.Instance.add_OnModelStart(value:  new Model_Events.BasicDelegate(object:  this, method:  System.Void View_Core::OnModelStart()));
        this.SetSortingLayers();
        if(0 == (this.LeftPlayer.LineRenderer.GetComponent<AimLineLengthAdapter>()))
        {
                AimLineLengthAdapter val_15 = this.LeftPlayer.LineRenderer.gameObject.AddComponent<AimLineLengthAdapter>();
        }
        
        if(0 != (this.RightPlayer.LineRenderer.GetComponent<AimLineLengthAdapter>()))
        {
                return;
        }
        
        AimLineLengthAdapter val_19 = this.RightPlayer.LineRenderer.gameObject.AddComponent<AimLineLengthAdapter>();
    }
    private void OnDisable()
    {
        if(InkWars.Model.Model_Events.Instance == 0)
        {
                return;
        }
        
        InkWars.Model.Model_Events.Instance.remove_OnBubbleSuction(value:  new Model_Events.OnBubbleSuctionDelegate(object:  this, method:  public System.Void View_Core::OnBubbleSuction(InkWars.Model.Player playerID, int ringID, int ringIndex, int amount)));
        InkWars.Model.Model_Events.Instance.remove_OnPlayerShot(value:  new Model_Events.OnPlayerShotDelegate(object:  this, method:  public System.Void View_Core::OnPlayerShot(float gameTime, InkWars.Model.Player playerID, InkWars.Model.AimTarget aimTarget, InkWars.Model.BubbleTypes shotBubble, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, bool sendOverNetwork)));
        InkWars.Model.Model_Events.Instance.remove_OnComboPop(value:  new Model_Events.OnPlayerMessageDelegate(object:  this, method:  System.Void View_Core::OnPlayerMessage(PlayerMessage message)));
        InkWars.Model.Model_Events.Instance.remove_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void View_Core::OnGameResult(InkWars.Model.GameResult result, bool isFinished)));
        InkWars.Model.Model_Events.Instance.remove_OnModelStart(value:  new Model_Events.BasicDelegate(object:  this, method:  System.Void View_Core::OnModelStart()));
    }
    private void OnGameResult(InkWars.Model.GameResult result, bool isFinished)
    {
        if(isFinished == false)
        {
                return;
        }
        
        this.LeftPlayer.ResetStunStates();
        this.RightPlayer.ResetStunStates();
        this.LeftPlayer.ResetCharacterLayer();
        this.RightPlayer.ResetCharacterLayer();
    }
    public View_Objects GetViewObjectsByPlayerId_Flip(InkWars.Model.Player aNewPlayerId)
    {
        View_Objects val_3;
        if(aNewPlayerId == 1)
        {
            goto label_0;
        }
        
        if(aNewPlayerId != 0)
        {
            goto label_3;
        }
        
        InkWars.Model.Model_Core val_1 = View_Core.Model;
        if(val_1.PlayersFlippedLocally == false)
        {
            goto label_3;
        }
        
        label_6:
        val_3 = this.RightPlayer;
        return (View_Objects)mem[this.LeftPlayer];
        label_0:
        InkWars.Model.Model_Core val_2 = View_Core.Model;
        if(val_2.PlayersFlippedLocally == false)
        {
            goto label_6;
        }
        
        label_3:
        val_3 = this.LeftPlayer;
        return (View_Objects)mem[this.LeftPlayer];
    }
    public View_Objects GetOpponentViewObjectsByPlayerId_Flip(InkWars.Model.Player aNewPlayerId)
    {
        View_Objects val_3;
        if(aNewPlayerId == 1)
        {
            goto label_0;
        }
        
        if(aNewPlayerId != 0)
        {
            goto label_6;
        }
        
        InkWars.Model.Model_Core val_1 = View_Core.Model;
        if(val_1.PlayersFlippedLocally == false)
        {
            goto label_3;
        }
        
        label_6:
        val_3 = this.LeftPlayer;
        return (View_Objects)mem[this.RightPlayer];
        label_0:
        InkWars.Model.Model_Core val_2 = View_Core.Model;
        if(val_2.PlayersFlippedLocally == false)
        {
            goto label_6;
        }
        
        label_3:
        val_3 = this.RightPlayer;
        return (View_Objects)mem[this.RightPlayer];
    }
    private void OnModelStart()
    {
        InkWars.Model.Model_Bubble[] val_28;
        var val_29;
        InkWars.Model.Model_Player val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        System.Collections.Generic.List<InkWars.Model.BubbleTypes> val_35;
        var val_36;
        var val_37;
        var val_38;
        this.SyncPlayerRings = false;
        this.triggered_GameOver = false;
        this.enableBubbleDisplay = false;
        InkWars.Model.Model_Player val_2 = View_Core.Model.LeftPlayer;
        val_28 = 1152921504858337280;
        val_29 = 0;
        var val_3 = (val_2.ID == 0) ? 1f : -1f;
        goto label_3;
        label_11:
        UnityEngine.RectTransform val_28 = this.FlipperObjects[0];
        if(val_28 != 0)
        {
                val_28.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        val_29 = 1;
        label_3:
        if(val_29 < this.FlipperObjects.Length)
        {
            goto label_11;
        }
        
        this.LeftPlayer.LoadCharacter(player:  View_Core.Model.LeftPlayer);
        val_30 = View_Core.Model.RightPlayer;
        this.RightPlayer.LoadCharacter(player:  val_30);
        val_31 = null;
        val_31 = null;
        if(Character_GlobalInfo.gameMode != 3)
        {
            goto label_18;
        }
        
        System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes> val_10 = new System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes>();
        InkWars.Model.Model_Core val_11 = View_Core.Model;
        val_32 = 0;
        goto label_21;
        label_26:
        InkWars.Model.Model_Bubble val_29 = val_11.Player2.OuterRing[0];
        bool val_12 = val_10.Add(item:  val_11.Player2.OuterRing[0x0][0].BubbleType);
        val_32 = 1;
        label_21:
        if(val_32 < val_11.Player2.OuterRing.Length)
        {
            goto label_26;
        }
        
        InkWars.Model.Model_Core val_13 = View_Core.Model;
        val_33 = 0;
        goto label_29;
        label_34:
        InkWars.Model.Model_Bubble val_30 = val_13.Player2.MiddleRing[0];
        bool val_14 = val_10.Add(item:  val_13.Player2.MiddleRing[0x0][0].BubbleType);
        val_33 = 1;
        label_29:
        if(val_33 < val_13.Player2.MiddleRing.Length)
        {
            goto label_34;
        }
        
        InkWars.Model.Model_Core val_15 = View_Core.Model;
        val_28 = val_15.Player2.InnerRing;
        val_34 = 0;
        goto label_37;
        label_42:
        InkWars.Model.Model_Bubble val_31 = val_28[0];
        bool val_16 = val_10.Add(item:  val_15.Player2.InnerRing[0x0][0].BubbleType);
        val_34 = 1;
        label_37:
        if(val_34 < val_15.Player2.InnerRing.Length)
        {
            goto label_42;
        }
        
        System.Collections.Generic.List<InkWars.Model.BubbleTypes> val_17 = null;
        val_35 = val_17;
        val_17 = new System.Collections.Generic.List<InkWars.Model.BubbleTypes>(collection:  val_10);
        this.PuzzleBubbleList = val_35;
        val_36 = 0;
        goto label_43;
        label_58:
        val_37 = null;
        val_28 = this.PuzzleModeBubblesSelected[0];
        val_37 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_18 = DataStructs.UserDataDictionary.Settings.SelectedBubble;
        UnityEngine.Sprite val_21 = this.m_bubblesCollection.GetBubbleSpriteByFamilyAndType(family:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_18.currentCryptoKey, hiddenValue = val_18.hiddenValue, fakeValue = val_18.fakeValue, inited = val_18.inited}), type:  this.PuzzleBubbleList.Item[0]);
        val_28.sprite = val_21;
        this.PuzzleModeBubblesUnselected[0].sprite = val_21;
        val_35 = this.PuzzleBubbleList;
        val_36 = 1;
        label_43:
        if(val_36 < val_35.Count)
        {
            goto label_58;
        }
        
        this.PuzzleModeHolder.gameObject.SetActive(value:  true);
        val_30 = this.PuzzleModeHolder;
        val_30.Play(stateName:  val_10.Count + "Balls", layer:  0, normalizedTime:  0f);
        val_38 = this.PuzzleModeBubblesUnselected[0].GetComponentInChildren<UnityEngine.UI.Toggle>();
        val_38.isOn = true;
        return;
        label_18:
        val_38 = this.PuzzleModeHolder.gameObject;
        val_38.SetActive(value:  false);
    }
    private void BlinkTimer()
    {
        float val_4 = 5f;
        val_4 = UnityEngine.Time.time * val_4;
        float val_2 = UnityEngine.Mathf.PingPong(t:  val_4, length:  1f);
        UnityEngine.Color val_3 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.CountdownTime.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
    }
    public void Update()
    {
        View_Objects val_45;
        bool val_46;
        int val_48;
        InkWars.Model.Player val_49;
        val_45 = this;
        if(View_Core.Model == null)
        {
                return;
        }
        
        InkWars.Model.Model_Core val_2 = View_Core.Model;
        if(val_2.Feature_Powerup != 1)
        {
            goto label_25;
        }
        
        InkWars.Model.Model_Core val_3 = View_Core.Model;
        if(val_3.PauseForRevengeSuper <= 0f)
        {
            goto label_5;
        }
        
        val_46 = this.RevertToPreviousAnimatorPauseStates;
        goto label_6;
        label_5:
        InkWars.Model.Model_Core val_4 = View_Core.Model;
        val_46 = this.RevertToPreviousAnimatorPauseStates;
        if(val_4.PauseForStunBreak <= 0f)
        {
            goto label_8;
        }
        
        label_6:
        if(val_46 == true)
        {
                return;
        }
        
        this.LeftPlayerAnimatorPauseState = this.LeftPlayer.PlayerAnimator.pause;
        this.LeftPlayer.PlayerAnimator.pause = true;
        this.RightPlayerAnimatorPauseState = this.RightPlayer.PlayerAnimator.pause;
        this.RightPlayer.PlayerAnimator.pause = true;
        this.RevertToPreviousAnimatorPauseStates = true;
        this.LeftPlayer.LineRenderer.gameObject.SetActive(value:  false);
        val_45 = this.RightPlayer.LineRenderer.gameObject;
        val_45.SetActive(value:  false);
        return;
        label_8:
        if(val_46 != false)
        {
                this.RevertToPreviousAnimatorPauseStates = false;
            this.LeftPlayer.PlayerAnimator.pause = this.LeftPlayerAnimatorPauseState;
            this.RightPlayer.PlayerAnimator.pause = this.RightPlayerAnimatorPauseState;
            this.LeftPlayer.LineRenderer.gameObject.SetActive(value:  true);
            this.RightPlayer.LineRenderer.gameObject.SetActive(value:  true);
        }
        
        label_25:
        this.DeltaTime = UnityEngine.Time.deltaTime;
        UnityEngine.GameObject val_12 = this.CountdownTime.gameObject;
        if(View_Core.Model.TimeLeft > (-1f))
        {
                val_12.SetActive(value:  true);
            this.CountdownTime_Infinite.gameObject.SetActive(value:  false);
            int val_16 = UnityEngine.Mathf.CeilToInt(f:  View_Core.Model.TimeLeft);
            string val_17 = val_16.ToString();
            val_48 = val_16;
            if(((val_48 <= 10) && (val_48 != 0)) && (val_48 < this.prevTimeInt))
        {
                if(val_48 == 10)
        {
                this.InvokeRepeating(methodName:  "BlinkTimer", time:  0f, repeatRate:  UnityEngine.Time.deltaTime);
        }
        
            UnityEngine.AudioSource val_20 = GameAudio.sound.PlayOneShot(clip:  this.audio_TimerFinal10, volume:  1f);
            val_48 = val_16;
        }
        
            this.prevTimeInt = val_48;
        }
        else
        {
                val_12.SetActive(value:  false);
            this.CountdownTime_Infinite.gameObject.SetActive(value:  true);
        }
        
        if((View_Core.Model.GameResult == 0) || (this.triggered_GameOver == true))
        {
            goto label_58;
        }
        
        if(View_Core.Model.GameResult != 1)
        {
                if(View_Core.Model.GameResult != 4)
        {
            goto label_62;
        }
        
        }
        
        val_49 = 0;
        goto label_63;
        label_62:
        if(View_Core.Model.GameResult != 2)
        {
                if(View_Core.Model.GameResult != 5)
        {
            goto label_67;
        }
        
        }
        
        val_49 = 1;
        label_63:
        this.PlayerWinner = this.GetPlayer(playerID:  val_49);
        label_67:
        this.SyncPlayerRings = true;
        this.triggered_GameOver = true;
        UnityEngine.Coroutine val_34 = this.StartCoroutine(routine:  this.Activate_AnimText_MatchConclusion_PartOne());
        label_58:
        this.InkEmUp_Update();
        this.LeftPlayer.Sync(playerModel:  View_Core.Model.LeftPlayer, otherPlayerModel:  View_Core.Model.RightPlayer, model:  View_Core.Model, otherPlayer:  this.RightPlayer);
        val_45 = this.LeftPlayer;
        this.RightPlayer.Sync(playerModel:  View_Core.Model.RightPlayer, otherPlayerModel:  View_Core.Model.LeftPlayer, model:  View_Core.Model, otherPlayer:  val_45);
    }
    public System.Collections.IEnumerator StunBreaker_ExpandThenDestroy(UnityEngine.GameObject obj, float speed)
    {
        View_Core.<StunBreaker_ExpandThenDestroy>d__89 val_1 = new View_Core.<StunBreaker_ExpandThenDestroy>d__89();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .obj = obj;
        }
        else
        {
                mem[32] = obj;
        }
        
        .speed = speed;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator Activate_AnimText_MatchConclusion_PartOne()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new View_Core.<Activate_AnimText_MatchConclusion_PartOne>d__90();
    }
    private System.Collections.IEnumerator MatchConclusion_Finish()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new View_Core.<MatchConclusion_Finish>d__91();
    }
    private System.Collections.IEnumerator TriggerPostMatchPanel()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new View_Core.<TriggerPostMatchPanel>d__92();
    }
    public void LoadBubbles()
    {
        this.LeftPlayer.LoadBubbles();
        this.RightPlayer.LoadBubbles();
    }
    private View_Objects GetPlayer(InkWars.Model.Player playerID)
    {
        View_Objects val_2;
        InkWars.Model.Model_Core val_1 = View_Core.Model;
        if(val_1.PlayersFlippedLocally == false)
        {
            goto label_1;
        }
        
        if(playerID == 0)
        {
            goto label_2;
        }
        
        label_4:
        val_2 = this.LeftPlayer;
        return (View_Objects)mem[this.RightPlayer];
        label_1:
        if(playerID == 0)
        {
            goto label_4;
        }
        
        label_2:
        val_2 = this.RightPlayer;
        return (View_Objects)mem[this.RightPlayer];
    }
    public void OnPlayerShot(float gameTime, InkWars.Model.Player playerID, InkWars.Model.AimTarget aimTarget, InkWars.Model.BubbleTypes shotBubble, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, bool sendOverNetwork)
    {
        this.GetPlayer(playerID:  playerID).ShootAnimation();
    }
    public void OnBubbleSuction(InkWars.Model.Player playerID, int ringID, int ringIndex, int amount)
    {
        this.GetPlayer(playerID:  playerID).SuctionAnimation(ringID:  ringID, ringIndex:  ringIndex, amount:  amount);
    }
    private void OnPlayerMessage(PlayerMessage message)
    {
        message.LogMessage();
    }
    private void SetSortingLayers()
    {
        var val_11;
        ViewPrefab_Background val_1 = ViewPrefab_Background.Instance;
        val_1.Canvas.sortingOrder = 0;
        this.canvas_CharacterBase.sortingOrder = 2;
        this.canvas_ParticleEffects.sortingOrder = 6;
        this.canvas_DynamicMessages.sortingOrder = 11;
        this.canvas_UI.sortingOrder = 13;
        this.canvas_MenuOverlay.sortingOrder = 17;
        this.canvas_ControlImages.sortingOrder = 12;
        val_11 = 0;
        goto label_9;
        label_22:
        if(0 != (this.Container_AnimatedText.transform.GetChild(index:  0).GetComponent<UnityEngine.SpriteRenderer>()))
        {
                this.Container_AnimatedText.transform.GetChild(index:  0).GetComponent<UnityEngine.SpriteRenderer>().sortingOrder = 13;
        }
        
        val_11 = 1;
        label_9:
        int val_10 = this.Container_AnimatedText.transform.childCount;
        if(val_11 < val_10)
        {
            goto label_22;
        }
        
        val_10.SetSortingLayer_Player(player:  this.LeftPlayer);
        val_10.SetSortingLayer_Player(player:  this.RightPlayer);
    }
    private void SetSortingLayer_Player(View_Objects player)
    {
        player.PlayerAnimator.SetSortingLayer(_sortingLayer:  9);
        player.Grid.GetComponent<UnityEngine.SpriteRenderer>().sortingOrder = 1;
        player.GridEntryIndicator.GetComponent<UnityEngine.SpriteRenderer>().sortingOrder = 1;
        player.SetGridEntryIndicatorEnable(enable:  false);
        UnityEngine.Transform val_4 = player.LineRenderer.gameObject.transform;
        int val_5 = val_4.childCount;
        if(val_5 < 1)
        {
                return;
        }
        
        var val_8 = 0;
        do
        {
            val_4.GetChild(index:  0).GetComponent<UnityEngine.SpriteRenderer>().sortingOrder = 8;
            val_8 = val_8 + 1;
        }
        while(val_5 != val_8);
    
    }
    private void SetSortingLayer_Bubbles(UnityEngine.GameObject[] bubbleRing)
    {
        goto label_1;
        label_6:
        bubbleRing[0].GetComponent<UnityEngine.SpriteRenderer>().sortingOrder = 5;
        0 = 1;
        label_1:
        if(0 < bubbleRing.Length)
        {
            goto label_6;
        }
    
    }
    public void CreateScorePopUp(int score, UnityEngine.Vector3 pos, View_Objects player, ScoreSize sizing = 1)
    {
        View_Core val_1 = View_Core.Instance;
        UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.templateScorePoints, parent:  val_1.canvas_UI.transform).GetComponent<View_ScorePopUp>().Initialize(score:  score, pos:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, size:  sizing, playerScoreTarget:  player, comboType:  0);
    }
    private void InkEmUp_Update()
    {
        View_Bubble val_15;
        InkEmUp_Phase val_16;
        InkEmUp_Phase val_17;
        val_15 = this;
        InkWars.Model.Model_Core val_1 = View_Core.Model;
        if(val_1.Feature_InkEmUp == false)
        {
                return;
        }
        
        val_16 = this.InkEmUp_CurrentPhase;
        InkWars.Model.Model_Core val_2 = View_Core.Model;
        if(val_16 != val_2.InkEmUp_CurrentPhase)
        {
            goto label_4;
        }
        
        val_17 = this.InkEmUp_CurrentPhase;
        goto label_5;
        label_4:
        InkWars.Model.Model_Core val_3 = View_Core.Model;
        if(val_3.InkEmUp_CurrentPhase == 6)
        {
            goto label_7;
        }
        
        if(val_3.InkEmUp_CurrentPhase != 3)
        {
            goto label_8;
        }
        
        System.Collections.IEnumerator val_4 = this.InkEmUp_MovingInkToPlayer();
        goto label_9;
        label_7:
        label_9:
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.InkEmUp_Ending());
        label_8:
        InkWars.Model.Model_Core val_7 = View_Core.Model;
        val_17 = val_7.InkEmUp_CurrentPhase;
        this.InkEmUp_CurrentPhase = val_17;
        label_5:
        val_17 = val_17 & 4294967294;
        if(val_17 != 4)
        {
                return;
        }
        
        InkWars.Model.Model_Core val_8 = View_Core.Model;
        this.InkEmUp_Timer_Text.text = val_8.InkEmUp_TimeRemaining.ToString(format:  "F2");
        val_16 = 0;
        goto label_29;
        label_33:
        InkWars.Model.Model_Core val_10 = View_Core.Model;
        InkWars.Model.Model_Bubble val_15 = val_10.InkEmUp_InkBubbles[0];
        if(val_10.InkEmUp_InkBubbles[0x0][0].ShotAsInk == false)
        {
            goto label_19;
        }
        
        InkWars.Model.Model_Core val_11 = View_Core.Model;
        InkWars.Model.Model_Bubble val_16 = val_11.InkEmUp_InkBubbles[0];
        val_11.InkEmUp_InkBubbles[0x0][0].ShotAsInk = false;
        View_Bubble val_17 = this.InkEmUp_InkBubbles[0];
        if(this.InkEmUp_InkBubbles == null)
        {
            goto label_26;
        }
        
        label_31:
        int val_18 = this.InkEmUp_InkBubbles.Length;
        val_18 = val_18 - 1;
        val_17.ShootAsInk(FinalBubble:  (val_16 == val_18) ? 1 : 0);
        this.InkEmUp_Player_Winner.AnimTrigger_Attack = true;
        label_19:
        val_16 = 1;
        goto label_29;
        label_26:
        if(val_17 != null)
        {
            goto label_31;
        }
        
        goto label_31;
        label_29:
        if(val_16 < this.InkEmUp_InkBubbles.Length)
        {
            goto label_33;
        }
        
        if(this.InkEmUp_InkBubbles.Length != 0)
        {
                var val_19 = -4294967296;
            val_19 = val_19 + ((this.InkEmUp_InkBubbles.Length) << 32);
            val_15 = this.InkEmUp_InkBubbles[val_19 >> 32];
            if((this.InkEmUp_InkBubbles[((-4294967296 + (this.InkEmUp_InkBubbles.Length) << 32) >> 32)][0].InkEmUp_InkState) != 5)
        {
                return;
        }
        
        }
        
        UnityEngine.Debug.LogWarning(message:  "ERROR: NO BUBBLES AT INKEMUP");
        val_15 = View_Core.Model;
        val_14.InkEmUp_CurrentPhase = 6;
    }
    private System.Collections.IEnumerator InkEmUp_Setup()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new View_Core.<InkEmUp_Setup>d__124();
    }
    private System.Collections.IEnumerator InkEmUp_Ending()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new View_Core.<InkEmUp_Ending>d__125();
    }
    private System.Collections.IEnumerator InkEmUp_MovingInkToPlayer()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new View_Core.<InkEmUp_MovingInkToPlayer>d__126();
    }
    public static int get_InkEmUp_BubblesTotal()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetCurrentLevelData().InkPercentage;
        InkWars.Model.Model_Manager val_5 = InkWars.Model.Model_Manager.Instance;
        int val_7 = val_5.Model.InkEmUp_InkIndex;
        val_7 = val_7 + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited}));
        return (int)(val_7 < 100) ? (val_7) : 100;
    }
    private void ConvertToInkBubbles(View_Bubble[] ring)
    {
        goto label_0;
        label_8:
        View_Bubble val_1 = ring[0];
        if(ring[0x0][0]._bubbleType != 0)
        {
                val_1.SetBubble(type:  11, bubbleAddedToGrid:  false);
            this.InkEmUp_InkBubbles[this.InkEmUp_InkIndex] = val_1;
            int val_2 = this.InkEmUp_InkIndex;
            val_2 = val_2 + 1;
            this.InkEmUp_InkIndex = val_2;
        }
        
        0 = 1;
        label_0:
        if(0 < ring.Length)
        {
            goto label_8;
        }
    
    }
    public void PuzzleBubbleSelected(int index)
    {
        int val_6;
        System.Collections.Generic.List<InkWars.Model.BubbleTypes> val_7;
        val_6 = index;
        val_7 = this.PuzzleBubbleList;
        if(val_7.Count < val_6)
        {
                return;
        }
        
        InkWars.Model.Model_Core val_2 = View_Core.Model;
        val_2.Player1.LoadedBubble = this.PuzzleBubbleList.Item[val_6];
        InkWars.Model.Model_Core val_4 = View_Core.Model;
        val_7 = val_4.Player1;
        val_6 = this.PuzzleBubbleList.Item[val_6];
        val_4.Player1.SpareBubble = val_6;
    }
    public View_Core()
    {
        this.PuzzleBubbleList = new System.Collections.Generic.List<InkWars.Model.BubbleTypes>();
    }
    private void <TriggerPostMatchPanel>b__92_0()
    {
        MainThreadDispatcher.Invoke(action:  new System.Action(object:  this, method:  System.Void View_Core::<TriggerPostMatchPanel>b__92_1()), delay:  0f);
    }
    private void <TriggerPostMatchPanel>b__92_1()
    {
        this.enableBubbleDisplay = false;
        InkWars.Model.Model_Manager.Instance.RestartForBossRessurection();
        this.LeftPlayer.firstSync = false;
        this.RightPlayer.firstSync = false;
    }

}
