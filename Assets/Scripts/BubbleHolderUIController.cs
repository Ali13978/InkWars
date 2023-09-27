using UnityEngine;
public class BubbleHolderUIController : Control_Base<BubbleHolderUIController>
{
    // Fields
    private UnityEngine.RectTransform m_RectTransform;
    private UnityEngine.UI.Image m_BubbleSlot;
    private UnityEngine.UI.Image m_BubbleSlotGlow;
    public UnityEngine.UI.Image m_BubbleSlotArrow;
    public UnityEngine.UI.Text m_BubbleCounter;
    private RevengeCharacterInformation m_RevengeCharacterInformation;
    private RevengeCharacterInformation.BubbleInfo m_BubbleInfo;
    private UnityEngine.UI.Image m_BubbleTypeText;
    private UnityEngine.Color m_FlashGlowColor;
    private ColorFlash m_FlashBubbleGlow;
    private UnityEngine.Sprite[] m_StunnerText;
    private UnityEngine.Sprite[] m_CannonBallText;
    private UnityEngine.Sprite[] m_EraserText;
    private UnityEngine.Sprite[] m_RainbowTransformerText;
    private UnityEngine.Sprite[] m_VirusText;
    private UnityEngine.AudioClip onSuperFullSound;
    private BubblesCollection bubbleCollection;
    private bool active;
    private System.Collections.IEnumerator animateTextCoroutine;
    
    // Properties
    public int StunnerCount { get; set; }
    public int CannonballCount { get; set; }
    public int EraserCount { get; set; }
    
    // Methods
    public int get_StunnerCount()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.StunnerBall;
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
    }
    public void set_StunnerCount(int value)
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  value);
        DataStructs.UserDataDictionary.Items.StunnerBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
    }
    public int get_CannonballCount()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.IronBall;
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
    }
    public void set_CannonballCount(int value)
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  value);
        DataStructs.UserDataDictionary.Items.IronBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
    }
    public int get_EraserCount()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.ColorEraserBall;
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
    }
    public void set_EraserCount(int value)
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  value);
        DataStructs.UserDataDictionary.Items.ColorEraserBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
    }
    internal override void Awake()
    {
        this.Awake();
        if(0 == this.m_RectTransform)
        {
                this.m_RectTransform = this.GetComponent<UnityEngine.RectTransform>();
        }
        
        if(0 == this.m_RevengeCharacterInformation)
        {
                return;
        }
        
        this.m_BubbleInfo = this.m_RevengeCharacterInformation.BubbleInformation;
    }
    private void Update()
    {
        InkWars.Model.Model_Player val_1 = this.PlayerModel;
        if(val_1.ID != 0)
        {
                return;
        }
        
        this.RefreshArrowAndCount();
    }
    internal override void Start()
    {
        this.Start();
        UnityEngine.Vector3 val_3 = this.m_BubbleSlot.rectTransform.localScale;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  1.1f);
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_BubbleSlot.rectTransform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.2f), loops:  0, loopType:  1);
        UnityEngine.Vector3 val_9 = this.m_BubbleSlotGlow.rectTransform.localScale;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  1.2f);
        DG.Tweening.Tweener val_12 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_BubbleSlotGlow.rectTransform, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.2f), loops:  0, loopType:  1);
        this.Hide(_shouldWait:  false);
        this.OnModelStart();
    }
    private void OnEnable()
    {
        InkWars.Model.Model_Events.Instance.add_OnModelStart(value:  new Model_Events.BasicDelegate(object:  this, method:  System.Void BubbleHolderUIController::OnModelStart()));
    }
    private void OnDisable()
    {
        InkWars.Model.Model_Events.Instance.remove_OnModelStart(value:  new Model_Events.BasicDelegate(object:  this, method:  System.Void BubbleHolderUIController::OnModelStart()));
    }
    private void OnModelStart()
    {
        InkWars.Model.Model_Player val_1 = this.PlayerModel;
        if(val_1.ID != 0)
        {
                return;
        }
        
        if(val_2.Feature_Powerup != 2)
        {
                return;
        }
        
        int val_3 = Control_Base<BubbleHolderUIController>.Model.StunnerCount;
        int val_4 = val_3.CannonballCount;
        int val_6 = val_4 + val_3;
        val_6 = val_6 + val_4.EraserCount;
        if(val_6 < 1)
        {
                return;
        }
        
        this.m_BubbleInfo.BubbleType = 10;
        this.CyclePowerUpSFX(playButtonSound:  false);
        this.ForceShow();
    }
    public void Initialize()
    {
        UnityEngine.Sprite[] val_39;
        var val_44;
        if(this.PlayerModel != null)
        {
                InkWars.Model.Model_Core val_2 = Control_Base<BubbleHolderUIController>.Model;
            if(val_2.Feature_Powerup == 1)
        {
                InkWars.Model.Model_Player val_3 = this.PlayerModel;
            this.m_BubbleInfo.BubbleType = val_3.RevengeSuperType;
        }
        
        }
        
        InkWars.Model.BubbleTypes val_35 = this.m_BubbleInfo.BubbleType;
        val_35 = val_35 - 8;
        if(val_35 <= 8)
        {
                var val_36 = 40825956 + ((this.m_BubbleInfo.BubbleType - 8)) << 2;
            val_36 = val_36 + 40825956;
        }
        else
        {
                object[] val_16 = new object[4];
            val_16[0] = "CANNOT INITIALIZE BUBBLE SLOT - Wrong ball type: ";
            val_16[1] = this.m_BubbleInfo.BubbleType;
            val_16[2] = " id: ";
            InkWars.Model.Model_Player val_17 = this.PlayerModel;
            val_16[3] = val_17.ID;
            UnityEngine.Debug.LogError(message:  +val_16);
            this.m_BubbleSlot.sprite = 0;
            val_39 = 0;
            InkWars.Model.Model_Manager val_27 = InkWars.Model.Model_Manager.Instance;
            this.m_BubbleCounter.gameObject.SetActive(value:  (val_27.Model.Feature_Powerup == 2) ? 1 : 0);
            this.m_BubbleSlotArrow.gameObject.SetActive(value:  (val_27.Model.Feature_Powerup == 2) ? 1 : 0);
            val_44 = this.m_BubbleSlotGlow;
            val_44.SetColor(name:  "_FlashColor", value:  new UnityEngine.Color() {r = this.m_FlashGlowColor, g = V9.16B, b = V10.16B, a = V11.16B});
            if( == null)
        {
                return;
        }
        
            if(this.animateTextCoroutine != null)
        {
                this.StopCoroutine(routine:  this.animateTextCoroutine);
        }
        
            val_44 = this.m_RevengeCharacterInformation.BubbleInformation;
            System.Collections.IEnumerator val_33 = this.AnimateText(_swapRate:  val_32.TextAnimationSwapRate, _spritesToSwap:  null);
            this.animateTextCoroutine = val_33;
            UnityEngine.Coroutine val_34 = this.StartCoroutine(routine:  val_33);
        }
    
    }
    public void Show()
    {
        null = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
                InkWars.Model.Model_Player val_1 = this.PlayerModel;
            if(val_1.ID != 0)
        {
                return;
        }
        
        }
        
        this.ForceShow();
    }
    private void ForceShow()
    {
        this.StopAllCoroutines();
        this.Initialize();
        this.m_FlashBubbleGlow.Flash();
        DG.Tweening.Tweener val_2 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.m_RectTransform, endValue:  0f, duration:  0.5f, snapping:  false), ease:  27);
        UnityEngine.AudioSource val_4 = GameAudio.sound.PlayOneShot(clip:  this.onSuperFullSound, volume:  1f);
        this.active = true;
    }
    private System.Collections.IEnumerator AnimateText(float _swapRate, UnityEngine.Sprite[] _spritesToSwap)
    {
        BubbleHolderUIController.<AnimateText>d__37 val_1 = new BubbleHolderUIController.<AnimateText>d__37();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            ._swapRate = _swapRate;
        }
        else
        {
                mem[32] = this;
            mem[48] = _swapRate;
        }
        
        ._spritesToSwap = _spritesToSwap;
        return (System.Collections.IEnumerator)val_1;
    }
    public void Hide(bool _shouldWait)
    {
        this.active = false;
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.m_RectTransform, endValue:  -300f, duration:  (_shouldWait != true) ? 0.25f : 0f, snapping:  false), ease:  6);
    }
    public void EquipSuper()
    {
        var val_27;
        InkWars.Model.BubbleTypes val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        val_27 = this;
        if(this.active == false)
        {
                return;
        }
        
        val_28 = 1152921528422372144;
        if(this.PlayerModel == null)
        {
                return;
        }
        
        GameAudio.PlayBubbleSwitchSound();
        InkWars.Model.Model_Core val_2 = Control_Base<BubbleHolderUIController>.Model;
        if(val_2.Feature_Powerup != 2)
        {
                if(val_2.Feature_Powerup != 1)
        {
                return;
        }
        
            val_27 = this.PlayerModel;
            val_3.TryEquipSuper = true;
            return;
        }
        
        InkWars.Model.Model_Player val_4 = this.PlayerModel;
        if(this.m_BubbleInfo.BubbleType == val_4.LoadedBubble)
        {
                return;
        }
        
        InkWars.Model.Model_Player val_5 = this.PlayerModel;
        if(val_5.LoadedBubble == 8)
        {
            goto label_14;
        }
        
        if(val_5.LoadedBubble == 9)
        {
            goto label_15;
        }
        
        if(val_5.LoadedBubble != 10)
        {
            goto label_18;
        }
        
        int val_6 = val_5.EraserCount;
        val_6.EraserCount = val_6 + 1;
        goto label_18;
        label_14:
        int val_8 = val_5.StunnerCount;
        val_8.StunnerCount = val_8 + 1;
        goto label_18;
        label_15:
        int val_10 = val_5.CannonballCount;
        val_10.CannonballCount = val_10 + 1;
        label_18:
        if(this.m_BubbleInfo == null)
        {
                val_29 = 0;
        }
        
        if(this.m_BubbleInfo.BubbleType == 10)
        {
            goto label_20;
        }
        
        if(this.m_BubbleInfo.BubbleType == 9)
        {
            goto label_21;
        }
        
        if(this.m_BubbleInfo.BubbleType != 8)
        {
                return;
        }
        
        if(this.StunnerCount < 1)
        {
                return;
        }
        
        if(this.m_BubbleInfo == null)
        {
                val_30 = 0;
        }
        
        val_28 = this.m_BubbleInfo.BubbleType;
        if(this.PlayerModel == null)
        {
                val_30 = 0;
        }
        
        val_13.LoadedBubble = val_28;
        int val_14 = this.StunnerCount;
        val_14.StunnerCount = val_14 - 1;
        this.RefreshArrowAndCount();
        if(this.StunnerCount != 0)
        {
                return;
        }
        
        goto label_36;
        label_20:
        if(this.EraserCount < 1)
        {
                return;
        }
        
        if(this.m_BubbleInfo == null)
        {
                val_31 = 0;
        }
        
        val_28 = this.m_BubbleInfo.BubbleType;
        if(this.PlayerModel == null)
        {
                val_31 = 0;
        }
        
        val_18.LoadedBubble = val_28;
        int val_19 = this.EraserCount;
        val_19.EraserCount = val_19 - 1;
        this.RefreshArrowAndCount();
        if(this.EraserCount != 0)
        {
                return;
        }
        
        goto label_36;
        label_21:
        if(this.CannonballCount < 1)
        {
                return;
        }
        
        if(this.m_BubbleInfo == null)
        {
                val_32 = 0;
        }
        
        val_28 = this.m_BubbleInfo.BubbleType;
        if(this.PlayerModel == null)
        {
                val_32 = 0;
        }
        
        val_23.LoadedBubble = val_28;
        int val_24 = this.CannonballCount;
        val_24.CannonballCount = val_24 - 1;
        this.RefreshArrowAndCount();
        if(this.CannonballCount != 0)
        {
                return;
        }
        
        label_36:
        this.CyclePowerUpSFX(playButtonSound:  false);
    }
    public void RefreshArrowAndCount()
    {
        object val_15;
        var val_16;
        val_15 = 5145;
        int val_1 = this.StunnerCount;
        int val_2 = val_1.CannonballCount;
        var val_5 = (val_2 < 1) ? ((val_1 > 0) ? 1 : 0) : ((val_1 > 0) ? (1 + 1) : 1);
        if(this.m_BubbleInfo == null)
        {
                val_15 = 0;
        }
        
        if(this.m_BubbleInfo.BubbleType == 10)
        {
            goto label_2;
        }
        
        if(this.m_BubbleInfo.BubbleType == 9)
        {
            goto label_3;
        }
        
        if(this.m_BubbleInfo.BubbleType != 8)
        {
            goto label_4;
        }
        
        int val_8 = this.StunnerCount;
        goto label_7;
        label_2:
        int val_9 = this.EraserCount;
        goto label_7;
        label_3:
        int val_10 = this.CannonballCount;
        goto label_7;
        label_4:
        val_15 = 0;
        label_7:
        string val_11 = System.String.Format(format:  "<size=50%>x </size>{0}", arg0:  val_15);
        UnityEngine.GameObject val_12 = this.m_BubbleSlotArrow.gameObject;
        if(((val_2.EraserCount > 0) ? (val_5 + 1) : (val_5)) >= 2)
        {
            goto label_10;
        }
        
        val_16 = 0;
        if(val_12 != null)
        {
            goto label_15;
        }
        
        goto label_12;
        label_10:
        InkWars.Model.Model_Manager val_13 = InkWars.Model.Model_Manager.Instance;
        if(val_12 != null)
        {
            goto label_15;
        }
        
        label_12:
        label_15:
        val_12.SetActive(value:  (val_13.Model.Feature_Powerup == 2) ? 1 : 0);
    }
    private void CyclePowerUpSFX(bool playButtonSound = True)
    {
        var val_8;
        int val_1 = this.StunnerCount;
        int val_2 = val_1.EraserCount;
        if(val_2.CannonballCount == (val_1 + val_2))
        {
                this.Hide(_shouldWait:  false);
            return;
        }
        
        if(playButtonSound != false)
        {
                val_8 = 0;
            GameAudio.PlayBubbleSwitchSound();
        }
        
        label_14:
        if(this.m_BubbleInfo == null)
        {
                val_8 = 0;
        }
        
        if(this.m_BubbleInfo.BubbleType == 10)
        {
            goto label_6;
        }
        
        if(this.m_BubbleInfo.BubbleType == 9)
        {
            goto label_7;
        }
        
        if(this.m_BubbleInfo.BubbleType != 8)
        {
            goto label_14;
        }
        
        if(this.m_BubbleInfo == null)
        {
                val_8 = 0;
        }
        
        this.m_BubbleInfo.BubbleType = 9;
        int val_5 = this.CannonballCount;
        goto label_12;
        label_6:
        if(this.m_BubbleInfo == null)
        {
                val_8 = 0;
        }
        
        this.m_BubbleInfo.BubbleType = 8;
        int val_6 = this.StunnerCount;
        goto label_12;
        label_7:
        if(this.m_BubbleInfo == null)
        {
                val_8 = 0;
        }
        
        this.m_BubbleInfo.BubbleType = 10;
        label_12:
        if(this.EraserCount <= 0)
        {
            goto label_14;
        }
        
        this.RefreshArrowAndCount();
        this.Initialize();
    }
    public void CyclePowerup()
    {
        this.CyclePowerUpSFX(playButtonSound:  true);
    }
    public BubbleHolderUIController()
    {
    
    }

}
