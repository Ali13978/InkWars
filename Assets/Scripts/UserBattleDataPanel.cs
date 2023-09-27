using UnityEngine;
public class UserBattleDataPanel : MonoBehaviour
{
    // Fields
    public bool isLeft;
    public UnityEngine.UI.Text shellCountText;
    public UnityEngine.UI.Text winCountText;
    public UnityEngine.UI.Text loseCountText;
    public UnityEngine.UI.Text drawCountText;
    public UnityEngine.UI.Outline winTextOutLine;
    public UnityEngine.UI.Image shellOutline;
    public PostMatchPvPWinStarAnimationController winStarParticle;
    public UnityEngine.RectTransform winTextRoot;
    public UnityEngine.Color loseNumberColor;
    public UserBattleDataPanel.ScaleUpdateTextAnimSettings animSettings;
    public float duration;
    private InkWars.Model.GameResult <gameResult>k__BackingField;
    
    // Properties
    public InkWars.Model.GameResult gameResult { get; set; }
    
    // Methods
    public InkWars.Model.GameResult get_gameResult()
    {
        return (InkWars.Model.GameResult)this.<gameResult>k__BackingField;
    }
    public void set_gameResult(InkWars.Model.GameResult value)
    {
        this.<gameResult>k__BackingField = value;
    }
    public void SetData(int shell, long win, int lose, int draw)
    {
        string val_1 = PlayerPrefsManager.GetShellString(shells:  shell);
        string val_2 = win.ToString();
        string val_3 = lose.ToString();
        string val_4 = draw.ToString();
        if(this.drawCountText != null)
        {
                return;
        }
    
    }
    public void PlayDataUpdateAnimation()
    {
        object val_42;
        bool val_43;
        var val_44;
        DG.Tweening.Tweener val_45;
        IntPtr val_47;
        ScaleUpdateTextAnimSettings val_48;
        var val_49;
        var val_50;
        val_42 = this;
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        val_43 = (((this.<gameResult>k__BackingField) == 1) ? 1 : 0) | (((this.<gameResult>k__BackingField) == 4) ? 1 : 0);
        this.winTextOutLine.enabled = val_43;
        InkWars.Model.GameResult val_42 = this.<gameResult>k__BackingField;
        if(val_42 > 6)
        {
                return;
        }
        
        var val_41 = 1;
        val_41 = val_41 << val_42;
        if((val_41 & 18) != 0)
        {
            goto label_5;
        }
        
        val_41 = val_41 & 36;
        if(val_41 != 0)
        {
            goto label_6;
        }
        
        val_42 = 1 << val_42;
        val_42 = val_42 & 72;
        if(val_42 == 0)
        {
                return;
        }
        
        val_44 = null;
        val_44 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = DataStructs.UserDataDictionary.Stats.TotalPVPDraws;
        val_45 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOText(target:  this.drawCountText, endValue:  val_6.currentCryptoKey.ToString(), duration:  this.duration, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0), isIndependentUpdate:  true);
        val_47 = 1152921529071589024;
        goto label_11;
        label_5:
        DG.Tweening.Sequence val_10 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  val_10, isIndependentUpdate:  true);
        UnityEngine.Vector2 val_43 = this.animSettings.leftOffset;
        UnityEngine.Vector2 val_13 = this.winTextRoot.anchoredPosition;
        val_43 = val_43 * ((this.isLeft == true) ? 1f : -1f);
        UnityEngine.Vector2 val_14 = this.winTextRoot.anchoredPosition;
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y}, b:  new UnityEngine.Vector2() {x = val_43, y = V10.16B});
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.winTextRoot, endValue:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, duration:  this.animSettings.enlargeDuration, snapping:  false), ease:  this.animSettings.enlargeEase));
        val_48 = this.animSettings;
        if(this.animSettings != null)
        {
            goto label_21;
        }
        
        val_48 = this.animSettings;
        if(val_48 == null)
        {
            goto label_22;
        }
        
        label_21:
        DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_10, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.winTextRoot, endValue:  this.animSettings.textScale, duration:  this.animSettings.enlargeDuration), ease:  this.animSettings.enlargeEase), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void UserBattleDataPanel::<PlayDataUpdateAnimation>b__18_0())));
        val_49 = null;
        val_49 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_24 = DataStructs.UserDataDictionary.Stats.TotalPVPWins;
        DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.ShortcutExtensions46.DOText(target:  this.winCountText, endValue:  val_24.currentCryptoKey.ToString(), duration:  this.animSettings.updateTextDuration, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0));
        DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_10, interval:  this.animSettings.updatedTextDisplayDelay);
        DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.winTextRoot, endValue:  1f, duration:  this.animSettings.narrowDuration), ease:  this.animSettings.narrowEase));
        val_43 = this.animSettings;
        val_42 = DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.winTextRoot, endValue:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, duration:  this.animSettings.narrowDuration, snapping:  false);
        DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_10, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  val_42, ease:  this.animSettings.narrowEase));
        return;
        label_6:
        val_50 = null;
        val_50 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_35 = DataStructs.UserDataDictionary.Stats.TotalPVPLosses;
        val_45 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOText(target:  this.loseCountText, endValue:  val_35.currentCryptoKey.ToString(), duration:  this.duration, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0), isIndependentUpdate:  true);
        DG.Tweening.TweenCallback val_39 = null;
        val_47 = 1152921529071787680;
        label_11:
        val_43 = val_39;
        val_39 = new DG.Tweening.TweenCallback(object:  this, method:  val_47);
        DG.Tweening.Tweener val_40 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Tweener>(t:  val_45, action:  val_39);
        return;
        label_22:
    }
    public UserBattleDataPanel()
    {
        this.loseNumberColor = 0;
        mem[1152921529072171588] = 0;
        mem[1152921529072171596] = 0;
        this.animSettings = new UserBattleDataPanel.ScaleUpdateTextAnimSettings();
        this.duration = 0.8f;
    }
    private void <PlayDataUpdateAnimation>b__18_0()
    {
        UnityEngine.Vector3 val_2 = this.winTextRoot.transform.position;
        this.winStarParticle.PlayAnimation(worldPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.AudioSource val_4 = GameAudio.sound.PlayOneShot(clip:  this.animSettings.starSound, volume:  1f);
    }
    private void <PlayDataUpdateAnimation>b__18_1()
    {
        this.loseCountText.color = new UnityEngine.Color() {r = this.loseNumberColor, g = V9.16B, b = V10.16B, a = V11.16B};
    }
    private void <PlayDataUpdateAnimation>b__18_2()
    {
        this.drawCountText.color = new UnityEngine.Color() {r = this.loseNumberColor, g = V9.16B, b = V10.16B, a = V11.16B};
    }

}
