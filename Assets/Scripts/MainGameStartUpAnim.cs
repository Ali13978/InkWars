using UnityEngine;
public class MainGameStartUpAnim : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject m_leftNameBackingStrip;
    private UnityEngine.GameObject m_rightNameBackingStrip;
    private MotionPanelsControler m_TimerBackingPanel;
    private UnityEngine.GameObject m_scorePanel;
    private MotionPanelsControler m_leftCharacter;
    private MotionPanelsControler m_rightCharacter;
    private MotionPanelsControler m_leftBattleEnhancer;
    private MotionPanelsControler m_rightBattleEnhancer;
    private MotionPanelsControler m_leftRankFlag;
    private MotionPanelsControler m_rightRankFlag;
    private MotionPanelsControler m_leftSwitcher;
    private MotionPanelsControler m_rightSwitcher;
    
    // Methods
    public void DoAnimation()
    {
        var val_31;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.m_TimerBackingPanel.MovetoEnd());
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScaleX(target:  this.m_leftNameBackingStrip.GetComponent<UnityEngine.RectTransform>(), endValue:  1f, duration:  0.75f));
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScaleX(target:  this.m_rightNameBackingStrip.GetComponent<UnityEngine.RectTransform>(), endValue:  -1f, duration:  0.75f));
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_scorePanel.GetComponent<UnityEngine.RectTransform>(), endValue:  1f, duration:  0.75f));
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.m_leftCharacter.MovetoEnd());
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.m_rightCharacter.MovetoEnd());
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.m_leftRankFlag.MovetoEnd());
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.m_rightRankFlag.MovetoEnd());
        DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.m_leftBattleEnhancer.MovetoEnd());
        DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.m_rightBattleEnhancer.MovetoEnd());
        DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.m_leftSwitcher.MovetoEnd());
        DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.m_rightSwitcher.MovetoEnd());
        val_31 = null;
        val_31 = null;
        this.m_scorePanel.gameObject.SetActive(value:  (Character_GlobalInfo.gameMode != 3) ? 1 : 0);
    }
    public MainGameStartUpAnim()
    {
    
    }

}
