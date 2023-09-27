using UnityEngine;
public class PlayerCharacterUIController : Control_Base<PlayerCharacterUIController>
{
    // Fields
    public bool DEBUG_MODE;
    private bool m_IsRevengeReady;
    private bool m_IsLoadedBubbleNotSpecial;
    private float m_BackgroundSize;
    private CharacterAssetLoader m_CharacterAssetLoader;
    private UnityEngine.UI.Image m_BackgroundMask;
    private UnityEngine.UI.Image m_FillBar;
    private UnityEngine.UI.Image m_CharacterMask;
    private UnityEngine.UI.Image m_CharacterImage;
    private UnityEngine.UI.Image m_CharacterTypeIcon;
    private float m_FillPercent;
    private ColorFlashAlt m_FlashPlayerCharacterAvatar;
    private ColorFlash m_FlashPlayerCharacter;
    private ColorFlashAlt m_FlashRevengeGraphic;
    private float m_RevengeSuperFillPercent;
    private BubbleHolderUIController m_BubbleHolder;
    private UnityEngine.Sprite m_BlueSprite;
    private UnityEngine.Sprite m_RedSprite;
    private UnityEngine.Sprite m_TealSprite;
    private UnityEngine.Sprite m_PurpleSprite;
    private UnityEngine.AudioClip stunBreakerSound;
    private UnityEngine.AudioClip superEquippedSound;
    private UnityEngine.AudioSource equippedSoundSource;
    private static UnityEngine.Events.UnityEvent OnFullyInkAnimationPlayedEvent;
    private System.Collections.IEnumerator EquippedSoundCoroutine;
    
    // Properties
    public CharacterNameID m_CharID { get; }
    public ColorFlash FlashPlayer { get; }
    public UnityEngine.Sprite CharacterSprite { get; }
    public CharacterAssetLoader AssetLoader { get; }
    public bool IsRevengeReady { get; set; }
    
    // Methods
    public CharacterNameID get_m_CharID()
    {
        if(this.PlayerModel != null)
        {
                return (CharacterNameID)val_1.Name;
        }
        
        return (CharacterNameID)val_1.Name;
    }
    public static void LoadFullyInkedAvatar()
    {
        null = null;
        PlayerCharacterUIController.OnFullyInkAnimationPlayedEvent.Invoke();
    }
    private void StopEquippedSoundCoroutine()
    {
        if(this.EquippedSoundCoroutine == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.EquippedSoundCoroutine);
        this.EquippedSoundCoroutine = 0;
    }
    public ColorFlash get_FlashPlayer()
    {
        return (ColorFlash)this.m_FlashPlayerCharacter;
    }
    internal override void Awake()
    {
        this.Awake();
        this.DEBUG_MODE = false;
        UnityEngine.Rect val_2 = this.m_BackgroundMask.rectTransform.rect;
        this.m_BackgroundSize = val_2.m_XMin;
    }
    internal void OnModelStart()
    {
        this.m_FlashRevengeGraphic.Flash();
        this.InitializeCharaterImages();
    }
    private void OnEnable()
    {
        var val_12;
        InkWars.Model.Model_Events.Instance.add_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void PlayerCharacterUIController::OnGameResult(InkWars.Model.GameResult result, bool isFinished)));
        InkWars.Model.Model_Events.Instance.add_OnRevengeSuper(value:  new Model_Events.OnRevengeSuperDelegate(object:  this, method:  System.Void PlayerCharacterUIController::OnRevengeSuper(InkWars.Model.Player id, InkWars.Model.BubbleTypes revengeSuperType, InkWars.Model.RevengeSuperEventState state)));
        InkWars.Model.Model_Events.Instance.add_OnPlayerSwitch(value:  new Model_Events.OnPlayerSwitchDelegate(object:  this, method:  public System.Void PlayerCharacterUIController::OnBubbleSwitch(InkWars.Model.Player playerId, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, bool manualSwitch)));
        InkWars.Model.Model_Events.Instance.add_OnStunBreak(value:  new Model_Events.OnStunBreakDelegate(object:  this, method:  public System.Void PlayerCharacterUIController::OnStunBreak(InkWars.Model.Player playerId, float revengeSuperLevel, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)));
        InkWars.Model.Model_Events.Instance.add_OnModelStart(value:  new Model_Events.BasicDelegate(object:  this, method:  System.Void PlayerCharacterUIController::OnModelStart()));
        val_12 = null;
        val_12 = null;
        PlayerCharacterUIController.OnFullyInkAnimationPlayedEvent.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PlayerCharacterUIController::ReloadInkedAvatar()));
    }
    private void OnDisable()
    {
        var val_14;
        if(InkWars.Model.Model_Events.Instance == 0)
        {
                return;
        }
        
        InkWars.Model.Model_Events.Instance.remove_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void PlayerCharacterUIController::OnGameResult(InkWars.Model.GameResult result, bool isFinished)));
        InkWars.Model.Model_Events.Instance.remove_OnRevengeSuper(value:  new Model_Events.OnRevengeSuperDelegate(object:  this, method:  System.Void PlayerCharacterUIController::OnRevengeSuper(InkWars.Model.Player id, InkWars.Model.BubbleTypes revengeSuperType, InkWars.Model.RevengeSuperEventState state)));
        InkWars.Model.Model_Events.Instance.remove_OnPlayerSwitch(value:  new Model_Events.OnPlayerSwitchDelegate(object:  this, method:  public System.Void PlayerCharacterUIController::OnBubbleSwitch(InkWars.Model.Player playerId, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, bool manualSwitch)));
        InkWars.Model.Model_Events.Instance.remove_OnStunBreak(value:  new Model_Events.OnStunBreakDelegate(object:  this, method:  public System.Void PlayerCharacterUIController::OnStunBreak(InkWars.Model.Player playerId, float revengeSuperLevel, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)));
        InkWars.Model.Model_Events.Instance.remove_OnModelStart(value:  new Model_Events.BasicDelegate(object:  this, method:  System.Void PlayerCharacterUIController::OnModelStart()));
        val_14 = null;
        val_14 = null;
        PlayerCharacterUIController.OnFullyInkAnimationPlayedEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PlayerCharacterUIController::ReloadInkedAvatar()));
    }
    private void ReloadInkedAvatar()
    {
        UnityEngine.Coroutine val_3 = this.m_CharacterAssetLoader.StartCoroutine(routine:  this.LoadPlayerAvatar(_image:  this.m_CharacterImage, _ID:  this.m_CharID, _cl:  this.m_CharacterAssetLoader, forceLoadInked:  true));
    }
    private System.Collections.IEnumerator LoadPlayerAvatar(UnityEngine.UI.Image _image, CharacterNameID _ID, CharacterAssetLoader _cl, bool forceLoadInked = False)
    {
        PlayerCharacterUIController.<LoadPlayerAvatar>d__36 val_1 = new PlayerCharacterUIController.<LoadPlayerAvatar>d__36();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            ._image = _image;
            ._ID = _ID;
            ._cl = _cl;
        }
        else
        {
                mem[48] = this;
            mem[64] = _image;
            mem[40] = _ID;
            mem[32] = _cl;
        }
        
        .forceLoadInked = forceLoadInked;
        return (System.Collections.IEnumerator)val_1;
    }
    private void InitializeCharaterImages()
    {
        null = null;
        if((Character_GlobalInfo.gameMode - 1) >= 2)
        {
            
        }
        else
        {
                InkWars.Model.Model_Player val_2 = this.PlayerModel;
        }
        
        this.m_CharacterTypeIcon.enabled = ((val_2.ID == 1) ? 1 : 0) ^ 1;
        UnityEngine.Coroutine val_7 = this.m_CharacterAssetLoader.StartCoroutine(routine:  this.LoadPlayerAvatar(_image:  this.m_CharacterImage, _ID:  this.m_CharID, _cl:  this.m_CharacterAssetLoader, forceLoadInked:  false));
        this.m_CharacterTypeIcon.sprite = CharacterAssetLoader.LoadResource_CharacterStatTypeIcon(charNameID:  this.m_CharID);
        CharacterData val_11 = CharacterDataManager.Get(id:  this.m_CharID);
        if(val_11.realPersonCharacter == false)
        {
            goto label_11;
        }
        
        this.m_BackgroundMask.sprite = this.m_PurpleSprite;
        this.m_FillBar.sprite = this.m_PurpleSprite;
        if(this.m_CharacterMask != null)
        {
            goto label_26;
        }
        
        label_27:
        label_26:
        this.m_CharacterMask.sprite = this.m_PurpleSprite;
        return;
        label_11:
        CharacterClan val_14 = CharacterDataManager.Get(id:  this.m_CharID).clan;
        if(val_14 == 1)
        {
            goto label_18;
        }
        
        if(val_14 != 0)
        {
                return;
        }
        
        this.m_BackgroundMask.sprite = this.m_RedSprite;
        this.m_FillBar.sprite = this.m_RedSprite;
        if(this.m_CharacterMask != null)
        {
            goto label_26;
        }
        
        goto label_27;
        label_18:
        this.m_BackgroundMask.sprite = this.m_BlueSprite;
        this.m_FillBar.sprite = this.m_BlueSprite;
        if(this.m_CharacterMask != null)
        {
            goto label_26;
        }
        
        goto label_27;
    }
    private void Update()
    {
        if(this.PlayerModel == null)
        {
                return;
        }
        
        float val_3 = this.PlayerModel.RevengeSuperLevel;
        val_3 = val_3 - this.m_RevengeSuperFillPercent;
        val_3 = val_3 * 0.04f;
        val_3 = this.m_RevengeSuperFillPercent + val_3;
        this.m_RevengeSuperFillPercent = val_3;
        val_3 = val_3 / 100f;
        this.m_FillPercent = val_3;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  this.m_BackgroundSize, y:  this.m_BackgroundSize);
        this.m_FillBar.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        float val_6 = 0.84f;
        val_6 = this.m_FillPercent * val_6;
        this.m_FillBar.fillAmount = val_6;
    }
    private void OnRevengeSuper(InkWars.Model.Player id, InkWars.Model.BubbleTypes revengeSuperType, InkWars.Model.RevengeSuperEventState state)
    {
        BubbleHolderUIController val_4;
        System.Object[] val_5;
        val_4 = this;
        val_5 = this.PlayerModel;
        if(val_1.ID != id)
        {
                return;
        }
        
        object[] val_2 = new object[2];
        val_5 = val_2;
        val_5[0] = id;
        val_5[1] = state;
        UnityEngine.Debug.LogFormat(format:  ">> PlayerCharacterUIController - OnRevengeSuper: {0} - State: {1}", args:  val_2);
        if(state > 4)
        {
                return;
        }
        
        var val_4 = 40824412 + (state) << 2;
        val_4 = val_4 + 40824412;
        goto (40824412 + (state) << 2 + 40824412);
    }
    public void OnBubbleSwitch(InkWars.Model.Player playerId, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, bool manualSwitch)
    {
        if(val_1.ID != playerId)
        {
                return;
        }
        
        if(this.m_IsRevengeReady == false)
        {
                return;
        }
        
        InkWars.Model.Model_Player val_2 = this.PlayerModel;
        bool val_9 = ~(GenericFunctions.IsSuperType(bubbleType:  val_2.LoadedBubble));
        val_9 = val_9 & 1;
        this.m_IsLoadedBubbleNotSpecial = val_9;
        object[] val_4 = new object[2];
        InkWars.Model.Model_Player val_5 = this.PlayerModel;
        val_4[0] = val_5.LoadedBubble;
        val_4[1] = this.m_IsLoadedBubbleNotSpecial;
        UnityEngine.Debug.LogFormat(format:  "Equipped bubble (Spare): {0} - Is not special? {1}", args:  val_4);
        this.PlayerModel = this.m_IsLoadedBubbleNotSpecial;
        if(this.m_FlashPlayerCharacter == null)
        {
            goto label_15;
        }
        
        if(this.PlayerModel == false)
        {
            goto label_16;
        }
        
        label_23:
        this.m_FlashPlayerCharacter.StopFlash();
        if(0 != this.equippedSoundSource)
        {
                this.equippedSoundSource.Stop();
        }
        
        if(this.EquippedSoundCoroutine == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.EquippedSoundCoroutine);
        this.EquippedSoundCoroutine = 0;
        return;
        label_15:
        if(this.PlayerModel == true)
        {
            goto label_23;
        }
        
        label_16:
        this.m_FlashPlayerCharacter.Flash();
        if(this.EquippedSoundCoroutine != null)
        {
                return;
        }
        
        System.Collections.IEnumerator val_7 = this.SoundLoop();
        this.EquippedSoundCoroutine = val_7;
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  val_7);
    }
    private System.Collections.IEnumerator SoundLoop()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new PlayerCharacterUIController.<SoundLoop>d__41();
    }
    public void OnStunBreak(InkWars.Model.Player playerId, float revengeSuperLevel, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)
    {
        UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.stunBreakerSound, volume:  1f);
        InkWars.Model.Model_Player val_3 = this.PlayerModel;
        if(val_3.ID != playerId)
        {
                return;
        }
        
        this.ResetRevengeState();
        InkWars.Model.Model_Events.Instance.Event_Switch(Id:  playerId, loadedBubble:  spareBubble, spareBubble:  2, manualSwitch:  false);
    }
    private void ResetRevengeState()
    {
        this.m_IsRevengeReady = false;
        this.m_FlashPlayerCharacterAvatar.StopFlash();
        this.m_BubbleHolder.Hide(_shouldWait:  true);
        this.m_FlashRevengeGraphic.Flash();
        if(0 != this.equippedSoundSource)
        {
                this.equippedSoundSource.Stop();
        }
        
        if(this.EquippedSoundCoroutine == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.EquippedSoundCoroutine);
        this.EquippedSoundCoroutine = 0;
    }
    public UnityEngine.Sprite get_CharacterSprite()
    {
        if(this.m_CharacterImage != null)
        {
                return this.m_CharacterImage.sprite;
        }
        
        return this.m_CharacterImage.sprite;
    }
    public CharacterAssetLoader get_AssetLoader()
    {
        return (CharacterAssetLoader)this.m_CharacterAssetLoader;
    }
    public bool get_IsRevengeReady()
    {
        return (bool)this.m_IsRevengeReady;
    }
    public void set_IsRevengeReady(bool value)
    {
        this.m_IsRevengeReady = value;
    }
    private void OnGameResult(InkWars.Model.GameResult result, bool isFinished)
    {
        this.ResetRevengeState();
    }
    public PlayerCharacterUIController()
    {
    
    }
    private static PlayerCharacterUIController()
    {
        PlayerCharacterUIController.OnFullyInkAnimationPlayedEvent = new UnityEngine.Events.UnityEvent();
    }

}
