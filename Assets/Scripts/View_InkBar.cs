using UnityEngine;
public class View_InkBar : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image emptyMeterImg;
    private UnityEngine.UI.Image fullMeterImg;
    private UnityEngine.UI.Image fullGlowMeterImg;
    private UnityEngine.UI.Image brokenMeterImg;
    private UnityEngine.UI.Image inkBlobImg;
    private UnityEngine.UI.Image arrowImg;
    private UnityEngine.ParticleSystem inkBlobFX;
    private UnityEngine.AudioClip largeBlobClip;
    private UnityEngine.AudioClip fullMeterSFX;
    private UnityEngine.RectTransform arrowLowPos;
    private UnityEngine.RectTransform arrowHighPos;
    private const float LOW_IMAGE_FILL_AMOUNT = 0.2;
    private const float HIGH_IMAGE_FILL_AMOUNT = 0.65;
    private int initAmount;
    private bool fullyInkAnimPlayed;
    private int lastModelInkIndex;
    private int _inkAmount;
    
    // Properties
    public int inkAmount { get; set; }
    
    // Methods
    public int get_inkAmount()
    {
        return (int)this._inkAmount;
    }
    public void set_inkAmount(int value)
    {
        int val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  0, max:  100);
        if(this._inkAmount == val_1)
        {
                return;
        }
        
        this._inkAmount = val_1;
        this.UpdateInkMeterFullAmountUI();
        this.PlayInkMeterChangeToFullAnimation();
    }
    private void OnEnable()
    {
        this.fullyInkAnimPlayed = false;
    }
    private void Start()
    {
        var val_8;
        GameMode val_9;
        var val_10;
        InkWars.Model.Model_Core val_1 = View_Core.Model;
        if(val_1.Feature_InkEmUp == false)
        {
            goto label_8;
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = Character_GlobalInfo.gameMode;
        if(val_9 == 1)
        {
            goto label_5;
        }
        
        val_9 = Character_GlobalInfo.gameMode;
        if(val_9 != 2)
        {
            goto label_8;
        }
        
        label_5:
        InkWars.Model.Model_Core val_2 = View_Core.Model;
        if(val_2.InkEmUp_Player.ID == 0)
        {
            goto label_11;
        }
        
        label_8:
        this.gameObject.SetActive(value:  false);
        return;
        label_11:
        val_10 = null;
        val_10 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetCurrentLevelData().InkPercentage;
        this.Init(fullAmount:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited}));
    }
    private void Update()
    {
        InkWars.Model.Model_Core val_1 = View_Core.Model;
        if((val_1.InkEmUp_CurrentPhase - 4) < 2)
        {
            goto label_2;
        }
        
        if(val_1.InkEmUp_CurrentPhase == 2)
        {
            goto label_3;
        }
        
        if(val_1.InkEmUp_CurrentPhase != 6)
        {
                return;
        }
        
        if(this.fullyInkAnimPlayed == true)
        {
                return;
        }
        
        this.fullyInkAnimPlayed = true;
        if(this._inkAmount >= 100)
        {
            goto label_6;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.8f), ease:  26), delay:  2f);
        return;
        label_2:
        InkWars.Model.Model_Core val_8 = View_Core.Model;
        this.inkAmount = val_8.InkEmUp_InkIndex + this.initAmount;
        InkWars.Model.Model_Core val_10 = View_Core.Model;
        if(this.lastModelInkIndex == val_10.InkEmUp_InkIndex)
        {
                return;
        }
        
        InkWars.Model.Model_Core val_11 = View_Core.Model;
        this.lastModelInkIndex = val_11.InkEmUp_InkIndex;
        this.PlayInkMeterChangeAnimation();
        return;
        label_3:
        InkWars.Model.Model_Core val_12 = View_Core.Model;
        this.lastModelInkIndex = val_12.InkEmUp_InkIndex;
        return;
        label_6:
        DG.Tweening.Sequence val_13 = this.PlayFullMeterAnim();
    }
    private void UpdateInkMeterFullAmountUI()
    {
        float val_1 = (float)this._inkAmount / 100f;
        this.fullMeterImg.fillAmount = UnityEngine.Mathf.Lerp(a:  0.2f, b:  0.65f, t:  val_1);
        UnityEngine.Vector2 val_4 = this.arrowLowPos.anchoredPosition;
        UnityEngine.Vector2 val_5 = this.arrowHighPos.anchoredPosition;
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, t:  val_1);
        this.arrowImg.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
    }
    private void PlayInkMeterChangeAnimation()
    {
        int val_1 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.arrowImg, complete:  false);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        this.arrowImg.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.1f);
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.arrowImg.transform, punch:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.25f, vibrato:  1, elasticity:  1f);
    }
    private void PlayInkMeterChangeToFullAnimation()
    {
        if(this._inkAmount != 100)
        {
                return;
        }
        
        UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.fullMeterSFX, volume:  1f);
        UnityEngine.Color val_3 = UnityEngine.Color.green;
        this.arrowImg.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFillAmount(target:  this.fullMeterImg, endValue:  1f, duration:  0.7f);
    }
    public void Init(int fullAmount)
    {
        int val_1 = UnityEngine.Mathf.Clamp(value:  fullAmount, min:  0, max:  100);
        if(val_1 < 100)
        {
                this.SetImages(isBroken:  false);
            this._inkAmount = val_1;
            this.UpdateInkMeterFullAmountUI();
            this.initAmount = val_1;
            return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    private void SetImages(bool isBroken)
    {
        bool val_2 = isBroken ^ 1;
        this.emptyMeterImg.gameObject.SetActive(value:  val_2);
        this.fullGlowMeterImg.gameObject.SetActive(value:  false);
        UnityEngine.Color val_5 = UnityEngine.Color.white;
        this.fullGlowMeterImg.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
        this.fullMeterImg.gameObject.SetActive(value:  val_2);
        this.brokenMeterImg.gameObject.SetActive(value:  isBroken);
        this.inkBlobImg.gameObject.SetActive(value:  false);
        UnityEngine.Color val_11 = UnityEngine.Color.white;
        this.inkBlobImg.color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
        this.inkBlobImg.transform.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        this.arrowImg.gameObject.SetActive(value:  val_2);
        UnityEngine.Color val_16 = UnityEngine.Color.red;
        this.arrowImg.color = new UnityEngine.Color() {r = val_16.r, g = val_16.g, b = val_16.b, a = val_16.a};
    }
    public DG.Tweening.Sequence PlayFullMeterAnim()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View_InkBar::<PlayFullMeterAnim>b__28_0()));
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.fullGlowMeterImg, endValue:  0.5f, duration:  0.3f), loops:  UnityEngine.Mathf.RoundToInt(f:  6.666667f), loopType:  0));
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOShakePosition(target:  this.transform, duration:  2f, strength:  6f, vibrato:  30, randomness:  90f, snapping:  false, fadeOut:  false));
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.arrowImg, endValue:  0f, duration:  2f));
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  1.4f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View_InkBar::<PlayFullMeterAnim>b__28_1()));
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View_InkBar::<PlayFullMeterAnim>b__28_2()));
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.inkBlobImg.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, duration:  0.3f)));
        DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View_InkBar::<PlayFullMeterAnim>b__28_3()));
        DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1.8f);
        DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View_InkBar::<PlayFullMeterAnim>b__28_4()));
        DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.inkBlobImg, endValue:  0f, duration:  0.8f));
        return val_1;
    }
    public View_InkBar()
    {
    
    }
    private void <PlayFullMeterAnim>b__28_0()
    {
        this.emptyMeterImg.gameObject.SetActive(value:  false);
        this.fullGlowMeterImg.gameObject.SetActive(value:  true);
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        this.fullGlowMeterImg.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
    }
    private void <PlayFullMeterAnim>b__28_1()
    {
        UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.largeBlobClip, volume:  1f);
    }
    private void <PlayFullMeterAnim>b__28_2()
    {
        int val_1 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.arrowImg, complete:  false);
        this.arrowImg.gameObject.SetActive(value:  false);
        this.inkBlobImg.gameObject.SetActive(value:  true);
    }
    private void <PlayFullMeterAnim>b__28_3()
    {
        this.fullGlowMeterImg.gameObject.SetActive(value:  false);
        this.fullMeterImg.gameObject.SetActive(value:  false);
        this.brokenMeterImg.gameObject.SetActive(value:  true);
        PlayerCharacterUIController.LoadFullyInkedAvatar();
        this.inkBlobFX.Play();
    }
    private void <PlayFullMeterAnim>b__28_4()
    {
        this.inkBlobFX.Stop();
    }

}
