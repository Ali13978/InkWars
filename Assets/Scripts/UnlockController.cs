using UnityEngine;
public class UnlockController : InteractiveUIElement
{
    // Fields
    private UnlockableCollection m_Collection;
    private UnlockController.Data m_Data;
    private UnityEngine.AudioClip unlockSFX;
    
    // Methods
    protected override void Awake()
    {
        this.Awake();
        if(0 == this.m_Collection)
        {
                this.m_Collection = this.GetComponentInParent<UnlockableCollection>();
        }
        
        Variables val_3 = this.Options;
        val_3.AnimateFromStart = false;
    }
    protected override void Start()
    {
        this.Start();
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this.m_Data.RaysPanel, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  5f, mode:  3), ease:  1), loops:  0, loopType:  0), isIndependentUpdate:  true);
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_Data.RaysPanel, endValue:  1.15f, duration:  0.85f), ease:  10), loops:  0, loopType:  1), isIndependentUpdate:  true);
        DG.Tweening.Tweener val_14 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_Data.UnlockableImage.rectTransform, endValue:  1.25f, duration:  1f), delay:  0.25f), ease:  10), loops:  0, loopType:  1), isIndependentUpdate:  true);
        DG.Tweening.Tweener val_19 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_Data.Title.GetComponent<UnityEngine.RectTransform>(), endValue:  2f, duration:  1f), ease:  10), loops:  0, loopType:  1), isIndependentUpdate:  true);
    }
    public override void InitializeLocalVariables()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    public override void Hide()
    {
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  mem[53674008], endValue:  0f, duration:  0.15f), isIndependentUpdate:  true), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void UnlockController::<Hide>b__7_0()));
    }
    public override void Animate()
    {
        var val_12;
        this.InitializeSequence();
        UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.unlockSFX, volume:  1f);
        val_12 = this.unlockSFX;
        if(this.unlockSFX == null)
        {
                if(val_12 == null)
        {
            goto label_5;
        }
        
        }
        
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.unlockSFX, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  0, endValue:  1f, duration:  0.15f), ease:  27));
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.unlockSFX, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_Data.UnlockableText.rectTransform, endValue:  1f, duration:  0.15f), ease:  27));
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.unlockSFX, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void UnlockController::<Animate>b__8_0()));
        return;
        label_5:
    }
    public void ClosePanel()
    {
        goto typeof(UnlockController).__il2cppRuntimeField_1B8;
    }
    public void SetupAvatar(ProfileUnlockables_Avatar _avatar)
    {
        UnityEngine.UI.Image val_6;
        this.m_Data.AvatarTransparency.alpha = 1f;
        this.m_Data.TitleTransparency.alpha = 0f;
        val_6 = this.m_Data.UnlockableImage;
        val_6.sprite = _avatar.Sprite_Avatar;
        if((_avatar & 1) != 0)
        {
                string val_1 = LanguageManager.GetText(key:  "LK.UnlockMsg.NewCommonAvatar");
        }
        else
        {
                object[] val_2 = new object[2];
            val_6 = val_2;
            val_6[0] = CharacterHelper.GetLocalizedClanAndName(cid:  _avatar.Sprite_Avatar);
            val_6[1] = _avatar.SpecificKey.ToString(format:  "00");
        }
        
        this.m_Data.UnlockableText.text = LanguageManager.GetTextFormat(key:  "LK.UnlockMsg.SpecialAvatar", list:  val_2);
    }
    public void SetupTitle(ProfileUnlockables_Title _title)
    {
        CustomTitle val_6;
        this.m_Data.TitleTransparency.alpha = 1f;
        this.m_Data.AvatarTransparency.alpha = 0f;
        val_6 = this.m_Data.Title;
        val_6.Setup(title:  _title);
        if((_title & 1) != 0)
        {
                string val_1 = LanguageManager.GetText(key:  "LK.UnlockMsg.NewCommonTitle");
        }
        else
        {
                object[] val_2 = new object[2];
            val_6 = val_2;
            val_6[0] = CharacterHelper.GetLocalizedClanAndName(cid:  W22);
            val_6[1] = _title.SpecificKey.ToString(format:  "00");
        }
        
        this.m_Data.UnlockableText.text = LanguageManager.GetTextFormat(key:  "LK.UnlockMsg.SpecialTitle", list:  val_2);
    }
    public UnlockController()
    {
        this.m_Data = new UnlockController.Data();
    }
    private void <Hide>b__7_0()
    {
        this.m_Collection.ProcessUnlockables();
    }
    private void <Animate>b__8_0()
    {
        X19 + 24.interactable = true;
    }

}
