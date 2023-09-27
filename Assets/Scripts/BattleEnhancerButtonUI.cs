using UnityEngine;
public class BattleEnhancerButtonUI : Control_Base<BattleEnhancerButtonUI>
{
    // Fields
    private UnityEngine.UI.Image buttonBG;
    private UnityEngine.UI.Image icon;
    private TMPro.TextMeshProUGUI levelTxt;
    private UnityEngine.UI.Button button;
    private IconGlowEffect glowEffect;
    private UnityEngine.UI.Outline glowObj;
    private UnityEngine.Sprite raySprite;
    private UnityEngine.UI.Image rays;
    private DG.Tweening.Tweener rayRotateTW;
    private DG.Tweening.Tweener buttonScaleAnimTW;
    private DG.Tweening.Tweener buttonFlashAnimTW;
    private DG.Tweening.Sequence soundSequence;
    private BattleEnhancerItem data;
    
    // Methods
    private int GetPlayerEnhancerId()
    {
        var val_4;
        InkWars.Model.Model_Player val_1 = this.PlayerModel;
        if(val_1.ID != 0)
        {
                if(CloudOpponent.current != null)
        {
                return (int)val_2.enhancerID;
        }
        
            return (int)val_2.enhancerID;
        }
        
        val_4 = null;
        val_4 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Settings.SelectedBattleEnhancer;
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited});
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "RayEffect");
        UnityEngine.UI.Image val_2 = val_1.AddComponent<UnityEngine.UI.Image>();
        this.rays = val_2;
        val_2.sprite = this.raySprite;
        val_1.transform.SetParent(p:  this.transform);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_1.GetComponent<UnityEngine.RectTransform>().anchoredPosition3D = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.one;
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, d:  450f);
        val_1.GetComponent<UnityEngine.RectTransform>().sizeDelta = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
        val_1.transform.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        if(val_1 != null)
        {
                val_1.SetActive(value:  false);
        }
        else
        {
                val_1.SetActive(value:  false);
        }
        
        val_1.transform.SetAsFirstSibling();
    }
    public void OnEnable()
    {
        InkWars.Model.Model_Events.Instance.add_OnModelStart(value:  new Model_Events.BasicDelegate(object:  this, method:  System.Void BattleEnhancerButtonUI::OnModelStart()));
        InkWars.Model.Model_Events.Instance.add_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void BattleEnhancerButtonUI::OnGameResult(InkWars.Model.GameResult result, bool afterFinished)));
        this.rays.gameObject.SetActive(value:  false);
    }
    public void OnDisable()
    {
        InkWars.Model.Model_Events.Instance.remove_OnModelStart(value:  new Model_Events.BasicDelegate(object:  this, method:  System.Void BattleEnhancerButtonUI::OnModelStart()));
        InkWars.Model.Model_Events.Instance.remove_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void BattleEnhancerButtonUI::OnGameResult(InkWars.Model.GameResult result, bool afterFinished)));
        if(this.rayRotateTW == null)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.rayRotateTW, complete:  false);
    }
    private void OnGameResult(InkWars.Model.GameResult result, bool afterFinished)
    {
        if(afterFinished != false)
        {
                return;
        }
        
        this.OnButtonAnimDone();
        this.PlayEndSound();
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void OnModelStart()
    {
        BattleEnhancerItem val_13;
        InkWars.Model.Model_Manager val_1 = InkWars.Model.Model_Manager.Instance;
        if(val_1.Model.Feature_BattleEnhancer != false)
        {
                int val_2 = this.GetPlayerEnhancerId();
            val_13 = BattleEnhancerItem.FromInt(number:  val_2);
            this.data = val_13;
            if(val_3.enhancerType != 0)
        {
                this.UpdateButtonBG();
            val_13 = this.data.enhancerType;
            if((BattleEnhancerCollection.Get(type:  val_13)) != null)
        {
                this.icon.sprite = val_4.icon;
            InkWars.Model.Model_Player val_5 = this.PlayerModel;
            if(val_5.ID == 0)
        {
                this.button.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerButtonUI::OnClick()));
            this.button.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerButtonUI::OnClick()));
        }
        
            this.SetLevelTxt(itemData:  val_2);
            InkWars.Model.Model_Events.Instance.add_OnBattleEnhancer(value:  new Model_Events.OnBattleEnhancerDelegate(object:  this, method:  System.Void BattleEnhancerButtonUI::OnBattleEnhancer(float timeStamp, InkWars.Model.Player aNePlayerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)));
            this.glowEffect.enabled = false;
            this.glowObj.enabled = false;
            return;
        }
        
        }
        
        }
        
        this.gameObject.SetActive(value:  false);
    }
    private void SetLevelTxt(int itemData)
    {
        BattleEnhancerItem val_1 = BattleEnhancerItem.FromInt(number:  itemData);
        this.levelTxt.text = "Lv " + val_1.level.ToString();
    }
    private void OnDestroy()
    {
        InkWars.Model.Model_Events.Instance.remove_OnBattleEnhancer(value:  new Model_Events.OnBattleEnhancerDelegate(object:  this, method:  System.Void BattleEnhancerButtonUI::OnBattleEnhancer(float timeStamp, InkWars.Model.Player aNePlayerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)));
        this.glowEffect.enabled = false;
        this.glowObj.enabled = false;
    }
    private void OnBattleEnhancer(float timeStamp, InkWars.Model.Player aNePlayerId, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)
    {
        InkWars.Model.Model_Player val_1 = this.PlayerModel;
        if(val_1.ID != aNePlayerId)
        {
                return;
        }
        
        if(state != 2)
        {
                if(state != 1)
        {
                return;
        }
        
            this.PlayButtonAnim();
            this.UpdateButtonBG();
            return;
        }
        
        this.OnButtonAnimDone();
    }
    private void OnClick()
    {
        var val_7;
        BattleEnhancerItem val_8;
        this.button.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerButtonUI::OnClick()));
        this.UpdateButtonBG();
        InkWars.Model.Model_Player val_3 = this.PlayerModel;
        val_3.BattleEnhancerLevel = this.data.level;
        InkWars.Model.Model_Player val_4 = this.PlayerModel;
        val_4.BattleEnhancerType = this.data.enhancerType;
        InkWars.Model.Model_Player val_5 = this.PlayerModel;
        val_5.TryEquipBattleEnhancer = true;
        val_7 = null;
        val_7 = null;
        val_8 = this.data;
        if(this.data != null)
        {
            goto label_10;
        }
        
        val_8 = this.data;
        if(val_8 == null)
        {
            goto label_11;
        }
        
        label_10:
        DataStructs.UserDataDictionary.Items.AddEnhancerCount(type:  this.data.enhancerType, level:  this.data.level, count:  0);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
        DataStructs.UserDataDictionary.Settings.SelectedBattleEnhancer = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited};
        return;
        label_11:
    }
    private void PlayButtonAnim()
    {
        int val_1 = UnityEngine.Mathf.Clamp(value:  this.data.level, min:  1, max:  6);
        int val_2 = val_1 + (val_1 << 2);
        val_2 = val_2 << 1;
        if(this.buttonScaleAnimTW != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.buttonScaleAnimTW, complete:  false);
        }
        
        float val_37 = 1.5f;
        val_37 = (float)val_2 * val_37;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  1.2f);
        this.buttonScaleAnimTW = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.4f), loops:  UnityEngine.Mathf.RoundToInt(f:  val_37 / 0.4f), loopType:  1), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void BattleEnhancerButtonUI::OnButtonAnimDone()));
        if(this.buttonFlashAnimTW != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.buttonFlashAnimTW, complete:  false);
        }
        
        float val_38 = -4.5f;
        val_38 = val_37 + val_38;
        this.buttonFlashAnimTW = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.transform.GetComponent<UnityEngine.CanvasGroup>(), endValue:  0f, duration:  0.1f), delay:  val_38), loops:  UnityEngine.Mathf.RoundToInt(f:  45f), loopType:  1), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void BattleEnhancerButtonUI::OnButtonAnimDone()));
        if(this.soundSequence != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.soundSequence, complete:  false);
        }
        
        DG.Tweening.Sequence val_20 = DG.Tweening.DOTween.Sequence();
        this.soundSequence = val_20;
        DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_20, interval:  val_37 + (-1f));
        DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.soundSequence, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void BattleEnhancerButtonUI::PlayEndSound()));
        this.glowEffect.enabled = true;
        this.glowObj.enabled = true;
        if(this.rayRotateTW != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.rayRotateTW, complete:  false);
        }
        
        this.rays.gameObject.SetActive(value:  true);
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, d:  360f);
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, d:  (1152921528860213664 != 0) ? 1f : -1f);
        this.rayRotateTW = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this.rays.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, duration:  2f, mode:  1), ease:  1), loops:  0, loopType:  0);
        UnityEngine.AudioSource val_36 = GameAudio.sound.PlayOneShot(clip:  BattleEnhancerCollection.GetSFX(state:  1), volume:  1f);
    }
    private void PlayEndSound()
    {
        UnityEngine.AudioSource val_3 = GameAudio.sound.PlayOneShot(clip:  BattleEnhancerCollection.GetSFX(state:  2), volume:  1f);
    }
    private void OnButtonAnimDone()
    {
        if(this.buttonScaleAnimTW != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.buttonScaleAnimTW, complete:  false);
        }
        
        if(this.buttonFlashAnimTW != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.buttonFlashAnimTW, complete:  false);
        }
        
        if(this.soundSequence != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.soundSequence, complete:  false);
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.icon.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        this.transform.GetComponent<UnityEngine.CanvasGroup>().alpha = 0.6f;
        this.button.interactable = false;
        this.glowEffect.enabled = false;
        this.glowObj.enabled = false;
        this.UpdateButtonBG();
        if(this.rayRotateTW != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.rayRotateTW, complete:  false);
        }
        
        this.rays.gameObject.SetActive(value:  false);
    }
    private void UpdateButtonBG()
    {
        InkWars.Model.Model_Player val_1 = this.PlayerModel;
        this.buttonBG.sprite = BattleEnhancerCollection.GetButtonBG(state:  val_1.BattleEnhancerState);
    }
    public BattleEnhancerButtonUI()
    {
    
    }

}
